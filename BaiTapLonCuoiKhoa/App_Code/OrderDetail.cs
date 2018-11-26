using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for OrderFood
/// </summary>
public class OrderDetail
{
    public int? orderdetailid  { get; set; }
    public int? ordertableid  { get; set; }
    public int? foodid { get; set; }
    public int? quantity { get; set; }        

    //
    public Double? food_price { get; set; }
    public int? food_sale{ get; set; }
    public string food_name { get; set; }
    public Double? thanhtien { get; set; }
    public OrderDetail()
    {
        //
        // TODO: Add constructor logic here
        //
    } 
}