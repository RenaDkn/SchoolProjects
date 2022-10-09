-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Φιλοξενητής: 127.0.0.1
-- Χρόνος δημιουργίας: 05 Ιαν 2020 στις 15:09:05
-- Έκδοση διακομιστή: 10.4.10-MariaDB
-- Έκδοση PHP: 7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Βάση δεδομένων: `geniki`
--

-- --------------------------------------------------------

--
-- Δομή πίνακα για τον πίνακα `geniki`
--

CREATE TABLE `geniki` (
  `Onoma` varchar(40) NOT NULL,
  `Email` varchar(40) NOT NULL,
  `Size` varchar(3) NOT NULL,
  `Adr` varchar(30) NOT NULL,
  `Pay` varchar(20) NOT NULL,
  `Comm` varchar(50) NOT NULL,
  `Merch1` varchar(10) NOT NULL DEFAULT 'Red merch',
  `Pos1` int(1) NOT NULL,
  `Merch2` varchar(15) NOT NULL DEFAULT 'Green merch',
  `Pos2` int(1) NOT NULL,
  `Merch3` varchar(20) NOT NULL DEFAULT 'Grey hoodie merch',
  `Pos3` int(1) NOT NULL,
  `Merch4` varchar(20) NOT NULL DEFAULT 'Green hoodie merch',
  `Pos4` int(1) NOT NULL,
  `Timi` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
