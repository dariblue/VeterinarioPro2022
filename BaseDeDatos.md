-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         8.0.27 - MySQL Community Server - GPL
-- SO del servidor:              Win64
-- HeidiSQL Versión:             11.3.0.6295
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Volcando estructura de base de datos para veterinario
CREATE DATABASE IF NOT EXISTS `veterinario` /*!40100 DEFAULT CHARACTER SET utf8mb4*/ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `veterinario`;

-- Volcando estructura para tabla veterinario.animales
CREATE TABLE IF NOT EXISTS `animales` (
  `id_animales` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) DEFAULT NULL,
  `raza` varchar(50) DEFAULT NULL,
  `especie` varchar(50) DEFAULT NULL,
  `dni` char(9) CHARACTER SET utf8mb4 DEFAULT NULL,
  PRIMARY KEY (`id_animales`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla veterinario.animales: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `animales` DISABLE KEYS */;
INSERT INTO `animales` (`id_animales`, `nombre`, `raza`, `especie`, `dni`) VALUES
	(1, 'Jaime', NULL, NULL, '51725704S');
/*!40000 ALTER TABLE `animales` ENABLE KEYS */;

-- Volcando estructura para tabla veterinario.clientes
CREATE TABLE IF NOT EXISTS `clientes` (
  `dni` char(9) CHARACTER SET utf8mb4 NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `usuario` varchar(120) NOT NULL,
  `contraseña` varchar(40) CHARACTER SET utf8mb4 NOT NULL,
  PRIMARY KEY (`dni`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla veterinario.clientes: ~4 rows (aproximadamente)
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` (`dni`, `nombre`, `usuario`, `contraseña`) VALUES
	('1', 'Jaime', 'Dario', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
	('2', 'jota', 'JuanPablo', '1920a56593b125b12813085d0845ffcdd31e1349'),
	('3', 'Hola', 'Nombre', 'e96b0bb7e24c71bee63840745a3fc46ddfc73800'),
	('4', 'Holaaa', 'Nombree', '902f5e8ca6d03a4d807d5fc364612bf48004647c');
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;

-- Volcando estructura para tabla veterinario.consultas
CREATE TABLE IF NOT EXISTS `consultas` (
  `id_consulta` int NOT NULL AUTO_INCREMENT,
  `id_animal` int NOT NULL,
  `n_empleado` int NOT NULL,
  `hora` datetime NOT NULL,
  PRIMARY KEY (`id_consulta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla veterinario.consultas: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `consultas` DISABLE KEYS */;
/*!40000 ALTER TABLE `consultas` ENABLE KEYS */;

-- Volcando estructura para tabla veterinario.tienda
CREATE TABLE IF NOT EXISTS `tienda` (
  `id_producto` int NOT NULL AUTO_INCREMENT,
  `stok` int NOT NULL,
  `precio` decimal(20,6) NOT NULL DEFAULT '0.000000',
  PRIMARY KEY (`id_producto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla veterinario.tienda: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `tienda` DISABLE KEYS */;
/*!40000 ALTER TABLE `tienda` ENABLE KEYS */;

-- Volcando estructura para tabla veterinario.trabajadores
CREATE TABLE IF NOT EXISTS `trabajadores` (
  `n_empleado` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL,
  `usuario` varchar(50) NOT NULL,
  `contraseña` varchar(40) NOT NULL,
  PRIMARY KEY (`n_empleado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla veterinario.trabajadores: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `trabajadores` DISABLE KEYS */;
/*!40000 ALTER TABLE `trabajadores` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
