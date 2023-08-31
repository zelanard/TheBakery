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
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.radioButtonStaff = new System.Windows.Forms.RadioButton();
            this.radioButtonCustomer = new System.Windows.Forms.RadioButton();
            this.InputPassword = new System.Windows.Forms.TextBox();
            this.InputUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CancleButton = new System.Windows.Forms.Button();
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
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.Location = new System.Drawing.Point(225, 197);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(54, 17);
            this.radioButtonAdmin.TabIndex = 15;
            this.radioButtonAdmin.Text = "Admin";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            // 
            // radioButtonStaff
            // 
            this.radioButtonStaff.AutoSize = true;
            this.radioButtonStaff.Location = new System.Drawing.Point(144, 197);
            this.radioButtonStaff.Name = "radioButtonStaff";
            this.radioButtonStaff.Size = new System.Drawing.Size(47, 17);
            this.radioButtonStaff.TabIndex = 14;
            this.radioButtonStaff.Text = "Staff";
            this.radioButtonStaff.UseVisualStyleBackColor = true;
            // 
            // radioButtonCustomer
            // 
            this.radioButtonCustomer.AutoSize = true;
            this.radioButtonCustomer.Checked = true;
            this.radioButtonCustomer.Location = new System.Drawing.Point(50, 197);
            this.radioButtonCustomer.Name = "radioButtonCustomer";
            this.radioButtonCustomer.Size = new System.Drawing.Size(69, 17);
            this.radioButtonCustomer.TabIndex = 13;
            this.radioButtonCustomer.TabStop = true;
            this.radioButtonCustomer.Text = "Customer";
            this.radioButtonCustomer.UseVisualStyleBackColor = true;
            // 
            // InputPassword
            // 
            this.InputPassword.Location = new System.Drawing.Point(144, 157);
            this.InputPassword.Name = "InputPassword";
            this.InputPassword.Size = new System.Drawing.Size(100, 20);
            this.InputPassword.TabIndex = 12;
            this.InputPassword.TextChanged += new System.EventHandler(this.InputPassword_TextChanged);
            // 
            // InputUserName
            // 
            this.InputUserName.Location = new System.Drawing.Point(144, 125);
            this.InputUserName.Name = "InputUserName";
            this.InputUserName.Size = new System.Drawing.Size(100, 20);
            this.InputUserName.TabIndex = 11;
            this.InputUserName.TextChanged += new System.EventHandler(this.InputUserName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Username";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(69, 229);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 17;
            this.SubmitButton.Text = "Login";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CancleButton
            // 
            this.CancleButton.Location = new System.Drawing.Point(172, 229);
            this.CancleButton.Name = "CancleButton";
            this.CancleButton.Size = new System.Drawing.Size(75, 23);
            this.CancleButton.TabIndex = 18;
            this.CancleButton.Text = "Cancle";
            this.CancleButton.UseVisualStyleBackColor = true;
            this.CancleButton.Click += new System.EventHandler(this.CancleButton_Click);
            // 
            // LoginFormV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 281);
            this.Controls.Add(this.CancleButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.radioButtonAdmin);
            this.Controls.Add(this.radioButtonStaff);
            this.Controls.Add(this.radioButtonCustomer);
            this.Controls.Add(this.InputPassword);
            this.Controls.Add(this.InputUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "LoginFormV2";
            this.Text = "LoginFormV2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label Register;
        private System.Windows.Forms.RadioButton radioButtonAdmin;
        private System.Windows.Forms.RadioButton radioButtonStaff;
        private System.Windows.Forms.RadioButton radioButtonCustomer;
        private System.Windows.Forms.TextBox InputPassword;
        private System.Windows.Forms.TextBox InputUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CancleButton;
    }
}