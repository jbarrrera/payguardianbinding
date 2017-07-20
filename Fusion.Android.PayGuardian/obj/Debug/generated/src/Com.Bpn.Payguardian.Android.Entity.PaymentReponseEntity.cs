using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bpn.Payguardian.Android.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']"
	[global::Android.Runtime.Register ("com/bpn/payguardian/android/entity/PaymentReponseEntity", DoNotGenerateAcw=true)]
	public partial class PaymentReponseEntity : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bpn/payguardian/android/entity/PaymentReponseEntity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PaymentReponseEntity); }
		}

		protected PaymentReponseEntity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/constructor[@name='PaymentReponseEntity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PaymentReponseEntity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PaymentReponseEntity)) {
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

		static Delegate cb_getATC;
#pragma warning disable 0169
		static Delegate GetGetATCHandler ()
		{
			if (cb_getATC == null)
				cb_getATC = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetATC);
			return cb_getATC;
		}

		static IntPtr n_GetATC (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ATC);
		}
#pragma warning restore 0169

		static Delegate cb_setATC_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetATC_Ljava_lang_String_Handler ()
		{
			if (cb_setATC_Ljava_lang_String_ == null)
				cb_setATC_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetATC_Ljava_lang_String_);
			return cb_setATC_Ljava_lang_String_;
		}

		static void n_SetATC_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ATC = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getATC;
		static IntPtr id_setATC_Ljava_lang_String_;
		public virtual unsafe string ATC {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getATC' and count(parameter)=0]"
			[Register ("getATC", "()Ljava/lang/String;", "GetGetATCHandler")]
			get {
				if (id_getATC == IntPtr.Zero)
					id_getATC = JNIEnv.GetMethodID (class_ref, "getATC", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getATC), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getATC", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setATC' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setATC", "(Ljava/lang/String;)V", "GetSetATC_Ljava_lang_String_Handler")]
			set {
				if (id_setATC_Ljava_lang_String_ == IntPtr.Zero)
					id_setATC_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setATC", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setATC_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setATC", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AVSMessage = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAVSMessage;
		static IntPtr id_setAVSMessage_Ljava_lang_String_;
		public virtual unsafe string AVSMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getAVSMessage' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setAVSMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getAVSResult;
#pragma warning disable 0169
		static Delegate GetGetAVSResultHandler ()
		{
			if (cb_getAVSResult == null)
				cb_getAVSResult = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAVSResult);
			return cb_getAVSResult;
		}

		static IntPtr n_GetAVSResult (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AVSResult);
		}
#pragma warning restore 0169

		static Delegate cb_setAVSResult_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAVSResult_Ljava_lang_String_Handler ()
		{
			if (cb_setAVSResult_Ljava_lang_String_ == null)
				cb_setAVSResult_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAVSResult_Ljava_lang_String_);
			return cb_setAVSResult_Ljava_lang_String_;
		}

		static void n_SetAVSResult_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AVSResult = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAVSResult;
		static IntPtr id_setAVSResult_Ljava_lang_String_;
		public virtual unsafe string AVSResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getAVSResult' and count(parameter)=0]"
			[Register ("getAVSResult", "()Ljava/lang/String;", "GetGetAVSResultHandler")]
			get {
				if (id_getAVSResult == IntPtr.Zero)
					id_getAVSResult = JNIEnv.GetMethodID (class_ref, "getAVSResult", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAVSResult), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAVSResult", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setAVSResult' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAVSResult", "(Ljava/lang/String;)V", "GetSetAVSResult_Ljava_lang_String_Handler")]
			set {
				if (id_setAVSResult_Ljava_lang_String_ == IntPtr.Zero)
					id_setAVSResult_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAVSResult", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAVSResult_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAVSResult", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getAppLabel;
#pragma warning disable 0169
		static Delegate GetGetAppLabelHandler ()
		{
			if (cb_getAppLabel == null)
				cb_getAppLabel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppLabel);
			return cb_getAppLabel;
		}

		static IntPtr n_GetAppLabel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppLabel);
		}
