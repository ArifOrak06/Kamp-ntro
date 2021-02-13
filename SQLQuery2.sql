--Select
Select ContactName Adi,CompanyName Sirketadi,City Sehir From Customers

Select * From Customers where City = 'London'
Select * From Products where CategoryID = 1 or CategoryID=3

Select * From Products where categoryID = 1 and UnitPrice>=10
Select * From Products order by UnitPrice asc
Select * From Products where categoryID=1 order by UnitPrice desc 
Select count(*) From  Products where CategoryID=2
