using System.Runtime.InteropServices;

namespace IntegerSetLibrary;

public enum ast_expr_type : int
{
    error = -1,
    op,
    id,
    int_
}

public enum dim_type : int
{
    cst,
    param,
    in_,
    out_,
    set = out_,
    div,
    all
};

public enum ast_node_type : int
{
    error = -1,
    op,
    id,
    int_
}

public enum ast_expr_op_type : int
{
    error = -1,
    and,
    and_then,
    or,
    or_else,
    max,
    min,
    minus,
    add,
    sub,
    mul,
    div,
    fdiv_q, /* Round towards -infty */
    pdiv_q, /* Dividend is non-negative */
    pdiv_r, /* Dividend is non-negative */
    zdiv_r, /* Result only compared against zero */
    cond,
    select,
    eq,
    le,
    lt,
    ge,
    gt,
    call,
    access,
    member,
    address_of
};

public enum schedule_node_type : int
{
    error = -1,
    band,
    context,
    domain,
    expansion,
    extension,
    filter,
    leaf,
    guard,
    mark,
    sequence,
    set
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


public enum ast_loop_type : int
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

#pragma warning disable CS8981 // The type name only contains lower-cased ascii characters. Such names may become reserved for the language.
public sealed class ctx : IDisposable, IObject
#pragma warning restore CS8981 // The type name only contains lower-cased ascii characters. Such names may become reserved for the language.
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
