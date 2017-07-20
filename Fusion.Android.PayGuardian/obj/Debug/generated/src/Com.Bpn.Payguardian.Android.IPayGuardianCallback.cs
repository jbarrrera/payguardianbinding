using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bpn.Payguardian.Android {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bpn.payguardian.android']/interface[@name='PayGuardianCallback']"
	[Register ("com/bpn/payguardian/android/PayGuardianCallback", "", "Com.Bpn.Payguardian.Android.IPayGuardianCallbackInvoker")]
	public partial interface IPayGuardianCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/interface[@name='PayGuardianCallback']/method[@name='keyedFallback' and count(parameter)=0]"
		[Register ("keyedFallback", "()V", "GetKeyedFallbackHandler:Com.Bpn.Payguardian.Android.IPayGuardianCallbackInvoker, Fusion.Android.PayGuardian")]
		void KeyedFallback ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/interface[@name='PayGuardianCallback']/method[@name='selectEmvApplication' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;java.lang.String&gt;']]"
		[Register ("selectEmvApplication", "(Ljava/util/ArrayList;)V", "GetSelectEmvApplication_Ljava_util_ArrayList_Handler:Com.Bpn.Payguardian.Android.IPayGuardianCallbackInvoker, Fusion.Android.PayGuardian")]
		void SelectEmvApplication (global::System.Collections.Generic.IList<string> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/interface[@name='PayGuardianCallback']/method[@name='statusUpdated' and count(parameter)=2 and parameter[1][@type='com.bpn.payguardian.android.PayGuardianStatus'] and parameter[2][@type='java.lang.String']]"
		[Register ("statusUpdated", "(Lcom/bpn/payguardian/android/PayGuardianStatus;Ljava/lang/String;)V", "GetStatusUpdated_Lcom_bpn_payguardian_android_PayGuardianStatus_Ljava_lang_String_Handler:Com.Bpn.Payguardian.Android.IPayGuardianCallbackInvoker, Fusion.Android.PayGuardian")]
		void StatusUpdated (global::Com.Bpn.Payguardian.Android.PayGuardianStatus p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/interface[@name='PayGuardianCallback']/method[@name='transactionResponse' and count(parameter)=1 and parameter[1][@type='com.bpn.payguardian.android.model.PaymentResponse']]"
		[Register ("transactionResponse", "(Lcom/bpn/payguardian/android/model/PaymentResponse;)V", "GetTransactionResponse_Lcom_bpn_payguardian_android_model_PaymentResponse_Handler:Com.Bpn.Payguardian.Android.IPayGuardianCallbackInvoker, Fusion.Android.PayGuardian")]
		void TransactionResponse (global::Com.Bpn.Payguardian.Android.Model.PaymentResponse p0);

	}

	[global::Android.Runtime.Register ("com/bpn/payguardian/android/PayGuardianCallback", DoNotGenerateAcw=true)]
	internal class IPayGuardianCallbackInvoker : global::Java.Lang.Object, IPayGuardianCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bpn/payguardian/android/PayGuardianCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IPayGuardianCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IPayGuardianCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPayGuardianCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bpn.payguardian.android.PayGuardianCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPayGuardianCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_keyedFallback;
#pragma warning disable 0169
		static Delegate GetKeyedFallbackHandler ()
		{
			if (cb_keyedFallback == null)
				cb_keyedFallback = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_KeyedFallback);
			return cb_keyedFallback;
		}

		static void n_KeyedFallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.IPayGuardianCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.IPayGuardianCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.KeyedFallback ();
		}
#pragma warning restore 0169

		IntPtr id_keyedFallback;
		public unsafe void KeyedFallback ()
		{
			if (id_keyedFallback == IntPtr.Zero)
				id_keyedFallback = JNIEnv.GetMethodID (class_ref, "keyedFallback", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_keyedFallback);
		}

		static Delegate cb_selectEmvApplication_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetSelectEmvApplication_Ljava_util_ArrayList_Handler ()
		{
			if (cb_selectEmvApplication_Ljava_util_ArrayList_ == null)
				cb_selectEmvApplication_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SelectEmvApplication_Ljava_util_ArrayList_);
			return cb_selectEmvApplication_Ljava_util_ArrayList_;
		}

		static void n_SelectEmvApplication_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.IPayGuardianCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.IPayGuardianCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SelectEmvApplication (p0);
		}
