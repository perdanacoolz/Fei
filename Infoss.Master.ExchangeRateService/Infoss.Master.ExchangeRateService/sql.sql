/*
 Navicat Premium Data Transfer

 Source Server         : local
 Source Server Type    : SQL Server
 Source Server Version : 15002000
 Source Host           : DESKTOP-2LQS1V5\SQLEXPRESS:1433
 Source Catalog        : Infoss.Finance
 Source Schema         : master

 Target Server Type    : SQL Server
 Target Server Version : 15002000
 File Encoding         : 65001

 Date: 12/08/2022 13:00:58
*/


-- ----------------------------
-- Table structure for ExchangeRate
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[master].[ExchangeRate]') AND type IN ('U'))
	DROP TABLE [master].[ExchangeRate]
GO

CREATE TABLE [master].[ExchangeRate] (
  [RowStatus] char(3) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Id] int  IDENTITY(1,1) NOT NULL,
  [Code] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [ExRateDate] datetime2(7)  NOT NULL,
  [ExRate1] decimal(18)  NOT NULL,
  [ExRate2] decimal(18)  NOT NULL,
  [ExRate3] decimal(18)  NOT NULL,
  [Deleted] bit  NOT NULL,
  [CompanyId] int  NOT NULL,
  [IdLama] int  NULL,
  [Remarks] varchar(500) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [DeletedBy] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [DeletedOn] datetime2(7)  NULL,
  [ModifiedBy] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [ModifiedOn] datetime2(7) DEFAULT getdate() NULL,
  [CreatedBy] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [CreatedOn] datetime2(7) DEFAULT getdate() NULL
)
GO

ALTER TABLE [master].[ExchangeRate] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of ExchangeRate
-- ----------------------------
SET IDENTITY_INSERT [master].[ExchangeRate] ON
GO

INSERT INTO [master].[ExchangeRate] ([RowStatus], [Id], [Code], [ExRateDate], [ExRate1], [ExRate2], [ExRate3], [Deleted], [CompanyId], [IdLama], [Remarks], [DeletedBy], [DeletedOn], [ModifiedBy], [ModifiedOn], [CreatedBy], [CreatedOn]) VALUES (N'ACT', N'1', NULL, N'2001-08-01 00:00:00.0000000', N'8975', N'0', N'0', N'0', N'4', NULL, NULL, NULL, NULL, N'test', N'2022-07-14 10:10:42.1833333', N'system', N'2022-07-14 10:10:42.1833333')
GO

INSERT INTO [master].[ExchangeRate] ([RowStatus], [Id], [Code], [ExRateDate], [ExRate1], [ExRate2], [ExRate3], [Deleted], [CompanyId], [IdLama], [Remarks], [DeletedBy], [DeletedOn], [ModifiedBy], [ModifiedOn], [CreatedBy], [CreatedOn]) VALUES (N'ACT', N'26', N'', N'2001-08-01 00:00:00.0000000', N'8975', N'0', N'0', N'0', N'4', N'0', N'', N'', N'2001-08-01 00:00:00.0000000', N'', N'2022-08-12 11:06:18.0466667', N'', N'2022-08-12 11:06:18.0466667')
GO

INSERT INTO [master].[ExchangeRate] ([RowStatus], [Id], [Code], [ExRateDate], [ExRate1], [ExRate2], [ExRate3], [Deleted], [CompanyId], [IdLama], [Remarks], [DeletedBy], [DeletedOn], [ModifiedBy], [ModifiedOn], [CreatedBy], [CreatedOn]) VALUES (N'ACT', N'27', N'', N'2001-08-01 00:00:00.0000000', N'8975', N'45343', N'0', N'0', N'4', N'0', N'', N'', N'2001-08-01 00:00:00.0000000', N'', N'2022-08-12 11:08:55.4100000', NULL, N'2022-08-12 11:08:55.4100000')
GO

INSERT INTO [master].[ExchangeRate] ([RowStatus], [Id], [Code], [ExRateDate], [ExRate1], [ExRate2], [ExRate3], [Deleted], [CompanyId], [IdLama], [Remarks], [DeletedBy], [DeletedOn], [ModifiedBy], [ModifiedOn], [CreatedBy], [CreatedOn]) VALUES (N'ACT', N'28', N'', N'2001-08-01 00:00:00.0000000', N'8975', N'0', N'0', N'0', N'4', N'0', N'', N'', N'2001-08-01 00:00:00.0000000', N'', N'2022-08-12 12:53:14.8500000', NULL, N'2022-08-12 12:53:14.8500000')
GO

