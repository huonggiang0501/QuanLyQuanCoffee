create database QuanLyQuanCoffe
go

use QuanLyQuanCoffe
go
---------
create table Employee
(	idEmployee nvarchar(50) primary key NOT NULL,
	Name nvarchar(50) NOT NULL,
	Gender nvarchar(50) NOT NULL,
	Address nvarchar(100) NOT NULL,
	Phone nvarchar(50) NOT NULL,
	Email nvarchar(100) NOT NULL,
	Salary decimal(18, 0) NOT NULL,
	StartDay date NOT NULL,

)
insert into Employee values
(	'N00',N'Nguyễn Nhật Minh',N'NAM',N'Hà Nội','0983328643','MINH@gmail.com',100000,'1/2/2022'),
(	'N01',N'Trần Linh Chi',N'Nữ',N'Hà Nội','09828643','Chi@gmail.com',50000,'2/2/2022'),
(	'N02',N'Hà Mai Trang',N'Nữ',N'Hưng Yên','09834443','Trang@gmail.com',40000,'1/2/2022'),
(	'N03',N'Trần Văn Kiên',N'Nam',N'Thái Bình','0922338643','Kien@gmail.com',45000,'2/2/2022'),
(	'N04',N'Nguyễn Huy Quang',N'Nam',N'Cần Thơ','098224223','Quang@gmail.com',20000,'6/2/2022');
go

-------
create table Account
( 
	username nvarchar(100) primary key not null,
	password nvarchar(100) not null,
	type nvarchar(50) not null,
	idEmployee nvarchar(50),
	constraint FK_1 foreign key (idEmployee) references Employee(idEmployee)

)
go

insert into Account values 
	('Admin','admin','admin','N00'),
	('chichi','chi','staff','N01'),
	('hatrang','trang','staff','N02'),
	('kientran','kien','staff','N03'),
	('quang','quang','staff','N04');


------
create table FoodCategory
(
	id int identity(1,1) primary key,
	name nvarchar(100) default N'Trống' 
)
go
set identity_insert FoodCategory on
	insert FoodCategory(id, name)values     (1,N'Trà sữa')
	insert FoodCategory(id, name) values	(2,N'Hồng Trà')
	insert FoodCategory(id, name) values	(3,N'Bánh Ngọt')
	insert FoodCategory(id, name) values	(4,N'Cafe Việt Nam')
	insert FoodCategory(id, name) values	(5,N'Cafe Máy')
set identity_insert FoodCategory off	

----------
create table Food(
	id int identity(1,1) primary key,
	Foodname nvarchar(100) not null default N'Chưa đặt tên',
	idCategory int not null,
	price float not null default 0,
	image nchar(100),
	constraint FK_2 foreign key (idCategory) references FoodCategory(id)
)
go
set identity_insert Food on
	insert Food (id,Foodname,idCategory, price, image) values (1, N'Trà sữa matcha ', 1, 30000, N'ts_matcha.jpg ')
	
	insert Food (id,Foodname,idCategory, price, image) values (2, N'Trà sữa chân trâu đen ',1, 41000, N'ts_chantrau.jpg ')
	
	insert Food (id,Foodname,idCategory, price, image) values (3, N'Hồng Trà xanh ',2, 30000, N'ht_xanh.jpg ')
	
	insert Food (id,Foodname,idCategory, price, image) values (4, N'Hồng Trà Nhài ',2, 35000, N'ht_nhai.jpg ')
	
	insert Food (id,Foodname,idCategory, price, image) values (5, N'Bánh socola ',3, 20000, N'b_socola.jpg ')
	
	insert Food (id,Foodname,idCategory, price, image) values (6, N'Bánh crepe',3, 25000, N'b_crepe.jpg ')
	
	insert Food (id,Foodname,idCategory, price, image) values (7, N'Bánh kimsa',3, 25000, N'b_kimchi.jpg ')
	
	insert Food (id,Foodname,idCategory, price, image) values (8, N'Cafe đen',4, 25000, N'cafe_den.jpg ')
	
	insert Food (id,Foodname,idCategory, price, image) values (9, N'Cafe sữa',4, 35000, N'cafe_sua.jpg ')
	
	insert Food (id,Foodname,idCategory, price, image) values (10, N'Latte',5, 35000, N'latte.jpg ')
	
	insert Food (id,Foodname,idCategory, price, image) values (11, N'Mocha',5, 45000, N'mocha.jpg ')
	
