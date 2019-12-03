using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP_5101_FinalProject_N01329988
{
    public partial class editpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                seasondb db = new seasondb();
                ShowSeasonInfo(db);
            }
        }

        protected void Update_Page(object sender, EventArgs e)
        {
            seasondb db = new seasondb();

            bool valid = true;
            string season_id = Request.QueryString["seasonid"];
            if (String.IsNullOrEmpty(season_id)) valid = false;

            if (valid)
            {
                http_page new_season = new http_page();              

                new_season.SetStitle(s_title.Text);
                new_season.SetSbody(s_body.Text);
                try
                {
                    db.UpdatePage(Int32.Parse(season_id), new_season);
                   Response.Redirect("listpages.aspx?seasonid=" + season_id);
                }
                catch
                {
                    valid = false;
                }
            }
        }
        protected void ShowSeasonInfo(seasondb db)
        {
            bool valid = true;
            string season_id = Request.QueryString["seasonid"];
            if (String.IsNullOrEmpty(season_id)) valid = false;

            if (valid)
            {
                http_page season_record = db.FindPage(Int32.Parse(season_id));

                s_title.Text = season_record.GetStitle();
                s_body.Text= season_record.GetSbody();
            }

            if (!valid)
            {
                main_content.InnerHtml = "There was an error finding the season.";
            }
        }   
    }
}