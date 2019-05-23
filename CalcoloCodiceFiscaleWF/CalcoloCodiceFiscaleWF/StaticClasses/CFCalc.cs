using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcoloCodiceFiscaleWF.Enums;
using System.Windows.Forms;

namespace CalcoloCodiceFiscaleWF.StaticClasses
{
    public static class CFCalc
    {
        public static void GetInfo(string nomeUser, string cognomeUser, DateTime data, Gender gender, string comune)
        {
            _name = nomeUser;
            _surname = cognomeUser;
            _birthdate = data;
            _gender = gender;
            _codiceComune = comune;
            
        }
       

        static private string _name;
        static private string _surname;
        static private DateTime _birthdate;
        static private Gender _gender;
        static private string _codiceComune;

     

        public static string Calculate()
        {
            string result = "";

            result += CalcSurname(_surname);
            result += CalcName(_name);
            result += CalcYear();
            result += CalcMese();
            result += _gender == Gender.Male ? _birthdate.ToString("dd") : (_birthdate.Day + 40).ToString();
            result += _codiceComune;
            result += IdControle(result);

            MessageBox.Show(result.ToUpper());
            return result;
        }

        private static string IdControle(string result) 
        {
            //Codigo p controle da ultima letra do CF
                   
            string temp;
            int subIndexPari = 0;
            int subIndexDisp = 0;
            int[] arr_dispari = new int[8]; //da 0 a 7
            int[] arr_pari = new int[7];


            for (int i = 0; i < 15; i++)
            {
                if ((i + 1) % 2 != 0)
                {
                    temp = result.Substring(i, 1); //substring parte da zero

                    switch (temp)
                    {

                        case "0": arr_dispari[subIndexDisp] = 1; break;
                        case "1": arr_dispari[subIndexDisp] = 0; break;
                        case "2": arr_dispari[subIndexDisp] = 5; break;
                        case "3": arr_dispari[subIndexDisp] = 7; break;
                        case "4": arr_dispari[subIndexDisp] = 9; break;
                        case "5": arr_dispari[subIndexDisp] = 13; break;
                        case "6": arr_dispari[subIndexDisp] = 15; break;
                        case "7": arr_dispari[subIndexDisp] = 17; break;
                        case "8": arr_dispari[subIndexDisp] = 19; break;

                        case "9": arr_dispari[subIndexDisp] = 21; break;
                        case "A": arr_dispari[subIndexDisp] = 1; break;
                        case "B": arr_dispari[subIndexDisp] = 0; break;
                        case "C": arr_dispari[subIndexDisp] = 5; break;
                        case "D": arr_dispari[subIndexDisp] = 7; break;
                        case "E": arr_dispari[subIndexDisp] = 9; break;
                        case "F": arr_dispari[subIndexDisp] = 13; break;
                        case "G": arr_dispari[subIndexDisp] = 15; break;
                        case "H": arr_dispari[subIndexDisp] = 17; break;

                        case "I": arr_dispari[subIndexDisp] = 19; break;
                        case "J": arr_dispari[subIndexDisp] = 21; break;
                        case "K": arr_dispari[subIndexDisp] = 2; break;
                        case "L": arr_dispari[subIndexDisp] = 4; break;
                        case "M": arr_dispari[subIndexDisp] = 18; break;
                        case "N": arr_dispari[subIndexDisp] = 20; break;
                        case "O": arr_dispari[subIndexDisp] = 11; break;
                        case "P": arr_dispari[subIndexDisp] = 3; break;
                        case "Q": arr_dispari[subIndexDisp] = 6; break;

                        case "R": arr_dispari[subIndexDisp] = 8; break;
                        case "S": arr_dispari[subIndexDisp] = 12; break;
                        case "T": arr_dispari[subIndexDisp] = 14; break;
                        case "U": arr_dispari[subIndexDisp] = 16; break;
                        case "V": arr_dispari[subIndexDisp] = 10; break;
                        case "W": arr_dispari[subIndexDisp] = 22; break;
                        case "X": arr_dispari[subIndexDisp] = 25; break;
                        case "Y": arr_dispari[subIndexDisp] = 24; break;
                        case "Z": arr_dispari[subIndexDisp] = 23; break;

                    }

                    
                    subIndexDisp++; //incrementa altrimente subscrive no mesmmo indice
                }




                else
                {
                    temp = result.Substring(i, 1);

                    switch (temp)
                    {

                        case "0": arr_pari[subIndexPari] = 0; break;
                        case "1": arr_pari[subIndexPari] = 1; break;
                        case "2": arr_pari[subIndexPari] = 2; break;
                        case "3": arr_pari[subIndexPari] = 3; break;
                        case "4": arr_pari[subIndexPari] = 4; break;
                        case "5": arr_pari[subIndexPari] = 5; break;
                        case "6": arr_pari[subIndexPari] = 6; break;
                        case "7": arr_pari[subIndexPari] = 7; break;
                        case "8": arr_pari[subIndexPari] = 8; break;

                        case "9": arr_pari[subIndexPari] = 9; break;
                        case "A": arr_pari[subIndexPari] = 0; break;
                        case "B": arr_pari[subIndexPari] = 1; break;
                        case "C": arr_pari[subIndexPari] = 2; break;
                        case "D": arr_pari[subIndexPari] = 3; break;
                        case "E": arr_pari[subIndexPari] = 4; break;
                        case "F": arr_pari[subIndexPari] = 5; break;
                        case "G": arr_pari[subIndexPari] = 6; break;
                        case "H": arr_pari[subIndexPari] = 7; break;

                        case "I": arr_pari[subIndexPari] = 8; break;
                        case "J": arr_pari[subIndexPari] = 9; break;
                        case "K": arr_pari[subIndexPari] = 10; break;
                        case "L": arr_pari[subIndexPari] = 11; break;
                        case "M": arr_pari[subIndexPari] = 12; break;
                        case "N": arr_pari[subIndexPari] = 13; break;
                        case "O": arr_pari[subIndexPari] = 14; break;
                        case "P": arr_pari[subIndexPari] = 15; break;
                        case "Q": arr_pari[subIndexPari] = 16; break;

                        case "R": arr_pari[subIndexPari] = 17; break;
                        case "S": arr_pari[subIndexPari] = 18; break;
                        case "T": arr_pari[subIndexPari] = 19; break;
                        case "U": arr_pari[subIndexPari] = 20; break;
                        case "V": arr_pari[subIndexPari] = 21; break;
                        case "W": arr_pari[subIndexPari] = 22; break;
                        case "X": arr_pari[subIndexPari] = 23; break;
                        case "Y": arr_pari[subIndexPari] = 24; break;
                        case "Z": arr_pari[subIndexPari] = 25; break;


                    }

                    subIndexPari++;
                }


            }

            int somaDispari = 0;
            int somaPari = 0;
            string identificativo = "";

            for (int i = 0; i < arr_dispari.Length; i++)
            {
                somaDispari += arr_dispari[i];
            }

            for (int i = 0; i < arr_pari.Length; i++)
            {
                somaPari += arr_pari[i];
            }

            int totale = somaDispari + somaPari;
            int resto = totale % 26;


            switch (resto)
            {

                case 0: identificativo = "A"; break;
                case 1: identificativo = "B"; break;
                case 2: identificativo = "C"; break;
                case 3: identificativo = "D"; break;
                case 4: identificativo = "E"; break;
                case 5: identificativo = "F"; break;
                case 6: identificativo = "G"; break;
                case 7: identificativo = "H"; break;
                case 8: identificativo = "I"; break;
                case 9: identificativo = "J"; break;
                case 10: identificativo = "K"; break;
                case 11: identificativo = "L"; break;
                case 12: identificativo = "M"; break;
                case 13: identificativo = "N"; break;
                case 14: identificativo = "O"; break;
                case 15: identificativo = "P"; break;
                case 16: identificativo = "Q"; break;
                case 17: identificativo = "R"; break;
                case 18: identificativo = "S"; break;

                case 19: identificativo = "T"; break;
                case 20: identificativo = "U"; break;
                case 21: identificativo = "V"; break;
                case 22: identificativo = "W"; break;
                case 23: identificativo = "X"; break;
                case 24: identificativo = "Y"; break;
                case 25: identificativo = "Z"; break;


            }
            return identificativo;

        }



