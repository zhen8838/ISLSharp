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

public abstract class IntrusiveHandle : SafeHandle
{
    protected IntrusiveHandle(IntPtr handle, bool ownsHandle = true) : base(handle, ownsHandle)
    {
    }

    public override bool IsInvalid => handle == IntPtr.Zero;

    internal abstract IntPtr IncreaseReference();
}

#pragma warning disable CS8981 // The type name only contains lower-cased ascii characters. Such names may become reserved for the language.
public sealed class ctx : IntrusiveHandle
#pragma warning restore CS8981 // The type name only contains lower-cased ascii characters. Such names may become reserved for the language.
{
    private static readonly AsyncLocal<ctx?> _currentContext = new AsyncLocal<ctx?>();

    private readonly List<IntrusiveHandle> _objectHandles;

    private ctx() : base(IntPtr.Zero, true)
    {
        SetHandle(Interop.isl_ctx_alloc());
        _objectHandles = new();
        if (IsInvalid)
        {
            throw new InvalidDataException("Failed to allocate isl_ctx");
        }
    }

    public static ctx Create()
    {
        if (_currentContext.Value != null)
        {
            throw new InvalidOperationException("A context is already set for this thread.");
        }

        var newContext = new ctx();
        _currentContext.Value = newContext;
        return newContext;
    }

    public static ctx Current
    {
        get
        {
            return _currentContext.Value ?? throw new InvalidOperationException("No context is set for this thread.");
        }
    }

    public override bool IsInvalid => handle == IntPtr.Zero;

    internal override IntPtr IncreaseReference()
    {
        throw new NotSupportedException();
    }

    protected override bool ReleaseHandle()
    {
        Interop.isl_ctx_free(handle);
        return true;
    }

    protected override void Dispose(bool disposing)
    {
        foreach (var obj in _objectHandles)
        {
            obj.Dispose();
        }
        _objectHandles.Clear();
        base.Dispose(disposing);
        if (disposing)
        {
            _currentContext.Value = null;
        }
    }

    public void AddObjectHandle(IntrusiveHandle handle) => _objectHandles.Add(handle);
}

internal static partial class Interop
{
    public const string LibraryName = "libisl";

    [DllImport(LibraryName)]
    public static extern IntPtr isl_ctx_alloc();

    [DllImport(LibraryName)]
    public static extern void isl_ctx_free(IntPtr ctx);

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
