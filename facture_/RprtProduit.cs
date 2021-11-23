using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facture_
{
   public class RprtProduit
    {
        public string Reference { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Qte { get; set; }
      

        public RprtProduit(string reference, string name, double price, double qte)
        {
            Reference = reference;
            Name = name;
            Price = price;
            Qte = qte;
        }
    }


}
