-- MySQL dump 10.13  Distrib 9.6.0, for Linux (x86_64)
--
-- Host: localhost    Database: asistencia
-- ------------------------------------------------------
-- Server version	9.6.0

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
SET @MYSQLDUMP_TEMP_LOG_BIN = @@SESSION.SQL_LOG_BIN;
SET @@SESSION.SQL_LOG_BIN= 0;

--
-- GTID state at the beginning of the backup 
--

SET @@GLOBAL.GTID_PURGED=/*!80000 '+'*/ '183a3f71-200d-11f1-bbe3-362def220f14:1-417';

--
-- Table structure for table `Alumnos`
--

DROP TABLE IF EXISTS `Alumnos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Alumnos` (
  `NoControl` varchar(9) NOT NULL,
  `Nombre` char(15) DEFAULT NULL,
  `Appat` char(15) DEFAULT NULL,
  `Apmat` char(15) DEFAULT NULL,
  `Semestre` int DEFAULT NULL,
  PRIMARY KEY (`NoControl`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Alumnos`
--

LOCK TABLES `Alumnos` WRITE;
/*!40000 ALTER TABLE `Alumnos` DISABLE KEYS */;
INSERT INTO `Alumnos` VALUES ('25130001','Juan','Lopez','Lopez',4),('25130002','Luis','Torres','Perez',9),('25130003','Carlos','Lopez','Garcia',7),('25130004','Sofia','Hernandez','Sanchez',8),('25130005','Miguel','Torres','Ramirez',1),('25130006','Carlos','Hernandez','Hernandez',2),('25130007','Miguel','Hernandez','Torres',2),('25130008','Lucia','Martinez','Torres',1),('25130009','Lucia','Gonzalez','Torres',7),('25130010','Sofia','Flores','Garcia',1),('25130011','Lucia','Garcia','Torres',6),('25130012','Lucia','Lopez','Gonzalez',6),('25130013','Ana','Flores','Gonzalez',2),('25130014','Elena','Garcia','Garcia',1),('25130015','Pedro','Torres','Gonzalez',5),('25130016','Sofia','Perez','Martinez',8),('25130017','Elena','Gonzalez','Hernandez',6),('25130018','Luis','Hernandez','Hernandez',4),('25130019','Sofia','Martinez','Martinez',5),('25130020','Juan','Flores','Flores',2),('25130021','Ana','Lopez','Hernandez',4),('25130022','Lucia','Flores','Garcia',5),('25130023','Pedro','Lopez','Sanchez',9),('25130024','Ana','Flores','Flores',6),('25130025','Sofia','Gonzalez','Lopez',8),('25130026','Sofia','Hernandez','Hernandez',5),('25130027','Maria','Torres','Gonzalez',7),('25130028','Luis','Gonzalez','Ramirez',5),('25130029','Maria','Flores','Garcia',4),('25130030','Sofia','Garcia','Torres',1),('25130031','Elena','Gonzalez','Torres',8),('25130032','Maria','Garcia','Torres',5),('25130033','Miguel','Ramirez','Ramirez',1),('25130034','Carlos','Sanchez','Gonzalez',7),('25130035','Carlos','Garcia','Martinez',8),('25130036','Miguel','Garcia','Ramirez',5),('25130037','Maria','Ramirez','Gonzalez',7),('25130038','Sofia','Hernandez','Gonzalez',7),('25130039','Maria','Garcia','Perez',8),('25130040','Sofia','Flores','Torres',3),('25130041','Maria','Lopez','Garcia',8),('25130042','Sofia','Torres','Lopez',2),('25130043','Luis','Garcia','Perez',4),('25130044','Sofia','Ramirez','Sanchez',2),('25130045','Juan','Garcia','Sanchez',2),('25130046','Luis','Martinez','Lopez',8),('25130047','Ana','Gonzalez','Martinez',2),('25130048','Elena','Sanchez','Ramirez',8),('25130049','Carlos','Torres','Lopez',1),('25130050','Maria','Ramirez','Torres',5),('NC1000','Pedro','Perez','Torres',1),('NC1001','Elena','Perez','Ramirez',2),('NC1002','Lucia','Ramirez','Lopez',9),('NC1003','Maria','Garcia','Perez',6),('NC1004','Maria','Ramirez','Gonzalez',2),('NC1005','Pedro','Martinez','Martinez',6),('NC1006','Ana','Hernandez','Hernandez',9),('NC1007','Elena','Hernandez','Ramirez',6),('NC1008','Sofia','Hernandez','Lopez',1),('NC1009','Lucia','Perez','Garcia',1),('NC1010','Juan','Torres','Torres',4),('NC1011','Miguel','Perez','Martinez',2),('NC1012','Maria','Ramirez','Garcia',3),('NC1013','Elena','Ramirez','Hernandez',6),('NC1014','Carlos','Garcia','Hernandez',2),('NC1015','Miguel','Garcia','Garcia',6),('NC1016','Sofia','Garcia','Garcia',3),('NC1017','Ana','Gonzalez','Gonzalez',8),('NC1018','Maria','Lopez','Martinez',5),('NC1019','Sofia','Torres','Garcia',4),('NC1020','Sofia','Ramirez','Lopez',6),('NC1021','Elena','Ramirez','Hernandez',1),('NC1022','Ana','Gonzalez','Torres',2),('NC1023','Ana','Ramirez','Garcia',3),('NC1024','Elena','Ramirez','Sanchez',3),('NC1025','Maria','Garcia','Hernandez',2),('NC1026','Elena','Flores','Lopez',6),('NC1027','Juan','Hernandez','Martinez',1),('NC1028','Pedro','Gonzalez','Gonzalez',6),('NC1029','Maria','Garcia','Hernandez',8),('NC1030','Ana','Martinez','Ramirez',8),('NC1031','Luis','Martinez','Garcia',9),('NC1032','Juan','Lopez','Martinez',8),('NC1033','Pedro','Ramirez','Sanchez',6),('NC1034','Ana','Lopez','Gonzalez',7),('NC1035','Pedro','Hernandez','Garcia',5),('NC1036','Lucia','Martinez','Garcia',4),('NC1037','Lucia','Garcia','Ramirez',2),('NC1038','Sofia','Lopez','Sanchez',4),('NC1039','Sofia','Hernandez','Gonzalez',6),('NC1040','Elena','Hernandez','Flores',5),('NC1041','Carlos','Torres','Garcia',8),('NC1042','Juan','Ramirez','Ramirez',3),('NC1043','Carlos','Hernandez','Garcia',1),('NC1044','Ana','Sanchez','Garcia',3),('NC1045','Maria','Perez','Perez',6),('NC1046','Juan','Torres','Gonzalez',1),('NC1047','Carlos','Torres','Lopez',2),('NC1048','Carlos','Martinez','Sanchez',6),('NC1049','Juan','Flores','Hernandez',5);
/*!40000 ALTER TABLE `Alumnos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Asistencia`
--

DROP TABLE IF EXISTS `Asistencia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Asistencia` (
  `No_Registro` int NOT NULL,
  `No_Control` char(15) NOT NULL,
  `Nombre` char(15) DEFAULT NULL,
  `Asistio` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`No_Registro`,`No_Control`),
  KEY `FK_Asistencia_Alumno` (`No_Control`),
  CONSTRAINT `FK_Asistencia_Alumno` FOREIGN KEY (`No_Control`) REFERENCES `Alumnos` (`NoControl`),
  CONSTRAINT `FK_Asistencia_Registro` FOREIGN KEY (`No_Registro`) REFERENCES `Registros` (`No_Registro`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Asistencia`
--

LOCK TABLES `Asistencia` WRITE;
/*!40000 ALTER TABLE `Asistencia` DISABLE KEYS */;
INSERT INTO `Asistencia` VALUES (1,'25130001','Juan',0),(1,'25130002','Luis',0),(1,'25130003','Carlos',0),(1,'25130004','Sofia',0),(1,'25130005','Miguel',1),(1,'25130006','Carlos',1),(1,'25130007','Miguel',0),(1,'25130008','Lucia',1),(1,'25130009','Lucia',0),(1,'25130010','Sofia',1),(1,'25130011','Lucia',0),(1,'25130012','Lucia',1),(1,'25130013','Ana',0),(1,'25130014','Elena',1),(1,'25130015','Pedro',0),(1,'25130016','Sofia',1),(1,'25130017','Elena',0),(1,'25130018','Luis',1),(1,'25130019','Sofia',0),(1,'25130020','Juan',1),(1,'25130021','Ana',0),(1,'25130022','Lucia',1),(1,'25130023','Pedro',0),(1,'25130024','Ana',1),(1,'25130025','Sofia',0),(1,'25130026','Sofia',1),(1,'25130027','Maria',0),(1,'25130028','Luis',1),(1,'25130029','Maria',0),(1,'25130030','Sofia',1),(1,'25130031','Elena',0),(1,'25130032','Maria',1),(1,'25130033','Miguel',0),(1,'25130034','Carlos',1),(1,'25130035','Carlos',0),(1,'25130036','Miguel',1),(1,'25130037','Maria',1),(1,'25130038','Sofia',0),(1,'25130039','Maria',0),(1,'25130040','Sofia',0),(1,'25130041','Maria',0),(1,'25130042','Sofia',1),(1,'25130043','Luis',1),(1,'25130044','Sofia',1),(1,'25130045','Juan',1),(1,'25130046','Luis',0),(1,'25130047','Ana',0),(1,'25130048','Elena',1),(1,'25130049','Carlos',0),(1,'25130050','Maria',1),(1,'NC1000','Pedro',0),(1,'NC1001','Elena',1),(1,'NC1002','Lucia',0),(1,'NC1003','Maria',1),(1,'NC1004','Maria',0),(1,'NC1005','Pedro',1),(1,'NC1006','Ana',0),(1,'NC1007','Elena',1),(1,'NC1008','Sofia',0),(1,'NC1009','Lucia',1),(1,'NC1010','Juan',0),(1,'NC1011','Miguel',1),(1,'NC1012','Maria',1),(1,'NC1013','Elena',1),(1,'NC1014','Carlos',1),(1,'NC1015','Miguel',0),(1,'NC1016','Sofia',0),(1,'NC1017','Ana',1),(1,'NC1018','Maria',1),(1,'NC1019','Sofia',1),(1,'NC1020','Sofia',1),(1,'NC1021','Elena',1),(1,'NC1022','Ana',0),(1,'NC1023','Ana',0),(1,'NC1024','Elena',0),(1,'NC1025','Maria',0),(1,'NC1026','Elena',0),(1,'NC1027','Juan',0),(1,'NC1028','Pedro',0),(1,'NC1029','Maria',0),(1,'NC1030','Ana',0),(1,'NC1031','Luis',0),(1,'NC1032','Juan',0),(1,'NC1033','Pedro',0),(1,'NC1034','Ana',0),(1,'NC1035','Pedro',0),(1,'NC1036','Lucia',0),(1,'NC1037','Lucia',0),(1,'NC1038','Sofia',0),(1,'NC1039','Sofia',0),(1,'NC1040','Elena',0),(1,'NC1041','Carlos',0),(1,'NC1042','Juan',0),(1,'NC1043','Carlos',0),(1,'NC1044','Ana',0),(1,'NC1045','Maria',0),(1,'NC1046','Juan',0),(1,'NC1047','Carlos',0),(1,'NC1048','Carlos',0),(1,'NC1049','Juan',0),(2,'25130001','Juan',0),(2,'25130002','Luis',1),(2,'25130003','Carlos',1),(2,'25130004','Sofia',0),(2,'25130005','Miguel',1),(2,'25130006','Carlos',1),(2,'25130007','Miguel',1),(2,'25130008','Lucia',1),(2,'25130009','Lucia',0),(2,'25130010','Sofia',1),(2,'25130011','Lucia',0),(2,'25130012','Lucia',0),(2,'25130013','Ana',1),(2,'25130014','Elena',0),(2,'25130015','Pedro',1),(2,'25130016','Sofia',0),(2,'25130017','Elena',1),(2,'25130018','Luis',0),(2,'25130019','Sofia',1),(2,'25130020','Juan',0),(2,'25130021','Ana',1),(2,'25130022','Lucia',0),(2,'25130023','Pedro',0),(2,'25130024','Ana',0),(2,'25130025','Sofia',1),(2,'25130026','Sofia',1),(2,'25130027','Maria',1),(2,'25130028','Luis',1),(2,'25130029','Maria',1),(2,'25130030','Sofia',1),(2,'25130031','Elena',1),(2,'25130032','Maria',1),(2,'25130033','Miguel',1),(2,'25130034','Carlos',1),(2,'25130035','Carlos',0),(2,'25130036','Miguel',0),(2,'25130037','Maria',1),(2,'25130038','Sofia',1),(2,'25130039','Maria',1),(2,'25130040','Sofia',0),(2,'25130041','Maria',1),(2,'25130042','Sofia',1),(2,'25130043','Luis',1),(2,'25130044','Sofia',0),(2,'25130045','Juan',0),(2,'25130046','Luis',1),(2,'25130047','Ana',0),(2,'25130048','Elena',1),(2,'25130049','Carlos',0),(2,'25130050','Maria',1),(2,'NC1000','Pedro',0),(2,'NC1001','Elena',1),(2,'NC1002','Lucia',1),(2,'NC1003','Maria',1),(2,'NC1004','Maria',0),(2,'NC1005','Pedro',0),(2,'NC1006','Ana',0),(2,'NC1007','Elena',0),(2,'NC1008','Sofia',0),(2,'NC1009','Lucia',0),(2,'NC1010','Juan',0),(2,'NC1011','Miguel',0),(2,'NC1012','Maria',0),(2,'NC1013','Elena',0),(2,'NC1014','Carlos',0),(2,'NC1015','Miguel',0),(2,'NC1016','Sofia',0),(2,'NC1017','Ana',0),(2,'NC1018','Maria',0),(2,'NC1019','Sofia',0),(2,'NC1020','Sofia',0),(2,'NC1021','Elena',0),(2,'NC1022','Ana',0),(2,'NC1023','Ana',0),(2,'NC1024','Elena',0),(2,'NC1025','Maria',0),(2,'NC1026','Elena',0),(2,'NC1027','Juan',0),(2,'NC1028','Pedro',0),(2,'NC1029','Maria',0),(2,'NC1030','Ana',0),(2,'NC1031','Luis',0),(2,'NC1032','Juan',0),(2,'NC1033','Pedro',0),(2,'NC1034','Ana',0),(2,'NC1035','Pedro',0),(2,'NC1036','Lucia',0),(2,'NC1037','Lucia',0),(2,'NC1038','Sofia',0),(2,'NC1039','Sofia',0),(2,'NC1040','Elena',0),(2,'NC1041','Carlos',0),(2,'NC1042','Juan',0),(2,'NC1043','Carlos',0),(2,'NC1044','Ana',0),(2,'NC1045','Maria',0),(2,'NC1046','Juan',0),(2,'NC1047','Carlos',0),(2,'NC1048','Carlos',0),(2,'NC1049','Juan',0);
/*!40000 ALTER TABLE `Asistencia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Registros`
--

DROP TABLE IF EXISTS `Registros`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Registros` (
  `No_Registro` int NOT NULL AUTO_INCREMENT,
  `Fecha_Hora` date DEFAULT NULL,
  PRIMARY KEY (`No_Registro`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Registros`
--

LOCK TABLES `Registros` WRITE;
/*!40000 ALTER TABLE `Registros` DISABLE KEYS */;
INSERT INTO `Registros` VALUES (1,'2026-03-27'),(2,'2026-03-27');
/*!40000 ALTER TABLE `Registros` ENABLE KEYS */;
UNLOCK TABLES;
SET @@SESSION.SQL_LOG_BIN = @MYSQLDUMP_TEMP_LOG_BIN;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-03-27  3:10:05
