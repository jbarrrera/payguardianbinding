using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bpn.Payguardian.Android.Payment {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestHeader']"
	[global::Android.Runtime.Register ("com/bpn/payguardian/android/payment/PayloadRequestHeader", DoNotGenerateAcw=true)]
	public partial class PayloadRequestHeader : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bpn/payguardian/android/payment/PayloadRequestHeader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PayloadRequestHeader); }
		}

		protected PayloadRequestHeader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestHeader']/constructor[@name='PayloadRequestHeader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PayloadRequestHeader ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PayloadRequestHeader)) {
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

		static Delegate cb_getClientIdentifier;
#pragma warning disable 0169
		static Delegate GetGetClientIdentifierHandler ()
		{
			if (cb_getClientIdentifier == null)
				cb_getClientIdentifier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientIdentifier);
			return cb_getClientIdentifier;
		}

		static IntPtr n_GetClientIdentifier (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestHeader __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientIdentifier);
		}
#pragma warning restore 0169

		static Delegate cb_setClientIdentifier_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetClientIdentifier_Ljava_lang_String_Handler ()
		{
			if (cb_setClientIdentifier_Ljava_lang_String_ == null)
				cb_setClientIdentifier_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetClientIdentifier_Ljava_lang_String_);
			return cb_setClientIdentifier_Ljava_lang_String_;
		}

		static void n_SetClientIdentifier_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestHeader __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClientIdentifier = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getClientIdentifier;
		static IntPtr id_setClientIdentifier_Ljava_lang_String_;
		public virtual unsafe string ClientIdentifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestHeader']/method[@name='getClientIdentifier' and count(parameter)=0]"
			[Register ("getClientIdentifier", "()Ljava/lang/String;", "GetGetClientIdentifierHandler")]
			get {
				if (id_getClientIdentifier == IntPtr.Zero)
					id_getClientIdentifier = JNIEnv.GetMethodID (class_ref, "getClientIdentifier", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientIdentifier), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClientIdentifier", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestHeader']/method[@name='setClientIdentifier' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setClientIdentifier", "(Ljava/lang/String;)V", "GetSetClientIdentifier_Ljava_lang_String_Handler")]
			set {
				if (id_setClientIdentifier_Ljava_lang_String_ == IntPtr.Zero)
					id_setClientIdentifier_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setClientIdentifier", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setClientIdentifier_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setClientIdentifier", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getPassword;
#pragma warning disable 0169
		static Delegate GetGetPasswordHandler ()
		{
			if (cb_getPassword == null)
				cb_getPassword = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPassword);
			return cb_getPassword;
		}

		static IntPtr n_GetPassword (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestHeader __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Password);
		}
#pragma warning restore 0169

		static Delegate cb_setPassword_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPassword_Ljava_lang_String_Handler ()
		{
			if (cb_setPassword_Ljava_lang_String_ == null)
				cb_setPassword_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPassword_Ljava_lang_String_);
			return cb_setPassword_Ljava_lang_String_;
		}

		static void n_SetPassword_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestHeader __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Password = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPassword;
		static IntPtr id_setPassword_Ljava_lang_String_;
		public virtual unsafe string Password {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestHeader']/method[@name='getPassword' and count(parameter)=0]"
			[Register ("getPassword", "()Ljava/lang/String;", "GetGetPasswordHandler")]
			get {
				if (id_getPassword == IntPtr.Zero)
					id_getPassword = JNIEnv.GetMethodID (class_ref, "getPassword", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPassword), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPassword", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestHeader']/method[@name='setPassword' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPassword", "(Ljava/lang/String;)V", "GetSetPassword_Ljava_lang_String_Handler")]
			set {
				if (id_setPassword_Ljava_lang_String_ == IntPtr.Zero)
					id_setPassword_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPassword", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPassword_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPassword", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getRequestDateTime;
#pragma warning disable 0169
		static Delegate GetGetRequestDateTimeHandler ()
		{
			if (cb_getRequestDateTime == null)
				cb_getRequestDateTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestDateTime);
			return cb_getRequestDateTime;
		}

		static IntPtr n_GetRequestDateTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestHeader __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestDateTime);
		}
#pragma warning restore 0169

		static IntPtr id_getRequestDateTime;
		public virtual unsafe string RequestDateTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestHeader']/method[@name='getRequestDateTime' and count(parameter)=0]"
			[Register ("getRequestDateTime", "()Ljava/lang/String;", "GetGetRequestDateTimeHandler")]
			get {
				if (id_getRequestDateTime == IntPtr.Zero)
					id_getRequestDateTime = JNIEnv.GetMethodID (class_ref, "getRequestDateTime", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequestDateTime), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestDateTime", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRequestMessage;
#pragma warning disable 0169
		static Delegate GetGetRequestMessageHandler ()
		{
			if (cb_getRequestMessage == null)
				cb_getRequestMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestMessage);
			return cb_getRequestMessage;
		}

		static IntPtr n_GetRequestMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestHeader __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RequestMessage);
		}
