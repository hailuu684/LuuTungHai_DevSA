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
                vipPicture.Visible = true;
                drinkCheckbox.Visible = true;
                drinkLabel.Visible = true;
                drinkTextbox.Visible = true;
                mealCheckbox.Visible = true;
                mealLabel.Visible = true;
                mealTextbox.Visible = true;
                mealTextbox.ReadOnly = true;
                drinkTextbox.ReadOnly = true;
            }
            else
            {
                BookingFormTitle.Text = "Customer data";
                airportTransferLabel.Visible = false;
                airportTransferCheckbox.Visible = false;
                vipPicture.Visible = false;
                drinkCheckbox.Visible = false;
                drinkLabel.Visible = false;
                drinkTextbox.Visible = false;
                mealCheckbox.Visible = false;
                mealLabel.Visible = false;
                mealTextbox.Visible = false;
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
            int nrOfSmallLuggage, nrOfMediumLuggage, nrOfLargeLuggage;
            try
            {
                nrOfSmallLuggage = Convert.ToInt32(smallLuggageNr.Text);
                nrOfMediumLuggage = Convert.ToInt32(mediumLuggageNr.Text);
                nrOfLargeLuggage = Convert.ToInt32(largeLuggageNr.Text);
            }
            catch
            {
                MessageBox.Show("Input only numbers");
                return;
            }

            if (customer.VIP == false)
            {
                if (nrOfSmallLuggage+ nrOfMediumLuggage+ nrOfLargeLuggage > 3)
                {
                    MessageBox.Show("Choose less luggage please");
                    return;
                }
            }
            else
            {
                if (nrOfSmallLuggage + nrOfMediumLuggage + nrOfLargeLuggage > 10)
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

            double currentPrice = (Convert.ToDouble(currentFlight.StandardPrice) +
                                   nrOfSmallLuggage*10 +
                                   nrOfMediumLuggage*50 +
                                   nrOfLargeLuggage*100) * multiplier;

            if (mealCheckbox.Checked)
            {
                currentPrice += 100;
            }
            if (drinkCheckbox.Checked)
            {
                currentPrice += 50;
            }
            if (airportTransferCheckbox.Checked)
            {
                currentPrice += 150;
            }

            priceBox.Text = "$ " + Convert.ToString(currentPrice);
        }

        private void mealCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (mealCheckbox.Checked)
            {
                mealTextbox.ReadOnly = false;
            }
            else
            {
                mealTextbox.ReadOnly = true;
            }
        }

        private void drinkCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (drinkCheckbox.Checked)
            {
                drinkTextbox.ReadOnly = false;
            }
            else
            {
                drinkTextbox.ReadOnly = true;
            }
        }
    }
}
