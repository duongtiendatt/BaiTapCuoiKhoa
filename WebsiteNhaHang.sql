create database WebsiteNhaHang
go

use WebsiteNhaHang
go

create table Food
(
	food_id int primary key identity(1,1),
	food_name nvarchar(200),
	food_price float,
	food_type int,
	food_sale int,
	food_avatar nvarchar(200),
	food_description ntext
)
go


create table Member
(
	member_id int primary key identity(1,1),
	member_fullname nvarchar(200),
	member_phone varchar(16),
	member_mail varchar(100),
	member_username varchar(20),
	member_password varchar(20),
	member_status int,
	member_type int
)
go


create table OrderTable
(
	ordertable_id int primary key identity(1,1),
	ordertable_timeset datetime,
	ordertable_quantity int,
	ordertable_status int,
	ordertable_iduser int constraint FK_OrderTable_Member foreign key references Member(member_id),
)
go
create table OrderFood
(
	orderfood_id int primary key identity(1,1),
	orderfood_foodid int constraint FK_OrderFood_Food foreign key references Food(food_id),
	orderfood_timeorder datetime,
	orderfood_quantity int,
	orderfood_totalmoney float,
	orderfood_iduser int constraint FK_OrderFood_Member foreign key references Member(member_id),
	orderfood_ordertable bit,
	orderfood_status int

)
go