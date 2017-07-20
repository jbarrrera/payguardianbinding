using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bpn.Payguardian.Android.Payment {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']"
	[global::Android.Runtime.Register ("com/bpn/payguardian/android/payment/PayloadReponseMessage", DoNotGenerateAcw=true)]
	public partial class PayloadReponseMessage : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bpn/payguardian/android/payment/PayloadReponseMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PayloadReponseMessage); }
		}

		protected PayloadReponseMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/constructor[@name='PayloadReponseMessage' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PayloadReponseMessage ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PayloadReponseMessage)) {
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
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AuthorizationCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAuthorizationCode;
		static IntPtr id_setAuthorizationCode_Ljava_lang_String_;
		public virtual unsafe string AuthorizationCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='getAuthorizationCode' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='setAuthorizationCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getAuthorizedAmount;
#pragma warning disable 0169
		static Delegate GetGetAuthorizedAmountHandler ()
		{
			if (cb_getAuthorizedAmount == null)
				cb_getAuthorizedAmount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuthorizedAmount);
			return cb_getAuthorizedAmount;
		}

		static IntPtr n_GetAuthorizedAmount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthorizedAmount);
		}
#pragma warning restore 0169

		static Delegate cb_setAuthorizedAmount_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAuthorizedAmount_Ljava_lang_String_Handler ()
		{
			if (cb_setAuthorizedAmount_Ljava_lang_String_ == null)
				cb_setAuthorizedAmount_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAuthorizedAmount_Ljava_lang_String_);
			return cb_setAuthorizedAmount_Ljava_lang_String_;
		}

		static void n_SetAuthorizedAmount_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AuthorizedAmount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAuthorizedAmount;
		static IntPtr id_setAuthorizedAmount_Ljava_lang_String_;
		public virtual unsafe string AuthorizedAmount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='getAuthorizedAmount' and count(parameter)=0]"
			[Register ("getAuthorizedAmount", "()Ljava/lang/String;", "GetGetAuthorizedAmountHandler")]
			get {
				if (id_getAuthorizedAmount == IntPtr.Zero)
					id_getAuthorizedAmount = JNIEnv.GetMethodID (class_ref, "getAuthorizedAmount", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAuthorizedAmount), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuthorizedAmount", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='setAuthorizedAmount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAuthorizedAmount", "(Ljava/lang/String;)V", "GetSetAuthorizedAmount_Ljava_lang_String_Handler")]
			set {
				if (id_setAuthorizedAmount_Ljava_lang_String_ == IntPtr.Zero)
					id_setAuthorizedAmount_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAuthorizedAmount", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAuthorizedAmount_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAuthorizedAmount", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AvsMessage = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAvsMessage;
		static IntPtr id_setAvsMessage_Ljava_lang_String_;
		public virtual unsafe string AvsMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='getAvsMessage' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='setAvsMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AvsResult = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAvsResult;
		static IntPtr id_setAvsResult_Ljava_lang_String_;
		public virtual unsafe string AvsResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='getAvsResult' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='setAvsResult' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getCardType;
#pragma warning disable 0169
		static Delegate GetGetCardTypeHandler ()
		{
			if (cb_getCardType == null)
				cb_getCardType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCardType);
			return cb_getCardType;
		}

		static IntPtr n_GetCardType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CardType);
		}
#pragma warning restore 0169

		static Delegate cb_setCardType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCardType_Ljava_lang_String_Handler ()
		{
			if (cb_setCardType_Ljava_lang_String_ == null)
				cb_setCardType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCardType_Ljava_lang_String_);
			return cb_setCardType_Ljava_lang_String_;
		}

		static void n_SetCardType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CardType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCardType;
		static IntPtr id_setCardType_Ljava_lang_String_;
		public virtual unsafe string CardType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='getCardType' and count(parameter)=0]"
			[Register ("getCardType", "()Ljava/lang/String;", "GetGetCardTypeHandler")]
			get {
				if (id_getCardType == IntPtr.Zero)
					id_getCardType = JNIEnv.GetMethodID (class_ref, "getCardType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCardType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCardType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='setCardType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCardType", "(Ljava/lang/String;)V", "GetSetCardType_Ljava_lang_String_Handler")]
			set {
				if (id_setCardType_Ljava_lang_String_ == IntPtr.Zero)
					id_setCardType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCardType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCardType_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCardType", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CvMessage = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCvMessage;
		static IntPtr id_setCvMessage_Ljava_lang_String_;
		public virtual unsafe string CvMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='getCvMessage' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='setCvMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CvResult = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCvResult;
		static IntPtr id_setCvResult_Ljava_lang_String_;
		public virtual unsafe string CvResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='getCvResult' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='setCvResult' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ExpirationDate = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getExpirationDate;
		static IntPtr id_setExpirationDate_Ljava_lang_String_;
		public virtual unsafe string ExpirationDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='getExpirationDate' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='setExpirationDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GatewayMessage = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getGatewayMessage;
		static IntPtr id_setGatewayMessage_Ljava_lang_String_;
		public virtual unsafe string GatewayMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='getGatewayMessage' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='setGatewayMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GatewayResult = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getGatewayResult;
		static IntPtr id_setGatewayResult_Ljava_lang_String_;
		public virtual unsafe string GatewayResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='getGatewayResult' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='setGatewayResult' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getGatewayTransID;
#pragma warning disable 0169
		static Delegate GetGetGatewayTransIDHandler ()
		{
			if (cb_getGatewayTransID == null)
				cb_getGatewayTransID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGatewayTransID);
			return cb_getGatewayTransID;
		}

		static IntPtr n_GetGatewayTransID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GatewayTransID);
		}
