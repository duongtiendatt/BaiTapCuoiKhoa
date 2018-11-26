using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_QlOrderDetail_OrderDetailPage : System.Web.UI.Page
{
    DataUtil data = new DataUtil();
    protected void Page_Load(object sender, EventArgs e)
    {

    }   
    [WebMethod]
    //public string DetailFood(int idfood)
    //{

    //}    
    public static OrderVM DetailOrderTable(int idtable)
    {
        DataUtil data = new DataUtil();
        return data.GetOrderVM(idtable);
    }
}