using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bpn.Payguardian.Android.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='ConversionUtil']"
	[global::Android.Runtime.Register ("com/bpn/payguardian/android/util/ConversionUtil", DoNotGenerateAcw=true)]
	public partial class ConversionUtil : global::Java.Lang.Object {


		static IntPtr hexArray_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='ConversionUtil']/field[@name='hexArray']"
		[Register ("hexArray")]
		protected static IList<char> HexArray {
			get {
				if (hexArray_jfieldId == IntPtr.Zero)
					hexArray_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "hexArray", "[C");
				return global::Android.Runtime.JavaArray<char>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, hexArray_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bpn/payguardian/android/util/ConversionUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConversionUtil); }
		}

		protected ConversionUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Bpn.Payguardian.Android.Util.ConversionUtil Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='ConversionUtil']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/bpn/payguardian/android/util/ConversionUtil;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/bpn/payguardian/android/util/ConversionUtil;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.ConversionUtil> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_bytesToHex_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='ConversionUtil']/method[@name='bytesToHex' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("bytesToHex", "([B)Ljava/lang/String;", "")]
		public static unsafe string BytesToHex (byte[] p0)
		{
			if (id_bytesToHex_arrayB == IntPtr.Zero)
				id_bytesToHex_arrayB = JNIEnv.GetStaticMethodID (class_ref, "bytesToHex", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_bytesToHex_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_errorResponseTOResponseEntity_Lcom_bpn_payguardian_android_payment_PayloadErrorResponse_;
#pragma warning disable 0169
		static Delegate GetErrorResponseTOResponseEntity_Lcom_bpn_payguardian_android_payment_PayloadErrorResponse_Handler ()
		{
			if (cb_errorResponseTOResponseEntity_Lcom_bpn_payguardian_android_payment_PayloadErrorResponse_ == null)
				cb_errorResponseTOResponseEntity_Lcom_bpn_payguardian_android_payment_PayloadErrorResponse_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ErrorResponseTOResponseEntity_Lcom_bpn_payguardian_android_payment_PayloadErrorResponse_);
			return cb_errorResponseTOResponseEntity_Lcom_bpn_payguardian_android_payment_PayloadErrorResponse_;
		}

		static IntPtr n_ErrorResponseTOResponseEntity_Lcom_bpn_payguardian_android_payment_PayloadErrorResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Util.ConversionUtil __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.ConversionUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bpn.Payguardian.Android.Payment.PayloadErrorResponse p0 = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadErrorResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ErrorResponseTOResponseEntity (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_errorResponseTOResponseEntity_Lcom_bpn_payguardian_android_payment_PayloadErrorResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='ConversionUtil']/method[@name='errorResponseTOResponseEntity' and count(parameter)=1 and parameter[1][@type='com.bpn.payguardian.android.payment.PayloadErrorResponse']]"
		[Register ("errorResponseTOResponseEntity", "(Lcom/bpn/payguardian/android/payment/PayloadErrorResponse;)Lcom/bpn/payguardian/android/entity/PaymentReponseEntity;", "GetErrorResponseTOResponseEntity_Lcom_bpn_payguardian_android_payment_PayloadErrorResponse_Handler")]
		public virtual unsafe global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity ErrorResponseTOResponseEntity (global::Com.Bpn.Payguardian.Android.Payment.PayloadErrorResponse p0)
		{
			if (id_errorResponseTOResponseEntity_Lcom_bpn_payguardian_android_payment_PayloadErrorResponse_ == IntPtr.Zero)
				id_errorResponseTOResponseEntity_Lcom_bpn_payguardian_android_payment_PayloadErrorResponse_ = JNIEnv.GetMethodID (class_ref, "errorResponseTOResponseEntity", "(Lcom/bpn/payguardian/android/payment/PayloadErrorResponse;)Lcom/bpn/payguardian/android/entity/PaymentReponseEntity;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_errorResponseTOResponseEntity_Lcom_bpn_payguardian_android_payment_PayloadErrorResponse_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "errorResponseTOResponseEntity", "(Lcom/bpn/payguardian/android/payment/PayloadErrorResponse;)Lcom/bpn/payguardian/android/entity/PaymentReponseEntity;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_hexStringToAscii_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='ConversionUtil']/method[@name='hexStringToAscii' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hexStringToAscii", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string HexStringToAscii (string p0)
		{
			if (id_hexStringToAscii_Ljava_lang_String_ == IntPtr.Zero)
				id_hexStringToAscii_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "hexStringToAscii", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_hexStringToAscii_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_payloadResponseTOResponseEntity_Lcom_bpn_payguardian_android_payment_PayloadResponse_;
#pragma warning disable 0169
		static Delegate GetPayloadResponseTOResponseEntity_Lcom_bpn_payguardian_android_payment_PayloadResponse_Handler ()
		{
			if (cb_payloadResponseTOResponseEntity_Lcom_bpn_payguardian_android_payment_PayloadResponse_ == null)
				cb_payloadResponseTOResponseEntity_Lcom_bpn_payguardian_android_payment_PayloadResponse_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_PayloadResponseTOResponseEntity_Lcom_bpn_payguardian_android_payment_PayloadResponse_);
			return cb_payloadResponseTOResponseEntity_Lcom_bpn_payguardian_android_payment_PayloadResponse_;
		}

		static IntPtr n_PayloadResponseTOResponseEntity_Lcom_bpn_payguardian_android_payment_PayloadResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Util.ConversionUtil __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.ConversionUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bpn.Payguardian.Android.Payment.PayloadResponse p0 = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PayloadResponseTOResponseEntity (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_payloadResponseTOResponseEntity_Lcom_bpn_payguardian_android_payment_PayloadResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='ConversionUtil']/method[@name='payloadResponseTOResponseEntity' and count(parameter)=1 and parameter[1][@type='com.bpn.payguardian.android.payment.PayloadResponse']]"
		[Register ("payloadResponseTOResponseEntity", "(Lcom/bpn/payguardian/android/payment/PayloadResponse;)Lcom/bpn/payguardian/android/entity/PaymentReponseEntity;", "GetPayloadResponseTOResponseEntity_Lcom_bpn_payguardian_android_payment_PayloadResponse_Handler")]
		public virtual unsafe global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity PayloadResponseTOResponseEntity (global::Com.Bpn.Payguardian.Android.Payment.PayloadResponse p0)
		{
			if (id_payloadResponseTOResponseEntity_Lcom_bpn_payguardian_android_payment_PayloadResponse_ == IntPtr.Zero)
				id_payloadResponseTOResponseEntity_Lcom_bpn_payguardian_android_payment_PayloadResponse_ = JNIEnv.GetMethodID (class_ref, "payloadResponseTOResponseEntity", "(Lcom/bpn/payguardian/android/payment/PayloadResponse;)Lcom/bpn/payguardian/android/entity/PaymentReponseEntity;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_payloadResponseTOResponseEntity_Lcom_bpn_payguardian_android_payment_PayloadResponse_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "payloadResponseTOResponseEntity", "(Lcom/bpn/payguardian/android/payment/PayloadResponse;)Lcom/bpn/payguardian/android/entity/PaymentReponseEntity;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_requestEntityTOPayloadRequest_Lcom_bpn_payguardian_android_entity_PaymentRequestEntity_;
#pragma warning disable 0169
		static Delegate GetRequestEntityTOPayloadRequest_Lcom_bpn_payguardian_android_entity_PaymentRequestEntity_Handler ()
		{
			if (cb_requestEntityTOPayloadRequest_Lcom_bpn_payguardian_android_entity_PaymentRequestEntity_ == null)
				cb_requestEntityTOPayloadRequest_Lcom_bpn_payguardian_android_entity_PaymentRequestEntity_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RequestEntityTOPayloadRequest_Lcom_bpn_payguardian_android_entity_PaymentRequestEntity_);
			return cb_requestEntityTOPayloadRequest_Lcom_bpn_payguardian_android_entity_PaymentRequestEntity_;
		}

		static IntPtr n_RequestEntityTOPayloadRequest_Lcom_bpn_payguardian_android_entity_PaymentRequestEntity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Util.ConversionUtil __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.ConversionUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity p0 = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RequestEntityTOPayloadRequest (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_requestEntityTOPayloadRequest_Lcom_bpn_payguardian_android_entity_PaymentRequestEntity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='ConversionUtil']/method[@name='requestEntityTOPayloadRequest' and count(parameter)=1 and parameter[1][@type='com.bpn.payguardian.android.entity.PaymentRequestEntity']]"
		[Register ("requestEntityTOPayloadRequest", "(Lcom/bpn/payguardian/android/entity/PaymentRequestEntity;)Lcom/bpn/payguardian/android/payment/PayloadRequestHeader;", "GetRequestEntityTOPayloadRequest_Lcom_bpn_payguardian_android_entity_PaymentRequestEntity_Handler")]
		public virtual unsafe global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestHeader RequestEntityTOPayloadRequest (global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity p0)
		{
			if (id_requestEntityTOPayloadRequest_Lcom_bpn_payguardian_android_entity_PaymentRequestEntity_ == IntPtr.Zero)
				id_requestEntityTOPayloadRequest_Lcom_bpn_payguardian_android_entity_PaymentRequestEntity_ = JNIEnv.GetMethodID (class_ref, "requestEntityTOPayloadRequest", "(Lcom/bpn/payguardian/android/entity/PaymentRequestEntity;)Lcom/bpn/payguardian/android/payment/PayloadRequestHeader;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestHeader __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestHeader> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_requestEntityTOPayloadRequest_Lcom_bpn_payguardian_android_entity_PaymentRequestEntity_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestHeader> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestEntityTOPayloadRequest", "(Lcom/bpn/payguardian/android/entity/PaymentRequestEntity;)Lcom/bpn/payguardian/android/payment/PayloadRequestHeader;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_responseEntityTOObject_Lcom_bpn_payguardian_android_entity_PaymentReponseEntity_;
#pragma warning disable 0169
		static Delegate GetResponseEntityTOObject_Lcom_bpn_payguardian_android_entity_PaymentReponseEntity_Handler ()
		{
			if (cb_responseEntityTOObject_Lcom_bpn_payguardian_android_entity_PaymentReponseEntity_ == null)
				cb_responseEntityTOObject_Lcom_bpn_payguardian_android_entity_PaymentReponseEntity_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ResponseEntityTOObject_Lcom_bpn_payguardian_android_entity_PaymentReponseEntity_);
			return cb_responseEntityTOObject_Lcom_bpn_payguardian_android_entity_PaymentReponseEntity_;
		}

		static IntPtr n_ResponseEntityTOObject_Lcom_bpn_payguardian_android_entity_PaymentReponseEntity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Util.ConversionUtil __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.ConversionUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity p0 = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ResponseEntityTOObject (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_responseEntityTOObject_Lcom_bpn_payguardian_android_entity_PaymentReponseEntity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='ConversionUtil']/method[@name='responseEntityTOObject' and count(parameter)=1 and parameter[1][@type='com.bpn.payguardian.android.entity.PaymentReponseEntity']]"
		[Register ("responseEntityTOObject", "(Lcom/bpn/payguardian/android/entity/PaymentReponseEntity;)Lcom/bpn/payguardian/android/model/PaymentResponse;", "GetResponseEntityTOObject_Lcom_bpn_payguardian_android_entity_PaymentReponseEntity_Handler")]
		public virtual unsafe global::Com.Bpn.Payguardian.Android.Model.PaymentResponse ResponseEntityTOObject (global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity p0)
		{
			if (id_responseEntityTOObject_Lcom_bpn_payguardian_android_entity_PaymentReponseEntity_ == IntPtr.Zero)
				id_responseEntityTOObject_Lcom_bpn_payguardian_android_entity_PaymentReponseEntity_ = JNIEnv.GetMethodID (class_ref, "responseEntityTOObject", "(Lcom/bpn/payguardian/android/entity/PaymentReponseEntity;)Lcom/bpn/payguardian/android/model/PaymentResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bpn.Payguardian.Android.Model.PaymentResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_responseEntityTOObject_Lcom_bpn_payguardian_android_entity_PaymentReponseEntity_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "responseEntityTOObject", "(Lcom/bpn/payguardian/android/entity/PaymentReponseEntity;)Lcom/bpn/payguardian/android/model/PaymentResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
