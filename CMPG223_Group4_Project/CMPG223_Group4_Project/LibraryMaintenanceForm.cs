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
    public enum LibraryTab { Textbooks, Subjects, Authors }

    public partial class LibraryMaintenanceForm : Form
    {
        public LibraryMaintenanceForm()
        {
            InitializeComponent();
        }

        public LibraryMaintenanceForm(LibraryTab tabToSelect) : this()
        {
            switch (tabToSelect)
            {
                case LibraryTab.Textbooks:
                    TabControl_Library.SelectedTab = Tab_TxtBooks;
                    break;
                case LibraryTab.Subjects:
                    TabControl_Library.SelectedTab = Tab_Subjects;
                    break;
                case LibraryTab.Authors:
                    TabControl_Library.SelectedTab = Tab_Authors;
                    break;
            }
        }
    }

}
