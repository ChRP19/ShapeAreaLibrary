--Создание таблицы с категориями
CREATE TABLE Category 
(
	id INT PRIMARY KEY,
	name VARCHAR(255) NOT NULL
);
--Создание таблицы с продуктами       
CREATE TABLE Products 
(
	id int PRIMARY KEY,
	name VARCHAR(255) NOT NULL,
    id_category int FOREIGN KEY (id_category) REFERENCES Category(id)
);
--Запрос на выборку продуктов с их категориями
SELECT Products.name, Category.name FROM Products
LEFT JOIN Category ON Products.id_category = Category.id 