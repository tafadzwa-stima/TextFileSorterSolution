using NameSorterDomain.Interfaces;

namespace FileSorterUI
{
    public class App
    {

        private readonly ITextReader _textReader;
        private readonly INameSorter _nameSorter;
        private readonly IWriter _writer;

        public App(ITextReader textReader,INameSorter nameSorter, IWriter writer)
        {
            _textReader = textReader;
            _nameSorter = nameSorter;
            _writer = writer;
                
        }

        public void Run(string[] args)
        {
            //if (args.Length != 1)
            //{
            //    Console.WriteLine("usage: FileSorterUI.exe <inputfilename>");
            //    return;
            //}

            string inputfilePath = @"C:\src\File Sorter\unsortedListOfNames.txt";

            //Read Names From File
            var names = _textReader.ReadFromFile(inputfilePath);

            //Sorting
            var sortedNames= new List<string>();  

            if (names != null) 
            {
                sortedNames =_nameSorter.SortNames(names).ToList();
            }

            Console.WriteLine("sorted");
            //OverWrite sorted names to text file

            _writer.WriteNamesToTextFile(sortedNames);


            Console.WriteLine("Done");

            


        }

    }
}
