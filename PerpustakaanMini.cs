public class PerpustakaanMini
{
    public static void Main()
    {
        // Data buku: ID, Judul, Pengarang, Stock
        int[] idBuku = { 1, 2, 3, 4, 5 };
        string[] judulBuku = { "C# Basics", "Clean Code", "Design Patterns", "The Pragmatic Programmer", "Code Complete" };
        string[] pengarangBuku = { "Microsoft", "Robert Martin", "Gang of Four", "Hunt & Thomas", "Steve McConnell" };
        int[] stockBuku = { 5, 3, 2, 4, 1 };

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("===== PERPUSTAKAAN MINI =====");
            Console.WriteLine("1. Lihat Daftar Buku");
            Console.WriteLine("2. Pinjam Buku");
            Console.WriteLine("3. Kembalikan Buku");
            Console.WriteLine("0. Keluar");
            Console.Write("Pilih menu: ");

            string? input = Console.ReadLine();

            // Validasi input menu (if/else)
            if (!int.TryParse(input, out int pilihan))
            {
                Console.WriteLine("Input tidak valid. Masukkan nomor menu.");
                continue;
            }

            // Switch untuk menu utama
            switch (pilihan)
            {
                case 1:
                    // Lihat Daftar Buku
                    Console.WriteLine();
                    Console.WriteLine("===== DAFTAR BUKU =====");
                    Console.WriteLine("ID | Judul                       | Pengarang              | Stock");
                    Console.WriteLine("---------------------------------------------------------------------");
                    for (int i = 0; i < idBuku.Length; i++)
                    {
                        string status = stockBuku[i] > 0 ? "Tersedia" : "Habis";
                        Console.WriteLine($"{idBuku[i]}  | {judulBuku[i],-27} | {pengarangBuku[i],-22} | {stockBuku[i]} ({status})");
                    }
                    break;

                case 2:
                    // Pinjam Buku
                    Console.WriteLine();
                    Console.WriteLine("===== DAFTAR BUKU =====");
                    Console.WriteLine("ID | Judul                       | Pengarang              | Stock");
                    Console.WriteLine("---------------------------------------------------------------------");
                    for (int i = 0; i < idBuku.Length; i++)
                    {
                        string status = stockBuku[i] > 0 ? "Tersedia" : "Habis";
                        Console.WriteLine($"{idBuku[i]}  | {judulBuku[i],-27} | {pengarangBuku[i],-22} | {stockBuku[i]} ({status})");
                    }

                    Console.Write("\nMasukkan ID buku yang ingin dipinjam: ");
                    string? pinjamInput = Console.ReadLine();

                    // Validasi input ID
                    if (!int.TryParse(pinjamInput, out int idPinjam) || idPinjam < 1 || idPinjam > idBuku.Length)
                    {
                        Console.WriteLine("ID buku tidak valid.");
                        break;
                    }

                    // Cek stock dengan if/else
                    int indexPinjam = idPinjam - 1;
                    if (stockBuku[indexPinjam] <= 0)
                    {
                        Console.WriteLine($"Maaf, buku '{judulBuku[indexPinjam]}' sedang habis.");
                    }
                    else
                    {
                        // Pinjam buku (operator matematika: kurangi stock)
                        stockBuku[indexPinjam] -= 1;
                        Console.WriteLine($"Berhasil meminjam '{judulBuku[indexPinjam]}'.");
                        Console.WriteLine($"Stock tersisa: {stockBuku[indexPinjam]}");
                    }
                    break;

                case 3:
                    // Kembalikan Buku
                    Console.Write("Masukkan ID buku yang ingin dikembalikan: ");
                    string? kembalikanInput = Console.ReadLine();

                    // Validasi input ID
                    if (!int.TryParse(kembalikanInput, out int idKembali) || idKembali < 1 || idKembali > idBuku.Length)
                    {
                        Console.WriteLine("ID buku tidak valid.");
                        break;
                    }

                    // Kembalikan buku (operator matematika: tambah stock)
                    int indexKembali = idKembali - 1;
                    stockBuku[indexKembali] += 1;
                    Console.WriteLine($"Terima kasih telah mengembalikan '{judulBuku[indexKembali]}'.");
                    Console.WriteLine($"Stock sekarang: {stockBuku[indexKembali]}");
                    break;

                case 0:
                    Console.WriteLine("Terima kasih telah mengunjungi perpustakaan. Sampai jumpa!");
                    return;

                default:
                    Console.WriteLine("Pilihan tidak tersedia.");
                    break;
            }
        }
    }
}
