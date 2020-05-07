namespace CrmApp.Models
{
    public class BasketProducts
    {
        public int Id { get; set; }
        public Basket Basket { get; set; }
        public Product Product { get; set; }
    }
}