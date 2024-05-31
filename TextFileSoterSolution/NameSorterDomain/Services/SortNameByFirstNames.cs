using NameSorterDomain.Interfaces;

namespace NameSorterDomain.Services
{
    public class SortNameByFirstNames : INameSorter
    {
        public IEnumerable<string> SortNames(IEnumerable<string> namesList)
        {

            var names = namesList.ToList();
            names.Sort((name1, name2) =>
            {
                string[] parts1 = name1.Split(' ');
                string[] parts2 = name2.Split(' ');

                return string.Compare(parts1[0], parts2[0], StringComparison.Ordinal);
            });

            return names;
        }
    }
}
