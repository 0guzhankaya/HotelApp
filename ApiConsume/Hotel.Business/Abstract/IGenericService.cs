﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Business.Abstract
{
    public interface IGenericService<T> where T : class
    {
        List<T> TGetList();
        T TGetById(int id);
        void TInsert(T entity);
        void TUpdate(T entity);
        void TDelete(T entity);
    }
}
