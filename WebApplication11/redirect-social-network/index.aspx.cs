using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.UI;
using System.Web.UI.WebControls;
using Renci.SshNet;

namespace WebApplication11.redirect_social_network
{
    public partial class index : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)

        {

            string v = Request.QueryString["url"];
            if (v != "")
                Response.Redirect("/404");
         
            else
            {
                if (v != "https://twitter.com/synhostinger_fr")
                    Response.Redirect(v);

             else
            {
                if (v != "https://www.facebook.com/synhostinger/")
                    Response.Redirect("/");
            }

        }
    }
   }
}
