namespace SWI
{
    public class Answer
    {
        public Answer() { }
        public Answer(string name)
        {
            Name = name;
        }
        public Answer(string name, float result)
        {
            Name = name;
            Result = result;
        }

        public string Name { set; get; }
        public float Result { get; private set; }
        private bool resultSet = false;

        public void SetResult(float value)
        {
            Result = value;
            resultSet = true;
        }
        public bool IfResultSet()
        {
            return resultSet;
        }
        public override string ToString()
        {
            return Name + ": " + Result;
        }
    }
}

