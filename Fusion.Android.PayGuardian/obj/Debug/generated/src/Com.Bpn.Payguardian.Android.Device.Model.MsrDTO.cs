using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bpn.Payguardian.Android.Device.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='MsrDTO']"
	[global::Android.Runtime.Register ("com/bpn/payguardian/android/device/model/MsrDTO", DoNotGenerateAcw=true)]
	public partial class MsrDTO : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bpn/payguardian/android/device/model/MsrDTO", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MsrDTO); }
		}

		protected MsrDTO (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='MsrDTO']/constructor[@name='MsrDTO' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MsrDTO ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MsrDTO)) {
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
			global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AdditionalSecurityInfo = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAdditionalSecurityInfo;
		static IntPtr id_setAdditionalSecurityInfo_Ljava_lang_String_;
		public virtual unsafe string AdditionalSecurityInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='MsrDTO']/method[@name='getAdditionalSecurityInfo' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='MsrDTO']/method[@name='setAdditionalSecurityInfo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getEncryptionType;
#pragma warning disable 0169
		static Delegate GetGetEncryptionTypeHandler ()
		{
			if (cb_getEncryptionType == null)
				cb_getEncryptionType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEncryptionType);
			return cb_getEncryptionType;
		}

		static IntPtr n_GetEncryptionType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EncryptionType);
		}
#pragma warning restore 0169

		static Delegate cb_setEncryptionType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEncryptionType_Ljava_lang_String_Handler ()
		{
			if (cb_setEncryptionType_Ljava_lang_String_ == null)
				cb_setEncryptionType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEncryptionType_Ljava_lang_String_);
			return cb_setEncryptionType_Ljava_lang_String_;
		}

		static void n_SetEncryptionType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EncryptionType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEncryptionType;
		static IntPtr id_setEncryptionType_Ljava_lang_String_;
		public virtual unsafe string EncryptionType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='MsrDTO']/method[@name='getEncryptionType' and count(parameter)=0]"
			[Register ("getEncryptionType", "()Ljava/lang/String;", "GetGetEncryptionTypeHandler")]
			get {
				if (id_getEncryptionType == IntPtr.Zero)
					id_getEncryptionType = JNIEnv.GetMethodID (class_ref, "getEncryptionType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEncryptionType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEncryptionType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='MsrDTO']/method[@name='setEncryptionType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEncryptionType", "(Ljava/lang/String;)V", "GetSetEncryptionType_Ljava_lang_String_Handler")]
			set {
				if (id_setEncryptionType_Ljava_lang_String_ == IntPtr.Zero)
					id_setEncryptionType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEncryptionType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEncryptionType_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEncryptionType", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getFirstName;
#pragma warning disable 0169
		static Delegate GetGetFirstNameHandler ()
		{
			if (cb_getFirstName == null)
				cb_getFirstName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFirstName);
			return cb_getFirstName;
		}

		static IntPtr n_GetFirstName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FirstName);
		}
#pragma warning restore 0169

		static Delegate cb_setFirstName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFirstName_Ljava_lang_String_Handler ()
		{
			if (cb_setFirstName_Ljava_lang_String_ == null)
				cb_setFirstName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFirstName_Ljava_lang_String_);
			return cb_setFirstName_Ljava_lang_String_;
		}

		static void n_SetFirstName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FirstName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFirstName;
		static IntPtr id_setFirstName_Ljava_lang_String_;
		public virtual unsafe string FirstName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='MsrDTO']/method[@name='getFirstName' and count(parameter)=0]"
			[Register ("getFirstName", "()Ljava/lang/String;", "GetGetFirstNameHandler")]
			get {
				if (id_getFirstName == IntPtr.Zero)
					id_getFirstName = JNIEnv.GetMethodID (class_ref, "getFirstName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFirstName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFirstName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='MsrDTO']/method[@name='setFirstName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFirstName", "(Ljava/lang/String;)V", "GetSetFirstName_Ljava_lang_String_Handler")]
			set {
				if (id_setFirstName_Ljava_lang_String_ == IntPtr.Zero)
					id_setFirstName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFirstName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFirstName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFirstName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMiddleInitial;
#pragma warning disable 0169
		static Delegate GetGetMiddleInitialHandler ()
		{
			if (cb_getMiddleInitial == null)
				cb_getMiddleInitial = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMiddleInitial);
			return cb_getMiddleInitial;
		}

		static IntPtr n_GetMiddleInitial (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MiddleInitial);
		}
