using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _repoContext;
        private IProductRepository _product;
        private ICustomerPointRepository _customerPoint;    
        private ICustomerRepository _customer;
        private IOrderRepository _order;
        private IOrderDetailRepository _orderDetail;
        private ICategoryRepository _category;
        private IPromotionRepository _promotion;
        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
        public ICategoryRepository Category
        {
            get
            {
                if (_category == null)
                {
                    _category = new CategoryRepository(_repoContext);
                }
                return _category;
            }
        }
        public ICustomerRepository Customer
        {
            get
            {
                if (_customer == null)
                {
                    _customer = new CusotmerRepository(_repoContext);
                }
                return _customer;
            }
        }

        public ICustomerPointRepository CustomerPoint
        {
            get
            {
                if (_customerPoint == null)
                {
                    _customerPoint = new CusotmerPointRepository(_repoContext);
                }
                return _customerPoint;
            }
        }

        public IOrderDetailRepository OrderDetail
        {
            get
            {
                if (_orderDetail == null)
                {
                    _orderDetail = new OrderDetailRepository(_repoContext);
                }
                return _orderDetail;
            }
        }

        public IOrderRepository OrderRepository
        {
            get
            {
                if (_order == null)
                {
                    _order = new OrderRepository(_repoContext);
                }
                return _order;
            }
        }

        public IProductRepository Product
        {
            get
            {
                if (_product == null)
                {
                    _product = new ProductRepository(_repoContext);
                }
                return _product;
            }
        }

        public IPromotionRepository Promotion
        {
            get
            {
                if (_promotion == null)
                {
                    _promotion = new PromotionRepository(_repoContext);
                }
                return _promotion;
            }
        }

     
        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
