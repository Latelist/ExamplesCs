string username = "";

while(true) {
  Console.Write("Введите ваше имя: ");
  username = Console.ReadLine();
  if (username == "") {
    Console.WriteLine("Тебе сука че непонятно? Сказали же по-русски: введи имя! Давай по новой");
    continue;
  }
  break;
};

Console.Write("Привет, ");
Console.WriteLine(username);
