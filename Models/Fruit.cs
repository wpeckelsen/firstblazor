using System.Text.Json.Serialization;

namespace firstblazor.Models
{


    public class Fruit
    {

     [JsonPropertyName("name")]
        public string fruitName { get; set; }

        [JsonPropertyName("color")]
        public string fruitColor { get; set; }

        [JsonPropertyName("weight")]
        public int fruitWeight { get; set; }

        [JsonPropertyName("id")]
        public string fruitId { get; set; }

       public Fruit() { }


    }
}