--Q1
SELECT * FROM Orders WHERE RequiredDate < ShippedDate;
---
--Q2
SELECT DISTINCT(Country) FROM Employees;
---
--Q3
SELECT * FROM Employees WHERE ReportsTo IS Null;
---
--Q4
SELECT ProductName FROM Products WHERE Discontinued=1;
---
--Q5
SELECT * FROM [Order Details] Where Discount=0  AND  Discount Not Like '0.%';
---
--Q6
SELECT ContactName FROM Customers WHERE Region is Null;
---
--Q7
SELECT ContactName,Phone FROM Customers WHERE Country='UK' OR Country='USA';
---
--Q8
SELECT CompanyName FROM Suppliers WHERE HomePage is Not Null;
---
--Q9
SELECT DISTINCT(ShipCountry) FROM Orders WHERE Year(OrderDate)=1997;
---
--Q10
SELECT CustomerID FROM Orders WHERE ShippedDate is Null;
---
--Q11
SELECT SupplierID,CompanyName,City From Suppliers;
---
--Q12
SELECT * FROM Employees WHERE City='London';
---
--Q13
SELECT ProductName FROM Products WHERE Discontinued=0;
---
--Q14
SELECT OrderID FROM [Order Details] WHERE Discount<=0.1;
---
--Q15
SELECT EmployeeID,LastName,FirstName,HomePhone,Extension FROM Employees WHERE Region is Null;
---















