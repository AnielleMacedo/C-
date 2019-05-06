using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores_Acesso
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovel carro = new Automovel();
            carro.DadosAutomovel();
            carro.MostraChassis();
            Console.WriteLine(carro.portas.ToString());


            Veiculo veiculo = new Veiculo();
            veiculo.MostraChassis();
            

            Console.ReadKey();
        }
    }


//classe mae
class Veiculo
    {
        //campo protegido acessivel pela classe veiculo e suas classes filhas/derivadas
        //convecao usar underline antes de campos privado e protegidos
        protected string _placa;

        //campo privado
        private string _chassis;

        //campo publico acessivel em qq lugar
        public int portas;

        //metodo construtor padrao q inicializa as variaveis
        public Veiculo()
        {
            this._placa = "AAA-0000";
            this._chassis = "0000000000000";
            this.portas = 4; //this fz referencia aos campos da propria classe
        }

        public void MostraChassis()
        {
            //precisa de um metodo publico pra poder acessar o valor do chassi que è privado
            Console.WriteLine("O chassis è {0}", this._chassis);
        }
    }

    //classe filha
    class Automovel: Veiculo
    {
        public void DadosAutomovel()
        {
            Console.WriteLine("A placa do auto è {0}", this._placa);

            //veja q na classe filha nao posso acessar o campo chassi so atraves do metodo mostrachassis
        }
    }
}