#pragma warning restore 0169

		static Delegate cb_setGatewayTransID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetGatewayTransID_Ljava_lang_String_Handler ()
		{
			if (cb_setGatewayTransID_Ljava_lang_String_ == null)
				cb_setGatewayTransID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetGatewayTransID_Ljava_lang_String_);
			return cb_setGatewayTransID_Ljava_lang_String_;
		}

		static void n_SetGatewayTransID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GatewayTransID = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getGatewayTransID;
		static IntPtr id_setGatewayTransID_Ljava_lang_String_;
		public virtual unsafe string GatewayTransID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='getGatewayTransID' and count(parameter)=0]"
			[Register ("getGatewayTransID", "()Ljava/lang/String;", "GetGetGatewayTransIDHandler")]
			get {
				if (id_getGatewayTransID == IntPtr.Zero)
					id_getGatewayTransID = JNIEnv.GetMethodID (class_ref, "getGatewayTransID", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGatewayTransID), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGatewayTransID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='setGatewayTransID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setGatewayTransID", "(Ljava/lang/String;)V", "GetSetGatewayTransID_Ljava_lang_String_Handler")]
			set {
				if (id_setGatewayTransID_Ljava_lang_String_ == IntPtr.Zero)
					id_setGatewayTransID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setGatewayTransID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setGatewayTransID_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGatewayTransID", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getInternalMessage;
#pragma warning disable 0169
		static Delegate GetGetInternalMessageHandler ()
		{
			if (cb_getInternalMessage == null)
				cb_getInternalMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInternalMessage);
			return cb_getInternalMessage;
		}

		static IntPtr n_GetInternalMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.InternalMessage);
		}
#pragma warning restore 0169

		static Delegate cb_setInternalMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetInternalMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setInternalMessage_Ljava_lang_String_ == null)
				cb_setInternalMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInternalMessage_Ljava_lang_String_);
			return cb_setInternalMessage_Ljava_lang_String_;
		}

		static void n_SetInternalMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InternalMessage = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getInternalMessage;
		static IntPtr id_setInternalMessage_Ljava_lang_String_;
		public virtual unsafe string InternalMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='getInternalMessage' and count(parameter)=0]"
			[Register ("getInternalMessage", "()Ljava/lang/String;", "GetGetInternalMessageHandler")]
			get {
				if (id_getInternalMessage == IntPtr.Zero)
					id_getInternalMessage = JNIEnv.GetMethodID (class_ref, "getInternalMessage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInternalMessage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInternalMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='setInternalMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setInternalMessage", "(Ljava/lang/String;)V", "GetSetInternalMessage_Ljava_lang_String_Handler")]
			set {
				if (id_setInternalMessage_Ljava_lang_String_ == IntPtr.Zero)
					id_setInternalMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setInternalMessage", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInternalMessage_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInternalMessage", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getIsCommercialCard;
#pragma warning disable 0169
		static Delegate GetGetIsCommercialCardHandler ()
		{
			if (cb_getIsCommercialCard == null)
				cb_getIsCommercialCard = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIsCommercialCard);
			return cb_getIsCommercialCard;
		}

		static IntPtr n_GetIsCommercialCard (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IsCommercialCard);
		}
#pragma warning restore 0169

		static Delegate cb_setIsCommercialCard_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetIsCommercialCard_Ljava_lang_String_Handler ()
		{
			if (cb_setIsCommercialCard_Ljava_lang_String_ == null)
				cb_setIsCommercialCard_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIsCommercialCard_Ljava_lang_String_);
			return cb_setIsCommercialCard_Ljava_lang_String_;
		}

		static void n_SetIsCommercialCard_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IsCommercialCard = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIsCommercialCard;
		static IntPtr id_setIsCommercialCard_Ljava_lang_String_;
		public virtual unsafe string IsCommercialCard {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='getIsCommercialCard' and count(parameter)=0]"
			[Register ("getIsCommercialCard", "()Ljava/lang/String;", "GetGetIsCommercialCardHandler")]
			get {
				if (id_getIsCommercialCard == IntPtr.Zero)
					id_getIsCommercialCard = JNIEnv.GetMethodID (class_ref, "getIsCommercialCard", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIsCommercialCard), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIsCommercialCard", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='setIsCommercialCard' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setIsCommercialCard", "(Ljava/lang/String;)V", "GetSetIsCommercialCard_Ljava_lang_String_Handler")]
			set {
				if (id_setIsCommercialCard_Ljava_lang_String_ == IntPtr.Zero)
					id_setIsCommercialCard_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setIsCommercialCard", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIsCommercialCard_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIsCommercialCard", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getIsoCountryCode;
#pragma warning disable 0169
		static Delegate GetGetIsoCountryCodeHandler ()
		{
			if (cb_getIsoCountryCode == null)
				cb_getIsoCountryCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIsoCountryCode);
			return cb_getIsoCountryCode;
		}

		static IntPtr n_GetIsoCountryCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IsoCountryCode);
		}
