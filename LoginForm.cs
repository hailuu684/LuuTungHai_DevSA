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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            databaseEntities db = DataBaseSingleton.GetDataBase();
            
            bool isAdmin = false;
            
            if (usrtxt.Text != string.Empty && usrpwtxt.Text != string.Empty)
            {
                var user = db.Personal_Info.Where(a => a.Username.Equals(usrtxt.Text)).SingleOrDefault();
                if (user != null)
                {
                    if (user.Username == "admin")
                        isAdmin = true;

                    if (user.Password.Equals(usrpwtxt.Text))
                    {
                        Globals.PersonalID = user.Id;

                        if (!isAdmin)
                        {
                            var myForm = new FlightSearch(this);
                            myForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            var myForm = new AdminDashboard(this);
                            myForm.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong password");
                    }
                }
                else
                {
                    MessageBox.Show("User not found");
                }
            }
            else
            {
                MessageBox.Show("Enter valid username/password");
            }
        }

        private void usrpwtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }

        private void LoginForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                usrtxt.Text = "";
                usrpwtxt.Text = "";
            }
        }

        private void usrtxt_KeyDown(object sender, KeyEventArgs e)
        {
            usrpwtxt_KeyDown(sender, e);
        }
    }
}
