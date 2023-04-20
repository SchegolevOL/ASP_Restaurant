namespace ASP_Restaurant.Models
{
    public class MenuNamePosition
    {
        public int Id { get; set; }
        public int MenuPositionId { get; set; }
        public MenuPosition menuPosition { get; set; }
        public int MenuNameId { get; set; }
        public MenuName menuName { get; set; }

    }
}
