using NameSorterDomain.Services;

namespace FileSorter.Tests
{

    public class ReadTextFileTests
    {
        [Fact]
        public void ReadFromFile_ExistingFile_ShouldReturnNamesList()
        {
            // Arrange
            var textReader = new ReadTextFile();
            var testFilePath = "test-file.txt";
            var expectedNames = new List<string>{
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

            // Create a test file with sample names
            File.WriteAllLines(testFilePath, expectedNames);

            // Act
            var names = textReader.ReadFromFile(testFilePath);

            // Assert
            Assert.Equal(expectedNames, names);

            // Clean up
            File.Delete(testFilePath);
        }

        [Fact]
        public void ReadFromFile_NonexistentFile_ShouldReturnEmptyList()
        {
            // Arrange
            var textReader = new ReadTextFile();
            var nonexistentFilePath = "nonexistent-file.txt";

            // Act
            var names = textReader.ReadFromFile(nonexistentFilePath);

            // Assert
            Assert.Empty(names);
        }

        [Fact]
        public void ReadFromFile_EmptyFile_ShouldReturnEmptyList()
        {
            // Arrange
            var textReader = new ReadTextFile();
            var emptyFilePath = "empty-file.txt";
            File.WriteAllText(emptyFilePath, ""); 

            // Act
            var names = textReader.ReadFromFile(emptyFilePath);

            // Assert
            Assert.Empty(names);

            // Clean up
            File.Delete(emptyFilePath);
        }
    }
}
