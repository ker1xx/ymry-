using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace fuuuuck
{
    internal class order
    {
        public int metod(int back)
        {
            string itog = "";
            int sum = 0;
            int pos = 2;
            int peremen = 0;
            int qq = 0;
            ConsoleKeyInfo key = new ConsoleKeyInfo((char)ConsoleKey.A, ConsoleKey.A, false, false, false);
            while (key.Key != ConsoleKey.O)
            {
                cake chiks = new cake("",0);
                cake kvadrat = new cake("Квадрат", 350);
                cake oval = new cake("Овал", 450);
                cake krug = new cake("Круг", 500);
                cake pryam = new cake("Прямоугольник", 250);
                cake klub = new cake("Клубнички)", 450);
                cake malin = new cake("Малинки)", 850);
                cake vish = new cake("Вишенки....", 450);
                cake zemlya = new cake("Земляника", 1350);
                cake karamel = new cake("'Карамелька'", 650);
                cake beze = new cake("'Овцы в облаках))'", 500);
                cake yagodi = new cake("'Ягодное ассорти'", 850);
                cake chocolade = new cake("'Негры в поле'", 550);
                cake shokolad_korzhi = new cake("Шоколадные", 500);
                cake malina_korzhi = new cake("Малиновые", 650);
                cake molochnie_korzhi = new cake("Молочные", 450);
                cake vafelnia_korzhi = new cake("Вафельные", 450);
                cake mini = new cake("Диаметр 15 см", 350);
                cake small = new cake("Диаметр 25 см", 550);
                cake medium = new cake("Диаметр 35 см", 750);
                cake large = new cake("Диаметр 50 см", 1250);
                cake custom = new cake("Цена договорная (в конце заказа укажите свой phone number, наш работник обязательно вам перезвонит и обо всем договоритесь))");
                back = pos;
                Console.Clear();
                List<cake> form = new List<cake> { kvadrat, oval, krug, pryam };
                List<cake> decor = new List<cake> { klub, malin, vish, zemlya };
                List<cake> glaze = new List<cake> { karamel, beze, yagodi, chocolade };
                List<cake> taste = new List<cake> { shokolad_korzhi, malina_korzhi, molochnie_korzhi, vafelnia_korzhi };
                List<cake> size = new List<cake> { mini, small, medium, large };
                Console.WriteLine("Добро пожаловать в кондирскую 'Не жирней'\nЧтобы сделать заказ, выберите один из пунктов в каждой категории:");
                Console.WriteLine("  Форма коржа");
                Console.WriteLine("  Размер коржа");
                Console.WriteLine("  Глазурь");
                Console.WriteLine("  Вкус коржа");
                Console.WriteLine("  Декор торта");
                Console.WriteLine("  Завершить заказ");
                Console.WriteLine("Сумма вашего заказа: " + sum);
                Console.WriteLine("Ваш заказ: " + itog);
                if (key.Key == ConsoleKey.Enter)
                {
                    if (pos == 2)
                        chiks = pushout(form);
                    else if (pos == 3)
                        chiks = pushout(decor);
                    else if (pos == 4)
                        chiks = pushout(glaze);
                    else if (pos == 5)
                        chiks = pushout(taste);
                    if (pos == 6)
                        chiks = pushout(size);
                    else if (pos == 7)
                        create(itog,sum);
                    sum += chiks.price;
                    itog += chiks.name + "; ";
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos++;
                    if (pos == 8)
                        pos = 7;
                }
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos--;
                    if (pos == 1)
                        pos = 2;
                }
                Console.SetCursorPosition(0, pos);
                if (key.Key != ConsoleKey.Enter)
                    Console.WriteLine("->");
                key = Console.ReadKey();
            }
            return back;
        }
        private cake pushout(List<cake> gg)
        {
            Console.Clear();
            cake summ = new cake("", 0);
            ConsoleKeyInfo key = new ConsoleKeyInfo((char)ConsoleKey.A, ConsoleKey.A, false, false, false);
            int pos = 0;
            int i = 0;
            while (key.Key != ConsoleKey.Enter)
            {
                foreach (var zxc in gg)
                {
                    Console.WriteLine("  " + zxc.name + " - " + zxc.price);
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos++;
                    if (pos == 4)
                        pos = 3;
                }
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos--;
                    if (pos == -1)
                        pos = 0;
                }
                Console.SetCursorPosition(0, pos);
                if (key.Key != ConsoleKey.Enter)
                    Console.WriteLine("->");
                key = Console.ReadKey();
                Console.Clear();
            }
            if ((pos == 0) && (key.Key == ConsoleKey.Enter))
            {
                summ = gg[0];
                Console.WriteLine("В ваш заказ был добавлен элемент: " + gg[0].name);
            }
            if ((pos == 1) && (key.Key == ConsoleKey.Enter))
            {
                summ = gg[1];
                Console.WriteLine("В ваш заказ был добавлен элемент: " + gg[1].name);
            }
            if ((pos == 2) && (key.Key == ConsoleKey.Enter))
            {
                summ = gg[2];
                Console.WriteLine("В ваш заказ был добавлен элемент: " + gg[2].name);
            }
            if ((pos == 3) && (key.Key == ConsoleKey.Enter))
            {
                summ = gg[3];
                Console.WriteLine("В ваш заказ был добавлен элемент: " + gg[3].name);
            }
            return summ;
        }
        private void create(string itog, int sum)
        {
            itog += Convert.ToString(sum);
            string way = "C:\\Users\\я\\Desktop\\order.txt";
            if (File.Exists(way))
                File.WriteAllText(way, itog);
            else
            {
                File.Create(way);
                File.AppendAllText(way, itog);
            }
        }
    }

}
