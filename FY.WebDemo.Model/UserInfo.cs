﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FY.WebDemo.Model
{

   public class UserInfo
    {
       public int Id { get; set; }
       public string UserName { get; set; }
       public string Password { get; set; }
       public DateTime RegTime { get; set; }
       public string Email { get; set; }
    }
}
