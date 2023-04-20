namespace ASP_Restaurant.Models
{
    public class MenuPosition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        
        public IEnumerable<MenuNamePosition>menuNamePositions { get; set; }
    }
}
