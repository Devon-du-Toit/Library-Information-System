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

        private void eNDOWMENTSToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
            using (var newform = new ReadersForm(StaffId))
            {
                newform.ShowDialog(this);
            }
        }

        private void rEPORTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Code just to check if form works and loads with no code. - Scholtz 
            ReportsForm newform = new ReportsForm();

            newform.ShowDialog();
        }

        private void tEXTBOOKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new LibraryMaintenanceForm(LibraryTab.Textbooks))
                f.ShowDialog(this);
        }

        private void aUTHORSToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            using (var f = new LibraryMaintenanceForm(LibraryTab.Authors))
                f.ShowDialog(this);
        }

        private void sUBJECTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new LibraryMaintenanceForm(LibraryTab.Subjects))
                f.ShowDialog(this);
        }

        private void dONORSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EndowmentsForm newform = new EndowmentsForm(StaffId);

            newform.ShowDialog();
        }

        private void dONATIONSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EndowmentsForm newform = new EndowmentsForm(StaffId);

            newform.ShowDialog();
        }

        private void sTAFFToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (Role == "STAFF")
            {
                eMPLOYEEMENTToolStripMenuItem.Visible = false;
                dONATIONSToolStripMenuItem.Visible = false;
            }
        }
    }
}