#pragma warning restore 0169

		static Delegate cb_setAppLabel_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppLabel_Ljava_lang_String_Handler ()
		{
			if (cb_setAppLabel_Ljava_lang_String_ == null)
				cb_setAppLabel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAppLabel_Ljava_lang_String_);
			return cb_setAppLabel_Ljava_lang_String_;
		}

		static void n_SetAppLabel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AppLabel = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAppLabel;
		static IntPtr id_setAppLabel_Ljava_lang_String_;
		public virtual unsafe string AppLabel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getAppLabel' and count(parameter)=0]"
			[Register ("getAppLabel", "()Ljava/lang/String;", "GetGetAppLabelHandler")]
			get {
				if (id_getAppLabel == IntPtr.Zero)
					id_getAppLabel = JNIEnv.GetMethodID (class_ref, "getAppLabel", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppLabel), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppLabel", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setAppLabel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAppLabel", "(Ljava/lang/String;)V", "GetSetAppLabel_Ljava_lang_String_Handler")]
			set {
				if (id_setAppLabel_Ljava_lang_String_ == IntPtr.Zero)
					id_setAppLabel_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppLabel", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAppLabel_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAppLabel", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AuthorizationCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAuthorizationCode;
		static IntPtr id_setAuthorizationCode_Ljava_lang_String_;
		public virtual unsafe string AuthorizationCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getAuthorizationCode' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setAuthorizationCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AuthorizedAmount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAuthorizedAmount;
		static IntPtr id_setAuthorizedAmount_Ljava_lang_String_;
		public virtual unsafe string AuthorizedAmount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getAuthorizedAmount' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setAuthorizedAmount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CVMessage = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCVMessage;
		static IntPtr id_setCVMessage_Ljava_lang_String_;
		public virtual unsafe string CVMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getCVMessage' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setCVMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getCVResult;
#pragma warning disable 0169
		static Delegate GetGetCVResultHandler ()
		{
			if (cb_getCVResult == null)
				cb_getCVResult = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCVResult);
			return cb_getCVResult;
		}

		static IntPtr n_GetCVResult (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CVResult);
		}
#pragma warning restore 0169

		static Delegate cb_setCVResult_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCVResult_Ljava_lang_String_Handler ()
		{
			if (cb_setCVResult_Ljava_lang_String_ == null)
				cb_setCVResult_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCVResult_Ljava_lang_String_);
			return cb_setCVResult_Ljava_lang_String_;
		}

		static void n_SetCVResult_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CVResult = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCVResult;
		static IntPtr id_setCVResult_Ljava_lang_String_;
		public virtual unsafe string CVResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getCVResult' and count(parameter)=0]"
			[Register ("getCVResult", "()Ljava/lang/String;", "GetGetCVResultHandler")]
			get {
				if (id_getCVResult == IntPtr.Zero)
					id_getCVResult = JNIEnv.GetMethodID (class_ref, "getCVResult", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCVResult), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCVResult", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setCVResult' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCVResult", "(Ljava/lang/String;)V", "GetSetCVResult_Ljava_lang_String_Handler")]
			set {
				if (id_setCVResult_Ljava_lang_String_ == IntPtr.Zero)
					id_setCVResult_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCVResult", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCVResult_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCVResult", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CardType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCardType;
		static IntPtr id_setCardType_Ljava_lang_String_;
		public virtual unsafe string CardType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getCardType' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setCardType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getCashBackAmt;
#pragma warning disable 0169
		static Delegate GetGetCashBackAmtHandler ()
		{
			if (cb_getCashBackAmt == null)
				cb_getCashBackAmt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCashBackAmt);
			return cb_getCashBackAmt;
		}

		static IntPtr n_GetCashBackAmt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CashBackAmt);
		}
