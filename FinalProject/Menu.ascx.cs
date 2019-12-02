using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public partial class Menu : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DATABASE db = new DATABASE();
            ListPages(db);

        }

        protected void ListPages(DATABASE db)
        {
            string query = "SELECT * FROM pages";
            List<Dictionary<String, String>> rs = db.List_Query(query);

            foreach (Dictionary<String, String> row in rs)
            {
                menu_pages.InnerHtml += "<li><a href=\"#\">" + row["PAGE_TITLE"] + "</a></li>";

            }
        }
    }

    
}