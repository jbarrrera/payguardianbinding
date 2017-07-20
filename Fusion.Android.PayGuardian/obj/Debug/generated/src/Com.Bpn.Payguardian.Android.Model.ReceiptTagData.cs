using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bpn.Payguardian.Android.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='ReceiptTagData']"
	[global::Android.Runtime.Register ("com/bpn/payguardian/android/model/ReceiptTagData", DoNotGenerateAcw=true)]
	public partial class ReceiptTagData : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bpn/payguardian/android/model/ReceiptTagData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ReceiptTagData); }
		}

		protected ReceiptTagData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='ReceiptTagData']/constructor[@name='ReceiptTagData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ReceiptTagData ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ReceiptTagData)) {
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
			global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AppLabel = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAppLabel;
		static IntPtr id_setAppLabel_Ljava_lang_String_;
		public virtual unsafe string AppLabel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='ReceiptTagData']/method[@name='getAppLabel' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='ReceiptTagData']/method[@name='setAppLabel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getAtc;
#pragma warning disable 0169
		static Delegate GetGetAtcHandler ()
		{
			if (cb_getAtc == null)
				cb_getAtc = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAtc);
			return cb_getAtc;
		}

		static IntPtr n_GetAtc (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Atc);
		}
#pragma warning restore 0169

		static Delegate cb_setAtc_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAtc_Ljava_lang_String_Handler ()
		{
			if (cb_setAtc_Ljava_lang_String_ == null)
				cb_setAtc_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAtc_Ljava_lang_String_);
			return cb_setAtc_Ljava_lang_String_;
		}

		static void n_SetAtc_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Atc = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAtc;
		static IntPtr id_setAtc_Ljava_lang_String_;
		public virtual unsafe string Atc {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='ReceiptTagData']/method[@name='getAtc' and count(parameter)=0]"
			[Register ("getAtc", "()Ljava/lang/String;", "GetGetAtcHandler")]
			get {
				if (id_getAtc == IntPtr.Zero)
					id_getAtc = JNIEnv.GetMethodID (class_ref, "getAtc", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAtc), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAtc", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='ReceiptTagData']/method[@name='setAtc' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAtc", "(Ljava/lang/String;)V", "GetSetAtc_Ljava_lang_String_Handler")]
			set {
				if (id_setAtc_Ljava_lang_String_ == IntPtr.Zero)
					id_setAtc_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAtc", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAtc_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAtc", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AuthCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAuthCode;
		static IntPtr id_setAuthCode_Ljava_lang_String_;
		public virtual unsafe string AuthCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='ReceiptTagData']/method[@name='getAuthCode' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='ReceiptTagData']/method[@name='setAuthCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ChipCardAID = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getChipCardAID;
		static IntPtr id_setChipCardAID_Ljava_lang_String_;
		public virtual unsafe string ChipCardAID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='ReceiptTagData']/method[@name='getChipCardAID' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='ReceiptTagData']/method[@name='setChipCardAID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EntryMethod = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEntryMethod;
		static IntPtr id_setEntryMethod_Ljava_lang_String_;
		public virtual unsafe string EntryMethod {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='ReceiptTagData']/method[@name='getEntryMethod' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='ReceiptTagData']/method[@name='setEntryMethod' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Invoice = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getInvoice;
		static IntPtr id_setInvoice_Ljava_lang_String_;
		public virtual unsafe string Invoice {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='ReceiptTagData']/method[@name='getInvoice' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='ReceiptTagData']/method[@name='setInvoice' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getMaskedCard;
#pragma warning disable 0169
		static Delegate GetGetMaskedCardHandler ()
		{
			if (cb_getMaskedCard == null)
				cb_getMaskedCard = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMaskedCard);
			return cb_getMaskedCard;
		}

		static IntPtr n_GetMaskedCard (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MaskedCard);
		}
#pragma warning restore 0169

		static Delegate cb_setMaskedCard_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMaskedCard_Ljava_lang_String_Handler ()
		{
			if (cb_setMaskedCard_Ljava_lang_String_ == null)
				cb_setMaskedCard_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMaskedCard_Ljava_lang_String_);
			return cb_setMaskedCard_Ljava_lang_String_;
		}

		static void n_SetMaskedCard_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MaskedCard = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaskedCard;
		static IntPtr id_setMaskedCard_Ljava_lang_String_;
		public virtual unsafe string MaskedCard {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='ReceiptTagData']/method[@name='getMaskedCard' and count(parameter)=0]"
			[Register ("getMaskedCard", "()Ljava/lang/String;", "GetGetMaskedCardHandler")]
			get {
				if (id_getMaskedCard == IntPtr.Zero)
					id_getMaskedCard = JNIEnv.GetMethodID (class_ref, "getMaskedCard", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMaskedCard), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaskedCard", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='ReceiptTagData']/method[@name='setMaskedCard' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMaskedCard", "(Ljava/lang/String;)V", "GetSetMaskedCard_Ljava_lang_String_Handler")]
			set {
				if (id_setMaskedCard_Ljava_lang_String_ == IntPtr.Zero)
					id_setMaskedCard_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMaskedCard", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMaskedCard_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaskedCard", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSeq;
#pragma warning disable 0169
		static Delegate GetGetSeqHandler ()
		{
			if (cb_getSeq == null)
				cb_getSeq = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSeq);
			return cb_getSeq;
		}

		static IntPtr n_GetSeq (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Seq);
		}
