namespace CalcoloCodiceFiscaleWF
{
    partial class FormCodiceFiscale
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitolo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCognome = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.rbtMaschio = new System.Windows.Forms.RadioButton();
            this.rbtFemmina = new System.Windows.Forms.RadioButton();
            this.dtpDataNascita = new System.Windows.Forms.DateTimePicker();
            this.lblDataNascita = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.lblComuneNascita = new System.Windows.Forms.Label();
            this.cbxComuneNascita = new System.Windows.Forms.ComboBox();
            this.comuneBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comuneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnClean = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.comuneBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comuneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitolo
            // 
            this.lblTitolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitolo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTitolo.Location = new System.Drawing.Point(19, 20);
            this.lblTitolo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitolo.Size = new System.Drawing.Size(756, 43);
            this.lblTitolo.TabIndex = 0;
            this.lblTitolo.Text = "Calcolo Codice Fiscale";
            this.lblTitolo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(257, 113);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(277, 27);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.TxtNome_TextChanged);
            // 
            // lblNome
            // 
            this.lblNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(79, 113);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 20);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // lblCognome
            // 
            this.lblCognome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCognome.AutoSize = true;
            this.lblCognome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCognome.Location = new System.Drawing.Point(79, 174);
            this.lblCognome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(80, 20);
            this.lblCognome.TabIndex = 4;
            this.lblCognome.Text = "Cognome";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(353, 432);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(117, 48);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // rbtMaschio
            // 
            this.rbtMaschio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtMaschio.AutoSize = true;
            this.rbtMaschio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMaschio.Location = new System.Drawing.Point(263, 360);
            this.rbtMaschio.Margin = new System.Windows.Forms.Padding(4);
            this.rbtMaschio.Name = "rbtMaschio";
            this.rbtMaschio.Size = new System.Drawing.Size(93, 24);
            this.rbtMaschio.TabIndex = 6;
            this.rbtMaschio.TabStop = true;
            this.rbtMaschio.Text = "Maschio";
            this.rbtMaschio.UseVisualStyleBackColor = true;
            this.rbtMaschio.CheckedChanged += new System.EventHandler(this.RbtMaschio_CheckedChanged);
            // 
            // rbtFemmina
            // 
            this.rbtFemmina.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtFemmina.AutoSize = true;
            this.rbtFemmina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtFemmina.Location = new System.Drawing.Point(380, 360);
            this.rbtFemmina.Margin = new System.Windows.Forms.Padding(4);
            this.rbtFemmina.Name = "rbtFemmina";
            this.rbtFemmina.Size = new System.Drawing.Size(99, 24);
            this.rbtFemmina.TabIndex = 7;
            this.rbtFemmina.TabStop = true;
            this.rbtFemmina.Text = "Femmina";
            this.rbtFemmina.UseVisualStyleBackColor = true;
            this.rbtFemmina.CheckedChanged += new System.EventHandler(this.RbtFemmina_CheckedChanged);
            // 
            // dtpDataNascita
            // 
            this.dtpDataNascita.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataNascita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNascita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascita.Location = new System.Drawing.Point(257, 233);
            this.dtpDataNascita.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDataNascita.Name = "dtpDataNascita";
            this.dtpDataNascita.Size = new System.Drawing.Size(278, 27);
            this.dtpDataNascita.TabIndex = 8;
            this.dtpDataNascita.ValueChanged += new System.EventHandler(this.DtpDataNascita_ValueChanged);
            // 
            // lblDataNascita
            // 
            this.lblDataNascita.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataNascita.AutoSize = true;
            this.lblDataNascita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascita.Location = new System.Drawing.Point(79, 235);
            this.lblDataNascita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataNascita.Name = "lblDataNascita";
            this.lblDataNascita.Size = new System.Drawing.Size(125, 20);
            this.lblDataNascita.TabIndex = 9;
            this.lblDataNascita.Text = "Data di Nascita";
            // 
            // txtCognome
            // 
            this.txtCognome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCognome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCognome.Location = new System.Drawing.Point(257, 171);
            this.txtCognome.Margin = new System.Windows.Forms.Padding(4);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(277, 27);
            this.txtCognome.TabIndex = 3;
            this.txtCognome.TextChanged += new System.EventHandler(this.TxtCognome_TextChanged);
            // 
            // lblComuneNascita
            // 
            this.lblComuneNascita.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblComuneNascita.AutoSize = true;
            this.lblComuneNascita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComuneNascita.Location = new System.Drawing.Point(79, 296);
            this.lblComuneNascita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComuneNascita.Name = "lblComuneNascita";
            this.lblComuneNascita.Size = new System.Drawing.Size(151, 20);
            this.lblComuneNascita.TabIndex = 10;
            this.lblComuneNascita.Text = "Comune di Nascita";
            // 
            // cbxComuneNascita
            // 
            this.cbxComuneNascita.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxComuneNascita.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxComuneNascita.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxComuneNascita.DataSource = this.comuneBindingSource1;
            this.cbxComuneNascita.DisplayMember = "Name";
            this.cbxComuneNascita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxComuneNascita.FormattingEnabled = true;
            this.cbxComuneNascita.Location = new System.Drawing.Point(260, 292);
            this.cbxComuneNascita.Margin = new System.Windows.Forms.Padding(4);
            this.cbxComuneNascita.Name = "cbxComuneNascita";
            this.cbxComuneNascita.Size = new System.Drawing.Size(328, 28);
            this.cbxComuneNascita.TabIndex = 11;
            this.cbxComuneNascita.SelectedIndexChanged += new System.EventHandler(this.CbxComuneNascita_SelectedIndexChanged);
            // 
            // comuneBindingSource1
            // 
            this.comuneBindingSource1.DataSource = typeof(CalcoloCodiceFiscaleWF.Comune);
            // 
            // btnClean
            // 
            this.btnClean.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClean.Location = new System.Drawing.Point(171, 432);
            this.btnClean.Margin = new System.Windows.Forms.Padding(4);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(117, 48);
            this.btnClean.TabIndex = 12;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.Location = new System.Drawing.Point(515, 432);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(117, 48);
            this.btnQuit.TabIndex = 13;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sesso";
            // 
            // FormCodiceFiscale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(801, 529);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.cbxComuneNascita);
            this.Controls.Add(this.lblComuneNascita);
            this.Controls.Add(this.lblDataNascita);
            this.Controls.Add(this.dtpDataNascita);
            this.Controls.Add(this.rbtFemmina);
            this.Controls.Add(this.rbtMaschio);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblTitolo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCodiceFiscale";
            this.Text = "FormCodiceFiscale";
            ((System.ComponentModel.ISupportInitialize)(this.comuneBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comuneBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.RadioButton rbtMaschio;
        private System.Windows.Forms.RadioButton rbtFemmina;
        private System.Windows.Forms.DateTimePicker dtpDataNascita;
        private System.Windows.Forms.Label lblDataNascita;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label lblComuneNascita;
        private System.Windows.Forms.ComboBox cbxComuneNascita;
        private System.Windows.Forms.BindingSource comuneBindingSource;
        private System.Windows.Forms.BindingSource comuneBindingSource1;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label label1;
    }
}

