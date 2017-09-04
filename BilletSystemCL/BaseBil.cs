using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystemCL
{
   public abstract class BaseBil
    {
        public string Nummerplade
        { get { return nummerPlade; }
          set { if (value.Length > 7)
                    throw new ArgumentException("Din nummerplade er for lang.");

                nummerPlade = value;

            }
        }

        private string nummerPlade;

        public abstract int Pris();

        public abstract string Køretøj();

       
    }
}
