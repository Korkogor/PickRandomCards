using PickRandomCards;

// класс Программа
internal class Program
{//Метод main, который запрашивает у пользователя..
    static void Main(string[] args)
    {
        Console.Write("Enter the number of cards to pick: "); // запросить у пользователя количество карт
        string line = Console.ReadLine(); // запись с консоли в переменную line

        if (int.TryParse(line, out int numberOfCards))
        {
            // этот блок выполняется в тому случае, если строка МОЖЕТ БЫТЬ преобразована в int
            // значение, сохраняемое в новой переменной, называется numberOfCards
            foreach (string card in CardPicker.PickSomeCards(numberOfCards)) // Данный цикл выполняет Console.WriteLine(card) для каждого
                //элемента массива, возвращённого PickSomeCard
            {
                Console.WriteLine(card);
            }

        }
        else
        {
            //этот блок выполняется, если строка НЕ МОЖЕТ БЫТЬ преобразована в int
            Console.WriteLine("Введённое значение не подходит. Пожалуйста, введите число");
        }
    }
}