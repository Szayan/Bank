namespace Bank
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
            this.titel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Deposittxt = new System.Windows.Forms.TextBox();
            this.WeeksTxt = new System.Windows.Forms.TextBox();
            this.TotalBalance = new System.Windows.Forms.Label();
            this.deposit = new System.Windows.Forms.Button();
            this.Balance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Wallet = new System.Windows.Forms.TextBox();
            this.Withdraw = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.NewBalance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // titel
            // 
            this.titel.AutoSize = true;
            this.titel.BackColor = System.Drawing.Color.White;
            this.titel.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titel.Location = new System.Drawing.Point(12, 9);
            this.titel.Name = "titel";
            this.titel.Size = new System.Drawing.Size(174, 35);
            this.titel.TabIndex = 0;
            this.titel.Text = "Shayan Bank";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount to deposit";
            // 
            // Deposittxt
            // 
            this.Deposittxt.Location = new System.Drawing.Point(62, 39);
            this.Deposittxt.Name = "Deposittxt";
            this.Deposittxt.Size = new System.Drawing.Size(176, 20);
            this.Deposittxt.TabIndex = 2;
            // 
            // WeeksTxt
            // 
            this.WeeksTxt.Location = new System.Drawing.Point(62, 105);
            this.WeeksTxt.Name = "WeeksTxt";
            this.WeeksTxt.Size = new System.Drawing.Size(174, 20);
            this.WeeksTxt.TabIndex = 3;
            // 
            // TotalBalance
            // 
            this.TotalBalance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TotalBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBalance.Location = new System.Drawing.Point(287, 34);
            this.TotalBalance.Name = "TotalBalance";
            this.TotalBalance.Size = new System.Drawing.Size(149, 25);
            this.TotalBalance.TabIndex = 4;
            this.TotalBalance.Text = "Total balance";
            // 
            // deposit
            // 
            this.deposit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deposit.ForeColor = System.Drawing.Color.Red;
            this.deposit.Location = new System.Drawing.Point(305, 90);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(109, 46);
            this.deposit.TabIndex = 5;
            this.deposit.Text = "Deposit";
            this.deposit.UseVisualStyleBackColor = false;
            this.deposit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Balance
            // 
            this.Balance.Location = new System.Drawing.Point(276, 62);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(174, 20);
            this.Balance.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Amount of weeks";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.deposit);
            this.panel1.Controls.Add(this.Balance);
            this.panel1.Controls.Add(this.TotalBalance);
            this.panel1.Controls.Add(this.WeeksTxt);
            this.panel1.Controls.Add(this.Deposittxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 161);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Wallet);
            this.panel2.Controls.Add(this.Withdraw);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(526, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 185);
            this.panel2.TabIndex = 9;
            // 
            // Wallet
            // 
            this.Wallet.Location = new System.Drawing.Point(40, 75);
            this.Wallet.Name = "Wallet";
            this.Wallet.Size = new System.Drawing.Size(174, 20);
            this.Wallet.TabIndex = 8;
            // 
            // Withdraw
            // 
            this.Withdraw.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Withdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Withdraw.ForeColor = System.Drawing.Color.Red;
            this.Withdraw.Location = new System.Drawing.Point(70, 103);
            this.Withdraw.Name = "Withdraw";
            this.Withdraw.Size = new System.Drawing.Size(109, 46);
            this.Withdraw.TabIndex = 8;
            this.Withdraw.Text = "Withdraw";
            this.Withdraw.UseVisualStyleBackColor = false;
            this.Withdraw.Click += new System.EventHandler(this.Withdraw_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(48, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "       Wallet";
            // 
            // NewBalance
            // 
            this.NewBalance.Location = new System.Drawing.Point(569, 65);
            this.NewBalance.Name = "NewBalance";
            this.NewBalance.Size = new System.Drawing.Size(174, 20);
            this.NewBalance.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(577, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = " New Balance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NewBalance);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Deposittxt;
        private System.Windows.Forms.TextBox WeeksTxt;
        private System.Windows.Forms.Label TotalBalance;
        private System.Windows.Forms.Button deposit;
        private System.Windows.Forms.TextBox Balance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Withdraw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Wallet;
        private System.Windows.Forms.TextBox NewBalance;
        private System.Windows.Forms.Label label4;
    }
}

