using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bpn.Payguardian.Android.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='ConnectionManager']"
	[global::Android.Runtime.Register ("com/bpn/payguardian/android/util/ConnectionManager", DoNotGenerateAcw=true)]
	public partial class ConnectionManager : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bpn/payguardian/android/util/ConnectionManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConnectionManager); }
		}

		protected ConnectionManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='ConnectionManager']/constructor[@name='ConnectionManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConnectionManager ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ConnectionManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Bpn.Payguardian.Android.Util.ConnectionManager Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='ConnectionManager']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/bpn/payguardian/android/util/ConnectionManager;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/bpn/payguardian/android/util/ConnectionManager;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.ConnectionManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isNetworkAvailable_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetIsNetworkAvailable_Landroid_content_Context_Handler ()
		{
			if (cb_isNetworkAvailable_Landroid_content_Context_ == null)
				cb_isNetworkAvailable_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsNetworkAvailable_Landroid_content_Context_);
			return cb_isNetworkAvailable_Landroid_content_Context_;
		}

		static bool n_IsNetworkAvailable_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Util.ConnectionManager __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.ConnectionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsNetworkAvailable (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isNetworkAvailable_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='ConnectionManager']/method[@name='isNetworkAvailable' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isNetworkAvailable", "(Landroid/content/Context;)Z", "GetIsNetworkAvailable_Landroid_content_Context_Handler")]
		public virtual unsafe bool IsNetworkAvailable (global::Android.Content.Context p0)
		{
			if (id_isNetworkAvailable_Landroid_content_Context_ == IntPtr.Zero)
				id_isNetworkAvailable_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "isNetworkAvailable", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isNetworkAvailable_Landroid_content_Context_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isNetworkAvailable", "(Landroid/content/Context;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
