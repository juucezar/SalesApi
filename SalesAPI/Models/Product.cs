using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesAPI.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public int CategorieId { get; set; }
        public int ProductId { get; set; }
        public int PriceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Reserved { get; set; }
        public bool Activated { get; set; }
        public DateTime DateActivated { get; set; }
        public DateTime DateDeactivated { get; set; }

    }
}
