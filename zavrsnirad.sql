
use master;
go
drop database if exists zavrsnirad;
go
create database zavrsnirad;
go
use zavrsnirad;
go

create table recepti(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
vrsta varchar(60) not null,
uputa varchar(1000) not null,
trajanje int not null

);

create table sastav(
sifra int not null primary key identity(1,1),
recept int not null references recepti(sifra),
sastojak varchar(100) not null,
kolicina bit not null,
napomena varchar(1000) not null

);

create table sastojci(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null references recepti(sifra),
podrijetlo varchar(50) not null,
nutritivna_deklaracija decimal not null,
energija decimal not null,
ugljikohidrati decimal not null,
masti decimal not null,
zasiceni_seceri decimal not null,
vlakna decimal not null,
bjelancevine decimal not null,
sol decimal not null

);

-- 1
insert into recepti
(sifra,naziv,vrsta,uputa,trajanje)
(1234,'Goveda juha','toplo predjelo','ulijte vodu u lonac',25:10)