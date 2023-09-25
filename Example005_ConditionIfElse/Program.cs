Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "оксана")
{
    Console.WriteLine("Ура, это же ОКСАНААА!!");
}
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}