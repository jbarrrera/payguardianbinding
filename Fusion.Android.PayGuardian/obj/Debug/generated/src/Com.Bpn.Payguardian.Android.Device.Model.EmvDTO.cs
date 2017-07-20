using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bpn.Payguardian.Android.Device.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='EmvDTO']"
	[global::Android.Runtime.Register ("com/bpn/payguardian/android/device/model/EmvDTO", DoNotGenerateAcw=true)]
	public partial class EmvDTO : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bpn/payguardian/android/device/model/EmvDTO", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EmvDTO); }
		}

		protected EmvDTO (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='EmvDTO']/constructor[@name='EmvDTO' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EmvDTO ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (EmvDTO)) {
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

		static Delegate cb_getApplicationIdentifier;
#pragma warning disable 0169
		static Delegate GetGetApplicationIdentifierHandler ()
		{
			if (cb_getApplicationIdentifier == null)
				cb_getApplicationIdentifier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApplicationIdentifier);
			return cb_getApplicationIdentifier;
		}

		static IntPtr n_GetApplicationIdentifier (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApplicationIdentifier);
		}
#pragma warning restore 0169

		static Delegate cb_setApplicationIdentifier_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetApplicationIdentifier_Ljava_lang_String_Handler ()
		{
			if (cb_setApplicationIdentifier_Ljava_lang_String_ == null)
				cb_setApplicationIdentifier_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetApplicationIdentifier_Ljava_lang_String_);
			return cb_setApplicationIdentifier_Ljava_lang_String_;
		}

		static void n_SetApplicationIdentifier_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ApplicationIdentifier = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getApplicationIdentifier;
		static IntPtr id_setApplicationIdentifier_Ljava_lang_String_;
		public virtual unsafe string ApplicationIdentifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='EmvDTO']/method[@name='getApplicationIdentifier' and count(parameter)=0]"
			[Register ("getApplicationIdentifier", "()Ljava/lang/String;", "GetGetApplicationIdentifierHandler")]
			get {
				if (id_getApplicationIdentifier == IntPtr.Zero)
					id_getApplicationIdentifier = JNIEnv.GetMethodID (class_ref, "getApplicationIdentifier", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getApplicationIdentifier), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getApplicationIdentifier", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='EmvDTO']/method[@name='setApplicationIdentifier' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setApplicationIdentifier", "(Ljava/lang/String;)V", "GetSetApplicationIdentifier_Ljava_lang_String_Handler")]
			set {
				if (id_setApplicationIdentifier_Ljava_lang_String_ == IntPtr.Zero)
					id_setApplicationIdentifier_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setApplicationIdentifier", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setApplicationIdentifier_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setApplicationIdentifier", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getApplicationTransactionCounter;
#pragma warning disable 0169
		static Delegate GetGetApplicationTransactionCounterHandler ()
		{
			if (cb_getApplicationTransactionCounter == null)
				cb_getApplicationTransactionCounter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApplicationTransactionCounter);
			return cb_getApplicationTransactionCounter;
		}

		static IntPtr n_GetApplicationTransactionCounter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApplicationTransactionCounter);
		}
