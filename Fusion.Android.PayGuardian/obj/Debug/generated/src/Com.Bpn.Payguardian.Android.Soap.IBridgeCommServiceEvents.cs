using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bpn.Payguardian.Android.Soap {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bpn.payguardian.android.soap']/interface[@name='BridgeCommServiceEvents']"
	[Register ("com/bpn/payguardian/android/soap/BridgeCommServiceEvents", "", "Com.Bpn.Payguardian.Android.Soap.IBridgeCommServiceEventsInvoker")]
	public partial interface IBridgeCommServiceEvents : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.soap']/interface[@name='BridgeCommServiceEvents']/method[@name='bridgeCommServiceCompleted' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("bridgeCommServiceCompleted", "(Ljava/lang/String;)V", "GetBridgeCommServiceCompleted_Ljava_lang_String_Handler:Com.Bpn.Payguardian.Android.Soap.IBridgeCommServiceEventsInvoker, Fusion.Android.PayGuardian")]
		void BridgeCommServiceCompleted (string p0);

	}

	[global::Android.Runtime.Register ("com/bpn/payguardian/android/soap/BridgeCommServiceEvents", DoNotGenerateAcw=true)]
	internal class IBridgeCommServiceEventsInvoker : global::Java.Lang.Object, IBridgeCommServiceEvents {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bpn/payguardian/android/soap/BridgeCommServiceEvents");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBridgeCommServiceEventsInvoker); }
		}

		IntPtr class_ref;

		public static IBridgeCommServiceEvents GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBridgeCommServiceEvents> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bpn.payguardian.android.soap.BridgeCommServiceEvents"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBridgeCommServiceEventsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_bridgeCommServiceCompleted_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetBridgeCommServiceCompleted_Ljava_lang_String_Handler ()
		{
			if (cb_bridgeCommServiceCompleted_Ljava_lang_String_ == null)
				cb_bridgeCommServiceCompleted_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_BridgeCommServiceCompleted_Ljava_lang_String_);
			return cb_bridgeCommServiceCompleted_Ljava_lang_String_;
		}

		static void n_BridgeCommServiceCompleted_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Soap.IBridgeCommServiceEvents __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Soap.IBridgeCommServiceEvents> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BridgeCommServiceCompleted (p0);
		}
#pragma warning restore 0169

		IntPtr id_bridgeCommServiceCompleted_Ljava_lang_String_;
		public unsafe void BridgeCommServiceCompleted (string p0)
		{
			if (id_bridgeCommServiceCompleted_Ljava_lang_String_ == IntPtr.Zero)
				id_bridgeCommServiceCompleted_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "bridgeCommServiceCompleted", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_bridgeCommServiceCompleted_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
