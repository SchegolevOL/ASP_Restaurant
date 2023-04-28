namespace ASP_Restaurant.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