#pragma warning restore 0169

		static Delegate cb_setSeq_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSeq_Ljava_lang_String_Handler ()
		{
			if (cb_setSeq_Ljava_lang_String_ == null)
				cb_setSeq_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSeq_Ljava_lang_String_);
			return cb_setSeq_Ljava_lang_String_;
		}

		static void n_SetSeq_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Seq = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSeq;
		static IntPtr id_setSeq_Ljava_lang_String_;
		public virtual unsafe string Seq {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='ReceiptTagData']/method[@name='getSeq' and count(parameter)=0]"
			[Register ("getSeq", "()Ljava/lang/String;", "GetGetSeqHandler")]
			get {
				if (id_getSeq == IntPtr.Zero)
					id_getSeq = JNIEnv.GetMethodID (class_ref, "getSeq", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSeq), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSeq", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='ReceiptTagData']/method[@name='setSeq' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSeq", "(Ljava/lang/String;)V", "GetSetSeq_Ljava_lang_String_Handler")]
			set {
				if (id_setSeq_Ljava_lang_String_ == IntPtr.Zero)
					id_setSeq_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSeq", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSeq_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSeq", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTc;
#pragma warning disable 0169
		static Delegate GetGetTcHandler ()
		{
			if (cb_getTc == null)
				cb_getTc = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTc);
			return cb_getTc;
		}

		static IntPtr n_GetTc (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Tc);
		}
#pragma warning restore 0169

		static Delegate cb_setTc_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTc_Ljava_lang_String_Handler ()
		{
			if (cb_setTc_Ljava_lang_String_ == null)
				cb_setTc_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTc_Ljava_lang_String_);
			return cb_setTc_Ljava_lang_String_;
		}

		static void n_SetTc_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Tc = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTc;
		static IntPtr id_setTc_Ljava_lang_String_;
		public virtual unsafe string Tc {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='ReceiptTagData']/method[@name='getTc' and count(parameter)=0]"
			[Register ("getTc", "()Ljava/lang/String;", "GetGetTcHandler")]
			get {
				if (id_getTc == IntPtr.Zero)
					id_getTc = JNIEnv.GetMethodID (class_ref, "getTc", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTc), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTc", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='ReceiptTagData']/method[@name='setTc' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTc", "(Ljava/lang/String;)V", "GetSetTc_Ljava_lang_String_Handler")]
			set {
				if (id_setTc_Ljava_lang_String_ == IntPtr.Zero)
					id_setTc_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTc", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTc_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTc", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTotalAmount;
#pragma warning disable 0169
		static Delegate GetGetTotalAmountHandler ()
		{
			if (cb_getTotalAmount == null)
				cb_getTotalAmount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTotalAmount);
			return cb_getTotalAmount;
		}

		static IntPtr n_GetTotalAmount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TotalAmount);
		}
