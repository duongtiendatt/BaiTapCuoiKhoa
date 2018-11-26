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
    string sqlcon = @"Data Source=.\SQLEXPRESS;Initial Catalog=WebsiteNhaHang;Integrated Security=True";        
    public DataUtil()
    {
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
    #region DUC
    public List<Food> getListFood()
    {
        List<Food> li = new List<Food>();
        string strSql = "select * from Food";
        con.Open();

        SqlCommand cmd = new SqlCommand(strSql, con);
        SqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            Food f = new Food();
            f.food_id = (int)dr["food_id"];
            f.food_name = (string)dr["food_name"];
            f.food_price = (double)dr["food_price"];
            f.food_sale = (int)dr["food_sale"];
            f.food_avatar = (string)dr["food_avatar"];
            f.food_description = (string)dr["food_description"];
            f.foodtype_id = (int)dr["foodtype_id"];

            li.Add(f);
        }
        con.Close();
        return li;
    }
    public void DeleteFood(int idFood)
    {
        string strSql = "delete from Food where food_id=@idFood";
        con.Open();
        SqlCommand cmd = new SqlCommand(strSql, con);

        cmd.Parameters.AddWithValue("idFood", idFood);
        cmd.ExecuteNonQuery();

        con.Close();
    }
    public void AddFood(Food f)
    {
        string strSql = "insert into Food values(@food_name, @food_price, @food_sale, @food_avatar, @food_description, @foodtype_id)";
        con.Open();
        SqlCommand cmd = new SqlCommand(strSql, con);

        cmd.Parameters.AddWithValue("food_name", f.food_name);
        cmd.Parameters.AddWithValue("food_price", f.food_price);
        cmd.Parameters.AddWithValue("food_sale", f.food_sale);
        cmd.Parameters.AddWithValue("food_avatar", f.food_avatar);
        cmd.Parameters.AddWithValue("food_description", f.food_description);
        cmd.Parameters.AddWithValue("foodtype_id", f.foodtype_id);

        cmd.ExecuteNonQuery();

        con.Close();
    }

    public List<FoodType> getListFoodType()
    {
        List<FoodType> liFoodType = new List<FoodType>();
        string strSql = "select * from FoodType";
        con.Open();

        SqlCommand cmd = new SqlCommand(strSql, con);
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            FoodType d = new FoodType();
            d.foodtype_id = (int)dr["foodtype_id"];
            d.foodtype_name = (string)dr["foodtype_name"];

            liFoodType.Add(d);
        }
        con.Close();
        return liFoodType;

    }

    // Sửa
    public Food get1Food(int food_id)
    {
        List<Food> lifood = new List<Food>();
        string strSql = "select * from Food where food_id=@food_id";
        con.Open();

        SqlCommand cmd = new SqlCommand(strSql, con);

        cmd.Parameters.AddWithValue("food_id", food_id);

        SqlDataReader dr = cmd.ExecuteReader();

        Food f = new Food();
        if (dr.Read())
        {
            f.food_id = (int)dr["food_id"];
            f.food_name = (string)dr["food_name"];
            f.food_price = (double)dr["food_price"];
            f.food_sale = (int)dr["food_sale"];
            f.food_avatar = (string)dr["food_avatar"];
            f.food_description = (string)dr["food_description"];
            f.foodtype_id = (int)dr["foodtype_id"];

        }
        con.Close();
        return f;
    }

    public void EditFood(Food food)
    {
        string strsql = "update Food set food_name=@food_name, food_price=@food_price, food_sale=@food_sale, food_avatar=@food_avatar, food_description=@food_description, foodtype_id=@foodtype_id where food_id=@id";
        con.Open();
        SqlCommand cmd = new SqlCommand(strsql, con);

        cmd.Parameters.AddWithValue("food_name", food.food_name);
        cmd.Parameters.AddWithValue("food_price", food.food_price);
        cmd.Parameters.AddWithValue("food_sale", food.food_sale);
        cmd.Parameters.AddWithValue("food_avatar", food.food_avatar);
        cmd.Parameters.AddWithValue("food_description", food.food_description);
        cmd.Parameters.AddWithValue("foodtype_id", food.foodtype_id);
        cmd.Parameters.AddWithValue("id", food.food_id);

        cmd.ExecuteNonQuery();
        con.Close();
    }

    // Select theo THẺ lOẠI MÓN ĂN
    public List<Food> getListFoodDiscount(int foodtype_id)
    {
        List<Food> liFoDiscount = new List<Food>();
        string strSql = "select * from Food where foodtype_id=@foodtype_id";
        con.Open();

        SqlCommand cmd = new SqlCommand(strSql, con);
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            Food f = new Food();
            f.food_id = (int)dr["food_id"];
            f.food_name = (string)dr["food_name"];
            f.food_price = (double)dr["food_price"];
            f.food_sale = (int)dr["food_sale"];
            f.food_avatar = (string)dr["food_avatar"];
            f.food_description = (string)dr["food_description"];
            f.foodtype_id = (int)dr["foodtype_id"];

            liFoDiscount.Add(f);
        }
        con.Close();
        return liFoDiscount;
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
            od.thanhtien = od.quantity * od.food_price * (Double)(100 - od.food_sale) / 100;
            list.Add(od);
        }
        con.Close();
        return list;
    }

    public List<OrderDetail> dsOrderDetailByTable(int tableid)
    {
        using (var conn = new SqlConnection(sqlcon))
        {
            List<OrderDetail> list = new List<OrderDetail>();
            string query = "select od.orderdetail_id,od.foodid,od.quantity,od.ordertableid,f.food_name,f.food_price,f.food_sale from OrderDetail od inner join Food f on od.foodid=f.food_id inner join OrderTable tb on od.ordertableid=tb.ordertable_id where od.ordertableid=@tableid";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
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
            conn.Close();
            return list;
        }
    }

    public List<OrderDetail> dsOrderDetailByFood(int foodid)
    {
        using (var conn = new SqlConnection(sqlcon))
        {
            List<OrderDetail> list = new List<OrderDetail>();
            string query = "select od.orderdetail_id,od.foodid,od.quantity,od.ordertableid,f.food_name,f.food_price,f.food_sale from OrderDetail od inner join Food f on od.foodid=f.food_id inner join OrderTable tb on od.ordertableid=tb.ordertable_id where od.foodid=@foodid";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
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
            conn.Close();
            return list;
        }
    }

    public void ThemOrderDetail(OrderDetail od)
    {
        using (var conn = new SqlConnection(sqlcon))
        {
            string query = "insert into OrderDetail values(@orderdetailid,@foodid,@quantity,@ordertableid)";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("orderdetailid", od.orderdetailid);
            cmd.Parameters.AddWithValue("orderdetailid", od.orderdetailid);
            cmd.Parameters.AddWithValue("quantity", od.quantity);
            cmd.Parameters.AddWithValue("ordertableid", od.ordertableid);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
    public void xoaOrderDetail(int matb)
    {
        using (var conn = new SqlConnection(sqlcon))
        {
            string query = "delete from OrderDetail where orderdetail_id=" + matb;
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
    public List<OrderVM> GetListOrderVMByUser(int iduser)
    {
        using (var conn = new SqlConnection(sqlcon))
        {
            string query = "select odtbl.ordertable_id,odtbl.ordertable_iduser,odtbl.ordertable_status,odtbl.ordertable_timeset,odtbl.ordertable_idtable,tbl.table_name,m.member_id,m.member_fullname,m.member_mail,m.member_phone  from OrderTable odtbl inner join Member m on odtbl.ordertable_iduser=m.member_id left join qlTable tbl on odtbl.ordertable_idtable=tbl.table_id where odtbl.ordertable_iduser=" + iduser;
            conn.Close();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
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
            conn.Close();
            return listRS;
        }
    }
    public List<OrderVM> GetListOrderVM()
    {
        using (var conn = new SqlConnection(sqlcon))
        {
            List<OrderVM> listRS = new List<OrderVM>();
            string query = "select odtbl.ordertable_id,odtbl.ordertable_iduser,odtbl.ordertable_status,odtbl.ordertable_timeset,odtbl.ordertable_idtable,tbl.table_name,m.member_id,m.member_fullname,m.member_mail,m.member_phone  from OrderTable odtbl inner join Member m on odtbl.ordertable_iduser=m.member_id left join qlTable tbl on odtbl.ordertable_idtable=tbl.table_id";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
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
            conn.Close();
            dr.Close();
            return listRS;
        }
    }

    public OrderVM GetOrderVM(int idorderTable)
    {
        using (var conn = new SqlConnection(sqlcon))
        {
            string query = "select odtbl.ordertable_id,odtbl.ordertable_iduser,odtbl.ordertable_status,odtbl.ordertable_timeset,odtbl.ordertable_idtable,tbl.table_name,m.member_id,m.member_fullname,m.member_mail,m.member_phone  from OrderTable odtbl inner join Member m on odtbl.ordertable_iduser=m.member_id left join qlTable tbl on odtbl.ordertable_idtable=tbl.table_id  where odtbl.ordertable_id=" + idorderTable;
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
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
            conn.Close();
            return tbVM;
        }
    }

    #endregion

}


