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

namespace Menu
{
    public partial class TextEditer : Form
    {
        public TextEditer()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog myOpen = new OpenFileDialog();
            StreamReader myLectura = null;

            myOpen.Filter = "Archivos de textos (.txt)|*.txt|Todos los archivos (*.*)| *.*";
            myOpen.Title = "Abrir archivo";
            myOpen.ShowDialog();
            myOpen.OpenFile();
            string rutaArchivo = myOpen.FileName;
            myLectura = File.OpenText(rutaArchivo);
            richTextBox1.Text = myLectura.ReadToEnd();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog mySave = new SaveFileDialog();
            StreamWriter myEscritura = null;

            mySave.Filter = "Archivos de textos (.txt)|*.txt|Todos los archivos (*.*)| *.*";
            mySave.Title = "Guardar como...";
            mySave.ShowDialog();
            string ruta = mySave.FileName;
            myEscritura = File.AppendText(ruta);
            myEscritura.Write(richTextBox1.Text);
            myEscritura.Flush();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu volver = new Menu();
            volver.Show();
        }

        private void adelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void deshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void borrarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void estiloDeFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog myFont = new FontDialog();
            myFont.Font = richTextBox1.Font;
            if (myFont.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font=myFont.Font;
            }

        }

        private void TextEditer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void colorDeFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog myColor = new ColorDialog();
            if (myColor.ShowDialog() == DialogResult.OK);
            {
                richTextBox1.ForeColor = myColor.Color;
            }
        }

        private void colorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog myFondo = new ColorDialog();
            if (myFondo.ShowDialog() == DialogResult.OK) ;
            {
                richTextBox1.BackColor = myFondo.Color;
            }
        }
    }
}
