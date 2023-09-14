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
    public partial class EmployeeDataDisplay : Form
    {
        int aPos, aNeg, bPos, bNeg, oPos, oNeg, abPos, abNeg = 0;

        List<Donor> Donors = new List<Donor>();

        private void btnDonateToday_Click(object sender, EventArgs e)
        {
            lblOutputDonors.Text = "";

            for (int i = 0; i < Donors.Count; i++)
            {
                DateTime date1 = Donors[i].GetDonationDate();
                DateTime date2 = DateTime.Now;

                int years = date2.Year - date1.Year;
                int months = date2.Month - date1.Month;

                if (months >= 2 || years > 0)
                {
                    lblOutputDonors.Text += Donors[i].GetEmail() + "\n";
                }
            }
        }


        public EmployeeDataDisplay()
        {
            InitializeComponent();

            ReadFile("Donors.txt", Donors);

            for (int i = 0; i < Donors.Count; i++)
            {
                if(Donors[i].GetBloodType().ToString() == "A_POSITIVE")
                {
                    aPos += 1;
                }
                if(Donors[i].GetBloodType().ToString() == "A_NEGATIVE")
                {
                    aNeg += 1;
                }
                if (Donors[i].GetBloodType().ToString() == "B_POSITIVE")
                {
                    bPos += 1;
                }
                if (Donors[i].GetBloodType().ToString() == "B_NEGATIVE")
                {
                    bNeg += 1;
                }
                if (Donors[i].GetBloodType().ToString() == "O_POSITIVE")
                {
                    oPos += 1;
                }
                if (Donors[i].GetBloodType().ToString() == "O_NEGATIVE")
                {
                    oNeg += 1;
                }
                if (Donors[i].GetBloodType().ToString() == "AB_POSITIVE")
                {
                    abPos += 1;
                }
                if (Donors[i].GetBloodType().ToString() == "AB_NEGATIVE")
                {
                    abNeg += 1;
                }
            }

            this.chtBloodTypes.Series["Blood"].Points.AddXY("A_POSITIVE", aPos);          
            this.chtBloodTypes.Series["Blood"].Points.AddXY("A_NEGATIVE", aNeg);
            this.chtBloodTypes.Series["Blood"].Points.AddXY("B_POSITIVE", bPos);
            this.chtBloodTypes.Series["Blood"].Points.AddXY("B_NEGATIVE", bNeg);
            this.chtBloodTypes.Series["Blood"].Points.AddXY("O_POSITIVE", oPos);
            this.chtBloodTypes.Series["Blood"].Points.AddXY("O_NEGATIVE", oNeg);
            this.chtBloodTypes.Series["Blood"].Points.AddXY("AB_POSITIVE", abPos);
            this.chtBloodTypes.Series["Blood"].Points.AddXY("AB_NEGATIVE", abNeg);


            var bloodTypes = new List < KeyValuePair<string, int>>();
            bloodTypes.Add(new KeyValuePair<string, int>("A_POSITIVE", aPos));
            bloodTypes.Add(new KeyValuePair<string, int>("A_NEGATIVE", aNeg));
            bloodTypes.Add(new KeyValuePair<string, int>("B_POSITIVE", bPos));
            bloodTypes.Add(new KeyValuePair<string, int>("B_NEGATIVE", bNeg));
            bloodTypes.Add(new KeyValuePair<string, int>("O_POSITIVE", oPos));
            bloodTypes.Add(new KeyValuePair<string, int>("O_NEGATIVE", oNeg));
            bloodTypes.Add(new KeyValuePair<string, int>("AB_POSITIVE", abPos));
            bloodTypes.Add(new KeyValuePair<string, int>("AB_NEGATIVE", abNeg));

            bloodTypes.Sort(Compare1);
            bloodTypes.Sort(Compare2);

            lblLowBlood.Text = "Blood Shortage: " +bloodTypes[0].Key + ", " + bloodTypes[1].Key + ", & " + bloodTypes[2].Key;

        }

        static int Compare1(KeyValuePair<string, int> a, KeyValuePair<string, int> b)
        {
            return a.Key.CompareTo(b.Key);
        }

        static int Compare2(KeyValuePair<string, int> a, KeyValuePair<string, int> b)
        {
            return a.Value.CompareTo(b.Value);
        }


        private void ReadFile(string fileName, List<Donor> Donors)
        {
            char[] delim = { ',' };
            int count = 0;
            StreamReader catalogFile;

            try
            {
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
            catch (Exception ex)
            {
                MessageBox.Show("Loading Error...");
            }

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {

            //need to check first name or email?
            lblOutputDonors.Text = "";
            string searchedDonor = txtSearchDonors.Text;

            for (int i = 0; i < Donors.Count; i++)
            {
                if (searchedDonor == Donors[i].GetFirstName() || searchedDonor == Donors[i].GetBloodType().ToString())
                {
                    string donorEligibility = "No";

                    DateTime date1 = Donors[i].GetDonationDate();
                    DateTime date2 = DateTime.Now;

                    int years = date2.Year - date1.Year;
                    int months = date2.Month - date1.Month;

                    if (months >= 2 || years > 0)
                    {
                        donorEligibility = "Yes";
                    }

                    if (Donors[i].GetInfo() == "none")
                    {
                        lblOutputDonors.Text += "Donor Name: " + Donors[i].GetFirstName() + " " + Donors[i].GetLastName() + "\n" +
                            "Previous Donation: " + Donors[i].GetDonationDate().ToString("d") + "\n" +
                            "Blood-Type: " + Donors[i].GetBloodType() + "\n" +
                            "Address: " + Donors[i].GetAddress() + "\n" +
                            "Email: " + Donors[i].GetEmail() + "\n" +
                            "Eligible to donate today? " + donorEligibility + "\n\n";
                    }
                    else
                    {
                        lblOutputDonors.Text += "Donor Name: " + Donors[i].GetFirstName() + " " + Donors[i].GetLastName() + "\n" +
                           "Previous Donation: " + Donors[i].GetDonationDate().ToString("d") + "\n" +
                           "Blood-Type: " + Donors[i].GetBloodType() + "\n" + 
                           "Blood-Info: " + Donors[i].GetInfo() + "\n" +
                           "Address: " + Donors[i].GetAddress() + "\n" +
                           "Email: " + Donors[i].GetEmail() + "\n" +
                           "Eligible to donate today? " + donorEligibility + "\n\n";
                    }
                }/*else{
                    lblOutputDonors.Text = "Donor Not Found.";
                }*/
            }

            if(searchedDonor == "")
            {
                lblOutputDonors.Text = "Please Enter a Valid Donor Name or Email.";
            }
        }

    }
}
