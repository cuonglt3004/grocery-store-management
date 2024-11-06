using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryWrapper
    {
        ICategoryRepository Category { get; }
        ICustomerRepository Customer { get; }
        ICustomerPointRepository CustomerPoint { get; }
        IOrderDetailRepository OrderDetail { get; }
        IOrderRepository OrderRepository { get; }
        IProductRepository Product { get; }
        IPromotionRepository Promotion { get; }
        void Save();
    }
}
