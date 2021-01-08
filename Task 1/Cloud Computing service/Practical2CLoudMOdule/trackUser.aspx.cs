using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CloudComputingAssignment1
{
    public partial class trackUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string browser = null;
            // Getting ip of visitor
            string ipClient = Request.ServerVariables["REMOTE_ADDR"];
            // Getting ip of Server
            string ipServer = Request.ServerVariables["LOCAL_ADDR"];

            string RequestMethod = Request.ServerVariables["REQUEST_METHOD"];
            // Getting the page which called the script
            string reqURL = Request.ServerVariables["URL"];
            string refererPage = Request.ServerVariables["HTTP_REFERER"];
            // Getting Browser Name of Visitor
            if ((Request.ServerVariables["HTTP_USER_AGENT"].Contains("MSIE")))
            {
                browser = "Internet Explorer";
            }
            else if ((Request.ServerVariables["HTTP_USER_AGENT"].Contains("FireFox")))
            {
                browser = "Fire Fox";
            }
            else if ((Request.ServerVariables["HTTP_USER_AGENT"].Contains("Opera")))
            {
                browser = "Opera";
            }
            else if ((Request.ServerVariables["HTTP_USER_AGENT"].Contains("Chrome")))
            {
                browser = "Chrome";
            }

        }
    }
}