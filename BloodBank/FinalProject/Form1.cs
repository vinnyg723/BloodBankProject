﻿using System;
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
    public partial class Form1 : Form
    {
        List<Donor> Donors = new List<Donor>();

        List<Employee> Employees = new List<Employee>();


        public Form1()
        {
            InitializeComponent();
            Employees.Add(new Employee("Employee1", "12345"));
        
            ReadFile("Donors.txt", Donors);
        }

        //Vincents Sample Commit

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

                Donors.Add( new Donor(tokens[0], tokens[1], tokens[2], tokens[3], bType, tokens[5], oDate, tokens[7], tokens[8]));
                    count++;
                }
                catalogFile.Close();


        }



        private void Login(string emailUserInput, string passwordInput, bool employeeLogin)
        {

            if (employeeLogin == true)
            {
                for (int i = 0; i < Employees.Count; i++)
                {
                    if (emailUserInput == Employees[i].GetUserName().ToString() && passwordInput == Employees[i].GetPassword().ToString())
                    {
                        Form2 f2 = new Form2();
                        f2.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Employee Account not found.");
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
                        string donorsName = Donors[i].GetFirstName();

                        DateTime date1 = Donors[i].GetDonationDate();
                        DateTime date2 = DateTime.Now;

                        int years = date2.Year - date1.Year;
                        int months = date2.Month - date1.Month;

                        if (months >=  2 || years > 0)
                        {
                            donorEligibility = "Eligible";
                        }

                        //Display Form on Login
                        Form3 f3 = new Form3(donorsName, donorEligibility);
                        f3.ShowDialog();
                    }
                }

                if (found == false)
                {
                    MessageBox.Show("Donor Account not found.");
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

        private void lblNewDonor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }
    }
}
