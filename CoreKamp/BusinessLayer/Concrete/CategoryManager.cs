﻿using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;

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
    EfCategoryRepository EfCategoryRepository;


    public void CategoryAdd(Category category)
    {
      throw new NotImplementedException();
    }

    public void CategoryDelete(Category category)
    {
     
        EfCategoryRepository.Delete(category);
      
    }

    public void CategoryUpdate(Category category)
    {
      EfCategoryRepository.Update(category);
    }

    public Category GetById(int id)
    {
      return EfCategoryRepository.GetByID(id);
    }

    public List<Category> GetList()
    {
      return EfCategoryRepository.GetListAll();
    }
  }
}