#pragma warning restore 0169

		static Delegate cb_setApplicationTransactionCounter_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetApplicationTransactionCounter_Ljava_lang_String_Handler ()
		{
			if (cb_setApplicationTransactionCounter_Ljava_lang_String_ == null)
				cb_setApplicationTransactionCounter_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetApplicationTransactionCounter_Ljava_lang_String_);
			return cb_setApplicationTransactionCounter_Ljava_lang_String_;
		}

		static void n_SetApplicationTransactionCounter_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ApplicationTransactionCounter = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getApplicationTransactionCounter;
		static IntPtr id_setApplicationTransactionCounter_Ljava_lang_String_;
		public virtual unsafe string ApplicationTransactionCounter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='EmvDTO']/method[@name='getApplicationTransactionCounter' and count(parameter)=0]"
			[Register ("getApplicationTransactionCounter", "()Ljava/lang/String;", "GetGetApplicationTransactionCounterHandler")]
			get {
				if (id_getApplicationTransactionCounter == IntPtr.Zero)
					id_getApplicationTransactionCounter = JNIEnv.GetMethodID (class_ref, "getApplicationTransactionCounter", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getApplicationTransactionCounter), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getApplicationTransactionCounter", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='EmvDTO']/method[@name='setApplicationTransactionCounter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setApplicationTransactionCounter", "(Ljava/lang/String;)V", "GetSetApplicationTransactionCounter_Ljava_lang_String_Handler")]
			set {
				if (id_setApplicationTransactionCounter_Ljava_lang_String_ == IntPtr.Zero)
					id_setApplicationTransactionCounter_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setApplicationTransactionCounter", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setApplicationTransactionCounter_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setApplicationTransactionCounter", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getAuth_Code;
#pragma warning disable 0169
		static Delegate GetGetAuth_CodeHandler ()
		{
			if (cb_getAuth_Code == null)
				cb_getAuth_Code = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuth_Code);
			return cb_getAuth_Code;
		}

		static IntPtr n_GetAuth_Code (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Auth_Code);
		}
#pragma warning restore 0169

		static Delegate cb_setAuth_Code_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAuth_Code_Ljava_lang_String_Handler ()
		{
			if (cb_setAuth_Code_Ljava_lang_String_ == null)
				cb_setAuth_Code_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAuth_Code_Ljava_lang_String_);
			return cb_setAuth_Code_Ljava_lang_String_;
		}

		static void n_SetAuth_Code_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Auth_Code = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAuth_Code;
		static IntPtr id_setAuth_Code_Ljava_lang_String_;
		public virtual unsafe string Auth_Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='EmvDTO']/method[@name='getAuth_Code' and count(parameter)=0]"
			[Register ("getAuth_Code", "()Ljava/lang/String;", "GetGetAuth_CodeHandler")]
			get {
				if (id_getAuth_Code == IntPtr.Zero)
					id_getAuth_Code = JNIEnv.GetMethodID (class_ref, "getAuth_Code", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAuth_Code), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuth_Code", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='EmvDTO']/method[@name='setAuth_Code' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAuth_Code", "(Ljava/lang/String;)V", "GetSetAuth_Code_Ljava_lang_String_Handler")]
			set {
				if (id_setAuth_Code_Ljava_lang_String_ == IntPtr.Zero)
					id_setAuth_Code_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAuth_Code", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAuth_Code_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAuth_Code", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getEmvTags;
#pragma warning disable 0169
		static Delegate GetGetEmvTagsHandler ()
		{
			if (cb_getEmvTags == null)
				cb_getEmvTags = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEmvTags);
			return cb_getEmvTags;
		}

		static IntPtr n_GetEmvTags (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EmvTags);
		}
#pragma warning restore 0169

		static Delegate cb_setEmvTags_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEmvTags_Ljava_lang_String_Handler ()
		{
			if (cb_setEmvTags_Ljava_lang_String_ == null)
				cb_setEmvTags_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEmvTags_Ljava_lang_String_);
			return cb_setEmvTags_Ljava_lang_String_;
		}

		static void n_SetEmvTags_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EmvTags = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEmvTags;
		static IntPtr id_setEmvTags_Ljava_lang_String_;
		public virtual unsafe string EmvTags {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='EmvDTO']/method[@name='getEmvTags' and count(parameter)=0]"
			[Register ("getEmvTags", "()Ljava/lang/String;", "GetGetEmvTagsHandler")]
			get {
				if (id_getEmvTags == IntPtr.Zero)
					id_getEmvTags = JNIEnv.GetMethodID (class_ref, "getEmvTags", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEmvTags), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEmvTags", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='EmvDTO']/method[@name='setEmvTags' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEmvTags", "(Ljava/lang/String;)V", "GetSetEmvTags_Ljava_lang_String_Handler")]
			set {
				if (id_setEmvTags_Ljava_lang_String_ == IntPtr.Zero)
					id_setEmvTags_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEmvTags", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEmvTags_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEmvTags", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getEntryMedium;
#pragma warning disable 0169
		static Delegate GetGetEntryMediumHandler ()
		{
			if (cb_getEntryMedium == null)
				cb_getEntryMedium = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEntryMedium);
			return cb_getEntryMedium;
		}

		static IntPtr n_GetEntryMedium (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EntryMedium);
		}
