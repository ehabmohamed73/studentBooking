using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace StudentBooking
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        public static OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Booking.accdb");
        public static OleDbDataAdapter dataAdep;
        public static OleDbDataAdapter stuDataAdep;
        public static OleDbDataAdapter dataAdep1;
        public static BindingSource bindingSource;
        public static BindingSource bindingSource1;
        public static BindingSource stuBindingSource;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