set identity_insert Food off
--------
create table Incredient(
	idCre char(10) primary key,
	NameCre nvarchar(30),
	Quantity float ,
	Price float

);
insert into Incredient values
	( '1','Bột trà sữa truyền thống',10.0,280.0),
	( '2','Bột trà sữa matcha',10.0,280.0),
	( '3','lá trà xanh',10.0,280.0),
	( '4','Trân châu đen',10.0,280.0),
	( '5','Đường',10.0,280.0),
	( '6','Bột Cafe',10.0,280.0),
	( '7','Sữa tươi',10.0,280.0),
	( '8','Bột Latte',10.0,280.0),
	( '9','Bột trà nhài',10.0,280.0),
	( '10','Bánh Socola',10.0,280.0),
	( '11','Bánh Crepe',10.0,280.0),
	( '12','Bánh Kimsa',10.0,280.0),
	( '13','Mocha',10.0,280.0);


----
create table IncredientOfFood(
	id char(10) primary key,
	idFood int null,
	idCre char(10) null,
	QuantityIncre float null,
	constraint FK_10 foreign key (idFood) references Food(id),
	constraint FK_11 foreign key (idCre) references Incredient(idCre)
);
ALTER TABLE IncredientOfFood
add constraint QI default 0 for QuantityIncre;


insert into IncredientOfFood values
	('1',1,'2',0.1),
	('2',1,'5',0.2),
	('3',1,'4',0.1),
	('4',2,'1',0.1),
	('5',2,'5',0.1),
	('6',3,'3',0.1),
	('7',3,'5',0.1),
	('8',4,'9',0.1),
	('9',4,'7',0.1),
	('10',5,'10',1),
	('11',6,'11',1),
	('12',7,'12',1),
	('13',11,'13',1),
	('14',8,'6',0.3),
	('15',8,'5',0.2),
	('16',9,'6',0.3),
	('17',9,'7',0.5),
	('18',9,'5',0.2),
	('19',10,'8',0.3),
	('20',10,'7',0.2);

-----
create table Promotion
(	idPromotion nvarchar(50) primary key NOT NULL,
	StartDate date NULL,
	EndDate date NULL,
	Description nvarchar(500) NOT NULL,
	PricePromotion decimal(18, 0) NOT NULL,
	
	
)
insert into Promotion values 
	(N'Không','2022-5-20','2022-5-22',N'Không khuyến mại',CAST(0 AS Decimal(18, 0))),
	(N'KMU22','2022-5-25','2022-5-27',N'Khuyến mại U22',CAST(20000 AS Decimal(18, 0)));


--------
create table Bill
(	id int identity(1,1) primary key,
	time datetime NOT NULL,
	idEmployee nvarchar(50) not null,
	idPromotion nvarchar(50) ,
	TotalPrice int NOT NULL,
	
	constraint FK_9 foreign key (idEmployee) references Employee(idEmployee),
	constraint FK_8 foreign key (idPromotion) references Promotion(idPromotion)
	
)
go
ALTER TABLE dbo.Bill 
AlTER COLUMN idEmployee nvarchar(50) null;

--------
create table BillInfo
(	id int identity(1,1) primary key,
	idBill int not null,
	idFood int not null,
	count int not null default 0,
	constraint FK_3 foreign key (idBill) references Bill(id),
	constraint FK_4 foreign key (idFood) references Food(id)
)
go