#pragma warning restore 0169

		static Delegate cb_setEntryMedium_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEntryMedium_Ljava_lang_String_Handler ()
		{
			if (cb_setEntryMedium_Ljava_lang_String_ == null)
				cb_setEntryMedium_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEntryMedium_Ljava_lang_String_);
			return cb_setEntryMedium_Ljava_lang_String_;
		}

		static void n_SetEntryMedium_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EntryMedium = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEntryMedium;
		static IntPtr id_setEntryMedium_Ljava_lang_String_;
		public virtual unsafe string EntryMedium {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='EmvDTO']/method[@name='getEntryMedium' and count(parameter)=0]"
			[Register ("getEntryMedium", "()Ljava/lang/String;", "GetGetEntryMediumHandler")]
			get {
				if (id_getEntryMedium == IntPtr.Zero)
					id_getEntryMedium = JNIEnv.GetMethodID (class_ref, "getEntryMedium", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEntryMedium), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEntryMedium", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='EmvDTO']/method[@name='setEntryMedium' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEntryMedium", "(Ljava/lang/String;)V", "GetSetEntryMedium_Ljava_lang_String_Handler")]
			set {
				if (id_setEntryMedium_Ljava_lang_String_ == IntPtr.Zero)
					id_setEntryMedium_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEntryMedium", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEntryMedium_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEntryMedium", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EntryMode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEntryMode;
		static IntPtr id_setEntryMode_Ljava_lang_String_;
		public virtual unsafe string EntryMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='EmvDTO']/method[@name='getEntryMode' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='EmvDTO']/method[@name='setEntryMode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getEntryPINMode;
#pragma warning disable 0169
		static Delegate GetGetEntryPINModeHandler ()
		{
			if (cb_getEntryPINMode == null)
				cb_getEntryPINMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEntryPINMode);
			return cb_getEntryPINMode;
		}

		static IntPtr n_GetEntryPINMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EntryPINMode);
		}
#pragma warning restore 0169

		static Delegate cb_setEntryPINMode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEntryPINMode_Ljava_lang_String_Handler ()
		{
			if (cb_setEntryPINMode_Ljava_lang_String_ == null)
				cb_setEntryPINMode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEntryPINMode_Ljava_lang_String_);
			return cb_setEntryPINMode_Ljava_lang_String_;
		}

		static void n_SetEntryPINMode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EntryPINMode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEntryPINMode;
		static IntPtr id_setEntryPINMode_Ljava_lang_String_;
		public virtual unsafe string EntryPINMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='EmvDTO']/method[@name='getEntryPINMode' and count(parameter)=0]"
			[Register ("getEntryPINMode", "()Ljava/lang/String;", "GetGetEntryPINModeHandler")]
			get {
				if (id_getEntryPINMode == IntPtr.Zero)
					id_getEntryPINMode = JNIEnv.GetMethodID (class_ref, "getEntryPINMode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEntryPINMode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEntryPINMode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='EmvDTO']/method[@name='setEntryPINMode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEntryPINMode", "(Ljava/lang/String;)V", "GetSetEntryPINMode_Ljava_lang_String_Handler")]
			set {
				if (id_setEntryPINMode_Ljava_lang_String_ == IntPtr.Zero)
					id_setEntryPINMode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEntryPINMode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEntryPINMode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEntryPINMode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getEntry_Method;
#pragma warning disable 0169
		static Delegate GetGetEntry_MethodHandler ()
		{
			if (cb_getEntry_Method == null)
				cb_getEntry_Method = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEntry_Method);
			return cb_getEntry_Method;
		}

		static IntPtr n_GetEntry_Method (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Entry_Method);
		}
