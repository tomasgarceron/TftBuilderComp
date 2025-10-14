namespace TftComp.Models
{
    public class Champion
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Cost { get; set; }
        public List<string> Traits { get; set; } = new();
        public List<int> RecommendedItems { get; set; } = new();
    }
}
