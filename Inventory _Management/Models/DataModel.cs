using System.Collections.Generic;
namespace Inventory_Management.Models
{
    public class DataModel
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public List<Category> Categories { get; set; } = new List<Category>();
    }
}
