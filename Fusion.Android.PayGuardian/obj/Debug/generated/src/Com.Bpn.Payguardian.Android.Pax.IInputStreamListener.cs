using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bpn.Payguardian.Android.Pax {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bpn.payguardian.android.pax']/interface[@name='InputStreamListener']"
	[Register ("com/bpn/payguardian/android/pax/InputStreamListener", "", "Com.Bpn.Payguardian.Android.Pax.IInputStreamListenerInvoker")]
	public partial interface IInputStreamListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.pax']/interface[@name='InputStreamListener']/method[@name='dataRead' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("dataRead", "([BI)V", "GetDataRead_arrayBIHandler:Com.Bpn.Payguardian.Android.Pax.IInputStreamListenerInvoker, Fusion.Android.PayGuardian")]
		void DataRead (byte[] p0, int p1);

	}

	[global::Android.Runtime.Register ("com/bpn/payguardian/android/pax/InputStreamListener", DoNotGenerateAcw=true)]
	internal class IInputStreamListenerInvoker : global::Java.Lang.Object, IInputStreamListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bpn/payguardian/android/pax/InputStreamListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IInputStreamListenerInvoker); }
		}

		IntPtr class_ref;

		public static IInputStreamListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInputStreamListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bpn.payguardian.android.pax.InputStreamListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInputStreamListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_dataRead_arrayBI;
#pragma warning disable 0169
		static Delegate GetDataRead_arrayBIHandler ()
		{
			if (cb_dataRead_arrayBI == null)
				cb_dataRead_arrayBI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_DataRead_arrayBI);
			return cb_dataRead_arrayBI;
		}

		static void n_DataRead_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Bpn.Payguardian.Android.Pax.IInputStreamListener __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Pax.IInputStreamListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.DataRead (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_dataRead_arrayBI;
		public unsafe void DataRead (byte[] p0, int p1)
		{
			if (id_dataRead_arrayBI == IntPtr.Zero)
				id_dataRead_arrayBI = JNIEnv.GetMethodID (class_ref, "dataRead", "([BI)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dataRead_arrayBI, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

	public partial class InputStreamEventArgs : global::System.EventArgs {

		public InputStreamEventArgs (byte[] p0, int p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		byte[] p0;
		public byte[] P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/bpn/payguardian/android/pax/InputStreamListenerImplementor")]
	internal sealed partial class IInputStreamListenerImplementor : global::Java.Lang.Object, IInputStreamListener {

		object sender;

		public IInputStreamListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/bpn/payguardian/android/pax/InputStreamListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<InputStreamEventArgs> Handler;
#pragma warning restore 0649

		public void DataRead (byte[] p0, int p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new InputStreamEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IInputStreamListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
