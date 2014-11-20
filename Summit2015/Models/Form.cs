using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Summit2015.Models
{
    public class Form
    {
        public virtual string Name { get; set; }

        public virtual Home Page { get; set; }
        public bool Completed { get; set; }
    }
}