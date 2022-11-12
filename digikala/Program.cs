using static System.Console;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using RestSharp;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore; // Include extension method
using digiDB;
using System.Diagnostics;
using System.Threading;

public class Program
{
    public static void Main()
    {
        using (digikalaDB db = new())
        {
            Stopwatch timer = new();
            timer.Start();
            //digikaladg(1, 100);
            Thread t1 = new Thread(() => digikaladg(1, 25));
            t1.Start();
            Thread t2 = new Thread(() => digikaladg(26, 50));
            t2.Start();
            Thread t3 = new Thread(() => digikaladg(51, 75));
            t3.Start();
            Thread t4 = new Thread(() => digikaladg(76, 100));
            t4.Start();
            timer.Stop();
            log ob = new log();
            ob.WriteToLogFile("Time ellapsed: " + timer.ElapsedMilliseconds + " milliseconds");
            WriteLine("{0:N0} milliseconds ellapsed.", timer.ElapsedMilliseconds);

            void digikaladg(int a, int b)
            {
                var url = "https://api.digikala.com/v1/categories/mobile-phone/search/?sort=7";
                int startPage = a;
                int endPage = b;
                var productslist = new List<Product>();
                do
                {
                    var nextUrl = $"{url}&page={startPage}";
                    var client = new RestClient($"{nextUrl}");
                    client.Timeout = -1;
                    var request = new RestRequest(Method.GET);
                    //request.AddHeader("Cookie", "TS01e4b47a=01023105914a1c22fe9d5e6af320427ac2d64a6e6678346f142d0fe7875248f0021a59ad17ac0acd5f189ba17cb78a0fe6559f8191f874b8c122f398428f5dad9f5d4938c514343696c5ef68777d130b1f0a127408; tracker_glob_new=dKHCjXP; tracker_session=8uozxjC");
                    IRestResponse response = client.Execute(request);
                    string json = response.Content;
                    var settings = new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        MissingMemberHandling = MissingMemberHandling.Ignore
                    };
                    var myDeserializedClass = JsonConvert.DeserializeObject<Root>(json, settings);
                    int count = myDeserializedClass.data.products.Count;
                    for (int i = 0; i < count; i++)
                    {
                        var pr = new Product
                        {
                            id = myDeserializedClass.data.products[i].id,
                            title_fa = myDeserializedClass.data.products[i].title_fa,
                            title_en = myDeserializedClass.data.products[i].title_en,
                            status = myDeserializedClass.data.products[i].status,
                            url = myDeserializedClass.data.products[i].url,
                            has_quick_view = myDeserializedClass.data.products[i].has_quick_view,
                            digiplus = myDeserializedClass.data.products[i].digiplus,
                            data_layer = myDeserializedClass.data.products[i].data_layer,
                            images = myDeserializedClass.data.products[i].images,
                            colors = myDeserializedClass.data.products[i].colors
                        };
                        //productslist.Add(pr);
                        log ob = new log();
                        ob.ProductsToFile($"Id:{pr.id}, title_fa: {pr.title_fa}, title_en: {pr.title_en}, status: {pr.status}, url: {pr.url}");
                        ob.ProductsToFile($",has_quick_view: {pr.has_quick_view}, digiplus: {pr.digiplus}, data_layer: {pr.data_layer}, images: {pr.images}, colors: {pr.colors}");
                    }

                    // for (int i = 1; i < count; i++)
                    // {
                    //     var pr = new ProductDb
                    //     {
                    //         ProductId = myDeserializedClass.data.products[i].id,
                    //         TitleFa = myDeserializedClass.data.products[i].title_fa,
                    //         TitleEn = myDeserializedClass.data.products[i].title_en,
                    //         DatalayerBrand = myDeserializedClass.data.products[i].data_layer.brand,
                    //         UrlAdd = myDeserializedClass.data.products[i].url.uri,
                    //         DigiplusTitle = myDeserializedClass.data.products[i].digiplus.title,
                    //         Status = myDeserializedClass.data.products[i].status,
                    //         DescriptionFa = myDeserializedClass.data.category.description_fa,
                    //         Image = myDeserializedClass.data.products[i].images.main.url[0],
                    //         Color = myDeserializedClass.data.products[i].colors.FirstOrDefault()?.title
                    //     };
                    //     db.Add(pr);
                    //     db.SaveChanges();
                    //     OutputThreadInfo();
                    // }
                    startPage++;
                    nextUrl = $"{url}&page={startPage}";

                } while (startPage < endPage);
            }
            static void OutputThreadInfo()
            {
                Thread t = Thread.CurrentThread;
                WriteLine(
                "Thread Id: {0}, Priority: {1}, Background: {2}, Name: {3}",
                t.ManagedThreadId, t.Priority,
                t.IsBackground, t.Name ?? "null");
            }
        }
    }
}