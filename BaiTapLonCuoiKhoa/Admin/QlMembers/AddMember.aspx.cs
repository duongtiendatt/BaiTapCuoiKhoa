using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_QlMembers_AddMember : System.Web.UI.Page
{
    DataUtil data = new DataUtil();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            msg.Text = "";
        }
    }



    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        try
        {

            var user = new Member()
            {
                member_fullname = txtfullname.Text,
                member_mail = txtemail.Text,
                member_password = Encryptor.MD5Hash(txtpassword.Text),
                member_phone = txtphone.Text,
                member_username = txtusername.Text,
                member_status = 1, ///Active
                member_type = Convert.ToInt16(ddltype.SelectedValue.ToString())
            };
            if(data.CheckRegister(user.member_fullname, user.member_mail, user.member_phone))
            {
                msg.Text = "Add Fail. Username or email or phone exists. Let try again!";
                msg.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                data.AddNewUser(user);
                msg.Text = "Add success!";
                msg.ForeColor = System.Drawing.Color.Green;
                ReloadPage();
            }

        }
        catch (Exception ex)
        {
            msg.Text = "Add Fail. Erorr: "+ex.Message+". Let try again!";
            msg.ForeColor = System.Drawing.Color.Red;
        }
    }

    private void ReloadPage()
    {
        txtemail.Text = "";
        txtfullname.Text = "";
        txtphone.Text = "";
        txtusername.Text = "";
    }
}