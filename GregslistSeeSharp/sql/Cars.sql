-- Active: 1666715468048@@SG-curved-roast-6734-6831-mysql-master.servers.mongodirector.com@3306@MyFirstDatabase

CREATE TABLE IF NOT EXISTS cars(
id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
make VARCHAR(255)  NOT NULL,
model VARCHAR(255)  NOT NULL,
year INT CHECK(year >=1886) NOT NULL,
price DECIMAL (10,2) NOT NULL CHECK(price >= 0),
description VARCHAR(255),
imgUrl VARCHAR(255) DEFAULT "https://upload.wikimedia.org/wikipedia/commons/2/22/Hot_dog_car_in_New_York_city_1020027.jpg"
);

INSERT INTO cars (make,model,year,price,description,imgUrl) 
VALUES ("HOTDOG", "BUCKET", 1996, 9999, "Yuck Yuck", "https://upload.wikimedia.org/wikipedia/commons/2/22/Hot_dog_car_in_New_York_city_1020027.jpg");


SELECT * FROM cars ;

DROP TABLE cars;