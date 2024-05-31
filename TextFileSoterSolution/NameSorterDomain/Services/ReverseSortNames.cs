using NameSorterDomain.Interfaces;

namespace NameSorterDomain.Services
{
    public class ReverseSortNames : INameSorter
    {
       

        public IEnumerable<string> SortNames(IEnumerable<string> namesList)
        {
            var names = namesList.ToList();
            names.Sort((name1, name2) =>
            {
                string[] parts1 = name1.Split(' ');
                string[] parts2 = name2.Split(' ');

                return string.Compare(parts2[parts2.Length - 1], parts1[parts1.Length - 1], StringComparison.Ordinal);
            });

            //names.Reverse();
            return names;

        }
    }
}
