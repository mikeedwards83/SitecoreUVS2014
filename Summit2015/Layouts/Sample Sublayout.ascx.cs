using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web.Ui;
using Summit2015.Models;

namespace Summit2015.Layouts
{
    public partial class Sample_Sublayout : AbstractGlassUserControl
    {

        public Home Model { get; set; }


        protected void Page_Load(object sender, EventArgs e)
        {
            ISitecoreContext context = new SitecoreContext();
            Model = context.GetCurrentItem<Home>();

        }
    }
}