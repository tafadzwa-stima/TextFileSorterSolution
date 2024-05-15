using NameSorterDomain.Services;

namespace FileSorter.Tests
{
    public class NameSorterTests
    {
        [Fact]
        public void SortNames_ShouldSortCorrectly()
        {
            // Arrange
            var nameSorter = new NameSorter();
            var unsortedNames = new List<string> 
            {
            "Janet Parsons",
            "Vaugh Lewis",
            "Adonis Julius Archer",
            "Shelby Nathan Yoder",
            "Marin Alvarez",
            "London Lindsey",
            "Beau Tristan Bentley",
            "Leo Gardner",
            "Hunter Uriah Mathew Clarke",
            "Mikayla Lopez",
            "Frankie Conner Ritter"
            };
            var expectedSortedNames = new List<string> 
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
            var sortedNames = nameSorter.SortNames(unsortedNames);

            // Assert
            Assert.Equal(expectedSortedNames, sortedNames);
        }

        [Fact]
        public void SortNames_EmptyList_ShouldReturnEmptyList()
        {
            // Arrange
            var nameSorter = new NameSorter();
            var unsortedNames = new List<string>();

            // Act
            var sortedNames = nameSorter.SortNames(unsortedNames);

            // Assert
            Assert.Empty(sortedNames);
        }
    }
}

