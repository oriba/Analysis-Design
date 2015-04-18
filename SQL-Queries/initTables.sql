Create table Customer(
id varchar(9),
firstName varchar(10),
lastName varchar(10),
email varchar(30),
phone varchar(10),
age int,
[password] varchar(10) NOT NULL,
primary key(id),
CONSTRAINT chk_age CHECK (age>=18 AND age<=99)
);

Create table [Owner](
id varchar(9),
firstName varchar(10),
lastName varchar(10),
email varchar(30),
phone varchar(10),
[password] varchar(10) NOT NULL,
primary key(id)
);

Create table [Admin](
id varchar(9),
firstName varchar(10),
LastName varchar(10),
email varchar(30),
phone varchar(10),
[password]  varchar(10) NOT NULL,
primary key(id)
);

Create table Category(
name varchar(20),
primary key(name)
);
	
Create table Business(
id int,
name varchar(30) UNIQUE,
ownerId varchar(9), 
category varchar(20),
[description] varchar(50) NOT NULL,
[address] varchar(30) NOT NULL,
city varchar(30),
moneyEarned int,
rating real,
primary key(id),
foreign key(ownerId) references Owner(id),
foreign key(category) references Category(name),
CONSTRAINT chk_ratingC CHECK (rating>=1 AND rating<=5),
CONSTRAINT chk_moneyEarned CHECK (moneyEarned>=0)
);

Create table CouponMaker(
id int,
name varchar(30),
[description] varchar(30), 
originalPrice int,
couponPrice int,
rating int,
startDate dateTime,
endDate dateTime,
quantity int,
maxQuantity int,
[status] varchar(15),
business int,
primary key(id),
foreign key(business) references Business(id),
CONSTRAINT const_price CHECK (originalPrice > couponPrice AND originalPrice >= 0),
CONSTRAINT const_quantity CHECK (maxQuantity >=quantity AND quantity>=0),
CONSTRAINT chk_ratingCM CHECK (rating>=1 AND rating<=5),
CONSTRAINT chk_status CHECK ([status] in ('AwaitsApproval','approved','active','inactive'))
);

Create table Coupon(
serialCode int,
isActive bit NOT NULL,
couponMaker int,
customer varchar(9),
primary key(serialCode),
foreign key(couponMaker) references CouponMaker(id),
foreign key(customer) references Customer(id)
);

Create table CustomerCategory(
customerID varchar(9),
category varchar(20),
primary key(customerID,category),
foreign key(customerID) references Customer(id),
foreign key(category) references Category(name)
);