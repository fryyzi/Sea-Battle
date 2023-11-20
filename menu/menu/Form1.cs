using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    public partial class Form1 : Form
    {
        private Form active;
        public Form1()
        {
            InitializeComponent();
        }

        internal void ChangeFormColor(Color red)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game test = new Game();
            test.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settin coursesForm = new Settin();
            coursesForm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            rules rules = new rules();
            rules.Show();
        }
    }
}
