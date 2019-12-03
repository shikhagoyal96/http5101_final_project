using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP_5101_FinalProject_N01329988
{
    public partial class addpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected void Add_Page(object sender, EventArgs e)
        {
            seasondb db = new seasondb();

            http_page new_season = new http_page();
            
            new_season.SetStitle(season_title.Text);
            new_season.SetSbody(season_body.Text);

            db.AddPage(new_season);
            Response.Redirect("listpages.aspx");
        }       
    }
}