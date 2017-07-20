using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bpn.Payguardian.Android.Payment {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse']"
	[global::Android.Runtime.Register ("com/bpn/payguardian/android/payment/AccountInquiryResponse", DoNotGenerateAcw=true)]
	public partial class AccountInquiryResponse : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse.AccountInquiryResponseMessage']"
		[global::Android.Runtime.Register ("com/bpn/payguardian/android/payment/AccountInquiryResponse$AccountInquiryResponseMessage", DoNotGenerateAcw=true)]
		public partial class AccountInquiryResponseMessage : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bpn/payguardian/android/payment/AccountInquiryResponse$AccountInquiryResponseMessage", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AccountInquiryResponseMessage); }
			}

			protected AccountInquiryResponseMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse.AccountInquiryResponseMessage']/constructor[@name='AccountInquiryResponse.AccountInquiryResponseMessage' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe AccountInquiryResponseMessage ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (AccountInquiryResponseMessage)) {
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

			static Delegate cb_getAuthorizationCode;
#pragma warning disable 0169
			static Delegate GetGetAuthorizationCodeHandler ()
			{
				if (cb_getAuthorizationCode == null)
					cb_getAuthorizationCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuthorizationCode);
				return cb_getAuthorizationCode;
			}

			static IntPtr n_GetAuthorizationCode (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.AuthorizationCode);
			}
#pragma warning restore 0169

			static Delegate cb_setAuthorizationCode_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetAuthorizationCode_Ljava_lang_String_Handler ()
			{
				if (cb_setAuthorizationCode_Ljava_lang_String_ == null)
					cb_setAuthorizationCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAuthorizationCode_Ljava_lang_String_);
				return cb_setAuthorizationCode_Ljava_lang_String_;
			}

			static void n_SetAuthorizationCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.AuthorizationCode = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getAuthorizationCode;
			static IntPtr id_setAuthorizationCode_Ljava_lang_String_;
			public virtual unsafe string AuthorizationCode {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse.AccountInquiryResponseMessage']/method[@name='getAuthorizationCode' and count(parameter)=0]"
				[Register ("getAuthorizationCode", "()Ljava/lang/String;", "GetGetAuthorizationCodeHandler")]
				get {
					if (id_getAuthorizationCode == IntPtr.Zero)
						id_getAuthorizationCode = JNIEnv.GetMethodID (class_ref, "getAuthorizationCode", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAuthorizationCode), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuthorizationCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse.AccountInquiryResponseMessage']/method[@name='setAuthorizationCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setAuthorizationCode", "(Ljava/lang/String;)V", "GetSetAuthorizationCode_Ljava_lang_String_Handler")]
				set {
					if (id_setAuthorizationCode_Ljava_lang_String_ == IntPtr.Zero)
						id_setAuthorizationCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAuthorizationCode", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAuthorizationCode_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAuthorizationCode", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getAvsMessage;
#pragma warning disable 0169
			static Delegate GetGetAvsMessageHandler ()
			{
				if (cb_getAvsMessage == null)
					cb_getAvsMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAvsMessage);
				return cb_getAvsMessage;
			}

			static IntPtr n_GetAvsMessage (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.AvsMessage);
			}
#pragma warning restore 0169

			static Delegate cb_setAvsMessage_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetAvsMessage_Ljava_lang_String_Handler ()
			{
				if (cb_setAvsMessage_Ljava_lang_String_ == null)
					cb_setAvsMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAvsMessage_Ljava_lang_String_);
				return cb_setAvsMessage_Ljava_lang_String_;
			}

			static void n_SetAvsMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.AvsMessage = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getAvsMessage;
			static IntPtr id_setAvsMessage_Ljava_lang_String_;
			public virtual unsafe string AvsMessage {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse.AccountInquiryResponseMessage']/method[@name='getAvsMessage' and count(parameter)=0]"
				[Register ("getAvsMessage", "()Ljava/lang/String;", "GetGetAvsMessageHandler")]
				get {
					if (id_getAvsMessage == IntPtr.Zero)
						id_getAvsMessage = JNIEnv.GetMethodID (class_ref, "getAvsMessage", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAvsMessage), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAvsMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse.AccountInquiryResponseMessage']/method[@name='setAvsMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setAvsMessage", "(Ljava/lang/String;)V", "GetSetAvsMessage_Ljava_lang_String_Handler")]
				set {
					if (id_setAvsMessage_Ljava_lang_String_ == IntPtr.Zero)
						id_setAvsMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAvsMessage", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAvsMessage_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAvsMessage", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getAvsResult;
#pragma warning disable 0169
			static Delegate GetGetAvsResultHandler ()
			{
				if (cb_getAvsResult == null)
					cb_getAvsResult = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAvsResult);
				return cb_getAvsResult;
			}

			static IntPtr n_GetAvsResult (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.AvsResult);
			}
#pragma warning restore 0169

			static Delegate cb_setAvsResult_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetAvsResult_Ljava_lang_String_Handler ()
			{
				if (cb_setAvsResult_Ljava_lang_String_ == null)
					cb_setAvsResult_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAvsResult_Ljava_lang_String_);
				return cb_setAvsResult_Ljava_lang_String_;
			}

			static void n_SetAvsResult_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.AvsResult = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getAvsResult;
			static IntPtr id_setAvsResult_Ljava_lang_String_;
			public virtual unsafe string AvsResult {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse.AccountInquiryResponseMessage']/method[@name='getAvsResult' and count(parameter)=0]"
				[Register ("getAvsResult", "()Ljava/lang/String;", "GetGetAvsResultHandler")]
				get {
					if (id_getAvsResult == IntPtr.Zero)
						id_getAvsResult = JNIEnv.GetMethodID (class_ref, "getAvsResult", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAvsResult), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAvsResult", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse.AccountInquiryResponseMessage']/method[@name='setAvsResult' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setAvsResult", "(Ljava/lang/String;)V", "GetSetAvsResult_Ljava_lang_String_Handler")]
				set {
					if (id_setAvsResult_Ljava_lang_String_ == IntPtr.Zero)
						id_setAvsResult_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAvsResult", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAvsResult_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAvsResult", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getBalance;
#pragma warning disable 0169
			static Delegate GetGetBalanceHandler ()
			{
				if (cb_getBalance == null)
					cb_getBalance = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBalance);
				return cb_getBalance;
			}

			static IntPtr n_GetBalance (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Balance);
			}
