using Knowledge_Check_week_13;

//string input = "aabbbccc";
//Console.WriteLine(QuestionThree.CountDistinctItems(input));

string input = "C:\\Windows\\System32";
Dictionary<char, int> occurrences = QuestionThree.CountDistinctItems(input);

foreach (var item in occurrences)
{
    Console.WriteLine("Item: " + item.Key + ", Occurrence: " + item.Value);
}
