using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bpn.Payguardian.Android.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']"
	[global::Android.Runtime.Register ("com/bpn/payguardian/android/model/PaymentResponse", DoNotGenerateAcw=true)]
	public partial class PaymentResponse : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bpn/payguardian/android/model/PaymentResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PaymentResponse); }
		}

		protected PaymentResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/constructor[@name='PaymentResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PaymentResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PaymentResponse)) {
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

		static Delegate cb_getAVSMessage;
#pragma warning disable 0169
		static Delegate GetGetAVSMessageHandler ()
		{
			if (cb_getAVSMessage == null)
				cb_getAVSMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAVSMessage);
			return cb_getAVSMessage;
		}

		static IntPtr n_GetAVSMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AVSMessage);
		}
#pragma warning restore 0169

		static Delegate cb_setAVSMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAVSMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setAVSMessage_Ljava_lang_String_ == null)
				cb_setAVSMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAVSMessage_Ljava_lang_String_);
			return cb_setAVSMessage_Ljava_lang_String_;
		}

		static void n_SetAVSMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AVSMessage = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAVSMessage;
		static IntPtr id_setAVSMessage_Ljava_lang_String_;
		public virtual unsafe string AVSMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getAVSMessage' and count(parameter)=0]"
			[Register ("getAVSMessage", "()Ljava/lang/String;", "GetGetAVSMessageHandler")]
			get {
				if (id_getAVSMessage == IntPtr.Zero)
					id_getAVSMessage = JNIEnv.GetMethodID (class_ref, "getAVSMessage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAVSMessage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAVSMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setAVSMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAVSMessage", "(Ljava/lang/String;)V", "GetSetAVSMessage_Ljava_lang_String_Handler")]
			set {
				if (id_setAVSMessage_Ljava_lang_String_ == IntPtr.Zero)
					id_setAVSMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAVSMessage", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAVSMessage_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAVSMessage", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getApprovedAmount;
#pragma warning disable 0169
		static Delegate GetGetApprovedAmountHandler ()
		{
			if (cb_getApprovedAmount == null)
				cb_getApprovedAmount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApprovedAmount);
			return cb_getApprovedAmount;
		}

		static IntPtr n_GetApprovedAmount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApprovedAmount);
		}
#pragma warning restore 0169

		static Delegate cb_setApprovedAmount_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetApprovedAmount_Ljava_lang_String_Handler ()
		{
			if (cb_setApprovedAmount_Ljava_lang_String_ == null)
				cb_setApprovedAmount_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetApprovedAmount_Ljava_lang_String_);
			return cb_setApprovedAmount_Ljava_lang_String_;
		}

		static void n_SetApprovedAmount_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ApprovedAmount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getApprovedAmount;
		static IntPtr id_setApprovedAmount_Ljava_lang_String_;
		public virtual unsafe string ApprovedAmount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getApprovedAmount' and count(parameter)=0]"
			[Register ("getApprovedAmount", "()Ljava/lang/String;", "GetGetApprovedAmountHandler")]
			get {
				if (id_getApprovedAmount == IntPtr.Zero)
					id_getApprovedAmount = JNIEnv.GetMethodID (class_ref, "getApprovedAmount", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getApprovedAmount), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getApprovedAmount", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setApprovedAmount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setApprovedAmount", "(Ljava/lang/String;)V", "GetSetApprovedAmount_Ljava_lang_String_Handler")]
			set {
				if (id_setApprovedAmount_Ljava_lang_String_ == IntPtr.Zero)
					id_setApprovedAmount_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setApprovedAmount", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setApprovedAmount_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setApprovedAmount", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getAuthCode;
#pragma warning disable 0169
		static Delegate GetGetAuthCodeHandler ()
		{
			if (cb_getAuthCode == null)
				cb_getAuthCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuthCode);
			return cb_getAuthCode;
		}

		static IntPtr n_GetAuthCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthCode);
		}
#pragma warning restore 0169

		static Delegate cb_setAuthCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAuthCode_Ljava_lang_String_Handler ()
		{
			if (cb_setAuthCode_Ljava_lang_String_ == null)
				cb_setAuthCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAuthCode_Ljava_lang_String_);
			return cb_setAuthCode_Ljava_lang_String_;
		}

		static void n_SetAuthCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AuthCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAuthCode;
		static IntPtr id_setAuthCode_Ljava_lang_String_;
		public virtual unsafe string AuthCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getAuthCode' and count(parameter)=0]"
			[Register ("getAuthCode", "()Ljava/lang/String;", "GetGetAuthCodeHandler")]
			get {
				if (id_getAuthCode == IntPtr.Zero)
					id_getAuthCode = JNIEnv.GetMethodID (class_ref, "getAuthCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAuthCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuthCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setAuthCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAuthCode", "(Ljava/lang/String;)V", "GetSetAuthCode_Ljava_lang_String_Handler")]
			set {
				if (id_setAuthCode_Ljava_lang_String_ == IntPtr.Zero)
					id_setAuthCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAuthCode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAuthCode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAuthCode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getAvsResponse;
#pragma warning disable 0169
		static Delegate GetGetAvsResponseHandler ()
		{
			if (cb_getAvsResponse == null)
				cb_getAvsResponse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAvsResponse);
			return cb_getAvsResponse;
		}

		static IntPtr n_GetAvsResponse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AvsResponse);
		}
