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
    public partial class AdminDashboard : Form
    {
        LoginForm loginWindow;

        public AdminDashboard(LoginForm startWindow)
        {
            InitializeComponent();

            loginWindow = startWindow;
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {

        }

        private void AddFlightButton_Click(object sender, EventArgs e)
        {
            var myForm = new FlightInfo();
            myForm.Show();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            loginWindow.Show();
        }
    }
}