-------
create table TimeKeep
(
	id int identity(1,1) primary key NOT NULL,
	idEmployee nvarchar(50) NOT NULL,
	Date date NOT NULL,
	CheckIn time(7) NOT NULL,
	CheckOut time(7) NOT NULL,
	Note nchar(10) NULL,
	constraint FK_6 foreign key (idEmployee) references Employee(idEmployee)

)
------
create table Shifts
(	idShift nvarchar(50) primary key NOT NULL,
	StartDate nvarchar(50) NOT NULL,
	EndDate nvarchar(50) NOT NULL,
	Note nvarchar(500) NULL,
	idEmployee nvarchar(50) ,
	constraint FK_7 foreign key (idEmployee) references Employee(idEmployee)
)
insert into Shifts values
	(N'Ca 1', N'7:00', N'11:00', NULL, 'N02'),
	(N'Ca 2', N'11:05', N'16:05', NULL, 'N01'),
	(N'Ca 3', N'16:10', N'20:00', NULL, 'N03'),
	(N'Ca 4', N'20:10', N'22:00', NULL, 'N04');
--- proc login
CREATE PROC USP_Login
	@username nvarchar(100),
	@password nvarchar(100)
AS
BEGIN
	select * from Account where username = @username and password = @password
END
GO
DROP PROC dbo.USP_Login 
GO
execute USP_Login 'Admin','@admin@';
------ 
---proc đổi mật khẩu
Create proc USP_ChangePassword
@username varchar(50) , @newpass varchar(50)
as
Begin
	UPDATE Account
   SET 
      password = @newpass
      
 WHERE username = @username
End
GO
--------Thêm bill
Create proc USP_InsertBill
	@idEmp nvarchar(50), 
	@idPromo nvarchar(50), 
	@totalPrice int
as
begin
	Insert  Bill
	(
		time,
		idEmployee,
		idPromotion,
		TotalPrice
	)
	Values
	(
		GETDATE(),
		@idEmp,
		@idPromo,
		@totalPrice
	)
end
GO
execute USP_InsertBill 'N01','Không',30000;
drop proc USP_InsertBill;
---------Thêm billinfo
Create proc USP_InsertBillInfo
	@idBill int, @idFood int, @idCount int
as
Begin
	INSERT BillInfo
           (idBill
           ,idFood
           ,count)
     VALUES
           (@idBill
           ,@idFood
           ,@idCount)
End
GO
execute USP_InsertBillInfo 5,3,1;
-------
---- trigger trừ nguyên liệu sau khi order
-------
create trigger tg_test on BillInfo
for insert,update
as
	-- Lấy ra danh sách nguyên liệu của food
	declare @incre table(
		id char(10) primary key,
		idFood int ,
		idCre char(10),
		QuantityIncre float
		
		
	);
	
	insert into @incre 
	select * from IncredientOfFood where IncredientOfFood.idFood = (select idFood from inserted) ;
	
	-- Trừ nguyên liệu
	declare @count int, @idF int, @idCre char(10), @Quantity float
	select @count = (select inserted.count from inserted); -- lấy ra số lượng của món khi đặt hàng

	declare cursors CURSOR for  -- khai báo con trỏ cursors trỏ tới từng dòng của @incre
	select idFood, idCre, QuantityIncre from @incre

	open cursors -- mở con trỏ

	FETCH NEXT FROM cursors into @idF, @idCre, @Quantity  -- đọc dòng đầu tiên

	WHILE @@FETCH_STATUS =0  -- vong lặp while khi đọc cursur thành công

	BEGIN
		update Incredient
		set Quantity = Quantity - ( @Quantity * @count )
		where Incredient.idCre = @idCre
		
		FETCH NEXT FROM cursors into @idF, @idCre, @Quantity

	END
	CLOSE cursors -- đóng con trỏ
	DEALLOCATE cursors -- giải phóng tài nguyên
	
	


	--select * from inserted;

	--select * from @incre;
	--select * from Incredient;

go
drop trigger tg_test;


-----Lấy danh sách bill theo time

create proc USP_GetListByDateRange
@start date , @end date
as
Begin
	Select * 
	from dbo.Bill where @start <= time and time <= @end
End
GO
drop database QuanLyQuanCoffe;


-----Update khuyến mại
create proc USP_UpdatePromo
	@idnew varchar(50) , @start date , @end date , @price decimal , @des nvarchar(50) , @id varchar(50)
