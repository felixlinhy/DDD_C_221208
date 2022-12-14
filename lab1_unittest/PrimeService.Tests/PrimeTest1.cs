namespace Prime.Service.Tests;
[TestFixture]
public class PrimeTest1 {
    [Test]
    public void test1() {
        PrimeService s1 = new PrimeService();
        bool result = s1.IsPrime(1);
        Assert.IsFalse(result, "1 should not be a prime");
        Console.WriteLine("開始測PrimeService");
    }
    [Test]
    public void test2() {
        PrimeService s1 = new PrimeService();
        bool result = s1.IsPrime(2);
        Assert.IsTrue(result, "2 should be a prime");
    }
}
