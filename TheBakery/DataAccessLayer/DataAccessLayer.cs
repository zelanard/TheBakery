using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;


namespace TheBakery.DataAccessLayer
{
    /// <summary>
    /// Collect data from the database.
    /// </summary>
    public static class DataAccess
    {
        public const string DB_CONNECTION_STRING = @"Data Source=BALDER\MSSQLSERVER01;Initial Catalog=TheBakery;Integrated Security=True";
        /// <summary>
        /// The data below within the whole class is what goes into the list the Gui displays
        /// any number or sign typed here will alter the outcome of the display results.
        /// </summary>
        /// <param name="CategoryId"></param>
        /// <returns>Array of products</returns>
        public static Product[] GetProducts(int CategoryId)
        {
            string SelectRecipes = $"EXEC dbo.SelectRecipeByCategory {CategoryId}";
            List<Product> Products = new List<Product>();

            using (SqlConnection conn = new SqlConnection(DB_CONNECTION_STRING))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(SelectRecipes, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) // Loop through each row
                        {
                            Recipes Recipe = new Recipes
                            {
                                RecipesName = reader["RecipesName"].ToString(),
                                Price = float.Parse(reader["Price"].ToString()),
                                Tempratures = int.Parse(reader["Tempratures"].ToString()),
                                Portions = int.Parse(reader["Portions"].ToString()),
                                PrepTimeMin = int.Parse(reader["PrepTimeMin"].ToString()),
                                RecipeId = int.Parse(reader["RecipieId"].ToString()),
                                Refs = reader["Refs"].ToString()
                            };

                            Product product = new Product(Recipe);
                            Products.Add(product); // Add the product to the list
                        }
                    }
                }
            }
            return Products.ToArray();
        }
        /// <summary>
        /// Looks up categories in the database.
        /// </summary>
        /// <returns>String Array containing all categories</returns>
        public static string[] GetListOfCategories()
        {
            string SelectCategories = $"EXEC dbo.SelectCategories";
            List<string> Categories = new List<string>();

            using (SqlConnection conn = new SqlConnection(DB_CONNECTION_STRING))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(SelectCategories, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) // Loop through each row
                        {
                            Categories.Add(reader["CategoryName"].ToString());
                        }
                    }
                }
            }
            return Categories.ToArray();
        }
    }

    /****************************************************************
     * Here Be Logic: All of this should be moved to the logic layer!
     ***************************************************************/

    /// <summary>
    /// Product Data Item
    /// </summary>
    public class Product
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public Recipes Recipe { get; set; }
        public Product(Recipes res)
        {
            this.Recipe = res;
            this.ProductId = res.RecipeId;
            this.Name = res.RecipesName;
            this.Price = res.Price.ToString();
            this.Description = CreateDescription(res);
        }
        private string CreateDescription(Recipes res)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("PrepTime: " + res.PrepTimeMin.ToString() + " ");
            sb.Append("Portions: " + res.Portions.ToString());
            return sb.ToString();
        }
    }

    /// <summary>
    /// Contains Recipie Data
    /// </summary>
    public class Recipes
    {
        public int RecipeId { get; set; }
        public string RecipesName { get; set; }
        public float Portions { get; set; }
        public int Tempratures { get; set; }
        public int PrepTimeMin { get; set; }
        public float Price { get; set; }
        public string Refs { get; set; }
    }

    /// <summary>
    /// Control User Login and User Roles.
    /// </summary>
    public class Users
    {
        /// <summary>
        /// THIS SHOULE BE PART OF THE BLL: 
        /// HERE IS THE UerDataAccess class
        /// create an instace of User from BLL, 
        /// here is a method GetUser then return user to BLL
        /// 
        /// Method has two functions: 
        /// 1. LogUserIn
        /// 2. if success => GetUserRole => return to BLL
        ///  (next time seperate the two methods for better organization and modularity)
        /// 
        /// In BLL method RoleForWindowNavigator() gets the string return from here and convert to Enum
        /// In GUI new a BLL instance, call BLL method RoleForWindowNavigator()
        /// 
        /// Method to get user role and return BLL, GUI to detemine which userinterface is shown
        /// 
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string LogUserInAndGetUserRole(string userName, string password)
        {
            string connectionString = DataAccess.DB_CONNECTION_STRING;
            string userRole = "Wrong username or password.";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string selectCommand = "SELECT EMail From Users WHERE Username = (@Username) AND PASSWORD = (@Password)";

                /** ----------------------------------- Salt and hashed version ---------------------------------------
                // Now we can not select the password direct, so only find the EMail
                // We also need to retrieve corresponding salt for the specific user from the DB
                // string selectCommand = "SELECT Username, PASSWORD, Salt From Users WHERE Username = (@Username)";
                // ---------------------------------------------------------------------------------------------------*/

                using (SqlCommand sCommand = new SqlCommand(selectCommand, conn))
                {
                    sCommand.Parameters.AddWithValue("@Username", userName);
                    sCommand.Parameters.AddWithValue("@PASSWORD", password);

                    /** ---------------- Salt and hashed version------------------
                    // We only +need to add UserNamer here
                    // sCommand.Parameters.AddWithValue("@Username", userName);
                    // ----------------------------------------------------------*/

                    /* Use of DataReader,when you need to retrieve multiple rows of data from a query result 
                     * or when you need to iterate over a result set,
                     * or For more complex queries that involve multiple queries executed sequentially, 
                     * you might need separate SqlDataReader instances for each query result.
                     * 
                     * In cases where you are fetching a single value (such as with SELECT COUNT(*) or SELECT MAX(column) queries) 
                     * or if you're using ExecuteScalar() to fetch a single value, you don't necessarily need a separate SqlDataReader. 
                     */
                    SqlDataReader reader = sCommand.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            // Get user email of the logged in user
                            string userEMail = reader["EMail"].ToString();

                            /** ------------------------------ Salt and hashed version-----------------------------
                            // string storedHashedPassword = reader["PASSWORD"].ToString();
                            // string storedSalt = reader["Salt"].ToString();
                            // string userEMail = reader["EMail"].ToString();*/

                            // reader.Close();

                            /* ----- Hashed password by User Input using retrieved salt --------
                             * string enteredHashedPassword = PasswordManager.HashPassword(password, storedSalt);
                             * 
                             * ----- Compare Hashed password by User Input and Stroed PASSWORD --------
                             * if (enteredHashedPassword = storedHashedPassword)
                             *    {
                             *         // Retrieve userRole and return
                             *    }
                            */
                            // -----------------------------------------------------------------------------------

                            /* If a list of users is needed in the GUI, create new instaces and fill the data fetched fro DB
                            * Create User class in BLL, then new an instance in DAL => return to BLL => show in GUI
                            * Users user = new Users();
                            * user.EMail = userEMail;

                            * !! Close the DataReader before executing the second qurey roleIDQuery
                            */
                            reader.Close();

                            // get connection for the seceond query to retrieve RoleID through EMail
                            string roleIDQuery = $"SELECT RoleID FROM UsersRoles WHERE EMail = (@userEMail)";
                            using (SqlCommand roleIDCommand = new SqlCommand(roleIDQuery, conn))
                            {
                                roleIDCommand.Parameters.AddWithValue("@UserEMail", userEMail);

                                object RoleID = roleIDCommand.ExecuteScalar();

                                if (RoleID != null)
                                {
                                    int userRoleID = Convert.ToInt32(RoleID);

                                    /* Rretrieve RoleName by userRoleID in table Roles
                                     * Single Value with ExecuteScalar(): If you're fetching a single value from a query result, 
                                     * such as when using SELECT COUNT(*) or SELECT MAX(column), 
                                     * and you're using ExecuteScalar() to directly retrieve that value, you don't need a separate SqlDataReader.
                                     * 
                                     */
                                    string roleQuery = "SELECT RoleName FROM Roles WHERE RoleID = (@UserRoleID)";
                                    using (SqlCommand roleCommand = new SqlCommand(roleQuery, conn))
                                    {
                                        roleCommand.Parameters.AddWithValue("@UserRoleID", userRoleID);
                                        object RoleName = roleCommand.ExecuteScalar();

                                        if (RoleName != null)
                                        {
                                            return RoleName.ToString();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return userRole;
        }
    }
}