#pragma warning restore 0169

		static Delegate cb_setIsoCountryCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetIsoCountryCode_Ljava_lang_String_Handler ()
		{
			if (cb_setIsoCountryCode_Ljava_lang_String_ == null)
				cb_setIsoCountryCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIsoCountryCode_Ljava_lang_String_);
			return cb_setIsoCountryCode_Ljava_lang_String_;
		}

		static void n_SetIsoCountryCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IsoCountryCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIsoCountryCode;
		static IntPtr id_setIsoCountryCode_Ljava_lang_String_;
		public virtual unsafe string IsoCountryCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='getIsoCountryCode' and count(parameter)=0]"
			[Register ("getIsoCountryCode", "()Ljava/lang/String;", "GetGetIsoCountryCodeHandler")]
			get {
				if (id_getIsoCountryCode == IntPtr.Zero)
					id_getIsoCountryCode = JNIEnv.GetMethodID (class_ref, "getIsoCountryCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIsoCountryCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIsoCountryCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='setIsoCountryCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setIsoCountryCode", "(Ljava/lang/String;)V", "GetSetIsoCountryCode_Ljava_lang_String_Handler")]
			set {
				if (id_setIsoCountryCode_Ljava_lang_String_ == IntPtr.Zero)
					id_setIsoCountryCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setIsoCountryCode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIsoCountryCode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIsoCountryCode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getIsoCurrencyCode;
#pragma warning disable 0169
		static Delegate GetGetIsoCurrencyCodeHandler ()
		{
			if (cb_getIsoCurrencyCode == null)
				cb_getIsoCurrencyCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIsoCurrencyCode);
			return cb_getIsoCurrencyCode;
		}

		static IntPtr n_GetIsoCurrencyCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IsoCurrencyCode);
		}
#pragma warning restore 0169

		static Delegate cb_setIsoCurrencyCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetIsoCurrencyCode_Ljava_lang_String_Handler ()
		{
			if (cb_setIsoCurrencyCode_Ljava_lang_String_ == null)
				cb_setIsoCurrencyCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIsoCurrencyCode_Ljava_lang_String_);
			return cb_setIsoCurrencyCode_Ljava_lang_String_;
		}

		static void n_SetIsoCurrencyCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IsoCurrencyCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIsoCurrencyCode;
		static IntPtr id_setIsoCurrencyCode_Ljava_lang_String_;
		public virtual unsafe string IsoCurrencyCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='getIsoCurrencyCode' and count(parameter)=0]"
			[Register ("getIsoCurrencyCode", "()Ljava/lang/String;", "GetGetIsoCurrencyCodeHandler")]
			get {
				if (id_getIsoCurrencyCode == IntPtr.Zero)
					id_getIsoCurrencyCode = JNIEnv.GetMethodID (class_ref, "getIsoCurrencyCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIsoCurrencyCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIsoCurrencyCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='setIsoCurrencyCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setIsoCurrencyCode", "(Ljava/lang/String;)V", "GetSetIsoCurrencyCode_Ljava_lang_String_Handler")]
			set {
				if (id_setIsoCurrencyCode_Ljava_lang_String_ == IntPtr.Zero)
					id_setIsoCurrencyCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setIsoCurrencyCode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIsoCurrencyCode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIsoCurrencyCode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getIsoRequestDate;
#pragma warning disable 0169
		static Delegate GetGetIsoRequestDateHandler ()
		{
			if (cb_getIsoRequestDate == null)
				cb_getIsoRequestDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIsoRequestDate);
			return cb_getIsoRequestDate;
		}

		static IntPtr n_GetIsoRequestDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IsoRequestDate);
		}
#pragma warning restore 0169

		static Delegate cb_setIsoRequestDate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetIsoRequestDate_Ljava_lang_String_Handler ()
		{
			if (cb_setIsoRequestDate_Ljava_lang_String_ == null)
				cb_setIsoRequestDate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIsoRequestDate_Ljava_lang_String_);
			return cb_setIsoRequestDate_Ljava_lang_String_;
		}

		static void n_SetIsoRequestDate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IsoRequestDate = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIsoRequestDate;
		static IntPtr id_setIsoRequestDate_Ljava_lang_String_;
		public virtual unsafe string IsoRequestDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='getIsoRequestDate' and count(parameter)=0]"
			[Register ("getIsoRequestDate", "()Ljava/lang/String;", "GetGetIsoRequestDateHandler")]
			get {
				if (id_getIsoRequestDate == IntPtr.Zero)
					id_getIsoRequestDate = JNIEnv.GetMethodID (class_ref, "getIsoRequestDate", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIsoRequestDate), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIsoRequestDate", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='setIsoRequestDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setIsoRequestDate", "(Ljava/lang/String;)V", "GetSetIsoRequestDate_Ljava_lang_String_Handler")]
			set {
				if (id_setIsoRequestDate_Ljava_lang_String_ == IntPtr.Zero)
					id_setIsoRequestDate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setIsoRequestDate", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIsoRequestDate_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIsoRequestDate", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getIsoTransactionDate;
#pragma warning disable 0169
		static Delegate GetGetIsoTransactionDateHandler ()
		{
			if (cb_getIsoTransactionDate == null)
				cb_getIsoTransactionDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIsoTransactionDate);
			return cb_getIsoTransactionDate;
		}

		static IntPtr n_GetIsoTransactionDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IsoTransactionDate);
		}
#pragma warning restore 0169

		static Delegate cb_setIsoTransactionDate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetIsoTransactionDate_Ljava_lang_String_Handler ()
		{
			if (cb_setIsoTransactionDate_Ljava_lang_String_ == null)
				cb_setIsoTransactionDate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIsoTransactionDate_Ljava_lang_String_);
			return cb_setIsoTransactionDate_Ljava_lang_String_;
		}

		static void n_SetIsoTransactionDate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IsoTransactionDate = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIsoTransactionDate;
		static IntPtr id_setIsoTransactionDate_Ljava_lang_String_;
		public virtual unsafe string IsoTransactionDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='getIsoTransactionDate' and count(parameter)=0]"
			[Register ("getIsoTransactionDate", "()Ljava/lang/String;", "GetGetIsoTransactionDateHandler")]
			get {
				if (id_getIsoTransactionDate == IntPtr.Zero)
					id_getIsoTransactionDate = JNIEnv.GetMethodID (class_ref, "getIsoTransactionDate", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIsoTransactionDate), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIsoTransactionDate", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='setIsoTransactionDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setIsoTransactionDate", "(Ljava/lang/String;)V", "GetSetIsoTransactionDate_Ljava_lang_String_Handler")]
			set {
				if (id_setIsoTransactionDate_Ljava_lang_String_ == IntPtr.Zero)
					id_setIsoTransactionDate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setIsoTransactionDate", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIsoTransactionDate_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIsoTransactionDate", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getIssuerTagData;
#pragma warning disable 0169
		static Delegate GetGetIssuerTagDataHandler ()
		{
			if (cb_getIssuerTagData == null)
				cb_getIssuerTagData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIssuerTagData);
			return cb_getIssuerTagData;
		}

		static IntPtr n_GetIssuerTagData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IssuerTagData);
		}