#pragma warning restore 0169

		static Delegate cb_setAvsResponse_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAvsResponse_Ljava_lang_String_Handler ()
		{
			if (cb_setAvsResponse_Ljava_lang_String_ == null)
				cb_setAvsResponse_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAvsResponse_Ljava_lang_String_);
			return cb_setAvsResponse_Ljava_lang_String_;
		}

		static void n_SetAvsResponse_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AvsResponse = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAvsResponse;
		static IntPtr id_setAvsResponse_Ljava_lang_String_;
		public virtual unsafe string AvsResponse {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getAvsResponse' and count(parameter)=0]"
			[Register ("getAvsResponse", "()Ljava/lang/String;", "GetGetAvsResponseHandler")]
			get {
				if (id_getAvsResponse == IntPtr.Zero)
					id_getAvsResponse = JNIEnv.GetMethodID (class_ref, "getAvsResponse", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAvsResponse), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAvsResponse", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setAvsResponse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAvsResponse", "(Ljava/lang/String;)V", "GetSetAvsResponse_Ljava_lang_String_Handler")]
			set {
				if (id_setAvsResponse_Ljava_lang_String_ == IntPtr.Zero)
					id_setAvsResponse_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAvsResponse", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAvsResponse_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAvsResponse", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getBogusAccountNumber;
#pragma warning disable 0169
		static Delegate GetGetBogusAccountNumberHandler ()
		{
			if (cb_getBogusAccountNumber == null)
				cb_getBogusAccountNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBogusAccountNumber);
			return cb_getBogusAccountNumber;
		}

		static IntPtr n_GetBogusAccountNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BogusAccountNumber);
		}
#pragma warning restore 0169

		static Delegate cb_setBogusAccountNumber_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBogusAccountNumber_Ljava_lang_String_Handler ()
		{
			if (cb_setBogusAccountNumber_Ljava_lang_String_ == null)
				cb_setBogusAccountNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBogusAccountNumber_Ljava_lang_String_);
			return cb_setBogusAccountNumber_Ljava_lang_String_;
		}

		static void n_SetBogusAccountNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BogusAccountNumber = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBogusAccountNumber;
		static IntPtr id_setBogusAccountNumber_Ljava_lang_String_;
		public virtual unsafe string BogusAccountNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getBogusAccountNumber' and count(parameter)=0]"
			[Register ("getBogusAccountNumber", "()Ljava/lang/String;", "GetGetBogusAccountNumberHandler")]
			get {
				if (id_getBogusAccountNumber == IntPtr.Zero)
					id_getBogusAccountNumber = JNIEnv.GetMethodID (class_ref, "getBogusAccountNumber", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBogusAccountNumber), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBogusAccountNumber", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setBogusAccountNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBogusAccountNumber", "(Ljava/lang/String;)V", "GetSetBogusAccountNumber_Ljava_lang_String_Handler")]
			set {
				if (id_setBogusAccountNumber_Ljava_lang_String_ == IntPtr.Zero)
					id_setBogusAccountNumber_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBogusAccountNumber", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBogusAccountNumber_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBogusAccountNumber", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCVMessage;
#pragma warning disable 0169
		static Delegate GetGetCVMessageHandler ()
		{
			if (cb_getCVMessage == null)
				cb_getCVMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCVMessage);
			return cb_getCVMessage;
		}

		static IntPtr n_GetCVMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CVMessage);
		}
#pragma warning restore 0169

		static Delegate cb_setCVMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCVMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setCVMessage_Ljava_lang_String_ == null)
				cb_setCVMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCVMessage_Ljava_lang_String_);
			return cb_setCVMessage_Ljava_lang_String_;
		}

		static void n_SetCVMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CVMessage = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCVMessage;
		static IntPtr id_setCVMessage_Ljava_lang_String_;
		public virtual unsafe string CVMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getCVMessage' and count(parameter)=0]"
			[Register ("getCVMessage", "()Ljava/lang/String;", "GetGetCVMessageHandler")]
			get {
				if (id_getCVMessage == IntPtr.Zero)
					id_getCVMessage = JNIEnv.GetMethodID (class_ref, "getCVMessage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCVMessage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCVMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setCVMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCVMessage", "(Ljava/lang/String;)V", "GetSetCVMessage_Ljava_lang_String_Handler")]
			set {
				if (id_setCVMessage_Ljava_lang_String_ == IntPtr.Zero)
					id_setCVMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCVMessage", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCVMessage_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCVMessage", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CardType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCardType;
		static IntPtr id_setCardType_Ljava_lang_String_;
		public virtual unsafe string CardType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getCardType' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setCardType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getCashBackAmount;
#pragma warning disable 0169
		static Delegate GetGetCashBackAmountHandler ()
		{
			if (cb_getCashBackAmount == null)
				cb_getCashBackAmount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCashBackAmount);
			return cb_getCashBackAmount;
		}

		static IntPtr n_GetCashBackAmount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CashBackAmount);
		}
