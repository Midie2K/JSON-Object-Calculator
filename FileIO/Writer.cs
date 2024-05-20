namespace SWI
{
    public class Writer
    {
        private static string filePath = "output.txt";
        public static void SaveData(List<Answer> list)
        {
            try
            {
                StreamWriter sw = new StreamWriter(filePath);
                foreach (var element in list)
                {
                    sw.WriteLine(element);
                }
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Data successfully written to file.");
            }
        }
    }
}
