using FIRSTPrinciplesProj;

namespace FIRSTPrinciplesTest;

//Never ever write tests which depend on other test cases.
//No matter how carefully you design them, there will always be possibilities of false alarms.

public class IndependentTest
{
    private readonly string _orderByStr = "ID, Name, Tel";

    [Fact]
    public bool IsSeparatedCorrectly()
    {
        var exp = new IndependentExp();

        var res = exp.Seprator(_orderByStr);

        if (res.Any())
        {
            Assert.True(true);
            return true;
        }

        Assert.True(false);
        return false;
    }

    [Fact]
    public void GetItemInOrderByStringCorrectly()
    {
        var isSeparatedCorrectly = IsSeparatedCorrectly();

        if (isSeparatedCorrectly)
        {
            var exp = new IndependentExp();

            var exep = new List<string>
            {
                "ID",
                "Name",
                "Tel"
            };

            var res = exp.Seprator(_orderByStr);

            Assert.Equal(exep, res);
        }
    }
}