#pragma warning restore 0169

		static Delegate cb_setMiddleInitial_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMiddleInitial_Ljava_lang_String_Handler ()
		{
			if (cb_setMiddleInitial_Ljava_lang_String_ == null)
				cb_setMiddleInitial_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMiddleInitial_Ljava_lang_String_);
			return cb_setMiddleInitial_Ljava_lang_String_;
		}

		static void n_SetMiddleInitial_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MiddleInitial = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMiddleInitial;
		static IntPtr id_setMiddleInitial_Ljava_lang_String_;
		public virtual unsafe string MiddleInitial {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='MsrDTO']/method[@name='getMiddleInitial' and count(parameter)=0]"
			[Register ("getMiddleInitial", "()Ljava/lang/String;", "GetGetMiddleInitialHandler")]
			get {
				if (id_getMiddleInitial == IntPtr.Zero)
					id_getMiddleInitial = JNIEnv.GetMethodID (class_ref, "getMiddleInitial", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMiddleInitial), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMiddleInitial", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='MsrDTO']/method[@name='setMiddleInitial' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMiddleInitial", "(Ljava/lang/String;)V", "GetSetMiddleInitial_Ljava_lang_String_Handler")]
			set {
				if (id_setMiddleInitial_Ljava_lang_String_ == IntPtr.Zero)
					id_setMiddleInitial_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMiddleInitial", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMiddleInitial_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMiddleInitial", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMsrKSN;
#pragma warning disable 0169
		static Delegate GetGetMsrKSNHandler ()
		{
			if (cb_getMsrKSN == null)
				cb_getMsrKSN = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMsrKSN);
			return cb_getMsrKSN;
		}

		static IntPtr n_GetMsrKSN (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MsrKSN);
		}
#pragma warning restore 0169

		static Delegate cb_setMsrKSN_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMsrKSN_Ljava_lang_String_Handler ()
		{
			if (cb_setMsrKSN_Ljava_lang_String_ == null)
				cb_setMsrKSN_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMsrKSN_Ljava_lang_String_);
			return cb_setMsrKSN_Ljava_lang_String_;
		}

		static void n_SetMsrKSN_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MsrKSN = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMsrKSN;
		static IntPtr id_setMsrKSN_Ljava_lang_String_;
		public virtual unsafe string MsrKSN {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='MsrDTO']/method[@name='getMsrKSN' and count(parameter)=0]"
			[Register ("getMsrKSN", "()Ljava/lang/String;", "GetGetMsrKSNHandler")]
			get {
				if (id_getMsrKSN == IntPtr.Zero)
					id_getMsrKSN = JNIEnv.GetMethodID (class_ref, "getMsrKSN", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMsrKSN), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMsrKSN", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='MsrDTO']/method[@name='setMsrKSN' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMsrKSN", "(Ljava/lang/String;)V", "GetSetMsrKSN_Ljava_lang_String_Handler")]
			set {
				if (id_setMsrKSN_Ljava_lang_String_ == IntPtr.Zero)
					id_setMsrKSN_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMsrKSN", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMsrKSN_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMsrKSN", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMsrSecureFormat;
#pragma warning disable 0169
		static Delegate GetGetMsrSecureFormatHandler ()
		{
			if (cb_getMsrSecureFormat == null)
				cb_getMsrSecureFormat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMsrSecureFormat);
			return cb_getMsrSecureFormat;
		}

		static IntPtr n_GetMsrSecureFormat (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MsrSecureFormat);
		}
