using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bpn.Payguardian.Android.Service {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bpn.payguardian.android.service']/interface[@name='PaymentProcessService']"
	[Register ("com/bpn/payguardian/android/service/PaymentProcessService", "", "Com.Bpn.Payguardian.Android.Service.IPaymentProcessServiceInvoker")]
	public partial interface IPaymentProcessService : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.service']/interface[@name='PaymentProcessService']/method[@name='processBridgeCommTransaction' and count(parameter)=2 and parameter[1][@type='com.bpn.payguardian.android.entity.PaymentRequestEntity'] and parameter[2][@type='java.lang.String']]"
		[Register ("processBridgeCommTransaction", "(Lcom/bpn/payguardian/android/entity/PaymentRequestEntity;Ljava/lang/String;)V", "GetProcessBridgeCommTransaction_Lcom_bpn_payguardian_android_entity_PaymentRequestEntity_Ljava_lang_String_Handler:Com.Bpn.Payguardian.Android.Service.IPaymentProcessServiceInvoker, Fusion.Android.PayGuardian")]
		void ProcessBridgeCommTransaction (global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity p0, string p1);

	}

	[global::Android.Runtime.Register ("com/bpn/payguardian/android/service/PaymentProcessService", DoNotGenerateAcw=true)]
	internal class IPaymentProcessServiceInvoker : global::Java.Lang.Object, IPaymentProcessService {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bpn/payguardian/android/service/PaymentProcessService");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IPaymentProcessServiceInvoker); }
		}

		IntPtr class_ref;

		public static IPaymentProcessService GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPaymentProcessService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bpn.payguardian.android.service.PaymentProcessService"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPaymentProcessServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_processBridgeCommTransaction_Lcom_bpn_payguardian_android_entity_PaymentRequestEntity_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetProcessBridgeCommTransaction_Lcom_bpn_payguardian_android_entity_PaymentRequestEntity_Ljava_lang_String_Handler ()
		{
			if (cb_processBridgeCommTransaction_Lcom_bpn_payguardian_android_entity_PaymentRequestEntity_Ljava_lang_String_ == null)
				cb_processBridgeCommTransaction_Lcom_bpn_payguardian_android_entity_PaymentRequestEntity_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ProcessBridgeCommTransaction_Lcom_bpn_payguardian_android_entity_PaymentRequestEntity_Ljava_lang_String_);
			return cb_processBridgeCommTransaction_Lcom_bpn_payguardian_android_entity_PaymentRequestEntity_Ljava_lang_String_;
		}

		static void n_ProcessBridgeCommTransaction_Lcom_bpn_payguardian_android_entity_PaymentRequestEntity_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bpn.Payguardian.Android.Service.IPaymentProcessService __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.IPaymentProcessService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity p0 = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ProcessBridgeCommTransaction (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_processBridgeCommTransaction_Lcom_bpn_payguardian_android_entity_PaymentRequestEntity_Ljava_lang_String_;
		public unsafe void ProcessBridgeCommTransaction (global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity p0, string p1)
		{
			if (id_processBridgeCommTransaction_Lcom_bpn_payguardian_android_entity_PaymentRequestEntity_Ljava_lang_String_ == IntPtr.Zero)
				id_processBridgeCommTransaction_Lcom_bpn_payguardian_android_entity_PaymentRequestEntity_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "processBridgeCommTransaction", "(Lcom/bpn/payguardian/android/entity/PaymentRequestEntity;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processBridgeCommTransaction_Lcom_bpn_payguardian_android_entity_PaymentRequestEntity_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