#pragma warning restore 0169

		IntPtr id_selectEmvApplication_Ljava_util_ArrayList_;
		public unsafe void SelectEmvApplication (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_selectEmvApplication_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_selectEmvApplication_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "selectEmvApplication", "(Ljava/util/ArrayList;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_selectEmvApplication_Ljava_util_ArrayList_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_statusUpdated_Lcom_bpn_payguardian_android_PayGuardianStatus_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStatusUpdated_Lcom_bpn_payguardian_android_PayGuardianStatus_Ljava_lang_String_Handler ()
		{
			if (cb_statusUpdated_Lcom_bpn_payguardian_android_PayGuardianStatus_Ljava_lang_String_ == null)
				cb_statusUpdated_Lcom_bpn_payguardian_android_PayGuardianStatus_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_StatusUpdated_Lcom_bpn_payguardian_android_PayGuardianStatus_Ljava_lang_String_);
			return cb_statusUpdated_Lcom_bpn_payguardian_android_PayGuardianStatus_Ljava_lang_String_;
		}

		static void n_StatusUpdated_Lcom_bpn_payguardian_android_PayGuardianStatus_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bpn.Payguardian.Android.IPayGuardianCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.IPayGuardianCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bpn.Payguardian.Android.PayGuardianStatus p0 = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardianStatus> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.StatusUpdated (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_statusUpdated_Lcom_bpn_payguardian_android_PayGuardianStatus_Ljava_lang_String_;
		public unsafe void StatusUpdated (global::Com.Bpn.Payguardian.Android.PayGuardianStatus p0, string p1)
		{
			if (id_statusUpdated_Lcom_bpn_payguardian_android_PayGuardianStatus_Ljava_lang_String_ == IntPtr.Zero)
				id_statusUpdated_Lcom_bpn_payguardian_android_PayGuardianStatus_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "statusUpdated", "(Lcom/bpn/payguardian/android/PayGuardianStatus;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_statusUpdated_Lcom_bpn_payguardian_android_PayGuardianStatus_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_transactionResponse_Lcom_bpn_payguardian_android_model_PaymentResponse_;
#pragma warning disable 0169
		static Delegate GetTransactionResponse_Lcom_bpn_payguardian_android_model_PaymentResponse_Handler ()
		{
			if (cb_transactionResponse_Lcom_bpn_payguardian_android_model_PaymentResponse_ == null)
				cb_transactionResponse_Lcom_bpn_payguardian_android_model_PaymentResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_TransactionResponse_Lcom_bpn_payguardian_android_model_PaymentResponse_);
			return cb_transactionResponse_Lcom_bpn_payguardian_android_model_PaymentResponse_;
		}

		static void n_TransactionResponse_Lcom_bpn_payguardian_android_model_PaymentResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.IPayGuardianCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.IPayGuardianCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse p0 = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TransactionResponse (p0);
		}
#pragma warning restore 0169

		IntPtr id_transactionResponse_Lcom_bpn_payguardian_android_model_PaymentResponse_;
		public unsafe void TransactionResponse (global::Com.Bpn.Payguardian.Android.Model.PaymentResponse p0)
		{
			if (id_transactionResponse_Lcom_bpn_payguardian_android_model_PaymentResponse_ == IntPtr.Zero)
				id_transactionResponse_Lcom_bpn_payguardian_android_model_PaymentResponse_ = JNIEnv.GetMethodID (class_ref, "transactionResponse", "(Lcom/bpn/payguardian/android/model/PaymentResponse;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_transactionResponse_Lcom_bpn_payguardian_android_model_PaymentResponse_, __args);
		}

	}

}
