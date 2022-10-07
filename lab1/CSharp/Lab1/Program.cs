using static Lab1.ListFunctions;

var firstList = Singleton(5);

Console.WriteLine("First list contains: ");
foreach (var element in firstList)
{
    Console.WriteLine(element);
}

var isFirstListNull = Null(firstList);
Console.WriteLine($"First list is empty: {isFirstListNull}");

var secondList = Snoc(firstList, 6);

Console.WriteLine("Second list contains: ");
foreach (var element in secondList)
{
    Console.WriteLine(element);
}

var secondListLength = Lenght(secondList);
Console.WriteLine($"Second list length: {secondListLength}");

