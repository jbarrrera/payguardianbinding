using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bpn.Payguardian.Android.Pax {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.pax']/class[@name='InputStreamReader']"
	[global::Android.Runtime.Register ("com/bpn/payguardian/android/pax/InputStreamReader", DoNotGenerateAcw=true)]
	public partial class InputStreamReader : global::Java.Lang.Object, global::Java.Lang.IRunnable {


		static IntPtr bytes_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.pax']/class[@name='InputStreamReader']/field[@name='bytes']"
		[Register ("bytes")]
		protected IList<byte> Bytes {
			get {
				if (bytes_jfieldId == IntPtr.Zero)
					bytes_jfieldId = JNIEnv.GetFieldID (class_ref, "bytes", "[B");
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, bytes_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (bytes_jfieldId == IntPtr.Zero)
					bytes_jfieldId = JNIEnv.GetFieldID (class_ref, "bytes", "[B");
				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, bytes_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr in_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.pax']/class[@name='InputStreamReader']/field[@name='in']"
		[Register ("in")]
		protected global::System.IO.Stream In {
			get {
				if (in_jfieldId == IntPtr.Zero)
					in_jfieldId = JNIEnv.GetFieldID (class_ref, "in", "Ljava/io/InputStream;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, in_jfieldId);
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (in_jfieldId == IntPtr.Zero)
					in_jfieldId = JNIEnv.GetFieldID (class_ref, "in", "Ljava/io/InputStream;");
				IntPtr native_value = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, in_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr listeners_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.pax']/class[@name='InputStreamReader']/field[@name='listeners']"
		[Register ("listeners")]
		protected global::System.Collections.IList Listeners {
			get {
				if (listeners_jfieldId == IntPtr.Zero)
					listeners_jfieldId = JNIEnv.GetFieldID (class_ref, "listeners", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, listeners_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (listeners_jfieldId == IntPtr.Zero)
					listeners_jfieldId = JNIEnv.GetFieldID (class_ref, "listeners", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, listeners_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bpn/payguardian/android/pax/InputStreamReader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InputStreamReader); }
		}

		protected InputStreamReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_InputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bpn.payguardian.android.pax']/class[@name='InputStreamReader']/constructor[@name='InputStreamReader' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register (".ctor", "(Ljava/io/InputStream;)V", "")]
		public unsafe InputStreamReader (global::System.IO.Stream p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (InputStreamReader)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/io/InputStream;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/InputStream;)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_InputStream_ == IntPtr.Zero)
					id_ctor_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/InputStream;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_InputStream_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_InputStream_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_addChangeListener_Lcom_bpn_payguardian_android_pax_InputStreamListener_;
#pragma warning disable 0169
		static Delegate GetAddChangeListener_Lcom_bpn_payguardian_android_pax_InputStreamListener_Handler ()
		{
			if (cb_addChangeListener_Lcom_bpn_payguardian_android_pax_InputStreamListener_ == null)
				cb_addChangeListener_Lcom_bpn_payguardian_android_pax_InputStreamListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddChangeListener_Lcom_bpn_payguardian_android_pax_InputStreamListener_);
			return cb_addChangeListener_Lcom_bpn_payguardian_android_pax_InputStreamListener_;
		}

		static void n_AddChangeListener_Lcom_bpn_payguardian_android_pax_InputStreamListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Pax.InputStreamReader __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Pax.InputStreamReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bpn.Payguardian.Android.Pax.IInputStreamListener p0 = (global::Com.Bpn.Payguardian.Android.Pax.IInputStreamListener)global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Pax.IInputStreamListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddChangeListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addChangeListener_Lcom_bpn_payguardian_android_pax_InputStreamListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.pax']/class[@name='InputStreamReader']/method[@name='addChangeListener' and count(parameter)=1 and parameter[1][@type='com.bpn.payguardian.android.pax.InputStreamListener']]"
		[Register ("addChangeListener", "(Lcom/bpn/payguardian/android/pax/InputStreamListener;)V", "GetAddChangeListener_Lcom_bpn_payguardian_android_pax_InputStreamListener_Handler")]
		public virtual unsafe void AddChangeListener (global::Com.Bpn.Payguardian.Android.Pax.IInputStreamListener p0)
		{
			if (id_addChangeListener_Lcom_bpn_payguardian_android_pax_InputStreamListener_ == IntPtr.Zero)
				id_addChangeListener_Lcom_bpn_payguardian_android_pax_InputStreamListener_ = JNIEnv.GetMethodID (class_ref, "addChangeListener", "(Lcom/bpn/payguardian/android/pax/InputStreamListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addChangeListener_Lcom_bpn_payguardian_android_pax_InputStreamListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addChangeListener", "(Lcom/bpn/payguardian/android/pax/InputStreamListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeListeners;
#pragma warning disable 0169
		static Delegate GetRemoveListenersHandler ()
		{
			if (cb_removeListeners == null)
				cb_removeListeners = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveListeners);
			return cb_removeListeners;
		}

		static void n_RemoveListeners (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Pax.InputStreamReader __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Pax.InputStreamReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveListeners ();
		}
#pragma warning restore 0169

		static IntPtr id_removeListeners;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.pax']/class[@name='InputStreamReader']/method[@name='removeListeners' and count(parameter)=0]"
		[Register ("removeListeners", "()V", "GetRemoveListenersHandler")]
		public virtual unsafe void RemoveListeners ()
		{
			if (id_removeListeners == IntPtr.Zero)
				id_removeListeners = JNIEnv.GetMethodID (class_ref, "removeListeners", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeListeners);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeListeners", "()V"));
			} finally {
			}
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Pax.InputStreamReader __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Pax.InputStreamReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		static IntPtr id_run;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.pax']/class[@name='InputStreamReader']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual unsafe void Run ()
		{
			if (id_run == IntPtr.Zero)
				id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Pax.InputStreamReader __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Pax.InputStreamReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.pax']/class[@name='InputStreamReader']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
			} finally {
			}
		}

#region "Event implementation for Com.Bpn.Payguardian.Android.Pax.IInputStreamListener"
		public event EventHandler<global::Com.Bpn.Payguardian.Android.Pax.InputStreamEventArgs> Change {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Bpn.Payguardian.Android.Pax.IInputStreamListener, global::Com.Bpn.Payguardian.Android.Pax.IInputStreamListenerImplementor>(
						ref weak_implementor_AddChangeListener,
						__CreateIInputStreamListenerImplementor,
						AddChangeListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Bpn.Payguardian.Android.Pax.IInputStreamListener, global::Com.Bpn.Payguardian.Android.Pax.IInputStreamListenerImplementor>(
						ref weak_implementor_AddChangeListener,
						global::Com.Bpn.Payguardian.Android.Pax.IInputStreamListenerImplementor.__IsEmpty,
						__v => {throw new NotSupportedException ("Cannot unregister from Com.Bpn.Payguardian.Android.Pax.IInputStreamListener.AddChangeListener");},
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddChangeListener;

		global::Com.Bpn.Payguardian.Android.Pax.IInputStreamListenerImplementor __CreateIInputStreamListenerImplementor ()
		{
			return new global::Com.Bpn.Payguardian.Android.Pax.IInputStreamListenerImplementor (this);
		}
#endregion
	}
}
