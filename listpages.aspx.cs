using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP_5101_FinalProject_N01329988
{
    public partial class listpages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            result_season.InnerHtml = "";

            string search_key = "";
            string query = "select * from season";

            if (search_key != "")
            {
                query += " WHERE seasonid LIKE '%" + search_key + "%'";
                query += " OR seasontitle LIKE '%" + search_key + "%'";
                query += " OR seasonbody LIKE '%" + search_key + "%'";
            }

            var db = new seasondb();
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String, String> row in rs)
            {
                result_season.InnerHtml += "<div class=\"result_season\">";

                string season_id = row["seasonid"];

                string season_title = row["seasontitle"];
                result_season.InnerHtml += "<a href=\"showpage.aspx?seasonid=" + season_id + "\">" + season_title + ": </a>";

                string season_body = row["seasonbody"];
                result_season.InnerHtml += season_body ;
                
                result_season.InnerHtml += "";
            }
        }     
    }    
}