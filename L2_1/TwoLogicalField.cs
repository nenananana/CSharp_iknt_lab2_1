namespace L2_1
{
    internal class TwoLogicalField
    {
        private bool _firstLogicalField;
        public bool FirstLogicalField
        {
            get => _firstLogicalField;
            set => _firstLogicalField = value;
        }

        private bool _secondLogicalField;
        public bool SecondLogicalField
        {
            get => _secondLogicalField;
            set => _secondLogicalField = value;
        }

        public TwoLogicalField(bool firstLogicalField, bool secondLogicalField)
        {
            _firstLogicalField = firstLogicalField;
            _secondLogicalField = secondLogicalField;
        }

        public TwoLogicalField(TwoLogicalField copy)
        {
            _firstLogicalField = copy.FirstLogicalField;
            _secondLogicalField = copy.SecondLogicalField;
        }

        public bool Disjunction()
        {
            return _firstLogicalField || _secondLogicalField;
        }

        public override string ToString()
        {
            return $"Поле 1: {_firstLogicalField}, Поле 2: {_secondLogicalField}";
        }
    }
}

