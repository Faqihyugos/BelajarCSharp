Console.Write("Nilai: ");

int nilai = Convert.ToInt32(Console.ReadLine());

if(nilai >= 80)
{
    Console.WriteLine("Grade A");
}
else if(nilai >= 70)
{
    Console.WriteLine("Grade B");
}
else if(nilai >= 60)
{
    Console.WriteLine("Grade C");
}
else
{
    Console.WriteLine("Grade D");
}
