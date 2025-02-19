use TechShop
insert into Users ([Username],[Password],[Email],[Age],[Address],[Role])
values("");
select [UserId],[Username],[Password],[Email],[Age],[Address],[Role] from Users where Role=''
select * from Users;
select * from Products
select * from Categories
select [ProductId],[ProductName],[Price],[CategoryName] from Products p join Categories c on(p.CategoryId=c.CategoryId)
select [Username],[Password] from Users where Password='password123' and Username='mahmoud'and Role='Admin';
select [UserId],[Username],[Password],[Email],[Age],[Address],[Role] from Users
select [CategoryId],[CategoryName] from Categories
insert into Products ([ProductName],[Price],[CategoryId]) values()
delete from Products where[ProductId]=
select [CategoryId],[CategoryName] from Categories
insert into Categories ([CategoryName]) values('akd');
update Categories set CategoryName='' where CategoryId=
delete from Categories where CategoryId=

select p.[ProductId],[ProductName],[Price],[CategoryName]
from Products p join Categories c on(p.CategoryId=c.CategoryId)
join Favorites f on(p.ProductId=f.ProductId) and f.UserId !=2 
insert into Favorites([UserId],ProductId) values ()



SELECT 
    p.[ProductId], 
    p.[ProductName], 
    p.[Price], 
    c.[CategoryName]
FROM Products p
JOIN Categories c ON p.CategoryId = c.CategoryId
WHERE  EXISTS (
    SELECT 1 
    FROM Favorites f 
    WHERE f.ProductId = p.ProductId 
    AND f.UserId = 2
);

delete from Favorites where ProductId= and UserId=
