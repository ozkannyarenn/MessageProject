using Message.Data.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Message.Data.DAL.Repository.Core
{
    public class EfRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity<Guid>
    {
        protected MessageContext _context;

        protected DbSet<TEntity> _dbSet;

        protected DbSet<TEntity> DbSet
        {
            get { return _dbSet; }
            set { _dbSet = value; }
        }
        public EfRepository(MessageContext context)
        {
            _dbSet = context.Set<TEntity>();
            _context = context;
        }

        public IQueryable<TEntity> GetQueryable()
        {
            return DbSet as IQueryable<TEntity>;
        }
        public IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> where)
        {
            return DbSet.Where(where).ToList();
        }

        public TEntity GetSingle(Guid id)
        {
            return DbSet.SingleOrDefault(p => p.Id == id);
        }

        public TEntity GetById(Guid id)
        {
            return DbSet.Where(p => p.Id == id).FirstOrDefault();
        }

        public TModel GetById<TModel>(Func<TEntity, TModel> selector, Guid id)
        {
            return DbSet.Where(p => p.Id == id).Select(selector).Single();
        }

        public void Delete(TEntity entity)
        {
            DbSet.Remove(entity);
        }

        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            DbSet.RemoveRange(entities);
        }

        public void Add(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            DbSet.AddRange(entities);
        }

        public void Attach(TEntity entity)
        {
            DbSet.Attach(entity);
        }

        public void Detach(TEntity entity)
        {
            
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
