/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

CREATE DATABASE IF NOT EXISTS `dance_scheduler_system` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;
USE `dance_scheduler_system`;

CREATE TABLE IF NOT EXISTS `booking` (
  `Booking ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Phone Number` varchar(50) NOT NULL,
  `Class` int(11) NOT NULL,
  `Date Booked` date NOT NULL DEFAULT curdate(),
  PRIMARY KEY (`Booking ID`),
  KEY `FK__schedule` (`Class`),
  CONSTRAINT `FK__schedule` FOREIGN KEY (`Class`) REFERENCES `schedule` (`Schedule ID`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;


CREATE TABLE IF NOT EXISTS `schedule` (
  `Schedule ID` int(11) NOT NULL AUTO_INCREMENT,
  `Day` date NOT NULL,
  `Type` varchar(50) NOT NULL,
  `Time` varchar(50) NOT NULL,
  `Instructor` varchar(50) DEFAULT 'TBA',
  `Slots` int(11) DEFAULT 30,
  PRIMARY KEY (`Schedule ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `schedule` (`Schedule ID`, `Day`, `Type`, `Time`, `Instructor`, `Slots`) VALUES
	(1, '2025-05-06', 'Hip Hop', '1:00 PM - 2:30 PM', 'Nicole', 30),
	(2, '2025-05-06', 'Sexy Class', '3:30 PM - 4:00 PM', 'Shane', 30),
	(3, '2025-05-08', 'Open Class', '1:00 PM - 2:00 PM', 'Jhamir', 30),
	(4, '2025-05-08', 'Choreography', '2:30 PM - 3:30 PM', 'Shanley', 30);

CREATE TABLE IF NOT EXISTS `users` (
  `User ID` int(11) NOT NULL AUTO_INCREMENT,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `Permission` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`User ID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `users` (`User ID`, `Username`, `Password`, `Permission`) VALUES
	(1, 'admin', 'admin', 'admin');

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
