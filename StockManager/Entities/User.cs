﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.Entities
{
  public class User
  {
    public string username { get; set; }
    public string password { get; set; }
    public string role { get; set; }
    public DateTime lastLogin { get; set; }
  }
}
