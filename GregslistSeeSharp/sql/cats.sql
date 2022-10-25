




CREATE TABLE IF NOT EXISTS cats(
  id INT AUTO_INCREMENT PRIMARY KEY,
name VARCHAR(255)
);

INSERT INTO cats (name) VALUE ("Monkey");
INSERT INTO cats (name) VALUE ("Goblin");
INSERT INTO cats (name) VALUE ("Felix");
INSERT INTO cats (name) VALUE ("Tony");
INSERT INTO cats (name) VALUE ("Hobs");

SELECT * FROM cats  ;

SELECT * FROM cats WHERE id = 4;

SELECT * FROM cats WHERE name = "Monkey";


UPDATE cats SET
  name = "Felix the Cat"
WHERE id = 3;


UPDATE cats SET
age = 1;

ALTER TABLE cats ADD COLUMN(
age int DEFAULT 0
);




DELETE FROM cats WHERE id = 7;

DROP TABLE cats;