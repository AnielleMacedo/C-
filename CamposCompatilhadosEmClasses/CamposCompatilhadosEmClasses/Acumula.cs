using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamposCompatilhadosEmClasses
{
    class Acumula
    {
        public static int soma;//campo estatico publico

        //construtor
        public Acumula()
        {
            soma = 0;
        }

        //metodos
        public void Incrementa()
        {
            soma++;
        }

        public void Incrementa(int valor)
        {
            soma += valor;
        }
    }
}
