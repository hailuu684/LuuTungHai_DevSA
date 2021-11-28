
namespace FlightManager
{
    partial class CustomerDetails
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
            this.customerDetailsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.customerFullName = new System.Windows.Forms.TextBox();
            this.customerEmail = new System.Windows.Forms.TextBox();
            this.customerSex = new System.Windows.Forms.TextBox();
            this.customerDocNr = new System.Windows.Forms.TextBox();
            this.customerPhoneNr = new System.Windows.Forms.TextBox();
            this.customerDatePicker = new System.Windows.Forms.DateTimePicker();
            this.CustomerDetailsSaveButton = new System.Windows.Forms.Button();
            this.customerUpdateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerDetailsLabel
            // 
            this.customerDetailsLabel.AutoSize = true;
            this.customerDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerDetailsLabel.Location = new System.Drawing.Point(64, 54);
            this.customerDetailsLabel.Name = "customerDetailsLabel";
            this.customerDetailsLabel.Size = new System.Drawing.Size(285, 39);
            this.customerDetailsLabel.TabIndex = 0;
            this.customerDetailsLabel.Text = "Customer Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date of birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Document number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phone number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 30);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sex";
            // 
            // customerFullName
            // 
            this.customerFullName.Location = new System.Drawing.Point(354, 136);
            this.customerFullName.Name = "customerFullName";
            this.customerFullName.Size = new System.Drawing.Size(343, 29);
            this.customerFullName.TabIndex = 7;
            // 
            // customerEmail
            // 
            this.customerEmail.Location = new System.Drawing.Point(354, 368);
            this.customerEmail.Name = "customerEmail";
            this.customerEmail.Size = new System.Drawing.Size(343, 29);
            this.customerEmail.TabIndex = 9;
            // 
            // customerSex
            // 
            this.customerSex.Location = new System.Drawing.Point(354, 248);
            this.customerSex.Name = "customerSex";
            this.customerSex.Size = new System.Drawing.Size(343, 29);
            this.customerSex.TabIndex = 10;
            // 
            // customerDocNr
            // 
            this.customerDocNr.Location = new System.Drawing.Point(354, 308);
            this.customerDocNr.Name = "customerDocNr";
            this.customerDocNr.Size = new System.Drawing.Size(343, 29);
            this.customerDocNr.TabIndex = 11;
            // 
            // customerPhoneNr
            // 
            this.customerPhoneNr.Location = new System.Drawing.Point(354, 420);
            this.customerPhoneNr.Name = "customerPhoneNr";
            this.customerPhoneNr.Size = new System.Drawing.Size(343, 29);
            this.customerPhoneNr.TabIndex = 12;
            // 
            // customerDatePicker
            // 
            this.customerDatePicker.Location = new System.Drawing.Point(354, 193);
            this.customerDatePicker.Name = "customerDatePicker";
            this.customerDatePicker.Size = new System.Drawing.Size(343, 29);
            this.customerDatePicker.TabIndex = 14;
            // 
            // CustomerDetailsSaveButton
            // 
            this.CustomerDetailsSaveButton.Location = new System.Drawing.Point(198, 498);
            this.CustomerDetailsSaveButton.Name = "CustomerDetailsSaveButton";
            this.CustomerDetailsSaveButton.Size = new System.Drawing.Size(183, 45);
            this.CustomerDetailsSaveButton.TabIndex = 15;
            this.CustomerDetailsSaveButton.Text = "Save";
            this.CustomerDetailsSaveButton.UseVisualStyleBackColor = true;
            this.CustomerDetailsSaveButton.Click += new System.EventHandler(this.CustomerDetailsSaveButton_Click);
            // 
            // customerUpdateButton
            // 
            this.customerUpdateButton.Location = new System.Drawing.Point(454, 498);
            this.customerUpdateButton.Name = "customerUpdateButton";
            this.customerUpdateButton.Size = new System.Drawing.Size(182, 45);
            this.customerUpdateButton.TabIndex = 16;
            this.customerUpdateButton.Text = "Update";
            this.customerUpdateButton.UseVisualStyleBackColor = true;
            this.customerUpdateButton.Click += new System.EventHandler(this.customerUpdateButton_Click);
            // 
            // CustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 604);
            this.Controls.Add(this.customerUpdateButton);
            this.Controls.Add(this.CustomerDetailsSaveButton);
            this.Controls.Add(this.customerDatePicker);
            this.Controls.Add(this.customerPhoneNr);
            this.Controls.Add(this.customerDocNr);
            this.Controls.Add(this.customerSex);
            this.Controls.Add(this.customerEmail);
            this.Controls.Add(this.customerFullName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerDetailsLabel);
            this.Name = "CustomerDetails";
            this.Text = "Customer details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerDetailsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox customerFullName;
        private System.Windows.Forms.TextBox customerEmail;
        private System.Windows.Forms.TextBox customerSex;
        private System.Windows.Forms.TextBox customerDocNr;
        private System.Windows.Forms.TextBox customerPhoneNr;
        private System.Windows.Forms.DateTimePicker customerDatePicker;
        private System.Windows.Forms.Button CustomerDetailsSaveButton;
        private System.Windows.Forms.Button customerUpdateButton;
    }
}