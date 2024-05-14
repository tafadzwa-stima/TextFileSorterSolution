using NameSorterDomain.Interfaces;

namespace NameSorterDomain.Services
{
    public class TextReader : ITextReader
    {
        public List<string> ReadFromFile(string filePath)
        {
            List<string> names = new List<string>();

            try
            {
               
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    
                    while ((line = reader.ReadLine()) != null)
                    {
                       
                        names.Add(line.Trim());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading from file: {ex.Message}");
                return names;
            }

            return names;
        }
    }
}
