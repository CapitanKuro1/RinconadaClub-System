USE [master];
GO

CREATE DATABASE [db_rinconadaclub];
GO

USE [db_rinconadaclub];
GO

-------------------------------------------------------
-- TABLAS
-------------------------------------------------------

-- Socio
CREATE TABLE Socio (
    id_socio        int IDENTITY(1,1) NOT NULL,
    nombre_completo nvarchar(50)      NOT NULL,
    dni             nvarchar(8)       NOT NULL,
    correo          nvarchar(100)     NOT NULL,
    telefono        nvarchar(15)      NOT NULL,
    direccion       nvarchar(100)     NOT NULL,
    estado          bit               NOT NULL,
    CONSTRAINT Socio_pk PRIMARY KEY (id_socio)
);

-- Instalaciones
CREATE TABLE Instalaciones (
    id_instalacion  int IDENTITY(1,1) NOT NULL,
    nombre          nvarchar(50)      NOT NULL,
    tipo            nvarchar(50)      NOT NULL,
    ubicacion       nvarchar(100)     NOT NULL,
    capacidad       int               NOT NULL,
    CONSTRAINT Instalaciones_pk PRIMARY KEY (id_instalacion)
);

-- Reservas
CREATE TABLE Reservas (
    id_reserva      int IDENTITY(1,1) NOT NULL,
    fecha_reserva   date              NOT NULL,
    hora_inicio     time(0)           NOT NULL,
    hora_fin        time(0)           NOT NULL,
    id_socio        int               NOT NULL,
    area            nvarchar(30)      NOT NULL,
    id_instalacion  int               NOT NULL,
    CONSTRAINT Reservas_pk PRIMARY KEY (id_reserva)
);

-- Pagos
CREATE TABLE Pagos (
    id_pago     int IDENTITY(1,1) NOT NULL,
    monto       decimal(10,2)     NOT NULL,
    fecha_pago  datetime          NOT NULL,
    metodo_pago nvarchar(30)      NOT NULL,
    id_socio    int               NOT NULL,
    CONSTRAINT Pagos_pk PRIMARY KEY (id_pago)
);

-- Invitados
CREATE TABLE Invitados (
    id_invitado     int IDENTITY(1,1) NOT NULL,
    nombre_invitado nvarchar(50)      NOT NULL,
    dni_invitado    nvarchar(15)      NOT NULL,
    id_socio        int               NOT NULL,
    fecha_visita    date              NOT NULL,
    CONSTRAINT Invitados_pk PRIMARY KEY (id_invitado)
);

-- Carnet
CREATE TABLE Carnet (
    id_carnet     int IDENTITY(1,1) NOT NULL,
    fecha_emision datetime          NOT NULL,
    estado        bit               NOT NULL,
    id_socio      int               NOT NULL,
    CONSTRAINT Carnet_pk PRIMARY KEY (id_carnet)
);

-- Auditoria
CREATE TABLE Auditoria (
    id_auditoria int IDENTITY(1,1) NOT NULL,
    id_usuario   int               NULL,
    accion       nvarchar(200)     NULL,
    fecha_accion datetime          NULL,
    CONSTRAINT Auditoria_pk PRIMARY KEY (id_auditoria)
);

-------------------------------------------------------
-- FOREIGN KEYS
-------------------------------------------------------

ALTER TABLE Carnet
ADD CONSTRAINT Carnet_Socio
FOREIGN KEY (id_socio) REFERENCES Socio (id_socio);

ALTER TABLE Invitados
ADD CONSTRAINT Invitados_Socio
FOREIGN KEY (id_socio) REFERENCES Socio (id_socio);

ALTER TABLE Pagos
ADD CONSTRAINT Pagos_Socio
FOREIGN KEY (id_socio) REFERENCES Socio (id_socio);

ALTER TABLE Reservas
ADD CONSTRAINT Reservas_Socio
FOREIGN KEY (id_socio) REFERENCES Socio (id_socio);

ALTER TABLE Reservas
ADD CONSTRAINT Reservas_Instalaciones
FOREIGN KEY (id_instalacion) REFERENCES Instalaciones (id_instalacion);

USE db_rinconadaclub;
GO

