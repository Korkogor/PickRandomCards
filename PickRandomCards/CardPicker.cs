using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Создан новый класс
namespace PickRandomCards
{
    internal class CardPicker
    {
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

        private static string RandomValue()
        {
            throw new NotImplementedException();
        }

        private static string RandomSuit()
        {
            throw new NotImplementedException();
        }
    }
}
