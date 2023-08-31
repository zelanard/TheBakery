using System.Text.RegularExpressions;
using System;
using TheBakery.DataAccessLayer;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace TheBakery.LogicLayer
{
    public class Logic
    {
        //readonly DataAccess UserItems = new DataAccess();
        //public object[] GetProducts(string Category)
        //{
        //    return UserItems.GetProducts(Category);
        //}
    }

   

    public class UserLogIn
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        private Users dalUser = new Users();
        
        /// <summary>
        /// User input validation:
        /// Username: not null
        /// Password: at least 12 chars, includes special symbols, chars and nums
        /// isValid => Check user and get UserRole
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool UserInputValidator(string userName, string password)
        {
            bool isValid = true;
            //string passwordRegex = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{12,}$";

            if (String.IsNullOrEmpty(userName))
            {
                isValid = !isValid;
            }
            return isValid;
        }
        /// <summary>
        /// This method returns a enum value for the 
        /// 
        /// </summary>
        /// <returns></returns>
        public URole RoleForWindowNavigator()// here is logic, return result to GUI to navigate
        {

            
            try
            {
                URole userRole;
                userRole = (URole)Enum.Parse(typeof(URole), dalUser.LogUserInAndGetUserRole(UserName, Password));
                return userRole;
            }
            catch
            {
                MessageBox.Show("Fail to define a user role.");
            }
            return URole.None;
        }        
    }
    // ENUM for UserRoles
    public enum URole
    {
        Admin,
        Staff,
        Customer,
        None
    }


}
