class Program
{
    static void Main()
    {
        int d = 1, f = 28, g = 2024;
        if (g % 4 == 0)
            f = 29;
        int month = 0, date = 0, tOtsceta = d - 1;
        int[] array = new int[] { 31, f, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        try
        {
            Console.WriteLine("месяц:");
            month = Convert.ToInt32(Console.ReadLine());
            if (month < 1 || month > 12)
            {
                Console.WriteLine("Ошибка! номер месяца должен находиться в отрезке [1;12]");
                Main();
            }
            Console.WriteLine("число:");
            date = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Ошибка!");
            Main();
        }
        if (date > array[month - 1] || date < 1)
        {
            Console.WriteLine("Ошибка! в этом месяце не может быть столько дней");
            Main();
        }
        for (int i = 0; i < month - 1; i++)
            tOtsceta += array[i];
        tOtsceta += date;
        Console.WriteLine("День недели:");
        switch (tOtsceta % 7)
        {
            case 1:
                Console.WriteLine("ПН");
                break;
            case 2:
                Console.WriteLine("ВТ");
                break;
            case 3:
                Console.WriteLine("СР");
                break;
            case 4:
                Console.WriteLine("ЧТ");
                break;
            case 5:
                Console.WriteLine("ПТ");
                break;
            case 6:
                Console.WriteLine("СБ");
                break;
            case 0:
                Console.WriteLine("ВС");
                break;
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("");
        Console.WriteLine("Повтор?( enter - да; люб. др. клавиша - нет )");
        string povtor = Convert.ToString(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.White;
        if (povtor == "")
            Main();
    }
}