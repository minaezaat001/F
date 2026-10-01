namespace WebApplication6.Models.Services
{
    public class ProductServies : IproductServies
    {
        #region Fields
        public List<Product> Products { get; set; }
        #endregion

        #region Constructors
        public ProductServies()
        {
            Products = new List<Product>()
            {
                new Product(){Id=1,Name="Suger",Price=50 },
                 new Product(){Id=2,Name="Tea",Price=20 },
                  new Product(){Id=3,Name="Milk",Price=70 },
                   new Product(){Id=4,Name="Bnana",Price=100 },
            };
        }
        #endregion

        #region Functions Imlementation
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public Product GetById(int id)
        {
            var product = Products.FirstOrDefault(x => x.Id == id);
            return product;

        }
        public void DeleteProduct(int id)
        {
            var product = GetById(id);

            Products.Remove(product);
        }

        public List<Product> GetProducts()
        {
            return Products;
        }

        public void UpdateProduct(Product product)
        {
            var Pro = Products.FirstOrDefault(x => x.Id == product.Id);

            Pro.Name = product.Name;
            Pro.Price = product.Price;
        }
        #endregion

    }
}
