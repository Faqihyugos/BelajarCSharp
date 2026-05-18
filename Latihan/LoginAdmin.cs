Console.Write("Username: ");
string username = Console.ReadLine() ?? string.Empty;

Console.Write("Password: ");
string password = Console.ReadLine() ?? string.Empty;

if(username == "admin" && password == "123")
{
    Console.WriteLine("Login berhasil");
}
else
{
    Console.WriteLine("Username/password salah");
}
