// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Saya Belajar C#");

// Perbedaan Write dan WriteLine
Console.WriteLine("A");
Console.WriteLine("B");

Console.Write("A");
Console.Write("B");
Console.WriteLine(); // untuk membuat baris baru

/*
Ini komentar
lebih dari satu baris
*/
// Variable
string nama = "Faqih";
int umur = 26;
double tinggi = 1.65;
Console.WriteLine("Nama: " + nama);
Console.WriteLine("Umur: " + umur);

// lebih baik menggunakan string interpolation
Console.WriteLine($"Tinggi: {tinggi}");

// untuk menangkap input dari user Console.ReadLine()
Console.Write("Masukkan nama Anda: ");
string namaUser = Console.ReadLine();
Console.WriteLine($"Halo, {namaUser} Selamat belajar C#!");

/*
    ReadLine Selalu Menghasilkan String
    Jika ingin menangkap angka, kita harus mengkonversinya
    menggunakan int.Parse() atau double.Parse()
*/
Console.Write("Masukkan umur Anda: ");
// string umurInput = Console.ReadLine();
// int umurUser = int.Parse(umurInput);
int umurUser = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Umur Anda: {umurUser} tahun");