create database AnthonyHaspect

use AnthonyHaspect

create table objets(
	Nom varchar(255) NOT NULL,
	NbParHeure int NOT NULL,
	cout float NOT NULL,
	prix float,
	code varchar(255)primary key)

create table Commande(
	Item varchar(255) NOT NULL,
	NbItem int NOT NULL,
	Heures int NOT NULL,
	Prix float,
	Usager varchar(255) NOT NULL,
	NumeroCmd varchar(255) primary key)


INSERT INTO objets (Nom, NbParHeure, cout, prix, code)
VALUES ('Cannette', 1000, 10.00, 20.00, 'I-235867');

INSERT INTO Commande(Item, NbItem, Heures, Prix, Usager, NumeroCmd)
VALUES ('Cannette', 2000, 2, 20.00, 'Anthony', 'C-564286');