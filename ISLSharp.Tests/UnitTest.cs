using Isl = IntegerSetLibrary;

namespace ISLSharp.Tests;

public class UnitTest
{
    [Fact]
    public void TestSetMap()
    {
        using var scope = Isl.ctx.Create();
        var set = new Isl.set(Isl.ctx.Current, "{ [i,j,k] }");
        var map = new Isl.map(Isl.ctx.Current, "{ [i,j,k] -> [k,j,i] }");
        var nset = set.apply(map);
        System.Console.WriteLine(nset);
        System.Console.WriteLine(map);
    }
}
