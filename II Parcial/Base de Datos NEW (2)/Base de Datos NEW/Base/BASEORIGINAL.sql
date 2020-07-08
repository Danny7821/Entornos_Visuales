CREATE DATABASE BaseEmpleados

create schema eaquemaEmpleado1
go

--use BaseEmpleados2.0
-- seleccionar la base BaseEmpleados2.0 arriba a la izquierda 



select * from eaquemaEmpleado1.empleados;

CREATE TABLE eaquemaEmpleado1.empleados (
   -- NomEmpleado int not null IDENTITY(1, 1),
    identidad VARCHAR(13) not NULL PRIMARY KEY,
    empNom VARCHAR(30) not NULL,
	empApe VARCHAR(30) not NULL,
    direccion VARCHAR(120)not NULL,
    edad INTEGER not NULL,
    sexo VARCHAR(10) not NULL,
    puesto VARCHAR(100) not NULL,
);
GO
CREATE TABLE eaquemaEmpleado1.puesto(
puesto VARCHAR(100) not NULL PRIMARY KEY
);

-- TABLA DE PUESTOS
SELECT * FROM eaquemaEmpleado1.puesto
INSERT INTO eaquemaEmpleado1.puesto(puesto)
values('Gerente'),
('Jefe de TI Desarrollo'),
('Ejecutivo RRHH'),
('Marketing'),
('Chofer'),
('Técnicos de mantenimiento'),
('Servicio al Cliente'),
('Operador'),
('Dependiente'),
('Soporte TI'),
('Jefe de TI Infraestructura'),
('Cocinero'),
('Desarrollador'),
('Jefe de Calidad'),
('Jefe RRHH'),
('Medios');

CREATE TABLE eaquemaEmpleado1.sexo(
sexo VARCHAR(10) not NULL PRIMARY KEY
);

-- TABLA SEXO
SELECT * FROM eaquemaEmpleado1.sexo
INSERT INTO eaquemaEmpleado1.sexo(sexo)
VALUES('Masculino'),
('Femenino');


--select NomEmpleado,identidad,empNom,empApe,direccion,edad, sexo, puesto from empleados order by NomEmpleado  ASC

-- EMPLEADOS DE BULTO
INSERT INTO eaquemaEmpleado1.empleados(identidad,empNom,empApe,direccion,edad,sexo,puesto) 
VALUES('0801199302544','Gustavo Adolfo','Cano Valle','El Paraiso, Yuscaran, Barrio San Jose',31,'Masculino','Servicio al Cliente'),
      ('0301199002639','Marian Alejandra','Calix Rodriguez','Atlantida, La Ceiba, Barrio Independencia',38,'Femenino','Dependiente'),
	  ('0101199604512','Nidia Fernanda','Vazques Nuñez','El Paraiso, Yuscaran, Barrio San Jose',45,'Femenino','Desarrollador'),
	  ('0101198503602','Karen Valeria','Flores Agurcia','Colon, Tocoa, Barrio San Francisco',48,'Femenino','Cocinero'),
	  ('0101198503643','Geovany Josue','Martinez Velazques','Choluteca, Choluteca, Barrio san Lorenzo',54,'Masculino','Operador'),
	  ('0801199200087','Marcio Josue','Funez Ortiz','Choluteca, Choluteca, Barrio Fernandez',46,'Masculino','Servicio al Cliente'),
	  ('0301199800533','Karla Marixa','Herrera Zuniga','Francisco Morazán, Tegucigalpa, Barrio Los Robles',51,'Femenino','Cocinero'),
	  ('0318199104687','Marlon Josue','Mejia Monterroso','Choluteca, Choluteca, Barrio san Lorenzo',48,'Masculino','Servicio al Cliente'),
	  ('0801198504587','Angel David','Martinez Castro','Colon, Tocoa, Barrio Merendon',33,'Femenino','Cocinero'),
	  ('0301199012637','Marcio Javier','Mejia Ponce','Yoro, yoro, Barrio El Confite ',30,'Masculino','Cocinero'),
	  ('0101198605497','Geovany Josue','Martinez Velazques','Comayagua, Comayagua, Barrio Suizo',32,'Femenino','Desarrollador'),
	  ('0801189500458','Mario Josue','Carias Andino','Atlantida, La Ceiba, Barrio La esperanza',34,'Masculino','Servicio al Cliente'),
	  ('0301199800531','Justina Michel','Urbina Zavala','Francisco Morazán, Tegucigalpa, Barrio La Estacion',39,'Femenino','Desarrollador'),
	  ('0301197012639','Maria Fernanda','Vazques Nuñez','Valle, Nacaome, Barrio La Flecha',46,'Femenino','Dependiente'),
	  ('0101197304582','Marian Alejandra','Calix Rodriguez','Colon, Tocoa, Barrio Tamarindo',30,'Femenino','Servicio al Cliente'),
	  ('1807197520568','Karla Marixa','Herrera Zuniga','Valle, Nacaome, Barrio La Flecha',51,'Femenino','Técnicos de mantenimiento'),
	  ('0301197300532','Geovany Josue','Martinez Velazques','Comayagua, Comayagua, Barrio central',53,'Femenino','Cocinero'),
	  ('0801198604587','Juan Jose','Rodriguez Ortiz','Comayagua,Comayagua, Barrio la curva',41,'Masculino','Técnicos de mantenimiento'),
	  ('0101198505897','Marian Alejandra','Calix Rodriguez','El Paraiso, Yuscaran, Barrio San Jose',41,'Masculino','Chofer'),
	  ('0101198300897','Oscar Mauricio','Hernandez Ficosa','Atlantida, La Ceiba, Barrio la Isla',26,'Masculino','Servicio al Cliente');
