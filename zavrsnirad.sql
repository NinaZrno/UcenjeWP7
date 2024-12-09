
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
trajanje varchar(50) 

);


create table sastojci(
sifra int not null primary key identity(1,1),
naziv int not null references recepti(sifra),
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
recept int not null references recepti(sifra),
sastojak varchar(1000) not null, 
kolicina decimal(18,2) not null,
napomena varchar(1000) not null

);

-- 1
insert into recepti (naziv, vrsta, uputa, trajanje) values
( 'Fritule', 'Desert','1.Korak Sjedinite sve sastojke tako da dobijete glatku smjesu,
ako smjesa nije dovoljno gusta, dodati brasna po potrebi 2.Korak Ugrijati ulje, paziti
da se ulje ne pregrije. 3.Korak Sa dvije zlice manipulirati tijestom tako da dobijete
okruglice. 4.Korak Kuglice ubaciti u zagrijano ulje, kada kuglice porumene treba ih 
okrenuti na drugu stranu i cekati da se do kraja isprze. 5.Korak Kuglice premjestiti
u posudu oblozenu papirnatim rucnicima i zatim sve posipati secerom u prahu. 6.Korak 
Uzivajte u svojim fritulama.', '30 minuta');

--1
insert into sastojci( naziv, podrijetlo, energija, ugljikohidrati,
masti, zasiceni_seceri, vlakna, bjelancevine, sol) values 
( 1, 'Hrvatska', 1575.00, 24.90, 30.60, 80.00,220.00, 25.00, 7.00); 

--1
insert into sastavi(sifra,recept,sastojak, kolicina, napomena) values
(1,1,'200ml tekuceg jogurta, 1 jaje, 70g secera, 1 vrecica
vanilin secera, prstohvat soli, 1/2 vrecice praska za pecivo,
1 mala zlicica rakije, 200 g glatkog brasna, secer u prahu', 400.00,
'Posluziti uz razne vrste dzemova.');