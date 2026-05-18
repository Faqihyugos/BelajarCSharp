// See https://aka.ms/new-console-template for more information
/*
    Sesi 1 : 
    - Latihan Luas Persegi
    - Latihan Biodata
    - Latihan Kasir Mini
    - latihan Hitung umur
*/
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
// string nama = "Faqih";
// int umur = 26;
// double tinggi = 1.65;
// Console.WriteLine("Nama: " + nama);
// Console.WriteLine("Umur: " + umur);

// // lebih baik menggunakan string interpolation
// Console.WriteLine($"Tinggi: {tinggi}");

// // untuk menangkap input dari user Console.ReadLine()
// Console.Write("Masukkan nama Anda: ");
// string namaUser = Console.ReadLine();
// Console.WriteLine($"Halo, {namaUser} Selamat belajar C#!");

// /*
//     ReadLine Selalu Menghasilkan String
//     Jika ingin menangkap angka, kita harus mengkonversinya
//     menggunakan int.Parse() atau double.Parse()
// */
// Console.Write("Masukkan umur Anda: ");
// // string umurInput = Console.ReadLine();
// // int umurUser = int.Parse(umurInput);
// int umurUser = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Umur Anda: {umurUser} tahun");

/*
    Sesi 2 : 
    - Latihan Cek ganjil genap
    - Latihan Login Admin
    - Latihan Grade Nilai
    - latihan Diskon Belanja
*/
Console.WriteLine();
Console.WriteLine("====================");
Console.WriteLine("Operator Aritmatika");
Console.WriteLine("====================");
// operator aritmatika: +, -, *, /, %
int a = 10;
int b = 3;
Console.WriteLine($"a = {a}, b = {b}");
Console.WriteLine($"a + b = {a + b}");
Console.WriteLine($"a - b = {a - b}");
Console.WriteLine($"a * b = {a * b}");
Console.WriteLine($"a / b = {a / b}"); // hasilnya 3
Console.WriteLine($"a % b = {a % b}"); // hasilnya 1
Console.WriteLine();
Console.WriteLine("====================");
Console.WriteLine("Operator Perbandingan");
Console.WriteLine("====================");
// operator perbandingan: ==, !=, >, <, >=, <=
Console.WriteLine($"a == b: {a == b}"); // false
Console.WriteLine($"a != b: {a != b}"); // true
Console.WriteLine($"a > b: {a > b}"); // true
Console.WriteLine($"a < b: {a < b}"); // false
Console.WriteLine($"a >= b: {a >= b}"); // true
Console.WriteLine($"a <= b: {a <= b}"); // false    
Console.WriteLine();
Console.WriteLine("====================");
Console.WriteLine("Operator Logika");
Console.WriteLine("====================");
// operator logika: &&, ||, !
bool x = true;
bool y = false;
Console.WriteLine($"x = {x}, y = {y}");
Console.WriteLine($"x != y: {x != y}"); // true
Console.WriteLine($"x && y = {x && y}"); // false
Console.WriteLine($"x || y = {x || y}"); // true
Console.WriteLine($"!x = {!x}"); // false
Console.WriteLine($"!y = {!y}"); // true
Console.WriteLine();
Console.WriteLine("====================");
Console.WriteLine("Percabangan (if-else)");
Console.WriteLine("====================");
int umur = 20;
if(umur >= 17)
{
    Console.WriteLine(
        "Boleh membuat SIM"
    );
}
else
{
    Console.WriteLine(
        "Belum boleh membuat SIM"
    );
}

Console.WriteLine();
Console.WriteLine("====================");
Console.WriteLine("Contoh login ");
Console.WriteLine("====================");
Console.Write("Username: ");
string username = Console.ReadLine() ?? string.Empty;
if(username == "admin")
{
    Console.WriteLine(
        "Login berhasil"
    );
}
else
{
    Console.WriteLine(
        "Login gagal"
    );
}

Console.WriteLine();
Console.WriteLine("====================");
Console.WriteLine("Contoh grade nilai");
Console.WriteLine("====================");
Console.Write("Nilai: ");

int nilai = Convert.ToInt32(Console.ReadLine());

if(nilai >= 80)
{
    Console.WriteLine("Grade A");
}
else if(nilai >= 70)
{
    Console.WriteLine("Grade B");
}
else if(nilai >= 60)
{
    Console.WriteLine("Grade C");
}
else
{
    Console.WriteLine("Grade D");
}