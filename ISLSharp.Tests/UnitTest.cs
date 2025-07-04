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

    [Fact]
    public void TestSetMinAffFreeAuto()
    {
        using (var ctx = Isl.ctx.Create())
        {
            System.Console.WriteLine("TestSetMinAffFreeAuto");
            var set = new Isl.set(ctx, "[N] -> { [i,j,k]: 0<= i < 12 and 0 <= j < N and 0 <= k < N and 0 <= N < 123 }");
            var aff = set.max_multi_pw_aff();
            var min = aff.min_multi_val();
            var max = aff.max_multi_val();
            System.Console.WriteLine("min: {0}", min);
            System.Console.WriteLine("max: {0}", max);
        }
    }

    [Fact(Skip = "no need")]
    public void TestSetMinAffFreeManualy()
    {
        using (var ctx = Isl.ctx.Create())
        {
            var set = new Isl.set(ctx, "[N] -> { [i,j,k]: 0<= i < 12 and 0 <= j < N and 0 <= k < N and 0 <= N < 123 }");
            var aff = set.max_multi_pw_aff();
            var min = aff.min_multi_val();
            var max = aff.max_multi_val();
            System.Console.WriteLine(min);
            System.Console.WriteLine(max);
            max.Dispose();
            min.Dispose();
            aff.Dispose();
            set.Dispose();
        }
    }
}
