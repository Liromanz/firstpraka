string txt;
do
{
    Console.WriteLine("Какой цвет вы любите?");
    Console.WriteLine("1. Черный");
    Console.WriteLine("2. Белый");
    Console.WriteLine("3. Розовый");
    Console.WriteLine("4. Фиолетовый");
    Console.WriteLine("5. никакой, отстань");
    txt = Console.ReadLine();

} while (txt != "5");