using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TuneStore
{
    public partial class Form1 : Form
    {
        #region variabelen
        //om een bestand op te halen gebruik voor het pad naar het bestand:streamreader/writer naam = new streamreader/writer(playlistfolder+"rest van het pad");
        string playlistfolder;

        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            readConfig();
        }
        private void readConfig()
        {
            string[] config = System.IO.File.ReadAllLines(@"C:\Users\Luc\Documents\GitHub\tunestore\tunestore\tunestore\resources\config.txt");
            playlistfolder = config[0];
        }
    }
}