#pragma warning restore 0169

		static Delegate cb_setCashBackAmt_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCashBackAmt_Ljava_lang_String_Handler ()
		{
			if (cb_setCashBackAmt_Ljava_lang_String_ == null)
				cb_setCashBackAmt_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCashBackAmt_Ljava_lang_String_);
			return cb_setCashBackAmt_Ljava_lang_String_;
		}

		static void n_SetCashBackAmt_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CashBackAmt = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCashBackAmt;
		static IntPtr id_setCashBackAmt_Ljava_lang_String_;
		public virtual unsafe string CashBackAmt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getCashBackAmt' and count(parameter)=0]"
			[Register ("getCashBackAmt", "()Ljava/lang/String;", "GetGetCashBackAmtHandler")]
			get {
				if (id_getCashBackAmt == IntPtr.Zero)
					id_getCashBackAmt = JNIEnv.GetMethodID (class_ref, "getCashBackAmt", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCashBackAmt), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCashBackAmt", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setCashBackAmt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCashBackAmt", "(Ljava/lang/String;)V", "GetSetCashBackAmt_Ljava_lang_String_Handler")]
			set {
				if (id_setCashBackAmt_Ljava_lang_String_ == IntPtr.Zero)
					id_setCashBackAmt_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCashBackAmt", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCashBackAmt_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCashBackAmt", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCheckType;
#pragma warning disable 0169
		static Delegate GetGetCheckTypeHandler ()
		{
			if (cb_getCheckType == null)
				cb_getCheckType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCheckType);
			return cb_getCheckType;
		}

		static IntPtr n_GetCheckType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CheckType);
		}
#pragma warning restore 0169

		static Delegate cb_setCheckType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCheckType_Ljava_lang_String_Handler ()
		{
			if (cb_setCheckType_Ljava_lang_String_ == null)
				cb_setCheckType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCheckType_Ljava_lang_String_);
			return cb_setCheckType_Ljava_lang_String_;
		}

		static void n_SetCheckType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CheckType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCheckType;
		static IntPtr id_setCheckType_Ljava_lang_String_;
		public virtual unsafe string CheckType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getCheckType' and count(parameter)=0]"
			[Register ("getCheckType", "()Ljava/lang/String;", "GetGetCheckTypeHandler")]
			get {
				if (id_getCheckType == IntPtr.Zero)
					id_getCheckType = JNIEnv.GetMethodID (class_ref, "getCheckType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCheckType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCheckType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setCheckType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCheckType", "(Ljava/lang/String;)V", "GetSetCheckType_Ljava_lang_String_Handler")]
			set {
				if (id_setCheckType_Ljava_lang_String_ == IntPtr.Zero)
					id_setCheckType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCheckType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCheckType_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCheckType", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getChipCardAID;
#pragma warning disable 0169
		static Delegate GetGetChipCardAIDHandler ()
		{
			if (cb_getChipCardAID == null)
				cb_getChipCardAID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChipCardAID);
			return cb_getChipCardAID;
		}

		static IntPtr n_GetChipCardAID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ChipCardAID);
		}
#pragma warning restore 0169

		static Delegate cb_setChipCardAID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetChipCardAID_Ljava_lang_String_Handler ()
		{
			if (cb_setChipCardAID_Ljava_lang_String_ == null)
				cb_setChipCardAID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetChipCardAID_Ljava_lang_String_);
			return cb_setChipCardAID_Ljava_lang_String_;
		}

		static void n_SetChipCardAID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ChipCardAID = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getChipCardAID;
		static IntPtr id_setChipCardAID_Ljava_lang_String_;
		public virtual unsafe string ChipCardAID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getChipCardAID' and count(parameter)=0]"
			[Register ("getChipCardAID", "()Ljava/lang/String;", "GetGetChipCardAIDHandler")]
			get {
				if (id_getChipCardAID == IntPtr.Zero)
					id_getChipCardAID = JNIEnv.GetMethodID (class_ref, "getChipCardAID", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChipCardAID), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChipCardAID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setChipCardAID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setChipCardAID", "(Ljava/lang/String;)V", "GetSetChipCardAID_Ljava_lang_String_Handler")]
			set {
				if (id_setChipCardAID_Ljava_lang_String_ == IntPtr.Zero)
					id_setChipCardAID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setChipCardAID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setChipCardAID_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setChipCardAID", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDateOfBirth;
#pragma warning disable 0169
		static Delegate GetGetDateOfBirthHandler ()
		{
			if (cb_getDateOfBirth == null)
				cb_getDateOfBirth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDateOfBirth);
			return cb_getDateOfBirth;
		}

		static IntPtr n_GetDateOfBirth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DateOfBirth);
		}
