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
    public partial class LoginPage : Form
    {
        List<Donor> Donors = new List<Donor>();

        List<Employee> Employees = new List<Employee>();


        public LoginPage()
        {
            InitializeComponent();
            Employees.Add(new Employee("Employee1", "12345", "George", "Smith"));
        
            //working on removing the file read and use a database instead
            ReadFile("Donors.txt", Donors);
           
        }

        private void ReadFile(string fileName, List<Donor> Donors)
        {
            char[] delim = { ',' };
            int count = 0;
            StreamReader catalogFile;

            catalogFile = File.OpenText(fileName);
            while (!catalogFile.EndOfStream)
            {
                string line = catalogFile.ReadLine();
                string[] tokens = line.Split(delim);

                string bloodType = tokens[4];
                BloodType bType = (BloodType)Enum.Parse(typeof(BloodType), bloodType);

                string userDateTime = tokens[6];
                DateTime oDate = Convert.ToDateTime(userDateTime);

                Donors.Add(new Donor(tokens[0], tokens[1], tokens[2], tokens[3], bType, tokens[5], oDate, tokens[7], tokens[8]));
                count++;
            }
            catalogFile.Close();


        }



        private void Login(string emailUserInput, string passwordInput, bool employeeLogin)
        {
            lblLoginErrorOutput.Text = "";
            if (employeeLogin == true)
            {
                for (int i = 0; i < Employees.Count; i++)
                {
                    if (emailUserInput == Employees[i].GetUsername().ToString() && passwordInput == Employees[i].GetPassword().ToString())
                    {
                        lblLoginErrorOutput.Text = "";
                        txtEmailLogin.Text = "";
                        txtPasswordLogin.Text = "";
                        chkEmployee.Checked = false;

                        
                        EmployeeDataDisplay employeeDataDisplayPage = new EmployeeDataDisplay();
                        employeeDataDisplayPage.ShowDialog();
                        
                    }
                    else
                    {
                        lblLoginErrorOutput.Text = "No Employee Found.";
                    }
                }
            }
            else
            {
                bool found = false;
                string donorEligibility = "Uneligible";

                for (int i = 0; i < Donors.Count; i++)
                {
                    if (emailUserInput.Equals(Donors[i].GetEmail().ToString()) && passwordInput == (Donors[i].GetPassword().ToString()))
                    {
                        found = true;
                        string donorsName = Donors[i].GetFirstName() + " " + Donors[i].GetLastName();

                        lblLoginErrorOutput.Text = "";
                        txtEmailLogin.Text = "";
                        txtPasswordLogin.Text = "";
                        

                        DateTime date1 = Donors[i].GetDonationDate();
                        DateTime date2 = DateTime.Now;

                        int years = date2.Year - date1.Year;
                        int months = date2.Month - date1.Month;

                        if (months >=  2 || years > 0)
                        {
                            donorEligibility = "Eligible";
                        }

                        //Display Form on Login
                        
                        DonorEligibility donorEligibilityPage = new DonorEligibility(donorsName, donorEligibility);
                        donorEligibilityPage.ShowDialog();
                       
                    }
                }

                if (found == false)
                {
                    lblLoginErrorOutput.Text = "No Donor Found.";
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string emailInput = txtEmailLogin.Text;
            string passwordInput = txtPasswordLogin.Text;
            bool employeeLogin = chkEmployee.Checked;

            
            Login(emailInput, passwordInput, employeeLogin);
        }
        

        /*private void lblNewDonor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterDonor registerDonorPage = new RegisterDonor();
            registerDonorPage.ShowDialog();
        }*/

        private void btnNewDonor_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterDonor registerDonorPage = new RegisterDonor();
            registerDonorPage.ShowDialog();
        }
    }
}
