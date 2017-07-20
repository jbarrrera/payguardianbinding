using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bpn.Payguardian.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']"
	[global::Android.Runtime.Register ("com/bpn/payguardian/android/PayGuardian", DoNotGenerateAcw=true)]
	public partial class PayGuardian : global::Java.Lang.Object, global::Com.Bpn.Payguardian.Android.Device.Unipay.IUnipayCallback, global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector, global::Com.Bpn.Payguardian.Android.Service.IPaymentServiceEvents {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/field[@name='FIELD_SEPARATOR']"
		[Register ("FIELD_SEPARATOR")]
		public const string FieldSeparator = (string) "\u001C";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/field[@name='OFFLINE_AUTH']"
		[Register ("OFFLINE_AUTH")]
		public const string OfflineAuth = (string) "02";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/field[@name='OFFLINE_AUTH_SUCCESS']"
		[Register ("OFFLINE_AUTH_SUCCESS")]
		public const string OfflineAuthSuccess = (string) "00";

		static IntPtr SLEEPTIME_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/field[@name='SLEEPTIME']"
		[Register ("SLEEPTIME")]
		public long Sleeptime {
			get {
				if (SLEEPTIME_jfieldId == IntPtr.Zero)
					SLEEPTIME_jfieldId = JNIEnv.GetFieldID (class_ref, "SLEEPTIME", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, SLEEPTIME_jfieldId);
			}
			set {
				if (SLEEPTIME_jfieldId == IntPtr.Zero)
					SLEEPTIME_jfieldId = JNIEnv.GetFieldID (class_ref, "SLEEPTIME", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, SLEEPTIME_jfieldId, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/field[@name='TERMINAL_TYPE_BBPOS_EMVSWIPE']"
		[Register ("TERMINAL_TYPE_BBPOS_EMVSWIPE")]
		public const string TerminalTypeBbposEmvswipe = (string) "chipper2";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/field[@name='TERMINAL_TYPE_BBPOS_WISEPAD']"
		[Register ("TERMINAL_TYPE_BBPOS_WISEPAD")]
		public const string TerminalTypeBbposWisepad = (string) "wisepad2";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/field[@name='TERMINAL_TYPE_KEYED']"
		[Register ("TERMINAL_TYPE_KEYED")]
		public const string TerminalTypeKeyed = (string) "keyed";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/field[@name='TERMINAL_TYPE_MINISMARTII']"
		[Register ("TERMINAL_TYPE_MINISMARTII")]
		public const string TerminalTypeMinismartii = (string) "minismartii";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/field[@name='TERMINAL_TYPE_PAX_D180']"
		[Register ("TERMINAL_TYPE_PAX_D180")]
		public const string TerminalTypePaxD180 = (string) "d180";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/field[@name='TERMINAL_TYPE_RBABT']"
		[Register ("TERMINAL_TYPE_RBABT")]
		public const string TerminalTypeRbabt = (string) "rbabt";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/field[@name='TERMINAL_TYPE_RBAUSB']"
		[Register ("TERMINAL_TYPE_RBAUSB")]
		public const string TerminalTypeRbausb = (string) "rbausb";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/field[@name='TERMINAL_TYPE_UNIPAYIII']"
		[Register ("TERMINAL_TYPE_UNIPAYIII")]
		public const string TerminalTypeUnipayiii = (string) "unipayiii";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/field[@name='TERMINAL_TYPE_VIVOPAY']"
		[Register ("TERMINAL_TYPE_VIVOPAY")]
		public const string TerminalTypeVivopay = (string) "vivopay";

		static IntPtr readedData_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/field[@name='readedData']"
		[Register ("readedData")]
		public bool ReadedData {
			get {
				if (readedData_jfieldId == IntPtr.Zero)
					readedData_jfieldId = JNIEnv.GetFieldID (class_ref, "readedData", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, readedData_jfieldId);
			}
			set {
				if (readedData_jfieldId == IntPtr.Zero)
					readedData_jfieldId = JNIEnv.GetFieldID (class_ref, "readedData", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, readedData_jfieldId, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian.TenderTypes']"
		[global::Android.Runtime.Register ("com/bpn/payguardian/android/PayGuardian$TenderTypes", DoNotGenerateAcw=true)]
		public sealed partial class TenderTypes : global::Java.Lang.Enum {


			static IntPtr CREDIT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian.TenderTypes']/field[@name='CREDIT']"
			[Register ("CREDIT")]
			public static global::Com.Bpn.Payguardian.Android.PayGuardian.TenderTypes Credit {
				get {
					if (CREDIT_jfieldId == IntPtr.Zero)
						CREDIT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREDIT", "Lcom/bpn/payguardian/android/PayGuardian$TenderTypes;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREDIT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian.TenderTypes> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DEBIT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian.TenderTypes']/field[@name='DEBIT']"
			[Register ("DEBIT")]
			public static global::Com.Bpn.Payguardian.Android.PayGuardian.TenderTypes Debit {
				get {
					if (DEBIT_jfieldId == IntPtr.Zero)
						DEBIT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEBIT", "Lcom/bpn/payguardian/android/PayGuardian$TenderTypes;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEBIT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian.TenderTypes> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr GIFT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian.TenderTypes']/field[@name='GIFT']"
			[Register ("GIFT")]
			public static global::Com.Bpn.Payguardian.Android.PayGuardian.TenderTypes Gift {
				get {
					if (GIFT_jfieldId == IntPtr.Zero)
						GIFT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GIFT", "Lcom/bpn/payguardian/android/PayGuardian$TenderTypes;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GIFT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian.TenderTypes> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bpn/payguardian/android/PayGuardian$TenderTypes", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TenderTypes); }
			}

			internal TenderTypes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getType;
			public unsafe string Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian.TenderTypes']/method[@name='getType' and count(parameter)=0]"
				[Register ("getType", "()Ljava/lang/String;", "GetGetTypeHandler")]
				get {
					if (id_getType == IntPtr.Zero)
						id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian.TenderTypes']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/PayGuardian$TenderTypes;", "")]
			public static unsafe global::Com.Bpn.Payguardian.Android.PayGuardian.TenderTypes ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/PayGuardian$TenderTypes;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Bpn.Payguardian.Android.PayGuardian.TenderTypes __ret = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian.TenderTypes> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian.TenderTypes']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/bpn/payguardian/android/PayGuardian$TenderTypes;", "")]
			public static unsafe global::Com.Bpn.Payguardian.Android.PayGuardian.TenderTypes[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bpn/payguardian/android/PayGuardian$TenderTypes;");
				try {
					return (global::Com.Bpn.Payguardian.Android.PayGuardian.TenderTypes[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bpn.Payguardian.Android.PayGuardian.TenderTypes));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian.TransactionTypes']"
		[global::Android.Runtime.Register ("com/bpn/payguardian/android/PayGuardian$TransactionTypes", DoNotGenerateAcw=true)]
		public sealed partial class TransactionTypes : global::Java.Lang.Enum {


			static IntPtr ACTIVATE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian.TransactionTypes']/field[@name='ACTIVATE']"
			[Register ("ACTIVATE")]
			public static global::Com.Bpn.Payguardian.Android.PayGuardian.TransactionTypes Activate {
				get {
					if (ACTIVATE_jfieldId == IntPtr.Zero)
						ACTIVATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACTIVATE", "Lcom/bpn/payguardian/android/PayGuardian$TransactionTypes;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACTIVATE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian.TransactionTypes> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BALANCEINQUIRY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian.TransactionTypes']/field[@name='BALANCEINQUIRY']"
			[Register ("BALANCEINQUIRY")]
			public static global::Com.Bpn.Payguardian.Android.PayGuardian.TransactionTypes Balanceinquiry {
				get {
					if (BALANCEINQUIRY_jfieldId == IntPtr.Zero)
						BALANCEINQUIRY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BALANCEINQUIRY", "Lcom/bpn/payguardian/android/PayGuardian$TransactionTypes;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BALANCEINQUIRY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian.TransactionTypes> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CAPTURE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian.TransactionTypes']/field[@name='CAPTURE']"
			[Register ("CAPTURE")]
			public static global::Com.Bpn.Payguardian.Android.PayGuardian.TransactionTypes Capture {
				get {
					if (CAPTURE_jfieldId == IntPtr.Zero)
						CAPTURE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CAPTURE", "Lcom/bpn/payguardian/android/PayGuardian$TransactionTypes;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CAPTURE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian.TransactionTypes> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CAPTURE_ALL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian.TransactionTypes']/field[@name='CAPTURE_ALL']"
			[Register ("CAPTURE_ALL")]
			public static global::Com.Bpn.Payguardian.Android.PayGuardian.TransactionTypes CaptureAll {
				get {
					if (CAPTURE_ALL_jfieldId == IntPtr.Zero)
						CAPTURE_ALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CAPTURE_ALL", "Lcom/bpn/payguardian/android/PayGuardian$TransactionTypes;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CAPTURE_ALL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian.TransactionTypes> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CREDIT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian.TransactionTypes']/field[@name='CREDIT']"
			[Register ("CREDIT")]
			public static global::Com.Bpn.Payguardian.Android.PayGuardian.TransactionTypes Credit {
				get {
					if (CREDIT_jfieldId == IntPtr.Zero)
						CREDIT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREDIT", "Lcom/bpn/payguardian/android/PayGuardian$TransactionTypes;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREDIT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian.TransactionTypes> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CREDIT_AUTH_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian.TransactionTypes']/field[@name='CREDIT_AUTH']"
			[Register ("CREDIT_AUTH")]
			public static global::Com.Bpn.Payguardian.Android.PayGuardian.TransactionTypes CreditAuth {
				get {
					if (CREDIT_AUTH_jfieldId == IntPtr.Zero)
						CREDIT_AUTH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREDIT_AUTH", "Lcom/bpn/payguardian/android/PayGuardian$TransactionTypes;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREDIT_AUTH_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian.TransactionTypes> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DEACTIVATE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian.TransactionTypes']/field[@name='DEACTIVATE']"
			[Register ("DEACTIVATE")]
			public static global::Com.Bpn.Payguardian.Android.PayGuardian.TransactionTypes Deactivate {
				get {
					if (DEACTIVATE_jfieldId == IntPtr.Zero)
						DEACTIVATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEACTIVATE", "Lcom/bpn/payguardian/android/PayGuardian$TransactionTypes;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEACTIVATE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian.TransactionTypes> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MERCHANT_INFO_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian.TransactionTypes']/field[@name='MERCHANT_INFO']"
			[Register ("MERCHANT_INFO")]
			public static global::Com.Bpn.Payguardian.Android.PayGuardian.TransactionTypes MerchantInfo {
				get {
					if (MERCHANT_INFO_jfieldId == IntPtr.Zero)
						MERCHANT_INFO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MERCHANT_INFO", "Lcom/bpn/payguardian/android/PayGuardian$TransactionTypes;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MERCHANT_INFO_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian.TransactionTypes> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr REACTIVATE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian.TransactionTypes']/field[@name='REACTIVATE']"
			[Register ("REACTIVATE")]
			public static global::Com.Bpn.Payguardian.Android.PayGuardian.TransactionTypes Reactivate {
				get {
					if (REACTIVATE_jfieldId == IntPtr.Zero)
						REACTIVATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REACTIVATE", "Lcom/bpn/payguardian/android/PayGuardian$TransactionTypes;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REACTIVATE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian.TransactionTypes> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr REFUND_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian.TransactionTypes']/field[@name='REFUND']"
			[Register ("REFUND")]
			public static global::Com.Bpn.Payguardian.Android.PayGuardian.TransactionTypes Refund {
				get {
					if (REFUND_jfieldId == IntPtr.Zero)
						REFUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REFUND", "Lcom/bpn/payguardian/android/PayGuardian$TransactionTypes;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REFUND_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian.TransactionTypes> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr REVERSAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian.TransactionTypes']/field[@name='REVERSAL']"
			[Register ("REVERSAL")]
			public static global::Com.Bpn.Payguardian.Android.PayGuardian.TransactionTypes Reversal {
				get {
					if (REVERSAL_jfieldId == IntPtr.Zero)
						REVERSAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REVERSAL", "Lcom/bpn/payguardian/android/PayGuardian$TransactionTypes;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REVERSAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian.TransactionTypes> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SALE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian.TransactionTypes']/field[@name='SALE']"
			[Register ("SALE")]
			public static global::Com.Bpn.Payguardian.Android.PayGuardian.TransactionTypes Sale {
				get {
					if (SALE_jfieldId == IntPtr.Zero)
						SALE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SALE", "Lcom/bpn/payguardian/android/PayGuardian$TransactionTypes;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SALE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian.TransactionTypes> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SALE_AUTH_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian.TransactionTypes']/field[@name='SALE_AUTH']"
			[Register ("SALE_AUTH")]
			public static global::Com.Bpn.Payguardian.Android.PayGuardian.TransactionTypes SaleAuth {
				get {
					if (SALE_AUTH_jfieldId == IntPtr.Zero)
						SALE_AUTH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SALE_AUTH", "Lcom/bpn/payguardian/android/PayGuardian$TransactionTypes;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SALE_AUTH_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian.TransactionTypes> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TOKENADD_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian.TransactionTypes']/field[@name='TOKENADD']"
			[Register ("TOKENADD")]
			public static global::Com.Bpn.Payguardian.Android.PayGuardian.TransactionTypes Tokenadd {
				get {
					if (TOKENADD_jfieldId == IntPtr.Zero)
						TOKENADD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TOKENADD", "Lcom/bpn/payguardian/android/PayGuardian$TransactionTypes;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TOKENADD_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian.TransactionTypes> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VOID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian.TransactionTypes']/field[@name='VOID']"
			[Register ("VOID")]
			public static global::Com.Bpn.Payguardian.Android.PayGuardian.TransactionTypes Void {
				get {
					if (VOID_jfieldId == IntPtr.Zero)
						VOID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VOID", "Lcom/bpn/payguardian/android/PayGuardian$TransactionTypes;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VOID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian.TransactionTypes> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bpn/payguardian/android/PayGuardian$TransactionTypes", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TransactionTypes); }
			}

			internal TransactionTypes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getType;
			public unsafe string Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian.TransactionTypes']/method[@name='getType' and count(parameter)=0]"
				[Register ("getType", "()Ljava/lang/String;", "GetGetTypeHandler")]
				get {
					if (id_getType == IntPtr.Zero)
						id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian.TransactionTypes']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/PayGuardian$TransactionTypes;", "")]
			public static unsafe global::Com.Bpn.Payguardian.Android.PayGuardian.TransactionTypes ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/PayGuardian$TransactionTypes;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Bpn.Payguardian.Android.PayGuardian.TransactionTypes __ret = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian.TransactionTypes> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian.TransactionTypes']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/bpn/payguardian/android/PayGuardian$TransactionTypes;", "")]
			public static unsafe global::Com.Bpn.Payguardian.Android.PayGuardian.TransactionTypes[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bpn/payguardian/android/PayGuardian$TransactionTypes;");
				try {
					return (global::Com.Bpn.Payguardian.Android.PayGuardian.TransactionTypes[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bpn.Payguardian.Android.PayGuardian.TransactionTypes));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bpn/payguardian/android/PayGuardian", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PayGuardian); }
		}

		protected PayGuardian (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_app_Activity_Lcom_bpn_payguardian_android_PayGuardianCallback_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/constructor[@name='PayGuardian' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.app.Activity'] and parameter[3][@type='com.bpn.payguardian.android.PayGuardianCallback']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/app/Activity;Lcom/bpn/payguardian/android/PayGuardianCallback;)V", "")]
		public unsafe PayGuardian (global::Android.Content.Context p0, global::Android.App.Activity p1, global::Com.Bpn.Payguardian.Android.IPayGuardianCallback p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (PayGuardian)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/app/Activity;Lcom/bpn/payguardian/android/PayGuardianCallback;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/app/Activity;Lcom/bpn/payguardian/android/PayGuardianCallback;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_app_Activity_Lcom_bpn_payguardian_android_PayGuardianCallback_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_app_Activity_Lcom_bpn_payguardian_android_PayGuardianCallback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/app/Activity;Lcom/bpn/payguardian/android/PayGuardianCallback;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_app_Activity_Lcom_bpn_payguardian_android_PayGuardianCallback_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_app_Activity_Lcom_bpn_payguardian_android_PayGuardianCallback_, __args);
			} finally {
			}
		}

		static Delegate cb_badCardReader_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetBadCardReader_Ljava_lang_String_Handler ()
		{
			if (cb_badCardReader_Ljava_lang_String_ == null)
				cb_badCardReader_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_BadCardReader_Ljava_lang_String_);
			return cb_badCardReader_Ljava_lang_String_;
		}

		static void n_BadCardReader_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.PayGuardian __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BadCardReader (p0);
		}
#pragma warning restore 0169

		static IntPtr id_badCardReader_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/method[@name='badCardReader' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("badCardReader", "(Ljava/lang/String;)V", "GetBadCardReader_Ljava_lang_String_Handler")]
		public virtual unsafe void BadCardReader (string p0)
		{
			if (id_badCardReader_Ljava_lang_String_ == IntPtr.Zero)
				id_badCardReader_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "badCardReader", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_badCardReader_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "badCardReader", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_badCardReaderRetry_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetBadCardReaderRetry_Ljava_lang_String_Handler ()
		{
			if (cb_badCardReaderRetry_Ljava_lang_String_ == null)
				cb_badCardReaderRetry_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_BadCardReaderRetry_Ljava_lang_String_);
			return cb_badCardReaderRetry_Ljava_lang_String_;
		}

		static void n_BadCardReaderRetry_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.PayGuardian __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BadCardReaderRetry (p0);
		}
#pragma warning restore 0169

		static IntPtr id_badCardReaderRetry_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/method[@name='badCardReaderRetry' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("badCardReaderRetry", "(Ljava/lang/String;)V", "GetBadCardReaderRetry_Ljava_lang_String_Handler")]
		public virtual unsafe void BadCardReaderRetry (string p0)
		{
			if (id_badCardReaderRetry_Ljava_lang_String_ == IntPtr.Zero)
				id_badCardReaderRetry_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "badCardReaderRetry", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_badCardReaderRetry_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "badCardReaderRetry", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_cardReaderCompleted_Lcom_bpn_payguardian_android_device_model_MsrDTO_;
#pragma warning disable 0169
		static Delegate GetCardReaderCompleted_Lcom_bpn_payguardian_android_device_model_MsrDTO_Handler ()
		{
			if (cb_cardReaderCompleted_Lcom_bpn_payguardian_android_device_model_MsrDTO_ == null)
				cb_cardReaderCompleted_Lcom_bpn_payguardian_android_device_model_MsrDTO_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CardReaderCompleted_Lcom_bpn_payguardian_android_device_model_MsrDTO_);
			return cb_cardReaderCompleted_Lcom_bpn_payguardian_android_device_model_MsrDTO_;
		}

		static void n_CardReaderCompleted_Lcom_bpn_payguardian_android_device_model_MsrDTO_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.PayGuardian __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO p0 = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CardReaderCompleted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_cardReaderCompleted_Lcom_bpn_payguardian_android_device_model_MsrDTO_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/method[@name='cardReaderCompleted' and count(parameter)=1 and parameter[1][@type='com.bpn.payguardian.android.device.model.MsrDTO']]"
		[Register ("cardReaderCompleted", "(Lcom/bpn/payguardian/android/device/model/MsrDTO;)V", "GetCardReaderCompleted_Lcom_bpn_payguardian_android_device_model_MsrDTO_Handler")]
		public virtual unsafe void CardReaderCompleted (global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO p0)
		{
			if (id_cardReaderCompleted_Lcom_bpn_payguardian_android_device_model_MsrDTO_ == IntPtr.Zero)
				id_cardReaderCompleted_Lcom_bpn_payguardian_android_device_model_MsrDTO_ = JNIEnv.GetMethodID (class_ref, "cardReaderCompleted", "(Lcom/bpn/payguardian/android/device/model/MsrDTO;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cardReaderCompleted_Lcom_bpn_payguardian_android_device_model_MsrDTO_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cardReaderCompleted", "(Lcom/bpn/payguardian/android/device/model/MsrDTO;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_connect;
#pragma warning disable 0169
		static Delegate GetConnectHandler ()
		{
			if (cb_connect == null)
				cb_connect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Connect);
			return cb_connect;
		}

		static void n_Connect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.PayGuardian __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Connect ();
		}
#pragma warning restore 0169

		static IntPtr id_connect;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/method[@name='connect' and count(parameter)=0]"
		[Register ("connect", "()V", "GetConnectHandler")]
		public virtual unsafe void Connect ()
		{
			if (id_connect == IntPtr.Zero)
				id_connect = JNIEnv.GetMethodID (class_ref, "connect", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connect);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connect", "()V"));
			} finally {
			}
		}

		static Delegate cb_connectEmvSwipe;
#pragma warning disable 0169
		static Delegate GetConnectEmvSwipeHandler ()
		{
			if (cb_connectEmvSwipe == null)
				cb_connectEmvSwipe = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ConnectEmvSwipe);
			return cb_connectEmvSwipe;
		}

		static void n_ConnectEmvSwipe (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.PayGuardian __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConnectEmvSwipe ();
		}
#pragma warning restore 0169

		static IntPtr id_connectEmvSwipe;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/method[@name='connectEmvSwipe' and count(parameter)=0]"
		[Register ("connectEmvSwipe", "()V", "GetConnectEmvSwipeHandler")]
		public virtual unsafe void ConnectEmvSwipe ()
		{
			if (id_connectEmvSwipe == IntPtr.Zero)
				id_connectEmvSwipe = JNIEnv.GetMethodID (class_ref, "connectEmvSwipe", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connectEmvSwipe);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connectEmvSwipe", "()V"));
			} finally {
			}
		}

		static Delegate cb_connectUnipayIII_Z;
#pragma warning disable 0169
		static Delegate GetConnectUnipayIII_ZHandler ()
		{
			if (cb_connectUnipayIII_Z == null)
				cb_connectUnipayIII_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ConnectUnipayIII_Z);
			return cb_connectUnipayIII_Z;
		}

		static void n_ConnectUnipayIII_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Bpn.Payguardian.Android.PayGuardian __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConnectUnipayIII (p0);
		}
#pragma warning restore 0169

		static IntPtr id_connectUnipayIII_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/method[@name='connectUnipayIII' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("connectUnipayIII", "(Z)V", "GetConnectUnipayIII_ZHandler")]
		public virtual unsafe void ConnectUnipayIII (bool p0)
		{
			if (id_connectUnipayIII_Z == IntPtr.Zero)
				id_connectUnipayIII_Z = JNIEnv.GetMethodID (class_ref, "connectUnipayIII", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connectUnipayIII_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connectUnipayIII", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_connectWisePad;
#pragma warning disable 0169
		static Delegate GetConnectWisePadHandler ()
		{
			if (cb_connectWisePad == null)
				cb_connectWisePad = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ConnectWisePad);
			return cb_connectWisePad;
		}

		static void n_ConnectWisePad (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.PayGuardian __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConnectWisePad ();
		}
#pragma warning restore 0169

		static IntPtr id_connectWisePad;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/method[@name='connectWisePad' and count(parameter)=0]"
		[Register ("connectWisePad", "()V", "GetConnectWisePadHandler")]
		public virtual unsafe void ConnectWisePad ()
		{
			if (id_connectWisePad == IntPtr.Zero)
				id_connectWisePad = JNIEnv.GetMethodID (class_ref, "connectWisePad", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connectWisePad);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connectWisePad", "()V"));
			} finally {
			}
		}

		static Delegate cb_disconnectEmvSwipe;
#pragma warning disable 0169
		static Delegate GetDisconnectEmvSwipeHandler ()
		{
			if (cb_disconnectEmvSwipe == null)
				cb_disconnectEmvSwipe = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisconnectEmvSwipe);
			return cb_disconnectEmvSwipe;
		}

		static void n_DisconnectEmvSwipe (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.PayGuardian __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisconnectEmvSwipe ();
		}
#pragma warning restore 0169

		static IntPtr id_disconnectEmvSwipe;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/method[@name='disconnectEmvSwipe' and count(parameter)=0]"
		[Register ("disconnectEmvSwipe", "()V", "GetDisconnectEmvSwipeHandler")]
		public virtual unsafe void DisconnectEmvSwipe ()
		{
			if (id_disconnectEmvSwipe == IntPtr.Zero)
				id_disconnectEmvSwipe = JNIEnv.GetMethodID (class_ref, "disconnectEmvSwipe", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disconnectEmvSwipe);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnectEmvSwipe", "()V"));
			} finally {
			}
		}

		static Delegate cb_emvAuthorizationRequestCompleted_Lcom_bpn_payguardian_android_device_model_EmvDTO_;
#pragma warning disable 0169
		static Delegate GetEmvAuthorizationRequestCompleted_Lcom_bpn_payguardian_android_device_model_EmvDTO_Handler ()
		{
			if (cb_emvAuthorizationRequestCompleted_Lcom_bpn_payguardian_android_device_model_EmvDTO_ == null)
				cb_emvAuthorizationRequestCompleted_Lcom_bpn_payguardian_android_device_model_EmvDTO_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_EmvAuthorizationRequestCompleted_Lcom_bpn_payguardian_android_device_model_EmvDTO_);
			return cb_emvAuthorizationRequestCompleted_Lcom_bpn_payguardian_android_device_model_EmvDTO_;
		}

		static void n_EmvAuthorizationRequestCompleted_Lcom_bpn_payguardian_android_device_model_EmvDTO_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.PayGuardian __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO p0 = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EmvAuthorizationRequestCompleted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_emvAuthorizationRequestCompleted_Lcom_bpn_payguardian_android_device_model_EmvDTO_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/method[@name='emvAuthorizationRequestCompleted' and count(parameter)=1 and parameter[1][@type='com.bpn.payguardian.android.device.model.EmvDTO']]"
		[Register ("emvAuthorizationRequestCompleted", "(Lcom/bpn/payguardian/android/device/model/EmvDTO;)V", "GetEmvAuthorizationRequestCompleted_Lcom_bpn_payguardian_android_device_model_EmvDTO_Handler")]
		public virtual unsafe void EmvAuthorizationRequestCompleted (global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO p0)
		{
			if (id_emvAuthorizationRequestCompleted_Lcom_bpn_payguardian_android_device_model_EmvDTO_ == IntPtr.Zero)
				id_emvAuthorizationRequestCompleted_Lcom_bpn_payguardian_android_device_model_EmvDTO_ = JNIEnv.GetMethodID (class_ref, "emvAuthorizationRequestCompleted", "(Lcom/bpn/payguardian/android/device/model/EmvDTO;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_emvAuthorizationRequestCompleted_Lcom_bpn_payguardian_android_device_model_EmvDTO_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "emvAuthorizationRequestCompleted", "(Lcom/bpn/payguardian/android/device/model/EmvDTO;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_emvAuthorizationResponseCompleted_Lcom_bpn_payguardian_android_device_model_EmvDTO_;
#pragma warning disable 0169
		static Delegate GetEmvAuthorizationResponseCompleted_Lcom_bpn_payguardian_android_device_model_EmvDTO_Handler ()
		{
			if (cb_emvAuthorizationResponseCompleted_Lcom_bpn_payguardian_android_device_model_EmvDTO_ == null)
				cb_emvAuthorizationResponseCompleted_Lcom_bpn_payguardian_android_device_model_EmvDTO_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_EmvAuthorizationResponseCompleted_Lcom_bpn_payguardian_android_device_model_EmvDTO_);
			return cb_emvAuthorizationResponseCompleted_Lcom_bpn_payguardian_android_device_model_EmvDTO_;
		}

		static void n_EmvAuthorizationResponseCompleted_Lcom_bpn_payguardian_android_device_model_EmvDTO_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.PayGuardian __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO p0 = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EmvAuthorizationResponseCompleted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_emvAuthorizationResponseCompleted_Lcom_bpn_payguardian_android_device_model_EmvDTO_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/method[@name='emvAuthorizationResponseCompleted' and count(parameter)=1 and parameter[1][@type='com.bpn.payguardian.android.device.model.EmvDTO']]"
		[Register ("emvAuthorizationResponseCompleted", "(Lcom/bpn/payguardian/android/device/model/EmvDTO;)V", "GetEmvAuthorizationResponseCompleted_Lcom_bpn_payguardian_android_device_model_EmvDTO_Handler")]
		public virtual unsafe void EmvAuthorizationResponseCompleted (global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO p0)
		{
			if (id_emvAuthorizationResponseCompleted_Lcom_bpn_payguardian_android_device_model_EmvDTO_ == IntPtr.Zero)
				id_emvAuthorizationResponseCompleted_Lcom_bpn_payguardian_android_device_model_EmvDTO_ = JNIEnv.GetMethodID (class_ref, "emvAuthorizationResponseCompleted", "(Lcom/bpn/payguardian/android/device/model/EmvDTO;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_emvAuthorizationResponseCompleted_Lcom_bpn_payguardian_android_device_model_EmvDTO_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "emvAuthorizationResponseCompleted", "(Lcom/bpn/payguardian/android/device/model/EmvDTO;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_hexStringToByteArray_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/method[@name='hexStringToByteArray' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hexStringToByteArray", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] HexStringToByteArray (string p0)
		{
			if (id_hexStringToByteArray_Ljava_lang_String_ == IntPtr.Zero)
				id_hexStringToByteArray_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "hexStringToByteArray", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_hexStringToByteArray_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
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
			global::Com.Bpn.Payguardian.Android.PayGuardian __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity p0 = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PaymentProcessCompleted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_paymentProcessCompleted_Lcom_bpn_payguardian_android_entity_PaymentReponseEntity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/method[@name='paymentProcessCompleted' and count(parameter)=1 and parameter[1][@type='com.bpn.payguardian.android.entity.PaymentReponseEntity']]"
		[Register ("paymentProcessCompleted", "(Lcom/bpn/payguardian/android/entity/PaymentReponseEntity;)V", "GetPaymentProcessCompleted_Lcom_bpn_payguardian_android_entity_PaymentReponseEntity_Handler")]
		public virtual unsafe void PaymentProcessCompleted (global::Com.Bpn.Payguardian.Android.Entity.PaymentReponseEntity p0)
		{
			if (id_paymentProcessCompleted_Lcom_bpn_payguardian_android_entity_PaymentReponseEntity_ == IntPtr.Zero)
				id_paymentProcessCompleted_Lcom_bpn_payguardian_android_entity_PaymentReponseEntity_ = JNIEnv.GetMethodID (class_ref, "paymentProcessCompleted", "(Lcom/bpn/payguardian/android/entity/PaymentReponseEntity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_paymentProcessCompleted_Lcom_bpn_payguardian_android_entity_PaymentReponseEntity_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "paymentProcessCompleted", "(Lcom/bpn/payguardian/android/entity/PaymentReponseEntity;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_pinEntryCompleted_Lcom_bpn_payguardian_android_device_model_PinPadDTO_;
#pragma warning disable 0169
		static Delegate GetPinEntryCompleted_Lcom_bpn_payguardian_android_device_model_PinPadDTO_Handler ()
		{
			if (cb_pinEntryCompleted_Lcom_bpn_payguardian_android_device_model_PinPadDTO_ == null)
				cb_pinEntryCompleted_Lcom_bpn_payguardian_android_device_model_PinPadDTO_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PinEntryCompleted_Lcom_bpn_payguardian_android_device_model_PinPadDTO_);
			return cb_pinEntryCompleted_Lcom_bpn_payguardian_android_device_model_PinPadDTO_;
		}

		static void n_PinEntryCompleted_Lcom_bpn_payguardian_android_device_model_PinPadDTO_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.PayGuardian __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bpn.Payguardian.Android.Device.Model.PinPadDTO p0 = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.PinPadDTO> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PinEntryCompleted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_pinEntryCompleted_Lcom_bpn_payguardian_android_device_model_PinPadDTO_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/method[@name='pinEntryCompleted' and count(parameter)=1 and parameter[1][@type='com.bpn.payguardian.android.device.model.PinPadDTO']]"
		[Register ("pinEntryCompleted", "(Lcom/bpn/payguardian/android/device/model/PinPadDTO;)V", "GetPinEntryCompleted_Lcom_bpn_payguardian_android_device_model_PinPadDTO_Handler")]
		public virtual unsafe void PinEntryCompleted (global::Com.Bpn.Payguardian.Android.Device.Model.PinPadDTO p0)
		{
			if (id_pinEntryCompleted_Lcom_bpn_payguardian_android_device_model_PinPadDTO_ == IntPtr.Zero)
				id_pinEntryCompleted_Lcom_bpn_payguardian_android_device_model_PinPadDTO_ = JNIEnv.GetMethodID (class_ref, "pinEntryCompleted", "(Lcom/bpn/payguardian/android/device/model/PinPadDTO;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pinEntryCompleted_Lcom_bpn_payguardian_android_device_model_PinPadDTO_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pinEntryCompleted", "(Lcom/bpn/payguardian/android/device/model/PinPadDTO;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_readCardReader;
#pragma warning disable 0169
		static Delegate GetReadCardReaderHandler ()
		{
			if (cb_readCardReader == null)
				cb_readCardReader = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReadCardReader);
			return cb_readCardReader;
		}

		static void n_ReadCardReader (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.PayGuardian __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReadCardReader ();
		}
#pragma warning restore 0169

		static IntPtr id_readCardReader;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/method[@name='readCardReader' and count(parameter)=0]"
		[Register ("readCardReader", "()V", "GetReadCardReaderHandler")]
		public virtual unsafe void ReadCardReader ()
		{
			if (id_readCardReader == IntPtr.Zero)
				id_readCardReader = JNIEnv.GetMethodID (class_ref, "readCardReader", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readCardReader);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readCardReader", "()V"));
			} finally {
			}
		}

		static Delegate cb_readEmvSwipeReader;
#pragma warning disable 0169
		static Delegate GetReadEmvSwipeReaderHandler ()
		{
			if (cb_readEmvSwipeReader == null)
				cb_readEmvSwipeReader = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReadEmvSwipeReader);
			return cb_readEmvSwipeReader;
		}

		static void n_ReadEmvSwipeReader (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.PayGuardian __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReadEmvSwipeReader ();
		}
#pragma warning restore 0169

		static IntPtr id_readEmvSwipeReader;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/method[@name='readEmvSwipeReader' and count(parameter)=0]"
		[Register ("readEmvSwipeReader", "()V", "GetReadEmvSwipeReaderHandler")]
		public virtual unsafe void ReadEmvSwipeReader ()
		{
			if (id_readEmvSwipeReader == IntPtr.Zero)
				id_readEmvSwipeReader = JNIEnv.GetMethodID (class_ref, "readEmvSwipeReader", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readEmvSwipeReader);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readEmvSwipeReader", "()V"));
			} finally {
			}
		}

		static Delegate cb_readPinEntry;
#pragma warning disable 0169
		static Delegate GetReadPinEntryHandler ()
		{
			if (cb_readPinEntry == null)
				cb_readPinEntry = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReadPinEntry);
			return cb_readPinEntry;
		}

		static void n_ReadPinEntry (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.PayGuardian __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReadPinEntry ();
		}
#pragma warning restore 0169

		static IntPtr id_readPinEntry;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/method[@name='readPinEntry' and count(parameter)=0]"
		[Register ("readPinEntry", "()V", "GetReadPinEntryHandler")]
		public virtual unsafe void ReadPinEntry ()
		{
			if (id_readPinEntry == IntPtr.Zero)
				id_readPinEntry = JNIEnv.GetMethodID (class_ref, "readPinEntry", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readPinEntry);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readPinEntry", "()V"));
			} finally {
			}
		}

		static Delegate cb_readWisePadReader;
#pragma warning disable 0169
		static Delegate GetReadWisePadReaderHandler ()
		{
			if (cb_readWisePadReader == null)
				cb_readWisePadReader = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReadWisePadReader);
			return cb_readWisePadReader;
		}

		static void n_ReadWisePadReader (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.PayGuardian __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReadWisePadReader ();
		}
#pragma warning restore 0169

		static IntPtr id_readWisePadReader;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/method[@name='readWisePadReader' and count(parameter)=0]"
		[Register ("readWisePadReader", "()V", "GetReadWisePadReaderHandler")]
		public virtual unsafe void ReadWisePadReader ()
		{
			if (id_readWisePadReader == IntPtr.Zero)
				id_readWisePadReader = JNIEnv.GetMethodID (class_ref, "readWisePadReader", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readWisePadReader);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readWisePadReader", "()V"));
			} finally {
			}
		}

		static Delegate cb_selectBbposEmvApplication_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetSelectBbposEmvApplication_Ljava_util_ArrayList_Handler ()
		{
			if (cb_selectBbposEmvApplication_Ljava_util_ArrayList_ == null)
				cb_selectBbposEmvApplication_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SelectBbposEmvApplication_Ljava_util_ArrayList_);
			return cb_selectBbposEmvApplication_Ljava_util_ArrayList_;
		}

		static void n_SelectBbposEmvApplication_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.PayGuardian __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SelectBbposEmvApplication (p0);
		}
#pragma warning restore 0169

		static IntPtr id_selectBbposEmvApplication_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/method[@name='selectBbposEmvApplication' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;java.lang.String&gt;']]"
		[Register ("selectBbposEmvApplication", "(Ljava/util/ArrayList;)V", "GetSelectBbposEmvApplication_Ljava_util_ArrayList_Handler")]
		public virtual unsafe void SelectBbposEmvApplication (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_selectBbposEmvApplication_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_selectBbposEmvApplication_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "selectBbposEmvApplication", "(Ljava/util/ArrayList;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_selectBbposEmvApplication_Ljava_util_ArrayList_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "selectBbposEmvApplication", "(Ljava/util/ArrayList;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendBbposEmvFinalConfirm;
#pragma warning disable 0169
		static Delegate GetSendBbposEmvFinalConfirmHandler ()
		{
			if (cb_sendBbposEmvFinalConfirm == null)
				cb_sendBbposEmvFinalConfirm = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendBbposEmvFinalConfirm);
			return cb_sendBbposEmvFinalConfirm;
		}

		static void n_SendBbposEmvFinalConfirm (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.PayGuardian __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendBbposEmvFinalConfirm ();
		}
#pragma warning restore 0169

		static IntPtr id_sendBbposEmvFinalConfirm;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/method[@name='sendBbposEmvFinalConfirm' and count(parameter)=0]"
		[Register ("sendBbposEmvFinalConfirm", "()V", "GetSendBbposEmvFinalConfirmHandler")]
		public virtual unsafe void SendBbposEmvFinalConfirm ()
		{
			if (id_sendBbposEmvFinalConfirm == IntPtr.Zero)
				id_sendBbposEmvFinalConfirm = JNIEnv.GetMethodID (class_ref, "sendBbposEmvFinalConfirm", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendBbposEmvFinalConfirm);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendBbposEmvFinalConfirm", "()V"));
			} finally {
			}
		}

		static Delegate cb_sendServerConnectivity;
#pragma warning disable 0169
		static Delegate GetSendServerConnectivityHandler ()
		{
			if (cb_sendServerConnectivity == null)
				cb_sendServerConnectivity = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendServerConnectivity);
			return cb_sendServerConnectivity;
		}

		static void n_SendServerConnectivity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.PayGuardian __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendServerConnectivity ();
		}
#pragma warning restore 0169

		static IntPtr id_sendServerConnectivity;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/method[@name='sendServerConnectivity' and count(parameter)=0]"
		[Register ("sendServerConnectivity", "()V", "GetSendServerConnectivityHandler")]
		public virtual unsafe void SendServerConnectivity ()
		{
			if (id_sendServerConnectivity == IntPtr.Zero)
				id_sendServerConnectivity = JNIEnv.GetMethodID (class_ref, "sendServerConnectivity", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendServerConnectivity);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendServerConnectivity", "()V"));
			} finally {
			}
		}

		static Delegate cb_setBbposEmvAmount;
#pragma warning disable 0169
		static Delegate GetSetBbposEmvAmountHandler ()
		{
			if (cb_setBbposEmvAmount == null)
				cb_setBbposEmvAmount = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetBbposEmvAmount);
			return cb_setBbposEmvAmount;
		}

		static void n_SetBbposEmvAmount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.PayGuardian __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBbposEmvAmount ();
		}
#pragma warning restore 0169

		static IntPtr id_setBbposEmvAmount;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/method[@name='setBbposEmvAmount' and count(parameter)=0]"
		[Register ("setBbposEmvAmount", "()V", "GetSetBbposEmvAmountHandler")]
		public virtual unsafe void SetBbposEmvAmount ()
		{
			if (id_setBbposEmvAmount == IntPtr.Zero)
				id_setBbposEmvAmount = JNIEnv.GetMethodID (class_ref, "setBbposEmvAmount", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBbposEmvAmount);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBbposEmvAmount", "()V"));
			} finally {
			}
		}

		static Delegate cb_setEmvApplication_I;
#pragma warning disable 0169
		static Delegate GetSetEmvApplication_IHandler ()
		{
			if (cb_setEmvApplication_I == null)
				cb_setEmvApplication_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetEmvApplication_I);
			return cb_setEmvApplication_I;
		}

		static void n_SetEmvApplication_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Bpn.Payguardian.Android.PayGuardian __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetEmvApplication (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setEmvApplication_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/method[@name='setEmvApplication' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setEmvApplication", "(I)V", "GetSetEmvApplication_IHandler")]
		public virtual unsafe void SetEmvApplication (int p0)
		{
			if (id_setEmvApplication_I == IntPtr.Zero)
				id_setEmvApplication_I = JNIEnv.GetMethodID (class_ref, "setEmvApplication", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEmvApplication_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEmvApplication", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setReadData_Z;
#pragma warning disable 0169
		static Delegate GetSetReadData_ZHandler ()
		{
			if (cb_setReadData_Z == null)
				cb_setReadData_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetReadData_Z);
			return cb_setReadData_Z;
		}

		static void n_SetReadData_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Bpn.Payguardian.Android.PayGuardian __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetReadData (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setReadData_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/method[@name='setReadData' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setReadData", "(Z)V", "GetSetReadData_ZHandler")]
		public virtual unsafe void SetReadData (bool p0)
		{
			if (id_setReadData_Z == IntPtr.Zero)
				id_setReadData_Z = JNIEnv.GetMethodID (class_ref, "setReadData", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setReadData_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReadData", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_showKeyed;
#pragma warning disable 0169
		static Delegate GetShowKeyedHandler ()
		{
			if (cb_showKeyed == null)
				cb_showKeyed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowKeyed);
			return cb_showKeyed;
		}

		static void n_ShowKeyed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.PayGuardian __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowKeyed ();
		}
#pragma warning restore 0169

		static IntPtr id_showKeyed;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/method[@name='showKeyed' and count(parameter)=0]"
		[Register ("showKeyed", "()V", "GetShowKeyedHandler")]
		public virtual unsafe void ShowKeyed ()
		{
			if (id_showKeyed == IntPtr.Zero)
				id_showKeyed = JNIEnv.GetMethodID (class_ref, "showKeyed", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showKeyed);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showKeyed", "()V"));
			} finally {
			}
		}

		static Delegate cb_startBbposEmv;
#pragma warning disable 0169
		static Delegate GetStartBbposEmvHandler ()
		{
			if (cb_startBbposEmv == null)
				cb_startBbposEmv = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartBbposEmv);
			return cb_startBbposEmv;
		}

		static void n_StartBbposEmv (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.PayGuardian __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartBbposEmv ();
		}
#pragma warning restore 0169

		static IntPtr id_startBbposEmv;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/method[@name='startBbposEmv' and count(parameter)=0]"
		[Register ("startBbposEmv", "()V", "GetStartBbposEmvHandler")]
		public virtual unsafe void StartBbposEmv ()
		{
			if (id_startBbposEmv == IntPtr.Zero)
				id_startBbposEmv = JNIEnv.GetMethodID (class_ref, "startBbposEmv", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startBbposEmv);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startBbposEmv", "()V"));
			} finally {
			}
		}

		static Delegate cb_transactionCompleted_Lcom_bpn_payguardian_android_model_PaymentResponse_;
#pragma warning disable 0169
		static Delegate GetTransactionCompleted_Lcom_bpn_payguardian_android_model_PaymentResponse_Handler ()
		{
			if (cb_transactionCompleted_Lcom_bpn_payguardian_android_model_PaymentResponse_ == null)
				cb_transactionCompleted_Lcom_bpn_payguardian_android_model_PaymentResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_TransactionCompleted_Lcom_bpn_payguardian_android_model_PaymentResponse_);
			return cb_transactionCompleted_Lcom_bpn_payguardian_android_model_PaymentResponse_;
		}

		static void n_TransactionCompleted_Lcom_bpn_payguardian_android_model_PaymentResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.PayGuardian __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bpn.Payguardian.Android.Model.PaymentResponse p0 = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Model.PaymentResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TransactionCompleted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_transactionCompleted_Lcom_bpn_payguardian_android_model_PaymentResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/method[@name='transactionCompleted' and count(parameter)=1 and parameter[1][@type='com.bpn.payguardian.android.model.PaymentResponse']]"
		[Register ("transactionCompleted", "(Lcom/bpn/payguardian/android/model/PaymentResponse;)V", "GetTransactionCompleted_Lcom_bpn_payguardian_android_model_PaymentResponse_Handler")]
		public virtual unsafe void TransactionCompleted (global::Com.Bpn.Payguardian.Android.Model.PaymentResponse p0)
		{
			if (id_transactionCompleted_Lcom_bpn_payguardian_android_model_PaymentResponse_ == IntPtr.Zero)
				id_transactionCompleted_Lcom_bpn_payguardian_android_model_PaymentResponse_ = JNIEnv.GetMethodID (class_ref, "transactionCompleted", "(Lcom/bpn/payguardian/android/model/PaymentResponse;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_transactionCompleted_Lcom_bpn_payguardian_android_model_PaymentResponse_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "transactionCompleted", "(Lcom/bpn/payguardian/android/model/PaymentResponse;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_unipayDeviceReady;
#pragma warning disable 0169
		static Delegate GetUnipayDeviceReadyHandler ()
		{
			if (cb_unipayDeviceReady == null)
				cb_unipayDeviceReady = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UnipayDeviceReady);
			return cb_unipayDeviceReady;
		}

		static void n_UnipayDeviceReady (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.PayGuardian __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnipayDeviceReady ();
		}
#pragma warning restore 0169

		static IntPtr id_unipayDeviceReady;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/method[@name='unipayDeviceReady' and count(parameter)=0]"
		[Register ("unipayDeviceReady", "()V", "GetUnipayDeviceReadyHandler")]
		public virtual unsafe void UnipayDeviceReady ()
		{
			if (id_unipayDeviceReady == IntPtr.Zero)
				id_unipayDeviceReady = JNIEnv.GetMethodID (class_ref, "unipayDeviceReady", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unipayDeviceReady);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unipayDeviceReady", "()V"));
			} finally {
			}
		}

		static Delegate cb_unipayDisplay_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUnipayDisplay_Ljava_lang_String_Handler ()
		{
			if (cb_unipayDisplay_Ljava_lang_String_ == null)
				cb_unipayDisplay_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnipayDisplay_Ljava_lang_String_);
			return cb_unipayDisplay_Ljava_lang_String_;
		}

		static void n_UnipayDisplay_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.PayGuardian __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnipayDisplay (p0);
		}
#pragma warning restore 0169

		static IntPtr id_unipayDisplay_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/method[@name='unipayDisplay' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unipayDisplay", "(Ljava/lang/String;)V", "GetUnipayDisplay_Ljava_lang_String_Handler")]
		public virtual unsafe void UnipayDisplay (string p0)
		{
			if (id_unipayDisplay_Ljava_lang_String_ == IntPtr.Zero)
				id_unipayDisplay_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "unipayDisplay", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unipayDisplay_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unipayDisplay", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_unipayEmvCallback_Lcom_bpn_payguardian_android_device_model_EmvDTO_;
#pragma warning disable 0169
		static Delegate GetUnipayEmvCallback_Lcom_bpn_payguardian_android_device_model_EmvDTO_Handler ()
		{
			if (cb_unipayEmvCallback_Lcom_bpn_payguardian_android_device_model_EmvDTO_ == null)
				cb_unipayEmvCallback_Lcom_bpn_payguardian_android_device_model_EmvDTO_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnipayEmvCallback_Lcom_bpn_payguardian_android_device_model_EmvDTO_);
			return cb_unipayEmvCallback_Lcom_bpn_payguardian_android_device_model_EmvDTO_;
		}

		static void n_UnipayEmvCallback_Lcom_bpn_payguardian_android_device_model_EmvDTO_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.PayGuardian __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO p0 = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnipayEmvCallback (p0);
		}
#pragma warning restore 0169

		static IntPtr id_unipayEmvCallback_Lcom_bpn_payguardian_android_device_model_EmvDTO_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/method[@name='unipayEmvCallback' and count(parameter)=1 and parameter[1][@type='com.bpn.payguardian.android.device.model.EmvDTO']]"
		[Register ("unipayEmvCallback", "(Lcom/bpn/payguardian/android/device/model/EmvDTO;)V", "GetUnipayEmvCallback_Lcom_bpn_payguardian_android_device_model_EmvDTO_Handler")]
		public virtual unsafe void UnipayEmvCallback (global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO p0)
		{
			if (id_unipayEmvCallback_Lcom_bpn_payguardian_android_device_model_EmvDTO_ == IntPtr.Zero)
				id_unipayEmvCallback_Lcom_bpn_payguardian_android_device_model_EmvDTO_ = JNIEnv.GetMethodID (class_ref, "unipayEmvCallback", "(Lcom/bpn/payguardian/android/device/model/EmvDTO;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unipayEmvCallback_Lcom_bpn_payguardian_android_device_model_EmvDTO_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unipayEmvCallback", "(Lcom/bpn/payguardian/android/device/model/EmvDTO;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_unipayEmvComplete_Lcom_bpn_payguardian_android_device_model_EmvDTO_;
#pragma warning disable 0169
		static Delegate GetUnipayEmvComplete_Lcom_bpn_payguardian_android_device_model_EmvDTO_Handler ()
		{
			if (cb_unipayEmvComplete_Lcom_bpn_payguardian_android_device_model_EmvDTO_ == null)
				cb_unipayEmvComplete_Lcom_bpn_payguardian_android_device_model_EmvDTO_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnipayEmvComplete_Lcom_bpn_payguardian_android_device_model_EmvDTO_);
			return cb_unipayEmvComplete_Lcom_bpn_payguardian_android_device_model_EmvDTO_;
		}

		static void n_UnipayEmvComplete_Lcom_bpn_payguardian_android_device_model_EmvDTO_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.PayGuardian __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO p0 = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnipayEmvComplete (p0);
		}
#pragma warning restore 0169

		static IntPtr id_unipayEmvComplete_Lcom_bpn_payguardian_android_device_model_EmvDTO_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/method[@name='unipayEmvComplete' and count(parameter)=1 and parameter[1][@type='com.bpn.payguardian.android.device.model.EmvDTO']]"
		[Register ("unipayEmvComplete", "(Lcom/bpn/payguardian/android/device/model/EmvDTO;)V", "GetUnipayEmvComplete_Lcom_bpn_payguardian_android_device_model_EmvDTO_Handler")]
		public virtual unsafe void UnipayEmvComplete (global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO p0)
		{
			if (id_unipayEmvComplete_Lcom_bpn_payguardian_android_device_model_EmvDTO_ == IntPtr.Zero)
				id_unipayEmvComplete_Lcom_bpn_payguardian_android_device_model_EmvDTO_ = JNIEnv.GetMethodID (class_ref, "unipayEmvComplete", "(Lcom/bpn/payguardian/android/device/model/EmvDTO;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unipayEmvComplete_Lcom_bpn_payguardian_android_device_model_EmvDTO_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unipayEmvComplete", "(Lcom/bpn/payguardian/android/device/model/EmvDTO;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_unipayError_Lcom_bpn_payguardian_android_exception_PayGuardianException_;
#pragma warning disable 0169
		static Delegate GetUnipayError_Lcom_bpn_payguardian_android_exception_PayGuardianException_Handler ()
		{
			if (cb_unipayError_Lcom_bpn_payguardian_android_exception_PayGuardianException_ == null)
				cb_unipayError_Lcom_bpn_payguardian_android_exception_PayGuardianException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnipayError_Lcom_bpn_payguardian_android_exception_PayGuardianException_);
			return cb_unipayError_Lcom_bpn_payguardian_android_exception_PayGuardianException_;
		}

		static void n_UnipayError_Lcom_bpn_payguardian_android_exception_PayGuardianException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.PayGuardian __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bpn.Payguardian.Android.Exception.PayGuardianException p0 = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Exception.PayGuardianException> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnipayError (p0);
		}
#pragma warning restore 0169

		static IntPtr id_unipayError_Lcom_bpn_payguardian_android_exception_PayGuardianException_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/method[@name='unipayError' and count(parameter)=1 and parameter[1][@type='com.bpn.payguardian.android.exception.PayGuardianException']]"
		[Register ("unipayError", "(Lcom/bpn/payguardian/android/exception/PayGuardianException;)V", "GetUnipayError_Lcom_bpn_payguardian_android_exception_PayGuardianException_Handler")]
		public virtual unsafe void UnipayError (global::Com.Bpn.Payguardian.Android.Exception.PayGuardianException p0)
		{
			if (id_unipayError_Lcom_bpn_payguardian_android_exception_PayGuardianException_ == IntPtr.Zero)
				id_unipayError_Lcom_bpn_payguardian_android_exception_PayGuardianException_ = JNIEnv.GetMethodID (class_ref, "unipayError", "(Lcom/bpn/payguardian/android/exception/PayGuardianException;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unipayError_Lcom_bpn_payguardian_android_exception_PayGuardianException_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unipayError", "(Lcom/bpn/payguardian/android/exception/PayGuardianException;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_unipayMsrCallback_Lcom_bpn_payguardian_android_device_model_MsrDTO_;
#pragma warning disable 0169
		static Delegate GetUnipayMsrCallback_Lcom_bpn_payguardian_android_device_model_MsrDTO_Handler ()
		{
			if (cb_unipayMsrCallback_Lcom_bpn_payguardian_android_device_model_MsrDTO_ == null)
				cb_unipayMsrCallback_Lcom_bpn_payguardian_android_device_model_MsrDTO_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnipayMsrCallback_Lcom_bpn_payguardian_android_device_model_MsrDTO_);
			return cb_unipayMsrCallback_Lcom_bpn_payguardian_android_device_model_MsrDTO_;
		}

		static void n_UnipayMsrCallback_Lcom_bpn_payguardian_android_device_model_MsrDTO_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.PayGuardian __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO p0 = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnipayMsrCallback (p0);
		}
#pragma warning restore 0169

		static IntPtr id_unipayMsrCallback_Lcom_bpn_payguardian_android_device_model_MsrDTO_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/method[@name='unipayMsrCallback' and count(parameter)=1 and parameter[1][@type='com.bpn.payguardian.android.device.model.MsrDTO']]"
		[Register ("unipayMsrCallback", "(Lcom/bpn/payguardian/android/device/model/MsrDTO;)V", "GetUnipayMsrCallback_Lcom_bpn_payguardian_android_device_model_MsrDTO_Handler")]
		public virtual unsafe void UnipayMsrCallback (global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO p0)
		{
			if (id_unipayMsrCallback_Lcom_bpn_payguardian_android_device_model_MsrDTO_ == IntPtr.Zero)
				id_unipayMsrCallback_Lcom_bpn_payguardian_android_device_model_MsrDTO_ = JNIEnv.GetMethodID (class_ref, "unipayMsrCallback", "(Lcom/bpn/payguardian/android/device/model/MsrDTO;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unipayMsrCallback_Lcom_bpn_payguardian_android_device_model_MsrDTO_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unipayMsrCallback", "(Lcom/bpn/payguardian/android/device/model/MsrDTO;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateStatus_Lcom_bpn_payguardian_android_PayGuardianStatus_;
#pragma warning disable 0169
		static Delegate GetUpdateStatus_Lcom_bpn_payguardian_android_PayGuardianStatus_Handler ()
		{
			if (cb_updateStatus_Lcom_bpn_payguardian_android_PayGuardianStatus_ == null)
				cb_updateStatus_Lcom_bpn_payguardian_android_PayGuardianStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateStatus_Lcom_bpn_payguardian_android_PayGuardianStatus_);
			return cb_updateStatus_Lcom_bpn_payguardian_android_PayGuardianStatus_;
		}

		static void n_UpdateStatus_Lcom_bpn_payguardian_android_PayGuardianStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.PayGuardian __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bpn.Payguardian.Android.PayGuardianStatus p0 = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardianStatus> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateStatus (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateStatus_Lcom_bpn_payguardian_android_PayGuardianStatus_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/method[@name='updateStatus' and count(parameter)=1 and parameter[1][@type='com.bpn.payguardian.android.PayGuardianStatus']]"
		[Register ("updateStatus", "(Lcom/bpn/payguardian/android/PayGuardianStatus;)V", "GetUpdateStatus_Lcom_bpn_payguardian_android_PayGuardianStatus_Handler")]
		public virtual unsafe void UpdateStatus (global::Com.Bpn.Payguardian.Android.PayGuardianStatus p0)
		{
			if (id_updateStatus_Lcom_bpn_payguardian_android_PayGuardianStatus_ == IntPtr.Zero)
				id_updateStatus_Lcom_bpn_payguardian_android_PayGuardianStatus_ = JNIEnv.GetMethodID (class_ref, "updateStatus", "(Lcom/bpn/payguardian/android/PayGuardianStatus;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateStatus_Lcom_bpn_payguardian_android_PayGuardianStatus_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateStatus", "(Lcom/bpn/payguardian/android/PayGuardianStatus;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateStatus_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateStatus_Ljava_lang_String_Handler ()
		{
			if (cb_updateStatus_Ljava_lang_String_ == null)
				cb_updateStatus_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateStatus_Ljava_lang_String_);
			return cb_updateStatus_Ljava_lang_String_;
		}

		static void n_UpdateStatus_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.PayGuardian __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardian> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateStatus (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateStatus_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardian']/method[@name='updateStatus' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("updateStatus", "(Ljava/lang/String;)V", "GetUpdateStatus_Ljava_lang_String_Handler")]
		public virtual unsafe void UpdateStatus (string p0)
		{
			if (id_updateStatus_Ljava_lang_String_ == IntPtr.Zero)
				id_updateStatus_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateStatus", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateStatus_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateStatus", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
