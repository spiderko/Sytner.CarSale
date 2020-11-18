SET IDENTITY_INSERT dbo.Car ON;  
GO 

IF NOT EXISTS (SELECT 1 FROM dbo.Car WHERE Id=1)
BEGIN
	INSERT INTO dbo.Car (Id, Make, Model, Registration, YearOfManufacture, Price)
	VALUES (1, 'Ford', 'Fiesta', 'THE1', 2020, 18000)
END

IF NOT EXISTS (SELECT 1 FROM dbo.Car WHERE Id=2)
BEGIN
	INSERT INTO dbo.Car (Id, Make, Model, Registration, YearOfManufacture, Price)
	VALUES (2, 'Fiat', '500', 'THE2', 2019, 12000)
END

IF NOT EXISTS (SELECT 1 FROM dbo.Car WHERE Id=3)
BEGIN
	INSERT INTO dbo.Car (Id, Make, Model, Registration, YearOfManufacture, Price)
	VALUES (3, 'BMW', 'i8', 'THE3', 2018, 65000)
END	

SET IDENTITY_INSERT dbo.Car OFF;  
GO 
	
/*
    new Car{ Id = 1, Make = "Ford", Model = "Fiesta", Registration = "THE1", YearOfManufacture = 2020, Price=18000 },
	new Car{ Id = 2, Make = "Fiat", Model = "500", Registration = "THE2", YearOfManufacture = 2019, Price=12000 },
	new Car{ Id = 3, Make = "BMW", Model = "i8", Registration = "THE3", YearOfManufacture = 2018, Price=65000 },
          
*/