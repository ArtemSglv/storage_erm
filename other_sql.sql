alter table roles change column name name varchar(20) unique;


insert into roles (name) values ('Продавец');
insert into roles (name) values ('Кладовщик');
insert into roles (name) values ('Менеджер');

insert into typeclient (type) values ('Покупатель');
insert into typeclient (type) values ('Поставщик');

insert into typeplace (type) values ('Магазин');
insert into typeplace (type) values ('Склад');

insert into products (name,description) values ("meat","");
insert into products (name,description) values ("sugar","");
insert into products (name,description) values ("sult","");
insert into products (name,description) values ("gum","");
insert into products (name,description) values ("gun","");

insert into clients (cl_type_id,name,middle_name,lastname) values ((select id from typeclient where type='Поставщик'),'Andrey','Petrovich','Shcheglov');
insert into clients (cl_type_id,name,middle_name,lastname) values ((select id from typeclient where type='Поставщик'),'Mihail','Petrovich','Shmatko');
insert into clients (cl_type_id,name,middle_name,lastname) values ((select id from typeclient where type='Покупатель'),'Vasiliq','Petrovich','Zyev');

insert into placesofsale (type_id,name,information) values ((select id from typeplace where type='Магазин'),'Orion','OOO Orion');
insert into placesofsale (type_id,name,information) values ((select id from typeplace where type='Магазин'),'Lybava','OOO Orion');
insert into placesofsale (type_id,name,information) values ((select id from typeplace where type='Склад'),'Sklad 2','OOO Orion');

insert into listproducts (prod_id,place_id,count,price) values ((select id from products where name='meat'),
(select id from placesofsale
	where type_id= (select id from typeplace where type='Магазин') and name='Orion'),120,45);
    
insert into users (role_id,name,middle_name,lastname,hashpass,login) 
values (1,'Artem','Andreevich','Shcheglov','admin','admin');

delimiter //
create procedure addProduct(prod_name varchar(20), type_place varchar(20), name_place varchar(20),count int, price int)
begin
	insert into listproducts (prod_id,place_id,count,price) values ((select id from products where name=prod_name),
											(select id from placesofsale
											where type_id= (select id from typeplace where type=type_place) and name=name_place),count,price);
end //
delimiter ;

call addProduct('meat','Магазин','Lybava',300,260);