using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bpn.Payguardian.Android.Exception {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='PayGuardianException']"
	[global::Android.Runtime.Register ("com/bpn/payguardian/android/exception/PayGuardianException", DoNotGenerateAcw=true)]
	public partial class PayGuardianException : global::Java.Lang.RuntimeException {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bpn/payguardian/android/exception/PayGuardianException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PayGuardianException); }
		}

		protected PayGuardianException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='PayGuardianException']/constructor[@name='PayGuardianException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe PayGuardianException (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (PayGuardianException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Lcom_bpn_payguardian_android_exception_ErrorCode_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='PayGuardianException']/constructor[@name='PayGuardianException' and count(parameter)=1 and parameter[1][@type='com.bpn.payguardian.android.exception.ErrorCode']]"
		[Register (".ctor", "(Lcom/bpn/payguardian/android/exception/ErrorCode;)V", "")]
		public unsafe PayGuardianException (global::Com.Bpn.Payguardian.Android.Exception.ErrorCode p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (PayGuardianException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/bpn/payguardian/android/exception/ErrorCode;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(Lcom/bpn/payguardian/android/exception/ErrorCode;)V", __args);
					return;
				}

				if (id_ctor_Lcom_bpn_payguardian_android_exception_ErrorCode_ == IntPtr.Zero)
					id_ctor_Lcom_bpn_payguardian_android_exception_ErrorCode_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bpn/payguardian/android/exception/ErrorCode;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bpn_payguardian_android_exception_ErrorCode_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Lcom_bpn_payguardian_android_exception_ErrorCode_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_bpn_payguardian_android_exception_ErrorCode_Ljava_lang_Throwable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='PayGuardianException']/constructor[@name='PayGuardianException' and count(parameter)=2 and parameter[1][@type='com.bpn.payguardian.android.exception.ErrorCode'] and parameter[2][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Lcom/bpn/payguardian/android/exception/ErrorCode;Ljava/lang/Throwable;)V", "")]
		public unsafe PayGuardianException (global::Com.Bpn.Payguardian.Android.Exception.ErrorCode p0, global::Java.Lang.Throwable p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (PayGuardianException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/bpn/payguardian/android/exception/ErrorCode;Ljava/lang/Throwable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(Lcom/bpn/payguardian/android/exception/ErrorCode;Ljava/lang/Throwable;)V", __args);
					return;
				}

				if (id_ctor_Lcom_bpn_payguardian_android_exception_ErrorCode_Ljava_lang_Throwable_ == IntPtr.Zero)
					id_ctor_Lcom_bpn_payguardian_android_exception_ErrorCode_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bpn/payguardian/android/exception/ErrorCode;Ljava/lang/Throwable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bpn_payguardian_android_exception_ErrorCode_Ljava_lang_Throwable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Lcom_bpn_payguardian_android_exception_ErrorCode_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='PayGuardianException']/constructor[@name='PayGuardianException' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe PayGuardianException (string p0, global::Java.Lang.Throwable p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (PayGuardianException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/Throwable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(Ljava/lang/String;Ljava/lang/Throwable;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Throwable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Lcom_bpn_payguardian_android_exception_ErrorCode_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='PayGuardianException']/constructor[@name='PayGuardianException' and count(parameter)=2 and parameter[1][@type='com.bpn.payguardian.android.exception.ErrorCode'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/bpn/payguardian/android/exception/ErrorCode;Ljava/lang/String;)V", "")]
		public unsafe PayGuardianException (global::Com.Bpn.Payguardian.Android.Exception.ErrorCode p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (PayGuardianException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/bpn/payguardian/android/exception/ErrorCode;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(Lcom/bpn/payguardian/android/exception/ErrorCode;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lcom_bpn_payguardian_android_exception_ErrorCode_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_bpn_payguardian_android_exception_ErrorCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bpn/payguardian/android/exception/ErrorCode;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bpn_payguardian_android_exception_ErrorCode_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Lcom_bpn_payguardian_android_exception_ErrorCode_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getErrorCode;
#pragma warning disable 0169
		static Delegate GetGetErrorCodeHandler ()
		{
			if (cb_getErrorCode == null)
				cb_getErrorCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetErrorCode);
			return cb_getErrorCode;
		}

		static IntPtr n_GetErrorCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Exception.PayGuardianException __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Exception.PayGuardianException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ErrorCode);
		}
#pragma warning restore 0169

		static IntPtr id_getErrorCode;
		public virtual unsafe global::Com.Bpn.Payguardian.Android.Exception.ErrorCode ErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='PayGuardianException']/method[@name='getErrorCode' and count(parameter)=0]"
			[Register ("getErrorCode", "()Lcom/bpn/payguardian/android/exception/ErrorCode;", "GetGetErrorCodeHandler")]
			get {
				if (id_getErrorCode == IntPtr.Zero)
					id_getErrorCode = JNIEnv.GetMethodID (class_ref, "getErrorCode", "()Lcom/bpn/payguardian/android/exception/ErrorCode;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Exception.ErrorCode> (JNIEnv.CallObjectMethod (((global::Java.Lang.Throwable) this).Handle, id_getErrorCode), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Exception.ErrorCode> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Throwable) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getErrorCode", "()Lcom/bpn/payguardian/android/exception/ErrorCode;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getErrorMessage;
#pragma warning disable 0169
		static Delegate GetGetErrorMessageHandler ()
		{
			if (cb_getErrorMessage == null)
				cb_getErrorMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetErrorMessage);
			return cb_getErrorMessage;
		}

		static IntPtr n_GetErrorMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Exception.PayGuardianException __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Exception.PayGuardianException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ErrorMessage);
		}
#pragma warning restore 0169

		static IntPtr id_getErrorMessage;
		public virtual unsafe string ErrorMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='PayGuardianException']/method[@name='getErrorMessage' and count(parameter)=0]"
			[Register ("getErrorMessage", "()Ljava/lang/String;", "GetGetErrorMessageHandler")]
			get {
				if (id_getErrorMessage == IntPtr.Zero)
					id_getErrorMessage = JNIEnv.GetMethodID (class_ref, "getErrorMessage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Throwable) this).Handle, id_getErrorMessage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Throwable) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getErrorMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