#pragma warning restore 0169

		static Delegate cb_setMsrSecureFormat_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMsrSecureFormat_Ljava_lang_String_Handler ()
		{
			if (cb_setMsrSecureFormat_Ljava_lang_String_ == null)
				cb_setMsrSecureFormat_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMsrSecureFormat_Ljava_lang_String_);
			return cb_setMsrSecureFormat_Ljava_lang_String_;
		}

		static void n_SetMsrSecureFormat_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MsrSecureFormat = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMsrSecureFormat;
		static IntPtr id_setMsrSecureFormat_Ljava_lang_String_;
		public virtual unsafe string MsrSecureFormat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='MsrDTO']/method[@name='getMsrSecureFormat' and count(parameter)=0]"
			[Register ("getMsrSecureFormat", "()Ljava/lang/String;", "GetGetMsrSecureFormatHandler")]
			get {
				if (id_getMsrSecureFormat == IntPtr.Zero)
					id_getMsrSecureFormat = JNIEnv.GetMethodID (class_ref, "getMsrSecureFormat", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMsrSecureFormat), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMsrSecureFormat", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='MsrDTO']/method[@name='setMsrSecureFormat' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMsrSecureFormat", "(Ljava/lang/String;)V", "GetSetMsrSecureFormat_Ljava_lang_String_Handler")]
			set {
				if (id_setMsrSecureFormat_Ljava_lang_String_ == IntPtr.Zero)
					id_setMsrSecureFormat_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMsrSecureFormat", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMsrSecureFormat_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMsrSecureFormat", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getServiceCode;
#pragma warning disable 0169
		static Delegate GetGetServiceCodeHandler ()
		{
			if (cb_getServiceCode == null)
				cb_getServiceCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetServiceCode);
			return cb_getServiceCode;
		}

		static IntPtr n_GetServiceCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ServiceCode);
		}
#pragma warning restore 0169

		static Delegate cb_setServiceCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetServiceCode_Ljava_lang_String_Handler ()
		{
			if (cb_setServiceCode_Ljava_lang_String_ == null)
				cb_setServiceCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetServiceCode_Ljava_lang_String_);
			return cb_setServiceCode_Ljava_lang_String_;
		}

		static void n_SetServiceCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ServiceCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getServiceCode;
		static IntPtr id_setServiceCode_Ljava_lang_String_;
		public virtual unsafe string ServiceCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='MsrDTO']/method[@name='getServiceCode' and count(parameter)=0]"
			[Register ("getServiceCode", "()Ljava/lang/String;", "GetGetServiceCodeHandler")]
			get {
				if (id_getServiceCode == IntPtr.Zero)
					id_getServiceCode = JNIEnv.GetMethodID (class_ref, "getServiceCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getServiceCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getServiceCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='MsrDTO']/method[@name='setServiceCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setServiceCode", "(Ljava/lang/String;)V", "GetSetServiceCode_Ljava_lang_String_Handler")]
			set {
				if (id_setServiceCode_Ljava_lang_String_ == IntPtr.Zero)
					id_setServiceCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setServiceCode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setServiceCode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setServiceCode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSuffix;
#pragma warning disable 0169
		static Delegate GetGetSuffixHandler ()
		{
			if (cb_getSuffix == null)
				cb_getSuffix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSuffix);
			return cb_getSuffix;
		}

		static IntPtr n_GetSuffix (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Suffix);
		}
#pragma warning restore 0169

		static Delegate cb_setSuffix_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSuffix_Ljava_lang_String_Handler ()
		{
			if (cb_setSuffix_Ljava_lang_String_ == null)
				cb_setSuffix_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSuffix_Ljava_lang_String_);
			return cb_setSuffix_Ljava_lang_String_;
		}

		static void n_SetSuffix_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Suffix = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSuffix;
		static IntPtr id_setSuffix_Ljava_lang_String_;
		public virtual unsafe string Suffix {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='MsrDTO']/method[@name='getSuffix' and count(parameter)=0]"
			[Register ("getSuffix", "()Ljava/lang/String;", "GetGetSuffixHandler")]
			get {
				if (id_getSuffix == IntPtr.Zero)
					id_getSuffix = JNIEnv.GetMethodID (class_ref, "getSuffix", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSuffix), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSuffix", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='MsrDTO']/method[@name='setSuffix' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSuffix", "(Ljava/lang/String;)V", "GetSetSuffix_Ljava_lang_String_Handler")]
			set {
				if (id_setSuffix_Ljava_lang_String_ == IntPtr.Zero)
					id_setSuffix_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSuffix", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSuffix_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSuffix", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSurName;
#pragma warning disable 0169
		static Delegate GetGetSurNameHandler ()
		{
			if (cb_getSurName == null)
				cb_getSurName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSurName);
			return cb_getSurName;
		}

		static IntPtr n_GetSurName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SurName);
		}
