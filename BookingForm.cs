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
    public partial class BookingForm : Form
    {
        databaseEntities db;
        static int id = 0;

        public BookingForm()
        {
            InitializeComponent();
            id = Globals.PersonalID;

            db = new databaseEntities();
            Personal_Info customer = db.Personal_Info.Where(a => a.Id == id).FirstOrDefault();
            
            customerFullName.Text = customer.FullName;
            customerDatePicker.Value = (DateTime)customer.DateOfBirth;
            customerSex.Text = customer.Sex;
            customerDocNr.Text = customer.DocumentNr;
            customerEmail.Text = customer.Email;
            customerPhoneNr.Text = customer.PhoneNr;
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {

        }

        private void customerFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void customerPhoneNr_TextChanged(object sender, EventArgs e)
        {

        }

        private void customerDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void customerEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void customerSex_TextChanged(object sender, EventArgs e)
        {

        }

        private void customerDocNr_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nrOfLuggage;
            try
            {
                nrOfLuggage = Convert.ToInt32(luggageNr.Text);
            }
            catch
            {
                MessageBox.Show("Input only numbers");
                return;
            }
            
            if (nrOfLuggage > 10) // TODO: if VIP can do 10, otherwise 3 or something
            {
                MessageBox.Show("Choose less luggage please");
                return;
            }

            int flightId = Globals.FlightID;

            Flight_details_db currentFlight = db.Flight_details_db.Where(a => a.Id.Equals(flightId)).FirstOrDefault();

            double currentPrice = Convert.ToDouble(currentFlight.StandardPrice) + nrOfLuggage*100;
            priceBox.Text = Convert.ToString(currentPrice);
        }
    }
}
