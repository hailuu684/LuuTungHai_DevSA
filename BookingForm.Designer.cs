﻿
namespace FlightManager
{
    partial class BookingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.customerFullName = new System.Windows.Forms.TextBox();
            this.customerPhoneNr = new System.Windows.Forms.TextBox();
            this.customerEmail = new System.Windows.Forms.TextBox();
            this.customerSex = new System.Windows.Forms.TextBox();
            this.customerDocNr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.customerDatePicker = new System.Windows.Forms.DateTimePicker();
            this.bookButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date of birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sex";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Document number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(245, 39);
            this.label7.TabIndex = 6;
            this.label7.Text = "Customer data";
            // 
            // customerFullName
            // 
            this.customerFullName.Location = new System.Drawing.Point(293, 77);
            this.customerFullName.Name = "customerFullName";
            this.customerFullName.Size = new System.Drawing.Size(279, 29);
            this.customerFullName.TabIndex = 7;
            this.customerFullName.TextChanged += new System.EventHandler(this.customerFullName_TextChanged);
            // 
            // customerPhoneNr
            // 
            this.customerPhoneNr.Location = new System.Drawing.Point(293, 158);
            this.customerPhoneNr.Name = "customerPhoneNr";
            this.customerPhoneNr.Size = new System.Drawing.Size(279, 29);
            this.customerPhoneNr.TabIndex = 9;
            this.customerPhoneNr.TextChanged += new System.EventHandler(this.customerPhoneNr_TextChanged);
            // 
            // customerEmail
            // 
            this.customerEmail.Location = new System.Drawing.Point(293, 198);
            this.customerEmail.Name = "customerEmail";
            this.customerEmail.Size = new System.Drawing.Size(279, 29);
            this.customerEmail.TabIndex = 10;
            this.customerEmail.TextChanged += new System.EventHandler(this.customerEmail_TextChanged);
            // 
            // customerSex
            // 
            this.customerSex.Location = new System.Drawing.Point(293, 239);
            this.customerSex.Name = "customerSex";
            this.customerSex.Size = new System.Drawing.Size(279, 29);
            this.customerSex.TabIndex = 11;
            this.customerSex.TextChanged += new System.EventHandler(this.customerSex_TextChanged);
            // 
            // customerDocNr
            // 
            this.customerDocNr.Location = new System.Drawing.Point(293, 280);
            this.customerDocNr.Name = "customerDocNr";
            this.customerDocNr.Size = new System.Drawing.Size(279, 29);
            this.customerDocNr.TabIndex = 12;
            this.customerDocNr.TextChanged += new System.EventHandler(this.customerDocNr_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(230, 30);
            this.label8.TabIndex = 13;
            this.label8.Text = "Number of luggage";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(293, 365);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 32);
            this.comboBox1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "Calculate price";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(129, 510);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 32);
            this.label9.TabIndex = 16;
            this.label9.Text = "Price";
            // 
            // priceBox
            // 
            this.priceBox.Enabled = false;
            this.priceBox.Location = new System.Drawing.Point(266, 510);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(180, 29);
            this.priceBox.TabIndex = 18;
            // 
            // customerDatePicker
            // 
            this.customerDatePicker.Location = new System.Drawing.Point(293, 117);
            this.customerDatePicker.Name = "customerDatePicker";
            this.customerDatePicker.Size = new System.Drawing.Size(279, 29);
            this.customerDatePicker.TabIndex = 19;
            this.customerDatePicker.ValueChanged += new System.EventHandler(this.customerDatePicker_ValueChanged);
            // 
            // bookButton
            // 
            this.bookButton.Location = new System.Drawing.Point(177, 604);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(255, 54);
            this.bookButton.TabIndex = 20;
            this.bookButton.Text = "Book flight";
            this.bookButton.UseVisualStyleBackColor = true;
            this.bookButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 689);
            this.Controls.Add(this.bookButton);
            this.Controls.Add(this.customerDatePicker);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.customerDocNr);
            this.Controls.Add(this.customerSex);
            this.Controls.Add(this.customerEmail);
            this.Controls.Add(this.customerPhoneNr);
            this.Controls.Add(this.customerFullName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BookingForm";
            this.Text = "BookingForm";
            this.Load += new System.EventHandler(this.BookingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox customerFullName;
        private System.Windows.Forms.TextBox customerPhoneNr;
        private System.Windows.Forms.TextBox customerEmail;
        private System.Windows.Forms.TextBox customerSex;
        private System.Windows.Forms.TextBox customerDocNr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.DateTimePicker customerDatePicker;
        private System.Windows.Forms.Button bookButton;
    }
}