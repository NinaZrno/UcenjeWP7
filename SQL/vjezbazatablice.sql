use master;
go
drop database if exists vjezbezatablice;
go
create database vjezbezatablice;
go

use vjezbezatablice;

create table ispitnirok(
sifra int not null primary key identity (1,1),
predmet varchar(50) not null,
vrstaispita varchar(25) not null,
datum datetime null,
pristupio bit not null
);


create table pristupnici(
ispitnirok int not null references ispitnirok(sifra),
student varchar(50) not null,
brojbodova int not null,
ocjena int not null
);
