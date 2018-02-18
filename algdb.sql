-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 18, 2018 at 04:06 AM
-- Server version: 10.1.21-MariaDB
-- PHP Version: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `algdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `car_information`
--

CREATE TABLE `car_information` (
  `car_info_ID` int(11) NOT NULL,
  `color` int(11) NOT NULL,
  `brand` int(11) NOT NULL,
  `model` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `category`
--

CREATE TABLE `category` (
  `category_ID` int(11) NOT NULL,
  `category_name` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `category`
--

INSERT INTO `category` (`category_ID`, `category_name`) VALUES
(1, 'Oil'),
(2, 'nutsy'),
(3, 'bolts'),
(4, 'paper'),
(5, 'Gasoline');

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `emp_ID` int(11) NOT NULL,
  `emp_fName` varchar(25) NOT NULL,
  `emp_gName` varchar(25) NOT NULL,
  `emp_mInitial` varchar(10) NOT NULL,
  `emp_position` varchar(25) NOT NULL,
  `emp_address` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`emp_ID`, `emp_fName`, `emp_gName`, `emp_mInitial`, `emp_position`, `emp_address`) VALUES
(1, 'Paganini', 'Niccolo', 'G.', 'Violinist', 'Italya'),
(2, 'Vivaldi', 'Antonio', 'G', 'Violinist', 'Italya'),
(3, 'Bach', 'J.S', 'e', 'Musician', 'Italya'),
(5, 'asdad', 'asd', 'asda', 'asd', 'assd');

-- --------------------------------------------------------

--
-- Table structure for table `emp_service_trans_rela`
--

CREATE TABLE `emp_service_trans_rela` (
  `transac_ID` int(11) NOT NULL,
  `emp_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `product_ID` varchar(50) NOT NULL,
  `product_name` varchar(255) NOT NULL,
  `product_desc` varchar(255) NOT NULL,
  `product_price` double NOT NULL,
  `product_addedprice` int(11) NOT NULL,
  `product_sellingprice` int(11) NOT NULL,
  `category_ID` int(11) NOT NULL,
  `oil_type` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`product_ID`, `product_name`, `product_desc`, `product_price`, `product_addedprice`, `product_sellingprice`, `category_ID`, `oil_type`) VALUES
('112', 'sdsdffds', 'ssdsdfsdf', 40, 13, 53, 1, '4-Wheel'),
('123212232121', '1231', '123', 38, 12, 50, 1, '4-Wheel'),
('141414141414', 'lorem', 'ipsum', 9, 9, 18, 2, '4-Wheel'),
('321', 'GOLD', 'SILVER', 0, 0, 0, 1, '4-Wheel'),
('4800047865169', 'Mega Gold', 'Gasoline', 49, 30, 79, 5, '4-Wheel'),
('4800555164037', '2T', 'oil', 35, 7, 42, 1, '4-Wheel'),
('4800555191088', 'Ultron Extra Galon', 'Gasoline', 50, 20, 70, 5, '4-Wheel'),
('q212', '1212212', '212122212', 1221, 12223, 13444, 1, '4-Wheel');

-- --------------------------------------------------------

--
-- Table structure for table `product_price`
--

