Console.WriteLine("Aplikasi Hitung Umur dalam bulan");
try
{
    Console.Write("Masukkan umur Anda dalam tahun: ");
    int umur = Convert.ToInt32(Console.ReadLine());
    int umurDalamBulan = umur * 12;
    Console.WriteLine($"Umur Anda adalah {umurDalamBulan} bulan.");
}
catch
{
    Console.WriteLine("Input harus berupa angka");
    return;
}