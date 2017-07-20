using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bpn.Payguardian.Android.Payment {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadResponse']"
	[global::Android.Runtime.Register ("com/bpn/payguardian/android/payment/PayloadResponse", DoNotGenerateAcw=true)]
	public partial class PayloadResponse : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bpn/payguardian/android/payment/PayloadResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PayloadResponse); }
		}

		protected PayloadResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadResponse']/constructor[@name='PayloadResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PayloadResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PayloadResponse)) {
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
			global::Com.Bpn.Payguardian.Android.Payment.PayloadResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Payment.PayloadResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RequestType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRequestType;
		static IntPtr id_setRequestType_Ljava_lang_String_;
		public virtual unsafe string RequestType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadResponse']/method[@name='getRequestType' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadResponse']/method[@name='setRequestType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Payment.PayloadResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Payment.PayloadResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ResponseCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getResponseCode;
		static IntPtr id_setResponseCode_Ljava_lang_String_;
		public virtual unsafe string ResponseCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadResponse']/method[@name='getResponseCode' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadResponse']/method[@name='setResponseCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Payment.PayloadResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Payment.PayloadResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ResponseDescription = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getResponseDescription;
		static IntPtr id_setResponseDescription_Ljava_lang_String_;
		public virtual unsafe string ResponseDescription {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadResponse']/method[@name='getResponseDescription' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadResponse']/method[@name='setResponseDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Payment.PayloadResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ResponseMessage);
		}
#pragma warning restore 0169

		static Delegate cb_setResponseMessage_Lcom_bpn_payguardian_android_payment_PayloadReponseMessage_;
#pragma warning disable 0169
		static Delegate GetSetResponseMessage_Lcom_bpn_payguardian_android_payment_PayloadReponseMessage_Handler ()
		{
			if (cb_setResponseMessage_Lcom_bpn_payguardian_android_payment_PayloadReponseMessage_ == null)
				cb_setResponseMessage_Lcom_bpn_payguardian_android_payment_PayloadReponseMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetResponseMessage_Lcom_bpn_payguardian_android_payment_PayloadReponseMessage_);
			return cb_setResponseMessage_Lcom_bpn_payguardian_android_payment_PayloadReponseMessage_;
		}

		static void n_SetResponseMessage_Lcom_bpn_payguardian_android_payment_PayloadReponseMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ResponseMessage = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getResponseMessage;
		static IntPtr id_setResponseMessage_Lcom_bpn_payguardian_android_payment_PayloadReponseMessage_;
		public virtual unsafe global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage ResponseMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadResponse']/method[@name='getResponseMessage' and count(parameter)=0]"
			[Register ("getResponseMessage", "()Lcom/bpn/payguardian/android/payment/PayloadReponseMessage;", "GetGetResponseMessageHandler")]
			get {
				if (id_getResponseMessage == IntPtr.Zero)
					id_getResponseMessage = JNIEnv.GetMethodID (class_ref, "getResponseMessage", "()Lcom/bpn/payguardian/android/payment/PayloadReponseMessage;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponseMessage), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadReponseMessage> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponseMessage", "()Lcom/bpn/payguardian/android/payment/PayloadReponseMessage;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadResponse']/method[@name='setResponseMessage' and count(parameter)=1 and parameter[1][@type='com.bpn.payguardian.android.payment.PayloadReponseMessage']]"
			[Register ("setResponseMessage", "(Lcom/bpn/payguardian/android/payment/PayloadReponseMessage;)V", "GetSetResponseMessage_Lcom_bpn_payguardian_android_payment_PayloadReponseMessage_Handler")]
			set {
				if (id_setResponseMessage_Lcom_bpn_payguardian_android_payment_PayloadReponseMessage_ == IntPtr.Zero)
					id_setResponseMessage_Lcom_bpn_payguardian_android_payment_PayloadReponseMessage_ = JNIEnv.GetMethodID (class_ref, "setResponseMessage", "(Lcom/bpn/payguardian/android/payment/PayloadReponseMessage;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setResponseMessage_Lcom_bpn_payguardian_android_payment_PayloadReponseMessage_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResponseMessage", "(Lcom/bpn/payguardian/android/payment/PayloadReponseMessage;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTransactionID;
#pragma warning disable 0169
		static Delegate GetGetTransactionIDHandler ()
		{
			if (cb_getTransactionID == null)
				cb_getTransactionID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransactionID);
			return cb_getTransactionID;
		}

		static IntPtr n_GetTransactionID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TransactionID);
		}
#pragma warning restore 0169

		static Delegate cb_setTransactionID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTransactionID_Ljava_lang_String_Handler ()
		{
			if (cb_setTransactionID_Ljava_lang_String_ == null)
				cb_setTransactionID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTransactionID_Ljava_lang_String_);
			return cb_setTransactionID_Ljava_lang_String_;
		}

		static void n_SetTransactionID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TransactionID = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTransactionID;
		static IntPtr id_setTransactionID_Ljava_lang_String_;
		public virtual unsafe string TransactionID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadResponse']/method[@name='getTransactionID' and count(parameter)=0]"
			[Register ("getTransactionID", "()Ljava/lang/String;", "GetGetTransactionIDHandler")]
			get {
				if (id_getTransactionID == IntPtr.Zero)
					id_getTransactionID = JNIEnv.GetMethodID (class_ref, "getTransactionID", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTransactionID), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransactionID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadResponse']/method[@name='setTransactionID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTransactionID", "(Ljava/lang/String;)V", "GetSetTransactionID_Ljava_lang_String_Handler")]
			set {
				if (id_setTransactionID_Ljava_lang_String_ == IntPtr.Zero)
					id_setTransactionID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTransactionID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTransactionID_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTransactionID", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
