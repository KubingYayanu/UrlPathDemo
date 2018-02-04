using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UrlPathDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //~/Images/000.jpg: C:\inetpub\wwwroot\UrlPathDemo\Images\000.jpg
            lblPath1.Text = $"~/Images/000.jpg: {Server.MapPath("~/Images/000.jpg")}";

            ///Images/000.jpg: C:\inetpub\wwwroot\UrlPathDemo\Images\000.jpg
            lblPath2.Text = $"/Images/000.jpg: {Server.MapPath("/Images/000.jpg")}";

            //Yes, WebSite目錄
            Image1.ImageUrl = "~/Images/000.jpg";
            lblPath3.Text = Image1.ImageUrl;

            //No, 實體目錄(C:\inetpub\wwwroot\UrlPathDemo\Images\000.jpg)
            Image2.ImageUrl = Server.MapPath("~/Images/000.jpg");
            lblPath4.Text = Image2.ImageUrl;

            //Yes, IIS虛擬目錄(doc => D:\UrlPathDemo)
            Image3.ImageUrl = "~/doc/Images/000.jpg";
            lblPath5.Text = Image3.ImageUrl;
        }
    }
}