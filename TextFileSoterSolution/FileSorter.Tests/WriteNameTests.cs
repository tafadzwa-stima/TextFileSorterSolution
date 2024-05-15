using NameSorterDomain.Services;

namespace FileSorter.Tests
{
    public class WriteNameTests
    {
        [Fact]
        public void WriteNamesToTextFile_Success()
        {
            // Arrange
            var writer = new WriteName();
            var names = new List<string>
            {
                "Marin Alvarez",
                "Adonis Julius Archer",
                "Beau Tristan Bentley",
                "Hunter Uriah Mathew Clarke",
                "Leo Gardner",
                "Vaugh Lewis",
                "London Lindsey",
                "Mikayla Lopez",
                "Janet Parsons",
                "Frankie Conner Ritter",
                "Shelby Nathan Yoder"
            };


            // Act
            writer.WriteNamesToTextFile(names);

            // Assert
            var filePath = Path.Combine(Environment.CurrentDirectory, "sorted-names-list.txt");
            Assert.True(File.Exists(filePath)); 
            var fileContent = File.ReadAllLines(filePath);
            // Check if number of lines matches number of names
            Assert.Equal(names.Count, fileContent.Length);

            // Clean up
            File.Delete(filePath);
        }

       
    }
}