#pragma warning restore 0169

		static Delegate cb_setDateOfBirth_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDateOfBirth_Ljava_lang_String_Handler ()
		{
			if (cb_setDateOfBirth_Ljava_lang_String_ == null)
				cb_setDateOfBirth_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDateOfBirth_Ljava_lang_String_);
			return cb_setDateOfBirth_Ljava_lang_String_;
		}

		static void n_SetDateOfBirth_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DateOfBirth = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDateOfBirth;
		static IntPtr id_setDateOfBirth_Ljava_lang_String_;
		public virtual unsafe string DateOfBirth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getDateOfBirth' and count(parameter)=0]"
			[Register ("getDateOfBirth", "()Ljava/lang/String;", "GetGetDateOfBirthHandler")]
			get {
				if (id_getDateOfBirth == IntPtr.Zero)
					id_getDateOfBirth = JNIEnv.GetMethodID (class_ref, "getDateOfBirth", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDateOfBirth), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDateOfBirth", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setDateOfBirth' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDateOfBirth", "(Ljava/lang/String;)V", "GetSetDateOfBirth_Ljava_lang_String_Handler")]
			set {
				if (id_setDateOfBirth_Ljava_lang_String_ == IntPtr.Zero)
					id_setDateOfBirth_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDateOfBirth", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDateOfBirth_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDateOfBirth", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDriverLicence;
#pragma warning disable 0169
		static Delegate GetGetDriverLicenceHandler ()
		{
			if (cb_getDriverLicence == null)
				cb_getDriverLicence = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDriverLicence);
			return cb_getDriverLicence;
		}

		static IntPtr n_GetDriverLicence (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DriverLicence);
		}
#pragma warning restore 0169

		static Delegate cb_setDriverLicence_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDriverLicence_Ljava_lang_String_Handler ()
		{
			if (cb_setDriverLicence_Ljava_lang_String_ == null)
				cb_setDriverLicence_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDriverLicence_Ljava_lang_String_);
			return cb_setDriverLicence_Ljava_lang_String_;
		}

		static void n_SetDriverLicence_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DriverLicence = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDriverLicence;
		static IntPtr id_setDriverLicence_Ljava_lang_String_;
		public virtual unsafe string DriverLicence {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getDriverLicence' and count(parameter)=0]"
			[Register ("getDriverLicence", "()Ljava/lang/String;", "GetGetDriverLicenceHandler")]
			get {
				if (id_getDriverLicence == IntPtr.Zero)
					id_getDriverLicence = JNIEnv.GetMethodID (class_ref, "getDriverLicence", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDriverLicence), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDriverLicence", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setDriverLicence' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDriverLicence", "(Ljava/lang/String;)V", "GetSetDriverLicence_Ljava_lang_String_Handler")]
			set {
				if (id_setDriverLicence_Ljava_lang_String_ == IntPtr.Zero)
					id_setDriverLicence_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDriverLicence", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDriverLicence_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDriverLicence", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getEntryMethod;
#pragma warning disable 0169
		static Delegate GetGetEntryMethodHandler ()
		{
			if (cb_getEntryMethod == null)
				cb_getEntryMethod = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEntryMethod);
			return cb_getEntryMethod;
		}

		static IntPtr n_GetEntryMethod (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EntryMethod);
		}
