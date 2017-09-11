using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystemCL
{
    public class BIl : BaseBil
    {
        private int v;

       //TEST FEEDBACK
        public override int Pris()
        {
            int total = GrundPris;

            if (base.Dato.DayOfWeek == DayOfWeek.Saturday || base.Dato.DayOfWeek == DayOfWeek.Sunday)
                total = total * 80 / 100;

            if (BroBizz)
                return total * 95 / 100;

            return total;
        }

        public override string Køretøj()
        {
            return "Bil";
        }

        public BIl() : base(240)
        {

        }
            
    }
}
