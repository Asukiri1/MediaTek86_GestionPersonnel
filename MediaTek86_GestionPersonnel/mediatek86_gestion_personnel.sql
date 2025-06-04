-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mar. 03 juin 2025 à 13:45
-- Version du serveur : 9.1.0
-- Version de PHP : 8.3.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mediatek86_gestion_personnel`
--

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `idpersonnel` int NOT NULL,
  `datedebut` datetime NOT NULL,
  `datefin` datetime DEFAULT NULL,
  `idmotif` int NOT NULL,
  PRIMARY KEY (`idpersonnel`,`datedebut`),
  KEY `idmotif` (`idmotif`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `datefin`, `idmotif`) VALUES
(4, '2024-03-26 00:00:00', '2024-06-20 00:00:00', 3),
(4, '2024-03-30 00:00:00', '2024-04-18 00:00:00', 3),
(5, '2024-10-07 00:00:00', '2024-10-10 00:00:00', 4),
(6, '2024-12-02 00:00:00', '2024-12-29 00:00:00', 1),
(7, '2024-01-17 00:00:00', '2024-03-31 00:00:00', 1),
(10, '2024-01-26 00:00:00', '2024-10-19 00:00:00', 2),
(5, '2024-01-12 00:00:00', '2024-03-28 00:00:00', 2),
(9, '2024-02-20 00:00:00', '2024-04-27 00:00:00', 1),
(2, '2024-12-03 00:00:00', '2024-12-06 00:00:00', 4),
(5, '2024-12-29 00:00:00', '2025-01-03 00:00:00', 2),
(3, '2024-09-14 00:00:00', '2024-09-18 00:00:00', 3),
(8, '2024-06-02 00:00:00', '2024-06-30 00:00:00', 4),
(7, '2024-09-01 00:00:00', '2024-09-10 00:00:00', 3),
(6, '2024-06-24 00:00:00', '2024-10-11 00:00:00', 2),
(5, '2024-01-20 00:00:00', '2024-03-30 00:00:00', 2),
(5, '2024-01-18 00:00:00', '2024-07-29 00:00:00', 3),
(5, '2024-02-26 00:00:00', '2024-05-18 00:00:00', 4),
(6, '2024-07-28 00:00:00', '2024-12-30 00:00:00', 2),
(5, '2024-05-09 00:00:00', '2024-06-23 00:00:00', 2),
(7, '2024-12-31 00:00:00', '2025-01-03 00:00:00', 2),
(6, '2024-05-19 00:00:00', '2024-05-22 00:00:00', 2),
(6, '2024-01-31 00:00:00', '2024-10-05 00:00:00', 3),
(7, '2024-02-25 00:00:00', '2024-06-23 00:00:00', 1),
(8, '2024-04-22 00:00:00', '2024-06-13 00:00:00', 1),
(2, '2024-01-18 00:00:00', '2024-11-12 00:00:00', 3),
(5, '2024-06-30 00:00:00', '2024-07-03 00:00:00', 1),
(6, '2024-06-04 00:00:00', '2024-07-28 00:00:00', 4),
(7, '2024-01-24 00:00:00', '2024-02-09 00:00:00', 3),
(3, '2024-05-26 00:00:00', '2024-05-29 00:00:00', 2),
(6, '2024-12-09 00:00:00', '2024-12-12 00:00:00', 4),
(4, '2024-09-02 00:00:00', '2024-09-05 00:00:00', 3),
(5, '2024-06-10 00:00:00', '2024-09-21 00:00:00', 1),
(2, '2024-06-12 00:00:00', '2024-10-20 00:00:00', 3),
(5, '2024-03-10 00:00:00', '2024-10-05 00:00:00', 2),
(3, '2024-07-18 00:00:00', '2024-07-20 00:00:00', 4),
(3, '2024-08-18 00:00:00', '2024-10-12 00:00:00', 2),
(8, '2024-01-04 00:00:00', '2024-09-02 00:00:00', 4),
(6, '2024-01-11 00:00:00', '2024-10-04 00:00:00', 4),
(2, '2024-10-04 00:00:00', '2024-11-05 00:00:00', 2),
(7, '2024-12-22 00:00:00', '2024-12-25 00:00:00', 3),
(6, '2024-09-05 00:00:00', '2024-09-08 00:00:00', 2),
(8, '2024-11-08 00:00:00', '2024-11-11 00:00:00', 3),
(5, '2024-07-15 00:00:00', '2024-07-18 00:00:00', 2),
(9, '2024-04-09 00:00:00', '2024-07-05 00:00:00', 3),
(9, '2024-05-17 00:00:00', '2024-05-20 00:00:00', 2),
(6, '2024-02-21 00:00:00', '2024-06-25 00:00:00', 2),
(5, '2024-04-29 00:00:00', '2024-12-10 00:00:00', 2),
(4, '2024-09-16 00:00:00', '2024-09-19 00:00:00', 4),
(8, '2024-09-27 00:00:00', '2024-09-30 00:00:00', 2),
(1, '2025-06-03 00:00:00', '2025-06-10 00:00:00', 1);

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `idmotif` int NOT NULL AUTO_INCREMENT,
  `libelle` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`idmotif`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `idpersonnel` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) DEFAULT NULL,
  `prenom` varchar(50) DEFAULT NULL,
  `tel` varchar(15) DEFAULT NULL,
  `mail` varchar(128) DEFAULT NULL,
  `idservice` int NOT NULL,
  PRIMARY KEY (`idpersonnel`),
  KEY `idservice` (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `nom`, `prenom`, `tel`, `mail`, `idservice`) VALUES
(1, 'Conner', 'Leslie', '05 57 66 46 75', 'et@outlook.edu', 3),
(2, 'Vaughan', 'Ava', '05 52 77 74 86', 'elit@aol.org', 2),
(3, 'Pruitt', 'Grady', '08 16 03 53 15', 'praesent@hotmail.edu', 2),
(4, 'House', 'Deanna', '08 50 72 72 64', 'iaculis.enim@yahoo.org', 1),
(5, 'Phelps', 'Lael', '09 74 58 80 51', 'purus@outlook.com', 2),
(6, 'Lloyd', 'Demetria', '04 73 22 05 38', 'in.sodales.elit@icloud.org', 3),
(7, 'Macias', 'Zelenia', '02 23 07 55 86', 'in@icloud.org', 1),
(8, 'Ross', 'Philip', '04 44 68 18 76', 'integer.id@google.com', 2),
(9, 'Ford', 'Brendan', '08 66 82 94 07', 'fringilla@protonmail.couk', 2),
(10, 'Smith', 'Mia', '08 85 58 44 63', 'aliquam@protonmail.edu', 2);

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) NOT NULL,
  `pwd` varchar(64) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('admin_mediatek', '1451cc963cd2eebd6f60b55d64ae4486dca6b26b0d48a01bc82a8b00dcfceee4');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `idservice` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
