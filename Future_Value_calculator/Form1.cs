/*
 * Author Name: Berzaf Teklu
 * Date 09/27/2020
 * Calculate Expected investment return value
 * for 6 months, one year, two years and five years
 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Future_Value_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string stockName = "";
                string stockSymbol = "";
                double costPerShare = 0;
                double numOfShare = 0;
                double annReturnRate = 0;
                double intialInvestmentValue = 0;
                double effAnualReturnRate = 0;


                // Get stock name, stock symbol cost per share, number of shares and the annual return rate.

                stockName = txtStockName.Text;
                stockSymbol = txtStockSymbol.Text;
                costPerShare = double.Parse(txtCostPerShare.Text);
                numOfShare = double.Parse(txtNumberOfShare.Text);
                annReturnRate = double.Parse(txtAnnualReturnRate.Text) / 100;         // the annual return rate should be devided by 100 


                // calculate the Intial value investment of the stock
                intialInvestmentValue = costPerShare * numOfShare;

                // calculate effective annual return rate

                effAnualReturnRate = (annReturnRate/1) + 1;     
                // calculate expected investment value of the stock. The formula is
                //  expected investment value = intial investment value * (effective annual return rate)^year
                // use Math.pow()
                double sixMonthsValue = Math.Pow(effAnualReturnRate, 0.5) * intialInvestmentValue;       // calculate the expected investment reture value for six months. 0.5 represents half year 
                double oneYearValue = Math.Pow(effAnualReturnRate, 1) * intialInvestmentValue;          // calculate the expected investment reture value for one year.
                double twoYearsValue = Math.Pow(effAnualReturnRate, 2) * intialInvestmentValue;         // calculate the expected investment reture value for two years.
                double fiveYearsValue = Math.Pow(effAnualReturnRate, 5) * intialInvestmentValue;        // calculate the expected investment reture value for five years.


                // Display the outputs of expected investment return value for six month, one year, two year and five years.

                txtSixMonths.Text = sixMonthsValue.ToString("c");
                txtOneYear.Text = oneYearValue.ToString("c");
                txtTwoYears.Text = twoYearsValue.ToString("c");
                txtFiveYears.Text = fiveYearsValue.ToString("c");
            }
            catch (Exception ex)
            {
                // Display the default error message.
                MessageBox.Show(ex.Message);

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // clear the input and output controls.
            txtStockName.Text = "";
            txtStockSymbol.Text = "";
            txtCostPerShare.Text = "";
            txtNumberOfShare.Text = "";
            txtAnnualReturnRate.Text = "";
            txtSixMonths.Text = "";
            txtOneYear.Text = "";
            txtTwoYears.Text = "";
            txtFiveYears.Text = "";

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close form.
            this.Close();
        }
    }
}
