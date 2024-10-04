﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.UrunYonetimi.Managers.Abstract
{
    public interface IManager<TModel> where TModel : class
    {
        public void Create(TModel model);
        public void Update(TModel model);
        public void Delete(TModel model);
        public void Remove(TModel model);
        public List<TModel> GetAll();
        public TModel GetById(int id);
        public List<TModel> Search(Expression<Func<TModel, bool>> searchConditions);
    }
}
