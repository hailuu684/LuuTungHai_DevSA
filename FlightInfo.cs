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
    public partial class FlightInfo : Form
    {
        databaseEntities db;

        public FlightInfo()
        {
            InitializeComponent();
            db = DataBaseSingleton.GetDataBase();

            departureTimeSelection.Format = DateTimePickerFormat.Time;
            departureTimeSelection.ShowUpDown = true;
            arrivalTimeSelection.Format = DateTimePickerFormat.Time;
            arrivalTimeSelection.ShowUpDown = true;
        }

        private void addFlightButton_Click(object sender, EventArgs e)
        {
            Flight_details_db flight_db = new Flight_details_db();

            flight_db.FlightNumber = flightNumberTextbox.Text;
            flight_db.DepartureAirport = departureAirportTextbox.Text;
            flight_db.ArrivalAirport = destinationAirportTextbox.Text;
            flight_db.DepartureDateTime = (DateTime)(departureDateSelection.Value.Date + departureTimeSelection.Value.TimeOfDay);
            flight_db.ArrivalDateTime = (DateTime)(arrivalDateSelection.Value.Date + arrivalTimeSelection.Value.TimeOfDay);
            flight_db.StandardPrice = Convert.ToDouble(priceTextbox.Text);
            flight_db.TotalCapacity = Convert.ToInt32(totalCapacityTextbox.Text);
            flight_db.AvailableSeats = flight_db.TotalCapacity;
            flight_db.FlightDuration = flight_db.ArrivalDateTime - flight_db.DepartureDateTime;

            db.Flight_details_db.Add(flight_db);
            db.SaveChanges();
            MessageBox.Show("Added flight information successfully");
            this.Close();
        }
    }
}
