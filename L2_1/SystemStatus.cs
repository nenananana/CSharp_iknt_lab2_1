namespace L2_1
{
    class SystemStatus : TwoLogicalField
    {
        private string _nameSystem;

        public SystemStatus(string nameSystem, bool firstLogicalField, bool secondLogicalField) : base(firstLogicalField, secondLogicalField)
        {
            _nameSystem = nameSystem;
        }

        public SystemStatus(SystemStatus copy) : base(copy)
        {
            _nameSystem = copy._nameSystem;
        }

        public string GetSystemStatus()
        {
            return Disjunction() ? "Система активна" : "Система не активна";
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
            return $"Имя системы: {_nameSystem}";
        }
    }
}
