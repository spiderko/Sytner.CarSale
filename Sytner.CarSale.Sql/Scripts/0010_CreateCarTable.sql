IF OBJECT_ID(N'dbo.Car', N'U') IS NULL
	BEGIN
		PRINT 'Creating Car table'
		CREATE TABLE [dbo].[Car]
		(
		 [Id]        int IDENTITY (1, 1) NOT NULL ,
		 [Make] nvarchar(50) NOT NULL ,
		 [Model]  nvarchar(50) NOT NULL ,
		 [Registration] nvarchar(10) NOT NULL,
		 [YearOfManufacture] int NOT NULL,
		 [Price] int NOT NULL,
		 [Created]   datetime2(7) NOT NULL CONSTRAINT [DF_Car_Created] DEFAULT GetDate() ,
		 [Modified]  datetime2(7) NOT NULL CONSTRAINT [DF_Car_Modified] DEFAULT GetDate() ,
		 [Deleted]   bit NOT NULL CONSTRAINT [DF_Car_Deleted] DEFAULT 0 ,


		 CONSTRAINT [PK_car] PRIMARY KEY CLUSTERED ([Id] ASC)
		);
	END
ELSE
	BEGIN
		PRINT 'Car table exists, skipping'
	END
GO