#pragma warning restore 0169

		static Delegate cb_setEntry_Method_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEntry_Method_Ljava_lang_String_Handler ()
		{
			if (cb_setEntry_Method_Ljava_lang_String_ == null)
				cb_setEntry_Method_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEntry_Method_Ljava_lang_String_);
			return cb_setEntry_Method_Ljava_lang_String_;
		}

		static void n_SetEntry_Method_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Entry_Method = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEntry_Method;
		static IntPtr id_setEntry_Method_Ljava_lang_String_;
		public virtual unsafe string Entry_Method {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='EmvDTO']/method[@name='getEntry_Method' and count(parameter)=0]"
			[Register ("getEntry_Method", "()Ljava/lang/String;", "GetGetEntry_MethodHandler")]
			get {
				if (id_getEntry_Method == IntPtr.Zero)
					id_getEntry_Method = JNIEnv.GetMethodID (class_ref, "getEntry_Method", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEntry_Method), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEntry_Method", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='EmvDTO']/method[@name='setEntry_Method' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEntry_Method", "(Ljava/lang/String;)V", "GetSetEntry_Method_Ljava_lang_String_Handler")]
			set {
				if (id_setEntry_Method_Ljava_lang_String_ == IntPtr.Zero)
					id_setEntry_Method_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEntry_Method", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEntry_Method_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEntry_Method", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getErrorTag;
#pragma warning disable 0169
		static Delegate GetGetErrorTagHandler ()
		{
			if (cb_getErrorTag == null)
				cb_getErrorTag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetErrorTag);
			return cb_getErrorTag;
		}

		static IntPtr n_GetErrorTag (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ErrorTag);
		}
#pragma warning restore 0169

		static Delegate cb_setErrorTag_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetErrorTag_Ljava_lang_String_Handler ()
		{
			if (cb_setErrorTag_Ljava_lang_String_ == null)
				cb_setErrorTag_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetErrorTag_Ljava_lang_String_);
			return cb_setErrorTag_Ljava_lang_String_;
		}

		static void n_SetErrorTag_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ErrorTag = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getErrorTag;
		static IntPtr id_setErrorTag_Ljava_lang_String_;
		public virtual unsafe string ErrorTag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='EmvDTO']/method[@name='getErrorTag' and count(parameter)=0]"
			[Register ("getErrorTag", "()Ljava/lang/String;", "GetGetErrorTagHandler")]
			get {
				if (id_getErrorTag == IntPtr.Zero)
					id_getErrorTag = JNIEnv.GetMethodID (class_ref, "getErrorTag", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getErrorTag), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getErrorTag", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='EmvDTO']/method[@name='setErrorTag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setErrorTag", "(Ljava/lang/String;)V", "GetSetErrorTag_Ljava_lang_String_Handler")]
			set {
				if (id_setErrorTag_Ljava_lang_String_ == IntPtr.Zero)
					id_setErrorTag_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setErrorTag", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setErrorTag_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setErrorTag", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getInvoice;
#pragma warning disable 0169
		static Delegate GetGetInvoiceHandler ()
		{
			if (cb_getInvoice == null)
				cb_getInvoice = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInvoice);
			return cb_getInvoice;
		}

		static IntPtr n_GetInvoice (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Invoice);
		}
