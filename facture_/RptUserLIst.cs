using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facture_
{
    class RptUserLIst
    {
        public string Email { get; set; }
        public string Fullname { get; set; }

        public RptUserLIst(string email, string fullname)
        {
            Email = email;
            Fullname = fullname;
        }
    }
}
