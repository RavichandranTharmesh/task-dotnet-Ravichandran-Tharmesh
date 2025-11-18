using Inventory_Management.Models;
using InventoryManagement.Services;
using Microsoft.AspNetCore.Mvc;

namespace Inventory_Management.Controllers
{
    public class CategoryController : Controller
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

        //show categories
        [HttpGet("/api/categories")]
        public IActionResult GetAll()
        {
            var data = ds.ReadData();
            return Ok(data.Categories);
        }

        [HttpGet("/api/categories/{id}")]
        public IActionResult Get(int id)
        {
            var data = ds.ReadData();
            var c = data.Categories.FirstOrDefault(x => x.Id == id);
            if (c == null) return NotFound();
            return Ok(c);
        }


        //add categories
        [HttpPost("/api/categories")]
        public IActionResult AddCategory([FromBody] Category category)
        {
            if (category == null) return BadRequest();

            var data = ds.ReadData();
            category.Id = data.Categories.Count > 0 ? data.Categories.Max(c => c.Id) + 1 : 1;
            data.Categories.Add(category);
            ds.WriteData(data);


            return Ok(category);
        }

        //update categories
        [HttpPut("/api/categories/{id}")]
        public IActionResult UpdateCategory(int id, [FromBody] Category updated)
        {
            if (updated == null) return BadRequest();

            var data = ds.ReadData();
            var existing = data.Categories.FirstOrDefault(c => c.Id == id);
            if (existing == null) return NotFound();

            existing.Name = updated.Name;

            foreach (var p in data.Products.Where(p => p.CategoryId == existing.Id))
                p.CategoryName = existing.Name;

            ds.WriteData(data);
            return Ok(existing);
        }


        //delete categories
        [HttpDelete("/api/categories/{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var data = ds.ReadData();
            var used = data.Products.Any(p => p.CategoryId == id);
            if (used)
                return BadRequest(new { message = "Category is assigned to products. Remove or reassign products first." });

            var removed = data.Categories.RemoveAll(c => c.Id == id) > 0;
            if (!removed) return NotFound();
            ds.WriteData(data);
            return Ok();
        }
    }
}

