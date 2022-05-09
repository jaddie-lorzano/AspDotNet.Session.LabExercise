using System;
using System.Linq;
using ToyUniverse.Data.Data;
using ToyUniverse.Data.Models;
using ToyUniverse.Data.Repositories;
using ToyUniverse.Web.Models;

namespace ToyUniverse.Web.Services
{
    public interface IToyService
    {
        public PageResult<Toy> GetToyPage(int currentPage, int pageSize);
    }

    public class ToyService : GenericService, IToyService
    {
        private IUnitOfWork unitOfWork;

        public ToyService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public PageResult<Toy> GetToyPage(int currentPage, int pageSize)
        {
            return GetPage<Toy>(unitOfWork.ToyRepository.Context.Toys, currentPage, pageSize);
        }
    }
}
