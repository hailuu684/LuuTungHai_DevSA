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
    public partial class FlightSearch : Form
    {
        databaseEntities db;

        LoginForm loginWindow;
        
        public FlightSearch(LoginForm startWindow)
        {
            InitializeComponent();

            loginWindow = startWindow;

            db = DataBaseSingleton.GetDataBase();

            BindSource();
            BindDestination();
        }
        private void BindSource()
        {
            var items = db.Flight_details_db.ToList();
            sourceCombo.DataSource = items;
            sourceCombo.DisplayMember = "DepartureAirport";
        }
        private void BindDestination()
        {
            var items = db.Flight_details_db.ToList();
            destinationCombo.DataSource = items;
            destinationCombo.DisplayMember = "ArrivalAirport";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sourceCombo.Text != destinationCombo.Text)
            {
                dataGridView1.DataSource = db.Flight_details_db.Where(
                    a => a.DepartureAirport.Equals(sourceCombo.Text) &&
                    a.ArrivalAirport.Equals(destinationCombo.Text)).ToList();
                dataGridView1.Refresh();

                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
            }
            else
            {
                dataGridView1.DataSource = null;
                MessageBox.Show("No flight available");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;

            try
            {
                id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            }
            catch
            {
                return;
            }

            Globals.FlightID = id;

            var myForm = new BookingForm();
            myForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            loginWindow.Show();
        }
    }
}
