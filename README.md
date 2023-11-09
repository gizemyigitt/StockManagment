# StockManagment Application
1.Arayüz
![Ekran görüntüsü 2023-11-07 163912](https://github.com/gizemyigitt/StockManagment/assets/63100787/d5a36559-87ae-43ea-986d-2a7b8a683d89)
![Ekran görüntüsü 2023-11-07 163935](https://github.com/gizemyigitt/StockManagment/assets/63100787/b383d08f-55c4-44a1-83f0-e23a3448876d)
![Ekran görüntüsü 2023-11-07 164347](https://github.com/gizemyigitt/StockManagment/assets/63100787/a635153e-1e69-44ec-9f04-39a2e332e064)
2.	Sipariş Kayıtları Formu
•	Sipariş Kayıtları Formunda yer alan datagrdiview’ a ait satırlara çift tıklama yapıldığında Sipariş Girişi formuna yönlendirilmekte ve ilgili Evrak No ile OrderJson dosyasına kaydedilmiş veriler sayfaya iletilmektedir.
•	Yeni Sipariş Ekle, Stok Kart Listele Butonları da aynı zamanda başarıyla sonuçlanmıştır.
3.	FrmStokKart Formu
•	StockJson dosyasının okunmasıyla birlikte ListBox kontrolüne Stok Adı bilgileri listelenmiştir.
•	Yeni veri eklenmesi durumunda, veri json dosyasına kaydedilmiş ve ListBox da listelenmiştir
•	Boş veri ve aynı Stok Koduna sahip verilerin eklenmesi engellenmiştir.
•	ListBox üzerinde seçilen verinin bilgileri ilgili labellarda gösterilmiştir ve yapılan değişiklikler Json dosyası üzerinde güncellenmiştir.
4.	Sipariş Girişi Formu
•	Sipariş Girişi Ekranında Evrak Numarası ve Sipariş Tarihi ile oluşturulacak sipariş satırlarının hücrelerinde veri girişi, enter ile hücre geçişleri, satır ekleme ve grid içerisindeki satırlara ait toplam tutarın gösterilmesi fonksiyonlarının kaydedilip tekrar evrakno girilerek çağırılması işlemleri başarıyla gerçekleştirilmiştir.
•	İşlem bittikten sonra Sipariş Kayıtları formu üzerindeki datagrid içinde listelenmesi işlemi Sipariş Bilgilerini kaydet butonu ile başarılı bir şekilde gerçekleştirilmiştir.
