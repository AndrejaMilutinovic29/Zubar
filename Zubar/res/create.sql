create database Zubar;
GO
use Zubar;
GO
create table Doktor(
id INT IDENTITY(1,1) PRIMARY KEY,
ime NVARCHAR(20),
prezime NVARCHAR(20),
specijalizacija NVARCHAR(20),
broj_tel INT)
GO
create table Pacijent(
id INT IDENTITY(1,1) PRIMARY KEY,
ime NVARCHAR(20) NOT NULL,
prezime NVARCHAR(20) NOT NULL,
broj_tel INT NOT NULL,
broj_zk INT NOT NULL
)
GO
create table Karton(
id INT IDENTITY(1,1) PRIMARY KEY,
pacijent_id INT FOREIGN KEY REFERENCES Pacijent(id) NOT NULL,
doktor_id INT FOREIGN KEY REFERENCES Doktor(id) NULL,
stanje NVARCHAR(200),
UNIQUE (pacijent_id)
)

GO
create table Dijagnoza(
id INT IDENTITY(1,1) PRIMARY KEY,
opis NVARCHAR(120))

GO

create table Termin(
id INT IDENTITY(1,1) PRIMARY KEY,
datum DATE,
vreme_pocetka TIME(0),
vreme_zavrsetka TIME(0),
pacijent_id INT FOREIGN KEY REFERENCES Pacijent(id),
doktor_id INT FOREIGN KEY REFERENCES Doktor(id),
dijagnoza_id INT FOREIGN KEY REFERENCES Dijagnoza(id),
cena INT)

GO 
CREATE TRIGGER napraviKarton ON Pacijent
FOR INSERT
AS

INSERT INTO Karton
        (pacijent_id, doktor_id, stanje)
    SELECT
        id  , null , null
        FROM inserted


GO

CREATE TRIGGER obrisiPacijenta ON Pacijent
INSTEAD OF DELETE
AS
    DELETE FROM Karton
    WHERE pacijent_id = (SELECT deleted.id FROM deleted)

	DELETE FROM Termin
    WHERE pacijent_id = (SELECT deleted.id FROM deleted)

	 DELETE Pacijent
     FROM DELETED D
     INNER JOIN Pacijent T ON T.id = D.id

GO

CREATE TRIGGER obrisiDoktora ON Doktor
INSTEAD OF DELETE
AS
    DELETE FROM Karton
    WHERE doktor_id = (SELECT deleted.id FROM deleted)

	DELETE FROM Termin
    WHERE doktor_id = (SELECT deleted.id FROM deleted)

	 DELETE Doktor
     FROM DELETED D
     INNER JOIN Doktor T ON T.id = D.id