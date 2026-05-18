Console.Write("Nama barang: ");
string namaBarang = Console.ReadLine() ?? string.Empty;

try
{
	Console.Write("Harga: ");
	int harga = Convert.ToInt32(Console.ReadLine());

	Console.Write("Jumlah beli: ");
	int jumlah = Convert.ToInt32(Console.ReadLine());

	int total = harga * jumlah;

	Console.WriteLine();
	Console.WriteLine("==================== STRUK ====================");
	Console.WriteLine($"Barang      : {namaBarang}");
	Console.WriteLine($"Harga       : {harga}");
	Console.WriteLine($"Jumlah beli : {jumlah}");
	Console.WriteLine("------------------------------------------------");
	Console.WriteLine($"Total harga : {total}");
	Console.WriteLine("================================================");
}
catch
{
	Console.WriteLine("Input harga dan jumlah harus berupa angka.");
}
