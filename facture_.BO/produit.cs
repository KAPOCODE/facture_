using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facture_.BO
{
    public class produit
    {
        public string Reference { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Qte { get; set; }

        public produit(string reference, string name, double price, double qte)
        {
            Reference = reference;
            Name = name;
            Price = price;
            Qte = qte;
        }
        public produit(produit produit):this(produit?.Reference, produit?.Name, produit?.Price ?? 0)
        {
                
        }
        public produit(string reference, string name, double qte)
        {
            Reference = reference;
            Name = name;
            Qte = qte;
        }

        public override bool Equals(object obj)
        {
            return obj is produit produit &&
                   Reference == produit.Reference;
        }

        public override int GetHashCode()
        {
            return -1304721846 + EqualityComparer<string>.Default.GetHashCode(Reference);
        }
    }
}