#pragma warning restore 0169

			static Delegate cb_setBalance_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetBalance_Ljava_lang_String_Handler ()
			{
				if (cb_setBalance_Ljava_lang_String_ == null)
					cb_setBalance_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBalance_Ljava_lang_String_);
				return cb_setBalance_Ljava_lang_String_;
			}

			static void n_SetBalance_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Balance = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getBalance;
			static IntPtr id_setBalance_Ljava_lang_String_;
			public virtual unsafe string Balance {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse.AccountInquiryResponseMessage']/method[@name='getBalance' and count(parameter)=0]"
				[Register ("getBalance", "()Ljava/lang/String;", "GetGetBalanceHandler")]
				get {
					if (id_getBalance == IntPtr.Zero)
						id_getBalance = JNIEnv.GetMethodID (class_ref, "getBalance", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBalance), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBalance", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse.AccountInquiryResponseMessage']/method[@name='setBalance' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setBalance", "(Ljava/lang/String;)V", "GetSetBalance_Ljava_lang_String_Handler")]
				set {
					if (id_setBalance_Ljava_lang_String_ == IntPtr.Zero)
						id_setBalance_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBalance", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBalance_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBalance", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getCvMessage;
#pragma warning disable 0169
			static Delegate GetGetCvMessageHandler ()
			{
				if (cb_getCvMessage == null)
					cb_getCvMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCvMessage);
				return cb_getCvMessage;
			}

			static IntPtr n_GetCvMessage (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.CvMessage);
			}
#pragma warning restore 0169

			static Delegate cb_setCvMessage_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetCvMessage_Ljava_lang_String_Handler ()
			{
				if (cb_setCvMessage_Ljava_lang_String_ == null)
					cb_setCvMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCvMessage_Ljava_lang_String_);
				return cb_setCvMessage_Ljava_lang_String_;
			}

			static void n_SetCvMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.CvMessage = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getCvMessage;
			static IntPtr id_setCvMessage_Ljava_lang_String_;
			public virtual unsafe string CvMessage {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse.AccountInquiryResponseMessage']/method[@name='getCvMessage' and count(parameter)=0]"
				[Register ("getCvMessage", "()Ljava/lang/String;", "GetGetCvMessageHandler")]
				get {
					if (id_getCvMessage == IntPtr.Zero)
						id_getCvMessage = JNIEnv.GetMethodID (class_ref, "getCvMessage", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCvMessage), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCvMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse.AccountInquiryResponseMessage']/method[@name='setCvMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setCvMessage", "(Ljava/lang/String;)V", "GetSetCvMessage_Ljava_lang_String_Handler")]
				set {
					if (id_setCvMessage_Ljava_lang_String_ == IntPtr.Zero)
						id_setCvMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCvMessage", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCvMessage_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCvMessage", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getCvResult;
#pragma warning disable 0169
			static Delegate GetGetCvResultHandler ()
			{
				if (cb_getCvResult == null)
					cb_getCvResult = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCvResult);
				return cb_getCvResult;
			}

			static IntPtr n_GetCvResult (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.CvResult);
			}
#pragma warning restore 0169

			static Delegate cb_setCvResult_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetCvResult_Ljava_lang_String_Handler ()
			{
				if (cb_setCvResult_Ljava_lang_String_ == null)
					cb_setCvResult_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCvResult_Ljava_lang_String_);
				return cb_setCvResult_Ljava_lang_String_;
			}

			static void n_SetCvResult_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.CvResult = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getCvResult;
			static IntPtr id_setCvResult_Ljava_lang_String_;
			public virtual unsafe string CvResult {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse.AccountInquiryResponseMessage']/method[@name='getCvResult' and count(parameter)=0]"
				[Register ("getCvResult", "()Ljava/lang/String;", "GetGetCvResultHandler")]
				get {
					if (id_getCvResult == IntPtr.Zero)
						id_getCvResult = JNIEnv.GetMethodID (class_ref, "getCvResult", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCvResult), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCvResult", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse.AccountInquiryResponseMessage']/method[@name='setCvResult' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setCvResult", "(Ljava/lang/String;)V", "GetSetCvResult_Ljava_lang_String_Handler")]
				set {
					if (id_setCvResult_Ljava_lang_String_ == IntPtr.Zero)
						id_setCvResult_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCvResult", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCvResult_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCvResult", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getExpirationDate;
#pragma warning disable 0169
			static Delegate GetGetExpirationDateHandler ()
			{
				if (cb_getExpirationDate == null)
					cb_getExpirationDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExpirationDate);
				return cb_getExpirationDate;
			}

			static IntPtr n_GetExpirationDate (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ExpirationDate);
			}
