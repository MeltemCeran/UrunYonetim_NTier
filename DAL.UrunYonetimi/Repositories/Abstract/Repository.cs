using DAL.UrunYonetimi.Context;
using DAL.UrunYonetimi.Entities.Abstract;
using DAL.UrunYonetimi.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UrunYonetimi.Repositories.Abstract
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly ProductDbContext _context;
        private DbSet<TEntity> _entities;

        protected Repository(ProductDbContext context)
        {
            _context = context;
            _entities = _context.Set<TEntity>();
        }


        public void Create(TEntity entity)
        {
            entity.DataStatus= DataStatus.Inserted;
            entity.CreatedDate= DateTime.Now;
            _entities.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(TEntity entity) //Soft Delete
        {
            entity.DataStatus = DataStatus.Deleted;
            entity.DeletedDate = DateTime.Now;
            Update(entity); //burdaki update bizim yazdığımız metot. Update metotunun içindeki update ise sistemin kendisinin.

        }

        public void Remove(TEntity entity) //Hard Delete
        {
            _entities.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            entity.DataStatus = entity.DataStatus != DataStatus.Deleted ?
                DataStatus.Updated : DataStatus.Deleted;
            entity.ModifiedDate = DateTime.Now;
            _entities.Update(entity);
            _context.SaveChanges();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _entities.Where(e => e.DataStatus != DataStatus.Deleted);
        }

        public TEntity GetById(int id)
        {
            return _entities.Find(id);
            //return _entities.FirstOrDefault(e => e.Id == id);
        }

        public IQueryable<TEntity> Search(Expression<Func<TEntity, bool>> searchConditions)
        {
            var all = _entities.Where(e => e.DataStatus != DataStatus.Deleted);
            return all.Where(searchConditions);
        }

        
    }
}
