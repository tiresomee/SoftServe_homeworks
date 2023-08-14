﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    internal interface IDeveloper : IComparable <IDeveloper>
    {
        string Tool{ get; set;}
        void Create();

        void Destroy();
    }
}