#pragma warning restore 0169

			static Delegate cb_setExpirationDate_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetExpirationDate_Ljava_lang_String_Handler ()
			{
				if (cb_setExpirationDate_Ljava_lang_String_ == null)
					cb_setExpirationDate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExpirationDate_Ljava_lang_String_);
				return cb_setExpirationDate_Ljava_lang_String_;
			}

			static void n_SetExpirationDate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.ExpirationDate = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getExpirationDate;
			static IntPtr id_setExpirationDate_Ljava_lang_String_;
			public virtual unsafe string ExpirationDate {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse.AccountInquiryResponseMessage']/method[@name='getExpirationDate' and count(parameter)=0]"
				[Register ("getExpirationDate", "()Ljava/lang/String;", "GetGetExpirationDateHandler")]
				get {
					if (id_getExpirationDate == IntPtr.Zero)
						id_getExpirationDate = JNIEnv.GetMethodID (class_ref, "getExpirationDate", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExpirationDate), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExpirationDate", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse.AccountInquiryResponseMessage']/method[@name='setExpirationDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setExpirationDate", "(Ljava/lang/String;)V", "GetSetExpirationDate_Ljava_lang_String_Handler")]
				set {
					if (id_setExpirationDate_Ljava_lang_String_ == IntPtr.Zero)
						id_setExpirationDate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setExpirationDate", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setExpirationDate_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExpirationDate", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getGatewayMessage;
#pragma warning disable 0169
			static Delegate GetGetGatewayMessageHandler ()
			{
				if (cb_getGatewayMessage == null)
					cb_getGatewayMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGatewayMessage);
				return cb_getGatewayMessage;
			}

			static IntPtr n_GetGatewayMessage (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.GatewayMessage);
			}
#pragma warning restore 0169

			static Delegate cb_setGatewayMessage_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetGatewayMessage_Ljava_lang_String_Handler ()
			{
				if (cb_setGatewayMessage_Ljava_lang_String_ == null)
					cb_setGatewayMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetGatewayMessage_Ljava_lang_String_);
				return cb_setGatewayMessage_Ljava_lang_String_;
			}

			static void n_SetGatewayMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.GatewayMessage = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getGatewayMessage;
			static IntPtr id_setGatewayMessage_Ljava_lang_String_;
			public virtual unsafe string GatewayMessage {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse.AccountInquiryResponseMessage']/method[@name='getGatewayMessage' and count(parameter)=0]"
				[Register ("getGatewayMessage", "()Ljava/lang/String;", "GetGetGatewayMessageHandler")]
				get {
					if (id_getGatewayMessage == IntPtr.Zero)
						id_getGatewayMessage = JNIEnv.GetMethodID (class_ref, "getGatewayMessage", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGatewayMessage), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGatewayMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse.AccountInquiryResponseMessage']/method[@name='setGatewayMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setGatewayMessage", "(Ljava/lang/String;)V", "GetSetGatewayMessage_Ljava_lang_String_Handler")]
				set {
					if (id_setGatewayMessage_Ljava_lang_String_ == IntPtr.Zero)
						id_setGatewayMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setGatewayMessage", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setGatewayMessage_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGatewayMessage", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getGatewayResult;
#pragma warning disable 0169
			static Delegate GetGetGatewayResultHandler ()
			{
				if (cb_getGatewayResult == null)
					cb_getGatewayResult = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGatewayResult);
				return cb_getGatewayResult;
			}

			static IntPtr n_GetGatewayResult (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.GatewayResult);
			}
#pragma warning restore 0169

			static Delegate cb_setGatewayResult_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetGatewayResult_Ljava_lang_String_Handler ()
			{
				if (cb_setGatewayResult_Ljava_lang_String_ == null)
					cb_setGatewayResult_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetGatewayResult_Ljava_lang_String_);
				return cb_setGatewayResult_Ljava_lang_String_;
			}

			static void n_SetGatewayResult_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.GatewayResult = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getGatewayResult;
			static IntPtr id_setGatewayResult_Ljava_lang_String_;
			public virtual unsafe string GatewayResult {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse.AccountInquiryResponseMessage']/method[@name='getGatewayResult' and count(parameter)=0]"
				[Register ("getGatewayResult", "()Ljava/lang/String;", "GetGetGatewayResultHandler")]
				get {
					if (id_getGatewayResult == IntPtr.Zero)
						id_getGatewayResult = JNIEnv.GetMethodID (class_ref, "getGatewayResult", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGatewayResult), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGatewayResult", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse.AccountInquiryResponseMessage']/method[@name='setGatewayResult' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setGatewayResult", "(Ljava/lang/String;)V", "GetSetGatewayResult_Ljava_lang_String_Handler")]
				set {
					if (id_setGatewayResult_Ljava_lang_String_ == IntPtr.Zero)
						id_setGatewayResult_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setGatewayResult", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setGatewayResult_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGatewayResult", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getProviderAvsCode;
#pragma warning disable 0169
			static Delegate GetGetProviderAvsCodeHandler ()
			{
				if (cb_getProviderAvsCode == null)
					cb_getProviderAvsCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProviderAvsCode);
				return cb_getProviderAvsCode;
			}

			static IntPtr n_GetProviderAvsCode (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ProviderAvsCode);
			}
