---Q1
Select C.CustomerID,O.OrderID,O.OrderDate
From Customers As C
Left Join Orders As O
on C.CustomerID= O.CustomerID;
---
---Q2
Select C.CustomerID,O.OrderID,O.OrderDate
From Customers As C
Left Join Orders As O
on C.CustomerID= O.CustomerID
where O.OrderID is Null;
---
---Q3
Select C.CustomerID,O.OrderID,O.OrderDate
From Customers As C
Join Orders As O
on C.CustomerID= O.CustomerID
where MONTH(O.OrderDate)=7 And YEAR(O.OrderDate)=1997;
---
---Q4
Select C.CustomerID , Count(O.OrderID) As TotalOrders
From Customers As C
Left Join Orders As O
on C.CustomerID= O.CustomerID
Group By C.CustomerID;
---
---Q7
Select C.CustomerID,Count(O.OrderID) As TotalOrders ,SUM(OD.Quantity) As TotalQuantity
From Customers As C
Left Join Orders As O
On C.CustomerID=O.CustomerID
Join [Order Details] As OD
On O.OrderID=OD.OrderID
Where C.Country='USA'
Group By C.CustomerID;
---
---Q8
Select C.CustomerID,C.CompanyName,O.OrderID,O.OrderDate
From Customers As C
Join Orders As O
On C.CustomerID=O.CustomerID
Where  Month(O.OrderDate)=7 And Day(O.OrderDate)=4 And Year(O.OrderDate)=1997;


---Q10
Select P.ProductName,O.OrderDate
From Orders As O
Join [Order Details] As OD
On O.OrderID=OD.OrderID
Join Products As P
On OD.ProductID=P.ProductID
Where  Month(O.OrderDate)=8 And Day(O.OrderDate)=8 And Year(O.OrderDate)=1997;
---
---Q11
Select O.ShipAddress,O.ShipCity,O.ShipCountry,O.ShippedDate,O.RequiredDate
From Orders AS O
Join [Order Details] As OD 
On O.OrderID=OD.OrderID
Join Products AS P
On OD.ProductID=P.ProductID
Join Suppliers AS S
On P.SupplierID=S.SupplierID
Where S.ContactName like 'Anne%' And O.RequiredDate<O.ShippedDate;
---
---Q12
select Distinct ShipCountry
from Orders
Where ShipName like '%Beverages%';





