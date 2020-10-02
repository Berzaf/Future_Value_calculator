namespace Future_Value_calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl = new System.Windows.Forms.Label();
            this.txtStockSymbol = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.lblStockSymbol = new System.Windows.Forms.Label();
            this.lblCostPerShare = new System.Windows.Forms.Label();
            this.txtCostPerShare = new System.Windows.Forms.TextBox();
            this.lblNumberOfShares = new System.Windows.Forms.Label();
            this.txtNumberOfShare = new System.Windows.Forms.TextBox();
            this.lblAnnualReturnRate = new System.Windows.Forms.Label();
            this.txtAnnualReturnRate = new System.Windows.Forms.TextBox();
            this.sixMonthsValue = new System.Windows.Forms.Label();
            this.txtSixMonths = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStockName = new System.Windows.Forms.TextBox();
            this.oneYearValue = new System.Windows.Forms.Label();
            this.txtOneYear = new System.Windows.Forms.TextBox();
            this.twoYearsValue = new System.Windows.Forms.Label();
            this.txtTwoYears = new System.Windows.Forms.TextBox();
            this.fiveYearsValue = new System.Windows.Forms.Label();
            this.txtFiveYears = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(302, 9);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(205, 18);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Expected Value Calculator";
            // 
            // txtStockSymbol
            // 
            this.txtStockSymbol.Location = new System.Drawing.Point(293, 77);
            this.txtStockSymbol.Name = "txtStockSymbol";
            this.txtStockSymbol.Size = new System.Drawing.Size(100, 20);
            this.txtStockSymbol.TabIndex = 7;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(24, 400);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // lblStockSymbol
            // 
            this.lblStockSymbol.AutoSize = true;
            this.lblStockSymbol.Location = new System.Drawing.Point(126, 77);
            this.lblStockSymbol.Name = "lblStockSymbol";
            this.lblStockSymbol.Size = new System.Drawing.Size(103, 13);
            this.lblStockSymbol.TabIndex = 9;
            this.lblStockSymbol.Text = "Enter Stock Symbol:";
            // 
            // lblCostPerShare
            // 
            this.lblCostPerShare.AutoSize = true;
            this.lblCostPerShare.Location = new System.Drawing.Point(126, 118);
            this.lblCostPerShare.Name = "lblCostPerShare";
            this.lblCostPerShare.Size = new System.Drawing.Size(109, 13);
            this.lblCostPerShare.TabIndex = 11;
            this.lblCostPerShare.Text = "Enter Cost Per Share:";
            // 
            // txtCostPerShare
            // 
            this.txtCostPerShare.Location = new System.Drawing.Point(293, 118);
            this.txtCostPerShare.Name = "txtCostPerShare";
            this.txtCostPerShare.Size = new System.Drawing.Size(100, 20);
            this.txtCostPerShare.TabIndex = 10;
            // 
            // lblNumberOfShares
            // 
            this.lblNumberOfShares.AutoSize = true;
            this.lblNumberOfShares.Location = new System.Drawing.Point(126, 163);
            this.lblNumberOfShares.Name = "lblNumberOfShares";
            this.lblNumberOfShares.Size = new System.Drawing.Size(123, 13);
            this.lblNumberOfShares.TabIndex = 13;
            this.lblNumberOfShares.Text = "Enter Number of Shares:";
            // 
            // txtNumberOfShare
            // 
            this.txtNumberOfShare.Location = new System.Drawing.Point(293, 163);
            this.txtNumberOfShare.Name = "txtNumberOfShare";
            this.txtNumberOfShare.Size = new System.Drawing.Size(100, 20);
            this.txtNumberOfShare.TabIndex = 12;
            // 
            // lblAnnualReturnRate
            // 
            this.lblAnnualReturnRate.AutoSize = true;
            this.lblAnnualReturnRate.Location = new System.Drawing.Point(126, 210);
            this.lblAnnualReturnRate.Name = "lblAnnualReturnRate";
            this.lblAnnualReturnRate.Size = new System.Drawing.Size(132, 13);
            this.lblAnnualReturnRate.TabIndex = 15;
            this.lblAnnualReturnRate.Text = "Enter Annual Return Rate:";
            // 
            // txtAnnualReturnRate
            // 
            this.txtAnnualReturnRate.Location = new System.Drawing.Point(293, 210);
            this.txtAnnualReturnRate.Name = "txtAnnualReturnRate";
            this.txtAnnualReturnRate.Size = new System.Drawing.Size(100, 20);
            this.txtAnnualReturnRate.TabIndex = 14;
            // 
            // sixMonthsValue
            // 
            this.sixMonthsValue.AutoSize = true;
            this.sixMonthsValue.Location = new System.Drawing.Point(482, 257);
            this.sixMonthsValue.Name = "sixMonthsValue";
            this.sixMonthsValue.Size = new System.Drawing.Size(79, 13);
            this.sixMonthsValue.TabIndex = 17;
            this.sixMonthsValue.Text = "After 6 Months:";
            // 
            // txtSixMonths
            // 
            this.txtSixMonths.Location = new System.Drawing.Point(622, 250);
            this.txtSixMonths.Name = "txtSixMonths";
            this.txtSixMonths.Size = new System.Drawing.Size(100, 20);
            this.txtSixMonths.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Enter Stock Name:";
            // 
            // txtStockName
            // 
            this.txtStockName.Location = new System.Drawing.Point(293, 41);
            this.txtStockName.Name = "txtStockName";
            this.txtStockName.Size = new System.Drawing.Size(100, 20);
            this.txtStockName.TabIndex = 18;
            // 
            // oneYearValue
            // 
            this.oneYearValue.AutoSize = true;
            this.oneYearValue.Location = new System.Drawing.Point(495, 283);
            this.oneYearValue.Name = "oneYearValue";
            this.oneYearValue.Size = new System.Drawing.Size(66, 13);
            this.oneYearValue.TabIndex = 21;
            this.oneYearValue.Text = "After 1 Year:";
            // 
            // txtOneYear
            // 
            this.txtOneYear.Location = new System.Drawing.Point(622, 276);
            this.txtOneYear.Name = "txtOneYear";
            this.txtOneYear.Size = new System.Drawing.Size(100, 20);
            this.txtOneYear.TabIndex = 20;
            // 
            // twoYearsValue
            // 
            this.twoYearsValue.AutoSize = true;
            this.twoYearsValue.Location = new System.Drawing.Point(490, 314);
            this.twoYearsValue.Name = "twoYearsValue";
            this.twoYearsValue.Size = new System.Drawing.Size(71, 13);
            this.twoYearsValue.TabIndex = 23;
            this.twoYearsValue.Text = "After 2 Years:";
            // 
            // txtTwoYears
            // 
            this.txtTwoYears.Location = new System.Drawing.Point(622, 307);
            this.txtTwoYears.Name = "txtTwoYears";
            this.txtTwoYears.Size = new System.Drawing.Size(100, 20);
            this.txtTwoYears.TabIndex = 22;
            // 
            // fiveYearsValue
            // 
            this.fiveYearsValue.AutoSize = true;
            this.fiveYearsValue.Location = new System.Drawing.Point(476, 344);
            this.fiveYearsValue.Name = "fiveYearsValue";
            this.fiveYearsValue.Size = new System.Drawing.Size(85, 13);
            this.fiveYearsValue.TabIndex = 25;
            this.fiveYearsValue.Text = "After Five Years:";
            // 
            // txtFiveYears
            // 
            this.txtFiveYears.Location = new System.Drawing.Point(622, 337);
            this.txtFiveYears.Name = "txtFiveYears";
            this.txtFiveYears.Size = new System.Drawing.Size(100, 20);
            this.txtFiveYears.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(440, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Calculated Expected Investment Return Value";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(183, 400);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 27;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(350, 400);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 28;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fiveYearsValue);
            this.Controls.Add(this.txtFiveYears);
            this.Controls.Add(this.twoYearsValue);
            this.Controls.Add(this.txtTwoYears);
            this.Controls.Add(this.oneYearValue);
            this.Controls.Add(this.txtOneYear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStockName);
            this.Controls.Add(this.sixMonthsValue);
            this.Controls.Add(this.txtSixMonths);
            this.Controls.Add(this.lblAnnualReturnRate);
            this.Controls.Add(this.txtAnnualReturnRate);
            this.Controls.Add(this.lblNumberOfShares);
            this.Controls.Add(this.txtNumberOfShare);
            this.Controls.Add(this.lblCostPerShare);
            this.Controls.Add(this.txtCostPerShare);
            this.Controls.Add(this.lblStockSymbol);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.txtStockSymbol);
            this.Controls.Add(this.lbl);
            this.Name = "Form1";
            this.Text = "Expected Value Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtStockSymbol;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label lblStockSymbol;
        private System.Windows.Forms.Label lblCostPerShare;
        private System.Windows.Forms.TextBox txtCostPerShare;
        private System.Windows.Forms.Label lblNumberOfShares;
        private System.Windows.Forms.TextBox txtNumberOfShare;
        private System.Windows.Forms.Label lblAnnualReturnRate;
        private System.Windows.Forms.TextBox txtAnnualReturnRate;
        private System.Windows.Forms.Label sixMonthsValue;
        private System.Windows.Forms.TextBox txtSixMonths;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStockName;
        private System.Windows.Forms.Label oneYearValue;
        private System.Windows.Forms.TextBox txtOneYear;
        private System.Windows.Forms.Label twoYearsValue;
        private System.Windows.Forms.TextBox txtTwoYears;
        private System.Windows.Forms.Label fiveYearsValue;
        private System.Windows.Forms.TextBox txtFiveYears;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

