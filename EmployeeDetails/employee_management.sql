-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jun 14, 2018 at 05:09 PM
-- Server version: 10.1.10-MariaDB
-- PHP Version: 7.0.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `employee_management`
--

-- --------------------------------------------------------

--
-- Table structure for table `employees`
--

CREATE TABLE `employees` (
  `ID` int(11) NOT NULL,
  `first_name` varchar(50) DEFAULT NULL,
  `last_name` varchar(50) DEFAULT NULL,
  `age` int(11) DEFAULT NULL,
  `gender` varchar(10) DEFAULT NULL,
  `mobile` varchar(20) DEFAULT NULL,
  `email` varchar(30) DEFAULT NULL,
  `address1` varchar(30) DEFAULT NULL,
  `address2` varchar(30) DEFAULT NULL,
  `address3` varchar(30) DEFAULT NULL,
  `department` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employees`
--

INSERT INTO `employees` (`ID`, `first_name`, `last_name`, `age`, `gender`, `mobile`, `email`, `address1`, `address2`, `address3`, `department`) VALUES
(35, 'Sidath', 'Asiri', 24, 'Male', '071451458', 'sidathasiri@gmail.com', '', '', '', ''),
(37, 'Ushani', 'Amarasekara', 24, 'Female', '34324', 'ushani@gmail.com', '28/3', 'dote', 'thawa dote', 'Management'),
(38, 'ishara', 'devinda', 25, 'Male', '', '', '', '', '', ''),
(39, 'akila', 'bandara', 24, 'Male', '2342343', '', '', '', '', 'Transport'),
(40, 'sarasi', 'prera', 33, 'Female', '', '', '', '', '', ''),
(41, 'uththara', 'ranasinghe', 78, 'Female', '', '', '', '', '', ''),
(42, 'umayanga', 'sahan', 0, 'Male', '4534543', '', '', '', '', '');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `employees`
--
ALTER TABLE `employees`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `employees`
--
ALTER TABLE `employees`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=45;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
