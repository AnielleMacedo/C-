using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CalcoloCodiceFiscaleWF.Enums;
using CalcoloCodiceFiscaleWF.StaticClasses;


namespace CalcoloCodiceFiscaleWF
{
    public partial class FormCodiceFiscale : Form
    {
        public FormCodiceFiscale()
        {
            InitializeComponent();

            this.btnOK.Enabled = false;

            string[] comuni = new string[] { "Bari","Brasile", "Cosenza", "Cuneo", "Rivoli",
                "Roma", "Torino"};
            List<Comune> listComuni = new List<Comune>
            {
                new Comune() { Name = "Bari" , Codice= "A662"},
                new Comune() { Name = "Brasile" , Codice= "Z602"},
                new Comune() { Name = "Chieri" , Codice= "C627"},
                new Comune() { Name = "Cosenza" , Codice= "D086"},
                new Comune() { Name = "Cuba" , Codice= "Z504"},
                new Comune() { Name = "Cuneo" , Codice= "D205"},
                new Comune() { Name = "Rivoli" , Codice= "H355"},
                new Comune() { Name = "Roma" , Codice= "H501"},
                new Comune() { Name = "Romania" , Codice= "Z129"},
                new Comune() { Name = "Torino", Codice = "L219" },

            };

            cbxComuneNascita.DataSource = listComuni;
        }


        public void Clean()
        {
            txtNome.Text = "";
            txtCognome.Text = "";
            cbxComuneNascita.Text = "";
            rbtMaschio.Checked = false;
            rbtFemmina.Checked = false;
            
        }
        
        public void Validazione()
        {
            if (txtNome.Text == "" || txtCognome.Text == "" ||
                cbxComuneNascita.Text == "" || dtpDataNascita.Text
                == "" || (rbtMaschio.Checked == false && rbtFemmina.Checked == false))
            {

                btnOK.Enabled = false;
            }
            else
            {
                btnOK.Enabled = true;
            }
        }




        private void btnOK_Click(object sender, EventArgs e)
        {
            
            string nomeUser = txtNome.Text;
            string cognomeUser = txtCognome.Text;
            DateTime data = dtpDataNascita.Value;
            Gender gender = Gender.Undefined;


            if (rbtMaschio.Checked)
               gender = Gender.Male;
            else
               gender = Gender.Female;

            Comune selectedComune;
            try
            {
                selectedComune = (Comune)cbxComuneNascita.SelectedItem;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore", "Seleziona un comune valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           CFCalc.GetInfo(nomeUser, cognomeUser, data, gender, selectedComune.Codice);
           CFCalc.Calculate();
                       
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            Validazione();
        }

        private void TxtCognome_TextChanged(object sender, EventArgs e)
        {
            Validazione();
        }

        private void DtpDataNascita_ValueChanged(object sender, EventArgs e)
        {
            Validazione();
        }

        private void CbxComuneNascita_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validazione();
        }

        private void RbtMaschio_CheckedChanged(object sender, EventArgs e)
        {
            Validazione();
        }

        private void RbtFemmina_CheckedChanged(object sender, EventArgs e)
        {
            Validazione();
        }
    }



    internal class Comune {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _codice;

        public string Codice
        {
            get { return _codice; }
            set { _codice = value; }
        }
    }
}
