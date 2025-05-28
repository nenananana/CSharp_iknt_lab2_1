using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_1
{
    class SystemStatus : TwoLogicalField
    {
        string nameSystem;

        public SystemStatus(string nameSystem, bool firstLogicalField, bool secondLogicalField) : base(firstLogicalField, secondLogicalField)
        {
            this.nameSystem = nameSystem;
        }

        public SystemStatus(SystemStatus copy) : base(copy)
        {
            this.nameSystem = copy.nameSystem;
        }

        public string GetSystemStatus()
        {
            return base.Disjunction() ? "Система активна" : "Система не активна";
        }

        public int GetNumberActivField(bool firstLogicalField, bool secondLogicalField)
        {
            int countActivField = 0;

            if (secondLogicalField == true)
            {
                countActivField++;
            }

            if (secondLogicalField == true)
            {
                countActivField++;
            }

            return countActivField;
        }

        public override string ToString()
        {
            Console.WriteLine();
            return $"Имя системы: {nameSystem}";
        }
    }
}
