using System.ComponentModel.DataAnnotations; // [Required], [StringLength]
using System.ComponentModel.DataAnnotations.Schema; // [Column]
using Newtonsoft.Json;


/*public class DeserializedClass
{    
        [JsonProperty("productlist")]
        public List<Root>? productlist { get; set; }
        //public int count{get;set;}
}*/

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Advertisement
    {
        public List<object> sponsored_brands { get; set; }
    }

    public class Attributes
    {
        public string type { get; set; }
        public string title { get; set; }
        public List<Option> options { get; set; }
    }

    public class Brand
    {
        public int id { get; set; }
        public string code { get; set; }
        public string title_fa { get; set; }
        public string title_en { get; set; }
        public Url url { get; set; }
        public bool visibility { get; set; }
        public Logo logo { get; set; }
        public bool is_premium { get; set; }
        public bool is_miscellaneous { get; set; }
        public bool is_name_similar { get; set; }
        public string description { get; set; }
    }

    public class Breadcrumb
    {
        public string title { get; set; }
        public Url url { get; set; }
    }

    public class Category
    {
        public int id { get; set; }
        public string title_fa { get; set; }
        public string title_en { get; set; }
        public string code { get; set; }
        public string description_fa { get; set; }
        public object description_en { get; set; }
    }

    public class CategoryBrand
    {
        public string description { get; set; }
    }

    public class Color
    {
        public int id { get; set; }
        public string title { get; set; }
        public string hex_code { get; set; }
        public string type { get; set; }
        public List<Option> options { get; set; }
    }

    public class Data
    {
        public Filters filters { get; set; }
        public List<Product> products { get; set; }
        public Sort sort { get; set; }
        public List<SortOption> sort_options { get; set; }
        public List<object> did_you_mean { get; set; }
        public List<object> related_search_words { get; set; }
        public string? result_type { get; set; }
        public Pager pager { get; set; }
        public int search_phase { get; set; }
        public List<object> search_instead { get; set; }
        public Intrack intrack { get; set; }
        public Seo seo { get; set; }
        public Advertisement advertisement { get; set; }
        public Brand brand { get; set; }
        public Category category { get; set; }
        public List<Breadcrumb> breadcrumb { get; set; }
        public CategoryBrand category_brand { get; set; }
    }

    public class DataLayer
    {
        public string brand { get; set; }
        public string category { get; set; }
        public int metric6 { get; set; }
        public int dimension2 { get; set; }
        public int dimension6 { get; set; }
        public string dimension7 { get; set; }
        public double dimension9 { get; set; }
        public int dimension11 { get; set; }
        public string dimension20 { get; set; }
    }

    public class Digiplus
    {

        public string title { get; set; }
        public string icon { get; set; }
        public List<Option> options { get; set; }
        public List<string> services { get; set; }
        public bool is_jet_eligible { get; set; }
        public int cash_back { get; set; }
        public bool is_general_location_jet_eligible { get; set; }
    }

    public class EventData
    {
        public string name { get; set; }
        public int level { get; set; }
        public string url { get; set; }
        public string categoryLevel1 { get; set; }
        public string categoryLevel2 { get; set; }
        public string categoryLevel3 { get; set; }
        public string categoryLevel4 { get; set; }
        public string categoryLevel5 { get; set; }
    }

    public class Filters
    {
        public Color colors { get; set; }
        public Digiplus digiplus { get; set; }
        public HasShipBySeller has_ship_by_seller { get; set; }
        public Price price { get; set; }
        public HasSellingStock has_selling_stock { get; set; }
        public HasReadyToShipment has_ready_to_shipment { get; set; }
        public SellerTypes seller_types { get; set; }
        public Types types { get; set; }
        public Attributes attributes { get; set; }
    }

    public class HasReadyToShipment
    {
        public string type { get; set; }
        public string title { get; set; }
        public List<Option> options { get; set; }
    }

    public class HasSellingStock
    {
        public string type { get; set; }
        public string title { get; set; }
        public List<Option> options { get; set; }
    }

    public class HasShipBySeller
    {
        public string type { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
        public List<Option> options { get; set; }
    }

    public class Header
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class Images
    {
        public Main main { get; set; }
    }

    public class Intrack
    {
        public string eventName { get; set; }
        public EventData eventData { get; set; }
        public object userId { get; set; }
    }

    public class ItemListElement
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public int position { get; set; }
        public string name { get; set; }
        public object item { get; set; }
    }

    public class Logo
    {
        public List<object> storage_ids { get; set; }
        public List<string> url { get; set; }
        public object thumbnail_url { get; set; }
        public object temporary_id { get; set; }
    }

    public class Main
    {
        public List<object> storage_ids { get; set; }
        public List<string> url { get; set; }
        public object thumbnail_url { get; set; }
        public object temporary_id { get; set; }
    }

    public class MarkupSchema
    {
        [JsonProperty("@context")]
        public string Context { get; set; }

        [JsonProperty("@type")]
        public string Type { get; set; }
        public List<ItemListElement> itemListElement { get; set; }
    }

    public class OpenGraph
    {
        public string title { get; set; }
        public string description { get; set; }
        public string image { get; set; }
    }

    public class Option
    {
        public string id { get; set; }
        public string title { get; set; }
        public string hex_code { get; set; }
        public string type { get; set; }
        public string icon { get; set; }
        public List<Option> options { get; set; }
        public string title_fa { get; set; }
        public string title_en { get; set; }
        public int min { get; set; }
        public int max { get; set; }
    }

    public class Pager
    {
        public int current_page { get; set; }
        public int total_pages { get; set; }
        public int total_items { get; set; }
    }

    public class PindoAdvertisement
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class Price
    {
        public string type { get; set; }
        public string title { get; set; }
        public Option options { get; set; }
    }

    public class Product
    {
        public int id { get; set; }
        public string title_fa { get; set; }
        public string title_en { get; set; }
        public Url url { get; set; }
        public string status { get; set; }
        public bool has_quick_view { get; set; }
        public Digiplus digiplus { get; set; }
        public DataLayer data_layer { get; set; }
        public Images images { get; set; }
        public Rating rating { get; set; }
        public object default_variant { get; set; }
        public Properties properties { get; set; }
        public List<object> badges { get; set; }
        public List<Color> colors { get; set; }
        public PindoAdvertisement pindo_advertisement { get; set; }
    }

    public class Properties
    {
        public bool is_fast_shipping { get; set; }
        public bool is_ship_by_seller { get; set; }
        public bool free_shipping_badge { get; set; }
        public bool is_multi_warehouse { get; set; }
        public bool is_fake { get; set; }
        public bool has_gift { get; set; }
        public int min_price_in_last_month { get; set; }
        public bool is_non_inventory { get; set; }
        public bool is_ad { get; set; }
        public bool is_jet_eligible { get; set; }
        public bool is_medical_supplement { get; set; }
    }

    public class Rating
    {
        public int rate { get; set; }
        public int count { get; set; }
    }

    public class Root
    {
        public int status { get; set; }
        public Data data { get; set; }
    }

    public class SellerTypes
    {
        public string type { get; set; }
        public string title { get; set; }
        public List<Option> options { get; set; }
    }

    public class Seo
    {
        public string title { get; set; }
        public string description { get; set; }
        public string content { get; set; }
        public TwitterCard twitter_card { get; set; }
        public OpenGraph open_graph { get; set; }
        public Header header { get; set; }
        public List<MarkupSchema> markup_schema { get; set; }
    }

    public class Sort
    {
        public int @default { get; set; }
    }

    public class SortOption
    {
        public int id { get; set; }
        public string title_fa { get; set; }
    }

    public class TwitterCard
    {
        public string title { get; set; }
        public string description { get; set; }
        public string image { get; set; }
    }

    public class Types
    {
        public string type { get; set; }
        public string title { get; set; }
        public List<Option> options { get; set; }
    }

    public class Url
    {
        public object @base { get; set; }
        public string uri { get; set; }
    }

