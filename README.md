# Security Log Analyzer (VB.NET)

**Nama:** Hendika Satria Widiyadana  
**NIM:** 250401010052  
**Mata Kuliah:** Pemrograman Visual  
**Kampus:** Universitas [Nama Universitas Anda]  

---

## 📋 Deskripsi Proyek
**Security Log Analyzer** adalah aplikasi desktop berbasis Windows Forms yang dirancang untuk membantu administrator sistem dalam melakukan audit keamanan sederhana. Aplikasi ini membaca file log server mentah dan secara otomatis mengklasifikasikan aktivitas ke dalam tiga tingkat keparahan (*Severity Levels*):
- 🔴 **CRITICAL:** Aktivitas berbahaya (contoh: "FAILED login", "DENIED access").
- 🟡 **WARNING:** Peringatan sistem (contoh: "High CPU", "Disk Full").
- 🟢 **INFO:** Aktivitas normal sistem.

Proyek ini dibuat untuk memenuhi Tugas Ujian Akhir Semester (UAS).

---

## 🚀 Fitur Utama
Aplikasi ini memiliki fitur-fitur berikut:
1.  **File Reader:** Membaca file teks (`.txt` atau `.log`) dari direktori lokal.
2.  **Automated Analysis:** Menggunakan algoritma *parsing* string untuk mendeteksi kata kunci keamanan.
3.  **Real-time Statistics:** Menampilkan jumlah total baris dan temuan kritis secara langsung.
4.  **Report Export:** Menyimpan hasil analisis ke dalam file laporan `.txt` baru (lengkap dengan timestamp).
5.  **Reset Function:** Membersihkan memori dan tampilan untuk memulai sesi baru.

---

## 🛠️ Pemenuhan Kriteria Tugas
Kode program ini telah memenuhi seluruh syarat teknis yang diminta:

| Kriteria | Implementasi dalam Kode |
| :--- | :--- |
| **Membaca File** | Menggunakan `System.IO.File.ReadAllLines` untuk memuat data log. |
| **Percabangan** | Menggunakan `If...ElseIf...Else` untuk memfilter kata kunci "FAILED", "WARNING", dll. |
| **Perulangan** | Menggunakan `For Each` loop untuk memproses array baris satu per satu. |
| **Procedure** | Logika analisis dipisahkan ke dalam Sub-routine `AnalisisData()` agar modular. |

---

## 💻 Cara Menjalankan
1.  **Clone** repositori ini atau download sebagai ZIP.
2.  Buka file solusi `.sln` menggunakan **Visual Studio 2019/2022**.
3.  Pastikan .NET Framework terinstall.
4.  Tekan tombol **Start** atau **F5** untuk menjalankan.
5.  Gunakan file contoh `server_log.txt` yang disertakan dalam repositori ini untuk pengujian.

---

## 📝 Struktur Log Data
Aplikasi ini mengharapkan input file teks biasa. Contoh format log yang didukung:
```text
2026-02-12 10:00:00 [INFO] System started
2026-02-12 10:05:00 [FAILED] Login attempt from IP 192.168.1.50
2026-02-12 10:10:00 [WARNING] Disk space low
