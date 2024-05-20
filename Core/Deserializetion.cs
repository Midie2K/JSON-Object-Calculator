using System.Text.Json;

namespace SWI
{
    public class Deserializetion
    {
        public static Dictionary<string, Input> DeserializeJSON(string json)
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            Dictionary<string, Input> inputs = new Dictionary<string, Input>();
            try
            {
                var jsonObj = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(json, options);
                foreach (var item in jsonObj)
                {
                    try
                    {
                        Input input = JsonSerializer.Deserialize<Input>(item.Value.GetRawText(), options);
                        inputs.Add(item.Key, input);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("{0}: Invalid values", item.Key);
                    }
                }
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Error deserializing JSON: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error: {ex.Message}");
            }

            return inputs;
        }
    }
}



