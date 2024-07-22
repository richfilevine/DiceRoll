using DiceRoll;

namespace DiceRollTest;

[TestClass]
public class ChallengeTests
{
    private readonly Challenge _challenge;

    public ChallengeTests() {
        _challenge = new Challenge();
    }

    [TestMethod]
    public void GetSum_ShouldWork()
    {
        var valuesList = new List<GetSumData> {
            new GetSumData { Values = new List<int> { 1, 1, 1, 1, 1 }, Sum = 5},
            new GetSumData { Values = new List<int> { 6, 5, 4, 3, 2 }, Sum = 20}
        };

        foreach (var valueList in valuesList) {
            var calculatedSum = _challenge.GetSum(valueList.Values);
            Assert.AreEqual(valueList.Sum, calculatedSum);
        }
    }

    [TestMethod]
    public void GetSumIfThreeMatch_ShouldWork(int[] arrayList) {
        var valuesList = new List<GetSumData> {
            new GetSumData { Values = new List<int> { 1, 1, 1, 1, 1 }, Sum = 5},
            new GetSumData { Values = new List<int> { 6, 5, 4, 3, 2 }, Sum = 0}
        };

        foreach (var valueList in valuesList) {
            var calculatedSum = _challenge.GetSumIfThreeMatch(valueList.Values);
            Assert.AreEqual(valueList.Sum, calculatedSum);
        }
    } 

    class GetSumData {
        public List<int> Values {get;set;} = new List<int>();
        public int Sum {get;set;}
    }
}

