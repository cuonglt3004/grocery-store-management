using Contracts;
using Entities.Models;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CusotmerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CusotmerRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
