-- phpMyAdmin SQL Dump
-- version 2.11.2.1
-- http://www.phpmyadmin.net
--
-- Servidor: localhost
-- Tiempo de generación: 05-11-2022 a las 11:08:44
-- Versión del servidor: 5.0.45
-- Versión de PHP: 5.2.5

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";

--
-- Base de datos: `gimnasio`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cli00`
--
-- Creación: 08-05-2019 a las 13:03:42
--

DROP TABLE IF EXISTS `cli00`;
CREATE TABLE IF NOT EXISTS `cli00` (
  `idcli` int(11) NOT NULL auto_increment,
  `ncli` varchar(150) NOT NULL,
  `dir` varchar(200) default NULL,
  `telefono` varchar(20) default NULL,
  `obs` text,
  `huella` blob,
  `foto` longblob,
  `FLimite` date default NULL,
  `fechapago` date default NULL,
  `area1` tinyint(1) NOT NULL,
  `area2` tinyint(1) NOT NULL,
  `area3` tinyint(1) NOT NULL,
  `empresa` varchar(150) default NULL,
  `id` int(11) NOT NULL default '-1',
  `date_modify` datetime NOT NULL,
  PRIMARY KEY  (`idcli`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4586 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cli00tmp`
--
-- Creación: 16-01-2021 a las 11:49:17
--

