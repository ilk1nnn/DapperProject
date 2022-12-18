using DapperProject.Data_Access.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperProject.Data_Access.Abstractions
{
    public interface IProductRepository : IRepository<Product>
    {
    }
}
