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

        //act
        string bagel = "Ali";
        basket.add(bagel);

        //assert
        Assert.IsTrue(basket.Bagels.Contains(bagel));
    }
    [Test]
    public void removeBagelTest()
    {
        //arrange
        Basket basket = new Basket();

        //act
        string bagel2 = "Haider";
        basket.remove(bagel2);


        //assert

    }
}