using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleAPI.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string ClientDescription { get; set; }
        public int IdContact { get; set; }
        public double Credit { get; set; }
        public double Debt { get; set; }
        public DateTime BirthDate { get; set; }
        public int IdReservedItens { get; set; }
        public string Activated { get; set; }
        
    }
}
