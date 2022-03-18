using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsClubInformationSystem
{
    public partial class Interface_form : Form
    {
        public Interface_form()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void loginAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripComboBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Interface_form_Load(object sender, EventArgs e)
        {

        }

        private void mangerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            F.set_choose(1);
            F.Show();
           
        }

        private void login3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            F.set_choose(2);
            F.Show();
        }

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            F.set_choose(3);
            F.Show();
        }

        private void descriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Hide();
            label2.Text = "Manager Can Edit Members Data and Generate Report";
           
        }

        private void descriptionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label1.Hide();
            label2.Text = "Club member Choose sports and Register for Available Sessions";
        }

        private void descriptionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            label1.Hide();
            label2.Text = "Trainer can view his salary by using ID and View available session";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
