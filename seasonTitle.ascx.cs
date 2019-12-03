using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP_5101_FinalProject_N01329988
{
    public partial class seasonTitle : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            seasondb db = new seasondb();
            SeasonTitle(db);
        }

        protected void SeasonTitle(seasondb db)
        {
            seasontitle.InnerHtml = "";

            string search_key = "";
            string query = "select * from season";

            if (search_key != "")
            {
                query += " WHERE seasonid LIKE '%" + search_key + "%'";
                query += " OR seasontitle LIKE '%" + search_key + "%'";
                query += " OR seasonbody LIKE '%" + search_key + "%'";
            }

            //var db = new seasondb();
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String, String> row in rs)
            {
                seasontitle.InnerHtml += "";

                string season_id = row["seasonid"];

                string season_title = row["seasontitle"];
                seasontitle.InnerHtml += "<a href=\"showpage.aspx?seasonid=" + season_id + "\">" + season_title + "</a>  ";
            }
        }
    }
}