using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Parte1
{
    class Program
    {
        static void Main(string[] args)
        {
            //instancio a classe Caixa e crio o objeto cx
            Caixa cx = new Caixa();

            //instancio a classe Caixa agora usando parametros
            Caixa cx2 = new Caixa(8);


            //crio uma var p colocar o metodo volume
            double volumeCaixa;
            volumeCaixa = cx.Volume();
            Console.WriteLine(volumeCaixa.ToString());

            //aki chamo construtor sobrecarregado
            double volumeCaixa2;
            volumeCaixa2 = cx2.Volume();
            Console.WriteLine(volumeCaixa2.ToString());



            //como chamar o metodo estatico na classe test
            Console.WriteLine(Caixa.CaixaLadoDois().ToString());





            //Console.WriteLine("Pressione ENTER para sair...");
            Console.ReadKey();//comando pra esperar a tela de output
        }
    }
}
