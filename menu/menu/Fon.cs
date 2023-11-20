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
    public partial class Fon : Form
    {

        private Game form1;
        private Form1 form2;

        public Fon()
        {
            
            InitializeComponent();
            form1 = Application.OpenForms.OfType<Game>().FirstOrDefault();
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Fon exit = new Fon();
            this.Close();
        }

        private void Fon_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (form1 != null)
                form1.ChangeFormColor(Color.Red); // Установите нужный вам цвет
        }

        private void roundBtn1_Click(object sender, EventArgs e)
        {
            if (form1 != null)
                form1.ChangeFormColor(Color.Red); // Установите нужный вам цвет
        }

        private void roundBtn3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void roundBtn1_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void roundBtn1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void roundBtn14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roundBtn5_Click(object sender, EventArgs e)
        {
            if (form1 != null)
                form1.ChangeFormColor(Color.Green);
        }

        private void roundBtn4_Click(object sender, EventArgs e)
        {
            if (form1 != null)
                form1.ChangeFormColor(Color.FromArgb(0, 0, 192));
        }

        private void roundBtn8_Click(object sender, EventArgs e)
        {
            if (form1 != null)
                form1.ChangeFormColor(Color.Blue);
        }

        private void roundBtn12_Click(object sender, EventArgs e)
        {
            if (form1 != null)
                form1.ChangeFormColor(Color.Gray);
        }

        private void roundBtn3_Click(object sender, EventArgs e)
        {
            if(form1 != null)
                form1.ChangeFormColor(Color.Purple);
        }

        private void roundBtn2_Click(object sender, EventArgs e)
        {
            if(form1 != null)
                form1.ChangeFormColor(Color.White);
        }

        private void roundBtn7_Click(object sender, EventArgs e)
        {
            if(form1 != null)
                form1.ChangeFormColor(Color.FromArgb(64, 0, 64));
        }

        private void roundBtn13_Click(object sender, EventArgs e)
        {
            if(form1 != null)
                form1.ChangeFormColor(Color.DarkOrange);
        }

        private void roundBtn11_Click(object sender, EventArgs e)
        {
            if(form1 != null)
                form1 .ChangeFormColor(Color.Gold);
        }

        private void roundBtn6_Click(object sender, EventArgs e)
        {
            if(form1 != null)
                form1.ChangeFormColor(Color.Lime);
        }

        private void roundBtn10_Click(object sender, EventArgs e)
        {
            if(form1 != null)
                form1.ChangeFormColor (Color.Yellow);
        }

        private void roundBtn9_Click(object sender, EventArgs e)
        {
            if(form1 != null)
                form1.ChangeFormColor(Color.GreenYellow);
        }

        private void roundBtn15_Click(object sender, EventArgs e)
        {
            if (form1 != null)
                form1.ChangeFormColor(Color.Aqua);
        }
    }
}
