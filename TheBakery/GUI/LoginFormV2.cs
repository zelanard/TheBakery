using System;
using System.Windows.Forms;
using TheBakery.LogicLayer;

namespace TheBakery.GUI
{
    /// <summary>
    /// Form for logging into hte application.
    /// </summary>
    public partial class LoginFormV2 : Form
    {
        /// <summary>
        /// Login Form Constructor.
        /// </summary>
        public LoginFormV2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Check the username and password towards the username nad password in the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            
            UserLogIn uLogin = new UserLogIn();
            string userName = InputUserName.Text;
            string password = InputPassword.Text;

            //uLogin.UserName

            uLogin.UserName = userName;
            uLogin.Password = password;

            if (!uLogin.UserInputValidator(userName, password))
            {
                MessageBox.Show("Invalid input.");
            }
            else
            {
                DetermineUserRole(uLogin);
            }
        }

        /// <summary>
        /// Determines the logged in users role.
        /// </summary>
        /// <param name="uLogin"></param>
        private void DetermineUserRole(UserLogIn uLogin)
        {
            // In GUI new a BLL instance, call BLL method RoleForWindowNavigator()
            URole userRole = uLogin.RoleForWindowNavigator();

            // Window navigator is part of the presentation logic

            switch (userRole)
            {
                case URole.Admin:
                    {
                        //TheBakery obj = new TheBakery();
                        //obj.Show();
                        //this.Hide();
                        MessageBox.Show($"Hello, {userRole}");
                        break;
                    }
                case URole.Staff:
                    {
                        //TheBakery obj = new TheBakery();
                        //obj.Show();
                        //this.Hide();
                        MessageBox.Show($"Hello, {userRole}");
                        break;
                    }
                case URole.Custommer:
                    {
                        TheBakery obj = new TheBakery();
                        obj.Show();
                        this.Hide();
                        break;
                    }
                case URole.None:
                    {

                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        /// <summary>
        /// Navite to the register form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Register_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Navigate to the register form...");
        }

        /// <summary>
        /// While holding this button, show the password in plain text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewPassword_Click(object sender, EventArgs e)
        {
            InputPassword.UseSystemPasswordChar = !InputPassword.UseSystemPasswordChar;
            if (InputPassword.UseSystemPasswordChar)
            {this.ViewPassword.Text = "👁️";
            }
            else
            {
                this.ViewPassword.Text = "🔒";
                
            }
        }
    }
}
