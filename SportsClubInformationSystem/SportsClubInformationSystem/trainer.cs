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
    public partial class trainer : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;

        public trainer()
        {
            InitializeComponent();
        }

        private void trainer_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GETSALARY";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("title", textBox1.Text);
            cmd.Parameters.Add("salary", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            
            textBox2.Text = cmd.Parameters["salary"].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DISPLAY_SESSIONS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", textBox1.Text);
            cmd.Parameters.Add("sessions", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            comboBox1.Items.Clear();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["session_time"]);
            }
            dr.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
