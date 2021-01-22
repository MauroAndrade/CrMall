-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema crmall
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema crmall
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `crmall` DEFAULT CHARACTER SET utf8 ;
USE `crmall` ;

-- -----------------------------------------------------
-- Table `crmall`.`clientes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `crmall`.`clientes` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(150) NOT NULL,
  `nascimento` DATETIME NOT NULL,
  `sexo` VARCHAR(10) NOT NULL,
  `cep` VARCHAR(9) NULL,
  `endereco` VARCHAR(150) NULL,
  `numero` VARCHAR(10) NULL,
  `complemento` VARCHAR(100) NULL,
  `bairro` VARCHAR(150) NULL,
  `estado` VARCHAR(150) NULL,
  `cidade` VARCHAR(150) NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC) VISIBLE)
ENGINE = InnoDB;

USE `crmall` ;

-- -----------------------------------------------------
-- Placeholder table for view `crmall`.`view1`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `crmall`.`view1` (`id` INT);

-- -----------------------------------------------------
-- View `crmall`.`view1`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `crmall`.`view1`;
USE `crmall`;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
