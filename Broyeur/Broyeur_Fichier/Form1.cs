using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Broyeur_Fichier
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void grpBroyeur_Enter(object sender, EventArgs e)
        {

        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            txtPath.Text = @"C:\Res\Biblio\CSharp\Broyeur\Broyeur_Fichier\bin\Debug";
        }
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All files (*.*)|*.*|Txt files (*.txt)|*.txt";
            ofd.ShowDialog();
            txtPath.Text = ofd.FileName;
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All files (*.*)|*.*|Txt files (*.txt)|*.txt";
            ofd.ShowDialog();
            txtPath.Text = ofd.FileName;
        }
        private bool TableauByteVersFichierr(string nomFichier, byte[] tableauByte)
        {
            try
            {
                FileStream fs = new FileStream(nomFichier, FileMode.Create, FileAccess.Write);
                fs.Write(tableauByte, 0, tableauByte.Length);
                fs.Flush();
                fs.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            return false;
        }
        private void btnBroyer_Click(object sender, EventArgs e)
        {
            if (txtPath.Text== string.Empty)
            {
                MessageBox.Show("No path");
            }
            else
            {
                FileInfo file1 = new FileInfo(txtPath.Text);
                long fileLength = file1.Length;
                string fileExtension = file1.Extension;
                char[] lettre = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'x', 'y', 'z' };
                byte[] data = new byte[fileLength];
                for (int j = 0; j < lettre.Length; j++)
                {
                    for (int i = 0; i < fileLength; i++)
                    {
                        data[i] = (byte)lettre[j];
                    }
                    bool resultat;
                    resultat = TableauByteVersFichierr(txtPath.Text, data);
                }
                MessageBox.Show($"Ecriture terminée");
                file1.Delete();
                MessageBox.Show($"Fichier supprimé");
                txtPath.Text = @" ";
            }


        }

        private void rétablirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileInfo file1 = new FileInfo(txtPath.Text);
            long fileLength = file1.Length;
            string fileExtension = file1.Extension;
            char[] lettre = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'x', 'y', 'z' };
            byte[] data = new byte[fileLength];
            for (int j = 0; j < lettre.Length; j++)
            {
                for (int i = 0; i < fileLength; i++)
                {
                    data[i] = (byte)lettre[j];
                }
                bool resultat;
                resultat = TableauByteVersFichierr(txtPath.Text, data);
            }
            file1.Delete();
            MessageBox.Show($"Fichier supprimé");
        }

        private void annulerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileInfo file1 = new FileInfo(txtPath.Text);
            long fileLength = file1.Length;
            string fileExtension = file1.Extension;
            char[] lettre = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'x', 'y', 'z' };
            byte[] data = new byte[fileLength];
            for (int j = 0; j < lettre.Length; j++)
            {
                for (int i = 0; i < fileLength; i++)
                {
                    data[i] = (byte)lettre[j];
                }
                bool resultat;
                resultat = TableauByteVersFichierr(txtPath.Text, data);
            }
            MessageBox.Show($"Ecriture terminée");
        }
    }
}
