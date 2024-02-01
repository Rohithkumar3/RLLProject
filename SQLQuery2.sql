use OnlineBusBookingDb
create table BusBookingDetails
(  BusID VARCHAR(50) NOT NULL,
    username VARCHAR(80) NOT NULL,
    TicketID INT PRIMARY KEY,
    FullName VARCHAR(50) NOT NULL,
    Age INT NOT NULL,
    ContactNumber VARCHAR(10) NOT NULL,
    EmailID VARCHAR(50) NOT NULL,
    NumberOfTickets INT NOT NULL,
    TotalAmount INT NOT NULL,
	Fare int not null,
    PaymentMode VARCHAR(50) NOT NULL,
    PaymentStatus VARCHAR(10),
    TicketStatus VARCHAR(10),   
)

CREATE PROCEDURE Spec_BusBookingDetails
    @BusID VARCHAR(50),
    @username VARCHAR(80),
	@TicketID int ,
    @FullName VARCHAR(50),
    @Age INT,
    @ContactNumber VARCHAR(10),
    @EmailID VARCHAR(50),
    @NumberOfTickets INT,
    @TotalAmount INT,
    @Fare INT,
    @PaymentMode VARCHAR(50),
    @PaymentStatus VARCHAR(10),
    @TicketStatus VARCHAR(10)
AS
BEGIN
    INSERT INTO BusBookingDetails (
        BusID,
        username,
		TicketID,
        FullName,
        Age,
        ContactNumber,
        EmailID,
        NumberOfTickets,
        TotalAmount,
        Fare,
        PaymentMode,
        PaymentStatus,
        TicketStatus
    )
    VALUES (
        @BusID,
        @username,
		@TicketID,
        @FullName,
        @Age,
        @ContactNumber,
        @EmailID,
        @NumberOfTickets,
        @TotalAmount,
        @Fare,
        @PaymentMode,
        @PaymentStatus,
        @TicketStatus
    );
END

create table adminlogin
(
 username varchar(90),
 pswrd varchar(90),
 name varchar(90)
)

insert into adminlogin values('AD123','Admin@123','Raj')

create table usersignup 
(  
  fullname varchar(80),
  dob varchar(80),
  mobile varchar(80),
  email varchar(80),
  stat varchar(80),
  city varchar(80),
  pincode varchar(80),
  adress varchar(80),
  username varchar(80) primary key,
  pswrd varchar(80)
)

create procedure pros_usersignup 
(
  @fullname1 varchar(80),
  @dob1 varchar(80),
  @mobile1 varchar(80),
  @email1 varchar(80),
  @stat1 varchar(80),
  @city1 varchar(80),
  @pincode1 varchar(80),
  @adress1 varchar(80),
  @username1 varchar(80),
  @pswrd1 varchar(80)
)
as
insert into usersignup values(@fullname1,@dob1,@mobile1,@email1,@stat1,@city1,@pincode1,@adress1,@username1,@pswrd1)

create table BusInventory
(BusId varchar(50) primary key,
BusName varchar(15) not null,
BusCategory varchar(10) Check (BusCategory IN ('Ac','Non AC')),
Availability_Seats int not null,
Boarding varchar(50),
Departure varchar(50),
StartTime varchar(50),
EndTime varchar(50),
Price int)

CREATE PROCEDURE Spec_BusInventory
    @BusId varchar(50),
    @BusName varchar(15),
    @BusCategory varchar(10),
    @Availability_Seats int,
    @Boarding varchar(50),
    @Departure varchar(50),
    @StartTime varchar(50),
    @EndTime varchar(50),
    @Price int
AS
BEGIN
    -- Check if BusCategory is either 'Ac' or 'Non AC'
    IF @BusCategory NOT IN ('Ac', 'Non AC')
    BEGIN
        
        RETURN
    END

    -- Insert data into BusInventory table
    INSERT INTO BusInventory (
        BusId,
        BusName,
        BusCategory,
        Availability_Seats,
        Boarding,
        Departure,
        StartTime,
        EndTime,
        Price
    )
    VALUES (
        @BusId,
        @BusName,
        @BusCategory,
        @Availability_Seats,
        @Boarding,
        @Departure,
        @StartTime,
        @EndTime,
        @Price
    )
END

select * from BusBookingDetails
select * from adminlogin
select * from BusInventory
select * from usersignup