#pragma warning restore 0169

		static Delegate cb_setCashBackAmount_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCashBackAmount_Ljava_lang_String_Handler ()
		{
			if (cb_setCashBackAmount_Ljava_lang_String_ == null)
				cb_setCashBackAmount_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCashBackAmount_Ljava_lang_String_);
			return cb_setCashBackAmount_Ljava_lang_String_;
		}

		static void n_SetCashBackAmount_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CashBackAmount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCashBackAmount;
		static IntPtr id_setCashBackAmount_Ljava_lang_String_;
		public virtual unsafe string CashBackAmount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getCashBackAmount' and count(parameter)=0]"
			[Register ("getCashBackAmount", "()Ljava/lang/String;", "GetGetCashBackAmountHandler")]
			get {
				if (id_getCashBackAmount == IntPtr.Zero)
					id_getCashBackAmount = JNIEnv.GetMethodID (class_ref, "getCashBackAmount", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCashBackAmount), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCashBackAmount", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setCashBackAmount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCashBackAmount", "(Ljava/lang/String;)V", "GetSetCashBackAmount_Ljava_lang_String_Handler")]
			set {
				if (id_setCashBackAmount_Ljava_lang_String_ == IntPtr.Zero)
					id_setCashBackAmount_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCashBackAmount", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCashBackAmount_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCashBackAmount", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCvResponse;
#pragma warning disable 0169
		static Delegate GetGetCvResponseHandler ()
		{
			if (cb_getCvResponse == null)
				cb_getCvResponse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCvResponse);
			return cb_getCvResponse;
		}

		static IntPtr n_GetCvResponse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CvResponse);
		}
#pragma warning restore 0169

		static Delegate cb_setCvResponse_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCvResponse_Ljava_lang_String_Handler ()
		{
			if (cb_setCvResponse_Ljava_lang_String_ == null)
				cb_setCvResponse_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCvResponse_Ljava_lang_String_);
			return cb_setCvResponse_Ljava_lang_String_;
		}

		static void n_SetCvResponse_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CvResponse = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCvResponse;
		static IntPtr id_setCvResponse_Ljava_lang_String_;
		public virtual unsafe string CvResponse {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getCvResponse' and count(parameter)=0]"
			[Register ("getCvResponse", "()Ljava/lang/String;", "GetGetCvResponseHandler")]
			get {
				if (id_getCvResponse == IntPtr.Zero)
					id_getCvResponse = JNIEnv.GetMethodID (class_ref, "getCvResponse", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCvResponse), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCvResponse", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setCvResponse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCvResponse", "(Ljava/lang/String;)V", "GetSetCvResponse_Ljava_lang_String_Handler")]
			set {
				if (id_setCvResponse_Ljava_lang_String_ == IntPtr.Zero)
					id_setCvResponse_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCvResponse", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCvResponse_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCvResponse", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getEntryMode;
#pragma warning disable 0169
		static Delegate GetGetEntryModeHandler ()
		{
			if (cb_getEntryMode == null)
				cb_getEntryMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEntryMode);
			return cb_getEntryMode;
		}

		static IntPtr n_GetEntryMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EntryMode);
		}
#pragma warning restore 0169

		static Delegate cb_setEntryMode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEntryMode_Ljava_lang_String_Handler ()
		{
			if (cb_setEntryMode_Ljava_lang_String_ == null)
				cb_setEntryMode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEntryMode_Ljava_lang_String_);
			return cb_setEntryMode_Ljava_lang_String_;
		}

		static void n_SetEntryMode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EntryMode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEntryMode;
		static IntPtr id_setEntryMode_Ljava_lang_String_;
		public virtual unsafe string EntryMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getEntryMode' and count(parameter)=0]"
			[Register ("getEntryMode", "()Ljava/lang/String;", "GetGetEntryModeHandler")]
			get {
				if (id_getEntryMode == IntPtr.Zero)
					id_getEntryMode = JNIEnv.GetMethodID (class_ref, "getEntryMode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEntryMode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEntryMode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setEntryMode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEntryMode", "(Ljava/lang/String;)V", "GetSetEntryMode_Ljava_lang_String_Handler")]
			set {
				if (id_setEntryMode_Ljava_lang_String_ == IntPtr.Zero)
					id_setEntryMode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEntryMode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEntryMode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEntryMode", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ExpirationDate = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getExpirationDate;
		static IntPtr id_setExpirationDate_Ljava_lang_String_;
		public virtual unsafe string ExpirationDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getExpirationDate' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setExpirationDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getExtData;
#pragma warning disable 0169
		static Delegate GetGetExtDataHandler ()
		{
			if (cb_getExtData == null)
				cb_getExtData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExtData);
			return cb_getExtData;
		}

		static IntPtr n_GetExtData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExtData);
		}
#pragma warning restore 0169

		static Delegate cb_setExtData_Lcom_bpn_payguardian_android_model_ExtData_;
