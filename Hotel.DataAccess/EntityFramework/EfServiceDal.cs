﻿using Hotel.DataAccess.Abstract;
using Hotel.DataAccess.Concrete;
using Hotel.DataAccess.Repositories;
using Hotel.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DataAccess.EntityFramework
{
    public class EfServiceDal : GenericRepository<Service>, IServiceDal
    {
        public EfServiceDal(Context context) : base(context)
        {
        }
    }
}
