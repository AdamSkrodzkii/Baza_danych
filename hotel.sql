-- phpMyAdmin SQL Dump
-- version 3.5.5
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Czas wygenerowania: 16 Sie 2019, 20:42
-- Wersja serwera: 5.5.21-log
-- Wersja PHP: 5.3.20

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Baza danych: `hotel`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `atrakcje`
--

CREATE TABLE IF NOT EXISTS `atrakcje` (
  `ID_atrakcji` int(11) NOT NULL,
  `ID_hotelu` int(11) NOT NULL,
  `ID_opiekuna` int(11) NOT NULL,
  `ID_typu` int(11) NOT NULL,
  PRIMARY KEY (`ID_atrakcji`),
  KEY `ID_typu` (`ID_typu`),
  KEY `ID_hotelu` (`ID_hotelu`),
  KEY `ID_opiekuna` (`ID_opiekuna`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `cena_pokoju`
--

CREATE TABLE IF NOT EXISTS `cena_pokoju` (
  `ID_ceny` int(11) NOT NULL AUTO_INCREMENT,
  `ID_typu` int(11) NOT NULL,
  `id_sezonu` int(11) NOT NULL,
  PRIMARY KEY (`ID_ceny`),
  KEY `ID_typu` (`ID_typu`),
  KEY `id_sezonu` (`id_sezonu`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `cena_sali`
--

CREATE TABLE IF NOT EXISTS `cena_sali` (
  `ID_Ceny` int(11) NOT NULL AUTO_INCREMENT,
  `ID_typu` int(11) NOT NULL,
  `ID_sezonu` int(11) NOT NULL,
  PRIMARY KEY (`ID_Ceny`),
  KEY `ID_typu` (`ID_typu`),
  KEY `ID_sezonu` (`ID_sezonu`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `hotel`
--

CREATE TABLE IF NOT EXISTS `hotel` (
  `ID_hotelu` int(11) NOT NULL AUTO_INCREMENT,
  `Nazwa` text COLLATE utf8_polish_ci NOT NULL,
  `Miasto` text COLLATE utf8_polish_ci NOT NULL,
  `Ulica` text COLLATE utf8_polish_ci NOT NULL,
  `Kod_pocztowy` text COLLATE utf8_polish_ci NOT NULL,
  PRIMARY KEY (`ID_hotelu`),
  KEY `ID_hotelu` (`ID_hotelu`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci AUTO_INCREMENT=2 ;

--
-- Zrzut danych tabeli `hotel`
--

INSERT INTO `hotel` (`ID_hotelu`, `Nazwa`, `Miasto`, `Ulica`, `Kod_pocztowy`) VALUES
(1, 'a', 'a', 'a', 'a');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `kajaki`
--

CREATE TABLE IF NOT EXISTS `kajaki` (
  `ID_atrakcji` int(11) NOT NULL,
  `Wielkość` int(11) NOT NULL,
  KEY `ID_atrakcji` (`ID_atrakcji`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `klient`
--

CREATE TABLE IF NOT EXISTS `klient` (
  `ID_Klient` int(11) NOT NULL AUTO_INCREMENT,
  `Nazwa_organizacji` text COLLATE utf8_polish_ci NOT NULL,
  PRIMARY KEY (`ID_Klient`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `konie`
--

CREATE TABLE IF NOT EXISTS `konie` (
  `ID_atrakcji` int(11) NOT NULL,
  `Rasa` text COLLATE utf8_polish_ci NOT NULL,
  KEY `ID_atrakcji` (`ID_atrakcji`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `menedżera`
--

CREATE TABLE IF NOT EXISTS `menedżera` (
  `ID_menedżera` int(11) NOT NULL AUTO_INCREMENT,
  `ID_hotelu` int(11) NOT NULL,
  `Nazwisko` text COLLATE utf8_polish_ci NOT NULL,
  `Imię` text COLLATE utf8_polish_ci NOT NULL,
  `Ulica` text COLLATE utf8_polish_ci NOT NULL,
  `Miasto` text COLLATE utf8_polish_ci NOT NULL,
  `Kod_pocztowy` text COLLATE utf8_polish_ci NOT NULL,
  PRIMARY KEY (`ID_menedżera`),
  KEY `ID_hotelu` (`ID_hotelu`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `opiekun`
--

CREATE TABLE IF NOT EXISTS `opiekun` (
  `ID_opiekuna` int(11) NOT NULL AUTO_INCREMENT,
  `ID_hotelu` int(11) NOT NULL,
  `Imię` text COLLATE utf8_polish_ci NOT NULL,
  `Nazwisko` text COLLATE utf8_polish_ci NOT NULL,
  `Specjalizacja` text COLLATE utf8_polish_ci NOT NULL,
  `Ulica` text COLLATE utf8_polish_ci NOT NULL,
  `Miasto` text COLLATE utf8_polish_ci NOT NULL,
  `Kod_pocztowy` text COLLATE utf8_polish_ci NOT NULL,
  PRIMARY KEY (`ID_opiekuna`),
  KEY `ID_hotelu` (`ID_hotelu`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci AUTO_INCREMENT=2 ;

--
-- Zrzut danych tabeli `opiekun`
--

INSERT INTO `opiekun` (`ID_opiekuna`, `ID_hotelu`, `Imię`, `Nazwisko`, `Specjalizacja`, `Ulica`, `Miasto`, `Kod_pocztowy`) VALUES
(1, 1, 'Ania', 'Niewolnik', 'Jazda Konna', 'konnej', 'Warszawa', '07-908');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `osoba_prywatna`
--

CREATE TABLE IF NOT EXISTS `osoba_prywatna` (
  `ID_osoby` int(11) NOT NULL AUTO_INCREMENT,
  `ID_klienta` int(11) NOT NULL,
  `Numer_pokoju` int(11) NOT NULL,
  `Imię` text COLLATE utf8_polish_ci NOT NULL,
  `Nazwisko` text COLLATE utf8_polish_ci NOT NULL,
  `Ulica` text COLLATE utf8_polish_ci NOT NULL,
  `Miasto` text COLLATE utf8_polish_ci NOT NULL,
  `Kod_pocztowa` text COLLATE utf8_polish_ci NOT NULL,
  PRIMARY KEY (`ID_osoby`),
  KEY `ID_klienta` (`ID_klienta`),
  KEY `Numer_pokoju` (`Numer_pokoju`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `pokój`
--

CREATE TABLE IF NOT EXISTS `pokój` (
  `Numer_pokoju` int(11) NOT NULL,
  `ID_hotelu` int(11) NOT NULL,
  `ID_typu` int(11) NOT NULL,
  PRIMARY KEY (`Numer_pokoju`),
  KEY `ID_hotelu` (`ID_hotelu`),
  KEY `ID_typu` (`ID_typu`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `rezerwacja`
--

CREATE TABLE IF NOT EXISTS `rezerwacja` (
  `Numer_rezerwacji` int(11) NOT NULL AUTO_INCREMENT,
  `ID_menedżera` int(11) NOT NULL,
  `ID_klienta` int(11) NOT NULL,
  `ID_osoby` int(11) NOT NULL,
  `Od_kiedy` date NOT NULL,
  `do_kiedy` date NOT NULL,
  `Ile_osob` int(11) NOT NULL,
  `Cena` float NOT NULL,
  `Rabat` int(11) NOT NULL,
  PRIMARY KEY (`Numer_rezerwacji`),
  KEY `ID_menedżera` (`ID_menedżera`),
  KEY `ID_klienta` (`ID_klienta`),
  KEY `ID_osoby` (`ID_osoby`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `rezerwacja_atrakcje`
--

CREATE TABLE IF NOT EXISTS `rezerwacja_atrakcje` (
  `Numer_rezerwacji` int(11) NOT NULL,
  `ID_atrakcji` int(11) NOT NULL,
  PRIMARY KEY (`Numer_rezerwacji`,`ID_atrakcji`),
  KEY `Numer_rezerwacji` (`Numer_rezerwacji`),
  KEY `ID_atrakcji` (`ID_atrakcji`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `rezerwacja_pokój`
--

CREATE TABLE IF NOT EXISTS `rezerwacja_pokój` (
  `Numer_rezerwacji` int(11) NOT NULL,
  `Numer_pokoju` int(11) NOT NULL,
  PRIMARY KEY (`Numer_rezerwacji`,`Numer_pokoju`),
  KEY `Numer_rezerwacji` (`Numer_rezerwacji`),
  KEY `Numer_pokoju` (`Numer_pokoju`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `rezerwacja_sala`
--

CREATE TABLE IF NOT EXISTS `rezerwacja_sala` (
  `Numer_rezerwacji` int(11) NOT NULL,
  `Numer_sali` int(11) NOT NULL,
  PRIMARY KEY (`Numer_rezerwacji`,`Numer_sali`),
  KEY `Numer_rezerwacji` (`Numer_rezerwacji`),
  KEY `Numer_sali` (`Numer_sali`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `rowery`
--

CREATE TABLE IF NOT EXISTS `rowery` (
  `ID_atrakcji` int(11) NOT NULL,
  `Model` text COLLATE utf8_polish_ci NOT NULL,
  KEY `ID_atrakcji` (`ID_atrakcji`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `sala`
--

CREATE TABLE IF NOT EXISTS `sala` (
  `Numer_sali` int(11) NOT NULL,
  `ID_hotelu` int(11) NOT NULL,
  `ID_typu` int(11) NOT NULL,
  PRIMARY KEY (`Numer_sali`),
  KEY `ID_hotelu` (`ID_hotelu`),
  KEY `ID_typu` (`ID_typu`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `sezon`
--

CREATE TABLE IF NOT EXISTS `sezon` (
  `ID_sezonu` int(11) NOT NULL AUTO_INCREMENT,
  `Od_kiedy` date NOT NULL,
  `Do_kiedy` date NOT NULL,
  `Rodzaj_sezonu` text COLLATE utf8_polish_ci NOT NULL,
  PRIMARY KEY (`ID_sezonu`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `typ_atrakcji`
--

CREATE TABLE IF NOT EXISTS `typ_atrakcji` (
  `ID_typu` int(11) NOT NULL AUTO_INCREMENT,
  `Cena` float NOT NULL,
  `Nazwa_atrakcji` text COLLATE utf8_polish_ci NOT NULL,
  PRIMARY KEY (`ID_typu`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `typ_pokoju`
--

CREATE TABLE IF NOT EXISTS `typ_pokoju` (
  `ID_typu` int(11) NOT NULL AUTO_INCREMENT,
  `ID_widoku` int(11) NOT NULL,
  `Ile_osob` int(11) NOT NULL,
  `Dodatkowe_uslugi` text COLLATE utf8_polish_ci NOT NULL,
  `Cena_bazowa` float NOT NULL,
  PRIMARY KEY (`ID_typu`),
  KEY `ID_widoku` (`ID_widoku`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `typ_sali`
--

CREATE TABLE IF NOT EXISTS `typ_sali` (
  `ID_typu` int(11) NOT NULL AUTO_INCREMENT,
  `Wielkość` int(11) NOT NULL,
  `Możliwość_podziału` tinyint(1) NOT NULL,
  `Cena_Bazowa` float NOT NULL,
  PRIMARY KEY (`ID_typu`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `widok`
--

CREATE TABLE IF NOT EXISTS `widok` (
  `ID_widoku` int(11) NOT NULL AUTO_INCREMENT,
  `rodzaj` text COLLATE utf8_polish_ci NOT NULL,
  PRIMARY KEY (`ID_widoku`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci AUTO_INCREMENT=1 ;

--
-- Ograniczenia dla zrzutów tabel
--

--
-- Ograniczenia dla tabeli `atrakcje`
--
ALTER TABLE `atrakcje`
  ADD CONSTRAINT `atrakcje_ibfk_1` FOREIGN KEY (`ID_hotelu`) REFERENCES `hotel` (`ID_hotelu`),
  ADD CONSTRAINT `atrakcje_ibfk_2` FOREIGN KEY (`ID_opiekuna`) REFERENCES `opiekun` (`ID_opiekuna`),
  ADD CONSTRAINT `atrakcje_ibfk_3` FOREIGN KEY (`ID_typu`) REFERENCES `typ_atrakcji` (`ID_typu`);

--
-- Ograniczenia dla tabeli `cena_pokoju`
--
ALTER TABLE `cena_pokoju`
  ADD CONSTRAINT `cena_pokoju_ibfk_1` FOREIGN KEY (`ID_typu`) REFERENCES `typ_pokoju` (`ID_typu`),
  ADD CONSTRAINT `cena_pokoju_ibfk_2` FOREIGN KEY (`id_sezonu`) REFERENCES `sezon` (`ID_sezonu`);

--
-- Ograniczenia dla tabeli `cena_sali`
--
ALTER TABLE `cena_sali`
  ADD CONSTRAINT `cena_sali_ibfk_1` FOREIGN KEY (`ID_typu`) REFERENCES `typ_sali` (`ID_typu`),
  ADD CONSTRAINT `cena_sali_ibfk_2` FOREIGN KEY (`ID_sezonu`) REFERENCES `sezon` (`ID_sezonu`);

--
-- Ograniczenia dla tabeli `kajaki`
--
ALTER TABLE `kajaki`
  ADD CONSTRAINT `kajaki_ibfk_1` FOREIGN KEY (`ID_atrakcji`) REFERENCES `atrakcje` (`ID_atrakcji`);

--
-- Ograniczenia dla tabeli `konie`
--
ALTER TABLE `konie`
  ADD CONSTRAINT `konie_ibfk_1` FOREIGN KEY (`ID_atrakcji`) REFERENCES `atrakcje` (`ID_atrakcji`);

--
-- Ograniczenia dla tabeli `menedżera`
--
ALTER TABLE `menedżera`
  ADD CONSTRAINT `mened@4uera_ibfk_1` FOREIGN KEY (`ID_hotelu`) REFERENCES `hotel` (`ID_hotelu`);

--
-- Ograniczenia dla tabeli `opiekun`
--
ALTER TABLE `opiekun`
  ADD CONSTRAINT `opiekun_ibfk_1` FOREIGN KEY (`ID_hotelu`) REFERENCES `hotel` (`ID_hotelu`);

--
-- Ograniczenia dla tabeli `osoba_prywatna`
--
ALTER TABLE `osoba_prywatna`
  ADD CONSTRAINT `osoba_prywatna_ibfk_1` FOREIGN KEY (`ID_klienta`) REFERENCES `klient` (`ID_Klient`),
  ADD CONSTRAINT `osoba_prywatna_ibfk_2` FOREIGN KEY (`Numer_pokoju`) REFERENCES `pokój` (`Numer_pokoju`);

--
-- Ograniczenia dla tabeli `pokój`
--
ALTER TABLE `pokój`
  ADD CONSTRAINT `pok@0zj_ibfk_1` FOREIGN KEY (`ID_hotelu`) REFERENCES `hotel` (`ID_hotelu`),
  ADD CONSTRAINT `pok@0zj_ibfk_2` FOREIGN KEY (`ID_typu`) REFERENCES `typ_pokoju` (`ID_typu`);

--
-- Ograniczenia dla tabeli `rezerwacja`
--
ALTER TABLE `rezerwacja`
  ADD CONSTRAINT `rezerwacja_ibfk_1` FOREIGN KEY (`ID_menedżera`) REFERENCES `menedżera` (`ID_menedżera`),
  ADD CONSTRAINT `rezerwacja_ibfk_2` FOREIGN KEY (`ID_klienta`) REFERENCES `klient` (`ID_Klient`),
  ADD CONSTRAINT `rezerwacja_ibfk_3` FOREIGN KEY (`ID_osoby`) REFERENCES `osoba_prywatna` (`ID_osoby`);

--
-- Ograniczenia dla tabeli `rezerwacja_atrakcje`
--
ALTER TABLE `rezerwacja_atrakcje`
  ADD CONSTRAINT `rezerwacja_atrakcje_ibfk_1` FOREIGN KEY (`Numer_rezerwacji`) REFERENCES `rezerwacja` (`Numer_rezerwacji`),
  ADD CONSTRAINT `rezerwacja_atrakcje_ibfk_2` FOREIGN KEY (`ID_atrakcji`) REFERENCES `atrakcje` (`ID_atrakcji`);

--
-- Ograniczenia dla tabeli `rezerwacja_pokój`
--
ALTER TABLE `rezerwacja_pokój`
  ADD CONSTRAINT `rezerwacja_pok@0zj_ibfk_1` FOREIGN KEY (`Numer_rezerwacji`) REFERENCES `rezerwacja` (`Numer_rezerwacji`),
  ADD CONSTRAINT `rezerwacja_pok@0zj_ibfk_2` FOREIGN KEY (`Numer_pokoju`) REFERENCES `pokój` (`Numer_pokoju`);

--
-- Ograniczenia dla tabeli `rezerwacja_sala`
--
ALTER TABLE `rezerwacja_sala`
  ADD CONSTRAINT `rezerwacja_sala_ibfk_1` FOREIGN KEY (`Numer_rezerwacji`) REFERENCES `rezerwacja` (`Numer_rezerwacji`),
  ADD CONSTRAINT `rezerwacja_sala_ibfk_2` FOREIGN KEY (`Numer_sali`) REFERENCES `sala` (`Numer_sali`);

--
-- Ograniczenia dla tabeli `rowery`
--
ALTER TABLE `rowery`
  ADD CONSTRAINT `rowery_ibfk_1` FOREIGN KEY (`ID_atrakcji`) REFERENCES `atrakcje` (`ID_atrakcji`);

--
-- Ograniczenia dla tabeli `sala`
--
ALTER TABLE `sala`
  ADD CONSTRAINT `sala_ibfk_1` FOREIGN KEY (`ID_hotelu`) REFERENCES `hotel` (`ID_hotelu`),
  ADD CONSTRAINT `sala_ibfk_2` FOREIGN KEY (`ID_typu`) REFERENCES `typ_sali` (`ID_typu`);

--
-- Ograniczenia dla tabeli `typ_pokoju`
--
ALTER TABLE `typ_pokoju`
  ADD CONSTRAINT `typ_pokoju_ibfk_1` FOREIGN KEY (`ID_widoku`) REFERENCES `widok` (`ID_widoku`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
