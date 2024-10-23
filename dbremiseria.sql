-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         10.4.32-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win64
-- HeidiSQL Versión:             12.8.0.6908
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Volcando estructura de base de datos para remiseria
CREATE DATABASE IF NOT EXISTS `remiseria` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;
USE `remiseria`;

-- Volcando estructura para procedimiento remiseria.asp_guardar cliente
DELIMITER //
CREATE PROCEDURE `asp_guardar cliente`(
	IN `_apellido` VARCHAR(50),
	IN `_nombre ` VARCHAR(50),
	IN `_dni` INT,
	IN `_telefono ` VARCHAR(15),
	IN `_direccion ` VARCHAR(50)
)
BEGIN

END//
DELIMITER ;

-- Volcando estructura para tabla remiseria.choferes
CREATE TABLE IF NOT EXISTS `choferes` (
  `IdChofer` int(11) NOT NULL AUTO_INCREMENT,
  `apellido` varchar(50) NOT NULL DEFAULT '0',
  `nombre` varchar(50) NOT NULL DEFAULT '0',
  `licenciaConducir` varchar(6) NOT NULL DEFAULT '0',
  `activo` tinyint(1) NOT NULL DEFAULT 0,
  PRIMARY KEY (`IdChofer`),
  UNIQUE KEY `licenciaConducir` (`licenciaConducir`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla remiseria.choferes: ~0 rows (aproximadamente)

-- Volcando estructura para tabla remiseria.clientes
CREATE TABLE IF NOT EXISTS `clientes` (
  `idCliente` int(11) NOT NULL,
  `apellido` varchar(50) DEFAULT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  `telefono` varchar(15) DEFAULT NULL,
  `direccion` varchar(50) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `activo` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idCliente`),
  UNIQUE KEY `email` (`email`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla remiseria.clientes: ~0 rows (aproximadamente)

-- Volcando estructura para tabla remiseria.servicio
CREATE TABLE IF NOT EXISTS `servicio` (
  `id_Servicio` int(11) NOT NULL AUTO_INCREMENT,
  `id_Cliente` int(11) DEFAULT 0,
  `id_Vehiculo` int(11) DEFAULT 0,
  `id_chofer` int(11) DEFAULT 0,
  `fecha` date DEFAULT NULL,
  `horaInicio` date DEFAULT NULL,
  `horaFin` date DEFAULT NULL,
  `origen` varchar(50) DEFAULT NULL,
  `destino` varchar(50) DEFAULT NULL,
  `precio` decimal(10,2) DEFAULT NULL,
  `estado` varchar(50) DEFAULT NULL,
  `activo` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`id_Servicio`),
  KEY `id_chofer` (`id_chofer`),
  KEY `id_cliente` (`id_Cliente`),
  KEY `idvehiculo` (`id_Vehiculo`),
  CONSTRAINT `id_chofer` FOREIGN KEY (`id_chofer`) REFERENCES `choferes` (`IdChofer`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `id_cliente` FOREIGN KEY (`id_Cliente`) REFERENCES `clientes` (`idCliente`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `idvehiculo` FOREIGN KEY (`id_Vehiculo`) REFERENCES `vehiculos` (`idVehiculo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla remiseria.servicio: ~0 rows (aproximadamente)

-- Volcando estructura para tabla remiseria.vehiculos
CREATE TABLE IF NOT EXISTS `vehiculos` (
  `idVehiculo` int(11) NOT NULL,
  `patente` varchar(7) NOT NULL,
  `marca` varchar(20) DEFAULT NULL,
  `modelo` varchar(20) DEFAULT NULL,
  `año` varchar(20) DEFAULT NULL,
  `estado` varchar(20) DEFAULT NULL,
  `activo` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idVehiculo`),
  UNIQUE KEY `patente` (`patente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla remiseria.vehiculos: ~0 rows (aproximadamente)

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
