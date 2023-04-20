namespace ASP_Restaurant.Models
{
    public class CardMenu
    {
        

        public List<MenuPosition> BreakFast { get; set; }
        public List<MenuPosition> Lanch { get; set; }
        public List<MenuPosition> Dinner { get; set; }

        public CardMenu()
        {
            BreakFast = new List<MenuPosition>();
            Lanch = new List<MenuPosition>();
            Dinner = new List<MenuPosition>();
        }
    }
}
