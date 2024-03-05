using ISLSharp;
namespace ISLSharp.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var set = new isl.set(isl.ctx.Instance, "{ [i,j,k] }");
        var map = new isl.map(isl.ctx.Instance, "{ [i,j,k] -> [k,j,i] }");
        var nset = set.apply(map);
        System.Console.WriteLine(nset);
    }
}