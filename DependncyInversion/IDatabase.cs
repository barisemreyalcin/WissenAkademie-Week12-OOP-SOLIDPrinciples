﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependncyInversion
{
    public interface IDatabase
    {
        void add(Exception exception);
    }
}
