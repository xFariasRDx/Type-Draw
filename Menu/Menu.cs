using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextEditer editer = new TextEditer();
            editer.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Drawing drawing = new Drawing();
            drawing.Show();
            this.Hide();
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //}

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