#pragma warning disable 0169
		static Delegate GetSetExtData_Lcom_bpn_payguardian_android_model_ExtData_Handler ()
		{
			if (cb_setExtData_Lcom_bpn_payguardian_android_model_ExtData_ == null)
				cb_setExtData_Lcom_bpn_payguardian_android_model_ExtData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExtData_Lcom_bpn_payguardian_android_model_ExtData_);
			return cb_setExtData_Lcom_bpn_payguardian_android_model_ExtData_;
		}

		static void n_SetExtData_Lcom_bpn_payguardian_android_model_ExtData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bpn.Payguardian.Android.Model.ExtData p0 = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.ExtData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ExtData = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getExtData;
		static IntPtr id_setExtData_Lcom_bpn_payguardian_android_model_ExtData_;
		public virtual unsafe global::Com.Bpn.Payguardian.Android.Model.ExtData ExtData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getExtData' and count(parameter)=0]"
			[Register ("getExtData", "()Lcom/bpn/payguardian/android/model/ExtData;", "GetGetExtDataHandler")]
			get {
				if (id_getExtData == IntPtr.Zero)
					id_getExtData = JNIEnv.GetMethodID (class_ref, "getExtData", "()Lcom/bpn/payguardian/android/model/ExtData;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.ExtData> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExtData), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.ExtData> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExtData", "()Lcom/bpn/payguardian/android/model/ExtData;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setExtData' and count(parameter)=1 and parameter[1][@type='com.bpn.payguardian.android.model.ExtData']]"
			[Register ("setExtData", "(Lcom/bpn/payguardian/android/model/ExtData;)V", "GetSetExtData_Lcom_bpn_payguardian_android_model_ExtData_Handler")]
			set {
				if (id_setExtData_Lcom_bpn_payguardian_android_model_ExtData_ == IntPtr.Zero)
					id_setExtData_Lcom_bpn_payguardian_android_model_ExtData_ = JNIEnv.GetMethodID (class_ref, "setExtData", "(Lcom/bpn/payguardian/android/model/ExtData;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setExtData_Lcom_bpn_payguardian_android_model_ExtData_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExtData", "(Lcom/bpn/payguardian/android/model/ExtData;)V"), __args);
				} finally {
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
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GatewayMessage = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getGatewayMessage;
		static IntPtr id_setGatewayMessage_Ljava_lang_String_;
		public virtual unsafe string GatewayMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getGatewayMessage' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setGatewayMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GatewayResult = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getGatewayResult;
		static IntPtr id_setGatewayResult_Ljava_lang_String_;
		public virtual unsafe string GatewayResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getGatewayResult' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setGatewayResult' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getHostCode;
#pragma warning disable 0169
		static Delegate GetGetHostCodeHandler ()
		{
			if (cb_getHostCode == null)
				cb_getHostCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHostCode);
			return cb_getHostCode;
		}

		static IntPtr n_GetHostCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HostCode);
		}
#pragma warning restore 0169

		static Delegate cb_setHostCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetHostCode_Ljava_lang_String_Handler ()
		{
			if (cb_setHostCode_Ljava_lang_String_ == null)
				cb_setHostCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHostCode_Ljava_lang_String_);
			return cb_setHostCode_Ljava_lang_String_;
		}

		static void n_SetHostCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HostCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getHostCode;
		static IntPtr id_setHostCode_Ljava_lang_String_;
		public virtual unsafe string HostCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getHostCode' and count(parameter)=0]"
			[Register ("getHostCode", "()Ljava/lang/String;", "GetGetHostCodeHandler")]
			get {
				if (id_getHostCode == IntPtr.Zero)
					id_getHostCode = JNIEnv.GetMethodID (class_ref, "getHostCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHostCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHostCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setHostCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setHostCode", "(Ljava/lang/String;)V", "GetSetHostCode_Ljava_lang_String_Handler")]
			set {
				if (id_setHostCode_Ljava_lang_String_ == IntPtr.Zero)
					id_setHostCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setHostCode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHostCode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHostCode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getHostResponse;
#pragma warning disable 0169
		static Delegate GetGetHostResponseHandler ()
		{
			if (cb_getHostResponse == null)
				cb_getHostResponse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHostResponse);
			return cb_getHostResponse;
		}

		static IntPtr n_GetHostResponse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HostResponse);
		}
