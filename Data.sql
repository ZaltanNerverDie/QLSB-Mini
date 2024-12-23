CREATE DATABASE QuanLySanBong
GO

USE QuanLySanBong
GO


-- Customer
-- Staff
-- Field
-- Time
-- Account
-- FieldRegister
-- Bill

CREATE TABLE Account
(
	id INT IDENTITY PRIMARY KEY,
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'admin',
	UserName NVARCHAR(100) NOT NULL , 
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,    
	Type INT NOT NULL DEFAULT 1 --2:admin, 1: staff, 0: customer 
)

CREATE TABLE Field
(
	id INT IDENTITY PRIMARY KEY,
	FieldName NVARCHAR(100) NOT NULL, 
	FieldType NVARCHAR(100) NOT NULL, 
	FieldStatus INT NOT NULL DEFAULT 1,-- 1: In process 0: Stop
	FieldPrice FLOAT NOT NULL 
)


CREATE TABLE Time
(
	id INT IDENTITY PRIMARY KEY,
	idField INT NULL,
	TimeName NVARCHAR (100) NOT NULL,
	TimeStatus NVARCHAR(100) DEFAULT N'Trong'-- Trống||Đã đặt|| Đã Thanh Toán 

	FOREIGN KEY (idField) REFERENCES dbo.Field(id),
)



CREATE TABLE FieldRegister
(
	id INT IDENTITY PRIMARY KEY,
	idAccount INT NOT NULL,
	idTime INT NOT NULL,
	dateCreate DATE NOT NULL DEFAULT GETDATE(),
	FieldRegisterStatus INT NOT NULL DEFAULT 0,

	FOREIGN KEY (idAccount) REFERENCES dbo.Account(id),
	FOREIGN KEY (idTime) REFERENCES dbo.Time(id)

)

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	idFieldRegister INT NOT NULL,
	idAccount INT  NULL,
	BillStatus INT NOT NULL DEFAULT 0, -- 1: paid 0: not paid
	BillDate DATE NOT NULL DEFAULT GETDATE(),

	FOREIGN KEY (idAccount) REFERENCES dbo.Account(id),
	FOREIGN KEY (idFieldRegister) REFERENCES dbo.FieldRegister(id)
)

INSERT INTO dbo.Account
(
	DisplayName,
	UserName,
	[PassWord],
	[Type]
)
VALUES
(
	N'staff' ,
	N'staff' ,
	N'1' ,
	0
)
GO

CREATE PROC USP_GetAccountByUserName
@userName nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName
END
GO

EXEC dbo.USP_GetAccountByUserName @userName = N'staff' -- nvarchar(100)
GO

CREATE PROC USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
END
GO

CREATE PROC USP_GetTableList
AS SELECT * FROM dbo.Time
GO
EXEC dbo.USP_GetTableList
INSERT dbo.Field
	(FieldName,FieldPrice,FieldStatus,FieldType)
VALUES (N'San1', 100000, 1, N'San7')
INSERT dbo.Field
	(FieldName,FieldPrice,FieldStatus,FieldType)
VALUES (N'San2', 200000, 1, N'San11')

SELECT *FROM dbo.Time

SElECT *FROM dbo.Account

SELECT *FROM dbo.Time WHERE idField = 6

SELECT * FROM Field




INSERT INTO dbo.FieldRegister
	(idAccount, idTime, dateCreate, FieldRegisterStatus)
VALUES(1, 22, GETDATE(), 1)

SELECT *FROM dbo.FieldRegister WHERE idTime = 22
SELECT *FROM dbo.FieldRegister
INSERT INTO dbo.Bill
	(idFieldRegister, BillStatus, BillDate)
VALUES(1, 1, GETDATE())

GO

SELECT fn.FieldName, ft.TimeName, fa.DisplayName, fd.dateCreate, fn.FieldPrice FROM dbo.FieldRegister AS fd, dbo.Account AS fa, dbo.Field AS fn, dbo.Time AS ft
WHERE fd.idAccount = fa.id AND fd.idTime = ft.id AND ft.idField = fn.id AND fd.idTime = 22

GO


CREATE PROC USP_InsertFieldResigter
@idAccount INT, @idTime INT
AS
BEGIN
	INSERT dbo.FieldRegister
		(idAccount, idTime, dateCreate, FieldRegisterStatus)
		VALUES(@idAccount, @idTime, GETDATE(), 0)
END
GO
 

CREATE PROC USP_InsertBill
@idFieldRegister INT
AS
BEGIN
	INSERT dbo.Bill
		(idFieldRegister, BillStatus, BillDate)
		VALUES(@idFieldRegister, 0, GETDATE())
END
GO

UPDATE dbo.Account SET Type = 1 WHERE id = 1
UPDATE dbo.Bill SET BillStatus = 1, idAccount = 1 WHERE idFieldRegister = 34
GO
CREATE PROC USP_GetListBillByDate
@checkIn DATE, @checkOut DATE
AS
BEGIN
	SELECT fn.FieldName AS [Tên Sân], ft.TimeName AS [Khung Giờ], fa.DisplayName AS [Người thanh toán], BillDate AS [Ngày thanh toán], fn.FieldPrice AS [Giá tiền]
	FROM dbo.Bill AS b, dbo.FieldRegister AS fd, dbo.Account AS fa, dbo.Field AS fn, dbo.Time AS ft
	WHERE b.idAccount = fa.id AND fd.idTime = ft.id AND ft.idField = fn.id AND b.idFieldRegister = fd.id AND BillDate >= @checkIn AND BillDate <= @checkOut AND b.BillStatus = 1	

END
GO



UPDATE dbo.FieldRegister SET FieldRegisterStatus = 1

INSERT dbo.Field
	(FieldName,FieldPrice,FieldStatus,FieldType)
VALUES (N'San2', 200000, 1, N'San11')

SELECT * FROM FieldRegister
SELECT * FROM Account
INSERT dbo.Time
	(idField, TimeName, TimeStatus)
VALUES (10, N'6h30 - 7h30', N'Trong')


DELETE FROM Bill WHERE idFieldRegister IN (SELECT id FROM FieldRegister WHERE idTime = 51);

-- Delete related records from FieldRegister table
DELETE FROM FieldRegister WHERE idTime = 51;

-- Delete related records from Time table
DELETE FROM Time WHERE id = 51;

-- Finally, delete records from Field table
DELETE FROM Field WHERE id = 6;	