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
    public partial class Settin : Form
    {
        private Form active;

        
        public Settin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fon temp = new Fon();
            temp.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            PanelForm(new Fon());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void Settin_Load(object sender, EventArgs e)
        {
            
        }
        private void PanelForm(Form fm)
        {
            if (active != null)
                active.Close();
            active = fm;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            this.panelSet.Controls.Add(fm);
            this.panelSet.Tag = fm;
            fm.BringToFront();
            fm.Show();
        }

        private void panelSet_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }
    }
}
