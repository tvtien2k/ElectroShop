USE [ElectroShop]
GO
/****** Object:  Table [dbo].[tblBill]    Script Date: 7/30/2019 8:31:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBill](
	[Bill_id] [varchar](10) NOT NULL,
	[Invoice_date] [date] NOT NULL,
	[Staff_id] [varchar](10) NOT NULL,
	[Customer] [varchar](100) NOT NULL,
	[phone_customer] [varchar](15) NULL,
	[email] [varchar](50) NULL,
	[_add] [varchar](300) NULL,
	[total_cost] [float] NULL,
	[cmt] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Bill_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCategory]    Script Date: 7/30/2019 8:31:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCategory](
	[Category_id] [varchar](10) NOT NULL,
	[Category_name] [varchar](50) NULL,
	[cmt] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Category_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDetailedBill]    Script Date: 7/30/2019 8:31:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDetailedBill](
	[Bill_id] [varchar](10) NOT NULL,
	[Product_id] [varchar](10) NOT NULL,
	[number] [int] NULL,
	[price_current] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[Bill_id] ASC,
	[Product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblProduct]    Script Date: 7/30/2019 8:31:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProduct](
	[Product_id] [varchar](10) NOT NULL,
	[Product_name] [varchar](50) NOT NULL,
	[Supplier_id] [varchar](10) NOT NULL,
	[Category_id] [varchar](10) NOT NULL,
	[price_in] [float] NULL,
	[price_out] [float] NULL,
	[img] [varchar](500) NULL,
	[cmt] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblStaff]    Script Date: 7/30/2019 8:31:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblStaff](
	[Staff_user] [varchar](10) NOT NULL,
	[Staff_pass] [varchar](20) NOT NULL,
	[Staff_name] [varchar](100) NULL,
	[_power] [varchar](50) NOT NULL,
	[sex] [varchar](10) NULL,
	[Staff_address] [varchar](100) NULL,
	[phone_number] [varchar](15) NULL,
	[birthday] [date] NULL,
	[cmt] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Staff_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSupplier]    Script Date: 7/30/2019 8:31:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSupplier](
	[Supplier_id] [varchar](10) NOT NULL,
	[Supplier_name] [varchar](50) NOT NULL,
	[cmt] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Supplier_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblBill] ([Bill_id], [Invoice_date], [Staff_id], [Customer], [phone_customer], [email], [_add], [total_cost], [cmt]) VALUES (N'BI01', CAST(N'2019-06-09' AS Date), N'ST01', N'Tran Van Tien', N'03483475', N'tvt@gmail.com', N'Tuyen Quang', 1800, NULL)
INSERT [dbo].[tblBill] ([Bill_id], [Invoice_date], [Staff_id], [Customer], [phone_customer], [email], [_add], [total_cost], [cmt]) VALUES (N'BI02', CAST(N'2019-06-09' AS Date), N'ST02', N'Le Van Luyen', N'038475585', N'lvl@gmail.com', N'O dau con lau moi noi', 2600, NULL)
INSERT [dbo].[tblBill] ([Bill_id], [Invoice_date], [Staff_id], [Customer], [phone_customer], [email], [_add], [total_cost], [cmt]) VALUES (N'BI03', CAST(N'2019-06-10' AS Date), N'admin', N'Hoang Tuan Anh', N'093744753', N'hta@gmail.com', N'Ha Noi', 2800, N'Paid')
INSERT [dbo].[tblCategory] ([Category_id], [Category_name], [cmt]) VALUES (N'CT01', N'TV', NULL)
INSERT [dbo].[tblCategory] ([Category_id], [Category_name], [cmt]) VALUES (N'CT02', N'Laptop', NULL)
INSERT [dbo].[tblCategory] ([Category_id], [Category_name], [cmt]) VALUES (N'CT04', N'Headphone', NULL)
INSERT [dbo].[tblCategory] ([Category_id], [Category_name], [cmt]) VALUES (N'CT05', N'speaker', NULL)
INSERT [dbo].[tblCategory] ([Category_id], [Category_name], [cmt]) VALUES (N'CT06', N'Smartphone', NULL)
INSERT [dbo].[tblDetailedBill] ([Bill_id], [Product_id], [number], [price_current]) VALUES (N'BI01', N'PR01', 1, 1000)
INSERT [dbo].[tblDetailedBill] ([Bill_id], [Product_id], [number], [price_current]) VALUES (N'BI01', N'PR04', 1, 800)
INSERT [dbo].[tblDetailedBill] ([Bill_id], [Product_id], [number], [price_current]) VALUES (N'BI02', N'PR01', 1, 1000)
INSERT [dbo].[tblDetailedBill] ([Bill_id], [Product_id], [number], [price_current]) VALUES (N'BI02', N'PR06', 2, 800)
INSERT [dbo].[tblDetailedBill] ([Bill_id], [Product_id], [number], [price_current]) VALUES (N'BI03', N'PR01', 2, 1000)
INSERT [dbo].[tblDetailedBill] ([Bill_id], [Product_id], [number], [price_current]) VALUES (N'BI03', N'PR06', 1, 800)
INSERT [dbo].[tblProduct] ([Product_id], [Product_name], [Supplier_id], [Category_id], [price_in], [price_out], [img], [cmt]) VALUES (N'PR01', N'Samsung Galaxy S10', N'SL01', N'CT06', 800, 1000, NULL, N'abc')
INSERT [dbo].[tblProduct] ([Product_id], [Product_name], [Supplier_id], [Category_id], [price_in], [price_out], [img], [cmt]) VALUES (N'PR02', N'Asus X555LPB', N'SL02', N'CT02', 400, 600, NULL, NULL)
INSERT [dbo].[tblProduct] ([Product_id], [Product_name], [Supplier_id], [Category_id], [price_in], [price_out], [img], [cmt]) VALUES (N'PR03', N'Level U Headphone', N'SL01', N'CT04', 40, 50, NULL, NULL)
INSERT [dbo].[tblProduct] ([Product_id], [Product_name], [Supplier_id], [Category_id], [price_in], [price_out], [img], [cmt]) VALUES (N'PR04', N'SONY KD-43X8500F TIVI', N'SL01', N'CT06', 700, 800, NULL, NULL)
INSERT [dbo].[tblProduct] ([Product_id], [Product_name], [Supplier_id], [Category_id], [price_in], [price_out], [img], [cmt]) VALUES (N'PR05', N'XB12 speaker', N'SL03', N'CT05', 80, 100, NULL, NULL)
INSERT [dbo].[tblProduct] ([Product_id], [Product_name], [Supplier_id], [Category_id], [price_in], [price_out], [img], [cmt]) VALUES (N'PR06', N'Sony Xperia XZ1', N'SL03', N'CT06', 700, 800, NULL, NULL)
INSERT [dbo].[tblProduct] ([Product_id], [Product_name], [Supplier_id], [Category_id], [price_in], [price_out], [img], [cmt]) VALUES (N'PR07', N'Samsung Galaxy Y', N'SL01', N'CT01', 200, 300, N'dien-thoai-samsung-galaxy-y_clip_image002.jpg', N'Genuine')
INSERT [dbo].[tblProduct] ([Product_id], [Product_name], [Supplier_id], [Category_id], [price_in], [price_out], [img], [cmt]) VALUES (N'PR08', N'Samsung Galaxy S10', N'SL01', N'CT06', 800, 1000, NULL, NULL)
INSERT [dbo].[tblProduct] ([Product_id], [Product_name], [Supplier_id], [Category_id], [price_in], [price_out], [img], [cmt]) VALUES (N'PR09', N'Samsung Galaxy S10', N'SL01', N'CT06', 800, 1000, NULL, NULL)
INSERT [dbo].[tblProduct] ([Product_id], [Product_name], [Supplier_id], [Category_id], [price_in], [price_out], [img], [cmt]) VALUES (N'PR10', N'Samsung Galaxy S10', N'SL01', N'CT06', 800, 1000, NULL, NULL)
INSERT [dbo].[tblStaff] ([Staff_user], [Staff_pass], [Staff_name], [_power], [sex], [Staff_address], [phone_number], [birthday], [cmt]) VALUES (N'admin', N'admin', NULL, N'admin', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tblStaff] ([Staff_user], [Staff_pass], [Staff_name], [_power], [sex], [Staff_address], [phone_number], [birthday], [cmt]) VALUES (N'CT03', N'123456', N'Lam Thanh Hieu', N'Sales staf', N'Male', N'Vinh Phuc', N'095486575', CAST(N'2000-12-26' AS Date), N'')
INSERT [dbo].[tblStaff] ([Staff_user], [Staff_pass], [Staff_name], [_power], [sex], [Staff_address], [phone_number], [birthday], [cmt]) VALUES (N'ST01', N'123456', N'Nguyen Thi A', N'Sales staff', N'female', N'Ha Noi', N'0943975670', CAST(N'1995-02-15' AS Date), NULL)
INSERT [dbo].[tblStaff] ([Staff_user], [Staff_pass], [Staff_name], [_power], [sex], [Staff_address], [phone_number], [birthday], [cmt]) VALUES (N'ST02', N'123456', N'Dao Van C', N'Warehouse staff', N'male', N'Ha Noi', N'0943975670', CAST(N'1998-02-03' AS Date), NULL)
INSERT [dbo].[tblSupplier] ([Supplier_id], [Supplier_name], [cmt]) VALUES (N'SL01', N'Apple', NULL)
INSERT [dbo].[tblSupplier] ([Supplier_id], [Supplier_name], [cmt]) VALUES (N'SL02', N'abc', N'')
INSERT [dbo].[tblSupplier] ([Supplier_id], [Supplier_name], [cmt]) VALUES (N'SL03', N'Sony', NULL)
INSERT [dbo].[tblSupplier] ([Supplier_id], [Supplier_name], [cmt]) VALUES (N'SL04', N'Apple', N'')
ALTER TABLE [dbo].[tblBill] ADD  DEFAULT (getdate()) FOR [Invoice_date]
GO
ALTER TABLE [dbo].[tblBill]  WITH CHECK ADD FOREIGN KEY([Staff_id])
REFERENCES [dbo].[tblStaff] ([Staff_user])
GO
ALTER TABLE [dbo].[tblDetailedBill]  WITH CHECK ADD FOREIGN KEY([Bill_id])
REFERENCES [dbo].[tblBill] ([Bill_id])
GO
ALTER TABLE [dbo].[tblDetailedBill]  WITH CHECK ADD FOREIGN KEY([Product_id])
REFERENCES [dbo].[tblProduct] ([Product_id])
GO
ALTER TABLE [dbo].[tblProduct]  WITH CHECK ADD FOREIGN KEY([Category_id])
REFERENCES [dbo].[tblCategory] ([Category_id])
GO
ALTER TABLE [dbo].[tblProduct]  WITH CHECK ADD FOREIGN KEY([Supplier_id])
REFERENCES [dbo].[tblSupplier] ([Supplier_id])
GO
/****** Object:  StoredProcedure [dbo].[AddCategory]    Script Date: 7/30/2019 8:31:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[AddCategory] @id as varchar(10), @name as varchar(50), @cmt as varchar(200)
as
	begin
		insert into tblCategory values (@id,@name,@cmt)
		select * from tblCategory
	end
GO
/****** Object:  StoredProcedure [dbo].[AddStaff]    Script Date: 7/30/2019 8:31:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[AddStaff] @user as varchar(10), @pass as varchar(20), @name as varchar(100), @power as varchar(10), @sex as varchar(10), @add as varchar(100), @phone as varchar(15), @birthday as date, @cmt as varchar(200)
as
	begin
		insert into tblStaff values (@user,@pass,@name,@power,@sex,@add,@phone,@birthday,@cmt)
		select Staff_user, Staff_name, sex, Staff_address, phone_number, birthday, cmt from tblStaff  where Staff_user = @user
	end
GO
/****** Object:  StoredProcedure [dbo].[AddSupplier]    Script Date: 7/30/2019 8:31:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[AddSupplier] @id as varchar(10), @name as varchar(50), @cmt as varchar(200)
as
	begin
		insert into tblSupplier values (@id,@name,@cmt)
		select * from tblSupplier
	end
GO
/****** Object:  StoredProcedure [dbo].[EditCategory]    Script Date: 7/30/2019 8:31:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[EditCategory] @id as varchar(10), @name as varchar(50), @cmt as varchar(200)
as
	begin
		update tblCategory SET Category_name=@name, cmt=@cmt where Category_id=@id
		select * from tblCategory
	end
GO
/****** Object:  StoredProcedure [dbo].[EditProduct]    Script Date: 7/30/2019 8:31:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[EditProduct] @id as varchar(10), @p_in as float, @p_out as float, @cmt as varchar(200)
as
	begin
		UPDATE tblProduct SET price_in = @p_in, price_out = @p_out, cmt = @cmt WHERE Product_id=@id;
		select Product_id, Product_name, price_in, price_out, cmt from tblProduct;
	end
GO
/****** Object:  StoredProcedure [dbo].[EditSupplier]    Script Date: 7/30/2019 8:31:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[EditSupplier] @id as varchar(10), @name as varchar(50), @cmt as varchar(200)
as
	begin
		update tblSupplier SET Supplier_name=@name, cmt=@cmt where Supplier_id=@id
		select * from tblSupplier
	end
GO
