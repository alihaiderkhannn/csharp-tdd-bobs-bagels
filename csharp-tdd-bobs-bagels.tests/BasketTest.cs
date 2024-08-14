using NUnit.Framework;
using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests;
public class BasketTests
{
    [Test]
    public void addBagelTest()
    {
        //arrange
        Basket basket = new Basket();

        //execute
        string bagel = "Ali";
        basket.add(bagel);

        //verify
        Assert.IsTrue(basket.Bagels.Contains(bagel));

    }
}