#pragma warning restore 0169

			static Delegate cb_setProviderAvsCode_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetProviderAvsCode_Ljava_lang_String_Handler ()
			{
				if (cb_setProviderAvsCode_Ljava_lang_String_ == null)
					cb_setProviderAvsCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetProviderAvsCode_Ljava_lang_String_);
				return cb_setProviderAvsCode_Ljava_lang_String_;
			}

			static void n_SetProviderAvsCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.ProviderAvsCode = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getProviderAvsCode;
			static IntPtr id_setProviderAvsCode_Ljava_lang_String_;
			public virtual unsafe string ProviderAvsCode {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse.AccountInquiryResponseMessage']/method[@name='getProviderAvsCode' and count(parameter)=0]"
				[Register ("getProviderAvsCode", "()Ljava/lang/String;", "GetGetProviderAvsCodeHandler")]
				get {
					if (id_getProviderAvsCode == IntPtr.Zero)
						id_getProviderAvsCode = JNIEnv.GetMethodID (class_ref, "getProviderAvsCode", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProviderAvsCode), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProviderAvsCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse.AccountInquiryResponseMessage']/method[@name='setProviderAvsCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setProviderAvsCode", "(Ljava/lang/String;)V", "GetSetProviderAvsCode_Ljava_lang_String_Handler")]
				set {
					if (id_setProviderAvsCode_Ljava_lang_String_ == IntPtr.Zero)
						id_setProviderAvsCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setProviderAvsCode", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setProviderAvsCode_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setProviderAvsCode", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getProviderCvCode;
#pragma warning disable 0169
			static Delegate GetGetProviderCvCodeHandler ()
			{
				if (cb_getProviderCvCode == null)
					cb_getProviderCvCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProviderCvCode);
				return cb_getProviderCvCode;
			}

			static IntPtr n_GetProviderCvCode (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ProviderCvCode);
			}
#pragma warning restore 0169

			static Delegate cb_setProviderCvCode_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetProviderCvCode_Ljava_lang_String_Handler ()
			{
				if (cb_setProviderCvCode_Ljava_lang_String_ == null)
					cb_setProviderCvCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetProviderCvCode_Ljava_lang_String_);
				return cb_setProviderCvCode_Ljava_lang_String_;
			}

			static void n_SetProviderCvCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.ProviderCvCode = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getProviderCvCode;
			static IntPtr id_setProviderCvCode_Ljava_lang_String_;
			public virtual unsafe string ProviderCvCode {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse.AccountInquiryResponseMessage']/method[@name='getProviderCvCode' and count(parameter)=0]"
				[Register ("getProviderCvCode", "()Ljava/lang/String;", "GetGetProviderCvCodeHandler")]
				get {
					if (id_getProviderCvCode == IntPtr.Zero)
						id_getProviderCvCode = JNIEnv.GetMethodID (class_ref, "getProviderCvCode", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProviderCvCode), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProviderCvCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse.AccountInquiryResponseMessage']/method[@name='setProviderCvCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setProviderCvCode", "(Ljava/lang/String;)V", "GetSetProviderCvCode_Ljava_lang_String_Handler")]
				set {
					if (id_setProviderCvCode_Ljava_lang_String_ == IntPtr.Zero)
						id_setProviderCvCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setProviderCvCode", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setProviderCvCode_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setProviderCvCode", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getProviderReferenceNumber;
#pragma warning disable 0169
			static Delegate GetGetProviderReferenceNumberHandler ()
			{
				if (cb_getProviderReferenceNumber == null)
					cb_getProviderReferenceNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProviderReferenceNumber);
				return cb_getProviderReferenceNumber;
			}

			static IntPtr n_GetProviderReferenceNumber (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ProviderReferenceNumber);
			}
#pragma warning restore 0169

			static Delegate cb_setProviderReferenceNumber_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetProviderReferenceNumber_Ljava_lang_String_Handler ()
			{
				if (cb_setProviderReferenceNumber_Ljava_lang_String_ == null)
					cb_setProviderReferenceNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetProviderReferenceNumber_Ljava_lang_String_);
				return cb_setProviderReferenceNumber_Ljava_lang_String_;
			}

			static void n_SetProviderReferenceNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.ProviderReferenceNumber = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getProviderReferenceNumber;
			static IntPtr id_setProviderReferenceNumber_Ljava_lang_String_;
			public virtual unsafe string ProviderReferenceNumber {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse.AccountInquiryResponseMessage']/method[@name='getProviderReferenceNumber' and count(parameter)=0]"
				[Register ("getProviderReferenceNumber", "()Ljava/lang/String;", "GetGetProviderReferenceNumberHandler")]
				get {
					if (id_getProviderReferenceNumber == IntPtr.Zero)
						id_getProviderReferenceNumber = JNIEnv.GetMethodID (class_ref, "getProviderReferenceNumber", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProviderReferenceNumber), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProviderReferenceNumber", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse.AccountInquiryResponseMessage']/method[@name='setProviderReferenceNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setProviderReferenceNumber", "(Ljava/lang/String;)V", "GetSetProviderReferenceNumber_Ljava_lang_String_Handler")]
				set {
					if (id_setProviderReferenceNumber_Ljava_lang_String_ == IntPtr.Zero)
						id_setProviderReferenceNumber_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setProviderReferenceNumber", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setProviderReferenceNumber_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setProviderReferenceNumber", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getReferenceNumber;
#pragma warning disable 0169
			static Delegate GetGetReferenceNumberHandler ()
			{
				if (cb_getReferenceNumber == null)
					cb_getReferenceNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReferenceNumber);
				return cb_getReferenceNumber;
			}

			static IntPtr n_GetReferenceNumber (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ReferenceNumber);
			}
