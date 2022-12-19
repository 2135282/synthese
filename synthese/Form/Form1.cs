using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace synthese
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void consulterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsulter fConsulter = new FormConsulter();     //Création d'une instance du formulaire enfant FormConsulter
            fConsulter.MdiParent = this;
            fConsulter.WindowState = FormWindowState.Normal;    // Mettre la taille du formulaire enfant fIdentification à normal
            fConsulter.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormIdentification fidentification = new FormIdentification();     //Création d'une instance du formulaire enfant FormIdentification
            fidentification.MdiParent = this;
            fidentification.WindowState = FormWindowState.Normal;    // Mettre la taille du formulaire enfant fIdentification à normal
            fidentification.Show();
        }
    }
}
