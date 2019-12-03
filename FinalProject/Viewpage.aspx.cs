using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DATABASE db = new DATABASE();
            //showing the base record student information
            Show_Page(db);

        }
        /*protected void Show_Page(DATABASE db)
        {

            bool valid = true;
            string pageid = Request.QueryString["PAGE_ID"];
            if (String.IsNullOrEmpty(pageid)) valid = false;

            //We will attempt to get the record we need
            if (valid)
            {

                HTTP_PAGE view = db.FindPage(Int32.Parse(pageid));


                page_title.InnerHtml = view.GetPageTitle();
                page_content.InnerHtml = view.GetPageContent();

            }
            else
            {
                valid = false;
            }


            if (!valid)
            {
                view_page.InnerHtml = "There was an error finding that page";
            }
        }*/
        protected void Show_Page(DATABASE db)
        {

            bool valid = true;
            string pageid = Request.QueryString["page_id"];
            if (String.IsNullOrEmpty(pageid)) valid = false;

            if (valid)
            {

                Dictionary<String, String> teacher_record = db.FindPage(Int32.Parse(pageid));

                if (teacher_record.Count > 0)
                {
                    page_title.InnerHtml = teacher_record["PAGE_TITLE"];
                    page_content.InnerHtml = teacher_record["PAGE_BODY"];
                }
                else
                {
                    valid = false;
                }
            }

            if (!valid)
            {
                view_page.InnerHtml = "There was an error displaying your page";
            }
        }

       
    }
}