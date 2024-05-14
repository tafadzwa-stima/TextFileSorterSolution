using NameSorterDomain.Interfaces;

namespace NameSorterDomain.Services
{
    public class WriteName : IWriter
    {
        public void WriteNamesToTextFile(string filePath, List<string> names)
        {
            try
            {
                //use the stream writer to write to a file
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    
                    foreach (var name in names)
                    {
                        writer.WriteLine(name);
                    }
                }

                Console.WriteLine($"Names have been successfully written to {filePath}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to file: {ex.Message}");
            }
        }
    }
}
