using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodiceFiscale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //desabilito o botao no inicio carregamento do form
            this.btnCerca.Enabled = false;
        }


        //funcao pra validar os dados
        public void Validazione()
        {

            if (comboBox1.Text == "")
            {
                btnCerca.Enabled = false;
            }
            else
            {
                btnCerca.Enabled = true;
            }
        }

        private void BtnEsci_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCerca_Click(object sender, EventArgs e)
        {

            string nomeUser = textBoxNome.Text;
            string cognomeUser = textBoxCognome.Text;
            DateTime data = dateTimePicker1.Value;
            string comune = comboBox1.Text;
            bool sessoM = rbtn1.Checked;
            bool sessoF = rbtn2.Checked;



            //tratando Nome e Cognome
            string vogais = "aeiouAEIOU";
            string numeros = "0123456789";
            string specials = "*/+-.-.,;:_°\"#§@[]{}?^=()|£$%&!<>"; //ver funcao regex.replace
            string ctrNome = "";
            string ctrCognome = "";
            string vocali = "";


            //NOME

            foreach (char letter in nomeUser)
            {
                if (letter != ' ' && !numeros.Contains(letter) && !specials.Contains(letter))
                {
                    if (!vogais.Contains(letter))
                    {
                        //devo sempre converter pq a  messgBox so aceita string
                        ctrNome += Convert.ToString(letter);
                    }
                    else if (vogais.Contains(letter))
                    {
                        vocali += Convert.ToString(letter); 

                    }


                }

            }

            //condcicao controle vogais e controle do sesso

            if (ctrNome.Length > 3) //se tem 3 consoantes n add vogal
            {
                //if (sessoM )
                //{
                    //se maschio prendi solo 1° 3° e 4° consonante del nome in ordine 
                    //lembre que a string è imutavel por isso qdo a modificamos devem asseg a outra varia

                    ctrNome = ctrNome.Substring(0, 4);//0 posicao da letra e 3 è a qtidade de carct q quero obter
                    ctrNome = ctrNome.Remove(1, 1);//depois de obter 4 consoante removo so a 2 
                //}

                //else if (sessoF)
                //{
                //    ctrNome = ctrNome.Substring(0, 3);
                //}
                                                                        
            }
            //else if(ctrNome.Length == 3)
            //{
            //    ctrNome = ctrNome.Substring(0, 3);
            //}

            else if (ctrNome.Length == 2)
            {
                ctrNome = ctrNome.Substring(0, 2) + vocali.Substring(0, 1);

            }

            else if (ctrNome.Length == 1)
            {
                ctrNome = ctrNome.Substring(0, 1) + vocali.Substring(0, 2);
            }

            else if (ctrNome.Length == 0)
            {
                ctrNome += vocali.Substring(0, 3); //limito as primeiras 3 vogais

            }

            

            string subNome = ctrNome.ToUpper();




            //COGNOME           

            foreach (char letter in cognomeUser)
            {
                if (letter != ' ' && !numeros.Contains(letter) && !specials.Contains(letter))
                {

                    if (!vogais.Contains(letter))
                    {

                        ctrCognome += Convert.ToString(letter);
                    }
                    else if (vogais.Contains(letter))
                    {
                        vocali += Convert.ToString(letter); //guardo as vogais aki

                    }

                }

            }
            



            if (ctrCognome.Length >= 3) //se tem 3 consoantes n add vogal
            {
                ctrCognome = ctrCognome.Substring(0, 3);
            }

            else if (ctrCognome.Length == 2)
            {
                ctrCognome = ctrCognome.Substring(0, 2) + vocali.Substring(0, 1);

            }

            else if (ctrCognome.Length == 1)
            {
                ctrCognome = ctrCognome.Substring(0, 1) + vocali.Substring(0, 2);
            }

            else if (ctrCognome.Length == 0)
            {
                ctrCognome += vocali.Substring(0, 3); //limito as primeiras 3 vogais

            }
            //else if(ctrCognome.Length == 0 && vocali.Length <=2) //ve se recebeso vogal
            ////{
            ////    ctrCognome = "MEUCU";
            //   // ctrCognome = vocali + ctrCognome.PadRight(3,"X");
            ////}


            string subCognome = ctrCognome.ToUpper();




            //switchcase para o mes

            string mes = Convert.ToString(data.Month);


            switch (mes)
            {

                case "1":       //gennaio
                    mes = "A";
                    break;
                case "2":         
                    mes = "B";
                    break;
                case "3":
                    mes = "C";
                    break;
                case "4":
                    mes = "D";
                    break;
                case "5":
                    mes = "E";
                    break;
                case "6":       //giugno = H
                    mes = "H";
                    break;
                case "7":
                    mes = "L";
                    break;
                case "8":
                    mes = "M";
                    break;
                case "9":
                    mes = "P";
                    break;
                case "10":
                    mes = "R";
                    break;
                case "11":
                    mes = "S";
                    break;
                case "12":
                    mes = "T";
                    break;
            }

            //tratando o sexo e dia do nascimento
            //converto day tb em string
            string giorno = Convert.ToString(data.Day);
          

            int giorno2 = 0;
            string sexo = "";

            if (sessoM)
            {
                if (giorno.Length < 2)
                    sexo = "0" + giorno;
                else
                    sexo = giorno;
            }
            else if (sessoF)
            {
               
                    

               if (giorno.Length == 2)
                {
                    giorno2 = Convert.ToInt16(giorno);
                    giorno2 += 40;
                    sexo = Convert.ToString(giorno2);
                }
               
                else
                    sexo = "4" + giorno;
            }
            else
            {
                //devo tratar isso pra nao continuar a rodar
                MessageBox.Show("Inserisca un sesso valido!");
            }
           

            //tratando o ano
            string ano = Convert.ToString(data.Year);

            //pego os dois ultimos carcteres da string ano q ja foi convertida
            string finalAno = ano.Substring(ano.Length - 2, 2);


            //comune de torino e estero Brasile
            string finalComune = "";

            switch (comune)
            {

                case "Avigliana":
                    finalComune = "A518";
                    break;
                case "Brasile":
                    finalComune = "Z602";
                    break;
                case "Cuneo":
                    finalComune = "D205";
                    break;
                case "Carmagnola":
                    finalComune = "B791";
                    break;
                case "Collegno":
                    finalComune = "C860";
                    break;
                case "Giaveno":
                    finalComune = "E020";
                    break;
                case "Moncalieri":
                    finalComune = "F335";
                    break;
                case "Poirino":
                    finalComune = "G777";
                    break;
                case "Torino":
                    finalComune = "L219";
                    break;
                case "Roma":finalComune = "H501";break;
                case "Caraglio": finalComune = "B719"; break;
                case "Galatone": finalComune = "D863"; break;
                case "Lecce": finalComune = "E506"; break;

            }



            string nomeUser2 = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nomeUser.ToLower());
            string cognomeUser2 = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(cognomeUser.ToLower());



            //Codigo p controle da ultima letra do CF

            string code = subCognome + subNome + finalAno
                + mes + sexo + finalComune;

            
            string temp;
            int subIndexPari = 0;
            int subIndexDisp = 0;
            int[] arr_dispari = new int[8]; //temos 8 posicoes que vao da 0 a 7
            int[] arr_pari = new int[7];


            for(int i =0; i<15; i++)
            {
                if ((i + 1) % 2 != 0)
                {
                    temp = code.Substring(i, 1); //pq o substring parte da zero
                    
                    switch (temp)
                    {

                        case "0":arr_dispari[subIndexDisp] = 1;break;
                        case "1":arr_dispari[subIndexDisp] = 0;break;
                        case "2":arr_dispari[subIndexDisp] = 5;break;
                        case "3":arr_dispari[subIndexDisp] = 7;break;
                        case "4":arr_dispari[subIndexDisp] = 9;break;
                        case "5":arr_dispari[subIndexDisp] = 13;break;
                        case "6":arr_dispari[subIndexDisp] = 15;break;
                        case "7":arr_dispari[subIndexDisp] = 17;break;
                        case "8":arr_dispari[subIndexDisp] = 19;break;

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

                    //string test = Convert.ToString(arr_dispari[subIndexDisp]);
                    //MessageBox.Show(test);
                    subIndexDisp++; //incrementa altrimente subscrive no mesmmo indice
                }

                


                else 
                    {
                    temp = code.Substring(i, 1);

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

                    //string test = Convert.ToString(arr_pari[subIndexPari]);
                    //MessageBox.Show(test);
                    subIndexPari++;
                }

                
            }

            //somo os elementos de ambas os arrays pois sao numericos
            int somaDispari = 0;
            int somaPari = 0;
            string identificativo ="";

            for (int i = 0; i < arr_dispari.Length; i++)
            {
                somaDispari += arr_dispari[i];
            }

            for (int i = 0; i < arr_pari.Length; i++)
            {
                somaPari += arr_pari[i];
            }

            int totale= somaDispari + somaPari;
            //MessageBox.Show(Convert.ToString(totale));
            int resto = totale % 26;
            //resto.//MessageBox.Show(Convert.ToString(totale));



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

                                           

            //Imprimo todas as variaveis na MessageBox p me retornar o CF
            MessageBox.Show("Il Codice Fiscale è il seguente:  \n\n" + subCognome +
                subNome + finalAno + mes + sexo + finalComune + identificativo);


        }

        private void TextBoxNome_TextChanged(object sender, EventArgs e)
        {
            Validazione();
        }

        private void TextBoxCognome_TextChanged(object sender, EventArgs e)
        {
            Validazione();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Validazione();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validazione();
        }
    }
}
