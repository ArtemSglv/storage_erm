create table users (
id int not null auto_increment,
fio varchar(45),
phonenumber varchar(20),
role varchar(15),
hashpass varchar(120),
login varchar(20),
primary key(id)
);

create table partners (
id int not null auto_increment,
fio varchar(45),
phonenumber varchar(20),
primary key(id)
);

create table products (
prod_id int not null auto_increment,
name varchar(45),
about varchar(120),
primary key(id)
);

create table store (
prod_id int,
product_count int,
price decimal,
primary key(prod_id),
FOREIGN KEY fk_prod(prod_id)
REFERENCES products(prod_id)
);

create table storage (
prod_id int,
product_count int,
price decimal,
primary key(prod_id),
FOREIGN KEY fk_prod(prod_id)
REFERENCES products(prod_id)
);

insert into products (name,about) values ("meat",null);
insert into products (name,about) values ("sugar",null);
insert into products (name,about) values ("sult",null);
insert into products (name,about) values ("gum",null);
insert into products (name,about) values ("gun",null);

insert into partners (fio,phonenumber) values ("Артем Андреевич","58301");
insert into partners (fio,phonenumber) values ("Михаил Петрович","884921");
insert into partners (fio,phonenumber) values ("ООО 'Гауранга'","88005553535");

insert into store (prod_id,product_count,price) values (1,123,34);
insert into store (prod_id,product_count,price) values (3,450,75);
insert into store (prod_id,product_count,price) values (6,3,15000);

insert into storage (prod_id,product_count,price) values (1,240,28);
insert into storage (prod_id,product_count,price) values (6,10,14500);
insert into storage (prod_id,product_count,price) values (2,123,250);
insert into storage (prod_id,product_count,price) values (3,450,70);
insert into storage (prod_id,product_count,price) values (4,123,27);
insert into storage (prod_id,product_count,price) values (5,200,15);



