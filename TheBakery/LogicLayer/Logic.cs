using TheBakery.DataAccessLayer;

namespace TheBakery.LogicLayer
{
    public class Logic
    {
        readonly DataAccess UserItems = new DataAccess();
        public object[] GetProducts(string Category)
        {
            return UserItems.GetProducts(Category);
        }
    }
}
