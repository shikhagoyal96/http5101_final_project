-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Dec 03, 2019 at 09:52 PM
-- Server version: 5.7.24-log
-- PHP Version: 7.2.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `seasondatabase`
--

-- --------------------------------------------------------

--
-- Table structure for table `season`
--

CREATE TABLE `season` (
  `seasonid` int(20) UNSIGNED NOT NULL COMMENT 'PrimaryKey',
  `seasontitle` varchar(255) COLLATE latin1_bin DEFAULT NULL,
  `seasonbody` mediumtext COLLATE latin1_bin
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_bin;

--
-- Dumping data for table `season`
--

INSERT INTO `season` (`seasonid`, `seasontitle`, `seasonbody`) VALUES
(1, 'Summer', 'Summer is the hottest of the four temperate seasons, falling after spring and before autumn. At the summer solstice, the days are longest and the nights are shortest, with day length decreasing as the season progresses after the solstice. '),
(2, 'Fall', 'Autumn, also known as fall in North American English, is one of the four temperate seasons. Autumn marks the transition from summer to winter, in September or March, when the duration of daylight becomes noticeably shorter and the temperature cools considerably.'),
(3, 'Winters', 'Winter is the coldest season of the year in polar and temperate zones (winter does not occur in most of the tropical zone). It occurs after autumn and before spring in each year. Winter is caused by the axis of the Earth in that hemisphere being oriented away from the Sun. Different cultures define different dates as the start of winter, and some use a definition based on weather. When it is winter in the Northern Hemisphere, it is summer in the Southern Hemisphere, and vice versa.');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `season`
--
ALTER TABLE `season`
  ADD PRIMARY KEY (`seasonid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `season`
--
ALTER TABLE `season`
  MODIFY `seasonid` int(20) UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'PrimaryKey', AUTO_INCREMENT=12;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
