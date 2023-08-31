using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheBakery.DataAccessLayer;
using TheBakery.LogicLayer;

namespace TheBakery.GUI
{
    public partial class LoginFormV2 : Form
    {
        public LoginFormV2()
        {
            InitializeComponent();
        }
        string connextionString = @"Data Source=ZBC-S-tian0247\SQLEXPRESS;Initial Catalog=TheBakery;Integrated Security=True";

        private void InputUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputPassword_TextChanged(object sender, EventArgs e)
        {

        }

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
                URole userRole = uLogin.RoleForWindowNavigator();

                // Window navigator is part of the presentation logic

                MessageBox.Show(userRole.ToString());
                //switch (userRole)
                //{
                //    case URole.Admin:
                //        {
                //            //TheBakery obj = new TheBakery();
                //            //obj.Show();
                //            //this.Hide();
                //            break;
                //        }
                //    case URole.Staff:
                //        {
                //            //TheBakery obj = new TheBakery();
                //            //obj.Show();
                //            //this.Hide();
                //            break;
                //        }
                //    case URole.Customer:
                //        {
                //            TheBakery obj = new TheBakery();
                //            obj.Show();
                //            this.Hide();
                //            break;
                //        }
                //    case URole.None:
                //        {
                            
                //            break;
                //        }
                //}
            }
        }

        private void CancleButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Invalid input.");
        }
    }
}
