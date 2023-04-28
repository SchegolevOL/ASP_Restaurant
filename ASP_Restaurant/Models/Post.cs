namespace ASP_Restaurant.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool MasterChef { get; set; }

        public int PersonId { get; set; }

        public IEnumerable <Person> Persons { get; set; }
    }
}
