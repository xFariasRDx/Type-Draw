using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Drawing : Form
    {
        Bitmap Bitmap = new Bitmap(1920, 1080);
        Pen pen = new Pen(Color.Black, 5);
        bool isDrawing = false;
        int ThePenSize = 5;
        Image OpenedFile;
        public Drawing()
        {
            InitializeComponent();
            
            for (int i = 0; i <Bitmap.Width; i++)
            {
                for (int j = 0; j < Bitmap.Height; j++)
                {
                    Bitmap.SetPixel(i, j, Color.White);
                }
            }
        }

        private void Drawing_Load(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
             
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (isDrawing == true)
            {
                isDrawing = false;
            }
            else
            {
                isDrawing = true;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing == true)
            {
                Graphics graphics = Graphics.FromImage(Bitmap);
                graphics.DrawRectangle(pen, e.X, e.Y, ThePenSize, ThePenSize);
                pictureBox1.Image = Bitmap;
            
            }

        }

        private void Black_Btn_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Black;
        }

        private void Red_Btn_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Red;
        }

        private void Yellow_Btn_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Yellow;
        }

        private void Blue_Btn_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Blue;
        }

        private void Green_Btn_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Green;
        }

        private void PenSize_5_Click(object sender, EventArgs e)
        {
            ThePenSize = 5;
        }

        private void PenSize_10_Click(object sender, EventArgs e)
        {
            ThePenSize = 10;
        }

        private void PenSize_15_Click(object sender, EventArgs e)
        {
            ThePenSize = 15;
        }

        private void Tsm_Abrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog myOpen = new OpenFileDialog();
            DialogResult dr = myOpen.ShowDialog();
            if (dr == DialogResult.OK)
            {
                OpenedFile = Image.FromFile(myOpen.FileName);
                pictureBox1.Image = OpenedFile;
            }
        }

        private void Tsm_Guardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Jpeg|*.jpg|Bitmap Tmage *.bmp|";
            saveFileDialog.Title = "Guardar como...";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        {
                            this.pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        }
                        break;
                    case 2:
                        {
                            this.pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        }
                        break;
                }
                fs.Close();
            }
        }

        private void volverAlMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu mainMenu = new Menu();
            this.Hide();
            mainMenu.Show();
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            pictureBox1.BackColor = Color.Black;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pen.Color = Color.White;
        }

        private void Drawing_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