#pragma warning restore 0169

		static Delegate cb_setIssuerTagData_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetIssuerTagData_Ljava_lang_String_Handler ()
		{
			if (cb_setIssuerTagData_Ljava_lang_String_ == null)
				cb_setIssuerTagData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIssuerTagData_Ljava_lang_String_);
			return cb_setIssuerTagData_Ljava_lang_String_;
		}

		static void n_SetIssuerTagData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IssuerTagData = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIssuerTagData;
		static IntPtr id_setIssuerTagData_Ljava_lang_String_;
		public virtual unsafe string IssuerTagData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='getIssuerTagData' and count(parameter)=0]"
			[Register ("getIssuerTagData", "()Ljava/lang/String;", "GetGetIssuerTagDataHandler")]
			get {
				if (id_getIssuerTagData == IntPtr.Zero)
					id_getIssuerTagData = JNIEnv.GetMethodID (class_ref, "getIssuerTagData", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIssuerTagData), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIssuerTagData", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='setIssuerTagData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setIssuerTagData", "(Ljava/lang/String;)V", "GetSetIssuerTagData_Ljava_lang_String_Handler")]
			set {
				if (id_setIssuerTagData_Ljava_lang_String_ == IntPtr.Zero)
					id_setIssuerTagData_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setIssuerTagData", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIssuerTagData_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIssuerTagData", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMaskedPan;
#pragma warning disable 0169
		static Delegate GetGetMaskedPanHandler ()
		{
			if (cb_getMaskedPan == null)
				cb_getMaskedPan = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMaskedPan);
			return cb_getMaskedPan;
		}

		static IntPtr n_GetMaskedPan (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MaskedPan);
		}
#pragma warning restore 0169

		static Delegate cb_setMaskedPan_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMaskedPan_Ljava_lang_String_Handler ()
		{
			if (cb_setMaskedPan_Ljava_lang_String_ == null)
				cb_setMaskedPan_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMaskedPan_Ljava_lang_String_);
			return cb_setMaskedPan_Ljava_lang_String_;
		}

		static void n_SetMaskedPan_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MaskedPan = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaskedPan;
		static IntPtr id_setMaskedPan_Ljava_lang_String_;
		public virtual unsafe string MaskedPan {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='getMaskedPan' and count(parameter)=0]"
			[Register ("getMaskedPan", "()Ljava/lang/String;", "GetGetMaskedPanHandler")]
			get {
				if (id_getMaskedPan == IntPtr.Zero)
					id_getMaskedPan = JNIEnv.GetMethodID (class_ref, "getMaskedPan", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMaskedPan), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaskedPan", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='setMaskedPan' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMaskedPan", "(Ljava/lang/String;)V", "GetSetMaskedPan_Ljava_lang_String_Handler")]
			set {
				if (id_setMaskedPan_Ljava_lang_String_ == IntPtr.Zero)
					id_setMaskedPan_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMaskedPan", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMaskedPan_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaskedPan", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMerchantAccountCode;
#pragma warning disable 0169
		static Delegate GetGetMerchantAccountCodeHandler ()
		{
			if (cb_getMerchantAccountCode == null)
				cb_getMerchantAccountCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMerchantAccountCode);
			return cb_getMerchantAccountCode;
		}

		static IntPtr n_GetMerchantAccountCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MerchantAccountCode);
		}
#pragma warning restore 0169

		static Delegate cb_setMerchantAccountCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMerchantAccountCode_Ljava_lang_String_Handler ()
		{
			if (cb_setMerchantAccountCode_Ljava_lang_String_ == null)
				cb_setMerchantAccountCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMerchantAccountCode_Ljava_lang_String_);
			return cb_setMerchantAccountCode_Ljava_lang_String_;
		}

		static void n_SetMerchantAccountCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MerchantAccountCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMerchantAccountCode;
		static IntPtr id_setMerchantAccountCode_Ljava_lang_String_;
		public virtual unsafe string MerchantAccountCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='getMerchantAccountCode' and count(parameter)=0]"
			[Register ("getMerchantAccountCode", "()Ljava/lang/String;", "GetGetMerchantAccountCodeHandler")]
			get {
				if (id_getMerchantAccountCode == IntPtr.Zero)
					id_getMerchantAccountCode = JNIEnv.GetMethodID (class_ref, "getMerchantAccountCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMerchantAccountCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMerchantAccountCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='setMerchantAccountCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMerchantAccountCode", "(Ljava/lang/String;)V", "GetSetMerchantAccountCode_Ljava_lang_String_Handler")]
			set {
				if (id_setMerchantAccountCode_Ljava_lang_String_ == IntPtr.Zero)
					id_setMerchantAccountCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMerchantAccountCode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMerchantAccountCode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMerchantAccountCode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMerchantCategoryCode;
#pragma warning disable 0169
		static Delegate GetGetMerchantCategoryCodeHandler ()
		{
			if (cb_getMerchantCategoryCode == null)
				cb_getMerchantCategoryCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMerchantCategoryCode);
			return cb_getMerchantCategoryCode;
		}

		static IntPtr n_GetMerchantCategoryCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MerchantCategoryCode);
		}
