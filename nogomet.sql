use master;
go
drop database if exists nogomet;
go
create database nogomet;
go
use nogomet
go

create table klub(
sifra int not null primary key identity(1,1),
naziv varchar(35) not null,
osnovan datetime not null,
stadion varchar(50) not null,
predsjednik varchar(50),
drzava varchar(50) not null,
liga int
);

create table utakmica(
sifra int not null primary key identity(1,1),
datum datetime not null,
vrijeme datetime not null,
lokacija varchar(50) not null,
stadion varchar(50) not null,
domaci_klub int references klub(sifra),
gostujuci_klub int references klub(sifra)
);

create table igrac(
sifra int not null primary key identity(1,1),
ime varchar(25) not null,
prezime varchar(25) not null,
datum_rodenja datetime not null,
pozicija varchar(25) not null,
broj_adresa varchar(100) not null,
klub int references klub(sifra)
);

create table trener(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
klub int references klub(sifra),
nacionalnost varchar(50),
iskustvo bit
);