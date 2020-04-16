using System;

namespace Day_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = { }; //Массив с которым будет работать пользователь

            string menu =  "\n1. Pop (Удаляет последний элемент)\n" +
                           "2. Push (Добавляет элемент в конец списка)\n" +
                           "3. Shift (Удаляет первый элемент)\n" +
                           "4. UnShift (Добавляет элемент в начало списка)\n" +
                           "5. Slice (Возвращает новый массив, содержащий копию части исходного массива)\n" +
                           "6. Вывод списка\n" +
                           "0. Выход\n";
                           
            Console.WriteLine("Здравстуйте! Вас приветствует редактор массива!");
            Console.Write("Добавьте элементы в массив(через запятую, пример: Faridun,Firuz,Akmal,Rajab или введите '+' чтобы добавить в массив примерные элементы): ");

            string cmd = string.Empty;
            cmd = Console.ReadLine(); 

            if(cmd == "+")
                data = new string[4] { "Faridun", "Firuz", "Akmal", "Rajab" }; //Вводится примерные данные в массив
            else
                data = cmd.Split(','); //Пользователь вводит данные в массив

            Console.WriteLine(menu);
            while (cmd != "0")
            {
                cmd = Console.ReadLine();
                if(cmd == "1") //Pop
                {
                    var deletedElement = ArrayHelper<string>.Pop(ref data);
                    Console.WriteLine($"Удаленный элемент(метод Pop) - {deletedElement}");
                }
                else if(cmd == "2") //Push
                {
                    Console.Write("Введите элемент: ");
                    string el = Console.ReadLine();
                    int newSize = ArrayHelper<string>.Push(ref data, el);
                    Console.WriteLine($"Новый размер(метод Push) - {newSize}");
                }
                else if(cmd == "3") //Shift
                {
                    var deletedElement = ArrayHelper<string>.Shift(ref data);
                    Console.WriteLine($"Удаленный элемент(метод Shift) - {deletedElement}");
                }
                else if(cmd == "4") //UnShift
                {
                    Console.Write("Введите элемент: ");
                    string el = Console.ReadLine();
                    int newSize = ArrayHelper<string>.UnShift(ref data, el);
                    Console.WriteLine($"Новый размер(метод UnShift) - {newSize}");
                }
                else if(cmd == "5") //Slice
                {

                }
                else if(cmd == "6") //Output
                {
                    ArrayHelper<string>.Output(data);
                }
                Console.WriteLine(menu);
            } 
        }
    }
}