#pragma warning restore 0169

		static Delegate cb_setMerchantCategoryCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMerchantCategoryCode_Ljava_lang_String_Handler ()
		{
			if (cb_setMerchantCategoryCode_Ljava_lang_String_ == null)
				cb_setMerchantCategoryCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMerchantCategoryCode_Ljava_lang_String_);
			return cb_setMerchantCategoryCode_Ljava_lang_String_;
		}

		static void n_SetMerchantCategoryCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MerchantCategoryCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMerchantCategoryCode;
		static IntPtr id_setMerchantCategoryCode_Ljava_lang_String_;
		public virtual unsafe string MerchantCategoryCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='getMerchantCategoryCode' and count(parameter)=0]"
			[Register ("getMerchantCategoryCode", "()Ljava/lang/String;", "GetGetMerchantCategoryCodeHandler")]
			get {
				if (id_getMerchantCategoryCode == IntPtr.Zero)
					id_getMerchantCategoryCode = JNIEnv.GetMethodID (class_ref, "getMerchantCategoryCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMerchantCategoryCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMerchantCategoryCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='setMerchantCategoryCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMerchantCategoryCode", "(Ljava/lang/String;)V", "GetSetMerchantCategoryCode_Ljava_lang_String_Handler")]
			set {
				if (id_setMerchantCategoryCode_Ljava_lang_String_ == IntPtr.Zero)
					id_setMerchantCategoryCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMerchantCategoryCode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMerchantCategoryCode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMerchantCategoryCode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMerchantCode;
#pragma warning disable 0169
		static Delegate GetGetMerchantCodeHandler ()
		{
			if (cb_getMerchantCode == null)
				cb_getMerchantCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMerchantCode);
			return cb_getMerchantCode;
		}

		static IntPtr n_GetMerchantCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MerchantCode);
		}
#pragma warning restore 0169

		static Delegate cb_setMerchantCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMerchantCode_Ljava_lang_String_Handler ()
		{
			if (cb_setMerchantCode_Ljava_lang_String_ == null)
				cb_setMerchantCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMerchantCode_Ljava_lang_String_);
			return cb_setMerchantCode_Ljava_lang_String_;
		}

		static void n_SetMerchantCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MerchantCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMerchantCode;
		static IntPtr id_setMerchantCode_Ljava_lang_String_;
		public virtual unsafe string MerchantCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='getMerchantCode' and count(parameter)=0]"
			[Register ("getMerchantCode", "()Ljava/lang/String;", "GetGetMerchantCodeHandler")]
			get {
				if (id_getMerchantCode == IntPtr.Zero)
					id_getMerchantCode = JNIEnv.GetMethodID (class_ref, "getMerchantCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMerchantCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMerchantCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='setMerchantCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMerchantCode", "(Ljava/lang/String;)V", "GetSetMerchantCode_Ljava_lang_String_Handler")]
			set {
				if (id_setMerchantCode_Ljava_lang_String_ == IntPtr.Zero)
					id_setMerchantCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMerchantCode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMerchantCode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMerchantCode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMerchantName;
#pragma warning disable 0169
		static Delegate GetGetMerchantNameHandler ()
		{
			if (cb_getMerchantName == null)
				cb_getMerchantName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMerchantName);
			return cb_getMerchantName;
		}

		static IntPtr n_GetMerchantName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MerchantName);
		}
#pragma warning restore 0169

		static Delegate cb_setMerchantName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMerchantName_Ljava_lang_String_Handler ()
		{
			if (cb_setMerchantName_Ljava_lang_String_ == null)
				cb_setMerchantName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMerchantName_Ljava_lang_String_);
			return cb_setMerchantName_Ljava_lang_String_;
		}

		static void n_SetMerchantName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MerchantName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMerchantName;
		static IntPtr id_setMerchantName_Ljava_lang_String_;
		public virtual unsafe string MerchantName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='getMerchantName' and count(parameter)=0]"
			[Register ("getMerchantName", "()Ljava/lang/String;", "GetGetMerchantNameHandler")]
			get {
				if (id_getMerchantName == IntPtr.Zero)
					id_getMerchantName = JNIEnv.GetMethodID (class_ref, "getMerchantName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMerchantName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMerchantName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='setMerchantName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMerchantName", "(Ljava/lang/String;)V", "GetSetMerchantName_Ljava_lang_String_Handler")]
			set {
				if (id_setMerchantName_Ljava_lang_String_ == IntPtr.Zero)
					id_setMerchantName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMerchantName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMerchantName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMerchantName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getNetworkMerchantId;
#pragma warning disable 0169
		static Delegate GetGetNetworkMerchantIdHandler ()
		{
			if (cb_getNetworkMerchantId == null)
				cb_getNetworkMerchantId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNetworkMerchantId);
			return cb_getNetworkMerchantId;
		}

		static IntPtr n_GetNetworkMerchantId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NetworkMerchantId);
		}
