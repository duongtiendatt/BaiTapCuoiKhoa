using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for OrderTable
/// </summary>
public class OrderTable
{
    public OrderTable()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public int ordertable_id { get; set; }
    public int ordertable_iduser { get; set; }
    public DateTime ordertable_timeset { get; set; }
    public int ordertable_idtable { get; set; }
    public bool ordertable_status { get; set; }


}