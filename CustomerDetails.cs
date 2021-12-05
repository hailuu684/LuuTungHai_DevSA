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
    public partial class CustomerDetails : Form
    {
        databaseEntities db;

        public CustomerDetails()
        {
            InitializeComponent();

            db = DataBaseSingleton.GetDataBase();
        }
        private void CustomerDetailsSaveButton_Click(object sender, EventArgs e)
        {
            //databaseEntities db = new databaseEntities();
            if (customerPassword.Text != customerPasswordConfirmation.Text)
            {
                MessageBox.Show("Password is not the same");
                return;
            }

            Personal_Info customers = new Personal_Info
            {
                FullName = customerFullName.Text,
                DateOfBirth = customerDatePicker.Value,
                Sex = customerSex.Text,
                DocumentNr = customerDocNr.Text,
                Email = customerEmail.Text,
                PhoneNr = customerPhoneNr.Text,
                Username = customerUsername.Text,
                Password = customerPassword.Text
            };

            db.Personal_Info.Add(customers);
            db.SaveChanges();
            MessageBox.Show("Info added");

            this.Close();
        }
    }
}