#pragma warning restore 0169

		static Delegate cb_setNetworkMerchantId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNetworkMerchantId_Ljava_lang_String_Handler ()
		{
			if (cb_setNetworkMerchantId_Ljava_lang_String_ == null)
				cb_setNetworkMerchantId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNetworkMerchantId_Ljava_lang_String_);
			return cb_setNetworkMerchantId_Ljava_lang_String_;
		}

		static void n_SetNetworkMerchantId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NetworkMerchantId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNetworkMerchantId;
		static IntPtr id_setNetworkMerchantId_Ljava_lang_String_;
		public virtual unsafe string NetworkMerchantId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='getNetworkMerchantId' and count(parameter)=0]"
			[Register ("getNetworkMerchantId", "()Ljava/lang/String;", "GetGetNetworkMerchantIdHandler")]
			get {
				if (id_getNetworkMerchantId == IntPtr.Zero)
					id_getNetworkMerchantId = JNIEnv.GetMethodID (class_ref, "getNetworkMerchantId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNetworkMerchantId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNetworkMerchantId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='setNetworkMerchantId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNetworkMerchantId", "(Ljava/lang/String;)V", "GetSetNetworkMerchantId_Ljava_lang_String_Handler")]
			set {
				if (id_setNetworkMerchantId_Ljava_lang_String_ == IntPtr.Zero)
					id_setNetworkMerchantId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNetworkMerchantId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNetworkMerchantId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNetworkMerchantId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getNetworkReferenceNumber;
#pragma warning disable 0169
		static Delegate GetGetNetworkReferenceNumberHandler ()
		{
			if (cb_getNetworkReferenceNumber == null)
				cb_getNetworkReferenceNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNetworkReferenceNumber);
			return cb_getNetworkReferenceNumber;
		}

		static IntPtr n_GetNetworkReferenceNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NetworkReferenceNumber);
		}
#pragma warning restore 0169

		static Delegate cb_setNetworkReferenceNumber_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNetworkReferenceNumber_Ljava_lang_String_Handler ()
		{
			if (cb_setNetworkReferenceNumber_Ljava_lang_String_ == null)
				cb_setNetworkReferenceNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNetworkReferenceNumber_Ljava_lang_String_);
			return cb_setNetworkReferenceNumber_Ljava_lang_String_;
		}

		static void n_SetNetworkReferenceNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NetworkReferenceNumber = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNetworkReferenceNumber;
		static IntPtr id_setNetworkReferenceNumber_Ljava_lang_String_;
		public virtual unsafe string NetworkReferenceNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='getNetworkReferenceNumber' and count(parameter)=0]"
			[Register ("getNetworkReferenceNumber", "()Ljava/lang/String;", "GetGetNetworkReferenceNumberHandler")]
			get {
				if (id_getNetworkReferenceNumber == IntPtr.Zero)
					id_getNetworkReferenceNumber = JNIEnv.GetMethodID (class_ref, "getNetworkReferenceNumber", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNetworkReferenceNumber), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNetworkReferenceNumber", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='setNetworkReferenceNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNetworkReferenceNumber", "(Ljava/lang/String;)V", "GetSetNetworkReferenceNumber_Ljava_lang_String_Handler")]
			set {
				if (id_setNetworkReferenceNumber_Ljava_lang_String_ == IntPtr.Zero)
					id_setNetworkReferenceNumber_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNetworkReferenceNumber", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNetworkReferenceNumber_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNetworkReferenceNumber", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getNetworkTerminalId;
#pragma warning disable 0169
		static Delegate GetGetNetworkTerminalIdHandler ()
		{
			if (cb_getNetworkTerminalId == null)
				cb_getNetworkTerminalId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNetworkTerminalId);
			return cb_getNetworkTerminalId;
		}

		static IntPtr n_GetNetworkTerminalId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NetworkTerminalId);
		}
#pragma warning restore 0169

		static Delegate cb_setNetworkTerminalId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNetworkTerminalId_Ljava_lang_String_Handler ()
		{
			if (cb_setNetworkTerminalId_Ljava_lang_String_ == null)
				cb_setNetworkTerminalId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNetworkTerminalId_Ljava_lang_String_);
			return cb_setNetworkTerminalId_Ljava_lang_String_;
		}

		static void n_SetNetworkTerminalId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NetworkTerminalId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNetworkTerminalId;
		static IntPtr id_setNetworkTerminalId_Ljava_lang_String_;
		public virtual unsafe string NetworkTerminalId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='getNetworkTerminalId' and count(parameter)=0]"
			[Register ("getNetworkTerminalId", "()Ljava/lang/String;", "GetGetNetworkTerminalIdHandler")]
			get {
				if (id_getNetworkTerminalId == IntPtr.Zero)
					id_getNetworkTerminalId = JNIEnv.GetMethodID (class_ref, "getNetworkTerminalId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNetworkTerminalId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNetworkTerminalId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='setNetworkTerminalId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNetworkTerminalId", "(Ljava/lang/String;)V", "GetSetNetworkTerminalId_Ljava_lang_String_Handler")]
			set {
				if (id_setNetworkTerminalId_Ljava_lang_String_ == IntPtr.Zero)
					id_setNetworkTerminalId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNetworkTerminalId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNetworkTerminalId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNetworkTerminalId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getOriginalAmount;
#pragma warning disable 0169
		static Delegate GetGetOriginalAmountHandler ()
		{
			if (cb_getOriginalAmount == null)
				cb_getOriginalAmount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOriginalAmount);
			return cb_getOriginalAmount;
		}

		static IntPtr n_GetOriginalAmount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OriginalAmount);
		}
#pragma warning restore 0169

		static Delegate cb_setOriginalAmount_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetOriginalAmount_Ljava_lang_String_Handler ()
		{
			if (cb_setOriginalAmount_Ljava_lang_String_ == null)
				cb_setOriginalAmount_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOriginalAmount_Ljava_lang_String_);
			return cb_setOriginalAmount_Ljava_lang_String_;
		}

		static void n_SetOriginalAmount_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OriginalAmount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOriginalAmount;
		static IntPtr id_setOriginalAmount_Ljava_lang_String_;
		public virtual unsafe string OriginalAmount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='getOriginalAmount' and count(parameter)=0]"
			[Register ("getOriginalAmount", "()Ljava/lang/String;", "GetGetOriginalAmountHandler")]
			get {
				if (id_getOriginalAmount == IntPtr.Zero)
					id_getOriginalAmount = JNIEnv.GetMethodID (class_ref, "getOriginalAmount", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOriginalAmount), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOriginalAmount", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='setOriginalAmount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setOriginalAmount", "(Ljava/lang/String;)V", "GetSetOriginalAmount_Ljava_lang_String_Handler")]
			set {
				if (id_setOriginalAmount_Ljava_lang_String_ == IntPtr.Zero)
					id_setOriginalAmount_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setOriginalAmount", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOriginalAmount_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOriginalAmount", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getReceiptTagData;
#pragma warning disable 0169
		static Delegate GetGetReceiptTagDataHandler ()
		{
			if (cb_getReceiptTagData == null)
				cb_getReceiptTagData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReceiptTagData);
			return cb_getReceiptTagData;
		}

		static IntPtr n_GetReceiptTagData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReceiptTagData);
		}
