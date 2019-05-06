using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            //classe mae tb pode ser instanciada
            Mamifero animal = new Mamifero();
            animal.Respirar();

            //crio objeto homem, instancia da classe HUmano
            Humano homem = new Humano();
            Gato bichano = new Gato();

            homem.Falar();
            homem.Mamar();
            homem.Respirar();
            homem.Lutar();//metodo sobrescreveu o da classe mae

            bichano.Miar();
            bichano.Respirar();

            bichano.Lutar();//usa o metodo da classe mae pq n tem override

            Console.ReadKey();
        }
    }

    //essa minha classe base/MAE ta usando o construtor padrao do visual
    class Mamifero
    {

        public void Respirar()
        {
            Console.WriteLine("Eu respiro");
        }

        public void Mamar()
        {
            Console.WriteLine("Eu mamo leite");
        }

        //metodo virtual que sera implementado na classe fiha humano
        public virtual void Lutar()
        {
            Console.WriteLine("Eu luto com a forca dos musculos!");
        }
    }

    //classe filha
    class Humano : Mamifero
    {
        public void Falar()
        {
            Console.WriteLine("eu falo");
        }

        //override do metodo lutar da classe mae Mamifero
        public override void Lutar()
        {
            Console.WriteLine("Eu luto com armas e faco GUERRA!");
        }
    }

    //classe filha
    class Gato : Mamifero
    {
        public void Miar()
        {
            Console.WriteLine("eu mio");
        }

        
    }

   
}
