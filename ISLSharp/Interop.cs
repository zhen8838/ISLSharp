using System.Runtime.InteropServices;
namespace ISLSharp;

public class union_pw_multi_aff
{
    private Context ctx;
    private IntPtr ptr;
    public union_pw_multi_aff(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public union_pw_multi_aff(multi_aff arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_union_pw_multi_aff_from_multi_aff(Interop.isl_multi_aff_copy(args[0].ptr))
    }
    public union_pw_multi_aff(pw_multi_aff arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_union_pw_multi_aff_from_pw_multi_aff(Interop.isl_pw_multi_aff_copy(args[0].ptr))
    }
    public union_pw_multi_aff(union_pw_aff arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_union_pw_multi_aff_from_union_pw_aff(Interop.isl_union_pw_aff_copy(args[0].ptr))
    }
    public union_pw_multi_aff(string arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_union_pw_multi_aff_read_from_str(this.ctx, args[0].encode('ascii'))
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_union_pw_multi_aff_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_union_pw_multi_aff_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer add(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_pw_multi_aff_add(Interop.isl_union_pw_multi_aff_copy(arg0.ptr), Interop.isl_union_pw_multi_aff_copy(arg1.ptr));
        var obj = new union_pw_multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer apply(union_pw_multi_aff arg_1)
    {
        var res = Interop.isl_union_pw_multi_aff_apply_union_pw_multi_aff(Interop.isl_union_pw_multi_aff_copy(args[0].ptr), Interop.isl_union_pw_multi_aff_copy(args[1].ptr));
        var obj = new union_pw_multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer as_multi_union_pw_aff(Pointer arg0)
    {
        var res = Interop.isl_union_pw_multi_aff_as_multi_union_pw_aff(Interop.isl_union_pw_multi_aff_copy(arg0.ptr));
        var obj = new multi_union_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer as_pw_multi_aff(Pointer arg0)
    {
        var res = Interop.isl_union_pw_multi_aff_as_pw_multi_aff(Interop.isl_union_pw_multi_aff_copy(arg0.ptr));
        var obj = new pw_multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer as_union_map(Pointer arg0)
    {
        var res = Interop.isl_union_pw_multi_aff_as_union_map(Interop.isl_union_pw_multi_aff_copy(arg0.ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer coalesce(Pointer arg0)
    {
        var res = Interop.isl_union_pw_multi_aff_coalesce(Interop.isl_union_pw_multi_aff_copy(arg0.ptr));
        var obj = new union_pw_multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer domain(Pointer arg0)
    {
        var res = Interop.isl_union_pw_multi_aff_domain(Interop.isl_union_pw_multi_aff_copy(arg0.ptr));
        var obj = new union_set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer drop_unused_params(Pointer arg0)
    {
        var res = Interop.isl_union_pw_multi_aff_drop_unused_params(Interop.isl_union_pw_multi_aff_copy(arg0.ptr));
        var obj = new union_pw_multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public static Pointer empty()
    {
        var ctx = Context.DefaultInstance;
        var res = Interop.isl_union_pw_multi_aff_empty_ctx(ctx);
        var obj = new union_pw_multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer extract_pw_multi_aff(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_pw_multi_aff_extract_pw_multi_aff(arg0.ptr, Interop.isl_space_copy(arg1.ptr));
        var obj = new pw_multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer flat_range_product(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_pw_multi_aff_flat_range_product(Interop.isl_union_pw_multi_aff_copy(arg0.ptr), Interop.isl_union_pw_multi_aff_copy(arg1.ptr));
        var obj = new union_pw_multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer gist(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_pw_multi_aff_gist(Interop.isl_union_pw_multi_aff_copy(arg0.ptr), Interop.isl_union_set_copy(arg1.ptr));
        var obj = new union_pw_multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer intersect_domain(space arg_1)
    {
        var res = Interop.isl_union_pw_multi_aff_intersect_domain_space(Interop.isl_union_pw_multi_aff_copy(args[0].ptr), Interop.isl_space_copy(args[1].ptr));
        var obj = new union_pw_multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer intersect_domain(union_set arg_1)
    {
        var res = Interop.isl_union_pw_multi_aff_intersect_domain_union_set(Interop.isl_union_pw_multi_aff_copy(args[0].ptr), Interop.isl_union_set_copy(args[1].ptr));
        var obj = new union_pw_multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer intersect_domain_wrapped_domain(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_pw_multi_aff_intersect_domain_wrapped_domain(Interop.isl_union_pw_multi_aff_copy(arg0.ptr), Interop.isl_union_set_copy(arg1.ptr));
        var obj = new union_pw_multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer intersect_domain_wrapped_range(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_pw_multi_aff_intersect_domain_wrapped_range(Interop.isl_union_pw_multi_aff_copy(arg0.ptr), Interop.isl_union_set_copy(arg1.ptr));
        var obj = new union_pw_multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer intersect_params(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_pw_multi_aff_intersect_params(Interop.isl_union_pw_multi_aff_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
        var obj = new union_pw_multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef involves_locals(Pointer arg0)
    {
        var res = Interop.isl_union_pw_multi_aff_involves_locals(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef isa_pw_multi_aff(Pointer arg0)
    {
        var res = Interop.isl_union_pw_multi_aff_isa_pw_multi_aff(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef plain_is_empty(Pointer arg0)
    {
        var res = Interop.isl_union_pw_multi_aff_plain_is_empty(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef plain_is_equal(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_pw_multi_aff_plain_is_equal(arg0.ptr, arg1.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer preimage_domain_wrapped_domain(union_pw_multi_aff arg_1)
    {
        var res = Interop.isl_union_pw_multi_aff_preimage_domain_wrapped_domain_union_pw_multi_aff(Interop.isl_union_pw_multi_aff_copy(args[0].ptr), Interop.isl_union_pw_multi_aff_copy(args[1].ptr));
        var obj = new union_pw_multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer pullback(union_pw_multi_aff arg_1)
    {
        var res = Interop.isl_union_pw_multi_aff_pullback_union_pw_multi_aff(Interop.isl_union_pw_multi_aff_copy(args[0].ptr), Interop.isl_union_pw_multi_aff_copy(args[1].ptr));
        var obj = new union_pw_multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer pw_multi_aff_list(Pointer arg0)
    {
        var res = Interop.isl_union_pw_multi_aff_get_pw_multi_aff_list(arg0.ptr);
        var obj = new pw_multi_aff_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer range_factor_domain(Pointer arg0)
    {
        var res = Interop.isl_union_pw_multi_aff_range_factor_domain(Interop.isl_union_pw_multi_aff_copy(arg0.ptr));
        var obj = new union_pw_multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer range_factor_range(Pointer arg0)
    {
        var res = Interop.isl_union_pw_multi_aff_range_factor_range(Interop.isl_union_pw_multi_aff_copy(arg0.ptr));
        var obj = new union_pw_multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer range_product(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_pw_multi_aff_range_product(Interop.isl_union_pw_multi_aff_copy(arg0.ptr), Interop.isl_union_pw_multi_aff_copy(arg1.ptr));
        var obj = new union_pw_multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer space(Pointer arg0)
    {
        var res = Interop.isl_union_pw_multi_aff_get_space(arg0.ptr);
        var obj = new space(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer sub(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_pw_multi_aff_sub(Interop.isl_union_pw_multi_aff_copy(arg0.ptr), Interop.isl_union_pw_multi_aff_copy(arg1.ptr));
        var obj = new union_pw_multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer subtract_domain(space arg_1)
    {
        var res = Interop.isl_union_pw_multi_aff_subtract_domain_space(Interop.isl_union_pw_multi_aff_copy(args[0].ptr), Interop.isl_space_copy(args[1].ptr));
        var obj = new union_pw_multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer subtract_domain(union_set arg_1)
    {
        var res = Interop.isl_union_pw_multi_aff_subtract_domain_union_set(Interop.isl_union_pw_multi_aff_copy(args[0].ptr), Interop.isl_union_set_copy(args[1].ptr));
        var obj = new union_pw_multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer union_add(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_pw_multi_aff_union_add(Interop.isl_union_pw_multi_aff_copy(arg0.ptr), Interop.isl_union_pw_multi_aff_copy(arg1.ptr));
        var obj = new union_pw_multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_union_pw_multi_aff_from_multi_aff(IntPtr arg0);
    public static extern IntPtr isl_union_pw_multi_aff_from_pw_multi_aff(IntPtr arg0);
    public static extern IntPtr isl_union_pw_multi_aff_from_union_pw_aff(IntPtr arg0);
    public static extern IntPtr isl_union_pw_multi_aff_read_from_str(Context arg0, IntPtr arg1);
    public static extern IntPtr isl_union_pw_multi_aff_add(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_pw_multi_aff_apply_union_pw_multi_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_pw_multi_aff_as_multi_union_pw_aff(IntPtr arg0);
    public static extern IntPtr isl_union_pw_multi_aff_as_pw_multi_aff(IntPtr arg0);
    public static extern IntPtr isl_union_pw_multi_aff_as_union_map(IntPtr arg0);
    public static extern IntPtr isl_union_pw_multi_aff_coalesce(IntPtr arg0);
    public static extern IntPtr isl_union_pw_multi_aff_domain(IntPtr arg0);
    public static extern IntPtr isl_union_pw_multi_aff_drop_unused_params(IntPtr arg0);
    public static extern IntPtr isl_union_pw_multi_aff_empty_ctx(Context arg0);
    public static extern IntPtr isl_union_pw_multi_aff_extract_pw_multi_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_pw_multi_aff_flat_range_product(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_pw_multi_aff_gist(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_pw_multi_aff_intersect_domain_space(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_pw_multi_aff_intersect_domain_union_set(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_pw_multi_aff_intersect_domain_wrapped_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_pw_multi_aff_intersect_domain_wrapped_range(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_pw_multi_aff_intersect_params(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_pw_multi_aff_involves_locals(IntPtr arg0);
    public static extern IntPtr isl_union_pw_multi_aff_isa_pw_multi_aff(IntPtr arg0);
    public static extern IntPtr isl_union_pw_multi_aff_plain_is_empty(IntPtr arg0);
    public static extern IntPtr isl_union_pw_multi_aff_plain_is_equal(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_pw_multi_aff_preimage_domain_wrapped_domain_union_pw_multi_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_pw_multi_aff_pullback_union_pw_multi_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_pw_multi_aff_get_pw_multi_aff_list(IntPtr arg0);
    public static extern IntPtr isl_union_pw_multi_aff_range_factor_domain(IntPtr arg0);
    public static extern IntPtr isl_union_pw_multi_aff_range_factor_range(IntPtr arg0);
    public static extern IntPtr isl_union_pw_multi_aff_range_product(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_pw_multi_aff_get_space(IntPtr arg0);
    public static extern IntPtr isl_union_pw_multi_aff_sub(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_pw_multi_aff_subtract_domain_space(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_pw_multi_aff_subtract_domain_union_set(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_pw_multi_aff_union_add(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_pw_multi_aff_copy(IntPtr arg0);
    public static extern IntPtr isl_union_pw_multi_aff_free(IntPtr arg0);
    public static extern IntPtr isl_union_pw_multi_aff_to_str(IntPtr arg0);
}

public class multi_union_pw_aff
{
    private Context ctx;
    private IntPtr ptr;
    public multi_union_pw_aff(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public multi_union_pw_aff(multi_pw_aff arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_multi_union_pw_aff_from_multi_pw_aff(Interop.isl_multi_pw_aff_copy(args[0].ptr))
    }
    public multi_union_pw_aff(union_pw_aff arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_multi_union_pw_aff_from_union_pw_aff(Interop.isl_union_pw_aff_copy(args[0].ptr))
    }
    public multi_union_pw_aff(space arg_0union_pw_aff_list arg_1)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_multi_union_pw_aff_from_union_pw_aff_list(Interop.isl_space_copy(args[0].ptr), Interop.isl_union_pw_aff_list_copy(args[1].ptr))
    }
    public multi_union_pw_aff(string arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_multi_union_pw_aff_read_from_str(this.ctx, args[0].encode('ascii'))
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_multi_union_pw_aff_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_multi_union_pw_aff_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer add(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_union_pw_aff_add(Interop.isl_multi_union_pw_aff_copy(arg0.ptr), Interop.isl_multi_union_pw_aff_copy(arg1.ptr));
        var obj = new multi_union_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer at(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_union_pw_aff_get_at(arg0.ptr, arg1);
        var obj = new union_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer bind(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_union_pw_aff_bind(Interop.isl_multi_union_pw_aff_copy(arg0.ptr), Interop.isl_multi_id_copy(arg1.ptr));
        var obj = new union_set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer coalesce(Pointer arg0)
    {
        var res = Interop.isl_multi_union_pw_aff_coalesce(Interop.isl_multi_union_pw_aff_copy(arg0.ptr));
        var obj = new multi_union_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer domain(Pointer arg0)
    {
        var res = Interop.isl_multi_union_pw_aff_domain(Interop.isl_multi_union_pw_aff_copy(arg0.ptr));
        var obj = new union_set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer flat_range_product(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_union_pw_aff_flat_range_product(Interop.isl_multi_union_pw_aff_copy(arg0.ptr), Interop.isl_multi_union_pw_aff_copy(arg1.ptr));
        var obj = new multi_union_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer gist(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_union_pw_aff_gist(Interop.isl_multi_union_pw_aff_copy(arg0.ptr), Interop.isl_union_set_copy(arg1.ptr));
        var obj = new multi_union_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer gist_params(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_union_pw_aff_gist_params(Interop.isl_multi_union_pw_aff_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
        var obj = new multi_union_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef has_range_tuple_id(Pointer arg0)
    {
        var res = Interop.isl_multi_union_pw_aff_has_range_tuple_id(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer intersect_domain(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_union_pw_aff_intersect_domain(Interop.isl_multi_union_pw_aff_copy(arg0.ptr), Interop.isl_union_set_copy(arg1.ptr));
        var obj = new multi_union_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer intersect_params(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_union_pw_aff_intersect_params(Interop.isl_multi_union_pw_aff_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
        var obj = new multi_union_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef involves_nan(Pointer arg0)
    {
        var res = Interop.isl_multi_union_pw_aff_involves_nan(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer list(Pointer arg0)
    {
        var res = Interop.isl_multi_union_pw_aff_get_list(arg0.ptr);
        var obj = new union_pw_aff_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer neg(Pointer arg0)
    {
        var res = Interop.isl_multi_union_pw_aff_neg(Interop.isl_multi_union_pw_aff_copy(arg0.ptr));
        var obj = new multi_union_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef plain_is_equal(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_union_pw_aff_plain_is_equal(arg0.ptr, arg1.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer pullback(union_pw_multi_aff arg_1)
    {
        var res = Interop.isl_multi_union_pw_aff_pullback_union_pw_multi_aff(Interop.isl_multi_union_pw_aff_copy(args[0].ptr), Interop.isl_union_pw_multi_aff_copy(args[1].ptr));
        var obj = new multi_union_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer range_product(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_union_pw_aff_range_product(Interop.isl_multi_union_pw_aff_copy(arg0.ptr), Interop.isl_multi_union_pw_aff_copy(arg1.ptr));
        var obj = new multi_union_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer range_tuple_id(Pointer arg0)
    {
        var res = Interop.isl_multi_union_pw_aff_get_range_tuple_id(arg0.ptr);
        var obj = new id(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer reset_range_tuple_id(Pointer arg0)
    {
        var res = Interop.isl_multi_union_pw_aff_reset_range_tuple_id(Interop.isl_multi_union_pw_aff_copy(arg0.ptr));
        var obj = new multi_union_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer scale(multi_val arg_1)
    {
        var res = Interop.isl_multi_union_pw_aff_scale_multi_val(Interop.isl_multi_union_pw_aff_copy(args[0].ptr), Interop.isl_multi_val_copy(args[1].ptr));
        var obj = new multi_union_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer scale(val arg_1)
    {
        var res = Interop.isl_multi_union_pw_aff_scale_val(Interop.isl_multi_union_pw_aff_copy(args[0].ptr), Interop.isl_val_copy(args[1].ptr));
        var obj = new multi_union_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer scale_down(multi_val arg_1)
    {
        var res = Interop.isl_multi_union_pw_aff_scale_down_multi_val(Interop.isl_multi_union_pw_aff_copy(args[0].ptr), Interop.isl_multi_val_copy(args[1].ptr));
        var obj = new multi_union_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer scale_down(val arg_1)
    {
        var res = Interop.isl_multi_union_pw_aff_scale_down_val(Interop.isl_multi_union_pw_aff_copy(args[0].ptr), Interop.isl_val_copy(args[1].ptr));
        var obj = new multi_union_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer set_at(Pointer arg0, Pointer arg1, Pointer arg2)
    {
        var res = Interop.isl_multi_union_pw_aff_set_at(Interop.isl_multi_union_pw_aff_copy(arg0.ptr), arg1, Interop.isl_union_pw_aff_copy(arg2.ptr));
        var obj = new multi_union_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer set_range_tuple(id arg_1)
    {
        var res = Interop.isl_multi_union_pw_aff_set_range_tuple_id(Interop.isl_multi_union_pw_aff_copy(args[0].ptr), Interop.isl_id_copy(args[1].ptr));
        var obj = new multi_union_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef size(Pointer arg0)
    {
        var res = Interop.isl_multi_union_pw_aff_size(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer space(Pointer arg0)
    {
        var res = Interop.isl_multi_union_pw_aff_get_space(arg0.ptr);
        var obj = new space(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer sub(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_union_pw_aff_sub(Interop.isl_multi_union_pw_aff_copy(arg0.ptr), Interop.isl_multi_union_pw_aff_copy(arg1.ptr));
        var obj = new multi_union_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer union_add(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_union_pw_aff_union_add(Interop.isl_multi_union_pw_aff_copy(arg0.ptr), Interop.isl_multi_union_pw_aff_copy(arg1.ptr));
        var obj = new multi_union_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public static Pointer zero(Pointer arg0)
    {
        var res = Interop.isl_multi_union_pw_aff_zero(Interop.isl_space_copy(arg0.ptr));
        var obj = new multi_union_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_multi_union_pw_aff_from_multi_pw_aff(IntPtr arg0);
    public static extern IntPtr isl_multi_union_pw_aff_from_union_pw_aff(IntPtr arg0);
    public static extern IntPtr isl_multi_union_pw_aff_from_union_pw_aff_list(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_union_pw_aff_read_from_str(Context arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_union_pw_aff_add(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_union_pw_aff_get_at(IntPtr arg0, int arg1);
    public static extern IntPtr isl_multi_union_pw_aff_bind(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_union_pw_aff_coalesce(IntPtr arg0);
    public static extern IntPtr isl_multi_union_pw_aff_domain(IntPtr arg0);
    public static extern IntPtr isl_multi_union_pw_aff_flat_range_product(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_union_pw_aff_gist(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_union_pw_aff_gist_params(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_union_pw_aff_has_range_tuple_id(IntPtr arg0);
    public static extern IntPtr isl_multi_union_pw_aff_intersect_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_union_pw_aff_intersect_params(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_union_pw_aff_involves_nan(IntPtr arg0);
    public static extern IntPtr isl_multi_union_pw_aff_get_list(IntPtr arg0);
    public static extern IntPtr isl_multi_union_pw_aff_neg(IntPtr arg0);
    public static extern IntPtr isl_multi_union_pw_aff_plain_is_equal(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_union_pw_aff_pullback_union_pw_multi_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_union_pw_aff_range_product(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_union_pw_aff_get_range_tuple_id(IntPtr arg0);
    public static extern IntPtr isl_multi_union_pw_aff_reset_range_tuple_id(IntPtr arg0);
    public static extern IntPtr isl_multi_union_pw_aff_scale_multi_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_union_pw_aff_scale_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_union_pw_aff_scale_down_multi_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_union_pw_aff_scale_down_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_union_pw_aff_set_at(IntPtr arg0, int arg1, IntPtr arg2);
    public static extern IntPtr isl_multi_union_pw_aff_set_range_tuple_id(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_union_pw_aff_size(IntPtr arg0);
    public static extern IntPtr isl_multi_union_pw_aff_get_space(IntPtr arg0);
    public static extern IntPtr isl_multi_union_pw_aff_sub(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_union_pw_aff_union_add(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_union_pw_aff_zero(IntPtr arg0);
    public static extern IntPtr isl_multi_union_pw_aff_copy(IntPtr arg0);
    public static extern IntPtr isl_multi_union_pw_aff_free(IntPtr arg0);
    public static extern IntPtr isl_multi_union_pw_aff_to_str(IntPtr arg0);
}

public class union_pw_affunion_pw_multi_aff, multi_union_pw_aff{
    private Context ctx;
private IntPtr ptr;
public union_pw_aff(isl_context? ctx = null, IntPtr? ptr = null)
{
    if (ptr is not null)
    {
        this.ctx = ctx!;
        this.ptr = ptr!;
    }
}
public union_pw_aff(aff arg_0)
{
    this.ctx = Context.DefaultInstance;
    this.ptr = Interop.isl_union_pw_aff_from_aff(Interop.isl_aff_copy(args[0].ptr))
    }
public union_pw_aff(pw_aff arg_0)
{
    this.ctx = Context.DefaultInstance;
    this.ptr = Interop.isl_union_pw_aff_from_pw_aff(Interop.isl_pw_aff_copy(args[0].ptr))
    }
public union_pw_aff(string arg_0)
{
    this.ctx = Context.DefaultInstance;
    this.ptr = Interop.isl_union_pw_aff_read_from_str(this.ctx, args[0].encode('ascii'))
    }
public Dispose()
{
    if (ptr is not null)
    {
        isl.isl_union_pw_aff_free(ptr);
    }
}
public override ToString()
{
    IntPtr char_p = isl.isl_union_pw_aff_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
    Marshal.FreeHGlobal(ptr);
    return res;
}
public Pointer add(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_union_pw_aff_add(Interop.isl_union_pw_aff_copy(arg0.ptr), Interop.isl_union_pw_aff_copy(arg1.ptr));
    var obj = new union_pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer bind(id arg_1)
{
    var res = Interop.isl_union_pw_aff_bind_id(Interop.isl_union_pw_aff_copy(args[0].ptr), Interop.isl_id_copy(args[1].ptr));
    var obj = new union_set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer coalesce(Pointer arg0)
{
    var res = Interop.isl_union_pw_aff_coalesce(Interop.isl_union_pw_aff_copy(arg0.ptr));
    var obj = new union_pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer domain(Pointer arg0)
{
    var res = Interop.isl_union_pw_aff_domain(Interop.isl_union_pw_aff_copy(arg0.ptr));
    var obj = new union_set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer drop_unused_params(Pointer arg0)
{
    var res = Interop.isl_union_pw_aff_drop_unused_params(Interop.isl_union_pw_aff_copy(arg0.ptr));
    var obj = new union_pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer gist(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_union_pw_aff_gist(Interop.isl_union_pw_aff_copy(arg0.ptr), Interop.isl_union_set_copy(arg1.ptr));
    var obj = new union_pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer intersect_domain(space arg_1)
{
    var res = Interop.isl_union_pw_aff_intersect_domain_space(Interop.isl_union_pw_aff_copy(args[0].ptr), Interop.isl_space_copy(args[1].ptr));
    var obj = new union_pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer intersect_domain(union_set arg_1)
{
    var res = Interop.isl_union_pw_aff_intersect_domain_union_set(Interop.isl_union_pw_aff_copy(args[0].ptr), Interop.isl_union_set_copy(args[1].ptr));
    var obj = new union_pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer intersect_domain_wrapped_domain(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_union_pw_aff_intersect_domain_wrapped_domain(Interop.isl_union_pw_aff_copy(arg0.ptr), Interop.isl_union_set_copy(arg1.ptr));
    var obj = new union_pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer intersect_domain_wrapped_range(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_union_pw_aff_intersect_domain_wrapped_range(Interop.isl_union_pw_aff_copy(arg0.ptr), Interop.isl_union_set_copy(arg1.ptr));
    var obj = new union_pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer intersect_params(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_union_pw_aff_intersect_params(Interop.isl_union_pw_aff_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
    var obj = new union_pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Typedef plain_is_equal(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_union_pw_aff_plain_is_equal(arg0.ptr, arg1.ptr);
    if (res < 0)
    {
        throw new InvalidOperationException();
    }
    return res;
}
public Pointer pullback(union_pw_multi_aff arg_1)
{
    var res = Interop.isl_union_pw_aff_pullback_union_pw_multi_aff(Interop.isl_union_pw_aff_copy(args[0].ptr), Interop.isl_union_pw_multi_aff_copy(args[1].ptr));
    var obj = new union_pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer space(Pointer arg0)
{
    var res = Interop.isl_union_pw_aff_get_space(arg0.ptr);
    var obj = new space(ctx = ctx, ptr = res);
    return obj;
}
public Pointer sub(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_union_pw_aff_sub(Interop.isl_union_pw_aff_copy(arg0.ptr), Interop.isl_union_pw_aff_copy(arg1.ptr));
    var obj = new union_pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer subtract_domain(space arg_1)
{
    var res = Interop.isl_union_pw_aff_subtract_domain_space(Interop.isl_union_pw_aff_copy(args[0].ptr), Interop.isl_space_copy(args[1].ptr));
    var obj = new union_pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer subtract_domain(union_set arg_1)
{
    var res = Interop.isl_union_pw_aff_subtract_domain_union_set(Interop.isl_union_pw_aff_copy(args[0].ptr), Interop.isl_union_set_copy(args[1].ptr));
    var obj = new union_pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer to_list(Pointer arg0)
{
    var res = Interop.isl_union_pw_aff_to_list(Interop.isl_union_pw_aff_copy(arg0.ptr));
    var obj = new union_pw_aff_list(ctx = ctx, ptr = res);
    return obj;
}
public Pointer union_add(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_union_pw_aff_union_add(Interop.isl_union_pw_aff_copy(arg0.ptr), Interop.isl_union_pw_aff_copy(arg1.ptr));
    var obj = new union_pw_aff(ctx = ctx, ptr = res);
    return obj;
}
}
internal static partial class Interop
{
    public static extern IntPtr isl_union_pw_aff_from_aff(IntPtr arg0);
    public static extern IntPtr isl_union_pw_aff_from_pw_aff(IntPtr arg0);
    public static extern IntPtr isl_union_pw_aff_read_from_str(Context arg0, IntPtr arg1);
    public static extern IntPtr isl_union_pw_aff_add(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_pw_aff_bind_id(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_pw_aff_coalesce(IntPtr arg0);
    public static extern IntPtr isl_union_pw_aff_domain(IntPtr arg0);
    public static extern IntPtr isl_union_pw_aff_drop_unused_params(IntPtr arg0);
    public static extern IntPtr isl_union_pw_aff_gist(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_pw_aff_intersect_domain_space(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_pw_aff_intersect_domain_union_set(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_pw_aff_intersect_domain_wrapped_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_pw_aff_intersect_domain_wrapped_range(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_pw_aff_intersect_params(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_pw_aff_plain_is_equal(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_pw_aff_pullback_union_pw_multi_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_pw_aff_get_space(IntPtr arg0);
    public static extern IntPtr isl_union_pw_aff_sub(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_pw_aff_subtract_domain_space(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_pw_aff_subtract_domain_union_set(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_pw_aff_to_list(IntPtr arg0);
    public static extern IntPtr isl_union_pw_aff_union_add(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_pw_aff_copy(IntPtr arg0);
    public static extern IntPtr isl_union_pw_aff_free(IntPtr arg0);
    public static extern IntPtr isl_union_pw_aff_to_str(IntPtr arg0);
}

public class multi_pw_affmulti_union_pw_aff
{
    private Context ctx;
    private IntPtr ptr;
    public multi_pw_aff(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public multi_pw_aff(aff arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_multi_pw_aff_from_aff(Interop.isl_aff_copy(args[0].ptr))
    }
    public multi_pw_aff(multi_aff arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_multi_pw_aff_from_multi_aff(Interop.isl_multi_aff_copy(args[0].ptr))
    }
    public multi_pw_aff(pw_aff arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_multi_pw_aff_from_pw_aff(Interop.isl_pw_aff_copy(args[0].ptr))
    }
    public multi_pw_aff(space arg_0, pw_aff_list arg_1)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_multi_pw_aff_from_pw_aff_list(Interop.isl_space_copy(args[0].ptr), Interop.isl_pw_aff_list_copy(args[1].ptr))
    }
    public multi_pw_aff(pw_multi_aff arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_multi_pw_aff_from_pw_multi_aff(Interop.isl_pw_multi_aff_copy(args[0].ptr))
    }
    public multi_pw_aff(string arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_multi_pw_aff_read_from_str(this.ctx, args[0].encode('ascii'))
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_multi_pw_aff_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_multi_pw_aff_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer add(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_pw_aff_add(Interop.isl_multi_pw_aff_copy(arg0.ptr), Interop.isl_multi_pw_aff_copy(arg1.ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer add_constant(multi_val arg_1)
    {
        var res = Interop.isl_multi_pw_aff_add_constant_multi_val(Interop.isl_multi_pw_aff_copy(args[0].ptr), Interop.isl_multi_val_copy(args[1].ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer add_constant(val arg_1)
    {
        var res = Interop.isl_multi_pw_aff_add_constant_val(Interop.isl_multi_pw_aff_copy(args[0].ptr), Interop.isl_val_copy(args[1].ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer as_map(Pointer arg0)
    {
        var res = Interop.isl_multi_pw_aff_as_map(Interop.isl_multi_pw_aff_copy(arg0.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer as_multi_aff(Pointer arg0)
    {
        var res = Interop.isl_multi_pw_aff_as_multi_aff(Interop.isl_multi_pw_aff_copy(arg0.ptr));
        var obj = new multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer as_set(Pointer arg0)
    {
        var res = Interop.isl_multi_pw_aff_as_set(Interop.isl_multi_pw_aff_copy(arg0.ptr));
        var obj = new set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer at(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_pw_aff_get_at(arg0.ptr, arg1);
        var obj = new pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer bind(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_pw_aff_bind(Interop.isl_multi_pw_aff_copy(arg0.ptr), Interop.isl_multi_id_copy(arg1.ptr));
        var obj = new set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer bind_domain(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_pw_aff_bind_domain(Interop.isl_multi_pw_aff_copy(arg0.ptr), Interop.isl_multi_id_copy(arg1.ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer bind_domain_wrapped_domain(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_pw_aff_bind_domain_wrapped_domain(Interop.isl_multi_pw_aff_copy(arg0.ptr), Interop.isl_multi_id_copy(arg1.ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer coalesce(Pointer arg0)
    {
        var res = Interop.isl_multi_pw_aff_coalesce(Interop.isl_multi_pw_aff_copy(arg0.ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer domain(Pointer arg0)
    {
        var res = Interop.isl_multi_pw_aff_domain(Interop.isl_multi_pw_aff_copy(arg0.ptr));
        var obj = new set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer domain_reverse(Pointer arg0)
    {
        var res = Interop.isl_multi_pw_aff_domain_reverse(Interop.isl_multi_pw_aff_copy(arg0.ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer flat_range_product(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_pw_aff_flat_range_product(Interop.isl_multi_pw_aff_copy(arg0.ptr), Interop.isl_multi_pw_aff_copy(arg1.ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer gist(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_pw_aff_gist(Interop.isl_multi_pw_aff_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer gist_params(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_pw_aff_gist_params(Interop.isl_multi_pw_aff_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef has_range_tuple_id(Pointer arg0)
    {
        var res = Interop.isl_multi_pw_aff_has_range_tuple_id(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer identity()
    {
        var res = Interop.isl_multi_pw_aff_identity_multi_pw_aff(Interop.isl_multi_pw_aff_copy(args[0].ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public static Pointer identity_on_domain(space arg_0)
    {
        var res = Interop.isl_multi_pw_aff_identity_on_domain_space(Interop.isl_space_copy(args[0].ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer insert_domain(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_pw_aff_insert_domain(Interop.isl_multi_pw_aff_copy(arg0.ptr), Interop.isl_space_copy(arg1.ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer intersect_domain(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_pw_aff_intersect_domain(Interop.isl_multi_pw_aff_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer intersect_params(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_pw_aff_intersect_params(Interop.isl_multi_pw_aff_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef involves_nan(Pointer arg0)
    {
        var res = Interop.isl_multi_pw_aff_involves_nan(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef involves_param(id arg_1)
    {
        var res = Interop.isl_multi_pw_aff_involves_param_id(args[0].ptr, args[1].ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef involves_param(id_list arg_1)
    {
        var res = Interop.isl_multi_pw_aff_involves_param_id_list(args[0].ptr, args[1].ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef isa_multi_aff(Pointer arg0)
    {
        var res = Interop.isl_multi_pw_aff_isa_multi_aff(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer list(Pointer arg0)
    {
        var res = Interop.isl_multi_pw_aff_get_list(arg0.ptr);
        var obj = new pw_aff_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer max(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_pw_aff_max(Interop.isl_multi_pw_aff_copy(arg0.ptr), Interop.isl_multi_pw_aff_copy(arg1.ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer max_multi_val(Pointer arg0)
    {
        var res = Interop.isl_multi_pw_aff_max_multi_val(Interop.isl_multi_pw_aff_copy(arg0.ptr));
        var obj = new multi_val(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer min(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_pw_aff_min(Interop.isl_multi_pw_aff_copy(arg0.ptr), Interop.isl_multi_pw_aff_copy(arg1.ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer min_multi_val(Pointer arg0)
    {
        var res = Interop.isl_multi_pw_aff_min_multi_val(Interop.isl_multi_pw_aff_copy(arg0.ptr));
        var obj = new multi_val(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer neg(Pointer arg0)
    {
        var res = Interop.isl_multi_pw_aff_neg(Interop.isl_multi_pw_aff_copy(arg0.ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef plain_is_equal(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_pw_aff_plain_is_equal(arg0.ptr, arg1.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer product(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_pw_aff_product(Interop.isl_multi_pw_aff_copy(arg0.ptr), Interop.isl_multi_pw_aff_copy(arg1.ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer pullback(multi_aff arg_1)
    {
        var res = Interop.isl_multi_pw_aff_pullback_multi_aff(Interop.isl_multi_pw_aff_copy(args[0].ptr), Interop.isl_multi_aff_copy(args[1].ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer pullback(multi_pw_aff arg_1)
    {
        var res = Interop.isl_multi_pw_aff_pullback_multi_pw_aff(Interop.isl_multi_pw_aff_copy(args[0].ptr), Interop.isl_multi_pw_aff_copy(args[1].ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer pullback(pw_multi_aff arg_1)
    {
        var res = Interop.isl_multi_pw_aff_pullback_pw_multi_aff(Interop.isl_multi_pw_aff_copy(args[0].ptr), Interop.isl_pw_multi_aff_copy(args[1].ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer range_product(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_pw_aff_range_product(Interop.isl_multi_pw_aff_copy(arg0.ptr), Interop.isl_multi_pw_aff_copy(arg1.ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer range_tuple_id(Pointer arg0)
    {
        var res = Interop.isl_multi_pw_aff_get_range_tuple_id(arg0.ptr);
        var obj = new id(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer reset_range_tuple_id(Pointer arg0)
    {
        var res = Interop.isl_multi_pw_aff_reset_range_tuple_id(Interop.isl_multi_pw_aff_copy(arg0.ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer scale(multi_val arg_1)
    {
        var res = Interop.isl_multi_pw_aff_scale_multi_val(Interop.isl_multi_pw_aff_copy(args[0].ptr), Interop.isl_multi_val_copy(args[1].ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer scale(val arg_1)
    {
        var res = Interop.isl_multi_pw_aff_scale_val(Interop.isl_multi_pw_aff_copy(args[0].ptr), Interop.isl_val_copy(args[1].ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer scale_down(multi_val arg_1)
    {
        var res = Interop.isl_multi_pw_aff_scale_down_multi_val(Interop.isl_multi_pw_aff_copy(args[0].ptr), Interop.isl_multi_val_copy(args[1].ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer scale_down(val arg_1)
    {
        var res = Interop.isl_multi_pw_aff_scale_down_val(Interop.isl_multi_pw_aff_copy(args[0].ptr), Interop.isl_val_copy(args[1].ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer set_at(Pointer arg0, Pointer arg1, Pointer arg2)
    {
        var res = Interop.isl_multi_pw_aff_set_at(Interop.isl_multi_pw_aff_copy(arg0.ptr), arg1, Interop.isl_pw_aff_copy(arg2.ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer set_range_tuple(id arg_1)
    {
        var res = Interop.isl_multi_pw_aff_set_range_tuple_id(Interop.isl_multi_pw_aff_copy(args[0].ptr), Interop.isl_id_copy(args[1].ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef size(Pointer arg0)
    {
        var res = Interop.isl_multi_pw_aff_size(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer space(Pointer arg0)
    {
        var res = Interop.isl_multi_pw_aff_get_space(arg0.ptr);
        var obj = new space(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer sub(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_pw_aff_sub(Interop.isl_multi_pw_aff_copy(arg0.ptr), Interop.isl_multi_pw_aff_copy(arg1.ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer unbind_params_insert_domain(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_pw_aff_unbind_params_insert_domain(Interop.isl_multi_pw_aff_copy(arg0.ptr), Interop.isl_multi_id_copy(arg1.ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer union_add(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_pw_aff_union_add(Interop.isl_multi_pw_aff_copy(arg0.ptr), Interop.isl_multi_pw_aff_copy(arg1.ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public static Pointer zero(Pointer arg0)
    {
        var res = Interop.isl_multi_pw_aff_zero(Interop.isl_space_copy(arg0.ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_multi_pw_aff_from_aff(IntPtr arg0);
    public static extern IntPtr isl_multi_pw_aff_from_multi_aff(IntPtr arg0);
    public static extern IntPtr isl_multi_pw_aff_from_pw_aff(IntPtr arg0);
    public static extern IntPtr isl_multi_pw_aff_from_pw_aff_list(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_pw_aff_from_pw_multi_aff(IntPtr arg0);
    public static extern IntPtr isl_multi_pw_aff_read_from_str(Context arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_pw_aff_add(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_pw_aff_add_constant_multi_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_pw_aff_add_constant_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_pw_aff_as_map(IntPtr arg0);
    public static extern IntPtr isl_multi_pw_aff_as_multi_aff(IntPtr arg0);
    public static extern IntPtr isl_multi_pw_aff_as_set(IntPtr arg0);
    public static extern IntPtr isl_multi_pw_aff_get_at(IntPtr arg0, int arg1);
    public static extern IntPtr isl_multi_pw_aff_bind(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_pw_aff_bind_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_pw_aff_bind_domain_wrapped_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_pw_aff_coalesce(IntPtr arg0);
    public static extern IntPtr isl_multi_pw_aff_domain(IntPtr arg0);
    public static extern IntPtr isl_multi_pw_aff_domain_reverse(IntPtr arg0);
    public static extern IntPtr isl_multi_pw_aff_flat_range_product(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_pw_aff_gist(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_pw_aff_gist_params(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_pw_aff_has_range_tuple_id(IntPtr arg0);
    public static extern IntPtr isl_multi_pw_aff_identity_multi_pw_aff(IntPtr arg0);
    public static extern IntPtr isl_multi_pw_aff_identity_on_domain_space(IntPtr arg0);
    public static extern IntPtr isl_multi_pw_aff_insert_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_pw_aff_intersect_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_pw_aff_intersect_params(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_pw_aff_involves_nan(IntPtr arg0);
    public static extern IntPtr isl_multi_pw_aff_involves_param_id(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_pw_aff_involves_param_id_list(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_pw_aff_isa_multi_aff(IntPtr arg0);
    public static extern IntPtr isl_multi_pw_aff_get_list(IntPtr arg0);
    public static extern IntPtr isl_multi_pw_aff_max(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_pw_aff_max_multi_val(IntPtr arg0);
    public static extern IntPtr isl_multi_pw_aff_min(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_pw_aff_min_multi_val(IntPtr arg0);
    public static extern IntPtr isl_multi_pw_aff_neg(IntPtr arg0);
    public static extern IntPtr isl_multi_pw_aff_plain_is_equal(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_pw_aff_product(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_pw_aff_pullback_multi_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_pw_aff_pullback_multi_pw_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_pw_aff_pullback_pw_multi_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_pw_aff_range_product(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_pw_aff_get_range_tuple_id(IntPtr arg0);
    public static extern IntPtr isl_multi_pw_aff_reset_range_tuple_id(IntPtr arg0);
    public static extern IntPtr isl_multi_pw_aff_scale_multi_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_pw_aff_scale_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_pw_aff_scale_down_multi_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_pw_aff_scale_down_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_pw_aff_set_at(IntPtr arg0, int arg1, IntPtr arg2);
    public static extern IntPtr isl_multi_pw_aff_set_range_tuple_id(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_pw_aff_size(IntPtr arg0);
    public static extern IntPtr isl_multi_pw_aff_get_space(IntPtr arg0);
    public static extern IntPtr isl_multi_pw_aff_sub(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_pw_aff_unbind_params_insert_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_pw_aff_union_add(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_pw_aff_zero(IntPtr arg0);
    public static extern IntPtr isl_multi_pw_aff_copy(IntPtr arg0);
    public static extern IntPtr isl_multi_pw_aff_free(IntPtr arg0);
    public static extern IntPtr isl_multi_pw_aff_to_str(IntPtr arg0);
}

public class pw_multi_affunion_pw_multi_aff, multi_pw_aff{
    private Context ctx;
private IntPtr ptr;
public pw_multi_aff(isl_context? ctx = null, IntPtr? ptr = null)
{
    if (ptr is not null)
    {
        this.ctx = ctx!;
        this.ptr = ptr!;
    }
}
public pw_multi_aff(multi_aff arg_0)
{
    this.ctx = Context.DefaultInstance;
    this.ptr = Interop.isl_pw_multi_aff_from_multi_aff(Interop.isl_multi_aff_copy(args[0].ptr))
    }
public pw_multi_aff(pw_aff arg_0)
{
    this.ctx = Context.DefaultInstance;
    this.ptr = Interop.isl_pw_multi_aff_from_pw_aff(Interop.isl_pw_aff_copy(args[0].ptr))
    }
public pw_multi_aff(string arg_0)
{
    this.ctx = Context.DefaultInstance;
    this.ptr = Interop.isl_pw_multi_aff_read_from_str(this.ctx, args[0].encode('ascii'))
    }
public Dispose()
{
    if (ptr is not null)
    {
        isl.isl_pw_multi_aff_free(ptr);
    }
}
public override ToString() {
    IntPtr char_p = isl.isl_pw_multi_aff_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
    Marshal.FreeHGlobal(ptr);
    return res;
}
public Pointer add(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_multi_aff_add(Interop.isl_pw_multi_aff_copy(arg0.ptr), Interop.isl_pw_multi_aff_copy(arg1.ptr));
    var obj = new pw_multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer add_constant(multi_val arg_1)
{
    var res = Interop.isl_pw_multi_aff_add_constant_multi_val(Interop.isl_pw_multi_aff_copy(args[0].ptr), Interop.isl_multi_val_copy(args[1].ptr));
    var obj = new pw_multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer add_constant(val arg_1)
{
    var res = Interop.isl_pw_multi_aff_add_constant_val(Interop.isl_pw_multi_aff_copy(args[0].ptr), Interop.isl_val_copy(args[1].ptr));
    var obj = new pw_multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer as_map(Pointer arg0)
{
    var res = Interop.isl_pw_multi_aff_as_map(Interop.isl_pw_multi_aff_copy(arg0.ptr));
    var obj = new map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer as_multi_aff(Pointer arg0)
{
    var res = Interop.isl_pw_multi_aff_as_multi_aff(Interop.isl_pw_multi_aff_copy(arg0.ptr));
    var obj = new multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer as_set(Pointer arg0)
{
    var res = Interop.isl_pw_multi_aff_as_set(Interop.isl_pw_multi_aff_copy(arg0.ptr));
    var obj = new set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer at(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_multi_aff_get_at(arg0.ptr, arg1);
    var obj = new pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer bind_domain(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_multi_aff_bind_domain(Interop.isl_pw_multi_aff_copy(arg0.ptr), Interop.isl_multi_id_copy(arg1.ptr));
    var obj = new pw_multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer bind_domain_wrapped_domain(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_multi_aff_bind_domain_wrapped_domain(Interop.isl_pw_multi_aff_copy(arg0.ptr), Interop.isl_multi_id_copy(arg1.ptr));
    var obj = new pw_multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer coalesce(Pointer arg0)
{
    var res = Interop.isl_pw_multi_aff_coalesce(Interop.isl_pw_multi_aff_copy(arg0.ptr));
    var obj = new pw_multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer domain(Pointer arg0)
{
    var res = Interop.isl_pw_multi_aff_domain(Interop.isl_pw_multi_aff_copy(arg0.ptr));
    var obj = new set(ctx = ctx, ptr = res);
    return obj;
}
public static Pointer domain_map(Pointer arg0)
{
    var res = Interop.isl_pw_multi_aff_domain_map(Interop.isl_space_copy(arg0.ptr));
    var obj = new pw_multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer domain_reverse(Pointer arg0)
{
    var res = Interop.isl_pw_multi_aff_domain_reverse(Interop.isl_pw_multi_aff_copy(arg0.ptr));
    var obj = new pw_multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer drop_unused_params(Pointer arg0)
{
    var res = Interop.isl_pw_multi_aff_drop_unused_params(Interop.isl_pw_multi_aff_copy(arg0.ptr));
    var obj = new pw_multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer flat_range_product(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_multi_aff_flat_range_product(Interop.isl_pw_multi_aff_copy(arg0.ptr), Interop.isl_pw_multi_aff_copy(arg1.ptr));
    var obj = new pw_multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Typedef foreach_piece(Pointer arg0, Pointer arg1)
{
    var exc_info = new Exception[1];
    var fn = (IntPtr cb_arg0, IntPtr cb_arg1, IntPtr user) =>
    {
        var cb_cls0 = new set(ctx: arg0.ctx, ptr: (cb_arg0));
        var cb_cls1 = new multi_aff(ctx: arg0.ctx, ptr: (cb_arg1));
        try
        {
            arg1(cb_cls0, cb_cls1);
        }
        catch (Exception e)
        {
            exc_info[0] = e;
            return -1;
        }
        return 0;
    };
    var cb1 = Marshal.GetFunctionPointerForDelegate(cb_func);
    var res = Interop.isl_pw_multi_aff_foreach_piece(arg0.ptr, cb1, IntPtr.Zerp);
    if (exc_info[0] is not null)
    {
        throw exc_info[0];
    }
    if (res < 0)
    {
        throw new InvalidOperationException();
    }
}
public Pointer gist(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_multi_aff_gist(Interop.isl_pw_multi_aff_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
    var obj = new pw_multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer gist_params(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_multi_aff_gist_params(Interop.isl_pw_multi_aff_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
    var obj = new pw_multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Typedef has_range_tuple_id(Pointer arg0)
{
    var res = Interop.isl_pw_multi_aff_has_range_tuple_id(arg0.ptr);
    if (res < 0)
    {
        throw new InvalidOperationException();
    }
    return res;
}
public static Pointer identity_on_domain(space arg_0)
{
    var res = Interop.isl_pw_multi_aff_identity_on_domain_space(Interop.isl_space_copy(args[0].ptr));
    var obj = new pw_multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer insert_domain(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_multi_aff_insert_domain(Interop.isl_pw_multi_aff_copy(arg0.ptr), Interop.isl_space_copy(arg1.ptr));
    var obj = new pw_multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer intersect_domain(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_multi_aff_intersect_domain(Interop.isl_pw_multi_aff_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
    var obj = new pw_multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer intersect_params(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_multi_aff_intersect_params(Interop.isl_pw_multi_aff_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
    var obj = new pw_multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Typedef involves_locals(Pointer arg0)
{
    var res = Interop.isl_pw_multi_aff_involves_locals(arg0.ptr);
    if (res < 0)
    {
        throw new InvalidOperationException();
    }
    return res;
}
public Typedef isa_multi_aff(Pointer arg0)
{
    var res = Interop.isl_pw_multi_aff_isa_multi_aff(arg0.ptr);
    if (res < 0)
    {
        throw new InvalidOperationException();
    }
    return res;
}
public Pointer max_multi_val(Pointer arg0)
{
    var res = Interop.isl_pw_multi_aff_max_multi_val(Interop.isl_pw_multi_aff_copy(arg0.ptr));
    var obj = new multi_val(ctx = ctx, ptr = res);
    return obj;
}
public Pointer min_multi_val(Pointer arg0)
{
    var res = Interop.isl_pw_multi_aff_min_multi_val(Interop.isl_pw_multi_aff_copy(arg0.ptr));
    var obj = new multi_val(ctx = ctx, ptr = res);
    return obj;
}
public static Pointer multi_val_on_domain(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_multi_aff_multi_val_on_domain(Interop.isl_set_copy(arg0.ptr), Interop.isl_multi_val_copy(arg1.ptr));
    var obj = new pw_multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Typedef n_piece(Pointer arg0)
{
    var res = Interop.isl_pw_multi_aff_n_piece(arg0.ptr);
    if (res < 0)
    {
        throw new InvalidOperationException();
    }
    return res;
}
public Typedef plain_is_equal(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_multi_aff_plain_is_equal(arg0.ptr, arg1.ptr);
    if (res < 0)
    {
        throw new InvalidOperationException();
    }
    return res;
}
public Pointer preimage_domain_wrapped_domain(pw_multi_aff arg_1)
{
    var res = Interop.isl_pw_multi_aff_preimage_domain_wrapped_domain_pw_multi_aff(Interop.isl_pw_multi_aff_copy(args[0].ptr), Interop.isl_pw_multi_aff_copy(args[1].ptr));
    var obj = new pw_multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer product(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_multi_aff_product(Interop.isl_pw_multi_aff_copy(arg0.ptr), Interop.isl_pw_multi_aff_copy(arg1.ptr));
    var obj = new pw_multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer pullback(multi_aff arg_1)
{
    var res = Interop.isl_pw_multi_aff_pullback_multi_aff(Interop.isl_pw_multi_aff_copy(args[0].ptr), Interop.isl_multi_aff_copy(args[1].ptr));
    var obj = new pw_multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer pullback(pw_multi_aff arg_1)
{
    var res = Interop.isl_pw_multi_aff_pullback_pw_multi_aff(Interop.isl_pw_multi_aff_copy(args[0].ptr), Interop.isl_pw_multi_aff_copy(args[1].ptr));
    var obj = new pw_multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer range_factor_domain(Pointer arg0)
{
    var res = Interop.isl_pw_multi_aff_range_factor_domain(Interop.isl_pw_multi_aff_copy(arg0.ptr));
    var obj = new pw_multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer range_factor_range(Pointer arg0)
{
    var res = Interop.isl_pw_multi_aff_range_factor_range(Interop.isl_pw_multi_aff_copy(arg0.ptr));
    var obj = new pw_multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public static Pointer range_map(Pointer arg0)
{
    var res = Interop.isl_pw_multi_aff_range_map(Interop.isl_space_copy(arg0.ptr));
    var obj = new pw_multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer range_product(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_multi_aff_range_product(Interop.isl_pw_multi_aff_copy(arg0.ptr), Interop.isl_pw_multi_aff_copy(arg1.ptr));
    var obj = new pw_multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer range_tuple_id(Pointer arg0)
{
    var res = Interop.isl_pw_multi_aff_get_range_tuple_id(arg0.ptr);
    var obj = new id(ctx = ctx, ptr = res);
    return obj;
}
public Pointer scale(multi_val arg_1)
{
    var res = Interop.isl_pw_multi_aff_scale_multi_val(Interop.isl_pw_multi_aff_copy(args[0].ptr), Interop.isl_multi_val_copy(args[1].ptr));
    var obj = new pw_multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer scale(val arg_1)
{
    var res = Interop.isl_pw_multi_aff_scale_val(Interop.isl_pw_multi_aff_copy(args[0].ptr), Interop.isl_val_copy(args[1].ptr));
    var obj = new pw_multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer scale_down(multi_val arg_1)
{
    var res = Interop.isl_pw_multi_aff_scale_down_multi_val(Interop.isl_pw_multi_aff_copy(args[0].ptr), Interop.isl_multi_val_copy(args[1].ptr));
    var obj = new pw_multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer scale_down(val arg_1)
{
    var res = Interop.isl_pw_multi_aff_scale_down_val(Interop.isl_pw_multi_aff_copy(args[0].ptr), Interop.isl_val_copy(args[1].ptr));
    var obj = new pw_multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer set_range_tuple(id arg_1)
{
    var res = Interop.isl_pw_multi_aff_set_range_tuple_id(Interop.isl_pw_multi_aff_copy(args[0].ptr), Interop.isl_id_copy(args[1].ptr));
    var obj = new pw_multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer space(Pointer arg0)
{
    var res = Interop.isl_pw_multi_aff_get_space(arg0.ptr);
    var obj = new space(ctx = ctx, ptr = res);
    return obj;
}
public Pointer sub(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_multi_aff_sub(Interop.isl_pw_multi_aff_copy(arg0.ptr), Interop.isl_pw_multi_aff_copy(arg1.ptr));
    var obj = new pw_multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer subtract_domain(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_multi_aff_subtract_domain(Interop.isl_pw_multi_aff_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
    var obj = new pw_multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer to_list(Pointer arg0)
{
    var res = Interop.isl_pw_multi_aff_to_list(Interop.isl_pw_multi_aff_copy(arg0.ptr));
    var obj = new pw_multi_aff_list(ctx = ctx, ptr = res);
    return obj;
}
public Pointer to_multi_pw_aff(Pointer arg0)
{
    var res = Interop.isl_pw_multi_aff_to_multi_pw_aff(Interop.isl_pw_multi_aff_copy(arg0.ptr));
    var obj = new multi_pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer to_union_pw_multi_aff(Pointer arg0)
{
    var res = Interop.isl_pw_multi_aff_to_union_pw_multi_aff(Interop.isl_pw_multi_aff_copy(arg0.ptr));
    var obj = new union_pw_multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer union_add(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_multi_aff_union_add(Interop.isl_pw_multi_aff_copy(arg0.ptr), Interop.isl_pw_multi_aff_copy(arg1.ptr));
    var obj = new pw_multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public static Pointer zero(Pointer arg0)
{
    var res = Interop.isl_pw_multi_aff_zero(Interop.isl_space_copy(arg0.ptr));
    var obj = new pw_multi_aff(ctx = ctx, ptr = res);
    return obj;
}
}
internal static partial class Interop
{
    public static extern IntPtr isl_pw_multi_aff_from_multi_aff(IntPtr arg0);
    public static extern IntPtr isl_pw_multi_aff_from_pw_aff(IntPtr arg0);
    public static extern IntPtr isl_pw_multi_aff_read_from_str(Context arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_multi_aff_add(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_multi_aff_add_constant_multi_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_multi_aff_add_constant_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_multi_aff_as_map(IntPtr arg0);
    public static extern IntPtr isl_pw_multi_aff_as_multi_aff(IntPtr arg0);
    public static extern IntPtr isl_pw_multi_aff_as_set(IntPtr arg0);
    public static extern IntPtr isl_pw_multi_aff_get_at(IntPtr arg0, int arg1);
    public static extern IntPtr isl_pw_multi_aff_bind_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_multi_aff_bind_domain_wrapped_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_multi_aff_coalesce(IntPtr arg0);
    public static extern IntPtr isl_pw_multi_aff_domain(IntPtr arg0);
    public static extern IntPtr isl_pw_multi_aff_domain_map(IntPtr arg0);
    public static extern IntPtr isl_pw_multi_aff_domain_reverse(IntPtr arg0);
    public static extern IntPtr isl_pw_multi_aff_drop_unused_params(IntPtr arg0);
    public static extern IntPtr isl_pw_multi_aff_flat_range_product(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_multi_aff_foreach_piece(IntPtr arg0, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg1, IntPtr arg2);
    public static extern IntPtr isl_pw_multi_aff_gist(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_multi_aff_gist_params(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_multi_aff_has_range_tuple_id(IntPtr arg0);
    public static extern IntPtr isl_pw_multi_aff_identity_on_domain_space(IntPtr arg0);
    public static extern IntPtr isl_pw_multi_aff_insert_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_multi_aff_intersect_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_multi_aff_intersect_params(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_multi_aff_involves_locals(IntPtr arg0);
    public static extern IntPtr isl_pw_multi_aff_isa_multi_aff(IntPtr arg0);
    public static extern IntPtr isl_pw_multi_aff_max_multi_val(IntPtr arg0);
    public static extern IntPtr isl_pw_multi_aff_min_multi_val(IntPtr arg0);
    public static extern IntPtr isl_pw_multi_aff_multi_val_on_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_multi_aff_n_piece(IntPtr arg0);
    public static extern IntPtr isl_pw_multi_aff_plain_is_equal(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_multi_aff_preimage_domain_wrapped_domain_pw_multi_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_multi_aff_product(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_multi_aff_pullback_multi_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_multi_aff_pullback_pw_multi_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_multi_aff_range_factor_domain(IntPtr arg0);
    public static extern IntPtr isl_pw_multi_aff_range_factor_range(IntPtr arg0);
    public static extern IntPtr isl_pw_multi_aff_range_map(IntPtr arg0);
    public static extern IntPtr isl_pw_multi_aff_range_product(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_multi_aff_get_range_tuple_id(IntPtr arg0);
    public static extern IntPtr isl_pw_multi_aff_scale_multi_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_multi_aff_scale_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_multi_aff_scale_down_multi_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_multi_aff_scale_down_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_multi_aff_set_range_tuple_id(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_multi_aff_get_space(IntPtr arg0);
    public static extern IntPtr isl_pw_multi_aff_sub(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_multi_aff_subtract_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_multi_aff_to_list(IntPtr arg0);
    public static extern IntPtr isl_pw_multi_aff_to_multi_pw_aff(IntPtr arg0);
    public static extern IntPtr isl_pw_multi_aff_to_union_pw_multi_aff(IntPtr arg0);
    public static extern IntPtr isl_pw_multi_aff_union_add(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_multi_aff_zero(IntPtr arg0);
    public static extern IntPtr isl_pw_multi_aff_copy(IntPtr arg0);
    public static extern IntPtr isl_pw_multi_aff_free(IntPtr arg0);
    public static extern IntPtr isl_pw_multi_aff_to_str(IntPtr arg0);
}

public class pw_affunion_pw_aff, pw_multi_aff, multi_pw_aff{
    private Context ctx;
private IntPtr ptr;
public pw_aff(isl_context? ctx = null, IntPtr? ptr = null)
{
    if (ptr is not null)
    {
        this.ctx = ctx!;
        this.ptr = ptr!;
    }
}
public pw_aff(aff arg_0)
{
    this.ctx = Context.DefaultInstance;
    this.ptr = Interop.isl_pw_aff_from_aff(Interop.isl_aff_copy(args[0].ptr))
    }
public pw_aff(string arg_0)
{
    this.ctx = Context.DefaultInstance;
    this.ptr = Interop.isl_pw_aff_read_from_str(this.ctx, args[0].encode('ascii'))
    }
public Dispose()
{
    if (ptr is not null)
    {
        isl.isl_pw_aff_free(ptr);
    }
}
public override ToString() {
    IntPtr char_p = isl.isl_pw_aff_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
    Marshal.FreeHGlobal(ptr);
    return res;
}
public Pointer add(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_aff_add(Interop.isl_pw_aff_copy(arg0.ptr), Interop.isl_pw_aff_copy(arg1.ptr));
    var obj = new pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer add_constant(val arg_1)
{
    var res = Interop.isl_pw_aff_add_constant_val(Interop.isl_pw_aff_copy(args[0].ptr), Interop.isl_val_copy(args[1].ptr));
    var obj = new pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer as_aff(Pointer arg0)
{
    var res = Interop.isl_pw_aff_as_aff(Interop.isl_pw_aff_copy(arg0.ptr));
    var obj = new aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer as_map(Pointer arg0)
{
    var res = Interop.isl_pw_aff_as_map(Interop.isl_pw_aff_copy(arg0.ptr));
    var obj = new map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer bind(id arg_1)
{
    var res = Interop.isl_pw_aff_bind_id(Interop.isl_pw_aff_copy(args[0].ptr), Interop.isl_id_copy(args[1].ptr));
    var obj = new set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer bind_domain(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_aff_bind_domain(Interop.isl_pw_aff_copy(arg0.ptr), Interop.isl_multi_id_copy(arg1.ptr));
    var obj = new pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer bind_domain_wrapped_domain(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_aff_bind_domain_wrapped_domain(Interop.isl_pw_aff_copy(arg0.ptr), Interop.isl_multi_id_copy(arg1.ptr));
    var obj = new pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer ceil(Pointer arg0)
{
    var res = Interop.isl_pw_aff_ceil(Interop.isl_pw_aff_copy(arg0.ptr));
    var obj = new pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer coalesce(Pointer arg0)
{
    var res = Interop.isl_pw_aff_coalesce(Interop.isl_pw_aff_copy(arg0.ptr));
    var obj = new pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer cond(Pointer arg0, Pointer arg1, Pointer arg2)
{
    var res = Interop.isl_pw_aff_cond(Interop.isl_pw_aff_copy(arg0.ptr), Interop.isl_pw_aff_copy(arg1.ptr), Interop.isl_pw_aff_copy(arg2.ptr));
    var obj = new pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer div(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_aff_div(Interop.isl_pw_aff_copy(arg0.ptr), Interop.isl_pw_aff_copy(arg1.ptr));
    var obj = new pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer domain(Pointer arg0)
{
    var res = Interop.isl_pw_aff_domain(Interop.isl_pw_aff_copy(arg0.ptr));
    var obj = new set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer domain_reverse(Pointer arg0)
{
    var res = Interop.isl_pw_aff_domain_reverse(Interop.isl_pw_aff_copy(arg0.ptr));
    var obj = new pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer drop_unused_params(Pointer arg0)
{
    var res = Interop.isl_pw_aff_drop_unused_params(Interop.isl_pw_aff_copy(arg0.ptr));
    var obj = new pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer eq_set(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_aff_eq_set(Interop.isl_pw_aff_copy(arg0.ptr), Interop.isl_pw_aff_copy(arg1.ptr));
    var obj = new set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer eval(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_aff_eval(Interop.isl_pw_aff_copy(arg0.ptr), Interop.isl_point_copy(arg1.ptr));
    var obj = new val(ctx = ctx, ptr = res);
    return obj;
}
public Pointer floor(Pointer arg0)
{
    var res = Interop.isl_pw_aff_floor(Interop.isl_pw_aff_copy(arg0.ptr));
    var obj = new pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer ge_set(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_aff_ge_set(Interop.isl_pw_aff_copy(arg0.ptr), Interop.isl_pw_aff_copy(arg1.ptr));
    var obj = new set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer gist(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_aff_gist(Interop.isl_pw_aff_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
    var obj = new pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer gist_params(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_aff_gist_params(Interop.isl_pw_aff_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
    var obj = new pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer gt_set(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_aff_gt_set(Interop.isl_pw_aff_copy(arg0.ptr), Interop.isl_pw_aff_copy(arg1.ptr));
    var obj = new set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer insert_domain(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_aff_insert_domain(Interop.isl_pw_aff_copy(arg0.ptr), Interop.isl_space_copy(arg1.ptr));
    var obj = new pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer intersect_domain(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_aff_intersect_domain(Interop.isl_pw_aff_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
    var obj = new pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer intersect_params(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_aff_intersect_params(Interop.isl_pw_aff_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
    var obj = new pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Typedef isa_aff(Pointer arg0)
{
    var res = Interop.isl_pw_aff_isa_aff(arg0.ptr);
    if (res < 0)
    {
        throw new InvalidOperationException();
    }
    return res;
}
public Pointer le_set(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_aff_le_set(Interop.isl_pw_aff_copy(arg0.ptr), Interop.isl_pw_aff_copy(arg1.ptr));
    var obj = new set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer lt_set(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_aff_lt_set(Interop.isl_pw_aff_copy(arg0.ptr), Interop.isl_pw_aff_copy(arg1.ptr));
    var obj = new set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer max(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_aff_max(Interop.isl_pw_aff_copy(arg0.ptr), Interop.isl_pw_aff_copy(arg1.ptr));
    var obj = new pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer max_val(Pointer arg0)
{
    var res = Interop.isl_pw_aff_max_val(Interop.isl_pw_aff_copy(arg0.ptr));
    var obj = new val(ctx = ctx, ptr = res);
    return obj;
}
public Pointer min(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_aff_min(Interop.isl_pw_aff_copy(arg0.ptr), Interop.isl_pw_aff_copy(arg1.ptr));
    var obj = new pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer min_val(Pointer arg0)
{
    var res = Interop.isl_pw_aff_min_val(Interop.isl_pw_aff_copy(arg0.ptr));
    var obj = new val(ctx = ctx, ptr = res);
    return obj;
}
public Pointer mod(val arg_1)
{
    var res = Interop.isl_pw_aff_mod_val(Interop.isl_pw_aff_copy(args[0].ptr), Interop.isl_val_copy(args[1].ptr));
    var obj = new pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer mul(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_aff_mul(Interop.isl_pw_aff_copy(arg0.ptr), Interop.isl_pw_aff_copy(arg1.ptr));
    var obj = new pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer ne_set(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_aff_ne_set(Interop.isl_pw_aff_copy(arg0.ptr), Interop.isl_pw_aff_copy(arg1.ptr));
    var obj = new set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer neg(Pointer arg0)
{
    var res = Interop.isl_pw_aff_neg(Interop.isl_pw_aff_copy(arg0.ptr));
    var obj = new pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public static Pointer param_on_domain(set arg_0id arg_1)
{
    var res = Interop.isl_pw_aff_param_on_domain_id(Interop.isl_set_copy(args[0].ptr), Interop.isl_id_copy(args[1].ptr));
    var obj = new pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer params(Pointer arg0) {
        var res = Interop.isl_pw_aff_params(Interop.isl_pw_aff_copy(arg0.ptr));
var obj = new set(ctx = ctx, ptr = res);
return obj;
    }
    public Typedef plain_is_equal(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_aff_plain_is_equal(arg0.ptr, arg1.ptr);
    if (res < 0)
    {
        throw new InvalidOperationException();
    }
    return res;
}
public Pointer pullback(multi_aff arg_1)
{
    var res = Interop.isl_pw_aff_pullback_multi_aff(Interop.isl_pw_aff_copy(args[0].ptr), Interop.isl_multi_aff_copy(args[1].ptr));
    var obj = new pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer pullback(multi_pw_aff arg_1)
{
    var res = Interop.isl_pw_aff_pullback_multi_pw_aff(Interop.isl_pw_aff_copy(args[0].ptr), Interop.isl_multi_pw_aff_copy(args[1].ptr));
    var obj = new pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer pullback(pw_multi_aff arg_1)
{
    var res = Interop.isl_pw_aff_pullback_pw_multi_aff(Interop.isl_pw_aff_copy(args[0].ptr), Interop.isl_pw_multi_aff_copy(args[1].ptr));
    var obj = new pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer scale(val arg_1)
{
    var res = Interop.isl_pw_aff_scale_val(Interop.isl_pw_aff_copy(args[0].ptr), Interop.isl_val_copy(args[1].ptr));
    var obj = new pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer scale_down(val arg_1)
{
    var res = Interop.isl_pw_aff_scale_down_val(Interop.isl_pw_aff_copy(args[0].ptr), Interop.isl_val_copy(args[1].ptr));
    var obj = new pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer space(Pointer arg0)
{
    var res = Interop.isl_pw_aff_get_space(arg0.ptr);
    var obj = new space(ctx = ctx, ptr = res);
    return obj;
}
public Pointer sub(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_aff_sub(Interop.isl_pw_aff_copy(arg0.ptr), Interop.isl_pw_aff_copy(arg1.ptr));
    var obj = new pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer subtract_domain(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_aff_subtract_domain(Interop.isl_pw_aff_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
    var obj = new pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer tdiv_q(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_aff_tdiv_q(Interop.isl_pw_aff_copy(arg0.ptr), Interop.isl_pw_aff_copy(arg1.ptr));
    var obj = new pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer tdiv_r(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_aff_tdiv_r(Interop.isl_pw_aff_copy(arg0.ptr), Interop.isl_pw_aff_copy(arg1.ptr));
    var obj = new pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer to_list(Pointer arg0)
{
    var res = Interop.isl_pw_aff_to_list(Interop.isl_pw_aff_copy(arg0.ptr));
    var obj = new pw_aff_list(ctx = ctx, ptr = res);
    return obj;
}
public Pointer to_union_pw_aff(Pointer arg0)
{
    var res = Interop.isl_pw_aff_to_union_pw_aff(Interop.isl_pw_aff_copy(arg0.ptr));
    var obj = new union_pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer union_add(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_pw_aff_union_add(Interop.isl_pw_aff_copy(arg0.ptr), Interop.isl_pw_aff_copy(arg1.ptr));
    var obj = new pw_aff(ctx = ctx, ptr = res);
    return obj;
}
}
internal static partial class Interop
{
    public static extern IntPtr isl_pw_aff_from_aff(IntPtr arg0);
    public static extern IntPtr isl_pw_aff_read_from_str(Context arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_aff_add(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_aff_add_constant_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_aff_as_aff(IntPtr arg0);
    public static extern IntPtr isl_pw_aff_as_map(IntPtr arg0);
    public static extern IntPtr isl_pw_aff_bind_id(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_aff_bind_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_aff_bind_domain_wrapped_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_aff_ceil(IntPtr arg0);
    public static extern IntPtr isl_pw_aff_coalesce(IntPtr arg0);
    public static extern IntPtr isl_pw_aff_cond(IntPtr arg0, IntPtr arg1, IntPtr arg2);
    public static extern IntPtr isl_pw_aff_div(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_aff_domain(IntPtr arg0);
    public static extern IntPtr isl_pw_aff_domain_reverse(IntPtr arg0);
    public static extern IntPtr isl_pw_aff_drop_unused_params(IntPtr arg0);
    public static extern IntPtr isl_pw_aff_eq_set(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_aff_eval(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_aff_floor(IntPtr arg0);
    public static extern IntPtr isl_pw_aff_ge_set(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_aff_gist(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_aff_gist_params(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_aff_gt_set(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_aff_insert_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_aff_intersect_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_aff_intersect_params(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_aff_isa_aff(IntPtr arg0);
    public static extern IntPtr isl_pw_aff_le_set(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_aff_lt_set(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_aff_max(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_aff_max_val(IntPtr arg0);
    public static extern IntPtr isl_pw_aff_min(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_aff_min_val(IntPtr arg0);
    public static extern IntPtr isl_pw_aff_mod_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_aff_mul(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_aff_ne_set(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_aff_neg(IntPtr arg0);
    public static extern IntPtr isl_pw_aff_param_on_domain_id(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_aff_params(IntPtr arg0);
    public static extern IntPtr isl_pw_aff_plain_is_equal(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_aff_pullback_multi_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_aff_pullback_multi_pw_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_aff_pullback_pw_multi_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_aff_scale_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_aff_scale_down_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_aff_get_space(IntPtr arg0);
    public static extern IntPtr isl_pw_aff_sub(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_aff_subtract_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_aff_tdiv_q(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_aff_tdiv_r(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_aff_to_list(IntPtr arg0);
    public static extern IntPtr isl_pw_aff_to_union_pw_aff(IntPtr arg0);
    public static extern IntPtr isl_pw_aff_union_add(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_aff_copy(IntPtr arg0);
    public static extern IntPtr isl_pw_aff_free(IntPtr arg0);
    public static extern IntPtr isl_pw_aff_to_str(IntPtr arg0);
}

public class multi_affpw_multi_aff, multi_pw_aff{
    private Context ctx;
private IntPtr ptr;
public multi_aff(isl_context? ctx = null, IntPtr? ptr = null)
{
    if (ptr is not null)
    {
        this.ctx = ctx!;
        this.ptr = ptr!;
    }
}
public multi_aff(aff arg_0)
{
    this.ctx = Context.DefaultInstance;
    this.ptr = Interop.isl_multi_aff_from_aff(Interop.isl_aff_copy(args[0].ptr))
    }
public multi_aff(space arg_0aff_list arg_1)
{
    this.ctx = Context.DefaultInstance;
    this.ptr = Interop.isl_multi_aff_from_aff_list(Interop.isl_space_copy(args[0].ptr), Interop.isl_aff_list_copy(args[1].ptr))
    }
public multi_aff(string arg_0)
{
    this.ctx = Context.DefaultInstance;
    this.ptr = Interop.isl_multi_aff_read_from_str(this.ctx, args[0].encode('ascii'))
    }
public Dispose()
{
    if (ptr is not null)
    {
        isl.isl_multi_aff_free(ptr);
    }
}
public override ToString() {
    IntPtr char_p = isl.isl_multi_aff_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
    Marshal.FreeHGlobal(ptr);
    return res;
}
public Pointer add(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_multi_aff_add(Interop.isl_multi_aff_copy(arg0.ptr), Interop.isl_multi_aff_copy(arg1.ptr));
    var obj = new multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer add_constant(multi_val arg_1)
{
    var res = Interop.isl_multi_aff_add_constant_multi_val(Interop.isl_multi_aff_copy(args[0].ptr), Interop.isl_multi_val_copy(args[1].ptr));
    var obj = new multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer add_constant(val arg_1)
{
    var res = Interop.isl_multi_aff_add_constant_val(Interop.isl_multi_aff_copy(args[0].ptr), Interop.isl_val_copy(args[1].ptr));
    var obj = new multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer as_map(Pointer arg0)
{
    var res = Interop.isl_multi_aff_as_map(Interop.isl_multi_aff_copy(arg0.ptr));
    var obj = new map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer as_set(Pointer arg0)
{
    var res = Interop.isl_multi_aff_as_set(Interop.isl_multi_aff_copy(arg0.ptr));
    var obj = new set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer at(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_multi_aff_get_at(arg0.ptr, arg1);
    var obj = new aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer bind(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_multi_aff_bind(Interop.isl_multi_aff_copy(arg0.ptr), Interop.isl_multi_id_copy(arg1.ptr));
    var obj = new basic_set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer bind_domain(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_multi_aff_bind_domain(Interop.isl_multi_aff_copy(arg0.ptr), Interop.isl_multi_id_copy(arg1.ptr));
    var obj = new multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer bind_domain_wrapped_domain(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_multi_aff_bind_domain_wrapped_domain(Interop.isl_multi_aff_copy(arg0.ptr), Interop.isl_multi_id_copy(arg1.ptr));
    var obj = new multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer constant_multi_val(Pointer arg0)
{
    var res = Interop.isl_multi_aff_get_constant_multi_val(arg0.ptr);
    var obj = new multi_val(ctx = ctx, ptr = res);
    return obj;
}
public static Pointer domain_map(Pointer arg0)
{
    var res = Interop.isl_multi_aff_domain_map(Interop.isl_space_copy(arg0.ptr));
    var obj = new multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer domain_reverse(Pointer arg0)
{
    var res = Interop.isl_multi_aff_domain_reverse(Interop.isl_multi_aff_copy(arg0.ptr));
    var obj = new multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer flat_range_product(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_multi_aff_flat_range_product(Interop.isl_multi_aff_copy(arg0.ptr), Interop.isl_multi_aff_copy(arg1.ptr));
    var obj = new multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer floor(Pointer arg0)
{
    var res = Interop.isl_multi_aff_floor(Interop.isl_multi_aff_copy(arg0.ptr));
    var obj = new multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer gist(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_multi_aff_gist(Interop.isl_multi_aff_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
    var obj = new multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer gist_params(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_multi_aff_gist_params(Interop.isl_multi_aff_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
    var obj = new multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Typedef has_range_tuple_id(Pointer arg0)
{
    var res = Interop.isl_multi_aff_has_range_tuple_id(arg0.ptr);
    if (res < 0)
    {
        throw new InvalidOperationException();
    }
    return res;
}
public Pointer identity()
{
    var res = Interop.isl_multi_aff_identity_multi_aff(Interop.isl_multi_aff_copy(args[0].ptr));
    var obj = new multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public static Pointer identity_on_domain(space arg_0)
{
    var res = Interop.isl_multi_aff_identity_on_domain_space(Interop.isl_space_copy(args[0].ptr));
    var obj = new multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer insert_domain(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_multi_aff_insert_domain(Interop.isl_multi_aff_copy(arg0.ptr), Interop.isl_space_copy(arg1.ptr));
    var obj = new multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Typedef involves_locals(Pointer arg0)
{
    var res = Interop.isl_multi_aff_involves_locals(arg0.ptr);
    if (res < 0)
    {
        throw new InvalidOperationException();
    }
    return res;
}
public Typedef involves_nan(Pointer arg0)
{
    var res = Interop.isl_multi_aff_involves_nan(arg0.ptr);
    if (res < 0)
    {
        throw new InvalidOperationException();
    }
    return res;
}
public Pointer list(Pointer arg0)
{
    var res = Interop.isl_multi_aff_get_list(arg0.ptr);
    var obj = new aff_list(ctx = ctx, ptr = res);
    return obj;
}
public static Pointer multi_val_on_domain(space arg_0multi_val arg_1)
{
    var res = Interop.isl_multi_aff_multi_val_on_domain_space(Interop.isl_space_copy(args[0].ptr), Interop.isl_multi_val_copy(args[1].ptr));
    var obj = new multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer neg(Pointer arg0)
{
    var res = Interop.isl_multi_aff_neg(Interop.isl_multi_aff_copy(arg0.ptr));
    var obj = new multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Typedef plain_is_equal(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_multi_aff_plain_is_equal(arg0.ptr, arg1.ptr);
    if (res < 0)
    {
        throw new InvalidOperationException();
    }
    return res;
}
public Pointer product(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_multi_aff_product(Interop.isl_multi_aff_copy(arg0.ptr), Interop.isl_multi_aff_copy(arg1.ptr));
    var obj = new multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer pullback(multi_aff arg_1)
{
    var res = Interop.isl_multi_aff_pullback_multi_aff(Interop.isl_multi_aff_copy(args[0].ptr), Interop.isl_multi_aff_copy(args[1].ptr));
    var obj = new multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public static Pointer range_map(Pointer arg0)
{
    var res = Interop.isl_multi_aff_range_map(Interop.isl_space_copy(arg0.ptr));
    var obj = new multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer range_product(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_multi_aff_range_product(Interop.isl_multi_aff_copy(arg0.ptr), Interop.isl_multi_aff_copy(arg1.ptr));
    var obj = new multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer range_tuple_id(Pointer arg0)
{
    var res = Interop.isl_multi_aff_get_range_tuple_id(arg0.ptr);
    var obj = new id(ctx = ctx, ptr = res);
    return obj;
}
public Pointer reset_range_tuple_id(Pointer arg0)
{
    var res = Interop.isl_multi_aff_reset_range_tuple_id(Interop.isl_multi_aff_copy(arg0.ptr));
    var obj = new multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer scale(multi_val arg_1)
{
    var res = Interop.isl_multi_aff_scale_multi_val(Interop.isl_multi_aff_copy(args[0].ptr), Interop.isl_multi_val_copy(args[1].ptr));
    var obj = new multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer scale(val arg_1)
{
    var res = Interop.isl_multi_aff_scale_val(Interop.isl_multi_aff_copy(args[0].ptr), Interop.isl_val_copy(args[1].ptr));
    var obj = new multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer scale_down(multi_val arg_1)
{
    var res = Interop.isl_multi_aff_scale_down_multi_val(Interop.isl_multi_aff_copy(args[0].ptr), Interop.isl_multi_val_copy(args[1].ptr));
    var obj = new multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer scale_down(val arg_1)
{
    var res = Interop.isl_multi_aff_scale_down_val(Interop.isl_multi_aff_copy(args[0].ptr), Interop.isl_val_copy(args[1].ptr));
    var obj = new multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer set_at(Pointer arg0, Pointer arg1, Pointer arg2)
{
    var res = Interop.isl_multi_aff_set_at(Interop.isl_multi_aff_copy(arg0.ptr), arg1, Interop.isl_aff_copy(arg2.ptr));
    var obj = new multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer set_range_tuple(id arg_1)
{
    var res = Interop.isl_multi_aff_set_range_tuple_id(Interop.isl_multi_aff_copy(args[0].ptr), Interop.isl_id_copy(args[1].ptr));
    var obj = new multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Typedef size(Pointer arg0)
{
    var res = Interop.isl_multi_aff_size(arg0.ptr);
    if (res < 0)
    {
        throw new InvalidOperationException();
    }
    return res;
}
public Pointer space(Pointer arg0)
{
    var res = Interop.isl_multi_aff_get_space(arg0.ptr);
    var obj = new space(ctx = ctx, ptr = res);
    return obj;
}
public Pointer sub(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_multi_aff_sub(Interop.isl_multi_aff_copy(arg0.ptr), Interop.isl_multi_aff_copy(arg1.ptr));
    var obj = new multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer to_multi_pw_aff(Pointer arg0)
{
    var res = Interop.isl_multi_aff_to_multi_pw_aff(Interop.isl_multi_aff_copy(arg0.ptr));
    var obj = new multi_pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer to_multi_union_pw_aff(Pointer arg0)
{
    var res = Interop.isl_multi_aff_to_multi_union_pw_aff(Interop.isl_multi_aff_copy(arg0.ptr));
    var obj = new multi_union_pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer to_pw_multi_aff(Pointer arg0)
{
    var res = Interop.isl_multi_aff_to_pw_multi_aff(Interop.isl_multi_aff_copy(arg0.ptr));
    var obj = new pw_multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer unbind_params_insert_domain(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_multi_aff_unbind_params_insert_domain(Interop.isl_multi_aff_copy(arg0.ptr), Interop.isl_multi_id_copy(arg1.ptr));
    var obj = new multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public static Pointer zero(Pointer arg0)
{
    var res = Interop.isl_multi_aff_zero(Interop.isl_space_copy(arg0.ptr));
    var obj = new multi_aff(ctx = ctx, ptr = res);
    return obj;
}
}
internal static partial class Interop
{
    public static extern IntPtr isl_multi_aff_from_aff(IntPtr arg0);
    public static extern IntPtr isl_multi_aff_from_aff_list(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_aff_read_from_str(Context arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_aff_add(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_aff_add_constant_multi_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_aff_add_constant_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_aff_as_map(IntPtr arg0);
    public static extern IntPtr isl_multi_aff_as_set(IntPtr arg0);
    public static extern IntPtr isl_multi_aff_get_at(IntPtr arg0, int arg1);
    public static extern IntPtr isl_multi_aff_bind(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_aff_bind_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_aff_bind_domain_wrapped_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_aff_get_constant_multi_val(IntPtr arg0);
    public static extern IntPtr isl_multi_aff_domain_map(IntPtr arg0);
    public static extern IntPtr isl_multi_aff_domain_reverse(IntPtr arg0);
    public static extern IntPtr isl_multi_aff_flat_range_product(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_aff_floor(IntPtr arg0);
    public static extern IntPtr isl_multi_aff_gist(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_aff_gist_params(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_aff_has_range_tuple_id(IntPtr arg0);
    public static extern IntPtr isl_multi_aff_identity_multi_aff(IntPtr arg0);
    public static extern IntPtr isl_multi_aff_identity_on_domain_space(IntPtr arg0);
    public static extern IntPtr isl_multi_aff_insert_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_aff_involves_locals(IntPtr arg0);
    public static extern IntPtr isl_multi_aff_involves_nan(IntPtr arg0);
    public static extern IntPtr isl_multi_aff_get_list(IntPtr arg0);
    public static extern IntPtr isl_multi_aff_multi_val_on_domain_space(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_aff_neg(IntPtr arg0);
    public static extern IntPtr isl_multi_aff_plain_is_equal(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_aff_product(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_aff_pullback_multi_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_aff_range_map(IntPtr arg0);
    public static extern IntPtr isl_multi_aff_range_product(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_aff_get_range_tuple_id(IntPtr arg0);
    public static extern IntPtr isl_multi_aff_reset_range_tuple_id(IntPtr arg0);
    public static extern IntPtr isl_multi_aff_scale_multi_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_aff_scale_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_aff_scale_down_multi_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_aff_scale_down_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_aff_set_at(IntPtr arg0, int arg1, IntPtr arg2);
    public static extern IntPtr isl_multi_aff_set_range_tuple_id(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_aff_size(IntPtr arg0);
    public static extern IntPtr isl_multi_aff_get_space(IntPtr arg0);
    public static extern IntPtr isl_multi_aff_sub(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_aff_to_multi_pw_aff(IntPtr arg0);
    public static extern IntPtr isl_multi_aff_to_multi_union_pw_aff(IntPtr arg0);
    public static extern IntPtr isl_multi_aff_to_pw_multi_aff(IntPtr arg0);
    public static extern IntPtr isl_multi_aff_unbind_params_insert_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_aff_zero(IntPtr arg0);
    public static extern IntPtr isl_multi_aff_copy(IntPtr arg0);
    public static extern IntPtr isl_multi_aff_free(IntPtr arg0);
    public static extern IntPtr isl_multi_aff_to_str(IntPtr arg0);
}

public class affpw_aff, multi_aff{
    private Context ctx;
private IntPtr ptr;
public aff(isl_context? ctx = null, IntPtr? ptr = null)
{
    if (ptr is not null)
    {
        this.ctx = ctx!;
        this.ptr = ptr!;
    }
}
public aff(string arg_0)
{
    this.ctx = Context.DefaultInstance;
    this.ptr = Interop.isl_aff_read_from_str(this.ctx, args[0].encode('ascii'))
    }
public Dispose()
{
    if (ptr is not null)
    {
        isl.isl_aff_free(ptr);
    }
}
public override ToString() {
    IntPtr char_p = isl.isl_aff_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
    Marshal.FreeHGlobal(ptr);
    return res;
}
public Pointer add(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_aff_add(Interop.isl_aff_copy(arg0.ptr), Interop.isl_aff_copy(arg1.ptr));
    var obj = new aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer add_constant(val arg_1)
{
    var res = Interop.isl_aff_add_constant_val(Interop.isl_aff_copy(args[0].ptr), Interop.isl_val_copy(args[1].ptr));
    var obj = new aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer bind(id arg_1)
{
    var res = Interop.isl_aff_bind_id(Interop.isl_aff_copy(args[0].ptr), Interop.isl_id_copy(args[1].ptr));
    var obj = new basic_set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer ceil(Pointer arg0)
{
    var res = Interop.isl_aff_ceil(Interop.isl_aff_copy(arg0.ptr));
    var obj = new aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer constant_val(Pointer arg0)
{
    var res = Interop.isl_aff_get_constant_val(arg0.ptr);
    var obj = new val(ctx = ctx, ptr = res);
    return obj;
}
public Pointer div(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_aff_div(Interop.isl_aff_copy(arg0.ptr), Interop.isl_aff_copy(arg1.ptr));
    var obj = new aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer domain_reverse(Pointer arg0)
{
    var res = Interop.isl_aff_domain_reverse(Interop.isl_aff_copy(arg0.ptr));
    var obj = new aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer eq_set(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_aff_eq_set(Interop.isl_aff_copy(arg0.ptr), Interop.isl_aff_copy(arg1.ptr));
    var obj = new set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer eval(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_aff_eval(Interop.isl_aff_copy(arg0.ptr), Interop.isl_point_copy(arg1.ptr));
    var obj = new val(ctx = ctx, ptr = res);
    return obj;
}
public Pointer floor(Pointer arg0)
{
    var res = Interop.isl_aff_floor(Interop.isl_aff_copy(arg0.ptr));
    var obj = new aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer ge_set(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_aff_ge_set(Interop.isl_aff_copy(arg0.ptr), Interop.isl_aff_copy(arg1.ptr));
    var obj = new set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer gist(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_aff_gist(Interop.isl_aff_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
    var obj = new aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer gist_params(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_aff_gist_params(Interop.isl_aff_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
    var obj = new aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer gt_set(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_aff_gt_set(Interop.isl_aff_copy(arg0.ptr), Interop.isl_aff_copy(arg1.ptr));
    var obj = new set(ctx = ctx, ptr = res);
    return obj;
}
public Typedef is_cst(Pointer arg0)
{
    var res = Interop.isl_aff_is_cst(arg0.ptr);
    if (res < 0)
    {
        throw new InvalidOperationException();
    }
    return res;
}
public Pointer le_set(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_aff_le_set(Interop.isl_aff_copy(arg0.ptr), Interop.isl_aff_copy(arg1.ptr));
    var obj = new set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer lt_set(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_aff_lt_set(Interop.isl_aff_copy(arg0.ptr), Interop.isl_aff_copy(arg1.ptr));
    var obj = new set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer mod(val arg_1)
{
    var res = Interop.isl_aff_mod_val(Interop.isl_aff_copy(args[0].ptr), Interop.isl_val_copy(args[1].ptr));
    var obj = new aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer mul(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_aff_mul(Interop.isl_aff_copy(arg0.ptr), Interop.isl_aff_copy(arg1.ptr));
    var obj = new aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer ne_set(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_aff_ne_set(Interop.isl_aff_copy(arg0.ptr), Interop.isl_aff_copy(arg1.ptr));
    var obj = new set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer neg(Pointer arg0)
{
    var res = Interop.isl_aff_neg(Interop.isl_aff_copy(arg0.ptr));
    var obj = new aff(ctx = ctx, ptr = res);
    return obj;
}
public Typedef plain_is_equal(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_aff_plain_is_equal(arg0.ptr, arg1.ptr);
    if (res < 0)
    {
        throw new InvalidOperationException();
    }
    return res;
}
public Pointer pullback(multi_aff arg_1)
{
    var res = Interop.isl_aff_pullback_multi_aff(Interop.isl_aff_copy(args[0].ptr), Interop.isl_multi_aff_copy(args[1].ptr));
    var obj = new aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer scale(val arg_1)
{
    var res = Interop.isl_aff_scale_val(Interop.isl_aff_copy(args[0].ptr), Interop.isl_val_copy(args[1].ptr));
    var obj = new aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer scale_down(val arg_1)
{
    var res = Interop.isl_aff_scale_down_val(Interop.isl_aff_copy(args[0].ptr), Interop.isl_val_copy(args[1].ptr));
    var obj = new aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer sub(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_aff_sub(Interop.isl_aff_copy(arg0.ptr), Interop.isl_aff_copy(arg1.ptr));
    var obj = new aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer to_list(Pointer arg0)
{
    var res = Interop.isl_aff_to_list(Interop.isl_aff_copy(arg0.ptr));
    var obj = new aff_list(ctx = ctx, ptr = res);
    return obj;
}
public Pointer unbind_params_insert_domain(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_aff_unbind_params_insert_domain(Interop.isl_aff_copy(arg0.ptr), Interop.isl_multi_id_copy(arg1.ptr));
    var obj = new aff(ctx = ctx, ptr = res);
    return obj;
}
public static Pointer zero_on_domain(space arg_0)
{
    var res = Interop.isl_aff_zero_on_domain_space(Interop.isl_space_copy(args[0].ptr));
    var obj = new aff(ctx = ctx, ptr = res);
    return obj;
}
}
internal static partial class Interop
{
    public static extern IntPtr isl_aff_read_from_str(Context arg0, IntPtr arg1);
    public static extern IntPtr isl_aff_add(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_aff_add_constant_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_aff_bind_id(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_aff_ceil(IntPtr arg0);
    public static extern IntPtr isl_aff_get_constant_val(IntPtr arg0);
    public static extern IntPtr isl_aff_div(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_aff_domain_reverse(IntPtr arg0);
    public static extern IntPtr isl_aff_eq_set(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_aff_eval(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_aff_floor(IntPtr arg0);
    public static extern IntPtr isl_aff_ge_set(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_aff_gist(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_aff_gist_params(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_aff_gt_set(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_aff_is_cst(IntPtr arg0);
    public static extern IntPtr isl_aff_le_set(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_aff_lt_set(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_aff_mod_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_aff_mul(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_aff_ne_set(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_aff_neg(IntPtr arg0);
    public static extern IntPtr isl_aff_plain_is_equal(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_aff_pullback_multi_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_aff_scale_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_aff_scale_down_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_aff_sub(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_aff_to_list(IntPtr arg0);
    public static extern IntPtr isl_aff_unbind_params_insert_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_aff_zero_on_domain_space(IntPtr arg0);
    public static extern IntPtr isl_aff_copy(IntPtr arg0);
    public static extern IntPtr isl_aff_free(IntPtr arg0);
    public static extern IntPtr isl_aff_to_str(IntPtr arg0);
}

public class aff_list
{
    private Context ctx;
    private IntPtr ptr;
    public aff_list(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public aff_list(int args_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_aff_list_alloc(this.ctx, args[0])
    }
    public aff_list(aff arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_aff_list_from_aff(Interop.isl_aff_copy(args[0].ptr))
    }
    public aff_list(string arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_aff_list_read_from_str(this.ctx, args[0].encode('ascii'))
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_aff_list_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_aff_list_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer add(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_aff_list_add(Interop.isl_aff_list_copy(arg0.ptr), Interop.isl_aff_copy(arg1.ptr));
        var obj = new aff_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer at(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_aff_list_get_at(arg0.ptr, arg1);
        var obj = new aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer clear(Pointer arg0)
    {
        var res = Interop.isl_aff_list_clear(Interop.isl_aff_list_copy(arg0.ptr));
        var obj = new aff_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer concat(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_aff_list_concat(Interop.isl_aff_list_copy(arg0.ptr), Interop.isl_aff_list_copy(arg1.ptr));
        var obj = new aff_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer drop(Pointer arg0, Pointer arg1, Pointer arg2)
    {
        var res = Interop.isl_aff_list_drop(Interop.isl_aff_list_copy(arg0.ptr), arg1, arg2);
        var obj = new aff_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef foreach(Pointer arg0, Pointer arg1) {
        var exc_info = new Exception[1];
    var fn = (IntPtr cb_arg0, IntPtr user) =>
    {
        var cb_cls0 = new aff(ctx: arg0.ctx, ptr: (cb_arg0));
        try
        {
            arg1(cb_cls0);
        }
        catch (Exception e)
        {
            exc_info[0] = e;
            return -1;
        }
        return 0;
    };
    var cb1 = Marshal.GetFunctionPointerForDelegate(cb_func);
    var res = Interop.isl_aff_list_foreach(arg0.ptr, cb1, IntPtr.Zerp);
        if (exc_info[0] is not null) {
            throw exc_info[0];
        }
if (res < 0)
{
    throw new InvalidOperationException();
}
    }
    public Typedef foreach_scc(Pointer arg0, Pointer arg1, Pointer arg2)
{
    var exc_info = new Exception[1];
    var fn = (IntPtr cb_arg0, IntPtr cb_arg1, IntPtr user) =>
    {
        var cb_cls0 = new aff(ctx: arg0.ctx, ptr: Interop.isl_aff_copy(cb_arg0));
        var cb_cls1 = new aff(ctx: arg0.ctx, ptr: Interop.isl_aff_copy(cb_arg1));
        try
        {
            var res = arg1(cb_cls0, cb_cls1);
        }
        catch (Exception e)
        {
            exc_info[0] = e;
            return -1;
        }
        return res;
    };
    var cb1 = Marshal.GetFunctionPointerForDelegate(cb_func);
    var exc_info = new Exception[1];
    var fn = (IntPtr cb_arg0, IntPtr user) =>
    {
        var cb_cls0 = new aff_list(ctx: arg0.ctx, ptr: (cb_arg0));
        try
        {
            arg2(cb_cls0);
        }
        catch (Exception e)
        {
            exc_info[0] = e;
            return -1;
        }
        return 0;
    };
    var cb2 = Marshal.GetFunctionPointerForDelegate(cb_func);
    var res = Interop.isl_aff_list_foreach_scc(arg0.ptr, cb1, IntPtr.Zerp, cb2, IntPtr.Zerp);
    if (exc_info[0] is not null)
    {
        throw exc_info[0];
    }
    if (res < 0)
    {
        throw new InvalidOperationException();
    }
}
public Pointer insert(Pointer arg0, Pointer arg1, Pointer arg2)
{
    var res = Interop.isl_aff_list_insert(Interop.isl_aff_list_copy(arg0.ptr), arg1, Interop.isl_aff_copy(arg2.ptr));
    var obj = new aff_list(ctx = ctx, ptr = res);
    return obj;
}
public Pointer set_at(Pointer arg0, Pointer arg1, Pointer arg2)
{
    var res = Interop.isl_aff_list_set_at(Interop.isl_aff_list_copy(arg0.ptr), arg1, Interop.isl_aff_copy(arg2.ptr));
    var obj = new aff_list(ctx = ctx, ptr = res);
    return obj;
}
public Typedef size(Pointer arg0)
{
    var res = Interop.isl_aff_list_size(arg0.ptr);
    if (res < 0)
    {
        throw new InvalidOperationException();
    }
    return res;
}
}
internal static partial class Interop
{
    public static extern IntPtr isl_aff_list_alloc(Context arg0, int arg1);
    public static extern IntPtr isl_aff_list_from_aff(IntPtr arg0);
    public static extern IntPtr isl_aff_list_read_from_str(Context arg0, IntPtr arg1);
    public static extern IntPtr isl_aff_list_add(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_aff_list_get_at(IntPtr arg0, int arg1);
    public static extern IntPtr isl_aff_list_clear(IntPtr arg0);
    public static extern IntPtr isl_aff_list_concat(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_aff_list_drop(IntPtr arg0, int arg1, int arg2);
    public static extern IntPtr isl_aff_list_foreach(IntPtr arg0, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg1, IntPtr arg2);
    public static extern IntPtr isl_aff_list_foreach_scc(IntPtr arg0, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg1, IntPtr arg2, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg3, IntPtr arg4);
    public static extern IntPtr isl_aff_list_insert(IntPtr arg0, int arg1, IntPtr arg2);
    public static extern IntPtr isl_aff_list_set_at(IntPtr arg0, int arg1, IntPtr arg2);
    public static extern IntPtr isl_aff_list_size(IntPtr arg0);
    public static extern IntPtr isl_aff_list_copy(IntPtr arg0);
    public static extern IntPtr isl_aff_list_free(IntPtr arg0);
    public static extern IntPtr isl_aff_list_to_str(IntPtr arg0);
}

public class ast_build
{
    private Context ctx;
    private IntPtr ptr;
    public ast_build(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public ast_build()
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_ast_build_alloc(this.ctx)
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_ast_build_free(ptr);
        }
    }
    public void copy_callbacks(ast_build obj)
    {
        if (obj.at_each_domain is not null)
        {
            this.at_each_domain = obj.at_each_domain;
        }
    }
    public Pointer set_at_each_domain(Pointer arg0, Pointer arg1)
    {
        var exc_info = new Exception[1];
        var fn = (IntPtr cb_arg0, IntPtr cb_arg1, IntPtr user) =>
        {
            var cb_cls0 = new ast_node(ctx: arg0.ctx, ptr: (cb_arg0));
            var cb_cls1 = new ast_build(ctx: arg0.ctx, ptr: Interop.isl_ast_build_copy(cb_arg1));
            try
            {
                var res = arg1(cb_cls0, cb_cls1);
            }
            catch (Exception e)
            {
                exc_info[0] = e;
                return IntPtr.Zero;
            }
            return Interop.isl_ast_node_copy(res.ptr);
        };
        var cb1 = Marshal.GetFunctionPointerForDelegate(cb_func);
        var res = Interop.isl_ast_build_set_at_each_domain(Interop.isl_ast_build_copy(arg0.ptr), cb1, IntPtr.Zerp);
        if (exc_info[0] is not null)
        {
            throw exc_info[0];
        }
        if hasattr(arg0, 'at_each_domain') and arg0.at_each_domain['exc_info'] != None:
            exc_info = arg0.at_each_domain['exc_info'][0]
            arg0.at_each_domain['exc_info'][0] = None
            if (exc_info is not null)
        {
            throw exc_info;
        }
        var obj = new ast_build(ctx = ctx, ptr = res);
        obj.copy_callbacks(arg0);
        obj.at_each_domain = new CallBackInfo(cb1, exc_info);
        return obj;
    }
    public Pointer access_from(multi_pw_aff arg_1)
    {
        var res = Interop.isl_ast_build_access_from_multi_pw_aff(args[0].ptr, Interop.isl_multi_pw_aff_copy(args[1].ptr));
        if hasattr(args[0], 'at_each_domain') and args[0].at_each_domain['exc_info'] != None:
                exc_info = args[0].at_each_domain['exc_info'][0]
                args[0].at_each_domain['exc_info'][0] = None
                if (exc_info is not null)
        {
            throw exc_info;
        }
        var obj = new ast_expr(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer access_from(pw_multi_aff arg_1)
    {
        var res = Interop.isl_ast_build_access_from_pw_multi_aff(args[0].ptr, Interop.isl_pw_multi_aff_copy(args[1].ptr));
        if hasattr(args[0], 'at_each_domain') and args[0].at_each_domain['exc_info'] != None:
                exc_info = args[0].at_each_domain['exc_info'][0]
                args[0].at_each_domain['exc_info'][0] = None
                if (exc_info is not null)
        {
            throw exc_info;
        }
        var obj = new ast_expr(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer call_from(multi_pw_aff arg_1)
    {
        var res = Interop.isl_ast_build_call_from_multi_pw_aff(args[0].ptr, Interop.isl_multi_pw_aff_copy(args[1].ptr));
        if hasattr(args[0], 'at_each_domain') and args[0].at_each_domain['exc_info'] != None:
                exc_info = args[0].at_each_domain['exc_info'][0]
                args[0].at_each_domain['exc_info'][0] = None
                if (exc_info is not null)
        {
            throw exc_info;
        }
        var obj = new ast_expr(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer call_from(pw_multi_aff arg_1)
    {
        var res = Interop.isl_ast_build_call_from_pw_multi_aff(args[0].ptr, Interop.isl_pw_multi_aff_copy(args[1].ptr));
        if hasattr(args[0], 'at_each_domain') and args[0].at_each_domain['exc_info'] != None:
                exc_info = args[0].at_each_domain['exc_info'][0]
                args[0].at_each_domain['exc_info'][0] = None
                if (exc_info is not null)
        {
            throw exc_info;
        }
        var obj = new ast_expr(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer expr_from(pw_aff arg_1)
    {
        var res = Interop.isl_ast_build_expr_from_pw_aff(args[0].ptr, Interop.isl_pw_aff_copy(args[1].ptr));
        if hasattr(args[0], 'at_each_domain') and args[0].at_each_domain['exc_info'] != None:
                exc_info = args[0].at_each_domain['exc_info'][0]
                args[0].at_each_domain['exc_info'][0] = None
                if (exc_info is not null)
        {
            throw exc_info;
        }
        var obj = new ast_expr(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer expr_from(set arg_1)
    {
        var res = Interop.isl_ast_build_expr_from_set(args[0].ptr, Interop.isl_set_copy(args[1].ptr));
        if hasattr(args[0], 'at_each_domain') and args[0].at_each_domain['exc_info'] != None:
                exc_info = args[0].at_each_domain['exc_info'][0]
                args[0].at_each_domain['exc_info'][0] = None
                if (exc_info is not null)
        {
            throw exc_info;
        }
        var obj = new ast_expr(ctx = ctx, ptr = res);
        return obj;
    }
    public static Pointer from_context(Pointer arg0)
    {
        var res = Interop.isl_ast_build_from_context(Interop.isl_set_copy(arg0.ptr));
        var obj = new ast_build(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer node_from(schedule arg_1)
    {
        var res = Interop.isl_ast_build_node_from_schedule(args[0].ptr, Interop.isl_schedule_copy(args[1].ptr));
        if hasattr(args[0], 'at_each_domain') and args[0].at_each_domain['exc_info'] != None:
                exc_info = args[0].at_each_domain['exc_info'][0]
                args[0].at_each_domain['exc_info'][0] = None
                if (exc_info is not null)
        {
            throw exc_info;
        }
        var obj = new ast_node(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer node_from_schedule_map(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_ast_build_node_from_schedule_map(arg0.ptr, Interop.isl_union_map_copy(arg1.ptr));
        if hasattr(arg0, 'at_each_domain') and arg0.at_each_domain['exc_info'] != None:
            exc_info = arg0.at_each_domain['exc_info'][0]
            arg0.at_each_domain['exc_info'][0] = None
            if (exc_info is not null)
        {
            throw exc_info;
        }
        var obj = new ast_node(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer schedule(Pointer arg0)
    {
        var res = Interop.isl_ast_build_get_schedule(arg0.ptr);
        if hasattr(arg0, 'at_each_domain') and arg0.at_each_domain['exc_info'] != None:
            exc_info = arg0.at_each_domain['exc_info'][0]
            arg0.at_each_domain['exc_info'][0] = None
            if (exc_info is not null)
        {
            throw exc_info;
        }
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_ast_build_alloc(Context arg0);
    public static extern IntPtr isl_ast_build_set_at_each_domain(IntPtr arg0, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg1, IntPtr arg2);
    public static extern IntPtr isl_ast_build_access_from_multi_pw_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_ast_build_access_from_pw_multi_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_ast_build_call_from_multi_pw_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_ast_build_call_from_pw_multi_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_ast_build_expr_from_pw_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_ast_build_expr_from_set(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_ast_build_from_context(IntPtr arg0);
    public static extern IntPtr isl_ast_build_node_from_schedule(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_ast_build_node_from_schedule_map(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_ast_build_get_schedule(IntPtr arg0);
    public static extern IntPtr isl_ast_build_copy(IntPtr arg0);
    public static extern IntPtr isl_ast_build_free(IntPtr arg0);
}

public class ast_expr
{
    private Context ctx;
    private IntPtr ptr;
    public ast_expr(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public ast_expr(ast_expr_op arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_ast_expr_copy(arg0.ptr);
    }
    public ast_expr(ast_expr_id arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_ast_expr_copy(arg0.ptr);
    }
    public ast_expr(ast_expr_int arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_ast_expr_copy(arg0.ptr);
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_ast_expr_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_ast_expr_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer to_C_str(Pointer arg0)
    {
        var res = Interop.isl_ast_expr_to_C_str(arg0.ptr);
        if (res == IntPtr.Zero)
        {
            throw new InvalidOperationException();
        }
        var str = Marshal.PtrToStringAnsi(res);
        Marshal.FreeHGlobal(res);
        return str;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_ast_expr_to_C_str(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_copy(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_free(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_to_str(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_get_type(IntPtr arg0);
}

public class ast_expr_id : ast_expr
{
    private Context ctx;
    private IntPtr ptr;
    public ast_expr_id(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_ast_expr_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_ast_expr_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer id(Pointer arg0)
    {
        var res = Interop.isl_ast_expr_id_get_id(arg0.ptr);
        var obj = new id(ctx = ctx, ptr = res);
        return obj;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_ast_expr_id_get_id(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_copy(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_free(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_to_str(IntPtr arg0);
}

public class ast_expr_int : ast_expr
{
    private Context ctx;
    private IntPtr ptr;
    public ast_expr_int(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_ast_expr_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_ast_expr_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer val(Pointer arg0)
    {
        var res = Interop.isl_ast_expr_int_get_val(arg0.ptr);
        var obj = new val(ctx = ctx, ptr = res);
        return obj;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_ast_expr_int_get_val(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_copy(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_free(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_to_str(IntPtr arg0);
}

public class ast_expr_op : ast_expr
{
    private Context ctx;
    private IntPtr ptr;
    public ast_expr_op(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public ast_expr(ast_expr_op_and arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_ast_expr_copy(arg0.ptr);
    }
    public ast_expr(ast_expr_op_and_then arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_ast_expr_copy(arg0.ptr);
    }
    public ast_expr(ast_expr_op_or arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_ast_expr_copy(arg0.ptr);
    }
    public ast_expr(ast_expr_op_or_else arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_ast_expr_copy(arg0.ptr);
    }
    public ast_expr(ast_expr_op_max arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_ast_expr_copy(arg0.ptr);
    }
    public ast_expr(ast_expr_op_min arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_ast_expr_copy(arg0.ptr);
    }
    public ast_expr(ast_expr_op_minus arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_ast_expr_copy(arg0.ptr);
    }
    public ast_expr(ast_expr_op_add arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_ast_expr_copy(arg0.ptr);
    }
    public ast_expr(ast_expr_op_sub arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_ast_expr_copy(arg0.ptr);
    }
    public ast_expr(ast_expr_op_mul arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_ast_expr_copy(arg0.ptr);
    }
    public ast_expr(ast_expr_op_div arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_ast_expr_copy(arg0.ptr);
    }
    public ast_expr(ast_expr_op_fdiv_q arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_ast_expr_copy(arg0.ptr);
    }
    public ast_expr(ast_expr_op_pdiv_q arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_ast_expr_copy(arg0.ptr);
    }
    public ast_expr(ast_expr_op_pdiv_r arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_ast_expr_copy(arg0.ptr);
    }
    public ast_expr(ast_expr_op_zdiv_r arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_ast_expr_copy(arg0.ptr);
    }
    public ast_expr(ast_expr_op_cond arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_ast_expr_copy(arg0.ptr);
    }
    public ast_expr(ast_expr_op_select arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_ast_expr_copy(arg0.ptr);
    }
    public ast_expr(ast_expr_op_eq arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_ast_expr_copy(arg0.ptr);
    }
    public ast_expr(ast_expr_op_le arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_ast_expr_copy(arg0.ptr);
    }
    public ast_expr(ast_expr_op_lt arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_ast_expr_copy(arg0.ptr);
    }
    public ast_expr(ast_expr_op_ge arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_ast_expr_copy(arg0.ptr);
    }
    public ast_expr(ast_expr_op_gt arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_ast_expr_copy(arg0.ptr);
    }
    public ast_expr(ast_expr_op_call arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_ast_expr_copy(arg0.ptr);
    }
    public ast_expr(ast_expr_op_access arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_ast_expr_copy(arg0.ptr);
    }
    public ast_expr(ast_expr_op_member arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_ast_expr_copy(arg0.ptr);
    }
    public ast_expr(ast_expr_op_address_of arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_ast_expr_copy(arg0.ptr);
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_ast_expr_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_ast_expr_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer arg(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_ast_expr_op_get_arg(arg0.ptr, arg1);
        var obj = new ast_expr(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef n_arg(Pointer arg0)
    {
        var res = Interop.isl_ast_expr_op_get_n_arg(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_ast_expr_op_get_arg(IntPtr arg0, int arg1);
    public static extern IntPtr isl_ast_expr_op_get_n_arg(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_copy(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_free(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_to_str(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_op_get_type(IntPtr arg0);
}

public class ast_expr_op_access : ast_expr_op
{
    private Context ctx;
    private IntPtr ptr;
    public ast_expr_op_access(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_ast_expr_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_ast_expr_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_ast_expr_copy(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_free(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_to_str(IntPtr arg0);
}

public class ast_expr_op_add : ast_expr_op
{
    private Context ctx;
    private IntPtr ptr;
    public ast_expr_op_add(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_ast_expr_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_ast_expr_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_ast_expr_copy(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_free(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_to_str(IntPtr arg0);
}

public class ast_expr_op_address_of : ast_expr_op
{
    private Context ctx;
    private IntPtr ptr;
    public ast_expr_op_address_of(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_ast_expr_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_ast_expr_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_ast_expr_copy(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_free(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_to_str(IntPtr arg0);
}

public class ast_expr_op_and : ast_expr_op
{
    private Context ctx;
    private IntPtr ptr;
    public ast_expr_op_and(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_ast_expr_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_ast_expr_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_ast_expr_copy(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_free(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_to_str(IntPtr arg0);
}

public class ast_expr_op_and_then : ast_expr_op
{
    private Context ctx;
    private IntPtr ptr;
    public ast_expr_op_and_then(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_ast_expr_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_ast_expr_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_ast_expr_copy(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_free(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_to_str(IntPtr arg0);
}

public class ast_expr_op_call : ast_expr_op
{
    private Context ctx;
    private IntPtr ptr;
    public ast_expr_op_call(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_ast_expr_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_ast_expr_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_ast_expr_copy(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_free(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_to_str(IntPtr arg0);
}

public class ast_expr_op_cond : ast_expr_op
{
    private Context ctx;
    private IntPtr ptr;
    public ast_expr_op_cond(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_ast_expr_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_ast_expr_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_ast_expr_copy(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_free(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_to_str(IntPtr arg0);
}

public class ast_expr_op_div : ast_expr_op
{
    private Context ctx;
    private IntPtr ptr;
    public ast_expr_op_div(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_ast_expr_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_ast_expr_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_ast_expr_copy(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_free(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_to_str(IntPtr arg0);
}

public class ast_expr_op_eq : ast_expr_op
{
    private Context ctx;
    private IntPtr ptr;
    public ast_expr_op_eq(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_ast_expr_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_ast_expr_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_ast_expr_copy(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_free(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_to_str(IntPtr arg0);
}

public class ast_expr_op_fdiv_q : ast_expr_op
{
    private Context ctx;
    private IntPtr ptr;
    public ast_expr_op_fdiv_q(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_ast_expr_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_ast_expr_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_ast_expr_copy(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_free(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_to_str(IntPtr arg0);
}

public class ast_expr_op_ge : ast_expr_op
{
    private Context ctx;
    private IntPtr ptr;
    public ast_expr_op_ge(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_ast_expr_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_ast_expr_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_ast_expr_copy(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_free(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_to_str(IntPtr arg0);
}

public class ast_expr_op_gt : ast_expr_op
{
    private Context ctx;
    private IntPtr ptr;
    public ast_expr_op_gt(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_ast_expr_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_ast_expr_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_ast_expr_copy(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_free(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_to_str(IntPtr arg0);
}

public class ast_expr_op_le : ast_expr_op
{
    private Context ctx;
    private IntPtr ptr;
    public ast_expr_op_le(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_ast_expr_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_ast_expr_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_ast_expr_copy(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_free(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_to_str(IntPtr arg0);
}

public class ast_expr_op_lt : ast_expr_op
{
    private Context ctx;
    private IntPtr ptr;
    public ast_expr_op_lt(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_ast_expr_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_ast_expr_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_ast_expr_copy(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_free(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_to_str(IntPtr arg0);
}

public class ast_expr_op_max : ast_expr_op
{
    private Context ctx;
    private IntPtr ptr;
    public ast_expr_op_max(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_ast_expr_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_ast_expr_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_ast_expr_copy(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_free(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_to_str(IntPtr arg0);
}

public class ast_expr_op_member : ast_expr_op
{
    private Context ctx;
    private IntPtr ptr;
    public ast_expr_op_member(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_ast_expr_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_ast_expr_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_ast_expr_copy(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_free(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_to_str(IntPtr arg0);
}

public class ast_expr_op_min : ast_expr_op
{
    private Context ctx;
    private IntPtr ptr;
    public ast_expr_op_min(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_ast_expr_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_ast_expr_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_ast_expr_copy(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_free(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_to_str(IntPtr arg0);
}

public class ast_expr_op_minus : ast_expr_op
{
    private Context ctx;
    private IntPtr ptr;
    public ast_expr_op_minus(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_ast_expr_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_ast_expr_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_ast_expr_copy(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_free(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_to_str(IntPtr arg0);
}

public class ast_expr_op_mul : ast_expr_op
{
    private Context ctx;
    private IntPtr ptr;
    public ast_expr_op_mul(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_ast_expr_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_ast_expr_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_ast_expr_copy(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_free(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_to_str(IntPtr arg0);
}

public class ast_expr_op_or : ast_expr_op
{
    private Context ctx;
    private IntPtr ptr;
    public ast_expr_op_or(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_ast_expr_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_ast_expr_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_ast_expr_copy(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_free(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_to_str(IntPtr arg0);
}

public class ast_expr_op_or_else : ast_expr_op
{
    private Context ctx;
    private IntPtr ptr;
    public ast_expr_op_or_else(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_ast_expr_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_ast_expr_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_ast_expr_copy(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_free(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_to_str(IntPtr arg0);
}

public class ast_expr_op_pdiv_q : ast_expr_op
{
    private Context ctx;
    private IntPtr ptr;
    public ast_expr_op_pdiv_q(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_ast_expr_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_ast_expr_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_ast_expr_copy(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_free(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_to_str(IntPtr arg0);
}

public class ast_expr_op_pdiv_r : ast_expr_op
{
    private Context ctx;
    private IntPtr ptr;
    public ast_expr_op_pdiv_r(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_ast_expr_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_ast_expr_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_ast_expr_copy(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_free(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_to_str(IntPtr arg0);
}

public class ast_expr_op_select : ast_expr_op
{
    private Context ctx;
    private IntPtr ptr;
    public ast_expr_op_select(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_ast_expr_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_ast_expr_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_ast_expr_copy(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_free(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_to_str(IntPtr arg0);
}

public class ast_expr_op_sub : ast_expr_op
{
    private Context ctx;
    private IntPtr ptr;
    public ast_expr_op_sub(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_ast_expr_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_ast_expr_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_ast_expr_copy(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_free(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_to_str(IntPtr arg0);
}

public class ast_expr_op_zdiv_r : ast_expr_op
{
    private Context ctx;
    private IntPtr ptr;
    public ast_expr_op_zdiv_r(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_ast_expr_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_ast_expr_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_ast_expr_copy(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_free(IntPtr arg0);
    public static extern IntPtr isl_ast_expr_to_str(IntPtr arg0);
}

public class ast_node
{
    private Context ctx;
    private IntPtr ptr;
    public ast_node(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public ast_node(ast_node_for arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_ast_node_copy(arg0.ptr);
    }
    public ast_node(ast_node_if arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_ast_node_copy(arg0.ptr);
    }
    public ast_node(ast_node_block arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_ast_node_copy(arg0.ptr);
    }
    public ast_node(ast_node_mark arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_ast_node_copy(arg0.ptr);
    }
    public ast_node(ast_node_user arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_ast_node_copy(arg0.ptr);
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_ast_node_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_ast_node_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer map_descendant_bottom_up(Pointer arg0, Pointer arg1)
    {
        var exc_info = new Exception[1];
        var fn = (IntPtr cb_arg0, IntPtr user) =>
        {
            var cb_cls0 = new ast_node(ctx: arg0.ctx, ptr: (cb_arg0));
            try
            {
                var res = arg1(cb_cls0);
            }
            catch (Exception e)
            {
                exc_info[0] = e;
                return IntPtr.Zero;
            }
            return Interop.isl_ast_node_copy(res.ptr);
        };
        var cb1 = Marshal.GetFunctionPointerForDelegate(cb_func);
        var res = Interop.isl_ast_node_map_descendant_bottom_up(Interop.isl_ast_node_copy(arg0.ptr), cb1, IntPtr.Zerp);
        if (exc_info[0] is not null)
        {
            throw exc_info[0];
        }
        var obj = new ast_node(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer to_C_str(Pointer arg0)
    {
        var res = Interop.isl_ast_node_to_C_str(arg0.ptr);
        if (res == IntPtr.Zero)
        {
            throw new InvalidOperationException();
        }
        var str = Marshal.PtrToStringAnsi(res);
        Marshal.FreeHGlobal(res);
        return str;
    }
    public Pointer to_list(Pointer arg0)
    {
        var res = Interop.isl_ast_node_to_list(Interop.isl_ast_node_copy(arg0.ptr));
        var obj = new ast_node_list(ctx = ctx, ptr = res);
        return obj;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_ast_node_map_descendant_bottom_up(IntPtr arg0, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg1, IntPtr arg2);
    public static extern IntPtr isl_ast_node_to_C_str(IntPtr arg0);
    public static extern IntPtr isl_ast_node_to_list(IntPtr arg0);
    public static extern IntPtr isl_ast_node_copy(IntPtr arg0);
    public static extern IntPtr isl_ast_node_free(IntPtr arg0);
    public static extern IntPtr isl_ast_node_to_str(IntPtr arg0);
    public static extern IntPtr isl_ast_node_get_type(IntPtr arg0);
}

public class ast_node_block : ast_node
{
    private Context ctx;
    private IntPtr ptr;
    public ast_node_block(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public ast_node_block(ast_node_list arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_ast_node_block_from_children(Interop.isl_ast_node_list_copy(args[0].ptr))
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_ast_node_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_ast_node_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer children(Pointer arg0)
    {
        var res = Interop.isl_ast_node_block_get_children(arg0.ptr);
        var obj = new ast_node_list(ctx = ctx, ptr = res);
        return obj;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_ast_node_block_from_children(IntPtr arg0);
    public static extern IntPtr isl_ast_node_block_get_children(IntPtr arg0);
    public static extern IntPtr isl_ast_node_copy(IntPtr arg0);
    public static extern IntPtr isl_ast_node_free(IntPtr arg0);
    public static extern IntPtr isl_ast_node_to_str(IntPtr arg0);
}

public class ast_node_for : ast_node
{
    private Context ctx;
    private IntPtr ptr;
    public ast_node_for(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_ast_node_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_ast_node_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer body(Pointer arg0)
    {
        var res = Interop.isl_ast_node_for_get_body(arg0.ptr);
        var obj = new ast_node(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer cond(Pointer arg0)
    {
        var res = Interop.isl_ast_node_for_get_cond(arg0.ptr);
        var obj = new ast_expr(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer inc(Pointer arg0)
    {
        var res = Interop.isl_ast_node_for_get_inc(arg0.ptr);
        var obj = new ast_expr(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer init(Pointer arg0)
    {
        var res = Interop.isl_ast_node_for_get_init(arg0.ptr);
        var obj = new ast_expr(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef is_degenerate(Pointer arg0)
    {
        var res = Interop.isl_ast_node_for_is_degenerate(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer iterator(Pointer arg0)
    {
        var res = Interop.isl_ast_node_for_get_iterator(arg0.ptr);
        var obj = new ast_expr(ctx = ctx, ptr = res);
        return obj;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_ast_node_for_get_body(IntPtr arg0);
    public static extern IntPtr isl_ast_node_for_get_cond(IntPtr arg0);
    public static extern IntPtr isl_ast_node_for_get_inc(IntPtr arg0);
    public static extern IntPtr isl_ast_node_for_get_init(IntPtr arg0);
    public static extern IntPtr isl_ast_node_for_is_degenerate(IntPtr arg0);
    public static extern IntPtr isl_ast_node_for_get_iterator(IntPtr arg0);
    public static extern IntPtr isl_ast_node_copy(IntPtr arg0);
    public static extern IntPtr isl_ast_node_free(IntPtr arg0);
    public static extern IntPtr isl_ast_node_to_str(IntPtr arg0);
}

public class ast_node_if : ast_node
{
    private Context ctx;
    private IntPtr ptr;
    public ast_node_if(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_ast_node_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_ast_node_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer cond(Pointer arg0)
    {
        var res = Interop.isl_ast_node_if_get_cond(arg0.ptr);
        var obj = new ast_expr(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer else_node(Pointer arg0)
    {
        var res = Interop.isl_ast_node_if_get_else_node(arg0.ptr);
        var obj = new ast_node(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef has_else_node(Pointer arg0)
    {
        var res = Interop.isl_ast_node_if_has_else_node(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer then_node(Pointer arg0)
    {
        var res = Interop.isl_ast_node_if_get_then_node(arg0.ptr);
        var obj = new ast_node(ctx = ctx, ptr = res);
        return obj;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_ast_node_if_get_cond(IntPtr arg0);
    public static extern IntPtr isl_ast_node_if_get_else_node(IntPtr arg0);
    public static extern IntPtr isl_ast_node_if_has_else_node(IntPtr arg0);
    public static extern IntPtr isl_ast_node_if_get_then_node(IntPtr arg0);
    public static extern IntPtr isl_ast_node_copy(IntPtr arg0);
    public static extern IntPtr isl_ast_node_free(IntPtr arg0);
    public static extern IntPtr isl_ast_node_to_str(IntPtr arg0);
}

public class ast_node_list
{
    private Context ctx;
    private IntPtr ptr;
    public ast_node_list(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public ast_node_list(int args_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_ast_node_list_alloc(this.ctx, args[0])
    }
    public ast_node_list(ast_node arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_ast_node_list_from_ast_node(Interop.isl_ast_node_copy(args[0].ptr))
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_ast_node_list_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_ast_node_list_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer add(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_ast_node_list_add(Interop.isl_ast_node_list_copy(arg0.ptr), Interop.isl_ast_node_copy(arg1.ptr));
        var obj = new ast_node_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer at(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_ast_node_list_get_at(arg0.ptr, arg1);
        var obj = new ast_node(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer clear(Pointer arg0)
    {
        var res = Interop.isl_ast_node_list_clear(Interop.isl_ast_node_list_copy(arg0.ptr));
        var obj = new ast_node_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer concat(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_ast_node_list_concat(Interop.isl_ast_node_list_copy(arg0.ptr), Interop.isl_ast_node_list_copy(arg1.ptr));
        var obj = new ast_node_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer drop(Pointer arg0, Pointer arg1, Pointer arg2)
    {
        var res = Interop.isl_ast_node_list_drop(Interop.isl_ast_node_list_copy(arg0.ptr), arg1, arg2);
        var obj = new ast_node_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef foreach(Pointer arg0, Pointer arg1) {
        var exc_info = new Exception[1];
    var fn = (IntPtr cb_arg0, IntPtr user) =>
    {
        var cb_cls0 = new ast_node(ctx: arg0.ctx, ptr: (cb_arg0));
        try
        {
            arg1(cb_cls0);
        }
        catch (Exception e)
        {
            exc_info[0] = e;
            return -1;
        }
        return 0;
    };
    var cb1 = Marshal.GetFunctionPointerForDelegate(cb_func);
    var res = Interop.isl_ast_node_list_foreach(arg0.ptr, cb1, IntPtr.Zerp);
        if (exc_info[0] is not null) {
            throw exc_info[0];
        }
if (res < 0)
{
    throw new InvalidOperationException();
}
    }
    public Typedef foreach_scc(Pointer arg0, Pointer arg1, Pointer arg2)
{
    var exc_info = new Exception[1];
    var fn = (IntPtr cb_arg0, IntPtr cb_arg1, IntPtr user) =>
    {
        var cb_cls0 = new ast_node(ctx: arg0.ctx, ptr: Interop.isl_ast_node_copy(cb_arg0));
        var cb_cls1 = new ast_node(ctx: arg0.ctx, ptr: Interop.isl_ast_node_copy(cb_arg1));
        try
        {
            var res = arg1(cb_cls0, cb_cls1);
        }
        catch (Exception e)
        {
            exc_info[0] = e;
            return -1;
        }
        return res;
    };
    var cb1 = Marshal.GetFunctionPointerForDelegate(cb_func);
    var exc_info = new Exception[1];
    var fn = (IntPtr cb_arg0, IntPtr user) =>
    {
        var cb_cls0 = new ast_node_list(ctx: arg0.ctx, ptr: (cb_arg0));
        try
        {
            arg2(cb_cls0);
        }
        catch (Exception e)
        {
            exc_info[0] = e;
            return -1;
        }
        return 0;
    };
    var cb2 = Marshal.GetFunctionPointerForDelegate(cb_func);
    var res = Interop.isl_ast_node_list_foreach_scc(arg0.ptr, cb1, IntPtr.Zerp, cb2, IntPtr.Zerp);
    if (exc_info[0] is not null)
    {
        throw exc_info[0];
    }
    if (res < 0)
    {
        throw new InvalidOperationException();
    }
}
public Pointer insert(Pointer arg0, Pointer arg1, Pointer arg2)
{
    var res = Interop.isl_ast_node_list_insert(Interop.isl_ast_node_list_copy(arg0.ptr), arg1, Interop.isl_ast_node_copy(arg2.ptr));
    var obj = new ast_node_list(ctx = ctx, ptr = res);
    return obj;
}
public Pointer set_at(Pointer arg0, Pointer arg1, Pointer arg2)
{
    var res = Interop.isl_ast_node_list_set_at(Interop.isl_ast_node_list_copy(arg0.ptr), arg1, Interop.isl_ast_node_copy(arg2.ptr));
    var obj = new ast_node_list(ctx = ctx, ptr = res);
    return obj;
}
public Typedef size(Pointer arg0)
{
    var res = Interop.isl_ast_node_list_size(arg0.ptr);
    if (res < 0)
    {
        throw new InvalidOperationException();
    }
    return res;
}
}
internal static partial class Interop
{
    public static extern IntPtr isl_ast_node_list_alloc(Context arg0, int arg1);
    public static extern IntPtr isl_ast_node_list_from_ast_node(IntPtr arg0);
    public static extern IntPtr isl_ast_node_list_add(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_ast_node_list_get_at(IntPtr arg0, int arg1);
    public static extern IntPtr isl_ast_node_list_clear(IntPtr arg0);
    public static extern IntPtr isl_ast_node_list_concat(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_ast_node_list_drop(IntPtr arg0, int arg1, int arg2);
    public static extern IntPtr isl_ast_node_list_foreach(IntPtr arg0, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg1, IntPtr arg2);
    public static extern IntPtr isl_ast_node_list_foreach_scc(IntPtr arg0, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg1, IntPtr arg2, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg3, IntPtr arg4);
    public static extern IntPtr isl_ast_node_list_insert(IntPtr arg0, int arg1, IntPtr arg2);
    public static extern IntPtr isl_ast_node_list_set_at(IntPtr arg0, int arg1, IntPtr arg2);
    public static extern IntPtr isl_ast_node_list_size(IntPtr arg0);
    public static extern IntPtr isl_ast_node_list_copy(IntPtr arg0);
    public static extern IntPtr isl_ast_node_list_free(IntPtr arg0);
    public static extern IntPtr isl_ast_node_list_to_str(IntPtr arg0);
}

public class ast_node_mark : ast_node
{
    private Context ctx;
    private IntPtr ptr;
    public ast_node_mark(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_ast_node_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_ast_node_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer id(Pointer arg0)
    {
        var res = Interop.isl_ast_node_mark_get_id(arg0.ptr);
        var obj = new id(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer node(Pointer arg0)
    {
        var res = Interop.isl_ast_node_mark_get_node(arg0.ptr);
        var obj = new ast_node(ctx = ctx, ptr = res);
        return obj;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_ast_node_mark_get_id(IntPtr arg0);
    public static extern IntPtr isl_ast_node_mark_get_node(IntPtr arg0);
    public static extern IntPtr isl_ast_node_copy(IntPtr arg0);
    public static extern IntPtr isl_ast_node_free(IntPtr arg0);
    public static extern IntPtr isl_ast_node_to_str(IntPtr arg0);
}

public class ast_node_user : ast_node
{
    private Context ctx;
    private IntPtr ptr;
    public ast_node_user(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public ast_node_user(ast_expr arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_ast_node_user_from_expr(Interop.isl_ast_expr_copy(args[0].ptr))
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_ast_node_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_ast_node_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer expr(Pointer arg0)
    {
        var res = Interop.isl_ast_node_user_get_expr(arg0.ptr);
        var obj = new ast_expr(ctx = ctx, ptr = res);
        return obj;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_ast_node_user_from_expr(IntPtr arg0);
    public static extern IntPtr isl_ast_node_user_get_expr(IntPtr arg0);
    public static extern IntPtr isl_ast_node_copy(IntPtr arg0);
    public static extern IntPtr isl_ast_node_free(IntPtr arg0);
    public static extern IntPtr isl_ast_node_to_str(IntPtr arg0);
}

public class union_map
{
    private Context ctx;
    private IntPtr ptr;
    public union_map(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public union_map(basic_map arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_union_map_from_basic_map(Interop.isl_basic_map_copy(args[0].ptr))
    }
    public union_map(map arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_union_map_from_map(Interop.isl_map_copy(args[0].ptr))
    }
    public union_map(string arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_union_map_read_from_str(this.ctx, args[0].encode('ascii'))
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_union_map_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_union_map_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer affine_hull(Pointer arg0)
    {
        var res = Interop.isl_union_map_affine_hull(Interop.isl_union_map_copy(arg0.ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer apply_domain(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_map_apply_domain(Interop.isl_union_map_copy(arg0.ptr), Interop.isl_union_map_copy(arg1.ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer apply_range(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_map_apply_range(Interop.isl_union_map_copy(arg0.ptr), Interop.isl_union_map_copy(arg1.ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer as_map(Pointer arg0)
    {
        var res = Interop.isl_union_map_as_map(Interop.isl_union_map_copy(arg0.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer as_multi_union_pw_aff(Pointer arg0)
    {
        var res = Interop.isl_union_map_as_multi_union_pw_aff(Interop.isl_union_map_copy(arg0.ptr));
        var obj = new multi_union_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer as_union_pw_multi_aff(Pointer arg0)
    {
        var res = Interop.isl_union_map_as_union_pw_multi_aff(Interop.isl_union_map_copy(arg0.ptr));
        var obj = new union_pw_multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer bind_range(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_map_bind_range(Interop.isl_union_map_copy(arg0.ptr), Interop.isl_multi_id_copy(arg1.ptr));
        var obj = new union_set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer coalesce(Pointer arg0)
    {
        var res = Interop.isl_union_map_coalesce(Interop.isl_union_map_copy(arg0.ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer compute_divs(Pointer arg0)
    {
        var res = Interop.isl_union_map_compute_divs(Interop.isl_union_map_copy(arg0.ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer curry(Pointer arg0)
    {
        var res = Interop.isl_union_map_curry(Interop.isl_union_map_copy(arg0.ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer deltas(Pointer arg0)
    {
        var res = Interop.isl_union_map_deltas(Interop.isl_union_map_copy(arg0.ptr));
        var obj = new union_set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer detect_equalities(Pointer arg0)
    {
        var res = Interop.isl_union_map_detect_equalities(Interop.isl_union_map_copy(arg0.ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer domain(Pointer arg0)
    {
        var res = Interop.isl_union_map_domain(Interop.isl_union_map_copy(arg0.ptr));
        var obj = new union_set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer domain_factor_domain(Pointer arg0)
    {
        var res = Interop.isl_union_map_domain_factor_domain(Interop.isl_union_map_copy(arg0.ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer domain_factor_range(Pointer arg0)
    {
        var res = Interop.isl_union_map_domain_factor_range(Interop.isl_union_map_copy(arg0.ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer domain_map(Pointer arg0)
    {
        var res = Interop.isl_union_map_domain_map(Interop.isl_union_map_copy(arg0.ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer domain_map_union_pw_multi_aff(Pointer arg0)
    {
        var res = Interop.isl_union_map_domain_map_union_pw_multi_aff(Interop.isl_union_map_copy(arg0.ptr));
        var obj = new union_pw_multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer domain_product(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_map_domain_product(Interop.isl_union_map_copy(arg0.ptr), Interop.isl_union_map_copy(arg1.ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer domain_reverse(Pointer arg0)
    {
        var res = Interop.isl_union_map_domain_reverse(Interop.isl_union_map_copy(arg0.ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer drop_unused_params(Pointer arg0)
    {
        var res = Interop.isl_union_map_drop_unused_params(Interop.isl_union_map_copy(arg0.ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public static Pointer empty()
    {
        var ctx = Context.DefaultInstance;
        var res = Interop.isl_union_map_empty_ctx(ctx);
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer eq_at(multi_union_pw_aff arg_1)
    {
        var res = Interop.isl_union_map_eq_at_multi_union_pw_aff(Interop.isl_union_map_copy(args[0].ptr), Interop.isl_multi_union_pw_aff_copy(args[1].ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef every_map(Pointer arg0, Pointer arg1)
    {
        var exc_info = new Exception[1];
        var fn = (IntPtr cb_arg0, IntPtr user) =>
        {
            var cb_cls0 = new map(ctx: arg0.ctx, ptr: Interop.isl_map_copy(cb_arg0));
            try
            {
                var res = arg1(cb_cls0);
            }
            catch (Exception e)
            {
                exc_info[0] = e;
                return -1;
            }
            return res;
        };
        var cb1 = Marshal.GetFunctionPointerForDelegate(cb_func);
        var res = Interop.isl_union_map_every_map(arg0.ptr, cb1, IntPtr.Zerp);
        if (exc_info[0] is not null)
        {
            throw exc_info[0];
        }
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer extract_map(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_map_extract_map(arg0.ptr, Interop.isl_space_copy(arg1.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer factor_domain(Pointer arg0)
    {
        var res = Interop.isl_union_map_factor_domain(Interop.isl_union_map_copy(arg0.ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer factor_range(Pointer arg0)
    {
        var res = Interop.isl_union_map_factor_range(Interop.isl_union_map_copy(arg0.ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer fixed_power(val arg_1)
    {
        var res = Interop.isl_union_map_fixed_power_val(Interop.isl_union_map_copy(args[0].ptr), Interop.isl_val_copy(args[1].ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef foreach_map(Pointer arg0, Pointer arg1)
    {
        var exc_info = new Exception[1];
        var fn = (IntPtr cb_arg0, IntPtr user) =>
        {
            var cb_cls0 = new map(ctx: arg0.ctx, ptr: (cb_arg0));
            try
            {
                arg1(cb_cls0);
            }
            catch (Exception e)
            {
                exc_info[0] = e;
                return -1;
            }
            return 0;
        };
        var cb1 = Marshal.GetFunctionPointerForDelegate(cb_func);
        var res = Interop.isl_union_map_foreach_map(arg0.ptr, cb1, IntPtr.Zerp);
        if (exc_info[0] is not null)
        {
            throw exc_info[0];
        }
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
    }
    public static Pointer convert_from(multi_union_pw_aff arg_0)
    {
        var res = Interop.isl_union_map_from_multi_union_pw_aff(Interop.isl_multi_union_pw_aff_copy(args[0].ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public static Pointer convert_from(union_pw_multi_aff arg_0)
    {
        var res = Interop.isl_union_map_from_union_pw_multi_aff(Interop.isl_union_pw_multi_aff_copy(args[0].ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public static Pointer from_domain(Pointer arg0)
    {
        var res = Interop.isl_union_map_from_domain(Interop.isl_union_set_copy(arg0.ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public static Pointer from_domain_and_range(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_map_from_domain_and_range(Interop.isl_union_set_copy(arg0.ptr), Interop.isl_union_set_copy(arg1.ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public static Pointer from_range(Pointer arg0)
    {
        var res = Interop.isl_union_map_from_range(Interop.isl_union_set_copy(arg0.ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer gist(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_map_gist(Interop.isl_union_map_copy(arg0.ptr), Interop.isl_union_map_copy(arg1.ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer gist_domain(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_map_gist_domain(Interop.isl_union_map_copy(arg0.ptr), Interop.isl_union_set_copy(arg1.ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer gist_params(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_map_gist_params(Interop.isl_union_map_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer gist_range(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_map_gist_range(Interop.isl_union_map_copy(arg0.ptr), Interop.isl_union_set_copy(arg1.ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer intersect(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_map_intersect(Interop.isl_union_map_copy(arg0.ptr), Interop.isl_union_map_copy(arg1.ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer intersect_domain(space arg_1)
    {
        var res = Interop.isl_union_map_intersect_domain_space(Interop.isl_union_map_copy(args[0].ptr), Interop.isl_space_copy(args[1].ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer intersect_domain(union_set arg_1)
    {
        var res = Interop.isl_union_map_intersect_domain_union_set(Interop.isl_union_map_copy(args[0].ptr), Interop.isl_union_set_copy(args[1].ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer intersect_domain_factor_domain(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_map_intersect_domain_factor_domain(Interop.isl_union_map_copy(arg0.ptr), Interop.isl_union_map_copy(arg1.ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer intersect_domain_factor_range(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_map_intersect_domain_factor_range(Interop.isl_union_map_copy(arg0.ptr), Interop.isl_union_map_copy(arg1.ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer intersect_domain_wrapped_domain(union_set arg_1)
    {
        var res = Interop.isl_union_map_intersect_domain_wrapped_domain_union_set(Interop.isl_union_map_copy(args[0].ptr), Interop.isl_union_set_copy(args[1].ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer intersect_params(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_map_intersect_params(Interop.isl_union_map_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer intersect_range(space arg_1)
    {
        var res = Interop.isl_union_map_intersect_range_space(Interop.isl_union_map_copy(args[0].ptr), Interop.isl_space_copy(args[1].ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer intersect_range(union_set arg_1)
    {
        var res = Interop.isl_union_map_intersect_range_union_set(Interop.isl_union_map_copy(args[0].ptr), Interop.isl_union_set_copy(args[1].ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer intersect_range_factor_domain(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_map_intersect_range_factor_domain(Interop.isl_union_map_copy(arg0.ptr), Interop.isl_union_map_copy(arg1.ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer intersect_range_factor_range(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_map_intersect_range_factor_range(Interop.isl_union_map_copy(arg0.ptr), Interop.isl_union_map_copy(arg1.ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer intersect_range_wrapped_domain(union_set arg_1)
    {
        var res = Interop.isl_union_map_intersect_range_wrapped_domain_union_set(Interop.isl_union_map_copy(args[0].ptr), Interop.isl_union_set_copy(args[1].ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef is_bijective(Pointer arg0)
    {
        var res = Interop.isl_union_map_is_bijective(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_disjoint(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_map_is_disjoint(arg0.ptr, arg1.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_empty(Pointer arg0)
    {
        var res = Interop.isl_union_map_is_empty(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_equal(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_map_is_equal(arg0.ptr, arg1.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_injective(Pointer arg0)
    {
        var res = Interop.isl_union_map_is_injective(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_single_valued(Pointer arg0)
    {
        var res = Interop.isl_union_map_is_single_valued(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_strict_subset(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_map_is_strict_subset(arg0.ptr, arg1.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_subset(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_map_is_subset(arg0.ptr, arg1.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef isa_map(Pointer arg0)
    {
        var res = Interop.isl_union_map_isa_map(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer lexmax(Pointer arg0)
    {
        var res = Interop.isl_union_map_lexmax(Interop.isl_union_map_copy(arg0.ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer lexmin(Pointer arg0)
    {
        var res = Interop.isl_union_map_lexmin(Interop.isl_union_map_copy(arg0.ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer map_list(Pointer arg0)
    {
        var res = Interop.isl_union_map_get_map_list(arg0.ptr);
        var obj = new map_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer params(Pointer arg0) {
        var res = Interop.isl_union_map_params(Interop.isl_union_map_copy(arg0.ptr));
    var obj = new set(ctx = ctx, ptr = res);
        return obj;
    }
public Pointer polyhedral_hull(Pointer arg0)
{
    var res = Interop.isl_union_map_polyhedral_hull(Interop.isl_union_map_copy(arg0.ptr));
    var obj = new union_map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer preimage_domain(multi_aff arg_1)
{
    var res = Interop.isl_union_map_preimage_domain_multi_aff(Interop.isl_union_map_copy(args[0].ptr), Interop.isl_multi_aff_copy(args[1].ptr));
    var obj = new union_map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer preimage_domain(multi_pw_aff arg_1)
{
    var res = Interop.isl_union_map_preimage_domain_multi_pw_aff(Interop.isl_union_map_copy(args[0].ptr), Interop.isl_multi_pw_aff_copy(args[1].ptr));
    var obj = new union_map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer preimage_domain(pw_multi_aff arg_1)
{
    var res = Interop.isl_union_map_preimage_domain_pw_multi_aff(Interop.isl_union_map_copy(args[0].ptr), Interop.isl_pw_multi_aff_copy(args[1].ptr));
    var obj = new union_map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer preimage_domain(union_pw_multi_aff arg_1)
{
    var res = Interop.isl_union_map_preimage_domain_union_pw_multi_aff(Interop.isl_union_map_copy(args[0].ptr), Interop.isl_union_pw_multi_aff_copy(args[1].ptr));
    var obj = new union_map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer preimage_range(multi_aff arg_1)
{
    var res = Interop.isl_union_map_preimage_range_multi_aff(Interop.isl_union_map_copy(args[0].ptr), Interop.isl_multi_aff_copy(args[1].ptr));
    var obj = new union_map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer preimage_range(pw_multi_aff arg_1)
{
    var res = Interop.isl_union_map_preimage_range_pw_multi_aff(Interop.isl_union_map_copy(args[0].ptr), Interop.isl_pw_multi_aff_copy(args[1].ptr));
    var obj = new union_map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer preimage_range(union_pw_multi_aff arg_1)
{
    var res = Interop.isl_union_map_preimage_range_union_pw_multi_aff(Interop.isl_union_map_copy(args[0].ptr), Interop.isl_union_pw_multi_aff_copy(args[1].ptr));
    var obj = new union_map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer product(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_union_map_product(Interop.isl_union_map_copy(arg0.ptr), Interop.isl_union_map_copy(arg1.ptr));
    var obj = new union_map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer project_out_all_params(Pointer arg0)
{
    var res = Interop.isl_union_map_project_out_all_params(Interop.isl_union_map_copy(arg0.ptr));
    var obj = new union_map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer project_out_param(id arg_1)
{
    var res = Interop.isl_union_map_project_out_param_id(Interop.isl_union_map_copy(args[0].ptr), Interop.isl_id_copy(args[1].ptr));
    var obj = new union_map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer project_out_param(id_list arg_1)
{
    var res = Interop.isl_union_map_project_out_param_id_list(Interop.isl_union_map_copy(args[0].ptr), Interop.isl_id_list_copy(args[1].ptr));
    var obj = new union_map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer range(Pointer arg0)
{
    var res = Interop.isl_union_map_range(Interop.isl_union_map_copy(arg0.ptr));
    var obj = new union_set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer range_factor_domain(Pointer arg0)
{
    var res = Interop.isl_union_map_range_factor_domain(Interop.isl_union_map_copy(arg0.ptr));
    var obj = new union_map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer range_factor_range(Pointer arg0)
{
    var res = Interop.isl_union_map_range_factor_range(Interop.isl_union_map_copy(arg0.ptr));
    var obj = new union_map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer range_map(Pointer arg0)
{
    var res = Interop.isl_union_map_range_map(Interop.isl_union_map_copy(arg0.ptr));
    var obj = new union_map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer range_product(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_union_map_range_product(Interop.isl_union_map_copy(arg0.ptr), Interop.isl_union_map_copy(arg1.ptr));
    var obj = new union_map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer range_reverse(Pointer arg0)
{
    var res = Interop.isl_union_map_range_reverse(Interop.isl_union_map_copy(arg0.ptr));
    var obj = new union_map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer reverse(Pointer arg0)
{
    var res = Interop.isl_union_map_reverse(Interop.isl_union_map_copy(arg0.ptr));
    var obj = new union_map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer space(Pointer arg0)
{
    var res = Interop.isl_union_map_get_space(arg0.ptr);
    var obj = new space(ctx = ctx, ptr = res);
    return obj;
}
public Pointer subtract(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_union_map_subtract(Interop.isl_union_map_copy(arg0.ptr), Interop.isl_union_map_copy(arg1.ptr));
    var obj = new union_map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer subtract_domain(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_union_map_subtract_domain(Interop.isl_union_map_copy(arg0.ptr), Interop.isl_union_set_copy(arg1.ptr));
    var obj = new union_map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer subtract_range(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_union_map_subtract_range(Interop.isl_union_map_copy(arg0.ptr), Interop.isl_union_set_copy(arg1.ptr));
    var obj = new union_map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer uncurry(Pointer arg0)
{
    var res = Interop.isl_union_map_uncurry(Interop.isl_union_map_copy(arg0.ptr));
    var obj = new union_map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer union(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_union_map_union(Interop.isl_union_map_copy(arg0.ptr), Interop.isl_union_map_copy(arg1.ptr));
    var obj = new union_map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer universe(Pointer arg0)
{
    var res = Interop.isl_union_map_universe(Interop.isl_union_map_copy(arg0.ptr));
    var obj = new union_map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer wrap(Pointer arg0)
{
    var res = Interop.isl_union_map_wrap(Interop.isl_union_map_copy(arg0.ptr));
    var obj = new union_set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer zip(Pointer arg0)
{
    var res = Interop.isl_union_map_zip(Interop.isl_union_map_copy(arg0.ptr));
    var obj = new union_map(ctx = ctx, ptr = res);
    return obj;
}
}
internal static partial class Interop
{
    public static extern IntPtr isl_union_map_from_basic_map(IntPtr arg0);
    public static extern IntPtr isl_union_map_from_map(IntPtr arg0);
    public static extern IntPtr isl_union_map_read_from_str(Context arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_affine_hull(IntPtr arg0);
    public static extern IntPtr isl_union_map_apply_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_apply_range(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_as_map(IntPtr arg0);
    public static extern IntPtr isl_union_map_as_multi_union_pw_aff(IntPtr arg0);
    public static extern IntPtr isl_union_map_as_union_pw_multi_aff(IntPtr arg0);
    public static extern IntPtr isl_union_map_bind_range(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_coalesce(IntPtr arg0);
    public static extern IntPtr isl_union_map_compute_divs(IntPtr arg0);
    public static extern IntPtr isl_union_map_curry(IntPtr arg0);
    public static extern IntPtr isl_union_map_deltas(IntPtr arg0);
    public static extern IntPtr isl_union_map_detect_equalities(IntPtr arg0);
    public static extern IntPtr isl_union_map_domain(IntPtr arg0);
    public static extern IntPtr isl_union_map_domain_factor_domain(IntPtr arg0);
    public static extern IntPtr isl_union_map_domain_factor_range(IntPtr arg0);
    public static extern IntPtr isl_union_map_domain_map(IntPtr arg0);
    public static extern IntPtr isl_union_map_domain_map_union_pw_multi_aff(IntPtr arg0);
    public static extern IntPtr isl_union_map_domain_product(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_domain_reverse(IntPtr arg0);
    public static extern IntPtr isl_union_map_drop_unused_params(IntPtr arg0);
    public static extern IntPtr isl_union_map_empty_ctx(Context arg0);
    public static extern IntPtr isl_union_map_eq_at_multi_union_pw_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_every_map(IntPtr arg0, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg1, IntPtr arg2);
    public static extern IntPtr isl_union_map_extract_map(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_factor_domain(IntPtr arg0);
    public static extern IntPtr isl_union_map_factor_range(IntPtr arg0);
    public static extern IntPtr isl_union_map_fixed_power_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_foreach_map(IntPtr arg0, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg1, IntPtr arg2);
    public static extern IntPtr isl_union_map_from_multi_union_pw_aff(IntPtr arg0);
    public static extern IntPtr isl_union_map_from_union_pw_multi_aff(IntPtr arg0);
    public static extern IntPtr isl_union_map_from_domain(IntPtr arg0);
    public static extern IntPtr isl_union_map_from_domain_and_range(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_from_range(IntPtr arg0);
    public static extern IntPtr isl_union_map_gist(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_gist_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_gist_params(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_gist_range(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_intersect(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_intersect_domain_space(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_intersect_domain_union_set(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_intersect_domain_factor_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_intersect_domain_factor_range(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_intersect_domain_wrapped_domain_union_set(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_intersect_params(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_intersect_range_space(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_intersect_range_union_set(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_intersect_range_factor_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_intersect_range_factor_range(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_intersect_range_wrapped_domain_union_set(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_is_bijective(IntPtr arg0);
    public static extern IntPtr isl_union_map_is_disjoint(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_is_empty(IntPtr arg0);
    public static extern IntPtr isl_union_map_is_equal(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_is_injective(IntPtr arg0);
    public static extern IntPtr isl_union_map_is_single_valued(IntPtr arg0);
    public static extern IntPtr isl_union_map_is_strict_subset(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_is_subset(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_isa_map(IntPtr arg0);
    public static extern IntPtr isl_union_map_lexmax(IntPtr arg0);
    public static extern IntPtr isl_union_map_lexmin(IntPtr arg0);
    public static extern IntPtr isl_union_map_get_map_list(IntPtr arg0);
    public static extern IntPtr isl_union_map_params(IntPtr arg0);
    public static extern IntPtr isl_union_map_polyhedral_hull(IntPtr arg0);
    public static extern IntPtr isl_union_map_preimage_domain_multi_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_preimage_domain_multi_pw_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_preimage_domain_pw_multi_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_preimage_domain_union_pw_multi_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_preimage_range_multi_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_preimage_range_pw_multi_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_preimage_range_union_pw_multi_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_product(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_project_out_all_params(IntPtr arg0);
    public static extern IntPtr isl_union_map_project_out_param_id(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_project_out_param_id_list(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_range(IntPtr arg0);
    public static extern IntPtr isl_union_map_range_factor_domain(IntPtr arg0);
    public static extern IntPtr isl_union_map_range_factor_range(IntPtr arg0);
    public static extern IntPtr isl_union_map_range_map(IntPtr arg0);
    public static extern IntPtr isl_union_map_range_product(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_range_reverse(IntPtr arg0);
    public static extern IntPtr isl_union_map_reverse(IntPtr arg0);
    public static extern IntPtr isl_union_map_get_space(IntPtr arg0);
    public static extern IntPtr isl_union_map_subtract(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_subtract_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_subtract_range(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_uncurry(IntPtr arg0);
    public static extern IntPtr isl_union_map_union(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_map_universe(IntPtr arg0);
    public static extern IntPtr isl_union_map_wrap(IntPtr arg0);
    public static extern IntPtr isl_union_map_zip(IntPtr arg0);
    public static extern IntPtr isl_union_map_copy(IntPtr arg0);
    public static extern IntPtr isl_union_map_free(IntPtr arg0);
    public static extern IntPtr isl_union_map_to_str(IntPtr arg0);
}

public class mapunion_map
{
    private Context ctx;
    private IntPtr ptr;
    public map(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public map(basic_map arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_map_from_basic_map(Interop.isl_basic_map_copy(args[0].ptr))
    }
    public map(string arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_map_read_from_str(this.ctx, args[0].encode('ascii'))
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_map_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_map_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer affine_hull(Pointer arg0)
    {
        var res = Interop.isl_map_affine_hull(Interop.isl_map_copy(arg0.ptr));
        var obj = new basic_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer apply_domain(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_map_apply_domain(Interop.isl_map_copy(arg0.ptr), Interop.isl_map_copy(arg1.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer apply_range(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_map_apply_range(Interop.isl_map_copy(arg0.ptr), Interop.isl_map_copy(arg1.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer as_pw_multi_aff(Pointer arg0)
    {
        var res = Interop.isl_map_as_pw_multi_aff(Interop.isl_map_copy(arg0.ptr));
        var obj = new pw_multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer bind_domain(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_map_bind_domain(Interop.isl_map_copy(arg0.ptr), Interop.isl_multi_id_copy(arg1.ptr));
        var obj = new set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer bind_range(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_map_bind_range(Interop.isl_map_copy(arg0.ptr), Interop.isl_multi_id_copy(arg1.ptr));
        var obj = new set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer coalesce(Pointer arg0)
    {
        var res = Interop.isl_map_coalesce(Interop.isl_map_copy(arg0.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer complement(Pointer arg0)
    {
        var res = Interop.isl_map_complement(Interop.isl_map_copy(arg0.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer curry(Pointer arg0)
    {
        var res = Interop.isl_map_curry(Interop.isl_map_copy(arg0.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer deltas(Pointer arg0)
    {
        var res = Interop.isl_map_deltas(Interop.isl_map_copy(arg0.ptr));
        var obj = new set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer detect_equalities(Pointer arg0)
    {
        var res = Interop.isl_map_detect_equalities(Interop.isl_map_copy(arg0.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer domain(Pointer arg0)
    {
        var res = Interop.isl_map_domain(Interop.isl_map_copy(arg0.ptr));
        var obj = new set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer domain_factor_domain(Pointer arg0)
    {
        var res = Interop.isl_map_domain_factor_domain(Interop.isl_map_copy(arg0.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer domain_factor_range(Pointer arg0)
    {
        var res = Interop.isl_map_domain_factor_range(Interop.isl_map_copy(arg0.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer domain_product(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_map_domain_product(Interop.isl_map_copy(arg0.ptr), Interop.isl_map_copy(arg1.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer domain_reverse(Pointer arg0)
    {
        var res = Interop.isl_map_domain_reverse(Interop.isl_map_copy(arg0.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef domain_tuple_dim(Pointer arg0)
    {
        var res = Interop.isl_map_domain_tuple_dim(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer domain_tuple_id(Pointer arg0)
    {
        var res = Interop.isl_map_get_domain_tuple_id(arg0.ptr);
        var obj = new id(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer drop_unused_params(Pointer arg0)
    {
        var res = Interop.isl_map_drop_unused_params(Interop.isl_map_copy(arg0.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public static Pointer empty(Pointer arg0)
    {
        var res = Interop.isl_map_empty(Interop.isl_space_copy(arg0.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer eq_at(multi_pw_aff arg_1)
    {
        var res = Interop.isl_map_eq_at_multi_pw_aff(Interop.isl_map_copy(args[0].ptr), Interop.isl_multi_pw_aff_copy(args[1].ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer factor_domain(Pointer arg0)
    {
        var res = Interop.isl_map_factor_domain(Interop.isl_map_copy(arg0.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer factor_range(Pointer arg0)
    {
        var res = Interop.isl_map_factor_range(Interop.isl_map_copy(arg0.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer fixed_power(val arg_1)
    {
        var res = Interop.isl_map_fixed_power_val(Interop.isl_map_copy(args[0].ptr), Interop.isl_val_copy(args[1].ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer flatten(Pointer arg0)
    {
        var res = Interop.isl_map_flatten(Interop.isl_map_copy(arg0.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer flatten_domain(Pointer arg0)
    {
        var res = Interop.isl_map_flatten_domain(Interop.isl_map_copy(arg0.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer flatten_range(Pointer arg0)
    {
        var res = Interop.isl_map_flatten_range(Interop.isl_map_copy(arg0.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef foreach_basic_map(Pointer arg0, Pointer arg1)
    {
        var exc_info = new Exception[1];
        var fn = (IntPtr cb_arg0, IntPtr user) =>
        {
            var cb_cls0 = new basic_map(ctx: arg0.ctx, ptr: (cb_arg0));
            try
            {
                arg1(cb_cls0);
            }
            catch (Exception e)
            {
                exc_info[0] = e;
                return -1;
            }
            return 0;
        };
        var cb1 = Marshal.GetFunctionPointerForDelegate(cb_func);
        var res = Interop.isl_map_foreach_basic_map(arg0.ptr, cb1, IntPtr.Zerp);
        if (exc_info[0] is not null)
        {
            throw exc_info[0];
        }
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
    }
    public Pointer gist(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_map_gist(Interop.isl_map_copy(arg0.ptr), Interop.isl_map_copy(arg1.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer gist_domain(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_map_gist_domain(Interop.isl_map_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer gist_params(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_map_gist_params(Interop.isl_map_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef has_domain_tuple_id(Pointer arg0)
    {
        var res = Interop.isl_map_has_domain_tuple_id(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef has_range_tuple_id(Pointer arg0)
    {
        var res = Interop.isl_map_has_range_tuple_id(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer intersect(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_map_intersect(Interop.isl_map_copy(arg0.ptr), Interop.isl_map_copy(arg1.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer intersect_domain(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_map_intersect_domain(Interop.isl_map_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer intersect_domain_factor_domain(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_map_intersect_domain_factor_domain(Interop.isl_map_copy(arg0.ptr), Interop.isl_map_copy(arg1.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer intersect_domain_factor_range(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_map_intersect_domain_factor_range(Interop.isl_map_copy(arg0.ptr), Interop.isl_map_copy(arg1.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer intersect_domain_wrapped_domain(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_map_intersect_domain_wrapped_domain(Interop.isl_map_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer intersect_params(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_map_intersect_params(Interop.isl_map_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer intersect_range(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_map_intersect_range(Interop.isl_map_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer intersect_range_factor_domain(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_map_intersect_range_factor_domain(Interop.isl_map_copy(arg0.ptr), Interop.isl_map_copy(arg1.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer intersect_range_factor_range(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_map_intersect_range_factor_range(Interop.isl_map_copy(arg0.ptr), Interop.isl_map_copy(arg1.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer intersect_range_wrapped_domain(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_map_intersect_range_wrapped_domain(Interop.isl_map_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef is_bijective(Pointer arg0)
    {
        var res = Interop.isl_map_is_bijective(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_disjoint(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_map_is_disjoint(arg0.ptr, arg1.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_empty(Pointer arg0)
    {
        var res = Interop.isl_map_is_empty(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_equal(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_map_is_equal(arg0.ptr, arg1.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_injective(Pointer arg0)
    {
        var res = Interop.isl_map_is_injective(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_single_valued(Pointer arg0)
    {
        var res = Interop.isl_map_is_single_valued(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_strict_subset(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_map_is_strict_subset(arg0.ptr, arg1.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_subset(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_map_is_subset(arg0.ptr, arg1.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer lex_ge_at(multi_pw_aff arg_1)
    {
        var res = Interop.isl_map_lex_ge_at_multi_pw_aff(Interop.isl_map_copy(args[0].ptr), Interop.isl_multi_pw_aff_copy(args[1].ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer lex_gt_at(multi_pw_aff arg_1)
    {
        var res = Interop.isl_map_lex_gt_at_multi_pw_aff(Interop.isl_map_copy(args[0].ptr), Interop.isl_multi_pw_aff_copy(args[1].ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer lex_le_at(multi_pw_aff arg_1)
    {
        var res = Interop.isl_map_lex_le_at_multi_pw_aff(Interop.isl_map_copy(args[0].ptr), Interop.isl_multi_pw_aff_copy(args[1].ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer lex_lt_at(multi_pw_aff arg_1)
    {
        var res = Interop.isl_map_lex_lt_at_multi_pw_aff(Interop.isl_map_copy(args[0].ptr), Interop.isl_multi_pw_aff_copy(args[1].ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer lexmax(Pointer arg0)
    {
        var res = Interop.isl_map_lexmax(Interop.isl_map_copy(arg0.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer lexmax_pw_multi_aff(Pointer arg0)
    {
        var res = Interop.isl_map_lexmax_pw_multi_aff(Interop.isl_map_copy(arg0.ptr));
        var obj = new pw_multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer lexmin(Pointer arg0)
    {
        var res = Interop.isl_map_lexmin(Interop.isl_map_copy(arg0.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer lexmin_pw_multi_aff(Pointer arg0)
    {
        var res = Interop.isl_map_lexmin_pw_multi_aff(Interop.isl_map_copy(arg0.ptr));
        var obj = new pw_multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer lower_bound(multi_pw_aff arg_1)
    {
        var res = Interop.isl_map_lower_bound_multi_pw_aff(Interop.isl_map_copy(args[0].ptr), Interop.isl_multi_pw_aff_copy(args[1].ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer max_multi_pw_aff(Pointer arg0)
    {
        var res = Interop.isl_map_max_multi_pw_aff(Interop.isl_map_copy(arg0.ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer min_multi_pw_aff(Pointer arg0)
    {
        var res = Interop.isl_map_min_multi_pw_aff(Interop.isl_map_copy(arg0.ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef n_basic_map(Pointer arg0)
    {
        var res = Interop.isl_map_n_basic_map(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer params(Pointer arg0) {
        var res = Interop.isl_map_params(Interop.isl_map_copy(arg0.ptr));
    var obj = new set(ctx = ctx, ptr = res);
        return obj;
    }
public Pointer polyhedral_hull(Pointer arg0)
{
    var res = Interop.isl_map_polyhedral_hull(Interop.isl_map_copy(arg0.ptr));
    var obj = new basic_map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer preimage_domain(multi_aff arg_1)
{
    var res = Interop.isl_map_preimage_domain_multi_aff(Interop.isl_map_copy(args[0].ptr), Interop.isl_multi_aff_copy(args[1].ptr));
    var obj = new map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer preimage_domain(multi_pw_aff arg_1)
{
    var res = Interop.isl_map_preimage_domain_multi_pw_aff(Interop.isl_map_copy(args[0].ptr), Interop.isl_multi_pw_aff_copy(args[1].ptr));
    var obj = new map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer preimage_domain(pw_multi_aff arg_1)
{
    var res = Interop.isl_map_preimage_domain_pw_multi_aff(Interop.isl_map_copy(args[0].ptr), Interop.isl_pw_multi_aff_copy(args[1].ptr));
    var obj = new map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer preimage_range(multi_aff arg_1)
{
    var res = Interop.isl_map_preimage_range_multi_aff(Interop.isl_map_copy(args[0].ptr), Interop.isl_multi_aff_copy(args[1].ptr));
    var obj = new map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer preimage_range(pw_multi_aff arg_1)
{
    var res = Interop.isl_map_preimage_range_pw_multi_aff(Interop.isl_map_copy(args[0].ptr), Interop.isl_pw_multi_aff_copy(args[1].ptr));
    var obj = new map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer product(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_map_product(Interop.isl_map_copy(arg0.ptr), Interop.isl_map_copy(arg1.ptr));
    var obj = new map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer project_out_all_params(Pointer arg0)
{
    var res = Interop.isl_map_project_out_all_params(Interop.isl_map_copy(arg0.ptr));
    var obj = new map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer project_out_param(id arg_1)
{
    var res = Interop.isl_map_project_out_param_id(Interop.isl_map_copy(args[0].ptr), Interop.isl_id_copy(args[1].ptr));
    var obj = new map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer project_out_param(id_list arg_1)
{
    var res = Interop.isl_map_project_out_param_id_list(Interop.isl_map_copy(args[0].ptr), Interop.isl_id_list_copy(args[1].ptr));
    var obj = new map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer range(Pointer arg0)
{
    var res = Interop.isl_map_range(Interop.isl_map_copy(arg0.ptr));
    var obj = new set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer range_factor_domain(Pointer arg0)
{
    var res = Interop.isl_map_range_factor_domain(Interop.isl_map_copy(arg0.ptr));
    var obj = new map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer range_factor_range(Pointer arg0)
{
    var res = Interop.isl_map_range_factor_range(Interop.isl_map_copy(arg0.ptr));
    var obj = new map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer range_lattice_tile(Pointer arg0)
{
    var res = Interop.isl_map_get_range_lattice_tile(arg0.ptr);
    var obj = new fixed_box(ctx = ctx, ptr = res);
    return obj;
}
public Pointer range_product(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_map_range_product(Interop.isl_map_copy(arg0.ptr), Interop.isl_map_copy(arg1.ptr));
    var obj = new map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer range_reverse(Pointer arg0)
{
    var res = Interop.isl_map_range_reverse(Interop.isl_map_copy(arg0.ptr));
    var obj = new map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer range_simple_fixed_box_hull(Pointer arg0)
{
    var res = Interop.isl_map_get_range_simple_fixed_box_hull(arg0.ptr);
    var obj = new fixed_box(ctx = ctx, ptr = res);
    return obj;
}
public Typedef range_tuple_dim(Pointer arg0)
{
    var res = Interop.isl_map_range_tuple_dim(arg0.ptr);
    if (res < 0)
    {
        throw new InvalidOperationException();
    }
    return res;
}
public Pointer range_tuple_id(Pointer arg0)
{
    var res = Interop.isl_map_get_range_tuple_id(arg0.ptr);
    var obj = new id(ctx = ctx, ptr = res);
    return obj;
}
public Pointer reverse(Pointer arg0)
{
    var res = Interop.isl_map_reverse(Interop.isl_map_copy(arg0.ptr));
    var obj = new map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer sample(Pointer arg0)
{
    var res = Interop.isl_map_sample(Interop.isl_map_copy(arg0.ptr));
    var obj = new basic_map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer set_domain_tuple(id arg_1)
{
    var res = Interop.isl_map_set_domain_tuple_id(Interop.isl_map_copy(args[0].ptr), Interop.isl_id_copy(args[1].ptr));
    var obj = new map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer set_range_tuple(id arg_1)
{
    var res = Interop.isl_map_set_range_tuple_id(Interop.isl_map_copy(args[0].ptr), Interop.isl_id_copy(args[1].ptr));
    var obj = new map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer space(Pointer arg0)
{
    var res = Interop.isl_map_get_space(arg0.ptr);
    var obj = new space(ctx = ctx, ptr = res);
    return obj;
}
public Pointer subtract(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_map_subtract(Interop.isl_map_copy(arg0.ptr), Interop.isl_map_copy(arg1.ptr));
    var obj = new map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer to_list(Pointer arg0)
{
    var res = Interop.isl_map_to_list(Interop.isl_map_copy(arg0.ptr));
    var obj = new map_list(ctx = ctx, ptr = res);
    return obj;
}
public Pointer to_union_map(Pointer arg0)
{
    var res = Interop.isl_map_to_union_map(Interop.isl_map_copy(arg0.ptr));
    var obj = new union_map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer uncurry(Pointer arg0)
{
    var res = Interop.isl_map_uncurry(Interop.isl_map_copy(arg0.ptr));
    var obj = new map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer union(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_map_union(Interop.isl_map_copy(arg0.ptr), Interop.isl_map_copy(arg1.ptr));
    var obj = new map(ctx = ctx, ptr = res);
    return obj;
}
public static Pointer universe(Pointer arg0)
{
    var res = Interop.isl_map_universe(Interop.isl_space_copy(arg0.ptr));
    var obj = new map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer unshifted_simple_hull(Pointer arg0)
{
    var res = Interop.isl_map_unshifted_simple_hull(Interop.isl_map_copy(arg0.ptr));
    var obj = new basic_map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer upper_bound(multi_pw_aff arg_1)
{
    var res = Interop.isl_map_upper_bound_multi_pw_aff(Interop.isl_map_copy(args[0].ptr), Interop.isl_multi_pw_aff_copy(args[1].ptr));
    var obj = new map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer wrap(Pointer arg0)
{
    var res = Interop.isl_map_wrap(Interop.isl_map_copy(arg0.ptr));
    var obj = new set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer zip(Pointer arg0)
{
    var res = Interop.isl_map_zip(Interop.isl_map_copy(arg0.ptr));
    var obj = new map(ctx = ctx, ptr = res);
    return obj;
}
}
internal static partial class Interop
{
    public static extern IntPtr isl_map_from_basic_map(IntPtr arg0);
    public static extern IntPtr isl_map_read_from_str(Context arg0, IntPtr arg1);
    public static extern IntPtr isl_map_affine_hull(IntPtr arg0);
    public static extern IntPtr isl_map_apply_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_apply_range(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_as_pw_multi_aff(IntPtr arg0);
    public static extern IntPtr isl_map_bind_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_bind_range(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_coalesce(IntPtr arg0);
    public static extern IntPtr isl_map_complement(IntPtr arg0);
    public static extern IntPtr isl_map_curry(IntPtr arg0);
    public static extern IntPtr isl_map_deltas(IntPtr arg0);
    public static extern IntPtr isl_map_detect_equalities(IntPtr arg0);
    public static extern IntPtr isl_map_domain(IntPtr arg0);
    public static extern IntPtr isl_map_domain_factor_domain(IntPtr arg0);
    public static extern IntPtr isl_map_domain_factor_range(IntPtr arg0);
    public static extern IntPtr isl_map_domain_product(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_domain_reverse(IntPtr arg0);
    public static extern IntPtr isl_map_domain_tuple_dim(IntPtr arg0);
    public static extern IntPtr isl_map_get_domain_tuple_id(IntPtr arg0);
    public static extern IntPtr isl_map_drop_unused_params(IntPtr arg0);
    public static extern IntPtr isl_map_empty(IntPtr arg0);
    public static extern IntPtr isl_map_eq_at_multi_pw_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_factor_domain(IntPtr arg0);
    public static extern IntPtr isl_map_factor_range(IntPtr arg0);
    public static extern IntPtr isl_map_fixed_power_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_flatten(IntPtr arg0);
    public static extern IntPtr isl_map_flatten_domain(IntPtr arg0);
    public static extern IntPtr isl_map_flatten_range(IntPtr arg0);
    public static extern IntPtr isl_map_foreach_basic_map(IntPtr arg0, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg1, IntPtr arg2);
    public static extern IntPtr isl_map_gist(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_gist_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_gist_params(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_has_domain_tuple_id(IntPtr arg0);
    public static extern IntPtr isl_map_has_range_tuple_id(IntPtr arg0);
    public static extern IntPtr isl_map_intersect(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_intersect_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_intersect_domain_factor_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_intersect_domain_factor_range(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_intersect_domain_wrapped_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_intersect_params(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_intersect_range(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_intersect_range_factor_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_intersect_range_factor_range(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_intersect_range_wrapped_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_is_bijective(IntPtr arg0);
    public static extern IntPtr isl_map_is_disjoint(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_is_empty(IntPtr arg0);
    public static extern IntPtr isl_map_is_equal(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_is_injective(IntPtr arg0);
    public static extern IntPtr isl_map_is_single_valued(IntPtr arg0);
    public static extern IntPtr isl_map_is_strict_subset(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_is_subset(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_lex_ge_at_multi_pw_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_lex_gt_at_multi_pw_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_lex_le_at_multi_pw_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_lex_lt_at_multi_pw_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_lexmax(IntPtr arg0);
    public static extern IntPtr isl_map_lexmax_pw_multi_aff(IntPtr arg0);
    public static extern IntPtr isl_map_lexmin(IntPtr arg0);
    public static extern IntPtr isl_map_lexmin_pw_multi_aff(IntPtr arg0);
    public static extern IntPtr isl_map_lower_bound_multi_pw_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_max_multi_pw_aff(IntPtr arg0);
    public static extern IntPtr isl_map_min_multi_pw_aff(IntPtr arg0);
    public static extern IntPtr isl_map_n_basic_map(IntPtr arg0);
    public static extern IntPtr isl_map_params(IntPtr arg0);
    public static extern IntPtr isl_map_polyhedral_hull(IntPtr arg0);
    public static extern IntPtr isl_map_preimage_domain_multi_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_preimage_domain_multi_pw_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_preimage_domain_pw_multi_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_preimage_range_multi_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_preimage_range_pw_multi_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_product(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_project_out_all_params(IntPtr arg0);
    public static extern IntPtr isl_map_project_out_param_id(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_project_out_param_id_list(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_range(IntPtr arg0);
    public static extern IntPtr isl_map_range_factor_domain(IntPtr arg0);
    public static extern IntPtr isl_map_range_factor_range(IntPtr arg0);
    public static extern IntPtr isl_map_get_range_lattice_tile(IntPtr arg0);
    public static extern IntPtr isl_map_range_product(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_range_reverse(IntPtr arg0);
    public static extern IntPtr isl_map_get_range_simple_fixed_box_hull(IntPtr arg0);
    public static extern IntPtr isl_map_range_tuple_dim(IntPtr arg0);
    public static extern IntPtr isl_map_get_range_tuple_id(IntPtr arg0);
    public static extern IntPtr isl_map_reverse(IntPtr arg0);
    public static extern IntPtr isl_map_sample(IntPtr arg0);
    public static extern IntPtr isl_map_set_domain_tuple_id(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_set_range_tuple_id(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_get_space(IntPtr arg0);
    public static extern IntPtr isl_map_subtract(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_to_list(IntPtr arg0);
    public static extern IntPtr isl_map_to_union_map(IntPtr arg0);
    public static extern IntPtr isl_map_uncurry(IntPtr arg0);
    public static extern IntPtr isl_map_union(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_universe(IntPtr arg0);
    public static extern IntPtr isl_map_unshifted_simple_hull(IntPtr arg0);
    public static extern IntPtr isl_map_upper_bound_multi_pw_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_wrap(IntPtr arg0);
    public static extern IntPtr isl_map_zip(IntPtr arg0);
    public static extern IntPtr isl_map_copy(IntPtr arg0);
    public static extern IntPtr isl_map_free(IntPtr arg0);
    public static extern IntPtr isl_map_to_str(IntPtr arg0);
}

public class basic_mapmap
{
    private Context ctx;
    private IntPtr ptr;
    public basic_map(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public basic_map(string arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_basic_map_read_from_str(this.ctx, args[0].encode('ascii'))
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_basic_map_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_basic_map_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer affine_hull(Pointer arg0)
    {
        var res = Interop.isl_basic_map_affine_hull(Interop.isl_basic_map_copy(arg0.ptr));
        var obj = new basic_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer apply_domain(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_basic_map_apply_domain(Interop.isl_basic_map_copy(arg0.ptr), Interop.isl_basic_map_copy(arg1.ptr));
        var obj = new basic_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer apply_range(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_basic_map_apply_range(Interop.isl_basic_map_copy(arg0.ptr), Interop.isl_basic_map_copy(arg1.ptr));
        var obj = new basic_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer deltas(Pointer arg0)
    {
        var res = Interop.isl_basic_map_deltas(Interop.isl_basic_map_copy(arg0.ptr));
        var obj = new basic_set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer detect_equalities(Pointer arg0)
    {
        var res = Interop.isl_basic_map_detect_equalities(Interop.isl_basic_map_copy(arg0.ptr));
        var obj = new basic_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer flatten(Pointer arg0)
    {
        var res = Interop.isl_basic_map_flatten(Interop.isl_basic_map_copy(arg0.ptr));
        var obj = new basic_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer flatten_domain(Pointer arg0)
    {
        var res = Interop.isl_basic_map_flatten_domain(Interop.isl_basic_map_copy(arg0.ptr));
        var obj = new basic_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer flatten_range(Pointer arg0)
    {
        var res = Interop.isl_basic_map_flatten_range(Interop.isl_basic_map_copy(arg0.ptr));
        var obj = new basic_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer gist(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_basic_map_gist(Interop.isl_basic_map_copy(arg0.ptr), Interop.isl_basic_map_copy(arg1.ptr));
        var obj = new basic_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer intersect(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_basic_map_intersect(Interop.isl_basic_map_copy(arg0.ptr), Interop.isl_basic_map_copy(arg1.ptr));
        var obj = new basic_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer intersect_domain(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_basic_map_intersect_domain(Interop.isl_basic_map_copy(arg0.ptr), Interop.isl_basic_set_copy(arg1.ptr));
        var obj = new basic_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer intersect_params(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_basic_map_intersect_params(Interop.isl_basic_map_copy(arg0.ptr), Interop.isl_basic_set_copy(arg1.ptr));
        var obj = new basic_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer intersect_range(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_basic_map_intersect_range(Interop.isl_basic_map_copy(arg0.ptr), Interop.isl_basic_set_copy(arg1.ptr));
        var obj = new basic_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef is_empty(Pointer arg0)
    {
        var res = Interop.isl_basic_map_is_empty(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_equal(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_basic_map_is_equal(arg0.ptr, arg1.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_subset(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_basic_map_is_subset(arg0.ptr, arg1.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer lexmax(Pointer arg0)
    {
        var res = Interop.isl_basic_map_lexmax(Interop.isl_basic_map_copy(arg0.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer lexmin(Pointer arg0)
    {
        var res = Interop.isl_basic_map_lexmin(Interop.isl_basic_map_copy(arg0.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer reverse(Pointer arg0)
    {
        var res = Interop.isl_basic_map_reverse(Interop.isl_basic_map_copy(arg0.ptr));
        var obj = new basic_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer sample(Pointer arg0)
    {
        var res = Interop.isl_basic_map_sample(Interop.isl_basic_map_copy(arg0.ptr));
        var obj = new basic_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer union(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_basic_map_union(Interop.isl_basic_map_copy(arg0.ptr), Interop.isl_basic_map_copy(arg1.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_basic_map_read_from_str(Context arg0, IntPtr arg1);
    public static extern IntPtr isl_basic_map_affine_hull(IntPtr arg0);
    public static extern IntPtr isl_basic_map_apply_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_basic_map_apply_range(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_basic_map_deltas(IntPtr arg0);
    public static extern IntPtr isl_basic_map_detect_equalities(IntPtr arg0);
    public static extern IntPtr isl_basic_map_flatten(IntPtr arg0);
    public static extern IntPtr isl_basic_map_flatten_domain(IntPtr arg0);
    public static extern IntPtr isl_basic_map_flatten_range(IntPtr arg0);
    public static extern IntPtr isl_basic_map_gist(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_basic_map_intersect(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_basic_map_intersect_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_basic_map_intersect_params(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_basic_map_intersect_range(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_basic_map_is_empty(IntPtr arg0);
    public static extern IntPtr isl_basic_map_is_equal(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_basic_map_is_subset(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_basic_map_lexmax(IntPtr arg0);
    public static extern IntPtr isl_basic_map_lexmin(IntPtr arg0);
    public static extern IntPtr isl_basic_map_reverse(IntPtr arg0);
    public static extern IntPtr isl_basic_map_sample(IntPtr arg0);
    public static extern IntPtr isl_basic_map_union(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_basic_map_copy(IntPtr arg0);
    public static extern IntPtr isl_basic_map_free(IntPtr arg0);
    public static extern IntPtr isl_basic_map_to_str(IntPtr arg0);
}

public class union_set
{
    private Context ctx;
    private IntPtr ptr;
    public union_set(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public union_set(basic_set arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_union_set_from_basic_set(Interop.isl_basic_set_copy(args[0].ptr))
    }
    public union_set(point arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_union_set_from_point(Interop.isl_point_copy(args[0].ptr))
    }
    public union_set(set arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_union_set_from_set(Interop.isl_set_copy(args[0].ptr))
    }
    public union_set(string arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_union_set_read_from_str(this.ctx, args[0].encode('ascii'))
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_union_set_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_union_set_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer affine_hull(Pointer arg0)
    {
        var res = Interop.isl_union_set_affine_hull(Interop.isl_union_set_copy(arg0.ptr));
        var obj = new union_set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer apply(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_set_apply(Interop.isl_union_set_copy(arg0.ptr), Interop.isl_union_map_copy(arg1.ptr));
        var obj = new union_set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer as_set(Pointer arg0)
    {
        var res = Interop.isl_union_set_as_set(Interop.isl_union_set_copy(arg0.ptr));
        var obj = new set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer coalesce(Pointer arg0)
    {
        var res = Interop.isl_union_set_coalesce(Interop.isl_union_set_copy(arg0.ptr));
        var obj = new union_set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer compute_divs(Pointer arg0)
    {
        var res = Interop.isl_union_set_compute_divs(Interop.isl_union_set_copy(arg0.ptr));
        var obj = new union_set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer detect_equalities(Pointer arg0)
    {
        var res = Interop.isl_union_set_detect_equalities(Interop.isl_union_set_copy(arg0.ptr));
        var obj = new union_set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer drop_unused_params(Pointer arg0)
    {
        var res = Interop.isl_union_set_drop_unused_params(Interop.isl_union_set_copy(arg0.ptr));
        var obj = new union_set(ctx = ctx, ptr = res);
        return obj;
    }
    public static Pointer empty()
    {
        var ctx = Context.DefaultInstance;
        var res = Interop.isl_union_set_empty_ctx(ctx);
        var obj = new union_set(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef every_set(Pointer arg0, Pointer arg1)
    {
        var exc_info = new Exception[1];
        var fn = (IntPtr cb_arg0, IntPtr user) =>
        {
            var cb_cls0 = new set(ctx: arg0.ctx, ptr: Interop.isl_set_copy(cb_arg0));
            try
            {
                var res = arg1(cb_cls0);
            }
            catch (Exception e)
            {
                exc_info[0] = e;
                return -1;
            }
            return res;
        };
        var cb1 = Marshal.GetFunctionPointerForDelegate(cb_func);
        var res = Interop.isl_union_set_every_set(arg0.ptr, cb1, IntPtr.Zerp);
        if (exc_info[0] is not null)
        {
            throw exc_info[0];
        }
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer extract_set(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_set_extract_set(arg0.ptr, Interop.isl_space_copy(arg1.ptr));
        var obj = new set(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef foreach_point(Pointer arg0, Pointer arg1)
    {
        var exc_info = new Exception[1];
        var fn = (IntPtr cb_arg0, IntPtr user) =>
        {
            var cb_cls0 = new point(ctx: arg0.ctx, ptr: (cb_arg0));
            try
            {
                arg1(cb_cls0);
            }
            catch (Exception e)
            {
                exc_info[0] = e;
                return -1;
            }
            return 0;
        };
        var cb1 = Marshal.GetFunctionPointerForDelegate(cb_func);
        var res = Interop.isl_union_set_foreach_point(arg0.ptr, cb1, IntPtr.Zerp);
        if (exc_info[0] is not null)
        {
            throw exc_info[0];
        }
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
    }
    public Typedef foreach_set(Pointer arg0, Pointer arg1)
    {
        var exc_info = new Exception[1];
        var fn = (IntPtr cb_arg0, IntPtr user) =>
        {
            var cb_cls0 = new set(ctx: arg0.ctx, ptr: (cb_arg0));
            try
            {
                arg1(cb_cls0);
            }
            catch (Exception e)
            {
                exc_info[0] = e;
                return -1;
            }
            return 0;
        };
        var cb1 = Marshal.GetFunctionPointerForDelegate(cb_func);
        var res = Interop.isl_union_set_foreach_set(arg0.ptr, cb1, IntPtr.Zerp);
        if (exc_info[0] is not null)
        {
            throw exc_info[0];
        }
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
    }
    public Pointer gist(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_set_gist(Interop.isl_union_set_copy(arg0.ptr), Interop.isl_union_set_copy(arg1.ptr));
        var obj = new union_set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer gist_params(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_set_gist_params(Interop.isl_union_set_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
        var obj = new union_set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer identity(Pointer arg0)
    {
        var res = Interop.isl_union_set_identity(Interop.isl_union_set_copy(arg0.ptr));
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer intersect(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_set_intersect(Interop.isl_union_set_copy(arg0.ptr), Interop.isl_union_set_copy(arg1.ptr));
        var obj = new union_set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer intersect_params(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_set_intersect_params(Interop.isl_union_set_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
        var obj = new union_set(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef is_disjoint(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_set_is_disjoint(arg0.ptr, arg1.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_empty(Pointer arg0)
    {
        var res = Interop.isl_union_set_is_empty(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_equal(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_set_is_equal(arg0.ptr, arg1.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_strict_subset(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_set_is_strict_subset(arg0.ptr, arg1.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_subset(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_set_is_subset(arg0.ptr, arg1.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef isa_set(Pointer arg0)
    {
        var res = Interop.isl_union_set_isa_set(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer lexmax(Pointer arg0)
    {
        var res = Interop.isl_union_set_lexmax(Interop.isl_union_set_copy(arg0.ptr));
        var obj = new union_set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer lexmin(Pointer arg0)
    {
        var res = Interop.isl_union_set_lexmin(Interop.isl_union_set_copy(arg0.ptr));
        var obj = new union_set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer params(Pointer arg0) {
        var res = Interop.isl_union_set_params(Interop.isl_union_set_copy(arg0.ptr));
    var obj = new set(ctx = ctx, ptr = res);
        return obj;
    }
public Pointer polyhedral_hull(Pointer arg0)
{
    var res = Interop.isl_union_set_polyhedral_hull(Interop.isl_union_set_copy(arg0.ptr));
    var obj = new union_set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer preimage(multi_aff arg_1)
{
    var res = Interop.isl_union_set_preimage_multi_aff(Interop.isl_union_set_copy(args[0].ptr), Interop.isl_multi_aff_copy(args[1].ptr));
    var obj = new union_set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer preimage(pw_multi_aff arg_1)
{
    var res = Interop.isl_union_set_preimage_pw_multi_aff(Interop.isl_union_set_copy(args[0].ptr), Interop.isl_pw_multi_aff_copy(args[1].ptr));
    var obj = new union_set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer preimage(union_pw_multi_aff arg_1)
{
    var res = Interop.isl_union_set_preimage_union_pw_multi_aff(Interop.isl_union_set_copy(args[0].ptr), Interop.isl_union_pw_multi_aff_copy(args[1].ptr));
    var obj = new union_set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer project_out_all_params(Pointer arg0)
{
    var res = Interop.isl_union_set_project_out_all_params(Interop.isl_union_set_copy(arg0.ptr));
    var obj = new union_set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer sample_point(Pointer arg0)
{
    var res = Interop.isl_union_set_sample_point(Interop.isl_union_set_copy(arg0.ptr));
    var obj = new point(ctx = ctx, ptr = res);
    return obj;
}
public Pointer set_list(Pointer arg0)
{
    var res = Interop.isl_union_set_get_set_list(arg0.ptr);
    var obj = new set_list(ctx = ctx, ptr = res);
    return obj;
}
public Pointer space(Pointer arg0)
{
    var res = Interop.isl_union_set_get_space(arg0.ptr);
    var obj = new space(ctx = ctx, ptr = res);
    return obj;
}
public Pointer subtract(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_union_set_subtract(Interop.isl_union_set_copy(arg0.ptr), Interop.isl_union_set_copy(arg1.ptr));
    var obj = new union_set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer to_list(Pointer arg0)
{
    var res = Interop.isl_union_set_to_list(Interop.isl_union_set_copy(arg0.ptr));
    var obj = new union_set_list(ctx = ctx, ptr = res);
    return obj;
}
public Pointer union(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_union_set_union(Interop.isl_union_set_copy(arg0.ptr), Interop.isl_union_set_copy(arg1.ptr));
    var obj = new union_set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer universe(Pointer arg0)
{
    var res = Interop.isl_union_set_universe(Interop.isl_union_set_copy(arg0.ptr));
    var obj = new union_set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer unwrap(Pointer arg0)
{
    var res = Interop.isl_union_set_unwrap(Interop.isl_union_set_copy(arg0.ptr));
    var obj = new union_map(ctx = ctx, ptr = res);
    return obj;
}
}
internal static partial class Interop
{
    public static extern IntPtr isl_union_set_from_basic_set(IntPtr arg0);
    public static extern IntPtr isl_union_set_from_point(IntPtr arg0);
    public static extern IntPtr isl_union_set_from_set(IntPtr arg0);
    public static extern IntPtr isl_union_set_read_from_str(Context arg0, IntPtr arg1);
    public static extern IntPtr isl_union_set_affine_hull(IntPtr arg0);
    public static extern IntPtr isl_union_set_apply(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_set_as_set(IntPtr arg0);
    public static extern IntPtr isl_union_set_coalesce(IntPtr arg0);
    public static extern IntPtr isl_union_set_compute_divs(IntPtr arg0);
    public static extern IntPtr isl_union_set_detect_equalities(IntPtr arg0);
    public static extern IntPtr isl_union_set_drop_unused_params(IntPtr arg0);
    public static extern IntPtr isl_union_set_empty_ctx(Context arg0);
    public static extern IntPtr isl_union_set_every_set(IntPtr arg0, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg1, IntPtr arg2);
    public static extern IntPtr isl_union_set_extract_set(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_set_foreach_point(IntPtr arg0, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg1, IntPtr arg2);
    public static extern IntPtr isl_union_set_foreach_set(IntPtr arg0, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg1, IntPtr arg2);
    public static extern IntPtr isl_union_set_gist(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_set_gist_params(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_set_identity(IntPtr arg0);
    public static extern IntPtr isl_union_set_intersect(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_set_intersect_params(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_set_is_disjoint(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_set_is_empty(IntPtr arg0);
    public static extern IntPtr isl_union_set_is_equal(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_set_is_strict_subset(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_set_is_subset(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_set_isa_set(IntPtr arg0);
    public static extern IntPtr isl_union_set_lexmax(IntPtr arg0);
    public static extern IntPtr isl_union_set_lexmin(IntPtr arg0);
    public static extern IntPtr isl_union_set_params(IntPtr arg0);
    public static extern IntPtr isl_union_set_polyhedral_hull(IntPtr arg0);
    public static extern IntPtr isl_union_set_preimage_multi_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_set_preimage_pw_multi_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_set_preimage_union_pw_multi_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_set_project_out_all_params(IntPtr arg0);
    public static extern IntPtr isl_union_set_sample_point(IntPtr arg0);
    public static extern IntPtr isl_union_set_get_set_list(IntPtr arg0);
    public static extern IntPtr isl_union_set_get_space(IntPtr arg0);
    public static extern IntPtr isl_union_set_subtract(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_set_to_list(IntPtr arg0);
    public static extern IntPtr isl_union_set_union(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_set_universe(IntPtr arg0);
    public static extern IntPtr isl_union_set_unwrap(IntPtr arg0);
    public static extern IntPtr isl_union_set_copy(IntPtr arg0);
    public static extern IntPtr isl_union_set_free(IntPtr arg0);
    public static extern IntPtr isl_union_set_to_str(IntPtr arg0);
}

public class setunion_set
{
    private Context ctx;
    private IntPtr ptr;
    public set(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public set(basic_set arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_set_from_basic_set(Interop.isl_basic_set_copy(args[0].ptr))
    }
    public set(point arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_set_from_point(Interop.isl_point_copy(args[0].ptr))
    }
    public set(string arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_set_read_from_str(this.ctx, args[0].encode('ascii'))
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_set_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_set_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer affine_hull(Pointer arg0)
    {
        var res = Interop.isl_set_affine_hull(Interop.isl_set_copy(arg0.ptr));
        var obj = new basic_set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer apply(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_set_apply(Interop.isl_set_copy(arg0.ptr), Interop.isl_map_copy(arg1.ptr));
        var obj = new set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer as_pw_multi_aff(Pointer arg0)
    {
        var res = Interop.isl_set_as_pw_multi_aff(Interop.isl_set_copy(arg0.ptr));
        var obj = new pw_multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer bind(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_set_bind(Interop.isl_set_copy(arg0.ptr), Interop.isl_multi_id_copy(arg1.ptr));
        var obj = new set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer coalesce(Pointer arg0)
    {
        var res = Interop.isl_set_coalesce(Interop.isl_set_copy(arg0.ptr));
        var obj = new set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer complement(Pointer arg0)
    {
        var res = Interop.isl_set_complement(Interop.isl_set_copy(arg0.ptr));
        var obj = new set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer detect_equalities(Pointer arg0)
    {
        var res = Interop.isl_set_detect_equalities(Interop.isl_set_copy(arg0.ptr));
        var obj = new set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer dim_max_val(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_set_dim_max_val(Interop.isl_set_copy(arg0.ptr), arg1);
        var obj = new val(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer dim_min_val(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_set_dim_min_val(Interop.isl_set_copy(arg0.ptr), arg1);
        var obj = new val(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer drop_unused_params(Pointer arg0)
    {
        var res = Interop.isl_set_drop_unused_params(Interop.isl_set_copy(arg0.ptr));
        var obj = new set(ctx = ctx, ptr = res);
        return obj;
    }
    public static Pointer empty(Pointer arg0)
    {
        var res = Interop.isl_set_empty(Interop.isl_space_copy(arg0.ptr));
        var obj = new set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer flatten(Pointer arg0)
    {
        var res = Interop.isl_set_flatten(Interop.isl_set_copy(arg0.ptr));
        var obj = new set(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef foreach_basic_set(Pointer arg0, Pointer arg1)
    {
        var exc_info = new Exception[1];
        var fn = (IntPtr cb_arg0, IntPtr user) =>
        {
            var cb_cls0 = new basic_set(ctx: arg0.ctx, ptr: (cb_arg0));
            try
            {
                arg1(cb_cls0);
            }
            catch (Exception e)
            {
                exc_info[0] = e;
                return -1;
            }
            return 0;
        };
        var cb1 = Marshal.GetFunctionPointerForDelegate(cb_func);
        var res = Interop.isl_set_foreach_basic_set(arg0.ptr, cb1, IntPtr.Zerp);
        if (exc_info[0] is not null)
        {
            throw exc_info[0];
        }
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
    }
    public Typedef foreach_point(Pointer arg0, Pointer arg1)
    {
        var exc_info = new Exception[1];
        var fn = (IntPtr cb_arg0, IntPtr user) =>
        {
            var cb_cls0 = new point(ctx: arg0.ctx, ptr: (cb_arg0));
            try
            {
                arg1(cb_cls0);
            }
            catch (Exception e)
            {
                exc_info[0] = e;
                return -1;
            }
            return 0;
        };
        var cb1 = Marshal.GetFunctionPointerForDelegate(cb_func);
        var res = Interop.isl_set_foreach_point(arg0.ptr, cb1, IntPtr.Zerp);
        if (exc_info[0] is not null)
        {
            throw exc_info[0];
        }
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
    }
    public Pointer gist(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_set_gist(Interop.isl_set_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
        var obj = new set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer gist_params(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_set_gist_params(Interop.isl_set_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
        var obj = new set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer identity(Pointer arg0)
    {
        var res = Interop.isl_set_identity(Interop.isl_set_copy(arg0.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer indicator_function(Pointer arg0)
    {
        var res = Interop.isl_set_indicator_function(Interop.isl_set_copy(arg0.ptr));
        var obj = new pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer insert_domain(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_set_insert_domain(Interop.isl_set_copy(arg0.ptr), Interop.isl_space_copy(arg1.ptr));
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer intersect(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_set_intersect(Interop.isl_set_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
        var obj = new set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer intersect_params(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_set_intersect_params(Interop.isl_set_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
        var obj = new set(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef involves_locals(Pointer arg0)
    {
        var res = Interop.isl_set_involves_locals(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_disjoint(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_set_is_disjoint(arg0.ptr, arg1.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_empty(Pointer arg0)
    {
        var res = Interop.isl_set_is_empty(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_equal(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_set_is_equal(arg0.ptr, arg1.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_singleton(Pointer arg0)
    {
        var res = Interop.isl_set_is_singleton(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_strict_subset(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_set_is_strict_subset(arg0.ptr, arg1.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_subset(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_set_is_subset(arg0.ptr, arg1.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_wrapping(Pointer arg0)
    {
        var res = Interop.isl_set_is_wrapping(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer lattice_tile(Pointer arg0)
    {
        var res = Interop.isl_set_get_lattice_tile(arg0.ptr);
        var obj = new fixed_box(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer lexmax(Pointer arg0)
    {
        var res = Interop.isl_set_lexmax(Interop.isl_set_copy(arg0.ptr));
        var obj = new set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer lexmax_pw_multi_aff(Pointer arg0)
    {
        var res = Interop.isl_set_lexmax_pw_multi_aff(Interop.isl_set_copy(arg0.ptr));
        var obj = new pw_multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer lexmin(Pointer arg0)
    {
        var res = Interop.isl_set_lexmin(Interop.isl_set_copy(arg0.ptr));
        var obj = new set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer lexmin_pw_multi_aff(Pointer arg0)
    {
        var res = Interop.isl_set_lexmin_pw_multi_aff(Interop.isl_set_copy(arg0.ptr));
        var obj = new pw_multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer lower_bound(multi_pw_aff arg_1)
    {
        var res = Interop.isl_set_lower_bound_multi_pw_aff(Interop.isl_set_copy(args[0].ptr), Interop.isl_multi_pw_aff_copy(args[1].ptr));
        var obj = new set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer lower_bound(multi_val arg_1)
    {
        var res = Interop.isl_set_lower_bound_multi_val(Interop.isl_set_copy(args[0].ptr), Interop.isl_multi_val_copy(args[1].ptr));
        var obj = new set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer max_multi_pw_aff(Pointer arg0)
    {
        var res = Interop.isl_set_max_multi_pw_aff(Interop.isl_set_copy(arg0.ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer max_val(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_set_max_val(arg0.ptr, arg1.ptr);
        var obj = new val(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer min_multi_pw_aff(Pointer arg0)
    {
        var res = Interop.isl_set_min_multi_pw_aff(Interop.isl_set_copy(arg0.ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer min_val(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_set_min_val(arg0.ptr, arg1.ptr);
        var obj = new val(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef n_basic_set(Pointer arg0)
    {
        var res = Interop.isl_set_n_basic_set(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer param_pw_aff_on_domain(id arg_1)
    {
        var res = Interop.isl_set_param_pw_aff_on_domain_id(Interop.isl_set_copy(args[0].ptr), Interop.isl_id_copy(args[1].ptr));
        var obj = new pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer params(Pointer arg0) {
        var res = Interop.isl_set_params(Interop.isl_set_copy(arg0.ptr));
    var obj = new set(ctx = ctx, ptr = res);
        return obj;
    }
public Pointer plain_multi_val_if_fixed(Pointer arg0)
{
    var res = Interop.isl_set_get_plain_multi_val_if_fixed(arg0.ptr);
    var obj = new multi_val(ctx = ctx, ptr = res);
    return obj;
}
public Pointer polyhedral_hull(Pointer arg0)
{
    var res = Interop.isl_set_polyhedral_hull(Interop.isl_set_copy(arg0.ptr));
    var obj = new basic_set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer preimage(multi_aff arg_1)
{
    var res = Interop.isl_set_preimage_multi_aff(Interop.isl_set_copy(args[0].ptr), Interop.isl_multi_aff_copy(args[1].ptr));
    var obj = new set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer preimage(multi_pw_aff arg_1)
{
    var res = Interop.isl_set_preimage_multi_pw_aff(Interop.isl_set_copy(args[0].ptr), Interop.isl_multi_pw_aff_copy(args[1].ptr));
    var obj = new set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer preimage(pw_multi_aff arg_1)
{
    var res = Interop.isl_set_preimage_pw_multi_aff(Interop.isl_set_copy(args[0].ptr), Interop.isl_pw_multi_aff_copy(args[1].ptr));
    var obj = new set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer product(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_set_product(Interop.isl_set_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
    var obj = new set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer project_out_all_params(Pointer arg0)
{
    var res = Interop.isl_set_project_out_all_params(Interop.isl_set_copy(arg0.ptr));
    var obj = new set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer project_out_param(id arg_1)
{
    var res = Interop.isl_set_project_out_param_id(Interop.isl_set_copy(args[0].ptr), Interop.isl_id_copy(args[1].ptr));
    var obj = new set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer project_out_param(id_list arg_1)
{
    var res = Interop.isl_set_project_out_param_id_list(Interop.isl_set_copy(args[0].ptr), Interop.isl_id_list_copy(args[1].ptr));
    var obj = new set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer pw_aff_on_domain(val arg_1)
{
    var res = Interop.isl_set_pw_aff_on_domain_val(Interop.isl_set_copy(args[0].ptr), Interop.isl_val_copy(args[1].ptr));
    var obj = new pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer pw_multi_aff_on_domain(multi_val arg_1)
{
    var res = Interop.isl_set_pw_multi_aff_on_domain_multi_val(Interop.isl_set_copy(args[0].ptr), Interop.isl_multi_val_copy(args[1].ptr));
    var obj = new pw_multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer sample(Pointer arg0)
{
    var res = Interop.isl_set_sample(Interop.isl_set_copy(arg0.ptr));
    var obj = new basic_set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer sample_point(Pointer arg0)
{
    var res = Interop.isl_set_sample_point(Interop.isl_set_copy(arg0.ptr));
    var obj = new point(ctx = ctx, ptr = res);
    return obj;
}
public Pointer simple_fixed_box_hull(Pointer arg0)
{
    var res = Interop.isl_set_get_simple_fixed_box_hull(arg0.ptr);
    var obj = new fixed_box(ctx = ctx, ptr = res);
    return obj;
}
public Pointer space(Pointer arg0)
{
    var res = Interop.isl_set_get_space(arg0.ptr);
    var obj = new space(ctx = ctx, ptr = res);
    return obj;
}
public Pointer stride(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_set_get_stride(arg0.ptr, arg1);
    var obj = new val(ctx = ctx, ptr = res);
    return obj;
}
public Pointer subtract(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_set_subtract(Interop.isl_set_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
    var obj = new set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer to_list(Pointer arg0)
{
    var res = Interop.isl_set_to_list(Interop.isl_set_copy(arg0.ptr));
    var obj = new set_list(ctx = ctx, ptr = res);
    return obj;
}
public Pointer to_union_set(Pointer arg0)
{
    var res = Interop.isl_set_to_union_set(Interop.isl_set_copy(arg0.ptr));
    var obj = new union_set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer translation(Pointer arg0)
{
    var res = Interop.isl_set_translation(Interop.isl_set_copy(arg0.ptr));
    var obj = new map(ctx = ctx, ptr = res);
    return obj;
}
public Typedef tuple_dim(Pointer arg0)
{
    var res = Interop.isl_set_tuple_dim(arg0.ptr);
    if (res < 0)
    {
        throw new InvalidOperationException();
    }
    return res;
}
public Pointer unbind_params(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_set_unbind_params(Interop.isl_set_copy(arg0.ptr), Interop.isl_multi_id_copy(arg1.ptr));
    var obj = new set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer unbind_params_insert_domain(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_set_unbind_params_insert_domain(Interop.isl_set_copy(arg0.ptr), Interop.isl_multi_id_copy(arg1.ptr));
    var obj = new map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer union(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_set_union(Interop.isl_set_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
    var obj = new set(ctx = ctx, ptr = res);
    return obj;
}
public static Pointer universe(Pointer arg0)
{
    var res = Interop.isl_set_universe(Interop.isl_space_copy(arg0.ptr));
    var obj = new set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer unshifted_simple_hull(Pointer arg0)
{
    var res = Interop.isl_set_unshifted_simple_hull(Interop.isl_set_copy(arg0.ptr));
    var obj = new basic_set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer unwrap(Pointer arg0)
{
    var res = Interop.isl_set_unwrap(Interop.isl_set_copy(arg0.ptr));
    var obj = new map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer upper_bound(multi_pw_aff arg_1)
{
    var res = Interop.isl_set_upper_bound_multi_pw_aff(Interop.isl_set_copy(args[0].ptr), Interop.isl_multi_pw_aff_copy(args[1].ptr));
    var obj = new set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer upper_bound(multi_val arg_1)
{
    var res = Interop.isl_set_upper_bound_multi_val(Interop.isl_set_copy(args[0].ptr), Interop.isl_multi_val_copy(args[1].ptr));
    var obj = new set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer wrapped_reverse(Pointer arg0)
{
    var res = Interop.isl_set_wrapped_reverse(Interop.isl_set_copy(arg0.ptr));
    var obj = new set(ctx = ctx, ptr = res);
    return obj;
}
}
internal static partial class Interop
{
    public static extern IntPtr isl_set_from_basic_set(IntPtr arg0);
    public static extern IntPtr isl_set_from_point(IntPtr arg0);
    public static extern IntPtr isl_set_read_from_str(Context arg0, IntPtr arg1);
    public static extern IntPtr isl_set_affine_hull(IntPtr arg0);
    public static extern IntPtr isl_set_apply(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_set_as_pw_multi_aff(IntPtr arg0);
    public static extern IntPtr isl_set_bind(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_set_coalesce(IntPtr arg0);
    public static extern IntPtr isl_set_complement(IntPtr arg0);
    public static extern IntPtr isl_set_detect_equalities(IntPtr arg0);
    public static extern IntPtr isl_set_dim_max_val(IntPtr arg0, int arg1);
    public static extern IntPtr isl_set_dim_min_val(IntPtr arg0, int arg1);
    public static extern IntPtr isl_set_drop_unused_params(IntPtr arg0);
    public static extern IntPtr isl_set_empty(IntPtr arg0);
    public static extern IntPtr isl_set_flatten(IntPtr arg0);
    public static extern IntPtr isl_set_foreach_basic_set(IntPtr arg0, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg1, IntPtr arg2);
    public static extern IntPtr isl_set_foreach_point(IntPtr arg0, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg1, IntPtr arg2);
    public static extern IntPtr isl_set_gist(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_set_gist_params(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_set_identity(IntPtr arg0);
    public static extern IntPtr isl_set_indicator_function(IntPtr arg0);
    public static extern IntPtr isl_set_insert_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_set_intersect(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_set_intersect_params(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_set_involves_locals(IntPtr arg0);
    public static extern IntPtr isl_set_is_disjoint(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_set_is_empty(IntPtr arg0);
    public static extern IntPtr isl_set_is_equal(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_set_is_singleton(IntPtr arg0);
    public static extern IntPtr isl_set_is_strict_subset(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_set_is_subset(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_set_is_wrapping(IntPtr arg0);
    public static extern IntPtr isl_set_get_lattice_tile(IntPtr arg0);
    public static extern IntPtr isl_set_lexmax(IntPtr arg0);
    public static extern IntPtr isl_set_lexmax_pw_multi_aff(IntPtr arg0);
    public static extern IntPtr isl_set_lexmin(IntPtr arg0);
    public static extern IntPtr isl_set_lexmin_pw_multi_aff(IntPtr arg0);
    public static extern IntPtr isl_set_lower_bound_multi_pw_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_set_lower_bound_multi_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_set_max_multi_pw_aff(IntPtr arg0);
    public static extern IntPtr isl_set_max_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_set_min_multi_pw_aff(IntPtr arg0);
    public static extern IntPtr isl_set_min_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_set_n_basic_set(IntPtr arg0);
    public static extern IntPtr isl_set_param_pw_aff_on_domain_id(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_set_params(IntPtr arg0);
    public static extern IntPtr isl_set_get_plain_multi_val_if_fixed(IntPtr arg0);
    public static extern IntPtr isl_set_polyhedral_hull(IntPtr arg0);
    public static extern IntPtr isl_set_preimage_multi_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_set_preimage_multi_pw_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_set_preimage_pw_multi_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_set_product(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_set_project_out_all_params(IntPtr arg0);
    public static extern IntPtr isl_set_project_out_param_id(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_set_project_out_param_id_list(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_set_pw_aff_on_domain_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_set_pw_multi_aff_on_domain_multi_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_set_sample(IntPtr arg0);
    public static extern IntPtr isl_set_sample_point(IntPtr arg0);
    public static extern IntPtr isl_set_get_simple_fixed_box_hull(IntPtr arg0);
    public static extern IntPtr isl_set_get_space(IntPtr arg0);
    public static extern IntPtr isl_set_get_stride(IntPtr arg0, int arg1);
    public static extern IntPtr isl_set_subtract(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_set_to_list(IntPtr arg0);
    public static extern IntPtr isl_set_to_union_set(IntPtr arg0);
    public static extern IntPtr isl_set_translation(IntPtr arg0);
    public static extern IntPtr isl_set_tuple_dim(IntPtr arg0);
    public static extern IntPtr isl_set_unbind_params(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_set_unbind_params_insert_domain(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_set_union(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_set_universe(IntPtr arg0);
    public static extern IntPtr isl_set_unshifted_simple_hull(IntPtr arg0);
    public static extern IntPtr isl_set_unwrap(IntPtr arg0);
    public static extern IntPtr isl_set_upper_bound_multi_pw_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_set_upper_bound_multi_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_set_wrapped_reverse(IntPtr arg0);
    public static extern IntPtr isl_set_copy(IntPtr arg0);
    public static extern IntPtr isl_set_free(IntPtr arg0);
    public static extern IntPtr isl_set_to_str(IntPtr arg0);
}

public class basic_setset
{
    private Context ctx;
    private IntPtr ptr;
    public basic_set(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public basic_set(point arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_basic_set_from_point(Interop.isl_point_copy(args[0].ptr))
    }
    public basic_set(string arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_basic_set_read_from_str(this.ctx, args[0].encode('ascii'))
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_basic_set_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_basic_set_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer affine_hull(Pointer arg0)
    {
        var res = Interop.isl_basic_set_affine_hull(Interop.isl_basic_set_copy(arg0.ptr));
        var obj = new basic_set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer apply(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_basic_set_apply(Interop.isl_basic_set_copy(arg0.ptr), Interop.isl_basic_map_copy(arg1.ptr));
        var obj = new basic_set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer detect_equalities(Pointer arg0)
    {
        var res = Interop.isl_basic_set_detect_equalities(Interop.isl_basic_set_copy(arg0.ptr));
        var obj = new basic_set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer dim_max_val(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_basic_set_dim_max_val(Interop.isl_basic_set_copy(arg0.ptr), arg1);
        var obj = new val(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer flatten(Pointer arg0)
    {
        var res = Interop.isl_basic_set_flatten(Interop.isl_basic_set_copy(arg0.ptr));
        var obj = new basic_set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer gist(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_basic_set_gist(Interop.isl_basic_set_copy(arg0.ptr), Interop.isl_basic_set_copy(arg1.ptr));
        var obj = new basic_set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer intersect(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_basic_set_intersect(Interop.isl_basic_set_copy(arg0.ptr), Interop.isl_basic_set_copy(arg1.ptr));
        var obj = new basic_set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer intersect_params(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_basic_set_intersect_params(Interop.isl_basic_set_copy(arg0.ptr), Interop.isl_basic_set_copy(arg1.ptr));
        var obj = new basic_set(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef is_empty(Pointer arg0)
    {
        var res = Interop.isl_basic_set_is_empty(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_equal(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_basic_set_is_equal(arg0.ptr, arg1.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_subset(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_basic_set_is_subset(arg0.ptr, arg1.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_wrapping(Pointer arg0)
    {
        var res = Interop.isl_basic_set_is_wrapping(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer lexmax(Pointer arg0)
    {
        var res = Interop.isl_basic_set_lexmax(Interop.isl_basic_set_copy(arg0.ptr));
        var obj = new set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer lexmin(Pointer arg0)
    {
        var res = Interop.isl_basic_set_lexmin(Interop.isl_basic_set_copy(arg0.ptr));
        var obj = new set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer params(Pointer arg0) {
        var res = Interop.isl_basic_set_params(Interop.isl_basic_set_copy(arg0.ptr));
    var obj = new basic_set(ctx = ctx, ptr = res);
        return obj;
    }
public Pointer sample(Pointer arg0)
{
    var res = Interop.isl_basic_set_sample(Interop.isl_basic_set_copy(arg0.ptr));
    var obj = new basic_set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer sample_point(Pointer arg0)
{
    var res = Interop.isl_basic_set_sample_point(Interop.isl_basic_set_copy(arg0.ptr));
    var obj = new point(ctx = ctx, ptr = res);
    return obj;
}
public Pointer to_set(Pointer arg0)
{
    var res = Interop.isl_basic_set_to_set(Interop.isl_basic_set_copy(arg0.ptr));
    var obj = new set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer union(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_basic_set_union(Interop.isl_basic_set_copy(arg0.ptr), Interop.isl_basic_set_copy(arg1.ptr));
    var obj = new set(ctx = ctx, ptr = res);
    return obj;
}
}
internal static partial class Interop
{
    public static extern IntPtr isl_basic_set_from_point(IntPtr arg0);
    public static extern IntPtr isl_basic_set_read_from_str(Context arg0, IntPtr arg1);
    public static extern IntPtr isl_basic_set_affine_hull(IntPtr arg0);
    public static extern IntPtr isl_basic_set_apply(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_basic_set_detect_equalities(IntPtr arg0);
    public static extern IntPtr isl_basic_set_dim_max_val(IntPtr arg0, int arg1);
    public static extern IntPtr isl_basic_set_flatten(IntPtr arg0);
    public static extern IntPtr isl_basic_set_gist(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_basic_set_intersect(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_basic_set_intersect_params(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_basic_set_is_empty(IntPtr arg0);
    public static extern IntPtr isl_basic_set_is_equal(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_basic_set_is_subset(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_basic_set_is_wrapping(IntPtr arg0);
    public static extern IntPtr isl_basic_set_lexmax(IntPtr arg0);
    public static extern IntPtr isl_basic_set_lexmin(IntPtr arg0);
    public static extern IntPtr isl_basic_set_params(IntPtr arg0);
    public static extern IntPtr isl_basic_set_sample(IntPtr arg0);
    public static extern IntPtr isl_basic_set_sample_point(IntPtr arg0);
    public static extern IntPtr isl_basic_set_to_set(IntPtr arg0);
    public static extern IntPtr isl_basic_set_union(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_basic_set_copy(IntPtr arg0);
    public static extern IntPtr isl_basic_set_free(IntPtr arg0);
    public static extern IntPtr isl_basic_set_to_str(IntPtr arg0);
}

public class fixed_box
{
    private Context ctx;
    private IntPtr ptr;
    public fixed_box(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public fixed_box(string arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_fixed_box_read_from_str(this.ctx, args[0].encode('ascii'))
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_fixed_box_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_fixed_box_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Typedef is_valid(Pointer arg0)
    {
        var res = Interop.isl_fixed_box_is_valid(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer offset(Pointer arg0)
    {
        var res = Interop.isl_fixed_box_get_offset(arg0.ptr);
        var obj = new multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer size(Pointer arg0)
    {
        var res = Interop.isl_fixed_box_get_size(arg0.ptr);
        var obj = new multi_val(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer space(Pointer arg0)
    {
        var res = Interop.isl_fixed_box_get_space(arg0.ptr);
        var obj = new space(ctx = ctx, ptr = res);
        return obj;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_fixed_box_read_from_str(Context arg0, IntPtr arg1);
    public static extern IntPtr isl_fixed_box_is_valid(IntPtr arg0);
    public static extern IntPtr isl_fixed_box_get_offset(IntPtr arg0);
    public static extern IntPtr isl_fixed_box_get_size(IntPtr arg0);
    public static extern IntPtr isl_fixed_box_get_space(IntPtr arg0);
    public static extern IntPtr isl_fixed_box_copy(IntPtr arg0);
    public static extern IntPtr isl_fixed_box_free(IntPtr arg0);
    public static extern IntPtr isl_fixed_box_to_str(IntPtr arg0);
}

public class id
{
    private Context ctx;
    private IntPtr ptr;
    public id(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public id(string arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_id_read_from_str(this.ctx, args[0].encode('ascii'))
    }
        if len(args) == 2 and type(args[0]) == str:
            this.ctx = Context.DefaultInstance
            name = args[0].encode('ascii')
            this.ptr = isl.isl_id_alloc(this.ctx, name, args[1])
            this.ptr = isl.isl_id_set_free_user(this.ptr, Context.free_user)
            if this.ptr is not None:
                pythonapi.Py_IncRef(py_object(args[1]))
            return
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_id_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_id_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    def user(this):
        free_user = cast(Context.free_user, c_void_p)
        id_free_user = cast(isl.isl_id_get_free_user(this.ptr), c_void_p)
        if id_free_user.value != free_user.value:
            return None
        return isl.isl_id_get_user(this.ptr)
    public Pointer name(Pointer arg0)
    {
        var res = Interop.isl_id_get_name(arg0.ptr);
        if (res == IntPtr.Zero)
        {
            throw new InvalidOperationException();
        }
        var str = Marshal.PtrToStringAnsi(res);
        return str;
    }
    public Pointer to_list(Pointer arg0)
    {
        var res = Interop.isl_id_to_list(Interop.isl_id_copy(arg0.ptr));
        var obj = new id_list(ctx = ctx, ptr = res);
        return obj;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_id_read_from_str(Context arg0, IntPtr arg1);
    public static extern IntPtr isl_id_get_name(IntPtr arg0);
    public static extern IntPtr isl_id_to_list(IntPtr arg0);
    public static extern IntPtr isl_id_copy(IntPtr arg0);
    public static extern IntPtr isl_id_free(IntPtr arg0);
    public static extern IntPtr isl_id_to_str(IntPtr arg0);
}

public class id_list
{
    private Context ctx;
    private IntPtr ptr;
    public id_list(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public id_list(int args_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_id_list_alloc(this.ctx, args[0])
    }
    public id_list(id arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_id_list_from_id(Interop.isl_id_copy(args[0].ptr))
    }
    public id_list(string arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_id_list_read_from_str(this.ctx, args[0].encode('ascii'))
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_id_list_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_id_list_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer add(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_id_list_add(Interop.isl_id_list_copy(arg0.ptr), Interop.isl_id_copy(arg1.ptr));
        var obj = new id_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer at(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_id_list_get_at(arg0.ptr, arg1);
        var obj = new id(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer clear(Pointer arg0)
    {
        var res = Interop.isl_id_list_clear(Interop.isl_id_list_copy(arg0.ptr));
        var obj = new id_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer concat(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_id_list_concat(Interop.isl_id_list_copy(arg0.ptr), Interop.isl_id_list_copy(arg1.ptr));
        var obj = new id_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer drop(Pointer arg0, Pointer arg1, Pointer arg2)
    {
        var res = Interop.isl_id_list_drop(Interop.isl_id_list_copy(arg0.ptr), arg1, arg2);
        var obj = new id_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef foreach(Pointer arg0, Pointer arg1) {
        var exc_info = new Exception[1];
    var fn = (IntPtr cb_arg0, IntPtr user) =>
    {
        var cb_cls0 = new id(ctx: arg0.ctx, ptr: (cb_arg0));
        try
        {
            arg1(cb_cls0);
        }
        catch (Exception e)
        {
            exc_info[0] = e;
            return -1;
        }
        return 0;
    };
    var cb1 = Marshal.GetFunctionPointerForDelegate(cb_func);
    var res = Interop.isl_id_list_foreach(arg0.ptr, cb1, IntPtr.Zerp);
        if (exc_info[0] is not null) {
            throw exc_info[0];
        }
if (res < 0)
{
    throw new InvalidOperationException();
}
    }
    public Typedef foreach_scc(Pointer arg0, Pointer arg1, Pointer arg2)
{
    var exc_info = new Exception[1];
    var fn = (IntPtr cb_arg0, IntPtr cb_arg1, IntPtr user) =>
    {
        var cb_cls0 = new id(ctx: arg0.ctx, ptr: Interop.isl_id_copy(cb_arg0));
        var cb_cls1 = new id(ctx: arg0.ctx, ptr: Interop.isl_id_copy(cb_arg1));
        try
        {
            var res = arg1(cb_cls0, cb_cls1);
        }
        catch (Exception e)
        {
            exc_info[0] = e;
            return -1;
        }
        return res;
    };
    var cb1 = Marshal.GetFunctionPointerForDelegate(cb_func);
    var exc_info = new Exception[1];
    var fn = (IntPtr cb_arg0, IntPtr user) =>
    {
        var cb_cls0 = new id_list(ctx: arg0.ctx, ptr: (cb_arg0));
        try
        {
            arg2(cb_cls0);
        }
        catch (Exception e)
        {
            exc_info[0] = e;
            return -1;
        }
        return 0;
    };
    var cb2 = Marshal.GetFunctionPointerForDelegate(cb_func);
    var res = Interop.isl_id_list_foreach_scc(arg0.ptr, cb1, IntPtr.Zerp, cb2, IntPtr.Zerp);
    if (exc_info[0] is not null)
    {
        throw exc_info[0];
    }
    if (res < 0)
    {
        throw new InvalidOperationException();
    }
}
public Pointer insert(Pointer arg0, Pointer arg1, Pointer arg2)
{
    var res = Interop.isl_id_list_insert(Interop.isl_id_list_copy(arg0.ptr), arg1, Interop.isl_id_copy(arg2.ptr));
    var obj = new id_list(ctx = ctx, ptr = res);
    return obj;
}
public Pointer set_at(Pointer arg0, Pointer arg1, Pointer arg2)
{
    var res = Interop.isl_id_list_set_at(Interop.isl_id_list_copy(arg0.ptr), arg1, Interop.isl_id_copy(arg2.ptr));
    var obj = new id_list(ctx = ctx, ptr = res);
    return obj;
}
public Typedef size(Pointer arg0)
{
    var res = Interop.isl_id_list_size(arg0.ptr);
    if (res < 0)
    {
        throw new InvalidOperationException();
    }
    return res;
}
}
internal static partial class Interop
{
    public static extern IntPtr isl_id_list_alloc(Context arg0, int arg1);
    public static extern IntPtr isl_id_list_from_id(IntPtr arg0);
    public static extern IntPtr isl_id_list_read_from_str(Context arg0, IntPtr arg1);
    public static extern IntPtr isl_id_list_add(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_id_list_get_at(IntPtr arg0, int arg1);
    public static extern IntPtr isl_id_list_clear(IntPtr arg0);
    public static extern IntPtr isl_id_list_concat(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_id_list_drop(IntPtr arg0, int arg1, int arg2);
    public static extern IntPtr isl_id_list_foreach(IntPtr arg0, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg1, IntPtr arg2);
    public static extern IntPtr isl_id_list_foreach_scc(IntPtr arg0, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg1, IntPtr arg2, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg3, IntPtr arg4);
    public static extern IntPtr isl_id_list_insert(IntPtr arg0, int arg1, IntPtr arg2);
    public static extern IntPtr isl_id_list_set_at(IntPtr arg0, int arg1, IntPtr arg2);
    public static extern IntPtr isl_id_list_size(IntPtr arg0);
    public static extern IntPtr isl_id_list_copy(IntPtr arg0);
    public static extern IntPtr isl_id_list_free(IntPtr arg0);
    public static extern IntPtr isl_id_list_to_str(IntPtr arg0);
}

public class id_to_ast_expr
{
    private Context ctx;
    private IntPtr ptr;
    public id_to_ast_expr(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public id_to_ast_expr(int args_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_id_to_ast_expr_alloc(this.ctx, args[0])
    }
    public id_to_ast_expr(string arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_id_to_ast_expr_read_from_str(this.ctx, args[0].encode('ascii'))
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_id_to_ast_expr_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_id_to_ast_expr_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Typedef is_equal(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_id_to_ast_expr_is_equal(arg0.ptr, arg1.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer set(Pointer arg0, Pointer arg1, Pointer arg2)
    {
        var res = Interop.isl_id_to_ast_expr_set(Interop.isl_id_to_ast_expr_copy(arg0.ptr), Interop.isl_id_copy(arg1.ptr), Interop.isl_ast_expr_copy(arg2.ptr));
        var obj = new id_to_ast_expr(ctx = ctx, ptr = res);
        return obj;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_id_to_ast_expr_alloc(Context arg0, int arg1);
    public static extern IntPtr isl_id_to_ast_expr_read_from_str(Context arg0, IntPtr arg1);
    public static extern IntPtr isl_id_to_ast_expr_is_equal(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_id_to_ast_expr_set(IntPtr arg0, IntPtr arg1, IntPtr arg2);
    public static extern IntPtr isl_id_to_ast_expr_copy(IntPtr arg0);
    public static extern IntPtr isl_id_to_ast_expr_free(IntPtr arg0);
    public static extern IntPtr isl_id_to_ast_expr_to_str(IntPtr arg0);
}

public class id_to_id
{
    private Context ctx;
    private IntPtr ptr;
    public id_to_id(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public id_to_id(int args_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_id_to_id_alloc(this.ctx, args[0])
    }
    public id_to_id(string arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_id_to_id_read_from_str(this.ctx, args[0].encode('ascii'))
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_id_to_id_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_id_to_id_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Typedef is_equal(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_id_to_id_is_equal(arg0.ptr, arg1.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer set(Pointer arg0, Pointer arg1, Pointer arg2)
    {
        var res = Interop.isl_id_to_id_set(Interop.isl_id_to_id_copy(arg0.ptr), Interop.isl_id_copy(arg1.ptr), Interop.isl_id_copy(arg2.ptr));
        var obj = new id_to_id(ctx = ctx, ptr = res);
        return obj;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_id_to_id_alloc(Context arg0, int arg1);
    public static extern IntPtr isl_id_to_id_read_from_str(Context arg0, IntPtr arg1);
    public static extern IntPtr isl_id_to_id_is_equal(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_id_to_id_set(IntPtr arg0, IntPtr arg1, IntPtr arg2);
    public static extern IntPtr isl_id_to_id_copy(IntPtr arg0);
    public static extern IntPtr isl_id_to_id_free(IntPtr arg0);
    public static extern IntPtr isl_id_to_id_to_str(IntPtr arg0);
}

public class map_list
{
    private Context ctx;
    private IntPtr ptr;
    public map_list(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public map_list(int args_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_map_list_alloc(this.ctx, args[0])
    }
    public map_list(map arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_map_list_from_map(Interop.isl_map_copy(args[0].ptr))
    }
    public map_list(string arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_map_list_read_from_str(this.ctx, args[0].encode('ascii'))
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_map_list_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_map_list_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer add(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_map_list_add(Interop.isl_map_list_copy(arg0.ptr), Interop.isl_map_copy(arg1.ptr));
        var obj = new map_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer at(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_map_list_get_at(arg0.ptr, arg1);
        var obj = new map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer clear(Pointer arg0)
    {
        var res = Interop.isl_map_list_clear(Interop.isl_map_list_copy(arg0.ptr));
        var obj = new map_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer concat(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_map_list_concat(Interop.isl_map_list_copy(arg0.ptr), Interop.isl_map_list_copy(arg1.ptr));
        var obj = new map_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer drop(Pointer arg0, Pointer arg1, Pointer arg2)
    {
        var res = Interop.isl_map_list_drop(Interop.isl_map_list_copy(arg0.ptr), arg1, arg2);
        var obj = new map_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef foreach(Pointer arg0, Pointer arg1) {
        var exc_info = new Exception[1];
    var fn = (IntPtr cb_arg0, IntPtr user) =>
    {
        var cb_cls0 = new map(ctx: arg0.ctx, ptr: (cb_arg0));
        try
        {
            arg1(cb_cls0);
        }
        catch (Exception e)
        {
            exc_info[0] = e;
            return -1;
        }
        return 0;
    };
    var cb1 = Marshal.GetFunctionPointerForDelegate(cb_func);
    var res = Interop.isl_map_list_foreach(arg0.ptr, cb1, IntPtr.Zerp);
        if (exc_info[0] is not null) {
            throw exc_info[0];
        }
if (res < 0)
{
    throw new InvalidOperationException();
}
    }
    public Typedef foreach_scc(Pointer arg0, Pointer arg1, Pointer arg2)
{
    var exc_info = new Exception[1];
    var fn = (IntPtr cb_arg0, IntPtr cb_arg1, IntPtr user) =>
    {
        var cb_cls0 = new map(ctx: arg0.ctx, ptr: Interop.isl_map_copy(cb_arg0));
        var cb_cls1 = new map(ctx: arg0.ctx, ptr: Interop.isl_map_copy(cb_arg1));
        try
        {
            var res = arg1(cb_cls0, cb_cls1);
        }
        catch (Exception e)
        {
            exc_info[0] = e;
            return -1;
        }
        return res;
    };
    var cb1 = Marshal.GetFunctionPointerForDelegate(cb_func);
    var exc_info = new Exception[1];
    var fn = (IntPtr cb_arg0, IntPtr user) =>
    {
        var cb_cls0 = new map_list(ctx: arg0.ctx, ptr: (cb_arg0));
        try
        {
            arg2(cb_cls0);
        }
        catch (Exception e)
        {
            exc_info[0] = e;
            return -1;
        }
        return 0;
    };
    var cb2 = Marshal.GetFunctionPointerForDelegate(cb_func);
    var res = Interop.isl_map_list_foreach_scc(arg0.ptr, cb1, IntPtr.Zerp, cb2, IntPtr.Zerp);
    if (exc_info[0] is not null)
    {
        throw exc_info[0];
    }
    if (res < 0)
    {
        throw new InvalidOperationException();
    }
}
public Pointer insert(Pointer arg0, Pointer arg1, Pointer arg2)
{
    var res = Interop.isl_map_list_insert(Interop.isl_map_list_copy(arg0.ptr), arg1, Interop.isl_map_copy(arg2.ptr));
    var obj = new map_list(ctx = ctx, ptr = res);
    return obj;
}
public Pointer set_at(Pointer arg0, Pointer arg1, Pointer arg2)
{
    var res = Interop.isl_map_list_set_at(Interop.isl_map_list_copy(arg0.ptr), arg1, Interop.isl_map_copy(arg2.ptr));
    var obj = new map_list(ctx = ctx, ptr = res);
    return obj;
}
public Typedef size(Pointer arg0)
{
    var res = Interop.isl_map_list_size(arg0.ptr);
    if (res < 0)
    {
        throw new InvalidOperationException();
    }
    return res;
}
}
internal static partial class Interop
{
    public static extern IntPtr isl_map_list_alloc(Context arg0, int arg1);
    public static extern IntPtr isl_map_list_from_map(IntPtr arg0);
    public static extern IntPtr isl_map_list_read_from_str(Context arg0, IntPtr arg1);
    public static extern IntPtr isl_map_list_add(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_list_get_at(IntPtr arg0, int arg1);
    public static extern IntPtr isl_map_list_clear(IntPtr arg0);
    public static extern IntPtr isl_map_list_concat(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_map_list_drop(IntPtr arg0, int arg1, int arg2);
    public static extern IntPtr isl_map_list_foreach(IntPtr arg0, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg1, IntPtr arg2);
    public static extern IntPtr isl_map_list_foreach_scc(IntPtr arg0, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg1, IntPtr arg2, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg3, IntPtr arg4);
    public static extern IntPtr isl_map_list_insert(IntPtr arg0, int arg1, IntPtr arg2);
    public static extern IntPtr isl_map_list_set_at(IntPtr arg0, int arg1, IntPtr arg2);
    public static extern IntPtr isl_map_list_size(IntPtr arg0);
    public static extern IntPtr isl_map_list_copy(IntPtr arg0);
    public static extern IntPtr isl_map_list_free(IntPtr arg0);
    public static extern IntPtr isl_map_list_to_str(IntPtr arg0);
}

public class multi_id
{
    private Context ctx;
    private IntPtr ptr;
    public multi_id(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public multi_id(space arg_0id_list arg_1)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_multi_id_from_id_list(Interop.isl_space_copy(args[0].ptr), Interop.isl_id_list_copy(args[1].ptr))
    }
    public multi_id(string arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_multi_id_read_from_str(this.ctx, args[0].encode('ascii'))
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_multi_id_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_multi_id_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer at(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_id_get_at(arg0.ptr, arg1);
        var obj = new id(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer flat_range_product(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_id_flat_range_product(Interop.isl_multi_id_copy(arg0.ptr), Interop.isl_multi_id_copy(arg1.ptr));
        var obj = new multi_id(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer list(Pointer arg0)
    {
        var res = Interop.isl_multi_id_get_list(arg0.ptr);
        var obj = new id_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef plain_is_equal(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_id_plain_is_equal(arg0.ptr, arg1.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer range_product(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_id_range_product(Interop.isl_multi_id_copy(arg0.ptr), Interop.isl_multi_id_copy(arg1.ptr));
        var obj = new multi_id(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer set_at(Pointer arg0, Pointer arg1, Pointer arg2)
    {
        var res = Interop.isl_multi_id_set_at(Interop.isl_multi_id_copy(arg0.ptr), arg1, Interop.isl_id_copy(arg2.ptr));
        var obj = new multi_id(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef size(Pointer arg0)
    {
        var res = Interop.isl_multi_id_size(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer space(Pointer arg0)
    {
        var res = Interop.isl_multi_id_get_space(arg0.ptr);
        var obj = new space(ctx = ctx, ptr = res);
        return obj;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_multi_id_from_id_list(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_id_read_from_str(Context arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_id_get_at(IntPtr arg0, int arg1);
    public static extern IntPtr isl_multi_id_flat_range_product(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_id_get_list(IntPtr arg0);
    public static extern IntPtr isl_multi_id_plain_is_equal(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_id_range_product(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_id_set_at(IntPtr arg0, int arg1, IntPtr arg2);
    public static extern IntPtr isl_multi_id_size(IntPtr arg0);
    public static extern IntPtr isl_multi_id_get_space(IntPtr arg0);
    public static extern IntPtr isl_multi_id_copy(IntPtr arg0);
    public static extern IntPtr isl_multi_id_free(IntPtr arg0);
    public static extern IntPtr isl_multi_id_to_str(IntPtr arg0);
}

public class multi_val
{
    private Context ctx;
    private IntPtr ptr;
    public multi_val(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public multi_val(space arg_0val_list arg_1)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_multi_val_from_val_list(Interop.isl_space_copy(args[0].ptr), Interop.isl_val_list_copy(args[1].ptr))
    }
    public multi_val(string arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_multi_val_read_from_str(this.ctx, args[0].encode('ascii'))
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_multi_val_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_multi_val_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer add(multi_val arg_1)
    {
        var res = Interop.isl_multi_val_add(Interop.isl_multi_val_copy(args[0].ptr), Interop.isl_multi_val_copy(args[1].ptr));
        var obj = new multi_val(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer add(val arg_1)
    {
        var res = Interop.isl_multi_val_add_val(Interop.isl_multi_val_copy(args[0].ptr), Interop.isl_val_copy(args[1].ptr));
        var obj = new multi_val(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer at(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_val_get_at(arg0.ptr, arg1);
        var obj = new val(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer flat_range_product(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_val_flat_range_product(Interop.isl_multi_val_copy(arg0.ptr), Interop.isl_multi_val_copy(arg1.ptr));
        var obj = new multi_val(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef has_range_tuple_id(Pointer arg0)
    {
        var res = Interop.isl_multi_val_has_range_tuple_id(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef involves_nan(Pointer arg0)
    {
        var res = Interop.isl_multi_val_involves_nan(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer list(Pointer arg0)
    {
        var res = Interop.isl_multi_val_get_list(arg0.ptr);
        var obj = new val_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer max(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_val_max(Interop.isl_multi_val_copy(arg0.ptr), Interop.isl_multi_val_copy(arg1.ptr));
        var obj = new multi_val(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer min(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_val_min(Interop.isl_multi_val_copy(arg0.ptr), Interop.isl_multi_val_copy(arg1.ptr));
        var obj = new multi_val(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer neg(Pointer arg0)
    {
        var res = Interop.isl_multi_val_neg(Interop.isl_multi_val_copy(arg0.ptr));
        var obj = new multi_val(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef plain_is_equal(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_val_plain_is_equal(arg0.ptr, arg1.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer product(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_val_product(Interop.isl_multi_val_copy(arg0.ptr), Interop.isl_multi_val_copy(arg1.ptr));
        var obj = new multi_val(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer range_product(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_val_range_product(Interop.isl_multi_val_copy(arg0.ptr), Interop.isl_multi_val_copy(arg1.ptr));
        var obj = new multi_val(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer range_tuple_id(Pointer arg0)
    {
        var res = Interop.isl_multi_val_get_range_tuple_id(arg0.ptr);
        var obj = new id(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer reset_range_tuple_id(Pointer arg0)
    {
        var res = Interop.isl_multi_val_reset_range_tuple_id(Interop.isl_multi_val_copy(arg0.ptr));
        var obj = new multi_val(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer scale(multi_val arg_1)
    {
        var res = Interop.isl_multi_val_scale_multi_val(Interop.isl_multi_val_copy(args[0].ptr), Interop.isl_multi_val_copy(args[1].ptr));
        var obj = new multi_val(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer scale(val arg_1)
    {
        var res = Interop.isl_multi_val_scale_val(Interop.isl_multi_val_copy(args[0].ptr), Interop.isl_val_copy(args[1].ptr));
        var obj = new multi_val(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer scale_down(multi_val arg_1)
    {
        var res = Interop.isl_multi_val_scale_down_multi_val(Interop.isl_multi_val_copy(args[0].ptr), Interop.isl_multi_val_copy(args[1].ptr));
        var obj = new multi_val(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer scale_down(val arg_1)
    {
        var res = Interop.isl_multi_val_scale_down_val(Interop.isl_multi_val_copy(args[0].ptr), Interop.isl_val_copy(args[1].ptr));
        var obj = new multi_val(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer set_at(Pointer arg0, Pointer arg1, Pointer arg2)
    {
        var res = Interop.isl_multi_val_set_at(Interop.isl_multi_val_copy(arg0.ptr), arg1, Interop.isl_val_copy(arg2.ptr));
        var obj = new multi_val(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer set_range_tuple(id arg_1)
    {
        var res = Interop.isl_multi_val_set_range_tuple_id(Interop.isl_multi_val_copy(args[0].ptr), Interop.isl_id_copy(args[1].ptr));
        var obj = new multi_val(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef size(Pointer arg0)
    {
        var res = Interop.isl_multi_val_size(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer space(Pointer arg0)
    {
        var res = Interop.isl_multi_val_get_space(arg0.ptr);
        var obj = new space(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer sub(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_multi_val_sub(Interop.isl_multi_val_copy(arg0.ptr), Interop.isl_multi_val_copy(arg1.ptr));
        var obj = new multi_val(ctx = ctx, ptr = res);
        return obj;
    }
    public static Pointer zero(Pointer arg0)
    {
        var res = Interop.isl_multi_val_zero(Interop.isl_space_copy(arg0.ptr));
        var obj = new multi_val(ctx = ctx, ptr = res);
        return obj;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_multi_val_from_val_list(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_val_read_from_str(Context arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_val_add(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_val_add_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_val_get_at(IntPtr arg0, int arg1);
    public static extern IntPtr isl_multi_val_flat_range_product(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_val_has_range_tuple_id(IntPtr arg0);
    public static extern IntPtr isl_multi_val_involves_nan(IntPtr arg0);
    public static extern IntPtr isl_multi_val_get_list(IntPtr arg0);
    public static extern IntPtr isl_multi_val_max(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_val_min(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_val_neg(IntPtr arg0);
    public static extern IntPtr isl_multi_val_plain_is_equal(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_val_product(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_val_range_product(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_val_get_range_tuple_id(IntPtr arg0);
    public static extern IntPtr isl_multi_val_reset_range_tuple_id(IntPtr arg0);
    public static extern IntPtr isl_multi_val_scale_multi_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_val_scale_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_val_scale_down_multi_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_val_scale_down_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_val_set_at(IntPtr arg0, int arg1, IntPtr arg2);
    public static extern IntPtr isl_multi_val_set_range_tuple_id(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_val_size(IntPtr arg0);
    public static extern IntPtr isl_multi_val_get_space(IntPtr arg0);
    public static extern IntPtr isl_multi_val_sub(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_multi_val_zero(IntPtr arg0);
    public static extern IntPtr isl_multi_val_copy(IntPtr arg0);
    public static extern IntPtr isl_multi_val_free(IntPtr arg0);
    public static extern IntPtr isl_multi_val_to_str(IntPtr arg0);
}

public class pointbasic_set
{
    private Context ctx;
    private IntPtr ptr;
    public point(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_point_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_point_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer multi_val(Pointer arg0)
    {
        var res = Interop.isl_point_get_multi_val(arg0.ptr);
        var obj = new multi_val(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer to_set(Pointer arg0)
    {
        var res = Interop.isl_point_to_set(Interop.isl_point_copy(arg0.ptr));
        var obj = new set(ctx = ctx, ptr = res);
        return obj;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_point_get_multi_val(IntPtr arg0);
    public static extern IntPtr isl_point_to_set(IntPtr arg0);
    public static extern IntPtr isl_point_copy(IntPtr arg0);
    public static extern IntPtr isl_point_free(IntPtr arg0);
    public static extern IntPtr isl_point_to_str(IntPtr arg0);
}

public class pw_aff_list
{
    private Context ctx;
    private IntPtr ptr;
    public pw_aff_list(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public pw_aff_list(int args_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_pw_aff_list_alloc(this.ctx, args[0])
    }
    public pw_aff_list(pw_aff arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_pw_aff_list_from_pw_aff(Interop.isl_pw_aff_copy(args[0].ptr))
    }
    public pw_aff_list(string arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_pw_aff_list_read_from_str(this.ctx, args[0].encode('ascii'))
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_pw_aff_list_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_pw_aff_list_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer add(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_pw_aff_list_add(Interop.isl_pw_aff_list_copy(arg0.ptr), Interop.isl_pw_aff_copy(arg1.ptr));
        var obj = new pw_aff_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer at(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_pw_aff_list_get_at(arg0.ptr, arg1);
        var obj = new pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer clear(Pointer arg0)
    {
        var res = Interop.isl_pw_aff_list_clear(Interop.isl_pw_aff_list_copy(arg0.ptr));
        var obj = new pw_aff_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer concat(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_pw_aff_list_concat(Interop.isl_pw_aff_list_copy(arg0.ptr), Interop.isl_pw_aff_list_copy(arg1.ptr));
        var obj = new pw_aff_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer drop(Pointer arg0, Pointer arg1, Pointer arg2)
    {
        var res = Interop.isl_pw_aff_list_drop(Interop.isl_pw_aff_list_copy(arg0.ptr), arg1, arg2);
        var obj = new pw_aff_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef foreach(Pointer arg0, Pointer arg1) {
        var exc_info = new Exception[1];
    var fn = (IntPtr cb_arg0, IntPtr user) =>
    {
        var cb_cls0 = new pw_aff(ctx: arg0.ctx, ptr: (cb_arg0));
        try
        {
            arg1(cb_cls0);
        }
        catch (Exception e)
        {
            exc_info[0] = e;
            return -1;
        }
        return 0;
    };
    var cb1 = Marshal.GetFunctionPointerForDelegate(cb_func);
    var res = Interop.isl_pw_aff_list_foreach(arg0.ptr, cb1, IntPtr.Zerp);
        if (exc_info[0] is not null) {
            throw exc_info[0];
        }
if (res < 0)
{
    throw new InvalidOperationException();
}
    }
    public Typedef foreach_scc(Pointer arg0, Pointer arg1, Pointer arg2)
{
    var exc_info = new Exception[1];
    var fn = (IntPtr cb_arg0, IntPtr cb_arg1, IntPtr user) =>
    {
        var cb_cls0 = new pw_aff(ctx: arg0.ctx, ptr: Interop.isl_pw_aff_copy(cb_arg0));
        var cb_cls1 = new pw_aff(ctx: arg0.ctx, ptr: Interop.isl_pw_aff_copy(cb_arg1));
        try
        {
            var res = arg1(cb_cls0, cb_cls1);
        }
        catch (Exception e)
        {
            exc_info[0] = e;
            return -1;
        }
        return res;
    };
    var cb1 = Marshal.GetFunctionPointerForDelegate(cb_func);
    var exc_info = new Exception[1];
    var fn = (IntPtr cb_arg0, IntPtr user) =>
    {
        var cb_cls0 = new pw_aff_list(ctx: arg0.ctx, ptr: (cb_arg0));
        try
        {
            arg2(cb_cls0);
        }
        catch (Exception e)
        {
            exc_info[0] = e;
            return -1;
        }
        return 0;
    };
    var cb2 = Marshal.GetFunctionPointerForDelegate(cb_func);
    var res = Interop.isl_pw_aff_list_foreach_scc(arg0.ptr, cb1, IntPtr.Zerp, cb2, IntPtr.Zerp);
    if (exc_info[0] is not null)
    {
        throw exc_info[0];
    }
    if (res < 0)
    {
        throw new InvalidOperationException();
    }
}
public Pointer insert(Pointer arg0, Pointer arg1, Pointer arg2)
{
    var res = Interop.isl_pw_aff_list_insert(Interop.isl_pw_aff_list_copy(arg0.ptr), arg1, Interop.isl_pw_aff_copy(arg2.ptr));
    var obj = new pw_aff_list(ctx = ctx, ptr = res);
    return obj;
}
public Pointer set_at(Pointer arg0, Pointer arg1, Pointer arg2)
{
    var res = Interop.isl_pw_aff_list_set_at(Interop.isl_pw_aff_list_copy(arg0.ptr), arg1, Interop.isl_pw_aff_copy(arg2.ptr));
    var obj = new pw_aff_list(ctx = ctx, ptr = res);
    return obj;
}
public Typedef size(Pointer arg0)
{
    var res = Interop.isl_pw_aff_list_size(arg0.ptr);
    if (res < 0)
    {
        throw new InvalidOperationException();
    }
    return res;
}
}
internal static partial class Interop
{
    public static extern IntPtr isl_pw_aff_list_alloc(Context arg0, int arg1);
    public static extern IntPtr isl_pw_aff_list_from_pw_aff(IntPtr arg0);
    public static extern IntPtr isl_pw_aff_list_read_from_str(Context arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_aff_list_add(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_aff_list_get_at(IntPtr arg0, int arg1);
    public static extern IntPtr isl_pw_aff_list_clear(IntPtr arg0);
    public static extern IntPtr isl_pw_aff_list_concat(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_aff_list_drop(IntPtr arg0, int arg1, int arg2);
    public static extern IntPtr isl_pw_aff_list_foreach(IntPtr arg0, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg1, IntPtr arg2);
    public static extern IntPtr isl_pw_aff_list_foreach_scc(IntPtr arg0, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg1, IntPtr arg2, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg3, IntPtr arg4);
    public static extern IntPtr isl_pw_aff_list_insert(IntPtr arg0, int arg1, IntPtr arg2);
    public static extern IntPtr isl_pw_aff_list_set_at(IntPtr arg0, int arg1, IntPtr arg2);
    public static extern IntPtr isl_pw_aff_list_size(IntPtr arg0);
    public static extern IntPtr isl_pw_aff_list_copy(IntPtr arg0);
    public static extern IntPtr isl_pw_aff_list_free(IntPtr arg0);
    public static extern IntPtr isl_pw_aff_list_to_str(IntPtr arg0);
}

public class pw_multi_aff_list
{
    private Context ctx;
    private IntPtr ptr;
    public pw_multi_aff_list(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public pw_multi_aff_list(int args_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_pw_multi_aff_list_alloc(this.ctx, args[0])
    }
    public pw_multi_aff_list(pw_multi_aff arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_pw_multi_aff_list_from_pw_multi_aff(Interop.isl_pw_multi_aff_copy(args[0].ptr))
    }
    public pw_multi_aff_list(string arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_pw_multi_aff_list_read_from_str(this.ctx, args[0].encode('ascii'))
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_pw_multi_aff_list_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_pw_multi_aff_list_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer add(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_pw_multi_aff_list_add(Interop.isl_pw_multi_aff_list_copy(arg0.ptr), Interop.isl_pw_multi_aff_copy(arg1.ptr));
        var obj = new pw_multi_aff_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer at(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_pw_multi_aff_list_get_at(arg0.ptr, arg1);
        var obj = new pw_multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer clear(Pointer arg0)
    {
        var res = Interop.isl_pw_multi_aff_list_clear(Interop.isl_pw_multi_aff_list_copy(arg0.ptr));
        var obj = new pw_multi_aff_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer concat(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_pw_multi_aff_list_concat(Interop.isl_pw_multi_aff_list_copy(arg0.ptr), Interop.isl_pw_multi_aff_list_copy(arg1.ptr));
        var obj = new pw_multi_aff_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer drop(Pointer arg0, Pointer arg1, Pointer arg2)
    {
        var res = Interop.isl_pw_multi_aff_list_drop(Interop.isl_pw_multi_aff_list_copy(arg0.ptr), arg1, arg2);
        var obj = new pw_multi_aff_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef foreach(Pointer arg0, Pointer arg1) {
        var exc_info = new Exception[1];
    var fn = (IntPtr cb_arg0, IntPtr user) =>
    {
        var cb_cls0 = new pw_multi_aff(ctx: arg0.ctx, ptr: (cb_arg0));
        try
        {
            arg1(cb_cls0);
        }
        catch (Exception e)
        {
            exc_info[0] = e;
            return -1;
        }
        return 0;
    };
    var cb1 = Marshal.GetFunctionPointerForDelegate(cb_func);
    var res = Interop.isl_pw_multi_aff_list_foreach(arg0.ptr, cb1, IntPtr.Zerp);
        if (exc_info[0] is not null) {
            throw exc_info[0];
        }
if (res < 0)
{
    throw new InvalidOperationException();
}
    }
    public Typedef foreach_scc(Pointer arg0, Pointer arg1, Pointer arg2)
{
    var exc_info = new Exception[1];
    var fn = (IntPtr cb_arg0, IntPtr cb_arg1, IntPtr user) =>
    {
        var cb_cls0 = new pw_multi_aff(ctx: arg0.ctx, ptr: Interop.isl_pw_multi_aff_copy(cb_arg0));
        var cb_cls1 = new pw_multi_aff(ctx: arg0.ctx, ptr: Interop.isl_pw_multi_aff_copy(cb_arg1));
        try
        {
            var res = arg1(cb_cls0, cb_cls1);
        }
        catch (Exception e)
        {
            exc_info[0] = e;
            return -1;
        }
        return res;
    };
    var cb1 = Marshal.GetFunctionPointerForDelegate(cb_func);
    var exc_info = new Exception[1];
    var fn = (IntPtr cb_arg0, IntPtr user) =>
    {
        var cb_cls0 = new pw_multi_aff_list(ctx: arg0.ctx, ptr: (cb_arg0));
        try
        {
            arg2(cb_cls0);
        }
        catch (Exception e)
        {
            exc_info[0] = e;
            return -1;
        }
        return 0;
    };
    var cb2 = Marshal.GetFunctionPointerForDelegate(cb_func);
    var res = Interop.isl_pw_multi_aff_list_foreach_scc(arg0.ptr, cb1, IntPtr.Zerp, cb2, IntPtr.Zerp);
    if (exc_info[0] is not null)
    {
        throw exc_info[0];
    }
    if (res < 0)
    {
        throw new InvalidOperationException();
    }
}
public Pointer insert(Pointer arg0, Pointer arg1, Pointer arg2)
{
    var res = Interop.isl_pw_multi_aff_list_insert(Interop.isl_pw_multi_aff_list_copy(arg0.ptr), arg1, Interop.isl_pw_multi_aff_copy(arg2.ptr));
    var obj = new pw_multi_aff_list(ctx = ctx, ptr = res);
    return obj;
}
public Pointer set_at(Pointer arg0, Pointer arg1, Pointer arg2)
{
    var res = Interop.isl_pw_multi_aff_list_set_at(Interop.isl_pw_multi_aff_list_copy(arg0.ptr), arg1, Interop.isl_pw_multi_aff_copy(arg2.ptr));
    var obj = new pw_multi_aff_list(ctx = ctx, ptr = res);
    return obj;
}
public Typedef size(Pointer arg0)
{
    var res = Interop.isl_pw_multi_aff_list_size(arg0.ptr);
    if (res < 0)
    {
        throw new InvalidOperationException();
    }
    return res;
}
}
internal static partial class Interop
{
    public static extern IntPtr isl_pw_multi_aff_list_alloc(Context arg0, int arg1);
    public static extern IntPtr isl_pw_multi_aff_list_from_pw_multi_aff(IntPtr arg0);
    public static extern IntPtr isl_pw_multi_aff_list_read_from_str(Context arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_multi_aff_list_add(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_multi_aff_list_get_at(IntPtr arg0, int arg1);
    public static extern IntPtr isl_pw_multi_aff_list_clear(IntPtr arg0);
    public static extern IntPtr isl_pw_multi_aff_list_concat(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_pw_multi_aff_list_drop(IntPtr arg0, int arg1, int arg2);
    public static extern IntPtr isl_pw_multi_aff_list_foreach(IntPtr arg0, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg1, IntPtr arg2);
    public static extern IntPtr isl_pw_multi_aff_list_foreach_scc(IntPtr arg0, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg1, IntPtr arg2, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg3, IntPtr arg4);
    public static extern IntPtr isl_pw_multi_aff_list_insert(IntPtr arg0, int arg1, IntPtr arg2);
    public static extern IntPtr isl_pw_multi_aff_list_set_at(IntPtr arg0, int arg1, IntPtr arg2);
    public static extern IntPtr isl_pw_multi_aff_list_size(IntPtr arg0);
    public static extern IntPtr isl_pw_multi_aff_list_copy(IntPtr arg0);
    public static extern IntPtr isl_pw_multi_aff_list_free(IntPtr arg0);
    public static extern IntPtr isl_pw_multi_aff_list_to_str(IntPtr arg0);
}

public class schedule
{
    private Context ctx;
    private IntPtr ptr;
    public schedule(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public schedule(string arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_schedule_read_from_str(this.ctx, args[0].encode('ascii'))
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_schedule_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_schedule_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer domain(Pointer arg0)
    {
        var res = Interop.isl_schedule_get_domain(arg0.ptr);
        var obj = new union_set(ctx = ctx, ptr = res);
        return obj;
    }
    public static Pointer from_domain(Pointer arg0)
    {
        var res = Interop.isl_schedule_from_domain(Interop.isl_union_set_copy(arg0.ptr));
        var obj = new schedule(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer map(Pointer arg0)
    {
        var res = Interop.isl_schedule_get_map(arg0.ptr);
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer pullback(union_pw_multi_aff arg_1)
    {
        var res = Interop.isl_schedule_pullback_union_pw_multi_aff(Interop.isl_schedule_copy(args[0].ptr), Interop.isl_union_pw_multi_aff_copy(args[1].ptr));
        var obj = new schedule(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer root(Pointer arg0)
    {
        var res = Interop.isl_schedule_get_root(arg0.ptr);
        var obj = new schedule_node(ctx = ctx, ptr = res);
        return obj;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_schedule_read_from_str(Context arg0, IntPtr arg1);
    public static extern IntPtr isl_schedule_get_domain(IntPtr arg0);
    public static extern IntPtr isl_schedule_from_domain(IntPtr arg0);
    public static extern IntPtr isl_schedule_get_map(IntPtr arg0);
    public static extern IntPtr isl_schedule_pullback_union_pw_multi_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_schedule_get_root(IntPtr arg0);
    public static extern IntPtr isl_schedule_copy(IntPtr arg0);
    public static extern IntPtr isl_schedule_free(IntPtr arg0);
    public static extern IntPtr isl_schedule_to_str(IntPtr arg0);
}

public class schedule_constraints
{
    private Context ctx;
    private IntPtr ptr;
    public schedule_constraints(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public schedule_constraints(string arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_schedule_constraints_read_from_str(this.ctx, args[0].encode('ascii'))
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_schedule_constraints_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_schedule_constraints_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer coincidence(Pointer arg0)
    {
        var res = Interop.isl_schedule_constraints_get_coincidence(arg0.ptr);
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer compute_schedule(Pointer arg0)
    {
        var res = Interop.isl_schedule_constraints_compute_schedule(Interop.isl_schedule_constraints_copy(arg0.ptr));
        var obj = new schedule(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer conditional_validity(Pointer arg0)
    {
        var res = Interop.isl_schedule_constraints_get_conditional_validity(arg0.ptr);
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer conditional_validity_condition(Pointer arg0)
    {
        var res = Interop.isl_schedule_constraints_get_conditional_validity_condition(arg0.ptr);
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer context(Pointer arg0)
    {
        var res = Interop.isl_schedule_constraints_get_context(arg0.ptr);
        var obj = new set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer domain(Pointer arg0)
    {
        var res = Interop.isl_schedule_constraints_get_domain(arg0.ptr);
        var obj = new union_set(ctx = ctx, ptr = res);
        return obj;
    }
    public static Pointer on_domain(Pointer arg0)
    {
        var res = Interop.isl_schedule_constraints_on_domain(Interop.isl_union_set_copy(arg0.ptr));
        var obj = new schedule_constraints(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer proximity(Pointer arg0)
    {
        var res = Interop.isl_schedule_constraints_get_proximity(arg0.ptr);
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer set_coincidence(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_schedule_constraints_set_coincidence(Interop.isl_schedule_constraints_copy(arg0.ptr), Interop.isl_union_map_copy(arg1.ptr));
        var obj = new schedule_constraints(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer set_conditional_validity(Pointer arg0, Pointer arg1, Pointer arg2)
    {
        var res = Interop.isl_schedule_constraints_set_conditional_validity(Interop.isl_schedule_constraints_copy(arg0.ptr), Interop.isl_union_map_copy(arg1.ptr), Interop.isl_union_map_copy(arg2.ptr));
        var obj = new schedule_constraints(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer set_context(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_schedule_constraints_set_context(Interop.isl_schedule_constraints_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
        var obj = new schedule_constraints(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer set_proximity(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_schedule_constraints_set_proximity(Interop.isl_schedule_constraints_copy(arg0.ptr), Interop.isl_union_map_copy(arg1.ptr));
        var obj = new schedule_constraints(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer set_validity(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_schedule_constraints_set_validity(Interop.isl_schedule_constraints_copy(arg0.ptr), Interop.isl_union_map_copy(arg1.ptr));
        var obj = new schedule_constraints(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer validity(Pointer arg0)
    {
        var res = Interop.isl_schedule_constraints_get_validity(arg0.ptr);
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_schedule_constraints_read_from_str(Context arg0, IntPtr arg1);
    public static extern IntPtr isl_schedule_constraints_get_coincidence(IntPtr arg0);
    public static extern IntPtr isl_schedule_constraints_compute_schedule(IntPtr arg0);
    public static extern IntPtr isl_schedule_constraints_get_conditional_validity(IntPtr arg0);
    public static extern IntPtr isl_schedule_constraints_get_conditional_validity_condition(IntPtr arg0);
    public static extern IntPtr isl_schedule_constraints_get_context(IntPtr arg0);
    public static extern IntPtr isl_schedule_constraints_get_domain(IntPtr arg0);
    public static extern IntPtr isl_schedule_constraints_on_domain(IntPtr arg0);
    public static extern IntPtr isl_schedule_constraints_get_proximity(IntPtr arg0);
    public static extern IntPtr isl_schedule_constraints_set_coincidence(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_schedule_constraints_set_conditional_validity(IntPtr arg0, IntPtr arg1, IntPtr arg2);
    public static extern IntPtr isl_schedule_constraints_set_context(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_schedule_constraints_set_proximity(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_schedule_constraints_set_validity(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_schedule_constraints_get_validity(IntPtr arg0);
    public static extern IntPtr isl_schedule_constraints_copy(IntPtr arg0);
    public static extern IntPtr isl_schedule_constraints_free(IntPtr arg0);
    public static extern IntPtr isl_schedule_constraints_to_str(IntPtr arg0);
}

public class schedule_node
{
    private Context ctx;
    private IntPtr ptr;
    public schedule_node(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public schedule_node(schedule_node_band arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_schedule_node_copy(arg0.ptr);
    }
    public schedule_node(schedule_node_context arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_schedule_node_copy(arg0.ptr);
    }
    public schedule_node(schedule_node_domain arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_schedule_node_copy(arg0.ptr);
    }
    public schedule_node(schedule_node_expansion arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_schedule_node_copy(arg0.ptr);
    }
    public schedule_node(schedule_node_extension arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_schedule_node_copy(arg0.ptr);
    }
    public schedule_node(schedule_node_filter arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_schedule_node_copy(arg0.ptr);
    }
    public schedule_node(schedule_node_leaf arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_schedule_node_copy(arg0.ptr);
    }
    public schedule_node(schedule_node_guard arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_schedule_node_copy(arg0.ptr);
    }
    public schedule_node(schedule_node_mark arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_schedule_node_copy(arg0.ptr);
    }
    public schedule_node(schedule_node_sequence arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_schedule_node_copy(arg0.ptr);
    }
    public schedule_node(schedule_node_set arg0)
    {
        this.ctx = arg0.ctx;
        this.ptr = isl.isl_schedule_node_copy(arg0.ptr);
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_schedule_node_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_schedule_node_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer ancestor(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_schedule_node_ancestor(Interop.isl_schedule_node_copy(arg0.ptr), arg1);
        var obj = new schedule_node(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef ancestor_child_position(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_schedule_node_get_ancestor_child_position(arg0.ptr, arg1.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer child(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_schedule_node_child(Interop.isl_schedule_node_copy(arg0.ptr), arg1);
        var obj = new schedule_node(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef child_position(Pointer arg0)
    {
        var res = Interop.isl_schedule_node_get_child_position(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef every_descendant(Pointer arg0, Pointer arg1)
    {
        var exc_info = new Exception[1];
        var fn = (IntPtr cb_arg0, IntPtr user) =>
        {
            var cb_cls0 = new schedule_node(ctx: arg0.ctx, ptr: Interop.isl_schedule_node_copy(cb_arg0));
            try
            {
                var res = arg1(cb_cls0);
            }
            catch (Exception e)
            {
                exc_info[0] = e;
                return -1;
            }
            return res;
        };
        var cb1 = Marshal.GetFunctionPointerForDelegate(cb_func);
        var res = Interop.isl_schedule_node_every_descendant(arg0.ptr, cb1, IntPtr.Zerp);
        if (exc_info[0] is not null)
        {
            throw exc_info[0];
        }
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer first_child(Pointer arg0)
    {
        var res = Interop.isl_schedule_node_first_child(Interop.isl_schedule_node_copy(arg0.ptr));
        var obj = new schedule_node(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef foreach_ancestor_top_down(Pointer arg0, Pointer arg1)
    {
        var exc_info = new Exception[1];
        var fn = (IntPtr cb_arg0, IntPtr user) =>
        {
            var cb_cls0 = new schedule_node(ctx: arg0.ctx, ptr: Interop.isl_schedule_node_copy(cb_arg0));
            try
            {
                arg1(cb_cls0);
            }
            catch (Exception e)
            {
                exc_info[0] = e;
                return -1;
            }
            return 0;
        };
        var cb1 = Marshal.GetFunctionPointerForDelegate(cb_func);
        var res = Interop.isl_schedule_node_foreach_ancestor_top_down(arg0.ptr, cb1, IntPtr.Zerp);
        if (exc_info[0] is not null)
        {
            throw exc_info[0];
        }
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
    }
    public Typedef foreach_descendant_top_down(Pointer arg0, Pointer arg1)
    {
        var exc_info = new Exception[1];
        var fn = (IntPtr cb_arg0, IntPtr user) =>
        {
            var cb_cls0 = new schedule_node(ctx: arg0.ctx, ptr: Interop.isl_schedule_node_copy(cb_arg0));
            try
            {
                var res = arg1(cb_cls0);
            }
            catch (Exception e)
            {
                exc_info[0] = e;
                return -1;
            }
            return res;
        };
        var cb1 = Marshal.GetFunctionPointerForDelegate(cb_func);
        var res = Interop.isl_schedule_node_foreach_descendant_top_down(arg0.ptr, cb1, IntPtr.Zerp);
        if (exc_info[0] is not null)
        {
            throw exc_info[0];
        }
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
    }
    public static Pointer from_domain(Pointer arg0)
    {
        var res = Interop.isl_schedule_node_from_domain(Interop.isl_union_set_copy(arg0.ptr));
        var obj = new schedule_node(ctx = ctx, ptr = res);
        return obj;
    }
    public static Pointer from_extension(Pointer arg0)
    {
        var res = Interop.isl_schedule_node_from_extension(Interop.isl_union_map_copy(arg0.ptr));
        var obj = new schedule_node(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer graft_after(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_schedule_node_graft_after(Interop.isl_schedule_node_copy(arg0.ptr), Interop.isl_schedule_node_copy(arg1.ptr));
        var obj = new schedule_node(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer graft_before(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_schedule_node_graft_before(Interop.isl_schedule_node_copy(arg0.ptr), Interop.isl_schedule_node_copy(arg1.ptr));
        var obj = new schedule_node(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef has_children(Pointer arg0)
    {
        var res = Interop.isl_schedule_node_has_children(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef has_next_sibling(Pointer arg0)
    {
        var res = Interop.isl_schedule_node_has_next_sibling(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef has_parent(Pointer arg0)
    {
        var res = Interop.isl_schedule_node_has_parent(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef has_previous_sibling(Pointer arg0)
    {
        var res = Interop.isl_schedule_node_has_previous_sibling(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer insert_context(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_schedule_node_insert_context(Interop.isl_schedule_node_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
        var obj = new schedule_node(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer insert_filter(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_schedule_node_insert_filter(Interop.isl_schedule_node_copy(arg0.ptr), Interop.isl_union_set_copy(arg1.ptr));
        var obj = new schedule_node(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer insert_guard(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_schedule_node_insert_guard(Interop.isl_schedule_node_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
        var obj = new schedule_node(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer insert_mark(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_schedule_node_insert_mark(Interop.isl_schedule_node_copy(arg0.ptr), Interop.isl_id_copy(arg1.ptr));
        var obj = new schedule_node(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer insert_partial_schedule(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_schedule_node_insert_partial_schedule(Interop.isl_schedule_node_copy(arg0.ptr), Interop.isl_multi_union_pw_aff_copy(arg1.ptr));
        var obj = new schedule_node(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer insert_sequence(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_schedule_node_insert_sequence(Interop.isl_schedule_node_copy(arg0.ptr), Interop.isl_union_set_list_copy(arg1.ptr));
        var obj = new schedule_node(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer insert_set(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_schedule_node_insert_set(Interop.isl_schedule_node_copy(arg0.ptr), Interop.isl_union_set_list_copy(arg1.ptr));
        var obj = new schedule_node(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef is_equal(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_schedule_node_is_equal(arg0.ptr, arg1.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_subtree_anchored(Pointer arg0)
    {
        var res = Interop.isl_schedule_node_is_subtree_anchored(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer map_descendant_bottom_up(Pointer arg0, Pointer arg1)
    {
        var exc_info = new Exception[1];
        var fn = (IntPtr cb_arg0, IntPtr user) =>
        {
            var cb_cls0 = new schedule_node(ctx: arg0.ctx, ptr: (cb_arg0));
            try
            {
                var res = arg1(cb_cls0);
            }
            catch (Exception e)
            {
                exc_info[0] = e;
                return IntPtr.Zero;
            }
            return Interop.isl_schedule_node_copy(res.ptr);
        };
        var cb1 = Marshal.GetFunctionPointerForDelegate(cb_func);
        var res = Interop.isl_schedule_node_map_descendant_bottom_up(Interop.isl_schedule_node_copy(arg0.ptr), cb1, IntPtr.Zerp);
        if (exc_info[0] is not null)
        {
            throw exc_info[0];
        }
        var obj = new schedule_node(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef n_children(Pointer arg0)
    {
        var res = Interop.isl_schedule_node_n_children(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer next_sibling(Pointer arg0)
    {
        var res = Interop.isl_schedule_node_next_sibling(Interop.isl_schedule_node_copy(arg0.ptr));
        var obj = new schedule_node(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer order_after(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_schedule_node_order_after(Interop.isl_schedule_node_copy(arg0.ptr), Interop.isl_union_set_copy(arg1.ptr));
        var obj = new schedule_node(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer order_before(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_schedule_node_order_before(Interop.isl_schedule_node_copy(arg0.ptr), Interop.isl_union_set_copy(arg1.ptr));
        var obj = new schedule_node(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer parent(Pointer arg0)
    {
        var res = Interop.isl_schedule_node_parent(Interop.isl_schedule_node_copy(arg0.ptr));
        var obj = new schedule_node(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer prefix_schedule_multi_union_pw_aff(Pointer arg0)
    {
        var res = Interop.isl_schedule_node_get_prefix_schedule_multi_union_pw_aff(arg0.ptr);
        var obj = new multi_union_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer prefix_schedule_union_map(Pointer arg0)
    {
        var res = Interop.isl_schedule_node_get_prefix_schedule_union_map(arg0.ptr);
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer prefix_schedule_union_pw_multi_aff(Pointer arg0)
    {
        var res = Interop.isl_schedule_node_get_prefix_schedule_union_pw_multi_aff(arg0.ptr);
        var obj = new union_pw_multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer previous_sibling(Pointer arg0)
    {
        var res = Interop.isl_schedule_node_previous_sibling(Interop.isl_schedule_node_copy(arg0.ptr));
        var obj = new schedule_node(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer root(Pointer arg0)
    {
        var res = Interop.isl_schedule_node_root(Interop.isl_schedule_node_copy(arg0.ptr));
        var obj = new schedule_node(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer schedule(Pointer arg0)
    {
        var res = Interop.isl_schedule_node_get_schedule(arg0.ptr);
        var obj = new schedule(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer shared_ancestor(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_schedule_node_get_shared_ancestor(arg0.ptr, arg1.ptr);
        var obj = new schedule_node(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef tree_depth(Pointer arg0)
    {
        var res = Interop.isl_schedule_node_get_tree_depth(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_schedule_node_ancestor(IntPtr arg0, int arg1);
    public static extern IntPtr isl_schedule_node_get_ancestor_child_position(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_schedule_node_child(IntPtr arg0, int arg1);
    public static extern IntPtr isl_schedule_node_get_child_position(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_every_descendant(IntPtr arg0, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg1, IntPtr arg2);
    public static extern IntPtr isl_schedule_node_first_child(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_foreach_ancestor_top_down(IntPtr arg0, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg1, IntPtr arg2);
    public static extern IntPtr isl_schedule_node_foreach_descendant_top_down(IntPtr arg0, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg1, IntPtr arg2);
    public static extern IntPtr isl_schedule_node_from_domain(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_from_extension(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_graft_after(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_schedule_node_graft_before(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_schedule_node_has_children(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_has_next_sibling(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_has_parent(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_has_previous_sibling(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_insert_context(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_schedule_node_insert_filter(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_schedule_node_insert_guard(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_schedule_node_insert_mark(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_schedule_node_insert_partial_schedule(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_schedule_node_insert_sequence(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_schedule_node_insert_set(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_schedule_node_is_equal(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_schedule_node_is_subtree_anchored(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_map_descendant_bottom_up(IntPtr arg0, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg1, IntPtr arg2);
    public static extern IntPtr isl_schedule_node_n_children(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_next_sibling(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_order_after(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_schedule_node_order_before(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_schedule_node_parent(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_get_prefix_schedule_multi_union_pw_aff(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_get_prefix_schedule_union_map(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_get_prefix_schedule_union_pw_multi_aff(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_previous_sibling(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_root(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_get_schedule(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_get_shared_ancestor(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_schedule_node_get_tree_depth(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_copy(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_free(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_to_str(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_get_type(IntPtr arg0);
}

public class schedule_node_band : schedule_node
{
    private Context ctx;
    private IntPtr ptr;
    public schedule_node_band(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_schedule_node_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_schedule_node_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer ast_build_options(Pointer arg0)
    {
        var res = Interop.isl_schedule_node_band_get_ast_build_options(arg0.ptr);
        var obj = new union_set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer ast_isolate_option(Pointer arg0)
    {
        var res = Interop.isl_schedule_node_band_get_ast_isolate_option(arg0.ptr);
        var obj = new set(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef member_get_coincident(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_schedule_node_band_member_get_coincident(arg0.ptr, arg1);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer member_set_coincident(Pointer arg0, Pointer arg1, Pointer arg2)
    {
        var res = Interop.isl_schedule_node_band_member_set_coincident(Interop.isl_schedule_node_copy(arg0.ptr), arg1, arg2);
        var obj = new schedule_node(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer mod(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_schedule_node_band_mod(Interop.isl_schedule_node_copy(arg0.ptr), Interop.isl_multi_val_copy(arg1.ptr));
        var obj = new schedule_node(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef n_member(Pointer arg0)
    {
        var res = Interop.isl_schedule_node_band_n_member(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer partial_schedule(Pointer arg0)
    {
        var res = Interop.isl_schedule_node_band_get_partial_schedule(arg0.ptr);
        var obj = new multi_union_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef permutable(Pointer arg0)
    {
        var res = Interop.isl_schedule_node_band_get_permutable(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer scale(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_schedule_node_band_scale(Interop.isl_schedule_node_copy(arg0.ptr), Interop.isl_multi_val_copy(arg1.ptr));
        var obj = new schedule_node(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer scale_down(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_schedule_node_band_scale_down(Interop.isl_schedule_node_copy(arg0.ptr), Interop.isl_multi_val_copy(arg1.ptr));
        var obj = new schedule_node(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer set_ast_build_options(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_schedule_node_band_set_ast_build_options(Interop.isl_schedule_node_copy(arg0.ptr), Interop.isl_union_set_copy(arg1.ptr));
        var obj = new schedule_node(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer set_permutable(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_schedule_node_band_set_permutable(Interop.isl_schedule_node_copy(arg0.ptr), arg1);
        var obj = new schedule_node(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer shift(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_schedule_node_band_shift(Interop.isl_schedule_node_copy(arg0.ptr), Interop.isl_multi_union_pw_aff_copy(arg1.ptr));
        var obj = new schedule_node(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer split(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_schedule_node_band_split(Interop.isl_schedule_node_copy(arg0.ptr), arg1);
        var obj = new schedule_node(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer tile(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_schedule_node_band_tile(Interop.isl_schedule_node_copy(arg0.ptr), Interop.isl_multi_val_copy(arg1.ptr));
        var obj = new schedule_node(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer member_set_ast_loop_default(arg0, arg1)
    {
        try:
            if not arg0.__class__ is schedule_node:
                arg0 = schedule_node(arg0)
        except:
        raise
    ctx = arg0.ctx
        res = isl.isl_schedule_node_band_member_set_ast_loop_type(Interop.isl_schedule_node_copy(arg0.ptr), arg1, 0)
        var obj = new schedule_node(ctx = ctx, ptr = res);
        return obj;
        }
    public Pointer member_set_ast_loop_atomic(arg0, arg1)
        {
            try:
            if not arg0.__class__ is schedule_node:
                arg0 = schedule_node(arg0)
        except:
        raise
    ctx = arg0.ctx
        res = isl.isl_schedule_node_band_member_set_ast_loop_type(Interop.isl_schedule_node_copy(arg0.ptr), arg1, 1)
        var obj = new schedule_node(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer member_set_ast_loop_unroll(arg0, arg1)
    {
        try:
            if not arg0.__class__ is schedule_node:
                arg0 = schedule_node(arg0)
        except:
        raise
    ctx = arg0.ctx
        res = isl.isl_schedule_node_band_member_set_ast_loop_type(Interop.isl_schedule_node_copy(arg0.ptr), arg1, 2)
        var obj = new schedule_node(ctx = ctx, ptr = res);
        return obj;
        }
    public Pointer member_set_ast_loop_separate(arg0, arg1)
        {
            try:
            if not arg0.__class__ is schedule_node:
                arg0 = schedule_node(arg0)
        except:
        raise
    ctx = arg0.ctx
        res = isl.isl_schedule_node_band_member_set_ast_loop_type(Interop.isl_schedule_node_copy(arg0.ptr), arg1, 3)
        var obj = new schedule_node(ctx = ctx, ptr = res);
        return obj;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_schedule_node_band_get_ast_build_options(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_band_get_ast_isolate_option(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_band_member_get_coincident(IntPtr arg0, int arg1);
    public static extern IntPtr isl_schedule_node_band_member_set_coincident(IntPtr arg0, int arg1, int arg2);
    public static extern IntPtr isl_schedule_node_band_mod(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_schedule_node_band_n_member(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_band_get_partial_schedule(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_band_get_permutable(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_band_scale(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_schedule_node_band_scale_down(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_schedule_node_band_set_ast_build_options(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_schedule_node_band_set_permutable(IntPtr arg0, int arg1);
    public static extern IntPtr isl_schedule_node_band_shift(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_schedule_node_band_split(IntPtr arg0, int arg1);
    public static extern IntPtr isl_schedule_node_band_tile(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_schedule_node_band_member_set_ast_loop_type(IntPtr arg0, int arg1, int arg2);
    public static extern IntPtr isl_schedule_node_copy(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_free(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_to_str(IntPtr arg0);
}

public class schedule_node_context : schedule_node
{
    private Context ctx;
    private IntPtr ptr;
    public schedule_node_context(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_schedule_node_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_schedule_node_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer context(Pointer arg0)
    {
        var res = Interop.isl_schedule_node_context_get_context(arg0.ptr);
        var obj = new set(ctx = ctx, ptr = res);
        return obj;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_schedule_node_context_get_context(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_copy(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_free(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_to_str(IntPtr arg0);
}

public class schedule_node_domain : schedule_node
{
    private Context ctx;
    private IntPtr ptr;
    public schedule_node_domain(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_schedule_node_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_schedule_node_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer domain(Pointer arg0)
    {
        var res = Interop.isl_schedule_node_domain_get_domain(arg0.ptr);
        var obj = new union_set(ctx = ctx, ptr = res);
        return obj;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_schedule_node_domain_get_domain(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_copy(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_free(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_to_str(IntPtr arg0);
}

public class schedule_node_expansion : schedule_node
{
    private Context ctx;
    private IntPtr ptr;
    public schedule_node_expansion(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_schedule_node_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_schedule_node_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer contraction(Pointer arg0)
    {
        var res = Interop.isl_schedule_node_expansion_get_contraction(arg0.ptr);
        var obj = new union_pw_multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer expansion(Pointer arg0)
    {
        var res = Interop.isl_schedule_node_expansion_get_expansion(arg0.ptr);
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_schedule_node_expansion_get_contraction(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_expansion_get_expansion(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_copy(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_free(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_to_str(IntPtr arg0);
}

public class schedule_node_extension : schedule_node
{
    private Context ctx;
    private IntPtr ptr;
    public schedule_node_extension(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_schedule_node_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_schedule_node_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer extension(Pointer arg0)
    {
        var res = Interop.isl_schedule_node_extension_get_extension(arg0.ptr);
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_schedule_node_extension_get_extension(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_copy(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_free(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_to_str(IntPtr arg0);
}

public class schedule_node_filter : schedule_node
{
    private Context ctx;
    private IntPtr ptr;
    public schedule_node_filter(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_schedule_node_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_schedule_node_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer filter(Pointer arg0)
    {
        var res = Interop.isl_schedule_node_filter_get_filter(arg0.ptr);
        var obj = new union_set(ctx = ctx, ptr = res);
        return obj;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_schedule_node_filter_get_filter(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_copy(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_free(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_to_str(IntPtr arg0);
}

public class schedule_node_guard : schedule_node
{
    private Context ctx;
    private IntPtr ptr;
    public schedule_node_guard(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_schedule_node_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_schedule_node_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer guard(Pointer arg0)
    {
        var res = Interop.isl_schedule_node_guard_get_guard(arg0.ptr);
        var obj = new set(ctx = ctx, ptr = res);
        return obj;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_schedule_node_guard_get_guard(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_copy(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_free(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_to_str(IntPtr arg0);
}

public class schedule_node_leaf : schedule_node
{
    private Context ctx;
    private IntPtr ptr;
    public schedule_node_leaf(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_schedule_node_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_schedule_node_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_schedule_node_copy(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_free(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_to_str(IntPtr arg0);
}

public class schedule_node_mark : schedule_node
{
    private Context ctx;
    private IntPtr ptr;
    public schedule_node_mark(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_schedule_node_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_schedule_node_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_schedule_node_copy(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_free(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_to_str(IntPtr arg0);
}

public class schedule_node_sequence : schedule_node
{
    private Context ctx;
    private IntPtr ptr;
    public schedule_node_sequence(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_schedule_node_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_schedule_node_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_schedule_node_copy(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_free(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_to_str(IntPtr arg0);
}

public class schedule_node_set : schedule_node
{
    private Context ctx;
    private IntPtr ptr;
    public schedule_node_set(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_schedule_node_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_schedule_node_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_schedule_node_copy(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_free(IntPtr arg0);
    public static extern IntPtr isl_schedule_node_to_str(IntPtr arg0);
}

public class set_list
{
    private Context ctx;
    private IntPtr ptr;
    public set_list(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public set_list(int args_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_set_list_alloc(this.ctx, args[0])
    }
    public set_list(set arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_set_list_from_set(Interop.isl_set_copy(args[0].ptr))
    }
    public set_list(string arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_set_list_read_from_str(this.ctx, args[0].encode('ascii'))
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_set_list_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_set_list_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer add(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_set_list_add(Interop.isl_set_list_copy(arg0.ptr), Interop.isl_set_copy(arg1.ptr));
        var obj = new set_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer at(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_set_list_get_at(arg0.ptr, arg1);
        var obj = new set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer clear(Pointer arg0)
    {
        var res = Interop.isl_set_list_clear(Interop.isl_set_list_copy(arg0.ptr));
        var obj = new set_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer concat(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_set_list_concat(Interop.isl_set_list_copy(arg0.ptr), Interop.isl_set_list_copy(arg1.ptr));
        var obj = new set_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer drop(Pointer arg0, Pointer arg1, Pointer arg2)
    {
        var res = Interop.isl_set_list_drop(Interop.isl_set_list_copy(arg0.ptr), arg1, arg2);
        var obj = new set_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef foreach(Pointer arg0, Pointer arg1) {
        var exc_info = new Exception[1];
    var fn = (IntPtr cb_arg0, IntPtr user) =>
    {
        var cb_cls0 = new set(ctx: arg0.ctx, ptr: (cb_arg0));
        try
        {
            arg1(cb_cls0);
        }
        catch (Exception e)
        {
            exc_info[0] = e;
            return -1;
        }
        return 0;
    };
    var cb1 = Marshal.GetFunctionPointerForDelegate(cb_func);
    var res = Interop.isl_set_list_foreach(arg0.ptr, cb1, IntPtr.Zerp);
        if (exc_info[0] is not null) {
            throw exc_info[0];
        }
if (res < 0)
{
    throw new InvalidOperationException();
}
    }
    public Typedef foreach_scc(Pointer arg0, Pointer arg1, Pointer arg2)
{
    var exc_info = new Exception[1];
    var fn = (IntPtr cb_arg0, IntPtr cb_arg1, IntPtr user) =>
    {
        var cb_cls0 = new set(ctx: arg0.ctx, ptr: Interop.isl_set_copy(cb_arg0));
        var cb_cls1 = new set(ctx: arg0.ctx, ptr: Interop.isl_set_copy(cb_arg1));
        try
        {
            var res = arg1(cb_cls0, cb_cls1);
        }
        catch (Exception e)
        {
            exc_info[0] = e;
            return -1;
        }
        return res;
    };
    var cb1 = Marshal.GetFunctionPointerForDelegate(cb_func);
    var exc_info = new Exception[1];
    var fn = (IntPtr cb_arg0, IntPtr user) =>
    {
        var cb_cls0 = new set_list(ctx: arg0.ctx, ptr: (cb_arg0));
        try
        {
            arg2(cb_cls0);
        }
        catch (Exception e)
        {
            exc_info[0] = e;
            return -1;
        }
        return 0;
    };
    var cb2 = Marshal.GetFunctionPointerForDelegate(cb_func);
    var res = Interop.isl_set_list_foreach_scc(arg0.ptr, cb1, IntPtr.Zerp, cb2, IntPtr.Zerp);
    if (exc_info[0] is not null)
    {
        throw exc_info[0];
    }
    if (res < 0)
    {
        throw new InvalidOperationException();
    }
}
public Pointer insert(Pointer arg0, Pointer arg1, Pointer arg2)
{
    var res = Interop.isl_set_list_insert(Interop.isl_set_list_copy(arg0.ptr), arg1, Interop.isl_set_copy(arg2.ptr));
    var obj = new set_list(ctx = ctx, ptr = res);
    return obj;
}
public Pointer set_at(Pointer arg0, Pointer arg1, Pointer arg2)
{
    var res = Interop.isl_set_list_set_at(Interop.isl_set_list_copy(arg0.ptr), arg1, Interop.isl_set_copy(arg2.ptr));
    var obj = new set_list(ctx = ctx, ptr = res);
    return obj;
}
public Typedef size(Pointer arg0)
{
    var res = Interop.isl_set_list_size(arg0.ptr);
    if (res < 0)
    {
        throw new InvalidOperationException();
    }
    return res;
}
}
internal static partial class Interop
{
    public static extern IntPtr isl_set_list_alloc(Context arg0, int arg1);
    public static extern IntPtr isl_set_list_from_set(IntPtr arg0);
    public static extern IntPtr isl_set_list_read_from_str(Context arg0, IntPtr arg1);
    public static extern IntPtr isl_set_list_add(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_set_list_get_at(IntPtr arg0, int arg1);
    public static extern IntPtr isl_set_list_clear(IntPtr arg0);
    public static extern IntPtr isl_set_list_concat(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_set_list_drop(IntPtr arg0, int arg1, int arg2);
    public static extern IntPtr isl_set_list_foreach(IntPtr arg0, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg1, IntPtr arg2);
    public static extern IntPtr isl_set_list_foreach_scc(IntPtr arg0, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg1, IntPtr arg2, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg3, IntPtr arg4);
    public static extern IntPtr isl_set_list_insert(IntPtr arg0, int arg1, IntPtr arg2);
    public static extern IntPtr isl_set_list_set_at(IntPtr arg0, int arg1, IntPtr arg2);
    public static extern IntPtr isl_set_list_size(IntPtr arg0);
    public static extern IntPtr isl_set_list_copy(IntPtr arg0);
    public static extern IntPtr isl_set_list_free(IntPtr arg0);
    public static extern IntPtr isl_set_list_to_str(IntPtr arg0);
}

public class space
{
    private Context ctx;
    private IntPtr ptr;
    public space(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public space(string arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_space_read_from_str(this.ctx, args[0].encode('ascii'))
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_space_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_space_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer add_named_tuple(id arg_1int args_2)
    {
        var res = Interop.isl_space_add_named_tuple_id_ui(Interop.isl_space_copy(args[0].ptr), Interop.isl_id_copy(args[1].ptr), args[2]);
        var obj = new space(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer add_param(id arg_1)
    {
        var res = Interop.isl_space_add_param_id(Interop.isl_space_copy(args[0].ptr), Interop.isl_id_copy(args[1].ptr));
        var obj = new space(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer add_unnamed_tuple(int args_1)
    {
        var res = Interop.isl_space_add_unnamed_tuple_ui(Interop.isl_space_copy(args[0].ptr), args[1]);
        var obj = new space(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer curry(Pointer arg0)
    {
        var res = Interop.isl_space_curry(Interop.isl_space_copy(arg0.ptr));
        var obj = new space(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer domain(Pointer arg0)
    {
        var res = Interop.isl_space_domain(Interop.isl_space_copy(arg0.ptr));
        var obj = new space(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer domain_map_multi_aff(Pointer arg0)
    {
        var res = Interop.isl_space_domain_map_multi_aff(Interop.isl_space_copy(arg0.ptr));
        var obj = new multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer domain_map_pw_multi_aff(Pointer arg0)
    {
        var res = Interop.isl_space_domain_map_pw_multi_aff(Interop.isl_space_copy(arg0.ptr));
        var obj = new pw_multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer domain_reverse(Pointer arg0)
    {
        var res = Interop.isl_space_domain_reverse(Interop.isl_space_copy(arg0.ptr));
        var obj = new space(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer domain_tuple_id(Pointer arg0)
    {
        var res = Interop.isl_space_get_domain_tuple_id(arg0.ptr);
        var obj = new id(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer drop_all_params(Pointer arg0)
    {
        var res = Interop.isl_space_drop_all_params(Interop.isl_space_copy(arg0.ptr));
        var obj = new space(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer flatten_domain(Pointer arg0)
    {
        var res = Interop.isl_space_flatten_domain(Interop.isl_space_copy(arg0.ptr));
        var obj = new space(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer flatten_range(Pointer arg0)
    {
        var res = Interop.isl_space_flatten_range(Interop.isl_space_copy(arg0.ptr));
        var obj = new space(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef has_domain_tuple_id(Pointer arg0)
    {
        var res = Interop.isl_space_has_domain_tuple_id(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef has_range_tuple_id(Pointer arg0)
    {
        var res = Interop.isl_space_has_range_tuple_id(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer identity_multi_aff_on_domain(Pointer arg0)
    {
        var res = Interop.isl_space_identity_multi_aff_on_domain(Interop.isl_space_copy(arg0.ptr));
        var obj = new multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer identity_multi_pw_aff_on_domain(Pointer arg0)
    {
        var res = Interop.isl_space_identity_multi_pw_aff_on_domain(Interop.isl_space_copy(arg0.ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer identity_pw_multi_aff_on_domain(Pointer arg0)
    {
        var res = Interop.isl_space_identity_pw_multi_aff_on_domain(Interop.isl_space_copy(arg0.ptr));
        var obj = new pw_multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef is_equal(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_space_is_equal(arg0.ptr, arg1.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_wrapping(Pointer arg0)
    {
        var res = Interop.isl_space_is_wrapping(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer map_from_set(Pointer arg0)
    {
        var res = Interop.isl_space_map_from_set(Interop.isl_space_copy(arg0.ptr));
        var obj = new space(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer multi_aff(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_space_multi_aff(Interop.isl_space_copy(arg0.ptr), Interop.isl_aff_list_copy(arg1.ptr));
        var obj = new multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer multi_aff_on_domain(multi_val arg_1)
    {
        var res = Interop.isl_space_multi_aff_on_domain_multi_val(Interop.isl_space_copy(args[0].ptr), Interop.isl_multi_val_copy(args[1].ptr));
        var obj = new multi_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer multi_id(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_space_multi_id(Interop.isl_space_copy(arg0.ptr), Interop.isl_id_list_copy(arg1.ptr));
        var obj = new multi_id(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer multi_pw_aff(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_space_multi_pw_aff(Interop.isl_space_copy(arg0.ptr), Interop.isl_pw_aff_list_copy(arg1.ptr));
        var obj = new multi_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer multi_union_pw_aff(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_space_multi_union_pw_aff(Interop.isl_space_copy(arg0.ptr), Interop.isl_union_pw_aff_list_copy(arg1.ptr));
        var obj = new multi_union_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer multi_val(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_space_multi_val(Interop.isl_space_copy(arg0.ptr), Interop.isl_val_list_copy(arg1.ptr));
        var obj = new multi_val(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer param_aff_on_domain(id arg_1)
    {
        var res = Interop.isl_space_param_aff_on_domain_id(Interop.isl_space_copy(args[0].ptr), Interop.isl_id_copy(args[1].ptr));
        var obj = new aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer params(Pointer arg0) {
        var res = Interop.isl_space_params(Interop.isl_space_copy(arg0.ptr));
    var obj = new space(ctx = ctx, ptr = res);
        return obj;
    }
public Pointer product(Pointer arg0, Pointer arg1)
{
    var res = Interop.isl_space_product(Interop.isl_space_copy(arg0.ptr), Interop.isl_space_copy(arg1.ptr));
    var obj = new space(ctx = ctx, ptr = res);
    return obj;
}
public Pointer range(Pointer arg0)
{
    var res = Interop.isl_space_range(Interop.isl_space_copy(arg0.ptr));
    var obj = new space(ctx = ctx, ptr = res);
    return obj;
}
public Pointer range_map_multi_aff(Pointer arg0)
{
    var res = Interop.isl_space_range_map_multi_aff(Interop.isl_space_copy(arg0.ptr));
    var obj = new multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer range_map_pw_multi_aff(Pointer arg0)
{
    var res = Interop.isl_space_range_map_pw_multi_aff(Interop.isl_space_copy(arg0.ptr));
    var obj = new pw_multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer range_reverse(Pointer arg0)
{
    var res = Interop.isl_space_range_reverse(Interop.isl_space_copy(arg0.ptr));
    var obj = new space(ctx = ctx, ptr = res);
    return obj;
}
public Pointer range_tuple_id(Pointer arg0)
{
    var res = Interop.isl_space_get_range_tuple_id(arg0.ptr);
    var obj = new id(ctx = ctx, ptr = res);
    return obj;
}
public Pointer reverse(Pointer arg0)
{
    var res = Interop.isl_space_reverse(Interop.isl_space_copy(arg0.ptr));
    var obj = new space(ctx = ctx, ptr = res);
    return obj;
}
public Pointer set_domain_tuple(id arg_1)
{
    var res = Interop.isl_space_set_domain_tuple_id(Interop.isl_space_copy(args[0].ptr), Interop.isl_id_copy(args[1].ptr));
    var obj = new space(ctx = ctx, ptr = res);
    return obj;
}
public Pointer set_range_tuple(id arg_1)
{
    var res = Interop.isl_space_set_range_tuple_id(Interop.isl_space_copy(args[0].ptr), Interop.isl_id_copy(args[1].ptr));
    var obj = new space(ctx = ctx, ptr = res);
    return obj;
}
public Pointer uncurry(Pointer arg0)
{
    var res = Interop.isl_space_uncurry(Interop.isl_space_copy(arg0.ptr));
    var obj = new space(ctx = ctx, ptr = res);
    return obj;
}
public static Pointer unit()
{
    var ctx = Context.DefaultInstance;
    var res = Interop.isl_space_unit(ctx);
    var obj = new space(ctx = ctx, ptr = res);
    return obj;
}
public Pointer universe_map(Pointer arg0)
{
    var res = Interop.isl_space_universe_map(Interop.isl_space_copy(arg0.ptr));
    var obj = new map(ctx = ctx, ptr = res);
    return obj;
}
public Pointer universe_set(Pointer arg0)
{
    var res = Interop.isl_space_universe_set(Interop.isl_space_copy(arg0.ptr));
    var obj = new set(ctx = ctx, ptr = res);
    return obj;
}
public Pointer unwrap(Pointer arg0)
{
    var res = Interop.isl_space_unwrap(Interop.isl_space_copy(arg0.ptr));
    var obj = new space(ctx = ctx, ptr = res);
    return obj;
}
public Pointer wrap(Pointer arg0)
{
    var res = Interop.isl_space_wrap(Interop.isl_space_copy(arg0.ptr));
    var obj = new space(ctx = ctx, ptr = res);
    return obj;
}
public Pointer wrapped_reverse(Pointer arg0)
{
    var res = Interop.isl_space_wrapped_reverse(Interop.isl_space_copy(arg0.ptr));
    var obj = new space(ctx = ctx, ptr = res);
    return obj;
}
public Pointer zero_aff_on_domain(Pointer arg0)
{
    var res = Interop.isl_space_zero_aff_on_domain(Interop.isl_space_copy(arg0.ptr));
    var obj = new aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer zero_multi_aff(Pointer arg0)
{
    var res = Interop.isl_space_zero_multi_aff(Interop.isl_space_copy(arg0.ptr));
    var obj = new multi_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer zero_multi_pw_aff(Pointer arg0)
{
    var res = Interop.isl_space_zero_multi_pw_aff(Interop.isl_space_copy(arg0.ptr));
    var obj = new multi_pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer zero_multi_union_pw_aff(Pointer arg0)
{
    var res = Interop.isl_space_zero_multi_union_pw_aff(Interop.isl_space_copy(arg0.ptr));
    var obj = new multi_union_pw_aff(ctx = ctx, ptr = res);
    return obj;
}
public Pointer zero_multi_val(Pointer arg0)
{
    var res = Interop.isl_space_zero_multi_val(Interop.isl_space_copy(arg0.ptr));
    var obj = new multi_val(ctx = ctx, ptr = res);
    return obj;
}
}
internal static partial class Interop
{
    public static extern IntPtr isl_space_read_from_str(Context arg0, IntPtr arg1);
    public static extern IntPtr isl_space_add_named_tuple_id_ui(IntPtr arg0, IntPtr arg1, int arg2);
    public static extern IntPtr isl_space_add_param_id(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_space_add_unnamed_tuple_ui(IntPtr arg0, int arg1);
    public static extern IntPtr isl_space_curry(IntPtr arg0);
    public static extern IntPtr isl_space_domain(IntPtr arg0);
    public static extern IntPtr isl_space_domain_map_multi_aff(IntPtr arg0);
    public static extern IntPtr isl_space_domain_map_pw_multi_aff(IntPtr arg0);
    public static extern IntPtr isl_space_domain_reverse(IntPtr arg0);
    public static extern IntPtr isl_space_get_domain_tuple_id(IntPtr arg0);
    public static extern IntPtr isl_space_drop_all_params(IntPtr arg0);
    public static extern IntPtr isl_space_flatten_domain(IntPtr arg0);
    public static extern IntPtr isl_space_flatten_range(IntPtr arg0);
    public static extern IntPtr isl_space_has_domain_tuple_id(IntPtr arg0);
    public static extern IntPtr isl_space_has_range_tuple_id(IntPtr arg0);
    public static extern IntPtr isl_space_identity_multi_aff_on_domain(IntPtr arg0);
    public static extern IntPtr isl_space_identity_multi_pw_aff_on_domain(IntPtr arg0);
    public static extern IntPtr isl_space_identity_pw_multi_aff_on_domain(IntPtr arg0);
    public static extern IntPtr isl_space_is_equal(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_space_is_wrapping(IntPtr arg0);
    public static extern IntPtr isl_space_map_from_set(IntPtr arg0);
    public static extern IntPtr isl_space_multi_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_space_multi_aff_on_domain_multi_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_space_multi_id(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_space_multi_pw_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_space_multi_union_pw_aff(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_space_multi_val(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_space_param_aff_on_domain_id(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_space_params(IntPtr arg0);
    public static extern IntPtr isl_space_product(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_space_range(IntPtr arg0);
    public static extern IntPtr isl_space_range_map_multi_aff(IntPtr arg0);
    public static extern IntPtr isl_space_range_map_pw_multi_aff(IntPtr arg0);
    public static extern IntPtr isl_space_range_reverse(IntPtr arg0);
    public static extern IntPtr isl_space_get_range_tuple_id(IntPtr arg0);
    public static extern IntPtr isl_space_reverse(IntPtr arg0);
    public static extern IntPtr isl_space_set_domain_tuple_id(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_space_set_range_tuple_id(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_space_uncurry(IntPtr arg0);
    public static extern IntPtr isl_space_unit(Context arg0);
    public static extern IntPtr isl_space_universe_map(IntPtr arg0);
    public static extern IntPtr isl_space_universe_set(IntPtr arg0);
    public static extern IntPtr isl_space_unwrap(IntPtr arg0);
    public static extern IntPtr isl_space_wrap(IntPtr arg0);
    public static extern IntPtr isl_space_wrapped_reverse(IntPtr arg0);
    public static extern IntPtr isl_space_zero_aff_on_domain(IntPtr arg0);
    public static extern IntPtr isl_space_zero_multi_aff(IntPtr arg0);
    public static extern IntPtr isl_space_zero_multi_pw_aff(IntPtr arg0);
    public static extern IntPtr isl_space_zero_multi_union_pw_aff(IntPtr arg0);
    public static extern IntPtr isl_space_zero_multi_val(IntPtr arg0);
    public static extern IntPtr isl_space_copy(IntPtr arg0);
    public static extern IntPtr isl_space_free(IntPtr arg0);
    public static extern IntPtr isl_space_to_str(IntPtr arg0);
}

public class union_access_info
{
    private Context ctx;
    private IntPtr ptr;
    public union_access_info(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public union_access_info(union_map arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_union_access_info_from_sink(Interop.isl_union_map_copy(args[0].ptr))
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_union_access_info_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_union_access_info_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer compute_flow(Pointer arg0)
    {
        var res = Interop.isl_union_access_info_compute_flow(Interop.isl_union_access_info_copy(arg0.ptr));
        var obj = new union_flow(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer set_kill(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_access_info_set_kill(Interop.isl_union_access_info_copy(arg0.ptr), Interop.isl_union_map_copy(arg1.ptr));
        var obj = new union_access_info(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer set_may_source(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_access_info_set_may_source(Interop.isl_union_access_info_copy(arg0.ptr), Interop.isl_union_map_copy(arg1.ptr));
        var obj = new union_access_info(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer set_must_source(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_access_info_set_must_source(Interop.isl_union_access_info_copy(arg0.ptr), Interop.isl_union_map_copy(arg1.ptr));
        var obj = new union_access_info(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer set_schedule(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_access_info_set_schedule(Interop.isl_union_access_info_copy(arg0.ptr), Interop.isl_schedule_copy(arg1.ptr));
        var obj = new union_access_info(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer set_schedule_map(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_access_info_set_schedule_map(Interop.isl_union_access_info_copy(arg0.ptr), Interop.isl_union_map_copy(arg1.ptr));
        var obj = new union_access_info(ctx = ctx, ptr = res);
        return obj;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_union_access_info_from_sink(IntPtr arg0);
    public static extern IntPtr isl_union_access_info_compute_flow(IntPtr arg0);
    public static extern IntPtr isl_union_access_info_set_kill(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_access_info_set_may_source(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_access_info_set_must_source(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_access_info_set_schedule(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_access_info_set_schedule_map(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_access_info_copy(IntPtr arg0);
    public static extern IntPtr isl_union_access_info_free(IntPtr arg0);
    public static extern IntPtr isl_union_access_info_to_str(IntPtr arg0);
}

public class union_flow
{
    private Context ctx;
    private IntPtr ptr;
    public union_flow(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_union_flow_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_union_flow_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer full_may_dependence(Pointer arg0)
    {
        var res = Interop.isl_union_flow_get_full_may_dependence(arg0.ptr);
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer full_must_dependence(Pointer arg0)
    {
        var res = Interop.isl_union_flow_get_full_must_dependence(arg0.ptr);
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer may_dependence(Pointer arg0)
    {
        var res = Interop.isl_union_flow_get_may_dependence(arg0.ptr);
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer may_no_source(Pointer arg0)
    {
        var res = Interop.isl_union_flow_get_may_no_source(arg0.ptr);
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer must_dependence(Pointer arg0)
    {
        var res = Interop.isl_union_flow_get_must_dependence(arg0.ptr);
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer must_no_source(Pointer arg0)
    {
        var res = Interop.isl_union_flow_get_must_no_source(arg0.ptr);
        var obj = new union_map(ctx = ctx, ptr = res);
        return obj;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_union_flow_get_full_may_dependence(IntPtr arg0);
    public static extern IntPtr isl_union_flow_get_full_must_dependence(IntPtr arg0);
    public static extern IntPtr isl_union_flow_get_may_dependence(IntPtr arg0);
    public static extern IntPtr isl_union_flow_get_may_no_source(IntPtr arg0);
    public static extern IntPtr isl_union_flow_get_must_dependence(IntPtr arg0);
    public static extern IntPtr isl_union_flow_get_must_no_source(IntPtr arg0);
    public static extern IntPtr isl_union_flow_copy(IntPtr arg0);
    public static extern IntPtr isl_union_flow_free(IntPtr arg0);
    public static extern IntPtr isl_union_flow_to_str(IntPtr arg0);
}

public class union_pw_aff_list
{
    private Context ctx;
    private IntPtr ptr;
    public union_pw_aff_list(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public union_pw_aff_list(int args_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_union_pw_aff_list_alloc(this.ctx, args[0])
    }
    public union_pw_aff_list(union_pw_aff arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_union_pw_aff_list_from_union_pw_aff(Interop.isl_union_pw_aff_copy(args[0].ptr))
    }
    public union_pw_aff_list(string arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_union_pw_aff_list_read_from_str(this.ctx, args[0].encode('ascii'))
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_union_pw_aff_list_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_union_pw_aff_list_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer add(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_pw_aff_list_add(Interop.isl_union_pw_aff_list_copy(arg0.ptr), Interop.isl_union_pw_aff_copy(arg1.ptr));
        var obj = new union_pw_aff_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer at(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_pw_aff_list_get_at(arg0.ptr, arg1);
        var obj = new union_pw_aff(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer clear(Pointer arg0)
    {
        var res = Interop.isl_union_pw_aff_list_clear(Interop.isl_union_pw_aff_list_copy(arg0.ptr));
        var obj = new union_pw_aff_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer concat(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_pw_aff_list_concat(Interop.isl_union_pw_aff_list_copy(arg0.ptr), Interop.isl_union_pw_aff_list_copy(arg1.ptr));
        var obj = new union_pw_aff_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer drop(Pointer arg0, Pointer arg1, Pointer arg2)
    {
        var res = Interop.isl_union_pw_aff_list_drop(Interop.isl_union_pw_aff_list_copy(arg0.ptr), arg1, arg2);
        var obj = new union_pw_aff_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef foreach(Pointer arg0, Pointer arg1) {
        var exc_info = new Exception[1];
    var fn = (IntPtr cb_arg0, IntPtr user) =>
    {
        var cb_cls0 = new union_pw_aff(ctx: arg0.ctx, ptr: (cb_arg0));
        try
        {
            arg1(cb_cls0);
        }
        catch (Exception e)
        {
            exc_info[0] = e;
            return -1;
        }
        return 0;
    };
    var cb1 = Marshal.GetFunctionPointerForDelegate(cb_func);
    var res = Interop.isl_union_pw_aff_list_foreach(arg0.ptr, cb1, IntPtr.Zerp);
        if (exc_info[0] is not null) {
            throw exc_info[0];
        }
if (res < 0)
{
    throw new InvalidOperationException();
}
    }
    public Typedef foreach_scc(Pointer arg0, Pointer arg1, Pointer arg2)
{
    var exc_info = new Exception[1];
    var fn = (IntPtr cb_arg0, IntPtr cb_arg1, IntPtr user) =>
    {
        var cb_cls0 = new union_pw_aff(ctx: arg0.ctx, ptr: Interop.isl_union_pw_aff_copy(cb_arg0));
        var cb_cls1 = new union_pw_aff(ctx: arg0.ctx, ptr: Interop.isl_union_pw_aff_copy(cb_arg1));
        try
        {
            var res = arg1(cb_cls0, cb_cls1);
        }
        catch (Exception e)
        {
            exc_info[0] = e;
            return -1;
        }
        return res;
    };
    var cb1 = Marshal.GetFunctionPointerForDelegate(cb_func);
    var exc_info = new Exception[1];
    var fn = (IntPtr cb_arg0, IntPtr user) =>
    {
        var cb_cls0 = new union_pw_aff_list(ctx: arg0.ctx, ptr: (cb_arg0));
        try
        {
            arg2(cb_cls0);
        }
        catch (Exception e)
        {
            exc_info[0] = e;
            return -1;
        }
        return 0;
    };
    var cb2 = Marshal.GetFunctionPointerForDelegate(cb_func);
    var res = Interop.isl_union_pw_aff_list_foreach_scc(arg0.ptr, cb1, IntPtr.Zerp, cb2, IntPtr.Zerp);
    if (exc_info[0] is not null)
    {
        throw exc_info[0];
    }
    if (res < 0)
    {
        throw new InvalidOperationException();
    }
}
public Pointer insert(Pointer arg0, Pointer arg1, Pointer arg2)
{
    var res = Interop.isl_union_pw_aff_list_insert(Interop.isl_union_pw_aff_list_copy(arg0.ptr), arg1, Interop.isl_union_pw_aff_copy(arg2.ptr));
    var obj = new union_pw_aff_list(ctx = ctx, ptr = res);
    return obj;
}
public Pointer set_at(Pointer arg0, Pointer arg1, Pointer arg2)
{
    var res = Interop.isl_union_pw_aff_list_set_at(Interop.isl_union_pw_aff_list_copy(arg0.ptr), arg1, Interop.isl_union_pw_aff_copy(arg2.ptr));
    var obj = new union_pw_aff_list(ctx = ctx, ptr = res);
    return obj;
}
public Typedef size(Pointer arg0)
{
    var res = Interop.isl_union_pw_aff_list_size(arg0.ptr);
    if (res < 0)
    {
        throw new InvalidOperationException();
    }
    return res;
}
}
internal static partial class Interop
{
    public static extern IntPtr isl_union_pw_aff_list_alloc(Context arg0, int arg1);
    public static extern IntPtr isl_union_pw_aff_list_from_union_pw_aff(IntPtr arg0);
    public static extern IntPtr isl_union_pw_aff_list_read_from_str(Context arg0, IntPtr arg1);
    public static extern IntPtr isl_union_pw_aff_list_add(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_pw_aff_list_get_at(IntPtr arg0, int arg1);
    public static extern IntPtr isl_union_pw_aff_list_clear(IntPtr arg0);
    public static extern IntPtr isl_union_pw_aff_list_concat(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_pw_aff_list_drop(IntPtr arg0, int arg1, int arg2);
    public static extern IntPtr isl_union_pw_aff_list_foreach(IntPtr arg0, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg1, IntPtr arg2);
    public static extern IntPtr isl_union_pw_aff_list_foreach_scc(IntPtr arg0, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg1, IntPtr arg2, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg3, IntPtr arg4);
    public static extern IntPtr isl_union_pw_aff_list_insert(IntPtr arg0, int arg1, IntPtr arg2);
    public static extern IntPtr isl_union_pw_aff_list_set_at(IntPtr arg0, int arg1, IntPtr arg2);
    public static extern IntPtr isl_union_pw_aff_list_size(IntPtr arg0);
    public static extern IntPtr isl_union_pw_aff_list_copy(IntPtr arg0);
    public static extern IntPtr isl_union_pw_aff_list_free(IntPtr arg0);
    public static extern IntPtr isl_union_pw_aff_list_to_str(IntPtr arg0);
}

public class union_set_list
{
    private Context ctx;
    private IntPtr ptr;
    public union_set_list(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public union_set_list(int args_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_union_set_list_alloc(this.ctx, args[0])
    }
    public union_set_list(union_set arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_union_set_list_from_union_set(Interop.isl_union_set_copy(args[0].ptr))
    }
    public union_set_list(string arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_union_set_list_read_from_str(this.ctx, args[0].encode('ascii'))
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_union_set_list_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_union_set_list_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer add(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_set_list_add(Interop.isl_union_set_list_copy(arg0.ptr), Interop.isl_union_set_copy(arg1.ptr));
        var obj = new union_set_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer at(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_set_list_get_at(arg0.ptr, arg1);
        var obj = new union_set(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer clear(Pointer arg0)
    {
        var res = Interop.isl_union_set_list_clear(Interop.isl_union_set_list_copy(arg0.ptr));
        var obj = new union_set_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer concat(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_union_set_list_concat(Interop.isl_union_set_list_copy(arg0.ptr), Interop.isl_union_set_list_copy(arg1.ptr));
        var obj = new union_set_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer drop(Pointer arg0, Pointer arg1, Pointer arg2)
    {
        var res = Interop.isl_union_set_list_drop(Interop.isl_union_set_list_copy(arg0.ptr), arg1, arg2);
        var obj = new union_set_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef foreach(Pointer arg0, Pointer arg1) {
        var exc_info = new Exception[1];
    var fn = (IntPtr cb_arg0, IntPtr user) =>
    {
        var cb_cls0 = new union_set(ctx: arg0.ctx, ptr: (cb_arg0));
        try
        {
            arg1(cb_cls0);
        }
        catch (Exception e)
        {
            exc_info[0] = e;
            return -1;
        }
        return 0;
    };
    var cb1 = Marshal.GetFunctionPointerForDelegate(cb_func);
    var res = Interop.isl_union_set_list_foreach(arg0.ptr, cb1, IntPtr.Zerp);
        if (exc_info[0] is not null) {
            throw exc_info[0];
        }
if (res < 0)
{
    throw new InvalidOperationException();
}
    }
    public Typedef foreach_scc(Pointer arg0, Pointer arg1, Pointer arg2)
{
    var exc_info = new Exception[1];
    var fn = (IntPtr cb_arg0, IntPtr cb_arg1, IntPtr user) =>
    {
        var cb_cls0 = new union_set(ctx: arg0.ctx, ptr: Interop.isl_union_set_copy(cb_arg0));
        var cb_cls1 = new union_set(ctx: arg0.ctx, ptr: Interop.isl_union_set_copy(cb_arg1));
        try
        {
            var res = arg1(cb_cls0, cb_cls1);
        }
        catch (Exception e)
        {
            exc_info[0] = e;
            return -1;
        }
        return res;
    };
    var cb1 = Marshal.GetFunctionPointerForDelegate(cb_func);
    var exc_info = new Exception[1];
    var fn = (IntPtr cb_arg0, IntPtr user) =>
    {
        var cb_cls0 = new union_set_list(ctx: arg0.ctx, ptr: (cb_arg0));
        try
        {
            arg2(cb_cls0);
        }
        catch (Exception e)
        {
            exc_info[0] = e;
            return -1;
        }
        return 0;
    };
    var cb2 = Marshal.GetFunctionPointerForDelegate(cb_func);
    var res = Interop.isl_union_set_list_foreach_scc(arg0.ptr, cb1, IntPtr.Zerp, cb2, IntPtr.Zerp);
    if (exc_info[0] is not null)
    {
        throw exc_info[0];
    }
    if (res < 0)
    {
        throw new InvalidOperationException();
    }
}
public Pointer insert(Pointer arg0, Pointer arg1, Pointer arg2)
{
    var res = Interop.isl_union_set_list_insert(Interop.isl_union_set_list_copy(arg0.ptr), arg1, Interop.isl_union_set_copy(arg2.ptr));
    var obj = new union_set_list(ctx = ctx, ptr = res);
    return obj;
}
public Pointer set_at(Pointer arg0, Pointer arg1, Pointer arg2)
{
    var res = Interop.isl_union_set_list_set_at(Interop.isl_union_set_list_copy(arg0.ptr), arg1, Interop.isl_union_set_copy(arg2.ptr));
    var obj = new union_set_list(ctx = ctx, ptr = res);
    return obj;
}
public Typedef size(Pointer arg0)
{
    var res = Interop.isl_union_set_list_size(arg0.ptr);
    if (res < 0)
    {
        throw new InvalidOperationException();
    }
    return res;
}
}
internal static partial class Interop
{
    public static extern IntPtr isl_union_set_list_alloc(Context arg0, int arg1);
    public static extern IntPtr isl_union_set_list_from_union_set(IntPtr arg0);
    public static extern IntPtr isl_union_set_list_read_from_str(Context arg0, IntPtr arg1);
    public static extern IntPtr isl_union_set_list_add(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_set_list_get_at(IntPtr arg0, int arg1);
    public static extern IntPtr isl_union_set_list_clear(IntPtr arg0);
    public static extern IntPtr isl_union_set_list_concat(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_union_set_list_drop(IntPtr arg0, int arg1, int arg2);
    public static extern IntPtr isl_union_set_list_foreach(IntPtr arg0, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg1, IntPtr arg2);
    public static extern IntPtr isl_union_set_list_foreach_scc(IntPtr arg0, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg1, IntPtr arg2, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg3, IntPtr arg4);
    public static extern IntPtr isl_union_set_list_insert(IntPtr arg0, int arg1, IntPtr arg2);
    public static extern IntPtr isl_union_set_list_set_at(IntPtr arg0, int arg1, IntPtr arg2);
    public static extern IntPtr isl_union_set_list_size(IntPtr arg0);
    public static extern IntPtr isl_union_set_list_copy(IntPtr arg0);
    public static extern IntPtr isl_union_set_list_free(IntPtr arg0);
    public static extern IntPtr isl_union_set_list_to_str(IntPtr arg0);
}

public class val
{
    private Context ctx;
    private IntPtr ptr;
    public val(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public val(int args_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_val_int_from_si(this.ctx, args[0])
    }
    public val(string arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_val_read_from_str(this.ctx, args[0].encode('ascii'))
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_val_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_val_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer abs(Pointer arg0)
    {
        var res = Interop.isl_val_abs(Interop.isl_val_copy(arg0.ptr));
        var obj = new val(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef abs_eq(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_val_abs_eq(arg0.ptr, arg1.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer add(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_val_add(Interop.isl_val_copy(arg0.ptr), Interop.isl_val_copy(arg1.ptr));
        var obj = new val(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer ceil(Pointer arg0)
    {
        var res = Interop.isl_val_ceil(Interop.isl_val_copy(arg0.ptr));
        var obj = new val(ctx = ctx, ptr = res);
        return obj;
    }
    public Builtin cmp_si(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_val_cmp_si(arg0.ptr, arg1);
        return res;
    }
    public Builtin den_si(Pointer arg0)
    {
        var res = Interop.isl_val_get_den_si(arg0.ptr);
        return res;
    }
    public Pointer div(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_val_div(Interop.isl_val_copy(arg0.ptr), Interop.isl_val_copy(arg1.ptr));
        var obj = new val(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef eq(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_val_eq(arg0.ptr, arg1.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer floor(Pointer arg0)
    {
        var res = Interop.isl_val_floor(Interop.isl_val_copy(arg0.ptr));
        var obj = new val(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer gcd(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_val_gcd(Interop.isl_val_copy(arg0.ptr), Interop.isl_val_copy(arg1.ptr));
        var obj = new val(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef ge(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_val_ge(arg0.ptr, arg1.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef gt(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_val_gt(arg0.ptr, arg1.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public static Pointer infty()
    {
        var ctx = Context.DefaultInstance;
        var res = Interop.isl_val_infty(ctx);
        var obj = new val(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer inv(Pointer arg0)
    {
        var res = Interop.isl_val_inv(Interop.isl_val_copy(arg0.ptr));
        var obj = new val(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef is_divisible_by(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_val_is_divisible_by(arg0.ptr, arg1.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_infty(Pointer arg0)
    {
        var res = Interop.isl_val_is_infty(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_int(Pointer arg0)
    {
        var res = Interop.isl_val_is_int(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_nan(Pointer arg0)
    {
        var res = Interop.isl_val_is_nan(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_neg(Pointer arg0)
    {
        var res = Interop.isl_val_is_neg(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_neginfty(Pointer arg0)
    {
        var res = Interop.isl_val_is_neginfty(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_negone(Pointer arg0)
    {
        var res = Interop.isl_val_is_negone(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_nonneg(Pointer arg0)
    {
        var res = Interop.isl_val_is_nonneg(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_nonpos(Pointer arg0)
    {
        var res = Interop.isl_val_is_nonpos(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_one(Pointer arg0)
    {
        var res = Interop.isl_val_is_one(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_pos(Pointer arg0)
    {
        var res = Interop.isl_val_is_pos(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_rat(Pointer arg0)
    {
        var res = Interop.isl_val_is_rat(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef is_zero(Pointer arg0)
    {
        var res = Interop.isl_val_is_zero(arg0.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef le(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_val_le(arg0.ptr, arg1.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Typedef lt(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_val_lt(arg0.ptr, arg1.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer max(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_val_max(Interop.isl_val_copy(arg0.ptr), Interop.isl_val_copy(arg1.ptr));
        var obj = new val(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer min(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_val_min(Interop.isl_val_copy(arg0.ptr), Interop.isl_val_copy(arg1.ptr));
        var obj = new val(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer mod(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_val_mod(Interop.isl_val_copy(arg0.ptr), Interop.isl_val_copy(arg1.ptr));
        var obj = new val(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer mul(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_val_mul(Interop.isl_val_copy(arg0.ptr), Interop.isl_val_copy(arg1.ptr));
        var obj = new val(ctx = ctx, ptr = res);
        return obj;
    }
    public static Pointer nan()
    {
        var ctx = Context.DefaultInstance;
        var res = Interop.isl_val_nan(ctx);
        var obj = new val(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef ne(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_val_ne(arg0.ptr, arg1.ptr);
        if (res < 0)
        {
            throw new InvalidOperationException();
        }
        return res;
    }
    public Pointer neg(Pointer arg0)
    {
        var res = Interop.isl_val_neg(Interop.isl_val_copy(arg0.ptr));
        var obj = new val(ctx = ctx, ptr = res);
        return obj;
    }
    public static Pointer neginfty()
    {
        var ctx = Context.DefaultInstance;
        var res = Interop.isl_val_neginfty(ctx);
        var obj = new val(ctx = ctx, ptr = res);
        return obj;
    }
    public static Pointer negone()
    {
        var ctx = Context.DefaultInstance;
        var res = Interop.isl_val_negone(ctx);
        var obj = new val(ctx = ctx, ptr = res);
        return obj;
    }
    public Builtin num_si(Pointer arg0)
    {
        var res = Interop.isl_val_get_num_si(arg0.ptr);
        return res;
    }
    public static Pointer one()
    {
        var ctx = Context.DefaultInstance;
        var res = Interop.isl_val_one(ctx);
        var obj = new val(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer pow2(Pointer arg0)
    {
        var res = Interop.isl_val_pow2(Interop.isl_val_copy(arg0.ptr));
        var obj = new val(ctx = ctx, ptr = res);
        return obj;
    }
    public Builtin sgn(Pointer arg0)
    {
        var res = Interop.isl_val_sgn(arg0.ptr);
        return res;
    }
    public Pointer sub(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_val_sub(Interop.isl_val_copy(arg0.ptr), Interop.isl_val_copy(arg1.ptr));
        var obj = new val(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer to_list(Pointer arg0)
    {
        var res = Interop.isl_val_to_list(Interop.isl_val_copy(arg0.ptr));
        var obj = new val_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer trunc(Pointer arg0)
    {
        var res = Interop.isl_val_trunc(Interop.isl_val_copy(arg0.ptr));
        var obj = new val(ctx = ctx, ptr = res);
        return obj;
    }
    public static Pointer zero()
    {
        var ctx = Context.DefaultInstance;
        var res = Interop.isl_val_zero(ctx);
        var obj = new val(ctx = ctx, ptr = res);
        return obj;
    }
}
internal static partial class Interop
{
    public static extern IntPtr isl_val_int_from_si(Context arg0, long arg1);
    public static extern IntPtr isl_val_read_from_str(Context arg0, IntPtr arg1);
    public static extern IntPtr isl_val_abs(IntPtr arg0);
    public static extern IntPtr isl_val_abs_eq(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_val_add(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_val_ceil(IntPtr arg0);
    public static extern IntPtr isl_val_cmp_si(IntPtr arg0, long arg1);
    public static extern IntPtr isl_val_get_den_si(IntPtr arg0);
    public static extern IntPtr isl_val_div(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_val_eq(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_val_floor(IntPtr arg0);
    public static extern IntPtr isl_val_gcd(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_val_ge(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_val_gt(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_val_infty(Context arg0);
    public static extern IntPtr isl_val_inv(IntPtr arg0);
    public static extern IntPtr isl_val_is_divisible_by(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_val_is_infty(IntPtr arg0);
    public static extern IntPtr isl_val_is_int(IntPtr arg0);
    public static extern IntPtr isl_val_is_nan(IntPtr arg0);
    public static extern IntPtr isl_val_is_neg(IntPtr arg0);
    public static extern IntPtr isl_val_is_neginfty(IntPtr arg0);
    public static extern IntPtr isl_val_is_negone(IntPtr arg0);
    public static extern IntPtr isl_val_is_nonneg(IntPtr arg0);
    public static extern IntPtr isl_val_is_nonpos(IntPtr arg0);
    public static extern IntPtr isl_val_is_one(IntPtr arg0);
    public static extern IntPtr isl_val_is_pos(IntPtr arg0);
    public static extern IntPtr isl_val_is_rat(IntPtr arg0);
    public static extern IntPtr isl_val_is_zero(IntPtr arg0);
    public static extern IntPtr isl_val_le(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_val_lt(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_val_max(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_val_min(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_val_mod(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_val_mul(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_val_nan(Context arg0);
    public static extern IntPtr isl_val_ne(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_val_neg(IntPtr arg0);
    public static extern IntPtr isl_val_neginfty(Context arg0);
    public static extern IntPtr isl_val_negone(Context arg0);
    public static extern IntPtr isl_val_get_num_si(IntPtr arg0);
    public static extern IntPtr isl_val_one(Context arg0);
    public static extern IntPtr isl_val_pow2(IntPtr arg0);
    public static extern IntPtr isl_val_sgn(IntPtr arg0);
    public static extern IntPtr isl_val_sub(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_val_to_list(IntPtr arg0);
    public static extern IntPtr isl_val_trunc(IntPtr arg0);
    public static extern IntPtr isl_val_zero(Context arg0);
    public static extern IntPtr isl_val_copy(IntPtr arg0);
    public static extern IntPtr isl_val_free(IntPtr arg0);
    public static extern IntPtr isl_val_to_str(IntPtr arg0);
}

public class val_list
{
    private Context ctx;
    private IntPtr ptr;
    public val_list(isl_context? ctx = null, IntPtr? ptr = null)
    {
        if (ptr is not null)
        {
            this.ctx = ctx!;
            this.ptr = ptr!;
        }
    }
    public val_list(int args_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_val_list_alloc(this.ctx, args[0])
    }
    public val_list(val arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_val_list_from_val(Interop.isl_val_copy(args[0].ptr))
    }
    public val_list(string arg_0)
    {
        this.ctx = Context.DefaultInstance;
        this.ptr = Interop.isl_val_list_read_from_str(this.ctx, args[0].encode('ascii'))
    }
    public Dispose()
    {
        if (ptr is not null)
        {
            isl.isl_val_list_free(ptr);
        }
    }
    public override ToString()
    {
        IntPtr char_p = isl.isl_val_list_to_str(ptr)
        string res = Marshal.PtrToStringAnsi(ptr);
        Marshal.FreeHGlobal(ptr);
        return res;
    }
    public Pointer add(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_val_list_add(Interop.isl_val_list_copy(arg0.ptr), Interop.isl_val_copy(arg1.ptr));
        var obj = new val_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer at(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_val_list_get_at(arg0.ptr, arg1);
        var obj = new val(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer clear(Pointer arg0)
    {
        var res = Interop.isl_val_list_clear(Interop.isl_val_list_copy(arg0.ptr));
        var obj = new val_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer concat(Pointer arg0, Pointer arg1)
    {
        var res = Interop.isl_val_list_concat(Interop.isl_val_list_copy(arg0.ptr), Interop.isl_val_list_copy(arg1.ptr));
        var obj = new val_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Pointer drop(Pointer arg0, Pointer arg1, Pointer arg2)
    {
        var res = Interop.isl_val_list_drop(Interop.isl_val_list_copy(arg0.ptr), arg1, arg2);
        var obj = new val_list(ctx = ctx, ptr = res);
        return obj;
    }
    public Typedef foreach(Pointer arg0, Pointer arg1) {
        var exc_info = new Exception[1];
    var fn = (IntPtr cb_arg0, IntPtr user) =>
    {
        var cb_cls0 = new val(ctx: arg0.ctx, ptr: (cb_arg0));
        try
        {
            arg1(cb_cls0);
        }
        catch (Exception e)
        {
            exc_info[0] = e;
            return -1;
        }
        return 0;
    };
    var cb1 = Marshal.GetFunctionPointerForDelegate(cb_func);
    var res = Interop.isl_val_list_foreach(arg0.ptr, cb1, IntPtr.Zerp);
        if (exc_info[0] is not null) {
            throw exc_info[0];
        }
if (res < 0)
{
    throw new InvalidOperationException();
}
    }
    public Typedef foreach_scc(Pointer arg0, Pointer arg1, Pointer arg2)
{
    var exc_info = new Exception[1];
    var fn = (IntPtr cb_arg0, IntPtr cb_arg1, IntPtr user) =>
    {
        var cb_cls0 = new val(ctx: arg0.ctx, ptr: Interop.isl_val_copy(cb_arg0));
        var cb_cls1 = new val(ctx: arg0.ctx, ptr: Interop.isl_val_copy(cb_arg1));
        try
        {
            var res = arg1(cb_cls0, cb_cls1);
        }
        catch (Exception e)
        {
            exc_info[0] = e;
            return -1;
        }
        return res;
    };
    var cb1 = Marshal.GetFunctionPointerForDelegate(cb_func);
    var exc_info = new Exception[1];
    var fn = (IntPtr cb_arg0, IntPtr user) =>
    {
        var cb_cls0 = new val_list(ctx: arg0.ctx, ptr: (cb_arg0));
        try
        {
            arg2(cb_cls0);
        }
        catch (Exception e)
        {
            exc_info[0] = e;
            return -1;
        }
        return 0;
    };
    var cb2 = Marshal.GetFunctionPointerForDelegate(cb_func);
    var res = Interop.isl_val_list_foreach_scc(arg0.ptr, cb1, IntPtr.Zerp, cb2, IntPtr.Zerp);
    if (exc_info[0] is not null)
    {
        throw exc_info[0];
    }
    if (res < 0)
    {
        throw new InvalidOperationException();
    }
}
public Pointer insert(Pointer arg0, Pointer arg1, Pointer arg2)
{
    var res = Interop.isl_val_list_insert(Interop.isl_val_list_copy(arg0.ptr), arg1, Interop.isl_val_copy(arg2.ptr));
    var obj = new val_list(ctx = ctx, ptr = res);
    return obj;
}
public Pointer set_at(Pointer arg0, Pointer arg1, Pointer arg2)
{
    var res = Interop.isl_val_list_set_at(Interop.isl_val_list_copy(arg0.ptr), arg1, Interop.isl_val_copy(arg2.ptr));
    var obj = new val_list(ctx = ctx, ptr = res);
    return obj;
}
public Typedef size(Pointer arg0)
{
    var res = Interop.isl_val_list_size(arg0.ptr);
    if (res < 0)
    {
        throw new InvalidOperationException();
    }
    return res;
}
}
internal static partial class Interop
{
    public static extern IntPtr isl_val_list_alloc(Context arg0, int arg1);
    public static extern IntPtr isl_val_list_from_val(IntPtr arg0);
    public static extern IntPtr isl_val_list_read_from_str(Context arg0, IntPtr arg1);
    public static extern IntPtr isl_val_list_add(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_val_list_get_at(IntPtr arg0, int arg1);
    public static extern IntPtr isl_val_list_clear(IntPtr arg0);
    public static extern IntPtr isl_val_list_concat(IntPtr arg0, IntPtr arg1);
    public static extern IntPtr isl_val_list_drop(IntPtr arg0, int arg1, int arg2);
    public static extern IntPtr isl_val_list_foreach(IntPtr arg0, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg1, IntPtr arg2);
    public static extern IntPtr isl_val_list_foreach_scc(IntPtr arg0, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg1, IntPtr arg2, [MarshalAs(UnmanagedType.FunctionPtr)] IntPtr arg3, IntPtr arg4);
    public static extern IntPtr isl_val_list_insert(IntPtr arg0, int arg1, IntPtr arg2);
    public static extern IntPtr isl_val_list_set_at(IntPtr arg0, int arg1, IntPtr arg2);
    public static extern IntPtr isl_val_list_size(IntPtr arg0);
    public static extern IntPtr isl_val_list_copy(IntPtr arg0);
    public static extern IntPtr isl_val_list_free(IntPtr arg0);
    public static extern IntPtr isl_val_list_to_str(IntPtr arg0);
}