#pragma warning restore 0169

		static Delegate cb_setInvoice_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetInvoice_Ljava_lang_String_Handler ()
		{
			if (cb_setInvoice_Ljava_lang_String_ == null)
				cb_setInvoice_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInvoice_Ljava_lang_String_);
			return cb_setInvoice_Ljava_lang_String_;
		}

		static void n_SetInvoice_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Invoice = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getInvoice;
		static IntPtr id_setInvoice_Ljava_lang_String_;
		public virtual unsafe string Invoice {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='EmvDTO']/method[@name='getInvoice' and count(parameter)=0]"
			[Register ("getInvoice", "()Ljava/lang/String;", "GetGetInvoiceHandler")]
			get {
				if (id_getInvoice == IntPtr.Zero)
					id_getInvoice = JNIEnv.GetMethodID (class_ref, "getInvoice", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInvoice), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInvoice", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='EmvDTO']/method[@name='setInvoice' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setInvoice", "(Ljava/lang/String;)V", "GetSetInvoice_Ljava_lang_String_Handler")]
			set {
				if (id_setInvoice_Ljava_lang_String_ == IntPtr.Zero)
					id_setInvoice_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setInvoice", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInvoice_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInvoice", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMasked_Card;
#pragma warning disable 0169
		static Delegate GetGetMasked_CardHandler ()
		{
			if (cb_getMasked_Card == null)
				cb_getMasked_Card = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMasked_Card);
			return cb_getMasked_Card;
		}

		static IntPtr n_GetMasked_Card (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Masked_Card);
		}
#pragma warning restore 0169

		static Delegate cb_setMasked_Card_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMasked_Card_Ljava_lang_String_Handler ()
		{
			if (cb_setMasked_Card_Ljava_lang_String_ == null)
				cb_setMasked_Card_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMasked_Card_Ljava_lang_String_);
			return cb_setMasked_Card_Ljava_lang_String_;
		}

		static void n_SetMasked_Card_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Masked_Card = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMasked_Card;
		static IntPtr id_setMasked_Card_Ljava_lang_String_;
		public virtual unsafe string Masked_Card {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='EmvDTO']/method[@name='getMasked_Card' and count(parameter)=0]"
			[Register ("getMasked_Card", "()Ljava/lang/String;", "GetGetMasked_CardHandler")]
			get {
				if (id_getMasked_Card == IntPtr.Zero)
					id_getMasked_Card = JNIEnv.GetMethodID (class_ref, "getMasked_Card", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMasked_Card), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMasked_Card", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='EmvDTO']/method[@name='setMasked_Card' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMasked_Card", "(Ljava/lang/String;)V", "GetSetMasked_Card_Ljava_lang_String_Handler")]
			set {
				if (id_setMasked_Card_Ljava_lang_String_ == IntPtr.Zero)
					id_setMasked_Card_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMasked_Card", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMasked_Card_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMasked_Card", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MsrKSN = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMsrKSN;
		static IntPtr id_setMsrKSN_Ljava_lang_String_;
		public virtual unsafe string MsrKSN {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='EmvDTO']/method[@name='getMsrKSN' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='EmvDTO']/method[@name='setMsrKSN' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getSecureFormat;
#pragma warning disable 0169
		static Delegate GetGetSecureFormatHandler ()
		{
			if (cb_getSecureFormat == null)
				cb_getSecureFormat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSecureFormat);
			return cb_getSecureFormat;
		}

		static IntPtr n_GetSecureFormat (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SecureFormat);
		}
#pragma warning restore 0169

		static Delegate cb_setSecureFormat_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSecureFormat_Ljava_lang_String_Handler ()
		{
			if (cb_setSecureFormat_Ljava_lang_String_ == null)
				cb_setSecureFormat_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSecureFormat_Ljava_lang_String_);
			return cb_setSecureFormat_Ljava_lang_String_;
		}

		static void n_SetSecureFormat_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SecureFormat = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSecureFormat;
		static IntPtr id_setSecureFormat_Ljava_lang_String_;
		public virtual unsafe string SecureFormat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='EmvDTO']/method[@name='getSecureFormat' and count(parameter)=0]"
			[Register ("getSecureFormat", "()Ljava/lang/String;", "GetGetSecureFormatHandler")]
			get {
				if (id_getSecureFormat == IntPtr.Zero)
					id_getSecureFormat = JNIEnv.GetMethodID (class_ref, "getSecureFormat", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSecureFormat), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSecureFormat", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='EmvDTO']/method[@name='setSecureFormat' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSecureFormat", "(Ljava/lang/String;)V", "GetSetSecureFormat_Ljava_lang_String_Handler")]
			set {
				if (id_setSecureFormat_Ljava_lang_String_ == IntPtr.Zero)
					id_setSecureFormat_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSecureFormat", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSecureFormat_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSecureFormat", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStatus);
			return cb_getStatus;
		}

		static IntPtr n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Status);
		}