#pragma warning restore 0169

		static Delegate cb_setEntryMethod_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEntryMethod_Ljava_lang_String_Handler ()
		{
			if (cb_setEntryMethod_Ljava_lang_String_ == null)
				cb_setEntryMethod_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEntryMethod_Ljava_lang_String_);
			return cb_setEntryMethod_Ljava_lang_String_;
		}

		static void n_SetEntryMethod_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EntryMethod = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEntryMethod;
		static IntPtr id_setEntryMethod_Ljava_lang_String_;
		public virtual unsafe string EntryMethod {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getEntryMethod' and count(parameter)=0]"
			[Register ("getEntryMethod", "()Ljava/lang/String;", "GetGetEntryMethodHandler")]
			get {
				if (id_getEntryMethod == IntPtr.Zero)
					id_getEntryMethod = JNIEnv.GetMethodID (class_ref, "getEntryMethod", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEntryMethod), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEntryMethod", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setEntryMethod' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEntryMethod", "(Ljava/lang/String;)V", "GetSetEntryMethod_Ljava_lang_String_Handler")]
			set {
				if (id_setEntryMethod_Ljava_lang_String_ == IntPtr.Zero)
					id_setEntryMethod_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEntryMethod", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEntryMethod_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEntryMethod", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ExpirationDate = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getExpirationDate;
		static IntPtr id_setExpirationDate_Ljava_lang_String_;
		public virtual unsafe string ExpirationDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getExpirationDate' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setExpirationDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GatewayMessage = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getGatewayMessage;
		static IntPtr id_setGatewayMessage_Ljava_lang_String_;
		public virtual unsafe string GatewayMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getGatewayMessage' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setGatewayMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GatewayResult = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getGatewayResult;
		static IntPtr id_setGatewayResult_Ljava_lang_String_;
		public virtual unsafe string GatewayResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getGatewayResult' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setGatewayResult' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GatewayTransID = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getGatewayTransID;
		static IntPtr id_setGatewayTransID_Ljava_lang_String_;
		public virtual unsafe string GatewayTransID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getGatewayTransID' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setGatewayTransID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InternalMessage = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getInternalMessage;
		static IntPtr id_setInternalMessage_Ljava_lang_String_;
		public virtual unsafe string InternalMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getInternalMessage' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setInternalMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IsCommercialCard = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIsCommercialCard;
		static IntPtr id_setIsCommercialCard_Ljava_lang_String_;
		public virtual unsafe string IsCommercialCard {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getIsCommercialCard' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setIsCommercialCard' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IsoCountryCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIsoCountryCode;
		static IntPtr id_setIsoCountryCode_Ljava_lang_String_;
		public virtual unsafe string IsoCountryCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getIsoCountryCode' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setIsoCountryCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IsoCurrencyCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIsoCurrencyCode;
		static IntPtr id_setIsoCurrencyCode_Ljava_lang_String_;
		public virtual unsafe string IsoCurrencyCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getIsoCurrencyCode' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setIsoCurrencyCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IsoRequestDate = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIsoRequestDate;
		static IntPtr id_setIsoRequestDate_Ljava_lang_String_;
		public virtual unsafe string IsoRequestDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getIsoRequestDate' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setIsoRequestDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IsoTransactionDate = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIsoTransactionDate;
		static IntPtr id_setIsoTransactionDate_Ljava_lang_String_;
		public virtual unsafe string IsoTransactionDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getIsoTransactionDate' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setIsoTransactionDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IssuerTagData = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIssuerTagData;
		static IntPtr id_setIssuerTagData_Ljava_lang_String_;
		public virtual unsafe string IssuerTagData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getIssuerTagData' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setIssuerTagData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MaskedPan = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaskedPan;
		static IntPtr id_setMaskedPan_Ljava_lang_String_;
		public virtual unsafe string MaskedPan {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getMaskedPan' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setMaskedPan' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MerchantCategoryCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMerchantCategoryCode;
		static IntPtr id_setMerchantCategoryCode_Ljava_lang_String_;
		public virtual unsafe string MerchantCategoryCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getMerchantCategoryCode' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setMerchantCategoryCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getNameOnCheck;
#pragma warning disable 0169
		static Delegate GetGetNameOnCheckHandler ()
		{
			if (cb_getNameOnCheck == null)
				cb_getNameOnCheck = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNameOnCheck);
			return cb_getNameOnCheck;
		}

		static IntPtr n_GetNameOnCheck (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NameOnCheck);
		}
#pragma warning restore 0169

		static Delegate cb_setNameOnCheck_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNameOnCheck_Ljava_lang_String_Handler ()
		{
			if (cb_setNameOnCheck_Ljava_lang_String_ == null)
				cb_setNameOnCheck_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNameOnCheck_Ljava_lang_String_);
			return cb_setNameOnCheck_Ljava_lang_String_;
		}

		static void n_SetNameOnCheck_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NameOnCheck = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNameOnCheck;
		static IntPtr id_setNameOnCheck_Ljava_lang_String_;
		public virtual unsafe string NameOnCheck {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getNameOnCheck' and count(parameter)=0]"
			[Register ("getNameOnCheck", "()Ljava/lang/String;", "GetGetNameOnCheckHandler")]
			get {
				if (id_getNameOnCheck == IntPtr.Zero)
					id_getNameOnCheck = JNIEnv.GetMethodID (class_ref, "getNameOnCheck", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNameOnCheck), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNameOnCheck", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setNameOnCheck' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNameOnCheck", "(Ljava/lang/String;)V", "GetSetNameOnCheck_Ljava_lang_String_Handler")]
			set {
				if (id_setNameOnCheck_Ljava_lang_String_ == IntPtr.Zero)
					id_setNameOnCheck_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNameOnCheck", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNameOnCheck_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNameOnCheck", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NetworkMerchantId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNetworkMerchantId;
		static IntPtr id_setNetworkMerchantId_Ljava_lang_String_;
		public virtual unsafe string NetworkMerchantId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getNetworkMerchantId' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setNetworkMerchantId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NetworkReferenceNumber = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNetworkReferenceNumber;
		static IntPtr id_setNetworkReferenceNumber_Ljava_lang_String_;
		public virtual unsafe string NetworkReferenceNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getNetworkReferenceNumber' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setNetworkReferenceNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NetworkTerminalId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNetworkTerminalId;
		static IntPtr id_setNetworkTerminalId_Ljava_lang_String_;
		public virtual unsafe string NetworkTerminalId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getNetworkTerminalId' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setNetworkTerminalId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OriginalAmount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOriginalAmount;
		static IntPtr id_setOriginalAmount_Ljava_lang_String_;
		public virtual unsafe string OriginalAmount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getOriginalAmount' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setOriginalAmount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getPhoneNumber;
#pragma warning disable 0169
		static Delegate GetGetPhoneNumberHandler ()
		{
			if (cb_getPhoneNumber == null)
				cb_getPhoneNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPhoneNumber);
			return cb_getPhoneNumber;
		}

		static IntPtr n_GetPhoneNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PhoneNumber);
		}
