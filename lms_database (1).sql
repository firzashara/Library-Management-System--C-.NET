-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 20, 2023 at 05:11 PM
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
-- Database: `lms_database`
--

-- --------------------------------------------------------

--
-- Table structure for table `authors`
--

CREATE TABLE `authors` (
  `id` int(11) NOT NULL,
  `first_name` varchar(100) NOT NULL,
  `last_name` varchar(100) NOT NULL,
  `education` varchar(200) NOT NULL,
  `bio` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `authors`
--

INSERT INTO `authors` (`id`, `first_name`, `last_name`, `education`, `bio`) VALUES
(5, 'William', 'Shakespeare', 'graduated', 'poems,plays,sonnets'),
(1000, 'Mark', 'Twain', 'Graduated', 'Teacher'),
(2000, 'J.K.', 'Rowling', 'Graduated', 'Teacher'),
(12345, 'Jane', 'Austen', 'Author', 'romantic fiction'),
(54347, 'Lewis', 'Carroll', 'Literature', 'Wonderland,Jabberwockey'),
(98789, 'Stephen', 'King', 'graduated', 'American author');

-- --------------------------------------------------------

--
-- Table structure for table `books`
--

CREATE TABLE `books` (
  `id` int(11) NOT NULL,
  `ISBN` varchar(20) NOT NULL,
  `title` text NOT NULL,
  `author_id` int(11) NOT NULL,
  `genre_id` int(11) NOT NULL,
  `quantity` int(11) NOT NULL,
  `price` double NOT NULL,
  `publisher` varchar(250) NOT NULL,
  `date_received` date NOT NULL,
  `description` text NOT NULL,
  `cover` longblob NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `books`
--

INSERT INTO `books` (`id`, `ISBN`, `title`, `author_id`, `genre_id`, `quantity`, `price`, `publisher`, `date_received`, `description`, `cover`) VALUES
(1, 'SA1000', 'A million to one', 0, 0, 1, 0, '', '0000-00-00', 'YYYY-11-DD', ''),
(2, 'SA2000', 'Harry Potter', 0, 0, 1, 0, '', '0000-00-00', 'YYYY-10-DD', ''),
(3, 'SA3000', 'True Love', 0, 0, 2, 0, '', '0000-00-00', 'YYYY-06-DD', ''),
(4, 'SA4000', 'City of orange', 0, 0, 1, 0, '', '0000-00-00', 'YYYY-06-DD', ''),
(5, 'SA5000', 'Pencil ', 0, 0, 1, 0, '', '0000-00-00', 'YYYY-06-DD', ''),
(6, 'SA6000', 'Sin Eater', 0, 0, 1, 0, '', '0000-00-00', 'YYYY-05-DD', ''),
(7, 'SA7000', 'Invisible Man', 0, 0, 1, 0, '', '0000-00-00', 'YYYY-03-DD', ''),
(8, 'SA8000', 'Hypocrite world', 0, 0, 1, 0, '', '0000-00-00', 'YYYY-03-DD', ''),
(9, 'SA9000', 'Atomic habits', 0, 0, 1, 0, '', '0000-00-00', 'YYYY-02-DD', ''),
(10, 'SA101000', 'The help', 0, 0, 1, 0, '', '0000-00-00', 'YYYY-02-DD', '');

-- --------------------------------------------------------

--
-- Table structure for table `genres`
--

CREATE TABLE `genres` (
  `id` int(11) NOT NULL,
  `name` varchar(120) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `genres`
--

INSERT INTO `genres` (`id`, `name`) VALUES
(1, 'programming'),
(2, 'security'),
(3, 'database'),
(4, 'math'),
(5, 'science');

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`username`, `password`) VALUES
('admin', 'admin'),
('Admin', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `members`
--

CREATE TABLE `members` (
  `id` int(11) NOT NULL,
  `first_name` varchar(100) NOT NULL,
  `last_name` varchar(100) NOT NULL,
  `gender` varchar(10) NOT NULL,
  `phone` varchar(25) NOT NULL,
  `email` varchar(200) NOT NULL,
  `picture` longblob NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `members`
--

INSERT INTO `members` (`id`, `first_name`, `last_name`, `gender`, `phone`, `email`, `picture`) VALUES
(1, 'Gim', 'Ketsen', 'Male', '0767839323', 'gim@gmail.com', ''),
(2, 'Katy', 'Ann', 'Female', '0778905643', 'ann@gmail.com', ''),
(3, 'Elizebath', 'William', 'Female', '0773562345', 'william@gmail.com', ''),
(4, 'Roze', 'Tom', 'Female', '0776785679', 'roze@gmail.com', ''),
(5, 'John', 'Willson', 'Male', '0774357653', 'john@gmail.com', ''),
(6, 'Edward ', 'Crane', 'Male', '0775465367', 'edaward@gmail.com', '');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `first_name` varchar(100) NOT NULL,
  `last_name` varchar(100) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(50) NOT NULL,
  `user_type` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `first_name`, `last_name`, `username`, `password`, `user_type`) VALUES
(1, 'Andrew ', 'Tensen ', 'user12', '0000', 'user'),
(2, 'Ann', 'Willson', 'user22', '1111', 'admin'),
(3, 'John ', 'Mate', 'user32', '2222', 'user'),
(4, 'Mike ', 'Fred', 'user42', '3333', 'user');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `authors`
--
ALTER TABLE `authors`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `books`
--
ALTER TABLE `books`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `genres`
--
ALTER TABLE `genres`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `members`
--
ALTER TABLE `members`
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
-- AUTO_INCREMENT for table `authors`
--
ALTER TABLE `authors`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=98790;

--
-- AUTO_INCREMENT for table `genres`
--
ALTER TABLE `genres`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8788;

--
-- AUTO_INCREMENT for table `members`
--
ALTER TABLE `members`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
