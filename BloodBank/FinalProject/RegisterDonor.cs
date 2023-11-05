using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FinalProject
{
    public partial class RegisterDonor : Form
    {
        List<Donor> Donors;
        

        public RegisterDonor()
        {
            InitializeComponent();

            cboBloodType.Items.AddRange(GetBlood());
            cboBloodType.SelectedIndex = 0;


        }

        public string[] GetBlood()
        {
            return new string[]
            {
                BloodType.A_POSITIVE.ToString(),
                BloodType.A_NEGATIVE.ToString(),
                BloodType.B_POSITIVE.ToString(),
                BloodType.B_NEGATIVE.ToString(),
                BloodType.O_POSITIVE.ToString(),
                BloodType.O_NEGATIVE.ToString(),
                BloodType.AB_POSITIVE.ToString(),
                BloodType.AB_NEGATIVE.ToString()
            };
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            StreamWriter fileName = File.AppendText("Donors.txt");

            if (txtPasswordND1.Text == txtPasswordND2.Text)
            {
                string email = txtEmailND.Text;
                string password = txtPasswordND1.Text;
                string firstName = txtFirstNameND.Text;
                string lastName = txtLastNameND.Text;
                string address = txtAddressND.Text;
                string phoneNumber = txtPhoneNumND.Text;
                string bloodType = cboBloodType.SelectedItem.ToString();

                var dateToday = new DateTime(2015, 12, 31);


                BloodType bType = (BloodType)Enum.Parse(typeof(BloodType), bloodType);

                if(email != "" && password != "" && firstName != "" && lastName != "" && address != "" && phoneNumber != "")
                {
                    Donor donor = new Donor(firstName, lastName, address, phoneNumber, bType, "none", dateToday, email, password);

                    DateTime dateHolder = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    dateHolder.ToString("mm/dd/yyyy");

                    fileName.WriteLine(donor.GetFirstName() +","+ donor.GetLastName() + "," + donor.GetAddress() + "," + donor.GetAddress() + "," + bType + "," + "none" + "," + dateHolder + "," + donor.GetEmail() + "," + donor.GetPassword());
                    fileName.Close();
                    MessageBox.Show("Thank you for signing up.");

                    this.Hide();
                    LoginPage loginPage = new LoginPage();
                    loginPage.ShowDialog();
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int height;
            int weight;
            
            lblDonorCheckError.Text = "";
            lblOutputAccepted.Visible = false;

            if (rdoOfAgeYes.Checked)
            {
                if (rdoMale.Checked == true || rdoFemale.Checked == true)
                {
                    //trying to figure out how to make the check easier to read for selected options

                    if (int.TryParse(txtHeight.Text, out height))
                    {
                        if (int.TryParse(txtWeight.Text, out weight))
                        {
                            lblOutputAccepted.Visible = true;
                            if (rdoMale.Checked && height >= 60 && weight >= 110 || rdoFemale.Checked && height >= 65 && weight >= 110)
                            {
                                lblOutputAccepted.Text = "Congratulations! You meet the requirements to donate.";
                                gbDonorInfo.Visible = true;
                            }
                            else
                            {
                                lblOutputAccepted.Text = "You do not meet the requirements to donate.";
                                gbDonorInfo.Visible = false;
                            }
                        }
                        else
                        {
                             lblDonorCheckError.Text = "Please enter a weight.";
                        }
                    }
                    else
                    {
                        lblDonorCheckError.Text = "Please enter a height.";
                    }
                }
                else
                {
                    lblDonorCheckError.Text = "Are you male or female?";
                }
               

            }
            else
            {
                lblDonorCheckError.Text = "You are not of age to donate.";
            }
            
            


        }

        
    }
}
