using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace qwer
{
    public partial class Form1 : Form
    {
        public string CmdText = "SELECT * FROM [Doljnost]";
        public string ConnString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\пользователь\\Desktop\\лабы\\123.accdb";
        public Form1()
        {
            InitializeComponent();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CmdText, ConnString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Doljnost]");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;

        }
    }
}