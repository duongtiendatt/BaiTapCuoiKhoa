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
	member_password varchar(100),
	member_status int,
	member_type int
)
go


go
create table OrderDetail
(
	orderdetail_id int primary key identity(1,1),
	foodid int constraint FK_OrderFood_Food foreign key references Food(food_id),	
	quantity int,
	ordertableid int,	
)
go
create table qlTable
(
	table_id int primary key identity(1,1),
	table_name varchar(10),
	table_status bit,
	table_description ntext
)
create table OrderTable
(
	ordertable_id int primary key identity(1,1),
	ordertable_iduser int constraint FK_OrderTable_Member foreign key references Member(member_id),
	ordertable_timeset datetime,	
	ordertable_idtable int constraint FK_OrderTable_table foreign key references qlTable(table_id),
	ordertable_status bit,
)