#pragma warning restore 0169

		static Delegate cb_setStatus_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStatus_Ljava_lang_String_Handler ()
		{
			if (cb_setStatus_Ljava_lang_String_ == null)
				cb_setStatus_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStatus_Ljava_lang_String_);
			return cb_setStatus_Ljava_lang_String_;
		}

		static void n_SetStatus_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Status = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStatus;
		static IntPtr id_setStatus_Ljava_lang_String_;
		public virtual unsafe string Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='EmvDTO']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()Ljava/lang/String;", "GetGetStatusHandler")]
			get {
				if (id_getStatus == IntPtr.Zero)
					id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStatus), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStatus", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='EmvDTO']/method[@name='setStatus' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStatus", "(Ljava/lang/String;)V", "GetSetStatus_Ljava_lang_String_Handler")]
			set {
				if (id_setStatus_Ljava_lang_String_ == IntPtr.Zero)
					id_setStatus_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setStatus", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStatus_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStatus", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTerminalCapabilities;
#pragma warning disable 0169
		static Delegate GetGetTerminalCapabilitiesHandler ()
		{
			if (cb_getTerminalCapabilities == null)
				cb_getTerminalCapabilities = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTerminalCapabilities);
			return cb_getTerminalCapabilities;
		}

		static IntPtr n_GetTerminalCapabilities (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TerminalCapabilities);
		}
#pragma warning restore 0169

		static Delegate cb_setTerminalCapabilities_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTerminalCapabilities_Ljava_lang_String_Handler ()
		{
			if (cb_setTerminalCapabilities_Ljava_lang_String_ == null)
				cb_setTerminalCapabilities_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTerminalCapabilities_Ljava_lang_String_);
			return cb_setTerminalCapabilities_Ljava_lang_String_;
		}

		static void n_SetTerminalCapabilities_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TerminalCapabilities = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTerminalCapabilities;
		static IntPtr id_setTerminalCapabilities_Ljava_lang_String_;
		public virtual unsafe string TerminalCapabilities {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='EmvDTO']/method[@name='getTerminalCapabilities' and count(parameter)=0]"
			[Register ("getTerminalCapabilities", "()Ljava/lang/String;", "GetGetTerminalCapabilitiesHandler")]
			get {
				if (id_getTerminalCapabilities == IntPtr.Zero)
					id_getTerminalCapabilities = JNIEnv.GetMethodID (class_ref, "getTerminalCapabilities", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTerminalCapabilities), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTerminalCapabilities", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='EmvDTO']/method[@name='setTerminalCapabilities' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTerminalCapabilities", "(Ljava/lang/String;)V", "GetSetTerminalCapabilities_Ljava_lang_String_Handler")]
			set {
				if (id_setTerminalCapabilities_Ljava_lang_String_ == IntPtr.Zero)
					id_setTerminalCapabilities_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTerminalCapabilities", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTerminalCapabilities_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTerminalCapabilities", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTotal_Amount;
#pragma warning disable 0169
		static Delegate GetGetTotal_AmountHandler ()
		{
			if (cb_getTotal_Amount == null)
				cb_getTotal_Amount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTotal_Amount);
			return cb_getTotal_Amount;
		}

		static IntPtr n_GetTotal_Amount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Total_Amount);
		}
