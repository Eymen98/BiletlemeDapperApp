# CustomerOperations

- CustomerOperations proje'de Biletleme adında bir Veritabanı oluşuturlup, müşteriler tablosu oluşuturuldu. Açılan bu müşteriler tablosunda Asp.net Core MVC  + Dapper Framework kullanarak CRUD (Crate – Read-Update-Delete) işlemleri yapılarak bir Ekleme, Listeleme (Okuma), Silme , Güncelleme  Operasyonları yapılmaktadır.

#

### Uygulama İşlemleri:
- Creat: Yeni müşteri ekleme sayfasıdır. Müşterileri bir arayüz üzerinden ekleyebilir. Ajax post yapılarak backend ‘e gidilip ilgili validasyonlar javascript tarafında verilecek şekilde  yapılmaktadır.

- Read (Listeleme):  Listeleme operasyonu  MVC’deki partialView yapısı kullanarak yapıldı. Sayfa post olmadan(sayfa yenilenmeden) filtreleme yapılabilmektedir. Aktif veya pasif kayıtları sayfa post olmadan görmesi sağlandı.

- Update :  İlgili kaydın içeriğini değiştirebilme imkanı sağlanmaktadır.

- Delete: Her bir kaydın durumu pasife alabilme sağlanmaktadır.

#

### Teknolojiler:
  - kullanıldığı Dil: C#
  - Uygulama Framework :  Asp.NetCore MVC 
  - UI  Framework : Html Bootstrap, JQUERY, Ajax 
  - ORM Tools: Dapper Framework
  - Database: T-SQL
  
  #
  
  ### Proje nasıl çalışır?
   - Db oluşturacağız (Biletleme), Müşteriler tablosu oluşturma script oluşturacağız.
   
      USE [Biletleme]
      GO


      SET ANSI_NULLS ON
      GO

      SET QUOTED_IDENTIFIER ON
      GO

      CREATE TABLE [dbo].[Musteriler] (
          [id]                INT            IDENTITY (1, 1) NOT NULL,
          [musteri_adi]       NVARCHAR (25)  NOT NULL,
          [musteri_soyadi]    NVARCHAR (25)  NOT NULL,
          [dogum_tarihi]      DATE           NOT NULL,
          [tel_no]            NVARCHAR (11)  NULL,
          [email]             NVARCHAR (100) NULL,
          [kayit_tarihi]      DATETIME       NULL,
          [cinsiyet]          TINYINT        NULL,
          [durum]             TINYINT        NULL,
          [guncelleme_tarihi] DATETIME       NULL
      );
      
   - Yeni müşteri ekleme işlemi için iki yöntem var:
     - Dinamik yöntemi,
       ![Inkeddinamik](https://user-images.githubusercontent.com/108132815/211225656-de1dfc10-a22d-4f3c-a044-6d84d7b59d80.jpg)
       
     - Ayrı sayfada ekleme imkanı sağlandı.
       ![2023-01-09 03_10_23-Window](https://user-images.githubusercontent.com/108132815/211225806-704e2378-004a-45fd-a7a1-033df011b13d.png)
      
      
   - Yaptığımız proje visual studio ile açılıp çalıştıracağız.

#

### Proje videosu:
https://user-images.githubusercontent.com/108132815/211226841-444decf4-ff14-495b-bfdf-2c2bd8983430.mp4

     



 

     

