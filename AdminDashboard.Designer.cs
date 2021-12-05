
namespace FlightManager
{
    partial class AdminDashboard
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
            this.AddUserButton = new System.Windows.Forms.Button();
            this.AddFlightButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Admin";
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(35, 132);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(150, 39);
            this.AddUserButton.TabIndex = 1;
            this.AddUserButton.Text = "Add new user";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // AddFlightButton
            // 
            this.AddFlightButton.Location = new System.Drawing.Point(237, 132);
            this.AddFlightButton.Name = "AddFlightButton";
            this.AddFlightButton.Size = new System.Drawing.Size(150, 39);
            this.AddFlightButton.TabIndex = 2;
            this.AddFlightButton.Text = "Add new flight";
            this.AddFlightButton.UseVisualStyleBackColor = true;
            this.AddFlightButton.Click += new System.EventHandler(this.AddFlightButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(445, 132);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(150, 39);
            this.LogOutButton.TabIndex = 3;
            this.LogOutButton.Text = "Log out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 211);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.AddFlightButton);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.label1);
            this.Name = "AdminDashboard";
            this.Text = "Admin dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Button AddFlightButton;
        private System.Windows.Forms.Button LogOutButton;
    }
}