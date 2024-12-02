use master;
go
drop database if exists vjezbezatablice;
go
create database vjezbezatablice;
go

use vjezbezatablice;

create table ispitnirok(
sifra int,
predmet varchar(50),
vrstaispita varchar(25),
datum datetime,
pristupio varchar(50)
);


create table pristupnici(
ispitnirok int,
student varchar(50),
brojbodova int,
ocjena int
);
