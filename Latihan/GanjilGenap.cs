namespace Latihan
{
	public static class GanjilGenap
	{
		public static void Run()
		{
			System.Console.Write("Masukkan sebuah bilangan bulat: ");
			string? input = System.Console.ReadLine();
			if (!int.TryParse(input, out int angka))
			{
				System.Console.WriteLine("Input harus berupa bilangan bulat.");
				return;
			}

			int sisa = angka % 2;
			if (sisa == 0)
			{
				System.Console.WriteLine($"{angka} → genap");
			}
			else
			{
				System.Console.WriteLine($"{angka} → ganjil");
			}
		}
	}
}