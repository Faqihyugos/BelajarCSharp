Console.Write("Nama : ");
string nama = Console.ReadLine() ?? string.Empty;
Console.Write("Kota : ");
string kota = Console.ReadLine() ?? string.Empty;
try
{
    Console.Write("Umur : ");
    int umur = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();
    Console.WriteLine("======Biodata=====");
    Console.WriteLine($"Nama: {nama}");
    Console.WriteLine($"Kota: {kota}"); 
    Console.WriteLine($"Umur: {umur}");
}
catch
{
    Console.WriteLine("Input harus angka");
}