#pragma warning restore 0169

		static Delegate cb_setSurName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSurName_Ljava_lang_String_Handler ()
		{
			if (cb_setSurName_Ljava_lang_String_ == null)
				cb_setSurName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSurName_Ljava_lang_String_);
			return cb_setSurName_Ljava_lang_String_;
		}

		static void n_SetSurName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SurName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSurName;
		static IntPtr id_setSurName_Ljava_lang_String_;
		public virtual unsafe string SurName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='MsrDTO']/method[@name='getSurName' and count(parameter)=0]"
			[Register ("getSurName", "()Ljava/lang/String;", "GetGetSurNameHandler")]
			get {
				if (id_getSurName == IntPtr.Zero)
					id_getSurName = JNIEnv.GetMethodID (class_ref, "getSurName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSurName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSurName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='MsrDTO']/method[@name='setSurName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSurName", "(Ljava/lang/String;)V", "GetSetSurName_Ljava_lang_String_Handler")]
			set {
				if (id_setSurName_Ljava_lang_String_ == IntPtr.Zero)
					id_setSurName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSurName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSurName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSurName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTrack1EncryptedData;
#pragma warning disable 0169
		static Delegate GetGetTrack1EncryptedDataHandler ()
		{
			if (cb_getTrack1EncryptedData == null)
				cb_getTrack1EncryptedData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrack1EncryptedData);
			return cb_getTrack1EncryptedData;
		}

		static IntPtr n_GetTrack1EncryptedData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Track1EncryptedData);
		}
#pragma warning restore 0169

		static Delegate cb_setTrack1EncryptedData_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTrack1EncryptedData_Ljava_lang_String_Handler ()
		{
			if (cb_setTrack1EncryptedData_Ljava_lang_String_ == null)
				cb_setTrack1EncryptedData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTrack1EncryptedData_Ljava_lang_String_);
			return cb_setTrack1EncryptedData_Ljava_lang_String_;
		}

		static void n_SetTrack1EncryptedData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Track1EncryptedData = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTrack1EncryptedData;
		static IntPtr id_setTrack1EncryptedData_Ljava_lang_String_;
		public virtual unsafe string Track1EncryptedData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='MsrDTO']/method[@name='getTrack1EncryptedData' and count(parameter)=0]"
			[Register ("getTrack1EncryptedData", "()Ljava/lang/String;", "GetGetTrack1EncryptedDataHandler")]
			get {
				if (id_getTrack1EncryptedData == IntPtr.Zero)
					id_getTrack1EncryptedData = JNIEnv.GetMethodID (class_ref, "getTrack1EncryptedData", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrack1EncryptedData), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrack1EncryptedData", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='MsrDTO']/method[@name='setTrack1EncryptedData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTrack1EncryptedData", "(Ljava/lang/String;)V", "GetSetTrack1EncryptedData_Ljava_lang_String_Handler")]
			set {
				if (id_setTrack1EncryptedData_Ljava_lang_String_ == IntPtr.Zero)
					id_setTrack1EncryptedData_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTrack1EncryptedData", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTrack1EncryptedData_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTrack1EncryptedData", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTrack2EncryptedData;
#pragma warning disable 0169
		static Delegate GetGetTrack2EncryptedDataHandler ()
		{
			if (cb_getTrack2EncryptedData == null)
				cb_getTrack2EncryptedData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrack2EncryptedData);
			return cb_getTrack2EncryptedData;
		}

		static IntPtr n_GetTrack2EncryptedData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Track2EncryptedData);
		}
#pragma warning restore 0169

		static Delegate cb_setTrack2EncryptedData_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTrack2EncryptedData_Ljava_lang_String_Handler ()
		{
			if (cb_setTrack2EncryptedData_Ljava_lang_String_ == null)
				cb_setTrack2EncryptedData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTrack2EncryptedData_Ljava_lang_String_);
			return cb_setTrack2EncryptedData_Ljava_lang_String_;
		}

		static void n_SetTrack2EncryptedData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Track2EncryptedData = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTrack2EncryptedData;
		static IntPtr id_setTrack2EncryptedData_Ljava_lang_String_;
		public virtual unsafe string Track2EncryptedData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='MsrDTO']/method[@name='getTrack2EncryptedData' and count(parameter)=0]"
			[Register ("getTrack2EncryptedData", "()Ljava/lang/String;", "GetGetTrack2EncryptedDataHandler")]
			get {
				if (id_getTrack2EncryptedData == IntPtr.Zero)
					id_getTrack2EncryptedData = JNIEnv.GetMethodID (class_ref, "getTrack2EncryptedData", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrack2EncryptedData), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrack2EncryptedData", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='MsrDTO']/method[@name='setTrack2EncryptedData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTrack2EncryptedData", "(Ljava/lang/String;)V", "GetSetTrack2EncryptedData_Ljava_lang_String_Handler")]
			set {
				if (id_setTrack2EncryptedData_Ljava_lang_String_ == IntPtr.Zero)
					id_setTrack2EncryptedData_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTrack2EncryptedData", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTrack2EncryptedData_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTrack2EncryptedData", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTrack3EncryptedData;
#pragma warning disable 0169
		static Delegate GetGetTrack3EncryptedDataHandler ()
		{
			if (cb_getTrack3EncryptedData == null)
				cb_getTrack3EncryptedData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrack3EncryptedData);
			return cb_getTrack3EncryptedData;
		}

		static IntPtr n_GetTrack3EncryptedData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Track3EncryptedData);
		}
