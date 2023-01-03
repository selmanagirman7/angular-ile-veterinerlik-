using Business.Abstract;
using DataAccess.Abstract;
using Entity;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public Category Get(int id)
        {
            return _categoryDal.GetById(id);
        }

        public List<Category> GetAll()
        {

         
                return _categoryDal.GetAll();
            
       
           
        }

        public void Update(Category category)
        {


             _categoryDal.Update(category);

            
         
        }
    }
}