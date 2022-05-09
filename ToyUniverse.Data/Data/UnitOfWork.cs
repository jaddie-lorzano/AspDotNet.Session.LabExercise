using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyUniverse.Data.Repositories;

namespace ToyUniverse.Data.Data
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
        public IToyRepository ToyRepository { get; }
        public IShoppingCartRepository ShoppingCartRepository { get; set; }
    }
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private ToyUniverseContext context;
        public IToyRepository ToyRepository { get; private set; }
        public IShoppingCartRepository ShoppingCartRepository { get; set; }

        public UnitOfWork(ToyUniverseContext context)
        {
            this.context = context;
            this.ToyRepository = new ToyRepository(context);
            this.ShoppingCartRepository = new ShoppingCartRepository(context);
        }

        public async Task CommitAsync()
        {
            await this.context.SaveChangesAsync();
        }

        public void Dispose()
        {
            this.context.Dispose();
        }
    }
}
