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
            this.btnEmprunter = new System.Windows.Forms.Button();
            this.comboBoxUsager = new System.Windows.Forms.ComboBox();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.lblErreurPrenom = new System.Windows.Forms.Label();
            this.lblErreurNom = new System.Windows.Forms.Label();
            this.lblErreurCourriel = new System.Windows.Forms.Label();
            this.lblErreurNoTel = new System.Windows.Forms.Label();
            this.lblErreurNoIdentification = new System.Windows.Forms.Label();
            this.lblErreurCb = new System.Windows.Forms.Label();
            this.btnModifArticle = new System.Windows.Forms.Button();
            this.btnSupArticle = new System.Windows.Forms.Button();
            this.btnAjoutArticle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numéro de téléphone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numéro d\'identification";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adresse courriel";
            // 
            // txtboxPrenom
            // 
            this.txtboxPrenom.Location = new System.Drawing.Point(227, 44);
            this.txtboxPrenom.Name = "txtboxPrenom";
            this.txtboxPrenom.Size = new System.Drawing.Size(144, 20);
            this.txtboxPrenom.TabIndex = 5;
            this.txtboxPrenom.TextChanged += new System.EventHandler(this.txtboxPrenom_TextChanged);
            // 
            // txtNoIdentification
            // 
            this.txtNoIdentification.Location = new System.Drawing.Point(227, 163);
            this.txtNoIdentification.Name = "txtNoIdentification";
            this.txtNoIdentification.Size = new System.Drawing.Size(144, 20);
            this.txtNoIdentification.TabIndex = 6;
            this.txtNoIdentification.Text = "XXXXX";
            // 
            // txtboxNoTelephone
            // 
            this.txtboxNoTelephone.Location = new System.Drawing.Point(227, 135);
            this.txtboxNoTelephone.Name = "txtboxNoTelephone";
            this.txtboxNoTelephone.Size = new System.Drawing.Size(144, 20);
            this.txtboxNoTelephone.TabIndex = 7;
            this.txtboxNoTelephone.Text = "(XXX) XXX-XXXX";
            // 
            // txtboxCourriel
            // 
            this.txtboxCourriel.Location = new System.Drawing.Point(227, 104);
            this.txtboxCourriel.Name = "txtboxCourriel";
            this.txtboxCourriel.Size = new System.Drawing.Size(144, 20);
            this.txtboxCourriel.TabIndex = 8;
            this.txtboxCourriel.Text = "XXXXX@XXXXX.XXX";
            // 
            // txtboxNom
            // 
            this.txtboxNom.Location = new System.Drawing.Point(227, 70);
            this.txtboxNom.Name = "txtboxNom";
            this.txtboxNom.Size = new System.Drawing.Size(144, 20);
            this.txtboxNom.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAjoutArticle);
            this.groupBox1.Controls.Add(this.btnSupArticle);
            this.groupBox1.Controls.Add(this.btnModifArticle);
            this.groupBox1.Controls.Add(this.btnAjoutClient);
            this.groupBox1.Controls.Add(this.btnSupClient);
            this.groupBox1.Controls.Add(this.btnModifClient);
            this.groupBox1.Controls.Add(this.btnEmprunter);
            this.groupBox1.Location = new System.Drawing.Point(39, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 103);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            // 
            // btnAjoutClient
            // 
            this.btnAjoutClient.Location = new System.Drawing.Point(188, 62);
            this.btnAjoutClient.Name = "btnAjoutClient";
            this.btnAjoutClient.Size = new System.Drawing.Size(115, 23);
            this.btnAjoutClient.TabIndex = 5;
            this.btnAjoutClient.Text = "Ajouter client";
            this.btnAjoutClient.UseVisualStyleBackColor = true;
            this.btnAjoutClient.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupClient
            // 
            this.btnSupClient.Location = new System.Drawing.Point(393, 62);
            this.btnSupClient.Name = "btnSupClient";
            this.btnSupClient.Size = new System.Drawing.Size(115, 23);
            this.btnSupClient.TabIndex = 4;
            this.btnSupClient.Text = "Supprimer client";
            this.btnSupClient.UseVisualStyleBackColor = true;
            this.btnSupClient.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifClient
            // 
            this.btnModifClient.Location = new System.Drawing.Point(6, 62);
            this.btnModifClient.Name = "btnModifClient";
            this.btnModifClient.Size = new System.Drawing.Size(115, 23);
            this.btnModifClient.TabIndex = 2;
            this.btnModifClient.Text = "Modifier client";
            this.btnModifClient.UseVisualStyleBackColor = true;
            this.btnModifClient.Click += new System.EventHandler(this.btnModifArticle_Click);
            // 
            // btnEmprunter
            // 
            this.btnEmprunter.Location = new System.Drawing.Point(6, 19);
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
            this.comboBoxUsager.Location = new System.Drawing.Point(137, 199);
            this.comboBoxUsager.Name = "comboBoxUsager";
            this.comboBoxUsager.Size = new System.Drawing.Size(144, 21);
            this.comboBoxUsager.TabIndex = 11;
            this.comboBoxUsager.Text = "Type d\'usager";
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(163, 236);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmer.TabIndex = 12;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // lblErreurPrenom
            // 
            this.lblErreurPrenom.AutoSize = true;
            this.lblErreurPrenom.Location = new System.Drawing.Point(390, 44);
            this.lblErreurPrenom.Name = "lblErreurPrenom";
            this.lblErreurPrenom.Size = new System.Drawing.Size(0, 13);
            this.lblErreurPrenom.TabIndex = 13;
            // 
            // lblErreurNom
            // 
            this.lblErreurNom.AutoSize = true;
            this.lblErreurNom.Location = new System.Drawing.Point(390, 70);
            this.lblErreurNom.Name = "lblErreurNom";
            this.lblErreurNom.Size = new System.Drawing.Size(0, 13);
            this.lblErreurNom.TabIndex = 14;
            // 
            // lblErreurCourriel
            // 
            this.lblErreurCourriel.AutoSize = true;
            this.lblErreurCourriel.Location = new System.Drawing.Point(390, 104);
            this.lblErreurCourriel.Name = "lblErreurCourriel";
            this.lblErreurCourriel.Size = new System.Drawing.Size(0, 13);
            this.lblErreurCourriel.TabIndex = 15;
            // 
            // lblErreurNoTel
            // 
            this.lblErreurNoTel.AutoSize = true;
            this.lblErreurNoTel.Location = new System.Drawing.Point(390, 135);
            this.lblErreurNoTel.Name = "lblErreurNoTel";
            this.lblErreurNoTel.Size = new System.Drawing.Size(0, 13);
            this.lblErreurNoTel.TabIndex = 16;
            // 
            // lblErreurNoIdentification
            // 
            this.lblErreurNoIdentification.AutoSize = true;
            this.lblErreurNoIdentification.Location = new System.Drawing.Point(390, 166);
            this.lblErreurNoIdentification.Name = "lblErreurNoIdentification";
            this.lblErreurNoIdentification.Size = new System.Drawing.Size(0, 13);
            this.lblErreurNoIdentification.TabIndex = 17;
            // 
            // lblErreurCb
            // 
            this.lblErreurCb.AutoSize = true;
            this.lblErreurCb.Location = new System.Drawing.Point(390, 202);
            this.lblErreurCb.Name = "lblErreurCb";
            this.lblErreurCb.Size = new System.Drawing.Size(0, 13);
            this.lblErreurCb.TabIndex = 18;
            // 
            // btnModifArticle
            // 
            this.btnModifArticle.Location = new System.Drawing.Point(133, 19);
            this.btnModifArticle.Name = "btnModifArticle";
            this.btnModifArticle.Size = new System.Drawing.Size(115, 23);
            this.btnModifArticle.TabIndex = 6;
            this.btnModifArticle.Text = "Modifier article";
            this.btnModifArticle.UseVisualStyleBackColor = true;
            this.btnModifArticle.Click += new System.EventHandler(this.btnModifierArticle_Click);
            // 
            // btnSupArticle
            // 
            this.btnSupArticle.Location = new System.Drawing.Point(393, 19);
            this.btnSupArticle.Name = "btnSupArticle";
            this.btnSupArticle.Size = new System.Drawing.Size(115, 23);
            this.btnSupArticle.TabIndex = 7;
            this.btnSupArticle.Text = "Supprimer article";
            this.btnSupArticle.UseVisualStyleBackColor = true;
            this.btnSupArticle.Click += new System.EventHandler(this.btnSupArticle_Click);
            // 
            // btnAjoutArticle
            // 
            this.btnAjoutArticle.Location = new System.Drawing.Point(262, 19);
            this.btnAjoutArticle.Name = "btnAjoutArticle";
            this.btnAjoutArticle.Size = new System.Drawing.Size(115, 23);
            this.btnAjoutArticle.TabIndex = 8;
            this.btnAjoutArticle.Text = "Ajouter article";
            this.btnAjoutArticle.UseVisualStyleBackColor = true;
            this.btnAjoutArticle.Click += new System.EventHandler(this.btnAjoutArticle_Click);
            // 
            // FormIdentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 438);
            this.Controls.Add(this.lblErreurCb);
            this.Controls.Add(this.lblErreurNoIdentification);
            this.Controls.Add(this.lblErreurNoTel);
            this.Controls.Add(this.lblErreurCourriel);
            this.Controls.Add(this.lblErreurNom);
            this.Controls.Add(this.lblErreurPrenom);
            this.Controls.Add(this.btnConfirmer);
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
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Label lblErreurPrenom;
        private System.Windows.Forms.Label lblErreurNom;
        private System.Windows.Forms.Label lblErreurCourriel;
        private System.Windows.Forms.Label lblErreurNoTel;
        private System.Windows.Forms.Label lblErreurNoIdentification;
        private System.Windows.Forms.Label lblErreurCb;
        private System.Windows.Forms.Button btnAjoutClient;
        private System.Windows.Forms.Button btnSupClient;
        private System.Windows.Forms.Button btnSupArticle;
        private System.Windows.Forms.Button btnModifArticle;
        private System.Windows.Forms.Button btnAjoutArticle;
    }
}