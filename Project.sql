-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: project
-- ------------------------------------------------------
-- Server version	5.7.13-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `airplane`
--

DROP TABLE IF EXISTS `airplane`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `airplane` (
  `FlightID` int(11) NOT NULL,
  `capacity` int(11) DEFAULT NULL,
  `Arrival_Location` varchar(255) NOT NULL,
  `Departure_Location` varchar(255) NOT NULL,
  PRIMARY KEY (`FlightID`),
  CONSTRAINT `airplane_ibfk_1` FOREIGN KEY (`FlightID`) REFERENCES `flight` (`FlightID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `flight`
--

DROP TABLE IF EXISTS `flight`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `flight` (
  `FlightID` int(11) NOT NULL AUTO_INCREMENT,
  `AirlineID` varchar(255) NOT NULL,
  `AirlineName` varchar(255) NOT NULL,
  `ticket_price` float DEFAULT NULL,
  PRIMARY KEY (`FlightID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `flight_details`
--

DROP TABLE IF EXISTS `flight_details`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `flight_details` (
  `FlightID` int(11) NOT NULL,
  `arrival_time` datetime DEFAULT NULL,
  `depart_time` datetime DEFAULT NULL,
  PRIMARY KEY (`FlightID`),
  CONSTRAINT `flight_details_ibfk_1` FOREIGN KEY (`FlightID`) REFERENCES `flight` (`FlightID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `passenger_info`
--

DROP TABLE IF EXISTS `passenger_info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `passenger_info` (
  `PassengerID` varchar(255) NOT NULL,
  `FirstName` varchar(255) NOT NULL,
  `SecondName` varchar(255) NOT NULL,
  `Address` varchar(255) NOT NULL,
  `PhoneNum` varchar(255) NOT NULL,
  `Email` varchar(255) DEFAULT NULL,
  `NIC` varchar(255) NOT NULL,
  PRIMARY KEY (`PassengerID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `payment`
--

DROP TABLE IF EXISTS `payment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `payment` (
  `PassengerID` varchar(255) NOT NULL,
  `TicketID` int(11) NOT NULL,
  `PaymentMethod` varchar(255) NOT NULL,
  PRIMARY KEY (`PassengerID`),
  KEY `TicketID` (`TicketID`),
  CONSTRAINT `payment_ibfk_1` FOREIGN KEY (`PassengerID`) REFERENCES `passenger_info` (`PassengerID`),
  CONSTRAINT `payment_ibfk_2` FOREIGN KEY (`TicketID`) REFERENCES `ticket_info` (`TicketID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `route`
--

DROP TABLE IF EXISTS `route`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `route` (
  `FlightID` int(11) NOT NULL,
  `Departure_Location` varchar(255) DEFAULT NULL,
  `Arrival_Location` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`FlightID`),
  CONSTRAINT `route_ibfk_1` FOREIGN KEY (`FlightID`) REFERENCES `flight` (`FlightID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `ticket_info`
--

DROP TABLE IF EXISTS `ticket_info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ticket_info` (
  `TicketID` int(11) NOT NULL,
  `FlightID` int(11) NOT NULL,
  `PassengerID` varchar(255) NOT NULL,
  `Price` float NOT NULL,
  `Departure_Location` varchar(255) DEFAULT NULL,
  `Arrival_Location` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`TicketID`),
  KEY `FlightID` (`FlightID`),
  KEY `PassengerID` (`PassengerID`),
  CONSTRAINT `ticket_info_ibfk_1` FOREIGN KEY (`FlightID`) REFERENCES `flight` (`FlightID`),
  CONSTRAINT `ticket_info_ibfk_2` FOREIGN KEY (`PassengerID`) REFERENCES `passenger_info` (`PassengerID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tickets`
--

DROP TABLE IF EXISTS `tickets`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tickets` (
  `TicketID` int(11) NOT NULL,
  `FlightID` int(11) DEFAULT NULL,
  `AirlineName` varchar(255) DEFAULT NULL,
  `AirlineID` varchar(255) DEFAULT NULL,
  `ticket_availabe` int(11) DEFAULT NULL,
  `ticket_booked` int(11) DEFAULT NULL,
  PRIMARY KEY (`TicketID`),
  KEY `FlightID` (`FlightID`),
  CONSTRAINT `tickets_ibfk_1` FOREIGN KEY (`FlightID`) REFERENCES `flight` (`FlightID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-12-06  7:29:11
