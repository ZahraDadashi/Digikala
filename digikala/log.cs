using static System.Console;
using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;

public class log
{
    public void WriteToLogFile(String s)
    {
        try
        {
            string logFile = Combine(CurrentDirectory, "log.txt");
            if (!File.Exists(logFile))
            {
                File.Create(logFile).Dispose();
            }
            using (StreamWriter logg = File.AppendText(logFile))
            {
                logg.WriteLine(s);
                logg.Close();
            }

        }
        catch (Exception e)
        {
            e.ToString();
        }

    }

    public void ProductsToFile(String s)
    {
        try
        {
            string productsFile = Combine(CurrentDirectory, "products.txt");
            if (!File.Exists(productsFile))
            {
                File.Create(productsFile).Dispose();
            }
            using (StreamWriter logg = File.AppendText(productsFile))
            {
                logg.WriteLine(s);
                logg.Close();
            }

        }
        catch (Exception e)
        {
            e.ToString();
        }

    }

}
