namespace WebApplication1.DTOs
{
    public class ProductDetailsFileMaster
    {
        public string ProductName { get; set; }

        public string Price { get; set; }

        public string StockQuantity { get; set; }

       
    }
    public class ProductFileMaster
    {
        public IFormFile Filename { get; set; }
    }
}
