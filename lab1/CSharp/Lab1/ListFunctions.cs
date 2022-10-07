namespace Lab1;

public static class ListFunctions
{
    public static IEnumerable<T> Singleton<T>(T element)
    {
        return new List<T> { element };
    }

    public static bool Null<T>(IEnumerable<T> list)
    {
        using var enumerator = list.GetEnumerator();

        return !enumerator.MoveNext();
    }

    public static IEnumerable<T> Snoc<T>(IEnumerable<T> source, T newItem)
    {
        var newList = new List<T>(source) { newItem };
        return newList;
    }

    public static int Lenght<T>(IEnumerable<T> source)
    {
        using var enumerator = source.GetEnumerator();
        var counter = 0;
        while (enumerator.MoveNext())
        {
            counter++;
        }

        return counter;
    }
}