INSERT INTO [master].[ExchangeRate] ([RowStatus], [Id], [Code], [ExRateDate], [ExRate1], [ExRate2], [ExRate3], [Deleted], [CompanyId], [IdLama], [Remarks], [DeletedBy], [DeletedOn], [ModifiedBy], [ModifiedOn], [CreatedBy], [CreatedOn]) VALUES (N'ACT', N'29', N'', N'2002-02-05 00:00:00.0000000', N'3442', N'432432', N'432432', N'0', N'0', N'0', N'', N'', N'2001-08-01 00:00:00.0000000', N'', N'2022-08-12 12:54:11.6333333', NULL, N'2022-08-12 12:54:11.6333333')
GO

SET IDENTITY_INSERT [master].[ExchangeRate] OFF
GO


-- ----------------------------
-- Table structure for Product
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[master].[Product]') AND type IN ('U'))
	DROP TABLE [master].[Product]
GO

CREATE TABLE [master].[Product] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [nama_barang ] varchar(200) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [kode_barang ] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [jumlah_barang ] int  NOT NULL,
  [tanggal ] datetime  NOT NULL,
  [RowStatus] char(3) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [master].[Product] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Product
-- ----------------------------
SET IDENTITY_INSERT [master].[Product] ON
GO

INSERT INTO [master].[Product] ([Id], [nama_barang ], [kode_barang ], [jumlah_barang ], [tanggal ], [RowStatus]) VALUES (N'20', N'string', N'string', N'0', N'2022-08-12 01:52:40.817', NULL)
GO

INSERT INTO [master].[Product] ([Id], [nama_barang ], [kode_barang ], [jumlah_barang ], [tanggal ], [RowStatus]) VALUES (N'21', N'lemari', N'001', N'10', N'2022-08-12 01:52:40.817', N'ACT')
GO

INSERT INTO [master].[Product] ([Id], [nama_barang ], [kode_barang ], [jumlah_barang ], [tanggal ], [RowStatus]) VALUES (N'22', N'lemari22', N'001', N'200', N'2022-08-12 01:52:40.817', N'ACT')
GO

INSERT INTO [master].[Product] ([Id], [nama_barang ], [kode_barang ], [jumlah_barang ], [tanggal ], [RowStatus]) VALUES (N'23', N'test', N'001', N'10', N'2022-08-12 01:52:40.817', N'ACT')
GO

INSERT INTO [master].[Product] ([Id], [nama_barang ], [kode_barang ], [jumlah_barang ], [tanggal ], [RowStatus]) VALUES (N'24', N'string', N'string', N'0', N'2022-08-12 03:56:30.310', N'str')
GO

INSERT INTO [master].[Product] ([Id], [nama_barang ], [kode_barang ], [jumlah_barang ], [tanggal ], [RowStatus]) VALUES (N'28', N'fdsfdsf', N'55', N'44', N'2022-08-12 01:52:40.817', N'ACT')
GO

SET IDENTITY_INSERT [master].[Product] OFF
GO


-- ----------------------------
-- procedure structure for SP_ExchangeRate_Create
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[master].[SP_ExchangeRate_Create]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[master].[SP_ExchangeRate_Create]
GO

CREATE PROCEDURE [master].[SP_ExchangeRate_Create]
	@RowStatus CHAR(3) = 'ACT',
	@Code VARCHAR(50) = '',
	@ExRateDate DATETIME,
	@ExRate1 DECIMAL(18, 2) = 0,
	@ExRate2 DECIMAL(18, 2) = 0,
	@ExRate3 DECIMAL(18, 2) = 0,
	@Deleted BIT, 
	@CompanyId INT = 0,
	@DeletedOn DATETIME,
	@DeletedBy VARCHAR(50) = '',
	@IdLama INT = 0, 
	@Remarks VARCHAR(500) = '',
	@ModifiedBy VARCHAR(50) = ''
	--@CreatedBy VARCHAR(50) = ''

AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO master.ExchangeRate(
		RowStatus,
		Code,
		ExRateDate,
		ExRate1,
		ExRate2,
		ExRate3,
		Deleted,
		CompanyId,
		DeletedOn,
		DeletedBy,
		IdLama,
		Remarks,
		ModifiedBy)
		--CreatedBy)
	VALUES(
		@RowStatus,
		@Code,
		@ExRateDate,
		@ExRate1,
		@ExRate2,
		@ExRate3,
		@Deleted,
		@CompanyId,
		@DeletedOn,
		@DeletedBy,
		@IdLama,
		@Remarks,
		@ModifiedBy)
		--@CreatedBy)

END
GO


-- ----------------------------
-- procedure structure for SP_ExchangeRate_Delete
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[master].[SP_ExchangeRate_Delete]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[master].[SP_ExchangeRate_Delete]
GO

CREATE PROCEDURE [master].[SP_ExchangeRate_Delete]
    @Id INT = 0,
    @ModifiedBy VARCHAR(50) = ''

AS
BEGIN
	SET NOCOUNT ON;

	UPDATE b
	SET b.RowStatus = 'DEL', b.ModifiedBy = @ModifiedBy
	FROM master.ExchangeRate b WITH(INDEX(PK_ExchangeRate_Id) READPAST) 
	WHERE b.Id = @Id

END
GO


-- ----------------------------
-- procedure structure for SP_ExchangeRate_Read
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[master].[SP_ExchangeRate_Read]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[master].[SP_ExchangeRate_Read]
GO

CREATE PROCEDURE [master].[SP_ExchangeRate_Read]
    @Id			INT = 0,	
	@PageNo		INT = 1,
	@PageSize   INT = 20
AS
BEGIN
	SET NOCOUNT ON;

	IF (@Id != 0)
		BEGIN
			SELECT 
				RowStatus,
				Id,
				Code,
				ExRateDate,
				ExRate1,
				ExRate2,
				ExRate3,
				Deleted,
				CompanyId,
				DeletedOn,
				DeletedBy,
				IdLama,
				Remarks,
				ModifiedBy,
				ModifiedOn,
				CreatedBy,
				createdOn

			FROM master.ExchangeRate WITH(INDEX(PK_ExchangeRate_Id) READPAST) 
			WHERE Id = @Id
		END
	ELSE
	BEGIN
		WITH pg AS
		(
			SELECT Id, TotalRowCount = COUNT(Id) OVER()
			FROM master.ExchangeRate
			ORDER BY Id
			OFFSET @PageSize * (@PageNo - 1) ROWS
			FETCH NEXT @PageSize ROWS ONLY
		)
		SELECT 
			al.RowStatus,
			al.Id,
			al.Code,
			al.ExRateDate,
			al.ExRate1,
			al.ExRate2,
			al.ExRate3,
			al.Deleted,
			al.CompanyId,
			al.DeletedOn,
			al.DeletedBy,
			al.IdLama,
			al.Remarks,
			al.ModifiedBy,
			al.ModifiedOn,
			al.CreatedBy,
			al.createdOn

		FROM master.ExchangeRate al WITH(INDEX(PK_ExchangeRate_Id) READPAST) 
			 INNER JOIN pg ON pg.Id = al.Id
		ORDER BY al.Id OPTION (RECOMPILE)
	END
END
GO


-- ----------------------------
-- procedure structure for SP_ExchangeRate_Update
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[master].[SP_ExchangeRate_Update]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[master].[SP_ExchangeRate_Update]
GO

CREATE PROCEDURE [master].[SP_ExchangeRate_Update]
	@RowStatus CHAR(3) = 'ACT',
	@Id INT = 0,
	@Code VARCHAR(50) = '',
	@ExRateDate DATETIME,
	@ExRate1 DECIMAL(18, 2) = 0,
	@ExRate2 DECIMAL(18, 2) = 0,
	@ExRate3 DECIMAL(18, 2) = 0,
	@Deleted BIT, 
	@CompanyId INT = 0,
	@DeletedOn DATETIME,
	@DeletedBy VARCHAR(50) = '',
	@IdLama INT = 0, 
	@Remarks VARCHAR(500) = '',
	@ModifiedBy VARCHAR(50) = '',
	@CreatedBy VARCHAR(50) = ''
	
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE b
	SET 
		b.RowStatus = @RowStatus,
		b.ExRateDate = @ExRateDate,
		b.ExRate1 = @ExRate1,
		b.ExRate2 = @ExRate2,
		b.ExRate3 = @ExRate3,
		b.Deleted = @Deleted,
		b.CompanyId = @CompanyId,
		b.DeletedOn = @DeletedOn,
		b.DeletedBy = @DeletedBy,
		b.IdLama = @IdLama,
		b.Remarks = @Remarks,
		b.ModifiedBy = @ModifiedBy,
		b.CreatedBy = @CreatedBy

	FROM master.ExchangeRate b WITH(INDEX(PK_ExchangeRate_Id) READPAST) 
	WHERE b.Id = @Id
