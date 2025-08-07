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

    [Fact]
    public void TestSubScope()
    {
        using (var ctx = Isl.ctx.Create())
        {
            var set = new Isl.set(ctx, "[N] -> { [i,j,k]: 0<= i < 12 and 0 <= j < N and 0 <= k < N and 0 <= N < 123 }");
            var aff = set.max_multi_pw_aff();
            var min = aff.min_multi_val();
            var max = aff.max_multi_val();
            System.Console.WriteLine("min: {0}", min);
            System.Console.WriteLine("max: {0}", max);

            using (var ctx2 = Isl.ctx.Create())
            {
                var set2 = new Isl.set(ctx2, "[N] -> { [i,j,k]: 0<= i < 12 and 0 <= j < N and 0 <= k < N and 0 <= N < 123 }");
                var aff2 = set2.max_multi_pw_aff();
                var min2 = aff2.min_multi_val();
                var max2 = aff2.max_multi_val();
                System.Console.WriteLine("min: {0}", min2);
                System.Console.WriteLine("max: {0}", max2);
                using (var ctx3 = Isl.ctx.Create())
                {
                    var set3 = new Isl.set(ctx3, "[N] -> { [i,j,k]: 0<= i < 13 and 0 <= j < N and 0 <= k < N and 0 <= N < 133 }");
                    var aff3 = set3.max_multi_pw_aff();
                    var min3 = aff3.min_multi_val();
                    var max3 = aff3.max_multi_val();
                    System.Console.WriteLine("min: {0}", min2);
                    System.Console.WriteLine("max: {0}", max2);
                }
            }
        }
    }
}
