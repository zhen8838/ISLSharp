using System;
using System.Runtime.InteropServices;
#pragma warning disable
namespace IntegerSetLibrary {

public class aff : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal aff(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

 public /* explicit */ aff(ctx ctx, string str)
{
  var res = Interop.isl_aff_read_from_str(ctx.get(), str);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

public void Dispose() {
  if (!is_null()) {
    Interop.isl_aff_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_aff_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public aff add(aff aff2)
{
  if (get() == IntPtr.Zero || aff2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_aff_add(copy(), aff2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new aff(res);
}

 public multi_aff add(multi_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_aff(get()).add(multi2);
}

 public multi_pw_aff add(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).add(multi2);
}

 public multi_union_pw_aff add(multi_union_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).add(multi2);
}

 public pw_aff add(pw_aff pwaff2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).add(pwaff2);
}

 public pw_multi_aff add(pw_multi_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).add(pma2);
}

 public union_pw_aff add(union_pw_aff upa2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).add(upa2);
}

 public union_pw_multi_aff add(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).add(upma2);
}

 public aff add_constant(val v)
{
  if (get() == IntPtr.Zero || v.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_aff_add_constant_val(copy(), v.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new aff(res);
}

 public aff add_constant(long v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.add_constant(new val(ctx.Instance, v));
}

 public multi_aff add_constant(multi_val mv)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_aff(get()).add_constant(mv);
}

 public union_pw_multi_aff apply(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).apply(upma2);
}

 public aff as_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).as_aff();
}

 public map as_map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).as_map();
}

 public multi_aff as_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).as_multi_aff();
}

 public multi_union_pw_aff as_multi_union_pw_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).as_multi_union_pw_aff();
}

 public pw_multi_aff as_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).as_pw_multi_aff();
}

 public set as_set()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_aff(get()).as_set();
}

 public union_map as_union_map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).as_union_map();
}

 public aff at(int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_aff(get()).at(pos);
}

 public basic_set bind(id id)
{
  if (get() == IntPtr.Zero || id.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_aff_bind_id(copy(), id.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public basic_set bind(string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.bind(new id(ctx.Instance, id));
}

 public basic_set bind(multi_id tuple)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_aff(get()).bind(tuple);
}

 public pw_aff bind_domain(multi_id tuple)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).bind_domain(tuple);
}

 public pw_aff bind_domain_wrapped_domain(multi_id tuple)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).bind_domain_wrapped_domain(tuple);
}

 public aff ceil()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_aff_ceil(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new aff(res);
}

 public pw_aff coalesce()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).coalesce();
}

 public pw_aff cond(pw_aff pwaff_true, pw_aff pwaff_false)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).cond(pwaff_true, pwaff_false);
}

 public multi_val constant_multi_val()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_aff(get()).constant_multi_val();
}

 public val constant_val()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_aff_get_constant_val(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public aff div(aff aff2)
{
  if (get() == IntPtr.Zero || aff2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_aff_div(copy(), aff2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new aff(res);
}

 public pw_aff div(pw_aff pa2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).div(pa2);
}

 public set domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).domain();
}

 public aff domain_reverse()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_aff_domain_reverse(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new aff(res);
}

 public pw_aff drop_unused_params()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).drop_unused_params();
}

 public set eq_set(aff aff2)
{
  if (get() == IntPtr.Zero || aff2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_aff_eq_set(copy(), aff2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set eq_set(pw_aff pwaff2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).eq_set(pwaff2);
}

 public val eval(point pnt)
{
  if (get() == IntPtr.Zero || pnt.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_aff_eval(copy(), pnt.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public pw_multi_aff extract_pw_multi_aff(space space)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).extract_pw_multi_aff(space);
}

 public multi_aff flat_range_product(multi_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_aff(get()).flat_range_product(multi2);
}

 public multi_pw_aff flat_range_product(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).flat_range_product(multi2);
}

 public multi_union_pw_aff flat_range_product(multi_union_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).flat_range_product(multi2);
}

 public pw_multi_aff flat_range_product(pw_multi_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).flat_range_product(pma2);
}

 public union_pw_multi_aff flat_range_product(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).flat_range_product(upma2);
}

 public aff floor()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_aff_floor(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new aff(res);
}

 public void foreach_piece(Action<set, multi_aff> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
new pw_aff(get()).foreach_piece(fn);
}

 public set ge_set(aff aff2)
{
  if (get() == IntPtr.Zero || aff2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_aff_ge_set(copy(), aff2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set ge_set(pw_aff pwaff2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).ge_set(pwaff2);
}

 public aff gist(set context)
{
  if (get() == IntPtr.Zero || context.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_aff_gist(copy(), context.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new aff(res);
}

 public union_pw_aff gist(union_set context)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).gist(context);
}

 public aff gist(basic_set context)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.gist(new set(context));
}

 public aff gist(point context)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.gist(new set(context));
}

 public aff gist_params(set context)
{
  if (get() == IntPtr.Zero || context.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_aff_gist_params(copy(), context.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new aff(res);
}

 public set gt_set(aff aff2)
{
  if (get() == IntPtr.Zero || aff2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_aff_gt_set(copy(), aff2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set gt_set(pw_aff pwaff2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).gt_set(pwaff2);
}

 public bool has_range_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_aff(get()).has_range_tuple_id();
}

 public multi_aff identity()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_aff(get()).identity();
}

 public pw_aff insert_domain(space domain)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).insert_domain(domain);
}

 public pw_aff intersect_domain(set set)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).intersect_domain(set);
}

 public union_pw_aff intersect_domain(space space)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).intersect_domain(space);
}

 public union_pw_aff intersect_domain(union_set uset)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).intersect_domain(uset);
}

 public union_pw_aff intersect_domain_wrapped_domain(union_set uset)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).intersect_domain_wrapped_domain(uset);
}

 public union_pw_aff intersect_domain_wrapped_range(union_set uset)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).intersect_domain_wrapped_range(uset);
}

 public pw_aff intersect_params(set set)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).intersect_params(set);
}

 public bool involves_locals()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_aff(get()).involves_locals();
}

 public bool involves_nan()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_aff(get()).involves_nan();
}

 public bool involves_param(id id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).involves_param(id);
}

 public bool involves_param(string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.involves_param(new id(ctx.Instance, id));
}

 public bool involves_param(id_list list)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).involves_param(list);
}

 public bool is_cst()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_aff_is_cst(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool isa_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).isa_aff();
}

 public bool isa_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).isa_multi_aff();
}

 public bool isa_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).isa_pw_multi_aff();
}

 public set le_set(aff aff2)
{
  if (get() == IntPtr.Zero || aff2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_aff_le_set(copy(), aff2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set le_set(pw_aff pwaff2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).le_set(pwaff2);
}

 public aff_list list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_aff(get()).list();
}

 public set lt_set(aff aff2)
{
  if (get() == IntPtr.Zero || aff2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_aff_lt_set(copy(), aff2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set lt_set(pw_aff pwaff2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).lt_set(pwaff2);
}

 public multi_pw_aff max(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).max(multi2);
}

 public pw_aff max(pw_aff pwaff2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).max(pwaff2);
}

 public multi_val max_multi_val()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).max_multi_val();
}

 public val max_val()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).max_val();
}

 public multi_pw_aff min(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).min(multi2);
}

 public pw_aff min(pw_aff pwaff2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).min(pwaff2);
}

 public multi_val min_multi_val()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).min_multi_val();
}

 public val min_val()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).min_val();
}

 public aff mod(val mod)
{
  if (get() == IntPtr.Zero || mod.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_aff_mod_val(copy(), mod.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new aff(res);
}

 public aff mod(long mod)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.mod(new val(ctx.Instance, mod));
}

 public aff mul(aff aff2)
{
  if (get() == IntPtr.Zero || aff2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_aff_mul(copy(), aff2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new aff(res);
}

 public pw_aff mul(pw_aff pwaff2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).mul(pwaff2);
}

 public int n_piece()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).n_piece();
}

 public set ne_set(aff aff2)
{
  if (get() == IntPtr.Zero || aff2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_aff_ne_set(copy(), aff2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set ne_set(pw_aff pwaff2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).ne_set(pwaff2);
}

 public aff neg()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_aff_neg(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new aff(res);
}

 public set paramss()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).paramss();
}

 public bool plain_is_empty()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).plain_is_empty();
}

 public bool plain_is_equal(aff aff2)
{
  if (get() == IntPtr.Zero || aff2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_aff_plain_is_equal(get(), aff2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool plain_is_equal(multi_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_aff(get()).plain_is_equal(multi2);
}

 public bool plain_is_equal(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).plain_is_equal(multi2);
}

 public bool plain_is_equal(multi_union_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).plain_is_equal(multi2);
}

 public bool plain_is_equal(pw_aff pwaff2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).plain_is_equal(pwaff2);
}

 public bool plain_is_equal(pw_multi_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).plain_is_equal(pma2);
}

 public bool plain_is_equal(union_pw_aff upa2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).plain_is_equal(upa2);
}

 public bool plain_is_equal(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).plain_is_equal(upma2);
}

 public pw_multi_aff preimage_domain_wrapped_domain(pw_multi_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).preimage_domain_wrapped_domain(pma2);
}

 public union_pw_multi_aff preimage_domain_wrapped_domain(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).preimage_domain_wrapped_domain(upma2);
}

 public multi_aff product(multi_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_aff(get()).product(multi2);
}

 public multi_pw_aff product(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).product(multi2);
}

 public pw_multi_aff product(pw_multi_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).product(pma2);
}

 public aff pullback(multi_aff ma)
{
  if (get() == IntPtr.Zero || ma.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_aff_pullback_multi_aff(copy(), ma.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new aff(res);
}

 public pw_aff pullback(multi_pw_aff mpa)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).pullback(mpa);
}

 public pw_aff pullback(pw_multi_aff pma)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).pullback(pma);
}

 public union_pw_aff pullback(union_pw_multi_aff upma)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).pullback(upma);
}

 public aff pullback(aff ma)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.pullback(new multi_aff(ma));
}

 public pw_multi_aff_list pw_multi_aff_list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).pw_multi_aff_list();
}

 public pw_multi_aff range_factor_domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).range_factor_domain();
}

 public pw_multi_aff range_factor_range()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).range_factor_range();
}

 public multi_aff range_product(multi_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_aff(get()).range_product(multi2);
}

 public multi_pw_aff range_product(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).range_product(multi2);
}

 public multi_union_pw_aff range_product(multi_union_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).range_product(multi2);
}

 public pw_multi_aff range_product(pw_multi_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).range_product(pma2);
}

 public union_pw_multi_aff range_product(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).range_product(upma2);
}

 public id range_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_aff(get()).range_tuple_id();
}

 public multi_aff reset_range_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_aff(get()).reset_range_tuple_id();
}

 public aff scale(val v)
{
  if (get() == IntPtr.Zero || v.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_aff_scale_val(copy(), v.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new aff(res);
}

 public aff scale(long v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.scale(new val(ctx.Instance, v));
}

 public multi_aff scale(multi_val mv)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_aff(get()).scale(mv);
}

 public aff scale_down(val v)
{
  if (get() == IntPtr.Zero || v.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_aff_scale_down_val(copy(), v.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new aff(res);
}

 public aff scale_down(long v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.scale_down(new val(ctx.Instance, v));
}

 public multi_aff scale_down(multi_val mv)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_aff(get()).scale_down(mv);
}

 public multi_aff set_at(int pos, aff el)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_aff(get()).set_at(pos, el);
}

 public multi_pw_aff set_at(int pos, pw_aff el)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).set_at(pos, el);
}

 public multi_union_pw_aff set_at(int pos, union_pw_aff el)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).set_at(pos, el);
}

 public multi_aff set_range_tuple(id id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_aff(get()).set_range_tuple(id);
}

 public multi_aff set_range_tuple(string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.set_range_tuple(new id(ctx.Instance, id));
}

 public int size()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_aff(get()).size();
}

 public space space()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).space();
}

 public aff sub(aff aff2)
{
  if (get() == IntPtr.Zero || aff2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_aff_sub(copy(), aff2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new aff(res);
}

 public multi_aff sub(multi_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_aff(get()).sub(multi2);
}

 public multi_pw_aff sub(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).sub(multi2);
}

 public multi_union_pw_aff sub(multi_union_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).sub(multi2);
}

 public pw_aff sub(pw_aff pwaff2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).sub(pwaff2);
}

 public pw_multi_aff sub(pw_multi_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).sub(pma2);
}

 public union_pw_aff sub(union_pw_aff upa2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).sub(upa2);
}

 public union_pw_multi_aff sub(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).sub(upma2);
}

 public pw_aff subtract_domain(set set)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).subtract_domain(set);
}

 public union_pw_aff subtract_domain(space space)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).subtract_domain(space);
}

 public union_pw_aff subtract_domain(union_set uset)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).subtract_domain(uset);
}

 public pw_aff tdiv_q(pw_aff pa2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).tdiv_q(pa2);
}

 public pw_aff tdiv_r(pw_aff pa2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).tdiv_r(pa2);
}

 public aff_list to_list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_aff_to_list(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new aff_list(res);
}

 public multi_pw_aff to_multi_pw_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_aff(get()).to_multi_pw_aff();
}

 public multi_union_pw_aff to_multi_union_pw_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_aff(get()).to_multi_union_pw_aff();
}

 public pw_multi_aff to_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_aff(get()).to_pw_multi_aff();
}

 public union_pw_aff to_union_pw_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).to_union_pw_aff();
}

 public union_pw_multi_aff to_union_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).to_union_pw_multi_aff();
}

 public aff unbind_params_insert_domain(multi_id domain)
{
  if (get() == IntPtr.Zero || domain.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_aff_unbind_params_insert_domain(copy(), domain.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new aff(res);
}

 public multi_pw_aff union_add(multi_pw_aff mpa2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).union_add(mpa2);
}

 public multi_union_pw_aff union_add(multi_union_pw_aff mupa2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).union_add(mupa2);
}

 public pw_aff union_add(pw_aff pwaff2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).union_add(pwaff2);
}

 public pw_multi_aff union_add(pw_multi_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).union_add(pma2);
}

 public union_pw_aff union_add(union_pw_aff upa2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).union_add(upa2);
}

 public union_pw_multi_aff union_add(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_aff(get()).union_add(upma2);
}

 public static aff zero_on_domain(space space)
{
  if (space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_aff_zero_on_domain_space(space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new aff(res);
}

public override string ToString(){
  var str = Interop.isl_aff_to_str(get());
  return str;
}
}

public class aff_list : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal aff_list(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

 public /* explicit */ aff_list(ctx ctx, int n)
{
  var res = Interop.isl_aff_list_alloc(ctx.get(), n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ aff_list(aff el)
{
  if (el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_aff_list_from_aff(el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ aff_list(ctx ctx, string str)
{
  var res = Interop.isl_aff_list_read_from_str(ctx.get(), str);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

public void Dispose() {
  if (!is_null()) {
    Interop.isl_aff_list_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_aff_list_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public aff_list add(aff el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_aff_list_add(copy(), el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new aff_list(res);
}

 public aff at(int index)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_aff_list_get_at(get(), index);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new aff(res);
}

 public aff_list clear()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_aff_list_clear(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new aff_list(res);
}

 public aff_list concat(aff_list list2)
{
  if (get() == IntPtr.Zero || list2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_aff_list_concat(copy(), list2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new aff_list(res);
}

 public aff_list drop(uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_aff_list_drop(copy(), first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new aff_list(res);
}

 public void Foreach(Action<aff> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Action<aff> func,  Exception? eptr) fn_data = (func: fn, eptr: null);
Func<IntPtr, IntPtr, isl_stat> fn_lambda = (IntPtr arg_0, IntPtr arg_1) => {
    try {
      fn_data.func(new (arg_0));
      return isl_stat.Ok;
    } catch (Exception e) {
      throw e;
      return isl_stat.Error;
    }
  };
  var res = Interop.isl_aff_list_foreach(get(), fn_lambda, IntPtr.Zero);
  if (fn_data.eptr is not null) {
    throw fn_data.eptr;
  }
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return;
}

 public void foreach_scc(Func<aff, aff, bool> follows, Action<aff_list> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Func<aff, aff, bool> func,  Exception? eptr) follows_data = (func: follows, eptr: null);
Func<IntPtr, IntPtr, IntPtr, isl_bool> follows_lambda = (IntPtr arg_0, IntPtr arg_1, IntPtr arg_2) => {
    try {
      var ret = follows_data.func(new (arg_0), new (arg_1));
      return ret ? isl_bool.True : isl_bool.False;
    } catch (Exception e) {
      throw e;
      return isl_bool.Error;
    }
  };
 (Action<aff_list> func,  Exception? eptr) fn_data = (func: fn, eptr: null);
Func<IntPtr, IntPtr, isl_stat> fn_lambda = (IntPtr arg_0, IntPtr arg_1) => {
    try {
      fn_data.func(new (arg_0));
      return isl_stat.Ok;
    } catch (Exception e) {
      throw e;
      return isl_stat.Error;
    }
  };
  var res = Interop.isl_aff_list_foreach_scc(get(), follows_lambda, IntPtr.Zero, fn_lambda, IntPtr.Zero);
  if (follows_data.eptr is not null) {
    throw follows_data.eptr;
  }
  if (fn_data.eptr is not null) {
    throw fn_data.eptr;
  }
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return;
}

 public aff_list insert(uint pos, aff el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_aff_list_insert(copy(), pos, el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new aff_list(res);
}

 public aff_list set_at(int index, aff el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_aff_list_set_at(copy(), index, el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new aff_list(res);
}

 public int size()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_aff_list_size(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

public override string ToString(){
  var str = Interop.isl_aff_list_to_str(get());
  return str;
}
}

public class ast_build : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal ast_build(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }
 class at_each_domain_tuple {
 public Func<ast_node, ast_build, ast_node> func;
 public Exception? eptr;
}
  at_each_domain_tuple? at_each_domain_data = null;

 public /* explicit */ ast_build(ctx ctx)
{
  var res = Interop.isl_ast_build_alloc(ctx.get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

public void Dispose() {
  if (!is_null()) {
    Interop.isl_ast_build_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_ast_build_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

public ast_build copy_callbacks(ast_build obj)
{
  at_each_domain_data = obj.at_each_domain_data;
  return this;
}

private IntPtr at_each_domain(IntPtr arg_0, IntPtr arg_1, IntPtr arg_2)
{
  try {
    var ret = at_each_domain_data.func(new (arg_0), new (arg_1));
    return ret.get();
  } catch (Exception e) {
    throw e;
    return IntPtr.Zero;
  }
}

public void set_at_each_domain_data(Func<ast_node, ast_build, ast_node> fn)
{
  at_each_domain_data = new();
  at_each_domain_data.func = fn;
  ptr = Interop.isl_ast_build_set_at_each_domain(ptr, at_each_domain, IntPtr.Zero);
  if (ptr == IntPtr.Zero)
    throw new InvalidOperationException();
}

 public ast_build set_at_each_domain(Func<ast_node, ast_build, ast_node> fn)
{
  this.set_at_each_domain_data(fn);
  return this;
}

 public ast_expr access_from(multi_pw_aff mpa)
{
  if (get() == IntPtr.Zero || mpa.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_build_access_from_multi_pw_aff(get(), mpa.copy());
  if (at_each_domain_data is not null && at_each_domain_data.eptr is not null) {
    var eptr = at_each_domain_data.eptr!;
    at_each_domain_data.eptr = null;
    throw eptr;
  }
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new ast_expr(res);
}

 public ast_expr access_from(pw_multi_aff pma)
{
  if (get() == IntPtr.Zero || pma.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_build_access_from_pw_multi_aff(get(), pma.copy());
  if (at_each_domain_data is not null && at_each_domain_data.eptr is not null) {
    var eptr = at_each_domain_data.eptr!;
    at_each_domain_data.eptr = null;
    throw eptr;
  }
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new ast_expr(res);
}

 public ast_expr call_from(multi_pw_aff mpa)
{
  if (get() == IntPtr.Zero || mpa.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_build_call_from_multi_pw_aff(get(), mpa.copy());
  if (at_each_domain_data is not null && at_each_domain_data.eptr is not null) {
    var eptr = at_each_domain_data.eptr!;
    at_each_domain_data.eptr = null;
    throw eptr;
  }
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new ast_expr(res);
}

 public ast_expr call_from(pw_multi_aff pma)
{
  if (get() == IntPtr.Zero || pma.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_build_call_from_pw_multi_aff(get(), pma.copy());
  if (at_each_domain_data is not null && at_each_domain_data.eptr is not null) {
    var eptr = at_each_domain_data.eptr!;
    at_each_domain_data.eptr = null;
    throw eptr;
  }
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new ast_expr(res);
}

 public ast_expr expr_from(pw_aff pa)
{
  if (get() == IntPtr.Zero || pa.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_build_expr_from_pw_aff(get(), pa.copy());
  if (at_each_domain_data is not null && at_each_domain_data.eptr is not null) {
    var eptr = at_each_domain_data.eptr!;
    at_each_domain_data.eptr = null;
    throw eptr;
  }
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new ast_expr(res);
}

 public ast_expr expr_from(set set)
{
  if (get() == IntPtr.Zero || set.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_build_expr_from_set(get(), set.copy());
  if (at_each_domain_data is not null && at_each_domain_data.eptr is not null) {
    var eptr = at_each_domain_data.eptr!;
    at_each_domain_data.eptr = null;
    throw eptr;
  }
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new ast_expr(res);
}

 public static ast_build from_context(set set)
{
  if (set.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_build_from_context(set.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new ast_build(res);
}

 public ast_node node_from(schedule schedule)
{
  if (get() == IntPtr.Zero || schedule.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_build_node_from_schedule(get(), schedule.copy());
  if (at_each_domain_data is not null && at_each_domain_data.eptr is not null) {
    var eptr = at_each_domain_data.eptr!;
    at_each_domain_data.eptr = null;
    throw eptr;
  }
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new ast_node(res);
}

 public ast_node node_from_schedule_map(union_map schedule)
{
  if (get() == IntPtr.Zero || schedule.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_build_node_from_schedule_map(get(), schedule.copy());
  if (at_each_domain_data is not null && at_each_domain_data.eptr is not null) {
    var eptr = at_each_domain_data.eptr!;
    at_each_domain_data.eptr = null;
    throw eptr;
  }
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new ast_node(res);
}

 public union_map schedule()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_build_get_schedule(get());
  if (at_each_domain_data is not null && at_each_domain_data.eptr is not null) {
    var eptr = at_each_domain_data.eptr!;
    at_each_domain_data.eptr = null;
    throw eptr;
  }
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}
}

public class ast_expr : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal ast_expr(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

public void Dispose() {
  if (!is_null()) {
    Interop.isl_ast_expr_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_ast_expr_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public string to_C_str()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_expr_to_C_str(get());
  return res;
}

public override string ToString(){
  var str = Interop.isl_ast_expr_to_str(get());
  return str;
}
}

public class ast_expr_id : ast_expr , IDisposable, IObject {

internal ast_expr_id(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

 public id id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_expr_id_get_id(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new id(res);
}

public override string ToString(){
  var str = Interop.isl_ast_expr_to_str(get());
  return str;
}
}

public class ast_expr_int : ast_expr , IDisposable, IObject {

internal ast_expr_int(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

 public val val()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_expr_int_get_val(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

public override string ToString(){
  var str = Interop.isl_ast_expr_to_str(get());
  return str;
}
}

public class ast_expr_op : ast_expr , IDisposable, IObject {

internal ast_expr_op(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

 public ast_expr arg(int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_expr_op_get_arg(get(), pos);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new ast_expr(res);
}

 public int n_arg()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_expr_op_get_n_arg(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

public override string ToString(){
  var str = Interop.isl_ast_expr_to_str(get());
  return str;
}
}

public class ast_expr_op_access : ast_expr_op , IDisposable, IObject {

internal ast_expr_op_access(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

public override string ToString(){
  var str = Interop.isl_ast_expr_to_str(get());
  return str;
}
}

public class ast_expr_op_add : ast_expr_op , IDisposable, IObject {

internal ast_expr_op_add(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

public override string ToString(){
  var str = Interop.isl_ast_expr_to_str(get());
  return str;
}
}

public class ast_expr_op_address_of : ast_expr_op , IDisposable, IObject {

internal ast_expr_op_address_of(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

public override string ToString(){
  var str = Interop.isl_ast_expr_to_str(get());
  return str;
}
}

public class ast_expr_op_and : ast_expr_op , IDisposable, IObject {

internal ast_expr_op_and(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

public override string ToString(){
  var str = Interop.isl_ast_expr_to_str(get());
  return str;
}
}

public class ast_expr_op_and_then : ast_expr_op , IDisposable, IObject {

internal ast_expr_op_and_then(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

public override string ToString(){
  var str = Interop.isl_ast_expr_to_str(get());
  return str;
}
}

public class ast_expr_op_call : ast_expr_op , IDisposable, IObject {

internal ast_expr_op_call(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

public override string ToString(){
  var str = Interop.isl_ast_expr_to_str(get());
  return str;
}
}

public class ast_expr_op_cond : ast_expr_op , IDisposable, IObject {

internal ast_expr_op_cond(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

public override string ToString(){
  var str = Interop.isl_ast_expr_to_str(get());
  return str;
}
}

public class ast_expr_op_div : ast_expr_op , IDisposable, IObject {

internal ast_expr_op_div(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

public override string ToString(){
  var str = Interop.isl_ast_expr_to_str(get());
  return str;
}
}

public class ast_expr_op_eq : ast_expr_op , IDisposable, IObject {

internal ast_expr_op_eq(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

public override string ToString(){
  var str = Interop.isl_ast_expr_to_str(get());
  return str;
}
}

public class ast_expr_op_fdiv_q : ast_expr_op , IDisposable, IObject {

internal ast_expr_op_fdiv_q(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

public override string ToString(){
  var str = Interop.isl_ast_expr_to_str(get());
  return str;
}
}

public class ast_expr_op_ge : ast_expr_op , IDisposable, IObject {

internal ast_expr_op_ge(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

public override string ToString(){
  var str = Interop.isl_ast_expr_to_str(get());
  return str;
}
}

public class ast_expr_op_gt : ast_expr_op , IDisposable, IObject {

internal ast_expr_op_gt(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

public override string ToString(){
  var str = Interop.isl_ast_expr_to_str(get());
  return str;
}
}

public class ast_expr_op_le : ast_expr_op , IDisposable, IObject {

internal ast_expr_op_le(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

public override string ToString(){
  var str = Interop.isl_ast_expr_to_str(get());
  return str;
}
}

public class ast_expr_op_lt : ast_expr_op , IDisposable, IObject {

internal ast_expr_op_lt(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

public override string ToString(){
  var str = Interop.isl_ast_expr_to_str(get());
  return str;
}
}

public class ast_expr_op_max : ast_expr_op , IDisposable, IObject {

internal ast_expr_op_max(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

public override string ToString(){
  var str = Interop.isl_ast_expr_to_str(get());
  return str;
}
}

public class ast_expr_op_member : ast_expr_op , IDisposable, IObject {

internal ast_expr_op_member(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

public override string ToString(){
  var str = Interop.isl_ast_expr_to_str(get());
  return str;
}
}

public class ast_expr_op_min : ast_expr_op , IDisposable, IObject {

internal ast_expr_op_min(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

public override string ToString(){
  var str = Interop.isl_ast_expr_to_str(get());
  return str;
}
}

public class ast_expr_op_minus : ast_expr_op , IDisposable, IObject {

internal ast_expr_op_minus(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

public override string ToString(){
  var str = Interop.isl_ast_expr_to_str(get());
  return str;
}
}

public class ast_expr_op_mul : ast_expr_op , IDisposable, IObject {

internal ast_expr_op_mul(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

public override string ToString(){
  var str = Interop.isl_ast_expr_to_str(get());
  return str;
}
}

public class ast_expr_op_or : ast_expr_op , IDisposable, IObject {

internal ast_expr_op_or(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

public override string ToString(){
  var str = Interop.isl_ast_expr_to_str(get());
  return str;
}
}

public class ast_expr_op_or_else : ast_expr_op , IDisposable, IObject {

internal ast_expr_op_or_else(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

public override string ToString(){
  var str = Interop.isl_ast_expr_to_str(get());
  return str;
}
}

public class ast_expr_op_pdiv_q : ast_expr_op , IDisposable, IObject {

internal ast_expr_op_pdiv_q(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

public override string ToString(){
  var str = Interop.isl_ast_expr_to_str(get());
  return str;
}
}

public class ast_expr_op_pdiv_r : ast_expr_op , IDisposable, IObject {

internal ast_expr_op_pdiv_r(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

public override string ToString(){
  var str = Interop.isl_ast_expr_to_str(get());
  return str;
}
}

public class ast_expr_op_select : ast_expr_op , IDisposable, IObject {

internal ast_expr_op_select(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

public override string ToString(){
  var str = Interop.isl_ast_expr_to_str(get());
  return str;
}
}

public class ast_expr_op_sub : ast_expr_op , IDisposable, IObject {

internal ast_expr_op_sub(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

public override string ToString(){
  var str = Interop.isl_ast_expr_to_str(get());
  return str;
}
}

public class ast_expr_op_zdiv_r : ast_expr_op , IDisposable, IObject {

internal ast_expr_op_zdiv_r(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

public override string ToString(){
  var str = Interop.isl_ast_expr_to_str(get());
  return str;
}
}

public class ast_node : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal ast_node(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

public void Dispose() {
  if (!is_null()) {
    Interop.isl_ast_node_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_ast_node_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public ast_node map_descendant_bottom_up(Func<ast_node, ast_node> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Func<ast_node, ast_node> func,  Exception? eptr) fn_data = (func: fn, eptr: null);
Func<IntPtr, IntPtr, IntPtr> fn_lambda = (IntPtr arg_0, IntPtr arg_1) => {
    try {
      var ret = fn_data.func(new (arg_0));
      return ret.get();
    } catch (Exception e) {
      throw e;
      return IntPtr.Zero;
    }
  };
  var res = Interop.isl_ast_node_map_descendant_bottom_up(copy(), fn_lambda, IntPtr.Zero);
  if (fn_data.eptr is not null) {
    throw fn_data.eptr;
  }
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new ast_node(res);
}

 public string to_C_str()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_node_to_C_str(get());
  return res;
}

 public ast_node_list to_list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_node_to_list(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new ast_node_list(res);
}

public override string ToString(){
  var str = Interop.isl_ast_node_to_str(get());
  return str;
}
}

public class ast_node_block : ast_node , IDisposable, IObject {

internal ast_node_block(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

 public /* explicit */ ast_node_block(ast_node_list list) : base(IntPtr.Zero) 
{
  if (list.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_node_block_from_children(list.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public ast_node_list children()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_node_block_get_children(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new ast_node_list(res);
}

public override string ToString(){
  var str = Interop.isl_ast_node_to_str(get());
  return str;
}
}

public class ast_node_for : ast_node , IDisposable, IObject {

internal ast_node_for(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

 public ast_node body()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_node_for_get_body(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new ast_node(res);
}

 public ast_expr cond()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_node_for_get_cond(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new ast_expr(res);
}

 public ast_expr inc()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_node_for_get_inc(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new ast_expr(res);
}

 public ast_expr init()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_node_for_get_init(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new ast_expr(res);
}

 public bool is_degenerate()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_node_for_is_degenerate(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public ast_expr iterator()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_node_for_get_iterator(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new ast_expr(res);
}

public override string ToString(){
  var str = Interop.isl_ast_node_to_str(get());
  return str;
}
}

public class ast_node_if : ast_node , IDisposable, IObject {

internal ast_node_if(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

 public ast_expr cond()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_node_if_get_cond(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new ast_expr(res);
}

 public ast_node else_node()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_node_if_get_else_node(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new ast_node(res);
}

 public bool has_else_node()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_node_if_has_else_node(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public ast_node then_node()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_node_if_get_then_node(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new ast_node(res);
}

public override string ToString(){
  var str = Interop.isl_ast_node_to_str(get());
  return str;
}
}

public class ast_node_list : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal ast_node_list(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

 public /* explicit */ ast_node_list(ctx ctx, int n)
{
  var res = Interop.isl_ast_node_list_alloc(ctx.get(), n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ ast_node_list(ast_node el)
{
  if (el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_node_list_from_ast_node(el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

public void Dispose() {
  if (!is_null()) {
    Interop.isl_ast_node_list_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_ast_node_list_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public ast_node_list add(ast_node el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_node_list_add(copy(), el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new ast_node_list(res);
}

 public ast_node at(int index)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_node_list_get_at(get(), index);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new ast_node(res);
}

 public ast_node_list clear()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_node_list_clear(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new ast_node_list(res);
}

 public ast_node_list concat(ast_node_list list2)
{
  if (get() == IntPtr.Zero || list2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_node_list_concat(copy(), list2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new ast_node_list(res);
}

 public ast_node_list drop(uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_node_list_drop(copy(), first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new ast_node_list(res);
}

 public void Foreach(Action<ast_node> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Action<ast_node> func,  Exception? eptr) fn_data = (func: fn, eptr: null);
Func<IntPtr, IntPtr, isl_stat> fn_lambda = (IntPtr arg_0, IntPtr arg_1) => {
    try {
      fn_data.func(new (arg_0));
      return isl_stat.Ok;
    } catch (Exception e) {
      throw e;
      return isl_stat.Error;
    }
  };
  var res = Interop.isl_ast_node_list_foreach(get(), fn_lambda, IntPtr.Zero);
  if (fn_data.eptr is not null) {
    throw fn_data.eptr;
  }
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return;
}

 public void foreach_scc(Func<ast_node, ast_node, bool> follows, Action<ast_node_list> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Func<ast_node, ast_node, bool> func,  Exception? eptr) follows_data = (func: follows, eptr: null);
Func<IntPtr, IntPtr, IntPtr, isl_bool> follows_lambda = (IntPtr arg_0, IntPtr arg_1, IntPtr arg_2) => {
    try {
      var ret = follows_data.func(new (arg_0), new (arg_1));
      return ret ? isl_bool.True : isl_bool.False;
    } catch (Exception e) {
      throw e;
      return isl_bool.Error;
    }
  };
 (Action<ast_node_list> func,  Exception? eptr) fn_data = (func: fn, eptr: null);
Func<IntPtr, IntPtr, isl_stat> fn_lambda = (IntPtr arg_0, IntPtr arg_1) => {
    try {
      fn_data.func(new (arg_0));
      return isl_stat.Ok;
    } catch (Exception e) {
      throw e;
      return isl_stat.Error;
    }
  };
  var res = Interop.isl_ast_node_list_foreach_scc(get(), follows_lambda, IntPtr.Zero, fn_lambda, IntPtr.Zero);
  if (follows_data.eptr is not null) {
    throw follows_data.eptr;
  }
  if (fn_data.eptr is not null) {
    throw fn_data.eptr;
  }
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return;
}

 public ast_node_list insert(uint pos, ast_node el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_node_list_insert(copy(), pos, el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new ast_node_list(res);
}

 public ast_node_list set_at(int index, ast_node el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_node_list_set_at(copy(), index, el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new ast_node_list(res);
}

 public int size()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_node_list_size(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

public override string ToString(){
  var str = Interop.isl_ast_node_list_to_str(get());
  return str;
}
}

public class ast_node_mark : ast_node , IDisposable, IObject {

internal ast_node_mark(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

 public id id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_node_mark_get_id(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new id(res);
}

 public ast_node node()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_node_mark_get_node(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new ast_node(res);
}

public override string ToString(){
  var str = Interop.isl_ast_node_to_str(get());
  return str;
}
}

public class ast_node_user : ast_node , IDisposable, IObject {

internal ast_node_user(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

 public /* explicit */ ast_node_user(ast_expr expr) : base(IntPtr.Zero) 
{
  if (expr.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_node_user_from_expr(expr.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public ast_expr expr()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_ast_node_user_get_expr(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new ast_expr(res);
}

public override string ToString(){
  var str = Interop.isl_ast_node_to_str(get());
  return str;
}
}

public class basic_map : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal basic_map(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

 public /* explicit */ basic_map(ctx ctx, string str)
{
  var res = Interop.isl_basic_map_read_from_str(ctx.get(), str);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

public void Dispose() {
  if (!is_null()) {
    Interop.isl_basic_map_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_basic_map_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public basic_map add_constraint(constraint constraint)
{
  if (get() == IntPtr.Zero || constraint.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_add_constraint(copy(), constraint.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public basic_map add_dims(dim_type type, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_add_dims(copy(), type, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public basic_map affine_hull()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_affine_hull(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public basic_map align_params(space model)
{
  if (get() == IntPtr.Zero || model.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_align_params(copy(), model.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public basic_map apply_domain(basic_map bmap2)
{
  if (get() == IntPtr.Zero || bmap2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_apply_domain(copy(), bmap2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public map apply_domain(map map2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).apply_domain(map2);
}

 public union_map apply_domain(union_map umap2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).apply_domain(umap2);
}

 public basic_map apply_range(basic_map bmap2)
{
  if (get() == IntPtr.Zero || bmap2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_apply_range(copy(), bmap2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public map apply_range(map map2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).apply_range(map2);
}

 public union_map apply_range(union_map umap2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).apply_range(umap2);
}

 public map as_map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).as_map();
}

 public multi_union_pw_aff as_multi_union_pw_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).as_multi_union_pw_aff();
}

 public pw_multi_aff as_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).as_pw_multi_aff();
}

 public union_pw_multi_aff as_union_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).as_union_pw_multi_aff();
}

 public set bind_domain(multi_id tuple)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).bind_domain(tuple);
}

 public set bind_range(multi_id tuple)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).bind_range(tuple);
}

 public bool can_curry()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_can_curry(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool can_range_curry()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).can_range_curry();
}

 public bool can_uncurry()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_can_uncurry(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool can_zip()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_can_zip(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public map coalesce()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).coalesce();
}

 public map complement()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).complement();
}

 public map compute_divs()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_compute_divs(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public constraint_list constraint_list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_get_constraint_list(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new constraint_list(res);
}

 public basic_map convex_hull()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).convex_hull();
}

 public basic_map curry()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_curry(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public basic_set deltas()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_deltas(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public basic_map deltas_map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_deltas_map(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public basic_map detect_equalities()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_detect_equalities(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public int dim(dim_type type)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_dim(get(), type);
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

 public id dim_id(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).dim_id(type, pos);
}

 public pw_aff dim_max(int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).dim_max(pos);
}

 public pw_aff dim_min(int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).dim_min(pos);
}

 public string dim_name(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_get_dim_name(get(), type, pos);
  return Marshal.PtrToStringAnsi(res);
}

 public aff div(int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_get_div(get(), pos);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new aff(res);
}

 public basic_set domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_domain(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public map domain_factor_domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).domain_factor_domain();
}

 public map domain_factor_range()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).domain_factor_range();
}

 public bool domain_is_wrapping()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).domain_is_wrapping();
}

 public basic_map domain_map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_domain_map(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public union_pw_multi_aff domain_map_union_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).domain_map_union_pw_multi_aff();
}

 public map domain_product(map map2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).domain_product(map2);
}

 public union_map domain_product(union_map umap2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).domain_product(umap2);
}

 public map domain_reverse()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).domain_reverse();
}

 public int domain_tuple_dim()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).domain_tuple_dim();
}

 public id domain_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).domain_tuple_id();
}

 public basic_map drop_constraints_involving_dims(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_drop_constraints_involving_dims(copy(), type, first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public basic_map drop_constraints_not_involving_dims(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_drop_constraints_not_involving_dims(copy(), type, first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public basic_map drop_unused_params()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_drop_unused_params(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public basic_map eliminate(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_eliminate(copy(), type, first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public static basic_map empty(space space)
{
  if (space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_empty(space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public map eq_at(multi_pw_aff mpa)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).eq_at(mpa);
}

 public union_map eq_at(multi_union_pw_aff mupa)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).eq_at(mupa);
}

 public mat equalities_matrix(dim_type c1, dim_type c2, dim_type c3, dim_type c4, dim_type c5)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_equalities_matrix(get(), c1, c2, c3, c4, c5);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new mat(res);
}

 public basic_map equate(dim_type type1, int pos1, dim_type type2, int pos2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_equate(copy(), type1, pos1, type2, pos2);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public bool every_map(Func<map, bool> test)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).every_map(test);
}

 public map extract_map(space space)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).extract_map(space);
}

 public map factor_domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).factor_domain();
}

 public map factor_range()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).factor_range();
}

 public int find_dim_by_id(dim_type type, id id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).find_dim_by_id(type, id);
}

 public int find_dim_by_id(dim_type type, string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.find_dim_by_id(type, new id(ctx.Instance, id));
}

 public int find_dim_by_name(dim_type type, string name)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_find_dim_by_name(get(), type, name);
  return res;
}

 public map fix_input_si(uint input, int value)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).fix_input_si(input, value);
}

 public basic_map fix_si(dim_type type, uint pos, int value)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_fix_si(copy(), type, pos, value);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public basic_map fix_val(dim_type type, uint pos, val v)
{
  if (get() == IntPtr.Zero || v.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_fix_val(copy(), type, pos, v.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public basic_map fix_val(dim_type type, uint pos, long v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.fix_val(type, pos, new val(ctx.Instance, v));
}

 public map fixed_power(val exp)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).fixed_power(exp);
}

 public map fixed_power(long exp)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.fixed_power(new val(ctx.Instance, exp));
}

 public map flat_domain_product(map map2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).flat_domain_product(map2);
}

 public basic_map flat_product(basic_map bmap2)
{
  if (get() == IntPtr.Zero || bmap2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_flat_product(copy(), bmap2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public map flat_product(map map2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).flat_product(map2);
}

 public basic_map flat_range_product(basic_map bmap2)
{
  if (get() == IntPtr.Zero || bmap2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_flat_range_product(copy(), bmap2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public map flat_range_product(map map2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).flat_range_product(map2);
}

 public basic_map flatten()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_flatten(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public basic_map flatten_domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_flatten_domain(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public basic_map flatten_range()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_flatten_range(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public map floordiv_val(val d)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).floordiv_val(d);
}

 public map floordiv_val(long d)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.floordiv_val(new val(ctx.Instance, d));
}

 public void foreach_basic_map(Action<basic_map> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
new map(get()).foreach_basic_map(fn);
}

 public void foreach_constraint(Action<constraint> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Action<constraint> func,  Exception? eptr) fn_data = (func: fn, eptr: null);
Func<IntPtr, IntPtr, isl_stat> fn_lambda = (IntPtr arg_0, IntPtr arg_1) => {
    try {
      fn_data.func(new (arg_0));
      return isl_stat.Ok;
    } catch (Exception e) {
      throw e;
      return isl_stat.Error;
    }
  };
  var res = Interop.isl_basic_map_foreach_constraint(get(), fn_lambda, IntPtr.Zero);
  if (fn_data.eptr is not null) {
    throw fn_data.eptr;
  }
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return;
}

 public void foreach_map(Action<map> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
new map(get()).foreach_map(fn);
}

 public static basic_map from_aff(aff aff)
{
  if (aff.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_from_aff(aff.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public static basic_map from_aff_list(space domain_space, aff_list list)
{
  if (domain_space.is_null() || list.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_from_aff_list(domain_space.copy(), list.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public static basic_map from_constraint(constraint constraint)
{
  if (constraint.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_from_constraint(constraint.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public static basic_map from_constraint_matrices(space space, mat eq, mat ineq, dim_type c1, dim_type c2, dim_type c3, dim_type c4, dim_type c5)
{
  if (space.is_null() || eq.is_null() || ineq.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_from_constraint_matrices(space.copy(), eq.copy(), ineq.copy(), c1, c2, c3, c4, c5);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public static basic_map from_domain(basic_set bset)
{
  if (bset.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_from_domain(bset.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public static basic_map from_domain_and_range(basic_set domain, basic_set range)
{
  if (domain.is_null() || range.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_from_domain_and_range(domain.copy(), range.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public static basic_map from_multi_aff(multi_aff maff)
{
  if (maff.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_from_multi_aff(maff.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public static basic_map from_range(basic_set bset)
{
  if (bset.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_from_range(bset.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public basic_map gist(basic_map context)
{
  if (get() == IntPtr.Zero || context.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_gist(copy(), context.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public map gist(map context)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).gist(context);
}

 public union_map gist(union_map context)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).gist(context);
}

 public map gist_basic_map(basic_map context)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).gist_basic_map(context);
}

 public basic_map gist_domain(basic_set context)
{
  if (get() == IntPtr.Zero || context.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_gist_domain(copy(), context.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public map gist_domain(set context)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).gist_domain(context);
}

 public union_map gist_domain(union_set uset)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).gist_domain(uset);
}

 public basic_map gist_domain(point context)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.gist_domain(new basic_set(context));
}

 public map gist_params(set context)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).gist_params(context);
}

 public union_map gist_range(union_set uset)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).gist_range(uset);
}

 public bool has_dim_id(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_has_dim_id(get(), type, pos);
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool has_dim_name(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).has_dim_name(type, pos);
}

 public bool has_domain_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).has_domain_tuple_id();
}

 public bool has_equal_space(map map2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).has_equal_space(map2);
}

 public bool has_range_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).has_range_tuple_id();
}

 public bool has_tuple_name(dim_type type)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).has_tuple_name(type);
}

 public static basic_map identity(space space)
{
  if (space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_identity(space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public bool image_is_bounded()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_image_is_bounded(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public mat inequalities_matrix(dim_type c1, dim_type c2, dim_type c3, dim_type c4, dim_type c5)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_inequalities_matrix(get(), c1, c2, c3, c4, c5);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new mat(res);
}

 public basic_map insert_dims(dim_type type, uint pos, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_insert_dims(copy(), type, pos, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public basic_map intersect(basic_map bmap2)
{
  if (get() == IntPtr.Zero || bmap2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_intersect(copy(), bmap2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public map intersect(map map2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).intersect(map2);
}

 public union_map intersect(union_map umap2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).intersect(umap2);
}

 public basic_map intersect_domain(basic_set bset)
{
  if (get() == IntPtr.Zero || bset.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_intersect_domain(copy(), bset.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public map intersect_domain(set set)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).intersect_domain(set);
}

 public union_map intersect_domain(space space)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).intersect_domain(space);
}

 public union_map intersect_domain(union_set uset)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).intersect_domain(uset);
}

 public basic_map intersect_domain(point bset)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.intersect_domain(new basic_set(bset));
}

 public map intersect_domain_factor_domain(map factor)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).intersect_domain_factor_domain(factor);
}

 public union_map intersect_domain_factor_domain(union_map factor)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).intersect_domain_factor_domain(factor);
}

 public map intersect_domain_factor_range(map factor)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).intersect_domain_factor_range(factor);
}

 public union_map intersect_domain_factor_range(union_map factor)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).intersect_domain_factor_range(factor);
}

 public map intersect_domain_wrapped_domain(set domain)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).intersect_domain_wrapped_domain(domain);
}

 public union_map intersect_domain_wrapped_domain(union_set domain)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).intersect_domain_wrapped_domain(domain);
}

 public basic_map intersect_params(basic_set bset)
{
  if (get() == IntPtr.Zero || bset.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_intersect_params(copy(), bset.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public map intersect_params(set params_)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).intersect_params(params_);
}

 public basic_map intersect_params(point bset)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.intersect_params(new basic_set(bset));
}

 public basic_map intersect_range(basic_set bset)
{
  if (get() == IntPtr.Zero || bset.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_intersect_range(copy(), bset.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public map intersect_range(set set)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).intersect_range(set);
}

 public union_map intersect_range(space space)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).intersect_range(space);
}

 public union_map intersect_range(union_set uset)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).intersect_range(uset);
}

 public basic_map intersect_range(point bset)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.intersect_range(new basic_set(bset));
}

 public map intersect_range_factor_domain(map factor)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).intersect_range_factor_domain(factor);
}

 public union_map intersect_range_factor_domain(union_map factor)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).intersect_range_factor_domain(factor);
}

 public map intersect_range_factor_range(map factor)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).intersect_range_factor_range(factor);
}

 public union_map intersect_range_factor_range(union_map factor)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).intersect_range_factor_range(factor);
}

 public map intersect_range_wrapped_domain(set domain)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).intersect_range_wrapped_domain(domain);
}

 public union_map intersect_range_wrapped_domain(union_set domain)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).intersect_range_wrapped_domain(domain);
}

 public bool involves_dims(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_involves_dims(get(), type, first, n);
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_bijective()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).is_bijective();
}

 public bool is_disjoint(basic_map bmap2)
{
  if (get() == IntPtr.Zero || bmap2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_is_disjoint(get(), bmap2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_disjoint(map map2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).is_disjoint(map2);
}

 public bool is_disjoint(union_map umap2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).is_disjoint(umap2);
}

 public bool is_empty()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_is_empty(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_equal(basic_map bmap2)
{
  if (get() == IntPtr.Zero || bmap2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_is_equal(get(), bmap2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_equal(map map2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).is_equal(map2);
}

 public bool is_equal(union_map umap2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).is_equal(umap2);
}

 public bool is_identity()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).is_identity();
}

 public bool is_injective()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).is_injective();
}

 public bool is_product()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).is_product();
}

 public bool is_rational()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_is_rational(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_single_valued()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_is_single_valued(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_strict_subset(basic_map bmap2)
{
  if (get() == IntPtr.Zero || bmap2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_is_strict_subset(get(), bmap2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_strict_subset(map map2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).is_strict_subset(map2);
}

 public bool is_strict_subset(union_map umap2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).is_strict_subset(umap2);
}

 public bool is_subset(basic_map bmap2)
{
  if (get() == IntPtr.Zero || bmap2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_is_subset(get(), bmap2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_subset(map map2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).is_subset(map2);
}

 public bool is_subset(union_map umap2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).is_subset(umap2);
}

 public int is_translation()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).is_translation();
}

 public bool is_universe()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_is_universe(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool isa_map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).isa_map();
}

 public static basic_map less_at(space space, uint pos)
{
  if (space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_less_at(space.copy(), pos);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public map lex_ge_at(multi_pw_aff mpa)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).lex_ge_at(mpa);
}

 public map lex_ge_map(map map2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).lex_ge_map(map2);
}

 public map lex_gt_at(multi_pw_aff mpa)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).lex_gt_at(mpa);
}

 public map lex_gt_map(map map2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).lex_gt_map(map2);
}

 public map lex_le_at(multi_pw_aff mpa)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).lex_le_at(mpa);
}

 public map lex_le_map(map map2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).lex_le_map(map2);
}

 public map lex_lt_at(multi_pw_aff mpa)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).lex_lt_at(mpa);
}

 public map lex_lt_map(map map2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).lex_lt_map(map2);
}

 public map lexmax()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_lexmax(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public pw_multi_aff lexmax_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).lexmax_pw_multi_aff();
}

 public map lexmin()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_lexmin(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public pw_multi_aff lexmin_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).lexmin_pw_multi_aff();
}

 public map lower_bound(multi_pw_aff lower)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).lower_bound(lower);
}

 public basic_map lower_bound_si(dim_type type, uint pos, int value)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_lower_bound_si(copy(), type, pos, value);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public map lower_bound_val(dim_type type, uint pos, val value)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).lower_bound_val(type, pos, value);
}

 public map lower_bound_val(dim_type type, uint pos, long value)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.lower_bound_val(type, pos, new val(ctx.Instance, value));
}

 public map make_disjoint()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).make_disjoint();
}

 public map_list map_list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).map_list();
}

 public multi_pw_aff max_multi_pw_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).max_multi_pw_aff();
}

 public multi_pw_aff min_multi_pw_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).min_multi_pw_aff();
}

 public static basic_map more_at(space space, uint pos)
{
  if (space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_more_at(space.copy(), pos);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public basic_map move_dims(dim_type dst_type, uint dst_pos, dim_type src_type, uint src_pos, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_move_dims(copy(), dst_type, dst_pos, src_type, src_pos, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public int n_basic_map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).n_basic_map();
}

 public int n_constraint()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_n_constraint(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

 public static basic_map nat_universe(space space)
{
  if (space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_nat_universe(space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public basic_map neg()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_neg(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public map oppose(dim_type type1, int pos1, dim_type type2, int pos2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).oppose(type1, pos1, type2, pos2);
}

 public basic_map order_ge(dim_type type1, int pos1, dim_type type2, int pos2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_order_ge(copy(), type1, pos1, type2, pos2);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public basic_map order_gt(dim_type type1, int pos1, dim_type type2, int pos2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_order_gt(copy(), type1, pos1, type2, pos2);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public map order_le(dim_type type1, int pos1, dim_type type2, int pos2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).order_le(type1, pos1, type2, pos2);
}

 public map order_lt(dim_type type1, int pos1, dim_type type2, int pos2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).order_lt(type1, pos1, type2, pos2);
}

 public set paramss()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).paramss();
}

 public val plain_get_val_if_fixed(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).plain_get_val_if_fixed(type, pos);
}

 public bool plain_is_empty()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_plain_is_empty(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool plain_is_injective()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).plain_is_injective();
}

 public bool plain_is_single_valued()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).plain_is_single_valued();
}

 public bool plain_is_universe()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_plain_is_universe(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public basic_map plain_unshifted_simple_hull()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).plain_unshifted_simple_hull();
}

 public basic_map polyhedral_hull()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).polyhedral_hull();
}

 public map preimage_domain(multi_aff ma)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).preimage_domain(ma);
}

 public map preimage_domain(multi_pw_aff mpa)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).preimage_domain(mpa);
}

 public map preimage_domain(pw_multi_aff pma)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).preimage_domain(pma);
}

 public union_map preimage_domain(union_pw_multi_aff upma)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).preimage_domain(upma);
}

 public map preimage_range(multi_aff ma)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).preimage_range(ma);
}

 public map preimage_range(pw_multi_aff pma)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).preimage_range(pma);
}

 public union_map preimage_range(union_pw_multi_aff upma)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).preimage_range(upma);
}

 public map product(map map2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).product(map2);
}

 public union_map product(union_map umap2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).product(umap2);
}

 public basic_map project_out(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_project_out(copy(), type, first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public map project_out_all_params()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).project_out_all_params();
}

 public map project_out_param(id id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).project_out_param(id);
}

 public map project_out_param(string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.project_out_param(new id(ctx.Instance, id));
}

 public map project_out_param(id_list list)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).project_out_param(list);
}

 public basic_set range()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_range(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public map range_curry()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).range_curry();
}

 public map range_factor_domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).range_factor_domain();
}

 public map range_factor_range()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).range_factor_range();
}

 public bool range_is_wrapping()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).range_is_wrapping();
}

 public fixed_box range_lattice_tile()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).range_lattice_tile();
}

 public basic_map range_map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_range_map(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public map range_product(map map2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).range_product(map2);
}

 public union_map range_product(union_map umap2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).range_product(umap2);
}

 public map range_reverse()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).range_reverse();
}

 public fixed_box range_simple_fixed_box_hull()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).range_simple_fixed_box_hull();
}

 public int range_tuple_dim()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).range_tuple_dim();
}

 public id range_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).range_tuple_id();
}

 public basic_map remove_dims(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_remove_dims(copy(), type, first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public basic_map remove_divs()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_remove_divs(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public basic_map remove_divs_involving_dims(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_remove_divs_involving_dims(copy(), type, first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public map remove_inputs(uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).remove_inputs(first, n);
}

 public basic_map remove_redundancies()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_remove_redundancies(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public map remove_unknown_divs()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).remove_unknown_divs();
}

 public basic_map reverse()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_reverse(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public basic_map sample()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_sample(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public map set_dim_id(dim_type type, uint pos, id id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).set_dim_id(type, pos, id);
}

 public map set_dim_id(dim_type type, uint pos, string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.set_dim_id(type, pos, new id(ctx.Instance, id));
}

 public basic_map set_dim_name(dim_type type, uint pos, string s)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_set_dim_name(copy(), type, pos, s);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public map set_domain_tuple(id id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).set_domain_tuple(id);
}

 public map set_domain_tuple(string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.set_domain_tuple(new id(ctx.Instance, id));
}

 public map set_range_tuple(id id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).set_range_tuple(id);
}

 public map set_range_tuple(string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.set_range_tuple(new id(ctx.Instance, id));
}

 public basic_map set_tuple_id(dim_type type, id id)
{
  if (get() == IntPtr.Zero || id.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_set_tuple_id(copy(), type, id.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public basic_map set_tuple_id(dim_type type, string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.set_tuple_id(type, new id(ctx.Instance, id));
}

 public basic_map set_tuple_name(dim_type type, string s)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_set_tuple_name(copy(), type, s);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public basic_map simple_hull()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).simple_hull();
}

 public space space()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_get_space(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public map subtract(map map2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).subtract(map2);
}

 public union_map subtract(union_map umap2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).subtract(umap2);
}

 public map subtract_domain(set dom)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).subtract_domain(dom);
}

 public union_map subtract_domain(union_set dom)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).subtract_domain(dom);
}

 public map subtract_range(set dom)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).subtract_range(dom);
}

 public union_map subtract_range(union_set dom)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).subtract_range(dom);
}

 public basic_map sum(basic_map bmap2)
{
  if (get() == IntPtr.Zero || bmap2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_sum(copy(), bmap2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public map sum(map map2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).sum(map2);
}

 public map_list to_list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).to_list();
}

 public union_map to_union_map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).to_union_map();
}

 public static int total_dim(basic_map bmap)
{
  if (bmap.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_total_dim(bmap.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

 public string tuple_name(dim_type type)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_get_tuple_name(get(), type);
  return Marshal.PtrToStringAnsi(res);
}

 public basic_map uncurry()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_uncurry(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public map union(basic_map bmap2)
{
  if (get() == IntPtr.Zero || bmap2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_union(copy(), bmap2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map union(map map2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).union(map2);
}

 public union_map union(union_map umap2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).union(umap2);
}

 public map union_disjoint(map map2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).union_disjoint(map2);
}

 public static basic_map universe(space space)
{
  if (space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_universe(space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public basic_map unshifted_simple_hull()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).unshifted_simple_hull();
}

 public basic_map unshifted_simple_hull_from_map_list(map_list list)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).unshifted_simple_hull_from_map_list(list);
}

 public map upper_bound(multi_pw_aff upper)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).upper_bound(upper);
}

 public basic_map upper_bound_si(dim_type type, uint pos, int value)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_upper_bound_si(copy(), type, pos, value);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public map upper_bound_val(dim_type type, uint pos, val value)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).upper_bound_val(type, pos, value);
}

 public map upper_bound_val(dim_type type, uint pos, long value)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.upper_bound_val(type, pos, new val(ctx.Instance, value));
}

 public set wrap()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new map(get()).wrap();
}

 public basic_map zip()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_map_zip(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

public override string ToString(){
  var str = Interop.isl_basic_map_to_str(get());
  return str;
}
}

public class basic_map_list : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal basic_map_list(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

public void Dispose() {
  if (!is_null()) {
    Interop.isl_basic_map_list_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_basic_map_list_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

public override string ToString(){
  var str = Interop.isl_basic_map_list_to_str(get());
  return str;
}
}

public class basic_set : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal basic_set(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

 public /* implicit */ basic_set(point pnt)
{
  if (pnt.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_from_point(pnt.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ basic_set(ctx ctx, string str)
{
  var res = Interop.isl_basic_set_read_from_str(ctx.get(), str);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

public void Dispose() {
  if (!is_null()) {
    Interop.isl_basic_set_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_basic_set_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public basic_set add_constraint(constraint constraint)
{
  if (get() == IntPtr.Zero || constraint.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_add_constraint(copy(), constraint.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public basic_set add_dims(dim_type type, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_add_dims(copy(), type, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public basic_set affine_hull()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_affine_hull(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public basic_set align_params(space model)
{
  if (get() == IntPtr.Zero || model.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_align_params(copy(), model.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public basic_set apply(basic_map bmap)
{
  if (get() == IntPtr.Zero || bmap.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_apply(copy(), bmap.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public set apply(map map)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).apply(map);
}

 public union_set apply(union_map umap)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).apply(umap);
}

 public pw_multi_aff as_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).as_pw_multi_aff();
}

 public set as_set()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).as_set();
}

 public basic_set_list basic_set_list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).basic_set_list();
}

 public set bind(multi_id tuple)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).bind(tuple);
}

 public static basic_set box_from_points(point pnt1, point pnt2)
{
  if (pnt1.is_null() || pnt2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_box_from_points(pnt1.copy(), pnt2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public set coalesce()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).coalesce();
}

 public basic_set coefficients()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_coefficients(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public set complement()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).complement();
}

 public set compute_divs()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_compute_divs(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public constraint_list constraint_list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_get_constraint_list(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new constraint_list(res);
}

 public val count_val()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).count_val();
}

 public basic_set detect_equalities()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_detect_equalities(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public int dim(dim_type type)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_dim(get(), type);
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

 public bool dim_has_any_lower_bound(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).dim_has_any_lower_bound(type, pos);
}

 public bool dim_has_any_upper_bound(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).dim_has_any_upper_bound(type, pos);
}

 public bool dim_has_lower_bound(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).dim_has_lower_bound(type, pos);
}

 public bool dim_has_upper_bound(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).dim_has_upper_bound(type, pos);
}

 public id dim_id(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_get_dim_id(get(), type, pos);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new id(res);
}

 public bool dim_is_bounded(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).dim_is_bounded(type, pos);
}

 public pw_aff dim_max(int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).dim_max(pos);
}

 public val dim_max_val(int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_dim_max_val(copy(), pos);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public pw_aff dim_min(int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).dim_min(pos);
}

 public val dim_min_val(int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).dim_min_val(pos);
}

 public string dim_name(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_get_dim_name(get(), type, pos);
  return Marshal.PtrToStringAnsi(res);
}

 public aff div(int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_get_div(get(), pos);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new aff(res);
}

 public basic_set drop_constraints_involving_dims(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_drop_constraints_involving_dims(copy(), type, first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public basic_set drop_constraints_not_involving_dims(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_drop_constraints_not_involving_dims(copy(), type, first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public basic_set drop_unused_params()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_drop_unused_params(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public basic_set eliminate(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_eliminate(copy(), type, first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public set eliminate_dims(uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).eliminate_dims(first, n);
}

 public mat equalities_matrix(dim_type c1, dim_type c2, dim_type c3, dim_type c4)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_equalities_matrix(get(), c1, c2, c3, c4);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new mat(res);
}

 public bool every_set(Func<set, bool> test)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).every_set(test);
}

 public set extract_set(space space)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).extract_set(space);
}

 public int find_dim_by_id(dim_type type, id id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).find_dim_by_id(type, id);
}

 public int find_dim_by_id(dim_type type, string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.find_dim_by_id(type, new id(ctx.Instance, id));
}

 public int find_dim_by_name(dim_type type, string name)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).find_dim_by_name(type, name);
}

 public set fix_dim_si(uint dim, int value)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).fix_dim_si(dim, value);
}

 public basic_set fix_si(dim_type type, uint pos, int value)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_fix_si(copy(), type, pos, value);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public basic_set fix_val(dim_type type, uint pos, val v)
{
  if (get() == IntPtr.Zero || v.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_fix_val(copy(), type, pos, v.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public basic_set fix_val(dim_type type, uint pos, long v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.fix_val(type, pos, new val(ctx.Instance, v));
}

 public basic_set flatten()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_flatten(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public map flatten_map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).flatten_map();
}

 public void foreach_basic_set(Action<basic_set> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
new set(get()).foreach_basic_set(fn);
}

 public void foreach_bound_pair(dim_type type, uint pos, Action<constraint, constraint, basic_set> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Action<constraint, constraint, basic_set> func,  Exception? eptr) fn_data = (func: fn, eptr: null);
Func<IntPtr, IntPtr, IntPtr, IntPtr, isl_stat> fn_lambda = (IntPtr arg_0, IntPtr arg_1, IntPtr arg_2, IntPtr arg_3) => {
    try {
      fn_data.func(new (arg_0), new (arg_1), new (arg_2));
      return isl_stat.Ok;
    } catch (Exception e) {
      throw e;
      return isl_stat.Error;
    }
  };
  var res = Interop.isl_basic_set_foreach_bound_pair(get(), type, pos, fn_lambda, IntPtr.Zero);
  if (fn_data.eptr is not null) {
    throw fn_data.eptr;
  }
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return;
}

 public void foreach_constraint(Action<constraint> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Action<constraint> func,  Exception? eptr) fn_data = (func: fn, eptr: null);
Func<IntPtr, IntPtr, isl_stat> fn_lambda = (IntPtr arg_0, IntPtr arg_1) => {
    try {
      fn_data.func(new (arg_0));
      return isl_stat.Ok;
    } catch (Exception e) {
      throw e;
      return isl_stat.Error;
    }
  };
  var res = Interop.isl_basic_set_foreach_constraint(get(), fn_lambda, IntPtr.Zero);
  if (fn_data.eptr is not null) {
    throw fn_data.eptr;
  }
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return;
}

 public void foreach_point(Action<point> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
new set(get()).foreach_point(fn);
}

 public void foreach_set(Action<set> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
new set(get()).foreach_set(fn);
}

 public static basic_set from_constraint(constraint constraint)
{
  if (constraint.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_from_constraint(constraint.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public static basic_set from_constraint_matrices(space space, mat eq, mat ineq, dim_type c1, dim_type c2, dim_type c3, dim_type c4)
{
  if (space.is_null() || eq.is_null() || ineq.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_from_constraint_matrices(space.copy(), eq.copy(), ineq.copy(), c1, c2, c3, c4);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public static basic_set from_multi_aff(multi_aff ma)
{
  if (ma.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_from_multi_aff(ma.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public basic_set gist(basic_set context)
{
  if (get() == IntPtr.Zero || context.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_gist(copy(), context.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public set gist(set context)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).gist(context);
}

 public union_set gist(union_set context)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).gist(context);
}

 public basic_set gist(point context)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.gist(new basic_set(context));
}

 public set gist_basic_set(basic_set context)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).gist_basic_set(context);
}

 public set gist_params(set context)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).gist_params(context);
}

 public bool has_dim_id(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).has_dim_id(type, pos);
}

 public bool has_dim_name(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).has_dim_name(type, pos);
}

 public bool has_equal_space(set set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).has_equal_space(set2);
}

 public bool has_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).has_tuple_id();
}

 public bool has_tuple_name()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).has_tuple_name();
}

 public map identity()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).identity();
}

 public pw_aff indicator_function()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).indicator_function();
}

 public mat inequalities_matrix(dim_type c1, dim_type c2, dim_type c3, dim_type c4)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_inequalities_matrix(get(), c1, c2, c3, c4);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new mat(res);
}

 public basic_set insert_dims(dim_type type, uint pos, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_insert_dims(copy(), type, pos, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public map insert_domain(space domain)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).insert_domain(domain);
}

 public basic_set intersect(basic_set bset2)
{
  if (get() == IntPtr.Zero || bset2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_intersect(copy(), bset2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public set intersect(set set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).intersect(set2);
}

 public union_set intersect(union_set uset2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).intersect(uset2);
}

 public basic_set intersect(point bset2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.intersect(new basic_set(bset2));
}

 public basic_set intersect_params(basic_set bset2)
{
  if (get() == IntPtr.Zero || bset2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_intersect_params(copy(), bset2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public set intersect_params(set params_)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).intersect_params(params_);
}

 public basic_set intersect_params(point bset2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.intersect_params(new basic_set(bset2));
}

 public bool involves_dims(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_involves_dims(get(), type, first, n);
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool involves_locals()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).involves_locals();
}

 public bool is_bounded()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).is_bounded();
}

 public bool is_box()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).is_box();
}

 public bool is_disjoint(set set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).is_disjoint(set2);
}

 public bool is_disjoint(union_set uset2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).is_disjoint(uset2);
}

 public bool is_empty()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_is_empty(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_equal(basic_set bset2)
{
  if (get() == IntPtr.Zero || bset2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_is_equal(get(), bset2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_equal(set set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).is_equal(set2);
}

 public bool is_equal(union_set uset2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).is_equal(uset2);
}

 public bool is_equal(point bset2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.is_equal(new basic_set(bset2));
}

 public bool is_params()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).is_params();
}

 public int is_rational()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_is_rational(get());
  return res;
}

 public bool is_singleton()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).is_singleton();
}

 public bool is_strict_subset(set set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).is_strict_subset(set2);
}

 public bool is_strict_subset(union_set uset2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).is_strict_subset(uset2);
}

 public bool is_subset(basic_set bset2)
{
  if (get() == IntPtr.Zero || bset2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_is_subset(get(), bset2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_subset(set set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).is_subset(set2);
}

 public bool is_subset(union_set uset2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).is_subset(uset2);
}

 public bool is_subset(point bset2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.is_subset(new basic_set(bset2));
}

 public bool is_wrapping()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_is_wrapping(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool isa_set()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).isa_set();
}

 public fixed_box lattice_tile()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).lattice_tile();
}

 public map lex_ge_set(set set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).lex_ge_set(set2);
}

 public map lex_gt_set(set set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).lex_gt_set(set2);
}

 public map lex_le_set(set set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).lex_le_set(set2);
}

 public map lex_lt_set(set set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).lex_lt_set(set2);
}

 public set lexmax()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_lexmax(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public pw_multi_aff lexmax_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).lexmax_pw_multi_aff();
}

 public set lexmin()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_lexmin(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public pw_multi_aff lexmin_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).lexmin_pw_multi_aff();
}

 public basic_set lift()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_lift(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public local_space local_space()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_get_local_space(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new local_space(res);
}

 public set lower_bound(multi_pw_aff lower)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).lower_bound(lower);
}

 public set lower_bound(multi_val lower)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).lower_bound(lower);
}

 public set lower_bound_si(dim_type type, uint pos, int value)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).lower_bound_si(type, pos, value);
}

 public basic_set lower_bound_val(dim_type type, uint pos, val value)
{
  if (get() == IntPtr.Zero || value.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_lower_bound_val(copy(), type, pos, value.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public basic_set lower_bound_val(dim_type type, uint pos, long value)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.lower_bound_val(type, pos, new val(ctx.Instance, value));
}

 public set make_disjoint()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).make_disjoint();
}

 public multi_pw_aff max_multi_pw_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).max_multi_pw_aff();
}

 public val max_val(aff obj)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).max_val(obj);
}

 public multi_pw_aff min_multi_pw_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).min_multi_pw_aff();
}

 public val min_val(aff obj)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).min_val(obj);
}

 public basic_set move_dims(dim_type dst_type, uint dst_pos, dim_type src_type, uint src_pos, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_move_dims(copy(), dst_type, dst_pos, src_type, src_pos, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public int n_basic_set()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).n_basic_set();
}

 public int n_constraint()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_n_constraint(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

 public int n_dim()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_n_dim(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

 public int n_param()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_n_param(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

 public static basic_set nat_universe(space space)
{
  if (space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_nat_universe(space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public basic_set neg()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_neg(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public pw_aff param_pw_aff_on_domain(id id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).param_pw_aff_on_domain(id);
}

 public pw_aff param_pw_aff_on_domain(string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.param_pw_aff_on_domain(new id(ctx.Instance, id));
}

 public basic_set paramss()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_params(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public val plain_get_val_if_fixed(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).plain_get_val_if_fixed(type, pos);
}

 public bool plain_is_disjoint(set set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).plain_is_disjoint(set2);
}

 public bool plain_is_empty()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).plain_is_empty();
}

 public bool plain_is_universe()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).plain_is_universe();
}

 public multi_val plain_multi_val_if_fixed()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).plain_multi_val_if_fixed();
}

 public basic_set polyhedral_hull()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).polyhedral_hull();
}

 public static basic_set positive_orthant(space space)
{
  if (space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_positive_orthant(space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public set preimage(multi_aff ma)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).preimage(ma);
}

 public set preimage(multi_pw_aff mpa)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).preimage(mpa);
}

 public set preimage(pw_multi_aff pma)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).preimage(pma);
}

 public union_set preimage(union_pw_multi_aff upma)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).preimage(upma);
}

 public basic_set preimage_multi_aff(multi_aff ma)
{
  if (get() == IntPtr.Zero || ma.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_preimage_multi_aff(copy(), ma.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public set product(set set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).product(set2);
}

 public map project_onto_map(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).project_onto_map(type, first, n);
}

 public basic_set project_out(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_project_out(copy(), type, first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public set project_out_all_params()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).project_out_all_params();
}

 public set project_out_param(id id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).project_out_param(id);
}

 public set project_out_param(string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.project_out_param(new id(ctx.Instance, id));
}

 public set project_out_param(id_list list)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).project_out_param(list);
}

 public pw_aff pw_aff_on_domain(val v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).pw_aff_on_domain(v);
}

 public pw_aff pw_aff_on_domain(long v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.pw_aff_on_domain(new val(ctx.Instance, v));
}

 public pw_multi_aff pw_multi_aff_on_domain(multi_val mv)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).pw_multi_aff_on_domain(mv);
}

 public mat reduced_basis()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_reduced_basis(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new mat(res);
}

 public basic_set remove_dims(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_remove_dims(copy(), type, first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public basic_set remove_divs()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_remove_divs(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public basic_set remove_divs_involving_dims(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_remove_divs_involving_dims(copy(), type, first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public basic_set remove_redundancies()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_remove_redundancies(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public basic_set remove_unknown_divs()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_remove_unknown_divs(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public set reset_space(space space)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).reset_space(space);
}

 public set reset_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).reset_tuple_id();
}

 public set reset_user()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).reset_user();
}

 public basic_set sample()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_sample(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public point sample_point()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_sample_point(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new point(res);
}

 public set set_dim_id(dim_type type, uint pos, id id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).set_dim_id(type, pos, id);
}

 public set set_dim_id(dim_type type, uint pos, string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.set_dim_id(type, pos, new id(ctx.Instance, id));
}

 public basic_set set_dim_name(dim_type type, uint pos, string s)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_set_dim_name(copy(), type, pos, s);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public set_list set_list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).set_list();
}

 public basic_set set_tuple_id(id id)
{
  if (get() == IntPtr.Zero || id.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_set_tuple_id(copy(), id.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public basic_set set_tuple_id(string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.set_tuple_id(new id(ctx.Instance, id));
}

 public basic_set set_tuple_name(string s)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_set_tuple_name(copy(), s);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public fixed_box simple_fixed_box_hull()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).simple_fixed_box_hull();
}

 public int size()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).size();
}

 public basic_set solutions()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_solutions(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public space space()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_get_space(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public set split_dims(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).split_dims(type, first, n);
}

 public val stride(int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).stride(pos);
}

 public set subtract(set set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).subtract(set2);
}

 public union_set subtract(union_set uset2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).subtract(uset2);
}

 public set sum(set set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).sum(set2);
}

 public basic_set_list to_list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_to_list(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set_list(res);
}

 public set to_set()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_to_set(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public union_set to_union_set()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).to_union_set();
}

 public static int total_dim(basic_set bset)
{
  if (bset.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_total_dim(bset.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

 public map translation()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).translation();
}

 public int tuple_dim()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).tuple_dim();
}

 public id tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).tuple_id();
}

 public string tuple_name()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_get_tuple_name(get());
  return Marshal.PtrToStringAnsi(res);
}

 public set unbind_params(multi_id tuple)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).unbind_params(tuple);
}

 public map unbind_params_insert_domain(multi_id domain)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).unbind_params_insert_domain(domain);
}

 public set union(basic_set bset2)
{
  if (get() == IntPtr.Zero || bset2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_union(copy(), bset2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set union(set set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).union(set2);
}

 public union_set union(union_set uset2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).union(uset2);
}

 public set union(point bset2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.union(new basic_set(bset2));
}

 public static basic_set universe(space space)
{
  if (space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_universe(space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public basic_set unshifted_simple_hull()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).unshifted_simple_hull();
}

 public basic_map unwrap()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_unwrap(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public set upper_bound(multi_pw_aff upper)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).upper_bound(upper);
}

 public set upper_bound(multi_val upper)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).upper_bound(upper);
}

 public set upper_bound_si(dim_type type, uint pos, int value)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).upper_bound_si(type, pos, value);
}

 public basic_set upper_bound_val(dim_type type, uint pos, val value)
{
  if (get() == IntPtr.Zero || value.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_upper_bound_val(copy(), type, pos, value.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public basic_set upper_bound_val(dim_type type, uint pos, long value)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.upper_bound_val(type, pos, new val(ctx.Instance, value));
}

 public map wrapped_domain_map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).wrapped_domain_map();
}

 public set wrapped_reverse()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new set(get()).wrapped_reverse();
}

public override string ToString(){
  var str = Interop.isl_basic_set_to_str(get());
  return str;
}
}

public class basic_set_list : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal basic_set_list(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

 public /* explicit */ basic_set_list(ctx ctx, int n)
{
  var res = Interop.isl_basic_set_list_alloc(ctx.get(), n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ basic_set_list(basic_set el)
{
  if (el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_list_from_basic_set(el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

public void Dispose() {
  if (!is_null()) {
    Interop.isl_basic_set_list_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_basic_set_list_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public basic_set_list add(basic_set el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_list_add(copy(), el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set_list(res);
}

 public basic_set at(int index)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_list_get_at(get(), index);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public basic_set_list clear()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_list_clear(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set_list(res);
}

 public basic_set_list coefficients()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_list_coefficients(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set_list(res);
}

 public basic_set_list concat(basic_set_list list2)
{
  if (get() == IntPtr.Zero || list2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_list_concat(copy(), list2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set_list(res);
}

 public basic_set_list drop(uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_list_drop(copy(), first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set_list(res);
}

 public void Foreach(Action<basic_set> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Action<basic_set> func,  Exception? eptr) fn_data = (func: fn, eptr: null);
Func<IntPtr, IntPtr, isl_stat> fn_lambda = (IntPtr arg_0, IntPtr arg_1) => {
    try {
      fn_data.func(new (arg_0));
      return isl_stat.Ok;
    } catch (Exception e) {
      throw e;
      return isl_stat.Error;
    }
  };
  var res = Interop.isl_basic_set_list_foreach(get(), fn_lambda, IntPtr.Zero);
  if (fn_data.eptr is not null) {
    throw fn_data.eptr;
  }
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return;
}

 public void foreach_scc(Func<basic_set, basic_set, bool> follows, Action<basic_set_list> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Func<basic_set, basic_set, bool> func,  Exception? eptr) follows_data = (func: follows, eptr: null);
Func<IntPtr, IntPtr, IntPtr, isl_bool> follows_lambda = (IntPtr arg_0, IntPtr arg_1, IntPtr arg_2) => {
    try {
      var ret = follows_data.func(new (arg_0), new (arg_1));
      return ret ? isl_bool.True : isl_bool.False;
    } catch (Exception e) {
      throw e;
      return isl_bool.Error;
    }
  };
 (Action<basic_set_list> func,  Exception? eptr) fn_data = (func: fn, eptr: null);
Func<IntPtr, IntPtr, isl_stat> fn_lambda = (IntPtr arg_0, IntPtr arg_1) => {
    try {
      fn_data.func(new (arg_0));
      return isl_stat.Ok;
    } catch (Exception e) {
      throw e;
      return isl_stat.Error;
    }
  };
  var res = Interop.isl_basic_set_list_foreach_scc(get(), follows_lambda, IntPtr.Zero, fn_lambda, IntPtr.Zero);
  if (follows_data.eptr is not null) {
    throw follows_data.eptr;
  }
  if (fn_data.eptr is not null) {
    throw fn_data.eptr;
  }
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return;
}

 public basic_set_list insert(uint pos, basic_set el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_list_insert(copy(), pos, el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set_list(res);
}

 public basic_set_list set_at(int index, basic_set el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_list_set_at(copy(), index, el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set_list(res);
}

 public int size()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_basic_set_list_size(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

public override string ToString(){
  var str = Interop.isl_basic_set_list_to_str(get());
  return str;
}
}

public class constraint : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal constraint(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

public void Dispose() {
  if (!is_null()) {
    Interop.isl_constraint_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_constraint_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public aff aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_constraint_get_aff(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new aff(res);
}

 public static constraint alloc_equality(local_space ls)
{
  if (ls.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_constraint_alloc_equality(ls.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new constraint(res);
}

 public static constraint alloc_inequality(local_space ls)
{
  if (ls.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_constraint_alloc_inequality(ls.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new constraint(res);
}

 public aff bound(dim_type type, int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_constraint_get_bound(get(), type, pos);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new aff(res);
}

 public int cmp_last_non_zero(constraint c2)
{
  if (get() == IntPtr.Zero || c2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_constraint_cmp_last_non_zero(get(), c2.get());
  return res;
}

 public val coefficient_val(dim_type type, int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_constraint_get_coefficient_val(get(), type, pos);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public val constant_val()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_constraint_get_constant_val(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public int dim(dim_type type)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_constraint_dim(get(), type);
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

 public string dim_name(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_constraint_get_dim_name(get(), type, pos);
  return Marshal.PtrToStringAnsi(res);
}

 public aff div(int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_constraint_get_div(get(), pos);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new aff(res);
}

 public bool involves_dims(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_constraint_involves_dims(get(), type, first, n);
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_div_constraint()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_constraint_is_div_constraint(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_equality()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_constraint_is_equality(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_lower_bound(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_constraint_is_lower_bound(get(), type, pos);
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_upper_bound(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_constraint_is_upper_bound(get(), type, pos);
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public local_space local_space()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_constraint_get_local_space(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new local_space(res);
}

 public constraint negate()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_constraint_negate(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new constraint(res);
}

 public constraint set_coefficient_si(dim_type type, int pos, int v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_constraint_set_coefficient_si(copy(), type, pos, v);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new constraint(res);
}

 public constraint set_coefficient_val(dim_type type, int pos, val v)
{
  if (get() == IntPtr.Zero || v.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_constraint_set_coefficient_val(copy(), type, pos, v.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new constraint(res);
}

 public constraint set_coefficient_val(dim_type type, int pos, long v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.set_coefficient_val(type, pos, new val(ctx.Instance, v));
}

 public constraint set_constant_si(int v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_constraint_set_constant_si(copy(), v);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new constraint(res);
}

 public constraint set_constant_val(val v)
{
  if (get() == IntPtr.Zero || v.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_constraint_set_constant_val(copy(), v.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new constraint(res);
}

 public constraint set_constant_val(long v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.set_constant_val(new val(ctx.Instance, v));
}

 public space space()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_constraint_get_space(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public constraint_list to_list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_constraint_to_list(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new constraint_list(res);
}

public override string ToString(){
  var str = Interop.isl_constraint_to_str(get());
  return str;
}
}

public class constraint_list : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal constraint_list(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

 public /* explicit */ constraint_list(ctx ctx, int n)
{
  var res = Interop.isl_constraint_list_alloc(ctx.get(), n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ constraint_list(constraint el)
{
  if (el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_constraint_list_from_constraint(el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

public void Dispose() {
  if (!is_null()) {
    Interop.isl_constraint_list_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_constraint_list_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public constraint_list add(constraint el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_constraint_list_add(copy(), el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new constraint_list(res);
}

 public constraint at(int index)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_constraint_list_get_at(get(), index);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new constraint(res);
}

 public constraint_list clear()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_constraint_list_clear(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new constraint_list(res);
}

 public constraint_list concat(constraint_list list2)
{
  if (get() == IntPtr.Zero || list2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_constraint_list_concat(copy(), list2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new constraint_list(res);
}

 public constraint_list drop(uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_constraint_list_drop(copy(), first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new constraint_list(res);
}

 public void Foreach(Action<constraint> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Action<constraint> func,  Exception? eptr) fn_data = (func: fn, eptr: null);
Func<IntPtr, IntPtr, isl_stat> fn_lambda = (IntPtr arg_0, IntPtr arg_1) => {
    try {
      fn_data.func(new (arg_0));
      return isl_stat.Ok;
    } catch (Exception e) {
      throw e;
      return isl_stat.Error;
    }
  };
  var res = Interop.isl_constraint_list_foreach(get(), fn_lambda, IntPtr.Zero);
  if (fn_data.eptr is not null) {
    throw fn_data.eptr;
  }
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return;
}

 public void foreach_scc(Func<constraint, constraint, bool> follows, Action<constraint_list> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Func<constraint, constraint, bool> func,  Exception? eptr) follows_data = (func: follows, eptr: null);
Func<IntPtr, IntPtr, IntPtr, isl_bool> follows_lambda = (IntPtr arg_0, IntPtr arg_1, IntPtr arg_2) => {
    try {
      var ret = follows_data.func(new (arg_0), new (arg_1));
      return ret ? isl_bool.True : isl_bool.False;
    } catch (Exception e) {
      throw e;
      return isl_bool.Error;
    }
  };
 (Action<constraint_list> func,  Exception? eptr) fn_data = (func: fn, eptr: null);
Func<IntPtr, IntPtr, isl_stat> fn_lambda = (IntPtr arg_0, IntPtr arg_1) => {
    try {
      fn_data.func(new (arg_0));
      return isl_stat.Ok;
    } catch (Exception e) {
      throw e;
      return isl_stat.Error;
    }
  };
  var res = Interop.isl_constraint_list_foreach_scc(get(), follows_lambda, IntPtr.Zero, fn_lambda, IntPtr.Zero);
  if (follows_data.eptr is not null) {
    throw follows_data.eptr;
  }
  if (fn_data.eptr is not null) {
    throw fn_data.eptr;
  }
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return;
}

 public constraint_list insert(uint pos, constraint el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_constraint_list_insert(copy(), pos, el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new constraint_list(res);
}

 public constraint_list set_at(int index, constraint el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_constraint_list_set_at(copy(), index, el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new constraint_list(res);
}

 public int size()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_constraint_list_size(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

public override string ToString(){
  var str = Interop.isl_constraint_list_to_str(get());
  return str;
}
}

public class fixed_box : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal fixed_box(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

 public /* explicit */ fixed_box(ctx ctx, string str)
{
  var res = Interop.isl_fixed_box_read_from_str(ctx.get(), str);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

public void Dispose() {
  if (!is_null()) {
    Interop.isl_fixed_box_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_fixed_box_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public bool is_valid()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_fixed_box_is_valid(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public multi_aff offset()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_fixed_box_get_offset(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_aff(res);
}

 public multi_val size()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_fixed_box_get_size(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_val(res);
}

 public space space()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_fixed_box_get_space(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

public override string ToString(){
  var str = Interop.isl_fixed_box_to_str(get());
  return str;
}
}

public class id : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal id(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

 public /* explicit */ id(ctx ctx, string str)
{
  var res = Interop.isl_id_read_from_str(ctx.get(), str);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

public void Dispose() {
  if (!is_null()) {
    Interop.isl_id_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_id_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public string name()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_id_get_name(get());
  return Marshal.PtrToStringAnsi(res);
}

 public id_list to_list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_id_to_list(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new id_list(res);
}


public override string ToString(){
  var str = Interop.isl_id_to_str(get());
  return str;
}
}

public class id_list : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal id_list(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

 public /* explicit */ id_list(ctx ctx, int n)
{
  var res = Interop.isl_id_list_alloc(ctx.get(), n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ id_list(id el)
{
  if (el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_id_list_from_id(el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ id_list(ctx ctx, string str)
{
  var res = Interop.isl_id_list_read_from_str(ctx.get(), str);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

public void Dispose() {
  if (!is_null()) {
    Interop.isl_id_list_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_id_list_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public id_list add(id el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_id_list_add(copy(), el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new id_list(res);
}

 public id_list add(string el)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.add(new id(ctx.Instance, el));
}

 public id at(int index)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_id_list_get_at(get(), index);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new id(res);
}

 public id_list clear()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_id_list_clear(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new id_list(res);
}

 public id_list concat(id_list list2)
{
  if (get() == IntPtr.Zero || list2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_id_list_concat(copy(), list2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new id_list(res);
}

 public id_list drop(uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_id_list_drop(copy(), first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new id_list(res);
}

 public void Foreach(Action<id> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Action<id> func,  Exception? eptr) fn_data = (func: fn, eptr: null);
Func<IntPtr, IntPtr, isl_stat> fn_lambda = (IntPtr arg_0, IntPtr arg_1) => {
    try {
      fn_data.func(new (arg_0));
      return isl_stat.Ok;
    } catch (Exception e) {
      throw e;
      return isl_stat.Error;
    }
  };
  var res = Interop.isl_id_list_foreach(get(), fn_lambda, IntPtr.Zero);
  if (fn_data.eptr is not null) {
    throw fn_data.eptr;
  }
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return;
}

 public void foreach_scc(Func<id, id, bool> follows, Action<id_list> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Func<id, id, bool> func,  Exception? eptr) follows_data = (func: follows, eptr: null);
Func<IntPtr, IntPtr, IntPtr, isl_bool> follows_lambda = (IntPtr arg_0, IntPtr arg_1, IntPtr arg_2) => {
    try {
      var ret = follows_data.func(new (arg_0), new (arg_1));
      return ret ? isl_bool.True : isl_bool.False;
    } catch (Exception e) {
      throw e;
      return isl_bool.Error;
    }
  };
 (Action<id_list> func,  Exception? eptr) fn_data = (func: fn, eptr: null);
Func<IntPtr, IntPtr, isl_stat> fn_lambda = (IntPtr arg_0, IntPtr arg_1) => {
    try {
      fn_data.func(new (arg_0));
      return isl_stat.Ok;
    } catch (Exception e) {
      throw e;
      return isl_stat.Error;
    }
  };
  var res = Interop.isl_id_list_foreach_scc(get(), follows_lambda, IntPtr.Zero, fn_lambda, IntPtr.Zero);
  if (follows_data.eptr is not null) {
    throw follows_data.eptr;
  }
  if (fn_data.eptr is not null) {
    throw fn_data.eptr;
  }
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return;
}

 public id_list insert(uint pos, id el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_id_list_insert(copy(), pos, el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new id_list(res);
}

 public id_list insert(uint pos, string el)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.insert(pos, new id(ctx.Instance, el));
}

 public id_list set_at(int index, id el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_id_list_set_at(copy(), index, el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new id_list(res);
}

 public id_list set_at(int index, string el)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.set_at(index, new id(ctx.Instance, el));
}

 public int size()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_id_list_size(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

public override string ToString(){
  var str = Interop.isl_id_list_to_str(get());
  return str;
}
}

public class id_to_ast_expr : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal id_to_ast_expr(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

 public /* explicit */ id_to_ast_expr(ctx ctx, int min_size)
{
  var res = Interop.isl_id_to_ast_expr_alloc(ctx.get(), min_size);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ id_to_ast_expr(ctx ctx, string str)
{
  var res = Interop.isl_id_to_ast_expr_read_from_str(ctx.get(), str);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

public void Dispose() {
  if (!is_null()) {
    Interop.isl_id_to_ast_expr_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_id_to_ast_expr_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public bool is_equal(id_to_ast_expr hmap2)
{
  if (get() == IntPtr.Zero || hmap2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_id_to_ast_expr_is_equal(get(), hmap2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public id_to_ast_expr set(id key, ast_expr val)
{
  if (get() == IntPtr.Zero || key.is_null() || val.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_id_to_ast_expr_set(copy(), key.copy(), val.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new id_to_ast_expr(res);
}

 public id_to_ast_expr set(string key, ast_expr val)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.set(new id(ctx.Instance, key), val);
}

public override string ToString(){
  var str = Interop.isl_id_to_ast_expr_to_str(get());
  return str;
}
}

public class id_to_id : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal id_to_id(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

 public /* explicit */ id_to_id(ctx ctx, int min_size)
{
  var res = Interop.isl_id_to_id_alloc(ctx.get(), min_size);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ id_to_id(ctx ctx, string str)
{
  var res = Interop.isl_id_to_id_read_from_str(ctx.get(), str);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

public void Dispose() {
  if (!is_null()) {
    Interop.isl_id_to_id_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_id_to_id_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public bool is_equal(id_to_id hmap2)
{
  if (get() == IntPtr.Zero || hmap2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_id_to_id_is_equal(get(), hmap2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public id_to_id set(id key, id val)
{
  if (get() == IntPtr.Zero || key.is_null() || val.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_id_to_id_set(copy(), key.copy(), val.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new id_to_id(res);
}

 public id_to_id set(id key, string val)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.set(key, new id(ctx.Instance, val));
}

 public id_to_id set(string key, id val)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.set(new id(ctx.Instance, key), val);
}

 public id_to_id set(string key, string val)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.set(new id(ctx.Instance, key), new id(ctx.Instance, val));
}

public override string ToString(){
  var str = Interop.isl_id_to_id_to_str(get());
  return str;
}
}

public class local_space : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal local_space(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

public void Dispose() {
  if (!is_null()) {
    Interop.isl_local_space_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_local_space_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public local_space add_dims(dim_type type, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_local_space_add_dims(copy(), type, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new local_space(res);
}

 public int dim(dim_type type)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_local_space_dim(get(), type);
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

 public id dim_id(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_local_space_get_dim_id(get(), type, pos);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new id(res);
}

 public string dim_name(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_local_space_get_dim_name(get(), type, pos);
  return Marshal.PtrToStringAnsi(res);
}

 public aff div(int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_local_space_get_div(get(), pos);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new aff(res);
}

 public local_space domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_local_space_domain(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new local_space(res);
}

 public local_space drop_dims(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_local_space_drop_dims(copy(), type, first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new local_space(res);
}

 public int find_dim_by_name(dim_type type, string name)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_local_space_find_dim_by_name(get(), type, name);
  return res;
}

 public local_space flatten_domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_local_space_flatten_domain(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new local_space(res);
}

 public local_space flatten_range()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_local_space_flatten_range(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new local_space(res);
}

 public local_space from_domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_local_space_from_domain(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new local_space(res);
}

 public static local_space from_space(space space)
{
  if (space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_local_space_from_space(space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new local_space(res);
}

 public bool has_dim_id(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_local_space_has_dim_id(get(), type, pos);
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool has_dim_name(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_local_space_has_dim_name(get(), type, pos);
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public local_space insert_dims(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_local_space_insert_dims(copy(), type, first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new local_space(res);
}

 public local_space intersect(local_space ls2)
{
  if (get() == IntPtr.Zero || ls2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_local_space_intersect(copy(), ls2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new local_space(res);
}

 public bool is_params()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_local_space_is_params(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_set()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_local_space_is_set(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public basic_map lifting()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_local_space_lifting(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public local_space range()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_local_space_range(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new local_space(res);
}

 public local_space set_dim_id(dim_type type, uint pos, id id)
{
  if (get() == IntPtr.Zero || id.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_local_space_set_dim_id(copy(), type, pos, id.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new local_space(res);
}

 public local_space set_dim_id(dim_type type, uint pos, string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.set_dim_id(type, pos, new id(ctx.Instance, id));
}

 public local_space set_dim_name(dim_type type, uint pos, string s)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_local_space_set_dim_name(copy(), type, pos, s);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new local_space(res);
}

 public local_space set_from_params()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_local_space_set_from_params(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new local_space(res);
}

 public local_space set_tuple_id(dim_type type, id id)
{
  if (get() == IntPtr.Zero || id.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_local_space_set_tuple_id(copy(), type, id.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new local_space(res);
}

 public local_space set_tuple_id(dim_type type, string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.set_tuple_id(type, new id(ctx.Instance, id));
}

 public space space()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_local_space_get_space(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public local_space wrap()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_local_space_wrap(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new local_space(res);
}

public override string ToString(){
  var str = Interop.isl_local_space_to_str(get());
  return str;
}
}

public class map : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal map(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

 public /* implicit */ map(basic_map bmap)
{
  if (bmap.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_from_basic_map(bmap.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ map(ctx ctx, string str)
{
  var res = Interop.isl_map_read_from_str(ctx.get(), str);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

public void Dispose() {
  if (!is_null()) {
    Interop.isl_map_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_map_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public map add_constraint(constraint constraint)
{
  if (get() == IntPtr.Zero || constraint.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_add_constraint(copy(), constraint.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map add_dims(dim_type type, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_add_dims(copy(), type, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public basic_map affine_hull()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_affine_hull(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public map align_params(space model)
{
  if (get() == IntPtr.Zero || model.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_align_params(copy(), model.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map apply_domain(map map2)
{
  if (get() == IntPtr.Zero || map2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_apply_domain(copy(), map2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public union_map apply_domain(union_map umap2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_map(get()).apply_domain(umap2);
}

 public map apply_domain(basic_map map2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.apply_domain(new map(map2));
}

 public map apply_range(map map2)
{
  if (get() == IntPtr.Zero || map2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_apply_range(copy(), map2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public union_map apply_range(union_map umap2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_map(get()).apply_range(umap2);
}

 public map apply_range(basic_map map2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.apply_range(new map(map2));
}

 public map as_map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_map(get()).as_map();
}

 public multi_union_pw_aff as_multi_union_pw_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_map(get()).as_multi_union_pw_aff();
}

 public pw_multi_aff as_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_as_pw_multi_aff(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public union_pw_multi_aff as_union_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_map(get()).as_union_pw_multi_aff();
}

 public set bind_domain(multi_id tuple)
{
  if (get() == IntPtr.Zero || tuple.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_bind_domain(copy(), tuple.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set bind_range(multi_id tuple)
{
  if (get() == IntPtr.Zero || tuple.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_bind_range(copy(), tuple.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public bool can_curry()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_can_curry(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool can_range_curry()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_can_range_curry(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool can_uncurry()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_can_uncurry(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool can_zip()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_can_zip(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public map coalesce()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_coalesce(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map complement()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_complement(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map compute_divs()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_compute_divs(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public basic_map convex_hull()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_convex_hull(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public map curry()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_curry(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public set deltas()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_deltas(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public map deltas_map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_deltas_map(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map detect_equalities()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_detect_equalities(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public int dim(dim_type type)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_dim(get(), type);
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

 public id dim_id(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_get_dim_id(get(), type, pos);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new id(res);
}

 public pw_aff dim_max(int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_dim_max(copy(), pos);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public pw_aff dim_min(int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_dim_min(copy(), pos);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public string dim_name(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_get_dim_name(get(), type, pos);
  return Marshal.PtrToStringAnsi(res);
}

 public set domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_domain(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public map domain_factor_domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_domain_factor_domain(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map domain_factor_range()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_domain_factor_range(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public bool domain_is_wrapping()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_domain_is_wrapping(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public map domain_map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_domain_map(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public union_pw_multi_aff domain_map_union_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_map(get()).domain_map_union_pw_multi_aff();
}

 public map domain_product(map map2)
{
  if (get() == IntPtr.Zero || map2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_domain_product(copy(), map2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public union_map domain_product(union_map umap2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_map(get()).domain_product(umap2);
}

 public map domain_product(basic_map map2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.domain_product(new map(map2));
}

 public map domain_reverse()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_domain_reverse(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public int domain_tuple_dim()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_domain_tuple_dim(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

 public id domain_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_get_domain_tuple_id(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new id(res);
}

 public map drop_constraints_involving_dims(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_drop_constraints_involving_dims(copy(), type, first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map drop_constraints_not_involving_dims(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_drop_constraints_not_involving_dims(copy(), type, first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map drop_unused_params()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_drop_unused_params(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map eliminate(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_eliminate(copy(), type, first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public static map empty(space space)
{
  if (space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_empty(space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map eq_at(multi_pw_aff mpa)
{
  if (get() == IntPtr.Zero || mpa.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_eq_at_multi_pw_aff(copy(), mpa.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public union_map eq_at(multi_union_pw_aff mupa)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_map(get()).eq_at(mupa);
}

 public map eq_at(aff mpa)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.eq_at(new multi_pw_aff(mpa));
}

 public map eq_at(multi_aff mpa)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.eq_at(new multi_pw_aff(mpa));
}

 public map eq_at(pw_aff mpa)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.eq_at(new multi_pw_aff(mpa));
}

 public map eq_at(pw_multi_aff mpa)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.eq_at(new multi_pw_aff(mpa));
}

 public map equate(dim_type type1, int pos1, dim_type type2, int pos2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_equate(copy(), type1, pos1, type2, pos2);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public bool every_map(Func<map, bool> test)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_map(get()).every_map(test);
}

 public map extract_map(space space)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_map(get()).extract_map(space);
}

 public map factor_domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_factor_domain(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map factor_range()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_factor_range(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public int find_dim_by_id(dim_type type, id id)
{
  if (get() == IntPtr.Zero || id.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_find_dim_by_id(get(), type, id.get());
  return res;
}

 public int find_dim_by_id(dim_type type, string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.find_dim_by_id(type, new id(ctx.Instance, id));
}

 public int find_dim_by_name(dim_type type, string name)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_find_dim_by_name(get(), type, name);
  return res;
}

 public map fix_input_si(uint input, int value)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_fix_input_si(copy(), input, value);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map fix_si(dim_type type, uint pos, int value)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_fix_si(copy(), type, pos, value);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map fix_val(dim_type type, uint pos, val v)
{
  if (get() == IntPtr.Zero || v.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_fix_val(copy(), type, pos, v.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map fix_val(dim_type type, uint pos, long v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.fix_val(type, pos, new val(ctx.Instance, v));
}

 public map fixed_power(val exp)
{
  if (get() == IntPtr.Zero || exp.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_fixed_power_val(copy(), exp.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map fixed_power(long exp)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.fixed_power(new val(ctx.Instance, exp));
}

 public map flat_domain_product(map map2)
{
  if (get() == IntPtr.Zero || map2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_flat_domain_product(copy(), map2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map flat_product(map map2)
{
  if (get() == IntPtr.Zero || map2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_flat_product(copy(), map2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map flat_range_product(map map2)
{
  if (get() == IntPtr.Zero || map2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_flat_range_product(copy(), map2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map flatten()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_flatten(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map flatten_domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_flatten_domain(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map flatten_range()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_flatten_range(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map floordiv_val(val d)
{
  if (get() == IntPtr.Zero || d.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_floordiv_val(copy(), d.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map floordiv_val(long d)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.floordiv_val(new val(ctx.Instance, d));
}

 public void foreach_basic_map(Action<basic_map> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Action<basic_map> func,  Exception? eptr) fn_data = (func: fn, eptr: null);
Func<IntPtr, IntPtr, isl_stat> fn_lambda = (IntPtr arg_0, IntPtr arg_1) => {
    try {
      fn_data.func(new (arg_0));
      return isl_stat.Ok;
    } catch (Exception e) {
      throw e;
      return isl_stat.Error;
    }
  };
  var res = Interop.isl_map_foreach_basic_map(get(), fn_lambda, IntPtr.Zero);
  if (fn_data.eptr is not null) {
    throw fn_data.eptr;
  }
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return;
}

 public void foreach_map(Action<map> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
new union_map(get()).foreach_map(fn);
}

 public static map from_aff(aff aff)
{
  if (aff.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_from_aff(aff.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public static map from_domain(set set)
{
  if (set.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_from_domain(set.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public static map from_domain_and_range(set domain, set range)
{
  if (domain.is_null() || range.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_from_domain_and_range(domain.copy(), range.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public static map from_multi_aff(multi_aff maff)
{
  if (maff.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_from_multi_aff(maff.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public static map from_range(set set)
{
  if (set.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_from_range(set.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map gist(map context)
{
  if (get() == IntPtr.Zero || context.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_gist(copy(), context.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public union_map gist(union_map context)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_map(get()).gist(context);
}

 public map gist(basic_map context)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.gist(new map(context));
}

 public map gist_basic_map(basic_map context)
{
  if (get() == IntPtr.Zero || context.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_gist_basic_map(copy(), context.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map gist_domain(set context)
{
  if (get() == IntPtr.Zero || context.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_gist_domain(copy(), context.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public union_map gist_domain(union_set uset)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_map(get()).gist_domain(uset);
}

 public map gist_domain(basic_set context)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.gist_domain(new set(context));
}

 public map gist_domain(point context)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.gist_domain(new set(context));
}

 public map gist_params(set context)
{
  if (get() == IntPtr.Zero || context.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_gist_params(copy(), context.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public union_map gist_range(union_set uset)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_map(get()).gist_range(uset);
}

 public bool has_dim_id(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_has_dim_id(get(), type, pos);
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool has_dim_name(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_has_dim_name(get(), type, pos);
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool has_domain_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_has_domain_tuple_id(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool has_equal_space(map map2)
{
  if (get() == IntPtr.Zero || map2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_has_equal_space(get(), map2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool has_range_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_has_range_tuple_id(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool has_tuple_name(dim_type type)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_has_tuple_name(get(), type);
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public static map identity(space space)
{
  if (space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_identity(space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map insert_dims(dim_type type, uint pos, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_insert_dims(copy(), type, pos, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map intersect(map map2)
{
  if (get() == IntPtr.Zero || map2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_intersect(copy(), map2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public union_map intersect(union_map umap2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_map(get()).intersect(umap2);
}

 public map intersect(basic_map map2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.intersect(new map(map2));
}

 public map intersect_domain(set set)
{
  if (get() == IntPtr.Zero || set.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_intersect_domain(copy(), set.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public union_map intersect_domain(space space)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_map(get()).intersect_domain(space);
}

 public union_map intersect_domain(union_set uset)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_map(get()).intersect_domain(uset);
}

 public map intersect_domain(basic_set set)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.intersect_domain(new set(set));
}

 public map intersect_domain(point set)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.intersect_domain(new set(set));
}

 public map intersect_domain_factor_domain(map factor)
{
  if (get() == IntPtr.Zero || factor.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_intersect_domain_factor_domain(copy(), factor.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public union_map intersect_domain_factor_domain(union_map factor)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_map(get()).intersect_domain_factor_domain(factor);
}

 public map intersect_domain_factor_domain(basic_map factor)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.intersect_domain_factor_domain(new map(factor));
}

 public map intersect_domain_factor_range(map factor)
{
  if (get() == IntPtr.Zero || factor.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_intersect_domain_factor_range(copy(), factor.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public union_map intersect_domain_factor_range(union_map factor)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_map(get()).intersect_domain_factor_range(factor);
}

 public map intersect_domain_factor_range(basic_map factor)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.intersect_domain_factor_range(new map(factor));
}

 public map intersect_domain_wrapped_domain(set domain)
{
  if (get() == IntPtr.Zero || domain.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_intersect_domain_wrapped_domain(copy(), domain.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public union_map intersect_domain_wrapped_domain(union_set domain)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_map(get()).intersect_domain_wrapped_domain(domain);
}

 public map intersect_domain_wrapped_domain(basic_set domain)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.intersect_domain_wrapped_domain(new set(domain));
}

 public map intersect_domain_wrapped_domain(point domain)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.intersect_domain_wrapped_domain(new set(domain));
}

 public map intersect_params(set params_)
{
  if (get() == IntPtr.Zero || params_.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_intersect_params(copy(), params_.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map intersect_range(set set)
{
  if (get() == IntPtr.Zero || set.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_intersect_range(copy(), set.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public union_map intersect_range(space space)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_map(get()).intersect_range(space);
}

 public union_map intersect_range(union_set uset)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_map(get()).intersect_range(uset);
}

 public map intersect_range(basic_set set)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.intersect_range(new set(set));
}

 public map intersect_range(point set)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.intersect_range(new set(set));
}

 public map intersect_range_factor_domain(map factor)
{
  if (get() == IntPtr.Zero || factor.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_intersect_range_factor_domain(copy(), factor.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public union_map intersect_range_factor_domain(union_map factor)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_map(get()).intersect_range_factor_domain(factor);
}

 public map intersect_range_factor_domain(basic_map factor)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.intersect_range_factor_domain(new map(factor));
}

 public map intersect_range_factor_range(map factor)
{
  if (get() == IntPtr.Zero || factor.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_intersect_range_factor_range(copy(), factor.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public union_map intersect_range_factor_range(union_map factor)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_map(get()).intersect_range_factor_range(factor);
}

 public map intersect_range_factor_range(basic_map factor)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.intersect_range_factor_range(new map(factor));
}

 public map intersect_range_wrapped_domain(set domain)
{
  if (get() == IntPtr.Zero || domain.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_intersect_range_wrapped_domain(copy(), domain.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public union_map intersect_range_wrapped_domain(union_set domain)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_map(get()).intersect_range_wrapped_domain(domain);
}

 public map intersect_range_wrapped_domain(basic_set domain)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.intersect_range_wrapped_domain(new set(domain));
}

 public map intersect_range_wrapped_domain(point domain)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.intersect_range_wrapped_domain(new set(domain));
}

 public bool involves_dims(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_involves_dims(get(), type, first, n);
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_bijective()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_is_bijective(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_disjoint(map map2)
{
  if (get() == IntPtr.Zero || map2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_is_disjoint(get(), map2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_disjoint(union_map umap2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_map(get()).is_disjoint(umap2);
}

 public bool is_disjoint(basic_map map2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.is_disjoint(new map(map2));
}

 public bool is_empty()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_is_empty(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_equal(map map2)
{
  if (get() == IntPtr.Zero || map2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_is_equal(get(), map2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_equal(union_map umap2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_map(get()).is_equal(umap2);
}

 public bool is_equal(basic_map map2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.is_equal(new map(map2));
}

 public bool is_identity()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_is_identity(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_injective()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_is_injective(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_product()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_is_product(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_single_valued()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_is_single_valued(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_strict_subset(map map2)
{
  if (get() == IntPtr.Zero || map2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_is_strict_subset(get(), map2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_strict_subset(union_map umap2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_map(get()).is_strict_subset(umap2);
}

 public bool is_strict_subset(basic_map map2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.is_strict_subset(new map(map2));
}

 public bool is_subset(map map2)
{
  if (get() == IntPtr.Zero || map2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_is_subset(get(), map2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_subset(union_map umap2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_map(get()).is_subset(umap2);
}

 public bool is_subset(basic_map map2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.is_subset(new map(map2));
}

 public int is_translation()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_is_translation(get());
  return res;
}

 public bool isa_map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_map(get()).isa_map();
}

 public static map lex_ge(space set_space)
{
  if (set_space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_lex_ge(set_space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map lex_ge_at(multi_pw_aff mpa)
{
  if (get() == IntPtr.Zero || mpa.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_lex_ge_at_multi_pw_aff(copy(), mpa.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public static map lex_ge_first(space space, uint n)
{
  if (space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_lex_ge_first(space.copy(), n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map lex_ge_map(map map2)
{
  if (get() == IntPtr.Zero || map2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_lex_ge_map(copy(), map2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public static map lex_gt(space set_space)
{
  if (set_space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_lex_gt(set_space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map lex_gt_at(multi_pw_aff mpa)
{
  if (get() == IntPtr.Zero || mpa.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_lex_gt_at_multi_pw_aff(copy(), mpa.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public static map lex_gt_first(space space, uint n)
{
  if (space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_lex_gt_first(space.copy(), n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map lex_gt_map(map map2)
{
  if (get() == IntPtr.Zero || map2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_lex_gt_map(copy(), map2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public static map lex_le(space set_space)
{
  if (set_space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_lex_le(set_space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map lex_le_at(multi_pw_aff mpa)
{
  if (get() == IntPtr.Zero || mpa.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_lex_le_at_multi_pw_aff(copy(), mpa.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public static map lex_le_first(space space, uint n)
{
  if (space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_lex_le_first(space.copy(), n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map lex_le_map(map map2)
{
  if (get() == IntPtr.Zero || map2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_lex_le_map(copy(), map2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public static map lex_lt(space set_space)
{
  if (set_space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_lex_lt(set_space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map lex_lt_at(multi_pw_aff mpa)
{
  if (get() == IntPtr.Zero || mpa.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_lex_lt_at_multi_pw_aff(copy(), mpa.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public static map lex_lt_first(space space, uint n)
{
  if (space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_lex_lt_first(space.copy(), n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map lex_lt_map(map map2)
{
  if (get() == IntPtr.Zero || map2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_lex_lt_map(copy(), map2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map lexmax()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_lexmax(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public pw_multi_aff lexmax_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_lexmax_pw_multi_aff(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public map lexmin()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_lexmin(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public pw_multi_aff lexmin_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_lexmin_pw_multi_aff(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public map lower_bound(multi_pw_aff lower)
{
  if (get() == IntPtr.Zero || lower.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_lower_bound_multi_pw_aff(copy(), lower.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map lower_bound_si(dim_type type, uint pos, int value)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_lower_bound_si(copy(), type, pos, value);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map lower_bound_val(dim_type type, uint pos, val value)
{
  if (get() == IntPtr.Zero || value.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_lower_bound_val(copy(), type, pos, value.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map lower_bound_val(dim_type type, uint pos, long value)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.lower_bound_val(type, pos, new val(ctx.Instance, value));
}

 public map make_disjoint()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_make_disjoint(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map_list map_list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_map(get()).map_list();
}

 public multi_pw_aff max_multi_pw_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_max_multi_pw_aff(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public multi_pw_aff min_multi_pw_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_min_multi_pw_aff(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public map move_dims(dim_type dst_type, uint dst_pos, dim_type src_type, uint src_pos, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_move_dims(copy(), dst_type, dst_pos, src_type, src_pos, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public int n_basic_map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_n_basic_map(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

 public static map nat_universe(space space)
{
  if (space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_nat_universe(space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map neg()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_neg(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map oppose(dim_type type1, int pos1, dim_type type2, int pos2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_oppose(copy(), type1, pos1, type2, pos2);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map order_ge(dim_type type1, int pos1, dim_type type2, int pos2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_order_ge(copy(), type1, pos1, type2, pos2);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map order_gt(dim_type type1, int pos1, dim_type type2, int pos2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_order_gt(copy(), type1, pos1, type2, pos2);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map order_le(dim_type type1, int pos1, dim_type type2, int pos2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_order_le(copy(), type1, pos1, type2, pos2);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map order_lt(dim_type type1, int pos1, dim_type type2, int pos2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_order_lt(copy(), type1, pos1, type2, pos2);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public set paramss()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_params(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public val plain_get_val_if_fixed(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_plain_get_val_if_fixed(get(), type, pos);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public bool plain_is_empty()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_plain_is_empty(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool plain_is_injective()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_plain_is_injective(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool plain_is_single_valued()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_plain_is_single_valued(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool plain_is_universe()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_plain_is_universe(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public basic_map plain_unshifted_simple_hull()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_plain_unshifted_simple_hull(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public basic_map polyhedral_hull()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_polyhedral_hull(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public map preimage_domain(multi_aff ma)
{
  if (get() == IntPtr.Zero || ma.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_preimage_domain_multi_aff(copy(), ma.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map preimage_domain(multi_pw_aff mpa)
{
  if (get() == IntPtr.Zero || mpa.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_preimage_domain_multi_pw_aff(copy(), mpa.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map preimage_domain(pw_multi_aff pma)
{
  if (get() == IntPtr.Zero || pma.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_preimage_domain_pw_multi_aff(copy(), pma.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public union_map preimage_domain(union_pw_multi_aff upma)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_map(get()).preimage_domain(upma);
}

 public map preimage_range(multi_aff ma)
{
  if (get() == IntPtr.Zero || ma.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_preimage_range_multi_aff(copy(), ma.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map preimage_range(pw_multi_aff pma)
{
  if (get() == IntPtr.Zero || pma.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_preimage_range_pw_multi_aff(copy(), pma.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public union_map preimage_range(union_pw_multi_aff upma)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_map(get()).preimage_range(upma);
}

 public map product(map map2)
{
  if (get() == IntPtr.Zero || map2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_product(copy(), map2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public union_map product(union_map umap2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_map(get()).product(umap2);
}

 public map product(basic_map map2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.product(new map(map2));
}

 public map project_out(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_project_out(copy(), type, first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map project_out_all_params()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_project_out_all_params(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map project_out_param(id id)
{
  if (get() == IntPtr.Zero || id.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_project_out_param_id(copy(), id.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map project_out_param(string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.project_out_param(new id(ctx.Instance, id));
}

 public map project_out_param(id_list list)
{
  if (get() == IntPtr.Zero || list.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_project_out_param_id_list(copy(), list.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public set range()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_range(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public map range_curry()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_range_curry(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map range_factor_domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_range_factor_domain(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map range_factor_range()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_range_factor_range(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public bool range_is_wrapping()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_range_is_wrapping(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public fixed_box range_lattice_tile()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_get_range_lattice_tile(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new fixed_box(res);
}

 public map range_map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_range_map(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map range_product(map map2)
{
  if (get() == IntPtr.Zero || map2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_range_product(copy(), map2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public union_map range_product(union_map umap2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_map(get()).range_product(umap2);
}

 public map range_product(basic_map map2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.range_product(new map(map2));
}

 public map range_reverse()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_range_reverse(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public fixed_box range_simple_fixed_box_hull()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_get_range_simple_fixed_box_hull(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new fixed_box(res);
}

 public int range_tuple_dim()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_range_tuple_dim(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

 public id range_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_get_range_tuple_id(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new id(res);
}

 public map remove_dims(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_remove_dims(copy(), type, first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map remove_divs()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_remove_divs(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map remove_divs_involving_dims(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_remove_divs_involving_dims(copy(), type, first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map remove_inputs(uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_remove_inputs(copy(), first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map remove_redundancies()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_remove_redundancies(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map remove_unknown_divs()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_remove_unknown_divs(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map reverse()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_reverse(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public basic_map sample()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_sample(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public map set_dim_id(dim_type type, uint pos, id id)
{
  if (get() == IntPtr.Zero || id.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_set_dim_id(copy(), type, pos, id.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map set_dim_id(dim_type type, uint pos, string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.set_dim_id(type, pos, new id(ctx.Instance, id));
}

 public map set_dim_name(dim_type type, uint pos, string s)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_set_dim_name(copy(), type, pos, s);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map set_domain_tuple(id id)
{
  if (get() == IntPtr.Zero || id.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_set_domain_tuple_id(copy(), id.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map set_domain_tuple(string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.set_domain_tuple(new id(ctx.Instance, id));
}

 public map set_range_tuple(id id)
{
  if (get() == IntPtr.Zero || id.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_set_range_tuple_id(copy(), id.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map set_range_tuple(string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.set_range_tuple(new id(ctx.Instance, id));
}

 public map set_tuple_id(dim_type type, id id)
{
  if (get() == IntPtr.Zero || id.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_set_tuple_id(copy(), type, id.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map set_tuple_id(dim_type type, string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.set_tuple_id(type, new id(ctx.Instance, id));
}

 public map set_tuple_name(dim_type type, string s)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_set_tuple_name(copy(), type, s);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public basic_map simple_hull()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_simple_hull(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public space space()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_get_space(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public map subtract(map map2)
{
  if (get() == IntPtr.Zero || map2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_subtract(copy(), map2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public union_map subtract(union_map umap2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_map(get()).subtract(umap2);
}

 public map subtract(basic_map map2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.subtract(new map(map2));
}

 public map subtract_domain(set dom)
{
  if (get() == IntPtr.Zero || dom.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_subtract_domain(copy(), dom.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public union_map subtract_domain(union_set dom)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_map(get()).subtract_domain(dom);
}

 public map subtract_domain(basic_set dom)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.subtract_domain(new set(dom));
}

 public map subtract_domain(point dom)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.subtract_domain(new set(dom));
}

 public map subtract_range(set dom)
{
  if (get() == IntPtr.Zero || dom.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_subtract_range(copy(), dom.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public union_map subtract_range(union_set dom)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_map(get()).subtract_range(dom);
}

 public map subtract_range(basic_set dom)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.subtract_range(new set(dom));
}

 public map subtract_range(point dom)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.subtract_range(new set(dom));
}

 public map sum(map map2)
{
  if (get() == IntPtr.Zero || map2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_sum(copy(), map2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map_list to_list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_to_list(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map_list(res);
}

 public union_map to_union_map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_to_union_map(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public string tuple_name(dim_type type)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_get_tuple_name(get(), type);
  return Marshal.PtrToStringAnsi(res);
}

 public map uncurry()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_uncurry(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map union(map map2)
{
  if (get() == IntPtr.Zero || map2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_union(copy(), map2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public union_map union(union_map umap2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_map(get()).union(umap2);
}

 public map union(basic_map map2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.union(new map(map2));
}

 public map union_disjoint(map map2)
{
  if (get() == IntPtr.Zero || map2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_union_disjoint(copy(), map2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public static map universe(space space)
{
  if (space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_universe(space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public basic_map unshifted_simple_hull()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_unshifted_simple_hull(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public basic_map unshifted_simple_hull_from_map_list(map_list list)
{
  if (get() == IntPtr.Zero || list.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_unshifted_simple_hull_from_map_list(copy(), list.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_map(res);
}

 public map upper_bound(multi_pw_aff upper)
{
  if (get() == IntPtr.Zero || upper.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_upper_bound_multi_pw_aff(copy(), upper.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map upper_bound_si(dim_type type, uint pos, int value)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_upper_bound_si(copy(), type, pos, value);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map upper_bound_val(dim_type type, uint pos, val value)
{
  if (get() == IntPtr.Zero || value.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_upper_bound_val(copy(), type, pos, value.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map upper_bound_val(dim_type type, uint pos, long value)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.upper_bound_val(type, pos, new val(ctx.Instance, value));
}

 public set wrap()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_wrap(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public map zip()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_zip(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

public override string ToString(){
  var str = Interop.isl_map_to_str(get());
  return str;
}
}

public class map_list : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal map_list(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

 public /* explicit */ map_list(ctx ctx, int n)
{
  var res = Interop.isl_map_list_alloc(ctx.get(), n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ map_list(map el)
{
  if (el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_list_from_map(el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ map_list(ctx ctx, string str)
{
  var res = Interop.isl_map_list_read_from_str(ctx.get(), str);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

public void Dispose() {
  if (!is_null()) {
    Interop.isl_map_list_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_map_list_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public map_list add(map el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_list_add(copy(), el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map_list(res);
}

 public map at(int index)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_list_get_at(get(), index);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map_list clear()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_list_clear(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map_list(res);
}

 public map_list concat(map_list list2)
{
  if (get() == IntPtr.Zero || list2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_list_concat(copy(), list2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map_list(res);
}

 public map_list drop(uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_list_drop(copy(), first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map_list(res);
}

 public void Foreach(Action<map> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Action<map> func,  Exception? eptr) fn_data = (func: fn, eptr: null);
Func<IntPtr, IntPtr, isl_stat> fn_lambda = (IntPtr arg_0, IntPtr arg_1) => {
    try {
      fn_data.func(new (arg_0));
      return isl_stat.Ok;
    } catch (Exception e) {
      throw e;
      return isl_stat.Error;
    }
  };
  var res = Interop.isl_map_list_foreach(get(), fn_lambda, IntPtr.Zero);
  if (fn_data.eptr is not null) {
    throw fn_data.eptr;
  }
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return;
}

 public void foreach_scc(Func<map, map, bool> follows, Action<map_list> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Func<map, map, bool> func,  Exception? eptr) follows_data = (func: follows, eptr: null);
Func<IntPtr, IntPtr, IntPtr, isl_bool> follows_lambda = (IntPtr arg_0, IntPtr arg_1, IntPtr arg_2) => {
    try {
      var ret = follows_data.func(new (arg_0), new (arg_1));
      return ret ? isl_bool.True : isl_bool.False;
    } catch (Exception e) {
      throw e;
      return isl_bool.Error;
    }
  };
 (Action<map_list> func,  Exception? eptr) fn_data = (func: fn, eptr: null);
Func<IntPtr, IntPtr, isl_stat> fn_lambda = (IntPtr arg_0, IntPtr arg_1) => {
    try {
      fn_data.func(new (arg_0));
      return isl_stat.Ok;
    } catch (Exception e) {
      throw e;
      return isl_stat.Error;
    }
  };
  var res = Interop.isl_map_list_foreach_scc(get(), follows_lambda, IntPtr.Zero, fn_lambda, IntPtr.Zero);
  if (follows_data.eptr is not null) {
    throw follows_data.eptr;
  }
  if (fn_data.eptr is not null) {
    throw fn_data.eptr;
  }
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return;
}

 public map_list insert(uint pos, map el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_list_insert(copy(), pos, el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map_list(res);
}

 public map_list set_at(int index, map el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_list_set_at(copy(), index, el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map_list(res);
}

 public int size()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_map_list_size(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

public override string ToString(){
  var str = Interop.isl_map_list_to_str(get());
  return str;
}
}

public class mat : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal mat(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

public void Dispose() {
  if (!is_null()) {
    Interop.isl_mat_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_mat_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public mat add_rows(uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_mat_add_rows(copy(), n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new mat(res);
}

 public mat add_zero_cols(uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_mat_add_zero_cols(copy(), n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new mat(res);
}

 public mat add_zero_rows(uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_mat_add_zero_rows(copy(), n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new mat(res);
}

 public mat aff_direct_sum(mat right)
{
  if (get() == IntPtr.Zero || right.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_mat_aff_direct_sum(copy(), right.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new mat(res);
}

 public int cols()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_mat_cols(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

 public mat concat(mat bot)
{
  if (get() == IntPtr.Zero || bot.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_mat_concat(copy(), bot.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new mat(res);
}

 public mat diagonal(mat mat2)
{
  if (get() == IntPtr.Zero || mat2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_mat_diagonal(copy(), mat2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new mat(res);
}

 public mat drop_cols(uint col, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_mat_drop_cols(copy(), col, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new mat(res);
}

 public mat drop_rows(uint row, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_mat_drop_rows(copy(), row, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new mat(res);
}

 public val element_val(int row, int col)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_mat_get_element_val(get(), row, col);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public bool has_linearly_independent_rows(mat mat2)
{
  if (get() == IntPtr.Zero || mat2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_mat_has_linearly_independent_rows(get(), mat2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public int initial_non_zero_cols()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_mat_initial_non_zero_cols(get());
  return res;
}

 public mat insert_cols(uint col, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_mat_insert_cols(copy(), col, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new mat(res);
}

 public mat insert_rows(uint row, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_mat_insert_rows(copy(), row, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new mat(res);
}

 public mat insert_zero_cols(uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_mat_insert_zero_cols(copy(), first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new mat(res);
}

 public mat insert_zero_rows(uint row, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_mat_insert_zero_rows(copy(), row, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new mat(res);
}

 public mat inverse_product(mat right)
{
  if (get() == IntPtr.Zero || right.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_mat_inverse_product(copy(), right.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new mat(res);
}

 public mat lin_to_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_mat_lin_to_aff(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new mat(res);
}

 public mat move_cols(uint dst_col, uint src_col, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_mat_move_cols(copy(), dst_col, src_col, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new mat(res);
}

 public mat normalize()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_mat_normalize(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new mat(res);
}

 public mat normalize_row(int row)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_mat_normalize_row(copy(), row);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new mat(res);
}

 public mat product(mat right)
{
  if (get() == IntPtr.Zero || right.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_mat_product(copy(), right.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new mat(res);
}

 public int rank()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_mat_rank(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

 public mat right_inverse()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_mat_right_inverse(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new mat(res);
}

 public mat right_kernel()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_mat_right_kernel(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new mat(res);
}

 public mat row_basis()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_mat_row_basis(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new mat(res);
}

 public mat row_basis_extension(mat mat2)
{
  if (get() == IntPtr.Zero || mat2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_mat_row_basis_extension(copy(), mat2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new mat(res);
}

 public int rows()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_mat_rows(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

 public mat set_element_si(int row, int col, int v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_mat_set_element_si(copy(), row, col, v);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new mat(res);
}

 public mat set_element_val(int row, int col, val v)
{
  if (get() == IntPtr.Zero || v.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_mat_set_element_val(copy(), row, col, v.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new mat(res);
}

 public mat set_element_val(int row, int col, long v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.set_element_val(row, col, new val(ctx.Instance, v));
}

 public mat swap_cols(uint i, uint j)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_mat_swap_cols(copy(), i, j);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new mat(res);
}

 public mat swap_rows(uint i, uint j)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_mat_swap_rows(copy(), i, j);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new mat(res);
}

 public mat transpose()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_mat_transpose(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new mat(res);
}

 public mat unimodular_complete(int row)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_mat_unimodular_complete(copy(), row);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new mat(res);
}
}

public class multi_aff : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal multi_aff(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

 public /* implicit */ multi_aff(aff aff)
{
  if (aff.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_from_aff(aff.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ multi_aff(space space, aff_list list)
{
  if (space.is_null() || list.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_from_aff_list(space.copy(), list.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ multi_aff(ctx ctx, string str)
{
  var res = Interop.isl_multi_aff_read_from_str(ctx.get(), str);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

public void Dispose() {
  if (!is_null()) {
    Interop.isl_multi_aff_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_multi_aff_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public multi_aff add(multi_aff multi2)
{
  if (get() == IntPtr.Zero || multi2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_add(copy(), multi2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_aff(res);
}

 public multi_pw_aff add(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).add(multi2);
}

 public multi_union_pw_aff add(multi_union_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).add(multi2);
}

 public pw_multi_aff add(pw_multi_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).add(pma2);
}

 public union_pw_multi_aff add(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).add(upma2);
}

 public multi_aff add(aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.add(new multi_aff(multi2));
}

 public multi_aff add_constant(multi_val mv)
{
  if (get() == IntPtr.Zero || mv.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_add_constant_multi_val(copy(), mv.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_aff(res);
}

 public multi_aff add_constant(val v)
{
  if (get() == IntPtr.Zero || v.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_add_constant_val(copy(), v.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_aff(res);
}

 public multi_aff add_constant(long v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.add_constant(new val(ctx.Instance, v));
}

 public union_pw_multi_aff apply(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).apply(upma2);
}

 public map as_map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_as_map(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public multi_aff as_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).as_multi_aff();
}

 public multi_union_pw_aff as_multi_union_pw_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).as_multi_union_pw_aff();
}

 public pw_multi_aff as_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).as_pw_multi_aff();
}

 public set as_set()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_as_set(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public union_map as_union_map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).as_union_map();
}

 public aff at(int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_get_at(get(), pos);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new aff(res);
}

 public basic_set bind(multi_id tuple)
{
  if (get() == IntPtr.Zero || tuple.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_bind(copy(), tuple.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public multi_aff bind_domain(multi_id tuple)
{
  if (get() == IntPtr.Zero || tuple.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_bind_domain(copy(), tuple.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_aff(res);
}

 public multi_aff bind_domain_wrapped_domain(multi_id tuple)
{
  if (get() == IntPtr.Zero || tuple.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_bind_domain_wrapped_domain(copy(), tuple.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_aff(res);
}

 public pw_multi_aff coalesce()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).coalesce();
}

 public multi_val constant_multi_val()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_get_constant_multi_val(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_val(res);
}

 public set domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).domain();
}

 public static multi_aff domain_map(space space)
{
  if (space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_domain_map(space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_aff(res);
}

 public multi_aff domain_reverse()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_domain_reverse(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_aff(res);
}

 public pw_multi_aff drop_unused_params()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).drop_unused_params();
}

 public pw_multi_aff extract_pw_multi_aff(space space)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).extract_pw_multi_aff(space);
}

 public multi_aff flat_range_product(multi_aff multi2)
{
  if (get() == IntPtr.Zero || multi2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_flat_range_product(copy(), multi2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_aff(res);
}

 public multi_pw_aff flat_range_product(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).flat_range_product(multi2);
}

 public multi_union_pw_aff flat_range_product(multi_union_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).flat_range_product(multi2);
}

 public pw_multi_aff flat_range_product(pw_multi_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).flat_range_product(pma2);
}

 public union_pw_multi_aff flat_range_product(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).flat_range_product(upma2);
}

 public multi_aff flat_range_product(aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.flat_range_product(new multi_aff(multi2));
}

 public multi_aff floor()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_floor(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_aff(res);
}

 public void foreach_piece(Action<set, multi_aff> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
new pw_multi_aff(get()).foreach_piece(fn);
}

 public multi_aff gist(set context)
{
  if (get() == IntPtr.Zero || context.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_gist(copy(), context.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_aff(res);
}

 public union_pw_multi_aff gist(union_set context)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).gist(context);
}

 public multi_aff gist(basic_set context)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.gist(new set(context));
}

 public multi_aff gist(point context)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.gist(new set(context));
}

 public multi_aff gist_params(set context)
{
  if (get() == IntPtr.Zero || context.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_gist_params(copy(), context.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_aff(res);
}

 public bool has_range_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_has_range_tuple_id(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public multi_aff identity()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_identity_multi_aff(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_aff(res);
}

 public static multi_aff identity_on_domain(space space)
{
  if (space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_identity_on_domain_space(space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_aff(res);
}

 public multi_aff insert_domain(space domain)
{
  if (get() == IntPtr.Zero || domain.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_insert_domain(copy(), domain.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_aff(res);
}

 public pw_multi_aff intersect_domain(set set)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).intersect_domain(set);
}

 public union_pw_multi_aff intersect_domain(space space)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).intersect_domain(space);
}

 public union_pw_multi_aff intersect_domain(union_set uset)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).intersect_domain(uset);
}

 public union_pw_multi_aff intersect_domain_wrapped_domain(union_set uset)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).intersect_domain_wrapped_domain(uset);
}

 public union_pw_multi_aff intersect_domain_wrapped_range(union_set uset)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).intersect_domain_wrapped_range(uset);
}

 public pw_multi_aff intersect_params(set set)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).intersect_params(set);
}

 public bool involves_locals()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_involves_locals(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool involves_nan()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_involves_nan(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool involves_param(id id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).involves_param(id);
}

 public bool involves_param(string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.involves_param(new id(ctx.Instance, id));
}

 public bool involves_param(id_list list)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).involves_param(list);
}

 public bool isa_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).isa_multi_aff();
}

 public bool isa_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).isa_pw_multi_aff();
}

 public aff_list list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_get_list(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new aff_list(res);
}

 public multi_pw_aff max(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).max(multi2);
}

 public multi_val max_multi_val()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).max_multi_val();
}

 public multi_pw_aff min(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).min(multi2);
}

 public multi_val min_multi_val()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).min_multi_val();
}

 public static multi_aff multi_val_on_domain(space space, multi_val mv)
{
  if (space.is_null() || mv.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_multi_val_on_domain_space(space.copy(), mv.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_aff(res);
}

 public int n_piece()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).n_piece();
}

 public multi_aff neg()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_neg(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_aff(res);
}

 public bool plain_is_empty()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).plain_is_empty();
}

 public bool plain_is_equal(multi_aff multi2)
{
  if (get() == IntPtr.Zero || multi2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_plain_is_equal(get(), multi2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool plain_is_equal(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).plain_is_equal(multi2);
}

 public bool plain_is_equal(multi_union_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).plain_is_equal(multi2);
}

 public bool plain_is_equal(pw_multi_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).plain_is_equal(pma2);
}

 public bool plain_is_equal(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).plain_is_equal(upma2);
}

 public bool plain_is_equal(aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.plain_is_equal(new multi_aff(multi2));
}

 public pw_multi_aff preimage_domain_wrapped_domain(pw_multi_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).preimage_domain_wrapped_domain(pma2);
}

 public union_pw_multi_aff preimage_domain_wrapped_domain(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).preimage_domain_wrapped_domain(upma2);
}

 public multi_aff product(multi_aff multi2)
{
  if (get() == IntPtr.Zero || multi2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_product(copy(), multi2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_aff(res);
}

 public multi_pw_aff product(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).product(multi2);
}

 public pw_multi_aff product(pw_multi_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).product(pma2);
}

 public multi_aff product(aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.product(new multi_aff(multi2));
}

 public multi_aff pullback(multi_aff ma2)
{
  if (get() == IntPtr.Zero || ma2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_pullback_multi_aff(copy(), ma2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_aff(res);
}

 public multi_pw_aff pullback(multi_pw_aff mpa2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).pullback(mpa2);
}

 public pw_multi_aff pullback(pw_multi_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).pullback(pma2);
}

 public union_pw_multi_aff pullback(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).pullback(upma2);
}

 public multi_aff pullback(aff ma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.pullback(new multi_aff(ma2));
}

 public pw_multi_aff_list pw_multi_aff_list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).pw_multi_aff_list();
}

 public pw_multi_aff range_factor_domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).range_factor_domain();
}

 public pw_multi_aff range_factor_range()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).range_factor_range();
}

 public static multi_aff range_map(space space)
{
  if (space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_range_map(space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_aff(res);
}

 public multi_aff range_product(multi_aff multi2)
{
  if (get() == IntPtr.Zero || multi2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_range_product(copy(), multi2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_aff(res);
}

 public multi_pw_aff range_product(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).range_product(multi2);
}

 public multi_union_pw_aff range_product(multi_union_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).range_product(multi2);
}

 public pw_multi_aff range_product(pw_multi_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).range_product(pma2);
}

 public union_pw_multi_aff range_product(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).range_product(upma2);
}

 public multi_aff range_product(aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.range_product(new multi_aff(multi2));
}

 public id range_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_get_range_tuple_id(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new id(res);
}

 public multi_aff reset_range_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_reset_range_tuple_id(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_aff(res);
}

 public multi_aff scale(multi_val mv)
{
  if (get() == IntPtr.Zero || mv.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_scale_multi_val(copy(), mv.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_aff(res);
}

 public multi_aff scale(val v)
{
  if (get() == IntPtr.Zero || v.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_scale_val(copy(), v.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_aff(res);
}

 public multi_aff scale(long v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.scale(new val(ctx.Instance, v));
}

 public multi_aff scale_down(multi_val mv)
{
  if (get() == IntPtr.Zero || mv.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_scale_down_multi_val(copy(), mv.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_aff(res);
}

 public multi_aff scale_down(val v)
{
  if (get() == IntPtr.Zero || v.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_scale_down_val(copy(), v.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_aff(res);
}

 public multi_aff scale_down(long v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.scale_down(new val(ctx.Instance, v));
}

 public multi_aff set_at(int pos, aff el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_set_at(copy(), pos, el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_aff(res);
}

 public multi_pw_aff set_at(int pos, pw_aff el)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).set_at(pos, el);
}

 public multi_union_pw_aff set_at(int pos, union_pw_aff el)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).set_at(pos, el);
}

 public multi_aff set_range_tuple(id id)
{
  if (get() == IntPtr.Zero || id.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_set_range_tuple_id(copy(), id.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_aff(res);
}

 public multi_aff set_range_tuple(string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.set_range_tuple(new id(ctx.Instance, id));
}

 public int size()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_size(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

 public space space()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_get_space(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public multi_aff sub(multi_aff multi2)
{
  if (get() == IntPtr.Zero || multi2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_sub(copy(), multi2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_aff(res);
}

 public multi_pw_aff sub(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).sub(multi2);
}

 public multi_union_pw_aff sub(multi_union_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).sub(multi2);
}

 public pw_multi_aff sub(pw_multi_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).sub(pma2);
}

 public union_pw_multi_aff sub(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).sub(upma2);
}

 public multi_aff sub(aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.sub(new multi_aff(multi2));
}

 public pw_multi_aff subtract_domain(set set)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).subtract_domain(set);
}

 public union_pw_multi_aff subtract_domain(space space)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).subtract_domain(space);
}

 public union_pw_multi_aff subtract_domain(union_set uset)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).subtract_domain(uset);
}

 public pw_multi_aff_list to_list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).to_list();
}

 public multi_pw_aff to_multi_pw_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_to_multi_pw_aff(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public multi_union_pw_aff to_multi_union_pw_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_to_multi_union_pw_aff(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_union_pw_aff(res);
}

 public pw_multi_aff to_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_to_pw_multi_aff(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public union_pw_multi_aff to_union_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).to_union_pw_multi_aff();
}

 public multi_aff unbind_params_insert_domain(multi_id domain)
{
  if (get() == IntPtr.Zero || domain.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_unbind_params_insert_domain(copy(), domain.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_aff(res);
}

 public multi_pw_aff union_add(multi_pw_aff mpa2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).union_add(mpa2);
}

 public multi_union_pw_aff union_add(multi_union_pw_aff mupa2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).union_add(mupa2);
}

 public pw_multi_aff union_add(pw_multi_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).union_add(pma2);
}

 public union_pw_multi_aff union_add(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).union_add(upma2);
}

 public static multi_aff zero(space space)
{
  if (space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_aff_zero(space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_aff(res);
}

public override string ToString(){
  var str = Interop.isl_multi_aff_to_str(get());
  return str;
}
}

public class multi_id : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal multi_id(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

 public /* explicit */ multi_id(space space, id_list list)
{
  if (space.is_null() || list.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_id_from_id_list(space.copy(), list.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ multi_id(ctx ctx, string str)
{
  var res = Interop.isl_multi_id_read_from_str(ctx.get(), str);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

public void Dispose() {
  if (!is_null()) {
    Interop.isl_multi_id_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_multi_id_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public id at(int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_id_get_at(get(), pos);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new id(res);
}

 public multi_id flat_range_product(multi_id multi2)
{
  if (get() == IntPtr.Zero || multi2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_id_flat_range_product(copy(), multi2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_id(res);
}

 public id_list list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_id_get_list(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new id_list(res);
}

 public bool plain_is_equal(multi_id multi2)
{
  if (get() == IntPtr.Zero || multi2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_id_plain_is_equal(get(), multi2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public multi_id range_product(multi_id multi2)
{
  if (get() == IntPtr.Zero || multi2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_id_range_product(copy(), multi2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_id(res);
}

 public multi_id set_at(int pos, id el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_id_set_at(copy(), pos, el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_id(res);
}

 public multi_id set_at(int pos, string el)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.set_at(pos, new id(ctx.Instance, el));
}

 public int size()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_id_size(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

 public space space()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_id_get_space(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

public override string ToString(){
  var str = Interop.isl_multi_id_to_str(get());
  return str;
}
}

public class multi_pw_aff : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal multi_pw_aff(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

 public /* implicit */ multi_pw_aff(aff aff)
{
  if (aff.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_from_aff(aff.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* implicit */ multi_pw_aff(multi_aff ma)
{
  if (ma.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_from_multi_aff(ma.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* implicit */ multi_pw_aff(pw_aff pa)
{
  if (pa.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_from_pw_aff(pa.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ multi_pw_aff(space space, pw_aff_list list)
{
  if (space.is_null() || list.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_from_pw_aff_list(space.copy(), list.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* implicit */ multi_pw_aff(pw_multi_aff pma)
{
  if (pma.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_from_pw_multi_aff(pma.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ multi_pw_aff(ctx ctx, string str)
{
  var res = Interop.isl_multi_pw_aff_read_from_str(ctx.get(), str);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

public void Dispose() {
  if (!is_null()) {
    Interop.isl_multi_pw_aff_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_multi_pw_aff_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public multi_pw_aff add(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero || multi2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_add(copy(), multi2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public multi_union_pw_aff add(multi_union_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_union_pw_aff(get()).add(multi2);
}

 public multi_pw_aff add(aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.add(new multi_pw_aff(multi2));
}

 public multi_pw_aff add(multi_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.add(new multi_pw_aff(multi2));
}

 public multi_pw_aff add(pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.add(new multi_pw_aff(multi2));
}

 public multi_pw_aff add(pw_multi_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.add(new multi_pw_aff(multi2));
}

 public multi_pw_aff add_constant(multi_val mv)
{
  if (get() == IntPtr.Zero || mv.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_add_constant_multi_val(copy(), mv.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public multi_pw_aff add_constant(val v)
{
  if (get() == IntPtr.Zero || v.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_add_constant_val(copy(), v.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public multi_pw_aff add_constant(long v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.add_constant(new val(ctx.Instance, v));
}

 public map as_map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_as_map(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public multi_aff as_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_as_multi_aff(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_aff(res);
}

 public set as_set()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_as_set(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public pw_aff at(int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_get_at(get(), pos);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public set bind(multi_id tuple)
{
  if (get() == IntPtr.Zero || tuple.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_bind(copy(), tuple.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public multi_pw_aff bind_domain(multi_id tuple)
{
  if (get() == IntPtr.Zero || tuple.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_bind_domain(copy(), tuple.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public multi_pw_aff bind_domain_wrapped_domain(multi_id tuple)
{
  if (get() == IntPtr.Zero || tuple.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_bind_domain_wrapped_domain(copy(), tuple.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public multi_pw_aff coalesce()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_coalesce(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public set domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_domain(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public multi_pw_aff domain_reverse()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_domain_reverse(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public multi_pw_aff flat_range_product(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero || multi2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_flat_range_product(copy(), multi2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public multi_union_pw_aff flat_range_product(multi_union_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_union_pw_aff(get()).flat_range_product(multi2);
}

 public multi_pw_aff flat_range_product(aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.flat_range_product(new multi_pw_aff(multi2));
}

 public multi_pw_aff flat_range_product(multi_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.flat_range_product(new multi_pw_aff(multi2));
}

 public multi_pw_aff flat_range_product(pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.flat_range_product(new multi_pw_aff(multi2));
}

 public multi_pw_aff flat_range_product(pw_multi_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.flat_range_product(new multi_pw_aff(multi2));
}

 public multi_pw_aff gist(set set)
{
  if (get() == IntPtr.Zero || set.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_gist(copy(), set.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public multi_union_pw_aff gist(union_set context)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_union_pw_aff(get()).gist(context);
}

 public multi_pw_aff gist(basic_set set)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.gist(new set(set));
}

 public multi_pw_aff gist(point set)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.gist(new set(set));
}

 public multi_pw_aff gist_params(set set)
{
  if (get() == IntPtr.Zero || set.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_gist_params(copy(), set.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public bool has_range_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_has_range_tuple_id(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public multi_pw_aff identity()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_identity_multi_pw_aff(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public static multi_pw_aff identity_on_domain(space space)
{
  if (space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_identity_on_domain_space(space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public multi_pw_aff insert_domain(space domain)
{
  if (get() == IntPtr.Zero || domain.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_insert_domain(copy(), domain.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public multi_pw_aff intersect_domain(set domain)
{
  if (get() == IntPtr.Zero || domain.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_intersect_domain(copy(), domain.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public multi_union_pw_aff intersect_domain(union_set uset)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_union_pw_aff(get()).intersect_domain(uset);
}

 public multi_pw_aff intersect_domain(basic_set domain)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.intersect_domain(new set(domain));
}

 public multi_pw_aff intersect_domain(point domain)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.intersect_domain(new set(domain));
}

 public multi_pw_aff intersect_params(set set)
{
  if (get() == IntPtr.Zero || set.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_intersect_params(copy(), set.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public bool involves_nan()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_involves_nan(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool involves_param(id id)
{
  if (get() == IntPtr.Zero || id.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_involves_param_id(get(), id.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool involves_param(string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.involves_param(new id(ctx.Instance, id));
}

 public bool involves_param(id_list list)
{
  if (get() == IntPtr.Zero || list.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_involves_param_id_list(get(), list.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool isa_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_isa_multi_aff(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public pw_aff_list list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_get_list(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff_list(res);
}

 public multi_pw_aff max(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero || multi2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_max(copy(), multi2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public multi_val max_multi_val()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_max_multi_val(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_val(res);
}

 public multi_pw_aff min(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero || multi2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_min(copy(), multi2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public multi_val min_multi_val()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_min_multi_val(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_val(res);
}

 public multi_pw_aff neg()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_neg(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public bool plain_is_equal(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero || multi2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_plain_is_equal(get(), multi2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool plain_is_equal(multi_union_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_union_pw_aff(get()).plain_is_equal(multi2);
}

 public bool plain_is_equal(aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.plain_is_equal(new multi_pw_aff(multi2));
}

 public bool plain_is_equal(multi_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.plain_is_equal(new multi_pw_aff(multi2));
}

 public bool plain_is_equal(pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.plain_is_equal(new multi_pw_aff(multi2));
}

 public bool plain_is_equal(pw_multi_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.plain_is_equal(new multi_pw_aff(multi2));
}

 public multi_pw_aff product(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero || multi2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_product(copy(), multi2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public multi_pw_aff pullback(multi_aff ma)
{
  if (get() == IntPtr.Zero || ma.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_pullback_multi_aff(copy(), ma.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public multi_pw_aff pullback(multi_pw_aff mpa2)
{
  if (get() == IntPtr.Zero || mpa2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_pullback_multi_pw_aff(copy(), mpa2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public multi_pw_aff pullback(pw_multi_aff pma)
{
  if (get() == IntPtr.Zero || pma.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_pullback_pw_multi_aff(copy(), pma.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public multi_union_pw_aff pullback(union_pw_multi_aff upma)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_union_pw_aff(get()).pullback(upma);
}

 public multi_pw_aff range_product(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero || multi2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_range_product(copy(), multi2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public multi_union_pw_aff range_product(multi_union_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_union_pw_aff(get()).range_product(multi2);
}

 public multi_pw_aff range_product(aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.range_product(new multi_pw_aff(multi2));
}

 public multi_pw_aff range_product(multi_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.range_product(new multi_pw_aff(multi2));
}

 public multi_pw_aff range_product(pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.range_product(new multi_pw_aff(multi2));
}

 public multi_pw_aff range_product(pw_multi_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.range_product(new multi_pw_aff(multi2));
}

 public id range_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_get_range_tuple_id(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new id(res);
}

 public multi_pw_aff reset_range_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_reset_range_tuple_id(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public multi_pw_aff scale(multi_val mv)
{
  if (get() == IntPtr.Zero || mv.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_scale_multi_val(copy(), mv.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public multi_pw_aff scale(val v)
{
  if (get() == IntPtr.Zero || v.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_scale_val(copy(), v.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public multi_pw_aff scale(long v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.scale(new val(ctx.Instance, v));
}

 public multi_pw_aff scale_down(multi_val mv)
{
  if (get() == IntPtr.Zero || mv.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_scale_down_multi_val(copy(), mv.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public multi_pw_aff scale_down(val v)
{
  if (get() == IntPtr.Zero || v.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_scale_down_val(copy(), v.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public multi_pw_aff scale_down(long v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.scale_down(new val(ctx.Instance, v));
}

 public multi_pw_aff set_at(int pos, pw_aff el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_set_at(copy(), pos, el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public multi_union_pw_aff set_at(int pos, union_pw_aff el)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_union_pw_aff(get()).set_at(pos, el);
}

 public multi_pw_aff set_range_tuple(id id)
{
  if (get() == IntPtr.Zero || id.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_set_range_tuple_id(copy(), id.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public multi_pw_aff set_range_tuple(string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.set_range_tuple(new id(ctx.Instance, id));
}

 public int size()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_size(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

 public space space()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_get_space(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public multi_pw_aff sub(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero || multi2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_sub(copy(), multi2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public multi_union_pw_aff sub(multi_union_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_union_pw_aff(get()).sub(multi2);
}

 public multi_pw_aff sub(aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.sub(new multi_pw_aff(multi2));
}

 public multi_pw_aff sub(multi_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.sub(new multi_pw_aff(multi2));
}

 public multi_pw_aff sub(pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.sub(new multi_pw_aff(multi2));
}

 public multi_pw_aff sub(pw_multi_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.sub(new multi_pw_aff(multi2));
}

 public multi_pw_aff unbind_params_insert_domain(multi_id domain)
{
  if (get() == IntPtr.Zero || domain.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_unbind_params_insert_domain(copy(), domain.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public multi_pw_aff union_add(multi_pw_aff mpa2)
{
  if (get() == IntPtr.Zero || mpa2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_union_add(copy(), mpa2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public multi_union_pw_aff union_add(multi_union_pw_aff mupa2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_union_pw_aff(get()).union_add(mupa2);
}

 public multi_pw_aff union_add(aff mpa2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.union_add(new multi_pw_aff(mpa2));
}

 public multi_pw_aff union_add(multi_aff mpa2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.union_add(new multi_pw_aff(mpa2));
}

 public multi_pw_aff union_add(pw_aff mpa2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.union_add(new multi_pw_aff(mpa2));
}

 public multi_pw_aff union_add(pw_multi_aff mpa2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.union_add(new multi_pw_aff(mpa2));
}

 public static multi_pw_aff zero(space space)
{
  if (space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_pw_aff_zero(space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

public override string ToString(){
  var str = Interop.isl_multi_pw_aff_to_str(get());
  return str;
}
}

public class multi_union_pw_aff : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal multi_union_pw_aff(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

 public /* implicit */ multi_union_pw_aff(multi_pw_aff mpa)
{
  if (mpa.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_union_pw_aff_from_multi_pw_aff(mpa.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* implicit */ multi_union_pw_aff(union_pw_aff upa)
{
  if (upa.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_union_pw_aff_from_union_pw_aff(upa.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ multi_union_pw_aff(space space, union_pw_aff_list list)
{
  if (space.is_null() || list.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_union_pw_aff_from_union_pw_aff_list(space.copy(), list.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ multi_union_pw_aff(ctx ctx, string str)
{
  var res = Interop.isl_multi_union_pw_aff_read_from_str(ctx.get(), str);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

public void Dispose() {
  if (!is_null()) {
    Interop.isl_multi_union_pw_aff_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_multi_union_pw_aff_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public multi_union_pw_aff add(multi_union_pw_aff multi2)
{
  if (get() == IntPtr.Zero || multi2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_union_pw_aff_add(copy(), multi2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_union_pw_aff(res);
}

 public union_pw_aff at(int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_union_pw_aff_get_at(get(), pos);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_aff(res);
}

 public union_set bind(multi_id tuple)
{
  if (get() == IntPtr.Zero || tuple.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_union_pw_aff_bind(copy(), tuple.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set(res);
}

 public multi_union_pw_aff coalesce()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_union_pw_aff_coalesce(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_union_pw_aff(res);
}

 public union_set domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_union_pw_aff_domain(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set(res);
}

 public multi_union_pw_aff flat_range_product(multi_union_pw_aff multi2)
{
  if (get() == IntPtr.Zero || multi2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_union_pw_aff_flat_range_product(copy(), multi2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_union_pw_aff(res);
}

 public multi_union_pw_aff gist(union_set context)
{
  if (get() == IntPtr.Zero || context.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_union_pw_aff_gist(copy(), context.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_union_pw_aff(res);
}

 public multi_union_pw_aff gist_params(set context)
{
  if (get() == IntPtr.Zero || context.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_union_pw_aff_gist_params(copy(), context.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_union_pw_aff(res);
}

 public bool has_range_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_union_pw_aff_has_range_tuple_id(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public multi_union_pw_aff intersect_domain(union_set uset)
{
  if (get() == IntPtr.Zero || uset.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_union_pw_aff_intersect_domain(copy(), uset.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_union_pw_aff(res);
}

 public multi_union_pw_aff intersect_params(set params_)
{
  if (get() == IntPtr.Zero || params_.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_union_pw_aff_intersect_params(copy(), params_.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_union_pw_aff(res);
}

 public bool involves_nan()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_union_pw_aff_involves_nan(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public union_pw_aff_list list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_union_pw_aff_get_list(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_aff_list(res);
}

 public multi_union_pw_aff neg()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_union_pw_aff_neg(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_union_pw_aff(res);
}

 public bool plain_is_equal(multi_union_pw_aff multi2)
{
  if (get() == IntPtr.Zero || multi2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_union_pw_aff_plain_is_equal(get(), multi2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public multi_union_pw_aff pullback(union_pw_multi_aff upma)
{
  if (get() == IntPtr.Zero || upma.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_union_pw_aff_pullback_union_pw_multi_aff(copy(), upma.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_union_pw_aff(res);
}

 public multi_union_pw_aff range_product(multi_union_pw_aff multi2)
{
  if (get() == IntPtr.Zero || multi2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_union_pw_aff_range_product(copy(), multi2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_union_pw_aff(res);
}

 public id range_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_union_pw_aff_get_range_tuple_id(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new id(res);
}

 public multi_union_pw_aff reset_range_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_union_pw_aff_reset_range_tuple_id(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_union_pw_aff(res);
}

 public multi_union_pw_aff scale(multi_val mv)
{
  if (get() == IntPtr.Zero || mv.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_union_pw_aff_scale_multi_val(copy(), mv.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_union_pw_aff(res);
}

 public multi_union_pw_aff scale(val v)
{
  if (get() == IntPtr.Zero || v.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_union_pw_aff_scale_val(copy(), v.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_union_pw_aff(res);
}

 public multi_union_pw_aff scale(long v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.scale(new val(ctx.Instance, v));
}

 public multi_union_pw_aff scale_down(multi_val mv)
{
  if (get() == IntPtr.Zero || mv.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_union_pw_aff_scale_down_multi_val(copy(), mv.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_union_pw_aff(res);
}

 public multi_union_pw_aff scale_down(val v)
{
  if (get() == IntPtr.Zero || v.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_union_pw_aff_scale_down_val(copy(), v.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_union_pw_aff(res);
}

 public multi_union_pw_aff scale_down(long v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.scale_down(new val(ctx.Instance, v));
}

 public multi_union_pw_aff set_at(int pos, union_pw_aff el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_union_pw_aff_set_at(copy(), pos, el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_union_pw_aff(res);
}

 public multi_union_pw_aff set_range_tuple(id id)
{
  if (get() == IntPtr.Zero || id.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_union_pw_aff_set_range_tuple_id(copy(), id.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_union_pw_aff(res);
}

 public multi_union_pw_aff set_range_tuple(string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.set_range_tuple(new id(ctx.Instance, id));
}

 public int size()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_union_pw_aff_size(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

 public space space()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_union_pw_aff_get_space(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public multi_union_pw_aff sub(multi_union_pw_aff multi2)
{
  if (get() == IntPtr.Zero || multi2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_union_pw_aff_sub(copy(), multi2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_union_pw_aff(res);
}

 public multi_union_pw_aff union_add(multi_union_pw_aff mupa2)
{
  if (get() == IntPtr.Zero || mupa2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_union_pw_aff_union_add(copy(), mupa2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_union_pw_aff(res);
}

 public static multi_union_pw_aff zero(space space)
{
  if (space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_union_pw_aff_zero(space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_union_pw_aff(res);
}

public override string ToString(){
  var str = Interop.isl_multi_union_pw_aff_to_str(get());
  return str;
}
}

public class multi_val : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal multi_val(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

 public /* explicit */ multi_val(space space, val_list list)
{
  if (space.is_null() || list.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_val_from_val_list(space.copy(), list.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ multi_val(ctx ctx, string str)
{
  var res = Interop.isl_multi_val_read_from_str(ctx.get(), str);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

public void Dispose() {
  if (!is_null()) {
    Interop.isl_multi_val_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_multi_val_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public multi_val add(multi_val multi2)
{
  if (get() == IntPtr.Zero || multi2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_val_add(copy(), multi2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_val(res);
}

 public multi_val add(val v)
{
  if (get() == IntPtr.Zero || v.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_val_add_val(copy(), v.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_val(res);
}

 public multi_val add(long v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.add(new val(ctx.Instance, v));
}

 public val at(int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_val_get_at(get(), pos);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public multi_val flat_range_product(multi_val multi2)
{
  if (get() == IntPtr.Zero || multi2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_val_flat_range_product(copy(), multi2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_val(res);
}

 public bool has_range_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_val_has_range_tuple_id(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool involves_nan()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_val_involves_nan(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public val_list list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_val_get_list(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val_list(res);
}

 public multi_val max(multi_val multi2)
{
  if (get() == IntPtr.Zero || multi2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_val_max(copy(), multi2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_val(res);
}

 public multi_val min(multi_val multi2)
{
  if (get() == IntPtr.Zero || multi2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_val_min(copy(), multi2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_val(res);
}

 public multi_val neg()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_val_neg(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_val(res);
}

 public bool plain_is_equal(multi_val multi2)
{
  if (get() == IntPtr.Zero || multi2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_val_plain_is_equal(get(), multi2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public multi_val product(multi_val multi2)
{
  if (get() == IntPtr.Zero || multi2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_val_product(copy(), multi2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_val(res);
}

 public multi_val range_product(multi_val multi2)
{
  if (get() == IntPtr.Zero || multi2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_val_range_product(copy(), multi2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_val(res);
}

 public id range_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_val_get_range_tuple_id(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new id(res);
}

 public multi_val reset_range_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_val_reset_range_tuple_id(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_val(res);
}

 public multi_val scale(multi_val mv)
{
  if (get() == IntPtr.Zero || mv.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_val_scale_multi_val(copy(), mv.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_val(res);
}

 public multi_val scale(val v)
{
  if (get() == IntPtr.Zero || v.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_val_scale_val(copy(), v.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_val(res);
}

 public multi_val scale(long v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.scale(new val(ctx.Instance, v));
}

 public multi_val scale_down(multi_val mv)
{
  if (get() == IntPtr.Zero || mv.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_val_scale_down_multi_val(copy(), mv.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_val(res);
}

 public multi_val scale_down(val v)
{
  if (get() == IntPtr.Zero || v.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_val_scale_down_val(copy(), v.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_val(res);
}

 public multi_val scale_down(long v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.scale_down(new val(ctx.Instance, v));
}

 public multi_val set_at(int pos, val el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_val_set_at(copy(), pos, el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_val(res);
}

 public multi_val set_at(int pos, long el)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.set_at(pos, new val(ctx.Instance, el));
}

 public multi_val set_range_tuple(id id)
{
  if (get() == IntPtr.Zero || id.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_val_set_range_tuple_id(copy(), id.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_val(res);
}

 public multi_val set_range_tuple(string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.set_range_tuple(new id(ctx.Instance, id));
}

 public int size()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_val_size(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

 public space space()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_val_get_space(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public multi_val sub(multi_val multi2)
{
  if (get() == IntPtr.Zero || multi2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_val_sub(copy(), multi2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_val(res);
}

 public static multi_val zero(space space)
{
  if (space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_multi_val_zero(space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_val(res);
}

public override string ToString(){
  var str = Interop.isl_multi_val_to_str(get());
  return str;
}
}

public class point : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal point(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

public void Dispose() {
  if (!is_null()) {
    Interop.isl_point_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_point_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public basic_set add_constraint(constraint constraint)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).add_constraint(constraint);
}

 public basic_set add_dims(dim_type type, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).add_dims(type, n);
}

 public point add_ui(dim_type type, int pos, uint val)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_point_add_ui(copy(), type, pos, val);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new point(res);
}

 public basic_set affine_hull()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).affine_hull();
}

 public basic_set align_params(space model)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).align_params(model);
}

 public basic_set apply(basic_map bmap)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).apply(bmap);
}

 public set apply(map map)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).apply(map);
}

 public union_set apply(union_map umap)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).apply(umap);
}

 public pw_multi_aff as_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).as_pw_multi_aff();
}

 public set as_set()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).as_set();
}

 public basic_set_list basic_set_list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).basic_set_list();
}

 public set bind(multi_id tuple)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).bind(tuple);
}

 public set coalesce()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).coalesce();
}

 public basic_set coefficients()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).coefficients();
}

 public set complement()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).complement();
}

 public set compute_divs()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).compute_divs();
}

 public constraint_list constraint_list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).constraint_list();
}

 public val coordinate_val(dim_type type, int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_point_get_coordinate_val(get(), type, pos);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public val count_val()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).count_val();
}

 public basic_set detect_equalities()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).detect_equalities();
}

 public int dim(dim_type type)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).dim(type);
}

 public bool dim_has_any_lower_bound(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).dim_has_any_lower_bound(type, pos);
}

 public bool dim_has_any_upper_bound(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).dim_has_any_upper_bound(type, pos);
}

 public bool dim_has_lower_bound(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).dim_has_lower_bound(type, pos);
}

 public bool dim_has_upper_bound(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).dim_has_upper_bound(type, pos);
}

 public id dim_id(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).dim_id(type, pos);
}

 public bool dim_is_bounded(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).dim_is_bounded(type, pos);
}

 public pw_aff dim_max(int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).dim_max(pos);
}

 public val dim_max_val(int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).dim_max_val(pos);
}

 public pw_aff dim_min(int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).dim_min(pos);
}

 public val dim_min_val(int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).dim_min_val(pos);
}

 public string dim_name(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).dim_name(type, pos);
}

 public aff div(int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).div(pos);
}

 public basic_set drop_constraints_involving_dims(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).drop_constraints_involving_dims(type, first, n);
}

 public basic_set drop_constraints_not_involving_dims(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).drop_constraints_not_involving_dims(type, first, n);
}

 public basic_set drop_unused_params()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).drop_unused_params();
}

 public basic_set eliminate(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).eliminate(type, first, n);
}

 public set eliminate_dims(uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).eliminate_dims(first, n);
}

 public mat equalities_matrix(dim_type c1, dim_type c2, dim_type c3, dim_type c4)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).equalities_matrix(c1, c2, c3, c4);
}

 public bool every_set(Func<set, bool> test)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).every_set(test);
}

 public set extract_set(space space)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).extract_set(space);
}

 public int find_dim_by_id(dim_type type, id id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).find_dim_by_id(type, id);
}

 public int find_dim_by_id(dim_type type, string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.find_dim_by_id(type, new id(ctx.Instance, id));
}

 public int find_dim_by_name(dim_type type, string name)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).find_dim_by_name(type, name);
}

 public set fix_dim_si(uint dim, int value)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).fix_dim_si(dim, value);
}

 public basic_set fix_si(dim_type type, uint pos, int value)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).fix_si(type, pos, value);
}

 public basic_set fix_val(dim_type type, uint pos, val v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).fix_val(type, pos, v);
}

 public basic_set fix_val(dim_type type, uint pos, long v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.fix_val(type, pos, new val(ctx.Instance, v));
}

 public basic_set flatten()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).flatten();
}

 public map flatten_map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).flatten_map();
}

 public void foreach_basic_set(Action<basic_set> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
new basic_set(get()).foreach_basic_set(fn);
}

 public void foreach_bound_pair(dim_type type, uint pos, Action<constraint, constraint, basic_set> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
new basic_set(get()).foreach_bound_pair(type, pos, fn);
}

 public void foreach_constraint(Action<constraint> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
new basic_set(get()).foreach_constraint(fn);
}

 public void foreach_point(Action<point> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
new basic_set(get()).foreach_point(fn);
}

 public void foreach_set(Action<set> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
new basic_set(get()).foreach_set(fn);
}

 public basic_set gist(basic_set context)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).gist(context);
}

 public set gist(set context)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).gist(context);
}

 public union_set gist(union_set context)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).gist(context);
}

 public set gist_basic_set(basic_set context)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).gist_basic_set(context);
}

 public set gist_params(set context)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).gist_params(context);
}

 public bool has_dim_id(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).has_dim_id(type, pos);
}

 public bool has_dim_name(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).has_dim_name(type, pos);
}

 public bool has_equal_space(set set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).has_equal_space(set2);
}

 public bool has_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).has_tuple_id();
}

 public bool has_tuple_name()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).has_tuple_name();
}

 public map identity()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).identity();
}

 public pw_aff indicator_function()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).indicator_function();
}

 public mat inequalities_matrix(dim_type c1, dim_type c2, dim_type c3, dim_type c4)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).inequalities_matrix(c1, c2, c3, c4);
}

 public basic_set insert_dims(dim_type type, uint pos, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).insert_dims(type, pos, n);
}

 public map insert_domain(space domain)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).insert_domain(domain);
}

 public basic_set intersect(basic_set bset2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).intersect(bset2);
}

 public set intersect(set set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).intersect(set2);
}

 public union_set intersect(union_set uset2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).intersect(uset2);
}

 public basic_set intersect_params(basic_set bset2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).intersect_params(bset2);
}

 public set intersect_params(set params_)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).intersect_params(params_);
}

 public bool involves_dims(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).involves_dims(type, first, n);
}

 public bool involves_locals()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).involves_locals();
}

 public bool is_bounded()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).is_bounded();
}

 public bool is_box()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).is_box();
}

 public bool is_disjoint(set set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).is_disjoint(set2);
}

 public bool is_disjoint(union_set uset2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).is_disjoint(uset2);
}

 public bool is_empty()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).is_empty();
}

 public bool is_equal(basic_set bset2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).is_equal(bset2);
}

 public bool is_equal(set set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).is_equal(set2);
}

 public bool is_equal(union_set uset2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).is_equal(uset2);
}

 public bool is_params()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).is_params();
}

 public int is_rational()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).is_rational();
}

 public bool is_singleton()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).is_singleton();
}

 public bool is_strict_subset(set set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).is_strict_subset(set2);
}

 public bool is_strict_subset(union_set uset2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).is_strict_subset(uset2);
}

 public bool is_subset(basic_set bset2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).is_subset(bset2);
}

 public bool is_subset(set set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).is_subset(set2);
}

 public bool is_subset(union_set uset2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).is_subset(uset2);
}

 public bool is_wrapping()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).is_wrapping();
}

 public bool isa_set()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).isa_set();
}

 public fixed_box lattice_tile()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).lattice_tile();
}

 public map lex_ge_set(set set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).lex_ge_set(set2);
}

 public map lex_gt_set(set set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).lex_gt_set(set2);
}

 public map lex_le_set(set set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).lex_le_set(set2);
}

 public map lex_lt_set(set set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).lex_lt_set(set2);
}

 public set lexmax()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).lexmax();
}

 public pw_multi_aff lexmax_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).lexmax_pw_multi_aff();
}

 public set lexmin()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).lexmin();
}

 public pw_multi_aff lexmin_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).lexmin_pw_multi_aff();
}

 public basic_set lift()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).lift();
}

 public local_space local_space()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).local_space();
}

 public set lower_bound(multi_pw_aff lower)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).lower_bound(lower);
}

 public set lower_bound(multi_val lower)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).lower_bound(lower);
}

 public set lower_bound_si(dim_type type, uint pos, int value)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).lower_bound_si(type, pos, value);
}

 public basic_set lower_bound_val(dim_type type, uint pos, val value)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).lower_bound_val(type, pos, value);
}

 public basic_set lower_bound_val(dim_type type, uint pos, long value)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.lower_bound_val(type, pos, new val(ctx.Instance, value));
}

 public set make_disjoint()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).make_disjoint();
}

 public multi_pw_aff max_multi_pw_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).max_multi_pw_aff();
}

 public val max_val(aff obj)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).max_val(obj);
}

 public multi_pw_aff min_multi_pw_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).min_multi_pw_aff();
}

 public val min_val(aff obj)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).min_val(obj);
}

 public basic_set move_dims(dim_type dst_type, uint dst_pos, dim_type src_type, uint src_pos, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).move_dims(dst_type, dst_pos, src_type, src_pos, n);
}

 public multi_val multi_val()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_point_get_multi_val(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_val(res);
}

 public int n_basic_set()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).n_basic_set();
}

 public int n_constraint()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).n_constraint();
}

 public int n_dim()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).n_dim();
}

 public int n_param()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).n_param();
}

 public basic_set neg()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).neg();
}

 public pw_aff param_pw_aff_on_domain(id id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).param_pw_aff_on_domain(id);
}

 public pw_aff param_pw_aff_on_domain(string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.param_pw_aff_on_domain(new id(ctx.Instance, id));
}

 public basic_set paramss()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).paramss();
}

 public val plain_get_val_if_fixed(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).plain_get_val_if_fixed(type, pos);
}

 public bool plain_is_disjoint(set set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).plain_is_disjoint(set2);
}

 public bool plain_is_empty()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).plain_is_empty();
}

 public bool plain_is_universe()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).plain_is_universe();
}

 public multi_val plain_multi_val_if_fixed()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).plain_multi_val_if_fixed();
}

 public basic_set polyhedral_hull()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).polyhedral_hull();
}

 public set preimage(multi_aff ma)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).preimage(ma);
}

 public set preimage(multi_pw_aff mpa)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).preimage(mpa);
}

 public set preimage(pw_multi_aff pma)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).preimage(pma);
}

 public union_set preimage(union_pw_multi_aff upma)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).preimage(upma);
}

 public basic_set preimage_multi_aff(multi_aff ma)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).preimage_multi_aff(ma);
}

 public set product(set set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).product(set2);
}

 public map project_onto_map(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).project_onto_map(type, first, n);
}

 public basic_set project_out(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).project_out(type, first, n);
}

 public set project_out_all_params()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).project_out_all_params();
}

 public set project_out_param(id id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).project_out_param(id);
}

 public set project_out_param(string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.project_out_param(new id(ctx.Instance, id));
}

 public set project_out_param(id_list list)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).project_out_param(list);
}

 public pw_aff pw_aff_on_domain(val v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).pw_aff_on_domain(v);
}

 public pw_aff pw_aff_on_domain(long v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.pw_aff_on_domain(new val(ctx.Instance, v));
}

 public pw_multi_aff pw_multi_aff_on_domain(multi_val mv)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).pw_multi_aff_on_domain(mv);
}

 public mat reduced_basis()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).reduced_basis();
}

 public basic_set remove_dims(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).remove_dims(type, first, n);
}

 public basic_set remove_divs()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).remove_divs();
}

 public basic_set remove_divs_involving_dims(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).remove_divs_involving_dims(type, first, n);
}

 public basic_set remove_redundancies()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).remove_redundancies();
}

 public basic_set remove_unknown_divs()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).remove_unknown_divs();
}

 public set reset_space(space space)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).reset_space(space);
}

 public set reset_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).reset_tuple_id();
}

 public set reset_user()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).reset_user();
}

 public basic_set sample()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).sample();
}

 public point sample_point()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).sample_point();
}

 public point set_coordinate_val(dim_type type, int pos, val v)
{
  if (get() == IntPtr.Zero || v.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_point_set_coordinate_val(copy(), type, pos, v.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new point(res);
}

 public point set_coordinate_val(dim_type type, int pos, long v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.set_coordinate_val(type, pos, new val(ctx.Instance, v));
}

 public set set_dim_id(dim_type type, uint pos, id id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).set_dim_id(type, pos, id);
}

 public set set_dim_id(dim_type type, uint pos, string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.set_dim_id(type, pos, new id(ctx.Instance, id));
}

 public basic_set set_dim_name(dim_type type, uint pos, string s)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).set_dim_name(type, pos, s);
}

 public set_list set_list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).set_list();
}

 public basic_set set_tuple_id(id id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).set_tuple_id(id);
}

 public basic_set set_tuple_id(string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.set_tuple_id(new id(ctx.Instance, id));
}

 public basic_set set_tuple_name(string s)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).set_tuple_name(s);
}

 public fixed_box simple_fixed_box_hull()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).simple_fixed_box_hull();
}

 public int size()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).size();
}

 public basic_set solutions()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).solutions();
}

 public space space()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).space();
}

 public set split_dims(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).split_dims(type, first, n);
}

 public val stride(int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).stride(pos);
}

 public point sub_ui(dim_type type, int pos, uint val)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_point_sub_ui(copy(), type, pos, val);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new point(res);
}

 public set subtract(set set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).subtract(set2);
}

 public union_set subtract(union_set uset2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).subtract(uset2);
}

 public set sum(set set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).sum(set2);
}

 public basic_set_list to_list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).to_list();
}

 public set to_set()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_point_to_set(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public union_set to_union_set()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).to_union_set();
}

 public map translation()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).translation();
}

 public int tuple_dim()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).tuple_dim();
}

 public id tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).tuple_id();
}

 public string tuple_name()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).tuple_name();
}

 public set unbind_params(multi_id tuple)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).unbind_params(tuple);
}

 public map unbind_params_insert_domain(multi_id domain)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).unbind_params_insert_domain(domain);
}

 public set union(basic_set bset2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).union(bset2);
}

 public set union(set set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).union(set2);
}

 public union_set union(union_set uset2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).union(uset2);
}

 public basic_set unshifted_simple_hull()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).unshifted_simple_hull();
}

 public basic_map unwrap()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).unwrap();
}

 public set upper_bound(multi_pw_aff upper)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).upper_bound(upper);
}

 public set upper_bound(multi_val upper)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).upper_bound(upper);
}

 public set upper_bound_si(dim_type type, uint pos, int value)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).upper_bound_si(type, pos, value);
}

 public basic_set upper_bound_val(dim_type type, uint pos, val value)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).upper_bound_val(type, pos, value);
}

 public basic_set upper_bound_val(dim_type type, uint pos, long value)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.upper_bound_val(type, pos, new val(ctx.Instance, value));
}

 public map wrapped_domain_map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).wrapped_domain_map();
}

 public set wrapped_reverse()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new basic_set(get()).wrapped_reverse();
}

public override string ToString(){
  var str = Interop.isl_point_to_str(get());
  return str;
}
}

public class pw_aff : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal pw_aff(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

 public /* implicit */ pw_aff(aff aff)
{
  if (aff.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_from_aff(aff.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ pw_aff(ctx ctx, string str)
{
  var res = Interop.isl_pw_aff_read_from_str(ctx.get(), str);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

public void Dispose() {
  if (!is_null()) {
    Interop.isl_pw_aff_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_pw_aff_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public multi_pw_aff add(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).add(multi2);
}

 public multi_union_pw_aff add(multi_union_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_aff(get()).add(multi2);
}

 public pw_aff add(pw_aff pwaff2)
{
  if (get() == IntPtr.Zero || pwaff2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_add(copy(), pwaff2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public pw_multi_aff add(pw_multi_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).add(pma2);
}

 public union_pw_aff add(union_pw_aff upa2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_aff(get()).add(upa2);
}

 public union_pw_multi_aff add(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_aff(get()).add(upma2);
}

 public pw_aff add(aff pwaff2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.add(new pw_aff(pwaff2));
}

 public pw_aff add_constant(val v)
{
  if (get() == IntPtr.Zero || v.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_add_constant_val(copy(), v.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public pw_aff add_constant(long v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.add_constant(new val(ctx.Instance, v));
}

 public pw_multi_aff add_constant(multi_val mv)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).add_constant(mv);
}

 public union_pw_multi_aff apply(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_aff(get()).apply(upma2);
}

 public aff as_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_as_aff(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new aff(res);
}

 public map as_map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_as_map(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public multi_aff as_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).as_multi_aff();
}

 public multi_union_pw_aff as_multi_union_pw_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_aff(get()).as_multi_union_pw_aff();
}

 public pw_multi_aff as_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_aff(get()).as_pw_multi_aff();
}

 public set as_set()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).as_set();
}

 public union_map as_union_map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_aff(get()).as_union_map();
}

 public pw_aff at(int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).at(pos);
}

 public set bind(multi_id tuple)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_pw_aff(get()).bind(tuple);
}

 public set bind(id id)
{
  if (get() == IntPtr.Zero || id.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_bind_id(copy(), id.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set bind(string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.bind(new id(ctx.Instance, id));
}

 public pw_aff bind_domain(multi_id tuple)
{
  if (get() == IntPtr.Zero || tuple.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_bind_domain(copy(), tuple.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public pw_aff bind_domain_wrapped_domain(multi_id tuple)
{
  if (get() == IntPtr.Zero || tuple.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_bind_domain_wrapped_domain(copy(), tuple.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public pw_aff ceil()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_ceil(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public pw_aff coalesce()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_coalesce(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public pw_aff cond(pw_aff pwaff_true, pw_aff pwaff_false)
{
  if (get() == IntPtr.Zero || pwaff_true.is_null() || pwaff_false.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_cond(copy(), pwaff_true.copy(), pwaff_false.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public pw_aff div(pw_aff pa2)
{
  if (get() == IntPtr.Zero || pa2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_div(copy(), pa2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public set domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_domain(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public pw_aff domain_reverse()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_domain_reverse(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public pw_aff drop_unused_params()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_drop_unused_params(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public set eq_set(pw_aff pwaff2)
{
  if (get() == IntPtr.Zero || pwaff2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_eq_set(copy(), pwaff2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public val eval(point pnt)
{
  if (get() == IntPtr.Zero || pnt.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_eval(copy(), pnt.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public pw_multi_aff extract_pw_multi_aff(space space)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_aff(get()).extract_pw_multi_aff(space);
}

 public multi_pw_aff flat_range_product(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).flat_range_product(multi2);
}

 public multi_union_pw_aff flat_range_product(multi_union_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_aff(get()).flat_range_product(multi2);
}

 public pw_multi_aff flat_range_product(pw_multi_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).flat_range_product(pma2);
}

 public union_pw_multi_aff flat_range_product(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_aff(get()).flat_range_product(upma2);
}

 public pw_aff floor()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_floor(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public void foreach_piece(Action<set, multi_aff> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
new pw_multi_aff(get()).foreach_piece(fn);
}

 public set ge_set(pw_aff pwaff2)
{
  if (get() == IntPtr.Zero || pwaff2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_ge_set(copy(), pwaff2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public pw_aff gist(set context)
{
  if (get() == IntPtr.Zero || context.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_gist(copy(), context.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public union_pw_aff gist(union_set context)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_aff(get()).gist(context);
}

 public pw_aff gist(basic_set context)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.gist(new set(context));
}

 public pw_aff gist(point context)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.gist(new set(context));
}

 public pw_aff gist_params(set context)
{
  if (get() == IntPtr.Zero || context.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_gist_params(copy(), context.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public set gt_set(pw_aff pwaff2)
{
  if (get() == IntPtr.Zero || pwaff2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_gt_set(copy(), pwaff2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public bool has_range_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).has_range_tuple_id();
}

 public multi_pw_aff identity()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).identity();
}

 public pw_aff insert_domain(space domain)
{
  if (get() == IntPtr.Zero || domain.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_insert_domain(copy(), domain.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public pw_aff intersect_domain(set set)
{
  if (get() == IntPtr.Zero || set.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_intersect_domain(copy(), set.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public union_pw_aff intersect_domain(space space)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_aff(get()).intersect_domain(space);
}

 public union_pw_aff intersect_domain(union_set uset)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_aff(get()).intersect_domain(uset);
}

 public pw_aff intersect_domain(basic_set set)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.intersect_domain(new set(set));
}

 public pw_aff intersect_domain(point set)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.intersect_domain(new set(set));
}

 public union_pw_aff intersect_domain_wrapped_domain(union_set uset)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_aff(get()).intersect_domain_wrapped_domain(uset);
}

 public union_pw_aff intersect_domain_wrapped_range(union_set uset)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_aff(get()).intersect_domain_wrapped_range(uset);
}

 public pw_aff intersect_params(set set)
{
  if (get() == IntPtr.Zero || set.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_intersect_params(copy(), set.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public bool involves_locals()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).involves_locals();
}

 public bool involves_nan()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_pw_aff(get()).involves_nan();
}

 public bool involves_param(id id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).involves_param(id);
}

 public bool involves_param(string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.involves_param(new id(ctx.Instance, id));
}

 public bool involves_param(id_list list)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).involves_param(list);
}

 public bool isa_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_isa_aff(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool isa_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).isa_multi_aff();
}

 public bool isa_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_aff(get()).isa_pw_multi_aff();
}

 public set le_set(pw_aff pwaff2)
{
  if (get() == IntPtr.Zero || pwaff2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_le_set(copy(), pwaff2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public pw_aff_list list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_pw_aff(get()).list();
}

 public set lt_set(pw_aff pwaff2)
{
  if (get() == IntPtr.Zero || pwaff2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_lt_set(copy(), pwaff2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public multi_pw_aff max(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).max(multi2);
}

 public pw_aff max(pw_aff pwaff2)
{
  if (get() == IntPtr.Zero || pwaff2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_max(copy(), pwaff2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public pw_aff max(aff pwaff2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.max(new pw_aff(pwaff2));
}

 public multi_val max_multi_val()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).max_multi_val();
}

 public val max_val()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_max_val(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public multi_pw_aff min(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).min(multi2);
}

 public pw_aff min(pw_aff pwaff2)
{
  if (get() == IntPtr.Zero || pwaff2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_min(copy(), pwaff2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public pw_aff min(aff pwaff2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.min(new pw_aff(pwaff2));
}

 public multi_val min_multi_val()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).min_multi_val();
}

 public val min_val()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_min_val(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public pw_aff mod(val mod)
{
  if (get() == IntPtr.Zero || mod.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_mod_val(copy(), mod.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public pw_aff mod(long mod)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.mod(new val(ctx.Instance, mod));
}

 public pw_aff mul(pw_aff pwaff2)
{
  if (get() == IntPtr.Zero || pwaff2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_mul(copy(), pwaff2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public int n_piece()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).n_piece();
}

 public set ne_set(pw_aff pwaff2)
{
  if (get() == IntPtr.Zero || pwaff2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_ne_set(copy(), pwaff2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public pw_aff neg()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_neg(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public static pw_aff param_on_domain(set domain, id id)
{
  if (domain.is_null() || id.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_param_on_domain_id(domain.copy(), id.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public set paramss()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_params(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public bool plain_is_empty()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_aff(get()).plain_is_empty();
}

 public bool plain_is_equal(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).plain_is_equal(multi2);
}

 public bool plain_is_equal(multi_union_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_aff(get()).plain_is_equal(multi2);
}

 public bool plain_is_equal(pw_aff pwaff2)
{
  if (get() == IntPtr.Zero || pwaff2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_plain_is_equal(get(), pwaff2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool plain_is_equal(pw_multi_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).plain_is_equal(pma2);
}

 public bool plain_is_equal(union_pw_aff upa2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_aff(get()).plain_is_equal(upa2);
}

 public bool plain_is_equal(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_aff(get()).plain_is_equal(upma2);
}

 public bool plain_is_equal(aff pwaff2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.plain_is_equal(new pw_aff(pwaff2));
}

 public pw_multi_aff preimage_domain_wrapped_domain(pw_multi_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).preimage_domain_wrapped_domain(pma2);
}

 public union_pw_multi_aff preimage_domain_wrapped_domain(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_aff(get()).preimage_domain_wrapped_domain(upma2);
}

 public multi_pw_aff product(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).product(multi2);
}

 public pw_multi_aff product(pw_multi_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).product(pma2);
}

 public pw_aff pullback(multi_aff ma)
{
  if (get() == IntPtr.Zero || ma.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_pullback_multi_aff(copy(), ma.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public pw_aff pullback(multi_pw_aff mpa)
{
  if (get() == IntPtr.Zero || mpa.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_pullback_multi_pw_aff(copy(), mpa.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public pw_aff pullback(pw_multi_aff pma)
{
  if (get() == IntPtr.Zero || pma.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_pullback_pw_multi_aff(copy(), pma.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public union_pw_aff pullback(union_pw_multi_aff upma)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_aff(get()).pullback(upma);
}

 public pw_multi_aff_list pw_multi_aff_list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_aff(get()).pw_multi_aff_list();
}

 public pw_multi_aff range_factor_domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).range_factor_domain();
}

 public pw_multi_aff range_factor_range()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).range_factor_range();
}

 public multi_pw_aff range_product(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).range_product(multi2);
}

 public multi_union_pw_aff range_product(multi_union_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_aff(get()).range_product(multi2);
}

 public pw_multi_aff range_product(pw_multi_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).range_product(pma2);
}

 public union_pw_multi_aff range_product(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_aff(get()).range_product(upma2);
}

 public id range_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).range_tuple_id();
}

 public multi_pw_aff reset_range_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_pw_aff(get()).reset_range_tuple_id();
}

 public pw_aff scale(val v)
{
  if (get() == IntPtr.Zero || v.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_scale_val(copy(), v.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public pw_aff scale(long v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.scale(new val(ctx.Instance, v));
}

 public pw_multi_aff scale(multi_val mv)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).scale(mv);
}

 public pw_aff scale_down(val f)
{
  if (get() == IntPtr.Zero || f.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_scale_down_val(copy(), f.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public pw_aff scale_down(long f)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.scale_down(new val(ctx.Instance, f));
}

 public pw_multi_aff scale_down(multi_val mv)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).scale_down(mv);
}

 public multi_pw_aff set_at(int pos, pw_aff el)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).set_at(pos, el);
}

 public multi_union_pw_aff set_at(int pos, union_pw_aff el)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_aff(get()).set_at(pos, el);
}

 public pw_multi_aff set_range_tuple(id id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).set_range_tuple(id);
}

 public pw_multi_aff set_range_tuple(string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.set_range_tuple(new id(ctx.Instance, id));
}

 public int size()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_pw_aff(get()).size();
}

 public space space()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_get_space(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public multi_pw_aff sub(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).sub(multi2);
}

 public multi_union_pw_aff sub(multi_union_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_aff(get()).sub(multi2);
}

 public pw_aff sub(pw_aff pwaff2)
{
  if (get() == IntPtr.Zero || pwaff2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_sub(copy(), pwaff2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public pw_multi_aff sub(pw_multi_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).sub(pma2);
}

 public union_pw_aff sub(union_pw_aff upa2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_aff(get()).sub(upa2);
}

 public union_pw_multi_aff sub(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_aff(get()).sub(upma2);
}

 public pw_aff sub(aff pwaff2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.sub(new pw_aff(pwaff2));
}

 public pw_aff subtract_domain(set set)
{
  if (get() == IntPtr.Zero || set.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_subtract_domain(copy(), set.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public union_pw_aff subtract_domain(space space)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_aff(get()).subtract_domain(space);
}

 public union_pw_aff subtract_domain(union_set uset)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_aff(get()).subtract_domain(uset);
}

 public pw_aff subtract_domain(basic_set set)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.subtract_domain(new set(set));
}

 public pw_aff subtract_domain(point set)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.subtract_domain(new set(set));
}

 public pw_aff tdiv_q(pw_aff pa2)
{
  if (get() == IntPtr.Zero || pa2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_tdiv_q(copy(), pa2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public pw_aff tdiv_r(pw_aff pa2)
{
  if (get() == IntPtr.Zero || pa2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_tdiv_r(copy(), pa2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public pw_aff_list to_list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_to_list(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff_list(res);
}

 public multi_pw_aff to_multi_pw_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).to_multi_pw_aff();
}

 public union_pw_aff to_union_pw_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_to_union_pw_aff(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_aff(res);
}

 public union_pw_multi_aff to_union_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).to_union_pw_multi_aff();
}

 public multi_pw_aff unbind_params_insert_domain(multi_id domain)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).unbind_params_insert_domain(domain);
}

 public multi_pw_aff union_add(multi_pw_aff mpa2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).union_add(mpa2);
}

 public multi_union_pw_aff union_add(multi_union_pw_aff mupa2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_aff(get()).union_add(mupa2);
}

 public pw_aff union_add(pw_aff pwaff2)
{
  if (get() == IntPtr.Zero || pwaff2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_union_add(copy(), pwaff2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public pw_multi_aff union_add(pw_multi_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new pw_multi_aff(get()).union_add(pma2);
}

 public union_pw_aff union_add(union_pw_aff upa2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_aff(get()).union_add(upa2);
}

 public union_pw_multi_aff union_add(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_aff(get()).union_add(upma2);
}

 public pw_aff union_add(aff pwaff2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.union_add(new pw_aff(pwaff2));
}

public override string ToString(){
  var str = Interop.isl_pw_aff_to_str(get());
  return str;
}
}

public class pw_aff_list : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal pw_aff_list(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

 public /* explicit */ pw_aff_list(ctx ctx, int n)
{
  var res = Interop.isl_pw_aff_list_alloc(ctx.get(), n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ pw_aff_list(pw_aff el)
{
  if (el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_list_from_pw_aff(el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ pw_aff_list(ctx ctx, string str)
{
  var res = Interop.isl_pw_aff_list_read_from_str(ctx.get(), str);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

public void Dispose() {
  if (!is_null()) {
    Interop.isl_pw_aff_list_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_pw_aff_list_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public pw_aff_list add(pw_aff el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_list_add(copy(), el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff_list(res);
}

 public pw_aff at(int index)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_list_get_at(get(), index);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public pw_aff_list clear()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_list_clear(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff_list(res);
}

 public pw_aff_list concat(pw_aff_list list2)
{
  if (get() == IntPtr.Zero || list2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_list_concat(copy(), list2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff_list(res);
}

 public pw_aff_list drop(uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_list_drop(copy(), first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff_list(res);
}

 public void Foreach(Action<pw_aff> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Action<pw_aff> func,  Exception? eptr) fn_data = (func: fn, eptr: null);
Func<IntPtr, IntPtr, isl_stat> fn_lambda = (IntPtr arg_0, IntPtr arg_1) => {
    try {
      fn_data.func(new (arg_0));
      return isl_stat.Ok;
    } catch (Exception e) {
      throw e;
      return isl_stat.Error;
    }
  };
  var res = Interop.isl_pw_aff_list_foreach(get(), fn_lambda, IntPtr.Zero);
  if (fn_data.eptr is not null) {
    throw fn_data.eptr;
  }
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return;
}

 public void foreach_scc(Func<pw_aff, pw_aff, bool> follows, Action<pw_aff_list> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Func<pw_aff, pw_aff, bool> func,  Exception? eptr) follows_data = (func: follows, eptr: null);
Func<IntPtr, IntPtr, IntPtr, isl_bool> follows_lambda = (IntPtr arg_0, IntPtr arg_1, IntPtr arg_2) => {
    try {
      var ret = follows_data.func(new (arg_0), new (arg_1));
      return ret ? isl_bool.True : isl_bool.False;
    } catch (Exception e) {
      throw e;
      return isl_bool.Error;
    }
  };
 (Action<pw_aff_list> func,  Exception? eptr) fn_data = (func: fn, eptr: null);
Func<IntPtr, IntPtr, isl_stat> fn_lambda = (IntPtr arg_0, IntPtr arg_1) => {
    try {
      fn_data.func(new (arg_0));
      return isl_stat.Ok;
    } catch (Exception e) {
      throw e;
      return isl_stat.Error;
    }
  };
  var res = Interop.isl_pw_aff_list_foreach_scc(get(), follows_lambda, IntPtr.Zero, fn_lambda, IntPtr.Zero);
  if (follows_data.eptr is not null) {
    throw follows_data.eptr;
  }
  if (fn_data.eptr is not null) {
    throw fn_data.eptr;
  }
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return;
}

 public pw_aff_list insert(uint pos, pw_aff el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_list_insert(copy(), pos, el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff_list(res);
}

 public pw_aff_list set_at(int index, pw_aff el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_list_set_at(copy(), index, el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff_list(res);
}

 public int size()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_aff_list_size(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

public override string ToString(){
  var str = Interop.isl_pw_aff_list_to_str(get());
  return str;
}
}

public class pw_multi_aff : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal pw_multi_aff(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

 public /* implicit */ pw_multi_aff(multi_aff ma)
{
  if (ma.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_from_multi_aff(ma.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* implicit */ pw_multi_aff(pw_aff pa)
{
  if (pa.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_from_pw_aff(pa.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ pw_multi_aff(ctx ctx, string str)
{
  var res = Interop.isl_pw_multi_aff_read_from_str(ctx.get(), str);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

public void Dispose() {
  if (!is_null()) {
    Interop.isl_pw_multi_aff_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_pw_multi_aff_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public multi_pw_aff add(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_pw_aff(get()).add(multi2);
}

 public multi_union_pw_aff add(multi_union_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_pw_aff(get()).add(multi2);
}

 public pw_multi_aff add(pw_multi_aff pma2)
{
  if (get() == IntPtr.Zero || pma2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_add(copy(), pma2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public union_pw_multi_aff add(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).add(upma2);
}

 public pw_multi_aff add(multi_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.add(new pw_multi_aff(pma2));
}

 public pw_multi_aff add(pw_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.add(new pw_multi_aff(pma2));
}

 public pw_multi_aff add_constant(multi_val mv)
{
  if (get() == IntPtr.Zero || mv.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_add_constant_multi_val(copy(), mv.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public pw_multi_aff add_constant(val v)
{
  if (get() == IntPtr.Zero || v.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_add_constant_val(copy(), v.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public pw_multi_aff add_constant(long v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.add_constant(new val(ctx.Instance, v));
}

 public union_pw_multi_aff apply(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).apply(upma2);
}

 public map as_map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_as_map(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public multi_aff as_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_as_multi_aff(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_aff(res);
}

 public multi_union_pw_aff as_multi_union_pw_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).as_multi_union_pw_aff();
}

 public pw_multi_aff as_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).as_pw_multi_aff();
}

 public set as_set()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_as_set(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public union_map as_union_map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).as_union_map();
}

 public pw_aff at(int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_get_at(get(), pos);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public set bind(multi_id tuple)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_pw_aff(get()).bind(tuple);
}

 public pw_multi_aff bind_domain(multi_id tuple)
{
  if (get() == IntPtr.Zero || tuple.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_bind_domain(copy(), tuple.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public pw_multi_aff bind_domain_wrapped_domain(multi_id tuple)
{
  if (get() == IntPtr.Zero || tuple.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_bind_domain_wrapped_domain(copy(), tuple.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public pw_multi_aff coalesce()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_coalesce(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public set domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_domain(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public static pw_multi_aff domain_map(space space)
{
  if (space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_domain_map(space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public pw_multi_aff domain_reverse()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_domain_reverse(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public pw_multi_aff drop_unused_params()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_drop_unused_params(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public pw_multi_aff extract_pw_multi_aff(space space)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).extract_pw_multi_aff(space);
}

 public multi_pw_aff flat_range_product(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_pw_aff(get()).flat_range_product(multi2);
}

 public multi_union_pw_aff flat_range_product(multi_union_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_pw_aff(get()).flat_range_product(multi2);
}

 public pw_multi_aff flat_range_product(pw_multi_aff pma2)
{
  if (get() == IntPtr.Zero || pma2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_flat_range_product(copy(), pma2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public union_pw_multi_aff flat_range_product(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).flat_range_product(upma2);
}

 public pw_multi_aff flat_range_product(multi_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.flat_range_product(new pw_multi_aff(pma2));
}

 public pw_multi_aff flat_range_product(pw_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.flat_range_product(new pw_multi_aff(pma2));
}

 public void foreach_piece(Action<set, multi_aff> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Action<set, multi_aff> func,  Exception? eptr) fn_data = (func: fn, eptr: null);
Func<IntPtr, IntPtr, IntPtr, isl_stat> fn_lambda = (IntPtr arg_0, IntPtr arg_1, IntPtr arg_2) => {
    try {
      fn_data.func(new (arg_0), new (arg_1));
      return isl_stat.Ok;
    } catch (Exception e) {
      throw e;
      return isl_stat.Error;
    }
  };
  var res = Interop.isl_pw_multi_aff_foreach_piece(get(), fn_lambda, IntPtr.Zero);
  if (fn_data.eptr is not null) {
    throw fn_data.eptr;
  }
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return;
}

 public pw_multi_aff gist(set set)
{
  if (get() == IntPtr.Zero || set.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_gist(copy(), set.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public union_pw_multi_aff gist(union_set context)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).gist(context);
}

 public pw_multi_aff gist(basic_set set)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.gist(new set(set));
}

 public pw_multi_aff gist(point set)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.gist(new set(set));
}

 public pw_multi_aff gist_params(set set)
{
  if (get() == IntPtr.Zero || set.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_gist_params(copy(), set.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public bool has_range_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_has_range_tuple_id(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public multi_pw_aff identity()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_pw_aff(get()).identity();
}

 public static pw_multi_aff identity_on_domain(space space)
{
  if (space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_identity_on_domain_space(space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public pw_multi_aff insert_domain(space domain)
{
  if (get() == IntPtr.Zero || domain.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_insert_domain(copy(), domain.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public pw_multi_aff intersect_domain(set set)
{
  if (get() == IntPtr.Zero || set.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_intersect_domain(copy(), set.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public union_pw_multi_aff intersect_domain(space space)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).intersect_domain(space);
}

 public union_pw_multi_aff intersect_domain(union_set uset)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).intersect_domain(uset);
}

 public pw_multi_aff intersect_domain(basic_set set)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.intersect_domain(new set(set));
}

 public pw_multi_aff intersect_domain(point set)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.intersect_domain(new set(set));
}

 public union_pw_multi_aff intersect_domain_wrapped_domain(union_set uset)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).intersect_domain_wrapped_domain(uset);
}

 public union_pw_multi_aff intersect_domain_wrapped_range(union_set uset)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).intersect_domain_wrapped_range(uset);
}

 public pw_multi_aff intersect_params(set set)
{
  if (get() == IntPtr.Zero || set.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_intersect_params(copy(), set.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public bool involves_locals()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_involves_locals(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool involves_nan()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_pw_aff(get()).involves_nan();
}

 public bool involves_param(id id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_pw_aff(get()).involves_param(id);
}

 public bool involves_param(string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.involves_param(new id(ctx.Instance, id));
}

 public bool involves_param(id_list list)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_pw_aff(get()).involves_param(list);
}

 public bool isa_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_isa_multi_aff(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool isa_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).isa_pw_multi_aff();
}

 public pw_aff_list list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_pw_aff(get()).list();
}

 public multi_pw_aff max(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_pw_aff(get()).max(multi2);
}

 public multi_val max_multi_val()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_max_multi_val(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_val(res);
}

 public multi_pw_aff min(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_pw_aff(get()).min(multi2);
}

 public multi_val min_multi_val()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_min_multi_val(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_val(res);
}

 public static pw_multi_aff multi_val_on_domain(set domain, multi_val mv)
{
  if (domain.is_null() || mv.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_multi_val_on_domain(domain.copy(), mv.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public int n_piece()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_n_piece(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

 public multi_pw_aff neg()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_pw_aff(get()).neg();
}

 public bool plain_is_empty()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).plain_is_empty();
}

 public bool plain_is_equal(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_pw_aff(get()).plain_is_equal(multi2);
}

 public bool plain_is_equal(multi_union_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_pw_aff(get()).plain_is_equal(multi2);
}

 public bool plain_is_equal(pw_multi_aff pma2)
{
  if (get() == IntPtr.Zero || pma2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_plain_is_equal(get(), pma2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool plain_is_equal(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).plain_is_equal(upma2);
}

 public bool plain_is_equal(multi_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.plain_is_equal(new pw_multi_aff(pma2));
}

 public bool plain_is_equal(pw_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.plain_is_equal(new pw_multi_aff(pma2));
}

 public pw_multi_aff preimage_domain_wrapped_domain(pw_multi_aff pma2)
{
  if (get() == IntPtr.Zero || pma2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_preimage_domain_wrapped_domain_pw_multi_aff(copy(), pma2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public union_pw_multi_aff preimage_domain_wrapped_domain(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).preimage_domain_wrapped_domain(upma2);
}

 public pw_multi_aff preimage_domain_wrapped_domain(multi_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.preimage_domain_wrapped_domain(new pw_multi_aff(pma2));
}

 public pw_multi_aff preimage_domain_wrapped_domain(pw_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.preimage_domain_wrapped_domain(new pw_multi_aff(pma2));
}

 public multi_pw_aff product(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_pw_aff(get()).product(multi2);
}

 public pw_multi_aff product(pw_multi_aff pma2)
{
  if (get() == IntPtr.Zero || pma2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_product(copy(), pma2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public pw_multi_aff product(multi_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.product(new pw_multi_aff(pma2));
}

 public pw_multi_aff product(pw_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.product(new pw_multi_aff(pma2));
}

 public multi_pw_aff pullback(multi_pw_aff mpa2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_pw_aff(get()).pullback(mpa2);
}

 public pw_multi_aff pullback(multi_aff ma)
{
  if (get() == IntPtr.Zero || ma.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_pullback_multi_aff(copy(), ma.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public pw_multi_aff pullback(pw_multi_aff pma2)
{
  if (get() == IntPtr.Zero || pma2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_pullback_pw_multi_aff(copy(), pma2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public union_pw_multi_aff pullback(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).pullback(upma2);
}

 public pw_multi_aff_list pw_multi_aff_list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).pw_multi_aff_list();
}

 public pw_multi_aff range_factor_domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_range_factor_domain(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public pw_multi_aff range_factor_range()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_range_factor_range(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public static pw_multi_aff range_map(space space)
{
  if (space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_range_map(space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public multi_pw_aff range_product(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_pw_aff(get()).range_product(multi2);
}

 public multi_union_pw_aff range_product(multi_union_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_pw_aff(get()).range_product(multi2);
}

 public pw_multi_aff range_product(pw_multi_aff pma2)
{
  if (get() == IntPtr.Zero || pma2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_range_product(copy(), pma2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public union_pw_multi_aff range_product(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).range_product(upma2);
}

 public pw_multi_aff range_product(multi_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.range_product(new pw_multi_aff(pma2));
}

 public pw_multi_aff range_product(pw_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.range_product(new pw_multi_aff(pma2));
}

 public id range_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_get_range_tuple_id(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new id(res);
}

 public multi_pw_aff reset_range_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_pw_aff(get()).reset_range_tuple_id();
}

 public pw_multi_aff scale(multi_val mv)
{
  if (get() == IntPtr.Zero || mv.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_scale_multi_val(copy(), mv.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public pw_multi_aff scale(val v)
{
  if (get() == IntPtr.Zero || v.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_scale_val(copy(), v.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public pw_multi_aff scale(long v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.scale(new val(ctx.Instance, v));
}

 public pw_multi_aff scale_down(multi_val mv)
{
  if (get() == IntPtr.Zero || mv.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_scale_down_multi_val(copy(), mv.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public pw_multi_aff scale_down(val v)
{
  if (get() == IntPtr.Zero || v.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_scale_down_val(copy(), v.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public pw_multi_aff scale_down(long v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.scale_down(new val(ctx.Instance, v));
}

 public multi_pw_aff set_at(int pos, pw_aff el)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_pw_aff(get()).set_at(pos, el);
}

 public multi_union_pw_aff set_at(int pos, union_pw_aff el)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_pw_aff(get()).set_at(pos, el);
}

 public pw_multi_aff set_range_tuple(id id)
{
  if (get() == IntPtr.Zero || id.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_set_range_tuple_id(copy(), id.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public pw_multi_aff set_range_tuple(string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.set_range_tuple(new id(ctx.Instance, id));
}

 public int size()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_pw_aff(get()).size();
}

 public space space()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_get_space(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public multi_pw_aff sub(multi_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_pw_aff(get()).sub(multi2);
}

 public multi_union_pw_aff sub(multi_union_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_pw_aff(get()).sub(multi2);
}

 public pw_multi_aff sub(pw_multi_aff pma2)
{
  if (get() == IntPtr.Zero || pma2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_sub(copy(), pma2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public union_pw_multi_aff sub(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).sub(upma2);
}

 public pw_multi_aff sub(multi_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.sub(new pw_multi_aff(pma2));
}

 public pw_multi_aff sub(pw_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.sub(new pw_multi_aff(pma2));
}

 public pw_multi_aff subtract_domain(set set)
{
  if (get() == IntPtr.Zero || set.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_subtract_domain(copy(), set.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public union_pw_multi_aff subtract_domain(space space)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).subtract_domain(space);
}

 public union_pw_multi_aff subtract_domain(union_set uset)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).subtract_domain(uset);
}

 public pw_multi_aff subtract_domain(basic_set set)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.subtract_domain(new set(set));
}

 public pw_multi_aff subtract_domain(point set)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.subtract_domain(new set(set));
}

 public pw_multi_aff_list to_list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_to_list(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff_list(res);
}

 public multi_pw_aff to_multi_pw_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_to_multi_pw_aff(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public union_pw_multi_aff to_union_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_to_union_pw_multi_aff(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_multi_aff(res);
}

 public multi_pw_aff unbind_params_insert_domain(multi_id domain)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_pw_aff(get()).unbind_params_insert_domain(domain);
}

 public multi_pw_aff union_add(multi_pw_aff mpa2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_pw_aff(get()).union_add(mpa2);
}

 public multi_union_pw_aff union_add(multi_union_pw_aff mupa2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_pw_aff(get()).union_add(mupa2);
}

 public pw_multi_aff union_add(pw_multi_aff pma2)
{
  if (get() == IntPtr.Zero || pma2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_union_add(copy(), pma2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public union_pw_multi_aff union_add(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).union_add(upma2);
}

 public pw_multi_aff union_add(multi_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.union_add(new pw_multi_aff(pma2));
}

 public pw_multi_aff union_add(pw_aff pma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.union_add(new pw_multi_aff(pma2));
}

 public static pw_multi_aff zero(space space)
{
  if (space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_zero(space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

public override string ToString(){
  var str = Interop.isl_pw_multi_aff_to_str(get());
  return str;
}
}

public class pw_multi_aff_list : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal pw_multi_aff_list(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

 public /* explicit */ pw_multi_aff_list(ctx ctx, int n)
{
  var res = Interop.isl_pw_multi_aff_list_alloc(ctx.get(), n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ pw_multi_aff_list(pw_multi_aff el)
{
  if (el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_list_from_pw_multi_aff(el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ pw_multi_aff_list(ctx ctx, string str)
{
  var res = Interop.isl_pw_multi_aff_list_read_from_str(ctx.get(), str);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

public void Dispose() {
  if (!is_null()) {
    Interop.isl_pw_multi_aff_list_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_pw_multi_aff_list_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public pw_multi_aff_list add(pw_multi_aff el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_list_add(copy(), el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff_list(res);
}

 public pw_multi_aff at(int index)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_list_get_at(get(), index);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public pw_multi_aff_list clear()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_list_clear(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff_list(res);
}

 public pw_multi_aff_list concat(pw_multi_aff_list list2)
{
  if (get() == IntPtr.Zero || list2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_list_concat(copy(), list2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff_list(res);
}

 public pw_multi_aff_list drop(uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_list_drop(copy(), first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff_list(res);
}

 public void Foreach(Action<pw_multi_aff> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Action<pw_multi_aff> func,  Exception? eptr) fn_data = (func: fn, eptr: null);
Func<IntPtr, IntPtr, isl_stat> fn_lambda = (IntPtr arg_0, IntPtr arg_1) => {
    try {
      fn_data.func(new (arg_0));
      return isl_stat.Ok;
    } catch (Exception e) {
      throw e;
      return isl_stat.Error;
    }
  };
  var res = Interop.isl_pw_multi_aff_list_foreach(get(), fn_lambda, IntPtr.Zero);
  if (fn_data.eptr is not null) {
    throw fn_data.eptr;
  }
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return;
}

 public void foreach_scc(Func<pw_multi_aff, pw_multi_aff, bool> follows, Action<pw_multi_aff_list> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Func<pw_multi_aff, pw_multi_aff, bool> func,  Exception? eptr) follows_data = (func: follows, eptr: null);
Func<IntPtr, IntPtr, IntPtr, isl_bool> follows_lambda = (IntPtr arg_0, IntPtr arg_1, IntPtr arg_2) => {
    try {
      var ret = follows_data.func(new (arg_0), new (arg_1));
      return ret ? isl_bool.True : isl_bool.False;
    } catch (Exception e) {
      throw e;
      return isl_bool.Error;
    }
  };
 (Action<pw_multi_aff_list> func,  Exception? eptr) fn_data = (func: fn, eptr: null);
Func<IntPtr, IntPtr, isl_stat> fn_lambda = (IntPtr arg_0, IntPtr arg_1) => {
    try {
      fn_data.func(new (arg_0));
      return isl_stat.Ok;
    } catch (Exception e) {
      throw e;
      return isl_stat.Error;
    }
  };
  var res = Interop.isl_pw_multi_aff_list_foreach_scc(get(), follows_lambda, IntPtr.Zero, fn_lambda, IntPtr.Zero);
  if (follows_data.eptr is not null) {
    throw follows_data.eptr;
  }
  if (fn_data.eptr is not null) {
    throw fn_data.eptr;
  }
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return;
}

 public pw_multi_aff_list insert(uint pos, pw_multi_aff el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_list_insert(copy(), pos, el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff_list(res);
}

 public pw_multi_aff_list set_at(int index, pw_multi_aff el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_list_set_at(copy(), index, el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff_list(res);
}

 public int size()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_pw_multi_aff_list_size(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

public override string ToString(){
  var str = Interop.isl_pw_multi_aff_list_to_str(get());
  return str;
}
}

public class schedule : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal schedule(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

 public /* explicit */ schedule(ctx ctx, string str)
{
  var res = Interop.isl_schedule_read_from_str(ctx.get(), str);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

public void Dispose() {
  if (!is_null()) {
    Interop.isl_schedule_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_schedule_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public union_set domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_get_domain(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set(res);
}

 public static schedule from_domain(union_set domain)
{
  if (domain.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_from_domain(domain.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule(res);
}

 public union_map map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_get_map(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public schedule pullback(union_pw_multi_aff upma)
{
  if (get() == IntPtr.Zero || upma.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_pullback_union_pw_multi_aff(copy(), upma.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule(res);
}

 public schedule_node root()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_get_root(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule_node(res);
}

public override string ToString(){
  var str = Interop.isl_schedule_to_str(get());
  return str;
}
}

public class schedule_constraints : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal schedule_constraints(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

 public /* explicit */ schedule_constraints(ctx ctx, string str)
{
  var res = Interop.isl_schedule_constraints_read_from_str(ctx.get(), str);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

public void Dispose() {
  if (!is_null()) {
    Interop.isl_schedule_constraints_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_schedule_constraints_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public union_map coincidence()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_constraints_get_coincidence(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public schedule compute_schedule()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_constraints_compute_schedule(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule(res);
}

 public union_map conditional_validity()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_constraints_get_conditional_validity(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map conditional_validity_condition()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_constraints_get_conditional_validity_condition(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public set context()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_constraints_get_context(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public union_set domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_constraints_get_domain(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set(res);
}

 public static schedule_constraints on_domain(union_set domain)
{
  if (domain.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_constraints_on_domain(domain.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule_constraints(res);
}

 public union_map proximity()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_constraints_get_proximity(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public schedule_constraints set_coincidence(union_map coincidence)
{
  if (get() == IntPtr.Zero || coincidence.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_constraints_set_coincidence(copy(), coincidence.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule_constraints(res);
}

 public schedule_constraints set_conditional_validity(union_map condition, union_map validity)
{
  if (get() == IntPtr.Zero || condition.is_null() || validity.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_constraints_set_conditional_validity(copy(), condition.copy(), validity.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule_constraints(res);
}

 public schedule_constraints set_context(set context)
{
  if (get() == IntPtr.Zero || context.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_constraints_set_context(copy(), context.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule_constraints(res);
}

 public schedule_constraints set_proximity(union_map proximity)
{
  if (get() == IntPtr.Zero || proximity.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_constraints_set_proximity(copy(), proximity.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule_constraints(res);
}

 public schedule_constraints set_validity(union_map validity)
{
  if (get() == IntPtr.Zero || validity.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_constraints_set_validity(copy(), validity.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule_constraints(res);
}

 public union_map validity()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_constraints_get_validity(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

public override string ToString(){
  var str = Interop.isl_schedule_constraints_to_str(get());
  return str;
}
}

public class schedule_node : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal schedule_node(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

public void Dispose() {
  if (!is_null()) {
    Interop.isl_schedule_node_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_schedule_node_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public schedule_node ancestor(int generation)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_ancestor(copy(), generation);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule_node(res);
}

 public int ancestor_child_position(schedule_node ancestor)
{
  if (get() == IntPtr.Zero || ancestor.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_get_ancestor_child_position(get(), ancestor.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

 public schedule_node child(int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_child(copy(), pos);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule_node(res);
}

 public int child_position()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_get_child_position(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

 public bool every_descendant(Func<schedule_node, bool> test)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Func<schedule_node, bool> func,  Exception? eptr) test_data = (func: test, eptr: null);
Func<IntPtr, IntPtr, isl_bool> test_lambda = (IntPtr arg_0, IntPtr arg_1) => {
    try {
      var ret = test_data.func(new (arg_0));
      return ret ? isl_bool.True : isl_bool.False;
    } catch (Exception e) {
      throw e;
      return isl_bool.Error;
    }
  };
  var res = Interop.isl_schedule_node_every_descendant(get(), test_lambda, IntPtr.Zero);
  if (test_data.eptr is not null) {
    throw test_data.eptr;
  }
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public schedule_node first_child()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_first_child(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule_node(res);
}

 public void foreach_ancestor_top_down(Action<schedule_node> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Action<schedule_node> func,  Exception? eptr) fn_data = (func: fn, eptr: null);
Func<IntPtr, IntPtr, isl_stat> fn_lambda = (IntPtr arg_0, IntPtr arg_1) => {
    try {
      fn_data.func(new (arg_0));
      return isl_stat.Ok;
    } catch (Exception e) {
      throw e;
      return isl_stat.Error;
    }
  };
  var res = Interop.isl_schedule_node_foreach_ancestor_top_down(get(), fn_lambda, IntPtr.Zero);
  if (fn_data.eptr is not null) {
    throw fn_data.eptr;
  }
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return;
}

 public void foreach_descendant_top_down(Func<schedule_node, bool> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Func<schedule_node, bool> func,  Exception? eptr) fn_data = (func: fn, eptr: null);
Func<IntPtr, IntPtr, isl_bool> fn_lambda = (IntPtr arg_0, IntPtr arg_1) => {
    try {
      var ret = fn_data.func(new (arg_0));
      return ret ? isl_bool.True : isl_bool.False;
    } catch (Exception e) {
      throw e;
      return isl_bool.Error;
    }
  };
  var res = Interop.isl_schedule_node_foreach_descendant_top_down(get(), fn_lambda, IntPtr.Zero);
  if (fn_data.eptr is not null) {
    throw fn_data.eptr;
  }
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return;
}

 public static schedule_node from_domain(union_set domain)
{
  if (domain.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_from_domain(domain.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule_node(res);
}

 public static schedule_node from_extension(union_map extension)
{
  if (extension.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_from_extension(extension.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule_node(res);
}

 public schedule_node graft_after(schedule_node graft)
{
  if (get() == IntPtr.Zero || graft.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_graft_after(copy(), graft.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule_node(res);
}

 public schedule_node graft_before(schedule_node graft)
{
  if (get() == IntPtr.Zero || graft.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_graft_before(copy(), graft.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule_node(res);
}

 public bool has_children()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_has_children(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool has_next_sibling()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_has_next_sibling(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool has_parent()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_has_parent(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool has_previous_sibling()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_has_previous_sibling(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public schedule_node insert_context(set context)
{
  if (get() == IntPtr.Zero || context.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_insert_context(copy(), context.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule_node(res);
}

 public schedule_node insert_filter(union_set filter)
{
  if (get() == IntPtr.Zero || filter.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_insert_filter(copy(), filter.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule_node(res);
}

 public schedule_node insert_guard(set context)
{
  if (get() == IntPtr.Zero || context.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_insert_guard(copy(), context.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule_node(res);
}

 public schedule_node insert_mark(id mark)
{
  if (get() == IntPtr.Zero || mark.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_insert_mark(copy(), mark.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule_node(res);
}

 public schedule_node insert_mark(string mark)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.insert_mark(new id(ctx.Instance, mark));
}

 public schedule_node insert_partial_schedule(multi_union_pw_aff schedule)
{
  if (get() == IntPtr.Zero || schedule.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_insert_partial_schedule(copy(), schedule.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule_node(res);
}

 public schedule_node insert_sequence(union_set_list filters)
{
  if (get() == IntPtr.Zero || filters.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_insert_sequence(copy(), filters.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule_node(res);
}

 public schedule_node insert_set(union_set_list filters)
{
  if (get() == IntPtr.Zero || filters.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_insert_set(copy(), filters.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule_node(res);
}

 public bool is_equal(schedule_node node2)
{
  if (get() == IntPtr.Zero || node2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_is_equal(get(), node2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_subtree_anchored()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_is_subtree_anchored(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public schedule_node map_descendant_bottom_up(Func<schedule_node, schedule_node> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Func<schedule_node, schedule_node> func,  Exception? eptr) fn_data = (func: fn, eptr: null);
Func<IntPtr, IntPtr, IntPtr> fn_lambda = (IntPtr arg_0, IntPtr arg_1) => {
    try {
      var ret = fn_data.func(new (arg_0));
      return ret.get();
    } catch (Exception e) {
      throw e;
      return IntPtr.Zero;
    }
  };
  var res = Interop.isl_schedule_node_map_descendant_bottom_up(copy(), fn_lambda, IntPtr.Zero);
  if (fn_data.eptr is not null) {
    throw fn_data.eptr;
  }
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule_node(res);
}

 public int n_children()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_n_children(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

 public schedule_node next_sibling()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_next_sibling(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule_node(res);
}

 public schedule_node order_after(union_set filter)
{
  if (get() == IntPtr.Zero || filter.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_order_after(copy(), filter.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule_node(res);
}

 public schedule_node order_before(union_set filter)
{
  if (get() == IntPtr.Zero || filter.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_order_before(copy(), filter.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule_node(res);
}

 public schedule_node parent()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_parent(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule_node(res);
}

 public multi_union_pw_aff prefix_schedule_multi_union_pw_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_get_prefix_schedule_multi_union_pw_aff(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_union_pw_aff(res);
}

 public union_map prefix_schedule_union_map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_get_prefix_schedule_union_map(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_pw_multi_aff prefix_schedule_union_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_get_prefix_schedule_union_pw_multi_aff(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_multi_aff(res);
}

 public schedule_node previous_sibling()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_previous_sibling(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule_node(res);
}

 public schedule_node root()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_root(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule_node(res);
}

 public schedule schedule()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_get_schedule(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule(res);
}

 public schedule_node shared_ancestor(schedule_node node2)
{
  if (get() == IntPtr.Zero || node2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_get_shared_ancestor(get(), node2.get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule_node(res);
}

 public int tree_depth()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_get_tree_depth(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

public override string ToString(){
  var str = Interop.isl_schedule_node_to_str(get());
  return str;
}
}

public class schedule_node_band : schedule_node , IDisposable, IObject {

internal schedule_node_band(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

 public union_set ast_build_options()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_band_get_ast_build_options(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set(res);
}

 public set ast_isolate_option()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_band_get_ast_isolate_option(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public bool member_get_coincident(int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_band_member_get_coincident(get(), pos);
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public schedule_node_band member_set_coincident(int pos, int coincident)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_band_member_set_coincident(copy(), pos, coincident);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule_node_band(res);
}

 public schedule_node_band mod(multi_val mv)
{
  if (get() == IntPtr.Zero || mv.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_band_mod(copy(), mv.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule_node_band(res);
}

 public int n_member()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_band_n_member(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

 public multi_union_pw_aff partial_schedule()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_band_get_partial_schedule(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_union_pw_aff(res);
}

 public bool permutable()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_band_get_permutable(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public schedule_node_band scale(multi_val mv)
{
  if (get() == IntPtr.Zero || mv.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_band_scale(copy(), mv.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule_node_band(res);
}

 public schedule_node_band scale_down(multi_val mv)
{
  if (get() == IntPtr.Zero || mv.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_band_scale_down(copy(), mv.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule_node_band(res);
}

 public schedule_node_band set_ast_build_options(union_set options)
{
  if (get() == IntPtr.Zero || options.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_band_set_ast_build_options(copy(), options.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule_node_band(res);
}

 public schedule_node_band set_permutable(int permutable)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_band_set_permutable(copy(), permutable);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule_node_band(res);
}

 public schedule_node_band shift(multi_union_pw_aff shift)
{
  if (get() == IntPtr.Zero || shift.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_band_shift(copy(), shift.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule_node_band(res);
}

 public schedule_node_band split(int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_band_split(copy(), pos);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule_node_band(res);
}

 public schedule_node_band tile(multi_val sizes)
{
  if (get() == IntPtr.Zero || sizes.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_band_tile(copy(), sizes.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule_node_band(res);
}

 public schedule_node_band member_set_ast_loop_type(int pos, ast_loop_type type)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_band_member_set_ast_loop_type(copy(), pos, type);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new schedule_node_band(res);
}

public override string ToString(){
  var str = Interop.isl_schedule_node_to_str(get());
  return str;
}
}

public class schedule_node_context : schedule_node , IDisposable, IObject {

internal schedule_node_context(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

 public set context()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_context_get_context(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

public override string ToString(){
  var str = Interop.isl_schedule_node_to_str(get());
  return str;
}
}

public class schedule_node_domain : schedule_node , IDisposable, IObject {

internal schedule_node_domain(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

 public union_set domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_domain_get_domain(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set(res);
}

public override string ToString(){
  var str = Interop.isl_schedule_node_to_str(get());
  return str;
}
}

public class schedule_node_expansion : schedule_node , IDisposable, IObject {

internal schedule_node_expansion(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

 public union_pw_multi_aff contraction()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_expansion_get_contraction(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_multi_aff(res);
}

 public union_map expansion()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_expansion_get_expansion(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

public override string ToString(){
  var str = Interop.isl_schedule_node_to_str(get());
  return str;
}
}

public class schedule_node_extension : schedule_node , IDisposable, IObject {

internal schedule_node_extension(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

 public union_map extension()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_extension_get_extension(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

public override string ToString(){
  var str = Interop.isl_schedule_node_to_str(get());
  return str;
}
}

public class schedule_node_filter : schedule_node , IDisposable, IObject {

internal schedule_node_filter(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

 public union_set filter()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_filter_get_filter(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set(res);
}

public override string ToString(){
  var str = Interop.isl_schedule_node_to_str(get());
  return str;
}
}

public class schedule_node_guard : schedule_node , IDisposable, IObject {

internal schedule_node_guard(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

 public set guard()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_schedule_node_guard_get_guard(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

public override string ToString(){
  var str = Interop.isl_schedule_node_to_str(get());
  return str;
}
}

public class schedule_node_leaf : schedule_node , IDisposable, IObject {

internal schedule_node_leaf(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

public override string ToString(){
  var str = Interop.isl_schedule_node_to_str(get());
  return str;
}
}

public class schedule_node_mark : schedule_node , IDisposable, IObject {

internal schedule_node_mark(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

public override string ToString(){
  var str = Interop.isl_schedule_node_to_str(get());
  return str;
}
}

public class schedule_node_sequence : schedule_node , IDisposable, IObject {

internal schedule_node_sequence(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

public override string ToString(){
  var str = Interop.isl_schedule_node_to_str(get());
  return str;
}
}

public class schedule_node_set : schedule_node , IDisposable, IObject {

internal schedule_node_set(/* __isl_take */ IntPtr ptr)
    : base(ptr) {}

public override string ToString(){
  var str = Interop.isl_schedule_node_to_str(get());
  return str;
}
}

public class set : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal set(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

 public /* implicit */ set(basic_set bset)
{
  if (bset.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_from_basic_set(bset.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* implicit */ set(point pnt)
{
  if (pnt.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_from_point(pnt.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ set(ctx ctx, string str)
{
  var res = Interop.isl_set_read_from_str(ctx.get(), str);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

public void Dispose() {
  if (!is_null()) {
    Interop.isl_set_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_set_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public set add_constraint(constraint constraint)
{
  if (get() == IntPtr.Zero || constraint.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_add_constraint(copy(), constraint.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set add_dims(dim_type type, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_add_dims(copy(), type, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public basic_set affine_hull()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_affine_hull(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public set align_params(space model)
{
  if (get() == IntPtr.Zero || model.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_align_params(copy(), model.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set apply(map map)
{
  if (get() == IntPtr.Zero || map.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_apply(copy(), map.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public union_set apply(union_map umap)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_set(get()).apply(umap);
}

 public set apply(basic_map map)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.apply(new map(map));
}

 public pw_multi_aff as_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_as_pw_multi_aff(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public set as_set()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_set(get()).as_set();
}

 public basic_set_list basic_set_list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_get_basic_set_list(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set_list(res);
}

 public set bind(multi_id tuple)
{
  if (get() == IntPtr.Zero || tuple.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_bind(copy(), tuple.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public static set box_from_points(point pnt1, point pnt2)
{
  if (pnt1.is_null() || pnt2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_box_from_points(pnt1.copy(), pnt2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set coalesce()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_coalesce(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public basic_set coefficients()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_coefficients(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public set complement()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_complement(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set compute_divs()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_compute_divs(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public val count_val()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_count_val(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public set detect_equalities()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_detect_equalities(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public int dim(dim_type type)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_dim(get(), type);
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

 public bool dim_has_any_lower_bound(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_dim_has_any_lower_bound(get(), type, pos);
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool dim_has_any_upper_bound(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_dim_has_any_upper_bound(get(), type, pos);
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool dim_has_lower_bound(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_dim_has_lower_bound(get(), type, pos);
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool dim_has_upper_bound(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_dim_has_upper_bound(get(), type, pos);
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public id dim_id(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_get_dim_id(get(), type, pos);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new id(res);
}

 public bool dim_is_bounded(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_dim_is_bounded(get(), type, pos);
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public pw_aff dim_max(int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_dim_max(copy(), pos);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public val dim_max_val(int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_dim_max_val(copy(), pos);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public pw_aff dim_min(int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_dim_min(copy(), pos);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public val dim_min_val(int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_dim_min_val(copy(), pos);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public string dim_name(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_get_dim_name(get(), type, pos);
  return Marshal.PtrToStringAnsi(res);
}

 public set drop_constraints_involving_dims(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_drop_constraints_involving_dims(copy(), type, first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set drop_constraints_not_involving_dims(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_drop_constraints_not_involving_dims(copy(), type, first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set drop_unused_params()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_drop_unused_params(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set eliminate(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_eliminate(copy(), type, first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set eliminate_dims(uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_eliminate_dims(copy(), first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public static set empty(space space)
{
  if (space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_empty(space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public bool every_set(Func<set, bool> test)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_set(get()).every_set(test);
}

 public set extract_set(space space)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_set(get()).extract_set(space);
}

 public int find_dim_by_id(dim_type type, id id)
{
  if (get() == IntPtr.Zero || id.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_find_dim_by_id(get(), type, id.get());
  return res;
}

 public int find_dim_by_id(dim_type type, string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.find_dim_by_id(type, new id(ctx.Instance, id));
}

 public int find_dim_by_name(dim_type type, string name)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_find_dim_by_name(get(), type, name);
  return res;
}

 public set fix_dim_si(uint dim, int value)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_fix_dim_si(copy(), dim, value);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set fix_si(dim_type type, uint pos, int value)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_fix_si(copy(), type, pos, value);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set fix_val(dim_type type, uint pos, val v)
{
  if (get() == IntPtr.Zero || v.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_fix_val(copy(), type, pos, v.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set fix_val(dim_type type, uint pos, long v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.fix_val(type, pos, new val(ctx.Instance, v));
}

 public set flatten()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_flatten(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public map flatten_map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_flatten_map(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public void foreach_basic_set(Action<basic_set> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Action<basic_set> func,  Exception? eptr) fn_data = (func: fn, eptr: null);
Func<IntPtr, IntPtr, isl_stat> fn_lambda = (IntPtr arg_0, IntPtr arg_1) => {
    try {
      fn_data.func(new (arg_0));
      return isl_stat.Ok;
    } catch (Exception e) {
      throw e;
      return isl_stat.Error;
    }
  };
  var res = Interop.isl_set_foreach_basic_set(get(), fn_lambda, IntPtr.Zero);
  if (fn_data.eptr is not null) {
    throw fn_data.eptr;
  }
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return;
}

 public void foreach_point(Action<point> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Action<point> func,  Exception? eptr) fn_data = (func: fn, eptr: null);
Func<IntPtr, IntPtr, isl_stat> fn_lambda = (IntPtr arg_0, IntPtr arg_1) => {
    try {
      fn_data.func(new (arg_0));
      return isl_stat.Ok;
    } catch (Exception e) {
      throw e;
      return isl_stat.Error;
    }
  };
  var res = Interop.isl_set_foreach_point(get(), fn_lambda, IntPtr.Zero);
  if (fn_data.eptr is not null) {
    throw fn_data.eptr;
  }
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return;
}

 public void foreach_set(Action<set> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
new union_set(get()).foreach_set(fn);
}

 public static set from_multi_aff(multi_aff ma)
{
  if (ma.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_from_multi_aff(ma.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set gist(set context)
{
  if (get() == IntPtr.Zero || context.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_gist(copy(), context.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public union_set gist(union_set context)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_set(get()).gist(context);
}

 public set gist(basic_set context)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.gist(new set(context));
}

 public set gist(point context)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.gist(new set(context));
}

 public set gist_basic_set(basic_set context)
{
  if (get() == IntPtr.Zero || context.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_gist_basic_set(copy(), context.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set gist_params(set context)
{
  if (get() == IntPtr.Zero || context.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_gist_params(copy(), context.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public bool has_dim_id(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_has_dim_id(get(), type, pos);
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool has_dim_name(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_has_dim_name(get(), type, pos);
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool has_equal_space(set set2)
{
  if (get() == IntPtr.Zero || set2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_has_equal_space(get(), set2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool has_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_has_tuple_id(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool has_tuple_name()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_has_tuple_name(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public map identity()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_identity(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public pw_aff indicator_function()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_indicator_function(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public set insert_dims(dim_type type, uint pos, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_insert_dims(copy(), type, pos, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public map insert_domain(space domain)
{
  if (get() == IntPtr.Zero || domain.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_insert_domain(copy(), domain.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public set intersect(set set2)
{
  if (get() == IntPtr.Zero || set2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_intersect(copy(), set2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public union_set intersect(union_set uset2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_set(get()).intersect(uset2);
}

 public set intersect(basic_set set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.intersect(new set(set2));
}

 public set intersect(point set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.intersect(new set(set2));
}

 public set intersect_params(set params_)
{
  if (get() == IntPtr.Zero || params_.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_intersect_params(copy(), params_.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public bool involves_dims(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_involves_dims(get(), type, first, n);
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool involves_locals()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_involves_locals(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_bounded()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_is_bounded(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_box()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_is_box(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_disjoint(set set2)
{
  if (get() == IntPtr.Zero || set2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_is_disjoint(get(), set2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_disjoint(union_set uset2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_set(get()).is_disjoint(uset2);
}

 public bool is_disjoint(basic_set set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.is_disjoint(new set(set2));
}

 public bool is_disjoint(point set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.is_disjoint(new set(set2));
}

 public bool is_empty()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_is_empty(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_equal(set set2)
{
  if (get() == IntPtr.Zero || set2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_is_equal(get(), set2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_equal(union_set uset2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_set(get()).is_equal(uset2);
}

 public bool is_equal(basic_set set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.is_equal(new set(set2));
}

 public bool is_equal(point set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.is_equal(new set(set2));
}

 public bool is_params()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_is_params(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_singleton()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_is_singleton(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_strict_subset(set set2)
{
  if (get() == IntPtr.Zero || set2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_is_strict_subset(get(), set2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_strict_subset(union_set uset2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_set(get()).is_strict_subset(uset2);
}

 public bool is_strict_subset(basic_set set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.is_strict_subset(new set(set2));
}

 public bool is_strict_subset(point set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.is_strict_subset(new set(set2));
}

 public bool is_subset(set set2)
{
  if (get() == IntPtr.Zero || set2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_is_subset(get(), set2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_subset(union_set uset2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_set(get()).is_subset(uset2);
}

 public bool is_subset(basic_set set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.is_subset(new set(set2));
}

 public bool is_subset(point set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.is_subset(new set(set2));
}

 public bool is_wrapping()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_is_wrapping(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool isa_set()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_set(get()).isa_set();
}

 public fixed_box lattice_tile()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_get_lattice_tile(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new fixed_box(res);
}

 public map lex_ge_set(set set2)
{
  if (get() == IntPtr.Zero || set2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_lex_ge_set(copy(), set2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map lex_gt_set(set set2)
{
  if (get() == IntPtr.Zero || set2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_lex_gt_set(copy(), set2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map lex_le_set(set set2)
{
  if (get() == IntPtr.Zero || set2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_lex_le_set(copy(), set2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public map lex_lt_set(set set2)
{
  if (get() == IntPtr.Zero || set2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_lex_lt_set(copy(), set2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public set lexmax()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_lexmax(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public pw_multi_aff lexmax_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_lexmax_pw_multi_aff(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public set lexmin()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_lexmin(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public pw_multi_aff lexmin_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_lexmin_pw_multi_aff(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public set lift()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_lift(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set lower_bound(multi_pw_aff lower)
{
  if (get() == IntPtr.Zero || lower.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_lower_bound_multi_pw_aff(copy(), lower.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set lower_bound(multi_val lower)
{
  if (get() == IntPtr.Zero || lower.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_lower_bound_multi_val(copy(), lower.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set lower_bound_si(dim_type type, uint pos, int value)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_lower_bound_si(copy(), type, pos, value);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set lower_bound_val(dim_type type, uint pos, val value)
{
  if (get() == IntPtr.Zero || value.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_lower_bound_val(copy(), type, pos, value.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set lower_bound_val(dim_type type, uint pos, long value)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.lower_bound_val(type, pos, new val(ctx.Instance, value));
}

 public set make_disjoint()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_make_disjoint(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public multi_pw_aff max_multi_pw_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_max_multi_pw_aff(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public val max_val(aff obj)
{
  if (get() == IntPtr.Zero || obj.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_max_val(get(), obj.get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public multi_pw_aff min_multi_pw_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_min_multi_pw_aff(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public val min_val(aff obj)
{
  if (get() == IntPtr.Zero || obj.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_min_val(get(), obj.get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public set move_dims(dim_type dst_type, uint dst_pos, dim_type src_type, uint src_pos, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_move_dims(copy(), dst_type, dst_pos, src_type, src_pos, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public int n_basic_set()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_n_basic_set(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

 public int n_dim()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_n_dim(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

 public int n_param()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_n_param(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

 public set neg()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_neg(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public pw_aff param_pw_aff_on_domain(id id)
{
  if (get() == IntPtr.Zero || id.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_param_pw_aff_on_domain_id(copy(), id.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public pw_aff param_pw_aff_on_domain(string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.param_pw_aff_on_domain(new id(ctx.Instance, id));
}

 public set paramss()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_params(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public val plain_get_val_if_fixed(dim_type type, uint pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_plain_get_val_if_fixed(get(), type, pos);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public bool plain_is_disjoint(set set2)
{
  if (get() == IntPtr.Zero || set2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_plain_is_disjoint(get(), set2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool plain_is_empty()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_plain_is_empty(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool plain_is_universe()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_plain_is_universe(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public multi_val plain_multi_val_if_fixed()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_get_plain_multi_val_if_fixed(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_val(res);
}

 public basic_set polyhedral_hull()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_polyhedral_hull(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public set preimage(multi_aff ma)
{
  if (get() == IntPtr.Zero || ma.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_preimage_multi_aff(copy(), ma.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set preimage(multi_pw_aff mpa)
{
  if (get() == IntPtr.Zero || mpa.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_preimage_multi_pw_aff(copy(), mpa.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set preimage(pw_multi_aff pma)
{
  if (get() == IntPtr.Zero || pma.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_preimage_pw_multi_aff(copy(), pma.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public union_set preimage(union_pw_multi_aff upma)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_set(get()).preimage(upma);
}

 public set product(set set2)
{
  if (get() == IntPtr.Zero || set2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_product(copy(), set2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public map project_onto_map(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_project_onto_map(copy(), type, first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public set project_out(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_project_out(copy(), type, first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set project_out_all_params()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_project_out_all_params(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set project_out_param(id id)
{
  if (get() == IntPtr.Zero || id.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_project_out_param_id(copy(), id.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set project_out_param(string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.project_out_param(new id(ctx.Instance, id));
}

 public set project_out_param(id_list list)
{
  if (get() == IntPtr.Zero || list.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_project_out_param_id_list(copy(), list.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public pw_aff pw_aff_on_domain(val v)
{
  if (get() == IntPtr.Zero || v.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_pw_aff_on_domain_val(copy(), v.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_aff(res);
}

 public pw_aff pw_aff_on_domain(long v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.pw_aff_on_domain(new val(ctx.Instance, v));
}

 public pw_multi_aff pw_multi_aff_on_domain(multi_val mv)
{
  if (get() == IntPtr.Zero || mv.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_pw_multi_aff_on_domain_multi_val(copy(), mv.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public set remove_dims(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_remove_dims(copy(), type, first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set remove_divs()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_remove_divs(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set remove_divs_involving_dims(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_remove_divs_involving_dims(copy(), type, first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set remove_redundancies()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_remove_redundancies(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set remove_unknown_divs()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_remove_unknown_divs(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set reset_space(space space)
{
  if (get() == IntPtr.Zero || space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_reset_space(copy(), space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set reset_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_reset_tuple_id(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set reset_user()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_reset_user(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public basic_set sample()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_sample(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public point sample_point()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_sample_point(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new point(res);
}

 public set set_dim_id(dim_type type, uint pos, id id)
{
  if (get() == IntPtr.Zero || id.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_set_dim_id(copy(), type, pos, id.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set set_dim_id(dim_type type, uint pos, string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.set_dim_id(type, pos, new id(ctx.Instance, id));
}

 public set set_dim_name(dim_type type, uint pos, string s)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_set_dim_name(copy(), type, pos, s);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set_list set_list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_set(get()).set_list();
}

 public set set_tuple_id(id id)
{
  if (get() == IntPtr.Zero || id.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_set_tuple_id(copy(), id.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set set_tuple_id(string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.set_tuple_id(new id(ctx.Instance, id));
}

 public set set_tuple_name(string s)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_set_tuple_name(copy(), s);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public fixed_box simple_fixed_box_hull()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_get_simple_fixed_box_hull(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new fixed_box(res);
}

 public int size()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_size(get());
  return res;
}

 public basic_set solutions()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_solutions(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public space space()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_get_space(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public set split_dims(dim_type type, uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_split_dims(copy(), type, first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public val stride(int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_get_stride(get(), pos);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public set subtract(set set2)
{
  if (get() == IntPtr.Zero || set2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_subtract(copy(), set2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public union_set subtract(union_set uset2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_set(get()).subtract(uset2);
}

 public set subtract(basic_set set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.subtract(new set(set2));
}

 public set subtract(point set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.subtract(new set(set2));
}

 public set sum(set set2)
{
  if (get() == IntPtr.Zero || set2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_sum(copy(), set2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set_list to_list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_to_list(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set_list(res);
}

 public union_set to_union_set()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_to_union_set(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set(res);
}

 public map translation()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_translation(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public int tuple_dim()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_tuple_dim(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

 public id tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_get_tuple_id(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new id(res);
}

 public string tuple_name()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_get_tuple_name(get());
  return Marshal.PtrToStringAnsi(res);
}

 public set unbind_params(multi_id tuple)
{
  if (get() == IntPtr.Zero || tuple.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_unbind_params(copy(), tuple.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public map unbind_params_insert_domain(multi_id domain)
{
  if (get() == IntPtr.Zero || domain.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_unbind_params_insert_domain(copy(), domain.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public set union(set set2)
{
  if (get() == IntPtr.Zero || set2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_union(copy(), set2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public union_set union(union_set uset2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_set(get()).union(uset2);
}

 public set union(basic_set set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.union(new set(set2));
}

 public set union(point set2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.union(new set(set2));
}

 public static set universe(space space)
{
  if (space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_universe(space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public basic_set unshifted_simple_hull()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_unshifted_simple_hull(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new basic_set(res);
}

 public map unwrap()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_unwrap(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public set upper_bound(multi_pw_aff upper)
{
  if (get() == IntPtr.Zero || upper.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_upper_bound_multi_pw_aff(copy(), upper.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set upper_bound(multi_val upper)
{
  if (get() == IntPtr.Zero || upper.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_upper_bound_multi_val(copy(), upper.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set upper_bound_si(dim_type type, uint pos, int value)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_upper_bound_si(copy(), type, pos, value);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set upper_bound_val(dim_type type, uint pos, val value)
{
  if (get() == IntPtr.Zero || value.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_upper_bound_val(copy(), type, pos, value.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set upper_bound_val(dim_type type, uint pos, long value)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.upper_bound_val(type, pos, new val(ctx.Instance, value));
}

 public map wrapped_domain_map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_wrapped_domain_map(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public set wrapped_reverse()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_wrapped_reverse(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

public override string ToString(){
  var str = Interop.isl_set_to_str(get());
  return str;
}
}

public class set_list : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal set_list(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

 public /* explicit */ set_list(ctx ctx, int n)
{
  var res = Interop.isl_set_list_alloc(ctx.get(), n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ set_list(set el)
{
  if (el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_list_from_set(el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ set_list(ctx ctx, string str)
{
  var res = Interop.isl_set_list_read_from_str(ctx.get(), str);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

public void Dispose() {
  if (!is_null()) {
    Interop.isl_set_list_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_set_list_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public set_list add(set el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_list_add(copy(), el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set_list(res);
}

 public set at(int index)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_list_get_at(get(), index);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public set_list clear()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_list_clear(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set_list(res);
}

 public set_list concat(set_list list2)
{
  if (get() == IntPtr.Zero || list2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_list_concat(copy(), list2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set_list(res);
}

 public set_list drop(uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_list_drop(copy(), first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set_list(res);
}

 public void Foreach(Action<set> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Action<set> func,  Exception? eptr) fn_data = (func: fn, eptr: null);
Func<IntPtr, IntPtr, isl_stat> fn_lambda = (IntPtr arg_0, IntPtr arg_1) => {
    try {
      fn_data.func(new (arg_0));
      return isl_stat.Ok;
    } catch (Exception e) {
      throw e;
      return isl_stat.Error;
    }
  };
  var res = Interop.isl_set_list_foreach(get(), fn_lambda, IntPtr.Zero);
  if (fn_data.eptr is not null) {
    throw fn_data.eptr;
  }
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return;
}

 public void foreach_scc(Func<set, set, bool> follows, Action<set_list> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Func<set, set, bool> func,  Exception? eptr) follows_data = (func: follows, eptr: null);
Func<IntPtr, IntPtr, IntPtr, isl_bool> follows_lambda = (IntPtr arg_0, IntPtr arg_1, IntPtr arg_2) => {
    try {
      var ret = follows_data.func(new (arg_0), new (arg_1));
      return ret ? isl_bool.True : isl_bool.False;
    } catch (Exception e) {
      throw e;
      return isl_bool.Error;
    }
  };
 (Action<set_list> func,  Exception? eptr) fn_data = (func: fn, eptr: null);
Func<IntPtr, IntPtr, isl_stat> fn_lambda = (IntPtr arg_0, IntPtr arg_1) => {
    try {
      fn_data.func(new (arg_0));
      return isl_stat.Ok;
    } catch (Exception e) {
      throw e;
      return isl_stat.Error;
    }
  };
  var res = Interop.isl_set_list_foreach_scc(get(), follows_lambda, IntPtr.Zero, fn_lambda, IntPtr.Zero);
  if (follows_data.eptr is not null) {
    throw follows_data.eptr;
  }
  if (fn_data.eptr is not null) {
    throw fn_data.eptr;
  }
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return;
}

 public set_list insert(uint pos, set el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_list_insert(copy(), pos, el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set_list(res);
}

 public set_list set_at(int index, set el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_list_set_at(copy(), index, el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set_list(res);
}

 public int size()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_list_size(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

 public set union()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_set_list_union(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

public override string ToString(){
  var str = Interop.isl_set_list_to_str(get());
  return str;
}
}

public class space : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal space(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

 public /* explicit */ space(ctx ctx, string str)
{
  var res = Interop.isl_space_read_from_str(ctx.get(), str);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

public void Dispose() {
  if (!is_null()) {
    Interop.isl_space_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_space_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public space add_dims(dim_type type, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_add_dims(copy(), type, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public space add_named_tuple(id tuple_id, uint dim)
{
  if (get() == IntPtr.Zero || tuple_id.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_add_named_tuple_id_ui(copy(), tuple_id.copy(), dim);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public space add_named_tuple(string tuple_id, uint dim)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.add_named_tuple(new id(ctx.Instance, tuple_id), dim);
}

 public space add_param(id id)
{
  if (get() == IntPtr.Zero || id.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_add_param_id(copy(), id.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public space add_param(string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.add_param(new id(ctx.Instance, id));
}

 public space add_unnamed_tuple(uint dim)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_add_unnamed_tuple_ui(copy(), dim);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public space curry()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_curry(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public space domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_domain(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public space domain_factor_domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_domain_factor_domain(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public space domain_factor_range()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_domain_factor_range(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public space domain_map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_domain_map(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public multi_aff domain_map_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_domain_map_multi_aff(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_aff(res);
}

 public pw_multi_aff domain_map_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_domain_map_pw_multi_aff(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public space domain_product(space right)
{
  if (get() == IntPtr.Zero || right.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_domain_product(copy(), right.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public space domain_reverse()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_domain_reverse(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public id domain_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_get_domain_tuple_id(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new id(res);
}

 public space domain_wrapped_domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_domain_wrapped_domain(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public space domain_wrapped_range()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_domain_wrapped_range(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public space drop_all_params()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_drop_all_params(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public space drop_dims(dim_type type, uint first, uint num)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_drop_dims(copy(), type, first, num);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public space factor_domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_factor_domain(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public space factor_range()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_factor_range(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public space flatten_domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_flatten_domain(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public space flatten_range()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_flatten_range(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public space from_domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_from_domain(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public space from_range()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_from_range(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public bool has_domain_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_has_domain_tuple_id(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool has_range_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_has_range_tuple_id(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public multi_aff identity_multi_aff_on_domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_identity_multi_aff_on_domain(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_aff(res);
}

 public multi_pw_aff identity_multi_pw_aff_on_domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_identity_multi_pw_aff_on_domain(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public pw_multi_aff identity_pw_multi_aff_on_domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_identity_pw_multi_aff_on_domain(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public space insert_dims(dim_type type, uint pos, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_insert_dims(copy(), type, pos, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public bool is_equal(space space2)
{
  if (get() == IntPtr.Zero || space2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_is_equal(get(), space2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_wrapping()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_is_wrapping(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public space join(space right)
{
  if (get() == IntPtr.Zero || right.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_join(copy(), right.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public space map_from_domain_and_range(space range)
{
  if (get() == IntPtr.Zero || range.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_map_from_domain_and_range(copy(), range.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public space map_from_set()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_map_from_set(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public space move_dims(dim_type dst_type, uint dst_pos, dim_type src_type, uint src_pos, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_move_dims(copy(), dst_type, dst_pos, src_type, src_pos, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public multi_aff multi_aff(aff_list list)
{
  if (get() == IntPtr.Zero || list.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_multi_aff(copy(), list.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_aff(res);
}

 public multi_aff multi_aff_on_domain(multi_val mv)
{
  if (get() == IntPtr.Zero || mv.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_multi_aff_on_domain_multi_val(copy(), mv.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_aff(res);
}

 public multi_id multi_id(id_list list)
{
  if (get() == IntPtr.Zero || list.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_multi_id(copy(), list.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_id(res);
}

 public multi_pw_aff multi_pw_aff(pw_aff_list list)
{
  if (get() == IntPtr.Zero || list.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_multi_pw_aff(copy(), list.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public multi_union_pw_aff multi_union_pw_aff(union_pw_aff_list list)
{
  if (get() == IntPtr.Zero || list.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_multi_union_pw_aff(copy(), list.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_union_pw_aff(res);
}

 public multi_val multi_val(val_list list)
{
  if (get() == IntPtr.Zero || list.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_multi_val(copy(), list.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_val(res);
}

 public aff param_aff_on_domain(id id)
{
  if (get() == IntPtr.Zero || id.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_param_aff_on_domain_id(copy(), id.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new aff(res);
}

 public aff param_aff_on_domain(string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.param_aff_on_domain(new id(ctx.Instance, id));
}

 public space paramss()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_params(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public space product(space right)
{
  if (get() == IntPtr.Zero || right.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_product(copy(), right.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public space range()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_range(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public space range_factor_domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_range_factor_domain(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public space range_factor_range()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_range_factor_range(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public space range_map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_range_map(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public multi_aff range_map_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_range_map_multi_aff(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_aff(res);
}

 public pw_multi_aff range_map_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_range_map_pw_multi_aff(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public space range_product(space right)
{
  if (get() == IntPtr.Zero || right.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_range_product(copy(), right.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public space range_reverse()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_range_reverse(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public id range_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_get_range_tuple_id(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new id(res);
}

 public space range_wrapped_domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_range_wrapped_domain(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public space range_wrapped_range()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_range_wrapped_range(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public space reverse()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_reverse(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public space set_domain_tuple(id id)
{
  if (get() == IntPtr.Zero || id.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_set_domain_tuple_id(copy(), id.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public space set_domain_tuple(string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.set_domain_tuple(new id(ctx.Instance, id));
}

 public space set_range_tuple(id id)
{
  if (get() == IntPtr.Zero || id.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_set_range_tuple_id(copy(), id.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public space set_range_tuple(string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.set_range_tuple(new id(ctx.Instance, id));
}

 public space uncurry()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_uncurry(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public static space unit(ctx ctx)
{
  var res = Interop.isl_space_unit(ctx.get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public map universe_map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_universe_map(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public set universe_set()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_universe_set(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public space unwrap()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_unwrap(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public space wrap()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_wrap(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public space wrapped_reverse()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_wrapped_reverse(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public aff zero_aff_on_domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_zero_aff_on_domain(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new aff(res);
}

 public multi_aff zero_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_zero_multi_aff(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_aff(res);
}

 public multi_pw_aff zero_multi_pw_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_zero_multi_pw_aff(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_pw_aff(res);
}

 public multi_union_pw_aff zero_multi_union_pw_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_zero_multi_union_pw_aff(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_union_pw_aff(res);
}

 public multi_val zero_multi_val()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_space_zero_multi_val(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_val(res);
}

public override string ToString(){
  var str = Interop.isl_space_to_str(get());
  return str;
}
}

public class union_access_info : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal union_access_info(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

 public /* explicit */ union_access_info(union_map sink)
{
  if (sink.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_access_info_from_sink(sink.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

public void Dispose() {
  if (!is_null()) {
    Interop.isl_union_access_info_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_union_access_info_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public union_flow compute_flow()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_access_info_compute_flow(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_flow(res);
}

 public union_access_info set_kill(union_map kill)
{
  if (get() == IntPtr.Zero || kill.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_access_info_set_kill(copy(), kill.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_access_info(res);
}

 public union_access_info set_may_source(union_map may_source)
{
  if (get() == IntPtr.Zero || may_source.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_access_info_set_may_source(copy(), may_source.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_access_info(res);
}

 public union_access_info set_must_source(union_map must_source)
{
  if (get() == IntPtr.Zero || must_source.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_access_info_set_must_source(copy(), must_source.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_access_info(res);
}

 public union_access_info set_schedule(schedule schedule)
{
  if (get() == IntPtr.Zero || schedule.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_access_info_set_schedule(copy(), schedule.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_access_info(res);
}

 public union_access_info set_schedule_map(union_map schedule_map)
{
  if (get() == IntPtr.Zero || schedule_map.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_access_info_set_schedule_map(copy(), schedule_map.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_access_info(res);
}

public override string ToString(){
  var str = Interop.isl_union_access_info_to_str(get());
  return str;
}
}

public class union_flow : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal union_flow(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

public void Dispose() {
  if (!is_null()) {
    Interop.isl_union_flow_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_union_flow_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public union_map full_may_dependence()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_flow_get_full_may_dependence(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map full_must_dependence()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_flow_get_full_must_dependence(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map may_dependence()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_flow_get_may_dependence(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map may_no_source()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_flow_get_may_no_source(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map must_dependence()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_flow_get_must_dependence(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map must_no_source()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_flow_get_must_no_source(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

public override string ToString(){
  var str = Interop.isl_union_flow_to_str(get());
  return str;
}
}

public class union_map : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal union_map(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

 public /* implicit */ union_map(basic_map bmap)
{
  if (bmap.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_from_basic_map(bmap.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* implicit */ union_map(map map)
{
  if (map.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_from_map(map.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ union_map(ctx ctx, string str)
{
  var res = Interop.isl_union_map_read_from_str(ctx.get(), str);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

public void Dispose() {
  if (!is_null()) {
    Interop.isl_union_map_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_union_map_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public union_map affine_hull()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_affine_hull(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map apply_domain(union_map umap2)
{
  if (get() == IntPtr.Zero || umap2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_apply_domain(copy(), umap2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map apply_range(union_map umap2)
{
  if (get() == IntPtr.Zero || umap2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_apply_range(copy(), umap2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public map as_map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_as_map(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public multi_union_pw_aff as_multi_union_pw_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_as_multi_union_pw_aff(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_union_pw_aff(res);
}

 public union_pw_multi_aff as_union_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_as_union_pw_multi_aff(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_multi_aff(res);
}

 public union_set bind_range(multi_id tuple)
{
  if (get() == IntPtr.Zero || tuple.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_bind_range(copy(), tuple.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set(res);
}

 public union_map coalesce()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_coalesce(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map compute_divs()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_compute_divs(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map curry()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_curry(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_set deltas()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_deltas(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set(res);
}

 public union_map detect_equalities()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_detect_equalities(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_set domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_domain(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set(res);
}

 public union_map domain_factor_domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_domain_factor_domain(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map domain_factor_range()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_domain_factor_range(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map domain_map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_domain_map(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_pw_multi_aff domain_map_union_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_domain_map_union_pw_multi_aff(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_multi_aff(res);
}

 public union_map domain_product(union_map umap2)
{
  if (get() == IntPtr.Zero || umap2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_domain_product(copy(), umap2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map domain_reverse()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_domain_reverse(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map drop_unused_params()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_drop_unused_params(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public static union_map empty(ctx ctx)
{
  var res = Interop.isl_union_map_empty_ctx(ctx.get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map eq_at(multi_union_pw_aff mupa)
{
  if (get() == IntPtr.Zero || mupa.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_eq_at_multi_union_pw_aff(copy(), mupa.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public bool every_map(Func<map, bool> test)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Func<map, bool> func,  Exception? eptr) test_data = (func: test, eptr: null);
Func<IntPtr, IntPtr, isl_bool> test_lambda = (IntPtr arg_0, IntPtr arg_1) => {
    try {
      var ret = test_data.func(new (arg_0));
      return ret ? isl_bool.True : isl_bool.False;
    } catch (Exception e) {
      throw e;
      return isl_bool.Error;
    }
  };
  var res = Interop.isl_union_map_every_map(get(), test_lambda, IntPtr.Zero);
  if (test_data.eptr is not null) {
    throw test_data.eptr;
  }
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public map extract_map(space space)
{
  if (get() == IntPtr.Zero || space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_extract_map(get(), space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map(res);
}

 public union_map factor_domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_factor_domain(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map factor_range()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_factor_range(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map fixed_power(val exp)
{
  if (get() == IntPtr.Zero || exp.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_fixed_power_val(copy(), exp.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map fixed_power(long exp)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.fixed_power(new val(ctx.Instance, exp));
}

 public void foreach_map(Action<map> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Action<map> func,  Exception? eptr) fn_data = (func: fn, eptr: null);
Func<IntPtr, IntPtr, isl_stat> fn_lambda = (IntPtr arg_0, IntPtr arg_1) => {
    try {
      fn_data.func(new (arg_0));
      return isl_stat.Ok;
    } catch (Exception e) {
      throw e;
      return isl_stat.Error;
    }
  };
  var res = Interop.isl_union_map_foreach_map(get(), fn_lambda, IntPtr.Zero);
  if (fn_data.eptr is not null) {
    throw fn_data.eptr;
  }
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return;
}

 public static union_map from(multi_union_pw_aff mupa)
{
  if (mupa.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_from_multi_union_pw_aff(mupa.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public static union_map from(union_pw_multi_aff upma)
{
  if (upma.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_from_union_pw_multi_aff(upma.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public static union_map from_domain(union_set uset)
{
  if (uset.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_from_domain(uset.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public static union_map from_domain_and_range(union_set domain, union_set range)
{
  if (domain.is_null() || range.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_from_domain_and_range(domain.copy(), range.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public static union_map from_range(union_set uset)
{
  if (uset.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_from_range(uset.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map gist(union_map context)
{
  if (get() == IntPtr.Zero || context.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_gist(copy(), context.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map gist_domain(union_set uset)
{
  if (get() == IntPtr.Zero || uset.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_gist_domain(copy(), uset.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map gist_params(set set)
{
  if (get() == IntPtr.Zero || set.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_gist_params(copy(), set.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map gist_range(union_set uset)
{
  if (get() == IntPtr.Zero || uset.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_gist_range(copy(), uset.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map intersect(union_map umap2)
{
  if (get() == IntPtr.Zero || umap2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_intersect(copy(), umap2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map intersect_domain(space space)
{
  if (get() == IntPtr.Zero || space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_intersect_domain_space(copy(), space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map intersect_domain(union_set uset)
{
  if (get() == IntPtr.Zero || uset.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_intersect_domain_union_set(copy(), uset.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map intersect_domain_factor_domain(union_map factor)
{
  if (get() == IntPtr.Zero || factor.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_intersect_domain_factor_domain(copy(), factor.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map intersect_domain_factor_range(union_map factor)
{
  if (get() == IntPtr.Zero || factor.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_intersect_domain_factor_range(copy(), factor.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map intersect_domain_wrapped_domain(union_set domain)
{
  if (get() == IntPtr.Zero || domain.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_intersect_domain_wrapped_domain_union_set(copy(), domain.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map intersect_params(set set)
{
  if (get() == IntPtr.Zero || set.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_intersect_params(copy(), set.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map intersect_range(space space)
{
  if (get() == IntPtr.Zero || space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_intersect_range_space(copy(), space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map intersect_range(union_set uset)
{
  if (get() == IntPtr.Zero || uset.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_intersect_range_union_set(copy(), uset.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map intersect_range_factor_domain(union_map factor)
{
  if (get() == IntPtr.Zero || factor.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_intersect_range_factor_domain(copy(), factor.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map intersect_range_factor_range(union_map factor)
{
  if (get() == IntPtr.Zero || factor.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_intersect_range_factor_range(copy(), factor.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map intersect_range_wrapped_domain(union_set domain)
{
  if (get() == IntPtr.Zero || domain.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_intersect_range_wrapped_domain_union_set(copy(), domain.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public bool is_bijective()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_is_bijective(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_disjoint(union_map umap2)
{
  if (get() == IntPtr.Zero || umap2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_is_disjoint(get(), umap2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_empty()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_is_empty(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_equal(union_map umap2)
{
  if (get() == IntPtr.Zero || umap2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_is_equal(get(), umap2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_injective()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_is_injective(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_single_valued()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_is_single_valued(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_strict_subset(union_map umap2)
{
  if (get() == IntPtr.Zero || umap2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_is_strict_subset(get(), umap2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_subset(union_map umap2)
{
  if (get() == IntPtr.Zero || umap2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_is_subset(get(), umap2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool isa_map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_isa_map(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public union_map lexmax()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_lexmax(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map lexmin()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_lexmin(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public map_list map_list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_get_map_list(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new map_list(res);
}

 public set paramss()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_params(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public union_map polyhedral_hull()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_polyhedral_hull(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map preimage_domain(multi_aff ma)
{
  if (get() == IntPtr.Zero || ma.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_preimage_domain_multi_aff(copy(), ma.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map preimage_domain(multi_pw_aff mpa)
{
  if (get() == IntPtr.Zero || mpa.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_preimage_domain_multi_pw_aff(copy(), mpa.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map preimage_domain(pw_multi_aff pma)
{
  if (get() == IntPtr.Zero || pma.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_preimage_domain_pw_multi_aff(copy(), pma.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map preimage_domain(union_pw_multi_aff upma)
{
  if (get() == IntPtr.Zero || upma.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_preimage_domain_union_pw_multi_aff(copy(), upma.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map preimage_range(multi_aff ma)
{
  if (get() == IntPtr.Zero || ma.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_preimage_range_multi_aff(copy(), ma.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map preimage_range(pw_multi_aff pma)
{
  if (get() == IntPtr.Zero || pma.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_preimage_range_pw_multi_aff(copy(), pma.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map preimage_range(union_pw_multi_aff upma)
{
  if (get() == IntPtr.Zero || upma.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_preimage_range_union_pw_multi_aff(copy(), upma.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map product(union_map umap2)
{
  if (get() == IntPtr.Zero || umap2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_product(copy(), umap2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map project_out_all_params()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_project_out_all_params(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map project_out_param(id id)
{
  if (get() == IntPtr.Zero || id.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_project_out_param_id(copy(), id.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map project_out_param(string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.project_out_param(new id(ctx.Instance, id));
}

 public union_map project_out_param(id_list list)
{
  if (get() == IntPtr.Zero || list.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_project_out_param_id_list(copy(), list.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_set range()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_range(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set(res);
}

 public union_map range_factor_domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_range_factor_domain(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map range_factor_range()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_range_factor_range(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map range_map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_range_map(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map range_product(union_map umap2)
{
  if (get() == IntPtr.Zero || umap2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_range_product(copy(), umap2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map range_reverse()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_range_reverse(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map reverse()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_reverse(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public space space()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_get_space(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public union_map subtract(union_map umap2)
{
  if (get() == IntPtr.Zero || umap2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_subtract(copy(), umap2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map subtract_domain(union_set dom)
{
  if (get() == IntPtr.Zero || dom.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_subtract_domain(copy(), dom.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map subtract_range(union_set dom)
{
  if (get() == IntPtr.Zero || dom.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_subtract_range(copy(), dom.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map uncurry()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_uncurry(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map union(union_map umap2)
{
  if (get() == IntPtr.Zero || umap2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_union(copy(), umap2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_map universe()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_universe(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_set wrap()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_wrap(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set(res);
}

 public union_map zip()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_map_zip(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

public override string ToString(){
  var str = Interop.isl_union_map_to_str(get());
  return str;
}
}

public class union_pw_aff : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal union_pw_aff(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

 public /* implicit */ union_pw_aff(aff aff)
{
  if (aff.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_aff_from_aff(aff.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* implicit */ union_pw_aff(pw_aff pa)
{
  if (pa.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_aff_from_pw_aff(pa.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ union_pw_aff(ctx ctx, string str)
{
  var res = Interop.isl_union_pw_aff_read_from_str(ctx.get(), str);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

public void Dispose() {
  if (!is_null()) {
    Interop.isl_union_pw_aff_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_union_pw_aff_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public multi_union_pw_aff add(multi_union_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_union_pw_aff(get()).add(multi2);
}

 public union_pw_aff add(union_pw_aff upa2)
{
  if (get() == IntPtr.Zero || upa2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_aff_add(copy(), upa2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_aff(res);
}

 public union_pw_multi_aff add(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).add(upma2);
}

 public union_pw_aff add(aff upa2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.add(new union_pw_aff(upa2));
}

 public union_pw_aff add(pw_aff upa2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.add(new union_pw_aff(upa2));
}

 public union_pw_multi_aff apply(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).apply(upma2);
}

 public multi_union_pw_aff as_multi_union_pw_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).as_multi_union_pw_aff();
}

 public pw_multi_aff as_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).as_pw_multi_aff();
}

 public union_map as_union_map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).as_union_map();
}

 public union_pw_aff at(int pos)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_union_pw_aff(get()).at(pos);
}

 public union_set bind(multi_id tuple)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_union_pw_aff(get()).bind(tuple);
}

 public union_set bind(id id)
{
  if (get() == IntPtr.Zero || id.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_aff_bind_id(copy(), id.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set(res);
}

 public union_set bind(string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.bind(new id(ctx.Instance, id));
}

 public union_pw_aff coalesce()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_aff_coalesce(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_aff(res);
}

 public union_set domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_aff_domain(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set(res);
}

 public union_pw_aff drop_unused_params()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_aff_drop_unused_params(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_aff(res);
}

 public pw_multi_aff extract_pw_multi_aff(space space)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).extract_pw_multi_aff(space);
}

 public multi_union_pw_aff flat_range_product(multi_union_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_union_pw_aff(get()).flat_range_product(multi2);
}

 public union_pw_multi_aff flat_range_product(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).flat_range_product(upma2);
}

 public union_pw_aff gist(union_set context)
{
  if (get() == IntPtr.Zero || context.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_aff_gist(copy(), context.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_aff(res);
}

 public multi_union_pw_aff gist_params(set context)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_union_pw_aff(get()).gist_params(context);
}

 public bool has_range_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_union_pw_aff(get()).has_range_tuple_id();
}

 public union_pw_aff intersect_domain(space space)
{
  if (get() == IntPtr.Zero || space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_aff_intersect_domain_space(copy(), space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_aff(res);
}

 public union_pw_aff intersect_domain(union_set uset)
{
  if (get() == IntPtr.Zero || uset.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_aff_intersect_domain_union_set(copy(), uset.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_aff(res);
}

 public union_pw_aff intersect_domain_wrapped_domain(union_set uset)
{
  if (get() == IntPtr.Zero || uset.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_aff_intersect_domain_wrapped_domain(copy(), uset.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_aff(res);
}

 public union_pw_aff intersect_domain_wrapped_range(union_set uset)
{
  if (get() == IntPtr.Zero || uset.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_aff_intersect_domain_wrapped_range(copy(), uset.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_aff(res);
}

 public union_pw_aff intersect_params(set set)
{
  if (get() == IntPtr.Zero || set.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_aff_intersect_params(copy(), set.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_aff(res);
}

 public bool involves_locals()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).involves_locals();
}

 public bool involves_nan()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_union_pw_aff(get()).involves_nan();
}

 public bool isa_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).isa_pw_multi_aff();
}

 public union_pw_aff_list list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_union_pw_aff(get()).list();
}

 public multi_union_pw_aff neg()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_union_pw_aff(get()).neg();
}

 public bool plain_is_empty()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).plain_is_empty();
}

 public bool plain_is_equal(multi_union_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_union_pw_aff(get()).plain_is_equal(multi2);
}

 public bool plain_is_equal(union_pw_aff upa2)
{
  if (get() == IntPtr.Zero || upa2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_aff_plain_is_equal(get(), upa2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool plain_is_equal(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).plain_is_equal(upma2);
}

 public bool plain_is_equal(aff upa2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.plain_is_equal(new union_pw_aff(upa2));
}

 public bool plain_is_equal(pw_aff upa2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.plain_is_equal(new union_pw_aff(upa2));
}

 public union_pw_multi_aff preimage_domain_wrapped_domain(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).preimage_domain_wrapped_domain(upma2);
}

 public union_pw_aff pullback(union_pw_multi_aff upma)
{
  if (get() == IntPtr.Zero || upma.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_aff_pullback_union_pw_multi_aff(copy(), upma.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_aff(res);
}

 public pw_multi_aff_list pw_multi_aff_list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).pw_multi_aff_list();
}

 public union_pw_multi_aff range_factor_domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).range_factor_domain();
}

 public union_pw_multi_aff range_factor_range()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).range_factor_range();
}

 public multi_union_pw_aff range_product(multi_union_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_union_pw_aff(get()).range_product(multi2);
}

 public union_pw_multi_aff range_product(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).range_product(upma2);
}

 public id range_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_union_pw_aff(get()).range_tuple_id();
}

 public multi_union_pw_aff reset_range_tuple_id()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_union_pw_aff(get()).reset_range_tuple_id();
}

 public multi_union_pw_aff scale(multi_val mv)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_union_pw_aff(get()).scale(mv);
}

 public multi_union_pw_aff scale(val v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_union_pw_aff(get()).scale(v);
}

 public multi_union_pw_aff scale(long v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.scale(new val(ctx.Instance, v));
}

 public multi_union_pw_aff scale_down(multi_val mv)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_union_pw_aff(get()).scale_down(mv);
}

 public multi_union_pw_aff scale_down(val v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_union_pw_aff(get()).scale_down(v);
}

 public multi_union_pw_aff scale_down(long v)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.scale_down(new val(ctx.Instance, v));
}

 public multi_union_pw_aff set_at(int pos, union_pw_aff el)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_union_pw_aff(get()).set_at(pos, el);
}

 public multi_union_pw_aff set_range_tuple(id id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_union_pw_aff(get()).set_range_tuple(id);
}

 public multi_union_pw_aff set_range_tuple(string id)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.set_range_tuple(new id(ctx.Instance, id));
}

 public int size()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_union_pw_aff(get()).size();
}

 public space space()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_aff_get_space(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public multi_union_pw_aff sub(multi_union_pw_aff multi2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_union_pw_aff(get()).sub(multi2);
}

 public union_pw_aff sub(union_pw_aff upa2)
{
  if (get() == IntPtr.Zero || upa2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_aff_sub(copy(), upa2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_aff(res);
}

 public union_pw_multi_aff sub(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).sub(upma2);
}

 public union_pw_aff sub(aff upa2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.sub(new union_pw_aff(upa2));
}

 public union_pw_aff sub(pw_aff upa2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.sub(new union_pw_aff(upa2));
}

 public union_pw_aff subtract_domain(space space)
{
  if (get() == IntPtr.Zero || space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_aff_subtract_domain_space(copy(), space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_aff(res);
}

 public union_pw_aff subtract_domain(union_set uset)
{
  if (get() == IntPtr.Zero || uset.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_aff_subtract_domain_union_set(copy(), uset.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_aff(res);
}

 public union_pw_aff_list to_list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_aff_to_list(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_aff_list(res);
}

 public multi_union_pw_aff union_add(multi_union_pw_aff mupa2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new multi_union_pw_aff(get()).union_add(mupa2);
}

 public union_pw_aff union_add(union_pw_aff upa2)
{
  if (get() == IntPtr.Zero || upa2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_aff_union_add(copy(), upa2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_aff(res);
}

 public union_pw_multi_aff union_add(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return new union_pw_multi_aff(get()).union_add(upma2);
}

 public union_pw_aff union_add(aff upa2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.union_add(new union_pw_aff(upa2));
}

 public union_pw_aff union_add(pw_aff upa2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.union_add(new union_pw_aff(upa2));
}

public override string ToString(){
  var str = Interop.isl_union_pw_aff_to_str(get());
  return str;
}
}

public class union_pw_aff_list : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal union_pw_aff_list(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

 public /* explicit */ union_pw_aff_list(ctx ctx, int n)
{
  var res = Interop.isl_union_pw_aff_list_alloc(ctx.get(), n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ union_pw_aff_list(union_pw_aff el)
{
  if (el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_aff_list_from_union_pw_aff(el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ union_pw_aff_list(ctx ctx, string str)
{
  var res = Interop.isl_union_pw_aff_list_read_from_str(ctx.get(), str);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

public void Dispose() {
  if (!is_null()) {
    Interop.isl_union_pw_aff_list_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_union_pw_aff_list_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public union_pw_aff_list add(union_pw_aff el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_aff_list_add(copy(), el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_aff_list(res);
}

 public union_pw_aff at(int index)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_aff_list_get_at(get(), index);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_aff(res);
}

 public union_pw_aff_list clear()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_aff_list_clear(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_aff_list(res);
}

 public union_pw_aff_list concat(union_pw_aff_list list2)
{
  if (get() == IntPtr.Zero || list2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_aff_list_concat(copy(), list2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_aff_list(res);
}

 public union_pw_aff_list drop(uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_aff_list_drop(copy(), first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_aff_list(res);
}

 public void Foreach(Action<union_pw_aff> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Action<union_pw_aff> func,  Exception? eptr) fn_data = (func: fn, eptr: null);
Func<IntPtr, IntPtr, isl_stat> fn_lambda = (IntPtr arg_0, IntPtr arg_1) => {
    try {
      fn_data.func(new (arg_0));
      return isl_stat.Ok;
    } catch (Exception e) {
      throw e;
      return isl_stat.Error;
    }
  };
  var res = Interop.isl_union_pw_aff_list_foreach(get(), fn_lambda, IntPtr.Zero);
  if (fn_data.eptr is not null) {
    throw fn_data.eptr;
  }
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return;
}

 public void foreach_scc(Func<union_pw_aff, union_pw_aff, bool> follows, Action<union_pw_aff_list> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Func<union_pw_aff, union_pw_aff, bool> func,  Exception? eptr) follows_data = (func: follows, eptr: null);
Func<IntPtr, IntPtr, IntPtr, isl_bool> follows_lambda = (IntPtr arg_0, IntPtr arg_1, IntPtr arg_2) => {
    try {
      var ret = follows_data.func(new (arg_0), new (arg_1));
      return ret ? isl_bool.True : isl_bool.False;
    } catch (Exception e) {
      throw e;
      return isl_bool.Error;
    }
  };
 (Action<union_pw_aff_list> func,  Exception? eptr) fn_data = (func: fn, eptr: null);
Func<IntPtr, IntPtr, isl_stat> fn_lambda = (IntPtr arg_0, IntPtr arg_1) => {
    try {
      fn_data.func(new (arg_0));
      return isl_stat.Ok;
    } catch (Exception e) {
      throw e;
      return isl_stat.Error;
    }
  };
  var res = Interop.isl_union_pw_aff_list_foreach_scc(get(), follows_lambda, IntPtr.Zero, fn_lambda, IntPtr.Zero);
  if (follows_data.eptr is not null) {
    throw follows_data.eptr;
  }
  if (fn_data.eptr is not null) {
    throw fn_data.eptr;
  }
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return;
}

 public union_pw_aff_list insert(uint pos, union_pw_aff el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_aff_list_insert(copy(), pos, el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_aff_list(res);
}

 public union_pw_aff_list set_at(int index, union_pw_aff el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_aff_list_set_at(copy(), index, el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_aff_list(res);
}

 public int size()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_aff_list_size(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

public override string ToString(){
  var str = Interop.isl_union_pw_aff_list_to_str(get());
  return str;
}
}

public class union_pw_multi_aff : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal union_pw_multi_aff(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

 public /* implicit */ union_pw_multi_aff(multi_aff ma)
{
  if (ma.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_multi_aff_from_multi_aff(ma.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* implicit */ union_pw_multi_aff(pw_multi_aff pma)
{
  if (pma.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_multi_aff_from_pw_multi_aff(pma.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* implicit */ union_pw_multi_aff(union_pw_aff upa)
{
  if (upa.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_multi_aff_from_union_pw_aff(upa.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ union_pw_multi_aff(ctx ctx, string str)
{
  var res = Interop.isl_union_pw_multi_aff_read_from_str(ctx.get(), str);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

public void Dispose() {
  if (!is_null()) {
    Interop.isl_union_pw_multi_aff_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_union_pw_multi_aff_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public union_pw_multi_aff add(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero || upma2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_multi_aff_add(copy(), upma2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_multi_aff(res);
}

 public union_pw_multi_aff apply(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero || upma2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_multi_aff_apply_union_pw_multi_aff(copy(), upma2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_multi_aff(res);
}

 public multi_union_pw_aff as_multi_union_pw_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_multi_aff_as_multi_union_pw_aff(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new multi_union_pw_aff(res);
}

 public pw_multi_aff as_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_multi_aff_as_pw_multi_aff(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public union_map as_union_map()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_multi_aff_as_union_map(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_pw_multi_aff coalesce()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_multi_aff_coalesce(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_multi_aff(res);
}

 public union_set domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_multi_aff_domain(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set(res);
}

 public union_pw_multi_aff drop_unused_params()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_multi_aff_drop_unused_params(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_multi_aff(res);
}

 public static union_pw_multi_aff empty(ctx ctx)
{
  var res = Interop.isl_union_pw_multi_aff_empty_ctx(ctx.get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_multi_aff(res);
}

 public pw_multi_aff extract_pw_multi_aff(space space)
{
  if (get() == IntPtr.Zero || space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_multi_aff_extract_pw_multi_aff(get(), space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff(res);
}

 public union_pw_multi_aff flat_range_product(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero || upma2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_multi_aff_flat_range_product(copy(), upma2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_multi_aff(res);
}

 public union_pw_multi_aff gist(union_set context)
{
  if (get() == IntPtr.Zero || context.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_multi_aff_gist(copy(), context.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_multi_aff(res);
}

 public union_pw_multi_aff intersect_domain(space space)
{
  if (get() == IntPtr.Zero || space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_multi_aff_intersect_domain_space(copy(), space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_multi_aff(res);
}

 public union_pw_multi_aff intersect_domain(union_set uset)
{
  if (get() == IntPtr.Zero || uset.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_multi_aff_intersect_domain_union_set(copy(), uset.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_multi_aff(res);
}

 public union_pw_multi_aff intersect_domain_wrapped_domain(union_set uset)
{
  if (get() == IntPtr.Zero || uset.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_multi_aff_intersect_domain_wrapped_domain(copy(), uset.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_multi_aff(res);
}

 public union_pw_multi_aff intersect_domain_wrapped_range(union_set uset)
{
  if (get() == IntPtr.Zero || uset.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_multi_aff_intersect_domain_wrapped_range(copy(), uset.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_multi_aff(res);
}

 public union_pw_multi_aff intersect_params(set set)
{
  if (get() == IntPtr.Zero || set.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_multi_aff_intersect_params(copy(), set.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_multi_aff(res);
}

 public bool involves_locals()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_multi_aff_involves_locals(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool isa_pw_multi_aff()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_multi_aff_isa_pw_multi_aff(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool plain_is_empty()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_multi_aff_plain_is_empty(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool plain_is_equal(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero || upma2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_multi_aff_plain_is_equal(get(), upma2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public union_pw_multi_aff preimage_domain_wrapped_domain(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero || upma2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_multi_aff_preimage_domain_wrapped_domain_union_pw_multi_aff(copy(), upma2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_multi_aff(res);
}

 public union_pw_multi_aff pullback(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero || upma2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_multi_aff_pullback_union_pw_multi_aff(copy(), upma2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_multi_aff(res);
}

 public pw_multi_aff_list pw_multi_aff_list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_multi_aff_get_pw_multi_aff_list(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new pw_multi_aff_list(res);
}

 public union_pw_multi_aff range_factor_domain()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_multi_aff_range_factor_domain(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_multi_aff(res);
}

 public union_pw_multi_aff range_factor_range()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_multi_aff_range_factor_range(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_multi_aff(res);
}

 public union_pw_multi_aff range_product(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero || upma2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_multi_aff_range_product(copy(), upma2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_multi_aff(res);
}

 public space space()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_multi_aff_get_space(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public union_pw_multi_aff sub(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero || upma2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_multi_aff_sub(copy(), upma2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_multi_aff(res);
}

 public union_pw_multi_aff subtract_domain(space space)
{
  if (get() == IntPtr.Zero || space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_multi_aff_subtract_domain_space(copy(), space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_multi_aff(res);
}

 public union_pw_multi_aff subtract_domain(union_set uset)
{
  if (get() == IntPtr.Zero || uset.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_multi_aff_subtract_domain_union_set(copy(), uset.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_multi_aff(res);
}

 public union_pw_multi_aff union_add(union_pw_multi_aff upma2)
{
  if (get() == IntPtr.Zero || upma2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_pw_multi_aff_union_add(copy(), upma2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_pw_multi_aff(res);
}

public override string ToString(){
  var str = Interop.isl_union_pw_multi_aff_to_str(get());
  return str;
}
}

public class union_set : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal union_set(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

 public /* implicit */ union_set(basic_set bset)
{
  if (bset.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_from_basic_set(bset.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* implicit */ union_set(point pnt)
{
  if (pnt.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_from_point(pnt.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* implicit */ union_set(set set)
{
  if (set.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_from_set(set.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ union_set(ctx ctx, string str)
{
  var res = Interop.isl_union_set_read_from_str(ctx.get(), str);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

public void Dispose() {
  if (!is_null()) {
    Interop.isl_union_set_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_union_set_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public union_set affine_hull()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_affine_hull(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set(res);
}

 public union_set apply(union_map umap)
{
  if (get() == IntPtr.Zero || umap.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_apply(copy(), umap.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set(res);
}

 public set as_set()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_as_set(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public union_set coalesce()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_coalesce(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set(res);
}

 public union_set compute_divs()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_compute_divs(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set(res);
}

 public union_set detect_equalities()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_detect_equalities(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set(res);
}

 public union_set drop_unused_params()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_drop_unused_params(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set(res);
}

 public static union_set empty(ctx ctx)
{
  var res = Interop.isl_union_set_empty_ctx(ctx.get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set(res);
}

 public bool every_set(Func<set, bool> test)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Func<set, bool> func,  Exception? eptr) test_data = (func: test, eptr: null);
Func<IntPtr, IntPtr, isl_bool> test_lambda = (IntPtr arg_0, IntPtr arg_1) => {
    try {
      var ret = test_data.func(new (arg_0));
      return ret ? isl_bool.True : isl_bool.False;
    } catch (Exception e) {
      throw e;
      return isl_bool.Error;
    }
  };
  var res = Interop.isl_union_set_every_set(get(), test_lambda, IntPtr.Zero);
  if (test_data.eptr is not null) {
    throw test_data.eptr;
  }
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public set extract_set(space space)
{
  if (get() == IntPtr.Zero || space.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_extract_set(get(), space.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public void foreach_point(Action<point> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Action<point> func,  Exception? eptr) fn_data = (func: fn, eptr: null);
Func<IntPtr, IntPtr, isl_stat> fn_lambda = (IntPtr arg_0, IntPtr arg_1) => {
    try {
      fn_data.func(new (arg_0));
      return isl_stat.Ok;
    } catch (Exception e) {
      throw e;
      return isl_stat.Error;
    }
  };
  var res = Interop.isl_union_set_foreach_point(get(), fn_lambda, IntPtr.Zero);
  if (fn_data.eptr is not null) {
    throw fn_data.eptr;
  }
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return;
}

 public void foreach_set(Action<set> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Action<set> func,  Exception? eptr) fn_data = (func: fn, eptr: null);
Func<IntPtr, IntPtr, isl_stat> fn_lambda = (IntPtr arg_0, IntPtr arg_1) => {
    try {
      fn_data.func(new (arg_0));
      return isl_stat.Ok;
    } catch (Exception e) {
      throw e;
      return isl_stat.Error;
    }
  };
  var res = Interop.isl_union_set_foreach_set(get(), fn_lambda, IntPtr.Zero);
  if (fn_data.eptr is not null) {
    throw fn_data.eptr;
  }
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return;
}

 public union_set gist(union_set context)
{
  if (get() == IntPtr.Zero || context.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_gist(copy(), context.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set(res);
}

 public union_set gist_params(set set)
{
  if (get() == IntPtr.Zero || set.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_gist_params(copy(), set.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set(res);
}

 public union_map identity()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_identity(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

 public union_set intersect(union_set uset2)
{
  if (get() == IntPtr.Zero || uset2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_intersect(copy(), uset2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set(res);
}

 public union_set intersect_params(set set)
{
  if (get() == IntPtr.Zero || set.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_intersect_params(copy(), set.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set(res);
}

 public bool is_disjoint(union_set uset2)
{
  if (get() == IntPtr.Zero || uset2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_is_disjoint(get(), uset2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_empty()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_is_empty(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_equal(union_set uset2)
{
  if (get() == IntPtr.Zero || uset2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_is_equal(get(), uset2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_strict_subset(union_set uset2)
{
  if (get() == IntPtr.Zero || uset2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_is_strict_subset(get(), uset2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_subset(union_set uset2)
{
  if (get() == IntPtr.Zero || uset2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_is_subset(get(), uset2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool isa_set()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_isa_set(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public union_set lexmax()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_lexmax(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set(res);
}

 public union_set lexmin()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_lexmin(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set(res);
}

 public set paramss()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_params(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set(res);
}

 public union_set polyhedral_hull()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_polyhedral_hull(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set(res);
}

 public union_set preimage(multi_aff ma)
{
  if (get() == IntPtr.Zero || ma.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_preimage_multi_aff(copy(), ma.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set(res);
}

 public union_set preimage(pw_multi_aff pma)
{
  if (get() == IntPtr.Zero || pma.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_preimage_pw_multi_aff(copy(), pma.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set(res);
}

 public union_set preimage(union_pw_multi_aff upma)
{
  if (get() == IntPtr.Zero || upma.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_preimage_union_pw_multi_aff(copy(), upma.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set(res);
}

 public union_set project_out_all_params()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_project_out_all_params(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set(res);
}

 public point sample_point()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_sample_point(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new point(res);
}

 public set_list set_list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_get_set_list(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new set_list(res);
}

 public space space()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_get_space(get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new space(res);
}

 public union_set subtract(union_set uset2)
{
  if (get() == IntPtr.Zero || uset2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_subtract(copy(), uset2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set(res);
}

 public union_set_list to_list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_to_list(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set_list(res);
}

 public union_set union(union_set uset2)
{
  if (get() == IntPtr.Zero || uset2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_union(copy(), uset2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set(res);
}

 public union_set universe()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_universe(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set(res);
}

 public union_map unwrap()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_unwrap(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_map(res);
}

public override string ToString(){
  var str = Interop.isl_union_set_to_str(get());
  return str;
}
}

public class union_set_list : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal union_set_list(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

 public /* explicit */ union_set_list(ctx ctx, int n)
{
  var res = Interop.isl_union_set_list_alloc(ctx.get(), n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ union_set_list(union_set el)
{
  if (el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_list_from_union_set(el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ union_set_list(ctx ctx, string str)
{
  var res = Interop.isl_union_set_list_read_from_str(ctx.get(), str);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

public void Dispose() {
  if (!is_null()) {
    Interop.isl_union_set_list_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_union_set_list_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public union_set_list add(union_set el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_list_add(copy(), el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set_list(res);
}

 public union_set at(int index)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_list_get_at(get(), index);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set(res);
}

 public union_set_list clear()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_list_clear(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set_list(res);
}

 public union_set_list concat(union_set_list list2)
{
  if (get() == IntPtr.Zero || list2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_list_concat(copy(), list2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set_list(res);
}

 public union_set_list drop(uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_list_drop(copy(), first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set_list(res);
}

 public void Foreach(Action<union_set> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Action<union_set> func,  Exception? eptr) fn_data = (func: fn, eptr: null);
Func<IntPtr, IntPtr, isl_stat> fn_lambda = (IntPtr arg_0, IntPtr arg_1) => {
    try {
      fn_data.func(new (arg_0));
      return isl_stat.Ok;
    } catch (Exception e) {
      throw e;
      return isl_stat.Error;
    }
  };
  var res = Interop.isl_union_set_list_foreach(get(), fn_lambda, IntPtr.Zero);
  if (fn_data.eptr is not null) {
    throw fn_data.eptr;
  }
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return;
}

 public void foreach_scc(Func<union_set, union_set, bool> follows, Action<union_set_list> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Func<union_set, union_set, bool> func,  Exception? eptr) follows_data = (func: follows, eptr: null);
Func<IntPtr, IntPtr, IntPtr, isl_bool> follows_lambda = (IntPtr arg_0, IntPtr arg_1, IntPtr arg_2) => {
    try {
      var ret = follows_data.func(new (arg_0), new (arg_1));
      return ret ? isl_bool.True : isl_bool.False;
    } catch (Exception e) {
      throw e;
      return isl_bool.Error;
    }
  };
 (Action<union_set_list> func,  Exception? eptr) fn_data = (func: fn, eptr: null);
Func<IntPtr, IntPtr, isl_stat> fn_lambda = (IntPtr arg_0, IntPtr arg_1) => {
    try {
      fn_data.func(new (arg_0));
      return isl_stat.Ok;
    } catch (Exception e) {
      throw e;
      return isl_stat.Error;
    }
  };
  var res = Interop.isl_union_set_list_foreach_scc(get(), follows_lambda, IntPtr.Zero, fn_lambda, IntPtr.Zero);
  if (follows_data.eptr is not null) {
    throw follows_data.eptr;
  }
  if (fn_data.eptr is not null) {
    throw fn_data.eptr;
  }
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return;
}

 public union_set_list insert(uint pos, union_set el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_list_insert(copy(), pos, el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set_list(res);
}

 public union_set_list set_at(int index, union_set el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_list_set_at(copy(), index, el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new union_set_list(res);
}

 public int size()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_union_set_list_size(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

public override string ToString(){
  var str = Interop.isl_union_set_list_to_str(get());
  return str;
}
}

public class val : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal val(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

 public /* explicit */ val(ctx ctx, long i)
{
  var res = Interop.isl_val_int_from_si(ctx.get(), i);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ val(ctx ctx, string str)
{
  var res = Interop.isl_val_read_from_str(ctx.get(), str);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

public void Dispose() {
  if (!is_null()) {
    Interop.isl_val_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_val_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public val abs()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_abs(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public bool abs_eq(val v2)
{
  if (get() == IntPtr.Zero || v2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_abs_eq(get(), v2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool abs_eq(long v2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.abs_eq(new val(ctx.Instance, v2));
}

 public val add(val v2)
{
  if (get() == IntPtr.Zero || v2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_add(copy(), v2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public val add(long v2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.add(new val(ctx.Instance, v2));
}

 public val ceil()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_ceil(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public int cmp_si(long i)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_cmp_si(get(), i);
  return res;
}

 public long den_si()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_get_den_si(get());
  return res;
}

 public val div(val v2)
{
  if (get() == IntPtr.Zero || v2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_div(copy(), v2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public val div(long v2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.div(new val(ctx.Instance, v2));
}

 public bool eq(val v2)
{
  if (get() == IntPtr.Zero || v2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_eq(get(), v2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool eq(long v2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.eq(new val(ctx.Instance, v2));
}

 public val floor()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_floor(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public val gcd(val v2)
{
  if (get() == IntPtr.Zero || v2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_gcd(copy(), v2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public val gcd(long v2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.gcd(new val(ctx.Instance, v2));
}

 public bool ge(val v2)
{
  if (get() == IntPtr.Zero || v2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_ge(get(), v2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool ge(long v2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.ge(new val(ctx.Instance, v2));
}

 public bool gt(val v2)
{
  if (get() == IntPtr.Zero || v2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_gt(get(), v2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool gt(long v2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.gt(new val(ctx.Instance, v2));
}

 public static val infty(ctx ctx)
{
  var res = Interop.isl_val_infty(ctx.get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public val inv()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_inv(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public bool is_divisible_by(val v2)
{
  if (get() == IntPtr.Zero || v2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_is_divisible_by(get(), v2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_divisible_by(long v2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.is_divisible_by(new val(ctx.Instance, v2));
}

 public bool is_infty()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_is_infty(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_int()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_is_int(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_nan()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_is_nan(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_neg()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_is_neg(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_neginfty()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_is_neginfty(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_negone()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_is_negone(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_nonneg()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_is_nonneg(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_nonpos()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_is_nonpos(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_one()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_is_one(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_pos()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_is_pos(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_rat()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_is_rat(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool is_zero()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_is_zero(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool le(val v2)
{
  if (get() == IntPtr.Zero || v2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_le(get(), v2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool le(long v2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.le(new val(ctx.Instance, v2));
}

 public bool lt(val v2)
{
  if (get() == IntPtr.Zero || v2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_lt(get(), v2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool lt(long v2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.lt(new val(ctx.Instance, v2));
}

 public val max(val v2)
{
  if (get() == IntPtr.Zero || v2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_max(copy(), v2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public val max(long v2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.max(new val(ctx.Instance, v2));
}

 public val min(val v2)
{
  if (get() == IntPtr.Zero || v2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_min(copy(), v2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public val min(long v2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.min(new val(ctx.Instance, v2));
}

 public val mod(val v2)
{
  if (get() == IntPtr.Zero || v2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_mod(copy(), v2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public val mod(long v2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.mod(new val(ctx.Instance, v2));
}

 public val mul(val v2)
{
  if (get() == IntPtr.Zero || v2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_mul(copy(), v2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public val mul(long v2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.mul(new val(ctx.Instance, v2));
}

 public static val nan(ctx ctx)
{
  var res = Interop.isl_val_nan(ctx.get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public bool ne(val v2)
{
  if (get() == IntPtr.Zero || v2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_ne(get(), v2.get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res == isl_bool.True;
}

 public bool ne(long v2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.ne(new val(ctx.Instance, v2));
}

 public val neg()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_neg(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public static val neginfty(ctx ctx)
{
  var res = Interop.isl_val_neginfty(ctx.get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public static val negone(ctx ctx)
{
  var res = Interop.isl_val_negone(ctx.get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public long num_si()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_get_num_si(get());
  return res;
}

 public static val one(ctx ctx)
{
  var res = Interop.isl_val_one(ctx.get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public val pow2()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_pow2(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public int sgn()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_sgn(get());
  return res;
}

 public val sub(val v2)
{
  if (get() == IntPtr.Zero || v2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_sub(copy(), v2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public val sub(long v2)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.sub(new val(ctx.Instance, v2));
}

 public val_list to_list()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_to_list(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val_list(res);
}

 public val trunc()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_trunc(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public static val zero(ctx ctx)
{
  var res = Interop.isl_val_zero(ctx.get());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

public override string ToString(){
  var str = Interop.isl_val_to_str(get());
  return str;
}
}

public class val_list : IDisposable, IObject {
  protected IntPtr ptr = IntPtr.Zero;
internal val_list(/* __isl_take */ IntPtr ptr)
 { this.ptr = ptr; }

 public /* explicit */ val_list(ctx ctx, int n)
{
  var res = Interop.isl_val_list_alloc(ctx.get(), n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ val_list(val el)
{
  if (el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_list_from_val(el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

 public /* explicit */ val_list(ctx ctx, string str)
{
  var res = Interop.isl_val_list_read_from_str(ctx.get(), str);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
  ptr = res;
}

public void Dispose() {
  if (!is_null()) {
    Interop.isl_val_list_free(ptr);
  }
}

public IntPtr copy() {
  return Interop.isl_val_list_copy(ptr);
}

public IntPtr get() {
  return ptr;
}

public bool is_null() {
  return ptr == IntPtr.Zero;
}

 public val_list add(val el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_list_add(copy(), el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val_list(res);
}

 public val_list add(long el)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.add(new val(ctx.Instance, el));
}

 public val at(int index)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_list_get_at(get(), index);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val(res);
}

 public val_list clear()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_list_clear(copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val_list(res);
}

 public val_list concat(val_list list2)
{
  if (get() == IntPtr.Zero || list2.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_list_concat(copy(), list2.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val_list(res);
}

 public val_list drop(uint first, uint n)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_list_drop(copy(), first, n);
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val_list(res);
}

 public void Foreach(Action<val> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Action<val> func,  Exception? eptr) fn_data = (func: fn, eptr: null);
Func<IntPtr, IntPtr, isl_stat> fn_lambda = (IntPtr arg_0, IntPtr arg_1) => {
    try {
      fn_data.func(new (arg_0));
      return isl_stat.Ok;
    } catch (Exception e) {
      throw e;
      return isl_stat.Error;
    }
  };
  var res = Interop.isl_val_list_foreach(get(), fn_lambda, IntPtr.Zero);
  if (fn_data.eptr is not null) {
    throw fn_data.eptr;
  }
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return;
}

 public void foreach_scc(Func<val, val, bool> follows, Action<val_list> fn)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
 (Func<val, val, bool> func,  Exception? eptr) follows_data = (func: follows, eptr: null);
Func<IntPtr, IntPtr, IntPtr, isl_bool> follows_lambda = (IntPtr arg_0, IntPtr arg_1, IntPtr arg_2) => {
    try {
      var ret = follows_data.func(new (arg_0), new (arg_1));
      return ret ? isl_bool.True : isl_bool.False;
    } catch (Exception e) {
      throw e;
      return isl_bool.Error;
    }
  };
 (Action<val_list> func,  Exception? eptr) fn_data = (func: fn, eptr: null);
Func<IntPtr, IntPtr, isl_stat> fn_lambda = (IntPtr arg_0, IntPtr arg_1) => {
    try {
      fn_data.func(new (arg_0));
      return isl_stat.Ok;
    } catch (Exception e) {
      throw e;
      return isl_stat.Error;
    }
  };
  var res = Interop.isl_val_list_foreach_scc(get(), follows_lambda, IntPtr.Zero, fn_lambda, IntPtr.Zero);
  if (follows_data.eptr is not null) {
    throw follows_data.eptr;
  }
  if (fn_data.eptr is not null) {
    throw fn_data.eptr;
  }
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return;
}

 public val_list insert(uint pos, val el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_list_insert(copy(), pos, el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val_list(res);
}

 public val_list insert(uint pos, long el)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.insert(pos, new val(ctx.Instance, el));
}

 public val_list set_at(int index, val el)
{
  if (get() == IntPtr.Zero || el.is_null()) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_list_set_at(copy(), index, el.copy());
  if (res == IntPtr.Zero) {
    throw new InvalidOperationException();
  }
return new val_list(res);
}

 public val_list set_at(int index, long el)
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");
  }
  return this.set_at(index, new val(ctx.Instance, el));
}

 public int size()
{
  if (get() == IntPtr.Zero) {
    throw new ArgumentNullException("NULL input");

  }
  var res = Interop.isl_val_list_size(get());
  if (res < 0) {
    throw new InvalidOperationException();
  }
  return res;
}

public override string ToString(){
  var str = Interop.isl_val_list_to_str(get());
  return str;
}
}
internal static partial class Interop {
[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_read_from_str(IntPtr ctx, [MarshalAs(UnmanagedType.LPStr)] string str);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_add(IntPtr aff1, IntPtr aff2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_add_constant_val(IntPtr aff, IntPtr v);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_bind_id(IntPtr aff, IntPtr id);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_ceil(IntPtr aff);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_get_constant_val(IntPtr aff);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_div(IntPtr aff1, IntPtr aff2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_domain_reverse(IntPtr aff);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_eq_set(IntPtr aff1, IntPtr aff2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_eval(IntPtr aff, IntPtr pnt);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_floor(IntPtr aff);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_ge_set(IntPtr aff1, IntPtr aff2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_gist(IntPtr aff, IntPtr context);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_gist_params(IntPtr aff, IntPtr context);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_gt_set(IntPtr aff1, IntPtr aff2);

[DllImport(LibraryName)]
public static extern  isl_bool isl_aff_is_cst(IntPtr aff);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_le_set(IntPtr aff1, IntPtr aff2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_lt_set(IntPtr aff1, IntPtr aff2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_mod_val(IntPtr aff, IntPtr mod);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_mul(IntPtr aff1, IntPtr aff2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_ne_set(IntPtr aff1, IntPtr aff2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_neg(IntPtr aff);

[DllImport(LibraryName)]
public static extern  isl_bool isl_aff_plain_is_equal(IntPtr aff1, IntPtr aff2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_pullback_multi_aff(IntPtr aff, IntPtr ma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_scale_val(IntPtr aff, IntPtr v);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_scale_down_val(IntPtr aff, IntPtr v);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_sub(IntPtr aff1, IntPtr aff2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_to_list(IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_unbind_params_insert_domain(IntPtr aff, IntPtr domain);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_zero_on_domain_space(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_copy(IntPtr aff);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_free(IntPtr aff);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_aff_to_str(IntPtr aff);


[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_list_alloc(IntPtr ctx, int n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_list_from_aff(IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_list_read_from_str(IntPtr ctx, [MarshalAs(UnmanagedType.LPStr)] string str);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_list_add(IntPtr list, IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_list_get_at(IntPtr list, int index);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_list_clear(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_list_concat(IntPtr list1, IntPtr list2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_list_drop(IntPtr list, uint first, uint n);

[DllImport(LibraryName)]
public static extern  isl_stat isl_aff_list_foreach(IntPtr list, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, isl_stat> fn, IntPtr user);

[DllImport(LibraryName)]
public static extern  isl_stat isl_aff_list_foreach_scc(IntPtr list, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, IntPtr, isl_bool> follows, IntPtr follows_user, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, isl_stat> fn, IntPtr fn_user);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_list_insert(IntPtr list, uint pos, IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_list_set_at(IntPtr list, int index, IntPtr el);

[DllImport(LibraryName)]
public static extern  int isl_aff_list_size(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_list_copy(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_aff_list_free(IntPtr list);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_aff_list_to_str(IntPtr list);


[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_build_alloc(IntPtr ctx);

[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_build_set_at_each_domain(IntPtr build, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, IntPtr, IntPtr> fn, IntPtr user);

[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_build_access_from_multi_pw_aff(IntPtr build, IntPtr mpa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_build_access_from_pw_multi_aff(IntPtr build, IntPtr pma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_build_call_from_multi_pw_aff(IntPtr build, IntPtr mpa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_build_call_from_pw_multi_aff(IntPtr build, IntPtr pma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_build_expr_from_pw_aff(IntPtr build, IntPtr pa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_build_expr_from_set(IntPtr build, IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_build_from_context(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_build_node_from_schedule(IntPtr build, IntPtr schedule);

[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_build_node_from_schedule_map(IntPtr build, IntPtr schedule);

[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_build_get_schedule(IntPtr build);

[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_build_copy(IntPtr build);

[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_build_free(IntPtr build);


[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_ast_expr_to_C_str(IntPtr expr);

[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_expr_copy(IntPtr expr);

[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_expr_free(IntPtr expr);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_ast_expr_to_str(IntPtr expr);

[DllImport(LibraryName)]
public static extern  ast_expr_type isl_ast_expr_get_type(IntPtr expr);


[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_expr_id_get_id(IntPtr expr);


[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_expr_int_get_val(IntPtr expr);


[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_expr_op_get_arg(IntPtr expr, int pos);

[DllImport(LibraryName)]
public static extern  int isl_ast_expr_op_get_n_arg(IntPtr expr);

[DllImport(LibraryName)]
public static extern  ast_expr_op_type isl_ast_expr_op_get_type(IntPtr expr);




























[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_node_map_descendant_bottom_up(IntPtr node, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, IntPtr> fn, IntPtr user);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_ast_node_to_C_str(IntPtr node);

[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_node_to_list(IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_node_copy(IntPtr node);

[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_node_free(IntPtr node);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_ast_node_to_str(IntPtr node);

[DllImport(LibraryName)]
public static extern  ast_node_type isl_ast_node_get_type(IntPtr node);


[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_node_block_from_children(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_node_block_get_children(IntPtr node);


[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_node_for_get_body(IntPtr node);

[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_node_for_get_cond(IntPtr node);

[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_node_for_get_inc(IntPtr node);

[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_node_for_get_init(IntPtr node);

[DllImport(LibraryName)]
public static extern  isl_bool isl_ast_node_for_is_degenerate(IntPtr node);

[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_node_for_get_iterator(IntPtr node);


[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_node_if_get_cond(IntPtr node);

[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_node_if_get_else_node(IntPtr node);

[DllImport(LibraryName)]
public static extern  isl_bool isl_ast_node_if_has_else_node(IntPtr node);

[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_node_if_get_then_node(IntPtr node);


[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_node_list_alloc(IntPtr ctx, int n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_node_list_from_ast_node(IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_node_list_add(IntPtr list, IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_node_list_get_at(IntPtr list, int index);

[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_node_list_clear(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_node_list_concat(IntPtr list1, IntPtr list2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_node_list_drop(IntPtr list, uint first, uint n);

[DllImport(LibraryName)]
public static extern  isl_stat isl_ast_node_list_foreach(IntPtr list, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, isl_stat> fn, IntPtr user);

[DllImport(LibraryName)]
public static extern  isl_stat isl_ast_node_list_foreach_scc(IntPtr list, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, IntPtr, isl_bool> follows, IntPtr follows_user, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, isl_stat> fn, IntPtr fn_user);

[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_node_list_insert(IntPtr list, uint pos, IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_node_list_set_at(IntPtr list, int index, IntPtr el);

[DllImport(LibraryName)]
public static extern  int isl_ast_node_list_size(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_node_list_copy(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_node_list_free(IntPtr list);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_ast_node_list_to_str(IntPtr list);


[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_node_mark_get_id(IntPtr node);

[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_node_mark_get_node(IntPtr node);


[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_node_user_from_expr(IntPtr expr);

[DllImport(LibraryName)]
public static extern  IntPtr isl_ast_node_user_get_expr(IntPtr node);


[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_read_from_str(IntPtr ctx, [MarshalAs(UnmanagedType.LPStr)] string str);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_add_constraint(IntPtr bmap, IntPtr constraint);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_add_dims(IntPtr bmap, dim_type type, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_affine_hull(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_align_params(IntPtr bmap, IntPtr model);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_apply_domain(IntPtr bmap1, IntPtr bmap2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_apply_range(IntPtr bmap1, IntPtr bmap2);

[DllImport(LibraryName)]
public static extern  isl_bool isl_basic_map_can_curry(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  isl_bool isl_basic_map_can_uncurry(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  isl_bool isl_basic_map_can_zip(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_compute_divs(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_get_constraint_list(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_curry(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_deltas(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_deltas_map(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_detect_equalities(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  int isl_basic_map_dim(IntPtr bmap, dim_type type);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_get_dim_name(IntPtr bmap, dim_type type, uint pos);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_get_div(IntPtr bmap, int pos);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_domain(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_domain_map(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_drop_constraints_involving_dims(IntPtr bmap, dim_type type, uint first, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_drop_constraints_not_involving_dims(IntPtr bmap, dim_type type, uint first, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_drop_unused_params(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_eliminate(IntPtr bmap, dim_type type, uint first, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_empty(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_equalities_matrix(IntPtr bmap, dim_type c1, dim_type c2, dim_type c3, dim_type c4, dim_type c5);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_equate(IntPtr bmap, dim_type type1, int pos1, dim_type type2, int pos2);

[DllImport(LibraryName)]
public static extern  int isl_basic_map_find_dim_by_name(IntPtr bmap, dim_type type, [MarshalAs(UnmanagedType.LPStr)] string name);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_fix_si(IntPtr bmap, dim_type type, uint pos, int value);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_fix_val(IntPtr bmap, dim_type type, uint pos, IntPtr v);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_flat_product(IntPtr bmap1, IntPtr bmap2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_flat_range_product(IntPtr bmap1, IntPtr bmap2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_flatten(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_flatten_domain(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_flatten_range(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  isl_stat isl_basic_map_foreach_constraint(IntPtr bmap, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, isl_stat> fn, IntPtr user);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_from_aff(IntPtr aff);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_from_aff_list(IntPtr domain_space, IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_from_constraint(IntPtr constraint);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_from_constraint_matrices(IntPtr space, IntPtr eq, IntPtr ineq, dim_type c1, dim_type c2, dim_type c3, dim_type c4, dim_type c5);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_from_domain(IntPtr bset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_from_domain_and_range(IntPtr domain, IntPtr range);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_from_multi_aff(IntPtr maff);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_from_range(IntPtr bset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_gist(IntPtr bmap, IntPtr context);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_gist_domain(IntPtr bmap, IntPtr context);

[DllImport(LibraryName)]
public static extern  isl_bool isl_basic_map_has_dim_id(IntPtr bmap, dim_type type, uint pos);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_identity(IntPtr space);

[DllImport(LibraryName)]
public static extern  isl_bool isl_basic_map_image_is_bounded(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_inequalities_matrix(IntPtr bmap, dim_type c1, dim_type c2, dim_type c3, dim_type c4, dim_type c5);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_insert_dims(IntPtr bmap, dim_type type, uint pos, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_intersect(IntPtr bmap1, IntPtr bmap2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_intersect_domain(IntPtr bmap, IntPtr bset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_intersect_params(IntPtr bmap, IntPtr bset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_intersect_range(IntPtr bmap, IntPtr bset);

[DllImport(LibraryName)]
public static extern  isl_bool isl_basic_map_involves_dims(IntPtr bmap, dim_type type, uint first, uint n);

[DllImport(LibraryName)]
public static extern  isl_bool isl_basic_map_is_disjoint(IntPtr bmap1, IntPtr bmap2);

[DllImport(LibraryName)]
public static extern  isl_bool isl_basic_map_is_empty(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  isl_bool isl_basic_map_is_equal(IntPtr bmap1, IntPtr bmap2);

[DllImport(LibraryName)]
public static extern  isl_bool isl_basic_map_is_rational(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  isl_bool isl_basic_map_is_single_valued(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  isl_bool isl_basic_map_is_strict_subset(IntPtr bmap1, IntPtr bmap2);

[DllImport(LibraryName)]
public static extern  isl_bool isl_basic_map_is_subset(IntPtr bmap1, IntPtr bmap2);

[DllImport(LibraryName)]
public static extern  isl_bool isl_basic_map_is_universe(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_less_at(IntPtr space, uint pos);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_lexmax(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_lexmin(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_lower_bound_si(IntPtr bmap, dim_type type, uint pos, int value);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_more_at(IntPtr space, uint pos);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_move_dims(IntPtr bmap, dim_type dst_type, uint dst_pos, dim_type src_type, uint src_pos, uint n);

[DllImport(LibraryName)]
public static extern  int isl_basic_map_n_constraint(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_nat_universe(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_neg(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_order_ge(IntPtr bmap, dim_type type1, int pos1, dim_type type2, int pos2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_order_gt(IntPtr bmap, dim_type type1, int pos1, dim_type type2, int pos2);

[DllImport(LibraryName)]
public static extern  isl_bool isl_basic_map_plain_is_empty(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  isl_bool isl_basic_map_plain_is_universe(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_project_out(IntPtr bmap, dim_type type, uint first, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_range(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_range_map(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_remove_dims(IntPtr bmap, dim_type type, uint first, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_remove_divs(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_remove_divs_involving_dims(IntPtr bmap, dim_type type, uint first, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_remove_redundancies(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_reverse(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_sample(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_set_dim_name(IntPtr bmap, dim_type type, uint pos, [MarshalAs(UnmanagedType.LPStr)] string s);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_set_tuple_id(IntPtr bmap, dim_type type, IntPtr id);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_set_tuple_name(IntPtr bmap, dim_type type, [MarshalAs(UnmanagedType.LPStr)] string s);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_get_space(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_sum(IntPtr bmap1, IntPtr bmap2);

[DllImport(LibraryName)]
public static extern  int isl_basic_map_total_dim(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_get_tuple_name(IntPtr bmap, dim_type type);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_uncurry(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_union(IntPtr bmap1, IntPtr bmap2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_universe(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_upper_bound_si(IntPtr bmap, dim_type type, uint pos, int value);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_zip(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_copy(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_free(IntPtr bmap);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_basic_map_to_str(IntPtr bmap);


[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_list_copy(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_map_list_free(IntPtr list);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_basic_map_list_to_str(IntPtr list);


[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_from_point(IntPtr pnt);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_read_from_str(IntPtr ctx, [MarshalAs(UnmanagedType.LPStr)] string str);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_add_constraint(IntPtr bset, IntPtr constraint);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_add_dims(IntPtr bset, dim_type type, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_affine_hull(IntPtr bset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_align_params(IntPtr bset, IntPtr model);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_apply(IntPtr bset, IntPtr bmap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_box_from_points(IntPtr pnt1, IntPtr pnt2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_coefficients(IntPtr bset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_compute_divs(IntPtr bset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_get_constraint_list(IntPtr bset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_detect_equalities(IntPtr bset);

[DllImport(LibraryName)]
public static extern  int isl_basic_set_dim(IntPtr bset, dim_type type);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_get_dim_id(IntPtr bset, dim_type type, uint pos);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_dim_max_val(IntPtr bset, int pos);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_get_dim_name(IntPtr bset, dim_type type, uint pos);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_get_div(IntPtr bset, int pos);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_drop_constraints_involving_dims(IntPtr bset, dim_type type, uint first, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_drop_constraints_not_involving_dims(IntPtr bset, dim_type type, uint first, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_drop_unused_params(IntPtr bset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_eliminate(IntPtr bset, dim_type type, uint first, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_equalities_matrix(IntPtr bset, dim_type c1, dim_type c2, dim_type c3, dim_type c4);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_fix_si(IntPtr bset, dim_type type, uint pos, int value);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_fix_val(IntPtr bset, dim_type type, uint pos, IntPtr v);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_flatten(IntPtr bset);

[DllImport(LibraryName)]
public static extern  isl_stat isl_basic_set_foreach_bound_pair(IntPtr bset, dim_type type, uint pos, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, IntPtr, IntPtr, isl_stat> fn, IntPtr user);

[DllImport(LibraryName)]
public static extern  isl_stat isl_basic_set_foreach_constraint(IntPtr bset, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, isl_stat> fn, IntPtr user);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_from_constraint(IntPtr constraint);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_from_constraint_matrices(IntPtr space, IntPtr eq, IntPtr ineq, dim_type c1, dim_type c2, dim_type c3, dim_type c4);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_from_multi_aff(IntPtr ma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_gist(IntPtr bset, IntPtr context);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_inequalities_matrix(IntPtr bset, dim_type c1, dim_type c2, dim_type c3, dim_type c4);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_insert_dims(IntPtr bset, dim_type type, uint pos, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_intersect(IntPtr bset1, IntPtr bset2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_intersect_params(IntPtr bset1, IntPtr bset2);

[DllImport(LibraryName)]
public static extern  isl_bool isl_basic_set_involves_dims(IntPtr bset, dim_type type, uint first, uint n);

[DllImport(LibraryName)]
public static extern  isl_bool isl_basic_set_is_empty(IntPtr bset);

[DllImport(LibraryName)]
public static extern  isl_bool isl_basic_set_is_equal(IntPtr bset1, IntPtr bset2);

[DllImport(LibraryName)]
public static extern  int isl_basic_set_is_rational(IntPtr bset);

[DllImport(LibraryName)]
public static extern  isl_bool isl_basic_set_is_subset(IntPtr bset1, IntPtr bset2);

[DllImport(LibraryName)]
public static extern  isl_bool isl_basic_set_is_wrapping(IntPtr bset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_lexmax(IntPtr bset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_lexmin(IntPtr bset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_lift(IntPtr bset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_get_local_space(IntPtr bset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_lower_bound_val(IntPtr bset, dim_type type, uint pos, IntPtr value);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_move_dims(IntPtr bset, dim_type dst_type, uint dst_pos, dim_type src_type, uint src_pos, uint n);

[DllImport(LibraryName)]
public static extern  int isl_basic_set_n_constraint(IntPtr bset);

[DllImport(LibraryName)]
public static extern  int isl_basic_set_n_dim(IntPtr bset);

[DllImport(LibraryName)]
public static extern  int isl_basic_set_n_param(IntPtr bset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_nat_universe(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_neg(IntPtr bset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_params(IntPtr bset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_positive_orthant(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_preimage_multi_aff(IntPtr bset, IntPtr ma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_project_out(IntPtr bset, dim_type type, uint first, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_reduced_basis(IntPtr bset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_remove_dims(IntPtr bset, dim_type type, uint first, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_remove_divs(IntPtr bset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_remove_divs_involving_dims(IntPtr bset, dim_type type, uint first, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_remove_redundancies(IntPtr bset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_remove_unknown_divs(IntPtr bset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_sample(IntPtr bset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_sample_point(IntPtr bset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_set_dim_name(IntPtr bset, dim_type type, uint pos, [MarshalAs(UnmanagedType.LPStr)] string s);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_set_tuple_id(IntPtr bset, IntPtr id);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_set_tuple_name(IntPtr set, [MarshalAs(UnmanagedType.LPStr)] string s);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_solutions(IntPtr bset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_get_space(IntPtr bset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_to_list(IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_to_set(IntPtr bset);

[DllImport(LibraryName)]
public static extern  int isl_basic_set_total_dim(IntPtr bset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_get_tuple_name(IntPtr bset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_union(IntPtr bset1, IntPtr bset2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_universe(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_unwrap(IntPtr bset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_upper_bound_val(IntPtr bset, dim_type type, uint pos, IntPtr value);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_copy(IntPtr bset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_free(IntPtr bset);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_basic_set_to_str(IntPtr bset);


[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_list_alloc(IntPtr ctx, int n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_list_from_basic_set(IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_list_add(IntPtr list, IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_list_get_at(IntPtr list, int index);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_list_clear(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_list_coefficients(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_list_concat(IntPtr list1, IntPtr list2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_list_drop(IntPtr list, uint first, uint n);

[DllImport(LibraryName)]
public static extern  isl_stat isl_basic_set_list_foreach(IntPtr list, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, isl_stat> fn, IntPtr user);

[DllImport(LibraryName)]
public static extern  isl_stat isl_basic_set_list_foreach_scc(IntPtr list, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, IntPtr, isl_bool> follows, IntPtr follows_user, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, isl_stat> fn, IntPtr fn_user);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_list_insert(IntPtr list, uint pos, IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_list_set_at(IntPtr list, int index, IntPtr el);

[DllImport(LibraryName)]
public static extern  int isl_basic_set_list_size(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_list_copy(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_basic_set_list_free(IntPtr list);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_basic_set_list_to_str(IntPtr list);


[DllImport(LibraryName)]
public static extern  IntPtr isl_constraint_get_aff(IntPtr constraint);

[DllImport(LibraryName)]
public static extern  IntPtr isl_constraint_alloc_equality(IntPtr ls);

[DllImport(LibraryName)]
public static extern  IntPtr isl_constraint_alloc_inequality(IntPtr ls);

[DllImport(LibraryName)]
public static extern  IntPtr isl_constraint_get_bound(IntPtr constraint, dim_type type, int pos);

[DllImport(LibraryName)]
public static extern  int isl_constraint_cmp_last_non_zero(IntPtr c1, IntPtr c2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_constraint_get_coefficient_val(IntPtr constraint, dim_type type, int pos);

[DllImport(LibraryName)]
public static extern  IntPtr isl_constraint_get_constant_val(IntPtr constraint);

[DllImport(LibraryName)]
public static extern  int isl_constraint_dim(IntPtr constraint, dim_type type);

[DllImport(LibraryName)]
public static extern  IntPtr isl_constraint_get_dim_name(IntPtr constraint, dim_type type, uint pos);

[DllImport(LibraryName)]
public static extern  IntPtr isl_constraint_get_div(IntPtr constraint, int pos);

[DllImport(LibraryName)]
public static extern  isl_bool isl_constraint_involves_dims(IntPtr constraint, dim_type type, uint first, uint n);

[DllImport(LibraryName)]
public static extern  isl_bool isl_constraint_is_div_constraint(IntPtr constraint);

[DllImport(LibraryName)]
public static extern  isl_bool isl_constraint_is_equality(IntPtr constraint);

[DllImport(LibraryName)]
public static extern  isl_bool isl_constraint_is_lower_bound(IntPtr constraint, dim_type type, uint pos);

[DllImport(LibraryName)]
public static extern  isl_bool isl_constraint_is_upper_bound(IntPtr constraint, dim_type type, uint pos);

[DllImport(LibraryName)]
public static extern  IntPtr isl_constraint_get_local_space(IntPtr constraint);

[DllImport(LibraryName)]
public static extern  IntPtr isl_constraint_negate(IntPtr constraint);

[DllImport(LibraryName)]
public static extern  IntPtr isl_constraint_set_coefficient_si(IntPtr constraint, dim_type type, int pos, int v);

[DllImport(LibraryName)]
public static extern  IntPtr isl_constraint_set_coefficient_val(IntPtr constraint, dim_type type, int pos, IntPtr v);

[DllImport(LibraryName)]
public static extern  IntPtr isl_constraint_set_constant_si(IntPtr constraint, int v);

[DllImport(LibraryName)]
public static extern  IntPtr isl_constraint_set_constant_val(IntPtr constraint, IntPtr v);

[DllImport(LibraryName)]
public static extern  IntPtr isl_constraint_get_space(IntPtr constraint);

[DllImport(LibraryName)]
public static extern  IntPtr isl_constraint_to_list(IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_constraint_copy(IntPtr c);

[DllImport(LibraryName)]
public static extern  IntPtr isl_constraint_free(IntPtr c);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_constraint_to_str(IntPtr c);


[DllImport(LibraryName)]
public static extern  IntPtr isl_constraint_list_alloc(IntPtr ctx, int n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_constraint_list_from_constraint(IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_constraint_list_add(IntPtr list, IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_constraint_list_get_at(IntPtr list, int index);

[DllImport(LibraryName)]
public static extern  IntPtr isl_constraint_list_clear(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_constraint_list_concat(IntPtr list1, IntPtr list2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_constraint_list_drop(IntPtr list, uint first, uint n);

[DllImport(LibraryName)]
public static extern  isl_stat isl_constraint_list_foreach(IntPtr list, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, isl_stat> fn, IntPtr user);

[DllImport(LibraryName)]
public static extern  isl_stat isl_constraint_list_foreach_scc(IntPtr list, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, IntPtr, isl_bool> follows, IntPtr follows_user, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, isl_stat> fn, IntPtr fn_user);

[DllImport(LibraryName)]
public static extern  IntPtr isl_constraint_list_insert(IntPtr list, uint pos, IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_constraint_list_set_at(IntPtr list, int index, IntPtr el);

[DllImport(LibraryName)]
public static extern  int isl_constraint_list_size(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_constraint_list_copy(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_constraint_list_free(IntPtr list);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_constraint_list_to_str(IntPtr list);


[DllImport(LibraryName)]
public static extern  IntPtr isl_fixed_box_read_from_str(IntPtr ctx, [MarshalAs(UnmanagedType.LPStr)] string str);

[DllImport(LibraryName)]
public static extern  isl_bool isl_fixed_box_is_valid(IntPtr box);

[DllImport(LibraryName)]
public static extern  IntPtr isl_fixed_box_get_offset(IntPtr box);

[DllImport(LibraryName)]
public static extern  IntPtr isl_fixed_box_get_size(IntPtr box);

[DllImport(LibraryName)]
public static extern  IntPtr isl_fixed_box_get_space(IntPtr box);

[DllImport(LibraryName)]
public static extern  IntPtr isl_fixed_box_copy(IntPtr box);

[DllImport(LibraryName)]
public static extern  IntPtr isl_fixed_box_free(IntPtr box);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_fixed_box_to_str(IntPtr box);


[DllImport(LibraryName)]
public static extern  IntPtr isl_id_read_from_str(IntPtr ctx, [MarshalAs(UnmanagedType.LPStr)] string str);

[DllImport(LibraryName)]
public static extern  IntPtr isl_id_get_name(IntPtr id);

[DllImport(LibraryName)]
public static extern  IntPtr isl_id_to_list(IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_id_copy(IntPtr id);

[DllImport(LibraryName)]
public static extern  IntPtr isl_id_free(IntPtr id);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_id_to_str(IntPtr id);


[DllImport(LibraryName)]
public static extern  IntPtr isl_id_list_alloc(IntPtr ctx, int n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_id_list_from_id(IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_id_list_read_from_str(IntPtr ctx, [MarshalAs(UnmanagedType.LPStr)] string str);

[DllImport(LibraryName)]
public static extern  IntPtr isl_id_list_add(IntPtr list, IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_id_list_get_at(IntPtr list, int index);

[DllImport(LibraryName)]
public static extern  IntPtr isl_id_list_clear(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_id_list_concat(IntPtr list1, IntPtr list2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_id_list_drop(IntPtr list, uint first, uint n);

[DllImport(LibraryName)]
public static extern  isl_stat isl_id_list_foreach(IntPtr list, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, isl_stat> fn, IntPtr user);

[DllImport(LibraryName)]
public static extern  isl_stat isl_id_list_foreach_scc(IntPtr list, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, IntPtr, isl_bool> follows, IntPtr follows_user, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, isl_stat> fn, IntPtr fn_user);

[DllImport(LibraryName)]
public static extern  IntPtr isl_id_list_insert(IntPtr list, uint pos, IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_id_list_set_at(IntPtr list, int index, IntPtr el);

[DllImport(LibraryName)]
public static extern  int isl_id_list_size(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_id_list_copy(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_id_list_free(IntPtr list);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_id_list_to_str(IntPtr list);


[DllImport(LibraryName)]
public static extern  IntPtr isl_id_to_ast_expr_alloc(IntPtr ctx, int min_size);

[DllImport(LibraryName)]
public static extern  IntPtr isl_id_to_ast_expr_read_from_str(IntPtr ctx, [MarshalAs(UnmanagedType.LPStr)] string str);

[DllImport(LibraryName)]
public static extern  isl_bool isl_id_to_ast_expr_is_equal(IntPtr hmap1, IntPtr hmap2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_id_to_ast_expr_set(IntPtr hmap, IntPtr key, IntPtr val);

[DllImport(LibraryName)]
public static extern  IntPtr isl_id_to_ast_expr_copy(IntPtr hmap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_id_to_ast_expr_free(IntPtr hmap);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_id_to_ast_expr_to_str(IntPtr hmap);


[DllImport(LibraryName)]
public static extern  IntPtr isl_id_to_id_alloc(IntPtr ctx, int min_size);

[DllImport(LibraryName)]
public static extern  IntPtr isl_id_to_id_read_from_str(IntPtr ctx, [MarshalAs(UnmanagedType.LPStr)] string str);

[DllImport(LibraryName)]
public static extern  isl_bool isl_id_to_id_is_equal(IntPtr hmap1, IntPtr hmap2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_id_to_id_set(IntPtr hmap, IntPtr key, IntPtr val);

[DllImport(LibraryName)]
public static extern  IntPtr isl_id_to_id_copy(IntPtr hmap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_id_to_id_free(IntPtr hmap);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_id_to_id_to_str(IntPtr hmap);


[DllImport(LibraryName)]
public static extern  IntPtr isl_local_space_add_dims(IntPtr ls, dim_type type, uint n);

[DllImport(LibraryName)]
public static extern  int isl_local_space_dim(IntPtr ls, dim_type type);

[DllImport(LibraryName)]
public static extern  IntPtr isl_local_space_get_dim_id(IntPtr ls, dim_type type, uint pos);

[DllImport(LibraryName)]
public static extern  IntPtr isl_local_space_get_dim_name(IntPtr ls, dim_type type, uint pos);

[DllImport(LibraryName)]
public static extern  IntPtr isl_local_space_get_div(IntPtr ls, int pos);

[DllImport(LibraryName)]
public static extern  IntPtr isl_local_space_domain(IntPtr ls);

[DllImport(LibraryName)]
public static extern  IntPtr isl_local_space_drop_dims(IntPtr ls, dim_type type, uint first, uint n);

[DllImport(LibraryName)]
public static extern  int isl_local_space_find_dim_by_name(IntPtr ls, dim_type type, [MarshalAs(UnmanagedType.LPStr)] string name);

[DllImport(LibraryName)]
public static extern  IntPtr isl_local_space_flatten_domain(IntPtr ls);

[DllImport(LibraryName)]
public static extern  IntPtr isl_local_space_flatten_range(IntPtr ls);

[DllImport(LibraryName)]
public static extern  IntPtr isl_local_space_from_domain(IntPtr ls);

[DllImport(LibraryName)]
public static extern  IntPtr isl_local_space_from_space(IntPtr space);

[DllImport(LibraryName)]
public static extern  isl_bool isl_local_space_has_dim_id(IntPtr ls, dim_type type, uint pos);

[DllImport(LibraryName)]
public static extern  isl_bool isl_local_space_has_dim_name(IntPtr ls, dim_type type, uint pos);

[DllImport(LibraryName)]
public static extern  IntPtr isl_local_space_insert_dims(IntPtr ls, dim_type type, uint first, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_local_space_intersect(IntPtr ls1, IntPtr ls2);

[DllImport(LibraryName)]
public static extern  isl_bool isl_local_space_is_params(IntPtr ls);

[DllImport(LibraryName)]
public static extern  isl_bool isl_local_space_is_set(IntPtr ls);

[DllImport(LibraryName)]
public static extern  IntPtr isl_local_space_lifting(IntPtr ls);

[DllImport(LibraryName)]
public static extern  IntPtr isl_local_space_range(IntPtr ls);

[DllImport(LibraryName)]
public static extern  IntPtr isl_local_space_set_dim_id(IntPtr ls, dim_type type, uint pos, IntPtr id);

[DllImport(LibraryName)]
public static extern  IntPtr isl_local_space_set_dim_name(IntPtr ls, dim_type type, uint pos, [MarshalAs(UnmanagedType.LPStr)] string s);

[DllImport(LibraryName)]
public static extern  IntPtr isl_local_space_set_from_params(IntPtr ls);

[DllImport(LibraryName)]
public static extern  IntPtr isl_local_space_set_tuple_id(IntPtr ls, dim_type type, IntPtr id);

[DllImport(LibraryName)]
public static extern  IntPtr isl_local_space_get_space(IntPtr ls);

[DllImport(LibraryName)]
public static extern  IntPtr isl_local_space_wrap(IntPtr ls);

[DllImport(LibraryName)]
public static extern  IntPtr isl_local_space_copy(IntPtr ls);

[DllImport(LibraryName)]
public static extern  IntPtr isl_local_space_free(IntPtr ls);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_local_space_to_str(IntPtr ls);


[DllImport(LibraryName)]
public static extern  IntPtr isl_map_from_basic_map(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_read_from_str(IntPtr ctx, [MarshalAs(UnmanagedType.LPStr)] string str);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_add_constraint(IntPtr map, IntPtr constraint);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_add_dims(IntPtr map, dim_type type, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_affine_hull(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_align_params(IntPtr map, IntPtr model);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_apply_domain(IntPtr map1, IntPtr map2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_apply_range(IntPtr map1, IntPtr map2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_as_pw_multi_aff(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_bind_domain(IntPtr map, IntPtr tuple);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_bind_range(IntPtr map, IntPtr tuple);

[DllImport(LibraryName)]
public static extern  isl_bool isl_map_can_curry(IntPtr map);

[DllImport(LibraryName)]
public static extern  isl_bool isl_map_can_range_curry(IntPtr map);

[DllImport(LibraryName)]
public static extern  isl_bool isl_map_can_uncurry(IntPtr map);

[DllImport(LibraryName)]
public static extern  isl_bool isl_map_can_zip(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_coalesce(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_complement(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_compute_divs(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_convex_hull(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_curry(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_deltas(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_deltas_map(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_detect_equalities(IntPtr map);

[DllImport(LibraryName)]
public static extern  int isl_map_dim(IntPtr map, dim_type type);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_get_dim_id(IntPtr map, dim_type type, uint pos);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_dim_max(IntPtr map, int pos);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_dim_min(IntPtr map, int pos);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_get_dim_name(IntPtr map, dim_type type, uint pos);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_domain(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_domain_factor_domain(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_domain_factor_range(IntPtr map);

[DllImport(LibraryName)]
public static extern  isl_bool isl_map_domain_is_wrapping(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_domain_map(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_domain_product(IntPtr map1, IntPtr map2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_domain_reverse(IntPtr map);

[DllImport(LibraryName)]
public static extern  int isl_map_domain_tuple_dim(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_get_domain_tuple_id(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_drop_constraints_involving_dims(IntPtr map, dim_type type, uint first, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_drop_constraints_not_involving_dims(IntPtr map, dim_type type, uint first, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_drop_unused_params(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_eliminate(IntPtr map, dim_type type, uint first, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_empty(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_eq_at_multi_pw_aff(IntPtr map, IntPtr mpa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_equate(IntPtr map, dim_type type1, int pos1, dim_type type2, int pos2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_factor_domain(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_factor_range(IntPtr map);

[DllImport(LibraryName)]
public static extern  int isl_map_find_dim_by_id(IntPtr map, dim_type type, IntPtr id);

[DllImport(LibraryName)]
public static extern  int isl_map_find_dim_by_name(IntPtr map, dim_type type, [MarshalAs(UnmanagedType.LPStr)] string name);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_fix_input_si(IntPtr map, uint input, int value);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_fix_si(IntPtr map, dim_type type, uint pos, int value);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_fix_val(IntPtr map, dim_type type, uint pos, IntPtr v);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_fixed_power_val(IntPtr map, IntPtr exp);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_flat_domain_product(IntPtr map1, IntPtr map2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_flat_product(IntPtr map1, IntPtr map2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_flat_range_product(IntPtr map1, IntPtr map2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_flatten(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_flatten_domain(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_flatten_range(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_floordiv_val(IntPtr map, IntPtr d);

[DllImport(LibraryName)]
public static extern  isl_stat isl_map_foreach_basic_map(IntPtr map, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, isl_stat> fn, IntPtr user);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_from_aff(IntPtr aff);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_from_domain(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_from_domain_and_range(IntPtr domain, IntPtr range);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_from_multi_aff(IntPtr maff);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_from_range(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_gist(IntPtr map, IntPtr context);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_gist_basic_map(IntPtr map, IntPtr context);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_gist_domain(IntPtr map, IntPtr context);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_gist_params(IntPtr map, IntPtr context);

[DllImport(LibraryName)]
public static extern  isl_bool isl_map_has_dim_id(IntPtr map, dim_type type, uint pos);

[DllImport(LibraryName)]
public static extern  isl_bool isl_map_has_dim_name(IntPtr map, dim_type type, uint pos);

[DllImport(LibraryName)]
public static extern  isl_bool isl_map_has_domain_tuple_id(IntPtr map);

[DllImport(LibraryName)]
public static extern  isl_bool isl_map_has_equal_space(IntPtr map1, IntPtr map2);

[DllImport(LibraryName)]
public static extern  isl_bool isl_map_has_range_tuple_id(IntPtr map);

[DllImport(LibraryName)]
public static extern  isl_bool isl_map_has_tuple_name(IntPtr map, dim_type type);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_identity(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_insert_dims(IntPtr map, dim_type type, uint pos, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_intersect(IntPtr map1, IntPtr map2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_intersect_domain(IntPtr map, IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_intersect_domain_factor_domain(IntPtr map, IntPtr factor);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_intersect_domain_factor_range(IntPtr map, IntPtr factor);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_intersect_domain_wrapped_domain(IntPtr map, IntPtr domain);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_intersect_params(IntPtr map, IntPtr params_);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_intersect_range(IntPtr map, IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_intersect_range_factor_domain(IntPtr map, IntPtr factor);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_intersect_range_factor_range(IntPtr map, IntPtr factor);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_intersect_range_wrapped_domain(IntPtr map, IntPtr domain);

[DllImport(LibraryName)]
public static extern  isl_bool isl_map_involves_dims(IntPtr map, dim_type type, uint first, uint n);

[DllImport(LibraryName)]
public static extern  isl_bool isl_map_is_bijective(IntPtr map);

[DllImport(LibraryName)]
public static extern  isl_bool isl_map_is_disjoint(IntPtr map1, IntPtr map2);

[DllImport(LibraryName)]
public static extern  isl_bool isl_map_is_empty(IntPtr map);

[DllImport(LibraryName)]
public static extern  isl_bool isl_map_is_equal(IntPtr map1, IntPtr map2);

[DllImport(LibraryName)]
public static extern  isl_bool isl_map_is_identity(IntPtr map);

[DllImport(LibraryName)]
public static extern  isl_bool isl_map_is_injective(IntPtr map);

[DllImport(LibraryName)]
public static extern  isl_bool isl_map_is_product(IntPtr map);

[DllImport(LibraryName)]
public static extern  isl_bool isl_map_is_single_valued(IntPtr map);

[DllImport(LibraryName)]
public static extern  isl_bool isl_map_is_strict_subset(IntPtr map1, IntPtr map2);

[DllImport(LibraryName)]
public static extern  isl_bool isl_map_is_subset(IntPtr map1, IntPtr map2);

[DllImport(LibraryName)]
public static extern  int isl_map_is_translation(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_lex_ge(IntPtr set_space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_lex_ge_at_multi_pw_aff(IntPtr map, IntPtr mpa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_lex_ge_first(IntPtr space, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_lex_ge_map(IntPtr map1, IntPtr map2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_lex_gt(IntPtr set_space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_lex_gt_at_multi_pw_aff(IntPtr map, IntPtr mpa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_lex_gt_first(IntPtr space, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_lex_gt_map(IntPtr map1, IntPtr map2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_lex_le(IntPtr set_space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_lex_le_at_multi_pw_aff(IntPtr map, IntPtr mpa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_lex_le_first(IntPtr space, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_lex_le_map(IntPtr map1, IntPtr map2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_lex_lt(IntPtr set_space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_lex_lt_at_multi_pw_aff(IntPtr map, IntPtr mpa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_lex_lt_first(IntPtr space, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_lex_lt_map(IntPtr map1, IntPtr map2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_lexmax(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_lexmax_pw_multi_aff(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_lexmin(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_lexmin_pw_multi_aff(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_lower_bound_multi_pw_aff(IntPtr map, IntPtr lower);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_lower_bound_si(IntPtr map, dim_type type, uint pos, int value);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_lower_bound_val(IntPtr map, dim_type type, uint pos, IntPtr value);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_make_disjoint(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_max_multi_pw_aff(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_min_multi_pw_aff(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_move_dims(IntPtr map, dim_type dst_type, uint dst_pos, dim_type src_type, uint src_pos, uint n);

[DllImport(LibraryName)]
public static extern  int isl_map_n_basic_map(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_nat_universe(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_neg(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_oppose(IntPtr map, dim_type type1, int pos1, dim_type type2, int pos2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_order_ge(IntPtr map, dim_type type1, int pos1, dim_type type2, int pos2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_order_gt(IntPtr map, dim_type type1, int pos1, dim_type type2, int pos2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_order_le(IntPtr map, dim_type type1, int pos1, dim_type type2, int pos2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_order_lt(IntPtr map, dim_type type1, int pos1, dim_type type2, int pos2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_params(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_plain_get_val_if_fixed(IntPtr map, dim_type type, uint pos);

[DllImport(LibraryName)]
public static extern  isl_bool isl_map_plain_is_empty(IntPtr map);

[DllImport(LibraryName)]
public static extern  isl_bool isl_map_plain_is_injective(IntPtr map);

[DllImport(LibraryName)]
public static extern  isl_bool isl_map_plain_is_single_valued(IntPtr map);

[DllImport(LibraryName)]
public static extern  isl_bool isl_map_plain_is_universe(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_plain_unshifted_simple_hull(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_polyhedral_hull(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_preimage_domain_multi_aff(IntPtr map, IntPtr ma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_preimage_domain_multi_pw_aff(IntPtr map, IntPtr mpa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_preimage_domain_pw_multi_aff(IntPtr map, IntPtr pma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_preimage_range_multi_aff(IntPtr map, IntPtr ma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_preimage_range_pw_multi_aff(IntPtr map, IntPtr pma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_product(IntPtr map1, IntPtr map2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_project_out(IntPtr map, dim_type type, uint first, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_project_out_all_params(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_project_out_param_id(IntPtr map, IntPtr id);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_project_out_param_id_list(IntPtr map, IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_range(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_range_curry(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_range_factor_domain(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_range_factor_range(IntPtr map);

[DllImport(LibraryName)]
public static extern  isl_bool isl_map_range_is_wrapping(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_get_range_lattice_tile(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_range_map(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_range_product(IntPtr map1, IntPtr map2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_range_reverse(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_get_range_simple_fixed_box_hull(IntPtr map);

[DllImport(LibraryName)]
public static extern  int isl_map_range_tuple_dim(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_get_range_tuple_id(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_remove_dims(IntPtr map, dim_type type, uint first, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_remove_divs(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_remove_divs_involving_dims(IntPtr map, dim_type type, uint first, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_remove_inputs(IntPtr map, uint first, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_remove_redundancies(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_remove_unknown_divs(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_reverse(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_sample(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_set_dim_id(IntPtr map, dim_type type, uint pos, IntPtr id);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_set_dim_name(IntPtr map, dim_type type, uint pos, [MarshalAs(UnmanagedType.LPStr)] string s);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_set_domain_tuple_id(IntPtr map, IntPtr id);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_set_range_tuple_id(IntPtr map, IntPtr id);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_set_tuple_id(IntPtr map, dim_type type, IntPtr id);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_set_tuple_name(IntPtr map, dim_type type, [MarshalAs(UnmanagedType.LPStr)] string s);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_simple_hull(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_get_space(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_subtract(IntPtr map1, IntPtr map2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_subtract_domain(IntPtr map, IntPtr dom);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_subtract_range(IntPtr map, IntPtr dom);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_sum(IntPtr map1, IntPtr map2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_to_list(IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_to_union_map(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_get_tuple_name(IntPtr map, dim_type type);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_uncurry(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_union(IntPtr map1, IntPtr map2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_union_disjoint(IntPtr map1, IntPtr map2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_universe(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_unshifted_simple_hull(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_unshifted_simple_hull_from_map_list(IntPtr map, IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_upper_bound_multi_pw_aff(IntPtr map, IntPtr upper);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_upper_bound_si(IntPtr map, dim_type type, uint pos, int value);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_upper_bound_val(IntPtr map, dim_type type, uint pos, IntPtr value);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_wrap(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_zip(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_copy(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_free(IntPtr map);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_map_to_str(IntPtr map);


[DllImport(LibraryName)]
public static extern  IntPtr isl_map_list_alloc(IntPtr ctx, int n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_list_from_map(IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_list_read_from_str(IntPtr ctx, [MarshalAs(UnmanagedType.LPStr)] string str);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_list_add(IntPtr list, IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_list_get_at(IntPtr list, int index);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_list_clear(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_list_concat(IntPtr list1, IntPtr list2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_list_drop(IntPtr list, uint first, uint n);

[DllImport(LibraryName)]
public static extern  isl_stat isl_map_list_foreach(IntPtr list, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, isl_stat> fn, IntPtr user);

[DllImport(LibraryName)]
public static extern  isl_stat isl_map_list_foreach_scc(IntPtr list, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, IntPtr, isl_bool> follows, IntPtr follows_user, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, isl_stat> fn, IntPtr fn_user);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_list_insert(IntPtr list, uint pos, IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_list_set_at(IntPtr list, int index, IntPtr el);

[DllImport(LibraryName)]
public static extern  int isl_map_list_size(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_list_copy(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_map_list_free(IntPtr list);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_map_list_to_str(IntPtr list);


[DllImport(LibraryName)]
public static extern  IntPtr isl_mat_add_rows(IntPtr mat, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_mat_add_zero_cols(IntPtr mat, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_mat_add_zero_rows(IntPtr mat, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_mat_aff_direct_sum(IntPtr left, IntPtr right);

[DllImport(LibraryName)]
public static extern  int isl_mat_cols(IntPtr mat);

[DllImport(LibraryName)]
public static extern  IntPtr isl_mat_concat(IntPtr top, IntPtr bot);

[DllImport(LibraryName)]
public static extern  IntPtr isl_mat_diagonal(IntPtr mat1, IntPtr mat2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_mat_drop_cols(IntPtr mat, uint col, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_mat_drop_rows(IntPtr mat, uint row, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_mat_get_element_val(IntPtr mat, int row, int col);

[DllImport(LibraryName)]
public static extern  isl_bool isl_mat_has_linearly_independent_rows(IntPtr mat1, IntPtr mat2);

[DllImport(LibraryName)]
public static extern  int isl_mat_initial_non_zero_cols(IntPtr mat);

[DllImport(LibraryName)]
public static extern  IntPtr isl_mat_insert_cols(IntPtr mat, uint col, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_mat_insert_rows(IntPtr mat, uint row, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_mat_insert_zero_cols(IntPtr mat, uint first, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_mat_insert_zero_rows(IntPtr mat, uint row, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_mat_inverse_product(IntPtr left, IntPtr right);

[DllImport(LibraryName)]
public static extern  IntPtr isl_mat_lin_to_aff(IntPtr mat);

[DllImport(LibraryName)]
public static extern  IntPtr isl_mat_move_cols(IntPtr mat, uint dst_col, uint src_col, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_mat_normalize(IntPtr mat);

[DllImport(LibraryName)]
public static extern  IntPtr isl_mat_normalize_row(IntPtr mat, int row);

[DllImport(LibraryName)]
public static extern  IntPtr isl_mat_product(IntPtr left, IntPtr right);

[DllImport(LibraryName)]
public static extern  int isl_mat_rank(IntPtr mat);

[DllImport(LibraryName)]
public static extern  IntPtr isl_mat_right_inverse(IntPtr mat);

[DllImport(LibraryName)]
public static extern  IntPtr isl_mat_right_kernel(IntPtr mat);

[DllImport(LibraryName)]
public static extern  IntPtr isl_mat_row_basis(IntPtr mat);

[DllImport(LibraryName)]
public static extern  IntPtr isl_mat_row_basis_extension(IntPtr mat1, IntPtr mat2);

[DllImport(LibraryName)]
public static extern  int isl_mat_rows(IntPtr mat);

[DllImport(LibraryName)]
public static extern  IntPtr isl_mat_set_element_si(IntPtr mat, int row, int col, int v);

[DllImport(LibraryName)]
public static extern  IntPtr isl_mat_set_element_val(IntPtr mat, int row, int col, IntPtr v);

[DllImport(LibraryName)]
public static extern  IntPtr isl_mat_swap_cols(IntPtr mat, uint i, uint j);

[DllImport(LibraryName)]
public static extern  IntPtr isl_mat_swap_rows(IntPtr mat, uint i, uint j);

[DllImport(LibraryName)]
public static extern  IntPtr isl_mat_transpose(IntPtr mat);

[DllImport(LibraryName)]
public static extern  IntPtr isl_mat_unimodular_complete(IntPtr M, int row);

[DllImport(LibraryName)]
public static extern  IntPtr isl_mat_copy(IntPtr mat);

[DllImport(LibraryName)]
public static extern  IntPtr isl_mat_free(IntPtr mat);


[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_from_aff(IntPtr aff);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_from_aff_list(IntPtr space, IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_read_from_str(IntPtr ctx, [MarshalAs(UnmanagedType.LPStr)] string str);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_add(IntPtr multi1, IntPtr multi2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_add_constant_multi_val(IntPtr mpa, IntPtr mv);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_add_constant_val(IntPtr mpa, IntPtr v);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_as_map(IntPtr ma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_as_set(IntPtr ma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_get_at(IntPtr multi, int pos);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_bind(IntPtr ma, IntPtr tuple);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_bind_domain(IntPtr multi, IntPtr tuple);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_bind_domain_wrapped_domain(IntPtr multi, IntPtr tuple);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_get_constant_multi_val(IntPtr ma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_domain_map(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_domain_reverse(IntPtr multi);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_flat_range_product(IntPtr multi1, IntPtr multi2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_floor(IntPtr ma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_gist(IntPtr maff, IntPtr context);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_gist_params(IntPtr maff, IntPtr context);

[DllImport(LibraryName)]
public static extern  isl_bool isl_multi_aff_has_range_tuple_id(IntPtr multi);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_identity_multi_aff(IntPtr multi);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_identity_on_domain_space(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_insert_domain(IntPtr multi, IntPtr domain);

[DllImport(LibraryName)]
public static extern  isl_bool isl_multi_aff_involves_locals(IntPtr multi);

[DllImport(LibraryName)]
public static extern  isl_bool isl_multi_aff_involves_nan(IntPtr multi);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_get_list(IntPtr multi);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_multi_val_on_domain_space(IntPtr space, IntPtr mv);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_neg(IntPtr multi);

[DllImport(LibraryName)]
public static extern  isl_bool isl_multi_aff_plain_is_equal(IntPtr multi1, IntPtr multi2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_product(IntPtr multi1, IntPtr multi2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_pullback_multi_aff(IntPtr ma1, IntPtr ma2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_range_map(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_range_product(IntPtr multi1, IntPtr multi2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_get_range_tuple_id(IntPtr multi);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_reset_range_tuple_id(IntPtr multi);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_scale_multi_val(IntPtr multi, IntPtr mv);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_scale_val(IntPtr multi, IntPtr v);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_scale_down_multi_val(IntPtr multi, IntPtr mv);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_scale_down_val(IntPtr multi, IntPtr v);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_set_at(IntPtr multi, int pos, IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_set_range_tuple_id(IntPtr multi, IntPtr id);

[DllImport(LibraryName)]
public static extern  int isl_multi_aff_size(IntPtr multi);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_get_space(IntPtr multi);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_sub(IntPtr multi1, IntPtr multi2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_to_multi_pw_aff(IntPtr ma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_to_multi_union_pw_aff(IntPtr ma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_to_pw_multi_aff(IntPtr ma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_unbind_params_insert_domain(IntPtr multi, IntPtr domain);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_zero(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_copy(IntPtr multi);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_aff_free(IntPtr multi);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_multi_aff_to_str(IntPtr ma);


[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_id_from_id_list(IntPtr space, IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_id_read_from_str(IntPtr ctx, [MarshalAs(UnmanagedType.LPStr)] string str);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_id_get_at(IntPtr multi, int pos);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_id_flat_range_product(IntPtr multi1, IntPtr multi2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_id_get_list(IntPtr multi);

[DllImport(LibraryName)]
public static extern  isl_bool isl_multi_id_plain_is_equal(IntPtr multi1, IntPtr multi2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_id_range_product(IntPtr multi1, IntPtr multi2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_id_set_at(IntPtr multi, int pos, IntPtr el);

[DllImport(LibraryName)]
public static extern  int isl_multi_id_size(IntPtr multi);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_id_get_space(IntPtr multi);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_id_copy(IntPtr multi);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_id_free(IntPtr multi);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_multi_id_to_str(IntPtr mi);


[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_from_aff(IntPtr aff);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_from_multi_aff(IntPtr ma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_from_pw_aff(IntPtr pa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_from_pw_aff_list(IntPtr space, IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_from_pw_multi_aff(IntPtr pma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_read_from_str(IntPtr ctx, [MarshalAs(UnmanagedType.LPStr)] string str);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_add(IntPtr multi1, IntPtr multi2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_add_constant_multi_val(IntPtr mpa, IntPtr mv);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_add_constant_val(IntPtr mpa, IntPtr v);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_as_map(IntPtr mpa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_as_multi_aff(IntPtr mpa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_as_set(IntPtr mpa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_get_at(IntPtr multi, int pos);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_bind(IntPtr mpa, IntPtr tuple);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_bind_domain(IntPtr multi, IntPtr tuple);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_bind_domain_wrapped_domain(IntPtr multi, IntPtr tuple);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_coalesce(IntPtr mpa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_domain(IntPtr mpa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_domain_reverse(IntPtr multi);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_flat_range_product(IntPtr multi1, IntPtr multi2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_gist(IntPtr mpa, IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_gist_params(IntPtr mpa, IntPtr set);

[DllImport(LibraryName)]
public static extern  isl_bool isl_multi_pw_aff_has_range_tuple_id(IntPtr multi);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_identity_multi_pw_aff(IntPtr multi);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_identity_on_domain_space(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_insert_domain(IntPtr multi, IntPtr domain);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_intersect_domain(IntPtr mpa, IntPtr domain);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_intersect_params(IntPtr mpa, IntPtr set);

[DllImport(LibraryName)]
public static extern  isl_bool isl_multi_pw_aff_involves_nan(IntPtr multi);

[DllImport(LibraryName)]
public static extern  isl_bool isl_multi_pw_aff_involves_param_id(IntPtr multi, IntPtr id);

[DllImport(LibraryName)]
public static extern  isl_bool isl_multi_pw_aff_involves_param_id_list(IntPtr multi, IntPtr list);

[DllImport(LibraryName)]
public static extern  isl_bool isl_multi_pw_aff_isa_multi_aff(IntPtr mpa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_get_list(IntPtr multi);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_max(IntPtr multi1, IntPtr multi2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_max_multi_val(IntPtr mpa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_min(IntPtr multi1, IntPtr multi2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_min_multi_val(IntPtr mpa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_neg(IntPtr multi);

[DllImport(LibraryName)]
public static extern  isl_bool isl_multi_pw_aff_plain_is_equal(IntPtr multi1, IntPtr multi2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_product(IntPtr multi1, IntPtr multi2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_pullback_multi_aff(IntPtr mpa, IntPtr ma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_pullback_multi_pw_aff(IntPtr mpa1, IntPtr mpa2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_pullback_pw_multi_aff(IntPtr mpa, IntPtr pma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_range_product(IntPtr multi1, IntPtr multi2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_get_range_tuple_id(IntPtr multi);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_reset_range_tuple_id(IntPtr multi);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_scale_multi_val(IntPtr multi, IntPtr mv);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_scale_val(IntPtr multi, IntPtr v);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_scale_down_multi_val(IntPtr multi, IntPtr mv);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_scale_down_val(IntPtr multi, IntPtr v);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_set_at(IntPtr multi, int pos, IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_set_range_tuple_id(IntPtr multi, IntPtr id);

[DllImport(LibraryName)]
public static extern  int isl_multi_pw_aff_size(IntPtr multi);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_get_space(IntPtr multi);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_sub(IntPtr multi1, IntPtr multi2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_unbind_params_insert_domain(IntPtr multi, IntPtr domain);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_union_add(IntPtr mpa1, IntPtr mpa2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_zero(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_copy(IntPtr multi);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_pw_aff_free(IntPtr multi);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_multi_pw_aff_to_str(IntPtr mpa);


[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_union_pw_aff_from_multi_pw_aff(IntPtr mpa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_union_pw_aff_from_union_pw_aff(IntPtr upa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_union_pw_aff_from_union_pw_aff_list(IntPtr space, IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_union_pw_aff_read_from_str(IntPtr ctx, [MarshalAs(UnmanagedType.LPStr)] string str);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_union_pw_aff_add(IntPtr multi1, IntPtr multi2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_union_pw_aff_get_at(IntPtr multi, int pos);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_union_pw_aff_bind(IntPtr mupa, IntPtr tuple);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_union_pw_aff_coalesce(IntPtr mupa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_union_pw_aff_domain(IntPtr mupa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_union_pw_aff_flat_range_product(IntPtr multi1, IntPtr multi2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_union_pw_aff_gist(IntPtr mupa, IntPtr context);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_union_pw_aff_gist_params(IntPtr mupa, IntPtr context);

[DllImport(LibraryName)]
public static extern  isl_bool isl_multi_union_pw_aff_has_range_tuple_id(IntPtr multi);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_union_pw_aff_intersect_domain(IntPtr mupa, IntPtr uset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_union_pw_aff_intersect_params(IntPtr mupa, IntPtr params_);

[DllImport(LibraryName)]
public static extern  isl_bool isl_multi_union_pw_aff_involves_nan(IntPtr multi);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_union_pw_aff_get_list(IntPtr multi);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_union_pw_aff_neg(IntPtr multi);

[DllImport(LibraryName)]
public static extern  isl_bool isl_multi_union_pw_aff_plain_is_equal(IntPtr multi1, IntPtr multi2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_union_pw_aff_pullback_union_pw_multi_aff(IntPtr mupa, IntPtr upma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_union_pw_aff_range_product(IntPtr multi1, IntPtr multi2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_union_pw_aff_get_range_tuple_id(IntPtr multi);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_union_pw_aff_reset_range_tuple_id(IntPtr multi);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_union_pw_aff_scale_multi_val(IntPtr multi, IntPtr mv);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_union_pw_aff_scale_val(IntPtr multi, IntPtr v);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_union_pw_aff_scale_down_multi_val(IntPtr multi, IntPtr mv);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_union_pw_aff_scale_down_val(IntPtr multi, IntPtr v);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_union_pw_aff_set_at(IntPtr multi, int pos, IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_union_pw_aff_set_range_tuple_id(IntPtr multi, IntPtr id);

[DllImport(LibraryName)]
public static extern  int isl_multi_union_pw_aff_size(IntPtr multi);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_union_pw_aff_get_space(IntPtr multi);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_union_pw_aff_sub(IntPtr multi1, IntPtr multi2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_union_pw_aff_union_add(IntPtr mupa1, IntPtr mupa2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_union_pw_aff_zero(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_union_pw_aff_copy(IntPtr multi);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_union_pw_aff_free(IntPtr multi);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_multi_union_pw_aff_to_str(IntPtr mupa);


[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_val_from_val_list(IntPtr space, IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_val_read_from_str(IntPtr ctx, [MarshalAs(UnmanagedType.LPStr)] string str);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_val_add(IntPtr multi1, IntPtr multi2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_val_add_val(IntPtr mv, IntPtr v);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_val_get_at(IntPtr multi, int pos);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_val_flat_range_product(IntPtr multi1, IntPtr multi2);

[DllImport(LibraryName)]
public static extern  isl_bool isl_multi_val_has_range_tuple_id(IntPtr multi);

[DllImport(LibraryName)]
public static extern  isl_bool isl_multi_val_involves_nan(IntPtr multi);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_val_get_list(IntPtr multi);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_val_max(IntPtr multi1, IntPtr multi2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_val_min(IntPtr multi1, IntPtr multi2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_val_neg(IntPtr multi);

[DllImport(LibraryName)]
public static extern  isl_bool isl_multi_val_plain_is_equal(IntPtr multi1, IntPtr multi2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_val_product(IntPtr multi1, IntPtr multi2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_val_range_product(IntPtr multi1, IntPtr multi2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_val_get_range_tuple_id(IntPtr multi);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_val_reset_range_tuple_id(IntPtr multi);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_val_scale_multi_val(IntPtr multi, IntPtr mv);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_val_scale_val(IntPtr multi, IntPtr v);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_val_scale_down_multi_val(IntPtr multi, IntPtr mv);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_val_scale_down_val(IntPtr multi, IntPtr v);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_val_set_at(IntPtr multi, int pos, IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_val_set_range_tuple_id(IntPtr multi, IntPtr id);

[DllImport(LibraryName)]
public static extern  int isl_multi_val_size(IntPtr multi);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_val_get_space(IntPtr multi);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_val_sub(IntPtr multi1, IntPtr multi2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_val_zero(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_val_copy(IntPtr multi);

[DllImport(LibraryName)]
public static extern  IntPtr isl_multi_val_free(IntPtr multi);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_multi_val_to_str(IntPtr mv);


[DllImport(LibraryName)]
public static extern  IntPtr isl_point_add_ui(IntPtr pnt, dim_type type, int pos, uint val);

[DllImport(LibraryName)]
public static extern  IntPtr isl_point_get_coordinate_val(IntPtr pnt, dim_type type, int pos);

[DllImport(LibraryName)]
public static extern  IntPtr isl_point_get_multi_val(IntPtr pnt);

[DllImport(LibraryName)]
public static extern  IntPtr isl_point_set_coordinate_val(IntPtr pnt, dim_type type, int pos, IntPtr v);

[DllImport(LibraryName)]
public static extern  IntPtr isl_point_sub_ui(IntPtr pnt, dim_type type, int pos, uint val);

[DllImport(LibraryName)]
public static extern  IntPtr isl_point_to_set(IntPtr pnt);

[DllImport(LibraryName)]
public static extern  IntPtr isl_point_copy(IntPtr pnt);

[DllImport(LibraryName)]
public static extern  IntPtr isl_point_free(IntPtr pnt);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_point_to_str(IntPtr pnt);


[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_from_aff(IntPtr aff);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_read_from_str(IntPtr ctx, [MarshalAs(UnmanagedType.LPStr)] string str);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_add(IntPtr pwaff1, IntPtr pwaff2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_add_constant_val(IntPtr pa, IntPtr v);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_as_aff(IntPtr pa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_as_map(IntPtr pa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_bind_id(IntPtr pa, IntPtr id);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_bind_domain(IntPtr pa, IntPtr tuple);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_bind_domain_wrapped_domain(IntPtr pa, IntPtr tuple);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_ceil(IntPtr pwaff);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_coalesce(IntPtr pa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_cond(IntPtr cond, IntPtr pwaff_true, IntPtr pwaff_false);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_div(IntPtr pa1, IntPtr pa2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_domain(IntPtr pwaff);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_domain_reverse(IntPtr pa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_drop_unused_params(IntPtr pa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_eq_set(IntPtr pwaff1, IntPtr pwaff2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_eval(IntPtr pa, IntPtr pnt);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_floor(IntPtr pwaff);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_ge_set(IntPtr pwaff1, IntPtr pwaff2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_gist(IntPtr pwaff, IntPtr context);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_gist_params(IntPtr pwaff, IntPtr context);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_gt_set(IntPtr pwaff1, IntPtr pwaff2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_insert_domain(IntPtr pa, IntPtr domain);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_intersect_domain(IntPtr pa, IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_intersect_params(IntPtr pa, IntPtr set);

[DllImport(LibraryName)]
public static extern  isl_bool isl_pw_aff_isa_aff(IntPtr pa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_le_set(IntPtr pwaff1, IntPtr pwaff2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_lt_set(IntPtr pwaff1, IntPtr pwaff2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_max(IntPtr pwaff1, IntPtr pwaff2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_max_val(IntPtr pa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_min(IntPtr pwaff1, IntPtr pwaff2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_min_val(IntPtr pa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_mod_val(IntPtr pa, IntPtr mod);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_mul(IntPtr pwaff1, IntPtr pwaff2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_ne_set(IntPtr pwaff1, IntPtr pwaff2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_neg(IntPtr pwaff);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_param_on_domain_id(IntPtr domain, IntPtr id);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_params(IntPtr pwa);

[DllImport(LibraryName)]
public static extern  isl_bool isl_pw_aff_plain_is_equal(IntPtr pwaff1, IntPtr pwaff2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_pullback_multi_aff(IntPtr pa, IntPtr ma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_pullback_multi_pw_aff(IntPtr pa, IntPtr mpa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_pullback_pw_multi_aff(IntPtr pa, IntPtr pma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_scale_val(IntPtr pa, IntPtr v);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_scale_down_val(IntPtr pa, IntPtr f);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_get_space(IntPtr pwaff);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_sub(IntPtr pwaff1, IntPtr pwaff2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_subtract_domain(IntPtr pa, IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_tdiv_q(IntPtr pa1, IntPtr pa2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_tdiv_r(IntPtr pa1, IntPtr pa2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_to_list(IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_to_union_pw_aff(IntPtr pa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_union_add(IntPtr pwaff1, IntPtr pwaff2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_copy(IntPtr pwaff);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_free(IntPtr pwaff);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_pw_aff_to_str(IntPtr pa);


[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_list_alloc(IntPtr ctx, int n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_list_from_pw_aff(IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_list_read_from_str(IntPtr ctx, [MarshalAs(UnmanagedType.LPStr)] string str);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_list_add(IntPtr list, IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_list_get_at(IntPtr list, int index);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_list_clear(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_list_concat(IntPtr list1, IntPtr list2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_list_drop(IntPtr list, uint first, uint n);

[DllImport(LibraryName)]
public static extern  isl_stat isl_pw_aff_list_foreach(IntPtr list, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, isl_stat> fn, IntPtr user);

[DllImport(LibraryName)]
public static extern  isl_stat isl_pw_aff_list_foreach_scc(IntPtr list, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, IntPtr, isl_bool> follows, IntPtr follows_user, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, isl_stat> fn, IntPtr fn_user);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_list_insert(IntPtr list, uint pos, IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_list_set_at(IntPtr list, int index, IntPtr el);

[DllImport(LibraryName)]
public static extern  int isl_pw_aff_list_size(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_list_copy(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_aff_list_free(IntPtr list);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_pw_aff_list_to_str(IntPtr list);


[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_from_multi_aff(IntPtr ma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_from_pw_aff(IntPtr pa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_read_from_str(IntPtr ctx, [MarshalAs(UnmanagedType.LPStr)] string str);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_add(IntPtr pma1, IntPtr pma2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_add_constant_multi_val(IntPtr pma, IntPtr mv);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_add_constant_val(IntPtr pma, IntPtr v);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_as_map(IntPtr pma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_as_multi_aff(IntPtr pma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_as_set(IntPtr pma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_get_at(IntPtr pma, int pos);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_bind_domain(IntPtr pma, IntPtr tuple);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_bind_domain_wrapped_domain(IntPtr pma, IntPtr tuple);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_coalesce(IntPtr pma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_domain(IntPtr pma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_domain_map(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_domain_reverse(IntPtr pma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_drop_unused_params(IntPtr pma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_flat_range_product(IntPtr pma1, IntPtr pma2);

[DllImport(LibraryName)]
public static extern  isl_stat isl_pw_multi_aff_foreach_piece(IntPtr pma, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, IntPtr, isl_stat> fn, IntPtr user);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_gist(IntPtr pma, IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_gist_params(IntPtr pma, IntPtr set);

[DllImport(LibraryName)]
public static extern  isl_bool isl_pw_multi_aff_has_range_tuple_id(IntPtr pma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_identity_on_domain_space(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_insert_domain(IntPtr pma, IntPtr domain);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_intersect_domain(IntPtr pma, IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_intersect_params(IntPtr pma, IntPtr set);

[DllImport(LibraryName)]
public static extern  isl_bool isl_pw_multi_aff_involves_locals(IntPtr pma);

[DllImport(LibraryName)]
public static extern  isl_bool isl_pw_multi_aff_isa_multi_aff(IntPtr pma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_max_multi_val(IntPtr pma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_min_multi_val(IntPtr pma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_multi_val_on_domain(IntPtr domain, IntPtr mv);

[DllImport(LibraryName)]
public static extern  int isl_pw_multi_aff_n_piece(IntPtr pma);

[DllImport(LibraryName)]
public static extern  isl_bool isl_pw_multi_aff_plain_is_equal(IntPtr pma1, IntPtr pma2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_preimage_domain_wrapped_domain_pw_multi_aff(IntPtr pma1, IntPtr pma2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_product(IntPtr pma1, IntPtr pma2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_pullback_multi_aff(IntPtr pma, IntPtr ma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_pullback_pw_multi_aff(IntPtr pma1, IntPtr pma2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_range_factor_domain(IntPtr pma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_range_factor_range(IntPtr pma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_range_map(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_range_product(IntPtr pma1, IntPtr pma2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_get_range_tuple_id(IntPtr pma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_scale_multi_val(IntPtr pma, IntPtr mv);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_scale_val(IntPtr pma, IntPtr v);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_scale_down_multi_val(IntPtr pma, IntPtr mv);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_scale_down_val(IntPtr pma, IntPtr v);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_set_range_tuple_id(IntPtr pma, IntPtr id);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_get_space(IntPtr pma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_sub(IntPtr pma1, IntPtr pma2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_subtract_domain(IntPtr pma, IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_to_list(IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_to_multi_pw_aff(IntPtr pma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_to_union_pw_multi_aff(IntPtr pma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_union_add(IntPtr pma1, IntPtr pma2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_zero(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_copy(IntPtr pma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_free(IntPtr pma);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_pw_multi_aff_to_str(IntPtr pma);


[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_list_alloc(IntPtr ctx, int n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_list_from_pw_multi_aff(IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_list_read_from_str(IntPtr ctx, [MarshalAs(UnmanagedType.LPStr)] string str);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_list_add(IntPtr list, IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_list_get_at(IntPtr list, int index);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_list_clear(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_list_concat(IntPtr list1, IntPtr list2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_list_drop(IntPtr list, uint first, uint n);

[DllImport(LibraryName)]
public static extern  isl_stat isl_pw_multi_aff_list_foreach(IntPtr list, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, isl_stat> fn, IntPtr user);

[DllImport(LibraryName)]
public static extern  isl_stat isl_pw_multi_aff_list_foreach_scc(IntPtr list, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, IntPtr, isl_bool> follows, IntPtr follows_user, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, isl_stat> fn, IntPtr fn_user);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_list_insert(IntPtr list, uint pos, IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_list_set_at(IntPtr list, int index, IntPtr el);

[DllImport(LibraryName)]
public static extern  int isl_pw_multi_aff_list_size(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_list_copy(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_pw_multi_aff_list_free(IntPtr list);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_pw_multi_aff_list_to_str(IntPtr list);


[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_read_from_str(IntPtr ctx, [MarshalAs(UnmanagedType.LPStr)] string str);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_get_domain(IntPtr schedule);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_from_domain(IntPtr domain);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_get_map(IntPtr sched);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_pullback_union_pw_multi_aff(IntPtr schedule, IntPtr upma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_get_root(IntPtr schedule);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_copy(IntPtr sched);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_free(IntPtr sched);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_schedule_to_str(IntPtr schedule);


[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_constraints_read_from_str(IntPtr ctx, [MarshalAs(UnmanagedType.LPStr)] string str);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_constraints_get_coincidence(IntPtr sc);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_constraints_compute_schedule(IntPtr sc);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_constraints_get_conditional_validity(IntPtr sc);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_constraints_get_conditional_validity_condition(IntPtr sc);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_constraints_get_context(IntPtr sc);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_constraints_get_domain(IntPtr sc);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_constraints_on_domain(IntPtr domain);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_constraints_get_proximity(IntPtr sc);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_constraints_set_coincidence(IntPtr sc, IntPtr coincidence);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_constraints_set_conditional_validity(IntPtr sc, IntPtr condition, IntPtr validity);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_constraints_set_context(IntPtr sc, IntPtr context);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_constraints_set_proximity(IntPtr sc, IntPtr proximity);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_constraints_set_validity(IntPtr sc, IntPtr validity);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_constraints_get_validity(IntPtr sc);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_constraints_copy(IntPtr sc);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_constraints_free(IntPtr sc);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_schedule_constraints_to_str(IntPtr sc);


[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_ancestor(IntPtr node, int generation);

[DllImport(LibraryName)]
public static extern  int isl_schedule_node_get_ancestor_child_position(IntPtr node, IntPtr ancestor);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_child(IntPtr node, int pos);

[DllImport(LibraryName)]
public static extern  int isl_schedule_node_get_child_position(IntPtr node);

[DllImport(LibraryName)]
public static extern  isl_bool isl_schedule_node_every_descendant(IntPtr node, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, isl_bool> test, IntPtr user);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_first_child(IntPtr node);

[DllImport(LibraryName)]
public static extern  isl_stat isl_schedule_node_foreach_ancestor_top_down(IntPtr node, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, isl_stat> fn, IntPtr user);

[DllImport(LibraryName)]
public static extern  isl_stat isl_schedule_node_foreach_descendant_top_down(IntPtr node, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, isl_bool> fn, IntPtr user);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_from_domain(IntPtr domain);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_from_extension(IntPtr extension);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_graft_after(IntPtr node, IntPtr graft);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_graft_before(IntPtr node, IntPtr graft);

[DllImport(LibraryName)]
public static extern  isl_bool isl_schedule_node_has_children(IntPtr node);

[DllImport(LibraryName)]
public static extern  isl_bool isl_schedule_node_has_next_sibling(IntPtr node);

[DllImport(LibraryName)]
public static extern  isl_bool isl_schedule_node_has_parent(IntPtr node);

[DllImport(LibraryName)]
public static extern  isl_bool isl_schedule_node_has_previous_sibling(IntPtr node);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_insert_context(IntPtr node, IntPtr context);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_insert_filter(IntPtr node, IntPtr filter);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_insert_guard(IntPtr node, IntPtr context);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_insert_mark(IntPtr node, IntPtr mark);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_insert_partial_schedule(IntPtr node, IntPtr schedule);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_insert_sequence(IntPtr node, IntPtr filters);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_insert_set(IntPtr node, IntPtr filters);

[DllImport(LibraryName)]
public static extern  isl_bool isl_schedule_node_is_equal(IntPtr node1, IntPtr node2);

[DllImport(LibraryName)]
public static extern  isl_bool isl_schedule_node_is_subtree_anchored(IntPtr node);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_map_descendant_bottom_up(IntPtr node, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, IntPtr> fn, IntPtr user);

[DllImport(LibraryName)]
public static extern  int isl_schedule_node_n_children(IntPtr node);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_next_sibling(IntPtr node);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_order_after(IntPtr node, IntPtr filter);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_order_before(IntPtr node, IntPtr filter);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_parent(IntPtr node);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_get_prefix_schedule_multi_union_pw_aff(IntPtr node);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_get_prefix_schedule_union_map(IntPtr node);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_get_prefix_schedule_union_pw_multi_aff(IntPtr node);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_previous_sibling(IntPtr node);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_root(IntPtr node);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_get_schedule(IntPtr node);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_get_shared_ancestor(IntPtr node1, IntPtr node2);

[DllImport(LibraryName)]
public static extern  int isl_schedule_node_get_tree_depth(IntPtr node);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_copy(IntPtr node);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_free(IntPtr node);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_schedule_node_to_str(IntPtr node);

[DllImport(LibraryName)]
public static extern  schedule_node_type isl_schedule_node_get_type(IntPtr node);


[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_band_get_ast_build_options(IntPtr node);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_band_get_ast_isolate_option(IntPtr node);

[DllImport(LibraryName)]
public static extern  isl_bool isl_schedule_node_band_member_get_coincident(IntPtr node, int pos);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_band_member_set_coincident(IntPtr node, int pos, int coincident);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_band_mod(IntPtr node, IntPtr mv);

[DllImport(LibraryName)]
public static extern  int isl_schedule_node_band_n_member(IntPtr node);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_band_get_partial_schedule(IntPtr node);

[DllImport(LibraryName)]
public static extern  isl_bool isl_schedule_node_band_get_permutable(IntPtr node);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_band_scale(IntPtr node, IntPtr mv);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_band_scale_down(IntPtr node, IntPtr mv);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_band_set_ast_build_options(IntPtr node, IntPtr options);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_band_set_permutable(IntPtr node, int permutable);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_band_shift(IntPtr node, IntPtr shift);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_band_split(IntPtr node, int pos);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_band_tile(IntPtr node, IntPtr sizes);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_band_member_set_ast_loop_type(IntPtr node, int pos, ast_loop_type type);


[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_context_get_context(IntPtr node);


[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_domain_get_domain(IntPtr node);


[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_expansion_get_contraction(IntPtr node);

[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_expansion_get_expansion(IntPtr node);


[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_extension_get_extension(IntPtr node);


[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_filter_get_filter(IntPtr node);


[DllImport(LibraryName)]
public static extern  IntPtr isl_schedule_node_guard_get_guard(IntPtr node);






[DllImport(LibraryName)]
public static extern  IntPtr isl_set_from_basic_set(IntPtr bset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_from_point(IntPtr pnt);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_read_from_str(IntPtr ctx, [MarshalAs(UnmanagedType.LPStr)] string str);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_add_constraint(IntPtr set, IntPtr constraint);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_add_dims(IntPtr set, dim_type type, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_affine_hull(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_align_params(IntPtr set, IntPtr model);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_apply(IntPtr set, IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_as_pw_multi_aff(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_get_basic_set_list(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_bind(IntPtr set, IntPtr tuple);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_box_from_points(IntPtr pnt1, IntPtr pnt2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_coalesce(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_coefficients(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_complement(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_compute_divs(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_count_val(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_detect_equalities(IntPtr set);

[DllImport(LibraryName)]
public static extern  int isl_set_dim(IntPtr set, dim_type type);

[DllImport(LibraryName)]
public static extern  isl_bool isl_set_dim_has_any_lower_bound(IntPtr set, dim_type type, uint pos);

[DllImport(LibraryName)]
public static extern  isl_bool isl_set_dim_has_any_upper_bound(IntPtr set, dim_type type, uint pos);

[DllImport(LibraryName)]
public static extern  isl_bool isl_set_dim_has_lower_bound(IntPtr set, dim_type type, uint pos);

[DllImport(LibraryName)]
public static extern  isl_bool isl_set_dim_has_upper_bound(IntPtr set, dim_type type, uint pos);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_get_dim_id(IntPtr set, dim_type type, uint pos);

[DllImport(LibraryName)]
public static extern  isl_bool isl_set_dim_is_bounded(IntPtr set, dim_type type, uint pos);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_dim_max(IntPtr set, int pos);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_dim_max_val(IntPtr set, int pos);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_dim_min(IntPtr set, int pos);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_dim_min_val(IntPtr set, int pos);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_get_dim_name(IntPtr set, dim_type type, uint pos);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_drop_constraints_involving_dims(IntPtr set, dim_type type, uint first, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_drop_constraints_not_involving_dims(IntPtr set, dim_type type, uint first, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_drop_unused_params(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_eliminate(IntPtr set, dim_type type, uint first, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_eliminate_dims(IntPtr set, uint first, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_empty(IntPtr space);

[DllImport(LibraryName)]
public static extern  int isl_set_find_dim_by_id(IntPtr set, dim_type type, IntPtr id);

[DllImport(LibraryName)]
public static extern  int isl_set_find_dim_by_name(IntPtr set, dim_type type, [MarshalAs(UnmanagedType.LPStr)] string name);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_fix_dim_si(IntPtr set, uint dim, int value);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_fix_si(IntPtr set, dim_type type, uint pos, int value);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_fix_val(IntPtr set, dim_type type, uint pos, IntPtr v);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_flatten(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_flatten_map(IntPtr set);

[DllImport(LibraryName)]
public static extern  isl_stat isl_set_foreach_basic_set(IntPtr set, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, isl_stat> fn, IntPtr user);

[DllImport(LibraryName)]
public static extern  isl_stat isl_set_foreach_point(IntPtr set, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, isl_stat> fn, IntPtr user);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_from_multi_aff(IntPtr ma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_gist(IntPtr set, IntPtr context);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_gist_basic_set(IntPtr set, IntPtr context);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_gist_params(IntPtr set, IntPtr context);

[DllImport(LibraryName)]
public static extern  isl_bool isl_set_has_dim_id(IntPtr set, dim_type type, uint pos);

[DllImport(LibraryName)]
public static extern  isl_bool isl_set_has_dim_name(IntPtr set, dim_type type, uint pos);

[DllImport(LibraryName)]
public static extern  isl_bool isl_set_has_equal_space(IntPtr set1, IntPtr set2);

[DllImport(LibraryName)]
public static extern  isl_bool isl_set_has_tuple_id(IntPtr set);

[DllImport(LibraryName)]
public static extern  isl_bool isl_set_has_tuple_name(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_identity(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_indicator_function(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_insert_dims(IntPtr set, dim_type type, uint pos, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_insert_domain(IntPtr set, IntPtr domain);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_intersect(IntPtr set1, IntPtr set2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_intersect_params(IntPtr set, IntPtr params_);

[DllImport(LibraryName)]
public static extern  isl_bool isl_set_involves_dims(IntPtr set, dim_type type, uint first, uint n);

[DllImport(LibraryName)]
public static extern  isl_bool isl_set_involves_locals(IntPtr set);

[DllImport(LibraryName)]
public static extern  isl_bool isl_set_is_bounded(IntPtr set);

[DllImport(LibraryName)]
public static extern  isl_bool isl_set_is_box(IntPtr set);

[DllImport(LibraryName)]
public static extern  isl_bool isl_set_is_disjoint(IntPtr set1, IntPtr set2);

[DllImport(LibraryName)]
public static extern  isl_bool isl_set_is_empty(IntPtr set);

[DllImport(LibraryName)]
public static extern  isl_bool isl_set_is_equal(IntPtr set1, IntPtr set2);

[DllImport(LibraryName)]
public static extern  isl_bool isl_set_is_params(IntPtr set);

[DllImport(LibraryName)]
public static extern  isl_bool isl_set_is_singleton(IntPtr set);

[DllImport(LibraryName)]
public static extern  isl_bool isl_set_is_strict_subset(IntPtr set1, IntPtr set2);

[DllImport(LibraryName)]
public static extern  isl_bool isl_set_is_subset(IntPtr set1, IntPtr set2);

[DllImport(LibraryName)]
public static extern  isl_bool isl_set_is_wrapping(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_get_lattice_tile(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_lex_ge_set(IntPtr set1, IntPtr set2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_lex_gt_set(IntPtr set1, IntPtr set2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_lex_le_set(IntPtr set1, IntPtr set2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_lex_lt_set(IntPtr set1, IntPtr set2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_lexmax(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_lexmax_pw_multi_aff(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_lexmin(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_lexmin_pw_multi_aff(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_lift(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_lower_bound_multi_pw_aff(IntPtr set, IntPtr lower);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_lower_bound_multi_val(IntPtr set, IntPtr lower);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_lower_bound_si(IntPtr set, dim_type type, uint pos, int value);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_lower_bound_val(IntPtr set, dim_type type, uint pos, IntPtr value);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_make_disjoint(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_max_multi_pw_aff(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_max_val(IntPtr set, IntPtr obj);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_min_multi_pw_aff(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_min_val(IntPtr set, IntPtr obj);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_move_dims(IntPtr set, dim_type dst_type, uint dst_pos, dim_type src_type, uint src_pos, uint n);

[DllImport(LibraryName)]
public static extern  int isl_set_n_basic_set(IntPtr set);

[DllImport(LibraryName)]
public static extern  int isl_set_n_dim(IntPtr set);

[DllImport(LibraryName)]
public static extern  int isl_set_n_param(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_neg(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_param_pw_aff_on_domain_id(IntPtr domain, IntPtr id);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_params(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_plain_get_val_if_fixed(IntPtr set, dim_type type, uint pos);

[DllImport(LibraryName)]
public static extern  isl_bool isl_set_plain_is_disjoint(IntPtr set1, IntPtr set2);

[DllImport(LibraryName)]
public static extern  isl_bool isl_set_plain_is_empty(IntPtr set);

[DllImport(LibraryName)]
public static extern  isl_bool isl_set_plain_is_universe(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_get_plain_multi_val_if_fixed(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_polyhedral_hull(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_preimage_multi_aff(IntPtr set, IntPtr ma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_preimage_multi_pw_aff(IntPtr set, IntPtr mpa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_preimage_pw_multi_aff(IntPtr set, IntPtr pma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_product(IntPtr set1, IntPtr set2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_project_onto_map(IntPtr set, dim_type type, uint first, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_project_out(IntPtr set, dim_type type, uint first, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_project_out_all_params(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_project_out_param_id(IntPtr set, IntPtr id);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_project_out_param_id_list(IntPtr set, IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_pw_aff_on_domain_val(IntPtr domain, IntPtr v);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_pw_multi_aff_on_domain_multi_val(IntPtr domain, IntPtr mv);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_remove_dims(IntPtr bset, dim_type type, uint first, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_remove_divs(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_remove_divs_involving_dims(IntPtr set, dim_type type, uint first, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_remove_redundancies(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_remove_unknown_divs(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_reset_space(IntPtr set, IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_reset_tuple_id(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_reset_user(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_sample(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_sample_point(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_set_dim_id(IntPtr set, dim_type type, uint pos, IntPtr id);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_set_dim_name(IntPtr set, dim_type type, uint pos, [MarshalAs(UnmanagedType.LPStr)] string s);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_set_tuple_id(IntPtr set, IntPtr id);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_set_tuple_name(IntPtr set, [MarshalAs(UnmanagedType.LPStr)] string s);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_get_simple_fixed_box_hull(IntPtr set);

[DllImport(LibraryName)]
public static extern  int isl_set_size(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_solutions(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_get_space(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_split_dims(IntPtr set, dim_type type, uint first, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_get_stride(IntPtr set, int pos);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_subtract(IntPtr set1, IntPtr set2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_sum(IntPtr set1, IntPtr set2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_to_list(IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_to_union_set(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_translation(IntPtr deltas);

[DllImport(LibraryName)]
public static extern  int isl_set_tuple_dim(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_get_tuple_id(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_get_tuple_name(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_unbind_params(IntPtr set, IntPtr tuple);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_unbind_params_insert_domain(IntPtr set, IntPtr domain);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_union(IntPtr set1, IntPtr set2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_universe(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_unshifted_simple_hull(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_unwrap(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_upper_bound_multi_pw_aff(IntPtr set, IntPtr upper);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_upper_bound_multi_val(IntPtr set, IntPtr upper);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_upper_bound_si(IntPtr set, dim_type type, uint pos, int value);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_upper_bound_val(IntPtr set, dim_type type, uint pos, IntPtr value);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_wrapped_domain_map(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_wrapped_reverse(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_copy(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_free(IntPtr set);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_set_to_str(IntPtr set);


[DllImport(LibraryName)]
public static extern  IntPtr isl_set_list_alloc(IntPtr ctx, int n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_list_from_set(IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_list_read_from_str(IntPtr ctx, [MarshalAs(UnmanagedType.LPStr)] string str);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_list_add(IntPtr list, IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_list_get_at(IntPtr list, int index);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_list_clear(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_list_concat(IntPtr list1, IntPtr list2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_list_drop(IntPtr list, uint first, uint n);

[DllImport(LibraryName)]
public static extern  isl_stat isl_set_list_foreach(IntPtr list, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, isl_stat> fn, IntPtr user);

[DllImport(LibraryName)]
public static extern  isl_stat isl_set_list_foreach_scc(IntPtr list, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, IntPtr, isl_bool> follows, IntPtr follows_user, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, isl_stat> fn, IntPtr fn_user);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_list_insert(IntPtr list, uint pos, IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_list_set_at(IntPtr list, int index, IntPtr el);

[DllImport(LibraryName)]
public static extern  int isl_set_list_size(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_list_union(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_list_copy(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_set_list_free(IntPtr list);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_set_list_to_str(IntPtr list);


[DllImport(LibraryName)]
public static extern  IntPtr isl_space_read_from_str(IntPtr ctx, [MarshalAs(UnmanagedType.LPStr)] string str);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_add_dims(IntPtr space, dim_type type, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_add_named_tuple_id_ui(IntPtr space, IntPtr tuple_id, uint dim);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_add_param_id(IntPtr space, IntPtr id);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_add_unnamed_tuple_ui(IntPtr space, uint dim);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_curry(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_domain(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_domain_factor_domain(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_domain_factor_range(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_domain_map(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_domain_map_multi_aff(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_domain_map_pw_multi_aff(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_domain_product(IntPtr left, IntPtr right);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_domain_reverse(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_get_domain_tuple_id(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_domain_wrapped_domain(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_domain_wrapped_range(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_drop_all_params(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_drop_dims(IntPtr space, dim_type type, uint first, uint num);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_factor_domain(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_factor_range(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_flatten_domain(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_flatten_range(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_from_domain(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_from_range(IntPtr space);

[DllImport(LibraryName)]
public static extern  isl_bool isl_space_has_domain_tuple_id(IntPtr space);

[DllImport(LibraryName)]
public static extern  isl_bool isl_space_has_range_tuple_id(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_identity_multi_aff_on_domain(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_identity_multi_pw_aff_on_domain(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_identity_pw_multi_aff_on_domain(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_insert_dims(IntPtr space, dim_type type, uint pos, uint n);

[DllImport(LibraryName)]
public static extern  isl_bool isl_space_is_equal(IntPtr space1, IntPtr space2);

[DllImport(LibraryName)]
public static extern  isl_bool isl_space_is_wrapping(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_join(IntPtr left, IntPtr right);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_map_from_domain_and_range(IntPtr domain, IntPtr range);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_map_from_set(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_move_dims(IntPtr space, dim_type dst_type, uint dst_pos, dim_type src_type, uint src_pos, uint n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_multi_aff(IntPtr space, IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_multi_aff_on_domain_multi_val(IntPtr space, IntPtr mv);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_multi_id(IntPtr space, IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_multi_pw_aff(IntPtr space, IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_multi_union_pw_aff(IntPtr space, IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_multi_val(IntPtr space, IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_param_aff_on_domain_id(IntPtr space, IntPtr id);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_params(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_product(IntPtr left, IntPtr right);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_range(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_range_factor_domain(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_range_factor_range(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_range_map(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_range_map_multi_aff(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_range_map_pw_multi_aff(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_range_product(IntPtr left, IntPtr right);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_range_reverse(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_get_range_tuple_id(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_range_wrapped_domain(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_range_wrapped_range(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_reverse(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_set_domain_tuple_id(IntPtr space, IntPtr id);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_set_range_tuple_id(IntPtr space, IntPtr id);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_uncurry(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_unit(IntPtr ctx);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_universe_map(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_universe_set(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_unwrap(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_wrap(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_wrapped_reverse(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_zero_aff_on_domain(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_zero_multi_aff(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_zero_multi_pw_aff(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_zero_multi_union_pw_aff(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_zero_multi_val(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_copy(IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_space_free(IntPtr space);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_space_to_str(IntPtr space);


[DllImport(LibraryName)]
public static extern  IntPtr isl_union_access_info_from_sink(IntPtr sink);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_access_info_compute_flow(IntPtr access);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_access_info_set_kill(IntPtr access, IntPtr kill);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_access_info_set_may_source(IntPtr access, IntPtr may_source);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_access_info_set_must_source(IntPtr access, IntPtr must_source);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_access_info_set_schedule(IntPtr access, IntPtr schedule);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_access_info_set_schedule_map(IntPtr access, IntPtr schedule_map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_access_info_copy(IntPtr access);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_access_info_free(IntPtr access);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_union_access_info_to_str(IntPtr access);


[DllImport(LibraryName)]
public static extern  IntPtr isl_union_flow_get_full_may_dependence(IntPtr flow);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_flow_get_full_must_dependence(IntPtr flow);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_flow_get_may_dependence(IntPtr flow);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_flow_get_may_no_source(IntPtr flow);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_flow_get_must_dependence(IntPtr flow);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_flow_get_must_no_source(IntPtr flow);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_flow_copy(IntPtr flow);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_flow_free(IntPtr flow);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_union_flow_to_str(IntPtr flow);


[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_from_basic_map(IntPtr bmap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_from_map(IntPtr map);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_read_from_str(IntPtr ctx, [MarshalAs(UnmanagedType.LPStr)] string str);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_affine_hull(IntPtr umap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_apply_domain(IntPtr umap1, IntPtr umap2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_apply_range(IntPtr umap1, IntPtr umap2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_as_map(IntPtr umap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_as_multi_union_pw_aff(IntPtr umap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_as_union_pw_multi_aff(IntPtr umap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_bind_range(IntPtr umap, IntPtr tuple);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_coalesce(IntPtr umap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_compute_divs(IntPtr umap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_curry(IntPtr umap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_deltas(IntPtr umap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_detect_equalities(IntPtr umap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_domain(IntPtr umap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_domain_factor_domain(IntPtr umap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_domain_factor_range(IntPtr umap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_domain_map(IntPtr umap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_domain_map_union_pw_multi_aff(IntPtr umap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_domain_product(IntPtr umap1, IntPtr umap2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_domain_reverse(IntPtr umap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_drop_unused_params(IntPtr umap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_empty_ctx(IntPtr ctx);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_eq_at_multi_union_pw_aff(IntPtr umap, IntPtr mupa);

[DllImport(LibraryName)]
public static extern  isl_bool isl_union_map_every_map(IntPtr umap, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, isl_bool> test, IntPtr user);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_extract_map(IntPtr umap, IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_factor_domain(IntPtr umap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_factor_range(IntPtr umap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_fixed_power_val(IntPtr umap, IntPtr exp);

[DllImport(LibraryName)]
public static extern  isl_stat isl_union_map_foreach_map(IntPtr umap, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, isl_stat> fn, IntPtr user);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_from_multi_union_pw_aff(IntPtr mupa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_from_union_pw_multi_aff(IntPtr upma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_from_domain(IntPtr uset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_from_domain_and_range(IntPtr domain, IntPtr range);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_from_range(IntPtr uset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_gist(IntPtr umap, IntPtr context);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_gist_domain(IntPtr umap, IntPtr uset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_gist_params(IntPtr umap, IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_gist_range(IntPtr umap, IntPtr uset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_intersect(IntPtr umap1, IntPtr umap2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_intersect_domain_space(IntPtr umap, IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_intersect_domain_union_set(IntPtr umap, IntPtr uset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_intersect_domain_factor_domain(IntPtr umap, IntPtr factor);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_intersect_domain_factor_range(IntPtr umap, IntPtr factor);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_intersect_domain_wrapped_domain_union_set(IntPtr umap, IntPtr domain);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_intersect_params(IntPtr umap, IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_intersect_range_space(IntPtr umap, IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_intersect_range_union_set(IntPtr umap, IntPtr uset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_intersect_range_factor_domain(IntPtr umap, IntPtr factor);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_intersect_range_factor_range(IntPtr umap, IntPtr factor);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_intersect_range_wrapped_domain_union_set(IntPtr umap, IntPtr domain);

[DllImport(LibraryName)]
public static extern  isl_bool isl_union_map_is_bijective(IntPtr umap);

[DllImport(LibraryName)]
public static extern  isl_bool isl_union_map_is_disjoint(IntPtr umap1, IntPtr umap2);

[DllImport(LibraryName)]
public static extern  isl_bool isl_union_map_is_empty(IntPtr umap);

[DllImport(LibraryName)]
public static extern  isl_bool isl_union_map_is_equal(IntPtr umap1, IntPtr umap2);

[DllImport(LibraryName)]
public static extern  isl_bool isl_union_map_is_injective(IntPtr umap);

[DllImport(LibraryName)]
public static extern  isl_bool isl_union_map_is_single_valued(IntPtr umap);

[DllImport(LibraryName)]
public static extern  isl_bool isl_union_map_is_strict_subset(IntPtr umap1, IntPtr umap2);

[DllImport(LibraryName)]
public static extern  isl_bool isl_union_map_is_subset(IntPtr umap1, IntPtr umap2);

[DllImport(LibraryName)]
public static extern  isl_bool isl_union_map_isa_map(IntPtr umap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_lexmax(IntPtr umap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_lexmin(IntPtr umap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_get_map_list(IntPtr umap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_params(IntPtr umap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_polyhedral_hull(IntPtr umap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_preimage_domain_multi_aff(IntPtr umap, IntPtr ma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_preimage_domain_multi_pw_aff(IntPtr umap, IntPtr mpa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_preimage_domain_pw_multi_aff(IntPtr umap, IntPtr pma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_preimage_domain_union_pw_multi_aff(IntPtr umap, IntPtr upma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_preimage_range_multi_aff(IntPtr umap, IntPtr ma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_preimage_range_pw_multi_aff(IntPtr umap, IntPtr pma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_preimage_range_union_pw_multi_aff(IntPtr umap, IntPtr upma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_product(IntPtr umap1, IntPtr umap2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_project_out_all_params(IntPtr umap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_project_out_param_id(IntPtr umap, IntPtr id);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_project_out_param_id_list(IntPtr umap, IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_range(IntPtr umap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_range_factor_domain(IntPtr umap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_range_factor_range(IntPtr umap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_range_map(IntPtr umap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_range_product(IntPtr umap1, IntPtr umap2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_range_reverse(IntPtr umap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_reverse(IntPtr umap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_get_space(IntPtr umap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_subtract(IntPtr umap1, IntPtr umap2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_subtract_domain(IntPtr umap, IntPtr dom);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_subtract_range(IntPtr umap, IntPtr dom);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_uncurry(IntPtr umap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_union(IntPtr umap1, IntPtr umap2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_universe(IntPtr umap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_wrap(IntPtr umap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_zip(IntPtr umap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_copy(IntPtr umap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_map_free(IntPtr umap);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_union_map_to_str(IntPtr umap);


[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_aff_from_aff(IntPtr aff);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_aff_from_pw_aff(IntPtr pa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_aff_read_from_str(IntPtr ctx, [MarshalAs(UnmanagedType.LPStr)] string str);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_aff_add(IntPtr upa1, IntPtr upa2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_aff_bind_id(IntPtr upa, IntPtr id);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_aff_coalesce(IntPtr upa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_aff_domain(IntPtr upa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_aff_drop_unused_params(IntPtr upa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_aff_gist(IntPtr upa, IntPtr context);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_aff_intersect_domain_space(IntPtr upa, IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_aff_intersect_domain_union_set(IntPtr upa, IntPtr uset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_aff_intersect_domain_wrapped_domain(IntPtr upa, IntPtr uset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_aff_intersect_domain_wrapped_range(IntPtr upa, IntPtr uset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_aff_intersect_params(IntPtr upa, IntPtr set);

[DllImport(LibraryName)]
public static extern  isl_bool isl_union_pw_aff_plain_is_equal(IntPtr upa1, IntPtr upa2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_aff_pullback_union_pw_multi_aff(IntPtr upa, IntPtr upma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_aff_get_space(IntPtr upa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_aff_sub(IntPtr upa1, IntPtr upa2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_aff_subtract_domain_space(IntPtr upa, IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_aff_subtract_domain_union_set(IntPtr upa, IntPtr uset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_aff_to_list(IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_aff_union_add(IntPtr upa1, IntPtr upa2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_aff_copy(IntPtr upa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_aff_free(IntPtr upa);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_union_pw_aff_to_str(IntPtr upa);


[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_aff_list_alloc(IntPtr ctx, int n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_aff_list_from_union_pw_aff(IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_aff_list_read_from_str(IntPtr ctx, [MarshalAs(UnmanagedType.LPStr)] string str);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_aff_list_add(IntPtr list, IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_aff_list_get_at(IntPtr list, int index);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_aff_list_clear(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_aff_list_concat(IntPtr list1, IntPtr list2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_aff_list_drop(IntPtr list, uint first, uint n);

[DllImport(LibraryName)]
public static extern  isl_stat isl_union_pw_aff_list_foreach(IntPtr list, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, isl_stat> fn, IntPtr user);

[DllImport(LibraryName)]
public static extern  isl_stat isl_union_pw_aff_list_foreach_scc(IntPtr list, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, IntPtr, isl_bool> follows, IntPtr follows_user, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, isl_stat> fn, IntPtr fn_user);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_aff_list_insert(IntPtr list, uint pos, IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_aff_list_set_at(IntPtr list, int index, IntPtr el);

[DllImport(LibraryName)]
public static extern  int isl_union_pw_aff_list_size(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_aff_list_copy(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_aff_list_free(IntPtr list);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_union_pw_aff_list_to_str(IntPtr list);


[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_multi_aff_from_multi_aff(IntPtr ma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_multi_aff_from_pw_multi_aff(IntPtr pma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_multi_aff_from_union_pw_aff(IntPtr upa);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_multi_aff_read_from_str(IntPtr ctx, [MarshalAs(UnmanagedType.LPStr)] string str);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_multi_aff_add(IntPtr upma1, IntPtr upma2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_multi_aff_apply_union_pw_multi_aff(IntPtr upma1, IntPtr upma2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_multi_aff_as_multi_union_pw_aff(IntPtr upma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_multi_aff_as_pw_multi_aff(IntPtr upma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_multi_aff_as_union_map(IntPtr upma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_multi_aff_coalesce(IntPtr upma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_multi_aff_domain(IntPtr upma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_multi_aff_drop_unused_params(IntPtr upma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_multi_aff_empty_ctx(IntPtr ctx);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_multi_aff_extract_pw_multi_aff(IntPtr upma, IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_multi_aff_flat_range_product(IntPtr upma1, IntPtr upma2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_multi_aff_gist(IntPtr upma, IntPtr context);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_multi_aff_intersect_domain_space(IntPtr upma, IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_multi_aff_intersect_domain_union_set(IntPtr upma, IntPtr uset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_multi_aff_intersect_domain_wrapped_domain(IntPtr upma, IntPtr uset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_multi_aff_intersect_domain_wrapped_range(IntPtr upma, IntPtr uset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_multi_aff_intersect_params(IntPtr upma, IntPtr set);

[DllImport(LibraryName)]
public static extern  isl_bool isl_union_pw_multi_aff_involves_locals(IntPtr upma);

[DllImport(LibraryName)]
public static extern  isl_bool isl_union_pw_multi_aff_isa_pw_multi_aff(IntPtr upma);

[DllImport(LibraryName)]
public static extern  isl_bool isl_union_pw_multi_aff_plain_is_empty(IntPtr upma);

[DllImport(LibraryName)]
public static extern  isl_bool isl_union_pw_multi_aff_plain_is_equal(IntPtr upma1, IntPtr upma2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_multi_aff_preimage_domain_wrapped_domain_union_pw_multi_aff(IntPtr upma1, IntPtr upma2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_multi_aff_pullback_union_pw_multi_aff(IntPtr upma1, IntPtr upma2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_multi_aff_get_pw_multi_aff_list(IntPtr upma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_multi_aff_range_factor_domain(IntPtr upma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_multi_aff_range_factor_range(IntPtr upma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_multi_aff_range_product(IntPtr upma1, IntPtr upma2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_multi_aff_get_space(IntPtr upma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_multi_aff_sub(IntPtr upma1, IntPtr upma2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_multi_aff_subtract_domain_space(IntPtr upma, IntPtr space);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_multi_aff_subtract_domain_union_set(IntPtr upma, IntPtr uset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_multi_aff_union_add(IntPtr upma1, IntPtr upma2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_multi_aff_copy(IntPtr upma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_pw_multi_aff_free(IntPtr upma);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_union_pw_multi_aff_to_str(IntPtr upma);


[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_from_basic_set(IntPtr bset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_from_point(IntPtr pnt);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_from_set(IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_read_from_str(IntPtr ctx, [MarshalAs(UnmanagedType.LPStr)] string str);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_affine_hull(IntPtr uset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_apply(IntPtr uset, IntPtr umap);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_as_set(IntPtr uset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_coalesce(IntPtr uset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_compute_divs(IntPtr uset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_detect_equalities(IntPtr uset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_drop_unused_params(IntPtr uset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_empty_ctx(IntPtr ctx);

[DllImport(LibraryName)]
public static extern  isl_bool isl_union_set_every_set(IntPtr uset, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, isl_bool> test, IntPtr user);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_extract_set(IntPtr uset, IntPtr space);

[DllImport(LibraryName)]
public static extern  isl_stat isl_union_set_foreach_point(IntPtr uset, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, isl_stat> fn, IntPtr user);

[DllImport(LibraryName)]
public static extern  isl_stat isl_union_set_foreach_set(IntPtr uset, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, isl_stat> fn, IntPtr user);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_gist(IntPtr uset, IntPtr context);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_gist_params(IntPtr uset, IntPtr set);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_identity(IntPtr uset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_intersect(IntPtr uset1, IntPtr uset2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_intersect_params(IntPtr uset, IntPtr set);

[DllImport(LibraryName)]
public static extern  isl_bool isl_union_set_is_disjoint(IntPtr uset1, IntPtr uset2);

[DllImport(LibraryName)]
public static extern  isl_bool isl_union_set_is_empty(IntPtr uset);

[DllImport(LibraryName)]
public static extern  isl_bool isl_union_set_is_equal(IntPtr uset1, IntPtr uset2);

[DllImport(LibraryName)]
public static extern  isl_bool isl_union_set_is_strict_subset(IntPtr uset1, IntPtr uset2);

[DllImport(LibraryName)]
public static extern  isl_bool isl_union_set_is_subset(IntPtr uset1, IntPtr uset2);

[DllImport(LibraryName)]
public static extern  isl_bool isl_union_set_isa_set(IntPtr uset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_lexmax(IntPtr uset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_lexmin(IntPtr uset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_params(IntPtr uset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_polyhedral_hull(IntPtr uset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_preimage_multi_aff(IntPtr uset, IntPtr ma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_preimage_pw_multi_aff(IntPtr uset, IntPtr pma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_preimage_union_pw_multi_aff(IntPtr uset, IntPtr upma);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_project_out_all_params(IntPtr uset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_sample_point(IntPtr uset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_get_set_list(IntPtr uset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_get_space(IntPtr uset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_subtract(IntPtr uset1, IntPtr uset2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_to_list(IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_union(IntPtr uset1, IntPtr uset2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_universe(IntPtr uset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_unwrap(IntPtr uset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_copy(IntPtr uset);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_free(IntPtr uset);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_union_set_to_str(IntPtr uset);


[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_list_alloc(IntPtr ctx, int n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_list_from_union_set(IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_list_read_from_str(IntPtr ctx, [MarshalAs(UnmanagedType.LPStr)] string str);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_list_add(IntPtr list, IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_list_get_at(IntPtr list, int index);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_list_clear(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_list_concat(IntPtr list1, IntPtr list2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_list_drop(IntPtr list, uint first, uint n);

[DllImport(LibraryName)]
public static extern  isl_stat isl_union_set_list_foreach(IntPtr list, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, isl_stat> fn, IntPtr user);

[DllImport(LibraryName)]
public static extern  isl_stat isl_union_set_list_foreach_scc(IntPtr list, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, IntPtr, isl_bool> follows, IntPtr follows_user, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, isl_stat> fn, IntPtr fn_user);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_list_insert(IntPtr list, uint pos, IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_list_set_at(IntPtr list, int index, IntPtr el);

[DllImport(LibraryName)]
public static extern  int isl_union_set_list_size(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_list_copy(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_union_set_list_free(IntPtr list);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_union_set_list_to_str(IntPtr list);


[DllImport(LibraryName)]
public static extern  IntPtr isl_val_int_from_si(IntPtr ctx, long i);

[DllImport(LibraryName)]
public static extern  IntPtr isl_val_read_from_str(IntPtr ctx, [MarshalAs(UnmanagedType.LPStr)] string str);

[DllImport(LibraryName)]
public static extern  IntPtr isl_val_abs(IntPtr v);

[DllImport(LibraryName)]
public static extern  isl_bool isl_val_abs_eq(IntPtr v1, IntPtr v2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_val_add(IntPtr v1, IntPtr v2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_val_ceil(IntPtr v);

[DllImport(LibraryName)]
public static extern  int isl_val_cmp_si(IntPtr v, long i);

[DllImport(LibraryName)]
public static extern  long isl_val_get_den_si(IntPtr v);

[DllImport(LibraryName)]
public static extern  IntPtr isl_val_div(IntPtr v1, IntPtr v2);

[DllImport(LibraryName)]
public static extern  isl_bool isl_val_eq(IntPtr v1, IntPtr v2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_val_floor(IntPtr v);

[DllImport(LibraryName)]
public static extern  IntPtr isl_val_gcd(IntPtr v1, IntPtr v2);

[DllImport(LibraryName)]
public static extern  isl_bool isl_val_ge(IntPtr v1, IntPtr v2);

[DllImport(LibraryName)]
public static extern  isl_bool isl_val_gt(IntPtr v1, IntPtr v2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_val_infty(IntPtr ctx);

[DllImport(LibraryName)]
public static extern  IntPtr isl_val_inv(IntPtr v);

[DllImport(LibraryName)]
public static extern  isl_bool isl_val_is_divisible_by(IntPtr v1, IntPtr v2);

[DllImport(LibraryName)]
public static extern  isl_bool isl_val_is_infty(IntPtr v);

[DllImport(LibraryName)]
public static extern  isl_bool isl_val_is_int(IntPtr v);

[DllImport(LibraryName)]
public static extern  isl_bool isl_val_is_nan(IntPtr v);

[DllImport(LibraryName)]
public static extern  isl_bool isl_val_is_neg(IntPtr v);

[DllImport(LibraryName)]
public static extern  isl_bool isl_val_is_neginfty(IntPtr v);

[DllImport(LibraryName)]
public static extern  isl_bool isl_val_is_negone(IntPtr v);

[DllImport(LibraryName)]
public static extern  isl_bool isl_val_is_nonneg(IntPtr v);

[DllImport(LibraryName)]
public static extern  isl_bool isl_val_is_nonpos(IntPtr v);

[DllImport(LibraryName)]
public static extern  isl_bool isl_val_is_one(IntPtr v);

[DllImport(LibraryName)]
public static extern  isl_bool isl_val_is_pos(IntPtr v);

[DllImport(LibraryName)]
public static extern  isl_bool isl_val_is_rat(IntPtr v);

[DllImport(LibraryName)]
public static extern  isl_bool isl_val_is_zero(IntPtr v);

[DllImport(LibraryName)]
public static extern  isl_bool isl_val_le(IntPtr v1, IntPtr v2);

[DllImport(LibraryName)]
public static extern  isl_bool isl_val_lt(IntPtr v1, IntPtr v2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_val_max(IntPtr v1, IntPtr v2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_val_min(IntPtr v1, IntPtr v2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_val_mod(IntPtr v1, IntPtr v2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_val_mul(IntPtr v1, IntPtr v2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_val_nan(IntPtr ctx);

[DllImport(LibraryName)]
public static extern  isl_bool isl_val_ne(IntPtr v1, IntPtr v2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_val_neg(IntPtr v);

[DllImport(LibraryName)]
public static extern  IntPtr isl_val_neginfty(IntPtr ctx);

[DllImport(LibraryName)]
public static extern  IntPtr isl_val_negone(IntPtr ctx);

[DllImport(LibraryName)]
public static extern  long isl_val_get_num_si(IntPtr v);

[DllImport(LibraryName)]
public static extern  IntPtr isl_val_one(IntPtr ctx);

[DllImport(LibraryName)]
public static extern  IntPtr isl_val_pow2(IntPtr v);

[DllImport(LibraryName)]
public static extern  int isl_val_sgn(IntPtr v);

[DllImport(LibraryName)]
public static extern  IntPtr isl_val_sub(IntPtr v1, IntPtr v2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_val_to_list(IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_val_trunc(IntPtr v);

[DllImport(LibraryName)]
public static extern  IntPtr isl_val_zero(IntPtr ctx);

[DllImport(LibraryName)]
public static extern  IntPtr isl_val_copy(IntPtr v);

[DllImport(LibraryName)]
public static extern  IntPtr isl_val_free(IntPtr v);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_val_to_str(IntPtr v);


[DllImport(LibraryName)]
public static extern  IntPtr isl_val_list_alloc(IntPtr ctx, int n);

[DllImport(LibraryName)]
public static extern  IntPtr isl_val_list_from_val(IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_val_list_read_from_str(IntPtr ctx, [MarshalAs(UnmanagedType.LPStr)] string str);

[DllImport(LibraryName)]
public static extern  IntPtr isl_val_list_add(IntPtr list, IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_val_list_get_at(IntPtr list, int index);

[DllImport(LibraryName)]
public static extern  IntPtr isl_val_list_clear(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_val_list_concat(IntPtr list1, IntPtr list2);

[DllImport(LibraryName)]
public static extern  IntPtr isl_val_list_drop(IntPtr list, uint first, uint n);

[DllImport(LibraryName)]
public static extern  isl_stat isl_val_list_foreach(IntPtr list, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, isl_stat> fn, IntPtr user);

[DllImport(LibraryName)]
public static extern  isl_stat isl_val_list_foreach_scc(IntPtr list, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, IntPtr, isl_bool> follows, IntPtr follows_user, [MarshalAs(UnmanagedType.FunctionPtr)] Func<IntPtr, IntPtr, isl_stat> fn, IntPtr fn_user);

[DllImport(LibraryName)]
public static extern  IntPtr isl_val_list_insert(IntPtr list, uint pos, IntPtr el);

[DllImport(LibraryName)]
public static extern  IntPtr isl_val_list_set_at(IntPtr list, int index, IntPtr el);

[DllImport(LibraryName)]
public static extern  int isl_val_list_size(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_val_list_copy(IntPtr list);

[DllImport(LibraryName)]
public static extern  IntPtr isl_val_list_free(IntPtr list);

[DllImport(LibraryName)]
[return: MarshalAs(UnmanagedType.LPStr)]
 public static extern  string isl_val_list_to_str(IntPtr list);

}
} // namespace isl
#pragma warning restore
