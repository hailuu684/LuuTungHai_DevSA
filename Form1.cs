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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            databaseEntities db = new databaseEntities();

            if (usrtxt.Text != string.Empty && usrpwtxt.Text != string.Empty)
            {
                var user = db.admins.Where(a => a.Username.Equals(usrtxt.Text)).SingleOrDefault();
                if (user != null)
                {
                    if (user.Password.Equals(usrpwtxt.Text))
                    {
                        MessageBox.Show("Password is correct");
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
