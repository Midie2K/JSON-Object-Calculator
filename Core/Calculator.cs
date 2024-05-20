namespace SWI
{
    public class Calculator{
        public Calculator() { }

        public static Answer Calculate(string name, Input input)
        {
            string operation = "";
            Answer answer = new Answer(name);
            if (input.IfOperatorExist()){
                operation = input.Operator.ToLower();
            }
            else {
                Console.WriteLine("{0}: no operator", name);
                return answer;
            }
       
            switch (operation)
            {
                case "add":
                    answer.SetResult(Add(input.Value1, input.Value2));
                    break;
                case "sub":
                    answer.SetResult(Sub(input.Value1, input.Value2));
                    break;
                case "mul":
                    answer.SetResult(Mul(input.Value1, input.Value2));
                    break;
                case "sqrt":
                    if (input.Value1 >= 0)
                    {
                        answer.SetResult(Sqrt(input.Value1));
                    }
                    else
                    {
                        Console.WriteLine("{0}: bad values", name);
                    }
                    break;
                default:
                    Console.WriteLine("{0}: unknown operator", name);
                    break;
            }
            return answer;
        }
        public static float Add(float v1, float v2)
        {
            return v1 + v2;
        }
        public static float Sub(float v1, float v2)
        {
            return v1 - v2;
        }
        public static float Mul(float v1, float v2)
        {
            return v1 * v2;
        }
        public static float Sqrt(float v1)
        {
            return (float) Math.Sqrt(v1);
        }
    }
}


