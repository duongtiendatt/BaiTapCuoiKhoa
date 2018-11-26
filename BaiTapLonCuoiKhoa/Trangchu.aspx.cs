using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tranchu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var member = (Member)Session["User"];
        if (member != null)
        {
            nameuser.Text = member.member_fullname;
            avatar.Style.Add("display", "block");
            login.Style.Add("display", "none");
        }
        else
        {
        }
    }

    protected void LogOut_Click(Object sender, EventArgs e)
    {
        Session["User"] = null;
        Response.Redirect("TrangChu.aspx");
    }
}