INSERT INTO eaquemaEmpleado1.empleados(identidad,empNom,empApe,direccion,edad,sexo,puesto) 
VALUES('0301199505466','Manuel Jair','Miranda Quezada','Valle, Nacaome, Barrio La Flecha',44,'Femenino','Chofer'),
('0301199805536','Marcio Josue','Funez Ortiz','Atlantida, La Ceiba, Barrio la Isla',40,'Femenino','Desarrollador'),
('0301199707523','Marixa Leotilda','Calix Fernandez','Colon, Tocoa, Barrio Merendon',30,'Femenino','Cocinero'),
('0801199302546','Karen Valeria','Flores Agurcia','Yoro, Olanchito, Barrio Amaya Amador',59,'Femenino','Operador'),
('0101199501002','Manuel Jair','Miranda Quezada','Choluteca, Choluteca, Barrio san Lorenzo',40,'Masculino','Cocinero'),
('0301199800536','Justina Michel','Urbina Zavala','Colon, Tocoa, Barrio San Francisco',44,'Femenino','Operador'),
('0301199505060','Armando Barreras','Quintanilla Ortiz','El Paraiso, Yuscaran, Barrio San Jose',33,'Masculino','Dependiente'),
('0301199607524','Karen Valeria','Flores Agurcia','Francisco Morazán, Tegucigalpa, Barrio La Estacion',26,'Femenino','Técnicos de mantenimiento'),
('0101188600560','Gustavo Adolfo','Cano Valle','Francisco Morazán, Tegucigalpa, Barrio Los Robles',33,'Masculino','Cocinero'),
('0101198500652','Justina Michel','Urbina Zavala','Atlantida, La Ceiba, Barrio Independencia',32,'Femenino','Chofer'),
('0301198700506','Justina Michel','Urbina Zavala','Francisco Morazán, Tegucigalpa, Barrio Los Robles',37,'Masculino','Desarrollador'),
('0801198502506','Gustavo Adolfo','Cano Valle','Francisco Morazán, Tegucigalpa, Barrio Kenedy',29,'Femenino','Operador'),
('0101198105897','Manuel Jair','Miranda Quezada','Francisco Morazán, Tegucigalpa, Barrio Central',51,'Masculino','Dependiente'),
('0101199604582','Oscar Mauricio','Hernandez Ficosa','Atlantida, La Ceiba,Barrio Mercedez',46,'Masculino','Cocinero'),
('1807198400568','Marixa Leotilda','Calix Fernandez','Choluteca, Choluteca, Barrio El Mango',28,'Masculino','Técnicos de mantenimiento'),
('0101197805817','Marian Alejandra','Calix Rodriguez','Colon, Tocoa, Barrio Merendon',25,'Masculino','Servicio al Cliente'),
('0101198703612','Marcio Javier','Mejia Ponce','Atlantida, La Ceiba, Barrio La esperanza',43,'Masculino','Cocinero'),
('0101198213652','Carolina Martina','Oseguera Quezada','Valle, Nacaome, Barrio El Pino',27,'Femenino','Dependiente'),
('0101197701412','Manuel Jair','Miranda Quezada','Atlantida, La Ceiba, Barrio Independencia',41,'Masculino','Dependiente'),
('0318198902567','Marcio Josue','Funez Ortiz','Choluteca, Choluteca, Barrio El Mango',53,'Masculino','Chofer');
INSERT INTO eaquemaEmpleado1.empleados(identidad,empNom,empApe,direccion,edad,sexo,puesto) 
VALUES('0101198005654','Carlos Fernando','Lopez Caceres','El Paraiso, Yuscaran, Barrio San Jose',32,'Femenino','Desarrollador'),
('1807199801568','Juan Jose','Rodriguez Ortiz','Choluteca, Choluteca, Barrio Marisol',41,'Masculino','Dependiente'),
('0101198005693','Jonatan Alexis','Manuel Bonilla','Choluteca, Choluteca, Barrio El Mango',46,'Masculino','Técnicos de mantenimiento'),
('0801198204577','Geovany Josue','Martinez Velazques','Francisco Morazán, Tegucigalpa, Barrio Los Pinos',41,'Femenino ','Desarrollador'),
('0801187500118','Horacioo Josue','Funez Ortiz','El Paraiso, Yuscaran, Barrio La Biblia',54,'Masculino','Dependiente'),
('0801199302526','Gustavo Adolfo','Cano Valle','Comayagua, Comayagua, Barrio la curva',49,'Femenino','Chofer'),
('0301198012631','Marcio Javier','Mejia Ponce','El Paraiso, Yuscaran, Barrio San Jose ',46,'Masculino','Chofer'),
('0801198401546','Oscar Mauricio','Hernandez Ficosa','El Paraiso, Yuscaran, Barrio San Jose',30,'Femenino','Desarrollador'),
('0318199002507','Angel David','Martinez Castro','Choluteca, Choluteca, Barrio Marisol',40,'Femenino','Servicio al Cliente'),
('0101198503650','Juan Jose','Rodriguez Ortiz','Comayagua, Comayagua, Barrio Ponce',35,'Femenino','Cocinero'),
('0101197901652','Mario Josue','Carias Andino','Colon, Tocoa, Barrio Julian',32,'Femenino','Servicio al Cliente'),
('0318198804680','Justina Michel','Urbina Zavala','Colon, Tocoa, Barrio Julian',30,'Femenino','Servicio al Cliente'),
('1806198700568','Karla Marixa','Herrera Zuniga','Choluteca, Choluteca, Barrio San Franciso',44,'Masculino','Chofer'),
('0801196500458','Alejandra Fernanda','Vazques Nuñez','El Paraiso, Yuscaran, Barrio La Biblia',51,'Femenino','Cocinero'),
('0101198605097','Marian Alejandra','Calix Rodriguez','Francisco Morazán, Tegucigalpa, Barrio Central',33,'Masculino','Servicio al Cliente'),
('0301198745468','Karla Marixa','Herrera Zuniga','Atlantida, La Ceiba, Barrio la Isla',41,'Masculino','Cocinero'),
('1807198402535','Manuel Jair','Miranda Quezada','Francisco Morazán, Tegucigalpa, Barrio Kenedy',25,'Femenino','Operador'),
('0301197500536','Marina Josefa','Carcamo Ortiz','Atlantida, La Ceiba, Barrio Independencia',41,'Masculino','Operador'),
('1807197700568','Juan Jose','Rodriguez Ortiz','Choluteca, Choluteca, Barrio san Lorenzo',53,'Masculino','Servicio al Cliente'),
('0301198305418','Marina Josefa','Carcamo Ortiz','Colon, Tocoa, Barrio Merendon',47,'Masculino','Cocinero');
INSERT INTO eaquemaEmpleado1.empleados(identidad,empNom,empApe,direccion,edad,sexo,puesto) 
VALUES('0101198503652','Marcio Javier','Mejia Ponce','Francisco Morazán, Tegucigalpa, Barrio el Ato',44,'Masculino','Chofer'),
('0801189502458','Tania Carolina','Funez Ortiz','Comayagua, Comayagua, Barrio Suizo',30,'Masculino','Desarrollador'),
('0301199800006','Angel David','Martinez Castro','Comayagua, Comayagua, Barrio Suizo ',54,'Femenino','Operador'),
('0101199605807','Marcio Javier','Mejia Ponce','Choluteca, Choluteca, Barrio san Lorenzo ',53,'Femenino','Cocinero'),
('0301199707304','Marian Alejandra','Calix Rodriguez','Valle, Nacaome, Barrio La Flecha',49,'Femenino','Desarrollador'),
('0301199505411','Karla Marixa','Herrera Zuniga','Francisco Morazán, Tegucigalpa, Barrio Los Robles',25,'Femenino ','Chofer'),
('0101199501452','Tania Carolina','Funez Ortiz','El Paraiso, Yuscaran, Barrio San Jose',32,'Femenino','Chofer'),
('0801198702006','Karla Marixa','Herrera Zuniga','Choluteca, Choluteca, Barrio Fernandez',25,'Masculino','Chofer'),
('0101199605007','Karen Valeria','Flores Agurcia','Valle, Nacaome, Barrio El Pino',40,'Femenino','Desarrollador'),
('0301198812625','Maria Fernanda','Vazques Nuñez','Atlantida, La Ceiba, Barrio La esperanza',30,'Masculino','Chofer'),
('0801198702546','Manuel Jair','Miranda Quezada','Colon, Tocoa, Barrio San Francisco',44,'Masculino','Cocinero'),
('0101198505817','Tania Carolina','Funez Ortiz','Colon, Tocoa, Barrio Julian',38,'Masculino','Operador'),
('0301197800536','Manuel Jair','Miranda Quezada','El Paraiso, Yuscaran, Barrio San Jose',46,'Masculino','Servicio al Cliente'),
('0101197305897','Geovany Josue','Martinez Velazques','Atlantida, La Ceiba,Barrio Mercedez',43,'Femenino','Técnicos de mantenimiento'),
('0101198205150','GUstavo Adolfo','Cano Valle','Atlantida, La Ceiba, Barrio LA Barra',24,'Masculino','Cocinero'),
('0101197701452','Marina Josefa','Carcamo Ortiz','Comayagua, Comayagua, Barrio Ponce',35,'Masculino','Operador'),
('0318199002567','GUstavo Adolfo','Cano Valle','Atlantida, La Ceiba,Barrio Mercedez',30,'Masculino','Dependiente'),
('0301197612639','Marcio Josue','Funez Ortiz','Atlantida, La Ceiba, Barrio la Isla',33,'Masculino','Técnicos de mantenimiento'),
('0101199045897','Marixa Leotilda','Calix Fernandez','El Paraiso, Yuscaran, Barrio San Jose',22,'Femenino','Técnicos de mantenimiento'),
('0801198324587','Catalina Mariana','Oseguera Lopez','El Paraiso, Yuscaran, Barrio La Biblia',38,'Masculino','Cocinero');
INSERT INTO eaquemaEmpleado1.empleados(identidad,empNom,empApe,direccion,edad,sexo,puesto) 
VALUES('0301197505460','Gustavo Adolfo','Cano Valle','Comayagua, Comayagua, Barrio la curva',51,'Masculino','Dependiente'),
('0301198715639','Marcio Josue','Funez Ortiz','Atlantida, La Ceiba,Barrio Mercedez',53,'Masculino','Dependiente'),
('0801189500455','Geovany Josue','Martinez Velazques','Yoro, Olanchito, Barrio Amaya Amador',27,'Femenino','Servicio al Cliente'),
('0301199800036','Geovany Josue','Martinez Velazques','Colon, Tocoa, Barrio Tamarindo',34,'Masculino','Dependiente'),
('0301199707555','Marian Alejandra','Calix Rodriguez','El Paraiso, Yuscaran, Barrio San Jose',49,'Femenino','Desarrollador'),
('0101199604502','Marina Josefa','Carcamo Ortiz','Valle, Nacaome, Barrio El Pino',54,'Femenino','Técnicos de mantenimiento'),
('0101199604501','Catalina Mariana','Oseguera Lopez','El Paraiso, Yuscaran, Barrio San Jose',49,'Femenino','Dependiente'),
('0801199602546','Marcio Josue','Funez Ortiz','Yoro, yoro, Barrio El Confite',32,'Masculino','Servicio al Cliente'),
('0101199501052','Geovany Josue','Martinez Velazques','El Paraiso, Yuscaran, Barrio San Jose',24,'Femenino','Técnicos de mantenimiento'),
('0101198005688','Juan Jose','Rodriguez Ortiz','Francisco Morazán, Tegucigalpa, Barrio Los Robles',25,'Femenino','Cocinero'),
('0801197502546','Marcio Josue','Funez Ortiz','Atlantida, La Ceiba, Barrio LA Barra',45,'Masculino','Cocinero'),
('0101198403653','Karen Valeria','Flores Agurcia','Colon, Tocoa, Barrio la Barra',37,'Masculino','Técnicos de mantenimiento'),
('0101198704682','Geovany Josue','Martinez Velazques','Atlantida, La Ceiba, Barrio LA Barra',29,'Femenino','Cocinero'),
('0801198400458','Angel David','Martinez Castro','Valle, Nacaome, Barrio la Estacion',40,'Masculino','Chofer'),
('0101198305097','Karen Valeria','Flores Agurcia','Francisco Morazán, Tegucigalpa, Barrio el Ato',46,'Masculino','Cocinero'),
('0301197807514','Marcio Javier','Mejia Ponce','El Paraiso, Yuscaran, Barrio La Biblia',44,'Femenino','Chofer'),
('0318198204687','Marina Josefa','Carcamo Ortiz','Comayagua, Comayagua, Barrio Ponce',33,'Femenino','Chofer'),
('0318197804687','Oscar Mauricio','Hernandez Ficosa','Atlantida, La Ceiba, Barrio Potrerito',32,'Femenino','Chofer');
-- Tres gerentes
INSERT INTO eaquemaEmpleado1.empleados(identidad,empNom,empApe,direccion,edad,sexo,puesto)
VALUES ('0301198712439','Oscar Mauricio','Hernandez Ficosa','Comayagua, Comayagua, Barrio San Fransisco',55,'Masculino','Gerente'),
('1807198610568','Marian Alejandra','Calix Rodriguez','Valle, Nacaome, Barrio El Pino',31,'Femenino','Gerente'),
('0101190004248','Jonathan Alexis','Aleman Linares','Atlantida, La Ceiba, Barrio La Isla',35,'Masculino','Gerente');
-- un jefe Calidad
INSERT INTO eaquemaEmpleado1.empleados(identidad,empNom,empApe,direccion,edad,sexo,puesto)
VALUES ('0201199900964','Melva Robertina','Romero Maldonado','Colon, Ilanga, Barrio Sacarias',32,'Femenino','Jefe de Calidad');
-- Un jefe de TI Infraestructura y Desarrollo
INSERT INTO eaquemaEmpleado1.empleados(identidad,empNom,empApe,direccion,edad,sexo,puesto)
VALUES ('0101198500964','Mauricio Carlos','Manuel Osiris','Colon, Ilanga, Barrio Sacarias',33,'Masculino','Jefe de TI Infraestructura'),
('1807198200904','Pepito Gavilan','Marques Soto','Colon, Ilanga, Barrio Sacarias',25,'Masculino','Jefe de TI Desarrollo');
-- Dos Soporte TI
INSERT INTO eaquemaEmpleado1.empleados(identidad,empNom,empApe,direccion,edad,sexo,puesto)
VALUES ('1808197800904','Manolito Oscar','Martinez Soto','Atlantida, La Ceiba, Barrio saquito',36,'Masculino','Soporte TI'),
('0101198500245','Maria Jose','Yunez Vindel','Atlantida, La Ceiba, Barrio los Maestros',33,'Femenino','Soporte TI');
-- un Medios 
INSERT INTO eaquemaEmpleado1.empleados(identidad,empNom,empApe,direccion,edad,sexo,puesto)
VALUES ('0103198200245','Marcos David','Soto Funez','Comayagua, Comayagua, Barrio la vida',36,'Masculino','Medios');
-- Marketing
INSERT INTO eaquemaEmpleado1.empleados(identidad,empNom,empApe,direccion,edad,sexo,puesto)
VALUES ('1805198500427','Reyna Isabel','Vallecio Ruiz','Yoro, Yoro, Barrio Sacarias',37,'Femenino','Marketing');
-- Jefe RRHH
INSERT INTO eaquemaEmpleado1.empleados(identidad,empNom,empApe,direccion,edad,sexo,puesto)
VALUES ('1806197801524','Manuel Jousue','Bonilla Soto','Yoro, Progreso, Barrio La Juventud',39,'Masculino','Jefe RRHH');
-- dos Ejecutivos de RRHH
INSERT INTO eaquemaEmpleado1.empleados(identidad,empNom,empApe,direccion,edad,sexo,puesto)
VALUES ('1807200000429','Hugo Geovany','Murillo Urbina','Yoro, Olanchito, Barrio Central',26,'Masculino','Ejecutivo RRHH'),
('0805188020543','Jim Rosell','Pavon Romero','Choluteca, Choluteca, Barrio El Mango',50,'Masculino','Ejecutivo RRHH');
-- QUEDAN 9 por meter desde la interfaz


