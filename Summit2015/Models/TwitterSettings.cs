using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Summit2015.Models
{
    public class TwitterSettings
    {

        public virtual string ConsumerKey { get; set; }
        public virtual string ConsumerSecret { get; set; }
        public virtual string ApiKey { get; set; }
        public virtual string ApiSecret { get; set; }
    }
}