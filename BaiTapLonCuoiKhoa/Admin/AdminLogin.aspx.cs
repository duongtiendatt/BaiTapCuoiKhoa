using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AdminLogin : System.Web.UI.Page
{
    DataUtil data = new DataUtil();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        var passwordHash = Encryptor.MD5Hash(txtpassword.Text);
        var type = 1; /// type 1 is admin
        var checkLogin = data.CheckLogin(txtusername.Text, passwordHash, type);
        if (checkLogin)
        {
            Session["UserAdmin"] = data.GetUserByName(txtusername.Text);
            Response.Redirect("/Admin/Dashboard.aspx");
        }
        else
        {

        }
    }
}