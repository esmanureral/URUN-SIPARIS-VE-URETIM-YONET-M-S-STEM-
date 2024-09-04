# 🎯 ÜRÜN SİPARİŞ VE ÜRETİM YÖNETİM SİSTEMİ

**Ürün Sipariş ve Üretim Yönetim Sistemi**, kullanıcıların **satıcıların ürünlerini yönetmelerine ve satışlarını takip etmelerine** olanak tanıyan, kullanımı kolay bir yazılım çözümüdür.


## ✨ Özellikler

### 🔑 Kullanıcı Girişi ve Kayıt Olma

- **Kullanıcı Girişi:** Mevcut kullanıcılar, uygulamaya giriş yaparak hesaplarına erişebilir.
- **Kayıt Olma:** Hesabı olmayan kullanıcılar, basit bir form doldurarak hesap oluşturabilir.
- 
  <img src="https://github.com/user-attachments/assets/39073364-813f-43f5-a0bf-561685bdeafe" width=400 />

### 📋 Ana Menü

Giriş yaptıktan sonra üç ana seçenek karşınıza çıkar:

1. **Müşteri İşlemleri:** Müşteri bilgilerini görüntüleyebilir ve yönetebilirsiniz. *(Listele, Kaydet, Sil, Güncelle, Ara)*
2. **Satış İşlemleri:** Satışlarınızı takip edebilir ve yönetebilirsiniz. *(Listele, Kaydet, Sil, Güncelle, Ara)*
3. **Ürün İşlemleri:** Ürünlerinizi ekleyebilir, güncelleyebilir ve listeleyebilirsiniz. *(Listele, Kaydet, Sil, Güncelle, Ara)*

<img src= "https://github.com/user-attachments/assets/911da51d-543e-4a5e-a4f1-654a6c4e2b5d" width=400 />


<img src ="https://github.com/user-attachments/assets/952f58aa-25ae-46ab-9f82-98d83d9ae46b" width=400 />

### 🛒 Satış Takibi

Satış işlemlerini takip edebilir ve detaylı raporlar alabilirsiniz. Örneğin, hangi müşterinin hangi ürünü kaç adet aldığı ve ne kadar ücret ödediği bilgilerine kolayca ulaşabilirsiniz.

<img src ="https://github.com/user-attachments/assets/a46b15cd-74b8-42ab-8057-0aa460fa5a32" width=400 />

## 🚀 Kurulum

### 1. Veritabanını Yükleyin

1. Projeyle birlikte gelen `.bak` dosyasını bilgisayarınızda `C:\` dizinine kopyalayın.
2. **SQL Server Management Studio**'yu (SSMS) açın ve veritabanınızı geri yükleyin:
    - **Object Explorer**'dan **Databases** üzerine sağ tıklayın ve **Restore Database...** seçeneğini seçin.
    - **Source** bölümünde `.bak` dosyasını gösterin ve geri yükleme işlemini başlatın.

### 2. Projeyi İndirin ve Açın

Projeyi GitHub'dan şu komutla klonlayabilirsiniz:

```bash
git clone https://github.com/esmanureral/URUN-SIPARIS-VE-URETIM-YONETIM-SISTEMI.git
```

### 3. Bağlantı Dizisini Güncelleyin
Projenin bağlantı dizisini (App.config veya appsettings.json) kendi SQL Server yapılandırmanıza göre düzenleyin.

### 4. Projeyi Çalıştırın
Veritabanı bağlantısını doğruladıktan sonra, projeyi IDE'niz üzerinden başlatarak kullanmaya başlayabilirsiniz.
