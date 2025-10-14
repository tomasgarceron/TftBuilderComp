namespace TftComp.Models
{
    public class Composition
    {
        public string Name { get; set; } = "";
        public List<int> Champions { get; set; } = new(); // todos los campeones de la compo
        public List<CoreChampion> CoreChampions { get; set; } = new(); // campeones core
        public List<CompTrait> RequiredTraits { get; set; } = new();
        public List<CoreItem> CoreItems { get; set; } = new();
        public List<CoreItem> RecommendedItems { get; set; } = new();
        public string Tier { get; set; } = "C";
    }

    public class CoreChampion
    {
        public int Id { get; set; }
        public double Weight { get; set; } = 2; // si no lo seteás, tomamos 2 por defecto
    }

    public class CompTrait
    {
        public string Name { get; set; } = "";
        public int MinUnits { get; set; }
        public double Weight { get; set; }
    }

    public class CoreItem
    {
        public int Id { get; set; }
        public double Weight { get; set; }
        public int MaxEffective { get; set; } = 3;
    }
}
