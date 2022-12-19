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
            this.button1 = new System.Windows.Forms.Button();
            this.btnModifArticle = new System.Windows.Forms.Button();
            this.btnEmprunter = new System.Windows.Forms.Button();
            this.comboBoxUsager = new System.Windows.Forms.ComboBox();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.lblErreurPrenom = new System.Windows.Forms.Label();
            this.lblErreurNom = new System.Windows.Forms.Label();
            this.lblErreurCourriel = new System.Windows.Forms.Label();
            this.lblErreurNoTel = new System.Windows.Forms.Label();
            this.lblErreurNoIdentification = new System.Windows.Forms.Label();
            this.lblErreurCb = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
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
            this.groupBox1.Controls.Add(this.btnAjouter);
            this.groupBox1.Controls.Add(this.btnSupprimer);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnModifArticle);
            this.groupBox1.Controls.Add(this.btnEmprunter);
            this.groupBox1.Location = new System.Drawing.Point(39, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 103);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Rechercher client";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnModifArticle
            // 
            this.btnModifArticle.Location = new System.Drawing.Point(188, 62);
            this.btnModifArticle.Name = "btnModifArticle";
            this.btnModifArticle.Size = new System.Drawing.Size(115, 23);
            this.btnModifArticle.TabIndex = 2;
            this.btnModifArticle.Text = "Modifier client";
            this.btnModifArticle.UseVisualStyleBackColor = true;
            // 
            // btnEmprunter
            // 
            this.btnEmprunter.Location = new System.Drawing.Point(98, 19);
            this.btnEmprunter.Name = "btnEmprunter";
            this.btnEmprunter.Size = new System.Drawing.Size(115, 23);
            this.btnEmprunter.TabIndex = 0;
            this.btnEmprunter.Text = "Emprunter";
            this.btnEmprunter.UseVisualStyleBackColor = true;
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
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(354, 62);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(115, 23);
            this.btnSupprimer.TabIndex = 4;
            this.btnSupprimer.Text = "Supprimer client";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(6, 62);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(115, 23);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "Ajouter article";
            this.btnAjouter.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Button btnModifArticle;
        private System.Windows.Forms.Button btnEmprunter;
        private System.Windows.Forms.ComboBox comboBoxUsager;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Label lblErreurPrenom;
        private System.Windows.Forms.Label lblErreurNom;
        private System.Windows.Forms.Label lblErreurCourriel;
        private System.Windows.Forms.Label lblErreurNoTel;
        private System.Windows.Forms.Label lblErreurNoIdentification;
        private System.Windows.Forms.Label lblErreurCb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
    }
}