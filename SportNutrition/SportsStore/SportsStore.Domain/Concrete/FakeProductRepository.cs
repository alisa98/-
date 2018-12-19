using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Concrete
{
    public class FakeProductRepository : IProductRepository
    {
        private IList<SportNutrition> products = new List<SportNutrition>()
        {
            new SportNutrition(){SportNutritionId = 1, Name = "PROTEIN 90, IRONMAXX", Description = "Ironmaxx Protein 90 - водорастворимый источник белка, богатый незаменимыми аминокислотами.", Category = "Протеин", Price = 12, ImageName ="1.jpg"},
            new SportNutrition(){SportNutritionId = 2, Name = "ПРОТЕИН ISO WHEY ZERO, BIOTECH USA", Description = "Порошок чистейшего сывороточного протеина, не содержащий лактозы, трансжиров и сахара.", Category = "Протеин", Price = 132,ImageName ="2.jpg"},
            new SportNutrition(){SportNutritionId = 3, Name = "ПРОТЕИН 100% WHEY PROTEIN, IRONMAXX", Description = "Первый 100% сывороточный протеин разработан для размешивания в воде!", Category = "Протеин", Price = 312,ImageName ="3.jpg"},
            new SportNutrition(){SportNutritionId = 4, Name = "ПРОТЕИН БИЗОН-ПРО, БИОФОН", Description = "БизонПРО (сывороточный протеин высшего качества) обладает уникальной пищевой и биологической ценностью, имеет наивысшую скорость расщепления среди цельных белков.", Category = "Протеин", Price = 128,ImageName ="4.jpg"},
            new SportNutrition(){SportNutritionId = 5, Name = "БИОФОН МЕДВЕДЬ 85", Description = "Протеин Медведь 85% является качественным молочно-сывороточным протеином, который прекрасно усваивается, легко смешивается в блендере, а также имеет приятный вкус. ", Category = "Протеин", Price = 112,ImageName ="5.jpg"},
            new SportNutrition(){SportNutritionId = 6, Name = "Л-КАРНИТИН PRO LIQUID, IRONMAXX", Description = "L-Carnitin Pro Liquid IronMaxx – источник аминокислоты L-карнитин, хорошо известной в мире спорта своими широкими свойствами.", Category = "Л-карнитин", Price = 62,ImageName ="6.jpg"},
            new SportNutrition(){SportNutritionId = 7, Name = "L-CARNITINE, BIOTECH USA", Description = "Таблетки, содержащие 1000 мг l-карнитин тартрат. В 1 порции: 1000 мг комплекса L-карнитина", Category = "Л-карнитин", Price = 64,ImageName ="7.jpg"},
            new SportNutrition(){SportNutritionId = 8, Name = "Л-КАРНИТИН ЖИДКАЯ ФОРМУЛА, QNT", Description = "Л-Карнитин Ликвид Формула от QNT обеспечивает транспорт жирных кислот в клетки, предназначен: для снижения веса, улучшения общего состояния организма.", Category = "Л-карнитин", Price = 45,ImageName ="8.jpg"},
            new SportNutrition(){SportNutritionId = 9, Name = "L-CARNITINE 3000, BIOTECH USA", Description = "L-Carnitine Ampule 3000 mg - жидкая формула л-карнитина, содержащая 3000мг действующего вещества. Жидкий л-карнитин на 99,9% чист, тогда как таблетки содержат 70% составных тартата.", Category = "Л-карнитин", Price = 90,ImageName ="9.jpg"},
            new SportNutrition(){SportNutritionId = 10, Name = "БУТЫЛКА IRONMAXX СИНЕ-ОРАНЖЕВАЯ", Description = "Бутылка для питья IronMaxx® в спортивном стиле с крышкой в виде соски и емкостью 700 мл.", Category = "Аксессуары", Price = 32,ImageName ="10.jpg"},
            new SportNutrition(){SportNutritionId = 10, Name = "НАПУЛЬСНИКИ CLINTON BIOTECH USA", Description = "Напульсники от известной марки BioTech", Category = "Аксессуары", Price = 36,ImageName ="11.jpg"},
            new SportNutrition(){SportNutritionId = 10, Name = "НАЛОКОТНИК ЗАЩИТНЫЙ LIVEUP LS5752", Description = "Защищает локти от ушибов, растяжений, травм.", Category = "Аксессуары", Price = 32,ImageName ="12.jpg"},
            new SportNutrition(){SportNutritionId = 10, Name = "СУМКА ЖЕНСКАЯ AI9132 / PERFECT", Description = "Держи свою экипировку в идеальном порядке с этой женской спортивной сумкой.", Category = "Аксессуары", Price = 38,ImageName ="13.jpg"},
            new SportNutrition(){SportNutritionId = 10, Name = "БУТЫЛКА FIZCULT", Description = "Фирменная бутылка от магазина спортивного питания Физкульт", Category = "Аксессуары", Price = 32,ImageName ="14.jpg"}

        };

        public IQueryable<SportNutrition> Products
        {
            get { return products.AsQueryable(); }
        }

        public void SaveProduct(SportNutrition product)
        {
            throw new NotImplementedException();
        }

        public SportNutrition DeleteProduct(int productID)
        {
            throw new NotImplementedException();
        }
    }
}
