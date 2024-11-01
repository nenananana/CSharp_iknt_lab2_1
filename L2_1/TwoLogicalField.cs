using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_1
{
    internal class TwoLogicalField
    {
        bool bool1;
        bool bool2;
        public TwoLogicalField(bool bool1, bool bool2)
        {
            this.bool1 = bool1;
            this.bool2 = bool2;
        }
        // конструктор копирования
        public TwoLogicalField(TwoLogicalField copy)
        {
            this.bool1 = copy.bool1;
            this.bool2 = copy.bool2;
        }

        // Дизъюнкция полей
        public bool Disjunction()
        {
            return bool1 || bool2;
        }
        // Перегрузка метода ToString()
        public override string ToString()
        {
            return $"Поле 1: {bool1}, Поле 2: {bool2}";
        }
    }
}