#pragma warning restore 0169

		static Delegate cb_setRequestMessage_Lcom_bpn_payguardian_android_payment_PayloadRequestMessage_;
#pragma warning disable 0169
		static Delegate GetSetRequestMessage_Lcom_bpn_payguardian_android_payment_PayloadRequestMessage_Handler ()
		{
			if (cb_setRequestMessage_Lcom_bpn_payguardian_android_payment_PayloadRequestMessage_ == null)
				cb_setRequestMessage_Lcom_bpn_payguardian_android_payment_PayloadRequestMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRequestMessage_Lcom_bpn_payguardian_android_payment_PayloadRequestMessage_);
			return cb_setRequestMessage_Lcom_bpn_payguardian_android_payment_PayloadRequestMessage_;
		}

		static void n_SetRequestMessage_Lcom_bpn_payguardian_android_payment_PayloadRequestMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestHeader __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RequestMessage = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRequestMessage;
		static IntPtr id_setRequestMessage_Lcom_bpn_payguardian_android_payment_PayloadRequestMessage_;
		public virtual unsafe global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage RequestMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestHeader']/method[@name='getRequestMessage' and count(parameter)=0]"
			[Register ("getRequestMessage", "()Lcom/bpn/payguardian/android/payment/PayloadRequestMessage;", "GetGetRequestMessageHandler")]
			get {
				if (id_getRequestMessage == IntPtr.Zero)
					id_getRequestMessage = JNIEnv.GetMethodID (class_ref, "getRequestMessage", "()Lcom/bpn/payguardian/android/payment/PayloadRequestMessage;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequestMessage), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestMessage", "()Lcom/bpn/payguardian/android/payment/PayloadRequestMessage;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestHeader']/method[@name='setRequestMessage' and count(parameter)=1 and parameter[1][@type='com.bpn.payguardian.android.payment.PayloadRequestMessage']]"
			[Register ("setRequestMessage", "(Lcom/bpn/payguardian/android/payment/PayloadRequestMessage;)V", "GetSetRequestMessage_Lcom_bpn_payguardian_android_payment_PayloadRequestMessage_Handler")]
			set {
				if (id_setRequestMessage_Lcom_bpn_payguardian_android_payment_PayloadRequestMessage_ == IntPtr.Zero)
					id_setRequestMessage_Lcom_bpn_payguardian_android_payment_PayloadRequestMessage_ = JNIEnv.GetMethodID (class_ref, "setRequestMessage", "(Lcom/bpn/payguardian/android/payment/PayloadRequestMessage;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRequestMessage_Lcom_bpn_payguardian_android_payment_PayloadRequestMessage_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRequestMessage", "(Lcom/bpn/payguardian/android/payment/PayloadRequestMessage;)V"), __args);
				} finally {
				}
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
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestHeader __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestHeader __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RequestType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRequestType;
		static IntPtr id_setRequestType_Ljava_lang_String_;
		public virtual unsafe string RequestType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestHeader']/method[@name='getRequestType' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestHeader']/method[@name='setRequestType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestHeader __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestHeader __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TransactionID = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTransactionID;
		static IntPtr id_setTransactionID_Ljava_lang_String_;
		public virtual unsafe string TransactionID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestHeader']/method[@name='getTransactionID' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestHeader']/method[@name='setTransactionID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getUser;
#pragma warning disable 0169
		static Delegate GetGetUserHandler ()
		{
			if (cb_getUser == null)
				cb_getUser = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUser);
			return cb_getUser;
		}

		static IntPtr n_GetUser (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestHeader __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.User);
		}
#pragma warning restore 0169

		static Delegate cb_setUser_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUser_Ljava_lang_String_Handler ()
		{
			if (cb_setUser_Ljava_lang_String_ == null)
				cb_setUser_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUser_Ljava_lang_String_);
			return cb_setUser_Ljava_lang_String_;
		}

		static void n_SetUser_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestHeader __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.User = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUser;
		static IntPtr id_setUser_Ljava_lang_String_;
		public virtual unsafe string User {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestHeader']/method[@name='getUser' and count(parameter)=0]"
			[Register ("getUser", "()Ljava/lang/String;", "GetGetUserHandler")]
			get {
				if (id_getUser == IntPtr.Zero)
					id_getUser = JNIEnv.GetMethodID (class_ref, "getUser", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUser), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUser", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestHeader']/method[@name='setUser' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUser", "(Ljava/lang/String;)V", "GetSetUser_Ljava_lang_String_Handler")]
			set {
				if (id_setUser_Ljava_lang_String_ == IntPtr.Zero)
					id_setUser_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUser", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUser_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUser", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
