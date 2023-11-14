using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal :EfEntityRepositoryBase<Order,NorthwindContext >, IOrderDal
    {
    }
}
