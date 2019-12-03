using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //We want to make sure Show_Page is only called the first time the page is loaded
            if (!Page.IsPostBack) { 
            DATABASE db = new DATABASE();
            Show_Page(db);
            }

        }

        protected void Show_Page(DATABASE db)
        {

            bool valid = true;
            string pageid = Request.QueryString["page_id"];
            if (String.IsNullOrEmpty(pageid)) valid = false;

            //We will attempt to get the record we need
            if (valid)
            {

                Dictionary<String, String> page_info = db.FindPage(Int32.Parse(pageid));

                if (page_info.Count > 0)
                {
                    page_header.InnerHtml = page_info["PAGE_TITLE"] + " Page";
                    new_page_title.Text = page_info["PAGE_TITLE"];
                    new_page_content.Text = page_info["PAGE_BODY"];
                }
                else
                {
                    valid = false;
                }
            }

            if (!valid)
            {
                page_update.InnerHtml = "There was an error finding this page";
            }
        }
        protected void Update_Page(object sender, EventArgs e)
        {
            //create connection
            DATABASE db = new DATABASE();

            bool valid = true;
            string pageid = Request.QueryString["page_id"];
            if (String.IsNullOrEmpty(pageid)) valid = false;

            if (valid)
            {
                //Create a new page object
                HTTP_PAGE updated_page = new HTTP_PAGE();

                //Set the values based on the new user input
                updated_page.SetPageTitle(new_page_title.Text);
                updated_page.SetPageContent(new_page_content.Text);

                //add page to database
                try
                {
                    db.UpdatePage(Int32.Parse(pageid), updated_page);
                    Response.Redirect("ManagePages.aspx");
                }
                catch
                {
                    valid = false;
                }

            }
            if (!valid)
            {
                page_update.InnerHtml = "There was an error editing your page.";
            }

        }

        protected void Delete_Page(object sender, EventArgs e)
        {
            bool valid = true;
            string pageid = Request.QueryString["page_id"];
            if (String.IsNullOrEmpty(pageid)) valid = false;

            DATABASE db = new DATABASE();

            //deleting the page
            if (valid)
            {
                db.DeletePage(Int32.Parse(pageid));
                Response.Redirect("ManagePages.aspx");
            }
        }
    }
}