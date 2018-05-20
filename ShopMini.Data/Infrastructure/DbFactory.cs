using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;

namespace ShopMini.Data.Infrastructure
{
    // Dùng để khởi tạo MiniShopDbContext thay vì new trực tiếp (Method Init() ) => giống @Inject trong spring
    // Method DisposeCore dùng để xóa đối tượng khi không dùng ( xóa bộ nhớ=> đỡ tốn dung lượng bộ nhớ) => giống cơ chế alias trong java
    public class DbFactory : Disposable, IDbFactory
    {
        private MiniShopDbContext dbContext;

        public MiniShopDbContext Init()
        {
            return dbContext ?? (dbContext = new MiniShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
