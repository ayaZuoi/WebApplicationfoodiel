﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationfoodiel.users
{
    public partial class user : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Request.Url.AbsoluteUri.ToString().Contains("Defult.aspx") || (Request.Url.AbsoluteUri.ToString().Contains("book.aspx")))
            {
             
              
            }
            else
            {

                Control sliderusercontrol = (Control)Page.LoadControl("../sliderusercontrol.ascx");
                
                //
                Pnlofsliderusercontrol.Controls.Add(sliderusercontrol);



            }
        }
    }
}