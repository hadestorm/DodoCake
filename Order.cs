using System.Diagnostics;

namespace DodoCake
{
    class Order
    {
        public int index = 1;
        private int[] indexArray = new int[2];
        private string[,] menu = new string[20, 20];
        private string label = "DODO CAKE CLI";
        private int currentMenu = 0;
        Cake orderedCake = new Cake();

        private void DrawUserMenu()
        {

            Console.CursorVisible = false;

            List<string> list = new List<string>();
            int j = 0;

            while (j < 20)
            {
                list.Add(menu[j, currentMenu]);
                j++;
            }

            for (int i = 0; i < list.Count; i++)
            {
                string currentString = menu[i, currentMenu];
                if (string.IsNullOrEmpty(currentString))
                {
                    continue;
                }
                if (index == i)
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.Write($"{currentString}\n");

            }
            Console.ResetColor();

        }

        private int[] UserMenu()
        {

            ConsoleKey consoleKey;
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{label}\n");

                new Thread(DrawUserMenu).Start();

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                consoleKey = keyInfo.Key;

                switch (consoleKey)
                {

                    case ConsoleKey.DownArrow:
                        index++;
                        if (menu[index, currentMenu] is null)
                        {
                            index--;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        index--;
                        if (index < 0)
                        {
                            index++;
                        }
                        else if (menu[index, currentMenu] is null)
                        {
                            index++;
                        }
                        break;

                    case ConsoleKey.Escape:
                        if (currentMenu == 0)
                        {
                            Process.GetCurrentProcess().Kill();
                        }
                        currentMenu = 0;
                        index = 1;
                        break;

                }

                Console.Clear();

            } while (consoleKey != ConsoleKey.Enter);

            indexArray[0] = index;
            indexArray[1] = currentMenu;

            return indexArray;
        }

        public Cake MakeOrder()
        {

            int[] indexLocal = new int[2];

            while (true)
            {
                Menu();
                indexLocal = UserMenu();

                switch (indexLocal[1])
                {
                    case 0:
                        switch (indexLocal[0])
                        {
                            case 1:
                                currentMenu = 1;
                                index = 1;
                                break;

                            case 2:
                                currentMenu = 2;
                                index = 1;
                                break;

                            case 3:
                                currentMenu = 3;
                                index = 1;
                                break;

                            case 4:
                                currentMenu = 4;
                                index = 1;
                                break;
                            case 5:
                                currentMenu = 5;
                                index = 1;
                                break;
                            case 6:
                                currentMenu = 6;
                                index = 1;
                                break;
                            case 7:
                                return orderedCake;
                        }
                        break;

                    case 1:
                        switch (indexLocal[0])
                        {
                            case 1:
                                orderedCake.shapeCost = 500;
                                orderedCake.shape = " Круг - 500,";
                                break;

                            case 2:
                                orderedCake.shapeCost = 500;
                                orderedCake.shape = " Квадрат - 500,";
                                break;

                            case 3:
                                orderedCake.shapeCost = 500;
                                orderedCake.shape = " Прямоугольник - 500,";
                                break;

                            case 4:
                                orderedCake.shapeCost = 1000;
                                orderedCake.shape = " Сердечко - 700,";
                                break;
                        }
                        currentMenu = 0;
                        index = 1;
                        break;
                    case 2:
                        switch (indexLocal[0])
                        {
                            case 1:
                                orderedCake.sizeCost = 1000;
                                orderedCake.size = " Малый(Диаметр 16см, 8 порций) - 1000,";
                                break;

                            case 2:
                                orderedCake.sizeCost = 1200;
                                orderedCake.size = " Обычный(Диаметр 18см, 10 порций) - 1200,";
                                break;

                            case 3:
                                orderedCake.sizeCost = 2000;
                                orderedCake.size = " Большой(Диаметр 28см, 24 порций) - 2000,";
                                break;
                        }
                        currentMenu = 0;
                        index = 2;
                        break;

                    case 3:
                        switch (indexLocal[0])
                        {
                            case 1:
                                orderedCake.tasteCost = 100;
                                orderedCake.taste = " Ваниль - 100,";
                                break;

                            case 2:
                                orderedCake.tasteCost = 100;
                                orderedCake.taste = " Шоколад - 100,";
                                break;

                            case 3:
                                orderedCake.tasteCost = 150;
                                orderedCake.taste = " Карамель - 150,";
                                break;

                            case 4:
                                orderedCake.tasteCost = 200;
                                orderedCake.taste = " Ягоды - 200,";
                                break;
                            case 5:
                                orderedCake.tasteCost = 250;
                                orderedCake.taste = " Кокос - 250,";
                                break;
                        }
                        currentMenu = 0;
                        index = 3;
                        break;
                    case 6:
                        switch (indexLocal[0])
                        {
                            case 1:
                                orderedCake.levelsAmountCost = 200;
                                orderedCake.levels = " 1 корж - 200,";
                                break;

                            case 2:
                                orderedCake.levelsAmountCost = 400;
                                orderedCake.levels = " 2 коржа - 400,";
                                break;

                            case 3:
                                orderedCake.levelsAmountCost = 600;
                                orderedCake.levels = " 3 коржа - 600,";
                                break;

                            case 4:
                                orderedCake.levelsAmountCost = 800;
                                orderedCake.levels = " 4 коржа - 800,";
                                break;
                        }
                        currentMenu = 0;
                        index = 6;
                        break;
                    case 5:
                        switch (indexLocal[0])
                        {
                            case 1:
                                orderedCake.saltGlazeCost = 100;
                                orderedCake.saltGlaze = " Шоколад - 100,";
                                break;

                            case 2:
                                orderedCake.saltGlazeCost = 100;
                                orderedCake.saltGlaze = " Крем - 100,";
                                break;

                            case 3:
                                orderedCake.saltGlazeCost = 150;
                                orderedCake.saltGlaze = " Карамель - 150,";
                                break;

                            case 4:
                                orderedCake.saltGlazeCost = 150;
                                orderedCake.saltGlaze = " Бизе - 150,";
                                break;
                            case 5:
                                orderedCake.saltGlazeCost = 200;
                                orderedCake.saltGlaze = " Ягоды - 200,";
                                break;
                        }
                        currentMenu = 0;
                        index = 5;
                        break;
                    case 4:
                        switch (indexLocal[0])
                        {
                            case 1:
                                orderedCake.saltGlazeCost = 150;
                                orderedCake.saltGlaze = " Шоколадная - 150,";
                                break;

                            case 2:
                                orderedCake.saltGlazeCost = 150;
                                orderedCake.saltGlaze = " Ягодная - 150,";
                                break;

                            case 3:
                                orderedCake.saltGlazeCost = 150;
                                orderedCake.saltGlaze = " Кремовая - 150,";
                                break;
                        }
                        currentMenu = 0;
                        index = 4;
                        break;

                }
            }
        }

