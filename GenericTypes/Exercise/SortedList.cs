
namespace GenericTypes.Exercise;

public class SortedList<T> where T : IComparable<T>
{
    public IEnumerable<T> Items { get; }

    public SortedList(IEnumerable<T> items)
    {
        var asList = items.ToList();
        asList.Sort();
        Items = asList;
    }
}

public class FullName: IComparable<FullName>
{
    public string FirstName { get; init; }
    public string LastName { get; init; }


    public int CompareTo(FullName other)
    {
        if (other is null) return 1;

        int lastNameCmp = string.Compare(LastName, other.LastName, StringComparison.Ordinal);
        if (lastNameCmp != 0) return lastNameCmp;

        return string.Compare(FirstName, other.FirstName, StringComparison.Ordinal);
    }

    public override string ToString() => $"{FirstName} {LastName}";

}
