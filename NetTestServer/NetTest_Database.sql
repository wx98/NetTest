create database NetTest_Database;
use NetTest_Database;
create table users
(
	uName varchar (32) primary key,
	uPass varchar (512)
)
create table tests
(
	ID int identity(1,1) primary key,
	tTitle varchar (256),
	tAnswer varchar (2),
	tDate varchar (32),
	tText text,
)
create table marks
(
	ID int identity(1,1) primary key,
	uName varchar(32) foreign key references users(uName) on delete cascade,
	mDate varchar(32),
	mValue int 
)