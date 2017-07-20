using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bpn.Payguardian.Android.Device.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='PinPadDTO']"
	[global::Android.Runtime.Register ("com/bpn/payguardian/android/device/model/PinPadDTO", DoNotGenerateAcw=true)]
	public partial class PinPadDTO : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bpn/payguardian/android/device/model/PinPadDTO", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PinPadDTO); }
		}

		protected PinPadDTO (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='PinPadDTO']/constructor[@name='PinPadDTO' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PinPadDTO ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PinPadDTO)) {
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

		static Delegate cb_getAdditionalSecurityInfo;
#pragma warning disable 0169
		static Delegate GetGetAdditionalSecurityInfoHandler ()
		{
			if (cb_getAdditionalSecurityInfo == null)
				cb_getAdditionalSecurityInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdditionalSecurityInfo);
			return cb_getAdditionalSecurityInfo;
		}

		static IntPtr n_GetAdditionalSecurityInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.PinPadDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.PinPadDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdditionalSecurityInfo);
		}
#pragma warning restore 0169

		static Delegate cb_setAdditionalSecurityInfo_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAdditionalSecurityInfo_Ljava_lang_String_Handler ()
		{
			if (cb_setAdditionalSecurityInfo_Ljava_lang_String_ == null)
				cb_setAdditionalSecurityInfo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAdditionalSecurityInfo_Ljava_lang_String_);
			return cb_setAdditionalSecurityInfo_Ljava_lang_String_;
		}

		static void n_SetAdditionalSecurityInfo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.PinPadDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.PinPadDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AdditionalSecurityInfo = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAdditionalSecurityInfo;
		static IntPtr id_setAdditionalSecurityInfo_Ljava_lang_String_;
		public virtual unsafe string AdditionalSecurityInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='PinPadDTO']/method[@name='getAdditionalSecurityInfo' and count(parameter)=0]"
			[Register ("getAdditionalSecurityInfo", "()Ljava/lang/String;", "GetGetAdditionalSecurityInfoHandler")]
			get {
				if (id_getAdditionalSecurityInfo == IntPtr.Zero)
					id_getAdditionalSecurityInfo = JNIEnv.GetMethodID (class_ref, "getAdditionalSecurityInfo", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdditionalSecurityInfo), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdditionalSecurityInfo", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='PinPadDTO']/method[@name='setAdditionalSecurityInfo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAdditionalSecurityInfo", "(Ljava/lang/String;)V", "GetSetAdditionalSecurityInfo_Ljava_lang_String_Handler")]
			set {
				if (id_setAdditionalSecurityInfo_Ljava_lang_String_ == IntPtr.Zero)
					id_setAdditionalSecurityInfo_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAdditionalSecurityInfo", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAdditionalSecurityInfo_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAdditionalSecurityInfo", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getEncryptPin;
#pragma warning disable 0169
		static Delegate GetGetEncryptPinHandler ()
		{
			if (cb_getEncryptPin == null)
				cb_getEncryptPin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEncryptPin);
			return cb_getEncryptPin;
		}

		static IntPtr n_GetEncryptPin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.PinPadDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.PinPadDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EncryptPin);
		}
#pragma warning restore 0169

		static Delegate cb_setEncryptPin_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEncryptPin_Ljava_lang_String_Handler ()
		{
			if (cb_setEncryptPin_Ljava_lang_String_ == null)
				cb_setEncryptPin_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEncryptPin_Ljava_lang_String_);
			return cb_setEncryptPin_Ljava_lang_String_;
		}

		static void n_SetEncryptPin_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.PinPadDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.PinPadDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EncryptPin = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEncryptPin;
		static IntPtr id_setEncryptPin_Ljava_lang_String_;
		public virtual unsafe string EncryptPin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='PinPadDTO']/method[@name='getEncryptPin' and count(parameter)=0]"
			[Register ("getEncryptPin", "()Ljava/lang/String;", "GetGetEncryptPinHandler")]
			get {
				if (id_getEncryptPin == IntPtr.Zero)
					id_getEncryptPin = JNIEnv.GetMethodID (class_ref, "getEncryptPin", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEncryptPin), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEncryptPin", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='PinPadDTO']/method[@name='setEncryptPin' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEncryptPin", "(Ljava/lang/String;)V", "GetSetEncryptPin_Ljava_lang_String_Handler")]
			set {
				if (id_setEncryptPin_Ljava_lang_String_ == IntPtr.Zero)
					id_setEncryptPin_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEncryptPin", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEncryptPin_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEncryptPin", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bpn.Payguardian.Android.Device.Model.PinPadDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.PinPadDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Device.Model.PinPadDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.PinPadDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TransactionType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTransactionType;
		static IntPtr id_setTransactionType_Ljava_lang_String_;
		public virtual unsafe string TransactionType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='PinPadDTO']/method[@name='getTransactionType' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='PinPadDTO']/method[@name='setTransactionType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
}
