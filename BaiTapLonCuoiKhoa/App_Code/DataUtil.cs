using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.Odbc;

/// <summary>
/// Summary description for DataUtil
/// </summary>
public class DataUtil
{
    SqlConnection con;
    public DataUtil()
    {
        string sqlcon = @"Data Source=.\SQLEXPRESS;Initial Catalog=WebsiteNhaHang;Integrated Security=True";
        con = new SqlConnection(sqlcon);

    }

    public List<table> dsTable()
    {
        List<table> listTable = new List<table>();
        string sqlslTable = "select * from qlTable";
        con.Open();
        SqlCommand cmd = new SqlCommand(sqlslTable, con);
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            table tb = new table();
            tb.table_id = (int)dr["table_id"];
            tb.table_name = (string)dr["table_name"];
            tb.table_status = (bool)dr["table_status"];
            tb.table_description = (string)dr["table_description"];

            listTable.Add(tb);

        }
        con.Close();
        return listTable;
    }


    public void AddTable(table tb)
    {
        string sqladdtb = "insert into qlTable values(@nametb,@stt,@mota)";
        con.Open();
        SqlCommand cmd = new SqlCommand(sqladdtb, con);
        cmd.Parameters.AddWithValue("nametb", tb.table_name);
        cmd.Parameters.AddWithValue("stt", tb.table_status);
        cmd.Parameters.AddWithValue("mota", tb.table_description);

        cmd.ExecuteNonQuery();
        con.Close();
    }
    public void xoatb(int matb)
    {
        string sqlxoatb = "delete from qlTable where table_id=@matb";
        con.Open();
        SqlCommand cmd = new SqlCommand(sqlxoatb, con);
        cmd.Parameters.AddWithValue("matb", matb);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public table lay1tb(int matb)
    {

        string sqlsl = "select * from qlTable where table_id=@matb";
        con.Open();
        SqlCommand cmd = new SqlCommand(sqlsl, con);
        cmd.Parameters.AddWithValue("matb", matb);
        SqlDataReader dr = cmd.ExecuteReader();
        table tb = null;
        while (dr.Read())
        {
            tb = new table();
            tb.table_id = (int)dr["table_id"];
            tb.table_name = (string)dr["table_name"];
            tb.table_status = (bool)dr["table_status"];
            tb.table_description = (string)dr["table_description"];



        }
        con.Close();
        return tb;
    }
    public void suatb(table tb)
    {
        string sqlsuqtb = "update  qlTable set table_name=@table_name,table_status=@table_status,table_description=@table_description where table_id=@table_id";
        con.Open();
        SqlCommand cmd = new SqlCommand(sqlsuqtb, con);
        cmd.Parameters.AddWithValue("table_name", tb.table_name);
        cmd.Parameters.AddWithValue("table_status", tb.table_status);
        cmd.Parameters.AddWithValue("table_description", tb.table_description);
        cmd.Parameters.AddWithValue("table_id", tb.table_id);

        cmd.ExecuteNonQuery();
        con.Close();
    }
    public List<OrderTable> dsOrderTable()
    {
        List<OrderTable> listOrderTable = new List<OrderTable>();
        string sqlslOrderTable = "select * from OrderTable";
        con.Open();
        SqlCommand cmd = new SqlCommand(sqlslOrderTable, con);
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            OrderTable tb = new OrderTable();
            tb.ordertable_id = (int)dr["ordertable_id"];
            tb.ordertable_iduser = (int)dr["ordertable_iduser"];
            tb.ordertable_timeset = (DateTime)dr["ordertable_timeset"];
            tb.ordertable_idtable = (int)dr["ordertable_idtable"];
            tb.ordertable_status = (bool)dr["ordertable_status"];




            listOrderTable.Add(tb);

        }
        con.Close();
        return listOrderTable;
    }



    public void xoaotb(int maotb)
    {
        string sqlxoatb = "delete from OrderTable where ordertable_id=@maotb";
        con.Open();
        SqlCommand cmd = new SqlCommand(sqlxoatb, con);
        cmd.Parameters.AddWithValue("maotb", maotb);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public OrderTable lay1otb(int maotb)
    {

        string sqlsl = "select * from OrderTable where ordertable_id=@maotb";
        con.Open();
        SqlCommand cmd = new SqlCommand(sqlsl, con);
        cmd.Parameters.AddWithValue("maotb", maotb);
        SqlDataReader dr = cmd.ExecuteReader();
        OrderTable otb = null;
        while (dr.Read())
        {
            otb = new OrderTable();
            otb.ordertable_id = (int)dr["ordertable_id"];
            otb.ordertable_iduser = (int)dr["ordertable_iduser"];
            otb.ordertable_timeset = (DateTime)dr["ordertable_timeset"];
            otb.ordertable_idtable = (int)dr["ordertable_idtable"];
            otb.ordertable_status = (bool)dr["ordertable_status"];


        }
        con.Close();
        return otb;
    }
    public void suaotb(OrderTable otb)
    {
        string sqlsuotb = "update  OrderTable set ordertable_iduser=@ordertable_iduser,ordertable_timeset=@ordertable_timeset,ordertable_idtable=@ordertable_idtable,ordertable_status=@ordertable_status where ordertable_id=@ordertable_id";
        con.Open();
        SqlCommand cmd = new SqlCommand(sqlsuotb, con);
        cmd.Parameters.AddWithValue("ordertable_iduser", otb.ordertable_iduser);
        cmd.Parameters.AddWithValue("ordertable_timeset", otb.ordertable_timeset);
        cmd.Parameters.AddWithValue("ordertable_idtable", otb.ordertable_idtable);
        cmd.Parameters.AddWithValue("ordertable_status", otb.ordertable_status);
        cmd.Parameters.AddWithValue("ordertable_id", otb.ordertable_id);

        cmd.ExecuteNonQuery();
        con.Close();
    }







    #region DatRegion
    /// <summary>
    /// Get list members
    /// created by : Dat 25-11-2018
    /// </summary>
    /// <returns></returns>
    public List<Member> GetListMembers()
    {
        List<Member> listMember = new List<Member>();
        string sqlslTable = "select * from Member";
        con.Open();
        SqlCommand cmd = new SqlCommand(sqlslTable, con);
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            Member mb = new Member();
            mb.member_id = (int)dr["member_id"];
            mb.member_status = (int)dr["member_status"];
            mb.member_type = (int)dr["member_type"];
            mb.member_fullname = (string)dr["member_fullname"];
            mb.member_mail = (string)dr["member_mail"];
            mb.member_password = (string)dr["member_password"];
            mb.member_phone = (string)dr["member_phone"];
            mb.member_username = (string)dr["member_username"];

            listMember.Add(mb);

        }
        con.Close();
        return listMember;
    }

    /// <summary>
    /// add new user
    /// </summary>
    /// <param name="member"></param>
    public void AddNewUser(Member member)
    {
        string sql = "insert into Member values(@fullname,@phone, @mail, @username, @password, @status, @type)";
        con.Open();
        SqlCommand cmd = new SqlCommand(sql, con);
        cmd.Parameters.AddWithValue("fullname", member.member_fullname);
        cmd.Parameters.AddWithValue("phone", member.member_phone);
        cmd.Parameters.AddWithValue("mail", member.member_mail);
        cmd.Parameters.AddWithValue("username", member.member_username);
        cmd.Parameters.AddWithValue("password", member.member_password);
        cmd.Parameters.AddWithValue("status", member.member_status);
        cmd.Parameters.AddWithValue("type", member.member_type);

        cmd.ExecuteNonQuery();
        con.Close();
    }


    /// <summary>
    /// Get info User by id
    /// </summary>
    /// <param name="idmember"></param>
    /// <returns></returns>
    public Member GetUser(int idmember)
    {

        string sql = "select * from Member where member_id=@idmember";
        con.Open();
        SqlCommand cmd = new SqlCommand(sql, con);
        cmd.Parameters.AddWithValue("idmember", idmember);
        SqlDataReader dr = cmd.ExecuteReader();

        Member mb = new Member();

        while (dr.Read())
        {
            mb.member_id = (int)dr["member_id"];
            mb.member_status = (int)dr["member_status"];
            mb.member_type = (int)dr["member_type"];
            mb.member_fullname = (string)dr["member_fullname"];
            mb.member_mail = (string)dr["member_mail"];
            mb.member_password = (string)dr["member_password"];
            mb.member_phone = (string)dr["member_phone"];
            mb.member_username = (string)dr["member_username"];
        }
        con.Close();
        return mb;
    }


    public Member GetUserByName(string username)
    {

        string sql = "select * from Member where member_username=@username or member_mail=@username";
        con.Open();
        SqlCommand cmd = new SqlCommand(sql, con);
        cmd.Parameters.AddWithValue("username", username);
        SqlDataReader dr = cmd.ExecuteReader();

        Member mb = new Member();

        while (dr.Read())
        {
            mb.member_id = (int)dr["member_id"];
            mb.member_status = (int)dr["member_status"];
            mb.member_type = (int)dr["member_type"];
            mb.member_fullname = (string)dr["member_fullname"];
            mb.member_mail = (string)dr["member_mail"];
            mb.member_password = (string)dr["member_password"];
            mb.member_phone = (string)dr["member_phone"];
            mb.member_username = (string)dr["member_username"];
        }
        con.Close();
        return mb;
    }


    /// <summary>
    /// Update user
    /// </summary>
    /// <param name="member"></param>
    public void UpdateUser(Member member)
    {
        string sql = "update Member set member_fullname=@fullname, member_mail=@mail, member_phone=@phone, member_status=@status, member_type=@type where member_id=@id";
        con.Open();
        SqlCommand cmd = new SqlCommand(sql, con);
        cmd.Parameters.AddWithValue("fullname", member.member_fullname);
        cmd.Parameters.AddWithValue("phone", member.member_phone);
        cmd.Parameters.AddWithValue("mail", member.member_mail);
        cmd.Parameters.AddWithValue("status", member.member_status);
        cmd.Parameters.AddWithValue("type", member.member_type);
        cmd.Parameters.AddWithValue("id", member.member_id);

        cmd.ExecuteNonQuery();
        con.Close();
    }



    public bool CheckLogin(string username, string password, int type)
    {
        string sql = "select * from Member where (member_username = @username or member_mail = @username) and member_password = @password and member_type=@type and member_status=1";
        con.Open();
        SqlCommand cmd = new SqlCommand(sql, con);

        cmd.Parameters.AddWithValue("username", username);
        cmd.Parameters.AddWithValue("password", password);
        cmd.Parameters.AddWithValue("type", type);

        Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
        con.Close();

        if (count > 0)
            return true;
        else
            return false;
    }



    public bool CheckRegister(string username, string mail, string phone)
    {
        string sql = "select * from Member where member_username=@username or member_mail = @mail or member_phone= @phone";
        con.Open();
        SqlCommand cmd = new SqlCommand(sql, con);

        cmd.Parameters.AddWithValue("username", username);
        cmd.Parameters.AddWithValue("mail", mail);
        cmd.Parameters.AddWithValue("phone", phone);

        Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
        con.Close();

        if (count > 0)
            return true;
        else
            return false;
    }
    #endregion    
    #region OrderDetai Huy

    public List<OrderDetail> dsOrderDetail()
    {
        List<OrderDetail> list = new List<OrderDetail>();
        string query = "select od.orderdetail_id,od.foodid,od.quantity,od.ordertableid,f.food_name,f.food_price,f.food_sale from OrderDetail od inner join Food f on od.foodid=f.food_id inner join OrderTable tb on od.ordertableid=tb.ordertable_id";
        con.Open();
        SqlCommand cmd = new SqlCommand(query, con);
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            OrderDetail od = new OrderDetail();
            od.orderdetailid = (int)dr["orderdetail_id"];
            od.foodid = (int)dr["foodid"];
            od.ordertableid = (int)dr["ordertableid"];
            od.quantity = (int)dr["quantity"];
            od.food_name = (string)dr["food_name"];
            od.food_price = (Double)dr["food_price"];
            od.food_sale = (int)dr["food_sale"];
            od.thanhtien = od.quantity  * od.food_price  * (Double)(100-od.food_sale)/ 100;
            list.Add(od);

        }
        con.Close();
        return list;
    }

    public List<OrderDetail> dsOrderDetailByTable(int tableid)
    {
        List<OrderDetail> list = new List<OrderDetail>();
        string query = "select od.orderdetail_id,od.foodid,od.quantity,od.ordertableid,f.food_name,f.food_price,f.food_sale from OrderDetail od inner join Food f on od.foodid=f.food_id inner join OrderTable tb on od.ordertableid=tb.ordertable_id where od.ordertableid=@tableid";
        con.Close();
        con.Open();
        SqlCommand cmd = new SqlCommand(query, con);
        cmd.Parameters.AddWithValue("tableid", tableid);
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            OrderDetail od = new OrderDetail();

            od.orderdetailid = (int)dr["orderdetail_id"];
            od.foodid = (int)dr["foodid"];
            od.ordertableid = (int)dr["ordertableid"];
            od.quantity = (int)dr["quantity"];
            od.food_name = (string)dr["food_name"];
            od.food_price = (Double)dr["food_price"];
            od.food_sale = (int)dr["food_sale"];

            od.thanhtien = od.quantity * od.food_price * (Double)(100 - od.food_sale) / 100;
            list.Add(od);

        }
        con.Close();
        return list;
    }

    public List<OrderDetail> dsOrderDetailByFood(int foodid)
    {
        List<OrderDetail> list = new List<OrderDetail>();
        string query = "select od.orderdetail_id,od.foodid,od.quantity,od.ordertableid,f.food_name,f.food_price,f.food_sale from OrderDetail od inner join Food f on od.foodid=f.food_id inner join OrderTable tb on od.ordertableid=tb.ordertable_id where od.foodid=@foodid";
        con.Open();
        SqlCommand cmd = new SqlCommand(query, con);
        cmd.Parameters.AddWithValue("foodid", foodid);
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            OrderDetail od = new OrderDetail()
            {
                orderdetailid = (int)dr["orderdetailid"],
                foodid = (int)dr["foodid"],
                ordertableid = (int)dr["ordertableid"],
                quantity = (int)dr["quantity"],
                food_name = (string)dr["food_name"],
                food_price = (Double)dr["food_price"],
                food_sale = (int)dr["food_sale"]
            };
            od.thanhtien = od.quantity * od.food_price * (Double)(100 - od.food_sale) / 100;
            list.Add(od);

        }
        con.Close();
        return list;
    }

    public void ThemOrderDetail(OrderDetail od)
    {
        string query = "insert into OrderDetail values(@orderdetailid,@foodid,@quantity,@ordertableid)";
        con.Open();
        SqlCommand cmd = new SqlCommand(query, con);
        cmd.Parameters.AddWithValue("orderdetailid", od.orderdetailid);
        cmd.Parameters.AddWithValue("orderdetailid", od.orderdetailid);
        cmd.Parameters.AddWithValue("quantity", od.quantity);
        cmd.Parameters.AddWithValue("ordertableid", od.ordertableid);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public void xoaOrderDetail(int matb)
    {
        string query = "delete from OrderDetail where orderdetail_id=" + matb;
        con.Open();
        SqlCommand cmd = new SqlCommand(query, con);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public List<OrderVM> GetListOrderVMByUser(int iduser)
    {
        string query = "select odtbl.ordertable_id,odtbl.ordertable_iduser,odtbl.ordertable_status,odtbl.ordertable_timeset,odtbl.ordertable_idtable,tbl.table_name,m.member_id,m.member_fullname,m.member_mail,m.member_phone  from OrderTable odtbl inner join Member m on odtbl.ordertable_iduser=m.member_id left join qlTable tbl on odtbl.ordertable_idtable=tbl.table_id where odtbl.ordertable_iduser="+iduser;
        con.Open();
        SqlCommand cmd = new SqlCommand(query, con);
        SqlDataReader dr = cmd.ExecuteReader();
        List<OrderVM> listRS = new List<OrderVM>();
        while (dr.Read())
        {
            OrderVM tbVM = new OrderVM();
            tbVM.ordertable_id = (int)dr["ordertable_id"];
            tbVM.ordertable_status = (Boolean)dr["ordertable_status"];
            tbVM.ordertable_iduser = (int)dr["ordertable_iduser"];
            tbVM.ordertable_timeset = (DateTime)dr["ordertable_timeset"];
            tbVM.member_fullname = (string)dr["member_fullname"];
            tbVM.member_mail = (string)dr["member_mail"];
            tbVM.member_phone = (string)dr["member_phone"];
            tbVM.table_name = (string)dr["table_name"];
            tbVM.TotalMoney = 0;
            tbVM.ListOrderDetail = this.dsOrderDetailByTable((int)dr["ordertable_id"]);
            var li = tbVM.ListOrderDetail;
            if (li.Count > 0)
            {
                Double t = 0;
                foreach (var item in li)
                {
                    t += (Double)(item.quantity * item.food_price * (Double)(100 - item.food_sale) / 100);
                }
                tbVM.TotalMoney = t;
            }
            listRS.Add(tbVM);
        }
        con.Close();
        return listRS;
    }
    public List<OrderVM> GetListOrderVM()
    {
        string query = "select odtbl.ordertable_id,odtbl.ordertable_iduser,odtbl.ordertable_status,odtbl.ordertable_timeset,odtbl.ordertable_idtable,tbl.table_name,m.member_id,m.member_fullname,m.member_mail,m.member_phone  from OrderTable odtbl inner join Member m on odtbl.ordertable_iduser=m.member_id left join qlTable tbl on odtbl.ordertable_idtable=tbl.table_id";
        con.Open();
        SqlCommand cmd = new SqlCommand(query, con);
        SqlDataReader dr = cmd.ExecuteReader();
        List<OrderVM> listRS = new List<OrderVM>();        
        if (dr.Read())
        {
            OrderVM tbVM = new OrderVM();
            tbVM.ordertable_id = (int)dr["ordertable_id"];
            tbVM.ordertable_status = (Boolean)dr["ordertable_status"];
            tbVM.ordertable_iduser = (int)dr["ordertable_iduser"];
            tbVM.ordertable_timeset = (DateTime)dr["ordertable_timeset"];
            tbVM.member_fullname = (string)dr["member_fullname"];
            tbVM.member_mail = (string)dr["member_mail"];
            tbVM.member_phone = (string)dr["member_phone"];
            tbVM.table_name = (string)dr["table_name"];
            tbVM.TotalMoney = 0;
            tbVM.ListOrderDetail = this.dsOrderDetailByTable((int)dr["ordertable_id"]);
            var li = tbVM.ListOrderDetail;
            if (li.Count > 0)
            {
                Double t = 0;
                foreach (var item in li)
                {
                    t += (Double)(item.quantity * item.food_price * (Double)(100 - item.food_sale) / 100);
                }
                tbVM.TotalMoney = t;
            }
            listRS.Add(tbVM);
        }
        con.Close();
        return listRS;
    }

    public OrderVM GetOrderVM(int idorderTable)
    {
        string query = "select odtbl.ordertable_id,odtbl.ordertable_iduser,odtbl.ordertable_status,odtbl.ordertable_timeset,odtbl.ordertable_idtable,tbl.table_name,m.member_id,m.member_fullname,m.member_mail,m.member_phone  from OrderTable odtbl inner join Member m on odtbl.ordertable_iduser=m.member_id left join qlTable tbl on odtbl.ordertable_idtable=tbl.table_id  where odtbl.ordertable_id=" + idorderTable;
        con.Open();
        SqlCommand cmd = new SqlCommand(query, con);
        SqlDataReader dr = cmd.ExecuteReader();
        OrderVM tbVM = new OrderVM();
        if (dr.Read())
        {
            tbVM.ordertable_id = (int)dr["ordertable_id"];
            tbVM.ordertable_status = (Boolean)dr["ordertable_status"];
            tbVM.ordertable_iduser = (int)dr["ordertable_iduser"];
            tbVM.ordertable_timeset = (DateTime)dr["ordertable_timeset"];
            tbVM.member_fullname = (string)dr["member_fullname"];
            tbVM.member_mail = (string)dr["member_mail"];
            tbVM.member_phone = (string)dr["member_phone"];
            tbVM.table_name = (string)dr["table_name"];
            tbVM.TotalMoney = 0;
            tbVM.ListOrderDetail = this.dsOrderDetailByTable(idorderTable);
            var li = tbVM.ListOrderDetail;
            if (li.Count > 0)
            {
                Double t = 0;
                foreach (var item in li)
                {
                    t += (Double)(item.quantity * item.food_price * (Double)(100 - item.food_sale) / 100);
                }
                tbVM.TotalMoney = t;
            }
        }
        con.Close();
        return tbVM;
    }

    #endregion

}


