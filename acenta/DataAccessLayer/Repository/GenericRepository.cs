﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdatAccsesLayer.Concrete;
using DataAccessLayer.Abstract;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using var c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }

        public List<T> GetList()
        {
            using var c = new Context();

            return c.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var c = new Context();

            c.Add(t);
        }

        public void Update(T t)
        {
            using var c = new Context();

            c.Update(t);
        }
    }
}
