using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp
{
    public class ProductPosted
    {
        public string IntegrationId { get; set; }
        public string BaseProductCode { get; set; }
        public string ColorVariantCode { get; set; }
        public string StockAmount { get; set; }
        public string Ean { get; set; }
        public string TaxRate { get; set; }
        public string Size { get; set; }
        public string Title { get; set; }
        public string Headline { get; set; }
        public string Description { get; set; }
        public string MainCategory { get; set; }
        public string FirstSellingVat { get; set; }
        public string LastSellingVat { get; set; }
        public string Color { get; set; }
        public string Image1Link { get; set; }
        public string Image2Link { get; set; }
        public string Image3Link { get; set; }
        public string Image4Link { get; set; }
        public string Image5Link { get; set; }
        public string WebCategory { get; set; }
        public string Store { get; set; }
        public string IsDeleted { get; set; }
        public string IsUnpublished { get; set; }
        public string Variant3 { get; set; }
        public string Variant4 { get; set; }
        public string Filter3 { get; set; }
        public string Filter4 { get; set; }
        public string Filter5 { get; set; }
        public string Filter6 { get; set; }

        public ProductPosted(string ıntegrationId, string baseProductCode, string colorVariantCode, string stockAmount, string ean, string taxRate, string size, string title, string headline, string description, string mainCategory, string firstSellingVat, string lastSellingVat, string color, string ımage1Link, string ımage2Link, string ımage3Link, string ımage4Link, string ımage5Link, string webCategory, string store, string ısDeleted, string ısUnpublished, string variant3, string variant4, string filter3, string filter4, string filter5, string filter6)
        {
            IntegrationId = ıntegrationId;
            BaseProductCode = baseProductCode;
            ColorVariantCode = colorVariantCode;
            StockAmount = stockAmount;
            Ean = ean;
            TaxRate = taxRate;
            Size = size;
            Title = title;
            Headline = headline;
            Description = description;
            MainCategory = mainCategory;
            FirstSellingVat = firstSellingVat;
            LastSellingVat = lastSellingVat;
            Color = color;
            Image1Link = ımage1Link;
            Image2Link = ımage2Link;
            Image3Link = ımage3Link;
            Image4Link = ımage4Link;
            Image5Link = ımage5Link;
            WebCategory = webCategory;
            Store = store;
            IsDeleted = ısDeleted;
            IsUnpublished = ısUnpublished;
            Variant3 = variant3;
            Variant4 = variant4;
            Filter3 = filter3;
            Filter4 = filter4;
            Filter5 = filter5;
            Filter6 = filter6;
        }
        //string ıntegrationId, string baseProductCode, string colorVariantCode, string stockAmount, string ean, string taxRate, string size, string title, string headline, string description, string mainCategory, string firstSellingVat, string lastSellingVat, string color, string ımage1Link, string ımage2Link, string ımage3Link, string ımage4Link, string ımage5Link, string webCategory, string store, string ısDeleted, string ısUnpublished, string variant3, string variant4, string filter3, string filter4, string filter5, string filter6

    }


    class Product
    {
        public string id;
        public string cloudId;
        public string productName;
        public string listPrice;
        public string headline;
        public string gtin;
        public bool inStock;
        public List<Variants> variants; //variant object
        public List<Filter> filters; //filter object
        public Picture picture;
        public List<Picture> pictures; //picture object
        public string productDetailUrl;
        public List<User> reviews;
        public string quantity;
        public string sku;
        public string description;
        public string strikeOutPrice;
        public string point; 
        public Category category; //category object
        public string ProductUrl;

        public Product(string id, string cloudId, string productName, string listPrice, string headline, string gtin, bool inStock, List<Variants> variants, List<Filter> filters, Picture picture, List<Picture> pictures, string productDetailUrl, List<User> reviews, string quantity, string sku, string description, string strikeOutPrice, string point, Category category, string productUrl)
        {
            this.id = id;
            this.cloudId = cloudId;
            this.productName = productName;
            this.listPrice = listPrice;
            this.headline = headline;
            this.gtin = gtin;
            this.inStock = inStock;
            this.variants = variants;
            this.filters = filters;
            this.picture = picture;
            this.pictures = pictures;
            this.productDetailUrl = productDetailUrl;
            this.reviews = reviews;
            this.quantity = quantity;
            this.sku = sku;
            this.description = description;
            this.strikeOutPrice = strikeOutPrice;
            this.point = point;
            this.category = category;
            ProductUrl = productUrl;
        }

        public Product()
        {
        }

       
    }

    class User
    {
        public string id;
        public string userName;
        public string title;
        public string review;
        public string reviewDate;
        public string point;

        public User(string id, string userName, string title, string review, string reviewDate, string point)
        {
            this.id = id;
            this.userName = userName;
            this.title = title;
            this.review = review;
            this.reviewDate = reviewDate;
            this.point = point;
        }
    }

    class Variants
    {
        public string order;
        public string cloudId;
        public string groupName;
        public string groupId;
        public List<VariantObjectAPI> features;
        public VariantObjectAPI selected;
    }

    class VariantObjectAPI
    {
        public string displayName;
        public string cloudId;
        public string value;
        public string productId;
        public bool isInStock;
        public string gtin;
        public string order;
        public Picture picture;

        public VariantObjectAPI()
        {
        }

        public VariantObjectAPI(string displayName, string cloudId, string value, string productId, bool isInStock, string gtin, string order, Picture picture) : this(displayName, cloudId, value, productId, isInStock, gtin, order)
        {
            this.picture = picture;
        }

        public VariantObjectAPI(string displayName, string cloudId, string value, string productId, bool isInStock, string gtin, string order)
        {
            this.displayName = displayName;
            this.cloudId = cloudId;
            this.value = value;
            this.productId = productId;
            this.isInStock = isInStock;
            this.gtin = gtin;
            this.order = order;
        }
    }

    class Filter
    {
        public string filterItemId;
        public Filter(string filterItemId)
        {
            this.filterItemId = filterItemId;
        }
    }

    class Picture
    {
        public string url;
        public string order;

        public Picture(string url, string order) : this(url)
        {
            this.order = order;
        }

        public Picture(string url)
        {
            this.url = url;
        }

        public Picture()
        {
        }
    }

    class Category
    {
        public string id;
        public string name;
        public bool isRoot;
        public string parentCategoryId;
        public string description;
        public string order;
        public string IncludeInTopMenu;
        public Category(string id, string name, bool isRoot, string parentCategoryId, string description, string order, string ıncludeInTopMenu)
        {
            this.id = id;
            this.name = name;
            this.isRoot = isRoot;
            this.parentCategoryId = parentCategoryId;
            this.description = description;
            this.order = order;
            IncludeInTopMenu = ıncludeInTopMenu;
        }
    }

    class ProductsList
    {
        private List<ProductPosted> _ProductList;

        public List<ProductPosted> ProductList { get => _ProductList; set => _ProductList = value; }
    }

    class Program
    {
        static HttpClient client = new HttpClient();

        static void Main()
        {
            RunAsync().GetAwaiter().GetResult();
        }

        static async Task RunAsync()
        {
            var url = client.BaseAddress = new Uri("https://dev.shopiconnect.com/api/product/123");
            //var url = client.BaseAddress = new Uri("https://dev.shopiconnect.com/api/product/1523");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                var responseMessage = await client.GetAsync(url);
                if (responseMessage.IsSuccessStatusCode)
                {
                    var jsonString = await responseMessage.Content.ReadAsStringAsync();
                    var newObject = JsonConvert.DeserializeObject<Product>(jsonString);
                    var newObject2 = JsonConvert.DeserializeObject<object>(jsonString);
                    //Console.WriteLine(newObject2);
                    string new_baseProductCode = newObject.id;
                    string new_colorVariantCode = "";
                    for (int i = 0; i < newObject.id.Length; i++)
                    {
                        if (i < 5) continue;
                        new_colorVariantCode += newObject.id[i];
                    }
                    string new_id = "";
                    string new_color = "";
                    string new_sku = newObject.sku;
                    string new_ean = "0";
                    string new_taxRate = "0";
                    string new_size = "";
                    string new_title = newObject.productName;
                    string new_headline = newObject.headline;
                    string new_description = newObject.description;
                    string new_mainCategory = newObject.category.name;
                    string new_firstSell = newObject.strikeOutPrice;
                    string new_lastSell = newObject.listPrice;
                    string new_stockAmount = newObject.quantity;
                    string new_variant3 = "";
;                   string new_variant4 = "";
;                   string new_filter3 = "None";
;                   string new_filter4 = "None";
;                   string new_filter5 = "None";
;                   string new_filter6 = "None";
;                   string new_image_link1 = "None";
;                   string new_image_link2 = "None";
;                   string new_image_link3 = "None";
;                   string new_image_link4 = "None";
;                   string new_image_link5 = "None";
;                   string new_webCategory = "None";
;                   string new_store = "None";
;                   string new_isDeleted = "None";
;                   string new_isUnpublish = "None";
                    List<string> new_variants = new List<string>();
                    for(int i = 0; i < newObject.variants.Count(); i++)
                    {
                        if (newObject.variants[i].groupName == "Color")
                        {
                            for(int j = 0; j < newObject.variants[i].features.Count(); j++)
                            {
                                new_variants.Add(newObject.variants[i].features[j].cloudId);
                            }
                            new_color = newObject.variants[i].selected.displayName;
                            new_variant3 = newObject.variants[i].groupName;
                        }
                        if (newObject.variants[i].groupName == "Size")
                        {
                            new_id = newObject.variants[i].selected.productId;
                            new_variant4 = newObject.variants[i].groupName;
                            new_size = newObject.variants[i].selected.displayName;
                        }
                    }
                    for(int j = 0; j < newObject.filters.Count(); j++)
                    {
                        switch (j)
                        {
                            case 0:
                                new_filter3 = newObject.filters[j].filterItemId;
                                break;
                            case 1:
                                new_filter4 = newObject.filters[j].filterItemId;
                                break;
                            case 2:
                                new_filter5 = newObject.filters[j].filterItemId;
                                break;
                            case 3:
                                new_filter6 = newObject.filters[j].filterItemId;
                                break;
                            default:
                                break;
                        }      
                    }
                    for(int k = 0; k < newObject.pictures.Count();k++)
                    {
                        switch (k)
                        {
                            case 0:
                                new_image_link1 = newObject.pictures[k].url;
                                break;
                            case 1:
                                new_image_link2 = newObject.pictures[k].url;
                                break;
                            case 2:
                                new_image_link3 = newObject.pictures[k].url;
                                break;
                            case 3:
                                new_image_link4 = newObject.pictures[k].url;
                                break;
                            case 4:
                                new_image_link5 = newObject.pictures[k].url;
                                break;
                            default:
                                break;
                        }
                    }
                    //Console.WriteLine("Integration Id:" + new_id);
                    //Console.WriteLine("BaseProductCode:" + new_baseProductCode);
                    //Console.WriteLine("ColorVariantCode:" + new_colorVariantCode);
                    //Console.WriteLine("Sku:" + new_sku);
                    //Console.WriteLine("Ean:" + new_ean);
                    //Console.WriteLine("TaxRate:" + new_taxRate);
                    //Console.WriteLine("StockAmount:" + new_stockAmount);
                    //Console.WriteLine("Size:" + new_size);
                    //Console.WriteLine("Title:" + new_title);
                    //Console.WriteLine("Headline:" + new_headline);
                    //Console.WriteLine("Description:" + new_description);
                    //Console.WriteLine("MainCategory:" + new_mainCategory);
                    //Console.WriteLine("FirstSellingVat:" + new_firstSell);
                    //Console.WriteLine("LastSellingVat:" + new_lastSell);
                    //Console.WriteLine("Color:" + new_color);
                    //Console.WriteLine("Image1Link:" + new_image_link1);
                    //Console.WriteLine("Image2Link:" + new_image_link2);
                    //Console.WriteLine("Image3Link:" + new_image_link3);
                    //Console.WriteLine("Image4Link:" + new_image_link4);
                    //Console.WriteLine("Image5Link:" + new_image_link5);
                    //Console.WriteLine("Variant3:" + new_variant3);
                    //Console.WriteLine("Variant4:" + new_variant4);
                    //Console.WriteLine("Filter3:" + new_filter3);
                    //Console.WriteLine("Filter4:" + new_filter4);
                    //Console.WriteLine("Filter5:" + new_filter5);
                    //Console.WriteLine("Filter6:" + new_filter6);
              

                    ProductsList productList = new ProductsList();
                    ProductPosted new_product = new ProductPosted(new_id,new_baseProductCode,new_colorVariantCode,new_stockAmount,new_ean,new_taxRate,new_size,new_title,new_headline,new_description,new_mainCategory,new_firstSell,new_lastSell,new_color,new_image_link1,new_image_link2,new_image_link3,new_image_link4,new_image_link5,new_webCategory,new_store,new_isDeleted,new_isUnpublish,new_variant3,new_variant4,new_filter3,new_filter4,new_filter5,new_filter6);

                    List<ProductPosted> newList = new List<ProductPosted>();
                    newList.Add(new_product);
                    productList.ProductList = newList;
                    string jsonString2 = JsonConvert.SerializeObject(productList);
                    Console.WriteLine(jsonString2);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var responsePost = await client.PostAsJsonAsync("https://dev.shopiconnect.com/api/productImport/ImportDeltaProducts", jsonString2);
                    Console.WriteLine(responsePost);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}