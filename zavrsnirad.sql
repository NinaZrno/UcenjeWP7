﻿
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
uputa text not null,
trajanje int 

);


create table sastojci(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
podrijetlo varchar(50) not null,
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
recept varchar(500) not null,
sastojak int not null references sastojci(sifra),
kolicina decimal(18,2) not null,
napomena varchar(1000) 

);

-- 1
insert into recepti (naziv, vrsta, uputa, trajanje) values
( 'Fritule', 'Desert','1.Korak Sjedinite sve sastojke tako da dobijete glatku smjesu,
ako smjesa nije dovoljno gusta, dodati brasna po potrebi 2.Korak Ugrijati ulje, paziti
da se ulje ne pregrije. 3.Korak Sa dvije zlice manipulirati tijestom tako da dobijete
okruglice. 4.Korak Kuglice ubaciti u zagrijano ulje, kada kuglice porumene treba ih 
okrenuti na drugu stranu i cekati da se do kraja isprze. 5.Korak Kuglice premjestiti
u posudu oblozenu papirnatim rucnicima i zatim sve posipati secerom u prahu. 6.Korak 
Uzivajte u svojim fritulama.', 30);

--1
insert into sastojci( naziv, podrijetlo, energija, ugljikohidrati,
masti, zasiceni_seceri, vlakna, bjelancevine, sol) values 
( 'Jogurt', 'Rusija', 60, 4.50, 2.80, 4.50, 0.17, 3.70, 0.13);

--2
insert into sastojci( naziv, podrijetlo, energija, ugljikohidrati,
masti, zasiceni_seceri, vlakna, bjelancevine, sol) values 
('Jaje', 'EU', 167, 1.50, 11.00, 2.50, 0.00, 13.00, 0.12);

--3
insert into sastojci( naziv, podrijetlo, energija, ugljikohidrati,
masti, zasiceni_seceri, vlakna, bjelancevine, sol) values 
('Secer', 'Polinezija', 387, 0.00, 0.00, 100.00, 0.00, 0.00, 0.00)

--4
insert into sastojci( naziv, podrijetlo, energija, ugljikohidrati,
masti, zasiceni_seceri, vlakna, bjelancevine, sol) values 
('Vanilin secer', 'Madagaskar', 387, 0.00, 0.00, 99.00, 0.00, 0.00, 1.00);

--5
insert into sastojci( naziv, podrijetlo, energija, ugljikohidrati,
masti, zasiceni_seceri, vlakna, bjelancevine, sol) values 
('Sol','Kina',0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 100.00);

--6
insert into sastojci( naziv, podrijetlo, energija, ugljikohidrati,
masti, zasiceni_seceri, vlakna, bjelancevine, sol) values 
('Prasak za pecivo', 'Engleska', 4.70, 0.00, 0.00, 0.00, 0.00, 1.25, 0.28);

--7
insert into sastojci( naziv, podrijetlo, energija, ugljikohidrati,
masti, zasiceni_seceri, vlakna, bjelancevine, sol) values 
('Rakija','Srbija', 185.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00);

--8
insert into sastojci( naziv, podrijetlo, energija, ugljikohidrati,
masti, zasiceni_seceri, vlakna, bjelancevine, sol) values
('Brasno','Srednji Istok', 364, 73.00, 1.70, 2.20, 2.70, 12.00, 0.12);



--1
insert into sastavi(sifra,recept,sastojak, kolicina, napomena) values
(1,'Fritule',1, 200.00, 'Jogurt drzati izvan hladnjaka 30 minuta prije koristenja');

--2
insert into sastavi(sifra,recept,sastojak, kolicina, napomena) values
(1,'Fritule',2,1.00, 'Koristiti jaje srednje velicine');

--3
insert into sastavi(sifra,recept,sastojak, kolicina, napomena) values
(1,'Fritule',3,7, 'Najbolje koristiti morsku sol.');


--4
insert into sastavi(sifra,recept,sastojak, kolicina) values
(1,'Fritule',4,1);

--5
insert into sastavi(sifra,recept,sastojak, kolicina) values
(1,'Fritule',