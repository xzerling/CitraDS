-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 07-05-2020 a las 23:28:12
-- Versión del servidor: 10.3.16-MariaDB
-- Versión de PHP: 7.3.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `citrads`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `admins`
--

CREATE TABLE `admins` (
  `id` int(11) NOT NULL,
  `full_name` varchar(255) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `roles_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `admins`
--

INSERT INTO `admins` (`id`, `full_name`, `email`, `password`, `roles_id`) VALUES
(1, 'Alvaro Elgueda', 'zerling@hotmail.com', '123456', 1),
(2, 'Juan Cordero', 'juan@hotmail.com', '12345', 2),
(3, 'Nicolas Pradenas', 'nico@hotmail.com', '12345', 6),
(6, 'asdf', 'hola@hotmail.com', '123456', 6);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estaciones_asignadas`
--

CREATE TABLE `estaciones_asignadas` (
  `id` int(32) NOT NULL,
  `idusuario` int(32) NOT NULL,
  `idestacion` int(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estacioneve`
--

CREATE TABLE `estacioneve` (
  `id` int(11) NOT NULL,
  `adcon_id` int(11) NOT NULL,
  `nombre` tinytext NOT NULL,
  `latitud` double NOT NULL,
  `longitud` double NOT NULL,
  `altura` double NOT NULL,
  `ultima_fecha` date NOT NULL,
  `ultima_hora` time NOT NULL,
  `intentos_de_descarga` int(11) NOT NULL DEFAULT 0,
  `estacion_clon_id` int(11) DEFAULT 0,
  `estado` tinytext NOT NULL COMMENT '[D] = Descargando\n[S] = Detenida\n[C] = En modo clonacion\n[O] = Offline\n[E] = Error Desconocido',
  `descargar` int(11) NOT NULL COMMENT '[1] = Si\n[0] = No',
  `clonar` int(11) NOT NULL COMMENT '[1] = Si\n[0] = No',
  `fuente_de_datos_id` int(11) DEFAULT NULL,
  `ultima_fecha_clon` date DEFAULT NULL,
  `ultima_hora_clon` time DEFAULT NULL,
  `RTU` int(11) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `estacioneve`
--

INSERT INTO `estacioneve` (`id`, `adcon_id`, `nombre`, `latitud`, `longitud`, `altura`, `ultima_fecha`, `ultima_hora`, `intentos_de_descarga`, `estacion_clon_id`, `estado`, `descargar`, `clonar`, `fuente_de_datos_id`, `ultima_fecha_clon`, `ultima_hora_clon`, `RTU`) VALUES
(84, 285, 'Peralillo (Viumanent)', -34.499, -71.45, 0, '2017-07-28', '19:15:00', 6851, 84, 'C', 1, 1, 3, '2017-08-06', '18:59:04', 49736),
(85, 282, 'Santa Cruz (Montgras)', -34.563, -71.401, 0, '2017-04-11', '18:45:00', 12462, 85, 'C', 1, 1, 3, '2017-04-19', '00:33:23', 49731),
(86, 240, 'E. E. Panguilemo', -35.22, -71.35, 118, '2019-07-30', '12:00:00', 2, 86, 'D', 1, 0, 3, '2017-05-23', '14:19:27', 47296),
(87, 287, 'Coinco', -34.246, -70.916, 347, '2010-10-25', '14:00:00', 3540, 87, 'O', 0, 1, 7, '2011-05-09', '02:28:28', 37284),
(89, 134, 'Agr. Malvilla', -33.5, -71.5, 0, '2012-03-19', '08:45:00', 23338, 89, 'O', 0, 0, 6, '2011-03-28', '14:01:12', 39370),
(90, 981, 'V. Anakena', -34.304901, -70.771599, 0, '2012-03-19', '09:00:00', 23337, 90, 'O', 0, 0, 6, '2000-01-01', '00:00:00', 44501),
(91, 2002, 'V. Aresti', -35.1516, -71.288401, 0, '2012-03-19', '08:45:00', 23337, 91, 'O', 0, 0, 6, '2011-02-15', '17:10:26', 44528),
(92, 1645, 'V. Casa Rivas', -33.5, -71.060898, 0, '2012-03-19', '09:15:00', 23337, 92, 'O', 0, 0, 6, '2011-12-21', '15:31:38', 44499),
(93, 1304, 'V. Casa Silva', -34.502201, -70.8946, 0, '2012-03-10', '22:45:00', 23576, 93, 'O', 0, 0, 6, '2000-01-01', '00:00:00', 44526),
(94, 110, 'V. Casas del Bosque', -33.310001, -71.419998, 0, '2012-03-19', '09:15:00', 23336, 94, 'O', 0, 0, 6, '2000-01-01', '00:00:00', 41146),
(95, 3292, 'V. Casas Patronales', -35.290001, -71.440002, 0, '2012-03-19', '09:30:00', 23335, 95, 'O', 0, 0, 6, '2000-01-01', '00:00:00', 45694),
(96, 490, 'V. Chocalan', -33.7607, -71.225601, 0, '2012-03-19', '09:45:00', 23335, 96, 'O', 0, 0, 6, '2000-01-01', '00:00:00', 44547),
(97, 1324, 'V. Cono Sur', -34.715698, -71.038803, 0, '2012-03-19', '09:45:00', 23335, 97, 'O', 0, 0, 6, '2000-01-01', '00:00:00', 44493),
(98, 162, 'V. Corpora', -37.002602, -73.527802, 106, '2012-03-19', '09:45:00', 23335, 98, 'O', 0, 0, 6, '2000-01-01', '00:00:00', 44496),
(99, 470, 'V. Demartino', -33.581699, -70.8815, 0, '2011-10-13', '15:00:00', 30455, 99, 'O', 0, 1, 6, '2011-10-20', '15:28:48', 44485),
(100, 3142, 'V. El Aromo', -35.330002, -71.599998, 0, '2012-03-19', '10:00:00', 23335, 100, 'O', 0, 0, 6, '2000-01-01', '00:00:00', 45649),
(101, 88, 'Agr. El Ensueno', -33.295101, -71.394798, 0, '2012-03-19', '10:15:00', 23335, 101, 'O', 0, 0, 6, '2011-04-08', '20:34:24', 39741),
(102, 1842, 'V. Emiliana', -33.361599, -71.309097, 0, '2012-03-19', '06:45:00', 23335, 102, 'O', 0, 0, 6, '2011-07-01', '12:10:45', 44527),
(103, 892, 'V. Errazuriz', -32.898899, -71.351501, 113, '2012-03-19', '10:30:00', 23335, 103, 'O', 0, 0, 6, '2000-01-01', '00:00:00', 44536),
(104, 272, 'V. Falernia', -30.027901, -70.801903, 515, '2012-03-19', '10:00:00', 23335, 104, 'O', 0, 0, 6, '2000-01-01', '00:00:00', 44492),
(105, 223, 'V. Altos de Quitralman', -37.648899, -72.216202, 187, '2012-03-19', '10:30:00', 23335, 105, 'O', 0, 0, 6, '2000-01-01', '00:00:00', 44518),
(106, 3312, 'V. J. Bouchon', -35.57, -72, 0, '2012-03-19', '10:45:00', 23335, 106, 'O', 0, 0, 6, '2000-01-01', '00:00:00', 45628),
(107, 1902, 'V. Lapostolle', -34.593899, -71.302399, 0, '2012-03-19', '10:45:00', 23335, 107, 'O', 0, 0, 6, '2011-02-15', '13:11:13', 44497),
(108, 1442, 'V. Larosa', -34.324799, -71.239502, 158, '2012-03-19', '10:45:00', 23335, 108, 'O', 0, 0, 6, '2000-01-01', '00:00:00', 44498),
(109, 24, 'Agr. Las Petras', -33.389999, -71.470001, 0, '2012-01-16', '20:30:00', 26052, 109, 'O', 0, 1, 6, '2012-01-21', '22:19:00', 41921),
(110, 4334, 'V. Loma Larga', -33.279999, -71.470001, 0, '2012-03-19', '11:00:00', 23335, 110, 'O', 0, 0, 6, '2011-03-29', '14:12:34', 39786),
(112, 172, 'V. LFE San Antonio', -34.669998, -71.529999, 123, '2012-03-19', '11:15:00', 23336, 112, 'O', 0, 0, 6, '2011-10-11', '05:35:02', 44488),
(113, 1497, 'V. Lurton', -34.727501, -71.859699, 0, '2011-10-31', '13:00:00', 29669, 113, 'O', 0, 1, 6, '2011-11-06', '19:57:22', 44483),
(114, 1294, 'V. Montes', -34.340599, -71.6502, 175, '2012-03-19', '11:15:00', 23335, 114, 'O', 0, 0, 6, '2000-01-01', '00:00:00', 44489),
(115, 1220, 'V. Morande Romeral', -33.706699, -70.772697, 0, '2012-03-19', '11:15:00', 23335, 115, 'O', 0, 0, 6, '2000-01-01', '00:00:00', 44529),
(116, 460, 'V. Morande San Bernardo', -33.581699, -70.717201, 0, '2012-03-19', '11:30:00', 23335, 116, 'O', 0, 0, 6, '2000-01-01', '00:00:00', 44487),
(117, 3282, 'V. Odfjell', -36.150002, -72.269997, 0, '2012-03-19', '06:00:00', 23334, 117, 'O', 0, 0, 6, '2011-12-24', '00:17:00', 45650),
(118, 4813, 'Orafti Los Angeles', -37.450001, -72.769997, 0, '2012-03-19', '11:45:00', 23334, 118, 'O', 0, 0, 6, '2000-01-01', '00:00:00', 39760),
(119, 4823, 'Orafti Selva Negra', -36.846001, -72.141998, 0, '2012-03-19', '11:15:00', 23334, 119, 'O', 0, 0, 6, '2000-01-01', '00:00:00', 41931),
(120, 4102, 'V. Perez Cruz', -33.843102, -70.619904, 0, '2012-03-19', '12:15:00', 23334, 120, 'O', 0, 0, 6, '2010-11-15', '11:00:00', 45703),
(121, 1162, 'V. Ravanal', -34.641602, -71.121201, 0, '2012-03-19', '12:15:00', 23334, 121, 'O', 0, 0, 6, '2011-10-11', '14:06:58', 44508),
(122, 2162, 'V. San Pedro El Transito', -33.771099, -70.6856, 0, '2012-03-19', '12:30:00', 23334, 122, 'O', 0, 0, 6, '2000-01-01', '00:00:00', 44500),
(123, 2192, 'V. San Pedro Molina', -35.114201, -71.334801, 0, '2012-03-19', '12:15:00', 23334, 123, 'O', 0, 0, 6, '2000-01-01', '00:00:00', 44511),
(124, 2182, 'V. San Pedro Pencahue', -35.333, -71.769302, 0, '2012-03-19', '12:30:00', 23334, 124, 'O', 0, 0, 6, '2000-01-01', '00:00:00', 44502),
(125, 2172, 'V. San Pedro Totihue', -34.341099, -70.727798, 0, '2012-03-19', '12:45:00', 23334, 125, 'O', 0, 0, 6, '2011-03-30', '01:09:19', 44541),
(126, 4322, 'V. Terranoble', -33.330002, -71.410004, 0, '2012-03-19', '12:30:00', 23334, 126, 'O', 0, 0, 6, '2000-01-01', '00:00:00', 40084),
(127, 121, 'Agr. Santa Elena', -35.700001, -71.839996, 0, '2012-03-19', '13:00:00', 23334, 127, 'O', 0, 0, 6, '2012-03-09', '20:35:07', 39775),
(128, 262, 'V. Casa Tamaya', -30.566601, -71.395798, 293, '2012-03-19', '13:15:00', 23334, 128, 'O', 0, 0, 6, '2000-01-01', '00:00:00', 44494),
(129, 3262, 'V. Terramater', -35.009998, -71.43, 0, '2012-03-19', '13:00:00', 23334, 129, 'O', 0, 0, 6, '2011-11-25', '00:35:29', 45647),
(130, 3302, 'V. Undurraga', -35.91, -72.260002, 0, '2012-03-19', '13:20:53', 23334, 130, 'O', 0, 0, 6, '2000-01-01', '00:00:00', 45645),
(131, 450, 'V. Ventisquero', -34.022499, -71.344101, 0, '2012-03-05', '23:15:00', 23810, 131, 'O', 0, 1, 6, '2012-03-11', '00:42:33', 44545),
(132, 882, 'V. Von Siebenthal', -32.798401, -70.836403, 0, '2012-03-19', '14:15:00', 23334, 132, 'O', 0, 0, 6, '2012-01-10', '03:55:51', 44486),
(133, 3122, 'V. William Fevre', -33.671299, -70.581596, 0, '2012-03-16', '00:00:00', 23335, 133, 'O', 0, 0, 6, '2000-01-01', '00:00:00', 45631),
(134, 184, 'Coltauco (El Sauce)', -34.245, -71.027, 281, '2011-02-12', '16:00:00', 3462, 134, 'O', 0, 1, 7, '2011-05-10', '18:03:54', 37152),
(135, 277, 'Coltauco (Los Bronces)', -34.212, -70.998, 298, '2011-02-12', '16:00:00', 3530, 135, 'O', 0, 1, 7, '2011-05-09', '06:34:06', 37272),
(136, 4163, 'V. Garces Silva', -33.69, -71.49, 222, '2012-03-16', '00:00:00', 23335, 89, 'O', 0, 0, 6, '2000-01-01', '00:00:00', 44505),
(137, 4462, 'V. Santa Rita', -33.720001, -70.669998, 0, '2012-03-16', '00:00:00', 23335, 137, 'O', 0, 0, 6, '2000-01-01', '00:00:00', 46196),
(138, 4622, 'V. Concha y Toro', -30.610001, -71.300003, 0, '2012-03-16', '00:15:00', 23335, 89, 'O', 0, 0, 6, '2000-01-01', '00:00:00', 46195),
(139, 3272, 'V. Carta Vieja', -35.650002, -71.669998, 0, '2012-03-16', '00:15:00', 23334, 139, 'O', 0, 0, 6, '2011-12-30', '12:16:22', 45638),
(140, 4344, 'V. LFE Colchagua', -34.689999, -71.209999, 123, '2011-06-24', '21:00:00', 32344, 140, 'O', 0, 1, 6, '2011-06-30', '00:32:17', 44484),
(142, 4942, 'Agr. La Concordia', -35.911999, -72.365898, 0, '2011-05-25', '00:15:00', 34665, 101, 'O', 0, 1, 6, '2011-05-31', '20:41:49', 40079),
(143, 408, 'Colbun (FRUCOL)', -35.699899, -71.461243, 224, '2012-04-15', '12:15:00', 20822, 143, 'O', 0, 1, 3, '2012-04-18', '02:17:46', 39702),
(148, 562, 'Marta Martinez (MS)', -35.74403, -71.572952, 154, '2014-12-03', '15:00:00', 10657, 148, 'O', 0, 1, 3, '2014-12-17', '18:20:39', 58471),
(149, 488, 'La Querencia (MS)', -35.711697, -71.497467, 194, '2014-12-03', '14:00:00', 10657, 149, 'O', 0, 1, 3, '2014-12-17', '18:21:27', 48466),
(150, 483, 'San Miguel (La Caba&ntilde;a) (MS)', -35.622307, -71.443977, 260, '2014-12-03', '11:00:00', 10657, 150, 'O', 0, 1, 3, '2014-12-17', '18:22:13', 48440),
(151, 478, 'La Estancia (MS)', -35.746655, -71.540695, 161, '2014-12-03', '13:00:00', 10656, 151, 'O', 0, 1, 3, '2014-12-17', '18:22:58', 48469),
(152, 279, 'Quepo', -35.392676, -71.734865, 86, '2018-03-09', '11:00:00', 2030, 152, 'C', 1, 1, 3, '2018-03-14', '00:12:32', 49320),
(153, 498, 'EL Llano (MS)', -35.666103, -71.506729, 213, '2014-12-03', '13:00:00', 10651, 153, 'O', 0, 1, 3, '2014-12-17', '18:23:54', 37272),
(154, 8022, 'V. Ventisquero Apalta', 0, 0, 0, '2012-03-16', '00:15:00', 23282, 154, 'O', 0, 0, 6, '2000-01-01', '00:00:00', 46208),
(158, 9071, 'V. Santa Carolina', 0, 0, 0, '2012-03-16', '00:15:00', 23282, 158, 'O', 0, 0, 6, '2000-01-01', '00:00:00', 46201),
(159, 5302, 'V. Torres', -35.560001, -72.279999, 0, '2012-03-12', '17:45:00', 23437, 159, 'O', 0, 0, 6, '2012-02-22', '09:42:51', 46206),
(160, 8083, 'V. Puertas', 0, 0, 0, '2012-03-15', '23:45:00', 23283, 160, 'O', 0, 0, 6, '2000-01-01', '00:00:00', 46188),
(161, 279, 'Quepo [c]', -35.392676, -71.734865, 86, '2018-03-09', '11:00:00', 2029, 161, 'C', 1, 1, 3, '2018-03-14', '00:27:52', 49320),
(162, 337, 'Longavi (La Sexta)', -36.11893259, -71.59465481, 240, '2012-12-12', '07:00:00', 59743, 162, 'O', 0, 1, 3, '2012-12-14', '19:57:55', 37277),
(164, 267, 'Pelarco (El Manzano)', -35.4222789, -71.38647679, 188, '2019-07-30', '12:00:00', 3, 164, 'D', 1, 0, 3, '2017-03-29', '03:08:56', 37275),
(165, 334, 'Parral (Quillaimo)', -36.183, -71.6045, 267, '2012-12-12', '07:00:00', 59731, 165, 'O', 0, 1, 3, '2012-12-14', '19:58:34', 37284),
(166, 249, 'San Clemente', -35.4594, -71.4961, 172, '2015-08-10', '11:00:00', 7793, 166, 'O', 0, 1, 3, '2015-08-21', '12:04:56', 37291),
(167, 249, 'San Clemente [c]', -35.4594, -71.4961, 172, '2015-08-10', '11:00:00', 7793, 167, 'O', 0, 1, 3, '2015-08-21', '12:05:38', 37291),
(168, 267, 'Pelarco (El Manzano) [c]', -35.4222789, -71.38647679, 188, '2019-07-30', '12:00:00', 3, 168, 'D', 1, 0, 3, '2017-03-29', '03:09:40', 37275),
(169, 9738, 'Tarapaca', -33.77, -70.93, 0, '2012-03-16', '00:15:00', 23249, 169, 'O', 0, 0, 6, '2000-01-01', '00:00:00', 46205),
(170, 546, 'Longavi - El Almendro', -35.95, -71.79, 141, '2017-04-03', '20:15:00', 12893, 84, 'C', 1, 1, 3, '2017-04-06', '21:42:01', 57291),
(171, 546, 'Longavi - El Almendro [c]', -35.95, -71.79, 141, '2017-04-03', '20:15:00', 12868, 84, 'C', 1, 1, 3, '2017-04-06', '21:42:29', 57291),
(172, 174, 'San Vicente', -34.353, -71.117, 225, '2011-02-12', '15:00:00', 50548, 172, 'O', 0, 1, 8, '2013-06-10', '21:39:00', 37184),
(175, 631, 'Parral', -36.1618, -71.8677, 171, '2019-07-30', '11:00:00', 7, 170, 'D', 1, 0, 3, '2000-01-01', '00:00:00', 15859),
(176, 659, 'Bramadero ENDESA', -35.58438, -71.308544, 0, '2019-07-30', '12:00:00', 3, 84, 'D', 1, 0, 3, '2017-10-04', '14:40:24', 27275),
(177, 656, 'Bajo Lircay ENDESA', -35.486037, -71.313832, 0, '2019-07-30', '12:00:00', 3, 84, 'D', 1, 0, 3, '2017-04-01', '03:48:14', 28471),
(178, 745, 'Mariposas ENDESA', -35.530245, -71.425204, 0, '2019-07-30', '12:00:00', 3, 84, 'D', 1, 0, 3, '2017-03-29', '03:24:19', 29242),
(182, 691, 'Duao CTA', -35.550874, -71.594541, 162, '2019-07-30', '12:00:00', 3, 182, 'D', 1, 0, 3, '2017-04-01', '01:47:35', 44209),
(183, 754, 'San Víctor Alamos FIC', -35.886594, -71.472779, 244, '2019-07-30', '12:00:00', 3, 84, 'D', 1, 0, 3, '2017-03-06', '00:36:23', 59044),
(184, 772, 'Huapi FIC', -35.887962, -71.602668, 170, '2016-03-09', '16:38:04', 30207, 84, 'O', 0, 1, 3, '2016-03-12', '16:58:35', 59043),
(185, 763, 'Palmilla FIC', -35.803578, -71.742717, 113, '2019-07-30', '12:30:00', 1, 84, 'D', 1, 0, 3, '2017-07-08', '05:24:56', 59308),
(186, 709, 'La Posada FIC', -35.816648, -71.580869, 155, '2018-01-23', '15:00:00', 3707, 84, 'C', 1, 1, 3, '2018-02-04', '19:06:16', 59317),
(187, 682, 'Coinco CTA', -34.268, -70.958, 330, '2019-07-30', '12:00:00', 3, 84, 'D', 1, 0, 3, '2017-10-04', '14:56:09', 44230),
(188, 797, 'Pencahue', -35.427, -71.398, 201, '2019-07-30', '12:00:00', 3, 84, 'D', 1, 0, 3, '2017-03-20', '03:53:52', 40671),
(189, 809, 'Test RTU 09.2017', 0, 0, 0, '2017-11-14', '11:43:09', 4370, 84, 'C', 1, 1, 3, '2017-12-01', '01:08:34', 40001),
(191, 821, 'Rio Claro (AgriChile)', -35.221, -71.355, 238, '2018-07-05', '21:00:00', 660, 86, 'C', 1, 1, 3, '2019-07-26', '04:29:21', 40002),
(192, 843, 'Retiro CTA', -36.069529, -71.774263, 183, '2019-07-30', '12:00:00', 3, 84, 'D', 1, 0, 3, '2000-01-01', '00:00:00', 40006);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `instrumento`
--

CREATE TABLE `instrumento` (
  `id` int(11) NOT NULL,
  `unidad` tinytext NOT NULL,
  `marca` tinytext DEFAULT NULL,
  `modelo` tinytext DEFAULT NULL,
  `adcon_id` int(11) DEFAULT NULL COMMENT 'condicional, no obligatorio',
  `ubicacion_nombre` text DEFAULT NULL,
  `observacion` text DEFAULT NULL,
  `fecha_instalacion` date DEFAULT NULL,
  `tipo_instrumento_id` int(11) NOT NULL,
  `estacion_id` int(11) DEFAULT NULL,
  `responsable_id` int(11) NOT NULL,
  `revisar_datos` int(11) DEFAULT NULL COMMENT '[1] = Revisar datos\n[0] = No revisar datos'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `instrumento`
--

INSERT INTO `instrumento` (`id`, `unidad`, `marca`, `modelo`, `adcon_id`, `ubicacion_nombre`, `observacion`, `fecha_instalacion`, `tipo_instrumento_id`, `estacion_id`, `responsable_id`, `revisar_datos`) VALUES
(419, 'V', 'Adcon Telemetry GmbH', 'Solar Cell', 286, 'Peralillo', '', '2000-01-01', 9, 84, 1, 0),
(420, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 287, 'Peralillo', '', '2000-01-01', 7, 84, 1, 0),
(421, 'km/h', 'Schiltknecht AG', 'Wind Speed', 316, 'Peralillo', '', '2000-01-01', 2, 84, 1, 0),
(422, '&deg;', 'Schiltknecht AG', 'Wind Direction', 315, 'Peralillo', '', '2000-01-01', 3, 84, 1, 0),
(423, 'mm', 'Pronamic', 'Precipitation', 317, 'Peralillo', '', '2000-01-01', 6, 84, 1, 0),
(424, '&#37;', 'Vaisala OY', 'Relative Humidity', 318, 'Peralillo', '', '2000-01-01', 4, 84, 1, 0),
(425, '&deg;C', 'Vaisala OY', 'Temperature', 319, 'Peralillo', '', '2000-01-01', 5, 84, 1, 0),
(426, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 320, 'Peralillo', '', '2000-01-01', 1, 84, 1, 0),
(427, 'V', 'Adcon Telemetry GmbH', 'Solar Cell', 283, 'Santa Cruz', '', '2000-01-01', 9, 85, 1, 0),
(428, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 284, 'Santa Cruz', '', '2000-01-01', 7, 85, 1, 0),
(429, 'km/h', 'Schiltknecht AG', 'Wind Speed', 322, 'Santa Cruz', '', '2000-01-01', 2, 85, 1, 0),
(430, '&deg;', 'Schiltknecht AG', 'Wind Direction', 321, 'Santa Cruz', '', '2000-01-01', 3, 85, 1, 0),
(431, 'mm', 'Pronamic', 'Precipitation', 333, 'Santa Cruz', '', '2000-01-01', 6, 85, 1, 0),
(432, '&#37;', 'Vaisala OY', 'Relative Humidity', 324, 'Santa Cruz', '', '2000-01-01', 4, 85, 1, 0),
(433, '&deg;C', 'Vaisala OY', 'Temperature', 325, 'Santa Cruz', '', '2000-01-01', 5, 85, 1, 0),
(434, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 326, 'Santa Cruz', '', '2000-01-01', 1, 85, 1, 0),
(435, 'V', 'Adcon Telemetry GmbH', 'Solar Cell', 241, 'Panguilemo', '', '2000-01-01', 9, 86, 1, 0),
(436, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 242, 'Panguilemo', '', '2000-01-01', 7, 86, 1, 0),
(437, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 243, 'Panguilemo', '', '2000-01-01', 1, 86, 1, 0),
(438, '&deg;C', 'Vaisala OY', 'Temperature', 245, 'Panguilemo', '', '2000-01-01', 5, 86, 1, 0),
(439, '&#37;', 'Vaisala OY', 'Relative Humidity', 244, 'Panguilemo', '', '2000-01-01', 4, 86, 1, 0),
(440, 'mm', 'Pronamic', 'Precipitation', 246, 'Panguilemo', '', '2000-01-01', 6, 86, 1, 0),
(441, '&deg;', 'Schiltknecht AG', 'Wind Direction', 247, 'Panguilemo', '', '2000-01-01', 3, 86, 1, 0),
(442, 'km/h', 'Schiltknecht AG', 'Wind Speed', 248, 'Panguilemo', '', '2000-01-01', 2, 86, 1, 0),
(443, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 288, 'Coinco', '', '2000-01-01', 7, 87, 1, 0),
(444, 'V', 'Adcon Telemetry GmbH', 'Solar Cell', 289, 'Coinco', '', '2000-01-01', 9, 87, 1, 0),
(445, 'W/m2', 'Kipp und Zonen', 'Pyranometer', 290, 'Coinco', '', '2000-01-01', 1, 87, 1, 0),
(446, '&deg;C', 'Vaisala OY', 'Temperature', 291, 'Coinco', '', '2000-01-01', 5, 87, 1, 0),
(447, '&#37;', 'Vaisala OY', 'Relative Humidity', 292, 'Coinco', '', '2000-01-01', 4, 87, 1, 0),
(448, 'mm', 'Pronamic', 'Precipitation', 293, 'Coinco', '', '2000-01-01', 6, 87, 1, 0),
(449, '&deg;', 'Schiltknecht AG', 'Wind Direction', 294, 'Coinco', '', '2000-01-01', 3, 87, 1, 0),
(450, 'km/h', 'Schiltknecht AG', 'Wind Speed', 295, 'Coinco', '', '2000-01-01', 2, 87, 1, 0),
(457, 'mm', 'Pronamic', 'Precipitation', 135, 'Agr Malvilla', '', '2000-01-01', 6, 89, 1, 0),
(458, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 136, 'Agr Malvilla', '', '2000-01-01', 1, 89, 1, 0),
(459, '&#37;', 'Vaisala OY', 'Relative Humidity', 139, 'Agr Malvilla', '', '2000-01-01', 4, 89, 1, 0),
(461, '&deg;C', 'Vaisala OY', 'Temperature', 143, 'Agr Malvilla', '', '2000-01-01', 5, 89, 1, 0),
(462, 'km/h', 'Schiltknecht AG', 'Wind Speed 200', 137, 'Agr Malvilla', '', '2000-01-01', 2, 89, 1, 0),
(463, 'mm', 'Various', 'Precipitation', 984, 'Anakena', '', '2000-01-01', 6, 90, 1, 0),
(464, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 982, 'Anakena', '', '2000-01-01', 1, 90, 1, 0),
(465, '&#37;', 'Various', 'Relative Humidity', 983, 'Anakena', '', '2000-01-01', 4, 90, 1, 0),
(466, '&deg;C', 'Various', 'Temperature', 985, 'Anakena', '', '2000-01-01', 5, 90, 1, 0),
(467, 'km/h', 'Various', 'Wind Speed', 987, 'Anakena', '', '2000-01-01', 2, 90, 1, 0),
(468, 'mm', 'Various', 'Precipitation', 2003, 'Aresti', '', '2000-01-01', 6, 91, 1, 0),
(469, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 2007, 'Aresti', '', '2000-01-01', 1, 91, 1, 0),
(470, '&#37;', 'Various', 'Relative Humidity', 2008, 'Aresti', '', '2000-01-01', 4, 91, 1, 0),
(471, '&deg;C', 'Various', 'Temperature', 2005, 'Aresti', '', '2000-01-01', 5, 91, 1, 0),
(472, 'km/h', 'Various', 'Wind Speed', 2009, 'Aresti', '', '2000-01-01', 2, 91, 1, 0),
(473, 'mm', 'Various', 'Precipitation', 1646, 'Casa Rivas', '', '2000-01-01', 6, 92, 1, 0),
(474, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 1652, 'Casa Rivas', '', '2000-01-01', 1, 92, 1, 0),
(475, '&#37;', 'Various', 'Relative Humidity', 1648, 'Casa Rivas', '', '2000-01-01', 4, 92, 1, 0),
(476, '&deg;C', 'Various', 'Temperature', 1651, 'Casa Rivas', '', '2000-01-01', 5, 92, 1, 0),
(477, 'km/h', 'Various', 'Wind Speed', 1647, 'Casa Rivas', '', '2000-01-01', 2, 92, 1, 0),
(478, 'mm', 'Various', 'Precipitation', 1309, 'Casa Silva', '', '2000-01-01', 6, 93, 1, 0),
(479, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 1311, 'Casa Silva', '', '2000-01-01', 1, 93, 1, 0),
(480, '&#37;', 'Various', 'Relative Humidity', 1307, 'Casa Silva', '', '2000-01-01', 4, 93, 1, 0),
(481, '&deg;C', 'Various', 'Temperature', 1306, 'Casa Silva', '', '2000-01-01', 5, 93, 1, 0),
(482, 'km/h', 'Various', 'Wind Speed', 1308, 'Casa Silva', '', '2000-01-01', 2, 93, 1, 0),
(483, 'mm', 'Pronamic', 'Precipitation', 111, 'Casas del Bosque', '', '2000-01-01', 6, 94, 1, 0),
(484, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 114, 'Casas del Bosque', '', '2000-01-01', 1, 94, 1, 0),
(485, '&#37;', 'Vaisala OY', 'Relative Humidity', 112, 'Casas del Bosque', '', '2000-01-01', 4, 94, 1, 0),
(486, '&deg;C', 'Vaisala OY', 'Temperature', 119, 'Casas del Bosque', '', '2000-01-01', 5, 94, 1, 0),
(487, 'km/h', 'Schiltknecht AG', 'Wind Speed 200', 115, 'Casas del Bosque', '', '2000-01-01', 2, 94, 1, 0),
(488, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 3295, 'Casas Patronales', '', '2000-01-01', 7, 95, 1, 0),
(491, 'mm', 'Various', 'Precipitation', 3293, 'Casas Patronales', '', '2000-01-01', 6, 95, 1, 0),
(492, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 3300, 'Casas Patronales', '', '2000-01-01', 1, 95, 1, 0),
(493, '&#37;', 'Various', 'Relative Humidity', 3296, 'Casas Patronales', '', '2000-01-01', 4, 95, 1, 0),
(494, '&deg;C', 'Various', 'Temperature', 3297, 'Casas Patronales', '', '2000-01-01', 5, 95, 1, 0),
(495, 'km/h', 'Various', 'Wind Speed', 3294, 'Casas Patronales', '', '2000-01-01', 2, 95, 1, 0),
(496, 'mm', 'Various', 'Precipitation', 494, 'Chocalan', '', '2000-01-01', 6, 96, 1, 0),
(497, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 495, 'Chocalan', '', '2000-01-01', 1, 96, 1, 0),
(498, '&#37;', 'Various', 'Relative Humidity', 497, 'Chocalan', '', '2000-01-01', 4, 96, 1, 0),
(499, '&deg;C', 'Various', 'Temperature', 498, 'Chocalan', '', '2000-01-01', 5, 96, 1, 0),
(500, 'km/h', 'Various', 'Wind Speed', 492, 'Chocalan', '', '2000-01-01', 2, 96, 1, 0),
(501, 'mm', 'Various', 'Precipitation', 1328, 'Cono Sur', '', '2000-01-01', 6, 97, 1, 0),
(502, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 1325, 'Cono Sur', '', '2000-01-01', 1, 97, 1, 0),
(503, '&#37;', 'Various', 'Relative Humidity', 1330, 'Cono Sur', '', '2000-01-01', 4, 97, 1, 0),
(504, '&deg;C', 'Various', 'Temperature', 1327, 'Cono Sur', '', '2000-01-01', 5, 97, 1, 0),
(505, 'km/h', 'Various', 'Wind Speed', 1326, 'Cono Sur', '', '2000-01-01', 2, 97, 1, 0),
(506, 'mm', 'Various', 'Precipitation', 165, 'Corpora', '', '2000-01-01', 6, 98, 1, 0),
(507, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 168, 'Corpora', '', '2000-01-01', 1, 98, 1, 0),
(508, '&#37;', 'Various', 'Relative Humidity', 167, 'Corpora', '', '2000-01-01', 4, 98, 1, 0),
(509, '&deg;C', 'Various', 'Temperature', 166, 'Corpora', '', '2000-01-01', 5, 98, 1, 0),
(510, 'km/h', 'Various', 'Wind Speed', 163, 'Corpora', '', '2000-01-01', 2, 98, 1, 0),
(511, 'mm', 'Various', 'Precipitation', 477, 'DeMartino', '', '2000-01-01', 6, 99, 1, 0),
(512, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 473, 'DeMartino', '', '2000-01-01', 1, 99, 1, 0),
(513, '&#37;', 'Various', 'Relative Humidity', 476, 'DeMartino', '', '2000-01-01', 4, 99, 1, 0),
(514, '&deg;C', 'Various', 'Temperature', 472, 'DeMartino', '', '2000-01-01', 5, 99, 1, 0),
(515, 'km/h', 'Various', 'Wind Speed', 478, 'DeMartino', '', '2000-01-01', 2, 99, 1, 0),
(516, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 3150, 'El Aromo', '', '2000-01-01', 7, 100, 1, 0),
(519, 'mm', 'Various', 'Precipitation', 3143, 'El Aromo', '', '2000-01-01', 6, 100, 1, 0),
(520, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 3149, 'El Aromo', '', '2000-01-01', 1, 100, 1, 0),
(521, '&#37;', 'Various', 'Relative Humidity', 3148, 'El Aromo', '', '2000-01-01', 4, 100, 1, 0),
(522, '&deg;C', 'Various', 'Temperature', 3147, 'El Aromo', '', '2000-01-01', 5, 100, 1, 0),
(523, 'km/h', 'Various', 'Wind Speed', 3144, 'El Aromo', '', '2000-01-01', 2, 100, 1, 0),
(524, 'mm', 'Pronamic', 'Precipitation', 6945, 'El Ensue&ntilde;o', '', '2000-01-01', 6, 101, 1, 0),
(525, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 6942, 'El Ensue&ntilde;o', '', '2000-01-01', 1, 101, 1, 0),
(526, '&#37;', 'Vaisala OY', 'Relative Humidity', 6944, 'El Ensue&ntilde;o', '', '2000-01-01', 4, 101, 1, 0),
(528, '&deg;C', 'Vaisala OY', 'Temperature', 6943, 'El Ensue&ntilde;o', '', '2000-01-01', 5, 101, 1, 0),
(529, 'km/h', 'Schiltknecht AG', 'Wind Speed 200', 6941, 'El Ensue&ntilde;o', '', '2000-01-01', 2, 101, 1, 0),
(530, 'mm', 'Various', 'Precipitation', 1846, 'Emiliana', '', '2000-01-01', 6, 102, 1, 0),
(531, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 1848, 'Emiliana', '', '2000-01-01', 1, 102, 1, 0),
(532, '&#37;', 'Various', 'Relative Humidity', 1849, 'Emiliana', '', '2000-01-01', 4, 102, 1, 0),
(533, '&deg;C', 'Various', 'Temperature', 1847, 'Emiliana', '', '2000-01-01', 5, 102, 1, 0),
(534, 'km/h', 'Various', 'Wind Speed', 1850, 'Emiliana', '', '2000-01-01', 2, 102, 1, 0),
(535, 'mm', 'Various', 'Precipitation', 896, 'Errazuriz', '', '2000-01-01', 6, 103, 1, 0),
(536, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 895, 'Errazuriz', '', '2000-01-01', 1, 103, 1, 0),
(537, '&#37;', 'Various', 'Relative Humidity', 898, 'Errazuriz', '', '2000-01-01', 4, 103, 1, 0),
(538, '&deg;C', 'Various', 'Temperature', 899, 'Errazuriz', '', '2000-01-01', 5, 103, 1, 0),
(539, 'km/h', 'Various', 'Wind Speed', 893, 'Errazuriz', '', '2000-01-01', 2, 103, 1, 0),
(540, 'mm', 'Various', 'Precipitation', 273, 'Falernia', '', '2000-01-01', 6, 104, 1, 0),
(541, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 277, 'Falernia', '', '2000-01-01', 1, 104, 1, 0),
(542, '&#37;', 'Various', 'Relative Humidity', 280, 'Falernia', '', '2000-01-01', 4, 104, 1, 0),
(543, '&deg;C', 'Various', 'Temperature', 275, 'Falernia', '', '2000-01-01', 5, 104, 1, 0),
(544, 'km/h', 'Various', 'Wind Speed', 276, 'Falernia', '', '2000-01-01', 2, 104, 1, 0),
(545, 'mm', 'Various', 'Precipitation', 229, 'Guillisasti', '', '2000-01-01', 6, 105, 1, 0),
(546, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 231, 'Guillisasti', '', '2000-01-01', 1, 105, 1, 0),
(547, '&#37;', 'Various', 'Relative Humidity', 226, 'Guillisasti', '', '2000-01-01', 4, 105, 1, 0),
(548, '&deg;C', 'Various', 'Temperature', 225, 'Guillisasti', '', '2000-01-01', 5, 105, 1, 0),
(549, 'km/h', 'Various', 'Wind Speed', 227, 'Guillisasti', '', '2000-01-01', 2, 105, 1, 0),
(550, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 3318, 'JBouchon', '', '2000-01-01', 7, 106, 1, 0),
(553, 'mm', 'Various', 'Precipitation', 3319, 'JBouchon', '', '2000-01-01', 6, 106, 1, 0),
(554, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 3315, 'JBouchon', '', '2000-01-01', 1, 106, 1, 0),
(555, '&#37;', 'Various', 'Relative Humidity', 3313, 'JBouchon', '', '2000-01-01', 4, 106, 1, 0),
(556, '&deg;C', 'Various', 'Temperature', 3317, 'JBouchon', '', '2000-01-01', 5, 106, 1, 0),
(557, 'km/h', 'Various', 'Wind Speed', 3320, 'JBouchon', '', '2000-01-01', 2, 106, 1, 0),
(558, 'mm', 'Various', 'Precipitation', 1907, 'Lapostolle', '', '2000-01-01', 6, 107, 1, 0),
(559, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 1908, 'Lapostolle', '', '2000-01-01', 1, 107, 1, 0),
(560, '&#37;', 'Various', 'Relative Humidity', 1910, 'Lapostolle', '', '2000-01-01', 4, 107, 1, 0),
(561, '&deg;C', 'Various', 'Temperature', 1904, 'Lapostolle', '', '2000-01-01', 5, 107, 1, 0),
(562, 'km/h', 'Various', 'Wind Speed', 1903, 'Lapostolle', '', '2000-01-01', 2, 107, 1, 0),
(563, 'mm', 'Various', 'Precipitation', 1449, 'Larosa', '', '2000-01-01', 6, 108, 1, 0),
(564, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 1445, 'Larosa', '', '2000-01-01', 1, 108, 1, 0),
(565, '&#37;', 'Various', 'Relative Humidity', 1444, 'Larosa', '', '2000-01-01', 4, 108, 1, 0),
(566, '&deg;C', 'Various', 'Temperature', 1448, 'Larosa', '', '2000-01-01', 5, 108, 1, 0),
(567, 'km/h', 'Various', 'Wind Speed', 1443, 'Larosa', '', '2000-01-01', 2, 108, 1, 0),
(568, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 26, 'Las Petras', '', '2000-01-01', 7, 109, 1, 0),
(571, 'mm', 'Pronamic', 'Precipitation', 25, 'Las Petras', '', '2000-01-01', 6, 109, 1, 0),
(572, 'W/m2', 'Kipp und Zonen', 'Pyranometer CM3', 29, 'Las Petras', '', '2000-01-01', 1, 109, 1, 0),
(573, '&#37;', 'Vaisala OY', 'Relative Humidity', 32, 'Las Petras', '', '2000-01-01', 4, 109, 1, 0),
(575, '&deg;C', 'Vaisala OY', 'Temperature', 27, 'Las Petras', '', '2000-01-01', 5, 109, 1, 0),
(576, 'km/h', 'Schiltknecht AG', 'Wind Speed 200', 30, 'Las Petras', '', '2000-01-01', 2, 109, 1, 0),
(577, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 4341, 'Loma Larga', '', '2000-01-01', 7, 110, 1, 0),
(580, 'mm', 'Pronamic', 'Precipitation', 4337, 'Loma Larga', '', '2000-01-01', 6, 110, 1, 0),
(581, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 4336, 'Loma Larga', '', '2000-01-01', 1, 110, 1, 0),
(582, '&#37;', 'Vaisala OY', 'Relative Humidity', 4342, 'Loma Larga', '', '2000-01-01', 4, 110, 1, 0),
(583, 'V', 'Adcon Telemetry GmbH', 'Solar Cell', 4338, 'Loma Larga', '', '2000-01-01', 9, 110, 1, 0),
(584, '&deg;C', 'Vaisala OY', 'Temperature', 4339, 'Loma Larga', '', '2000-01-01', 5, 110, 1, 0),
(585, 'km/h', 'Schiltknecht AG', 'Wind Speed 200', 4340, 'Loma Larga', '', '2000-01-01', 2, 110, 1, 0),
(591, 'mm', 'Various', 'Precipitation', 176, 'San Antonio', '', '2000-01-01', 6, 112, 1, 0),
(592, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 175, 'San Antonio', '', '2000-01-01', 1, 112, 1, 0),
(593, '&#37;', 'Various', 'Relative Humidity', 173, 'San Antonio', '', '2000-01-01', 4, 112, 1, 0),
(594, '&deg;C', 'Various', 'Temperature', 178, 'San Antonio', '', '2000-01-01', 5, 112, 1, 0),
(595, 'km/h', 'Various', 'Wind Speed', 174, 'San Antonio', '', '2000-01-01', 2, 112, 1, 0),
(596, 'mm', 'Various', 'Precipitation', 1498, 'Lurton', '', '2000-01-01', 6, 113, 1, 0),
(597, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 1504, 'Lurton', '', '2000-01-01', 1, 113, 1, 0),
(598, '&#37;', 'Various', 'Relative Humidity', 1499, 'Lurton', '', '2000-01-01', 4, 113, 1, 0),
(599, '&deg;C', 'Various', 'Temperature', 1505, 'Lurton', '', '2000-01-01', 5, 113, 1, 0),
(600, 'km/h', 'Various', 'Wind Speed', 1502, 'Lurton', '', '2000-01-01', 2, 113, 1, 0),
(601, 'mm', 'Various', 'Precipitation', 1299, 'Montes', '', '2000-01-01', 6, 114, 1, 0),
(602, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 1296, 'Montes', '', '2000-01-01', 1, 114, 1, 0),
(603, '&#37;', 'Various', 'Relative Humidity', 1298, 'Montes', '', '2000-01-01', 4, 114, 1, 0),
(604, '&deg;C', 'Various', 'Temperature', 1295, 'Montes', '', '2000-01-01', 5, 114, 1, 0),
(605, 'km/h', 'Various', 'Wind Speed', 1302, 'Montes', '', '2000-01-01', 2, 114, 1, 0),
(606, 'mm', 'Various', 'Precipitation', 1223, 'Romeral', '', '2000-01-01', 6, 115, 1, 0),
(607, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 1226, 'Romeral', '', '2000-01-01', 1, 115, 1, 0),
(608, '&#37;', 'Various', 'Relative Humidity', 1222, 'Romeral', '', '2000-01-01', 4, 115, 1, 0),
(609, '&deg;C', 'Various', 'Temperature', 1227, 'Romeral', '', '2000-01-01', 5, 115, 1, 0),
(610, 'km/h', 'Various', 'Wind Speed', 1224, 'Romeral', '', '2000-01-01', 2, 115, 1, 0),
(611, 'mm', 'Various', 'Precipitation', 465, 'San Bernardo', '', '2000-01-01', 6, 116, 1, 0),
(612, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 461, 'San Bernardo', '', '2000-01-01', 1, 116, 1, 0),
(613, '&#37;', 'Various', 'Relative Humidity', 464, 'San Bernardo', '', '2000-01-01', 4, 116, 1, 0),
(614, '&deg;C', 'Various', 'Temperature', 468, 'San Bernardo', '', '2000-01-01', 5, 116, 1, 0),
(615, 'km/h', 'Various', 'Wind Speed', 463, 'San Bernardo', '', '2000-01-01', 2, 116, 1, 0),
(616, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 3287, 'Odfjell', '', '2000-01-01', 7, 117, 1, 0),
(619, 'mm', 'Various', 'Precipitation', 3285, 'Odfjell', '', '2000-01-01', 6, 117, 1, 0),
(620, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 3284, 'Odfjell', '', '2000-01-01', 1, 117, 1, 0),
(621, '&#37;', 'Various', 'Relative Humidity', 3289, 'Odfjell', '', '2000-01-01', 4, 117, 1, 0),
(622, '&deg;C', 'Various', 'Temperature', 3286, 'Odfjell', '', '2000-01-01', 5, 117, 1, 0),
(623, 'km/h', 'Various', 'Wind Speed', 3288, 'Odfjell', '', '2000-01-01', 2, 117, 1, 0),
(624, 'mm', 'Pronamic', 'Precipitation', 4821, 'Los Angeles', '', '2000-01-01', 6, 118, 1, 0),
(625, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 4815, 'Los Angeles', '', '2000-01-01', 1, 118, 1, 0),
(626, '&#37;', 'Vaisala OY', 'Relative Humidity', 4819, 'Los Angeles', '', '2000-01-01', 4, 118, 1, 0),
(627, '&deg;C', 'Vaisala OY', 'Temperature', 4816, 'Los Angeles', '', '2000-01-01', 5, 118, 1, 0),
(628, '&deg;', 'Schiltknecht AG', 'Wind Direction', 4817, 'Los Angeles', '', '2000-01-01', 3, 118, 1, 0),
(629, 'km/h', 'Schiltknecht AG', 'Wind Speed 200', 4814, 'Los Angeles', '', '2000-01-01', 2, 118, 1, 0),
(630, 'mm', 'Pronamic', 'Precipitation', 4824, 'Orafti Selva Negra', '', '2000-01-01', 6, 119, 1, 0),
(631, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 4828, 'Orafti Selva Negra', '', '2000-01-01', 1, 119, 1, 0),
(632, '&#37;', 'Vaisala OY', 'Relative Humidity', 4825, 'Orafti Selva Negra', '', '2000-01-01', 4, 119, 1, 0),
(633, '&deg;C', 'Vaisala OY', 'Temperature', 4829, 'Orafti Selva Negra', '', '2000-01-01', 5, 119, 1, 0),
(634, '&deg;', 'Schiltknecht AG', 'Wind Direction', 4826, 'Orafti Selva Negra', '', '2000-01-01', 3, 119, 1, 0),
(635, 'km/h', 'Schiltknecht AG', 'Wind Speed 200', 4827, 'Orafti Selva Negra', '', '2000-01-01', 2, 119, 1, 0),
(636, 'mm', 'Various', 'Precipitation', 4104, 'Perez Cruz', '', '2000-01-01', 6, 120, 1, 0),
(637, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 4110, 'Perez Cruz', '', '2000-01-01', 1, 120, 1, 0),
(638, '&#37;', 'Various', 'Relative Humidity', 4105, 'Perez Cruz', '', '2000-01-01', 4, 120, 1, 0),
(639, '&deg;C', 'Various', 'Temperature', 4106, 'Perez Cruz', '', '2000-01-01', 5, 120, 1, 0),
(640, 'km/h', 'Various', 'Wind Speed', 4108, 'Perez Cruz', '', '2000-01-01', 2, 120, 1, 0),
(641, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 1166, 'Ravanal', '', '2000-01-01', 7, 121, 1, 0),
(644, 'mm', 'Various', 'Precipitation', 1167, 'Ravanal', '', '2000-01-01', 6, 121, 1, 0),
(645, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 1168, 'Ravanal', '', '2000-01-01', 1, 121, 1, 0),
(646, '&#37;', 'Various', 'Relative Humidity', 1165, 'Ravanal', '', '2000-01-01', 4, 121, 1, 0),
(647, '&deg;C', 'Various', 'Temperature', 1170, 'Ravanal', '', '2000-01-01', 5, 121, 1, 0),
(648, 'km/h', 'Various', 'Wind Speed', 1164, 'Ravanal', '', '2000-01-01', 2, 121, 1, 0),
(649, 'mm', 'Various', 'Precipitation', 2163, 'El Transito', '', '2000-01-01', 6, 122, 1, 0),
(650, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 2164, 'El Transito', '', '2000-01-01', 1, 122, 1, 0),
(651, '&#37;', 'Various', 'Relative Humidity', 2170, 'El Transito', '', '2000-01-01', 4, 122, 1, 0),
(652, '&deg;C', 'Various', 'Temperature', 2169, 'El Transito', '', '2000-01-01', 5, 122, 1, 0),
(653, 'km/h', 'Various', 'Wind Speed', 2168, 'El Transito', '', '2000-01-01', 2, 122, 1, 0),
(654, 'mm', 'Various', 'Precipitation', 2193, 'Molina', '', '2000-01-01', 6, 123, 1, 0),
(655, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 2198, 'Molina', '', '2000-01-01', 1, 123, 1, 0),
(656, '&#37;', 'Various', 'Relative Humidity', 2200, 'Molina', '', '2000-01-01', 4, 123, 1, 0),
(657, '&deg;C', 'Various', 'Temperature', 2196, 'Molina', '', '2000-01-01', 5, 123, 1, 0),
(658, 'km/h', 'Various', 'Wind Speed', 2194, 'Molina', '', '2000-01-01', 2, 123, 1, 0),
(659, 'mm', 'Various', 'Precipitation', 2183, 'Pencahue', '', '2000-01-01', 6, 124, 1, 0),
(660, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 2186, 'Pencahue', '', '2000-01-01', 1, 124, 1, 0),
(661, '&#37;', 'Various', 'Relative Humidity', 2184, 'Pencahue', '', '2000-01-01', 4, 124, 1, 0),
(662, '&deg;C', 'Various', 'Temperature', 2188, 'Pencahue', '', '2000-01-01', 5, 124, 1, 0),
(663, 'km/h', 'Various', 'Wind Speed', 2190, 'Pencahue', '', '2000-01-01', 2, 124, 1, 0),
(664, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 2175, 'Totihue', '', '2000-01-01', 7, 125, 1, 0),
(667, 'mm', 'Various', 'Precipitation', 2177, 'Totihue', '', '2000-01-01', 6, 125, 1, 0),
(668, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 2173, 'Totihue', '', '2000-01-01', 1, 125, 1, 0),
(669, '&#37;', 'Various', 'Relative Humidity', 2178, 'Totihue', '', '2000-01-01', 4, 125, 1, 0),
(670, '&deg;C', 'Various', 'Temperature', 2180, 'Totihue', '', '2000-01-01', 5, 125, 1, 0),
(671, 'km/h', 'Various', 'Wind Speed', 2179, 'Totihue', '', '2000-01-01', 2, 125, 1, 0),
(673, 'mm', 'X', 'Precipitation 0.1mm', 4332, 'Casablanca', '', '2000-01-01', 6, 126, 1, 0),
(674, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 4323, 'Casablanca', '', '2000-01-01', 1, 126, 1, 0),
(675, '&#37;', 'Vaisala OY', 'Relative Humidity', 4331, 'Casablanca', '', '2000-01-01', 4, 126, 1, 0),
(676, 'V', 'Adcon Telemetry GmbH', 'Solar Cell', 4325, 'Casablanca', '', '2000-01-01', 9, 126, 1, 0),
(677, '&deg;C', 'Vaisala OY', 'Temperature', 4328, 'Casablanca', '', '2000-01-01', 5, 126, 1, 0),
(678, 'km/h', 'Schiltknecht AG', 'Wind Speed 200', 4329, 'Casablanca', '', '2000-01-01', 2, 126, 1, 0),
(679, 'mm', 'Pronamic', 'Precipitation', 127, 'Santa Elena', '', '2000-01-01', 6, 127, 1, 0),
(680, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 123, 'Santa Elena', '', '2000-01-01', 1, 127, 1, 0),
(681, '&#37;', 'Vaisala OY', 'Relative Humidity', 125, 'Santa Elena', '', '2000-01-01', 4, 127, 1, 0),
(683, '&deg;C', 'Vaisala OY', 'Temperature', 131, 'Santa Elena', '', '2000-01-01', 5, 127, 1, 0),
(684, 'km/h', 'Schiltknecht AG', 'Wind Speed 200', 129, 'Santa Elena', '', '2000-01-01', 2, 127, 1, 0),
(685, 'mm', 'Various', 'Precipitation', 270, 'Tamaya', '', '2000-01-01', 6, 128, 1, 0),
(686, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 268, 'Tamaya', '', '2000-01-01', 1, 128, 1, 0),
(687, '&#37;', 'Various', 'Relative Humidity', 266, 'Tamaya', '', '2000-01-01', 4, 128, 1, 0),
(688, '&deg;C', 'Various', 'Temperature', 267, 'Tamaya', '', '2000-01-01', 5, 128, 1, 0),
(689, 'km/h', 'Various', 'Wind Speed', 265, 'Tamaya', '', '2000-01-01', 2, 128, 1, 0),
(690, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 3269, 'Terramater', '', '2000-01-01', 7, 129, 1, 0),
(693, 'mm', 'Various', 'Precipitation', 3265, 'Terramater', '', '2000-01-01', 6, 129, 1, 0),
(694, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 3270, 'Terramater', '', '2000-01-01', 1, 129, 1, 0),
(695, '&#37;', 'Various', 'Relative Humidity', 3266, 'Terramater', '', '2000-01-01', 4, 129, 1, 0),
(696, '&deg;C', 'Various', 'Temperature', 3267, 'Terramater', '', '2000-01-01', 5, 129, 1, 0),
(697, 'km/h', 'Various', 'Wind Speed', 3264, 'Terramater', '', '2000-01-01', 2, 129, 1, 0),
(698, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 3303, 'Undurraga', '', '2000-01-01', 7, 130, 1, 0),
(701, 'mm', 'Various', 'Precipitation', 3307, 'Undurraga', '', '2000-01-01', 6, 130, 1, 0),
(702, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 3309, 'Undurraga', '', '2000-01-01', 1, 130, 1, 0),
(703, '&#37;', 'Various', 'Relative Humidity', 3310, 'Undurraga', '', '2000-01-01', 4, 130, 1, 0),
(704, '&deg;C', 'Various', 'Temperature', 3305, 'Undurraga', '', '2000-01-01', 5, 130, 1, 0),
(705, 'km/h', 'Various', 'Wind Speed', 3306, 'Undurraga', '', '2000-01-01', 2, 130, 1, 0),
(706, 'mm', 'Various', 'Precipitation', 454, 'Ventisquero', '', '2000-01-01', 6, 131, 1, 0),
(707, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 457, 'Ventisquero', '', '2000-01-01', 1, 131, 1, 0),
(708, '&#37;', 'Various', 'Relative Humidity', 451, 'Ventisquero', '', '2000-01-01', 4, 131, 1, 0),
(709, '&deg;C', 'Various', 'Temperature', 452, 'Ventisquero', '', '2000-01-01', 5, 131, 1, 0),
(710, 'km/h', 'Various', 'Wind Speed', 456, 'Ventisquero', '', '2000-01-01', 2, 131, 1, 0),
(711, 'mm', 'Various', 'Precipitation', 885, 'Von Sibenthal', '', '2000-01-01', 6, 132, 1, 0),
(712, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 889, 'Von Sibenthal', '', '2000-01-01', 1, 132, 1, 0),
(713, '&#37;', 'Various', 'Relative Humidity', 884, 'Von Sibenthal', '', '2000-01-01', 4, 132, 1, 0),
(714, '&deg;C', 'Various', 'Temperature', 887, 'Von Sibenthal', '', '2000-01-01', 5, 132, 1, 0),
(715, 'km/h', 'Various', 'Wind Speed', 886, 'Von Sibenthal', '', '2000-01-01', 2, 132, 1, 0),
(716, 'mm', 'Various', 'Precipitation', 3128, 'William Fevre', '', '2000-01-01', 6, 133, 1, 0),
(717, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 3126, 'William Fevre', '', '2000-01-01', 1, 133, 1, 0),
(718, '&#37;', 'Various', 'Relative Humidity', 3124, 'William Fevre', '', '2000-01-01', 4, 133, 1, 0),
(719, '&deg;C', 'Various', 'Temperature', 3125, 'William Fevre', '', '2000-01-01', 5, 133, 1, 0),
(720, 'km/h', 'Various', 'Wind Speed', 3130, 'William Fevre', '', '2000-01-01', 2, 133, 1, 0),
(721, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 185, 'Coltauco (El Sauce)', '', '2000-01-01', 7, 134, 1, 0),
(722, 'V', 'Adcon Telemetry GmbH', 'Solar Cell', 186, 'Coltauco (El Sauce)', '', '2000-01-01', 9, 134, 1, 0),
(723, 'W/m2', 'Kipp und Zonen', 'Pyanometer SP-Lite', 187, 'Coltauco (El Sauce)', '', '2000-01-01', 1, 134, 1, 0),
(724, '&#37;', 'Vaisala OY', 'Relative Humidity', 188, 'Coltauco (El Sauce)', '', '2000-01-01', 4, 134, 1, 0),
(725, '&deg;C', 'Vaisala OY', 'Temperature', 189, 'Coltauco (El Sauce)', '', '2000-01-01', 5, 134, 1, 0),
(726, 'mm', 'Pronamic', 'Precipitation', 190, 'Coltauco (El Sauce)', '', '2000-01-01', 6, 134, 1, 0),
(727, 'km/h', 'Schiltknecht AG', 'Wind Speed', 191, 'Coltauco (El Sauce)', '', '2000-01-01', 2, 134, 1, 0),
(728, '&deg;', 'Schiltknecht AG', 'Wind Direction', 192, 'Coltauco (El Sauce)', '', '2000-01-01', 3, 134, 1, 0),
(729, 'V', 'Adcon Telemetry GmbH', 'Batery Voltage', 278, 'Coltauco (Los Bronces)', '', '2000-01-01', 7, 135, 1, 0),
(730, 'V', 'Adcon Telemetry GmbH', 'Solar Cell', 279, 'Coltauco (Los Bronces)', '', '2000-01-01', 9, 135, 1, 0),
(731, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 280, 'Coltauco (Los Bronces)', '', '2000-01-01', 1, 135, 1, 0),
(732, '&deg;C', 'Vaisala OY', 'Temperature', 281, 'Coltauco (Los Bronces)', '', '2000-01-01', 5, 135, 1, 0),
(733, '&#37;', 'Vaisala OY', 'Relative Humidity', 282, 'Coltauco (Los Bronces)', '', '2000-01-01', 4, 135, 1, 0),
(734, 'mm', 'Pronamic', 'Precipitation', 283, 'Coltauco (Los Bronces)', '', '2000-01-01', 6, 135, 1, 0),
(735, 'km/h', 'Schiltknecht AG', 'Wind Speed', 284, 'Coltauco (Los Bronces)', '', '2000-01-01', 2, 135, 1, 0),
(736, '&deg;', 'Schiltknecht AG', 'Wind Direction', 285, 'Coltauco (Los Bronces)', '', '2000-01-01', 3, 135, 1, 0),
(741, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 4165, 'Garces Silva', '', '2000-01-01', 7, 136, 1, 0),
(743, 'mm', 'Various', 'Precipitation', 4185, 'Garces Silva', '', '2000-01-01', 6, 136, 1, 0),
(744, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 4181, 'Garces Silva', '', '2000-01-01', 1, 136, 1, 0),
(745, '&#37;', 'Various', 'Relative Humidity', 4182, 'Garces Silva', '', '2000-01-01', 4, 136, 1, 0),
(746, '&deg;C', 'Various', 'Temperature', 4186, 'Garces Silva', '', '2000-01-01', 5, 136, 1, 0),
(747, 'km/h', 'Various', 'Wind Speed', 4183, 'Garces Silva', '', '2000-01-01', 2, 136, 1, 0),
(748, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 4467, 'Santa Rita', '', '2000-01-01', 7, 137, 1, 0),
(750, 'mm', 'Various', 'Precipitation', 4465, 'Santa Rita', '', '2000-01-01', 6, 137, 1, 0),
(751, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 4463, 'Santa Rita', '', '2000-01-01', 1, 137, 1, 0),
(752, '&#37;', 'Various', 'Relative Humidity', 4469, 'Santa Rita', '', '2000-01-01', 4, 137, 1, 0),
(753, '&deg;C', 'Various', 'Temperature', 4466, 'Santa Rita', '', '2000-01-01', 5, 137, 1, 0),
(754, 'km/h', 'Various', 'Wind Speed', 9010, 'Santa Rita', '', '2000-01-01', 2, 137, 1, 0),
(756, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 4627, 'Concha y Toro', '', '2000-01-01', 7, 138, 1, 0),
(757, 'mm', 'Various', 'Precipitation', 4629, 'Concha y Toro', '', '2000-01-01', 6, 138, 1, 0),
(758, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 4623, 'Concha y Toro', '', '2000-01-01', 1, 138, 1, 0),
(759, '&#37;', 'Various', 'Relative Humidity', 4624, 'Concha y Toro', '', '2000-01-01', 4, 138, 1, 0),
(760, '&deg;C', 'Various', 'Temperature', 4625, 'Concha y Toro', '', '2000-01-01', 5, 138, 1, 0),
(761, 'km/h', 'Various', 'Wind Speed', 4628, 'Concha y Toro', '', '2000-01-01', 2, 138, 1, 0),
(762, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 3276, 'Carta Vieja 45638', '', '2000-01-01', 7, 139, 1, 0),
(763, 'mm', 'Various', 'Precipitation', 3278, 'Carta Vieja 45638', '', '2000-01-01', 6, 139, 1, 0),
(764, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 3273, 'Carta Vieja 45638', '', '2000-01-01', 1, 139, 1, 0),
(765, '&#37;', 'Various', 'Relative Humidity', 3280, 'Carta Vieja 45638', '', '2000-01-01', 4, 139, 1, 0),
(766, '&deg;C', 'Various', 'Temperature', 3274, 'Carta Vieja 45638', '', '2000-01-01', 5, 139, 1, 0),
(767, 'km/h', 'Various', 'Wind Speed', 3275, 'Carta Vieja 45638', '', '2000-01-01', 2, 139, 1, 0),
(768, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 4354, 'Luis Felipe Edwards', '', '2000-01-01', 7, 140, 1, 0),
(769, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 4350, 'Luis Felipe Edwards', '', '2000-01-01', 1, 140, 1, 0),
(770, '&#37;', 'Vaisala OY', 'Relative Humidity', 4345, 'Luis Felipe Edwards', '', '2000-01-01', 4, 140, 1, 0),
(774, '&deg;C', 'Vaisala OY', 'Temperature', 4348, 'Luis Felipe Edwards', '', '2000-01-01', 5, 140, 1, 0),
(775, '&deg;', 'Schiltknecht AG', 'Wind Direction', 4349, 'Luis Felipe Edwards', '', '2000-01-01', 3, 140, 1, 0),
(776, 'km/h', 'Schiltknecht AG', 'Wind Speed 200', 4353, 'Luis Felipe Edwards', '', '2000-01-01', 2, 140, 1, 0),
(778, 'mm', 'Pronamic', 'Precipitation', 5541, 'Agricola La Concordia', '', '2000-01-01', 6, 142, 1, 0),
(779, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 4944, 'Agricola La Concordia', '', '2000-01-01', 1, 142, 1, 0),
(780, 'km/h', 'Schiltknecht AG', 'Wind Speed 200', 4946, 'Agricola La Concordia', '', '2000-01-01', 2, 142, 1, 0),
(781, 'V', 'Adcon Telemetry GmbH', 'Solar Cell', 409, 'FRUCOL', '', '2000-01-01', 9, 143, 1, 0),
(782, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 410, 'FRUCOL', '', '2000-01-01', 7, 143, 1, 0),
(783, 'km/h', 'Schiltknecht AG', 'Wind Speed', 411, 'FRUCOL', '', '2000-01-01', 2, 143, 1, 0),
(784, '&deg;', 'Schiltknecht AG', 'Wind Direction', 412, 'FRUCOL', '', '2000-01-01', 3, 143, 1, 0),
(785, 'mm', 'Pronamic', 'Precipitation', 413, 'FRUCOL', '', '2000-01-01', 6, 143, 1, 0),
(786, '&#37;', 'Vaisala OY', 'Relative Humidity', 414, 'FRUCOL', '', '2000-01-01', 4, 143, 1, 0),
(787, '&deg;C', 'Vaisala OY', 'Temperature', 415, 'FRUCOL', '', '2000-01-01', 5, 143, 1, 0),
(788, 'W/m2', 'Kipp und Zonen', 'Pyranometer', 416, 'FRUCOL', '', '2000-01-01', 1, 143, 1, 0),
(821, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 564, '48471 MS', '', '2000-01-01', 7, 148, 1, 0),
(822, 'V', 'Adcon Telemetry GmbH', 'Charging Regulator', 563, '48471 MS', '', '2000-01-01', 9, 148, 1, 0),
(825, '&#37;', 'Various', 'Relative Humidity', 565, '48471 MS', '', '2000-01-01', 4, 148, 1, 0),
(826, '&deg;C', 'Various', 'Temperature', 566, '48471 MS', '', '2000-01-01', 5, 148, 1, 0),
(827, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 567, '48471 MS', '', '2000-01-01', 1, 148, 1, 0),
(828, 'km/h', 'Various', 'Wind Speed', 568, '48471 MS', '', '2000-01-01', 2, 148, 1, 0),
(829, '&deg;', 'Various', 'Wind Direction', 569, '48471 MS', '', '2000-01-01', 3, 148, 1, 0),
(830, 'mm', 'Various', 'Precipitation', 570, '48471 MS', '', '2000-01-01', 6, 148, 1, 0),
(831, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 492, '48466 MS', '', '2000-01-01', 7, 149, 1, 0),
(832, 'V', 'Adcon Telemetry GmbH', 'Charging Regulator', 491, '48466 MS', '', '2000-01-01', 9, 149, 1, 0),
(835, '&#37;', 'Various', 'Relative Humidity', 514, '48466 MS', '', '2000-01-01', 4, 149, 1, 0),
(836, '&deg;C', 'Various', 'Temperature', 515, '48466 MS', '', '2000-01-01', 5, 149, 1, 0),
(837, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 516, '48466 MS', '', '2000-01-01', 1, 149, 1, 0),
(838, 'km/h', 'Various', 'Wind Speed', 517, '48466 MS', '', '2000-01-01', 2, 149, 1, 0),
(839, '&deg;', 'Various', 'Wind Direction', 518, '48466 MS', '', '2000-01-01', 3, 149, 1, 0),
(840, 'mm', 'Various', 'Precipitation', 519, '48466 MS', '', '2000-01-01', 6, 149, 1, 0),
(841, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 487, '48440 MS', '', '2000-01-01', 7, 150, 1, 0),
(842, 'V', 'Adcon Telemetry GmbH', 'Charging Regulator', 486, '48440 MS', '', '2000-01-01', 9, 150, 1, 0),
(845, '&#37;', 'Various', 'Relative Humidity', 508, '48440 MS', '', '2000-01-01', 4, 150, 1, 0),
(846, '&deg;C', 'Various', 'Temperature', 509, '48440 MS', '', '2000-01-01', 5, 150, 1, 0),
(847, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 510, '48440 MS', '', '2000-01-01', 1, 150, 1, 0),
(848, 'km/h', 'Various', 'Wind Speed', 511, '48440 MS', '', '2000-01-01', 2, 150, 1, 0),
(849, '&deg;', 'Various', 'Wind Direction', 512, '48440 MS', '', '2000-01-01', 3, 150, 1, 0),
(850, 'mm', 'Various', 'Precipitation', 513, '48440 MS', '', '2000-01-01', 6, 150, 1, 0),
(851, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 482, '48469 MS', '', '2000-01-01', 7, 151, 1, 0),
(852, 'V', 'Adcon Telemetry GmbH', 'Charging Regulator', 481, '48469 MS', '', '2000-01-01', 9, 151, 1, 0),
(855, '&#37;', 'Various', 'Relative Humidity', 501, '48469 MS', '', '2000-01-01', 4, 151, 1, 0),
(856, '&deg;C', 'Various', 'Temperature', 502, '48469 MS', '', '2000-01-01', 5, 151, 1, 0),
(857, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 503, '48469 MS', '', '2000-01-01', 1, 151, 1, 0),
(858, 'km/h', 'Various', 'Wind Speed', 504, '48469 MS', '', '2000-01-01', 2, 151, 1, 0),
(859, '&deg;', 'Various', 'Wind Direction', 505, '48469 MS', '', '2000-01-01', 3, 151, 1, 0),
(860, 'mm', 'Various', 'Precipitation', 507, '48469 MS', '', '2000-01-01', 6, 151, 1, 0),
(861, 'V', 'Adcon Telemetry GmbH', 'Solar Cell', 280, 'Quepo - 49320', '', '2000-01-01', 9, 152, 1, 0),
(862, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 281, 'Quepo - 49320', '', '2000-01-01', 7, 152, 1, 0),
(863, '&deg;', 'Schiltknecht AG', 'Wind Direction', 327, 'Quepo - 49320', '', '2000-01-01', 3, 152, 1, 0),
(864, 'km/h', 'Schiltknecht AG', 'Wind Speed', 328, 'Quepo - 49320', '', '2000-01-01', 2, 152, 1, 0),
(865, 'mm', 'Pronamic', 'Precipitation', 329, 'Quepo - 49320', '', '2000-01-01', 6, 152, 1, 0),
(866, '&#37;', 'Vaisala OY', 'Relative Humidity', 330, 'Quepo - 49320', '', '2000-01-01', 4, 152, 1, 0),
(867, '&deg;C', 'Vaisala OY', 'Temperature', 331, 'Quepo - 49320', '', '2000-01-01', 5, 152, 1, 0),
(868, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 332, 'Quepo - 49320', '', '2000-01-01', 1, 152, 1, 0),
(869, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 500, '37272 MS', '', '2000-01-01', 7, 153, 1, 0),
(870, 'V', 'Adcon Telemetry GmbH', 'Charging Regulator', 499, '37272 MS', '', '2000-01-01', 9, 153, 1, 0),
(871, '&#37;', 'Various', 'Relative Humidity', 526, '37272 MS', '', '2000-01-01', 4, 153, 1, 0),
(872, '&deg;C', 'Various', 'Temperature', 527, '37272 MS', '', '2000-01-01', 5, 153, 1, 0),
(873, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 528, '37272 MS', '', '2000-01-01', 1, 153, 1, 0),
(874, '&deg;', 'Various', 'Wind Direction', 530, '37272 MS', '', '2000-01-01', 3, 153, 1, 0),
(875, 'km/h', 'Various', 'Wind Speed', 529, '37272 MS', '', '2000-01-01', 2, 153, 1, 0),
(876, 'mm', 'Various', 'Precipitation', 531, '37272 MS', '', '2000-01-01', 6, 153, 1, 0),
(877, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 8029, 'Ventisquero Apalta 46208', '', '2000-01-01', 7, 154, 1, 0),
(878, 'mm', 'Various', 'Precipitation', 8028, 'Ventisquero Apalta 46208', '', '2000-01-01', 6, 154, 1, 0),
(879, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 8025, 'Ventisquero Apalta 46208', '', '2000-01-01', 1, 154, 1, 0),
(880, '&#37;', 'Various', 'Relative Humidity', 8026, 'Ventisquero Apalta 46208', '', '2000-01-01', 4, 154, 1, 0),
(881, '&deg;C', 'Various', 'Temperature', 8030, 'Ventisquero Apalta 46208', '', '2000-01-01', 5, 154, 1, 0),
(882, 'km/h', 'Various', 'Wind Speed', 8023, 'Ventisquero Apalta 46208', '', '2000-01-01', 2, 154, 1, 0),
(901, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 9073, 'Santa Carolina 46201 (1)', '', '2000-01-01', 7, 158, 1, 0),
(902, 'mm', 'Various', 'Precipitation', 9077, 'Santa Carolina 46201 (1)', '', '2000-01-01', 6, 158, 1, 0),
(903, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 9078, 'Santa Carolina 46201 (1)', '', '2000-01-01', 1, 158, 1, 0),
(904, '&#37;', 'Various', 'Relative Humidity', 9072, 'Santa Carolina 46201 (1)', '', '2000-01-01', 4, 158, 1, 0),
(905, '&deg;C', 'Various', 'Temperature', 9075, 'Santa Carolina 46201 (1)', '', '2000-01-01', 5, 158, 1, 0),
(906, 'km/h', 'Various', 'Wind Speed', 9204, 'Santa Carolina 46201 (1)', '', '2000-01-01', 2, 158, 1, 0),
(907, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 5303, 'Torres 46206', '', '2000-01-01', 7, 159, 1, 0),
(908, 'mm', 'Various', 'Precipitation', 5304, 'Torres 46206', '', '2000-01-01', 6, 159, 1, 0),
(909, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 5307, 'Torres 46206', '', '2000-01-01', 1, 159, 1, 0),
(910, '&#37;', 'Various', 'Relative Humidity', 5309, 'Torres 46206', '', '2000-01-01', 4, 159, 1, 0),
(911, '&deg;C', 'Various', 'Temperature', 5308, 'Torres 46206', '', '2000-01-01', 5, 159, 1, 0),
(912, 'km/h', 'Various', 'Wind Speed', 5305, 'Torres 46206', '', '2000-01-01', 2, 159, 1, 0),
(913, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 8087, 'Puertas 46188', '', '2000-01-01', 7, 160, 1, 0),
(914, 'mm', 'Various', 'Precipitation', 8089, 'Puertas 46188', '', '2000-01-01', 6, 160, 1, 0),
(915, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 8085, 'Puertas 46188', '', '2000-01-01', 1, 160, 1, 0),
(916, '&#37;', 'Various', 'Relative Humidity', 8084, 'Puertas 46188', '', '2000-01-01', 4, 160, 1, 0),
(917, '&deg;C', 'Various', 'Temperature', 8086, 'Puertas 46188', '', '2000-01-01', 5, 160, 1, 0),
(918, 'km/h', 'Various', 'Wind Speed', 8088, 'Puertas 46188', '', '2000-01-01', 2, 160, 1, 0),
(919, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 281, 'Quepo - 49320', '', '2000-01-01', 7, 161, 1, 0),
(920, 'V', 'Adcon Telemetry GmbH', 'Solar Cell', 280, 'Quepo - 49320', '', '2000-01-01', 9, 161, 1, 0),
(921, 'km/h', 'Various', 'Wind Speed', 328, 'Quepo - 49320', '', '2000-01-01', 2, 161, 1, 0),
(922, '&deg;', 'Various', 'Wind Direction', 327, 'Quepo - 49320', '', '2000-01-01', 3, 161, 1, 0),
(923, 'mm', 'Various', 'Precipitation', 329, 'Quepo - 49320', '', '2000-01-01', 6, 161, 1, 0),
(924, '&#37;', 'Various', 'Relative Humidity', 330, 'Quepo - 49320', '', '2000-01-01', 4, 161, 1, 0),
(925, '&deg;C', 'Various', 'Temperature', 331, 'Quepo - 49320', '', '2000-01-01', 5, 161, 1, 0),
(926, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 332, 'Quepo - 49320', '', '2000-01-01', 1, 161, 1, 0),
(927, 'V', 'Adcon Telemetry GmbH', 'Solar Cell', 338, 'Longavi - 37277', '', '2000-01-01', 9, 162, 1, 0),
(928, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 339, 'Longavi - 37277', '', '2000-01-01', 7, 162, 1, 0),
(929, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 349, 'Longavi - 37277', '', '2000-01-01', 1, 162, 1, 0),
(930, '&#37;', 'Various', 'Relative Humidity', 350, 'Longavi - 37277', '', '2000-01-01', 4, 162, 1, 0),
(931, '&deg;C', 'Various', 'Temperature', 351, 'Longavi - 37277', '', '2000-01-01', 5, 162, 1, 0),
(932, 'mm', 'Various', 'Precipitation', 352, 'Longavi - 37277', '', '2000-01-01', 6, 162, 1, 0),
(933, '&deg;', 'Various', 'Wind Direction', 353, 'Longavi - 37277', '', '2000-01-01', 3, 162, 1, 0),
(934, 'km/h', 'Various', 'Wind Speed', 354, 'Longavi - 37277', '', '2000-01-01', 2, 162, 1, 0),
(943, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 269, 'Pelarco - 37275', '', '2000-01-01', 7, 164, 1, 0),
(944, 'V', 'Adcon Telemetry GmbH', 'Solar Cell', 268, 'Pelarco - 37275', '', '2000-01-01', 9, 164, 1, 0),
(945, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 270, 'Pelarco - 37275', '', '2000-01-01', 1, 164, 1, 0),
(946, '&#37;', 'Various', 'Relative Humidity', 271, 'Pelarco - 37275', '', '2000-01-01', 4, 164, 1, 0),
(947, '&deg;C', 'Various', 'Temperature', 272, 'Pelarco - 37275', '', '2000-01-01', 5, 164, 1, 0),
(948, 'mm', 'Various', 'Precipitation', 535, 'Pelarco - 37275', '', '2000-01-01', 6, 164, 1, 0),
(949, '&deg;', 'Various', 'Wind Direction', 533, 'Pelarco - 37275', '', '2000-01-01', 3, 164, 1, 0),
(950, 'km/h', 'Various', 'Wind Speed', 534, 'Pelarco - 37275', '', '2000-01-01', 2, 164, 1, 0),
(951, 'V', 'Adcon Telemetry GmbH', 'Solar Cell', 335, 'Parral - 37284', '', '2000-01-01', 9, 165, 1, 0),
(952, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 336, 'Parral - 37284', '', '2000-01-01', 7, 165, 1, 0),
(953, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 536, 'Parral - 37284', '', '2000-01-01', 1, 165, 1, 0),
(954, '&#37;', 'Various', 'Relative Humidity', 537, 'Parral - 37284', '', '2000-01-01', 4, 165, 1, 0),
(955, '&deg;C', 'Various', 'Temperature', 538, 'Parral - 37284', '', '2000-01-01', 5, 165, 1, 0),
(956, 'mm', 'Various', 'Precipitation', 539, 'Parral - 37284', '', '2000-01-01', 6, 165, 1, 0),
(957, '&deg;', 'Various', 'Wind Direction', 540, 'Parral - 37284', '', '2000-01-01', 3, 165, 1, 0),
(958, 'km/h', 'Various', 'Wind Speed', 541, 'Parral - 37284', '', '2000-01-01', 2, 165, 1, 0),
(959, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 251, 'San Clemente - 37291', '', '2000-01-01', 7, 166, 1, 0),
(960, 'V', 'Adcon Telemetry GmbH', 'Solar Cell', 250, 'San Clemente - 37291', '', '2000-01-01', 9, 166, 1, 0),
(961, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 252, 'San Clemente - 37291', '', '2000-01-01', 1, 166, 1, 0),
(962, '&#37;', 'Various', 'Relative Humidity', 253, 'San Clemente - 37291', '', '2000-01-01', 4, 166, 1, 0),
(963, '&deg;C', 'Various', 'Temperature', 254, 'San Clemente - 37291', '', '2000-01-01', 5, 166, 1, 0),
(964, 'mm', 'Various', 'Precipitation', 255, 'San Clemente - 37291', '', '2000-01-01', 6, 166, 1, 0),
(965, 'km/h', 'Various', 'Wind Speed', 257, 'San Clemente - 37291', '', '2000-01-01', 2, 166, 1, 0),
(966, '&deg;', 'Various', 'Wind Direction', 256, 'San Clemente - 37291', '', '2000-01-01', 3, 166, 1, 0),
(967, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 251, 'San Clemente - 37291', '', '2000-01-01', 7, 167, 1, 0),
(968, 'V', 'Adcon Telemetry GmbH', 'Solar Cell', 250, 'San Clemente - 37291', '', '2000-01-01', 9, 167, 1, 0),
(969, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 252, 'San Clemente - 37291', '', '2000-01-01', 1, 167, 1, 0),
(970, '&#37;', 'Various', 'Relative Humidity', 253, 'San Clemente - 37291', '', '2000-01-01', 4, 167, 1, 0),
(971, '&deg;C', 'Various', 'Temperature', 254, 'San Clemente - 37291', '', '2000-01-01', 5, 167, 1, 0),
(972, 'mm', 'Various', 'Precipitation', 255, 'San Clemente - 37291', '', '2000-01-01', 6, 167, 1, 0),
(973, 'km/h', 'Various', 'Wind Speed', 257, 'San Clemente - 37291', '', '2000-01-01', 2, 167, 1, 0),
(974, '&deg;', 'Various', 'Wind Direction', 256, 'San Clemente - 37291', '', '2000-01-01', 3, 167, 1, 0),
(975, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 269, 'Pelarco - 37275', '', '2000-01-01', 7, 168, 1, 0),
(976, 'V', 'Adcon Telemetry GmbH', 'Solar Cell', 268, 'Pelarco - 37275', '', '2000-01-01', 9, 168, 1, 0),
(977, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 270, 'Pelarco - 37275', '', '2000-01-01', 1, 168, 1, 0),
(978, '&#37;', 'Various', 'Relative Humidity', 271, 'Pelarco - 37275', '', '2000-01-01', 4, 168, 1, 0),
(979, '&deg;C', 'Various', 'Temperature', 272, 'Pelarco - 37275', '', '2000-01-01', 5, 168, 1, 0),
(980, 'mm', 'Various', 'Precipitation', 535, 'Pelarco - 37275', '', '2000-01-01', 6, 168, 1, 0),
(981, '&deg;', 'Various', 'Wind Direction', 533, 'Pelarco - 37275', '', '2000-01-01', 3, 168, 1, 0),
(982, 'km/h', 'Various', 'Wind Speed', 534, 'Pelarco - 37275', '', '2000-01-01', 2, 168, 1, 0),
(983, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 9739, 'Tarapaca 46205', '', '2000-01-01', 7, 169, 1, 0),
(984, 'mm', 'Various', 'Precipitation', 9744, 'Tarapaca 46205', '', '2000-01-01', 6, 169, 1, 0),
(985, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite and CMP3', 9742, 'Tarapaca 46205', '', '2000-01-01', 1, 169, 1, 0),
(986, '&#37;', 'Various', 'Relative Humidity', 9746, 'Tarapaca 46205', '', '2000-01-01', 4, 169, 1, 0),
(987, '&deg;C', 'Various', 'Temperature', 9745, 'Tarapaca 46205', '', '2000-01-01', 5, 169, 1, 0),
(988, 'km/h', 'Various', 'Wind Speed', 9741, 'Tarapaca 46205', '', '2000-01-01', 2, 169, 1, 0),
(989, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 548, '57291 - Longavi - El Almendro', '', '2000-01-01', 7, 170, 1, 0),
(990, 'V', 'Adcon Telemetry GmbH', 'Charging Regulator', 547, '57291 - Longavi - El Almendro', '', '2000-01-01', 9, 170, 1, 0),
(991, '&#37;', 'Various', 'Relative Humidity', 549, '57291 - Longavi - El Almendro', '', '2000-01-01', 4, 170, 1, 0),
(992, '&deg;C', 'Various', 'Temperature', 550, '57291 - Longavi - El Almendro', '', '2000-01-01', 5, 170, 1, 0),
(993, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 551, '57291 - Longavi - El Almendro', '', '2000-01-01', 1, 170, 1, 0),
(994, 'mm', 'Various', 'Precipitation', 552, '57291 - Longavi - El Almendro', '', '2000-01-01', 6, 170, 1, 0),
(995, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 548, '57291 - Longavi - El Almendro', '', '2000-01-01', 7, 171, 1, 0),
(996, 'V', 'Adcon Telemetry GmbH', 'Charging Regulator', 547, '57291 - Longavi - El Almendro', '', '2000-01-01', 9, 171, 1, 0),
(997, '&#37;', 'Various', 'Relative Humidity', 549, '57291 - Longavi - El Almendro', '', '2000-01-01', 4, 171, 1, 0),
(998, '&deg;C', 'Various', 'Temperature', 550, '57291 - Longavi - El Almendro', '', '2000-01-01', 5, 171, 1, 0),
(999, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 551, '57291 - Longavi - El Almendro', '', '2000-01-01', 1, 171, 1, 0),
(1000, 'mm', 'Various', 'Precipitation', 552, '57291 - Longavi - El Almendro', '', '2000-01-01', 6, 171, 1, 0),
(1001, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 175, 'San Vicente', '', '2000-01-01', 7, 172, 1, 0),
(1002, 'V', 'Adcon Telemetry GmbH', 'Solar Cell', 176, 'San Vicente', '', '2000-01-01', 9, 172, 1, 0),
(1003, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 177, 'San Vicente', '', '2000-01-01', 1, 172, 1, 0),
(1004, '&#37;', 'Various', 'Relative Humidity', 178, 'San Vicente', '', '2000-01-01', 4, 172, 1, 0),
(1005, '&deg;C', 'Various', 'Temperature', 179, 'San Vicente', '', '2000-01-01', 5, 172, 1, 0),
(1006, 'mm', 'Various', 'Precipitation', 180, 'San Vicente', '', '2000-01-01', 6, 172, 1, 0),
(1007, 'km/h', 'Various', 'Wind Speed', 181, 'San Vicente', '', '2000-01-01', 2, 172, 1, 0),
(1008, '&deg;', 'Various', 'Wind Direction', 182, 'San Vicente', '', '2000-01-01', 3, 172, 1, 0),
(1023, 'n/a', 'Adcon Telemetry GmbH', 'RF IN', 632, '15859', '', '2000-01-01', 0, 175, 1, 0),
(1024, 'n/a', 'Adcon Telemetry GmbH', 'RF OUT', 633, '15859', '', '2000-01-01', 0, 175, 1, 0),
(1025, 'V', 'Adcon Telemetry GmbH', 'Charging Regulator', 634, '15859', '', '2000-01-01', 9, 175, 1, 0),
(1026, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 635, '15859', '', '2000-01-01', 7, 175, 1, 0),
(1027, '&#37;', 'Various', 'Relative Humidity', 636, '15859', '', '2000-01-01', 4, 175, 1, 0),
(1028, '&deg;C', 'Various', 'Temperature', 637, '15859', '', '2000-01-01', 5, 175, 1, 0),
(1029, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 638, '15859', '', '2000-01-01', 1, 175, 1, 0),
(1030, 'km/h', 'Various', 'Wind Speed', 639, '15859', '', '2000-01-01', 2, 175, 1, 0),
(1031, '&deg;', 'Various', 'Wind Direction', 640, '15859', '', '2000-01-01', 3, 175, 1, 0),
(1032, 'mm', 'Various', 'Precipitation', 641, '15859', '', '2000-01-01', 6, 175, 1, 0),
(1033, 'V', 'Adcon Telemetry GmbH', 'Charging Regulator', 660, '27275 Endesa', '', '2000-01-01', 9, 176, 1, 0),
(1034, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 661, '27275 Endesa', '', '2000-01-01', 7, 176, 1, 0),
(1035, '&deg;C', 'Various', 'Temperature', 678, '27275 Endesa', '', '2000-01-01', 5, 176, 1, 0),
(1036, '&#37;', 'Various', 'Relative Humidity', 679, '27275 Endesa', '', '2000-01-01', 4, 176, 1, 0),
(1037, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 671, '27275 Endesa', '', '2000-01-01', 1, 176, 1, 0),
(1038, '&deg;', 'Various', 'Wind Direction', 669, '27275 Endesa', '', '2000-01-01', 3, 176, 1, 0),
(1039, 'km/h', 'Various', 'Wind Speed', 670, '27275 Endesa', '', '2000-01-01', 2, 176, 1, 0),
(1040, 'mm', 'Various', 'Precipitation', 662, '27275 Endesa', '', '2000-01-01', 6, 176, 1, 0),
(1041, 'V', 'Adcon Telemetry GmbH', 'Charging Regulator', 657, '28471 Endesa', '', '2000-01-01', 9, 177, 1, 0),
(1042, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 658, '28471 Endesa', '', '2000-01-01', 7, 177, 1, 0),
(1043, '&deg;C', 'Various', 'Temperature', 676, '28471 Endesa', '', '2000-01-01', 5, 177, 1, 0),
(1044, '&#37;', 'Various', 'Relative Humidity', 677, '28471 Endesa', '', '2000-01-01', 4, 177, 1, 0),
(1045, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 672, '28471 Endesa', '', '2000-01-01', 1, 177, 1, 0);
INSERT INTO `instrumento` (`id`, `unidad`, `marca`, `modelo`, `adcon_id`, `ubicacion_nombre`, `observacion`, `fecha_instalacion`, `tipo_instrumento_id`, `estacion_id`, `responsable_id`, `revisar_datos`) VALUES
(1046, '&deg;', 'Various', 'Wind Direction', 667, '28471 Endesa', '', '2000-01-01', 3, 177, 1, 0),
(1047, 'km/h', 'Various', 'Wind Speed', 668, '28471 Endesa', '', '2000-01-01', 2, 177, 1, 0),
(1048, 'mm', 'Various', 'Precipitation', 663, '28471 Endesa', '', '2000-01-01', 6, 177, 1, 0),
(1049, 'V', 'Adcon Telemetry GmbH', 'Charging Regulator', 746, '29242 Endesa', '', '2000-01-01', 9, 178, 1, 0),
(1050, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 747, '29242 Endesa', '', '2000-01-01', 7, 178, 1, 0),
(1051, '&deg;C', 'Various', 'Temperature', 749, '29242 Endesa', '', '2000-01-01', 5, 178, 1, 0),
(1052, '&#37;', 'Various', 'Relative Humidity', 748, '29242 Endesa', '', '2000-01-01', 4, 178, 1, 0),
(1053, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 750, '29242 Endesa', '', '2000-01-01', 1, 178, 1, 0),
(1054, 'km/h', 'Various', 'Wind Speed', 751, '29242 Endesa', '', '2000-01-01', 2, 178, 1, 0),
(1055, '&deg;', 'Various', 'Wind Direction', 752, '29242 Endesa', '', '2000-01-01', 3, 178, 1, 0),
(1056, 'mm', 'Various', 'Precipitation', 753, '29242 Endesa', '', '2000-01-01', 6, 178, 1, 0),
(1073, 'V', 'Adcon Telemetry GmbH', 'Charging Regulator', 692, '44209 - Liceo Agrícola Duao', '', '2000-01-01', 9, 182, 1, 0),
(1074, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 693, '44209 - Liceo Agrícola Duao', '', '2000-01-01', 7, 182, 1, 0),
(1075, '&#37;', 'Various', 'Relative Humidity', 695, '44209 - Liceo Agrícola Duao', '', '2000-01-01', 4, 182, 1, 0),
(1076, '&deg;C', 'Various', 'Temperature', 694, '44209 - Liceo Agrícola Duao', '', '2000-01-01', 5, 182, 1, 0),
(1077, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 696, '44209 - Liceo Agrícola Duao', '', '2000-01-01', 1, 182, 1, 0),
(1078, '&deg;', 'Various', 'Wind Direction', 697, '44209 - Liceo Agrícola Duao', '', '2000-01-01', 3, 182, 1, 0),
(1079, 'km/h', 'Various', 'Wind Speed', 698, '44209 - Liceo Agrícola Duao', '', '2000-01-01', 2, 182, 1, 0),
(1080, 'mm', 'Various', 'Precipitation', 699, '44209 - Liceo Agrícola Duao', '', '2000-01-01', 6, 182, 1, 0),
(1081, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 756, '59044 San Víctor Alamos FIC', '', '2000-01-01', 7, 183, 1, 0),
(1082, 'V', 'Adcon Telemetry GmbH', 'Charging Regulator', 755, '59044 San Víctor Alamos FIC', '', '2000-01-01', 9, 183, 1, 0),
(1083, '&#37;', 'Various', 'Relative Humidity', 757, '59044 San Víctor Alamos FIC', '', '2000-01-01', 4, 183, 1, 0),
(1084, '&deg;C', 'Various', 'Temperature', 758, '59044 San Víctor Alamos FIC', '', '2000-01-01', 5, 183, 1, 0),
(1085, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 759, '59044 San Víctor Alamos FIC', '', '2000-01-01', 1, 183, 1, 0),
(1086, 'km/h', 'Various', 'Wind Speed', 761, '59044 San Víctor Alamos FIC', '', '2000-01-01', 2, 183, 1, 0),
(1087, '&deg;', 'Various', 'Wind Direction', 760, '59044 San Víctor Alamos FIC', '', '2000-01-01', 3, 183, 1, 0),
(1088, 'mm', 'Various', 'Precipitation', 762, '59044 San Víctor Alamos FIC', '', '2000-01-01', 6, 183, 1, 0),
(1089, 'V', 'Adcon Telemetry GmbH', 'Charging Regulator', 773, '59043 Huapi FIC', '', '2000-01-01', 9, 184, 1, 0),
(1090, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 774, '59043 Huapi FIC', '', '2000-01-01', 7, 184, 1, 0),
(1091, '&#37;', 'Various', 'Relative Humidity', 775, '59043 Huapi FIC', '', '2000-01-01', 4, 184, 1, 0),
(1092, '&deg;C', 'Various', 'Temperature', 776, '59043 Huapi FIC', '', '2000-01-01', 5, 184, 1, 0),
(1093, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 777, '59043 Huapi FIC', '', '2000-01-01', 1, 184, 1, 0),
(1094, 'km/h', 'Various', 'Wind Speed', 778, '59043 Huapi FIC', '', '2000-01-01', 2, 184, 1, 0),
(1095, '&deg;', 'Various', 'Wind Direction', 779, '59043 Huapi FIC', '', '2000-01-01', 3, 184, 1, 0),
(1096, 'mm', 'Various', 'Precipitation', 780, '59043 Huapi FIC', '', '2000-01-01', 6, 184, 1, 0),
(1097, 'V', 'Adcon Telemetry GmbH', 'Charging Regulator', 764, '59308 Palmilla FIC', '', '2000-01-01', 9, 185, 1, 0),
(1098, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 765, '59308 Palmilla FIC', '', '2000-01-01', 7, 185, 1, 0),
(1099, '&#37;', 'Various', 'Relative Humidity', 766, '59308 Palmilla FIC', '', '2000-01-01', 4, 185, 1, 0),
(1100, '&deg;C', 'Various', 'Temperature', 767, '59308 Palmilla FIC', '', '2000-01-01', 5, 185, 1, 0),
(1101, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 768, '59308 Palmilla FIC', '', '2000-01-01', 1, 185, 1, 0),
(1102, 'km/h', 'Various', 'Wind Speed', 769, '59308 Palmilla FIC', '', '2000-01-01', 2, 185, 1, 0),
(1103, '&deg;', 'Various', 'Wind Direction', 770, '59308 Palmilla FIC', '', '2000-01-01', 3, 185, 1, 0),
(1104, 'mm', 'Various', 'Precipitation', 771, '59308 Palmilla FIC', '', '2000-01-01', 6, 185, 1, 0),
(1105, 'V', 'Adcon Telemetry GmbH', 'Charging Regulator', 710, '59317 Test 1', '', '2000-01-01', 9, 186, 1, 0),
(1106, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 711, '59317 Test 1', '', '2000-01-01', 7, 186, 1, 0),
(1107, '&#37;', 'Various', 'Relative Humidity', 712, '59317 Test 1', '', '2000-01-01', 4, 186, 1, 0),
(1108, '&deg;C', 'Various', 'Temperature', 713, '59317 Test 1', '', '2000-01-01', 5, 186, 1, 0),
(1109, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 714, '59317 Test 1', '', '2000-01-01', 1, 186, 1, 0),
(1110, '&deg;', 'Various', 'Wind Direction', 715, '59317 Test 1', '', '2000-01-01', 3, 186, 1, 0),
(1111, 'km/h', 'Various', 'Wind Speed', 716, '59317 Test 1', '', '2000-01-01', 2, 186, 1, 0),
(1112, 'mm', 'Various', 'Precipitation', 717, '59317 Test 1', '', '2000-01-01', 6, 186, 1, 0),
(1113, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 684, '44230', '', '2000-01-01', 7, 187, 1, 0),
(1114, 'V', 'Adcon Telemetry GmbH', 'Charging Regulator', 683, '44230', '', '2000-01-01', 9, 187, 1, 0),
(1115, '&deg;C', 'Various', 'Temperature', 685, '44230', '', '2000-01-01', 5, 187, 1, 0),
(1116, '&#37;', 'Various', 'Relative Humidity', 686, '44230', '', '2000-01-01', 4, 187, 1, 0),
(1117, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 687, '44230', '', '2000-01-01', 1, 187, 1, 0),
(1118, '&deg;', 'Various', 'Wind Direction', 689, '44230', '', '2000-01-01', 3, 187, 1, 0),
(1119, 'km/h', 'Various', 'Wind Speed', 688, '44230', '', '2000-01-01', 2, 187, 1, 0),
(1120, 'mm', 'Various', 'Precipitation', 690, '44230', '', '2000-01-01', 6, 187, 1, 0),
(1121, 'V', 'Adcon Telemetry GmbH', 'Charging Regulator', 798, '40671 - Davis', '', '2000-01-01', 9, 188, 1, 0),
(1122, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 799, '40671 - Davis', '', '2000-01-01', 7, 188, 1, 0),
(1123, '&deg;C', 'Various', 'Temperature', 800, '40671 - Davis', '', '2000-01-01', 5, 188, 1, 0),
(1124, '&#37;', 'Various', 'Relative Humidity', 801, '40671 - Davis', '', '2000-01-01', 4, 188, 1, 0),
(1125, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 802, '40671 - Davis', '', '2000-01-01', 1, 188, 1, 0),
(1126, '&deg;', 'Various', 'Wind Direction', 803, '40671 - Davis', '', '2000-01-01', 3, 188, 1, 0),
(1127, 'km/h', 'Various', 'Wind Speed', 804, '40671 - Davis', '', '2000-01-01', 2, 188, 1, 0),
(1128, 'mm', 'Various', 'Precipitation', 805, '40671 - Davis', '', '2000-01-01', 6, 188, 1, 0),
(1129, 'V', 'Adcon Telemetry GmbH', 'Charging Regulator', 810, 'Test RTU 09.2017', '', '2000-01-01', 9, 189, 1, 0),
(1130, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 811, 'Test RTU 09.2017', '', '2000-01-01', 7, 189, 1, 0),
(1131, '&deg;C', 'Various', 'Temperature', 812, 'Test RTU 09.2017', '', '2000-01-01', 5, 189, 1, 0),
(1132, '&#37;', 'Various', 'Relative Humidity', 813, 'Test RTU 09.2017', '', '2000-01-01', 4, 189, 1, 0),
(1133, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 814, 'Test RTU 09.2017', '', '2000-01-01', 1, 189, 1, 0),
(1134, '&deg;', 'Various', 'Wind Direction', 815, 'Test RTU 09.2017', '', '2000-01-01', 3, 189, 1, 0),
(1135, 'km/h', 'Various', 'Wind Speed', 816, 'Test RTU 09.2017', '', '2000-01-01', 2, 189, 1, 0),
(1136, 'mm', 'Various', 'Precipitation', 817, 'Test RTU 09.2017', '', '2000-01-01', 6, 189, 1, 0),
(1145, 'V', 'Adcon Telemetry GmbH', 'Charging Regulator', 822, '40002 - Rio Claro', '', '2000-01-01', 9, 191, 1, 0),
(1146, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 823, '40002 - Rio Claro', '', '2000-01-01', 7, 191, 1, 0),
(1147, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 830, '40002 - Rio Claro', '', '2000-01-01', 1, 191, 1, 0),
(1148, '&deg;C', 'Various', 'Temperature', 827, '40002 - Rio Claro', '', '2000-01-01', 5, 191, 1, 0),
(1149, '&#37;', 'Various', 'Relative Humidity', 828, '40002 - Rio Claro', '', '2000-01-01', 4, 191, 1, 0),
(1150, 'km/h', 'Various', 'Wind Speed', 825, '40002 - Rio Claro', '', '2000-01-01', 2, 191, 1, 0),
(1151, '&deg;', 'Various', 'Wind Direction', 826, '40002 - Rio Claro', '', '2000-01-01', 3, 191, 1, 0),
(1152, 'mm', 'Various', 'Precipitation', 824, '40002 - Rio Claro', '', '2000-01-01', 6, 191, 1, 0),
(1153, 'n/a', 'Adcon Telemetry GmbH', 'RF IN', 844, '40006 - Retiro CTA', '', '2000-01-01', 0, 192, 1, 0),
(1154, 'n/a', 'Adcon Telemetry GmbH', 'RF OUT', 845, '40006 - Retiro CTA', '', '2000-01-01', 0, 192, 1, 0),
(1155, 'V', 'Adcon Telemetry GmbH', 'Charging Regulator', 846, '40006 - Retiro CTA', '', '2000-01-01', 9, 192, 1, 0),
(1156, 'V', 'Adcon Telemetry GmbH', 'Battery Voltage', 847, '40006 - Retiro CTA', '', '2000-01-01', 7, 192, 1, 0),
(1157, 'W/m2', 'Kipp und Zonen', 'Pyranometer SP-Lite', 851, '40006 - Retiro CTA', '', '2000-01-01', 1, 192, 1, 0),
(1158, '&deg;C', 'Various', 'Temperature', 852, '40006 - Retiro CTA', '', '2000-01-01', 5, 192, 1, 0),
(1159, '&#37;', 'Various', 'Relative Humidity', 853, '40006 - Retiro CTA', '', '2000-01-01', 4, 192, 1, 0),
(1160, 'km/h', 'Various', 'Wind Speed', 854, '40006 - Retiro CTA', '', '2000-01-01', 2, 192, 1, 0),
(1161, '&deg;', 'Various', 'Wind Direction', 855, '40006 - Retiro CTA', '', '2000-01-01', 3, 192, 1, 0),
(1162, 'mm', 'Various', 'Precipitation', 856, '40006 - Retiro CTA', '', '2000-01-01', 6, 192, 1, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `link_roles_menus`
--

CREATE TABLE `link_roles_menus` (
  `id` int(11) NOT NULL,
  `roles_id` int(11) NOT NULL,
  `menus_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `link_roles_menus`
--

INSERT INTO `link_roles_menus` (`id`, `roles_id`, `menus_id`) VALUES
(47, 2, 1),
(48, 2, 2),
(49, 2, 4),
(50, 2, 5),
(51, 2, 6),
(52, 2, 7),
(65, 1, 1),
(66, 1, 2),
(67, 1, 3),
(68, 1, 4),
(69, 1, 5),
(70, 1, 6),
(71, 1, 7),
(76, 6, 1),
(77, 6, 2),
(78, 6, 4),
(79, 1, 8),
(80, 1, 9);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `medicion`
--

CREATE TABLE `medicion` (
  `fecha` date NOT NULL,
  `hora` time NOT NULL,
  `medicion` double NOT NULL,
  `instrumento_id` int(11) NOT NULL,
  `estado` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `menus`
--

CREATE TABLE `menus` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `icon` varchar(50) NOT NULL,
  `url` varchar(255) DEFAULT NULL,
  `parent_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `menus`
--

INSERT INTO `menus` (`id`, `name`, `icon`, `url`, `parent_id`) VALUES
(1, 'Agrodatos', 'fa fa-dashboard', '/Agrodatos/Index', 0),
(2, 'Usuarios', 'fa fa-users', '#', 0),
(3, 'Crear Usuario', 'fa fa-plus', '/Admins/Create', 2),
(4, 'Administrar Usuarios', 'fa fa-users', '/Admins/Index', 2),
(5, 'Roles', 'fa fa-lock', '#', 0),
(6, 'Crear Rol', 'fa fa-lock', '/Roles/Create', 5),
(7, 'Administrar Roles', 'fa fa-lock', '/Roles/Index', 5),
(8, 'Estaciones', 'fa fa-lock', '#', 0),
(9, 'Asignar Estacion', 'fa fa-lock', '/EstacionesAsignadas/Index', 8);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `roles`
--

CREATE TABLE `roles` (
  `id` int(11) NOT NULL,
  `title` varchar(255) NOT NULL,
  `description` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `roles`
--

INSERT INTO `roles` (`id`, `title`, `description`) VALUES
(1, 'Admin', 'Super Admin Con todos los Poderes'),
(2, 'Supervisor', 'Puede Ver/agregar Agrodatos, Usuarios y Roles'),
(6, 'Normal', 'Puede ver Agrodatos y Usuarios');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `admins`
--
ALTER TABLE `admins`
  ADD PRIMARY KEY (`id`),
  ADD KEY `admins_ibfk_1` (`roles_id`);

--
-- Indices de la tabla `estaciones_asignadas`
--
ALTER TABLE `estaciones_asignadas`
  ADD PRIMARY KEY (`id`),
  ADD KEY `idusuario` (`idusuario`),
  ADD KEY `idestacion` (`idestacion`);

--
-- Indices de la tabla `estacioneve`
--
ALTER TABLE `estacioneve`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `instrumento`
--
ALTER TABLE `instrumento`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_instrumento_tipo_instrumento` (`tipo_instrumento_id`),
  ADD KEY `fk_instrumento_estacion` (`estacion_id`),
  ADD KEY `fk_instrumento_responsable` (`responsable_id`);

--
-- Indices de la tabla `link_roles_menus`
--
ALTER TABLE `link_roles_menus`
  ADD PRIMARY KEY (`id`),
  ADD KEY `menus_id` (`menus_id`),
  ADD KEY `roles_id` (`roles_id`);

--
-- Indices de la tabla `medicion`
--
ALTER TABLE `medicion`
  ADD PRIMARY KEY (`fecha`,`hora`,`instrumento_id`),
  ADD KEY `fk_medicion_instrumento` (`instrumento_id`),
  ADD KEY `fecha` (`fecha`),
  ADD KEY `hora` (`hora`);

--
-- Indices de la tabla `menus`
--
ALTER TABLE `menus`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `roles`
--
ALTER TABLE `roles`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `admins`
--
ALTER TABLE `admins`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `estaciones_asignadas`
--
ALTER TABLE `estaciones_asignadas`
  MODIFY `id` int(32) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `instrumento`
--
ALTER TABLE `instrumento`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1163;

--
-- AUTO_INCREMENT de la tabla `link_roles_menus`
--
ALTER TABLE `link_roles_menus`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=81;

--
-- AUTO_INCREMENT de la tabla `menus`
--
ALTER TABLE `menus`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de la tabla `roles`
--
ALTER TABLE `roles`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `admins`
--
ALTER TABLE `admins`
  ADD CONSTRAINT `admins_ibfk_1` FOREIGN KEY (`roles_id`) REFERENCES `roles` (`id`);

--
-- Filtros para la tabla `estaciones_asignadas`
--
ALTER TABLE `estaciones_asignadas`
  ADD CONSTRAINT `estaciones_asignadas_ibfk_1` FOREIGN KEY (`idestacion`) REFERENCES `estacioneve` (`id`),
  ADD CONSTRAINT `estaciones_asignadas_ibfk_2` FOREIGN KEY (`idusuario`) REFERENCES `admins` (`id`);

--
-- Filtros para la tabla `instrumento`
--
ALTER TABLE `instrumento`
  ADD CONSTRAINT `instrumento_ibfk_1` FOREIGN KEY (`estacion_id`) REFERENCES `estacioneve` (`id`);

--
-- Filtros para la tabla `link_roles_menus`
--
ALTER TABLE `link_roles_menus`
  ADD CONSTRAINT `link_roles_menus_ibfk_1` FOREIGN KEY (`menus_id`) REFERENCES `menus` (`id`),
  ADD CONSTRAINT `link_roles_menus_ibfk_2` FOREIGN KEY (`roles_id`) REFERENCES `roles` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
