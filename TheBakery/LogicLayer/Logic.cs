using System.Collections.Generic;
using TheBakery.DataAccessLayer;

namespace TheBakery.LogicLayer
{
    public static class Logic
    {
        /// <summary>
        /// Contact the Data Access Layer to request an array of products.
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public static Product[] GetProducts(int categoryId)
        {
            return DataAccess.GetProducts(categoryId);
        }

        /// <summary>
        /// The public static void below create a bridge
        /// it more or less allows the transporation of data
        /// between the actul code and the GUI that dispalys sat code
        /// </summary>
        /// <returns></returns>
        public static string[] GetCategories()
        {
            return DataAccess.GetListOfCategories();
        }
    }
}