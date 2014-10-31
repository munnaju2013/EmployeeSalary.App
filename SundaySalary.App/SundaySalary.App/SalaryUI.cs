using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SundaySalary.App
{
    public partial class SalaryUI : Form
    {
        public SalaryUI()
        {
            InitializeComponent();
        }

        private void showMeAllButton_Click(object sender, EventArgs e)
        {
            Salary aSalary = new Salary();
            aSalary.EmployeeName = employeeNameTextBox.Text;
            aSalary.BasicAmount = Convert.ToDouble(basicAmountTextBox.Text);
            aSalary.PercentOfHouseRant = Convert.ToDouble(houseRentTextBox.Text);
            aSalary.PercentOfMedicalAllowance = Convert.ToDouble(medicalAllowanceTextBox.Text);
            MessageBox.Show("Basic Amount : " + aSalary.BasicAmount + "\nHouseRent : " + aSalary.GetHouseRant() +
                            "\nMedical Allowance : " + aSalary.GetMedicalAllowance() + "\nTotal Salary : " +
                            aSalary.GetTotal());
        }
    }
}