#pragma warning restore 0169

		static Delegate cb_setTotalAmount_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTotalAmount_Ljava_lang_String_Handler ()
		{
			if (cb_setTotalAmount_Ljava_lang_String_ == null)
				cb_setTotalAmount_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTotalAmount_Ljava_lang_String_);
			return cb_setTotalAmount_Ljava_lang_String_;
		}

		static void n_SetTotalAmount_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TotalAmount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTotalAmount;
		static IntPtr id_setTotalAmount_Ljava_lang_String_;
		public virtual unsafe string TotalAmount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='ReceiptTagData']/method[@name='getTotalAmount' and count(parameter)=0]"
			[Register ("getTotalAmount", "()Ljava/lang/String;", "GetGetTotalAmountHandler")]
			get {
				if (id_getTotalAmount == IntPtr.Zero)
					id_getTotalAmount = JNIEnv.GetMethodID (class_ref, "getTotalAmount", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTotalAmount), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTotalAmount", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='ReceiptTagData']/method[@name='setTotalAmount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTotalAmount", "(Ljava/lang/String;)V", "GetSetTotalAmount_Ljava_lang_String_Handler")]
			set {
				if (id_setTotalAmount_Ljava_lang_String_ == IntPtr.Zero)
					id_setTotalAmount_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTotalAmount", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTotalAmount_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTotalAmount", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTsi;
#pragma warning disable 0169
		static Delegate GetGetTsiHandler ()
		{
			if (cb_getTsi == null)
				cb_getTsi = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTsi);
			return cb_getTsi;
		}

		static IntPtr n_GetTsi (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Tsi);
		}
#pragma warning restore 0169

		static Delegate cb_setTsi_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTsi_Ljava_lang_String_Handler ()
		{
			if (cb_setTsi_Ljava_lang_String_ == null)
				cb_setTsi_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTsi_Ljava_lang_String_);
			return cb_setTsi_Ljava_lang_String_;
		}

		static void n_SetTsi_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Tsi = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTsi;
		static IntPtr id_setTsi_Ljava_lang_String_;
		public virtual unsafe string Tsi {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='ReceiptTagData']/method[@name='getTsi' and count(parameter)=0]"
			[Register ("getTsi", "()Ljava/lang/String;", "GetGetTsiHandler")]
			get {
				if (id_getTsi == IntPtr.Zero)
					id_getTsi = JNIEnv.GetMethodID (class_ref, "getTsi", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTsi), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTsi", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='ReceiptTagData']/method[@name='setTsi' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTsi", "(Ljava/lang/String;)V", "GetSetTsi_Ljava_lang_String_Handler")]
			set {
				if (id_setTsi_Ljava_lang_String_ == IntPtr.Zero)
					id_setTsi_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTsi", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTsi_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTsi", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTvr;
#pragma warning disable 0169
		static Delegate GetGetTvrHandler ()
		{
			if (cb_getTvr == null)
				cb_getTvr = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTvr);
			return cb_getTvr;
		}

		static IntPtr n_GetTvr (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Tvr);
		}
#pragma warning restore 0169

		static Delegate cb_setTvr_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTvr_Ljava_lang_String_Handler ()
		{
			if (cb_setTvr_Ljava_lang_String_ == null)
				cb_setTvr_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTvr_Ljava_lang_String_);
			return cb_setTvr_Ljava_lang_String_;
		}

		static void n_SetTvr_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Tvr = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTvr;
		static IntPtr id_setTvr_Ljava_lang_String_;
		public virtual unsafe string Tvr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='ReceiptTagData']/method[@name='getTvr' and count(parameter)=0]"
			[Register ("getTvr", "()Ljava/lang/String;", "GetGetTvrHandler")]
			get {
				if (id_getTvr == IntPtr.Zero)
					id_getTvr = JNIEnv.GetMethodID (class_ref, "getTvr", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTvr), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTvr", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='ReceiptTagData']/method[@name='setTvr' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTvr", "(Ljava/lang/String;)V", "GetSetTvr_Ljava_lang_String_Handler")]
			set {
				if (id_setTvr_Ljava_lang_String_ == IntPtr.Zero)
					id_setTvr_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTvr", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTvr_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTvr", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
