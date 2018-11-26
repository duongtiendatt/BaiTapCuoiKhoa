using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Food
/// </summary>
public class Food
{
    public Food()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public int food_id { get; set; }
    public string food_name { get; set; }
    public double food_price { get; set; }
    public int food_sale { get; set; }
    public string food_avatar { get; set; }
    public string food_description { get; set; }
    public int foodtype_id { get; set; }

}