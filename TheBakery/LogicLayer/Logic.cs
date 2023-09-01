using System.Text.RegularExpressions;
using System;
using TheBakery.DataAccessLayer;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using BCrypt.Net;

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
        /// This is the first validator for a user login
        /// isValid => Check user in DB and get UserRole
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool UserInputValidator(string userName, string password)
        {
            bool isValid = true;
            //string passwordRegex = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{12,}$";
            // ? Do we need to do the password complexity check here also?
            if (String.IsNullOrEmpty(userName))
            {
                isValid = !isValid;
            }
            return isValid;
        }
        /// <summary>
        /// This method returns a enum value 
        /// for the string returned from DAL method LogUserInAndGetUserRole()
        /// Next time create class RoleManager, validator and login will be member methods inside it
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
    /// <summary>
    /// This time, Password Manager only takes in a user input password and the retrieved salt 
    /// then hash it and returnto UserManager/LogUserInAndGetUserRole for further varification 
    /// </summary>
    public class PasswordManager
    {

        /// <summary>
        /// Takes in input password ans salt, returns the hased password
        /// 
        /// ======================STATIC METHOD===========================
        /// When a method is declared as static, 
        /// it belongs to the class itself rather than an instance of the class.
        /// Static methods can be called without creating an instance of the class. 
        /// You can call them using the class name directly.
        /// Marking it as static allows you to call this method 
        /// without creating an instance of the PasswordManager class.
        /// 
        /// </summary>
        /// <param name="password"></param>
        /// <param name="salt"></param>
        /// <returns></returns>
        public static string HashPassword(string password, string salt)
        {
            return BCrypt.Net.BCrypt.HashPassword(password, salt);
            /*
             * in DAL, static allows you to call this method 
             * without creating an instance of the PasswordManager class.
             * 
             * string hashedPassword = PasswordManager.HashPassword(password, salt);
             * 
             * don't use the static keyword and instead make it an instance method (non-static), 
             * you would need to create an instance of the PasswordManager class to use the method:
             * 
             * PasswordManager passwordManager = new PasswordManager();
             * string hashedPassword = passwordManager.HashPassword(password, salt);
             */
        }
    }
}
