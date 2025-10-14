namespace TftComp.Models
{
    public class SelectedChampion
    {
        public int Id { get; set; }
        public int ChanpionId { get; set; }
        public int Count { get; set; }

        public int Stars { get; set; } = 1;
    }
}
