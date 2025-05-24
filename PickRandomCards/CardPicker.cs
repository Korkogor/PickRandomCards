using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Создано новое поле имён
namespace PickRandomCards
{
    //Создан новый класс
    internal class CardPicker
    {
        static Random Random = new Random(); // Генератор случайных чисел
        //Создан метод для набора карт
        public static string[] PickSomeCards (int numberOfCards)
        {
            // Создан массив строк pickedCards, который набирается из переменной int numberOfCards
            string[] pickedCards = new string[numberOfCards];
            // Цикл for показывает, что в массив pickedCards будут добавляться карты, до того кол-ва, которое указано переменной numberOfCards
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();            
            }
            return pickedCards;
        }
        //Создан метод для подбора "веса" карт
        private static string RandomValue()
        {
            int value = Random.Next(1, 14); // получить случайное число от 1 до 13
            if (value == 1) return "Ace"; // если это единица - вернуть "Туз"
            if (value == 11) return "Jack"; // если это 11 - вернуть "Валет"
            if (value == 12) return "Queen"; // если это 12 - вернуть "Дама"
            if (value == 13) return "King"; // если это 13 - вернуть "Король"
            return value.ToString();  // этот пункт необходим, чтобы вернуть значение от 2 до 10 в виде строки и отобразить её.
        }
        // Создан метод для подбора рубашки карт
        private static string RandomSuit()
        {
            //получить случайное число от 1 до 4
            int value = Random.Next(1, 5);
            // если это 1, вернуть строку Spades
            if (value == 1) return "Spades";
            // если это 2, вернуть строку Heartsчё
            if (value == 2) return "Hearts";
            //если это 3, вернуть строку Clubs
            if (value == 3) return "Clubs";
            // если выполнение продолжается, вернуть строку Diamonds
            return "Diamonds";
        }
    }
}
