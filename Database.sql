CREATE TABLE Category (
    id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(255) NOT NULL,
    description TEXT,
    photo NVARCHAR(MAX)
);

CREATE TABLE Product (
    id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(255) NOT NULL,
    description TEXT,
    price DECIMAL(10,2) NOT NULL,
    catid INT,
    photo NVARCHAR(MAX),
    FOREIGN KEY (catid) REFERENCES Category(id) ON DELETE NO ACTION
);

CREATE TABLE Review (
    id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(255) NOT NULL,
    email NVARCHAR(50) NOT NULL,
    subject NVARCHAR(255),
    description TEXT
);

CREATE TABLE Cart (
    id INT PRIMARY KEY IDENTITY(1,1),
    userid INT NOT NULL,
    productid INT NOT NULL,
    count INT NOT NULL,
    FOREIGN KEY (productid) REFERENCES Product(id) ON DELETE NO ACTION
);