        private static string CalcYear() //ve se precisa usar string year
        {
            
            string ano = Convert.ToString(_birthdate.Year);
            string finalAno = ano.Substring(ano.Length - 2, 2);

            return finalAno;
        }

        private static string CalcMese() 
        {
            string mes = Convert.ToString(_birthdate.Month);
            switch (mes)
            {

                case "1": mes = "A"; break;
                case "2": mes = "B"; break;
                case "3": mes = "C"; break;
                case "4": mes = "D"; break;
                case "5": mes = "E"; break;
                case "6": mes = "H"; break;
                case "7": mes = "L"; break;
                case "8": mes = "M"; break;
                case "9": mes = "P"; break;
                case "10": mes = "R"; break;
                case "11": mes = "S"; break;
                case "12": mes = "T"; break;
            }
            return mes;
        }

            
        

                     
        private static string CalcName(string nomeUser)
        {

            string vogais = "aeiouAEIOU";
            string numeros = "0123456789";
            string specials = "*/+-.-.,;:_°\"#§@[]{}?^=()|£$%&!<>";
            string consNome = "";
            string vocaliNome = "";
            string resNome = "";

            //se il nome contiene 4 o più consonanti, si scelgono la 1°, 3° e 4°

            foreach (char letter in nomeUser)
            {
                if (letter != ' ' && !numeros.Contains(letter) && !specials.Contains(letter))
                {
                    if (!vogais.Contains(letter))
                    {
                        consNome += Convert.ToString(letter);
                    }
                    else if (vogais.Contains(letter))
                    {
                        vocaliNome += Convert.ToString(letter);

                    }


                }

            }

            
            if (consNome.Length == 3)
            {
                resNome = consNome;
            }

            else if (consNome.Length > 3)
            {
                resNome = consNome.Substring(0, 4).Remove(1, 1);//0 posicao da letra e 3 è a qtidade de carct q quero obter
                                                                  
                                                                                                    
            }
            
            else if (consNome.Length == 2 && vocaliNome.Length > 0)
            {
                resNome = consNome.Substring(0, 2) + vocaliNome.Substring(0, 1);

            }
            else if (consNome.Length == 2 && vocaliNome.Length == 0)
            {
                resNome = consNome.Substring(0, 2) + "X";

            }
            else if (consNome.Length == 1 && vocaliNome.Length == 1)
            {
                resNome = consNome.Substring(0, 1) + vocaliNome.Substring(0, 1) + "X";

            }


            else if (consNome.Length == 1 && vocaliNome.Length > 0)
            {
                resNome = consNome.Substring(0, 1) + vocaliNome.Substring(0, 2);

            }

            else if (consNome.Length == 0 && vocaliNome.Length == 2)
            {
                resNome = vocaliNome.Substring(0, 2) + "X";
            }

            else if (consNome.Length == 0)
            {
                resNome = vocaliNome.Substring(0, 3);

            }

            return resNome.ToUpper();
        }





