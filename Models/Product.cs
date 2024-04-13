namespace SanPhamChauPhu.Models
{
    public class Product
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public string Code { get; set; }
        public string Slug { get; set; }
        public string Name { get; set; }
        public string Introduce { get; set; }
        public string Content { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public float? Discount { get; set; }
        public DateTime? PromotionEnd { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int ViewCount { get; set; }
        public bool IsVisible { get; set; }
    }
}
