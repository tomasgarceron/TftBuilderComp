using System.Text.Json.Serialization;

namespace TftComp.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Icon { get; set; } = "";
        [JsonPropertyName("weight")]

        public double Weight { get; set; } = 1.0;
        
        [JsonPropertyName("maxEffective")]
        public int MaxEffective { get; set; } = 99;
        public List<string> Recipe { get; set; }
    }
}
