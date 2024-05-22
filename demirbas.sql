-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 22 May 2024, 19:25:49
-- Sunucu sürümü: 10.4.32-MariaDB
-- PHP Sürümü: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `demirbas`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `donanim`
--

CREATE TABLE `donanim` (
  `Ad` varchar(255) NOT NULL,
  `Soyad` varchar(255) NOT NULL,
  `SicilNo` int(11) NOT NULL,
  `Ünvan` varchar(255) NOT NULL,
  `Bolum` varchar(255) NOT NULL,
  `EPosta` varchar(255) NOT NULL,
  `odaNumarasi` int(11) NOT NULL,
  `iseBaslamaTarihi` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `donanim`
--

INSERT INTO `donanim` (`Ad`, `Soyad`, `SicilNo`, `Ünvan`, `Bolum`, `EPosta`, `odaNumarasi`, `iseBaslamaTarihi`) VALUES
('Taha', 'Demir', 123, 'Öğrenci', 'Mühendis', 'taha@gmail.com', 1, 2023);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `giris`
--

CREATE TABLE `giris` (
  `kullanici` varchar(255) NOT NULL,
  `sifre` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `giris`
--

INSERT INTO `giris` (`kullanici`, `sifre`) VALUES
('taha', 1234);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kasabilgiler`
--

CREATE TABLE `kasabilgiler` (
  `isletimsistemi` varchar(255) NOT NULL,
  `ekran` varchar(255) NOT NULL,
  `ram` varchar(255) NOT NULL,
  `islemci` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `kasabilgiler`
--

INSERT INTO `kasabilgiler` (`isletimsistemi`, `ekran`, `ram`, `islemci`) VALUES
('windows', 'nvdia', '16', 'intel');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `urunler`
--

CREATE TABLE `urunler` (
  `marka` varchar(255) NOT NULL,
  `model` varchar(255) NOT NULL,
  `tarih` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `urunler`
--

INSERT INTO `urunler` (`marka`, `model`, `tarih`) VALUES
('hp', 'victus', '2023');


--
-- Üstveri
--
USE `phpmyadmin`;

--
-- donanim tablosu için üstveri
--

--
-- giris tablosu için üstveri
--

--
-- kasabilgiler tablosu için üstveri
--

--
-- urunler tablosu için üstveri
--

--
-- demirbas veritabanı için üstveri
--
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
