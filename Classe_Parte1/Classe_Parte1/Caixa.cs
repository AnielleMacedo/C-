using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Parte1 //nome do projeto
{
    class Caixa
    {
        //crio um campo privado
        private double lado;


        //crio um metodo construtor e inicializo um campo
        public Caixa()
        {
            lado = 10.5;
        }


        //sobrecaraga de costrutor pra poder aceitar numero de parametros diferente do const padrao que nao utiliza parametro nenhum
        //permitindo entao aceitar o argumento do usuario e nao mais o de default do construtor padrao
        public Caixa(double qualquerlado)
        {
            lado = qualquerlado;
        }


        //crio um metodo
        public double Volume()
        {
            return lado * lado * lado;
        }

        //criando metodo estatico
        public static int CaixaLadoDois()
        {
            int lateral = 2;
            int vol = lateral * lateral * lateral;
            return vol;
        }
    }
}
