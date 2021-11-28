using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightManager
{
    public partial class StoreCustomers : Form
    {
        public StoreCustomers()
        {
            InitializeComponent();
        }

        private void StoreCustomers_Load(object sender, EventArgs e)
        {
            databaseEntities db = DataBaseSingleton.GetDataBase();
            var items = db.Personal_Info.ToList();
            dataGridView1.DataSource = items;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            databaseEntities db = DataBaseSingleton.GetDataBase();
            var items = db.Personal_Info.Where(a => a.FullName.Equals(textBox1.Text)).ToList();
            dataGridView1.DataSource = items;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            CustomerDetails c1 = new CustomerDetails(id);
            c1.ShowDialog();
        }
    }
}
