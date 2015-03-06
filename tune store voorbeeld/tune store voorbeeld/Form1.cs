using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace tune_store_voorbeeld
{
    public partial class Form1 : Form
    {
        leden[] lid = new leden[100];
        int nummer = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnToevoegenLsie_Click(object sender, EventArgs e)
        {
            lid[nummer] = new leden();
            lid[nummer].naam = tbNaamLsie.Text;
            lid[nummer].adres = tbAddresLsie.Text;
            lid[nummer].woonPlaats = tbWoonplaatsLsie.Text;
           

            nummer++;
            tbNaamLsie.Clear();
            tbAddresLsie.Clear();
            tbWoonplaatsLsie.Clear();
            

        }

        private void btnShowLsie_Click(object sender, EventArgs e)
        {
            rtbOverzichtLsie.Clear();
            for (int m_nummer = 0; m_nummer < nummer; m_nummer++ )
            {
                rtbOverzichtLsie.AppendText("naam:\t\t"+lid[m_nummer].naam+"\n");
                rtbOverzichtLsie.AppendText("adres:\t\t" + lid[m_nummer].adres + "\n");
                rtbOverzichtLsie.AppendText("woonplaats:\t" + lid[m_nummer].woonPlaats + "\n");
                rtbOverzichtLsie.AppendText("\n");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


    }
}
