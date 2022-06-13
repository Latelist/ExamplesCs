Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "пидор")
{
    Console.WriteLine("Какой же ты пидорас");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}