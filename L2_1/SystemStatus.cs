using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_1
{
    class SystemStatus : TwoLogicalField
    {
        bool bool1;
        bool bool2;
        string systemName;
        public SystemStatus(string name, bool b1, bool b2) : base(b1, b2)
        {
            this.systemName = name;
        }
        public SystemStatus(SystemStatus copy) : base(copy)
        {
            systemName = copy.systemName;
        }

        // Метод для получения статуса системы
        public string GetSystemStatus()
        {
            return base.Disjunction() ? "Система активна" : "Система не активна";
        }
        public int GetNumber(bool bool1, bool bool2)
        {
            int count = 0;
            if (bool1 == true)
            {
                count++;
            }
            if (bool2 == true)
            {
                count++;
            }
            return count;
        }

        public override string ToString()
        {
            Console.WriteLine();
            return $"Имя системы: {systemName}";
        }
    }
}
