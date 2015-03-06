using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace tune_store_voorbeeld
{
    public partial class Form1 : Form
    {
        leden[] lid = new leden[100];
        int nummer = 0;
        int m_nummer;
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
            addobject();
            
            

        }

        private void addobject()
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

        public void btnShowLsie_Click(object sender, EventArgs e)
        {
            rtbOverzichtLsie.Clear();
            for (m_nummer = 0; m_nummer < nummer; m_nummer++ )
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofdSaveLsie.ShowDialog();

            StreamWriter saveinschrijving = new StreamWriter(ofdSaveLsie.FileName);
            for (m_nummer = 0; m_nummer < nummer; m_nummer++)
            {
                saveinschrijving.WriteLine(lid[m_nummer].naam);
                saveinschrijving.WriteLine(lid[m_nummer].adres);
                saveinschrijving.WriteLine(lid[m_nummer].woonPlaats);
            }
            saveinschrijving.Close();
            
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader loadinschrijvingen = new StreamReader(ofdLoadLsie.FileName);
            while(loadinschrijvingen.EndOfStream == false)
            {
                tbNaamLsie.Text = loadinschrijvingen.ReadLine();
                tbAddresLsie.Text = loadinschrijvingen.ReadLine();
                tbWoonplaatsLsie.Text = loadinschrijvingen.ReadLine();
                addobject();
                
                
            }
            loadinschrijvingen.Close();
            
        }


    }
}