#pragma warning restore 0169

		static Delegate cb_setHostResponse_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetHostResponse_Ljava_lang_String_Handler ()
		{
			if (cb_setHostResponse_Ljava_lang_String_ == null)
				cb_setHostResponse_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHostResponse_Ljava_lang_String_);
			return cb_setHostResponse_Ljava_lang_String_;
		}

		static void n_SetHostResponse_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HostResponse = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getHostResponse;
		static IntPtr id_setHostResponse_Ljava_lang_String_;
		public virtual unsafe string HostResponse {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getHostResponse' and count(parameter)=0]"
			[Register ("getHostResponse", "()Ljava/lang/String;", "GetGetHostResponseHandler")]
			get {
				if (id_getHostResponse == IntPtr.Zero)
					id_getHostResponse = JNIEnv.GetMethodID (class_ref, "getHostResponse", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHostResponse), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHostResponse", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setHostResponse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setHostResponse", "(Ljava/lang/String;)V", "GetSetHostResponse_Ljava_lang_String_Handler")]
			set {
				if (id_setHostResponse_Ljava_lang_String_ == IntPtr.Zero)
					id_setHostResponse_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setHostResponse", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHostResponse_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHostResponse", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InternalMessage = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getInternalMessage;
		static IntPtr id_setInternalMessage_Ljava_lang_String_;
		public virtual unsafe string InternalMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getInternalMessage' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setInternalMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IsCommercialCard = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIsCommercialCard;
		static IntPtr id_setIsCommercialCard_Ljava_lang_String_;
		public virtual unsafe string IsCommercialCard {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getIsCommercialCard' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setIsCommercialCard' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IsoCountryCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIsoCountryCode;
		static IntPtr id_setIsoCountryCode_Ljava_lang_String_;
		public virtual unsafe string IsoCountryCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getIsoCountryCode' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setIsoCountryCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IsoCurrencyCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIsoCurrencyCode;
		static IntPtr id_setIsoCurrencyCode_Ljava_lang_String_;
		public virtual unsafe string IsoCurrencyCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getIsoCurrencyCode' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setIsoCurrencyCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IsoRequestDate = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIsoRequestDate;
		static IntPtr id_setIsoRequestDate_Ljava_lang_String_;
		public virtual unsafe string IsoRequestDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getIsoRequestDate' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setIsoRequestDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IsoTransactionDate = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIsoTransactionDate;
		static IntPtr id_setIsoTransactionDate_Ljava_lang_String_;
		public virtual unsafe string IsoTransactionDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getIsoTransactionDate' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setIsoTransactionDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MerchantCategoryCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMerchantCategoryCode;
		static IntPtr id_setMerchantCategoryCode_Ljava_lang_String_;
		public virtual unsafe string MerchantCategoryCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getMerchantCategoryCode' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setMerchantCategoryCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getMessage;
#pragma warning disable 0169
		static Delegate GetGetMessageHandler ()
		{
			if (cb_getMessage == null)
				cb_getMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessage);
			return cb_getMessage;
		}

		static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		static Delegate cb_setMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setMessage_Ljava_lang_String_ == null)
				cb_setMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMessage_Ljava_lang_String_);
			return cb_setMessage_Ljava_lang_String_;
		}

		static void n_SetMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Message = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMessage;
		static IntPtr id_setMessage_Ljava_lang_String_;
		public virtual unsafe string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMessage", "(Ljava/lang/String;)V", "GetSetMessage_Ljava_lang_String_Handler")]
			set {
				if (id_setMessage_Ljava_lang_String_ == IntPtr.Zero)
					id_setMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMessage", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMessage_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessage", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMessage1;
#pragma warning disable 0169
		static Delegate GetGetMessage1Handler ()
		{
			if (cb_getMessage1 == null)
				cb_getMessage1 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessage1);
			return cb_getMessage1;
		}

		static IntPtr n_GetMessage1 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message1);
		}
#pragma warning restore 0169

		static Delegate cb_setMessage1_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMessage1_Ljava_lang_String_Handler ()
		{
			if (cb_setMessage1_Ljava_lang_String_ == null)
				cb_setMessage1_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMessage1_Ljava_lang_String_);
			return cb_setMessage1_Ljava_lang_String_;
		}

		static void n_SetMessage1_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Message1 = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMessage1;
		static IntPtr id_setMessage1_Ljava_lang_String_;
		public virtual unsafe string Message1 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getMessage1' and count(parameter)=0]"
			[Register ("getMessage1", "()Ljava/lang/String;", "GetGetMessage1Handler")]
			get {
				if (id_getMessage1 == IntPtr.Zero)
					id_getMessage1 = JNIEnv.GetMethodID (class_ref, "getMessage1", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessage1), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessage1", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setMessage1' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMessage1", "(Ljava/lang/String;)V", "GetSetMessage1_Ljava_lang_String_Handler")]
			set {
				if (id_setMessage1_Ljava_lang_String_ == IntPtr.Zero)
					id_setMessage1_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMessage1", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMessage1_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessage1", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMessage2;
#pragma warning disable 0169
		static Delegate GetGetMessage2Handler ()
		{
			if (cb_getMessage2 == null)
				cb_getMessage2 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessage2);
			return cb_getMessage2;
		}

		static IntPtr n_GetMessage2 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message2);
		}
#pragma warning restore 0169

		static Delegate cb_setMessage2_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMessage2_Ljava_lang_String_Handler ()
		{
			if (cb_setMessage2_Ljava_lang_String_ == null)
				cb_setMessage2_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMessage2_Ljava_lang_String_);
			return cb_setMessage2_Ljava_lang_String_;
		}

		static void n_SetMessage2_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Message2 = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMessage2;
		static IntPtr id_setMessage2_Ljava_lang_String_;
		public virtual unsafe string Message2 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getMessage2' and count(parameter)=0]"
			[Register ("getMessage2", "()Ljava/lang/String;", "GetGetMessage2Handler")]
			get {
				if (id_getMessage2 == IntPtr.Zero)
					id_getMessage2 = JNIEnv.GetMethodID (class_ref, "getMessage2", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessage2), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessage2", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setMessage2' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMessage2", "(Ljava/lang/String;)V", "GetSetMessage2_Ljava_lang_String_Handler")]
			set {
				if (id_setMessage2_Ljava_lang_String_ == IntPtr.Zero)
					id_setMessage2_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMessage2", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMessage2_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessage2", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NetworkMerchantId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNetworkMerchantId;
		static IntPtr id_setNetworkMerchantId_Ljava_lang_String_;
		public virtual unsafe string NetworkMerchantId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getNetworkMerchantId' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setNetworkMerchantId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NetworkReferenceNumber = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNetworkReferenceNumber;
		static IntPtr id_setNetworkReferenceNumber_Ljava_lang_String_;
		public virtual unsafe string NetworkReferenceNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getNetworkReferenceNumber' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setNetworkReferenceNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NetworkTerminalId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNetworkTerminalId;
		static IntPtr id_setNetworkTerminalId_Ljava_lang_String_;
		public virtual unsafe string NetworkTerminalId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getNetworkTerminalId' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setNetworkTerminalId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getRawResponse;
#pragma warning disable 0169
		static Delegate GetGetRawResponseHandler ()
		{
			if (cb_getRawResponse == null)
				cb_getRawResponse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRawResponse);
			return cb_getRawResponse;
		}

		static IntPtr n_GetRawResponse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RawResponse);
		}
