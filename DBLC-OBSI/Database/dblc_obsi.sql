-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 28, 2024 at 07:22 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dblc_obsi`
--

-- --------------------------------------------------------

--
-- Table structure for table `registration`
--

CREATE TABLE `registration` (
  `id` int(11) NOT NULL,
  `District` varchar(20) NOT NULL,
  `Location` varchar(20) NOT NULL,
  `DOR` date NOT NULL,
  `Fullname` varchar(30) NOT NULL,
  `DOB` date NOT NULL,
  `Hometown` varchar(30) NOT NULL,
  `Phone` varchar(10) NOT NULL,
  `Languages` varchar(200) NOT NULL,
  `Hse_address` varchar(20) NOT NULL,
  `Father` varchar(20) NOT NULL,
  `fphone` varchar(10) NOT NULL,
  `Mother` varchar(20) NOT NULL,
  `mphone` varchar(10) NOT NULL,
  `Salvation` text DEFAULT NULL,
  `DateOf_salvation` date NOT NULL,
  `Sanctification` text NOT NULL,
  `DateOf_sanctification` date NOT NULL,
  `HGB` text NOT NULL,
  `DateOf_hgb` date NOT NULL,
  `Orestitution` text NOT NULL,
  `Sproblems` text NOT NULL,
  `School` varchar(20) NOT NULL,
  `Class_Form` varchar(10) NOT NULL,
  `Sch_address` varchar(20) NOT NULL,
  `Boarder_Day` varchar(10) NOT NULL,
  `Hostel` varchar(20) NOT NULL,
  `Room` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `registration`
--

INSERT INTO `registration` (`id`, `District`, `Location`, `DOR`, `Fullname`, `DOB`, `Hometown`, `Phone`, `Languages`, `Hse_address`, `Father`, `fphone`, `Mother`, `mphone`, `Salvation`, `DateOf_salvation`, `Sanctification`, `DateOf_sanctification`, `HGB`, `DateOf_hgb`, `Orestitution`, `Sproblems`, `School`, `Class_Form`, `Sch_address`, `Boarder_Day`, `Hostel`, `Room`) VALUES
(12, 'Koffikurom', 'dgfhjkljkjhgt', '2023-09-09', 'esrdthfyg', '2023-09-09', 'dfsdgfhj', '1561534156', '2', 'aefsgdhbjnk', 'esrtdfgjhk', '53464644', 'esrdtfhgjk', '54643646', 'Yes', '2023-09-09', 'Yes', '2023-09-09', 'Yes', '2023-09-09', 'Yes', 'Yes', 'scgwfvuiaghuiqwhf', '5', 'wgfuygygwqfyga', 'Boarder', 'sbsufuahufhwaifh', '2'),
(13, 'Akaporiso', 'dgfhjkljkjhgt', '2023-09-09', 'esrdthfy', '2023-09-09', 'dfsdgfhj', '1561534156', '2', 'aefsgdhbjnk', 'esrtdfgjhk', '53464644', 'esrdtfhgjk', '54643646', 'Yes', '2023-09-09', 'Yes', '2023-09-09', 'Yes', '2023-09-09', 'Yes', 'Yes', 'scgwfvuiaghuiqwhf', '5', 'wgfuygygwqfyga', 'Boarder', 'sbsufuahufhwaifh', '2'),
(14, 'Estate', 'dgfhjkljkjhgt', '2023-09-09', 'esrdthfy', '2023-09-09', 'dfsdgfhj', '1561534156', '', 'aefsgdhbjnk', 'esrtdfgjhk', '53464644', 'esrdtfhgjk', '54643646', 'Yes', '2023-09-09', 'Yes', '2023-09-09', 'Yes', '2023-09-09', 'Yes', 'Yes', 'scgwfvuiaghuiqwhf', '5', 'wgfuygygwqfyga', 'Boarder', 'sbsufuahufhwaifh', '2');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `full_name` varchar(20) NOT NULL,
  `username` varchar(10) NOT NULL,
  `password` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `full_name`, `username`, `password`) VALUES
(7, 'Manasseh Minewuli', 'manasseh', 'password'),
(8, 'minewuli manasseh', 'cyb0r9', 'p@55w0rd.!'),
(9, 'minewuli manasseh', 'cyb0r9', 'p@55w0rd.!'),
(10, 'minewuli manasseh', 'disclaimer', 'password'),
(11, 'minewuli manasseh', 'disclaimer', 'password');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `registration`
--
ALTER TABLE `registration`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `registration`
--
ALTER TABLE `registration`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
