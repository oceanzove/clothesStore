using System.Runtime.CompilerServices;
using clotchstore;

internal class Program : User
{
    static void Main()
    {
        List<User> userslist = new List<User>();
        while (true)
        {
            Console.Write("Регистрация(р): ");
            string answer =  Console.ReadLine();
            switch (answer)
            {
                case "р":
                {
                    string fullName, email, password;
                    Console.Write("Введите полное имя пользователя: ");
                    fullName = Console.ReadLine();
                    Console.Write("Введите адресс электронной почты: ");
                    email = Console.ReadLine();
                    Console.Write("Введите пароль: ");
                    password = Console.ReadLine();
                    User userTmp = new User();
                    userTmp.registration(fullName, email, password);
                    userslist.Add(userTmp);
                    Console.WriteLine("Пользователь успешно добавлен успешно добавлен");
                }
                    break;
                case "а":
                {
                    string email, password;
                    Console.Write("Введите электронную почту: ");
                    email = Console.ReadLine();
                    Console.Write("Введите пароль: ");
                    password = Console.ReadLine();
                    foreach (var VARIABLE in userslist)
                    {
                        if (VARIABLE.auth(email, password))
                        {
                            Console.WriteLine("Авторизация прошла успешно");
                        }
                        else Console.WriteLine("Почта или пароль введены не верно");
                    }
                }
                    break;
            }
        }
    }
    
}