using Isl = IntegerSetLibrary;

namespace ISLSharp.Tests;

public class UnitTest
{
    [Fact]
    public void Test()
    {
        var set = new Isl.set(Isl.ctx.Instance, "{ [i,j,k] }");
        var map = new Isl.map(Isl.ctx.Instance, "{ [i,j,k] -> [k,j,i] }");
        var nset = set.apply(map);
        System.Console.WriteLine(nset);
        System.Console.WriteLine(map);
    }
}