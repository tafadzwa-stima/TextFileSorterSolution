namespace NameSorterDomain.Interfaces
{
    public interface IWriter
    {
        void WriteNamesToTextFile(string filePath, List<string>names);
    }
}
