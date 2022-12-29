namespace Empty.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public int CategoryId { get; set; }
        public Category Categories { get; set; }
        public int SizeId { get; set; }
        public Size Sizes { get; set; }
        public int ColorId { get; set; }
        public Color Colors { get; set; }
    }
}
