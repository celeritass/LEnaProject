﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lena.Core.Enum
{
    public interface IEntity <T>
    {
        T ID { get; set; }
    }
}
