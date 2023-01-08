namespace KaizenCase.HelperModels
{
    public class CodeGenerator
    {
        enum CharacterType
        {
            Char,
            Int
        }
        /// <summary>
        /// Default value equals 1
        /// </summary>
        public int ElementsCount { get; set; }=1;
        private static char[] _code ;
        private const int minValueOfChar = 65;
        private const int maxValueOfChar = 90;
        private const int minValueOfInt = 50;
        private const int maxValueOfInt = 57;
        private static char[] _defaultCode;

        public CodeGenerator(int elementsCount)
        {
            ElementsCount = elementsCount;
        }
        public CodeGenerator()
        {}
        static CodeGenerator()
        {
            _defaultCode = new char[] { 
                (char)minValueOfChar, 
                (char)minValueOfChar, 
                (char)minValueOfChar, 
                (char)minValueOfChar, 
                (char)minValueOfChar, 
                (char)minValueOfChar, 
                (char)minValueOfChar, 
                (char)minValueOfChar 
            };
           _code = _defaultCode;
        }
        public IEnumerable<string> Generate()
        {
            for (int k = 0; k < ElementsCount; k++)
            {
                bool changeNextOne = true;
                for (int i = _code.Length-1; i >= 0; i--)
                {
                    if (changeNextOne)
                    {
                        SetNewValue(i, ref changeNextOne);
                    }

                    if (i==0 && changeNextOne)
                    {
                        _code = _defaultCode;
                    }
                }
                yield return new string(_code);
            }

        }

        private void SetNewValue(int index, ref bool changeNextOne)
        {
            _code[index] = (char)(_code[index] + 1);

            if (_code[index] > maxValueOfInt && _code[index] < minValueOfChar)
            {
                _code[index] = (char)minValueOfChar;
                changeNextOne = true;
            }
            else if(_code[index] > maxValueOfChar)
            {
                _code[index] = (char)minValueOfInt;
                changeNextOne = false;
            }
            else
            {
                changeNextOne = false;
            }
        }

    }
}
