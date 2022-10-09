-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Φιλοξενητής: 127.0.0.1
-- Χρόνος δημιουργίας: 01 Ιαν 2020 στις 17:22:38
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
-- Βάση δεδομένων: `ergasia6`
--

-- --------------------------------------------------------

--
-- Δομή πίνακα για τον πίνακα `ergasia6`
--

CREATE TABLE `ergasia6` (
  `Username` varchar(15) CHARACTER SET utf8mb4 DEFAULT NULL,
  `Password` varchar(25) CHARACTER SET utf8mb4 DEFAULT NULL,
  `Onoma` varchar(40) CHARACTER SET utf8mb4 DEFAULT NULL,
  `Email` varchar(50) CHARACTER SET utf8mb4 DEFAULT NULL,
  `Age` varchar(15) CHARACTER SET utf8mb4 DEFAULT NULL,
  `Date` date DEFAULT NULL,
  `Adr` varchar(30) CHARACTER SET utf8mb4 DEFAULT NULL,
  `Pay` varchar(30) CHARACTER SET utf8mb4 DEFAULT NULL,
  `Comm` varchar(250) CHARACTER SET utf8mb4 DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Άδειασμα δεδομένων του πίνακα `ergasia6`
--

INSERT INTO `ergasia6` (`Username`, `Password`, `Onoma`, `Email`, `Age`, `Date`, `Adr`, `Pay`, `Comm`) VALUES
('rena', '12345', 'renarena', 'rena@gmail.com', '18', '2012-02-03', 'blah', 'xrewstiki', 'blahblahblah'),
('A', '5463663', 'AB', 'AB@gmail.com', '20 ÎºÎ±Î¹ Ï€Î¬Î', '2011-06-28', 'FAFNAF', 'pistwtiki', 'sjadjjabf'),
('blah', '348928758275', 'blahblah', 'la@gmail.com', 'ÎœÎ­Ï‡ÏÎ¹ 17', '2012-05-18', 'FAFNAF', 'adikatavoli', 'sajfnvaj');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
