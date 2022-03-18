using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;



namespace SportsClubInformationSystem
{
    

    public partial class Form1 : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        int choose;
       


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            if (choose == 1)
            {
                button3.Hide();
                button2.Hide();
            }
            else if (choose == 2)
            {
                button1.Hide();
                button3.Hide();
            }
            else if (choose == 3)
            {
                button1.Hide();
                button2.Hide();

            }

        }
        public void set_choose(int S)
        {
            choose = S;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select member_id from CLUBMEMBER where member_id = :n and mem_password = :m";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("n",textBox1.Text);
            cmd.Parameters.Add("m",textBox2.Text);

            OracleDataReader dr = cmd.ExecuteReader();
            bool a = dr.Read();
            if (a)
            {
                ClubMember clubMember = new ClubMember();
                clubMember.setID(Convert.ToInt32(textBox1.Text));
                clubMember.Show();
            }
            dr.Close();
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select trainer_id from trainer where trainer_id = :n and mem_password = :m";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("trainer_id", textBox1.Text);
            cmd.Parameters.Add("mem_password", textBox2.Text);

            OracleDataReader dr = cmd.ExecuteReader();
           
            while (dr.Read())
            {
                trainer trainer = new trainer();
                trainer.Show();
            }
            dr.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select EMPLOYEEID from employee_table where EMPLOYEEID =:n and EMP_PASSWORD = :m ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("n", textBox1.Text);
            cmd.Parameters.Add("m", textBox2.Text);
            
            OracleDataReader dr = cmd.ExecuteReader();
         

            if (dr.Read())
             {
                 employee employee = new employee();
                 employee.Show();
             }
            
                 
            dr.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
