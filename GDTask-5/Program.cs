List<int> input = new List<int>()
    { 4, 3, 3, 4, 5, 6, 1, 4 };
foreach (var el in remove_buble(input))
{
    Console.Write($"{el} ");
}

static List<int> remove_buble(List<int> input)
{
    List<int> output = new List<int>();
    foreach (var element in input)
    {
        if (!output.Contains(element))
        {
            output.Add(element);
        }
    }

    return output;
}