DROP TABLE IF EXISTS `cli00tmp`;
CREATE TABLE IF NOT EXISTS `cli00tmp` (
  `idcli` int(11) NOT NULL default '0',
  `ncli` varchar(150) NOT NULL,
  `dir` varchar(200) default NULL,
  `telefono` varchar(20) default NULL,
  `obs` text,
  `huella` blob,
  `foto` blob,
  `FLimite` date default NULL,
  `fechapago` date default NULL,
  `area1` tinyint(1) NOT NULL,
  `area2` tinyint(1) NOT NULL,
  `area3` tinyint(1) NOT NULL,
  `empresa` varchar(150) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cli01`
--
-- Creación: 08-05-2019 a las 13:03:42
--

DROP TABLE IF EXISTS `cli01`;
CREATE TABLE IF NOT EXISTS `cli01` (
  `id` int(11) NOT NULL auto_increment,
  `fechaela` datetime NOT NULL,
  `numcliact` int(11) NOT NULL,
  `numclipagos` int(11) NOT NULL,
  `numclient` int(11) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 COMMENT='Información diaria de los clientes' AUTO_INCREMENT=2101 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `conf00`
--
-- Creación: 08-05-2019 a las 13:03:42
--

DROP TABLE IF EXISTS `conf00`;
CREATE TABLE IF NOT EXISTS `conf00` (
  `id` int(11) NOT NULL auto_increment,
  `pass` varchar(40) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `corte00`
--
-- Creación: 08-05-2019 a las 13:03:42
--

DROP TABLE IF EXISTS `corte00`;
CREATE TABLE IF NOT EXISTS `corte00` (
  `fechaela` datetime NOT NULL,
  `minicio` decimal(10,0) NOT NULL,
  `mtalon` decimal(10,0) NOT NULL,
  `mventas` decimal(10,0) NOT NULL,
  `mgastos` decimal(10,0) NOT NULL,
  `mtotal` decimal(10,0) NOT NULL,
  `mretiro` decimal(10,0) NOT NULL,
  `caja` decimal(10,0) NOT NULL,
  `mefectivo` decimal(10,0) NOT NULL,
  `mtarjeta` decimal(10,0) NOT NULL,
  `mtotalefectivo` decimal(10,0) NOT NULL,
  PRIMARY KEY  (`fechaela`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `gastos00`
--
-- Creación: 08-05-2019 a las 13:03:42
--

DROP TABLE IF EXISTS `gastos00`;
CREATE TABLE IF NOT EXISTS `gastos00` (
  `id` int(11) NOT NULL auto_increment,
  `concepto` varchar(100) NOT NULL,
  `Precio` decimal(10,0) NOT NULL,
  `fechaela` datetime NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `inventario00`
--
-- Creación: 08-05-2019 a las 13:03:42
--

DROP TABLE IF EXISTS `inventario00`;
CREATE TABLE IF NOT EXISTS `inventario00` (
  `id` int(11) NOT NULL auto_increment,
  `articulo` varchar(100) NOT NULL,
  `desc` varchar(200) default NULL,
  `precio` decimal(10,0) default NULL,
  `stock` int(11) default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pagos00`
--
-- Creación: 08-05-2019 a las 13:03:42
--

DROP TABLE IF EXISTS `pagos00`;
CREATE TABLE IF NOT EXISTS `pagos00` (
  `id` int(11) NOT NULL auto_increment,
  `idcli` int(11) default NULL,
  `ncli` varchar(150) NOT NULL,
  `fechaela` datetime NOT NULL,
  `fechaini` date NOT NULL,
  `fechafin` date NOT NULL,
  `fechapago` date default NULL,
  `pago` decimal(10,0) NOT NULL,
  `Precio` varchar(100) NOT NULL,
  `tipo` enum('EFECTIVO','TARJETA') NOT NULL,
  `empresa` varchar(150) default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=14759 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `personal00`
--
-- Creación: 08-05-2019 a las 13:03:42
--

DROP TABLE IF EXISTS `personal00`;
CREATE TABLE IF NOT EXISTS `personal00` (
  `id` int(11) NOT NULL auto_increment,
  `nombre` varchar(150) NOT NULL,
  `dir` varchar(200) default NULL,
  `foto` longblob,
  `huella` blob,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `precio00`
--
-- Creación: 08-05-2019 a las 13:03:42
--

DROP TABLE IF EXISTS `precio00`;
CREATE TABLE IF NOT EXISTS `precio00` (
  `id` int(11) NOT NULL auto_increment,
  `Precio` varchar(100) default NULL,
  `Costo` decimal(10,0) default NULL,
  `semana` tinyint(1) NOT NULL,
  `quincena` tinyint(1) NOT NULL,
  `mes` tinyint(1) NOT NULL,
  `anio` tinyint(1) NOT NULL,
  `trimestre` tinyint(1) NOT NULL,
  `semestre` tinyint(1) NOT NULL,
  `tiempo` int(11) NOT NULL,
  `fechaini` date default NULL,
  `fechafin` date default NULL,
  `limitado` tinyint(1) NOT NULL,
  `tolerancia` int(11) NOT NULL default '0',
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=33 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `registro00`
--
-- Creación: 08-05-2019 a las 13:03:42
--

DROP TABLE IF EXISTS `registro00`;
CREATE TABLE IF NOT EXISTS `registro00` (
  `id` int(11) NOT NULL auto_increment,
  `idcli` int(11) NOT NULL,
  `ncli` varchar(150) NOT NULL,
  `fecha` datetime NOT NULL,
  `membresia` enum('Vigente','Vencida','Pago Pendiente') NOT NULL default 'Vigente',
  `acceso` enum('Permitido','No permitido','Pagado') NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=109678 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `registro01`
--
-- Creación: 08-05-2019 a las 13:03:42
--

DROP TABLE IF EXISTS `registro01`;
CREATE TABLE IF NOT EXISTS `registro01` (
  `id` int(11) NOT NULL auto_increment,
  `idemp` int(11) NOT NULL,
  `nemp` varchar(150) NOT NULL,
  `hora` datetime NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=820 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tmp`
--
-- Creación: 08-05-2019 a las 13:03:42
--

DROP TABLE IF EXISTS `tmp`;
CREATE TABLE IF NOT EXISTS `tmp` (
  `id` int(11) NOT NULL,
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas00`
--
-- Creación: 08-05-2019 a las 13:03:42
--

DROP TABLE IF EXISTS `ventas00`;
CREATE TABLE IF NOT EXISTS `ventas00` (
  `id` int(11) NOT NULL auto_increment,
  `idart` int(11) NOT NULL,
  `nart` varchar(200) NOT NULL,
  `can` int(11) NOT NULL,
  `precio` decimal(10,0) NOT NULL,
  `total` decimal(10,0) NOT NULL,
  `fechaela` datetime NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `visita00`
--
-- Creación: 08-05-2019 a las 13:03:42
--

DROP TABLE IF EXISTS `visita00`;
CREATE TABLE IF NOT EXISTS `visita00` (
  `id` int(11) NOT NULL auto_increment,
  `precio` decimal(10,0) NOT NULL,
  `fechaela` date NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

--
-- Procedimientos
--
DELIMITER $$
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `GuardarInfoClientes`(IN _fechacorte DateTime)
BEGIN 
insert into cli01 (fechaela,numcliact,numclipagos,numclient) values (_fechacorte, (select COUNT( * ) FROM cli00 WHERE flimite >= CURRENT_DATE( ) ), ( SELECT COUNT( * ) FROM pagos00 WHERE fechaela > CURRENT_DATE( ) ), ( SELECT COUNT(DISTINCT idcli) AS cantidad FROM registro00 where acceso='Permitido' and fecha > current_DAte())); 
END$$

--
DELIMITER ;
--
