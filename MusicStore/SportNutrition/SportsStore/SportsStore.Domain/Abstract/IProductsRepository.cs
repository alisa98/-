using System.Linq;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Abstract
{
    public interface IProductRepository
    {
        IQueryable<SportNutrition> Products { get; }

        void SaveProduct(SportNutrition product);

        SportNutrition DeleteProduct(int productID);
    }
}