#pragma warning restore 0169

			static Delegate cb_setReferenceNumber_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetReferenceNumber_Ljava_lang_String_Handler ()
			{
				if (cb_setReferenceNumber_Ljava_lang_String_ == null)
					cb_setReferenceNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetReferenceNumber_Ljava_lang_String_);
				return cb_setReferenceNumber_Ljava_lang_String_;
			}

			static void n_SetReferenceNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.ReferenceNumber = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getReferenceNumber;
			static IntPtr id_setReferenceNumber_Ljava_lang_String_;
			public virtual unsafe string ReferenceNumber {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse.AccountInquiryResponseMessage']/method[@name='getReferenceNumber' and count(parameter)=0]"
				[Register ("getReferenceNumber", "()Ljava/lang/String;", "GetGetReferenceNumberHandler")]
				get {
					if (id_getReferenceNumber == IntPtr.Zero)
						id_getReferenceNumber = JNIEnv.GetMethodID (class_ref, "getReferenceNumber", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getReferenceNumber), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReferenceNumber", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse.AccountInquiryResponseMessage']/method[@name='setReferenceNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setReferenceNumber", "(Ljava/lang/String;)V", "GetSetReferenceNumber_Ljava_lang_String_Handler")]
				set {
					if (id_setReferenceNumber_Ljava_lang_String_ == IntPtr.Zero)
						id_setReferenceNumber_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setReferenceNumber", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setReferenceNumber_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReferenceNumber", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getResponseType;
#pragma warning disable 0169
			static Delegate GetGetResponseTypeHandler ()
			{
				if (cb_getResponseType == null)
					cb_getResponseType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponseType);
				return cb_getResponseType;
			}

			static IntPtr n_GetResponseType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ResponseType);
			}
