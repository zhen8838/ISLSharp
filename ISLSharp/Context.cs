using System.Runtime.InteropServices;

namespace ISLSharp.isl;

public enum isl_ast_expr_type : int
{
    isl_ast_expr_error = -1,
    isl_ast_expr_op,
    isl_ast_expr_id,
    isl_ast_expr_int
}

public enum isl_ast_node_type : int
{
    isl_ast_expr_error = -1,
    isl_ast_expr_op,
    isl_ast_expr_id,
    isl_ast_expr_int
}

public enum isl_ast_expr_op_type : int
{
    isl_ast_expr_op_error = -1,
    isl_ast_expr_op_and,
    isl_ast_expr_op_and_then,
    isl_ast_expr_op_or,
    isl_ast_expr_op_or_else,
    isl_ast_expr_op_max,
    isl_ast_expr_op_min,
    isl_ast_expr_op_minus,
    isl_ast_expr_op_add,
    isl_ast_expr_op_sub,
    isl_ast_expr_op_mul,
    isl_ast_expr_op_div,
    isl_ast_expr_op_fdiv_q, /* Round towards -infty */
    isl_ast_expr_op_pdiv_q, /* Dividend is non-negative */
    isl_ast_expr_op_pdiv_r, /* Dividend is non-negative */
    isl_ast_expr_op_zdiv_r, /* Result only compared against zero */
    isl_ast_expr_op_cond,
    isl_ast_expr_op_select,
    isl_ast_expr_op_eq,
    isl_ast_expr_op_le,
    isl_ast_expr_op_lt,
    isl_ast_expr_op_ge,
    isl_ast_expr_op_gt,
    isl_ast_expr_op_call,
    isl_ast_expr_op_access,
    isl_ast_expr_op_member,
    isl_ast_expr_op_address_of
};

public enum isl_schedule_node_type : int
{
    isl_schedule_node_error = -1,
    isl_schedule_node_band,
    isl_schedule_node_context,
    isl_schedule_node_domain,
    isl_schedule_node_expansion,
    isl_schedule_node_extension,
    isl_schedule_node_filter,
    isl_schedule_node_leaf,
    isl_schedule_node_guard,
    isl_schedule_node_mark,
    isl_schedule_node_sequence,
    isl_schedule_node_set
};

public enum isl_stat : int
{
    Error = -1,
    Ok = 0
}

public enum isl_bool : int
{
    Error = -1,
    False = 0,
    True = 1
}


public enum isl_ast_loop_type : int
{
    Error = -1,
    Default = 0,
    Atomic,
    Unroll,
    Separate
}

internal interface IObject
{
    IntPtr copy();
    IntPtr get();
    bool is_null();
}

public sealed class ctx : IDisposable, IObject
{
    private IntPtr ptr = IntPtr.Zero;

    public ctx()
    {
        ptr = Interop.isl_ctx_alloc();
        if (ptr == IntPtr.Zero)
        {
            throw new InvalidDataException();
        }
    }

    public static ctx Instance { get; } = new();

    public nint copy()
    {
        throw new NotSupportedException();
    }

    public void Dispose()
    {
        Interop.isl_ctx_free(ptr);
        ptr = IntPtr.Zero;
    }

    public nint get() => ptr;

    public bool is_null() => ptr == IntPtr.Zero;
}

internal static partial class Interop
{
    public const string LibraryName = "libisl";

    [DllImport(LibraryName)]
    public static extern IntPtr isl_ctx_alloc();

    [DllImport(LibraryName)]
    public static extern IntPtr isl_ctx_free(IntPtr ctx);

    [DllImport(LibraryName)]
    public static extern IntPtr isl_id_alloc(IntPtr ctx, IntPtr arg0, IntPtr arg1);

    [DllImport(LibraryName)]
    public static extern IntPtr isl_id_set_free_user(IntPtr arg0, IntPtr arg1);

    [DllImport(LibraryName)]
    public static extern IntPtr isl_id_get_free_user(IntPtr arg0);

    [DllImport(LibraryName)]
    public static extern IntPtr isl_id_get_user(IntPtr arg0);

    [DllImport(LibraryName)]
    public static extern void isl_options_set_on_error(IntPtr arg0, int arg1);

    [DllImport(LibraryName)]
    public static extern int isl_options_get_on_error(IntPtr arg0);
}