-------------------------------------------------------
-- SOCIOS (15 registros)
-------------------------------------------------------
INSERT INTO Socio (nombre_completo, dni, correo, telefono, direccion, estado)
VALUES
('Giancarlo Ames', '60990433', 'giancarlo@gmail.com',  '997241972', 'San Juan de Miraflores', 1),
('Ronald Perez',   '77845884', 'ronald@gmail.com',    '988457112', 'Santa Anita',            1),
('Mayler Soto',    '65998814', 'mayler@gmail.com',    '945688788', 'Ancon',                  0),
('Nicolas Ruiz',   '65445859', 'nicolas@gmail.com',   '994875177', 'San Juan de Lurigancho', 1),
('Ariana Diaz',    '78478566', 'ariana@gmail.com',    '966532111', 'Los Olivos',             0),
('Marta Lopez',    '72545511', 'marta@gmail.com',     '987465552', 'Surco',                  1),
('Luis Torres',    '70112233', 'luis.torres@gmail.com','987111222','Barranco',               1),
('Brenda Salas',   '70223344', 'brenda.salas@gmail.com','986222333','Miraflores',            1),
('Carlos Medina',  '70334455', 'carlos.medina@gmail.com','985333444','Chorrillos',           0),
('Sofia Castro',   '70445566', 'sofia.castro@gmail.com','984444555','Pueblo Libre',          1),
('Jorge Rivas',    '70556677', 'jorge.rivas@gmail.com','983555666','Rimac',                  1),
('Lucia Herrera',  '70667788', 'lucia.herrera@gmail.com','982666777','La Molina',            1),
('Diego Campos',   '70778899', 'diego.campos@gmail.com','981777888','Ate',                   0),
('Andrea Paredes', '70889911', 'andrea.paredes@gmail.com','980888999','Magdalena',           1),
('Fernando Chavez','70991122', 'fernando.chavez@gmail.com','979999000','San Miguel',         1);
GO

-------------------------------------------------------
-- INSTALACIONES (6 registros)
-------------------------------------------------------
INSERT INTO Instalaciones (nombre, tipo, ubicacion, capacidad)
VALUES
('Cancha de Fútbol', 'Deporte', 'Zona Este', 20),
('Cancha de Tenis',  'Deporte', 'Zona Norte', 4),
('Zona de Parrillas',  'Evento',  'Zona Sur', 30),
('Piscina Olímpica','Recreación','Exterior', 50),
('Gimnasio Principal', 'Deporte', 'Zona Oeste', 25),
('Salón de Eventos',    'Evento',  'Edificio B', 80);
GO

-------------------------------------------------------
-- RESERVAS (12 registros)
-- (id_socio 1-12, id_instalacion 1-6)
-------------------------------------------------------
INSERT INTO Reservas (fecha_reserva, hora_inicio, hora_fin, id_socio, area, id_instalacion)
VALUES
('2025-11-29', '19:00', '20:30', 1,  'Cancha 1',           1),
('2025-12-10', '21:00', '23:00', 2,  'Zona B',   3),
('2026-01-28', '15:30', '17:00', 4,  'Cancha 1',           1),
('2026-02-05', '09:00', '10:30', 5,  'Piscina',    4),
('2026-02-10', '18:00', '19:00', 6,  'Libre',     5),
('2026-02-15', '08:00', '09:30', 7,  'Cancha 2',     2),
('2026-03-01', '19:00', '22:00', 8,  'Auditorio',    6),
('2026-03-05', '17:00', '18:30', 9,  'Cancha 1', 1),
('2026-03-10', '16:00', '18:00', 10, 'Piscina',   4),
('2026-03-15', '20:00', '22:00', 11, 'Zona A',    3),
('2026-03-20', '07:00', '08:00', 12, 'Libre',    5),
('2026-03-25', '10:00', '12:00', 3,  'Cancha 1',   1);
GO

-------------------------------------------------------
-- PAGOS (15 registros)
-------------------------------------------------------
INSERT INTO Pagos (monto, fecha_pago, metodo_pago, id_socio)
VALUES
(50.00,  '2025-11-29', 'Tarjeta',       1),
(40.00,  '2025-12-02', 'Efectivo',      2),
(20.00,  '2025-12-11', 'Transferencia', 4),
(60.00,  '2026-01-05', 'Tarjeta',       5),
(80.00,  '2026-01-10', 'Tarjeta',       6),
(35.50,  '2026-01-15', 'Efectivo',      7),
(45.75,  '2026-01-20', 'Transferencia', 8),
(90.00,  '2026-01-25', 'Tarjeta',       9),
(55.00,  '2026-02-01', 'Efectivo',      10),
(70.00,  '2026-02-05', 'Tarjeta',       11),
(30.00,  '2026-02-10', 'Transferencia', 12),
(65.00,  '2026-02-15', 'Tarjeta',       3),
(75.00,  '2026-02-20', 'Efectivo',      13),
(85.00,  '2026-02-25', 'Tarjeta',       14),
(95.00,  '2026-03-01', 'Transferencia', 15);
GO

