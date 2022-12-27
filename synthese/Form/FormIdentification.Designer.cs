namespace synthese
{
    partial class FormIdentification
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDuree = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxPages = new System.Windows.Forms.TextBox();
            this.txtBoxQuantite = new System.Windows.Forms.TextBox();
            this.txtboxTitre = new System.Windows.Forms.TextBox();
            this.comboBoxArticle = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnModifArticle = new System.Windows.Forms.Button();
            this.btnEmprunter = new System.Windows.Forms.Button();
            this.btnAjoutArticle = new System.Windows.Forms.Button();
            this.btnSupArticle = new System.Windows.Forms.Button();
            this.lblErreurCb = new System.Windows.Forms.Label();
            this.lblErreurNoIdentifFilm = new System.Windows.Forms.Label();
            this.lblErreurNoTelPages = new System.Windows.Forms.Label();
            this.lblErreurCourrielQuantite = new System.Windows.Forms.Label();
            this.lblErreurNomTitre = new System.Windows.Forms.Label();
            this.lblErreurPrenom = new System.Windows.Forms.Label();
            this.comboBoxUsager = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAjoutClient = new System.Windows.Forms.Button();
            this.btnSupClient = new System.Windows.Forms.Button();
            this.btnModifClient = new System.Windows.Forms.Button();
            this.txtboxNom = new System.Windows.Forms.TextBox();
            this.txtboxCourriel = new System.Windows.Forms.TextBox();
            this.txtboxNoTelephone = new System.Windows.Forms.TextBox();
            this.txtNoIdentification = new System.Windows.Forms.TextBox();
            this.txtboxPrenom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDuree
            // 
            this.txtDuree.Location = new System.Drawing.Point(634, 172);
            this.txtDuree.Name = "txtDuree";
            this.txtDuree.Size = new System.Drawing.Size(144, 20);
            this.txtDuree.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(515, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Durée du film";
            // 
            // txtBoxPages
            // 
            this.txtBoxPages.Location = new System.Drawing.Point(634, 141);
            this.txtBoxPages.Name = "txtBoxPages";
            this.txtBoxPages.Size = new System.Drawing.Size(144, 20);
            this.txtBoxPages.TabIndex = 53;
            // 
            // txtBoxQuantite
            // 
            this.txtBoxQuantite.Location = new System.Drawing.Point(634, 110);
            this.txtBoxQuantite.Name = "txtBoxQuantite";
            this.txtBoxQuantite.Size = new System.Drawing.Size(144, 20);
            this.txtBoxQuantite.TabIndex = 52;
            // 
            // txtboxTitre
            // 
            this.txtboxTitre.Location = new System.Drawing.Point(634, 83);
            this.txtboxTitre.Name = "txtboxTitre";
            this.txtboxTitre.Size = new System.Drawing.Size(144, 20);
            this.txtboxTitre.TabIndex = 51;
            // 
            // comboBoxArticle
            // 
            this.comboBoxArticle.FormattingEnabled = true;
            this.comboBoxArticle.Items.AddRange(new object[] {
            "Livre",
            "Film"});
            this.comboBoxArticle.Location = new System.Drawing.Point(567, 50);
            this.comboBoxArticle.Name = "comboBoxArticle";
            this.comboBoxArticle.Size = new System.Drawing.Size(144, 21);
            this.comboBoxArticle.TabIndex = 50;
            this.comboBoxArticle.Text = "Type d\'article";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(515, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Nombre de page";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(515, 86);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(28, 13);
            this.lblTitre.TabIndex = 48;
            this.lblTitre.Text = "Titre";
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Location = new System.Drawing.Point(515, 113);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(47, 13);
            this.lblQuantite.TabIndex = 47;
            this.lblQuantite.Text = "Quantité";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnModifArticle);
            this.groupBox2.Controls.Add(this.btnEmprunter);
            this.groupBox2.Controls.Add(this.btnAjoutArticle);
            this.groupBox2.Controls.Add(this.btnSupArticle);
            this.groupBox2.Location = new System.Drawing.Point(489, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 88);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Article";
            // 
            // btnModifArticle
            // 
            this.btnModifArticle.Location = new System.Drawing.Point(35, 50);
            this.btnModifArticle.Name = "btnModifArticle";
            this.btnModifArticle.Size = new System.Drawing.Size(115, 23);
            this.btnModifArticle.TabIndex = 6;
            this.btnModifArticle.Text = "Modifier article";
            this.btnModifArticle.UseVisualStyleBackColor = true;
            this.btnModifArticle.Click += new System.EventHandler(this.btnModifArticle_Click);
            // 
            // btnEmprunter
            // 
            this.btnEmprunter.Location = new System.Drawing.Point(35, 21);
            this.btnEmprunter.Name = "btnEmprunter";
            this.btnEmprunter.Size = new System.Drawing.Size(115, 23);
            this.btnEmprunter.TabIndex = 0;
            this.btnEmprunter.Text = "Emprunter";
            this.btnEmprunter.UseVisualStyleBackColor = true;
            this.btnEmprunter.Click += new System.EventHandler(this.btnEmprunter_Click);
            // 
            // btnAjoutArticle
            // 
            this.btnAjoutArticle.Location = new System.Drawing.Point(179, 19);
            this.btnAjoutArticle.Name = "btnAjoutArticle";
            this.btnAjoutArticle.Size = new System.Drawing.Size(115, 23);
            this.btnAjoutArticle.TabIndex = 8;
            this.btnAjoutArticle.Text = "Ajouter article";
            this.btnAjoutArticle.UseVisualStyleBackColor = true;
            this.btnAjoutArticle.Click += new System.EventHandler(this.btnAjoutArticle_Click);
            // 
            // btnSupArticle
            // 
            this.btnSupArticle.Location = new System.Drawing.Point(179, 48);
            this.btnSupArticle.Name = "btnSupArticle";
            this.btnSupArticle.Size = new System.Drawing.Size(115, 23);
            this.btnSupArticle.TabIndex = 7;
            this.btnSupArticle.Text = "Supprimer article";
            this.btnSupArticle.UseVisualStyleBackColor = true;
            this.btnSupArticle.Click += new System.EventHandler(this.btnSupArticle_Click);
            // 
            // lblErreurCb
            // 
            this.lblErreurCb.AutoSize = true;
            this.lblErreurCb.Location = new System.Drawing.Point(352, 208);
            this.lblErreurCb.Name = "lblErreurCb";
            this.lblErreurCb.Size = new System.Drawing.Size(0, 13);
            this.lblErreurCb.TabIndex = 46;
            // 
            // lblErreurNoIdentifFilm
            // 
            this.lblErreurNoIdentifFilm.AutoSize = true;
            this.lblErreurNoIdentifFilm.Location = new System.Drawing.Point(352, 172);
            this.lblErreurNoIdentifFilm.Name = "lblErreurNoIdentifFilm";
            this.lblErreurNoIdentifFilm.Size = new System.Drawing.Size(0, 13);
            this.lblErreurNoIdentifFilm.TabIndex = 45;
            // 
            // lblErreurNoTelPages
            // 
            this.lblErreurNoTelPages.AutoSize = true;
            this.lblErreurNoTelPages.Location = new System.Drawing.Point(352, 141);
            this.lblErreurNoTelPages.Name = "lblErreurNoTelPages";
            this.lblErreurNoTelPages.Size = new System.Drawing.Size(0, 13);
            this.lblErreurNoTelPages.TabIndex = 44;
            // 
            // lblErreurCourrielQuantite
            // 
            this.lblErreurCourrielQuantite.AutoSize = true;
            this.lblErreurCourrielQuantite.Location = new System.Drawing.Point(352, 110);
            this.lblErreurCourrielQuantite.Name = "lblErreurCourrielQuantite";
            this.lblErreurCourrielQuantite.Size = new System.Drawing.Size(0, 13);
            this.lblErreurCourrielQuantite.TabIndex = 43;
            // 
            // lblErreurNomTitre
            // 
            this.lblErreurNomTitre.AutoSize = true;
            this.lblErreurNomTitre.Location = new System.Drawing.Point(352, 76);
            this.lblErreurNomTitre.Name = "lblErreurNomTitre";
            this.lblErreurNomTitre.Size = new System.Drawing.Size(0, 13);
            this.lblErreurNomTitre.TabIndex = 42;
            // 
            // lblErreurPrenom
            // 
            this.lblErreurPrenom.AutoSize = true;
            this.lblErreurPrenom.Location = new System.Drawing.Point(352, 50);
            this.lblErreurPrenom.Name = "lblErreurPrenom";
            this.lblErreurPrenom.Size = new System.Drawing.Size(0, 13);
            this.lblErreurPrenom.TabIndex = 41;
            // 
            // comboBoxUsager
            // 
            this.comboBoxUsager.FormattingEnabled = true;
            this.comboBoxUsager.Items.AddRange(new object[] {
            "Client",
            "Responsable"});
            this.comboBoxUsager.Location = new System.Drawing.Point(99, 205);
            this.comboBoxUsager.Name = "comboBoxUsager";
            this.comboBoxUsager.Size = new System.Drawing.Size(144, 21);
            this.comboBoxUsager.TabIndex = 40;
            this.comboBoxUsager.Text = "Type d\'usager";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAjoutClient);
            this.groupBox1.Controls.Add(this.btnSupClient);
            this.groupBox1.Controls.Add(this.btnModifClient);
            this.groupBox1.Location = new System.Drawing.Point(30, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 90);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client";
            // 
            // btnAjoutClient
            // 
            this.btnAjoutClient.Location = new System.Drawing.Point(171, 21);
            this.btnAjoutClient.Name = "btnAjoutClient";
            this.btnAjoutClient.Size = new System.Drawing.Size(115, 23);
            this.btnAjoutClient.TabIndex = 5;
            this.btnAjoutClient.Text = "Ajouter client";
            this.btnAjoutClient.UseVisualStyleBackColor = true;
            this.btnAjoutClient.Click += new System.EventHandler(this.btnAjoutClient_Click);
            // 
            // btnSupClient
            // 
            this.btnSupClient.Location = new System.Drawing.Point(100, 50);
            this.btnSupClient.Name = "btnSupClient";
            this.btnSupClient.Size = new System.Drawing.Size(115, 23);
            this.btnSupClient.TabIndex = 4;
            this.btnSupClient.Text = "Supprimer client";
            this.btnSupClient.UseVisualStyleBackColor = true;
            this.btnSupClient.Click += new System.EventHandler(this.btnSupClient_Click);
            // 
            // btnModifClient
            // 
            this.btnModifClient.Location = new System.Drawing.Point(23, 21);
            this.btnModifClient.Name = "btnModifClient";
            this.btnModifClient.Size = new System.Drawing.Size(115, 23);
            this.btnModifClient.TabIndex = 2;
            this.btnModifClient.Text = "Modifier client";
            this.btnModifClient.UseVisualStyleBackColor = true;
            this.btnModifClient.Click += new System.EventHandler(this.btnModifClient_Click);
            // 
            // txtboxNom
            // 
            this.txtboxNom.Location = new System.Drawing.Point(189, 76);
            this.txtboxNom.Name = "txtboxNom";
            this.txtboxNom.Size = new System.Drawing.Size(144, 20);
            this.txtboxNom.TabIndex = 37;
            // 
            // txtboxCourriel
            // 
            this.txtboxCourriel.Location = new System.Drawing.Point(189, 110);
            this.txtboxCourriel.Name = "txtboxCourriel";
            this.txtboxCourriel.Size = new System.Drawing.Size(144, 20);
            this.txtboxCourriel.TabIndex = 36;
            this.txtboxCourriel.Text = "XXXXX@XXXXX.XXX";
            // 
            // txtboxNoTelephone
            // 
            this.txtboxNoTelephone.Location = new System.Drawing.Point(189, 141);
            this.txtboxNoTelephone.Name = "txtboxNoTelephone";
            this.txtboxNoTelephone.Size = new System.Drawing.Size(144, 20);
            this.txtboxNoTelephone.TabIndex = 35;
            this.txtboxNoTelephone.Text = "(XXX) XXX-XXXX";
            // 
            // txtNoIdentification
            // 
            this.txtNoIdentification.Location = new System.Drawing.Point(189, 169);
            this.txtNoIdentification.Name = "txtNoIdentification";
            this.txtNoIdentification.Size = new System.Drawing.Size(144, 20);
            this.txtNoIdentification.TabIndex = 34;
            this.txtNoIdentification.Text = "XXXXX";
            // 
            // txtboxPrenom
            // 
            this.txtboxPrenom.Location = new System.Drawing.Point(189, 50);
            this.txtboxPrenom.Name = "txtboxPrenom";
            this.txtboxPrenom.Size = new System.Drawing.Size(144, 20);
            this.txtboxPrenom.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Adresse courriel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Numéro d\'identification";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Numéro de téléphone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nom";
            // 
            // FormIdentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 438);
            this.Controls.Add(this.txtDuree);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBoxPages);
            this.Controls.Add(this.txtBoxQuantite);
            this.Controls.Add(this.txtboxTitre);
            this.Controls.Add(this.comboBoxArticle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblQuantite);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblErreurCb);
            this.Controls.Add(this.lblErreurNoIdentifFilm);
            this.Controls.Add(this.lblErreurNoTelPages);
            this.Controls.Add(this.lblErreurCourrielQuantite);
            this.Controls.Add(this.lblErreurNomTitre);
            this.Controls.Add(this.lblErreurPrenom);
            this.Controls.Add(this.comboBoxUsager);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtboxNom);
            this.Controls.Add(this.txtboxCourriel);
            this.Controls.Add(this.txtboxNoTelephone);
            this.Controls.Add(this.txtNoIdentification);
            this.Controls.Add(this.txtboxPrenom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormIdentification";
            this.Text = "Identification";
            this.Load += new System.EventHandler(this.FormIdentification_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDuree;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxPages;
        private System.Windows.Forms.TextBox txtBoxQuantite;
        private System.Windows.Forms.TextBox txtboxTitre;
        private System.Windows.Forms.ComboBox comboBoxArticle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnModifArticle;
        private System.Windows.Forms.Button btnEmprunter;
        private System.Windows.Forms.Button btnAjoutArticle;
        private System.Windows.Forms.Button btnSupArticle;
        private System.Windows.Forms.Label lblErreurCb;
        private System.Windows.Forms.Label lblErreurNoIdentifFilm;
        private System.Windows.Forms.Label lblErreurNoTelPages;
        private System.Windows.Forms.Label lblErreurCourrielQuantite;
        private System.Windows.Forms.Label lblErreurNomTitre;
        private System.Windows.Forms.Label lblErreurPrenom;
        private System.Windows.Forms.ComboBox comboBoxUsager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAjoutClient;
        private System.Windows.Forms.Button btnSupClient;
        private System.Windows.Forms.Button btnModifClient;
        private System.Windows.Forms.TextBox txtboxNom;
        private System.Windows.Forms.TextBox txtboxCourriel;
        private System.Windows.Forms.TextBox txtboxNoTelephone;
        private System.Windows.Forms.TextBox txtNoIdentification;
        private System.Windows.Forms.TextBox txtboxPrenom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}