#pragma warning restore 0169

		static Delegate cb_setReceiptTagData_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetReceiptTagData_Ljava_lang_String_Handler ()
		{
			if (cb_setReceiptTagData_Ljava_lang_String_ == null)
				cb_setReceiptTagData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetReceiptTagData_Ljava_lang_String_);
			return cb_setReceiptTagData_Ljava_lang_String_;
		}

		static void n_SetReceiptTagData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReceiptTagData = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getReceiptTagData;
		static IntPtr id_setReceiptTagData_Ljava_lang_String_;
		public virtual unsafe string ReceiptTagData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='getReceiptTagData' and count(parameter)=0]"
			[Register ("getReceiptTagData", "()Ljava/lang/String;", "GetGetReceiptTagDataHandler")]
			get {
				if (id_getReceiptTagData == IntPtr.Zero)
					id_getReceiptTagData = JNIEnv.GetMethodID (class_ref, "getReceiptTagData", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getReceiptTagData), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReceiptTagData", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='setReceiptTagData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setReceiptTagData", "(Ljava/lang/String;)V", "GetSetReceiptTagData_Ljava_lang_String_Handler")]
			set {
				if (id_setReceiptTagData_Ljava_lang_String_ == IntPtr.Zero)
					id_setReceiptTagData_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setReceiptTagData", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setReceiptTagData_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReceiptTagData", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReferenceNumber = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getReferenceNumber;
		static IntPtr id_setReferenceNumber_Ljava_lang_String_;
		public virtual unsafe string ReferenceNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='getReferenceNumber' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='setReferenceNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getRemainingAmount;
#pragma warning disable 0169
		static Delegate GetGetRemainingAmountHandler ()
		{
			if (cb_getRemainingAmount == null)
				cb_getRemainingAmount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRemainingAmount);
			return cb_getRemainingAmount;
		}

		static IntPtr n_GetRemainingAmount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RemainingAmount);
		}
#pragma warning restore 0169

		static Delegate cb_setRemainingAmount_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRemainingAmount_Ljava_lang_String_Handler ()
		{
			if (cb_setRemainingAmount_Ljava_lang_String_ == null)
				cb_setRemainingAmount_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRemainingAmount_Ljava_lang_String_);
			return cb_setRemainingAmount_Ljava_lang_String_;
		}

		static void n_SetRemainingAmount_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemainingAmount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRemainingAmount;
		static IntPtr id_setRemainingAmount_Ljava_lang_String_;
		public virtual unsafe string RemainingAmount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='getRemainingAmount' and count(parameter)=0]"
			[Register ("getRemainingAmount", "()Ljava/lang/String;", "GetGetRemainingAmountHandler")]
			get {
				if (id_getRemainingAmount == IntPtr.Zero)
					id_getRemainingAmount = JNIEnv.GetMethodID (class_ref, "getRemainingAmount", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRemainingAmount), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRemainingAmount", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='setRemainingAmount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRemainingAmount", "(Ljava/lang/String;)V", "GetSetRemainingAmount_Ljava_lang_String_Handler")]
			set {
				if (id_setRemainingAmount_Ljava_lang_String_ == IntPtr.Zero)
					id_setRemainingAmount_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRemainingAmount", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRemainingAmount_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRemainingAmount", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ResponseType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getResponseType;
		static IntPtr id_setResponseType_Ljava_lang_String_;
		public virtual unsafe string ResponseType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='getResponseType' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='setResponseType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getResponseTypeDescription;
#pragma warning disable 0169
		static Delegate GetGetResponseTypeDescriptionHandler ()
		{
			if (cb_getResponseTypeDescription == null)
				cb_getResponseTypeDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponseTypeDescription);
			return cb_getResponseTypeDescription;
		}

		static IntPtr n_GetResponseTypeDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ResponseTypeDescription);
		}
#pragma warning restore 0169

		static Delegate cb_setResponseTypeDescription_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetResponseTypeDescription_Ljava_lang_String_Handler ()
		{
			if (cb_setResponseTypeDescription_Ljava_lang_String_ == null)
				cb_setResponseTypeDescription_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetResponseTypeDescription_Ljava_lang_String_);
			return cb_setResponseTypeDescription_Ljava_lang_String_;
		}

		static void n_SetResponseTypeDescription_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ResponseTypeDescription = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getResponseTypeDescription;
		static IntPtr id_setResponseTypeDescription_Ljava_lang_String_;
		public virtual unsafe string ResponseTypeDescription {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='getResponseTypeDescription' and count(parameter)=0]"
			[Register ("getResponseTypeDescription", "()Ljava/lang/String;", "GetGetResponseTypeDescriptionHandler")]
			get {
				if (id_getResponseTypeDescription == IntPtr.Zero)
					id_getResponseTypeDescription = JNIEnv.GetMethodID (class_ref, "getResponseTypeDescription", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponseTypeDescription), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponseTypeDescription", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='setResponseTypeDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setResponseTypeDescription", "(Ljava/lang/String;)V", "GetSetResponseTypeDescription_Ljava_lang_String_Handler")]
			set {
				if (id_setResponseTypeDescription_Ljava_lang_String_ == IntPtr.Zero)
					id_setResponseTypeDescription_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setResponseTypeDescription", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setResponseTypeDescription_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResponseTypeDescription", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSecondsRemaining;
#pragma warning disable 0169
		static Delegate GetGetSecondsRemainingHandler ()
		{
			if (cb_getSecondsRemaining == null)
				cb_getSecondsRemaining = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSecondsRemaining);
			return cb_getSecondsRemaining;
		}

		static IntPtr n_GetSecondsRemaining (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SecondsRemaining);
		}