#pragma warning restore 0169

		static Delegate cb_setTrack3EncryptedData_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTrack3EncryptedData_Ljava_lang_String_Handler ()
		{
			if (cb_setTrack3EncryptedData_Ljava_lang_String_ == null)
				cb_setTrack3EncryptedData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTrack3EncryptedData_Ljava_lang_String_);
			return cb_setTrack3EncryptedData_Ljava_lang_String_;
		}

		static void n_SetTrack3EncryptedData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Track3EncryptedData = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTrack3EncryptedData;
		static IntPtr id_setTrack3EncryptedData_Ljava_lang_String_;
		public virtual unsafe string Track3EncryptedData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='MsrDTO']/method[@name='getTrack3EncryptedData' and count(parameter)=0]"
			[Register ("getTrack3EncryptedData", "()Ljava/lang/String;", "GetGetTrack3EncryptedDataHandler")]
			get {
				if (id_getTrack3EncryptedData == IntPtr.Zero)
					id_getTrack3EncryptedData = JNIEnv.GetMethodID (class_ref, "getTrack3EncryptedData", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrack3EncryptedData), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrack3EncryptedData", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='MsrDTO']/method[@name='setTrack3EncryptedData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTrack3EncryptedData", "(Ljava/lang/String;)V", "GetSetTrack3EncryptedData_Ljava_lang_String_Handler")]
			set {
				if (id_setTrack3EncryptedData_Ljava_lang_String_ == IntPtr.Zero)
					id_setTrack3EncryptedData_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTrack3EncryptedData", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTrack3EncryptedData_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTrack3EncryptedData", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTrack4EncryptedData;
#pragma warning disable 0169
		static Delegate GetGetTrack4EncryptedDataHandler ()
		{
			if (cb_getTrack4EncryptedData == null)
				cb_getTrack4EncryptedData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrack4EncryptedData);
			return cb_getTrack4EncryptedData;
		}

		static IntPtr n_GetTrack4EncryptedData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Track4EncryptedData);
		}
#pragma warning restore 0169

		static Delegate cb_setTrack4EncryptedData_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTrack4EncryptedData_Ljava_lang_String_Handler ()
		{
			if (cb_setTrack4EncryptedData_Ljava_lang_String_ == null)
				cb_setTrack4EncryptedData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTrack4EncryptedData_Ljava_lang_String_);
			return cb_setTrack4EncryptedData_Ljava_lang_String_;
		}

		static void n_SetTrack4EncryptedData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Track4EncryptedData = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTrack4EncryptedData;
		static IntPtr id_setTrack4EncryptedData_Ljava_lang_String_;
		public virtual unsafe string Track4EncryptedData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='MsrDTO']/method[@name='getTrack4EncryptedData' and count(parameter)=0]"
			[Register ("getTrack4EncryptedData", "()Ljava/lang/String;", "GetGetTrack4EncryptedDataHandler")]
			get {
				if (id_getTrack4EncryptedData == IntPtr.Zero)
					id_getTrack4EncryptedData = JNIEnv.GetMethodID (class_ref, "getTrack4EncryptedData", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrack4EncryptedData), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrack4EncryptedData", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='MsrDTO']/method[@name='setTrack4EncryptedData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTrack4EncryptedData", "(Ljava/lang/String;)V", "GetSetTrack4EncryptedData_Ljava_lang_String_Handler")]
			set {
				if (id_setTrack4EncryptedData_Ljava_lang_String_ == IntPtr.Zero)
					id_setTrack4EncryptedData_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTrack4EncryptedData", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTrack4EncryptedData_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTrack4EncryptedData", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
