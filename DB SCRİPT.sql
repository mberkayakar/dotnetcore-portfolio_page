--create database BerkayAkarDapperMyPage

use BerkayAkarDapperMyPage
go
create table kullanici (
Id int identity (1,1),
FirstName nvarchar (max),
LastName nvarchar(max),
Adress nvarchar(max),
Email nvarchar(max),
Username nvarchar(max),
Password nvarchar(max),
İmageUrl nvarchar(max),
PhoneNumber nvarchar(max),
shortdescription nvarchar(max),

primary key (id)
)

go 

create table SocialMediaİcons(
Id int identity (1,1),
Link nvarchar(max),
icon nvarchar (max),
Kullanici int,
primary key(Id),
foreign key (Kullanici) references kullanici(Id) on delete cascade,
)

go 

create table yetenekleryüzdeli
(
ID int identity(1,1) primary key,
YETENEK_İSMİ nvarchar(max),
YETENEK_yuzdesi int ,
YETENEK_RENGİ nvarchar (max),
CONSTRAINT CHECK_YETENEK_yuzdesi CHECK (YETENEK_yuzdesi>=0 AND YETENEK_yuzdesi<=0)
 

) 

create table DENEYİM (
Id int identity (1,1),
BASLİK nvarchar (max),
POZİSYON nvarchar (max),
ZAMAN_DİLİMİ_BASLANGİC date,
ZAMAN_DİLİMİ_BİTİS date,
Adress nvarchar(max),
ACİKLAMASİ nvarchar(max),
RESMİ nvarchar(max),
 

primary key (id)
)


create table EGİTİM (
Id int identity (1,1),
BASLİK nvarchar (max),
POZİSYON nvarchar (max),
ZAMAN_DİLİMİ_BASLANGİC date,
ZAMAN_DİLİMİ_BİTİS date,
Adress nvarchar(max),
ACİKLAMASİ nvarchar(max),
RESMİ nvarchar(max),
  
primary key (id)
)


