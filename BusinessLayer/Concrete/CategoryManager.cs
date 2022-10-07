using BusinessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        GenericRepository<Category> repository = new GenericRepository<Category>();
        public void CategoryAdd(Category category)
        {
            throw new NotImplementedException();
        }

        public void CategoryDelete(Category category)
        {
            if (category.CategoryID != 0)
            {
                repository.Delete(category);
            }

        }

        public void CategoryUpdate(Category category)
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
