

CREATE DATABASE Products
GO

USE Products
go

CREATE TABLE Product (
ProductId int IDENTITY(1,1) PRIMARY KEY,
Product_Name nvarchar(50) NOT NULL,
Product_Category nvarchar(50) NOT NULL,
Product_Description nvarchar(250) NOT NULL,
Is_Deleted int NOT NULL)
go

INSERT INTO Product Values 
('Cetkica za sminkanje','Sminka', 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptate, hic, assumenda. Dolorum, 
		nulla voluptates cum, minima, temporibus consectetur tempora voluptasrepudiandae ',0),
('Pinceta', 'Nega lica','Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptate, hic, assumenda. Dolorum, 
		nulla voluptates cum, minima, temporibus consectetur tempora voluptasrepudiandae ',0),
('Balzam','Sminka', 'Duis lacus odio, eleifend vel nulla ac, luctus eleifend sapien. Nam turpis nisi, condimentum 
et auctor at, porttitor et nisl.',0),
('Gel za skidanje sminke','Nega lica', 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptate, hic, assumenda. Dolorum, 
		nulla voluptates cum, minima, temporibus consectetur tempora voluptasrepudiandae ',0),
('Maskara','Sminka', 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptate, hic, assumenda. Dolorum, 
		nulla voluptates cum, minima, temporibus consectetur tempora voluptasrepudiandae ',0),
('Roll-on gel za oci', 'Nega lica','Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptate, hic, assumenda. Dolorum, 
		nulla voluptates cum, minima, temporibus consectetur tempora voluptasrepudiandae ',0),
('Cetka za kosu','Preparati za negu kose', 'Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptate, hic, assumenda. Dolorum, 
		nulla voluptates cum, minima, temporibus consectetur tempora voluptasrepudiandae ',0),
('Senka za oci-2u1','Sminka', 'Duis lacus odio, eleifend vel nulla ac, luctus eleifend sapien. Nam turpis nisi, condimentum 
et auctor at, porttitor et nisl.',0),
('Senka u prahu -2u1','Sminka', 'Duis lacus odio, eleifend vel nulla ac, luctus eleifend sapien. Nam turpis nisi, condimentum 
et auctor at, porttitor et nisl.',0),
('Sapun za ruke','Nega ruku', 'Duis lacus odio, eleifend vel nulla ac, luctus eleifend sapien. Nam turpis nisi, condimentum 
et auctor at, porttitor et nisl.',0),
('Sapun za telo','Nega tela', 'Duis lacus odio, eleifend vel nulla ac, luctus eleifend sapien. Nam turpis nisi, condimentum 
et auctor at, porttitor et nisl.',0),
('Gel za kosu','Nega kose', 'Duis lacus odio, eleifend vel nulla ac, luctus eleifend sapien. Nam turpis nisi, condimentum 
et auctor at, porttitor et nisl.',0),
('Krema za suncanje-2u1','Nega tela', 'Duis lacus odio, eleifend vel nulla ac, luctus eleifend sapien. Nam turpis nisi, condimentum 
et auctor at, porttitor et nisl.',0),
('Fen za kosu','Nega kose', 'Duis lacus odio, eleifend vel nulla ac, luctus eleifend sapien. Nam turpis nisi, condimentum 
et auctor at, porttitor et nisl.',0),
('Ruz za usne','Sminka', 'Duis lacus odio, eleifend vel nulla ac, luctus eleifend sapien. Nam turpis nisi, condimentum 
et auctor at, porttitor et nisl.',0),
('Lak za nokte','Preparativa', 'Duis lacus odio, eleifend vel nulla ac, luctus eleifend sapien. Nam turpis nisi, condimentum 
et auctor at, porttitor et nisl.',0),
('Maska za kosu','Nega kose', 'Duis lacus odio, eleifend vel nulla ac, luctus eleifend sapien. Nam turpis nisi, condimentum 
et auctor at, porttitor et nisl.',0),
('Krema za ruke','Nega ruku', 'Duis lacus odio, eleifend vel nulla ac, luctus eleifend sapien. Nam turpis nisi, condimentum 
et auctor at, porttitor et nisl.',0),
('Olovka za usne-2u1','Sminka', 'Duis lacus odio, eleifend vel nulla ac, luctus eleifend sapien. Nam turpis nisi, condimentum 
et auctor at, porttitor et nisl.',0),
('Ruz za usne 2u1','Sminka', 'Duis lacus odio, eleifend vel nulla ac, luctus eleifend sapien. Nam turpis nisi, condimentum 
et auctor at, porttitor et nisl.',0)



select * from Product