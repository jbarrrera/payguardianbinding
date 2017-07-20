using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bpn.Payguardian.Android.Service {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bpn.payguardian.android.service']/interface[@name='PaymentServiceEvents']"
	[Register ("com/bpn/payguardian/android/service/PaymentServiceEvents", "", "Com.Bpn.Payguardian.Android.Service.IPaymentServiceEventsInvoker")]
	public partial interface IPaymentServiceEvents : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.service']/interface[@name='PaymentServiceEvents']/method[@name='paymentProcessCompleted' and count(parameter)=1 and parameter[1][@type='com.bpn.payguardian.android.entity.PaymentReponseEntity']]"
		[Register ("paymentProcessCompleted", "(Lcom/bpn/payguardian/android/entity/PaymentReponseEntity;)V", "GetPaymentProcessCompleted_Lcom_bpn_payguardian_android_entity_PaymentReponseEntity_Handler:Com.Bpn.Payguardian.Android.Service.IPaymentServiceEventsInvoker, Fusion.Android.PayGuardian")]
		void PaymentProcessCompleted (global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity p0);

	}

	[global::Android.Runtime.Register ("com/bpn/payguardian/android/service/PaymentServiceEvents", DoNotGenerateAcw=true)]
	internal class IPaymentServiceEventsInvoker : global::Java.Lang.Object, IPaymentServiceEvents {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bpn/payguardian/android/service/PaymentServiceEvents");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IPaymentServiceEventsInvoker); }
		}

		IntPtr class_ref;

		public static IPaymentServiceEvents GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPaymentServiceEvents> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bpn.payguardian.android.service.PaymentServiceEvents"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPaymentServiceEventsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_paymentProcessCompleted_Lcom_bpn_payguardian_android_entity_PaymentReponseEntity_;
#pragma warning disable 0169
		static Delegate GetPaymentProcessCompleted_Lcom_bpn_payguardian_android_entity_PaymentReponseEntity_Handler ()
		{
			if (cb_paymentProcessCompleted_Lcom_bpn_payguardian_android_entity_PaymentReponseEntity_ == null)
				cb_paymentProcessCompleted_Lcom_bpn_payguardian_android_entity_PaymentReponseEntity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PaymentProcessCompleted_Lcom_bpn_payguardian_android_entity_PaymentReponseEntity_);
			return cb_paymentProcessCompleted_Lcom_bpn_payguardian_android_entity_PaymentReponseEntity_;
		}

		static void n_PaymentProcessCompleted_Lcom_bpn_payguardian_android_entity_PaymentReponseEntity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Service.IPaymentServiceEvents __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.IPaymentServiceEvents> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity p0 = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PaymentProcessCompleted (p0);
		}
#pragma warning restore 0169

		IntPtr id_paymentProcessCompleted_Lcom_bpn_payguardian_android_entity_PaymentReponseEntity_;
		public unsafe void PaymentProcessCompleted (global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity p0)
		{
			if (id_paymentProcessCompleted_Lcom_bpn_payguardian_android_entity_PaymentReponseEntity_ == IntPtr.Zero)
				id_paymentProcessCompleted_Lcom_bpn_payguardian_android_entity_PaymentReponseEntity_ = JNIEnv.GetMethodID (class_ref, "paymentProcessCompleted", "(Lcom/bpn/payguardian/android/entity/PaymentReponseEntity;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_paymentProcessCompleted_Lcom_bpn_payguardian_android_entity_PaymentReponseEntity_, __args);
		}

	}

}
