-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema biblioteca
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema biblioteca
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `biblioteca` DEFAULT CHARACTER SET utf8mb3 ;
USE `biblioteca` ;

-- -----------------------------------------------------
-- Table `biblioteca`.`book`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `biblioteca`.`book` (
  `book_id` INT NOT NULL,
  `title` VARCHAR(255) NOT NULL,
  `author` VARCHAR(255) NOT NULL,
  `isbn` VARCHAR(255) NOT NULL,
  `publisher` VARCHAR(255) NOT NULL,
  `year` VARCHAR(45) NOT NULL,
  `category` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`book_id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `biblioteca`.`user`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `biblioteca`.`user` (
  `username` VARCHAR(16) NOT NULL,
  `email` VARCHAR(255) NULL DEFAULT NULL,
  `password` VARCHAR(255) NOT NULL,
  `create_time` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP,
  `id` INT NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `username_UNIQUE` (`username` ASC) VISIBLE,
  UNIQUE INDEX `email_UNIQUE` (`email` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 10
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `biblioteca`.`requisicoes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `biblioteca`.`requisicoes` (
  `user_id` INT NOT NULL,
  `book_id` INT NOT NULL,
  `levantamento` VARCHAR(255) NOT NULL,
  `entrega` VARCHAR(45) NULL DEFAULT NULL,
  `id` INT NOT NULL,
  PRIMARY KEY (`user_id`, `book_id`, `id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC) VISIBLE,
  INDEX `fk_user_has_book_book1_idx` (`book_id` ASC) VISIBLE,
  INDEX `fk_user_has_book_user_idx` (`user_id` ASC) VISIBLE,
  CONSTRAINT `fk_user_has_book_book1`
    FOREIGN KEY (`book_id`)
    REFERENCES `biblioteca`.`book` (`book_id`),
  CONSTRAINT `fk_user_has_book_user`
    FOREIGN KEY (`user_id`)
    REFERENCES `biblioteca`.`user` (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;

USE `biblioteca` ;

-- -----------------------------------------------------
-- procedure deletebook
-- -----------------------------------------------------

DELIMITER $$
USE `biblioteca`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `deletebook`(
	in bookTitle varchar(45)
)
BEGIN
	DELETE FROM book WHERE title = bookTitle;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure deleteuser
-- -----------------------------------------------------

DELIMITER $$
USE `biblioteca`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `deleteuser`(
	in userId varchar(45)
)
BEGIN
	DELETE FROM user WHERE id = userId;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure getbook
-- -----------------------------------------------------

DELIMITER $$
USE `biblioteca`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `getbook`(
	in bookTitle varchar(255)
)
BEGIN
	select * from book where `title` = bookTitle;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure getrequisicao
-- -----------------------------------------------------

DELIMITER $$
USE `biblioteca`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `getrequisicao`(
	in requisicaoId INT
)
BEGIN
	select * from `requisicoes` where `id` = requisicaoId;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure getuser
-- -----------------------------------------------------

DELIMITER $$
USE `biblioteca`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `getuser`(
    in userName varchar(255)
)
BEGIN
	select * from user where username = userName;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure insertbook
-- -----------------------------------------------------

DELIMITER $$
USE `biblioteca`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insertbook`(
	in bookTitle varchar(255),
    in bookAuthor varchar(255),
    in bookIsbn varchar(255), 
    in bookPublisher varchar(255),
    in bookYear varchar(45),
    in bookCategory varchar(45)
)
BEGIN
	DECLARE bookid INT DEFAULT 0;
	SET bookid = ((SELECT max(`book`.`book_id`) FROM book ) + 1) OR 1;
	INSERT INTO book (
    book_id,
    title,
    author,
    isbn,
    publisher,
    year,
    category
    )
	VALUES (
	bookid,
    bookTitle,
    bookAuthor,
    bookIsbn,
    bookPublisher,
    bookYear,
    bookCategory
    );
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure insertrequisicao
-- -----------------------------------------------------

DELIMITER $$
USE `biblioteca`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insertrequisicao`(
	in userid INT,
    in bookid INT,
    in levantamento varchar(255)
)
BEGIN
	DECLARE reqid INT DEFAULT 0;
	SET reqid = ((SELECT max(`requisicoes`.`id`) FROM requisicoes) + 1) or 1;
    INSERT INTO `biblioteca`.`requisicoes`
	(
    `user_id`,
	`book_id`,
	`levantamento`,
	`entrega`,
	`id`)
	VALUES
	(userid, bookid, levantamento, "", reqid);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure insertuser
-- -----------------------------------------------------

DELIMITER $$
USE `biblioteca`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insertuser`(
	in userUsername varchar(255),
    in userEmail varchar(255),
    in userPassword varchar(255)
)
BEGIN
	DECLARE userid INT DEFAULT 0;
	SET userid = ((SELECT max(`user`.`id`) FROM user) + 1);
	INSERT INTO user (
		username,
        email,
        password,
        id
    )
	VALUES (
		userUsername,
        userEmail,
        userPassword,
        userid
    );
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure new_procedure
-- -----------------------------------------------------

DELIMITER $$
USE `biblioteca`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `new_procedure`(
	in requisicaoId INT
)
BEGIN
	select * from `requisicoes` where `user_id` = requisicaoId;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure updatebook
-- -----------------------------------------------------

DELIMITER $$
USE `biblioteca`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `updatebook`(
	in bookTitle varchar(255),
    in bookAuthor varchar(255),
    in bookIsbn varchar(255), 
    in bookPublisher varchar(255),
    in bookYear varchar(45),
    in bookCategory varchar(45)
)
BEGIN
	UPDATE book
    SET title = bookTitle, 
    Author = bookAuthor, 
    isbn = bookIsbn, 
    publisher = bookPublisher,
	year =  bookYear,
    category = bookCategory
    WHERE title = bookTitle;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure updaterequisicao
-- -----------------------------------------------------

DELIMITER $$
USE `biblioteca`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `updaterequisicao`(
	in entrega varchar(45),
    in userid INT,
    in bookid INT
)
BEGIN
	UPDATE `biblioteca`.`requisicoes`
	SET
	`entrega` = entrega
	WHERE `book_id` = bookid and `user_id` = userid;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure updateuser
-- -----------------------------------------------------

DELIMITER $$
USE `biblioteca`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `updateuser`(
	in userId INT,
	in userEmail varchar(255),
    in userPassword varchar(255)
)
BEGIN
	UPDATE user
	SET username = userName, email = userEmail, password = userPassword
	WHERE id = userId;
END$$

DELIMITER ;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
