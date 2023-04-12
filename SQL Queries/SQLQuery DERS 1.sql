--SQL
--  DML KOMUTLARI - DATA MANUPILATION LANGUAGE
--  SELECT - INSERT- DELETE - UPDATE - WEB TEMELL� UYGULAMALARDA BUTUN �SLEMLER BU DORT TEMEL KOMUT ETRAFINDA GERCEKLESIR

-- select ifadesinin syntax i  - select column1,column2,columnN from tableName

-- columnlar�n t�m�n� secmek istiyosak bunu "t�m�" anlam�na gelen * ile yapar�z.

-- select * from TblProduct

--�ARTLI SORGULAR 
--IF ELSE - TSQL - WHERE

--select * from TblProduct where ProductID = 4

--SQL L�KE ��LEC�
--Kelimelerin i�inde arama yapmaktad�r - lika ada - ada ile ba�layan �eklinde bir aramad�r
--L�KE
--select * from TblProduct where ProductName like '%a%'  -- i�erisinde a harfi ge�en b�t�n �r�nleri getir.
--select * from TblProduct where ProductName like 'a%'  -- a harfi ile ba�layan �r�nleri getir.
--select * from TblProduct where ProductName like '%a'  -- a harfi ile biten �r�nleri getir.
--NOT L�KE 
--select * from TblProduct where ProductName not like '%a%' -- i�erisinde a harfi ge�meyenleri getirir.
--select * from TblProduct where ProductName not like 'a%' -- a harfi ile ba�lamayanlar� getirir.

--aggregate komutlar� - COUNT SUM AVG MAX M�N

--select count(*) from tblproduct -- tablomuzdaki toplam kay�t say�s�n� bize vermi� olur
-- select COUNT(*) as 'Toplam' from TblProduct where ProductID > 4

-- INSERT KOMUTU

--insert into TblCategory (CategoryName) values ('Hali')
--insert into TblCategory (CategoryName) values ('Mutfak')
select * from TblCategory