Console.Write("Nama barang: ");
string namaBarang = Console.ReadLine();

Console.Write("Harga: ");
int harga =Convert.ToInt32(Console.ReadLine());

Console.Write("Jumlah: ");
int jumlah = Convert.ToInt32(Console.ReadLine());

int total = harga * jumlah;

Console.WriteLine();
Console.WriteLine("===== STRUK =====");
Console.WriteLine($"Barang : {namaBarang}");
Console.WriteLine($"Harga : {harga}");
Console.WriteLine($"Jumlah : {jumlah}");
Console.WriteLine($"Total : {total}");