as
begin
	UPDATE Promotion
   SET idPromotion = @idnew
      ,StartDate = @start
      ,EndDate = @end
      ,Description = @des
      ,PricePromotion = @price
 WHERE idPromotion = @id
end
go


----------------Thêm KM

create proc USP_InsertPromo
@idnew varchar(50) , @start date , @end date , @price decimal , @des nvarchar(50) 
as
begin
	INSERT INTO Promotion
           (idPromotion
           ,StartDate
           ,EndDate
           ,Description
           ,PricePromotion)
     VALUES
           (@idnew
           ,@start
           ,@end
           ,@des
           ,@price)

end
go
----- Thêm Food
create proc [dbo].[USP_InsertFood]
@name nvarchar(50) , @type int , @price int , @image nvarchar(1000)  
as
Begin
	INSERT INTO [dbo].[Food]        
        ( Foodname,
		idCategory,
		price,
		image)
     VALUES
         (@name
         ,@type
         ,@price
         ,@image)
End
GO

----Sửa thông tin Food
create proc [dbo].[USP_UpdateProductInf]
@id int, @name nvarchar(50) , @type int , @price int , @image nvarchar(50)
as
Begin
	UPDATE [dbo].[Food]
   SET 
      [FoodName] = @name,
      [idCategory] = @type,
      [price] = @price,
      [image] = @image
      
 WHERE id = @id
End
GO
--thêm nhân viên
Create proc [dbo].[USP_AddEmployee]
@id nvarchar(50), @name nvarchar(50) , @gender nvarchar(50) , @address nvarchar(100) , @phone nvarchar(50), @email nvarchar(100), @salary int, @startday date  
as
Begin
	INSERT INTO [dbo].[Employee]        
      ( [idEmployee]
       ,[Name]
       ,[Gender]
       ,[Address]
       ,[Phone]
       ,[Email]
       ,[Salary]
       ,[StartDay])
     VALUES
         (@id
         ,@name
         ,@gender
         ,@address
         ,@phone
         ,@email
         ,@salary
         ,@startday)
End
GO
-- thêm thông tin bảng nhân viên 
create proc [dbo].[USP_UpdateInfor]
@id nvarchar(50), @name nvarchar(50) , @gt nchar(50) , @dc nvarchar(100) , @dt nvarchar(50) , @email nvarchar(100) , @luong int , @ngaybd date 
as
Begin
	UPDATE [dbo].[Employee]
   SET 
      [Name] = @name,
      [Gender] = @gt,
      [Address] = @dc,
      [Phone] = @dt,
      [Email] = @email,
      [Salary] = @luong,
      [StartDay] = @ngaybd
           
 WHERE IdEmployee = @id
End
GO
drop proc USP_UpdateInfor;
------- them account
Create proc [dbo].[USP_AddNewUser]
@username nvarchar(100) , @password nvarchar(100) , @type nvarchar(50) , @idEmployee nvarchar(50)  
as
Begin
	INSERT INTO [dbo].[Account]        
       ( [username]
		,[password]
        ,[type]
        ,[idEmployee])
     VALUES
         (@username
         ,@password
         ,@type
         ,@idEmployee)
End
GO
SELECT *FROM dbo.Account
GO 
SELECT *FROM dbo.Employee
GO 
-- thống kê theo bill-- ngày làm 9/6/2022
create proc [dbo].[USP_GetListByDateRange1]
@start date , @end date
as 
Begin
	Select * 
	from dbo.Bill where @start <= Time and Time <= @end 
End
GO
select * from Bill 
go

-- tinh tong tien
create proc [dbo].[USP_SumPrice]
@start date , @end date
as 
Begin
	Select Sum(TotalPrice) 
	from dbo.Bill where @start <= Time and Time <= @end 
