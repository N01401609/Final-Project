using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject
{
    public class HTTP_PAGE
    {
        private string PageTitle;
        private string PageContent;

        public string GetPageTitle()
        {
            return PageTitle;
        }
        public string GetPageContent()
        {
            return PageContent;
        }

        public void SetPageTitle(string value)
        {
            PageTitle = value;
        }
        public void SetPageContent(string value)
        {
            PageContent = value;
        }
    }

}