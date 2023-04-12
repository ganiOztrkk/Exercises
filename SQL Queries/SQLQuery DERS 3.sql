--select productname as 'Urun Adi', customername + ' ' +customersurname as 'Musteri', quantity as 'Adet' , price as 'Fiyat' , totalprice as 'Toplam Fiyat'  from TblOrder
--inner join TblProduct
--on TblProduct.ProductCategory = TblOrder.Product
--inner join TblCustomer
--on TblCustomer.CustomerID = TblOrder.Customer
--where Quantity = 1 or Price < 10000 
--where ProductName like '%a%'


--select categoryname, COUNT(*) as 'adet' from TblProduct
--inner join TblCategory
--on TblCategory.CategoryID = TblProduct.ProductCategory
--group by CategoryName
--order by 'adet'

--hatalarý okumaya baþladýðýnýzda olmaya baþlarsýnýz
--turkce kaynaklar yeterli gelmemeye basladigi takdirde olmaya baslarsiniz

--PROCEDURE
--DML - SELECT INSERT UPDATE DELETE
--DDL (OBJE)
--DDL KOMUTLARI - CREATE ALTER DROP -- olusturmak icin create, duzenleme icin alter, silme icin drop

--Create Table Deneme
--(
--DenemeID int identity (1,1),
--Ad nvarchar(50),
--Soyad nvarchar(50)
--)
--select * from Deneme

--PROCEDURE - KOD TEKRARINI ONLEMEK ICIN KULLANIRIZ - C# METOT GIBI DUSUN
--DAHA GUVENLI KOD YAZMANIZI SAGLAR, DAHA YALIN KOD YAZMANIZI SAGLAR

--Create Procedure Pro1
--as
--select * from TblProduct where ProductName like '%a%'

--execute Pro1

--create procedure Pro2
--as
--select ProductName, productstock from TblProduct where ProductStock > 100

--execute Pro2

--TRIGGER - HERHANGI BIR TABLODA BIR ISLEM GERCEKLESTIGINDE BASKA BIR TABLODA OTONOM DEGISIKLIK YARATMAMIZI SAGLAR 

--Create table TblStock
--(
--TotalStock int
--)

--insert into TblStock (TotalStock) values ((select COUNT(*) from TblProduct))
--select * from tblstock

--Create Trigger Arttir
--on TblProduct
--after insert 
--as 
--update tblstock set TotalStock+=1

--Create Trigger Azalt
--on TblProduct
--after delete 
--as 
--update tblstock set TotalStock-=1

--NULL DEGERLER
--select * from TblProduct where ProductName is null 
--update TblProduct set ProductStock = 200 where ProductName is null 
--select * from TblProduct
--select * from TblProduct where PurchasePrice is not null

--DISTINCT
--tekrar eden verileri tek hale getirir. misal ayni sehirden 5 farkli kayit varsa ve biz sadece kac farkli sehirden insan var bunu gormek istiyorsak

--select distinct(CustomerCity) from TblCustomer

--BETWEEN OPERATORU - ARALIK DEGERI BELIRTMEMIZI SAGLAR
--BU ISLEMI NORMALDE WHERE SORGUSU ILE DE YAPABILIRIZ FAKAT DAHA PRATIK YONTEMI BETWEEN ILE UYGULARIZ
--burada iki deger de dahil edilir - 10 20 arasý dersek iki ifadeyi de dahil eder

--select * from TblProduct where ProductStock between 50 and 150

--T-SQL
--ORNEK 1
--declare @sayi1 int
--set @sayi1 = 10
--declare @sayi2 int
--set @sayi2 = 10
--declare @toplam int
--set @toplam = @sayi1 + @sayi2
--select @toplam as 'toplam'
--ORNEK 2
--declare @sayi1 int
--set @sayi1 = 10
--if (@sayi1=10)
--print 'islem basarili'
--else
--print 'islem hatali'
--ORNEK 3
--declare @sayi1 int
--set @sayi1 = 10
--declare @sayi2 int
--set @sayi2 = 5
--if (@sayi1*@sayi2 > 100)
--print 'sayi 100den buyuk'
--else
--print 'sayi 100den kucuk'

--WHILE - DOGRU DURUMLARINDA KULLANILIR
--SQL DE FOREACH DO WHILE FOR KEYWORDLERI BULUNMAZ

declare @sayac int
set @sayac = 1
while (@sayac <=5)
begin 
print 'Merhaba Ayten :) ehie'
set @sayac+=1
end