#pragma warning restore 0169

		static Delegate cb_setRawResponse_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRawResponse_Ljava_lang_String_Handler ()
		{
			if (cb_setRawResponse_Ljava_lang_String_ == null)
				cb_setRawResponse_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRawResponse_Ljava_lang_String_);
			return cb_setRawResponse_Ljava_lang_String_;
		}

		static void n_SetRawResponse_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RawResponse = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRawResponse;
		static IntPtr id_setRawResponse_Ljava_lang_String_;
		public virtual unsafe string RawResponse {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getRawResponse' and count(parameter)=0]"
			[Register ("getRawResponse", "()Ljava/lang/String;", "GetGetRawResponseHandler")]
			get {
				if (id_getRawResponse == IntPtr.Zero)
					id_getRawResponse = JNIEnv.GetMethodID (class_ref, "getRawResponse", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRawResponse), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRawResponse", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setRawResponse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRawResponse", "(Ljava/lang/String;)V", "GetSetRawResponse_Ljava_lang_String_Handler")]
			set {
				if (id_setRawResponse_Ljava_lang_String_ == IntPtr.Zero)
					id_setRawResponse_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRawResponse", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRawResponse_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRawResponse", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getRefNum;
#pragma warning disable 0169
		static Delegate GetGetRefNumHandler ()
		{
			if (cb_getRefNum == null)
				cb_getRefNum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRefNum);
			return cb_getRefNum;
		}

		static IntPtr n_GetRefNum (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RefNum);
		}
#pragma warning restore 0169

		static Delegate cb_setRefNum_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRefNum_Ljava_lang_String_Handler ()
		{
			if (cb_setRefNum_Ljava_lang_String_ == null)
				cb_setRefNum_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRefNum_Ljava_lang_String_);
			return cb_setRefNum_Ljava_lang_String_;
		}

		static void n_SetRefNum_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RefNum = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRefNum;
		static IntPtr id_setRefNum_Ljava_lang_String_;
		public virtual unsafe string RefNum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getRefNum' and count(parameter)=0]"
			[Register ("getRefNum", "()Ljava/lang/String;", "GetGetRefNumHandler")]
			get {
				if (id_getRefNum == IntPtr.Zero)
					id_getRefNum = JNIEnv.GetMethodID (class_ref, "getRefNum", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRefNum), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRefNum", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setRefNum' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRefNum", "(Ljava/lang/String;)V", "GetSetRefNum_Ljava_lang_String_Handler")]
			set {
				if (id_setRefNum_Ljava_lang_String_ == IntPtr.Zero)
					id_setRefNum_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRefNum", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRefNum_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRefNum", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemainingAmount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRemainingAmount;
		static IntPtr id_setRemainingAmount_Ljava_lang_String_;
		public virtual unsafe string RemainingAmount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getRemainingAmount' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setRemainingAmount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getRemainingBalance;
#pragma warning disable 0169
		static Delegate GetGetRemainingBalanceHandler ()
		{
			if (cb_getRemainingBalance == null)
				cb_getRemainingBalance = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRemainingBalance);
			return cb_getRemainingBalance;
		}

		static IntPtr n_GetRemainingBalance (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RemainingBalance);
		}
#pragma warning restore 0169

		static Delegate cb_setRemainingBalance_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRemainingBalance_Ljava_lang_String_Handler ()
		{
			if (cb_setRemainingBalance_Ljava_lang_String_ == null)
				cb_setRemainingBalance_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRemainingBalance_Ljava_lang_String_);
			return cb_setRemainingBalance_Ljava_lang_String_;
		}

		static void n_SetRemainingBalance_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemainingBalance = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRemainingBalance;
		static IntPtr id_setRemainingBalance_Ljava_lang_String_;
		public virtual unsafe string RemainingBalance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getRemainingBalance' and count(parameter)=0]"
			[Register ("getRemainingBalance", "()Ljava/lang/String;", "GetGetRemainingBalanceHandler")]
			get {
				if (id_getRemainingBalance == IntPtr.Zero)
					id_getRemainingBalance = JNIEnv.GetMethodID (class_ref, "getRemainingBalance", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRemainingBalance), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRemainingBalance", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setRemainingBalance' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRemainingBalance", "(Ljava/lang/String;)V", "GetSetRemainingBalance_Ljava_lang_String_Handler")]
			set {
				if (id_setRemainingBalance_Ljava_lang_String_ == IntPtr.Zero)
					id_setRemainingBalance_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRemainingBalance", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRemainingBalance_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRemainingBalance", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getRequestedAmount;
#pragma warning disable 0169
		static Delegate GetGetRequestedAmountHandler ()
		{
			if (cb_getRequestedAmount == null)
				cb_getRequestedAmount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestedAmount);
			return cb_getRequestedAmount;
		}

		static IntPtr n_GetRequestedAmount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestedAmount);
		}
