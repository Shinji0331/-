using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmCalendar : Form
    {
        public frmCalendar()
        {
            InitializeComponent();
        }

        private void frmCalendar_Load(object sender, EventArgs e)
        {
            monthCalendar1.DateChanged += new DateRangeEventHandler(monthCalendar1_DateChanged);
            monthCalendar1.DateSelected += new DateRangeEventHandler(monthCalendar1_DateSelected);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //
            DateTime start = e.Start;
            DateTime end = e.End;
            Console.WriteLine("Changed: " + start.ToString() + " " + end.ToString());
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            //
            DateTime start = e.Start;
            DateTime end = e.End;
            Console.WriteLine("Selected: " + start.ToString() + " " + end.ToString());
        }
    }
}
