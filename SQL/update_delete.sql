﻿
select * from smjerovi where sifra=2;

update smjerovi
set trajanje=300
where sifra=2;

update smjerovi
set trajanje=200, cijena=1000, vaucer=0
where sifra=3;

update smjerovi set cijena=999 where sifra=2;
update smjerovi set cijena=777.5 where sifra=4;

select * from smjerovi;
update smjerovi set cijena= cijena * 1.1;
select * from smjerovi;

select * from smjerovi;
update smjerovi set cijena= cijena -10;
select * from smjerovi;


update smjerovi 
set izvodiseod= '2024-10-02 18:30:00.000';
where sifra=3;

delete smjerovi where sifra=1;


select * from grupe;

delete grupe where smjer=1; 
delete from clanovi where grupa=2;
delete smjerovi where sifra=1;



insert into polaznici(ime,prezime, email) values
('Tomislav', 'Zrno', 'tomislavzrno12345@gmail.com');

select * from polaznici;
update polaznici set oib= 'HR63083976915'
where sifra=28