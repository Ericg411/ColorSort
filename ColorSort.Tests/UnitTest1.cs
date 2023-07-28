namespace ColorSort.Tests;

[TestClass]
public class UnitTest1
{
    private readonly Class1 _test;
    public UnitTest1()
    {
        _test = new Class1();    
    }
    [TestMethod]
    public void TestMethod1()
    {
        int[] nums = { 2, 0, 2, 1, 1, 0 };
        _test.SortColors(nums);
        int[] result = { 0, 0, 1, 1, 2, 2 };
        Assert.IsTrue(Enumerable.SequenceEqual(result, nums));
    }
    [TestMethod]
    public void TestMethod2()
    {
        int[] nums = { 2, 0, 1 };
        _test.SortColors(nums);
        int[] result = { 0, 1, 2 };
        Assert.IsTrue(Enumerable.SequenceEqual(result, nums));
    }
    [TestMethod]
    public void TestMethod3()
    {
        int[] nums = { 2, 0, 2, 1, 1, 0, 2, 1, 2, 1, 2, 1, 2, 1, 2, 0, 0, 2, 1, 2 };
        _test.SortColors(nums);
        int[] result = { 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2 };
        Assert.IsTrue(Enumerable.SequenceEqual(result, nums));
    }
}