#pragma warning restore 0169

			static Delegate cb_setResponseType_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetResponseType_Ljava_lang_String_Handler ()
			{
				if (cb_setResponseType_Ljava_lang_String_ == null)
					cb_setResponseType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetResponseType_Ljava_lang_String_);
				return cb_setResponseType_Ljava_lang_String_;
			}

			static void n_SetResponseType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.ResponseType = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getResponseType;
			static IntPtr id_setResponseType_Ljava_lang_String_;
			public virtual unsafe string ResponseType {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse.AccountInquiryResponseMessage']/method[@name='getResponseType' and count(parameter)=0]"
				[Register ("getResponseType", "()Ljava/lang/String;", "GetGetResponseTypeHandler")]
				get {
					if (id_getResponseType == IntPtr.Zero)
						id_getResponseType = JNIEnv.GetMethodID (class_ref, "getResponseType", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponseType), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponseType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse.AccountInquiryResponseMessage']/method[@name='setResponseType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setResponseType", "(Ljava/lang/String;)V", "GetSetResponseType_Ljava_lang_String_Handler")]
				set {
					if (id_setResponseType_Ljava_lang_String_ == IntPtr.Zero)
						id_setResponseType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setResponseType", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setResponseType_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResponseType", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getToken;
#pragma warning disable 0169
			static Delegate GetGetTokenHandler ()
			{
				if (cb_getToken == null)
					cb_getToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetToken);
				return cb_getToken;
			}

			static IntPtr n_GetToken (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Token);
			}
#pragma warning restore 0169

			static Delegate cb_setToken_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetToken_Ljava_lang_String_Handler ()
			{
				if (cb_setToken_Ljava_lang_String_ == null)
					cb_setToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetToken_Ljava_lang_String_);
				return cb_setToken_Ljava_lang_String_;
			}

			static void n_SetToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Token = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getToken;
			static IntPtr id_setToken_Ljava_lang_String_;
			public virtual unsafe string Token {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse.AccountInquiryResponseMessage']/method[@name='getToken' and count(parameter)=0]"
				[Register ("getToken", "()Ljava/lang/String;", "GetGetTokenHandler")]
				get {
					if (id_getToken == IntPtr.Zero)
						id_getToken = JNIEnv.GetMethodID (class_ref, "getToken", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getToken), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getToken", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse.AccountInquiryResponseMessage']/method[@name='setToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setToken", "(Ljava/lang/String;)V", "GetSetToken_Ljava_lang_String_Handler")]
				set {
					if (id_setToken_Ljava_lang_String_ == IntPtr.Zero)
						id_setToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setToken", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setToken_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setToken", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getTransactionDate;
#pragma warning disable 0169
			static Delegate GetGetTransactionDateHandler ()
			{
				if (cb_getTransactionDate == null)
					cb_getTransactionDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransactionDate);
				return cb_getTransactionDate;
			}

			static IntPtr n_GetTransactionDate (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.TransactionDate);
			}
#pragma warning restore 0169

			static Delegate cb_setTransactionDate_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetTransactionDate_Ljava_lang_String_Handler ()
			{
				if (cb_setTransactionDate_Ljava_lang_String_ == null)
					cb_setTransactionDate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTransactionDate_Ljava_lang_String_);
				return cb_setTransactionDate_Ljava_lang_String_;
			}

			static void n_SetTransactionDate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.TransactionDate = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getTransactionDate;
			static IntPtr id_setTransactionDate_Ljava_lang_String_;
			public virtual unsafe string TransactionDate {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse.AccountInquiryResponseMessage']/method[@name='getTransactionDate' and count(parameter)=0]"
				[Register ("getTransactionDate", "()Ljava/lang/String;", "GetGetTransactionDateHandler")]
				get {
					if (id_getTransactionDate == IntPtr.Zero)
						id_getTransactionDate = JNIEnv.GetMethodID (class_ref, "getTransactionDate", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTransactionDate), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransactionDate", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse.AccountInquiryResponseMessage']/method[@name='setTransactionDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setTransactionDate", "(Ljava/lang/String;)V", "GetSetTransactionDate_Ljava_lang_String_Handler")]
				set {
					if (id_setTransactionDate_Ljava_lang_String_ == IntPtr.Zero)
						id_setTransactionDate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTransactionDate", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTransactionDate_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTransactionDate", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getTransactionType;
#pragma warning disable 0169
			static Delegate GetGetTransactionTypeHandler ()
			{
				if (cb_getTransactionType == null)
					cb_getTransactionType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransactionType);
				return cb_getTransactionType;
			}

			static IntPtr n_GetTransactionType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.TransactionType);
			}
#pragma warning restore 0169

			static Delegate cb_setTransactionType_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetTransactionType_Ljava_lang_String_Handler ()
			{
				if (cb_setTransactionType_Ljava_lang_String_ == null)
					cb_setTransactionType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTransactionType_Ljava_lang_String_);
				return cb_setTransactionType_Ljava_lang_String_;
			}

			static void n_SetTransactionType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.TransactionType = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getTransactionType;
			static IntPtr id_setTransactionType_Ljava_lang_String_;
			public virtual unsafe string TransactionType {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse.AccountInquiryResponseMessage']/method[@name='getTransactionType' and count(parameter)=0]"
				[Register ("getTransactionType", "()Ljava/lang/String;", "GetGetTransactionTypeHandler")]
				get {
					if (id_getTransactionType == IntPtr.Zero)
						id_getTransactionType = JNIEnv.GetMethodID (class_ref, "getTransactionType", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTransactionType), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransactionType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse.AccountInquiryResponseMessage']/method[@name='setTransactionType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setTransactionType", "(Ljava/lang/String;)V", "GetSetTransactionType_Ljava_lang_String_Handler")]
				set {
					if (id_setTransactionType_Ljava_lang_String_ == IntPtr.Zero)
						id_setTransactionType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTransactionType", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTransactionType_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTransactionType", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bpn/payguardian/android/payment/AccountInquiryResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AccountInquiryResponse); }
		}

		protected AccountInquiryResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse']/constructor[@name='AccountInquiryResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AccountInquiryResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AccountInquiryResponse)) {
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

		static Delegate cb_getRequestType;
#pragma warning disable 0169
		static Delegate GetGetRequestTypeHandler ()
		{
			if (cb_getRequestType == null)
				cb_getRequestType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestType);
			return cb_getRequestType;
		}

		static IntPtr n_GetRequestType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestType);
		}
