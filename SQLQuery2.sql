create database bbank
create table btable
(
id int identity(1,1) primary key,
name varchar(250) not null,
fname varchar(250) not null,
mname varchar(250) not null,
bday varchar(250) not null,
gender varchar(250) not null,
blood varchar(250) not null,
adres varchar(250) not null
);
name,fname,mname,bday,gender,blood,adres
select * from btable;