#pragma warning restore 0169

		static Delegate cb_setSecondsRemaining_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSecondsRemaining_Ljava_lang_String_Handler ()
		{
			if (cb_setSecondsRemaining_Ljava_lang_String_ == null)
				cb_setSecondsRemaining_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSecondsRemaining_Ljava_lang_String_);
			return cb_setSecondsRemaining_Ljava_lang_String_;
		}

		static void n_SetSecondsRemaining_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SecondsRemaining = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSecondsRemaining;
		static IntPtr id_setSecondsRemaining_Ljava_lang_String_;
		public virtual unsafe string SecondsRemaining {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='getSecondsRemaining' and count(parameter)=0]"
			[Register ("getSecondsRemaining", "()Ljava/lang/String;", "GetGetSecondsRemainingHandler")]
			get {
				if (id_getSecondsRemaining == IntPtr.Zero)
					id_getSecondsRemaining = JNIEnv.GetMethodID (class_ref, "getSecondsRemaining", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSecondsRemaining), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSecondsRemaining", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='setSecondsRemaining' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSecondsRemaining", "(Ljava/lang/String;)V", "GetSetSecondsRemaining_Ljava_lang_String_Handler")]
			set {
				if (id_setSecondsRemaining_Ljava_lang_String_ == IntPtr.Zero)
					id_setSecondsRemaining_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSecondsRemaining", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSecondsRemaining_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSecondsRemaining", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getStreetMatchMessage;
#pragma warning disable 0169
		static Delegate GetGetStreetMatchMessageHandler ()
		{
			if (cb_getStreetMatchMessage == null)
				cb_getStreetMatchMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStreetMatchMessage);
			return cb_getStreetMatchMessage;
		}

		static IntPtr n_GetStreetMatchMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StreetMatchMessage);
		}
#pragma warning restore 0169

		static Delegate cb_setStreetMatchMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStreetMatchMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setStreetMatchMessage_Ljava_lang_String_ == null)
				cb_setStreetMatchMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStreetMatchMessage_Ljava_lang_String_);
			return cb_setStreetMatchMessage_Ljava_lang_String_;
		}

		static void n_SetStreetMatchMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StreetMatchMessage = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStreetMatchMessage;
		static IntPtr id_setStreetMatchMessage_Ljava_lang_String_;
		public virtual unsafe string StreetMatchMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='getStreetMatchMessage' and count(parameter)=0]"
			[Register ("getStreetMatchMessage", "()Ljava/lang/String;", "GetGetStreetMatchMessageHandler")]
			get {
				if (id_getStreetMatchMessage == IntPtr.Zero)
					id_getStreetMatchMessage = JNIEnv.GetMethodID (class_ref, "getStreetMatchMessage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStreetMatchMessage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStreetMatchMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='setStreetMatchMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStreetMatchMessage", "(Ljava/lang/String;)V", "GetSetStreetMatchMessage_Ljava_lang_String_Handler")]
			set {
				if (id_setStreetMatchMessage_Ljava_lang_String_ == IntPtr.Zero)
					id_setStreetMatchMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setStreetMatchMessage", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStreetMatchMessage_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStreetMatchMessage", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Token = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getToken;
		static IntPtr id_setToken_Ljava_lang_String_;
		public virtual unsafe string Token {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='getToken' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='setToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getTransactionCode;
#pragma warning disable 0169
		static Delegate GetGetTransactionCodeHandler ()
		{
			if (cb_getTransactionCode == null)
				cb_getTransactionCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransactionCode);
			return cb_getTransactionCode;
		}

		static IntPtr n_GetTransactionCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TransactionCode);
		}
#pragma warning restore 0169

		static Delegate cb_setTransactionCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTransactionCode_Ljava_lang_String_Handler ()
		{
			if (cb_setTransactionCode_Ljava_lang_String_ == null)
				cb_setTransactionCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTransactionCode_Ljava_lang_String_);
			return cb_setTransactionCode_Ljava_lang_String_;
		}

		static void n_SetTransactionCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TransactionCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTransactionCode;
		static IntPtr id_setTransactionCode_Ljava_lang_String_;
		public virtual unsafe string TransactionCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='getTransactionCode' and count(parameter)=0]"
			[Register ("getTransactionCode", "()Ljava/lang/String;", "GetGetTransactionCodeHandler")]
			get {
				if (id_getTransactionCode == IntPtr.Zero)
					id_getTransactionCode = JNIEnv.GetMethodID (class_ref, "getTransactionCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTransactionCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransactionCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='setTransactionCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTransactionCode", "(Ljava/lang/String;)V", "GetSetTransactionCode_Ljava_lang_String_Handler")]
			set {
				if (id_setTransactionCode_Ljava_lang_String_ == IntPtr.Zero)
					id_setTransactionCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTransactionCode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTransactionCode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTransactionCode", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TransactionDate = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTransactionDate;
		static IntPtr id_setTransactionDate_Ljava_lang_String_;
		public virtual unsafe string TransactionDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='getTransactionDate' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadReponseMessage']/method[@name='setTransactionDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

	}
}
