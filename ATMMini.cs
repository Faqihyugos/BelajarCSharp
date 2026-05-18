double saldo = 100000; // saldo awal

while (true)
{
    System.Console.WriteLine();
    System.Console.WriteLine("=== Mini ATM ===");
    System.Console.WriteLine("1. Cek saldo");
    System.Console.WriteLine("2. Tarik uang");
    System.Console.WriteLine("3. Setor uang");
    System.Console.WriteLine("0. Keluar");
    System.Console.Write("Pilih menu: ");

    string? input = System.Console.ReadLine();

    // Validasi input menu (if/else)
    if (!int.TryParse(input, out int pilihan))
    {
        System.Console.WriteLine("Input tidak valid. Masukkan nomor menu.");
        continue;
    }

    // Tangani pilihan dengan switch
    switch (pilihan)
    {
        case 1:
            System.Console.WriteLine($"Saldo Anda: {saldo}");
            break;

        case 2:
            System.Console.Write("Masukkan jumlah tarik: ");
            string? tarikInput = System.Console.ReadLine();
            if (!double.TryParse(tarikInput, out double tarik) || tarik <= 0)
            {
                System.Console.WriteLine("Jumlah tarik tidak valid.");
            }
            else if (tarik > saldo)
            {
                System.Console.WriteLine("Saldo tidak cukup.");
            }
            else
            {
                saldo -= tarik; // operator matematika
                System.Console.WriteLine($"Berhasil tarik {tarik}. Saldo sekarang {saldo}.");
            }
            break;

        case 3:
            System.Console.Write("Masukkan jumlah setor: ");
            string? setorInput = System.Console.ReadLine();
            if (!double.TryParse(setorInput, out double setor) || setor <= 0)
            {
                System.Console.WriteLine("Jumlah setor tidak valid.");
            }
            else
            {
                saldo += setor; // operator matematika
                System.Console.WriteLine($"Berhasil setor {setor}. Saldo sekarang {saldo}.");
            }
            break;

        case 0:
            System.Console.WriteLine("Terima kasih. Sampai jumpa.");
            return;

        default:
            System.Console.WriteLine("Pilihan tidak tersedia.");
            break;
    }
}
