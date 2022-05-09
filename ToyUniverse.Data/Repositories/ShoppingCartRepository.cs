using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyUniverse.Data.Data;
using ToyUniverse.Data.Models;

namespace ToyUniverse.Data.Repositories
{
    public interface IShoppingCartRepository : IBaseRepository<ShoppingCart>
    {
        public ShoppingCart FindByToyId(string id);
    }

    public class ShoppingCartRepository : GenericRepository<ShoppingCart>, IShoppingCartRepository
    {
        public ShoppingCartRepository(ToyUniverseContext context) : base(context)
        {
        }

        public ShoppingCart FindByToyId(string id)
        {
            var entity = this.Context.ShoppingCarts.Where(e => e.CToyId.Equals(id)).FirstOrDefault();

            if (entity is object)
            {
                return entity;
            }
            return null;
        }
    }
}
