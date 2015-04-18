------------------- Category ------------------- 
insert into Category
values ('food');

insert into Category
values ('entartainment');

insert into Category
values ('Health And Beauty');

insert into Category
values ('apparel');

insert into Category
values ('electronics');

------------------- Customer ------------------- 
insert into Customer
values ('333333333','aviram','vahaba','aviram@gmail.com','0503333333',26,'333');

insert into Customer
values ('222222222','lihi','verchik','lihi@gmail.com','0502222222',22,'222');

------------------- CustomerCategory ------------------- 
insert into CustomerCategory
values ('333333333','food');

insert into CustomerCategory
values ('333333333','Health And Beauty');

insert into CustomerCategory
values ('222222222','apparel');

------------------- Owner ------------------- 
insert into Owner
values ('111111111','ori','bar-ilan','ori@gmail.com','0501111111','111');

------------------- Admin ------------------- 
insert into Admin
values ('444444444','lital','morali','lital@gmail.com','0504444444','444');

------------------- Business ------------------- 
insert into Business
values ('1','cafe-cafe','111111111','food','description','BIG','Beer-Sheva',200,4);

------------------- CouponMaker ------------------- 
insert into CouponMaker
values (1,'coupon1','description',50,30,1,'04-10-2015','04-25-2015',20,30,'approved',1);

------------------- Coupon ------------------- 
insert into Coupon
values (1,1,1,'333333333');