﻿

select * from grupe;

select a. naziv, b. naziv as grupa, b. predavac
from smjerovi a inner join grupe b
on  a. sifra= b. smjer;

select * from smjerovi;

update grupe set predavac='Marija Perić' where sifra=1;

update grupe set predavac='Pero Perić' where sifra=2;

update grupe set predavac='Karlo Let' where sifra=3;

update grupe set predavac='Karla Let' where sifra=4;


select a. naziv, b. naziv as grupa, b. predavac
from smjerovi a left join grupe b
on  a. sifra= b. smjer;


select b.naziv as grupa, 
a.naziv as smjer,
d.ime, d.prezime
from smjerovi a 
inner join grupe b on a.sifra=b.smjer
inner join clanovi c on b.sifra =c. grupa
inner join polaznici d on d.sifra= c.polaznik;


use knjiznica;

select a. ime, a. prezime, 
b.naslov, c.naziv as izdavac, d.naziv as mjesto
from autor a
inner join katalog b on a.sifra= b. autor
inner join izdavac c on c.sifra= b.izdavac
inner join mjesto d on d.sifra= b.mjesto
where a.ime like 'I%'
order by a.prezime;



use svastara;

select  sum( b.cijena * b.kolicina) as vrijednost
from Artikli a
inner join ArtikliNaPrimci b on a.sifra=b.artikl
inner join Primke c on c.sifra=b.primka
where c.redniBroj='1/2008';


select c.redniBroj,
d.naziv, 
sum( b.cijena * b.kolicina) as vrijednost
from Artikli a
inner join ArtikliNaPrimci b on a.sifra=b.artikl
inner join Primke c on c.sifra=b.primka
inner join Dobavljaci d on c.dobavljac=d.sifra
group by c.redniBroj, d.naziv
having sum( b.cijena * b.kolicina)>13000000
order by 2 desc;



select count(*) from Artikli;
select distinct artikl from ArtikliNaPrimci;

select * from Artikli where sifra not in(
select distinct artikl from ArtikliNaPrimci
);