CREATE TABLE `product_price` (
  `product_price_ID` int(11) NOT NULL,
  `product_ID` varchar(50) NOT NULL,
  `product_price` double NOT NULL,
  `discount` int(11) NOT NULL,
  `discounted_price` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `product_price`
--

INSERT INTO `product_price` (`product_price_ID`, `product_ID`, `product_price`, `discount`, `discounted_price`) VALUES
(1, '112', 11, 0, 11),
(3, '123212232121', 11, 0, 11),
(4, '123212232121', 12, 0, 12);

-- --------------------------------------------------------

--
-- Table structure for table `prod_trans_rela`
--

CREATE TABLE `prod_trans_rela` (
  `prod_transac_rela_ID` int(11) NOT NULL,
  `transac_ID` int(11) NOT NULL,
  `product_ID` int(11) NOT NULL,
  `quantity` int(11) NOT NULL,
  `total` int(11) NOT NULL,
  `date_bought` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `service`
--

CREATE TABLE `service` (
  `service_ID` int(11) NOT NULL,
  `service_name` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `service`
--

INSERT INTO `service` (`service_ID`, `service_name`) VALUES
(4, 'Carwash');

-- --------------------------------------------------------

--
-- Table structure for table `service_personnel`
--

CREATE TABLE `service_personnel` (
  `service_trans_ID` int(11) NOT NULL,
  `emp_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `service_price`
--

CREATE TABLE `service_price` (
  `service_price_ID` int(11) NOT NULL,
  `service_ID` int(11) NOT NULL,
  `vehicletype_ID` int(11) NOT NULL,
  `service_fee` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `service_price`
--

INSERT INTO `service_price` (`service_price_ID`, `service_ID`, `vehicletype_ID`, `service_fee`) VALUES
(6, 4, 6, 160),
(7, 4, 1, 170),
(8, 4, 3, 190),
(9, 4, 4, 180),
(10, 4, 5, 200);

-- --------------------------------------------------------

--
-- Table structure for table `serv_trans_rela`
--

CREATE TABLE `serv_trans_rela` (
  `service_trans_ID` int(11) NOT NULL,
  `transac_ID` int(11) NOT NULL,
  `date_serviced` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `service_price_ID` int(11) NOT NULL,
  `car_info_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

-- --------------------------------------------------------

--
-- Table structure for table `stock`
--

CREATE TABLE `stock` (
  `stock_ID` int(11) NOT NULL,
  `product_ID` varchar(50) NOT NULL,
  `supplier_ID` int(11) NOT NULL,
  `received_date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `total_stocks` int(11) NOT NULL,
  `remaining_stocks` int(11) NOT NULL,
  `supplier_price` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `stock`
--

INSERT INTO `stock` (`stock_ID`, `product_ID`, `supplier_ID`, `received_date`, `total_stocks`, `remaining_stocks`, `supplier_price`) VALUES
(12121, '141414141414', 1, '2018-02-13 05:07:36', 5, 0, 0),
(21231, '112', 1, '2018-02-16 04:57:47', 10, 10, 163),
(111111, '141414141414', 1, '2018-02-13 05:06:07', 6, 0, 0),
(1112447, '4800047865169', 1, '2018-02-13 04:27:52', 10, 10, 0),
(1112448, '4800555164037', 1, '2018-02-14 17:27:15', 14, 14, 0),
(1112449, '4800555191088', 1, '2018-02-16 04:59:10', 30, 10, 15);

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE `supplier` (
  `supplier_ID` int(11) NOT NULL,
  `supplier_name` varchar(50) NOT NULL,
  `supplier_contact` varchar(50) NOT NULL,
  `supplier_address` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`supplier_ID`, `supplier_name`, `supplier_contact`, `supplier_address`) VALUES
(1, 'Supplier One', 'd', 'd');

-- --------------------------------------------------------

--
-- Table structure for table `transaction`
--

CREATE TABLE `transaction` (
  `transac_ID` int(11) NOT NULL,
  `date_transact` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `userID` int(11) NOT NULL,
  `fName` varchar(20) NOT NULL,
  `gName` varchar(25) NOT NULL,
  `mInitial` varchar(1) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `dateRegistered` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `user_type` varchar(20) NOT NULL,
  `login_status` tinyint(1) NOT NULL,
  `user_address` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`userID`, `fName`, `gName`, `mInitial`, `username`, `password`, `dateRegistered`, `user_type`, `login_status`, `user_address`) VALUES
(1, 'Mozart', 'Wolfgang', 'A', '2', '2', '2018-02-16 16:16:15', 'cashier', 0, 'Austria'),
(2, 'Beethoven', 'Ludwig', 'V', '3', '3', '2018-02-17 15:05:00', 'encoder', 0, 'Germany'),
(3, 'Saint-Saens', 'Camille', '', '1', '1', '2018-02-16 12:47:51', 'admin', 0, ''),
(5, 'Gregorio', 'Karen', 'A', 'kaye', 'kaye02', '2018-02-07 06:07:26', 'admin', 0, 'Tumaga, Zamboanga City');

-- --------------------------------------------------------

--
-- Table structure for table `vehicle_type`
--

CREATE TABLE `vehicle_type` (
  `vehicletype_ID` int(11) NOT NULL,
  `vehicle_type` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `vehicle_type`
--

INSERT INTO `vehicle_type` (`vehicletype_ID`, `vehicle_type`) VALUES
(1, 'SEDAN'),
(3, 'SUV'),
(4, 'MID SUV'),
(5, 'VAN'),
(6, 'COMPACT CAR');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`category_ID`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`emp_ID`);

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`product_ID`);

--
-- Indexes for table `product_price`
--
ALTER TABLE `product_price`
  ADD PRIMARY KEY (`product_price_ID`),
  ADD KEY `product_ID` (`product_ID`);

--
-- Indexes for table `prod_trans_rela`
--
ALTER TABLE `prod_trans_rela`
  ADD PRIMARY KEY (`prod_transac_rela_ID`);

--
-- Indexes for table `service`
--
ALTER TABLE `service`
  ADD PRIMARY KEY (`service_ID`);

--
-- Indexes for table `service_price`
--
ALTER TABLE `service_price`
  ADD PRIMARY KEY (`service_price_ID`),
  ADD KEY `service_ID` (`service_ID`),
  ADD KEY `vehicletype_ID` (`vehicletype_ID`);

--
-- Indexes for table `stock`
--
ALTER TABLE `stock`
  ADD PRIMARY KEY (`stock_ID`),
  ADD KEY `product_ID` (`product_ID`),
  ADD KEY `supplier_ID` (`supplier_ID`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`supplier_ID`);

--
-- Indexes for table `transaction`
--
ALTER TABLE `transaction`
  ADD PRIMARY KEY (`transac_ID`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`userID`);

--
-- Indexes for table `vehicle_type`
--
ALTER TABLE `vehicle_type`
  ADD PRIMARY KEY (`vehicletype_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `category`
--
ALTER TABLE `category`
  MODIFY `category_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `emp_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `product_price`
--
ALTER TABLE `product_price`
  MODIFY `product_price_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `prod_trans_rela`
--
ALTER TABLE `prod_trans_rela`
  MODIFY `prod_transac_rela_ID` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `service`
--
ALTER TABLE `service`
  MODIFY `service_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `service_price`
--
ALTER TABLE `service_price`
  MODIFY `service_price_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT for table `stock`
--
ALTER TABLE `stock`
  MODIFY `stock_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1112451;
--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `userID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `vehicle_type`
--
ALTER TABLE `vehicle_type`
  MODIFY `vehicletype_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `product_price`
--
ALTER TABLE `product_price`
  ADD CONSTRAINT `product_price_ibfk_1` FOREIGN KEY (`product_ID`) REFERENCES `products` (`product_ID`);

--
-- Constraints for table `service_price`
--
ALTER TABLE `service_price`
  ADD CONSTRAINT `service_price_ibfk_1` FOREIGN KEY (`service_ID`) REFERENCES `service` (`service_ID`),
  ADD CONSTRAINT `service_price_ibfk_2` FOREIGN KEY (`vehicletype_ID`) REFERENCES `vehicle_type` (`vehicletype_ID`);

--
-- Constraints for table `stock`
--
ALTER TABLE `stock`
  ADD CONSTRAINT `stock_ibfk_1` FOREIGN KEY (`product_ID`) REFERENCES `products` (`product_ID`),
  ADD CONSTRAINT `stock_ibfk_2` FOREIGN KEY (`supplier_ID`) REFERENCES `supplier` (`supplier_ID`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
