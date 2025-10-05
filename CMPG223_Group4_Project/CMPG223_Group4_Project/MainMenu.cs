using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG223_Group4_Project
{
    public partial class MainMenu : Form
    {
        public int StaffId { get; }
        public string Role { get; }
        public string FirstName { get; }

        public MainMenu()
        {
            InitializeComponent();
        }

        public MainMenu(int staffId, string role, string firstName) : this()
        {
            StaffId = staffId;
            Role = role;
            FirstName = firstName;
        }

        private void libraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Code just to check if form works and loads with no code. - Scholtz 
            LibraryMaintenanceForm newform = new LibraryMaintenanceForm();

            newform.ShowDialog();
        }

        private void eNDOWMENTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Code just to check if form works and loads with no code. - Scholtz 
            EndowmentsForm newform = new EndowmentsForm();

            newform.ShowDialog();
        }

        private void eMPLOYEEMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Code just to check if form works and loads with no code. - Scholtz 
            StaffForm newform = new StaffForm();

            newform.ShowDialog();
        }

        private void bORROWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Code just to check if form works and loads with no code. - Scholtz 
            ReadersForm newform = new ReadersForm();

            newform.ShowDialog();
        }

        private void rEPORTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Code just to check if form works and loads with no code. - Scholtz 
            ReportsForm newform = new ReportsForm();

            newform.ShowDialog();
        }
    }
}
