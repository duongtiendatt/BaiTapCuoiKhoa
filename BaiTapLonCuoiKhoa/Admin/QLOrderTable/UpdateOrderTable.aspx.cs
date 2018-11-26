using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_OrderTable_UpdateOrderTable : System.Web.UI.Page
{
    DataUtil data = new DataUtil();
    protected void Page_Load(object sender, EventArgs e)
    {
        ShowInfooTable();
        txtidotb.Enabled = false;
    }
    private void ShowInfooTable()
    {
        var id = Request.QueryString["idotable"];
        if (!string.IsNullOrEmpty(id))
        {
            var tb = data.lay1otb(Convert.ToInt16(id));
            Session["idotb"] = id;
            txtidotb.Text = tb.ordertable_id.ToString();
            txtuser.Text = tb.ordertable_iduser.ToString();
            txtidb.Text = tb.ordertable_idtable.ToString();
            dt.Value = tb.ordertable_timeset.ToString("yyyy-MM-dd");
            if (tb.ordertable_status == true)
            {
                rdodtt.Checked = true;
            }
            else
            {
                rdoctt.Checked = true;
            }

        }
    }







    protected void updatotb_Click(object sender, EventArgs e)
    {
        try
        {
            Boolean tttt;
            if (rdodtt.Checked == true)
            {
                tttt = true;
            }
            else
            {
                tttt = false;
            }

            var otb = new OrderTable()
            {
                ordertable_iduser = Convert.ToInt16( txtuser.Text),
                ordertable_timeset = Convert.ToDateTime( dt.Value.ToString()),
                ordertable_idtable = Convert.ToInt16(txtidb.Text),
                ordertable_id = Convert.ToInt16(Session["idotb"].ToString()),
                ordertable_status = tttt
            };
            data.suaotb(otb);
            mss.Text = "Update success!";
            mss.ForeColor = System.Drawing.Color.Green;
            ShowInfooTable();
        }
        catch (Exception ex)
        {
            mss.Text = "Update Fail. Erorr: " + ex.Message + ". Let try!";
            mss.ForeColor = System.Drawing.Color.Red;
        }
    }
}