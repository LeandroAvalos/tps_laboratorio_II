Create database Sucursales;
GO
use Sucursales;
GO
create table Sucursales(
barrio varchar(20),
numeroTelefonico decimal(18, 0) not null,
direccionParticular varchar(20) not null,
codigoDeSecursal varchar(5) not null,
abiertoDe varchar(10) not null,
abiertoHasta varchar(10) not null,
apertura varchar(10) not null,
cierre varchar(10) not null
)

insert into Sucursales (barrio,numeroTelefonico,direccionParticular,codigoDeSecursal,
abiertoDe, abiertoHasta, apertura, cierre) values
('Palermo', 1165479874, 'Calle Falsa 123', '65FGE', 'Lunes', 'Viernes', '08:00', '20:00'),
('Caballito', 1165479874, 'Angel Gallardo 900', '98CVD', 'Lunes', 'Jueves', '09:00', '21:00'),
('Villa Urquiza', 1165479874, 'Avenida Monroe 4600 ', '32DAQ', 'Lunes', 'Sabado', '10:00', '22:00'),
('Colegiales', 1165479874, 'Zapiola 722', '12GHJ', 'Lunes', 'Domingo', '11:00', '23:00'),
('Palomar', 1165479874, 'Los Aromos 2873', '73NMJ', 'Lunes', 'Miercoles', '12:00', '23:00');