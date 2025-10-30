
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.Programmiste.Sprint2.Task5.V4.Lib
{
    public class DataService : ISprint2Task5V4
    {
        public string FindCardSuit(int value)
        {
            string cardSuit;

            switch (value)
            {
                case 1:
                    cardSuit = "spades";      // piques
                    break;
                case 2:
                    cardSuit = "clubs";       // trèfles
                    break;
                case 3:
                    cardSuit = "diamonds";    // carreaux
                    break;
                case 4:
                    cardSuit = "hearts";      // cœurs
                    break;
                default:
                    cardSuit = "unknown suit";
                    break;
            }

            return cardSuit;
        }
    }
}