#pragma warning restore 0169

		static Delegate cb_setTotal_Amount_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTotal_Amount_Ljava_lang_String_Handler ()
		{
			if (cb_setTotal_Amount_Ljava_lang_String_ == null)
				cb_setTotal_Amount_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTotal_Amount_Ljava_lang_String_);
			return cb_setTotal_Amount_Ljava_lang_String_;
		}

		static void n_SetTotal_Amount_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Total_Amount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTotal_Amount;
		static IntPtr id_setTotal_Amount_Ljava_lang_String_;
		public virtual unsafe string Total_Amount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='EmvDTO']/method[@name='getTotal_Amount' and count(parameter)=0]"
			[Register ("getTotal_Amount", "()Ljava/lang/String;", "GetGetTotal_AmountHandler")]
			get {
				if (id_getTotal_Amount == IntPtr.Zero)
					id_getTotal_Amount = JNIEnv.GetMethodID (class_ref, "getTotal_Amount", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTotal_Amount), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTotal_Amount", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='EmvDTO']/method[@name='setTotal_Amount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTotal_Amount", "(Ljava/lang/String;)V", "GetSetTotal_Amount_Ljava_lang_String_Handler")]
			set {
				if (id_setTotal_Amount_Ljava_lang_String_ == IntPtr.Zero)
					id_setTotal_Amount_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTotal_Amount", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTotal_Amount_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTotal_Amount", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTrack1Data;
#pragma warning disable 0169
		static Delegate GetGetTrack1DataHandler ()
		{
			if (cb_getTrack1Data == null)
				cb_getTrack1Data = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrack1Data);
			return cb_getTrack1Data;
		}

		static IntPtr n_GetTrack1Data (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Track1Data);
		}
#pragma warning restore 0169

		static Delegate cb_setTrack1Data_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTrack1Data_Ljava_lang_String_Handler ()
		{
			if (cb_setTrack1Data_Ljava_lang_String_ == null)
				cb_setTrack1Data_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTrack1Data_Ljava_lang_String_);
			return cb_setTrack1Data_Ljava_lang_String_;
		}

		static void n_SetTrack1Data_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Track1Data = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTrack1Data;
		static IntPtr id_setTrack1Data_Ljava_lang_String_;
		public virtual unsafe string Track1Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='EmvDTO']/method[@name='getTrack1Data' and count(parameter)=0]"
			[Register ("getTrack1Data", "()Ljava/lang/String;", "GetGetTrack1DataHandler")]
			get {
				if (id_getTrack1Data == IntPtr.Zero)
					id_getTrack1Data = JNIEnv.GetMethodID (class_ref, "getTrack1Data", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrack1Data), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrack1Data", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='EmvDTO']/method[@name='setTrack1Data' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTrack1Data", "(Ljava/lang/String;)V", "GetSetTrack1Data_Ljava_lang_String_Handler")]
			set {
				if (id_setTrack1Data_Ljava_lang_String_ == IntPtr.Zero)
					id_setTrack1Data_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTrack1Data", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTrack1Data_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTrack1Data", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getsEQ;
#pragma warning disable 0169
		static Delegate GetGetsEQHandler ()
		{
			if (cb_getsEQ == null)
				cb_getsEQ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetsEQ);
			return cb_getsEQ;
		}

		static IntPtr n_GetsEQ (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetsEQ ());
		}
#pragma warning restore 0169

		static IntPtr id_getsEQ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='EmvDTO']/method[@name='getsEQ' and count(parameter)=0]"
		[Register ("getsEQ", "()Ljava/lang/String;", "GetGetsEQHandler")]
		public virtual unsafe string GetsEQ ()
		{
			if (id_getsEQ == IntPtr.Zero)
				id_getsEQ = JNIEnv.GetMethodID (class_ref, "getsEQ", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getsEQ), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getsEQ", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setsEQ_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetsEQ_Ljava_lang_String_Handler ()
		{
			if (cb_setsEQ_Ljava_lang_String_ == null)
				cb_setsEQ_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetsEQ_Ljava_lang_String_);
			return cb_setsEQ_Ljava_lang_String_;
		}

		static void n_SetsEQ_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetsEQ (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setsEQ_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.model']/class[@name='EmvDTO']/method[@name='setsEQ' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setsEQ", "(Ljava/lang/String;)V", "GetSetsEQ_Ljava_lang_String_Handler")]
		public virtual unsafe void SetsEQ (string p0)
		{
			if (id_setsEQ_Ljava_lang_String_ == IntPtr.Zero)
				id_setsEQ_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setsEQ", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setsEQ_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setsEQ", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
