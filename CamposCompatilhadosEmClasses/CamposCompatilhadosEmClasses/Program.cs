using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamposCompatilhadosEmClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            ///crio 2 objetos so tipo Acumula
            Acumula objeto1= new Acumula();
            Acumula objeto2 = new Acumula();

            objeto1.Incrementa();
            Console.WriteLine("O valor do objeto è {0}: ", Acumula.soma.ToString());


            objeto2.Incrementa(8);
            Console.WriteLine("O valor do objeto è {0}: ", Acumula.soma.ToString());


            //essa tecnica permite compartilhar informacoes da classe entre todos os objetos

            Console.ReadKey();

        }
    }
}
