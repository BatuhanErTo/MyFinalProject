﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    // Çıplak Class Kalmasın
    public class Category :IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
