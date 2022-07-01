﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Models.DAO
{
    internal interface IPayMethod
    {
        void AddPayMethod();
        PayMethod GetPayMethod(int payMethodId);
    }
}
