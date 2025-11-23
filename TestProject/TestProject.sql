Create table Products 
(ProductID  INT PRIMARY KEY IDENTITY (1,1), 
Name NVARCHAR(200), 
Category NVARCHAR(200), 
Quantity Int, 
Price DECIMAL(18,2), 
LastUpdated DATETIME)
ALTER TABLE Products
ADD CONSTRAINT df_LastUpdated
DEFAULT CURRENT_TIMESTAMP FOR LastUpdated;

go
CREATE TRIGGER LastUpdated
ON Products
AFTER INSERT, UPDATE
AS update Products set LastUpdated = CURRENT_TIMESTAMP where ProductID in (select ProductID from inserted)
