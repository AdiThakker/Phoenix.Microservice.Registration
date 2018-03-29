using Phoenix.Access.Registration.Core.Interfaces.Base;
using Phoenix.Access.Registration.Infrastructure.EntityFramework.Context;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Phoenix.Access.Registration.Infrastructure.EntityFramework.Repositories.Base
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : class, IEntity
    {
        protected readonly RegistrationContext context;
        private bool disposed = false;

        protected RepositoryBase(RegistrationContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public T Add(T entity)
        {
            this.context.Set<T>().Add(entity);
            this.context.SaveChanges();
            return entity;
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAllWhere(Expression<Func<T, bool>> matchExpression)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public T GetSingleWhere(Expression<Func<T, bool>> matchExpression)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                this.context.Dispose();
                // Free any other managed objects here. (if any)

            }

            // Free any unmanaged objects here. (if any)

            disposed = true;
        }
    }
}
