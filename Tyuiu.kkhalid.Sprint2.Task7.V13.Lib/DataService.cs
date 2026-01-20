using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.Kkhalid.Sprint2.Task7.V13.Lib
{
    public class DataService : ISprint2Task7V13
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            // Проверяем, находится ли точка в заштрихованной области

            // 1. Внутри или на границе круга x^2 + y^2 <= 1
            bool insideCircle = (x * x + y * y) <= 1;

            // 2. Выше или на линии y = 1 (y >= 1)
            bool aboveLineY1 = y >= 1;

            // 3. Выше или на линии y = x - 1 (y >= x - 1)
            bool aboveLineYXMinus1 = y >= (x - 1);

            // Точка в заштрихованной области, если удовлетворяет всем условиям
            return insideCircle && aboveLineY1 && aboveLineYXMinus1;
        }
    }
}