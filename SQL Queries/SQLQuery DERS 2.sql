--select * from TblProduct

--SUB QUERY
--select * from TblProduct where ProductCategory = (select TblCategory.CategoryID from TblCategory where CategoryName ='Beyaz Esya')

--**********************************************************************************************
--AGGREGATE
--count sum avg min max

--???sorgu beyaz esya kategorisindeki �r�n say�s� 
--select count (*) as 'Urun Sayisi' from TblProduct where ProductCategory =1 --(select CategoryID from TblCategory where CategoryName = 'Beyaz Esya')

--???sorgu kategorisi telefon olan �r�nlerin stok say�s�n� 20 azalt 

--update TblProduct set ProductStock -=20 where ProductCategory =(select CategoryID from TblCategory where CategoryName ='Telefon')
--select * from TblProduct

--select SUM(productstock) as 'Toplam Stok Sayisi' from TblProduct where ProductCategory=(select CategoryID from TblCategory where CategoryName='Beyaz Esya')

--???sorgu  buzdolab�ndan elde edece�imiz toplam kar nedir

--select ProductStock * (SalesPrice - PurchasePrice) from TblProduct where ProductID = 1

--???sorgu telefon kategorisi haricindeki �r�nleri satarsam toplam ne kadar kazan�r�m 
--select sum(ProductStock * (SalesPrice-PurchasePrice)) as 'G�zel Sorunun Cevab�' from TblProduct where ProductCategory!=(select CategoryID from TblCategory where CategoryName='Telefon')

--MODERN CAGIN PETROLU VER�D�R. VER� K�MDEYSE O KONUSUR...

--select * from TblProduct

--********************************************************************************************
--B�RLE�T�RMELER
--INNER JOIN

--select productname, ProductStock, ProductCategory from TblProduct -- bu sorgu �al��t���nda productcategory s�tununda rakamlar gelecek. bunu istemiyoruz. burada kategorilerin isimleri yazsin istiyoruz.*

--select productname, productstock, categoryname from TblProduct -- burada b�y�k k�c�k duyarl�l��� yok s�k�nt� yaratm�yor fakat s�t�n isimlerini orjinali gibi degil burada yazd���m haliyle yani k�c�k harflerle veriyor*
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