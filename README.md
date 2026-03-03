# 🎬 CinemaTracker (Harun Sinevazyon)

CinemaTracker, sinematik evrendeki favori filmlerinizi keşfetmenizi, detaylarını incelemenizi ve kendi "Editörün Seçimleri" listenizi oluşturmanızı sağlayan modern bir masaüstü uygulamasıdır. 

OMDb API gücüyle internetten anlık film verileri çeker ve kişisel favorilerinizi yerel MySQL veritabanınızda güvenle saklar.

## 🚀 Özellikler
* **Anlık API Entegrasyonu:** OMDb API kullanarak filmlerin afiş, özet, yıl ve IMDb puanı bilgilerini asenkron olarak çeker.
* **Dinamik Top 10 Listesi:** Kod derlemeye gerek kalmadan, dışarıdan okunan `top10.txt` konfigürasyon dosyası üzerinden listeyi anında güncelleyebilirsiniz.
* **Editörün Seçimleri (Veritabanı):** Filmleri tek tıkla favorilere ekleyip çıkarabilirsiniz. Veriler MySQL veritabanında (`sinevazyon_db`) tutulur.
* **Karanlık Tema & Ghost Mode UI:** Göz yormayan sinematik arayüz (Dark Mode) ve sayfalar arası geçişlerde önceki ekranı askıya alan "Ghost Mode" pencere yönetimi.
* **Asenkron Çalışma:** Arayüzü dondurmayan `async/await` mimarisi ile pürüzsüz kullanıcı deneyimi.

## 🛠️ Kullanılan Teknolojiler
* **Dil:** C#
* **Arayüz:** Windows Forms (.NET)
* **Veritabanı:** MySQL
* **Kütüphaneler:** `MySql.Data`, `System.Text.Json`
* **API:** OMDb (The Open Movie Database)

## ⚙️ Kurulum ve Çalıştırma
1. Projeyi klonlayın: `git clone https://github.com/KULLANICI_ADIN/CinemaTracker.git`
2. MySQL üzerinde veritabanını oluşturun:
   ```sql
   CREATE DATABASE sinevazyon_db;
   USE sinevazyon_db;
   CREATE TABLE editor_secimleri (
       id INT AUTO_INCREMENT PRIMARY KEY,
       imdb_id VARCHAR(20) NOT NULL UNIQUE,
       film_adi VARCHAR(255) NOT NULL,
       poster_url VARCHAR(500),
       eklenme_tarihi TIMESTAMP DEFAULT CURRENT_TIMESTAMP
   );
