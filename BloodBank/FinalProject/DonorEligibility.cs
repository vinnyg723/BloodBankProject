using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class DonorEligibility : Form
    {
        public DonorEligibility(string donorsName, string donorEligibility)
        {
            InitializeComponent();

            lblWelcomeUser.Text = "Welcome " + donorsName + "!";
            lblEligibility.Text = "You are " + donorEligibility + " to donate blood today.";
        }
    }
}
