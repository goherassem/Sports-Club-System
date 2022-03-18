using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace SportsClubInformationSystem
{
    
    public partial class crystal_form : Form
    {
        CrystalReport1 CR;
        CrystalReport2 CR2;
        public crystal_form()
        {
            InitializeComponent();
        }

        private void crystal_form_Load(object sender, EventArgs e)
        {
           
            CR = new CrystalReport1();
            
            CR2 = new CrystalReport2();
            foreach (ParameterDiscreteValue v in CR.ParameterFields[0].DefaultValues)
            {
                comboBox1.Items.Add(v.Value);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                CR.SetParameterValue(0, comboBox1.Text);
                crystalReportViewer1.ReportSource = CR;

            }
            else if(radioButton2.Checked)
            {
                
               
                crystalReportViewer1.ReportSource = CR2;
                

            }

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Hide();
            label1.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Show();
            label1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
