using ETicaret.Core.IUnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {


        protected readonly MyECommerceDB _commerceDb;

        public UnitOfWork(MyECommerceDB db)
        {
            _commerceDb = db;    
        }


        public void Commit()
        {
            _commerceDb.SaveChanges();

        }

        public async Task CommitAsync()
        {
           await  _commerceDb.SaveChangesAsync();

        }
    }
}