#pragma warning restore 0169

		static Delegate cb_setRequestedAmount_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRequestedAmount_Ljava_lang_String_Handler ()
		{
			if (cb_setRequestedAmount_Ljava_lang_String_ == null)
				cb_setRequestedAmount_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRequestedAmount_Ljava_lang_String_);
			return cb_setRequestedAmount_Ljava_lang_String_;
		}

		static void n_SetRequestedAmount_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RequestedAmount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRequestedAmount;
		static IntPtr id_setRequestedAmount_Ljava_lang_String_;
		public virtual unsafe string RequestedAmount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getRequestedAmount' and count(parameter)=0]"
			[Register ("getRequestedAmount", "()Ljava/lang/String;", "GetGetRequestedAmountHandler")]
			get {
				if (id_getRequestedAmount == IntPtr.Zero)
					id_getRequestedAmount = JNIEnv.GetMethodID (class_ref, "getRequestedAmount", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequestedAmount), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestedAmount", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setRequestedAmount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRequestedAmount", "(Ljava/lang/String;)V", "GetSetRequestedAmount_Ljava_lang_String_Handler")]
			set {
				if (id_setRequestedAmount_Ljava_lang_String_ == IntPtr.Zero)
					id_setRequestedAmount_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRequestedAmount", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRequestedAmount_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRequestedAmount", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ResponseTypeDescription = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getResponseTypeDescription;
		static IntPtr id_setResponseTypeDescription_Ljava_lang_String_;
		public virtual unsafe string ResponseTypeDescription {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getResponseTypeDescription' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setResponseTypeDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getResultCode;
#pragma warning disable 0169
		static Delegate GetGetResultCodeHandler ()
		{
			if (cb_getResultCode == null)
				cb_getResultCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResultCode);
			return cb_getResultCode;
		}

		static IntPtr n_GetResultCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ResultCode);
		}
#pragma warning restore 0169

		static Delegate cb_setResultCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetResultCode_Ljava_lang_String_Handler ()
		{
			if (cb_setResultCode_Ljava_lang_String_ == null)
				cb_setResultCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetResultCode_Ljava_lang_String_);
			return cb_setResultCode_Ljava_lang_String_;
		}

		static void n_SetResultCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ResultCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getResultCode;
		static IntPtr id_setResultCode_Ljava_lang_String_;
		public virtual unsafe string ResultCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getResultCode' and count(parameter)=0]"
			[Register ("getResultCode", "()Ljava/lang/String;", "GetGetResultCodeHandler")]
			get {
				if (id_getResultCode == IntPtr.Zero)
					id_getResultCode = JNIEnv.GetMethodID (class_ref, "getResultCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResultCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResultCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setResultCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setResultCode", "(Ljava/lang/String;)V", "GetSetResultCode_Ljava_lang_String_Handler")]
			set {
				if (id_setResultCode_Ljava_lang_String_ == IntPtr.Zero)
					id_setResultCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setResultCode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setResultCode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResultCode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getResultTxt;
#pragma warning disable 0169
		static Delegate GetGetResultTxtHandler ()
		{
			if (cb_getResultTxt == null)
				cb_getResultTxt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResultTxt);
			return cb_getResultTxt;
		}

		static IntPtr n_GetResultTxt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ResultTxt);
		}
#pragma warning restore 0169

		static Delegate cb_setResultTxt_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetResultTxt_Ljava_lang_String_Handler ()
		{
			if (cb_setResultTxt_Ljava_lang_String_ == null)
				cb_setResultTxt_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetResultTxt_Ljava_lang_String_);
			return cb_setResultTxt_Ljava_lang_String_;
		}

		static void n_SetResultTxt_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ResultTxt = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getResultTxt;
		static IntPtr id_setResultTxt_Ljava_lang_String_;
		public virtual unsafe string ResultTxt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getResultTxt' and count(parameter)=0]"
			[Register ("getResultTxt", "()Ljava/lang/String;", "GetGetResultTxtHandler")]
			get {
				if (id_getResultTxt == IntPtr.Zero)
					id_getResultTxt = JNIEnv.GetMethodID (class_ref, "getResultTxt", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResultTxt), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResultTxt", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setResultTxt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setResultTxt", "(Ljava/lang/String;)V", "GetSetResultTxt_Ljava_lang_String_Handler")]
			set {
				if (id_setResultTxt_Ljava_lang_String_ == IntPtr.Zero)
					id_setResultTxt_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setResultTxt", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setResultTxt_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResultTxt", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StreetMatchMessage = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStreetMatchMessage;
		static IntPtr id_setStreetMatchMessage_Ljava_lang_String_;
		public virtual unsafe string StreetMatchMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getStreetMatchMessage' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setStreetMatchMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getSubmittedAmount;
#pragma warning disable 0169
		static Delegate GetGetSubmittedAmountHandler ()
		{
			if (cb_getSubmittedAmount == null)
				cb_getSubmittedAmount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSubmittedAmount);
			return cb_getSubmittedAmount;
		}

		static IntPtr n_GetSubmittedAmount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SubmittedAmount);
		}
