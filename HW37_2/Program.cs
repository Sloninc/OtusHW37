using System.Collections.Concurrent;
namespace HW37_2
{
    internal class Program
    {
        static ConcurrentDictionary<string, int> _dic = new ConcurrentDictionary<string, int>();
        static void Main()
        {
            MainMenu();
            while (true)
            {
                var key = Console.ReadKey();
                if (key.KeyChar == '1')
                {
                    Console.CursorLeft = 0;
                    Menu_1();
                }
                else if (key.KeyChar == '2')
                {
                    Console.CursorLeft = 0;
                    Menu_2();
                }
                else if (key.KeyChar == '3')
                    Environment.Exit(0);
                else
                {
                    Console.Clear();
                    MainMenu();
                }  
            }
        }
        static void MainMenu()
        {
            Console.WriteLine("1 - добавить книгу\n2 - вывести список непрочитанного\n3 - выйти");
        }
        static void Menu_1()
        {
            while (true)
            {
                Console.Write("Введите название книги: ");
                var book = Console.ReadLine();
                if (book.Length==0)
                    Console.WriteLine("Вы ничего не ввели");
                else
                {
                    bool isAdd = _dic.TryAdd(book, 0);
                    Reading(book);
                    Console.Clear();
                    MainMenu();
                    break;
                }
            }
        }
        static void Menu_2()
        {
            Console.Clear();
            Console.WriteLine("книги, которые вы читаете:");
            foreach(var book in _dic)
                Console.WriteLine($"{book.Key} - {book.Value}%");
            MainMenu();
        }
        static void Reading(string book)
        {
            int percent = 0;
            int prevPercent = 0;
            Task task = new Task(() =>
            {
                while (percent<=100)
                {
                    percent++;  
                    Thread.Sleep(1000);
                    _dic.TryUpdate(book,percent,prevPercent);
                    prevPercent = percent;  
                }
                _dic.TryRemove(book,out percent);
            });
            task.Start();  
        }
    }
}