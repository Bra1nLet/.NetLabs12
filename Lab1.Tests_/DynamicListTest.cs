namespace Lab1.Tests_;
using System.Collections;
using System.Collections.Generic;

public class Tests
{
    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public void Add()
    {
        DynamicList dl = new DynamicList();
        ArrayList data = new ArrayList(){null, null, null, null, 5, 5, 5, 5, 5, 5 };
        dl.place(4, 10, 5);
        Assert.AreEqual(data, dl.array);
    }
    [Test]
    public void Remove()
    {
        DynamicList dl = new DynamicList();
        ArrayList data = new ArrayList(){5, 5, 5, 5, 5, 5 };
        dl.place(0, 10, 5);
        dl.pop(2, 6);
        Assert.AreEqual(data, dl.array);
    }
    [Test]
    public void Except()
    {
        DynamicList dl = new DynamicList();
        try
        {
            dl.place(20, 5, 1);
        }
        catch (IndexOutOfRangeException)
        {
            Assert.Pass("Got an error, pass");
        }
        Assert.Fail();
    }
    [Test]
    public void Get()
    {
        DynamicList dl = new DynamicList();
        dl.place(2, 20, 1);
        dl.place(7, 15, 5);
        dl.place(11, 13, 3);
        ArrayList data = new ArrayList() { 3, 5, 5, 1, 1, 1, 1, 1 };
        Assert.AreEqual(data, dl.get(12, 20));
    }
}