#pragma warning restore 0169

		static Delegate cb_setRequestType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRequestType_Ljava_lang_String_Handler ()
		{
			if (cb_setRequestType_Ljava_lang_String_ == null)
				cb_setRequestType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRequestType_Ljava_lang_String_);
			return cb_setRequestType_Ljava_lang_String_;
		}

		static void n_SetRequestType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RequestType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRequestType;
		static IntPtr id_setRequestType_Ljava_lang_String_;
		public virtual unsafe string RequestType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse']/method[@name='getRequestType' and count(parameter)=0]"
			[Register ("getRequestType", "()Ljava/lang/String;", "GetGetRequestTypeHandler")]
			get {
				if (id_getRequestType == IntPtr.Zero)
					id_getRequestType = JNIEnv.GetMethodID (class_ref, "getRequestType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequestType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse']/method[@name='setRequestType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRequestType", "(Ljava/lang/String;)V", "GetSetRequestType_Ljava_lang_String_Handler")]
			set {
				if (id_setRequestType_Ljava_lang_String_ == IntPtr.Zero)
					id_setRequestType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRequestType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRequestType_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRequestType", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getResponseCode;
#pragma warning disable 0169
		static Delegate GetGetResponseCodeHandler ()
		{
			if (cb_getResponseCode == null)
				cb_getResponseCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponseCode);
			return cb_getResponseCode;
		}

		static IntPtr n_GetResponseCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ResponseCode);
		}
#pragma warning restore 0169

		static Delegate cb_setResponseCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetResponseCode_Ljava_lang_String_Handler ()
		{
			if (cb_setResponseCode_Ljava_lang_String_ == null)
				cb_setResponseCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetResponseCode_Ljava_lang_String_);
			return cb_setResponseCode_Ljava_lang_String_;
		}

		static void n_SetResponseCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ResponseCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getResponseCode;
		static IntPtr id_setResponseCode_Ljava_lang_String_;
		public virtual unsafe string ResponseCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse']/method[@name='getResponseCode' and count(parameter)=0]"
			[Register ("getResponseCode", "()Ljava/lang/String;", "GetGetResponseCodeHandler")]
			get {
				if (id_getResponseCode == IntPtr.Zero)
					id_getResponseCode = JNIEnv.GetMethodID (class_ref, "getResponseCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponseCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponseCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse']/method[@name='setResponseCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setResponseCode", "(Ljava/lang/String;)V", "GetSetResponseCode_Ljava_lang_String_Handler")]
			set {
				if (id_setResponseCode_Ljava_lang_String_ == IntPtr.Zero)
					id_setResponseCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setResponseCode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setResponseCode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResponseCode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getResponseDescription;
#pragma warning disable 0169
		static Delegate GetGetResponseDescriptionHandler ()
		{
			if (cb_getResponseDescription == null)
				cb_getResponseDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponseDescription);
			return cb_getResponseDescription;
		}

		static IntPtr n_GetResponseDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ResponseDescription);
		}
#pragma warning restore 0169

		static Delegate cb_setResponseDescription_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetResponseDescription_Ljava_lang_String_Handler ()
		{
			if (cb_setResponseDescription_Ljava_lang_String_ == null)
				cb_setResponseDescription_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetResponseDescription_Ljava_lang_String_);
			return cb_setResponseDescription_Ljava_lang_String_;
		}

		static void n_SetResponseDescription_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ResponseDescription = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getResponseDescription;
		static IntPtr id_setResponseDescription_Ljava_lang_String_;
		public virtual unsafe string ResponseDescription {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse']/method[@name='getResponseDescription' and count(parameter)=0]"
			[Register ("getResponseDescription", "()Ljava/lang/String;", "GetGetResponseDescriptionHandler")]
			get {
				if (id_getResponseDescription == IntPtr.Zero)
					id_getResponseDescription = JNIEnv.GetMethodID (class_ref, "getResponseDescription", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponseDescription), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponseDescription", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse']/method[@name='setResponseDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setResponseDescription", "(Ljava/lang/String;)V", "GetSetResponseDescription_Ljava_lang_String_Handler")]
			set {
				if (id_setResponseDescription_Ljava_lang_String_ == IntPtr.Zero)
					id_setResponseDescription_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setResponseDescription", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setResponseDescription_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResponseDescription", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getResponseMessage;
#pragma warning disable 0169
		static Delegate GetGetResponseMessageHandler ()
		{
			if (cb_getResponseMessage == null)
				cb_getResponseMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponseMessage);
			return cb_getResponseMessage;
		}

		static IntPtr n_GetResponseMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ResponseMessage);
		}