End
GO
exec USP_SumPrice "2022-06-08","2022-06-10"
go 
select * from Bill 
go
--- thong ke KM
create proc [dbo].[USP_GetListByDateRangeKM]
@start date , @end date,@Makm nvarchar(30)
as 
Begin
	Select a.id , a.time, a.idEmployee,a.idPromotion, a.TotalPrice 
	from Bill a , Promotion b where a.idPromotion = b.idPromotion and @start <= Time and Time <= @end and a.idPromotion = @Makm /*and idPromotion != 'Không'*/ 
	
End
GO
exec USP_GetListByDateRangeKM "2022-06-08","2022-07-30",'Không'
drop proc [dbo].[USP_GetListByDateRangeKM];
select * from Bill 
go
-- tinh tong tien KM
create proc [dbo].[USP_SumPriceKM]
@start date , @end date,@Makm nvarchar(30)
as 
Begin
	Select Sum(a.TotalPrice) 
	from Bill a , Promotion b where a.idPromotion = b.idPromotion and @start <= Time and Time <= @end and a.idPromotion = @Makm /*and idPromotion != 'Không'*/ 
	
End
GO
exec USP_SumPriceKM "2022-06-08","2022-07-30",'Không'
drop proc [dbo].[USP_SumPriceKM];
go 
select * from Bill 
GO
------------- 

----- Thống kê theo sản phẩm

create proc [dbo].[USP_GetListByDateRangeSP]
@start date , @end date
as 
Begin
	Select c.id, c.Foodname,c.price,sum(a.count) as Soluong,sum((a.count)*c.price) as ThanhTien
	from BillInfo a, Bill b, Food c where a.idBill= b.id and a.idFood = c.id and @start <= Time and Time <= @end 
	group by c.id,c.Foodname,c.price
	order by sum(a.count) desc
End
GO
drop proc USP_GetListByDateRangeSP;
execute  USP_GetListByDateRangeSP "2022-07-01","2022-07-13";
GO 

select * from BillInfo

-- xóa acount 
CREATE TRIGGER Delete_Employee ON dbo.Employee INSTEAD OF DELETE
as
BEGIN 
	ALTER TABLE dbo.Account DROP CONSTRAINT FK_1;
	ALTER TABLE dbo.BillInfo DROP CONSTRAINT FK_3;
	ALTER TABLE dbo.Bill DROP CONSTRAINT FK_9;
	ALTER TABLE dbo.Shifts DROP CONSTRAINT FK_7;

	
	DELETE FROM dbo.Account WHERE idEmployee IN (SELECT idEmployee FROM Deleted);
	DELETE FROM dbo.Bill WHERE idEmployee IN(SELECT idEmployee FROM Deleted);
	DELETE FROM dbo.BillInfo WHERE idBill IN (SELECT idBill FROM Deleted);

	DELETE FROM dbo.Shifts WHERE idEmployee IN (SELECT idEmployee FROM deleted);
	DELETE FROM dbo.Employee WHERE idEmployee IN (SELECT idEmployee FROM Deleted);

	ALTER TABLE dbo.Bill ADD CONSTRAINT FK_9 FOREIGN KEY(idEmployee) REFERENCES dbo.Employee(idEmployee);
	ALTER TABLE dbo.BillInfo ADD CONSTRAINT FK_3 FOREIGN KEY(idBill) REFERENCES dbo.Bill(id);
	ALTER TABLE dbo.Account ADD CONSTRAINT FK_1 FOREIGN KEY (idEmployee) REFERENCES dbo.Employee(idEmployee);
	ALTER TABLE dbo.Shifts ADD CONSTRAINT FK_7 foreign key (idEmployee) references Employee(idEmployee);

END
GO 
drop trigger Delete_Employee;
-- trigger xoá sản phẩm
create trigger DELETE_Food ON dbo.Food instead of delete
as
begin
	--AlTER table dbo.Food DROP constraint FK_2;
	AlTER table dbo.BillInfo DROP constraint FK_4;

	delete from dbo.BillInfo where idFood IN (SELECT id from deleted);
	delete from dbo.Food where id IN (SELECT id from deleted);

	alter table dbo.BillInfo add constraint FK_4 foreign key (idFood) references Food(id);

end
go
delete from Food where id = 2;

