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
  `idJoueurs` INT NOT NULL ,
  `Pseudo` VARCHAR(105) NOT NULL ,
  `Résultat` TINYINT NOT NULL ,
  PRIMARY KEY (`idJoueurs`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Quizz`.`Catégories`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Quizz`.`Catégories` ;

CREATE  TABLE IF NOT EXISTS `Quizz`.`Catégories` (
  `idCatégories` INT NOT NULL ,
  `Nom` TEXT NOT NULL ,
  PRIMARY KEY (`idCatégories`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Quizz`.`Question`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Quizz`.`Question` ;

CREATE  TABLE IF NOT EXISTS `Quizz`.`Question` (
  `idQuestion` INT NOT NULL ,
  `Question` TEXT NOT NULL ,
  `Fkcatégories` INT NOT NULL ,
  PRIMARY KEY (`idQuestion`) ,
  INDEX `fk_Question_catégories1_idx` (`Fkcatégories` ASC) ,
  CONSTRAINT `fk_Question_catégories1`
    FOREIGN KEY (`Fkcatégories` )
    REFERENCES `Quizz`.`Catégories` (`idCatégories` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Quizz`.`Réponse`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Quizz`.`Réponse` ;

CREATE  TABLE IF NOT EXISTS `Quizz`.`Réponse` (
  `idRéponse` INT NOT NULL ,
  `Réponse` TEXT NOT NULL ,
  `Bonne` TINYINT(1) NOT NULL ,
  `FkQuestion` INT NOT NULL ,
  PRIMARY KEY (`idRéponse`) ,
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
