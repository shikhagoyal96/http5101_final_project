using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP_5101_FinalProject_N01329988
{
    public partial class showpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            seasondb db = new seasondb();
            ShowSeasonInfo(db);
        }

        protected void ShowSeasonInfo(seasondb db)
        {
            bool valid = true;
            string season_id = Request.QueryString["seasonid"];
            if (String.IsNullOrEmpty(season_id)) valid = false;

           
            if (valid)
            {

                http_page season_record = db.FindPage(Int32.Parse(season_id));
 
                s_title.InnerHtml += season_record.GetStitle();
                s_body.InnerHtml += season_record.GetSbody();

            }
            else
            {
                valid = false;
            }

            if (!valid)
            {
                main_content.InnerHtml = "There was an error finding the season.";
            }
        }

        protected void Delete_Season(object sender, EventArgs e)
        {
            bool valid = true;
            string season_id = Request.QueryString["seasonid"];

            if (String.IsNullOrEmpty(season_id)) valid = false;

            seasondb db = new seasondb();

            if (valid)
            {
                db.DeletePage(Int32.Parse(season_id));
                Response.Redirect("listpages.aspx");
            }
            else
            {
                valid = false;
            }
        }      
    }
}