#pragma warning restore 0169

		static Delegate cb_setSubmittedAmount_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSubmittedAmount_Ljava_lang_String_Handler ()
		{
			if (cb_setSubmittedAmount_Ljava_lang_String_ == null)
				cb_setSubmittedAmount_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSubmittedAmount_Ljava_lang_String_);
			return cb_setSubmittedAmount_Ljava_lang_String_;
		}

		static void n_SetSubmittedAmount_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SubmittedAmount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSubmittedAmount;
		static IntPtr id_setSubmittedAmount_Ljava_lang_String_;
		public virtual unsafe string SubmittedAmount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getSubmittedAmount' and count(parameter)=0]"
			[Register ("getSubmittedAmount", "()Ljava/lang/String;", "GetGetSubmittedAmountHandler")]
			get {
				if (id_getSubmittedAmount == IntPtr.Zero)
					id_getSubmittedAmount = JNIEnv.GetMethodID (class_ref, "getSubmittedAmount", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSubmittedAmount), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSubmittedAmount", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setSubmittedAmount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSubmittedAmount", "(Ljava/lang/String;)V", "GetSetSubmittedAmount_Ljava_lang_String_Handler")]
			set {
				if (id_setSubmittedAmount_Ljava_lang_String_ == IntPtr.Zero)
					id_setSubmittedAmount_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSubmittedAmount", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSubmittedAmount_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSubmittedAmount", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTimeStamp;
#pragma warning disable 0169
		static Delegate GetGetTimeStampHandler ()
		{
			if (cb_getTimeStamp == null)
				cb_getTimeStamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTimeStamp);
			return cb_getTimeStamp;
		}

		static IntPtr n_GetTimeStamp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TimeStamp);
		}
#pragma warning restore 0169

		static Delegate cb_setTimeStamp_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTimeStamp_Ljava_lang_String_Handler ()
		{
			if (cb_setTimeStamp_Ljava_lang_String_ == null)
				cb_setTimeStamp_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTimeStamp_Ljava_lang_String_);
			return cb_setTimeStamp_Ljava_lang_String_;
		}

		static void n_SetTimeStamp_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TimeStamp = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTimeStamp;
		static IntPtr id_setTimeStamp_Ljava_lang_String_;
		public virtual unsafe string TimeStamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getTimeStamp' and count(parameter)=0]"
			[Register ("getTimeStamp", "()Ljava/lang/String;", "GetGetTimeStampHandler")]
			get {
				if (id_getTimeStamp == IntPtr.Zero)
					id_getTimeStamp = JNIEnv.GetMethodID (class_ref, "getTimeStamp", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTimeStamp), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimeStamp", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setTimeStamp' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTimeStamp", "(Ljava/lang/String;)V", "GetSetTimeStamp_Ljava_lang_String_Handler")]
			set {
				if (id_setTimeStamp_Ljava_lang_String_ == IntPtr.Zero)
					id_setTimeStamp_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTimeStamp", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTimeStamp_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimeStamp", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTipAmount;
#pragma warning disable 0169
		static Delegate GetGetTipAmountHandler ()
		{
			if (cb_getTipAmount == null)
				cb_getTipAmount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTipAmount);
			return cb_getTipAmount;
		}

		static IntPtr n_GetTipAmount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TipAmount);
		}
#pragma warning restore 0169

		static Delegate cb_setTipAmount_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTipAmount_Ljava_lang_String_Handler ()
		{
			if (cb_setTipAmount_Ljava_lang_String_ == null)
				cb_setTipAmount_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTipAmount_Ljava_lang_String_);
			return cb_setTipAmount_Ljava_lang_String_;
		}

		static void n_SetTipAmount_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TipAmount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTipAmount;
		static IntPtr id_setTipAmount_Ljava_lang_String_;
		public virtual unsafe string TipAmount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getTipAmount' and count(parameter)=0]"
			[Register ("getTipAmount", "()Ljava/lang/String;", "GetGetTipAmountHandler")]
			get {
				if (id_getTipAmount == IntPtr.Zero)
					id_getTipAmount = JNIEnv.GetMethodID (class_ref, "getTipAmount", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTipAmount), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTipAmount", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setTipAmount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTipAmount", "(Ljava/lang/String;)V", "GetSetTipAmount_Ljava_lang_String_Handler")]
			set {
				if (id_setTipAmount_Ljava_lang_String_ == IntPtr.Zero)
					id_setTipAmount_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTipAmount", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTipAmount_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTipAmount", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Token = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getToken;
		static IntPtr id_setToken_Ljava_lang_String_;
		public virtual unsafe string Token {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getToken' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TransactionCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTransactionCode;
		static IntPtr id_setTransactionCode_Ljava_lang_String_;
		public virtual unsafe string TransactionCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='getTransactionCode' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='PaymentResponse']/method[@name='setTransactionCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

	}
}
