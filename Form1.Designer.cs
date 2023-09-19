namespace Loan_calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtLoanAmount = new TextBox();
            txtDownPayment = new TextBox();
            label2 = new Label();
            txtTerms = new TextBox();
            label3 = new Label();
            txtInterestRate = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btnMortgage = new Button();
            btnAuto = new Button();
            lblMonthlyPayment = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 81);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 0;
            label1.Text = "Loan Amount";
            // 
            // txtLoanAmount
            // 
            txtLoanAmount.Location = new Point(314, 82);
            txtLoanAmount.Name = "txtLoanAmount";
            txtLoanAmount.Size = new Size(216, 27);
            txtLoanAmount.TabIndex = 1;
            // 
            // txtDownPayment
            // 
            txtDownPayment.Location = new Point(314, 138);
            txtDownPayment.Name = "txtDownPayment";
            txtDownPayment.Size = new Size(216, 27);
            txtDownPayment.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 138);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 2;
            label2.Text = "Down Payment";
            // 
            // txtTerms
            // 
            txtTerms.Location = new Point(314, 245);
            txtTerms.Name = "txtTerms";
            txtTerms.Size = new Size(216, 27);
            txtTerms.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 245);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 6;
            label3.Text = "Terms in Years";
            // 
            // txtInterestRate
            // 
            txtInterestRate.Location = new Point(314, 189);
            txtInterestRate.Name = "txtInterestRate";
            txtInterestRate.Size = new Size(216, 27);
            txtInterestRate.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(142, 188);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(142, 192);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 8;
            label5.Text = "Interest Rate";
            // 
            // btnMortgage
            // 
            btnMortgage.Location = new Point(316, 293);
            btnMortgage.Name = "btnMortgage";
            btnMortgage.Size = new Size(94, 29);
            btnMortgage.TabIndex = 9;
            btnMortgage.Text = "Mortgage";
            btnMortgage.UseVisualStyleBackColor = true;
            btnMortgage.Click += btnMortgage_Click;
            // 
            // btnAuto
            // 
            btnAuto.Location = new Point(436, 293);
            btnAuto.Name = "btnAuto";
            btnAuto.Size = new Size(94, 29);
            btnAuto.TabIndex = 10;
            btnAuto.Text = "Auto";
            btnAuto.UseVisualStyleBackColor = true;
            btnAuto.Click += btnAuto_Click;
            // 
            // lblMonthlyPayment
            // 
            lblMonthlyPayment.AutoSize = true;
            lblMonthlyPayment.Location = new Point(162, 345);
            lblMonthlyPayment.Name = "lblMonthlyPayment";
            lblMonthlyPayment.Size = new Size(144, 20);
            lblMonthlyPayment.TabIndex = 11;
            lblMonthlyPayment.Text = "Monthly payment : $";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMonthlyPayment);
            Controls.Add(btnAuto);
            Controls.Add(btnMortgage);
            Controls.Add(label5);
            Controls.Add(txtTerms);
            Controls.Add(label3);
            Controls.Add(txtInterestRate);
            Controls.Add(label4);
            Controls.Add(txtDownPayment);
            Controls.Add(label2);
            Controls.Add(txtLoanAmount);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLoanAmount;
        private TextBox txtDownPayment;
        private Label label2;
        private TextBox txtTerms;
        private Label label3;
        private TextBox txtInterestRate;
        private Label label4;
        private Label label5;
        private Button btnMortgage;
        private Button btnAuto;
        private Label lblMonthlyPayment;
    }
}