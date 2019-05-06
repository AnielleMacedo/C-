using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComObjetos
{
    class Programm
    {
        static void Main(string[] args)
        {
            //variavel p armazenar a entrada de dados
            String entrada = "";
            Pessoa pessoa1;
            pessoa1 = new Pessoa();
            Console.WriteLine("Efetua leitura de dados");
            Console.WriteLine("Dados daa 1 pessoa");
            Console.WriteLine("Informe seu nome");

            entrada = Console.ReadLine();
            pessoa1.nome = entrada;
            Console.WriteLine("Informe sua altura:");
            entrada = Console.ReadLine();
            //pessoa1.altura = Convert.ToDouble(entrada);
            pessoa1.faleSobreVoce();
            Console.ReadKey();


        }
    }
}
