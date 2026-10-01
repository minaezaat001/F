namespace WebApplication6.Models.Services
{
    public interface IproductServies
    {
        public List<Product> GetProducts();
        public Product GetById(int id);

        public void AddProduct(Product product);
        public void UpdateProduct(Product product);
        public void DeleteProduct(int id);

    }
}
