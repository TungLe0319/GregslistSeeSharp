-- Active: 1666715468048@@SG-curved-roast-6734-6831-mysql-master.servers.mongodirector.com@3306@MyFirstDatabase
CREATE TABLE IF NOT EXISTS homes(
  
id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
bathrooms INT,
bedrooms INT,
levels INT,
year INT CHECK(year >=1800),
price DECIMAL (12,2) NOT NULL CHECK(price >= 0),
description VARCHAR(255) NOT NULL,
imgUrl VARCHAR(255) ,
sellerId VARCHAR(255) NOT NULL,
FOREIGN KEY(sellerId) REFERENCES accounts(id) ON DELETE CASCADE
)default charset utf8 COMMENT '';

INSERT INTO homes (bathrooms,bedrooms,levels,year,price,description,imgUrl) 
VALUES (1, 2, 1, 2001, 9000000 , 'lovely home',"https://images.unsplash.com/photo-1480074568708-e7b720bb3f09?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8OXx8aG9tZXxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=800&q=60");


SELECT * FROM homes ;

DROP TABLE homes;

DELETE from homes WHERE id = 1;

UPDATE cars SET 
  make = @make,
                model = @model,
                year = @year,
                price = @price,
                imgUrl = @imgUrl,
                description = @description        
            WHERE id = @id;