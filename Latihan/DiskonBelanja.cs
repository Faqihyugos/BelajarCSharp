Console.Write("Total belanja: ");
string? input = Console.ReadLine();
if (!double.TryParse(input, out double total))
{
    Console.WriteLine("Input harus berupa angka.");
    return;
}

double diskon = 0;
if (total >= 100000)
{
    diskon = total * 0.10; // 10%
}
else if (total >= 50000)
{
    diskon = total * 0.05; // 5%
}

double bayar = total - diskon;

Console.WriteLine();
Console.WriteLine("===== HITUNG DISKON =====");
Console.WriteLine($"Total belanja : {total}");
Console.WriteLine($"Diskon        : {diskon}");
Console.WriteLine("-------------------------");
Console.WriteLine($"Total bayar   : {bayar}");
