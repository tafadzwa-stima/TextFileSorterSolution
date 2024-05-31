# File Sorter Application

This is a console application that reads a list of names from a text file, sorts them alphabetically by last name, and writes the sorted list to another text file.



### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) must be installed on your machine.

### Installation
1. Clone this repository to your local machine.
2. Navigate to the the solution and run a dot net build

### Usage
1. Navigate your way to .net8.0 bin derictory where the FileSorterUI.exe file is located through the terminal
for example "C:\src\TextFileSorter\TextFileSoterSolution\FileSorterUI\bin\Debug\net8.0"

2. Run the application by executing the following command ./FileSorterUI.exe <inputname>
Replace `<inputfilename>` with the path to the unsorted list of names text file.
3. The sorted list of names will be written to a text file named `sorted-names-list.txt` in the same directory as the application.

## Project Structure

### `FileSorterUI` Namespace
- **App.cs**: Main entry point of the application.
- Reads unsorted names from a text file.
- Sorts the names alphabetically by last name.
- Writes the sorted names to another text file.

### `NameSorterDomain` Namespace
- **Interfaces**: Contains interfaces defining contracts for various services.

### `NameSorterDomain.Services` Namespace
- Contains implementation classes for the following services:
- `ReadTextFile`: Reads names from a text file.
- `WriteName`: Writes names to a text file.
- `NameSorter`: Sorts names alphabetically by last name.

### `NameSorter.Tests` Namespace
- Contains units tests for these services:
- `ReadTextFile`
- `WriteName`: 
- `NameSorter`: Sorts names alphabetically by last name.
  

## Contributing
Contributions are welcome! If you find any bugs or have suggestions for improvements, please open an issue or submit a pull request.

## License
This project is licensed under the [MIT License](LICENSE).
