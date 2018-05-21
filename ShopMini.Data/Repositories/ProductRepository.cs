using ShopMini.Data.Infrastructure;
using ShopMini.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMini.Data.Repositories
{
    public interface IProductRepository {
        
    }
    public class ProductRepository : RepositoryBase<Product>
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
          
        }
    }
}
