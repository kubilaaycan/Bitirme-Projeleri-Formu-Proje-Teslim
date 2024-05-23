-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 23 May 2024, 17:46:04
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
-- Veritabanı: `bitirme_projeleri_formu`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `akademisyenler`
--

CREATE TABLE `akademisyenler` (
  `adi` varchar(255) NOT NULL,
  `soyadi` varchar(255) NOT NULL,
  `numarasi` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `akademisyenler`
--

INSERT INTO `akademisyenler` (`adi`, `soyadi`, `numarasi`) VALUES
('Dr. Ögr. Üyesi Ahmet Turgut', 'Tuncer', 1),
('Öğr. Gör. Tuğba', 'Altındağ', 2),
('Öğr. Gör. Emre Öner', 'Tartan', 3),
('Ögr. Gör. Tenin', 'Çolak', 4),
('Araş. Gör. Tuğçe ', 'Kantar Uğur', 5),
('Öğr. Gör. Ramazan', 'Tekinarslan', 6),
('Öğr. Gör. Ali', 'Can', 7),
('Öğr. Gör. Arif', 'Koçoğlu', 8),
('Öğr. Gör Murat', 'Türkmen', 9),
('Ögr. Gör. Nazlıcan', 'Çakmak', 10);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `bpf`
--

CREATE TABLE `bpf` (
  `ID` varchar(255) NOT NULL,
  `ProjeAdi` varchar(255) NOT NULL,
  `ProjeDanismani` varchar(255) NOT NULL,
  `1Jüri` varchar(255) NOT NULL,
  `2Jüri` varchar(255) NOT NULL,
  `3Jüri` varchar(255) NOT NULL,
  `4Jüri` varchar(255) NOT NULL,
  `ProjeSüresi` varchar(255) NOT NULL,
  `ProjeYariyili` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `bpf`
--

INSERT INTO `bpf` (`ID`, `ProjeAdi`, `ProjeDanismani`, `1Jüri`, `2Jüri`, `3Jüri`, `4Jüri`, `ProjeSüresi`, `ProjeYariyili`) VALUES
('22295059', 'BPF', 'Dr. Ögr. Üyesi Ahmet Turgut Tuncer', 'Öğr. Gör. Tuğba Altındağ', 'Öğr. Gör. Emre Öner Tartan', 'Öğr. Gör. Ramazan Tekinarslan', 'Ögr. Gör. Nazlıcan Çakmak', '4', '1'),
('22295058', 'BPF_2', 'Ögr. Gör. Tenin Çolak', 'Ögr. Gör. Nazlıcan Çakmak', 'Araş. Gör. Tuğçe Kantar Uğur', 'Öğr. Gör. Tuğba Altındağ', 'Öğr. Gör. Ali Can', '2', '2');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kullanicilar`
--

CREATE TABLE `kullanicilar` (
  `kullanici_adi` varchar(255) CHARACTER SET utf8 COLLATE utf8_turkish_ci NOT NULL,
  `sifre` varchar(255) CHARACTER SET utf8 COLLATE utf8_turkish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `kullanicilar`
--

INSERT INTO `kullanicilar` (`kullanici_adi`, `sifre`) VALUES
('tuğba altındağ', '123');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `ögrenciler`
--

CREATE TABLE `ögrenciler` (
  `adi` varchar(255) NOT NULL,
  `soyadi` varchar(255) NOT NULL,
  `numarasi` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `ögrenciler`
--

INSERT INTO `ögrenciler` (`adi`, `soyadi`, `numarasi`) VALUES
('Kubilay', 'Can', '22295059'),
('Taha', 'Demir', '22295058'),
('Deniz ', 'Güldalı', '22295057'),
('Sergen', 'Taş', '22295056'),
('Volkan', 'Şahin', '22295055');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `kullanicilar`
--
ALTER TABLE `kullanicilar`
  ADD PRIMARY KEY (`kullanici_adi`) USING BTREE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