#pragma warning restore 0169

		static Delegate cb_setPhoneNumber_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPhoneNumber_Ljava_lang_String_Handler ()
		{
			if (cb_setPhoneNumber_Ljava_lang_String_ == null)
				cb_setPhoneNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPhoneNumber_Ljava_lang_String_);
			return cb_setPhoneNumber_Ljava_lang_String_;
		}

		static void n_SetPhoneNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PhoneNumber = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPhoneNumber;
		static IntPtr id_setPhoneNumber_Ljava_lang_String_;
		public virtual unsafe string PhoneNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getPhoneNumber' and count(parameter)=0]"
			[Register ("getPhoneNumber", "()Ljava/lang/String;", "GetGetPhoneNumberHandler")]
			get {
				if (id_getPhoneNumber == IntPtr.Zero)
					id_getPhoneNumber = JNIEnv.GetMethodID (class_ref, "getPhoneNumber", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPhoneNumber), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPhoneNumber", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setPhoneNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPhoneNumber", "(Ljava/lang/String;)V", "GetSetPhoneNumber_Ljava_lang_String_Handler")]
			set {
				if (id_setPhoneNumber_Ljava_lang_String_ == IntPtr.Zero)
					id_setPhoneNumber_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPhoneNumber", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPhoneNumber_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPhoneNumber", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReceiptTagData = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getReceiptTagData;
		static IntPtr id_setReceiptTagData_Ljava_lang_String_;
		public virtual unsafe string ReceiptTagData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getReceiptTagData' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setReceiptTagData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReferenceNumber = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getReferenceNumber;
		static IntPtr id_setReferenceNumber_Ljava_lang_String_;
		public virtual unsafe string ReferenceNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getReferenceNumber' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setReferenceNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemainingAmount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRemainingAmount;
		static IntPtr id_setRemainingAmount_Ljava_lang_String_;
		public virtual unsafe string RemainingAmount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getRemainingAmount' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setRemainingAmount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RequestType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRequestType;
		static IntPtr id_setRequestType_Ljava_lang_String_;
		public virtual unsafe string RequestType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getRequestType' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setRequestType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ResponseCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getResponseCode;
		static IntPtr id_setResponseCode_Ljava_lang_String_;
		public virtual unsafe string ResponseCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getResponseCode' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setResponseCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ResponseDescription = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getResponseDescription;
		static IntPtr id_setResponseDescription_Ljava_lang_String_;
		public virtual unsafe string ResponseDescription {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getResponseDescription' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setResponseDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ResponseTypeDescription = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getResponseTypeDescription;
		static IntPtr id_setResponseTypeDescription_Ljava_lang_String_;
		public virtual unsafe string ResponseTypeDescription {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getResponseTypeDescription' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setResponseTypeDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getStateCode;
#pragma warning disable 0169
		static Delegate GetGetStateCodeHandler ()
		{
			if (cb_getStateCode == null)
				cb_getStateCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStateCode);
			return cb_getStateCode;
		}

		static IntPtr n_GetStateCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StateCode);
		}
