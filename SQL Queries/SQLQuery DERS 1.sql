--SQL
--  DML KOMUTLARI - DATA MANUPILATION LANGUAGE
--  SELECT - INSERT- DELETE - UPDATE - WEB TEMELLÝ UYGULAMALARDA BUTUN ÝSLEMLER BU DORT TEMEL KOMUT ETRAFINDA GERCEKLESIR

-- select ifadesinin syntax i  - select column1,column2,columnN from tableName

-- columnlarýn tümünü secmek istiyosak bunu "tümü" anlamýna gelen * ile yaparýz.

-- select * from TblProduct

--ÞARTLI SORGULAR 
--IF ELSE - TSQL - WHERE

--select * from TblProduct where ProductID = 4

--SQL LÝKE ÝÞLECÝ
--Kelimelerin içinde arama yapmaktadýr - lika ada - ada ile baþlayan þeklinde bir aramadýr
--LÝKE
--select * from TblProduct where ProductName like '%a%'  -- içerisinde a harfi geçen bütün ürünleri getir.
--select * from TblProduct where ProductName like 'a%'  -- a harfi ile baþlayan ürünleri getir.
--select * from TblProduct where ProductName like '%a'  -- a harfi ile biten ürünleri getir.
--NOT LÝKE 
--select * from TblProduct where ProductName not like '%a%' -- içerisinde a harfi geçmeyenleri getirir.
--select * from TblProduct where ProductName not like 'a%' -- a harfi ile baþlamayanlarý getirir.

--aggregate komutlarý - COUNT SUM AVG MAX MÝN

--select count(*) from tblproduct -- tablomuzdaki toplam kayýt sayýsýný bize vermiþ olur
-- select COUNT(*) as 'Toplam' from TblProduct where ProductID > 4

-- INSERT KOMUTU

--insert into TblCategory (CategoryName) values ('Hali')
--insert into TblCategory (CategoryName) values ('Mutfak')
select * from TblCategory