namespace Bitcoin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.currencyMenu = new System.Windows.Forms.ComboBox();
            this.getRatesBtn = new System.Windows.Forms.Button();
            this.amountOfBtc = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.resultLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currencyMenu
            // 
            this.currencyMenu.FormattingEnabled = true;
            this.currencyMenu.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP"});
            this.currencyMenu.Location = new System.Drawing.Point(81, 84);
            this.currencyMenu.Name = "currencyMenu";
            this.currencyMenu.Size = new System.Drawing.Size(121, 21);
            this.currencyMenu.TabIndex = 0;
            this.currencyMenu.Text = "Select Currency";
            // 
            // getRatesBtn
            // 
            this.getRatesBtn.Location = new System.Drawing.Point(227, 132);
            this.getRatesBtn.Name = "getRatesBtn";
            this.getRatesBtn.Size = new System.Drawing.Size(75, 23);
            this.getRatesBtn.TabIndex = 1;
            this.getRatesBtn.Text = "Get Rates";
            this.getRatesBtn.UseVisualStyleBackColor = true;
            this.getRatesBtn.Click += new System.EventHandler(this.getRatesBtn_Click);
            // 
            // amountOfBtc
            // 
            this.amountOfBtc.Location = new System.Drawing.Point(81, 132);
            this.amountOfBtc.Name = "amountOfBtc";
            this.amountOfBtc.Size = new System.Drawing.Size(121, 20);
            this.amountOfBtc.TabIndex = 2;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(81, 246);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(121, 20);
            this.Result.TabIndex = 3;
            this.Result.Visible = false;
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(81, 227);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(37, 13);
            this.resultLbl.TabIndex = 4;
            this.resultLbl.Text = "Result";
            this.resultLbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.amountOfBtc);
            this.Controls.Add(this.getRatesBtn);
            this.Controls.Add(this.currencyMenu);
            this.Name = "Form1";
            this.Text = "Bitcoin Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox currencyMenu;
        private System.Windows.Forms.Button getRatesBtn;
        private System.Windows.Forms.TextBox amountOfBtc;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label resultLbl;
    }
}