select * from eaquemaEmpleado1.planes;

CREATE TABLE eaquemaEmpleado1.planes (
    numeroTel VARCHAR(8) not NULL PRIMARY KEY,
	marca VARCHAR(20) not NULL,
	Tplan money not NULL,
    descripcion VARCHAR(100) not NULL,
    identidad VARCHAR(13) not NULL ,
	CONSTRAINT FK_ID foreign key (identidad) references eaquemaEmpleado1.empleados(identidad)	
);
GO

--Valores para la tabla planes faltan los 9 que se meteran desde la interfaz
INSERT INTO eaquemaEmpleado1.planes(numeroTel,marca,Tplan,descripcion,identidad)
values ('96693356','Samsung','38','Plan Gerente: Llamadas Ilimitadas, 10GB Internet, Mensajes ilimitados','0301198712439'),
('96693350','Samsung','38','Plan Gerente: Llamadas Ilimitadas, 10GB Internet, Mensajes ilimitados','1807198610568'),
('95693856','Samsung','38','Plan Gerente: Llamadas Ilimitadas, 10GB Internet, Mensajes ilimitados','0101190004248'),
('96694355','Huawei','28','Plan Jefes: Llamadas ilimitadas, 5GB Internet, Mensajes ilimitados','0201199900964'),
('93691155','Huawei','28','Plan Jefes: Llamadas ilimitadas, 5GB Internet, Mensajes ilimitados','0101198500964'),
('92393455','Huawei','28','Plan Jefes: Llamadas ilimitadas, 5GB Internet, Mensajes ilimitados','1807198200904'),
('91390353','Huawei','28','Plan Jefes: Llamadas ilimitadas, 5GB Internet, Mensajes ilimitados','1806197801524'),
('90493354','Huawei','20','Plan de mas cargos: Llamadas ilimitadas, 2GB de interet','1808197800904'),
('91637354','Huawei','20','Plan de mas cargos: Llamadas ilimitadas, 2GB de interet','0101198500245'),
('94693259','Huawei','20','Plan de mas cargos: Llamadas ilimitadas, 2GB de interet','0103198200245'),
('93693355','Huawei','20','Plan de mas cargos: Llamadas ilimitadas, 2GB de interet','1805198500427'),
('92693363','Huawei','20','Plan de mas cargos: Llamadas ilimitadas, 2GB de interet','1807200000429'),
('91690356','Huawei','20','Plan de mas cargos: Llamadas ilimitadas, 2GB de interet','0805188020543');

