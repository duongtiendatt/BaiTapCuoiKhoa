using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_QlMembers_UpdateMember : System.Web.UI.Page
{
    DataUtil data = new DataUtil();
    protected void Page_Load(object sender, EventArgs e)
    {
        ShowInfoUser();
    }

    private void ShowInfoUser()
    {
        var id = Request.QueryString["idmember"];
        if (!string.IsNullOrEmpty(id))
        {
            var member = data.GetUser(Convert.ToInt16(id));
            Session["IdUser"] = id;
            txtfullname.Text = member.member_fullname;
            txtphone.Text = member.member_phone;
            txtemail.Text = member.member_mail;
            txtusername.Text = member.member_username;
            ddltype.SelectedValue = member.member_type.ToString();
            ddlstatus.SelectedValue = member.member_status.ToString();
        }
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {

            var user = new Member()
            {
                member_fullname = txtfullname.Text,
                member_mail = txtemail.Text,
                member_phone = txtphone.Text,
                member_status = Convert.ToInt16(ddlstatus.SelectedValue.ToString()), ///Active
                member_type = Convert.ToInt16(ddltype.SelectedValue.ToString()),
                member_id = Convert.ToInt16(Session["IdUser"].ToString())
            };
            data.UpdateUser(user);
            msg.Text = "Update success!";
            msg.ForeColor = System.Drawing.Color.Green;
            ShowInfoUser();
        }
        catch (Exception ex)
        {
            msg.Text = "Update Fail. Erorr: " + ex.Message + ". Let try!";
            msg.ForeColor = System.Drawing.Color.Red;
        }
    }
}