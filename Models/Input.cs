namespace SWI
{
    public class Input
    {
        public Input() { }
        public Input(string @operator, float value1)
        {
            Operator = @operator;
            Value1 = value1;
        }
        public Input(string @operator, float value1, float value2)
        {
            Operator = @operator;
            Value1 = value1;
            Value2 = value2;
        }

        public string Operator { set; get; }
        public float Value1 { set; get; }
        public float Value2 { set; get; }
        public bool IfOperatorExist()
        {
            return !string.IsNullOrEmpty(Operator);
        }
    }
}