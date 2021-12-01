using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightManager
{
    //TODO: - finish diagrams
    //      - admin dashboard
    //      - save bookings
    //      - fix closing (done for users, not admin)
    //      - admin: should be able to add users, similar window as bookflight
    //          with username + password

    public static class Globals
    {
        public static int PersonalID;
        public static int FlightID;
    }

    public class DataBaseSingleton
    {
        private static databaseEntities db;

        private DataBaseSingleton()
        { }

        public static databaseEntities GetDataBase()
        {
            if (db == null)
                db = new databaseEntities();

            return db;
        }
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
