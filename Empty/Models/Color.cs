namespace Empty.Models
{
    public class Color
    {
        public int Id { get; set; }
        public string Name { get; set; }
        ICollection<Product> Products { get; set; }
    }
}
