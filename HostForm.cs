using Microsoft.Extensions.Configuration;
using System;
using System.Windows.Forms;
using GuestsForShabat.DAL;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Data;
using System.Linq;

namespace GuestsForShabat
{
    public partial class HostForm : Form
    {

        private string _connString;
        public HostForm(string connStr)
        {
            InitializeComponent();
            _connString = connStr;
            InitializeList();
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            DBContext db = new DBContext(GetConnectionString());
            SqlParameter[] parameters = { new SqlParameter("@name", text_category.Text) };
            int answer = db.ExecuteNonQuery("insert into Categories(Name) values (@name)", parameters);
            if (answer < 1)
            {
                MessageBox.Show("שגיאה!");
                return;
            }
            list_categories.Items.Add(new ListViewItem(text_category.Text));
        }

        private string GetConnectionString()
        {
            IConfiguration builder = new ConfigurationBuilder()
 .AddJsonFile("DAL/secrets.json", optional: true) // Add secrets.json
 .Build();
            // Read a value from the configuration
            return builder["ConnectionString"];
        }


        private void InitializeList()
        {
            DBContext db = new DBContext(_connString);
            DataTable table = new DataTable();
            table = db.ExecuteQuery("select name from Categories", null);
            string[] cats = table.AsEnumerable().Select(row => row.Field<string>("Name")).ToArray();
            foreach (string cat in cats)
            {
                list_categories.Items.Add($"{cat}");
            }
        }
    }
}
