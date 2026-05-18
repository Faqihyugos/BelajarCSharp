Console.Write("Nama : ");
string nama = Console.ReadLine() ?? string.Empty;
Console.Write("Alamat : ");
string alamat = Console.ReadLine() ?? string.Empty;
try
{
    Console.Write("Umur : ");
    int umur = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();
    Console.WriteLine("======Biodata=====");
    Console.WriteLine($"Nama: {nama}");
    Console.WriteLine($"Umur: {umur}");
    Console.WriteLine($"Alamat: {alamat}");
}
catch
{
    Console.WriteLine("Input harus angka");
}