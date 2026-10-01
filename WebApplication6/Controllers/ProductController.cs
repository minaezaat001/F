using Microsoft.AspNetCore.Mvc;
using WebApplication6.Models;
using WebApplication6.Models.Services;

namespace WebApplication6.Controllers
{
    public class ProductController : Controller
    {
        private IproductServies _productServies;

        public ProductController(IproductServies productServies)
        {
            this._productServies = productServies;
        }

        public IActionResult Index()
        {
            var products = _productServies.GetProducts();
            return View(products);
        }

        //Product/Details/1 
        public IActionResult Details(int id) 
        {
            var product = _productServies.GetById(id);
                     
            return View(product);   
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Product product)
        {
         
           _productServies.AddProduct(product);

            return RedirectToAction("Index");

        }


        public IActionResult Edit(int id) 
        {
            var product = _productServies.GetById(id);

            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product) 
        {
           _productServies.UpdateProduct(product);

            return RedirectToAction("Index");
        }




        public IActionResult Delete(int id) 
        {
            var product = _productServies.GetById(id);

            return View(product);
        }

        [HttpPost]

        public IActionResult Delete(Product product)
        {
            _productServies.DeleteProduct(product.Id);

            return RedirectToAction("Index");
        }
    }
}
