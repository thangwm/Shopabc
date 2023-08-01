Create database shopabc
go
use shopabc 
go

CREATE TABLE KHACHHANG(

MaKH NCHAR (10) Primary Key,
TenKH NVARCHAR(50),
SDT INT,
DiaChi NVARCHAR(50)
)

create table loaihang
(
ID INT PRIMARY KEY,
Ten NVARCHAR (30)
)

CREATE TABLE Hang (
    MaMon INT PRIMARY KEY identity,
    TenMon NVARCHAR(50) NOT NULL,
	IDloaihang NVARCHAR(50) NOT NULL,
    Gia INT NOT NULL,
    HinhAnh VARBINARY(MAX) NOT NULL,
)

create table Account 
(
Username VARCHAR(50) Primary key,
Pass VARCHAR(50),
Phone INT,
)
go


CREATE TABLE Hoadon
(
MaHD nchar(10) Primary key,
MaKH nchar (10)
)

CREATE TABLE order_item (
    Id INT PRIMARY KEY IDENTITY,
    Item_id INT NOT NULL,
	MaHD nchar (10),
    Quantity INT NOT NULL,
    Total_price INT NOT NULL,
    Order_date DATETIME NOT NULL,
    
)
go 

Alter table Order_item add constraint FK_4 FOREIGN KEY (item_id) REFERENCES hang(MaMon)
Alter table Order_item add constraint FK_3 FOREIGN KEY (mahd)	 REFERENCES hoadon(mahd)
Alter table Hoadon	   add constraint FK_2 FOREIGN KEY (makh)	 REFERENCES khachhang(MaKH)
Alter table Hang	   add constraint FK_1 FOREIGN KEY (idhang)  REFERENCES loaihang(id)



INSERT INTO hang (TenMon,IDloaihang, Gia, HinhAnh)
VALUES ('Áo thun sọc ',1, 99000, (SELECT BulkColumn FROM Openrowset( Bulk 'C:\Users\thang\Downloads\BT_lớn_nhóm6\img\a.jpg', Single_Blob) as img))
INSERT INTO hang  (TenMon,IDloaihang, Gia, HinhAnh)
VALUES ('Áo Gucci ',1, 129000, (SELECT BulkColumn FROM Openrowset( Bulk 'C:\Users\thang\Downloads\BT_lớn_nhóm6\img\b.jpg', Single_Blob) as img))
INSERT INTO hang  (TenMon,IDloaihang, Gia, HinhAnh)
VALUES ('Quần rin Gucci',2, 199000, (SELECT BulkColumn FROM Openrowset( Bulk 'C:\Users\thang\Downloads\BT_lớn_nhóm6\img\c.jpg', Single_Blob) as img))
INSERT INTO hang  (TenMon,IDloaihang, Gia, HinhAnh)
VALUES ('áo khoác Gucci',1, 299000, (SELECT BulkColumn FROM Openrowset( Bulk 'C:\Users\thang\Downloads\BT_lớn_nhóm6\img\d.jpg', Single_Blob) as img))
INSERT INTO hang  (TenMon,IDloaihang, Gia, HinhAnh)
VALUES ('Áo thun trắng',1, 250000, (SELECT BulkColumn FROM Openrowset( Bulk 'C:\Users\thang\Downloads\BT_lớn_nhóm6\img\e.jpg', Single_Blob) as img))
INSERT INTO hang  (TenMon,IDloaihang, Gia, HinhAnh)
VALUES ('Giày abc',3, 300000, (SELECT BulkColumn FROM Openrowset( Bulk 'C:\Users\thang\Downloads\BT_lớn_nhóm6\img\g4.jpg', Single_Blob) as img))

insert into account values ('admin','123','0392694713')

select * from account
INSERT INTO order_item (item_id, quantity, total_price, order_date) VALUES (1, 1, 99000,getdate())
--
--INSERT INTO order_item (item_id, TenMon, Gia, quantity, total_price, order_date) 
--SELECT MaMon, TenMon, Gia, @quantity, @total_price, GETDATE() 
--FROM hang 
--WHERE MaMon = @item_id;

select * from  order_item

SELECT item_id, SUM(quantity) as total_quantity
FROM order_item
WHERE item_id = 6
GROUP BY item_id;




select * from  dbo.Hoadon
--
SELECT loaihang.Ten, SUM(order_item.Quantity) as total_quantity
FROM order_item
INNER JOIN Hang ON Hang.MaMon = order_item.Item_id
INNER JOIN loaihang ON loaihang.ID = Hang.IDloaihang
GROUP BY loaihang.Ten


select * from loaihang
insert dbo.loaihang values(1,N'Áo')
insert dbo.loaihang values(2,N'Quần')
insert dbo.loaihang values(3,N'Giày')


ALTER TABLE Hang
ALTER COLUMN MaMon int identity(1,1)
