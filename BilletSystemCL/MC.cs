using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystemCL
{
    public class MC : BaseBil
    {
        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }

       

        public override string Køretøj()
        {
            return "Motorcykel";
        }

        public override int Pris()
        {
            return 125;
        }
    }

}
