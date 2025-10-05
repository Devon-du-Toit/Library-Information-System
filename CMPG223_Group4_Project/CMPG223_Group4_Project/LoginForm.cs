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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_BNT_Click(object sender, EventArgs e)
        {
            //Code to go to the next form - Scholtz (if questions needed)
            MainMenu newForm = new MainMenu();
            newForm.ShowDialog();
            
        }
    }
}
