Create table Customer(
id varchar(9),
firstName varchar(10),
lastName varchar(10),
email varchar(20),
phone varchar(10),
age int,
password varchar(10),
primary key(id)
);

Create table [Owner](
id varchar(9),
firstName varchar(30),
lastName varchar(30),
email varchar(30),
phone varchar(10),
[password]  varchar(30),
businessId varchar(30) 
primary key(id)
);

Create table [Admin](
id varchar(9),
firstName varchar(30),
lastName varchar(30),
email varchar(30),
phone varchar(10),
[password] varchar(30),
primary key(id)
);

Create table Category(
id int,
name varchar(30) UNIQUE NOT NULL,
primary key(id)
);

Create table Business(
id int,
name varchar(30) UNIQUE,
ownerId varchar(9), 
categoryId int,
[description] varchar(50),
[address] varchar(30),
city varchar(30),
primary key(id),
foreign key(ownerId) references Owner(id),
foreign key(categoryId) references Category(id)
);

Create table Status(
id int,
name varchar(30) UNIQUE NOT NULL,
primary key(id)
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
[status] int,
business int,
primary key(id),
foreign key(status) references Status(id),
foreign key(business) references Business(id),
CONSTRAINT const_price CHECK (originalPrice > couponPrice AND originalPrice >= 0),
CONSTRAINT const_quantity CHECK (maxQuantity >=quantity AND quantity>=0)
);

Create table Coupon(
serialCode int,
isActive bit,
couponMaker int,
customer varchar(9),
primary key(serialCode),
foreign key(couponMaker) references CouponMaker(id),
foreign key(customer) references Customer(id)
);