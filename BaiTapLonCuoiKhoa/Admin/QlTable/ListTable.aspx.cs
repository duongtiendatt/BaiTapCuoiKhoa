﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_QlTable_ListTable : System.Web.UI.Page
{

    
    protected void Page_Load(object sender, EventArgs e)
    {

        


    }
    [WebMethod]

    public static string XoaTable(int idtable)
    {
        DataUtil data = new DataUtil();
        data.xoatb(idtable);
        return "Đã xóa";
    }

}