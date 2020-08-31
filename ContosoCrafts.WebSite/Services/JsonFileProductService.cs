using ContosoCrafts.WebSite.Models;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace ContosoCrafts.WebSite.Services
{
    // create Service retreive a list of our products (from our json file)
    public class JsonFileProductService
    {
        // Constructor
        public JsonFileProductService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }


        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            // getting namespace for data position in WebRoot of  WebhostEnvironment 
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "products.json"); }
        }


        // retrieving the json file as enumrable list 
        public IEnumerable<Product> GetProducts()
        {
            // using jsonFileReader lib to open up the Text file declared as JsonFileName Prop 
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                // using JsonSerializer to deserialized read the file arrays data into our Product Models shape
                return JsonSerializer.Deserialize<Product[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }

        public void AddRating(string productId, int rating)
        {
            var products = GetProducts();

            if (products.First(x => x.Id == productId).Ratings == null)
            {
                products.First(x => x.Id == productId).Ratings = new int[] { rating };
            }
            else
            {
                var ratings = products.First(x => x.Id == productId).Ratings.ToList();
                ratings.Add(rating);
                products.First(x => x.Id == productId).Ratings = ratings.ToArray();
            }

            using (var outputStream = File.OpenWrite(JsonFileName))
            {
                JsonSerializer.Serialize<IEnumerable<Product>>(
                    new Utf8JsonWriter(outputStream, new JsonWriterOptions
                    {
                        SkipValidation = true,
                        Indented = true
                    }),
                    products
                );
            }
        }


    }

}