#pragma warning restore 0169

		static Delegate cb_setResponseMessage_Lcom_bpn_payguardian_android_payment_AccountInquiryResponse_AccountInquiryResponseMessage_;
#pragma warning disable 0169
		static Delegate GetSetResponseMessage_Lcom_bpn_payguardian_android_payment_AccountInquiryResponse_AccountInquiryResponseMessage_Handler ()
		{
			if (cb_setResponseMessage_Lcom_bpn_payguardian_android_payment_AccountInquiryResponse_AccountInquiryResponseMessage_ == null)
				cb_setResponseMessage_Lcom_bpn_payguardian_android_payment_AccountInquiryResponse_AccountInquiryResponseMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetResponseMessage_Lcom_bpn_payguardian_android_payment_AccountInquiryResponse_AccountInquiryResponseMessage_);
			return cb_setResponseMessage_Lcom_bpn_payguardian_android_payment_AccountInquiryResponse_AccountInquiryResponseMessage_;
		}

		static void n_SetResponseMessage_Lcom_bpn_payguardian_android_payment_AccountInquiryResponse_AccountInquiryResponseMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ResponseMessage = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getResponseMessage;
		static IntPtr id_setResponseMessage_Lcom_bpn_payguardian_android_payment_AccountInquiryResponse_AccountInquiryResponseMessage_;
		public virtual unsafe global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage ResponseMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse']/method[@name='getResponseMessage' and count(parameter)=0]"
			[Register ("getResponseMessage", "()Lcom/bpn/payguardian/android/payment/AccountInquiryResponse$AccountInquiryResponseMessage;", "GetGetResponseMessageHandler")]
			get {
				if (id_getResponseMessage == IntPtr.Zero)
					id_getResponseMessage = JNIEnv.GetMethodID (class_ref, "getResponseMessage", "()Lcom/bpn/payguardian/android/payment/AccountInquiryResponse$AccountInquiryResponseMessage;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponseMessage), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse.AccountInquiryResponseMessage> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponseMessage", "()Lcom/bpn/payguardian/android/payment/AccountInquiryResponse$AccountInquiryResponseMessage;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse']/method[@name='setResponseMessage' and count(parameter)=1 and parameter[1][@type='com.bpn.payguardian.android.payment.AccountInquiryResponse.AccountInquiryResponseMessage']]"
			[Register ("setResponseMessage", "(Lcom/bpn/payguardian/android/payment/AccountInquiryResponse$AccountInquiryResponseMessage;)V", "GetSetResponseMessage_Lcom_bpn_payguardian_android_payment_AccountInquiryResponse_AccountInquiryResponseMessage_Handler")]
			set {
				if (id_setResponseMessage_Lcom_bpn_payguardian_android_payment_AccountInquiryResponse_AccountInquiryResponseMessage_ == IntPtr.Zero)
					id_setResponseMessage_Lcom_bpn_payguardian_android_payment_AccountInquiryResponse_AccountInquiryResponseMessage_ = JNIEnv.GetMethodID (class_ref, "setResponseMessage", "(Lcom/bpn/payguardian/android/payment/AccountInquiryResponse$AccountInquiryResponseMessage;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setResponseMessage_Lcom_bpn_payguardian_android_payment_AccountInquiryResponse_AccountInquiryResponseMessage_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResponseMessage", "(Lcom/bpn/payguardian/android/payment/AccountInquiryResponse$AccountInquiryResponseMessage;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTransactionId;
#pragma warning disable 0169
		static Delegate GetGetTransactionIdHandler ()
		{
			if (cb_getTransactionId == null)
				cb_getTransactionId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransactionId);
			return cb_getTransactionId;
		}

		static IntPtr n_GetTransactionId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TransactionId);
		}
#pragma warning restore 0169

		static Delegate cb_setTransactionId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTransactionId_Ljava_lang_String_Handler ()
		{
			if (cb_setTransactionId_Ljava_lang_String_ == null)
				cb_setTransactionId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTransactionId_Ljava_lang_String_);
			return cb_setTransactionId_Ljava_lang_String_;
		}

		static void n_SetTransactionId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.AccountInquiryResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TransactionId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTransactionId;
		static IntPtr id_setTransactionId_Ljava_lang_String_;
		public virtual unsafe string TransactionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse']/method[@name='getTransactionId' and count(parameter)=0]"
			[Register ("getTransactionId", "()Ljava/lang/String;", "GetGetTransactionIdHandler")]
			get {
				if (id_getTransactionId == IntPtr.Zero)
					id_getTransactionId = JNIEnv.GetMethodID (class_ref, "getTransactionId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTransactionId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransactionId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='AccountInquiryResponse']/method[@name='setTransactionId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTransactionId", "(Ljava/lang/String;)V", "GetSetTransactionId_Ljava_lang_String_Handler")]
			set {
				if (id_setTransactionId_Ljava_lang_String_ == IntPtr.Zero)
					id_setTransactionId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTransactionId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTransactionId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTransactionId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
