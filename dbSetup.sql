CREATE TABLE
    IF NOT EXISTS accounts(
        id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name varchar(255) COMMENT 'User Name',
        email varchar(255) COMMENT 'User Email',
        picture varchar(255) COMMENT 'User Picture'
    ) default charset utf8 COMMENT '';

CREATE TABLE
    IF NOT EXISTS pickles(
        id INT NOT NULL PRIMARY KEY AUTO_INCREMENT COMMENT ' this is the id primary key',
        name CHAR(255) NOT NULL COMMENT 'the name',
        pickleType ENUM(
            'green',
            'dark green',
            'yellow'
        ) NOT NULL,
        isSour BOOLEAN NOT NULL DEFAULT true
    ) default charset utf8 COMMENT '';

INSERT INTO pickles (name) VALUES('green pickle');

INSERT INTO
    pickles (name, pickleType)
VALUES (
        'dark green pickle',
        'dark green'
    );

INSERT INTO
    pickles (name, pickleType, isSour)
VALUES (
        'dark green pickle',
        'dark green',
        false
    );

SELECT * FROM pickles;

DROP TABLE pickles;