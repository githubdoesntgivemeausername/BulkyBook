
using BulkyBook.DataAccess.Repository.iRepository;//this statement was introduced by auto fix.may not be correct.
using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>

    {
        void Update(Product obj);

        
    }
}
