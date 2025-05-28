using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_1
{
    internal class TwoLogicalField
    {
        bool firstLogicalField;
        bool secondLogicalField;
        public TwoLogicalField(bool firstLogicalField, bool secondLogicalField)
        {
            this.firstLogicalField = firstLogicalField;
            this.secondLogicalField = secondLogicalField;
        }

        public TwoLogicalField(TwoLogicalField copy)
        {
            this.firstLogicalField = copy.firstLogicalField;
            this.secondLogicalField = copy.secondLogicalField;
        }

        public bool Disjunction()
        {
            return firstLogicalField || secondLogicalField;
        }

        public override string ToString()
        {
            return $"Поле 1: {firstLogicalField}, Поле 2: {secondLogicalField}";
        }
    }
}

