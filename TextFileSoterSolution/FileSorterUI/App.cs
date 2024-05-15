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
            if (args.Length != 1)
            {
                Console.WriteLine("usage: filesorterui.exe <inputfilename>");
                return;
            }

            string inputfilePath = args[0]; 

            //Read Names From File
            var names = _textReader.ReadFromFile(inputfilePath);

            //Sorting
            var sortedNames= new List<string>();  
                     

            if (names != null) 
            {
                sortedNames =_nameSorter.SortNames(names).ToList();
            }

            //Print Sorted List
            foreach ( var name in sortedNames ) 
            {
                Console.WriteLine(name);
            }
                       
            //OverWrite sorted names to text file

            _writer.WriteNamesToTextFile(sortedNames);

            Console.WriteLine("Done with file sorting operation ");

           
        }

    }
}
