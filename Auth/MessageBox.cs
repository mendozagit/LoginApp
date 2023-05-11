using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace LoginApp.Auth
{
    public static class MessageBox
    {
        public static void Show(this Page Page, string Message)
        {
            Page.ClientScript.RegisterStartupScript(
               Page.GetType(),
               "Message",
               "<script language='javascript'>alert('" + Message + "');</script>"
            );
        }
    }
}