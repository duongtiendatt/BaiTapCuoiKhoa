using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for OrderTableVM
/// </summary>
public class OrderVM
{
    public int? ordertable_id { get; set; }
    public DateTime ordertable_timeset { get; set; }    
    public Boolean? ordertable_status { get; set; }
    public int? ordertable_iduser { get; set; }

    public string table_name { get; set; }

    public string member_mail { get; set; }
    public string member_phone { get; set; }
    public string member_fullname { get; set; }

    public Double? TotalMoney { get; set; }

    public List<OrderDetail> ListOrderDetail { get; set; }

    public OrderVM()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}