-- Mostrar las columnas de dos tablas
select * from eaquemaEmpleado1.empleados as EMP inner join eaquemaEmpleado1.planes as PLA on EMP.identidad = PLA.identidad;

-- Mostrar columnas especificas 
select EMP.identidad,EMP.empNom,EMP.empApe,EMP.puesto,PLA.numeroTel,PLA.marca,PLA.descripcion from eaquemaEmpleado1.empleados as EMP inner join eaquemaEmpleado1.planes as PLA on EMP.identidad = PLA.identidad 
where (EMP.puesto ='Gerente' or EMP.puesto ='Jefe de Calidad' or EMP.puesto ='Jefe de TI Infraestructura' or EMP.puesto ='Jefe de TI Desarrollo' or EMP.puesto ='Jefe RRHH' or EMP.puesto ='Ejecutivo RRHH' or EMP.puesto ='Marketing' or EMP.puesto ='Medios' or EMP.puesto ='Soporte TI');


-- Procedimiento
create procedure informacion 
as begin
select EMP.identidad as 'Identidad',EMP.empNom as 'Nombre Empleado',EMP.empApe as 'Apellido Empleado',EMP.puesto as 'Puesto Empleado',PLA.numeroTel as 'Telefono',PLA.marca as 'Marca Telefono',PLA.descripcion as 'Descripción del plan' from eaquemaEmpleado1.empleados as EMP 
inner join eaquemaEmpleado1.planes as PLA on EMP.identidad = PLA.identidad 
where (EMP.puesto ='Gerente' or EMP.puesto ='Jefe de Calidad' or EMP.puesto ='Jefe de TI Infraestructura' or EMP.puesto ='Jefe de TI Desarrollo' or EMP.puesto ='Jefe RRHH' or EMP.puesto ='Ejecutivo RRHH' or EMP.puesto ='Marketing' or EMP.puesto ='Medios' or EMP.puesto ='Soporte TI')
end

-- Ejecutar el procedimiento
execute informacion;

-- Eliminar procedimiento
-- drop procedure informacion;



