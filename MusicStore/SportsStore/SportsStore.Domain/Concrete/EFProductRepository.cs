using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using System.Linq;

namespace SportsStore.Domain.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        private EFDbContext context = new EFDbContext();

        public IQueryable<SportNutrition> Products
        {
            get { return context.Products; }
        }

        public void SaveProduct(SportNutrition product)
        {

            if (product.SportNutritionId == 0)
            {
                context.Products.Add(product);
            }
            else
            {
                SportNutrition dbEntry = context.Products.Find(product.SportNutritionId);
                if (dbEntry != null)
                {
                    dbEntry.Name = product.Name;
                    dbEntry.Description = product.Description;
                    dbEntry.Price = product.Price;
                    dbEntry.Category = product.Category;
                    dbEntry.ImageName = product.ImageName;
                }
            }
            context.SaveChanges();
        }

        public SportNutrition DeleteProduct(int productID)
        {
            SportNutrition dbEntry = context.Products.Find(productID);
            if (dbEntry != null)
            {
                context.Products.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}