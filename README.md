# SIPKA - Sistem Informasi Pemesanan Tiket Kereta Api

**SIPKA** adalah aplikasi desktop berbasis Windows Forms (C# .NET) yang digunakan untuk mengelola pemesanan tiket kereta, jadwal keberangkatan, data penumpang, dan pembayaran.

## Fitur Utama
- Login dan Register user dengan sistem role (`admin` / `user`)
- Dashboard dinamis sesuai peran pengguna
- Manajemen data:
  - Kereta
  - Stasiun
  - Jadwal
  - Penumpang
  - Pemesanan Tiket
  - Pembayaran
- Pembayaran hanya bisa dilakukan oleh user yang telah melakukan pemesanan
- Cetak struk pembayaran otomatis (print preview atau langsung)

##  Role & Akses
| Role   | Akses Menu                                                 |
|--------|-------------------------------------------------------------|
| Admin  | Data Kereta, Stasiun, Jadwal, Penumpang, Pemesanan         |
| User   | Pemesanan, Pembayaran (pesan tiket & cetak struk pribadi)  |

## Struktur Folder
SIPKA/
├── config/ 
├── model/ 
├── view/ 
├── README.md


## Database
Gunakan file SQL: `sipka.sql` untuk membuat database awal. Pastikan:
- Sudah ada MySQL/MariaDB terinstall
- Aplikasi dikoneksikan dengan benar melalui `ConnectDB_cls.cs`

##  Cara Menjalankan
1. Buka folder proyek ini di **Visual Studio 2019/2022**
2. Pastikan target .NET Framework adalah **v4.8**
3. Build & Run (`Ctrl + F5`)
4. Login dengan akun yang sudah ada di tabel `user` atau register akun baru

##  Cetak Struk
Setelah melakukan pembayaran, user bisa:
- Melihat detail struk secara langsung
- Cetak langsung dengan tombol **[Cetak]**

---

## Developer
Aplikasi ini dikembangkan untuk memenuhi kebutuhan sistem pemesanan kereta dalam tugas atau proyek UAS Prakitkum Pemrograman Berbasis Objek.

