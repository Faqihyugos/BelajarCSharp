try
{
    Console.Write("Masukkan panjang sisi persegi: ");
    int sisi = Convert.ToInt32(Console.ReadLine());
    int luas = sisi * sisi;
    Console.WriteLine($"Luas persegi dengan sisi {sisi} adalah {luas}.");
}
catch
{
    Console.WriteLine("Input harus berupa angka");
    return;
}
