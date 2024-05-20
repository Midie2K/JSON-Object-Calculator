namespace SWI
{
    public class Reader
    {
        private string path = "input.json";
        private string json = "";

        public Reader() { }
        public void ReadJSON()
        {
            try
            {
                json = File.ReadAllText(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public bool IfJsonReaded()
        {
            return json != "" ? true : false;
        }
        public string GetJSON()
        {
            return json;
        }
    }
}