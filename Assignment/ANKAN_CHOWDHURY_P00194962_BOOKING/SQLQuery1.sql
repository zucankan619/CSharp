CREATE TABLE tblUser
(
	[UserId] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[UserName] VARCHAR(50) NULL,
	[Password] VARCHAR(50) NULL,
	[UserType] VARCHAR(50) NULL
)
Go

INSERT INTO  tblUser VALUES('admin','admin','admin')
GO

CREATE TABLE tblDepartment
(
	[DepartId] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Department_Name] VARCHAR(50) NULL
)
Go

INSERT INTO  tblDepartment VALUES('IT')
INSERT INTO  tblDepartment VALUES('Accounts')
Go



CREATE TABLE tblStaff_Account
(
	[StaffId] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Staff_Name] VARCHAR(50) NULL,
	[MobileNo] VARCHAR(50) NULL,
	[DepartId] INT NULL,
	CONSTRAINT [FK_departmentStaff] FOREIGN KEY ([DepartId]) REFERENCES [tblDepartment]([DepartId])
	ON DELETE CASCADE
)
Go

CREATE TABLE tblJob
(
	[Job_Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Title] VARCHAR(50) NULL,
	[Salary] VARCHAR(50) NULL,
	[DepartId] INT NULL,
	CONSTRAINT [FK_department] FOREIGN KEY ([DepartId]) REFERENCES [tblDepartment]([DepartId])
	ON DELETE CASCADE
)
GO
CREATE TABLE tblCustomer_Account
(
	[CustId] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Cust_Name] VARCHAR(50) NULL,
	[Cust_Address] VARCHAR(50) NULL,	
	[Gender] VARCHAR(50) NULL,
	[DOB] Date NULL,
	[MobileNo] VARCHAR(50) NULL,
	[CustEmail] VARCHAR(50) NULL,
	[StaffId] INT NULL,
	CONSTRAINT [FK_CustStaff] FOREIGN KEY ([StaffId]) REFERENCES [tblStaff_Account]([StaffId])
	ON DELETE CASCADE
)
Go

CREATE TABLE tblCust_User_Account
(
	[UserId] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[User_Name] VARCHAR(50) NULL,
	[User_Pass] VARCHAR(50) NULL,	
	[Amount] MONEY NULL,
	[TransLimit] MONEY NULL,
	[CustId] INT NULL,
	CONSTRAINT [FK_CustUser] FOREIGN KEY ([CustId]) REFERENCES [tblCustomer_Account]([CustId])
	ON DELETE CASCADE
)
Go

CREATE TABLE tblPayment
(
	[PaymentId] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Payment_Type] VARCHAR(50) NULL,
	[Payment_Amount] MONEY NULL,	
	[Biller_Account] VARCHAR(50) NULL,
	[Biller_Name] VARCHAR(50) NULL
)
Go

CREATE TABLE tblTransaction
(
	[TransId] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Trans_Type] VARCHAR(50) NULL,
	[Trans_Amount] MONEY NULL,	
	[Trans_Date] DATE NULL,
	[Receiver_Amount] MONEY NULL,	
	[Receiver_Name] VARCHAR(50) NULL
)
Go

CREATE TABLE tblLoan
(
	[LoanId] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Loan_Type] VARCHAR(50) NULL,
	[Loan_Number] INT NULL	
)
Go