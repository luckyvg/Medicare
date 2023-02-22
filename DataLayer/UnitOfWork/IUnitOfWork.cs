﻿using DataLayer.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.UnitOfWork
{
    public interface IUnitOfWork:IDisposable
    {
        IUserRepository UserRepository { get; }
        int Complete();
    }
}
