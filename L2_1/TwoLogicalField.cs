namespace L2_1
{
    internal class TwoLogicalField
    {
        private bool _firstLogicalField;
        private bool _secondLogicalField;

        public TwoLogicalField(bool firstLogicalField, bool secondLogicalField)
        {
            _firstLogicalField = firstLogicalField;
            _secondLogicalField = secondLogicalField;
        }

        public TwoLogicalField(TwoLogicalField copy)
        {
            this._firstLogicalField = copy._firstLogicalField;
            this._secondLogicalField = copy._secondLogicalField;
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

