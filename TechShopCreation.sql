-- Create Users Table
CREATE TABLE Users (
    UserId INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(255) NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    Age INT,
    Address NVARCHAR(255),
    Role NVARCHAR(10) CHECK (Role IN ('Admin', 'User')) NOT NULL
);

-- Create Categories Table
CREATE TABLE Categories (
    CategoryId INT IDENTITY(1,1) PRIMARY KEY,
    CategoryName NVARCHAR(100) NOT NULL UNIQUE
);

-- Create Products Table
CREATE TABLE Products (
    ProductId INT IDENTITY(1,1) PRIMARY KEY,
    ProductName NVARCHAR(100) NOT NULL,
    Price DECIMAL(10, 2) NOT NULL,
    CategoryId INT NOT NULL,
    FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId)
);

-- Create Favorites Table
CREATE TABLE Favorites (
    UserId INT NOT NULL,
    ProductId INT NOT NULL,
    PRIMARY KEY (UserId, ProductId),
    FOREIGN KEY (UserId) REFERENCES Users(UserId),
    FOREIGN KEY (ProductId) REFERENCES Products(ProductId)
);
-- Insert data into Categories
INSERT INTO Categories (CategoryName) VALUES
('Electronics'),
('Clothing'),
('Books');
-- Insert data into Products
INSERT INTO Products (ProductName, Price, CategoryId) VALUES
('Smartphone', 699.99, 1), -- Electronics
('Laptop', 999.99, 1),     -- Electronics
('T-Shirt', 19.99, 2),     -- Clothing
('Jeans', 49.99, 2),       -- Clothing
('Novel', 14.99, 3),       -- Books
('Science Journal', 29.99, 3); -- Books

-- Insert data into Users
INSERT INTO Users (Username, Password, Email, Age, Address, Role) VALUES
('mahmoud', 'password123', 'mahmoud@gmail.com', 22, '123 Elm Street', 'Admin'),
('ali', 'password345', 'ali@gmail.com', 23, '456 Oak Avenue', 'User');

-- Insert data into Favorites
-- Assuming 'john_doe' has UserId = 1 and 'Smartphone' has ProductId = 1
-- Assuming 'john_doe' has UserId = 1 and 'Novel' has ProductId = 5
INSERT INTO Favorites (UserId, ProductId) VALUES
(1, 1), -- john_doe favorites Smartphone
(1, 5); -- john_doe favorites Novel
