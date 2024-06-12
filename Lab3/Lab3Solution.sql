SELECT *
FROM [Northwind].[dbo].[Orders]
WHERE ShippedDate > RequiredDate;

SELECT Distinct country  
FROM [Northwind].[dbo].[Employees];

SELECT [EmployeeID],[LastName],[FirstName]
FROM [Northwind].[dbo].[Employees]
WHERE ReportsTo is NULL;

SELECT [ProductName]
FROM [Northwind].[dbo].[Products]
WHERE Discontinued =1;

SELECT OrderID
FROM [Northwind].[dbo].[Order Details]
WHERE discount=0;

SELECT CustomerID
FROM [Northwind].[dbo].[Customers]
WHERE Region IS NULL;

SELECT [CustomerID],[ContactName],Phone, Country
FROM [Northwind].[dbo].[Customers]
WHERE country IN('UK','USA');

SELECT [CompanyName], HomePage
FROM [Northwind].[dbo].[Suppliers]
Where HomePage is not NULL;

SELECT Distinct [ShipCountry]
FROM [Northwind].[dbo].[Orders]
WHERE YEAR(ShippedDate)=1997;

SELECT CustomerID
FROM [Northwind].[dbo].[Orders]
WHERE ShippedDate is NULL;

SELECT SupplierID, CompanyName, City
FROM [Northwind].[dbo].[Suppliers];

SELECT *
FROM [Northwind].[dbo].[Employees]
WHERE City = 'London';

SELECT *
FROM [Northwind].[dbo].Products
WHERE Discontinued=0;

SELECT *
FROM [Northwind].[dbo].[Order Details]
WHERE Discount <= 0.1;

SELECT EmployeeID, FirstName+' '+LastName AS [Name], HomePhone + '
ext. '+Extension AS Contact
FROM [Northwind].[dbo].[Employees]
WHERE Region is NULL;
