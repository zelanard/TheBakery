using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TheBakery.DataAccessLayer
{
    public class DataAccess
    {
        public const string DB_CONNECTION_STRING = @"Data Source=BALDER\MSSQLSERVER01;Initial Catalog=TheBakery;Integrated Security=True";
        public void ConnectToDatabase()
        {

        }

        //public Object[] Get(string Category)
        //{
        //    string SelectProducts = $"EXEC dbo.SelectProducts @Category = {Category}";
        //    List<Product> Products = new List<Product>();

        //    using (SqlConnection conn = new SqlConnection(DB_CONNECTION_STRING))
        //    {
        //        conn.Open();
        //        using (SqlCommand cmd = new SqlCommand(SelectProducts, conn))
        //        {
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //    return Products.ToArray();
        //}
    }

    public class Cities
    {
        int PostalCode { get; set; }
        string CName { get; set; }
    }

    public class Roles
    {
        int RoleId { get; set; }
        string RoleName { get; set; }
    }

    public class Product
    {
        int ProductId { get; set; }
        int Quantity { get; set; }
    }

    public class Recipes
    {
        int RecipeId { get; set; }
        string RecipesName { get; set; }
        float Portions { get; set; }
        int Tempratures { get; set; }
        int PrepTimeMin { get; set; }
        float Price { get; set; }
        string Refs { get; set; }
    }

    public class Bakeries
    {
        int BakeryId { get; set; }
        string BakeryName { get; set; }
    }

    public class Categories
    {
        int CategoryId { get; set; }
        string CategoryName { get; set; }
    }

    public class Persons
    {
        int PersonId { get; set; }
        string FristName { get; set; }
        string LastName { get; set; }
        string StreetAddress { get; set; }
        string Floor { get; set; }
        string Country { get; set; }
        Cities Cities { get; set; }

    }

    public class Users
    {
        string EMail { get; set; }
        string Username { get; set; }
        string PASSWORD { get; set; }
        string Tlf { get; set; }
        Persons Persons { get; set; }

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
            string connectionString = @"Data Source=ZBC-S-tian0247\SQLEXPRESS;Initial Catalog=TheBakery;Integrated Security=True";
            string userRole = "Wrong username or password.";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string selectCommand = "SELECT EMail From Users WHERE Username = (@Username) AND PASSWORD = (@Password)";

                // ----------------------------------- Salt and hashed version ---------------------------------------
                // Now we can not select the password direct, so only find the EMail
                // We also need to retrieve corresponding salt for the specific user from the DB
                // string selectCommand = "SELECT Username, PASSWORD, Salt From Users WHERE Username = (@Username)";
                // ---------------------------------------------------------------------------------------------------

                using (SqlCommand sCommand = new SqlCommand(selectCommand, conn))
                {
                    sCommand.Parameters.AddWithValue("@Username", userName);
                    sCommand.Parameters.AddWithValue("@PASSWORD", password);

                    // ---------------- Salt and hashed version------------------
                    // We only +need to add UserNamer here
                    // sCommand.Parameters.AddWithValue("@Username", userName);
                    // ----------------------------------------------------------

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

                            // ------------------------------ Salt and hashed version-----------------------------
                            // string storedHashedPassword = reader["PASSWORD"].ToString();
                            // string storedSalt = reader["Salt"].ToString();
                            // string userEMail = reader["EMail"].ToString();

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
    public class UsersRoles
    {
        int UserRoleId { get; set; }
        Users Users { get; set; }
        Roles Roles { get; set; }

    }

    public class Orders
    {
        int OrderId { get; set; }
        int FinalPrice { get; set; }
        DateTime PickupTime { get; set; }
        string Requirements { get; set; }
        string OrderStatus { get; set; }
        DateTime OrderPlaced { get; set; }
        Users User { get; set; }
        Product Products { get; set; }
    }

    public class StockItems
    {
        int StockItemId { get; set; }
        string ItemName { get; set; }
        string Brand { get; set; }
        int Quantity { get; set; }
        string ItemDescription { get; set; }
        float PurchasePrice { get; set; }
        float SalePrice { get; set; }
        Bakeries Bakeries { get; set; }
    }

    public class Ingredients
    {
        int IngredientId { get; set; }
        int Quantity { get; set; }
        StockItems StockItems { get; set; }
    }


    public class BakeriesUsers
    {
        int BakeryUserId { get; set; }
        Bakeries Bakeries { get; set; }
        Users Users { get; set; }
    }

    public class ProductCategories
    {
        int ProductCategoriesId { get; set; }
        Product Products { get; set; }
        Categories Categories { get; set; }
    }

    public class RecipesCategory
    {
        int RecipesCategoryId { get; set; }
        Recipes Recipes { get; set; }
        Categories Categories { get; set; }
    }

    public class RecipesProducts
    {
        int RecipesProductsId { get; set; }
        Recipes Recipes { get; set; }
        Product Products { get; set; }
    }

    public class StockItemsCategories
    {
        int StockItemCategoryID { get; set; }
        StockItems StockItems { get; set; }
        Categories Categories { get; set; }
    }

    public class RecipesBakeries
    {
        int RecipeBakeryId { get; set; }
        Recipes Recipes { get; set; }
        Bakeries Bakeries { get; set; }
    }

    public class RecipesIngredients
    {
        int RecipeIngredientId { get; set; }
        Recipes Recipes { get; set; }
        Ingredients Ingredients { get; set; }
    }

    public class OrdersProducts
    {
        int OrderProductId { get; set; }
        Orders Orders { get; set; }
        Product Products { get; set; }
    }
}
