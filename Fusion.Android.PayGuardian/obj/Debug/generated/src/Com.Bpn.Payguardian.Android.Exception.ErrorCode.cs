using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bpn.Payguardian.Android.Exception {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='ErrorCode']"
	[global::Android.Runtime.Register ("com/bpn/payguardian/android/exception/ErrorCode", DoNotGenerateAcw=true)]
	public sealed partial class ErrorCode : global::Java.Lang.Enum {


		static IntPtr DEVICE_NOT_FOUND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='ErrorCode']/field[@name='DEVICE_NOT_FOUND']"
		[Register ("DEVICE_NOT_FOUND")]
		public static global::Com.Bpn.Payguardian.Android.Exception.ErrorCode DeviceNotFound {
			get {
				if (DEVICE_NOT_FOUND_jfieldId == IntPtr.Zero)
					DEVICE_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_NOT_FOUND", "Lcom/bpn/payguardian/android/exception/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEVICE_NOT_FOUND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Exception.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DEVICE_TIMEDOUT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='ErrorCode']/field[@name='DEVICE_TIMEDOUT']"
		[Register ("DEVICE_TIMEDOUT")]
		public static global::Com.Bpn.Payguardian.Android.Exception.ErrorCode DeviceTimedout {
			get {
				if (DEVICE_TIMEDOUT_jfieldId == IntPtr.Zero)
					DEVICE_TIMEDOUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_TIMEDOUT", "Lcom/bpn/payguardian/android/exception/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEVICE_TIMEDOUT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Exception.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr GLOBAL_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='ErrorCode']/field[@name='GLOBAL_ERROR']"
		[Register ("GLOBAL_ERROR")]
		public static global::Com.Bpn.Payguardian.Android.Exception.ErrorCode GlobalError {
			get {
				if (GLOBAL_ERROR_jfieldId == IntPtr.Zero)
					GLOBAL_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GLOBAL_ERROR", "Lcom/bpn/payguardian/android/exception/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GLOBAL_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Exception.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INVALID_AMOUNT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='ErrorCode']/field[@name='INVALID_AMOUNT']"
		[Register ("INVALID_AMOUNT")]
		public static global::Com.Bpn.Payguardian.Android.Exception.ErrorCode InvalidAmount {
			get {
				if (INVALID_AMOUNT_jfieldId == IntPtr.Zero)
					INVALID_AMOUNT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_AMOUNT", "Lcom/bpn/payguardian/android/exception/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVALID_AMOUNT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Exception.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INVALID_INVOICE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='ErrorCode']/field[@name='INVALID_INVOICE']"
		[Register ("INVALID_INVOICE")]
		public static global::Com.Bpn.Payguardian.Android.Exception.ErrorCode InvalidInvoice {
			get {
				if (INVALID_INVOICE_jfieldId == IntPtr.Zero)
					INVALID_INVOICE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_INVOICE", "Lcom/bpn/payguardian/android/exception/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVALID_INVOICE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Exception.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INVALID_MERCHANT_ACCOUNT_CODE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='ErrorCode']/field[@name='INVALID_MERCHANT_ACCOUNT_CODE']"
		[Register ("INVALID_MERCHANT_ACCOUNT_CODE")]
		public static global::Com.Bpn.Payguardian.Android.Exception.ErrorCode InvalidMerchantAccountCode {
			get {
				if (INVALID_MERCHANT_ACCOUNT_CODE_jfieldId == IntPtr.Zero)
					INVALID_MERCHANT_ACCOUNT_CODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_MERCHANT_ACCOUNT_CODE", "Lcom/bpn/payguardian/android/exception/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVALID_MERCHANT_ACCOUNT_CODE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Exception.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INVALID_MERCHANT_CODE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='ErrorCode']/field[@name='INVALID_MERCHANT_CODE']"
		[Register ("INVALID_MERCHANT_CODE")]
		public static global::Com.Bpn.Payguardian.Android.Exception.ErrorCode InvalidMerchantCode {
			get {
				if (INVALID_MERCHANT_CODE_jfieldId == IntPtr.Zero)
					INVALID_MERCHANT_CODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_MERCHANT_CODE", "Lcom/bpn/payguardian/android/exception/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVALID_MERCHANT_CODE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Exception.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INVALID_PASSWORD_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='ErrorCode']/field[@name='INVALID_PASSWORD']"
		[Register ("INVALID_PASSWORD")]
		public static global::Com.Bpn.Payguardian.Android.Exception.ErrorCode InvalidPassword {
			get {
				if (INVALID_PASSWORD_jfieldId == IntPtr.Zero)
					INVALID_PASSWORD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_PASSWORD", "Lcom/bpn/payguardian/android/exception/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVALID_PASSWORD_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Exception.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INVALID_PAYMENT_REQUEST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='ErrorCode']/field[@name='INVALID_PAYMENT_REQUEST']"
		[Register ("INVALID_PAYMENT_REQUEST")]
		public static global::Com.Bpn.Payguardian.Android.Exception.ErrorCode InvalidPaymentRequest {
			get {
				if (INVALID_PAYMENT_REQUEST_jfieldId == IntPtr.Zero)
					INVALID_PAYMENT_REQUEST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_PAYMENT_REQUEST", "Lcom/bpn/payguardian/android/exception/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVALID_PAYMENT_REQUEST_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Exception.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INVALID_REFERENCE_NUMBER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='ErrorCode']/field[@name='INVALID_REFERENCE_NUMBER']"
		[Register ("INVALID_REFERENCE_NUMBER")]
		public static global::Com.Bpn.Payguardian.Android.Exception.ErrorCode InvalidReferenceNumber {
			get {
				if (INVALID_REFERENCE_NUMBER_jfieldId == IntPtr.Zero)
					INVALID_REFERENCE_NUMBER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_REFERENCE_NUMBER", "Lcom/bpn/payguardian/android/exception/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVALID_REFERENCE_NUMBER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Exception.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INVALID_REQUEST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='ErrorCode']/field[@name='INVALID_REQUEST']"
		[Register ("INVALID_REQUEST")]
		public static global::Com.Bpn.Payguardian.Android.Exception.ErrorCode InvalidRequest {
			get {
				if (INVALID_REQUEST_jfieldId == IntPtr.Zero)
					INVALID_REQUEST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_REQUEST", "Lcom/bpn/payguardian/android/exception/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVALID_REQUEST_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Exception.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INVALID_TENDER_TYPE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='ErrorCode']/field[@name='INVALID_TENDER_TYPE']"
		[Register ("INVALID_TENDER_TYPE")]
		public static global::Com.Bpn.Payguardian.Android.Exception.ErrorCode InvalidTenderType {
			get {
				if (INVALID_TENDER_TYPE_jfieldId == IntPtr.Zero)
					INVALID_TENDER_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_TENDER_TYPE", "Lcom/bpn/payguardian/android/exception/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVALID_TENDER_TYPE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Exception.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INVALID_TERMINAL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='ErrorCode']/field[@name='INVALID_TERMINAL']"
		[Register ("INVALID_TERMINAL")]
		public static global::Com.Bpn.Payguardian.Android.Exception.ErrorCode InvalidTerminal {
			get {
				if (INVALID_TERMINAL_jfieldId == IntPtr.Zero)
					INVALID_TERMINAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_TERMINAL", "Lcom/bpn/payguardian/android/exception/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVALID_TERMINAL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Exception.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INVALID_TRANSACTION_TYPE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='ErrorCode']/field[@name='INVALID_TRANSACTION_TYPE']"
		[Register ("INVALID_TRANSACTION_TYPE")]
		public static global::Com.Bpn.Payguardian.Android.Exception.ErrorCode InvalidTransactionType {
			get {
				if (INVALID_TRANSACTION_TYPE_jfieldId == IntPtr.Zero)
					INVALID_TRANSACTION_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_TRANSACTION_TYPE", "Lcom/bpn/payguardian/android/exception/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVALID_TRANSACTION_TYPE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Exception.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INVALID_USERNAME_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='ErrorCode']/field[@name='INVALID_USERNAME']"
		[Register ("INVALID_USERNAME")]
		public static global::Com.Bpn.Payguardian.Android.Exception.ErrorCode InvalidUsername {
			get {
				if (INVALID_USERNAME_jfieldId == IntPtr.Zero)
					INVALID_USERNAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_USERNAME", "Lcom/bpn/payguardian/android/exception/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVALID_USERNAME_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Exception.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NO_NETWORK_CONNECTION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='ErrorCode']/field[@name='NO_NETWORK_CONNECTION']"
		[Register ("NO_NETWORK_CONNECTION")]
		public static global::Com.Bpn.Payguardian.Android.Exception.ErrorCode NoNetworkConnection {
			get {
				if (NO_NETWORK_CONNECTION_jfieldId == IntPtr.Zero)
					NO_NETWORK_CONNECTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_NETWORK_CONNECTION", "Lcom/bpn/payguardian/android/exception/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NO_NETWORK_CONNECTION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Exception.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNBALE_TO_ACCESS_DEVICE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='ErrorCode']/field[@name='UNBALE_TO_ACCESS_DEVICE']"
		[Register ("UNBALE_TO_ACCESS_DEVICE")]
		public static global::Com.Bpn.Payguardian.Android.Exception.ErrorCode UnbaleToAccessDevice {
			get {
				if (UNBALE_TO_ACCESS_DEVICE_jfieldId == IntPtr.Zero)
					UNBALE_TO_ACCESS_DEVICE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNBALE_TO_ACCESS_DEVICE", "Lcom/bpn/payguardian/android/exception/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNBALE_TO_ACCESS_DEVICE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Exception.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNBALE_TO_PROCESS_TRANSACTION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='ErrorCode']/field[@name='UNBALE_TO_PROCESS_TRANSACTION']"
		[Register ("UNBALE_TO_PROCESS_TRANSACTION")]
		public static global::Com.Bpn.Payguardian.Android.Exception.ErrorCode UnbaleToProcessTransaction {
			get {
				if (UNBALE_TO_PROCESS_TRANSACTION_jfieldId == IntPtr.Zero)
					UNBALE_TO_PROCESS_TRANSACTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNBALE_TO_PROCESS_TRANSACTION", "Lcom/bpn/payguardian/android/exception/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNBALE_TO_PROCESS_TRANSACTION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Exception.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNIPAYIII_AUTOCONFIG_FAIL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='ErrorCode']/field[@name='UNIPAYIII_AUTOCONFIG_FAIL']"
		[Register ("UNIPAYIII_AUTOCONFIG_FAIL")]
		public static global::Com.Bpn.Payguardian.Android.Exception.ErrorCode UnipayiiiAutoconfigFail {
			get {
				if (UNIPAYIII_AUTOCONFIG_FAIL_jfieldId == IntPtr.Zero)
					UNIPAYIII_AUTOCONFIG_FAIL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNIPAYIII_AUTOCONFIG_FAIL", "Lcom/bpn/payguardian/android/exception/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNIPAYIII_AUTOCONFIG_FAIL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Exception.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNIPAYIII_BAD_SWIPE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='ErrorCode']/field[@name='UNIPAYIII_BAD_SWIPE']"
		[Register ("UNIPAYIII_BAD_SWIPE")]
		public static global::Com.Bpn.Payguardian.Android.Exception.ErrorCode UnipayiiiBadSwipe {
			get {
				if (UNIPAYIII_BAD_SWIPE_jfieldId == IntPtr.Zero)
					UNIPAYIII_BAD_SWIPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNIPAYIII_BAD_SWIPE", "Lcom/bpn/payguardian/android/exception/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNIPAYIII_BAD_SWIPE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Exception.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNIPAYIII_EMV_AUTH_FAIL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='ErrorCode']/field[@name='UNIPAYIII_EMV_AUTH_FAIL']"
		[Register ("UNIPAYIII_EMV_AUTH_FAIL")]
		public static global::Com.Bpn.Payguardian.Android.Exception.ErrorCode UnipayiiiEmvAuthFail {
			get {
				if (UNIPAYIII_EMV_AUTH_FAIL_jfieldId == IntPtr.Zero)
					UNIPAYIII_EMV_AUTH_FAIL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNIPAYIII_EMV_AUTH_FAIL", "Lcom/bpn/payguardian/android/exception/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNIPAYIII_EMV_AUTH_FAIL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Exception.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNIPAYIII_NO_CONNECTION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='ErrorCode']/field[@name='UNIPAYIII_NO_CONNECTION']"
		[Register ("UNIPAYIII_NO_CONNECTION")]
		public static global::Com.Bpn.Payguardian.Android.Exception.ErrorCode UnipayiiiNoConnection {
			get {
				if (UNIPAYIII_NO_CONNECTION_jfieldId == IntPtr.Zero)
					UNIPAYIII_NO_CONNECTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNIPAYIII_NO_CONNECTION", "Lcom/bpn/payguardian/android/exception/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNIPAYIII_NO_CONNECTION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Exception.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNIPAYIII_TIMEOUT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='ErrorCode']/field[@name='UNIPAYIII_TIMEOUT']"
		[Register ("UNIPAYIII_TIMEOUT")]
		public static global::Com.Bpn.Payguardian.Android.Exception.ErrorCode UnipayiiiTimeout {
			get {
				if (UNIPAYIII_TIMEOUT_jfieldId == IntPtr.Zero)
					UNIPAYIII_TIMEOUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNIPAYIII_TIMEOUT", "Lcom/bpn/payguardian/android/exception/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNIPAYIII_TIMEOUT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Exception.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VALIDATION_FAILED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='ErrorCode']/field[@name='VALIDATION_FAILED']"
		[Register ("VALIDATION_FAILED")]
		public static global::Com.Bpn.Payguardian.Android.Exception.ErrorCode ValidationFailed {
			get {
				if (VALIDATION_FAILED_jfieldId == IntPtr.Zero)
					VALIDATION_FAILED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VALIDATION_FAILED", "Lcom/bpn/payguardian/android/exception/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VALIDATION_FAILED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Exception.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr XML_BASE64_DECODE_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='ErrorCode']/field[@name='XML_BASE64_DECODE_ERROR']"
		[Register ("XML_BASE64_DECODE_ERROR")]
		public static global::Com.Bpn.Payguardian.Android.Exception.ErrorCode XmlBase64DecodeError {
			get {
				if (XML_BASE64_DECODE_ERROR_jfieldId == IntPtr.Zero)
					XML_BASE64_DECODE_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "XML_BASE64_DECODE_ERROR", "Lcom/bpn/payguardian/android/exception/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, XML_BASE64_DECODE_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Exception.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr XML_BASE64_ENCODE_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='ErrorCode']/field[@name='XML_BASE64_ENCODE_ERROR']"
		[Register ("XML_BASE64_ENCODE_ERROR")]
		public static global::Com.Bpn.Payguardian.Android.Exception.ErrorCode XmlBase64EncodeError {
			get {
				if (XML_BASE64_ENCODE_ERROR_jfieldId == IntPtr.Zero)
					XML_BASE64_ENCODE_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "XML_BASE64_ENCODE_ERROR", "Lcom/bpn/payguardian/android/exception/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, XML_BASE64_ENCODE_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Exception.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr XML_DESERIALIZTION_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='ErrorCode']/field[@name='XML_DESERIALIZTION_ERROR']"
		[Register ("XML_DESERIALIZTION_ERROR")]
		public static global::Com.Bpn.Payguardian.Android.Exception.ErrorCode XmlDeserializtionError {
			get {
				if (XML_DESERIALIZTION_ERROR_jfieldId == IntPtr.Zero)
					XML_DESERIALIZTION_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "XML_DESERIALIZTION_ERROR", "Lcom/bpn/payguardian/android/exception/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, XML_DESERIALIZTION_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Exception.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr XML_SERIALIZTION_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='ErrorCode']/field[@name='XML_SERIALIZTION_ERROR']"
		[Register ("XML_SERIALIZTION_ERROR")]
		public static global::Com.Bpn.Payguardian.Android.Exception.ErrorCode XmlSerializtionError {
			get {
				if (XML_SERIALIZTION_ERROR_jfieldId == IntPtr.Zero)
					XML_SERIALIZTION_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "XML_SERIALIZTION_ERROR", "Lcom/bpn/payguardian/android/exception/ErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, XML_SERIALIZTION_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Exception.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bpn/payguardian/android/exception/ErrorCode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ErrorCode); }
		}

		internal ErrorCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getCode;
		public unsafe string Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='ErrorCode']/method[@name='getCode' and count(parameter)=0]"
			[Register ("getCode", "()Ljava/lang/String;", "GetGetCodeHandler")]
			get {
				if (id_getCode == IntPtr.Zero)
					id_getCode = JNIEnv.GetMethodID (class_ref, "getCode", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCode), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getMessage;
		public unsafe string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='ErrorCode']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_get_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='ErrorCode']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/exception/ErrorCode;", "")]
		public static unsafe global::Com.Bpn.Payguardian.Android.Exception.ErrorCode Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "get", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/exception/ErrorCode;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Bpn.Payguardian.Android.Exception.ErrorCode __ret = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Exception.ErrorCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='ErrorCode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/exception/ErrorCode;", "")]
		public static unsafe global::Com.Bpn.Payguardian.Android.Exception.ErrorCode ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/exception/ErrorCode;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Bpn.Payguardian.Android.Exception.ErrorCode __ret = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Exception.ErrorCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.exception']/class[@name='ErrorCode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/bpn/payguardian/android/exception/ErrorCode;", "")]
		public static unsafe global::Com.Bpn.Payguardian.Android.Exception.ErrorCode[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bpn/payguardian/android/exception/ErrorCode;");
			try {
				return (global::Com.Bpn.Payguardian.Android.Exception.ErrorCode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bpn.Payguardian.Android.Exception.ErrorCode));
			} finally {
			}
		}

	}
}
