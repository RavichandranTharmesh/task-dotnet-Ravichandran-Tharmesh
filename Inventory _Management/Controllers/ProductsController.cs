using Inventory_Management.Models;
using InventoryManagement.Services;
using Microsoft.AspNetCore.Mvc;

namespace Inventory_Management.Controllers
{
    public class ProductController : Controller
    {
        private readonly DataService ds = new DataService();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            ViewBag.Id = id;
            return View();
        }


        //show product 
        [HttpGet("/api/products")]
        public IActionResult GetAll()
        {
            var data = ds.ReadData();
            return Ok(data.Products);
        }

        [HttpGet("/api/products/{id}")]
        public IActionResult Get(int id)
        {
            var data = ds.ReadData();
            var p = data.Products.FirstOrDefault(x => x.Id == id);
            if (p == null) return NotFound();
            return Ok(p);
        }
        //add product
        [HttpPost("/api/products")]
        public IActionResult AddProduct([FromBody] Product product)
        {
            if (product == null) return BadRequest();

            var data = ds.ReadData();
            product.Id = data.Products.Count > 0 ? data.Products.Max(p => p.Id) + 1 : 1;
            product.CategoryName = data.Categories.FirstOrDefault(c => c.Id == product.CategoryId)?.Name ?? "";

            data.Products.Add(product);
            ds.WriteData(data);
            return Ok(product);
        }


        //update product
        [HttpPut("/api/products/{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] Product updated)
        {
            if (updated == null) return BadRequest();

            var data = ds.ReadData();
            var existing = data.Products.FirstOrDefault(p => p.Id == id);
            if (existing == null) return NotFound();

            existing.ProductName = updated.ProductName;
            existing.ProductCode = updated.ProductCode;
            existing.Price = updated.Price;
            existing.StockQuantity = updated.StockQuantity;
            existing.IsActive = updated.IsActive;
            existing.CategoryId = updated.CategoryId;
            existing.CategoryName = data.Categories.FirstOrDefault(c => c.Id == updated.CategoryId)?.Name ?? "";

            ds.WriteData(data);
            return Ok(existing);
        }

        //delete product
        [HttpDelete("/api/products/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var data = ds.ReadData();
            var removed = data.Products.RemoveAll(p => p.Id == id) > 0;
            if (!removed) return NotFound();
            ds.WriteData(data);
            return Ok();
        }
    }
}
