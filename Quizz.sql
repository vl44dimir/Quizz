SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

CREATE SCHEMA IF NOT EXISTS `Quizz` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `Quizz` ;

-- -----------------------------------------------------
-- Table `Quizz`.`Joueurs`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Quizz`.`Joueurs` ;

CREATE  TABLE IF NOT EXISTS `Quizz`.`Joueurs` (
  `idJoueurs` INT NOT NULL AUTO_INCREMENT ,
  `Pseudo` VARCHAR(105) NOT NULL ,
  `Resultat` TINYINT NOT NULL ,
  PRIMARY KEY (`idJoueurs`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Quizz`.`Categories`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Quizz`.`Categories` ;

CREATE  TABLE IF NOT EXISTS `Quizz`.`Categories` (
  `idCategories` INT NOT NULL AUTO_INCREMENT ,
  `Nom` TEXT NOT NULL ,
  PRIMARY KEY (`idCategories`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Quizz`.`Question`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Quizz`.`Question` ;

CREATE  TABLE IF NOT EXISTS `Quizz`.`Question` (
  `idQuestion` INT NOT NULL AUTO_INCREMENT ,
  `Question` TEXT NOT NULL ,
  `Fkcategories` INT NOT NULL ,
  PRIMARY KEY (`idQuestion`) ,
  INDEX `fk_Question_catégories1_idx` (`Fkcategories` ASC) ,
  CONSTRAINT `fk_Question_catégories1`
    FOREIGN KEY (`Fkcategories` )
    REFERENCES `Quizz`.`Categories` (`idCategories` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Quizz`.`Reponse`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Quizz`.`Reponse` ;

CREATE  TABLE IF NOT EXISTS `Quizz`.`Reponse` (
  `idReponse` INT NOT NULL AUTO_INCREMENT ,
  `Réponse` TEXT NOT NULL ,
  `Bonne` TINYINT(1) NOT NULL ,
  `FkQuestion` INT NOT NULL ,
  PRIMARY KEY (`idReponse`) ,
  INDEX `fk_Réponse_Question_idx` (`FkQuestion` ASC) ,
  CONSTRAINT `fk_Réponse_Question`
    FOREIGN KEY (`FkQuestion` )
    REFERENCES `Quizz`.`Question` (`idQuestion` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

USE `Quizz` ;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
