
use master;
go
drop database if exists zavrsnirad;
go
create database zavrsnirad collate Croatian_CI_AS;
go
use zavrsnirad;
go

create table recepti(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
vrsta varchar(60) not null,
popis_sastojaka text not null,
uputa text not null,
trajanje time(7) 

);


create table sastojci(
sifra int not null primary key identity(1,1),
naziv int not null references recepti(sifra),
podrijetlo varchar(50) not null,
nutritivna_deklaracija decimal(18,2) not null,
energija decimal(18,2) not null,
ugljikohidrati decimal(18,2) not null,
masti decimal(18,2)not null,
zasiceni_seceri decimal(18,2)not null,
vlakna decimal(18,2)not null,
bjelancevine decimal(18,2)not null,
sol decimal(18,2) not null

);


create table sastavi(
sifra int not null primary key identity(1,1),
recept int not null references recepti(sifra),
sastojak varchar(100) not null, 
kolicina decimal(18,2) not null,
napomena varchar(1000) not null

);


