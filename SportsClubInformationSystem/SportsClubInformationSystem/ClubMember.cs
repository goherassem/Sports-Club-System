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
    public partial class ClubMember : Form
    {
        string ordb1 = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn1;
        
        
        
        public ClubMember()
        {
            InitializeComponent();
        }

        private void ClubMember_Load(object sender, EventArgs e)
        {
            
            conn1 = new OracleConnection(ordb1);
            conn1.Open();
            
            
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn1;
            cmd.CommandText = "Select sport_name from SPORTS";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr1 = cmd.ExecuteReader();
            while (dr1.Read())
            {
                sportlist.Items.Add(dr1[0]);
            }
            dr1.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn1 = new OracleConnection(ordb1);
            conn1.Open();
            
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn1;

            avalSession.Items.Clear();
            cmd.CommandText = "Select SESSION_id from SESSIOM where SPORT_NAME =:n ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("n",sportlist.SelectedItem.ToString());
            OracleDataReader dr1 = cmd.ExecuteReader();
            while (dr1.Read())
            {
                avalSession.Items.Add(dr1[0]);

            }
            dr1.Close();
        }

        private void ClubMember_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn1.Dispose();
        }

        int memID;
        public void setID(int id)
        {
            memID = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn1 = new OracleConnection(ordb1);
            conn1.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn1;

            cmd.CommandText = "INSERT INTO MEMBER_SESSION VALUES(:a,:b)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("a", memID);
            cmd.Parameters.Add("b", avalSession.SelectedItem.ToString());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Insert succeeded");
        }

        private void avalSession_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

        
}

