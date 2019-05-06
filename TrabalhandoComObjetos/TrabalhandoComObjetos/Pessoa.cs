using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComObjetos
{
    class Pessoa
    {
        public string nome;
        public string altura;

        public void faleSobreVoce()
        {
            Console.WriteLine("Meu nome è: " + nome);
            Console.WriteLine("Eu tenho: " + altura + "metros de altura");
        }
    }
}
