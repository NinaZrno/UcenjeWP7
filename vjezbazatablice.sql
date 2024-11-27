use master;
go
drop vjezbezatablice;
go
create database vjezbezatablice;
go

use vjezbezatablice;

create table ispitnirokovi(
sifra int,
predmet varchar(50),
vrstaispita int,
datum datetime,
pristupio varchar(50)
);


create table pristupnici(
ispitnirok int,
student varchar(50),
brojbodova int,
ocjena int
);
