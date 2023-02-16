create database VenueBooking
--event table
create table Event_Table(
Eventname varchar(50) primary key,
Details varchar(250))
--venue table
drop table VenueTab
create table Venue_Table(
eventname varchar(50),
venuename varchar(50),
price int,
address varchar(250)
foreign key(eventname) references Event_Table(Eventname))
--food table
create table Food_Table(
Eventname varchar(50),
foodname varchar(50),
cost int,
details varchar(250)
foreign key(Eventname) references Event_Table(Eventname))
--decoration table
create table Decoration_Table(
eventName varchar(50),
Price int
foreign key(eventName) references Event_Table(Eventname))
--customer table
create table Customer_RegisterTable(
uname varchar(50) primary key,
eventname varchar(50),
pwd varchar(50),
custname varchar(50),
custadd varchar(50),
mobileno varchar(50),
email varchar(100)
foreign key (eventname)references Event_Table(Eventname))
--customer event table
drop table CustEvent_Table
create table CustEvent_Table(
eventname varchar(50),
people varchar(50),
eventdate datetime,
details varchar(60),
uName varchar(50)
foreign key(uName) references Customer_RegisterTable(uname))
--booking table
create table Booking_Table(
bno float,
bDate datetime,
eventname varchar(50) ,
uName varchar(50),
price int,
seltype varchar(50),
selname varchar(50),
foreign key(uName) references Customer_RegisterTable(uname)
)
---payment table
create table Payment_Table(
bno int,
bDate datetime,
amt int,
eventtype varchar(50),
uname varchar(50),
paytype varchar(50),
details varchar(50)
foreign key(uname) references Customer_RegisterTable(uname))