using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UrunYonetimi.Repositories.Abstract
{
    public interface IRepository<TEntity>
    {
        public void Create(TEntity entity);
        public void Update(TEntity entity);
        public void Delete(TEntity entity);
        public void Remove(TEntity entity);
        public IQueryable<TEntity> GetAll();
        public TEntity GetById(int id);
        public IQueryable<TEntity> Search(Expression<Func<TEntity,bool>> searchConditions);
        //Burası dinamik bir arama metodu yaratmak için kullanıldı 
        //Expression<Func<Tentity,bool>> burası linq ile yapılan sorguları tutan bir nokta.
        //İçine her türlü linq filtreleme sorgusu yazılabilir ve dinamik bir şekilde değiştirilebilir.
        //Linq direkt olarak parametre şeklinde yazılamadığı için bu kullanılıyor.
        //searchConditions ise ortaya çıkacak sonucun ismi, parametre adı. int id gibi.
    }
}
