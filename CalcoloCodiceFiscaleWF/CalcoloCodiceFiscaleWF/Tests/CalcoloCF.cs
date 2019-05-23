using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CalcoloCodiceFiscaleWF.Enums;
using CalcoloCodiceFiscaleWF.StaticClasses;

namespace CalcoloCodiceFiscaleWF.Tests
{
    [TestFixture]
    class CalcoloCF
    {
        [TestCase]
        public void TestCalcoloCF()
        {
           

            //Assert.IsFalse(result, "");
            //Ver se a variavel result sera  a string indicada

            CFCalc.GetInfo("Gomes Macedo", "Anielle", new DateTime(1988,04,03), Enums.Gender.Female,"Z602");
        
            string result = CFCalc.Calculate();
            Assert.AreEqual( "GMSNLL88D43Z602B", result);


            
        }

        ////nao se pode testar metodos privados porque nao sao visiveis ao externo
       
        //{
            
        //}

    }
}
