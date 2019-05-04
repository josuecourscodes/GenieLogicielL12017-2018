create database gestion_personne
go

use gestion_personne
go

create table personne
(
	id int,
	nom varchar(50) not null,
	postnom varchar(50),
	prenom varchar(50),
	sexe varchar(1) default 'M',
	constraint pk_personne primary key(id),
	--constraint uk_personne unique(nom,postnom,prenom)	
)
go

create table telephone
(
	id int,
	id_personne int not null,
	initial varchar(4) not null,
	numero varchar(9),
	constraint pk_telephone primary key(id),
	constraint fk_personne_telephone foreign key(id_personne) references personne(id)
)
go

create table adresse 
(
	id int,
	quartier varchar(30),
	commune varchar(30),
	ville varchar(30),
	pays varchar(30),
	constraint pk_adresse primary key(id)
)
go

create table domicile
(
	id int,
	id_personne int not null,
	id_adresse int not null,
	avenue varchar(50) not null,
	numero_avenue int,
	constraint pk_domicile primary key(id),
	constraint fk_personne_domicile foreign key(id_personne) references personne(id),
	constraint fk_adresse_domicile foreign key(id_adresse) references adresse(id)
)
go


insert into personne(id,nom,postnom,prenom,sexe) 
values(1,'Isamuna','Nkembo','Josué','M'),
(2,'Elida','Sifa',null,'F'),
(3,'Eva','Evelyne','Teta','F')

select id,id_personne,initial,numero from telephone

select MAX(id) as lastId from personne
select MAX(id) as lastId from telephone

select * from personne
select id,id_personne,initial,numero from telephone

delete from personne where id=6

if not exists (select * from personne where id=2)
insert into personne(id,nom,postnom,prenom,sexe) 
values(6,'Isamuna','Nkembo','Josué','M')
else update personne set nom='Isamuna1',postnom='',prenom='Jos',sexe='' where id=2

if exists (select * from personne where id=3)
delete from personne where id=3


--Etat de sortie

--select personne.id,personne.nom,personne.postnom,personne.prenom,personne.sexe,telephone.initial;telephone.numero from personne
--inner join telephone on personne.id=telephone.id_personne

--select personne.id as Code,personne.nom + ' ' + ISNULL(personne.postnom,'') + ' ' + ISNULL(personne.prenom,'') as Nom,
--personne.sexe as Sexe,telephone.initial + '' + telephone.numero as 'Tél.' from personne
--left outer join telephone on personne.id=telephone.id_personne 

--select personne.id as Code,personne.nom + ' ' + ISNULL(personne.postnom,'') + ' ' + ISNULL(personne.prenom,'') as Nom,
--personne.sexe as Sexe,telephone.initial + '' + telephone.numero as 'Tél.' from personne
--left outer join telephone on personne.id=telephone.id_personne order by personne.nom

select personne.id as Code,personne.nom + ' ' + ISNULL(personne.postnom,'') + ' ' + ISNULL(personne.prenom,'') as Nom,
personne.sexe as Sexe,telephone.initial + '' + telephone.numero as 'Tél.' from personne
left outer join telephone on personne.id=telephone.id_personne order by Nom asc

drop schema josam
create schema josam

create table josam.jo
(
	id int identity primary key,
	nom varchar(50)
) 
select * from josam.jo





