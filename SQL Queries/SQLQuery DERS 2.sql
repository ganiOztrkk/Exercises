--select * from TblProduct

--SUB QUERY
--select * from TblProduct where ProductCategory = (select TblCategory.CategoryID from TblCategory where CategoryName ='Beyaz Esya')

--**********************************************************************************************
--AGGREGATE
--count sum avg min max

--???sorgu beyaz esya kategorisindeki ürün sayýsý 
--select count (*) as 'Urun Sayisi' from TblProduct where ProductCategory =1 --(select CategoryID from TblCategory where CategoryName = 'Beyaz Esya')

--???sorgu kategorisi telefon olan ürünlerin stok sayýsýný 20 azalt 

--update TblProduct set ProductStock -=20 where ProductCategory =(select CategoryID from TblCategory where CategoryName ='Telefon')
--select * from TblProduct

--select SUM(productstock) as 'Toplam Stok Sayisi' from TblProduct where ProductCategory=(select CategoryID from TblCategory where CategoryName='Beyaz Esya')

--???sorgu  buzdolabýndan elde edeceðimiz toplam kar nedir

--select ProductStock * (SalesPrice - PurchasePrice) from TblProduct where ProductID = 1

--???sorgu telefon kategorisi haricindeki ürünleri satarsam toplam ne kadar kazanýrým 
--select sum(ProductStock * (SalesPrice-PurchasePrice)) as 'Güzel Sorunun Cevabý' from TblProduct where ProductCategory!=(select CategoryID from TblCategory where CategoryName='Telefon')

--MODERN CAGIN PETROLU VERÝDÝR. VERÝ KÝMDEYSE O KONUSUR...

--select * from TblProduct

--********************************************************************************************
--BÝRLEÞTÝRMELER
--INNER JOIN

--select productname, ProductStock, ProductCategory from TblProduct -- bu sorgu çalýþtýðýnda productcategory sütununda rakamlar gelecek. bunu istemiyoruz. burada kategorilerin isimleri yazsin istiyoruz.*

--select productname, productstock, categoryname from TblProduct -- burada büyük kücük duyarlýlýðý yok sýkýntý yaratmýyor fakat sütün isimlerini orjinali gibi degil burada yazdýðým haliyle yani kücük harflerle veriyor*
--inner join TblCategory
--on TblCategory.CategoryID = TblProduct.ProductCategory

--***********************************************************************************
-- GROUP BY
--???sorgu musterilerin sehirlerine gore, hangi sehirde kac musteri var 
--select customercity, count(*) from tblcustomer group by customercity order by customercity desc

--select categoryname, COUNT(*) as  'Urun sayisi' from TblProduct
--inner join TblCategory
--on TblProduct.ProductCategory = TblCategory.CategoryID
--group by CategoryName order by 'Urun sayisi'