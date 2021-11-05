﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holtz_DDD_EF_Docker.Domain.Entities
{
    public class Customer : Base
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Document { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
