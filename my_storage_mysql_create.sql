#Drop table Users;
CREATE TABLE Users (
	id INT NOT NULL AUTO_INCREMENT,
	role_id INT NOT NULL,
	name varchar(20) NOT NULL,
	middle_name varchar(20) NOT NULL,
	lastname varchar(20) NOT NULL,
	hashpass varchar(200) NOT NULL,
	login varchar (25) NOT NULL unique,
	PRIMARY KEY (id)
);

#Drop table Roles;
CREATE TABLE Roles (
	id INT NOT NULL AUTO_INCREMENT,
	name INT NOT NULL UNIQUE,
	PRIMARY KEY (id)
);

#Drop table Clients;
CREATE TABLE Clients (
	id INT NOT NULL AUTO_INCREMENT,
	cl_type_id INT NOT NULL,
	name varchar (20),
	middle_name varchar (20),
	lastname varchar (20),
	PRIMARY KEY (id)
);

#Drop table TypeClient;
CREATE TABLE TypeClient (
	id INT NOT NULL AUTO_INCREMENT,
	type varchar (20) unique,
	type_action varchar (20),
	PRIMARY KEY (id)
);

#Drop table HistoryOfActions;
CREATE TABLE HistoryOfActions (
	id INT NOT NULL AUTO_INCREMENT,
	client_id INT NOT NULL,
	data DATETIME NOT NULL,
	PRIMARY KEY (id)
);

#Drop table Products;
CREATE TABLE Products (
	id INT NOT NULL AUTO_INCREMENT,
	name varchar (20),
	description varchar(200) NOT NULL,
	PRIMARY KEY (id)
);

#Drop table ListProducts;
CREATE TABLE ListProducts (
	id bigint NOT NULL AUTO_INCREMENT,
	prod_id INT NOT NULL,
	place_id INT NOT NULL,
	count INT NOT NULL,
	price DECIMAL NOT NULL,
	PRIMARY KEY (id)
);

#Drop table PlacesOfSale;
CREATE TABLE PlacesOfSale (
	id INT NOT NULL AUTO_INCREMENT,
	type_id INT NOT NULL,
	name varchar(20) NOT NULL,
	information varchar(200) NOT NULL,
	PRIMARY KEY (id)
);

#Drop table TypePlace;
CREATE TABLE TypePlace (
	id INT NOT NULL AUTO_INCREMENT,
	type varchar(20) NOT NULL,
	PRIMARY KEY (id)
);

ALTER TABLE Users ADD CONSTRAINT Users_fk0 FOREIGN KEY (role_id) REFERENCES Roles(id);

ALTER TABLE Clients ADD CONSTRAINT Clients_fk0 FOREIGN KEY (cl_type_id) REFERENCES TypeClient(id);

ALTER TABLE HistoryOfActions ADD CONSTRAINT HistoryOfActions_fk0 FOREIGN KEY (client_id) REFERENCES Clients(id);

ALTER TABLE ListProducts ADD CONSTRAINT ListProducts_fk0 FOREIGN KEY (prod_id) REFERENCES Products(id);

ALTER TABLE ListProducts ADD CONSTRAINT ListProducts_fk1 FOREIGN KEY (place_id) REFERENCES PlacesOfSale(id);

ALTER TABLE PlacesOfSale ADD CONSTRAINT PlacesOfSale_fk0 FOREIGN KEY (type_id) REFERENCES TypePlace(id);

delimiter //
create trigger before_insert_passTomd5 before insert on users for each row
begin
set NEW.hashpass=MD5(NEW.hashpass);
end 
//
delimiter ;