#pragma warning restore 0169

		static Delegate cb_setStateCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStateCode_Ljava_lang_String_Handler ()
		{
			if (cb_setStateCode_Ljava_lang_String_ == null)
				cb_setStateCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStateCode_Ljava_lang_String_);
			return cb_setStateCode_Ljava_lang_String_;
		}

		static void n_SetStateCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StateCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStateCode;
		static IntPtr id_setStateCode_Ljava_lang_String_;
		public virtual unsafe string StateCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getStateCode' and count(parameter)=0]"
			[Register ("getStateCode", "()Ljava/lang/String;", "GetGetStateCodeHandler")]
			get {
				if (id_getStateCode == IntPtr.Zero)
					id_getStateCode = JNIEnv.GetMethodID (class_ref, "getStateCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStateCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStateCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setStateCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStateCode", "(Ljava/lang/String;)V", "GetSetStateCode_Ljava_lang_String_Handler")]
			set {
				if (id_setStateCode_Ljava_lang_String_ == IntPtr.Zero)
					id_setStateCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setStateCode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStateCode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStateCode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getStreet;
#pragma warning disable 0169
		static Delegate GetGetStreetHandler ()
		{
			if (cb_getStreet == null)
				cb_getStreet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStreet);
			return cb_getStreet;
		}

		static IntPtr n_GetStreet (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Street);
		}
#pragma warning restore 0169

		static Delegate cb_setStreet_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStreet_Ljava_lang_String_Handler ()
		{
			if (cb_setStreet_Ljava_lang_String_ == null)
				cb_setStreet_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStreet_Ljava_lang_String_);
			return cb_setStreet_Ljava_lang_String_;
		}

		static void n_SetStreet_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Street = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStreet;
		static IntPtr id_setStreet_Ljava_lang_String_;
		public virtual unsafe string Street {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getStreet' and count(parameter)=0]"
			[Register ("getStreet", "()Ljava/lang/String;", "GetGetStreetHandler")]
			get {
				if (id_getStreet == IntPtr.Zero)
					id_getStreet = JNIEnv.GetMethodID (class_ref, "getStreet", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStreet), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStreet", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setStreet' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStreet", "(Ljava/lang/String;)V", "GetSetStreet_Ljava_lang_String_Handler")]
			set {
				if (id_setStreet_Ljava_lang_String_ == IntPtr.Zero)
					id_setStreet_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setStreet", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStreet_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStreet", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StreetMatchMessage = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStreetMatchMessage;
		static IntPtr id_setStreetMatchMessage_Ljava_lang_String_;
		public virtual unsafe string StreetMatchMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getStreetMatchMessage' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setStreetMatchMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getTaxAmount;
#pragma warning disable 0169
		static Delegate GetGetTaxAmountHandler ()
		{
			if (cb_getTaxAmount == null)
				cb_getTaxAmount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTaxAmount);
			return cb_getTaxAmount;
		}

		static IntPtr n_GetTaxAmount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TaxAmount);
		}
