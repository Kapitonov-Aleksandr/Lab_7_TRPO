using System;
using System.Collections.Generic;
using System.Text;

namespace Kapitonov
{
    class LinearEquation
    {
        public List<float> linearEquation (float a, float b)
        {
            if (a == 0)
            {
                throw new CawaException("Ошибка: уравнение не существует.");
            }

            return new List<float> { -b / a };
        }
    }
}
