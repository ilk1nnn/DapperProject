using DapperProject.Data_Access.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperProject.Data_Access.Concrets
{
    public class UnitOfWork : IUnitOfWork
    {
        public ICategoryRepository CategoryRepository => new CategoryRepository();

        public IProductRepository ProductRepository => new ProductRepository();
    }
}
