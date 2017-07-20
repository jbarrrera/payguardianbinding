using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bpn.Payguardian.Android.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='ExtData']"
	[global::Android.Runtime.Register ("com/bpn/payguardian/android/model/ExtData", DoNotGenerateAcw=true)]
	public partial class ExtData : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bpn/payguardian/android/model/ExtData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ExtData); }
		}

		protected ExtData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='ExtData']/constructor[@name='ExtData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ExtData ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ExtData)) {
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
			global::Com.Bpn.Payguardian.Android.Model.ExtData __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.ExtData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReceiptTagData);
		}
#pragma warning restore 0169

		static Delegate cb_setReceiptTagData_Lcom_bpn_payguardian_android_model_ReceiptTagData_;
#pragma warning disable 0169
		static Delegate GetSetReceiptTagData_Lcom_bpn_payguardian_android_model_ReceiptTagData_Handler ()
		{
			if (cb_setReceiptTagData_Lcom_bpn_payguardian_android_model_ReceiptTagData_ == null)
				cb_setReceiptTagData_Lcom_bpn_payguardian_android_model_ReceiptTagData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetReceiptTagData_Lcom_bpn_payguardian_android_model_ReceiptTagData_);
			return cb_setReceiptTagData_Lcom_bpn_payguardian_android_model_ReceiptTagData_;
		}

		static void n_SetReceiptTagData_Lcom_bpn_payguardian_android_model_ReceiptTagData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Model.ExtData __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.ExtData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData p0 = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReceiptTagData = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getReceiptTagData;
		static IntPtr id_setReceiptTagData_Lcom_bpn_payguardian_android_model_ReceiptTagData_;
		public virtual unsafe global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData ReceiptTagData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='ExtData']/method[@name='getReceiptTagData' and count(parameter)=0]"
			[Register ("getReceiptTagData", "()Lcom/bpn/payguardian/android/model/ReceiptTagData;", "GetGetReceiptTagDataHandler")]
			get {
				if (id_getReceiptTagData == IntPtr.Zero)
					id_getReceiptTagData = JNIEnv.GetMethodID (class_ref, "getReceiptTagData", "()Lcom/bpn/payguardian/android/model/ReceiptTagData;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getReceiptTagData), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.ReceiptTagData> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReceiptTagData", "()Lcom/bpn/payguardian/android/model/ReceiptTagData;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.model']/class[@name='ExtData']/method[@name='setReceiptTagData' and count(parameter)=1 and parameter[1][@type='com.bpn.payguardian.android.model.ReceiptTagData']]"
			[Register ("setReceiptTagData", "(Lcom/bpn/payguardian/android/model/ReceiptTagData;)V", "GetSetReceiptTagData_Lcom_bpn_payguardian_android_model_ReceiptTagData_Handler")]
			set {
				if (id_setReceiptTagData_Lcom_bpn_payguardian_android_model_ReceiptTagData_ == IntPtr.Zero)
					id_setReceiptTagData_Lcom_bpn_payguardian_android_model_ReceiptTagData_ = JNIEnv.GetMethodID (class_ref, "setReceiptTagData", "(Lcom/bpn/payguardian/android/model/ReceiptTagData;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setReceiptTagData_Lcom_bpn_payguardian_android_model_ReceiptTagData_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReceiptTagData", "(Lcom/bpn/payguardian/android/model/ReceiptTagData;)V"), __args);
				} finally {
				}
			}
		}

	}
}
