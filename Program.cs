namespace _5Tortiki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            start();
        }

        static void start()
        {
            bool mainNoExit = true;
            List<Positions> show = new List<Positions>();
            while (mainNoExit)
            {
                int pos = 3;
                int AllPrice = 0;
                bool noExit = true;
                Menu m = new Menu();
                while (noExit)
                {
                    if (pos < 3) { pos = 9; }
                    if (pos > 9) { pos = 3; }
                    Console.WriteLine("Вас приветствует Магазин Мега-Тортики!");
                    Console.WriteLine("Для заказа выберите характеристики торта снизу и нажмите \'Завершить покупку\'.");
                    Console.WriteLine("----------------------------------------------------------------------------------");
                    Console.SetCursorPosition(2, 3);
                    Console.WriteLine("1. Выбрать форму торта.");
                    Console.SetCursorPosition(2, 4);
                    Console.WriteLine("2. Выбрать размер торта.");
                    Console.SetCursorPosition(2, 5);
                    Console.WriteLine("3. Выбрать вкус коржей торта.");
                    Console.SetCursorPosition(2, 6);
                    Console.WriteLine("4. Выбрать количество коржей.");
                    Console.SetCursorPosition(2, 7);
                    Console.WriteLine("5. Выбрать глазурь торта.");
                    Console.SetCursorPosition(2, 8);
                    Console.WriteLine("6. Выбрать декор торта.");
                    Console.SetCursorPosition(2, 9);
                    Console.WriteLine("7. Завершить покупку.");
                    Console.SetCursorPosition(0, 10);
                    Console.WriteLine("----------------------------------------------------------------------------------");
                    Console.SetCursorPosition(0, 11);
                    Console.WriteLine("Цена вашего торта: " + AllPrice);
                    Console.SetCursorPosition(0, 12);
                    Console.Write("Итог: ");
                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine("->");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape) { noExit = false; mainNoExit = false; }

                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        pos--;
                    }
                    else if (key.Key == ConsoleKey.DownArrow)
                    {
                        pos++;
                    }
                    if (key.Key == ConsoleKey.Enter)
                    {
                        if (pos == 9)
                        {
                            noExit = false;
                            mainNoExit = false;
                            break;
                        }
                        else
                        {
                            Positions zz;
                            zz = m.Show(pos - 3);
                            show.Add(zz);
                            AllPrice += zz.Price;
                        }

                        string info = "Заказ от: " + Convert.ToString(DateTime.Now) + '\n' + "\tЗаказ: " + str + '\n' + "\tЦена: " + AllPrice + '.';
                        string path = "C:\\Users\\Public\\Documents\\zakaz.txt";
                        if (!File.Exists(path))
                        {
                            File.Create("C:\\Users\\Public\\Documents\\zakaz.txt").Dispose();
                            File.AppendAllText("C:\\Users\\Public\\Documents\\zakaz.txt", info);
                        }
                        else { File.AppendAllText("C:\\Users\\Public\\Documents\\zakaz.txt", '\n' + info); }
                        noExit = false;
                        break;
                    }
                    Console.Clear();
                }
                Console.Clear();
            }
        }
    }
}