END
GO


-- ----------------------------
-- procedure structure for SP_Product_Create
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[master].[SP_Product_Create]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[master].[SP_Product_Create]
GO

CREATE PROCEDURE [master].[SP_Product_Create]
	@nama_barang VARCHAR(200) = '',
	@kode_barang VARCHAR(50) = '',
	@jumlah_barang INT = 10,
	@tanggal DATETIME,
	@RowStatus CHAR(3) = 'ACT'
	 

AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO master.Product(
		nama_barang,
		kode_barang,
		jumlah_barang,
		RowStatus,
		tanggal)
		
	VALUES(
		@nama_barang,
		@kode_barang,
		@jumlah_barang,
		@RowStatus,
		@tanggal)
		END
GO


-- ----------------------------
-- procedure structure for SP_Product_Delete
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[master].[SP_Product_Delete]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[master].[SP_Product_Delete]
GO

CREATE PROCEDURE [master].[SP_Product_Delete]
    @Id INT = 0
     
AS
BEGIN
	SET NOCOUNT ON;
	
	DELETE FROM product WHERE Id=@Id;

END
GO


-- ----------------------------
-- procedure structure for SP_Product_Read
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[master].[SP_Product_Read]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[master].[SP_Product_Read]
GO

CREATE PROCEDURE [master].[SP_Product_Read]
    @Id			INT = 0,	
	@PageNo		INT = 1,
	@PageSize   INT = 20
AS
BEGIN
	SET NOCOUNT ON;

	IF (@Id != 0)
		BEGIN
			SELECT 
 				Id,
				nama_barang ,
				kode_barang ,
				jumlah_barang ,
				tanggal,
				RowStatus
				FROM master.Product  
			WHERE Id = @Id
		END
	ELSE
	BEGIN
		WITH pg AS
		(
			SELECT Id, TotalRowCount = COUNT(Id) OVER()
			FROM master.Product
			ORDER BY Id
			OFFSET @PageSize * (@PageNo - 1) ROWS
			FETCH NEXT @PageSize ROWS ONLY
		)
		SELECT 
			al.Id,
			al.nama_barang,
			al.kode_barang,
			al.jumlah_barang,
			al.tanggal,
			al.RowStatus

		FROM master.Product al
			 INNER JOIN pg ON pg.Id = al.Id
		ORDER BY al.Id OPTION (RECOMPILE)
	END
END
GO


-- ----------------------------
-- procedure structure for SP_Product_Update
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[master].[SP_Product_Update]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[master].[SP_Product_Update]
GO

CREATE PROCEDURE [master].[SP_Product_Update]
	@Id INT = 0,
	@nama_barang VARCHAR(200) = '',
	@kode_barang VARCHAR(50) = '',
	@jumlah_barang INT = 10,
	@tanggal DATETIME
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE b
	SET 
		b.nama_barang=@nama_barang,
		b.kode_barang=@kode_barang,
		b.jumlah_barang=@jumlah_barang,
		b.tanggal=@tanggal

	FROM master.Product b  
	WHERE b.Id = @Id
END
GO


-- ----------------------------
-- Auto increment value for ExchangeRate
-- ----------------------------
DBCC CHECKIDENT ('[master].[ExchangeRate]', RESEED, 29)
GO


-- ----------------------------
-- Primary Key structure for table ExchangeRate
-- ----------------------------
ALTER TABLE [master].[ExchangeRate] ADD CONSTRAINT [PK_ExchangeRate_Id] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Product
-- ----------------------------
DBCC CHECKIDENT ('[master].[Product]', RESEED, 28)
GO


-- ----------------------------
-- Primary Key structure for table Product
-- ----------------------------
ALTER TABLE [master].[Product] ADD CONSTRAINT [PK_ExchangeRate_Id_copy1] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

