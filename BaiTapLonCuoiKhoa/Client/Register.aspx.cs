using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Client_Register : System.Web.UI.Page
{
    DataUtil data = new DataUtil();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnregister_Click(object sender, EventArgs e)
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
                member_type = 0 ///user
            };
            if(data.CheckRegister(user.member_fullname, user.member_mail, user.member_phone))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Thông báo", "alert('Sign up fail! Username or email or phone exists!')", true);
            }
            else
            {
                data.AddNewUser(user);
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Thông báo", "alert('Sign up successful! Let login right now!')", true);
            }
        }
        catch (Exception)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Thông báo", "alert('Sign up fail! Let try again')", true);

        }
    }
}