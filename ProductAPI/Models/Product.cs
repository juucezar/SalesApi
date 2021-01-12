using System;

namespace SaleAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int CategorieId { get; set; }
        public int ProductId { get; set; }
        public int PriceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Reserved { get; set; }
        public string Activated { get; set; }
        public DateTime DateActivated { get; set; }
        public DateTime DateDeactivated { get; set; }
    }
}
