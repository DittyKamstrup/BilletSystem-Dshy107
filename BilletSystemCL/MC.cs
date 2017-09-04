using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystemCL
{
    public class MC : BaseBil
    {

        public override int Pris()
        {
            

            if (BroBizz)
                return GrundPris * 95 / 100;

            return GrundPris;
        }

        public override string Køretøj()
        {
            return "MC";
        }

        public MC() : base(125)
        {

        }
    }

}
