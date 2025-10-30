
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.Programmiste.Sprint2.Task2.V9.Lib
{
    public class DataService : ISprint2Task2V9
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            // Vérifie si le point (x,y) est dans la zone ombrée
            // Zone triangulaire : triangle rectangle de (0,0) à (15,0) à (0,15)
            bool inTriangle = (x >= 0) && (y >= 0) && (x + y <= 15);

            // Zone rectangulaire : rectangle de (5,3) à (10,8)
            bool inRectangle = (x >= 5) && (x <= 10) && (y >= 3) && (y <= 8);

            // Le point est dans la zone ombrée s'il est dans le triangle OU le rectangle
            return inTriangle || inRectangle;
        }
    }
}