#pragma warning restore 0169

		static Delegate cb_setTaxAmount_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTaxAmount_Ljava_lang_String_Handler ()
		{
			if (cb_setTaxAmount_Ljava_lang_String_ == null)
				cb_setTaxAmount_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTaxAmount_Ljava_lang_String_);
			return cb_setTaxAmount_Ljava_lang_String_;
		}

		static void n_SetTaxAmount_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TaxAmount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTaxAmount;
		static IntPtr id_setTaxAmount_Ljava_lang_String_;
		public virtual unsafe string TaxAmount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getTaxAmount' and count(parameter)=0]"
			[Register ("getTaxAmount", "()Ljava/lang/String;", "GetGetTaxAmountHandler")]
			get {
				if (id_getTaxAmount == IntPtr.Zero)
					id_getTaxAmount = JNIEnv.GetMethodID (class_ref, "getTaxAmount", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTaxAmount), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTaxAmount", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setTaxAmount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTaxAmount", "(Ljava/lang/String;)V", "GetSetTaxAmount_Ljava_lang_String_Handler")]
			set {
				if (id_setTaxAmount_Ljava_lang_String_ == IntPtr.Zero)
					id_setTaxAmount_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTaxAmount", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTaxAmount_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTaxAmount", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TipAmount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTipAmount;
		static IntPtr id_setTipAmount_Ljava_lang_String_;
		public virtual unsafe string TipAmount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getTipAmount' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setTipAmount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Token = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getToken;
		static IntPtr id_setToken_Ljava_lang_String_;
		public virtual unsafe string Token {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getToken' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getTokenResponse;
#pragma warning disable 0169
		static Delegate GetGetTokenResponseHandler ()
		{
			if (cb_getTokenResponse == null)
				cb_getTokenResponse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTokenResponse);
			return cb_getTokenResponse;
		}

		static IntPtr n_GetTokenResponse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TokenResponse);
		}
#pragma warning restore 0169

		static Delegate cb_setTokenResponse_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTokenResponse_Ljava_lang_String_Handler ()
		{
			if (cb_setTokenResponse_Ljava_lang_String_ == null)
				cb_setTokenResponse_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTokenResponse_Ljava_lang_String_);
			return cb_setTokenResponse_Ljava_lang_String_;
		}

		static void n_SetTokenResponse_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TokenResponse = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTokenResponse;
		static IntPtr id_setTokenResponse_Ljava_lang_String_;
		public virtual unsafe string TokenResponse {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getTokenResponse' and count(parameter)=0]"
			[Register ("getTokenResponse", "()Ljava/lang/String;", "GetGetTokenResponseHandler")]
			get {
				if (id_getTokenResponse == IntPtr.Zero)
					id_getTokenResponse = JNIEnv.GetMethodID (class_ref, "getTokenResponse", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTokenResponse), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTokenResponse", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setTokenResponse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTokenResponse", "(Ljava/lang/String;)V", "GetSetTokenResponse_Ljava_lang_String_Handler")]
			set {
				if (id_setTokenResponse_Ljava_lang_String_ == IntPtr.Zero)
					id_setTokenResponse_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTokenResponse", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTokenResponse_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTokenResponse", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TransactionCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTransactionCode;
		static IntPtr id_setTransactionCode_Ljava_lang_String_;
		public virtual unsafe string TransactionCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getTransactionCode' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setTransactionCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TransactionDate = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTransactionDate;
		static IntPtr id_setTransactionDate_Ljava_lang_String_;
		public virtual unsafe string TransactionDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getTransactionDate' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setTransactionDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TransactionID = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTransactionID;
		static IntPtr id_setTransactionID_Ljava_lang_String_;
		public virtual unsafe string TransactionID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getTransactionID' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setTransactionID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getZipCode;
#pragma warning disable 0169
		static Delegate GetGetZipCodeHandler ()
		{
			if (cb_getZipCode == null)
				cb_getZipCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetZipCode);
			return cb_getZipCode;
		}

		static IntPtr n_GetZipCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ZipCode);
		}
#pragma warning restore 0169

		static Delegate cb_setZipCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetZipCode_Ljava_lang_String_Handler ()
		{
			if (cb_setZipCode_Ljava_lang_String_ == null)
				cb_setZipCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetZipCode_Ljava_lang_String_);
			return cb_setZipCode_Ljava_lang_String_;
		}

		static void n_SetZipCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ZipCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getZipCode;
		static IntPtr id_setZipCode_Ljava_lang_String_;
		public virtual unsafe string ZipCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='getZipCode' and count(parameter)=0]"
			[Register ("getZipCode", "()Ljava/lang/String;", "GetGetZipCodeHandler")]
			get {
				if (id_getZipCode == IntPtr.Zero)
					id_getZipCode = JNIEnv.GetMethodID (class_ref, "getZipCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getZipCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getZipCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentReponseEntity']/method[@name='setZipCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setZipCode", "(Ljava/lang/String;)V", "GetSetZipCode_Ljava_lang_String_Handler")]
			set {
				if (id_setZipCode_Ljava_lang_String_ == IntPtr.Zero)
					id_setZipCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setZipCode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setZipCode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setZipCode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
