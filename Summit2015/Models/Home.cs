using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using TweetSharp;

namespace Summit2015.Models
{
    public class Home
    {
        public virtual Guid Id { get; set;}
        public virtual string Title { get; set; }
        public virtual string Text { get; set; }

        [SitecoreNode(Id = "{986AD41D-00CD-4D7D-88C7-EF7D98827EE2}")]
        public virtual TwitterSettings Settings { get; set; }

        [SitecoreField(Setting = SitecoreFieldSettings.DontLoadLazily)]
        public virtual SendTweetOptions Tweet { get; set; }
    }
}