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
        Personal_Info customer;
        static int id = 0;

        public BookingForm()
        {
            InitializeComponent();
            id = Globals.PersonalID;

            db = new databaseEntities();
            customer = db.Personal_Info.Where(a => a.Id == id).FirstOrDefault();
            
            if (customer.VIP == true)
            {
                BookingFormTitle.Text = "VIP customer data";
                airportTransferLabel.Visible = true;
                airportTransferCheckbox.Visible = true;
            }
            else
            {
                BookingFormTitle.Text = "Customer data";
                airportTransferLabel.Visible = false;
                airportTransferCheckbox.Visible = false;
            }
            
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
            int flightId = Globals.FlightID;

            Flight_details_db currentFlight = db.Flight_details_db.Where(a => a.Id.Equals(flightId)).FirstOrDefault();
            if (currentFlight.AvailableSeats <= 0)
            {
                MessageBox.Show("No available seats on this flight");
                return;
            }

            currentFlight.AvailableSeats--;
            db.SaveChanges();
            MessageBox.Show("Flight booked successfully, there are " + currentFlight.AvailableSeats + " seats left");
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

            if (customer.VIP == false)
            {
                if (nrOfLuggage > 3)
                {
                    MessageBox.Show("Choose less luggage please");
                    return;
                }
            }
            else
            {
                if (nrOfLuggage > 10)
                {
                    MessageBox.Show("Choose less luggage please");
                    return;
                }
            }

            int flightId = Globals.FlightID;

            Flight_details_db currentFlight = db.Flight_details_db.Where(a => a.Id.Equals(flightId)).FirstOrDefault();

            double multiplier = 1;
            if (customer.VIP == true)
                multiplier = 0.8;

            double currentPrice = (Convert.ToDouble(currentFlight.StandardPrice) + nrOfLuggage*100) * multiplier;
            priceBox.Text = "$ " + Convert.ToString(currentPrice);
        }
    }
}
