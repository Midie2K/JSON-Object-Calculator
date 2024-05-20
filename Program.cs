namespace SWI
{
    public class Program
    {
        private static void Main()
        {
            Reader reader = new Reader();
            Dictionary<string, Input> inputs;
            List<Answer> answers = new List<Answer>();

            reader.ReadJSON();

            if (reader.IfJsonReaded())
            {
                inputs = Deserializetion.DeserializeJSON(reader.GetJSON());
                if (inputs.Count > 0)
                {
                    foreach (var input in inputs)
                    {
                        Answer solusion = Calculator.Calculate(input.Key, input.Value);
                        if (solusion.IfResultSet())
                        {
                            answers.Add(solusion);
                        }
                    }
                    answers.Sort((a, b) => a.Result.CompareTo(b.Result));

                    Writer.SaveData(answers);
                }
            }
        }
    }
}
