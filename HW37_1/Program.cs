namespace HW37_1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("\'a\' - добавление товара\t\'d\' - удаление товара\t\'x\' - выход из программы");
            var count = 1;
            Shop shop = new Shop();
            shop.AddCustomer(new Customer());
            while (true)
            {
                var key = Console.ReadKey();
                if (key.KeyChar == 'a')
                {
                    Console.CursorLeft = 0;
                    shop.Add(new Item() { ID = count, Name = $"Товар от {DateTime.Now}" });
                    count++;
                }
                else if (key.KeyChar == 'd')
                {
                    Console.CursorLeft = 0;
                    int id;
                    while (true)
                    {
                        Console.Write("Какой товар нужно удалить?(укажите ID):");
                        var isID = int.TryParse(Console.ReadLine(), out id);
                        if (isID)
                        {
                            shop.Remove(id);
                            break;
                        }
                        else Console.WriteLine("ID - целое число");
                    }
                }
                else if (key.KeyChar == 'x')
                    Environment.Exit(0);
            }
        }
    }
}