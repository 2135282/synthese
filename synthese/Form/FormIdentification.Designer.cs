using System;

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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxPrenom = new System.Windows.Forms.TextBox();
            this.txtNoIdentification = new System.Windows.Forms.TextBox();
            this.txtboxNoTelephone = new System.Windows.Forms.TextBox();
            this.txtboxCourriel = new System.Windows.Forms.TextBox();
            this.txtboxNom = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAjoutClient = new System.Windows.Forms.Button();
            this.btnSupClient = new System.Windows.Forms.Button();
            this.btnModifClient = new System.Windows.Forms.Button();
            this.btnAjoutArticle = new System.Windows.Forms.Button();
            this.btnSupArticle = new System.Windows.Forms.Button();
            this.btnModifArticle = new System.Windows.Forms.Button();
            this.btnEmprunter = new System.Windows.Forms.Button();
            this.comboBoxUsager = new System.Windows.Forms.ComboBox();
            this.lblErreurPrenom = new System.Windows.Forms.Label();
            this.lblErreurNomTitre = new System.Windows.Forms.Label();
            this.lblErreurCourrielQuantite = new System.Windows.Forms.Label();
            this.lblErreurNoTelPages = new System.Windows.Forms.Label();
            this.lblErreurNoIdentifFilm = new System.Windows.Forms.Label();
            this.lblErreurCb = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxArticle = new System.Windows.Forms.ComboBox();
            this.txtboxTitre = new System.Windows.Forms.TextBox();
            this.txtBoxQuantite = new System.Windows.Forms.TextBox();
            this.txtBoxPages = new System.Windows.Forms.TextBox();
            this.txtDuree = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numéro de téléphone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numéro d\'identification";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adresse courriel";
            // 
            // txtboxPrenom
            // 
            this.txtboxPrenom.Location = new System.Drawing.Point(193, 33);
            this.txtboxPrenom.Name = "txtboxPrenom";
            this.txtboxPrenom.Size = new System.Drawing.Size(144, 20);
            this.txtboxPrenom.TabIndex = 5;
            this.txtboxPrenom.TextChanged += new System.EventHandler(this.txtboxPrenom_TextChanged);
            // 
            // txtNoIdentification
            // 
            this.txtNoIdentification.Location = new System.Drawing.Point(193, 152);
            this.txtNoIdentification.Name = "txtNoIdentification";
            this.txtNoIdentification.Size = new System.Drawing.Size(144, 20);
            this.txtNoIdentification.TabIndex = 6;
            this.txtNoIdentification.Text = "XXXXX";
            // 
            // txtboxNoTelephone
            // 
            this.txtboxNoTelephone.Location = new System.Drawing.Point(193, 124);
            this.txtboxNoTelephone.Name = "txtboxNoTelephone";
            this.txtboxNoTelephone.Size = new System.Drawing.Size(144, 20);
            this.txtboxNoTelephone.TabIndex = 7;
            this.txtboxNoTelephone.Text = "(XXX) XXX-XXXX";
            // 
            // txtboxCourriel
            // 
            this.txtboxCourriel.Location = new System.Drawing.Point(193, 93);
            this.txtboxCourriel.Name = "txtboxCourriel";
            this.txtboxCourriel.Size = new System.Drawing.Size(144, 20);
            this.txtboxCourriel.TabIndex = 8;
            this.txtboxCourriel.Text = "XXXXX@XXXXX.XXX";
            // 
            // txtboxNom
            // 
            this.txtboxNom.Location = new System.Drawing.Point(193, 59);
            this.txtboxNom.Name = "txtboxNom";
            this.txtboxNom.Size = new System.Drawing.Size(144, 20);
            this.txtboxNom.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAjoutClient);
            this.groupBox1.Controls.Add(this.btnSupClient);
            this.groupBox1.Controls.Add(this.btnModifClient);
            this.groupBox1.Location = new System.Drawing.Point(34, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 90);
            this.groupBox1.TabIndex = 10;
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
            this.btnAjoutClient.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupClient
            // 
            this.btnSupClient.Location = new System.Drawing.Point(100, 50);
            this.btnSupClient.Name = "btnSupClient";
            this.btnSupClient.Size = new System.Drawing.Size(115, 23);
            this.btnSupClient.TabIndex = 4;
            this.btnSupClient.Text = "Supprimer client";
            this.btnSupClient.UseVisualStyleBackColor = true;
            this.btnSupClient.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifClient
            // 
            this.btnModifClient.Location = new System.Drawing.Point(23, 21);
            this.btnModifClient.Name = "btnModifClient";
            this.btnModifClient.Size = new System.Drawing.Size(115, 23);
            this.btnModifClient.TabIndex = 2;
            this.btnModifClient.Text = "Modifier client";
            this.btnModifClient.UseVisualStyleBackColor = true;
            this.btnModifClient.Click += new System.EventHandler(this.btnModifArticle_Click);
            // 
            // btnAjoutArticle
            // 
            this.btnAjoutArticle.Location = new System.Drawing.Point(179, 19);
            this.btnAjoutArticle.Name = "btnAjoutArticle";
            this.btnAjoutArticle.Size = new System.Drawing.Size(115, 23);
            this.btnAjoutArticle.TabIndex = 8;
            this.btnAjoutArticle.Text = "Ajouter article";
            this.btnAjoutArticle.UseVisualStyleBackColor = true;
            this.btnAjoutArticle.Click += new System.EventHandler(this.btnAjoutArticle_Click_1);
            // 
            // btnSupArticle
            // 
            this.btnSupArticle.Location = new System.Drawing.Point(179, 48);
            this.btnSupArticle.Name = "btnSupArticle";
            this.btnSupArticle.Size = new System.Drawing.Size(115, 23);
            this.btnSupArticle.TabIndex = 7;
            this.btnSupArticle.Text = "Supprimer article";
            this.btnSupArticle.UseVisualStyleBackColor = true;
            this.btnSupArticle.Click += new System.EventHandler(this.btnSupArticle_Click_1);
            // 
            // btnModifArticle
            // 
            this.btnModifArticle.Location = new System.Drawing.Point(35, 50);
            this.btnModifArticle.Name = "btnModifArticle";
            this.btnModifArticle.Size = new System.Drawing.Size(115, 23);
            this.btnModifArticle.TabIndex = 6;
            this.btnModifArticle.Text = "Modifier article";
            this.btnModifArticle.UseVisualStyleBackColor = true;
            this.btnModifArticle.Click += new System.EventHandler(this.btnModifArticle_Click_1);
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
            // comboBoxUsager
            // 
            this.comboBoxUsager.FormattingEnabled = true;
            this.comboBoxUsager.Items.AddRange(new object[] {
            "Client",
            "Responsable"});
            this.comboBoxUsager.Location = new System.Drawing.Point(103, 188);
            this.comboBoxUsager.Name = "comboBoxUsager";
            this.comboBoxUsager.Size = new System.Drawing.Size(144, 21);
            this.comboBoxUsager.TabIndex = 11;
            this.comboBoxUsager.Text = "Type d\'usager";
            // 
            // lblErreurPrenom
            // 
            this.lblErreurPrenom.AutoSize = true;
            this.lblErreurPrenom.Location = new System.Drawing.Point(356, 33);
            this.lblErreurPrenom.Name = "lblErreurPrenom";
            this.lblErreurPrenom.Size = new System.Drawing.Size(0, 13);
            this.lblErreurPrenom.TabIndex = 13;
            // 
            // lblErreurNomTitre
            // 
            this.lblErreurNomTitre.AutoSize = true;
            this.lblErreurNomTitre.Location = new System.Drawing.Point(356, 59);
            this.lblErreurNomTitre.Name = "lblErreurNomTitre";
            this.lblErreurNomTitre.Size = new System.Drawing.Size(0, 13);
            this.lblErreurNomTitre.TabIndex = 14;
            // 
            // lblErreurCourrielQuantite
            // 
            this.lblErreurCourrielQuantite.AutoSize = true;
            this.lblErreurCourrielQuantite.Location = new System.Drawing.Point(356, 93);
            this.lblErreurCourrielQuantite.Name = "lblErreurCourrielQuantite";
            this.lblErreurCourrielQuantite.Size = new System.Drawing.Size(0, 13);
            this.lblErreurCourrielQuantite.TabIndex = 15;
            // 
            // lblErreurNoTelPages
            // 
            this.lblErreurNoTelPages.AutoSize = true;
            this.lblErreurNoTelPages.Location = new System.Drawing.Point(356, 124);
            this.lblErreurNoTelPages.Name = "lblErreurNoTelPages";
            this.lblErreurNoTelPages.Size = new System.Drawing.Size(0, 13);
            this.lblErreurNoTelPages.TabIndex = 16;
            // 
            // lblErreurNoIdentifFilm
            // 
            this.lblErreurNoIdentifFilm.AutoSize = true;
            this.lblErreurNoIdentifFilm.Location = new System.Drawing.Point(356, 155);
            this.lblErreurNoIdentifFilm.Name = "lblErreurNoIdentifFilm";
            this.lblErreurNoIdentifFilm.Size = new System.Drawing.Size(0, 13);
            this.lblErreurNoIdentifFilm.TabIndex = 17;
            // 
            // lblErreurCb
            // 
            this.lblErreurCb.AutoSize = true;
            this.lblErreurCb.Location = new System.Drawing.Point(356, 191);
            this.lblErreurCb.Name = "lblErreurCb";
            this.lblErreurCb.Size = new System.Drawing.Size(0, 13);
            this.lblErreurCb.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnModifArticle);
            this.groupBox2.Controls.Add(this.btnEmprunter);
            this.groupBox2.Controls.Add(this.btnAjoutArticle);
            this.groupBox2.Controls.Add(this.btnSupArticle);
            this.groupBox2.Location = new System.Drawing.Point(493, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 88);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Article";
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Location = new System.Drawing.Point(519, 96);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(47, 13);
            this.lblQuantite.TabIndex = 19;
            this.lblQuantite.Text = "Quantité";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(519, 69);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(28, 13);
            this.lblTitre.TabIndex = 20;
            this.lblTitre.Text = "Titre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(519, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Nombre de page";
            // 
            // comboBoxArticle
            // 
            this.comboBoxArticle.FormattingEnabled = true;
            this.comboBoxArticle.Items.AddRange(new object[] {
            "Livre",
            "Film"});
            this.comboBoxArticle.Location = new System.Drawing.Point(571, 33);
            this.comboBoxArticle.Name = "comboBoxArticle";
            this.comboBoxArticle.Size = new System.Drawing.Size(144, 21);
            this.comboBoxArticle.TabIndex = 22;
            this.comboBoxArticle.Text = "Type d\'article";
            // 
            // txtboxTitre
            // 
            this.txtboxTitre.Location = new System.Drawing.Point(638, 66);
            this.txtboxTitre.Name = "txtboxTitre";
            this.txtboxTitre.Size = new System.Drawing.Size(144, 20);
            this.txtboxTitre.TabIndex = 23;
            // 
            // txtBoxQuantite
            // 
            this.txtBoxQuantite.Location = new System.Drawing.Point(638, 93);
            this.txtBoxQuantite.Name = "txtBoxQuantite";
            this.txtBoxQuantite.Size = new System.Drawing.Size(144, 20);
            this.txtBoxQuantite.TabIndex = 24;
            // 
            // txtBoxPages
            // 
            this.txtBoxPages.Location = new System.Drawing.Point(638, 124);
            this.txtBoxPages.Name = "txtBoxPages";
            this.txtBoxPages.Size = new System.Drawing.Size(144, 20);
            this.txtBoxPages.TabIndex = 25;
            // 
            // txtDuree
            // 
            this.txtDuree.Location = new System.Drawing.Point(638, 155);
            this.txtDuree.Name = "txtDuree";
            this.txtDuree.Size = new System.Drawing.Size(144, 20);
            this.txtDuree.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(519, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Durée du film";
            // 
            // FormIdentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 407);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtboxPrenom;
        private System.Windows.Forms.TextBox txtNoIdentification;
        private System.Windows.Forms.TextBox txtboxNoTelephone;
        private System.Windows.Forms.TextBox txtboxCourriel;
        private System.Windows.Forms.TextBox txtboxNom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnModifClient;
        private System.Windows.Forms.Button btnEmprunter;
        private System.Windows.Forms.ComboBox comboBoxUsager;
        private System.Windows.Forms.Label lblErreurPrenom;
        private System.Windows.Forms.Label lblErreurNomTitre;
        private System.Windows.Forms.Label lblErreurCourrielQuantite;
        private System.Windows.Forms.Label lblErreurNoTelPages;
        private System.Windows.Forms.Label lblErreurNoIdentifFilm;
        private System.Windows.Forms.Label lblErreurCb;
        private System.Windows.Forms.Button btnAjoutClient;
        private System.Windows.Forms.Button btnSupClient;
        private System.Windows.Forms.Button btnSupArticle;
        private System.Windows.Forms.Button btnModifArticle;
        private System.Windows.Forms.Button btnAjoutArticle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxArticle;
        private System.Windows.Forms.TextBox txtboxTitre;
        private System.Windows.Forms.TextBox txtBoxQuantite;
        private System.Windows.Forms.TextBox txtBoxPages;
        private System.Windows.Forms.TextBox txtDuree;
        private System.Windows.Forms.Label label7;
        private EventHandler btnConfirmer_Click;
        private EventHandler btnModifierArticle_Click;
        private EventHandler btnSupArticle_Click;
        private EventHandler btnAjoutArticle_Click;
        private EventHandler groupBox1_Enter;
    }
}