using System.Text.Json;
using System.Text.Json.Serialization;

namespace ContosoCrafts.WebSite.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Maker { get; set; }

        // map "img" to Models Property Image
        [JsonPropertyName("img")]
        public string Image { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int[] Ratings { get; set; }

        // override (cast) default json data to a basic String
        // Serialize represents the kind of how the json data will be casted (one after the other )
        // <Product> represents (this) Model
        public override string ToString() => JsonSerializer.Serialize<Product>(this);


    }
}