-- trigger xoá khuyến mại

create trigger delete_KM on dbo.Promotion instead of delete
as
begin
	alter table dbo.Bill drop constraint FK_8;

	delete from dbo.Bill where idPromotion in ( select idPromotion from deleted);
	delete from dbo.Promotion where idPromotion in ( select idPromotion from deleted);
	
	alter table dbo.Bill add constraint FK_8 foreign key (idPromotion) references Promotion(idPromotion);

end
go

delete from Promotion where idPromotion = 'KMU22';

--- Theem Nguyen Lieu
create proc [dbo].[USP_InsertIncre]
@idCre char(10), @NameCre nvarchar(30) ,@Quantity float, @Price float
as
Begin 
	insert into [dbo].[Incredient] 
		(idCre,
		NameCre,
		Quantity,
		Price)
	values 
	   (@idCre,
		@NameCre,
		@Quantity,
		@Price)
end
go
drop proc [dbo].[USP_InsertIncre];
execute  [dbo].[USP_InsertIncre] 'suuu','Kem',10,10;


--- Sua Nguyen Lieu
create proc [dbo].[USP_UpdateIncre]
@id char(10), @NameCre nvarchar(30) ,@Quantity float, @Price float
as
Begin 
	update [dbo].[Incredient] 
	set 
	    --idCre = @idCre,
		NameCre = @NameCre,
		Quantity = @Quantity,
		Price = @Price
	where idCre = @id
end
go
drop proc [dbo].[USP_UpdateIncre];
execute [dbo].[USP_UpdateIncre] 'suuu','Kem1',12,10;


--- triger xóa nguyên liệu
create trigger delete_NL on dbo.Incredient instead of delete
as
begin
	alter table dbo.IncredientOfFood drop constraint FK_11;

	delete from dbo.IncredientOfFood where idCre in (select idCre from deleted);
	delete from dbo.Incredient where idCre in (select idCre from deleted);

	alter table dbo.IncredientOfFood add constraint FK_11 foreign key (idCre) references Incredient(idCre);
	

end
go
	
------ Lấy danh sách nguyên liệu thuộc món ăn
create proc USP_GetListInCreOfFood
@idFood int
as
begin
	declare @incre table(
		id char(10) primary key,
		idFood int ,
		idCre char(10),
		QuantityIncre float
		
		
	);
	
	insert into @incre 
	select * from IncredientOfFood where IncredientOfFood.idFood = @idFood ;
	
	select * from @incre;


end
go
drop proc USP_GetListInCreOfFood;
exec USP_GetListInCreOfFood 1;


---- Thêm nguyên liệu cho 1 món ăn

create proc [dbo].[USP_InsertIncreOfFood]
@id char(10), @idFood int ,@idCre char(10), @QuantityIncre float
as
Begin 
	insert into [dbo].[IncredientOfFood] 
		(id,
		idFood,
		idCre,
		QuantityIncre)
	values 
	   (@id,
		@idFood,
		@idCre,
		@QuantityIncre)
end
go

exec USP_InsertIncreOfFood '22',1,'7',0.2;
select * from IncredientOfFood;

-- Sửa nguyên liệu cho 1 món ăn

create proc [dbo].[USP_UpdateQuantityIncreOfFood]
 @idFood int ,@idCre char(10), @QuantityIncre float
as
Begin 
	update [dbo].[IncredientOfFood] 
	set 
		
		QuantityIncre = @QuantityIncre
	    
	where idFood = @idFood and idCre = @idCre
end
go

exec USP_UpdateQuantityIncreOfFood 1,'7',0.3;

---- Xóa 1 nguyên liệu cho món ăn
create proc USP_RemoveIncreofFood
@idFood int, @idCre char(10)
as
begin
	Delete from IncredientOfFood where idFood = @idFood and idCre = @idCre

end
go

exec USP_RemoveIncreofFood 1,'7';





delete from Employee where idEmployee = 'N05';
SELECT * FROM dbo.BillInfo
GO 
select * from Employee;
select * from Account;
select * from Bill;
select * from BillInfo;


