-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : ven. 19 avr. 2024 à 13:37
-- Version du serveur : 10.4.28-MariaDB
-- Version de PHP : 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `quizz`
--

-- --------------------------------------------------------

--
-- Structure de la table `categories`
--

CREATE TABLE `categories` (
  `idCategories` int(11) NOT NULL,
  `Nom` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Déchargement des données de la table `categories`
--

INSERT INTO `categories` (`idCategories`, `Nom`) VALUES
(1, 'Math'),
(2, 'Programmation'),
(3, 'Culture générale');

-- --------------------------------------------------------

--
-- Structure de la table `joueurs`
--

CREATE TABLE `joueurs` (
  `idJoueurs` int(11) NOT NULL,
  `Pseudo` varchar(105) NOT NULL,
  `score` tinyint(4) NOT NULL,
  `PASSWORD_USER` varchar(1000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Déchargement des données de la table `joueurs`
--

INSERT INTO `joueurs` (`idJoueurs`, `Pseudo`, `score`, `PASSWORD_USER`) VALUES
(1, 'Pago', 10, ''),
(5, 'Adrien pago', 0, '$2a$11$.oa2dV1mK8Kfmsf6AY1ZN.mhLNA6I6UwYf5gl5WceFv24rG0eMOES'),
(6, 'Pago-Fraise', 0, '$2a$11$SJLk5vVnjZ9vuMAsE1M9VeQsyu8FDbEMM7mbDgUB076ZAf6CX/.sG'),
(7, 'test', 0, '$2a$11$BZy24e9/nyW3yDxLiEnT9.7RESkS63fbWq41TvJNOwxLM7qFsWTO.'),
(8, 'salut', 0, '$2a$11$YBPOxZKMMcWsSL1.c1nKDeY5bycRhVygCfnm2uOB4xy3A1sjStOJ6'),
(9, 'kiwi', 0, '$2a$11$gT4eoPjzcQ9Z3U8jbtynCOtbQwqEjm16C.n0GohO1PRNz9mannhTm');

-- --------------------------------------------------------

--
-- Structure de la table `question`
--

CREATE TABLE `question` (
  `idQuestion` int(11) NOT NULL,
  `Question` text NOT NULL,
  `Fkcategories` int(11) NOT NULL,
  `Reponse_1` text NOT NULL,
  `Reponse_2` text NOT NULL,
  `Reponse_3` text NOT NULL,
  `Bonne` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Déchargement des données de la table `question`
--

INSERT INTO `question` (`idQuestion`, `Question`, `Fkcategories`, `Reponse_1`, `Reponse_2`, `Reponse_3`, `Bonne`) VALUES
(1, 'Combien font 3 * 3 ?', 1, '6', '9', '12', 2),
(2, 'Quel est le langage de programmation qui n\'existe pas ?', 2, 'C', 'C++', 'C--', 3),
(3, 'Quelle Marque à une pomme comme logo ?', 3, 'Apple', 'Microsoft', 'Linux', 1),
(4, 'Quand le premier Iphone est-il sorti ?', 3, '2006', '2007', '2017', 2),
(5, 'Quelle entreprise a créé Cortana ?', 3, 'Apple', 'Microsoft', 'Linux', 2),
(6, 'Quel est la valeur de PI arrondie à deux chiffres ?', 1, '3.14', '3.13', '3.15', 1),
(7, 'Que fait la ligne de code suivante : mavariable++ ?', 2, 'Incrémente la variable \'mavariable\' de 1', 'Décrémente la variable \'mavariable\' de 1', 'Ne fait rien', 1),
(8, 'En quelle année le Titanic a-t-il coulé ?', 3, '1911', '1912', '1913', 2),
(9, 'En quelle année a été adopté le drapeau actuel de la suisse ?', 3, '1840', '1841', '1842', 1),
(10, 'quelle est la réponse à la grande question sur la vie, l\'univers et le reste ?', 3, '42.2', '42', '42.42', 2),
(11, 'Qu’est-ce qui est petit et marron ?', 3, 'un marron', 'un petit pois', 'une châtaigne', 1),
(12, 'Qui est célèbre pour la phrase \'C\'est pas faux\'', 3, 'Le Roi Arthur', 'Perceval', 'Léodagan', 2);

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`idCategories`);

--
-- Index pour la table `joueurs`
--
ALTER TABLE `joueurs`
  ADD PRIMARY KEY (`idJoueurs`);

--
-- Index pour la table `question`
--
ALTER TABLE `question`
  ADD PRIMARY KEY (`idQuestion`),
  ADD KEY `fk_Question_catégories1_idx` (`Fkcategories`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `categories`
--
ALTER TABLE `categories`
  MODIFY `idCategories` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT pour la table `joueurs`
--
ALTER TABLE `joueurs`
  MODIFY `idJoueurs` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT pour la table `question`
--
ALTER TABLE `question`
  MODIFY `idQuestion` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `question`
--
ALTER TABLE `question`
  ADD CONSTRAINT `fk_Question_catégories1` FOREIGN KEY (`Fkcategories`) REFERENCES `categories` (`idCategories`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
