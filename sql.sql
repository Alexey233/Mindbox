CREATE TABLE Products (
Id INT PRIMARY KEY,
"Name" TEXT
);

INSERT INTO Products
VALUES
(1, 'Harry Potter'),
(2, 'Lord of the Rings'),
(3, 'Star wars');

CREATE TABLE Categories (
Id INT PRIMARY KEY,
"Name" TEXT
);

INSERT INTO Categories
VALUES
(1, 'Fantasy'),
(2, 'Wars'),
(3, 'Journeys');


INSERT INTO ProductCategories
VALUES
(1, 1),
(1, 2),
(2, 3),
(2, 1),
(3, 1),
(3, 2);


SELECT P."Name", C."Name"
FROM Products P
LEFT JOIN ProductCategories PC
ON P.Id = PC.ProductId
LEFT JOIN Categories C
ON PC.CategoryId = C.Id;