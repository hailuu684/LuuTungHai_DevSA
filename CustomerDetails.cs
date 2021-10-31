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
        static int id = 0;

        public CustomerDetails(int ? Id)
        {
            InitializeComponent();
            if (Id != null)
            {
                CustomerDetailsSaveButton.Visible = false;

                db = new databaseEntities();
                Personal_Info customer = db.Personal_Info.Where(a => a.Id == Id).FirstOrDefault();
                id = customer.Id;
                
                customerFullName.Text = customer.FullName;
                customerDatePicker.Value = (DateTime) customer.DateOfBirth;
                customerSex.Text = customer.Sex;
                customerDocNr.Text = customer.DocumentNr;
                customerEmail.Text = customer.Email;
                customerPhoneNr.Text = customer.PhoneNr;
            }
            else
            {
                customerUpdateButton.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CustomerDetailsSaveButton_Click(object sender, EventArgs e)
        {
            databaseEntities db = new databaseEntities();
            Personal_Info customers = new Personal_Info
            {
                FullName = customerFullName.Text,
                DateOfBirth = customerDatePicker.Value,
                Sex = customerSex.Text,
                DocumentNr = customerDocNr.Text,
                Email = customerEmail.Text,
                PhoneNr = customerPhoneNr.Text
            };
            db.Personal_Info.Add(customers);
            db.SaveChanges();
            MessageBox.Show("Info added");
        }

        private void customerUpdateButton_Click(object sender, EventArgs e)
        {
            db = new databaseEntities();
            Personal_Info customer = db.Personal_Info.Where(a => a.Id == id).FirstOrDefault();

            customer.FullName = customerFullName.Text;
            customer.DateOfBirth = customerDatePicker.Value;
            customer.Sex = customerSex.Text;
            customer.DocumentNr = customerDocNr.Text;
            customer.Email = customerEmail.Text;
            customer.PhoneNr = customerPhoneNr.Text;
            db.SaveChanges();
            
            MessageBox.Show("Updated successfully");
            this.Close();
        }
    }
}
