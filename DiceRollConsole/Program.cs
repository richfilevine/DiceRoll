using System.Text;
using DiceRoll;

GetSumConsole();
GetSumIfThreeMatchConsole();

void GetSumConsole()
{
    var challenge = new Challenge();
    var valuesList = new List<GetSumData> {
        new GetSumData { Values = new List<int> { 1, 1, 1, 1, 1 }, ExpectedSum = 5},
        new GetSumData { Values = new List<int> { 6, 5, 4, 3, 2 }, ExpectedSum = 20}
    };

    foreach (var valueList in valuesList) {
        var calculatedSum = challenge.GetSum(valueList.Values);
        writeToConsole(valueList, calculatedSum);
    }
}

void GetSumIfThreeMatchConsole() {
    var challenge = new Challenge();
    var valuesList = new List<GetSumData> {
        new GetSumData { Values = new List<int> { 1, 1, 1, 1, 1 }, ExpectedSum = 5},
        new GetSumData { Values = new List<int> { 6, 5, 4, 3, 2 }, ExpectedSum = 0}
    };

    foreach (var valueList in valuesList) {
        var calculatedSum = challenge.GetSumIfThreeMatch(valueList.Values);
        writeToConsole(valueList, calculatedSum);
    }
} 

void writeToConsole(GetSumData data, int calculatedSum) {
    if (calculatedSum == data.ExpectedSum) {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"For array {printList(data.Values)}, Expected Sum: {data.ExpectedSum} Actual Sum: {calculatedSum} -- Success");
    } else {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"For array {printList(data.Values)}, Expected Sum: {data.ExpectedSum} Actual Sum: {calculatedSum} -- Fail");
    }
}

string printList(List<int> values) {
    var result = new StringBuilder("[");
    foreach (var value in values) {
        result.Append($"{value},");
    }
    return result.ToString().Trim(',') + "]";
}

class GetSumData {
    public List<int> Values {get;set;} = new List<int>();
    public int ExpectedSum {get;set;}
}
