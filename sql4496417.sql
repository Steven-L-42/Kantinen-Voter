-- phpMyAdmin SQL Dump
-- version 4.7.1
-- https://www.phpmyadmin.net/
--
-- Host: sql4.freemysqlhosting.net
-- Erstellungszeit: 08. Jun 2022 um 08:23
-- Server-Version: 5.5.54-0ubuntu0.12.04.1
-- PHP-Version: 7.0.33-0ubuntu0.16.04.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `sql4496417`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `CanteenTable`
--

CREATE TABLE `CanteenTable` (
  `Menue-ID` int(11) NOT NULL,
  `Menues` text COLLATE utf8_unicode_ci,
  `Montag` text COLLATE utf8_unicode_ci,
  `Dienstag` text COLLATE utf8_unicode_ci,
  `Mittwoch` text COLLATE utf8_unicode_ci,
  `Donnerstag` text COLLATE utf8_unicode_ci,
  `Freitag` text COLLATE utf8_unicode_ci,
  `Samstag` text COLLATE utf8_unicode_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Daten für Tabelle `CanteenTable`
--

INSERT INTO `CanteenTable` (`Menue-ID`, `Menues`, `Montag`, `Dienstag`, `Mittwoch`, `Donnerstag`, `Freitag`, `Samstag`) VALUES
(16, 'Menü A \n(Normal Kost)', 'Frischer Oktopus vom Grill auf einem Bett von Trüffel Kartoffelpüree', 'Tonnarelli mit Peccorino Käse, Grana Padana (24 Monate gereift), schwarzem und grünem Pfeffer, leicht scharf', 'Hauchdünne Scheiben vom rohen Rinderfilet mit gebratenen Steinpilzen', 'Frischer Kalbstartar mit Grissini, geriebenen Pistazien und Trüffel', 'Carpaccio, Vitello Tonato, Büffelmozarrella, Parmaschinken, Salami Calabrese und eingelegtes Gemüse', 'Bellucci\nTomatensauce, Mozzarella, Rucola, Cherrytomaten, Schafskäse'),
(17, 'Menü B \n(Vegan)', 'Fruchtige Kürbissuppe\nmit Goldampfer Pesto und Sauerteigbrot', 'Omas Kartoffelsuppe\nmit Wurzelgemüse, geräuchertem Tofu und frischen Gartenkräutern', 'Schnippelbohnen Lammtopf\nmit Sellerie Rettich Gemüse, Kartoffeln und Kräutern vom Feld', 'Schnippelbohnen Lammtopf\nmit Sellerie Rettich Gemüse, Kartoffeln und Kräutern vom Feld', 'Geknusperter Landfrauen Gurkensalat\nmit grünen Landgurken, Lauchzwiebeln, weißen Senfkörnern, Sesam Estragon Öl und Gartendill', 'Schmorgurken\nGelbe und grüne Schmorgurken mit Linsenbällchen, Zwiebeln, gezupften Kräutern und Kartoffeln'),
(18, 'Menü C \n(Vegetarisch)', 'Zweierlei Bierkäse\n(die perfekte Feierabendbierbegleitung) in Dunkel  und Helles Bier eingelegte Harzer Käserollen mit Quark', 'Spreewälder Bauernsülze\nZartes Fleisch und Gemüse in Aspik mit knusprigen Bratkartoffeln und hausgemachter Remouladensoße', 'Vergessener Kohl\nim ganzen gebackener Blumenkohl mit Drillings kartoffeln, Bundmöhren und zerlassener Butter', 'Biene sticht Jäger\nhausgemachter Mandel Bienenstich mit Vanillepudding Füllung', 'Waldpilzbrot\nmit gebratenen Wald  und Wiesenpilzen, Zwiebeln und Waldkräutern', 'Stroh & Heu\nBandnudeln mit regionalen Gemüsestreifen, Brennnessel Rauken Pesto und Gartenkräutern'),
(20, 'Menü D \n(Gluten-/Lak.- Frei)', 'Rosenspitz\n(das beste Stück der Rinderkeule) in Meerrettichsoße, dazu Blumenkohl Möhren  Gemüse und Salzkartoffeln', 'Dicke Rippe\nRinderschmorrippe (ca. 400g) mit rauchiger Kräuter Honig Marinade, grünen Spargelstangen und gebackenen neuen Kartoffeln\n', 'Forelle aus dem Bach\nmit Schwenkkartoffeln, Mandel Nussbutter und kleinem Knusper Gurkensalat', 'Medaillons vom Reh mit Ahornkirschen\n(wird nur hier so serviert) mit gebratenem Spitzkohl, Kartoffel Lauch Gratin und Rotweinsoße', 'Kaninchenpfanne\n(Brandenburger Rezept) mit Bohnen, Zwiebeln, Rüben und Kräuterkartoffeln', 'Wildschweinrücken\n(aus dem Fläminger Forst) mit geschmortem Spitzkohl, Bratkartoffeln und viel Bratensoße');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `MenuesTable`
--

CREATE TABLE `MenuesTable` (
  `Menü A` text,
  `Menü B` text,
  `Menü C` text,
  `Menü D` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Daten für Tabelle `MenuesTable`
--

INSERT INTO `MenuesTable` (`Menü A`, `Menü B`, `Menü C`, `Menü D`) VALUES
('Frischer Oktopus vom Grill auf einem Bett von Trüffel Kartoffelpüree', 'Fruchtige Kürbissuppe\nmit Goldampfer Pesto und Sauerteigbrot', 'Zweierlei Bierkäse\n(die perfekte Feierabendbierbegleitung) in Dunkel  und Helles Bier eingelegte Harzer Käserollen mit Quark', 'Rosenspitz\n(das beste Stück der Rinderkeule) in Meerrettichsoße, dazu Blumenkohl Möhren  Gemüse und Salzkartoffeln'),
('Tonnarelli mit Peccorino Käse, Grana Padana (24 Monate gereift), schwarzem und grünem Pfeffer, leicht scharf', 'Omas Kartoffelsuppe\nmit Wurzelgemüse, geräuchertem Tofu und frischen Gartenkräutern', 'Spreewälder Bauernsülze\nZartes Fleisch und Gemüse in Aspik mit knusprigen Bratkartoffeln und hausgemachter Remouladensoße', 'Dicke Rippe\nRinderschmorrippe (ca. 400g) mit rauchiger Kräuter Honig Marinade, grünen Spargelstangen und gebackenen neuen Kartoffeln\n'),
('Hauchdünne Scheiben vom rohen Rinderfilet mit gebratenen Steinpilzen', 'Schnippelbohnen Lammtopf\nmit Sellerie Rettich Gemüse, Kartoffeln und Kräutern vom Feld', 'Vergessener Kohl\nim ganzen gebackener Blumenkohl mit Drillings kartoffeln, Bundmöhren und zerlassener Butter', 'Medaillons vom Reh mit Ahornkirschen\n(wird nur hier so serviert) mit gebratenem Spitzkohl, Kartoffel Lauch Gratin und Rotweinsoße'),
('Frischer Kalbstartar mit Grissini, geriebenen Pistazien und Trüffel', 'Geknusperter Landfrauen Gurkensalat\nmit grünen Landgurken, Lauchzwiebeln, weißen Senfkörnern, Sesam Estragon Öl und Gartendill', 'Biene sticht Jäger\nhausgemachter Mandel Bienenstich mit Vanillepudding Füllung', 'Forelle aus dem Bach\nmit Schwenkkartoffeln, Mandel Nussbutter und kleinem Knusper Gurkensalat'),
('Carpaccio, Vitello Tonato, Büffelmozarrella, Parmaschinken, Salami Calabrese und eingelegtes Gemüse', 'Schmorgurken\nGelbe und grüne Schmorgurken mit Linsenbällchen, Zwiebeln, gezupften Kräutern und Kartoffeln', 'Waldpilzbrot\nmit gebratenen Wald  und Wiesenpilzen, Zwiebeln und Waldkräutern', 'Kaninchenpfanne\n(Brandenburger Rezept) mit Bohnen, Zwiebeln, Rüben und Kräuterkartoffeln'),
('Bellucci\nTomatensauce, Mozzarella, Rucola, Cherrytomaten, Schafskäse', 'Gemüsegulasch\nin der Pfanne gebratene Rüben, Romanesco, Blumenkohl und bunte Paprika an Kartoffeln und Pastinaken Stroh', 'Stroh & Heu\nBandnudeln mit regionalen Gemüsestreifen, Brennnessel Rauken Pesto und Gartenkräutern', 'Wildschweinrücken\n(aus dem Fläminger Forst) mit geschmortem Spitzkohl, Bratkartoffeln und viel Bratensoße');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `UserMenueTable`
--

CREATE TABLE `UserMenueTable` (
  `User-ID` int(11) NOT NULL,
  `Benutzername` varchar(50) NOT NULL,
  `Montag` varchar(50) DEFAULT NULL,
  `MontagGericht` text,
  `Dienstag` varchar(50) DEFAULT NULL,
  `DienstagGericht` text,
  `Mittwoch` varchar(50) DEFAULT NULL,
  `MittwochGericht` text,
  `Donnerstag` varchar(50) DEFAULT NULL,
  `DonnerstagGericht` text,
  `Freitag` varchar(50) DEFAULT NULL,
  `FreitagGericht` text,
  `Samstag` varchar(50) DEFAULT NULL,
  `SamstagGericht` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Daten für Tabelle `UserMenueTable`
--

INSERT INTO `UserMenueTable` (`User-ID`, `Benutzername`, `Montag`, `MontagGericht`, `Dienstag`, `DienstagGericht`, `Mittwoch`, `MittwochGericht`, `Donnerstag`, `DonnerstagGericht`, `Freitag`, `FreitagGericht`, `Samstag`, `SamstagGericht`) VALUES
(1, 'ShiiikK', 'Menü C \n(Vegetarisch)', 'Zweierlei Bierkäse\n(die perfekte Feierabendbierbegleitung) in Dunkel  und Helles Bier eingelegte Harzer Käserollen mit Quark', 'Menü B \n(Vegan)', 'Omas Kartoffelsuppe\nmit Wurzelgemüse, geräuchertem Tofu und frischen Gartenkräutern', 'Menü A \n(Normal Kost)', 'Hauchdünne Scheiben vom rohen Rinderfilet mit gebratenen Steinpilzen', 'Menü C \n(Vegetarisch)', 'Biene sticht Jäger\nhausgemachter Mandel Bienenstich mit Vanillepudding Füllung', 'Menü B \n(Vegan)', 'Geknusperter Landfrauen Gurkensalat\nmit grünen Landgurken, Lauchzwiebeln, weißen Senfkörnern, Sesam Estragon Öl und Gartendill', 'Menü A \n(Normal Kost)', 'Bellucci\nTomatensauce, Mozzarella, Rucola, Cherrytomaten, Schafskäse'),
(4, 'Mentalill', 'Menü A \n(Normal Kost)', 'Frischer Oktopus vom Grill auf einem Bett von Trüffel-Kartoffelpüree', 'Menü B \n(Vegan)', 'Omas Kartoffelsuppe\nmit Wurzelgemüse, geräuchertem Tofu und frischen Gartenkräutern', 'Menü C \n(Vegetarisch)', 'Vergessener Kohl\nim ganzen gebackener Blumenkohl mit Drillings-kartoffeln, Bundmöhren und zerlassener Butter', 'Menü D \n(Gluten-/Lak.- Frei)', 'Forelle aus dem Bach\nmit Schwenkkartoffeln, Mandel-Nussbutter und kleinem Knusper-Gurkensalat', 'Menü C \n(Vegetarisch)', 'Waldpilzbrot\nmit gebratenen Wald- und Wiesenpilzen, Zwiebeln und Waldkräutern', 'Menü B \n(Vegan)', 'Gemüsegulasch\nin der Pfanne gebratene Rüben, Romanesco, Blumenkohl und bunte Paprika an Kartoffeln und Pastinaken-Stroh'),
(23, 'Admin', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `UserTable`
--

CREATE TABLE `UserTable` (
  `id` int(11) NOT NULL,
  `Benutzername` varchar(50) NOT NULL,
  `Passwort` varchar(32) NOT NULL,
  `Vorname` varchar(50) DEFAULT NULL,
  `Nachname` varchar(50) DEFAULT NULL,
  `Geburtsdatum` date DEFAULT NULL,
  `Allergene` varchar(50) DEFAULT NULL,
  `Menue` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Daten für Tabelle `UserTable`
--

INSERT INTO `UserTable` (`id`, `Benutzername`, `Passwort`, `Vorname`, `Nachname`, `Geburtsdatum`, `Allergene`, `Menue`) VALUES
(15, 'ShiiikK', '1b471f11c7ab462249b1cb6b57a657c3', 'Steven', 'Lippert', '1997-02-28', 'Gluten-/Milch-Unverträg', NULL),
(18, 'Mentalill', '0ff6803912d2c3889c262cea5baaad36', 'Hans', 'Peter-Peterson', '1983-10-25', 'Schlechter code', NULL),
(37, 'Admin', '751cb3f4aa17c36186f4856c8982bf27', NULL, NULL, NULL, NULL, NULL);

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `CanteenTable`
--
ALTER TABLE `CanteenTable`
  ADD PRIMARY KEY (`Menue-ID`);

--
-- Indizes für die Tabelle `UserMenueTable`
--
ALTER TABLE `UserMenueTable`
  ADD PRIMARY KEY (`User-ID`);

--
-- Indizes für die Tabelle `UserTable`
--
ALTER TABLE `UserTable`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `CanteenTable`
--
ALTER TABLE `CanteenTable`
  MODIFY `Menue-ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;
--
-- AUTO_INCREMENT für Tabelle `UserMenueTable`
--
ALTER TABLE `UserMenueTable`
  MODIFY `User-ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;
--
-- AUTO_INCREMENT für Tabelle `UserTable`
--
ALTER TABLE `UserTable`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=38;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
