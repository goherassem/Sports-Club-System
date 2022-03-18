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
    public partial class update_form : Form
    {
        OracleDataAdapter adapter;
        DataSet ds;
        OracleCommandBuilder builder;
        public update_form()
        {
            InitializeComponent();
        }

        private void update_form_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=orcl;User Id=scott;Password = tiger;";
            string cmdstr = "select * from clubmember where member_id=:n";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("n", txt_memberid.Text);
            ds = new DataSet();
            adapter.Fill(ds);
            dgv_members.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            MessageBox.Show("Updated succeded");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
