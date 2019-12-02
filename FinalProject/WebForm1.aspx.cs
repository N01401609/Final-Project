using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DATABASE db = new DATABASE();
            ListofPages(db);

        }

        protected void ListofPages(DATABASE db)
        {
            result.InnerHtml = "";
            string query = "select * from pages";
            //string searchkey = class_search.Text;
            /*if (searchkey != "")
            {
                query += " WHERE CLASSCODE like '%" + searchkey + "%' ";
                query += " or CLASSNAME like '%" + searchkey + "%' ";
                query += " or concat (TEACHERFNAME, ' ', TEACHERLNAME) like '%" + searchkey + "%' ";
            }
            sql_debugger.InnerHtml = query;*/

            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String, String> row in rs)
            {
                result.InnerHtml += "<div class=\"listitem\">";

                string pageid = row["PAGE_ID"];
                result.InnerHtml += "<div class=\"col5\">" + pageid + "</div>";

                string pagetitle = row["PAGE_TITLE"];
                result.InnerHtml += "<div class=\"col5\">" + pagetitle + "</div>";

                string pagebody = row["PAGE_BODY"];
                result.InnerHtml += "<div class=\"col5last\">" + pagebody + " </ div > ";

                result.InnerHtml += "</div>";
            }
        }
    }
}