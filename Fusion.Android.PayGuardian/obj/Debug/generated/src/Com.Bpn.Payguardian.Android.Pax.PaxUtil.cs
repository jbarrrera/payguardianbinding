using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bpn.Payguardian.Android.Pax {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.pax']/class[@name='PaxUtil']"
	[global::Android.Runtime.Register ("com/bpn/payguardian/android/pax/PaxUtil", DoNotGenerateAcw=true)]
	public partial class PaxUtil : global::Java.Lang.Object, global::Com.Bpn.Payguardian.Android.Pax.IInputStreamListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bpn/payguardian/android/pax/PaxUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PaxUtil); }
		}

		protected PaxUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Bpn.Payguardian.Android.Pax.PaxUtil Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.pax']/class[@name='PaxUtil']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/bpn/payguardian/android/pax/PaxUtil;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/bpn/payguardian/android/pax/PaxUtil;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Pax.PaxUtil> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Pax.PaxUtil __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Pax.PaxUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.pax']/class[@name='PaxUtil']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
			} finally {
			}
		}

		static Delegate cb_connect;
#pragma warning disable 0169
		static Delegate GetConnectHandler ()
		{
			if (cb_connect == null)
				cb_connect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Connect);
			return cb_connect;
		}

		static bool n_Connect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Pax.PaxUtil __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Pax.PaxUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Connect ();
		}
#pragma warning restore 0169

		static IntPtr id_connect;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.pax']/class[@name='PaxUtil']/method[@name='connect' and count(parameter)=0]"
		[Register ("connect", "()Z", "GetConnectHandler")]
		public virtual unsafe bool Connect ()
		{
			if (id_connect == IntPtr.Zero)
				id_connect = JNIEnv.GetMethodID (class_ref, "connect", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_connect);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connect", "()Z"));
			} finally {
			}
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
			global::Com.Bpn.Payguardian.Android.Pax.PaxUtil __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Pax.PaxUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.DataRead (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_dataRead_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.pax']/class[@name='PaxUtil']/method[@name='dataRead' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("dataRead", "([BI)V", "GetDataRead_arrayBIHandler")]
		public virtual unsafe void DataRead (byte[] p0, int p1)
		{
			if (id_dataRead_arrayBI == IntPtr.Zero)
				id_dataRead_arrayBI = JNIEnv.GetMethodID (class_ref, "dataRead", "([BI)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dataRead_arrayBI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dataRead", "([BI)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_open;
#pragma warning disable 0169
		static Delegate GetOpenHandler ()
		{
			if (cb_open == null)
				cb_open = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Open);
			return cb_open;
		}

		static bool n_Open (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Pax.PaxUtil __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Pax.PaxUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Open ();
		}
#pragma warning restore 0169

		static IntPtr id_open;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.pax']/class[@name='PaxUtil']/method[@name='open' and count(parameter)=0]"
		[Register ("open", "()Z", "GetOpenHandler")]
		public virtual unsafe bool Open ()
		{
			if (id_open == IntPtr.Zero)
				id_open = JNIEnv.GetMethodID (class_ref, "open", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_open);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "open", "()Z"));
			} finally {
			}
		}

		static Delegate cb_promptMessage_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPromptMessage_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_promptMessage_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_promptMessage_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PromptMessage_Ljava_lang_String_Ljava_lang_String_);
			return cb_promptMessage_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_PromptMessage_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bpn.Payguardian.Android.Pax.PaxUtil __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Pax.PaxUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PromptMessage (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_promptMessage_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.pax']/class[@name='PaxUtil']/method[@name='promptMessage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("promptMessage", "(Ljava/lang/String;Ljava/lang/String;)V", "GetPromptMessage_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void PromptMessage (string p0, string p1)
		{
			if (id_promptMessage_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_promptMessage_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "promptMessage", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_promptMessage_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "promptMessage", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_readCardData_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReadCardData_Ljava_lang_String_Handler ()
		{
			if (cb_readCardData_Ljava_lang_String_ == null)
				cb_readCardData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReadCardData_Ljava_lang_String_);
			return cb_readCardData_Ljava_lang_String_;
		}

		static IntPtr n_ReadCardData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Pax.PaxUtil __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Pax.PaxUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.ReadCardData (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_readCardData_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.pax']/class[@name='PaxUtil']/method[@name='readCardData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("readCardData", "(Ljava/lang/String;)[Ljava/lang/String;", "GetReadCardData_Ljava_lang_String_Handler")]
		public virtual unsafe string[] ReadCardData (string p0)
		{
			if (id_readCardData_Ljava_lang_String_ == IntPtr.Zero)
				id_readCardData_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "readCardData", "(Ljava/lang/String;)[Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readCardData_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				else
					__ret = (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readCardData", "(Ljava/lang/String;)[Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_removeCard_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveCard_Ljava_lang_String_Handler ()
		{
			if (cb_removeCard_Ljava_lang_String_ == null)
				cb_removeCard_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveCard_Ljava_lang_String_);
			return cb_removeCard_Ljava_lang_String_;
		}

		static void n_RemoveCard_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Pax.PaxUtil __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Pax.PaxUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveCard (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeCard_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.pax']/class[@name='PaxUtil']/method[@name='removeCard' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeCard", "(Ljava/lang/String;)V", "GetRemoveCard_Ljava_lang_String_Handler")]
		public virtual unsafe void RemoveCard (string p0)
		{
			if (id_removeCard_Ljava_lang_String_ == IntPtr.Zero)
				id_removeCard_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeCard", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeCard_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeCard", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setSessionKey;
#pragma warning disable 0169
		static Delegate GetSetSessionKeyHandler ()
		{
			if (cb_setSessionKey == null)
				cb_setSessionKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_SetSessionKey);
			return cb_setSessionKey;
		}

		static bool n_SetSessionKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Pax.PaxUtil __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Pax.PaxUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetSessionKey ();
		}
#pragma warning restore 0169

		static IntPtr id_setSessionKey;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.pax']/class[@name='PaxUtil']/method[@name='setSessionKey' and count(parameter)=0]"
		[Register ("setSessionKey", "()Z", "GetSetSessionKeyHandler")]
		public virtual unsafe bool SetSessionKey ()
		{
			if (id_setSessionKey == IntPtr.Zero)
				id_setSessionKey = JNIEnv.GetMethodID (class_ref, "setSessionKey", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setSessionKey);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSessionKey", "()Z"));
			} finally {
			}
		}

	}
}
