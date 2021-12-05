
namespace FlightManager
{
    partial class LoginForm
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
            this.usrtxt = new System.Windows.Forms.TextBox();
            this.usrpwtxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // usrtxt
            // 
            this.usrtxt.Location = new System.Drawing.Point(157, 83);
            this.usrtxt.Name = "usrtxt";
            this.usrtxt.Size = new System.Drawing.Size(174, 29);
            this.usrtxt.TabIndex = 2;
            this.usrtxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // usrpwtxt
            // 
            this.usrpwtxt.Location = new System.Drawing.Point(157, 124);
            this.usrpwtxt.Name = "usrpwtxt";
            this.usrpwtxt.PasswordChar = '*';
            this.usrpwtxt.Size = new System.Drawing.Size(174, 29);
            this.usrpwtxt.TabIndex = 3;
            this.usrpwtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usrpwtxt_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 264);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usrpwtxt);
            this.Controls.Add(this.usrtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.VisibleChanged += new System.EventHandler(this.LoginForm_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usrtxt;
        private System.Windows.Forms.TextBox usrpwtxt;
        private System.Windows.Forms.Button button1;
    }
}

