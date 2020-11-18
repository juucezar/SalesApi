using System;

namespace SaleWeb.Models
{
    public class Product
    {
        public int id { get; set; }
        public int categorieId { get; set; }
        public int productId { get; set; }
        public int priceId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string reserved { get; set; }
        public string activated { get; set; }
        public DateTime dateActivated { get; set; }
        public DateTime dateDeactivated { get; set; }
    }


}