        private static string CalcSurname(string cognomeUser)
        {

            string vogais = "aeiouAEIOU";
            string numeros = "0123456789";
            string specials = "*/+-.-.,;:_°\"#§@[]{}?^=()|£$%&!<>";
            string consCognome = "";
            string vocaliCognome = "";
            string resCognome = "";


            foreach (char letter in cognomeUser)
            {
                if (letter != ' ' && !numeros.Contains(letter) && !specials.Contains(letter))
                {

                    if (!vogais.Contains(letter))
                    {

                        consCognome += Convert.ToString(letter);
                    }
                    else if (vogais.Contains(letter))
                    {
                        vocaliCognome += Convert.ToString(letter);

                    }

                }

            }
                                 
            if (consCognome.Length >= 3)
            {
                resCognome = consCognome.Substring(0, 3);
            }

            else if (consCognome.Length == 2 && vocaliCognome.Length > 0)
            {
                resCognome = consCognome.Substring(0, 2) + vocaliCognome.Substring(0, 1);

            }
            else if (consCognome.Length == 2 && vocaliCognome.Length == 0)
            {
                resCognome = consCognome.Substring(0, 2) + "X";

            }
            else if (consCognome.Length == 1 && vocaliCognome.Length == 1)
            {
                resCognome = consCognome.Substring(0, 1) + vocaliCognome.Substring(0, 1) + "X";

            }


            else if (consCognome.Length == 1 && vocaliCognome.Length > 0)
            {
                resCognome = consCognome.Substring(0, 1) + vocaliCognome.Substring(0, 2);

            }

            else if (consCognome.Length == 0 && vocaliCognome.Length == 2)
            {
                resCognome = vocaliCognome.Substring(0, 2) + "X";
            }


            else if (consCognome.Length == 0)
            {
                resCognome = vocaliCognome.Substring(0, 3); 

            }

            return resCognome.ToUpper();


        }

       

        

        
      
         
    }
}
