namespace TheBakery.GUI
{
    partial class LoginFormV2
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Label();
            this.InputPassword = new System.Windows.Forms.TextBox();
            this.InputUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ViewPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(62, 30);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(135, 45);
            this.WelcomeLabel.TabIndex = 1;
            this.WelcomeLabel.Text = "Welcome to the Bakery!\r\n\r\nPlease log in.";
            // 
            // Register
            // 
            this.Register.AutoSize = true;
            this.Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register.Location = new System.Drawing.Point(63, 87);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(181, 13);
            this.Register.TabIndex = 16;
            this.Register.Text = "Not a member? Click here to register.";
            // 
            // InputPassword
            // 
            this.InputPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputPassword.Location = new System.Drawing.Point(144, 155);
            this.InputPassword.Name = "InputPassword";
            this.InputPassword.Size = new System.Drawing.Size(110, 23);
            this.InputPassword.TabIndex = 12;
            this.InputPassword.UseSystemPasswordChar = true;
            // 
            // InputUserName
            // 
            this.InputUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputUserName.Location = new System.Drawing.Point(144, 123);
            this.InputUserName.Name = "InputUserName";
            this.InputUserName.Size = new System.Drawing.Size(110, 23);
            this.InputUserName.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Username";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(122, 197);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 17;
            this.SubmitButton.Text = "Login";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ViewPassword
            // 
            this.ViewPassword.AutoSize = true;
            this.ViewPassword.BackColor = System.Drawing.Color.Transparent;
            this.ViewPassword.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ViewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewPassword.Location = new System.Drawing.Point(228, 156);
            this.ViewPassword.Margin = new System.Windows.Forms.Padding(0);
            this.ViewPassword.Name = "ViewPassword";
            this.ViewPassword.Size = new System.Drawing.Size(25, 20);
            this.ViewPassword.TabIndex = 19;
            this.ViewPassword.Text = "👁️";
            this.ViewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ViewPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPassword_Click);
            this.ViewPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPassword_Click);
            // 
            // LoginFormV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(316, 263);
            this.Controls.Add(this.ViewPassword);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.InputPassword);
            this.Controls.Add(this.InputUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "LoginFormV2";
            this.Text = "Welcome to the Bakery 🎂";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label Register;
        private System.Windows.Forms.TextBox InputPassword;
        private System.Windows.Forms.TextBox InputUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label ViewPassword;
    }
}