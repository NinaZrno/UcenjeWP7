

use master;
go
drop database if exists edunovawp7;
go
create database edunovawp7;
go


use edunovawp7;

create table smjerovi(
sifra int,
naziv varchar(50),
trajanje int,
cijena decimal(18,2),
vaucer bit,
izvodiseod datetime
);


create table polaznici(
sifra int,
ime varchar(50),
prezime varchar (50),
oib char(11),
email varchar(100)
);