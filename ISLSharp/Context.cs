using System.Runtime.InteropServices;

namespace ISLSharp;

public sealed class Context : SafeHandle
{
    private static Context? _defalut = null;

    private Context(nint invalidHandleValue, bool ownsHandle) : base(invalidHandleValue, ownsHandle)
    {
    }

    private Context() : this(Interop.isl_ctx_alloc(), true)
    {
    }

    public override bool IsInvalid => handle == IntPtr.Zero;

    public static Context DefaultInstance => _defalut ??= new Context();

    protected override bool ReleaseHandle()
    {
        Interop.isl_ctx_free(this);
        SetHandleAsInvalid();
        return true;
    }
}


internal static partial class Interop
{
    public const string LibraryName = "22";

    [DllImport(LibraryName)]
    public static extern IntPtr isl_ctx_alloc();

    [DllImport(LibraryName)]
    public static extern IntPtr isl_ctx_free(Context ctx);

    [DllImport(LibraryName)]
    public static extern IntPtr isl_id_alloc(Context ctx, IntPtr arg0, IntPtr arg1);

    [DllImport(LibraryName)]
    public static extern IntPtr isl_id_set_free_user(IntPtr arg0, IntPtr arg1);

    [DllImport(LibraryName)]
    public static extern IntPtr isl_id_get_free_user(IntPtr arg0);

    [DllImport(LibraryName)]
    public static extern IntPtr isl_id_get_user(IntPtr arg0);

}