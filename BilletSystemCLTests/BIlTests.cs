using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletSystemCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystemCL.Tests
{
    [TestClass()]
    public class BIlTests
    {
        [TestMethod()]
        public void PrisTestBil()
        {
            var bil = new BIl();
            int pris = bil.Pris();
            Assert.AreEqual(240, pris);
        }

        [TestMethod()]
        public void KøretøjTest()
        {
            var bil = new BIl();
            string køretøj = bil.Køretøj();
            Assert.AreEqual("Bil", køretøj);
           
        }
    }
}