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
    public class MCTests
    {
        [TestMethod()]
        public void PrisTestMC()
        {
            var mc = new MC();
            int pris = mc.Pris();
            Assert.AreEqual(125, pris);
        }

        [TestMethod()]
        public void KøretøjTest()
        {
            var mc = new MC();
            string køretøj = mc.Køretøj();
            Assert.AreEqual("Motorcykel", køretøj); 
        }
    }
}