        private void Menu()
        {
            orderedCake.totalCost = orderedCake.shapeCost + orderedCake.sizeCost + orderedCake.tasteCost + orderedCake.levelsAmountCost + orderedCake.decorationCost + orderedCake.saltGlazeCost;
            orderedCake.orderOutput = string.Concat(orderedCake.shape, orderedCake.size, orderedCake.taste, orderedCake.decor, orderedCake.saltGlaze, orderedCake.levels);
            
            menu[10, 0] = $"Итог: {orderedCake.totalCost}";
            menu[11, 0] = $"Заказ: {orderedCake.orderOutput}";

            menu[1, 0] = "Форма";
            menu[2, 0] = "Размер";
            menu[3, 0] = "Вкус";
            menu[4, 0] = "Глазурь";
            menu[5, 0] = "Декор";
            menu[6, 0] = "Кол-во коржей\n";
            menu[7, 0] = "Записать заказ\n";

            menu[1, 1] = "Круг - 500";
            menu[2, 1] = "Квадрат - 500";
            menu[3, 1] = "Прямоугольник - 500";
            menu[4, 1] = "Сердечко - 700";

            menu[1, 2] = "Малый(Диаметр 16см, 8 порций) - 1000";
            menu[2, 2] = "Обычный(Диаметр 18см, 10 порций) - 1200";
            menu[3, 2] = "Большой(Диаметр 28см, 24 порций) - 2000";

            menu[1, 3] = "Ваниль - 100";
            menu[2, 3] = "Шоколад - 100";
            menu[3, 3] = "Карамель - 150";
            menu[4, 3] = "Ягоды - 200";
            menu[5, 3] = "Кокос - 250";

            menu[1, 6] = "1 корж - 200";
            menu[2, 6] = "2 коржа - 400";
            menu[3, 6] = "3 коржа - 600";
            menu[4, 6] = "4 коржа - 800";

            menu[1, 5] = "Шоколад - 100";
            menu[2, 5] = "Крем - 100";
            menu[3, 5] = "Бизе - 150";
            menu[4, 5] = "Драже - 150";
            menu[5, 5] = "Ягоды - 200";

            menu[1, 4] = "Шоколадная - 150";
            menu[2, 4] = "Ягодная - 150";
            menu[3, 4] = "Кремовая - 150";
        }
    }
}