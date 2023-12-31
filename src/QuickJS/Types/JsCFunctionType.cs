﻿using System.Runtime.InteropServices;

namespace Hosihikari.ScriptExtension.QuickJS.Types
{
    //ref #L925
    [StructLayout(LayoutKind.Explicit)]
    public ref struct JsCFunctionType
    {
        [FieldOffset(0)]
        public unsafe void* func;

        [FieldOffset(0)]
        public double fvalue;
    }

    //typedef union JSCFunctionType {
    //    JSCFunction* generic;
    //    JSValue(*generic_magic)(JSContext* ctx, JSValueConst this_val, int argc, JSValueConst* argv, int magic);
    //    JSCFunction* constructor;
    //    JSValue(*constructor_magic)(JSContext* ctx, JSValueConst new_target, int argc, JSValueConst* argv, int magic);
    //    JSCFunction* constructor_or_func;
    //    double (* f_f) (double);
    //    double (* f_f_f) (double, double);
    //    JSValue(*getter)(JSContext* ctx, JSValueConst this_val);
    //    JSValue(*setter)(JSContext* ctx, JSValueConst this_val, JSValueConst val);
    //    JSValue(*getter_magic)(JSContext* ctx, JSValueConst this_val, int magic);
    //    JSValue(*setter_magic)(JSContext* ctx, JSValueConst this_val, JSValueConst val, int magic);
    //    JSValue(*iterator_next)(JSContext* ctx, JSValueConst this_val,
    //        int argc, JSValueConst* argv, int* pdone, int magic);
    //} JSCFunctionType;
}
