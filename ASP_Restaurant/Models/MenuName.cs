namespace ASP_Restaurant.Models
{
    public class MenuName
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<MenuNamePosition>menuNamePositions { get; set; }
    }
}
