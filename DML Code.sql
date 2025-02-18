use TechShop
insert into Users ([Username],[Password],[Email],[Age],[Address],[Role])
values("");
select * from Users;
select * from Products
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