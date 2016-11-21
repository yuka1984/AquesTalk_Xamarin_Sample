using System;
using Android.Runtime;

namespace App1
{

    [global::Android.Runtime.Register("aquestalk/AquesTalk", DoNotGenerateAcw = true)]
    public partial class AquesTalk : global::Java.Lang.Object
    {

        internal static IntPtr JavaClassHandle;
        internal static IntPtr ClassRef => JNIEnv.FindClass("aquestalk/AquesTalk", ref JavaClassHandle);

        protected override IntPtr ThresholdClass => ClassRef;
        protected override global::System.Type ThresholdType => typeof(AquesTalk);

        protected AquesTalk(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        static IntPtr _idCtor;

        [Register(".ctor", "()V", "")]
        public unsafe AquesTalk()
            : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
        {
            if (Handle != IntPtr.Zero)
                return;

            try
            {
                if (GetType() != typeof(AquesTalk))
                {
                    SetHandle(
                        global::Android.Runtime.JNIEnv.StartCreateInstance(GetType(), "()V"),
                        JniHandleOwnership.TransferLocalRef);
                    global::Android.Runtime.JNIEnv.FinishCreateInstance(Handle, "()V");
                    return;
                }

                if (_idCtor == IntPtr.Zero)
                    _idCtor = JNIEnv.GetMethodID(ClassRef, "<init>", "()V");
                SetHandle(
                    global::Android.Runtime.JNIEnv.StartCreateInstance(ClassRef, _idCtor),
                    JniHandleOwnership.TransferLocalRef);
                JNIEnv.FinishCreateInstance(Handle, ClassRef, _idCtor);
            }
            finally
            {
            }
        }

        static Delegate cb_synthe;
#pragma warning disable 0169
        static Delegate GetsyntheHandler()
        {
            if (cb_synthe == null)
                cb_synthe = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, string, int, byte[]>)n_synthe);
            return cb_synthe;
        }

        static byte[] n_synthe(IntPtr jnienv, IntPtr native__this, string kana, int speed)
        {
            global::App1.AquesTalk __this = global::Java.Lang.Object.GetObject<global::App1.AquesTalk>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.synthe(kana, speed);
        }
#pragma warning restore 0169

        static IntPtr id_syntheWav;

        [Register("syntheWav", "(Ljava/lang/String;I)[B", "GetsyntheHandler")]
        public virtual unsafe byte[] synthe(string kana, int speed)
        {
            if (id_syntheWav == IntPtr.Zero)
                id_syntheWav = JNIEnv.GetMethodID(ClassRef, "syntheWav", "(Ljava/lang/String;I)[B");
            try
            {
                var ptr = IntPtr.Zero;
                if (GetType() != ThresholdType)
                    ptr = JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "syntheWav", "(Ljava/lang/String;I)[B"), new JValue(new Java.Lang.String(kana)), new JValue(speed));
                else
                    ptr = JNIEnv.CallObjectMethod(Handle, id_syntheWav, new JValue(new Java.Lang.String(kana)), new JValue(speed));
                return JNIEnv.GetArray<byte>(ptr);
            }
            finally
            {
            }
        }

    }
}

