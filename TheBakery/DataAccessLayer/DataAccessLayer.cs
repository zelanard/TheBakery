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

        public Product[] GetProducts(string Category)
        {
            string SelectProducts = $"EXEC dbo.SelectProducts @Category = {Category}";
            List<Product> Products = new List<Product>();

            using (SqlConnection conn = new SqlConnection(DB_CONNECTION_STRING))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(SelectProducts, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            return Products.ToArray();
        }
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

    public class UsersRoles
    {
        int UserRoleId { get; set; }
        Users Users { get; set; }
        Roles Roles { get; set; }
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
