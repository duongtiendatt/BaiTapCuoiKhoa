using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Member
/// </summary>
public class Member
{
    public Member()
    {
        //
        // TODO: Add constructor logic here
        //
    }

 //   member_id int primary key identity(1,1),
	//member_fullname nvarchar(200),
	//member_phone varchar(16),
	//member_mail varchar(100),
	//member_username varchar(20),
	//member_password varchar(20),
	//member_status int,
	//member_type int
    public int member_id { get; set; }
    public string member_fullname { get; set; }
    public string member_phone { get; set; }
    public string member_mail { get; set; }
    public string member_username { get; set; }
    public string member_password { get; set; }
    public int member_status { get; set; }
    public int member_type { get; set; }
}