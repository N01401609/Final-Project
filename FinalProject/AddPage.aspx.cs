using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Add_Page (object sender, EventArgs e)
        {
            //create connection
            DATABASE db = new DATABASE();

            //Create a new page object
            HTTP_PAGE new_page = new HTTP_PAGE();

            //Set the values based on user input
            new_page.SetPageTitle(page_title.Text);
            new_page.SetPageContent(page_content.Text);

            //Add page to the database
            db.AddPage(new_page);


            Response.Redirect("ManagePages.aspx");
        }
    }
}