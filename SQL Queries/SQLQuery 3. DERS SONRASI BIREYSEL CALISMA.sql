--select * from TblOrder
--Toplam fiyat kisimlarini null gecmistim, query uzerinden toplu olarak guncelledim
--update TblOrder set TotalPrice = (Price*Quantity)


--order tablosunu kod numaralarý yerine anlamli metinler ile baþlýklarý da degistirerek gosterdim. toplam fiyatta yuksekten aza dogru siraladim
--select OrderID as 'Siparis Numarasi', ProductName as 'Urun Adi', CustomerName+ ' '+CustomerSurname as 'Ad Soyad', quantity as 'Adet', price as 'Urun Fiyat', totalprice as 'Toplam Fiyat'  from TblOrder
--inner join TblProduct
--on TblProduct.ProductID = TblOrder.Product
--inner join TblCustomer
--on TblCustomer.CustomerID = TblOrder.Customer
--order by 'Toplam Fiyat' desc


--select * from TblCustomer
--hangi sehirden kac musteri var bunu goruntulemek istedim
--select CustomerCity as 'Sehir', count(*) as 'Musteri Sayisi' from TblCustomer group by CustomerCity


--Toplam kac musterim var gormek istedim
--select COUNT(*) as 'Musteri Sayisi'  from TblCustomer


--Kac Farkli Sehirden Musterim var
--select distinct customercity from TblCustomer order by CustomerCity


--ismi a harfi ile baslayan musterilerimi gormek istiyorum
--select * from TblCustomer where CustomerName like 'a%'


--fiyati 1000tl uzeri urunlerimi gormek istiyorum ya da satis durumu false olanlari
--select * from TblProduct where SalesPrice > 1000 or ProductStatus = 0



--sadece atakanin siparis hareketlerini gormek istiyorum. bunu hep atakanin ismini bilerek hem de ismini bilmiyor oldugumu varsayarak yapmak istiyorum 
-- once sadece adini bildigimi varsayarak
--select * from TblOrder where Customer = (select CustomerID from TblCustomer where CustomerName= 'Atakan' and CustomerSurname != 'Yalcin')
--simdi sadece customerid bildigimi varsayarak
--select * from TblOrder where Customer = 5


--urun tablomuza komut kullanarak yeni bir urun ekleyelim sonrasýnda da goruntuleyelim
--insert into TblProduct (ProductName,ProductStock,PurchasePrice,SalesPrice,ProductStatus) values ('Poster', 60,120,180,1) 
--select * from TblProduct


--komut ile son ekledigimiz urunun kategorisini guncelleyelim ve sonra goruntuleyelim
--update TblProduct set ProductCategory = 7 where ProductID = 41
--select * from TblProduct where ProductID = 41