-------------------------------------------------------
-- INVITADOS (12 registros)
-------------------------------------------------------
INSERT INTO Invitados (nombre_invitado, dni_invitado, id_socio, fecha_visita)
VALUES
('Pedro Gomez',   '61235444', 1,  '2025-12-09'),
('Tulio Rios',    '74111454', 2,  '2025-12-18'),
('Katty Vega',    '76545589', 3,  '2025-11-30'),
('Mario Salazar', '71234567', 4,  '2026-01-05'),
('Lucero Ponce',  '72345678', 5,  '2026-01-06'),
('Nelson Cruz',   '73456789', 6,  '2026-01-07'),
('Rosa Torres',   '74567890', 7,  '2026-01-10'),
('Ivan Romero',   '75678901', 8,  '2026-01-11'),
('Claudia Rey',   '76789012', 9,  '2026-01-15'),
('Hector Vidal',  '77890123', 10, '2026-01-20'),
('Pia Morales',   '78901234', 11, '2026-02-01'),
('German Lara',   '79012345', 12, '2026-02-05');
GO

-------------------------------------------------------
-- CARNET (10 registros)
-------------------------------------------------------
INSERT INTO Carnet (fecha_emision, estado, id_socio)
VALUES
('2025-12-23', 1, 1),
('2025-12-05', 1, 2),
('2025-12-14', 0, 3),
('2026-01-02', 1, 4),
('2026-01-03', 1, 5),
('2026-01-04', 1, 6),
('2026-01-05', 0, 7),
('2026-01-06', 1, 8),
('2026-01-07', 1, 9),
('2026-01-08', 0, 10);
GO

-------------------------------------------------------
-- AUDITORIA (8 registros)
-------------------------------------------------------
INSERT INTO Auditoria (id_usuario, accion, fecha_accion)
VALUES
(1, 'Creacion de reserva',      GETDATE()),
(2, 'Registro de pago',         GETDATE()),
(1, 'Actualizacion de socio',   GETDATE()),
(3, 'Anulacion de pago',        GETDATE()),
(2, 'Modificacion de reserva',  GETDATE()),
(4, 'Ingreso al sistema',       GETDATE()),
(1, 'Generacion de reporte',    GETDATE()),
(3, 'Creacion de invitado',     GETDATE());
GO


USE db_rinconadaclub;
GO

SELECT * FROM Socio;
SELECT * FROM Instalaciones;
SELECT * FROM Reservas;
SELECT * FROM Pagos;
SELECT * FROM Invitados;
SELECT * FROM Carnet;
SELECT * FROM Auditoria;

SELECT 'Socio'          AS Tabla, COUNT(*) AS Total FROM Socio
UNION ALL
SELECT 'Instalaciones', COUNT(*) FROM Instalaciones
UNION ALL
SELECT 'Reservas',      COUNT(*) FROM Reservas
UNION ALL
SELECT 'Pagos',         COUNT(*) FROM Pagos
UNION ALL
SELECT 'Invitados',     COUNT(*) FROM Invitados
UNION ALL
SELECT 'Carnet',        COUNT(*) FROM Carnet
UNION ALL
SELECT 'Auditoria',     COUNT(*) FROM Auditoria;

SELECT 
    r.id_reserva,
    r.fecha_reserva,
    r.hora_inicio,
    r.hora_fin,
    s.nombre_completo AS Socio,
    i.nombre AS Instalacion,
    r.area
FROM Reservas r
INNER JOIN Socio s ON r.id_socio = s.id_socio
INNER JOIN Instalaciones i ON r.id_instalacion = i.id_instalacion;

SELECT 
    p.id_pago,
    p.monto,
    p.fecha_pago,
    p.metodo_pago,
    s.nombre_completo AS Socio
FROM Pagos p
INNER JOIN Socio s ON p.id_socio = s.id_socio;

SELECT 
    i.id_invitado,
    i.nombre_invitado,
    i.dni_invitado,
    i.fecha_visita,
    s.nombre_completo AS Socio
FROM Invitados i
INNER JOIN Socio s ON i.id_socio = s.id_socio;



SELECT 
    c.id_carnet,
    c.fecha_emision,
    c.estado,
    s.nombre_completo AS Socio
FROM Carnet c
INNER JOIN Socio s ON c.id_socio = s.id_socio;

SELECT *
FROM Auditoria
ORDER BY fecha_accion DESC;
