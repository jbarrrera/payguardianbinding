using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bpn.Payguardian.Android.Service.Impl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl']"
	[global::Android.Runtime.Register ("com/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl", DoNotGenerateAcw=true)]
	public partial class PaymentProcessServiceImpl : global::Java.Lang.Object, global::Com.Bpn.Payguardian.Android.Service.IPaymentProcessService, global::Com.Bpn.Payguardian.Android.Soap.IBridgeCommServiceEvents {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl']/field[@name='GATEWAY_CLIENT_INDENTIFIER']"
		[Register ("GATEWAY_CLIENT_INDENTIFIER")]
		public const string GatewayClientIndentifier = (string) "SOAP";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl']/field[@name='GATEWAY_CURRENCY_CODE']"
		[Register ("GATEWAY_CURRENCY_CODE")]
		public const string GatewayCurrencyCode = (string) "USD";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl']/field[@name='GATEWAY_HOLDER_TYPE']"
		[Register ("GATEWAY_HOLDER_TYPE")]
		public const string GatewayHolderType = (string) "P";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl']/field[@name='GATEWAY_TRANSCAT_CODE_BILLPAY']"
		[Register ("GATEWAY_TRANSCAT_CODE_BILLPAY")]
		public const string GatewayTranscatCodeBillpay = (string) "B";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl']/field[@name='GATEWAY_TRANSINDUSTRY_TYPE']"
		[Register ("GATEWAY_TRANSINDUSTRY_TYPE")]
		public const string GatewayTransindustryType = (string) "RE";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.ACCTYPE']"
		[global::Android.Runtime.Register ("com/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$ACCTYPE", DoNotGenerateAcw=true)]
		public sealed partial class ACCTYPE : global::Java.Lang.Enum {


			static IntPtr CHECK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.ACCTYPE']/field[@name='CHECK']"
			[Register ("CHECK")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.ACCTYPE Check {
				get {
					if (CHECK_jfieldId == IntPtr.Zero)
						CHECK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CHECK", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$ACCTYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CHECK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.ACCTYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CREDIT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.ACCTYPE']/field[@name='CREDIT']"
			[Register ("CREDIT")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.ACCTYPE Credit {
				get {
					if (CREDIT_jfieldId == IntPtr.Zero)
						CREDIT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREDIT", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$ACCTYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREDIT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.ACCTYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DEBIT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.ACCTYPE']/field[@name='DEBIT']"
			[Register ("DEBIT")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.ACCTYPE Debit {
				get {
					if (DEBIT_jfieldId == IntPtr.Zero)
						DEBIT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEBIT", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$ACCTYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEBIT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.ACCTYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr EBT_CASHBENEFIT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.ACCTYPE']/field[@name='EBT_CASHBENEFIT']"
			[Register ("EBT_CASHBENEFIT")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.ACCTYPE EbtCashbenefit {
				get {
					if (EBT_CASHBENEFIT_jfieldId == IntPtr.Zero)
						EBT_CASHBENEFIT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EBT_CASHBENEFIT", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$ACCTYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EBT_CASHBENEFIT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.ACCTYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr EBT_FOODSTAMP_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.ACCTYPE']/field[@name='EBT_FOODSTAMP']"
			[Register ("EBT_FOODSTAMP")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.ACCTYPE EbtFoodstamp {
				get {
					if (EBT_FOODSTAMP_jfieldId == IntPtr.Zero)
						EBT_FOODSTAMP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EBT_FOODSTAMP", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$ACCTYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EBT_FOODSTAMP_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.ACCTYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr GIFT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.ACCTYPE']/field[@name='GIFT']"
			[Register ("GIFT")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.ACCTYPE Gift {
				get {
					if (GIFT_jfieldId == IntPtr.Zero)
						GIFT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GIFT", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$ACCTYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GIFT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.ACCTYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LOYALTY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.ACCTYPE']/field[@name='LOYALTY']"
			[Register ("LOYALTY")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.ACCTYPE Loyalty {
				get {
					if (LOYALTY_jfieldId == IntPtr.Zero)
						LOYALTY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOYALTY", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$ACCTYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOYALTY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.ACCTYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SAVING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.ACCTYPE']/field[@name='SAVING']"
			[Register ("SAVING")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.ACCTYPE Saving {
				get {
					if (SAVING_jfieldId == IntPtr.Zero)
						SAVING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SAVING", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$ACCTYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SAVING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.ACCTYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$ACCTYPE", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ACCTYPE); }
			}

			internal ACCTYPE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getAccType;
			public unsafe string AccType {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.ACCTYPE']/method[@name='getAccType' and count(parameter)=0]"
				[Register ("getAccType", "()Ljava/lang/String;", "GetGetAccTypeHandler")]
				get {
					if (id_getAccType == IntPtr.Zero)
						id_getAccType = JNIEnv.GetMethodID (class_ref, "getAccType", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAccType), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.ACCTYPE']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$ACCTYPE;", "")]
			public static unsafe global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.ACCTYPE ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$ACCTYPE;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.ACCTYPE __ret = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.ACCTYPE> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.ACCTYPE']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$ACCTYPE;", "")]
			public static unsafe global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.ACCTYPE[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$ACCTYPE;");
				try {
					return (global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.ACCTYPE[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.ACCTYPE));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.HOLDERTYPE']"
		[global::Android.Runtime.Register ("com/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$HOLDERTYPE", DoNotGenerateAcw=true)]
		public sealed partial class HOLDERTYPE : global::Java.Lang.Enum {


			static IntPtr Corporate_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.HOLDERTYPE']/field[@name='Corporate']"
			[Register ("Corporate")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.HOLDERTYPE Corporate {
				get {
					if (Corporate_jfieldId == IntPtr.Zero)
						Corporate_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Corporate", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$HOLDERTYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Corporate_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.HOLDERTYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Government_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.HOLDERTYPE']/field[@name='Government']"
			[Register ("Government")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.HOLDERTYPE Government {
				get {
					if (Government_jfieldId == IntPtr.Zero)
						Government_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Government", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$HOLDERTYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Government_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.HOLDERTYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Personal_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.HOLDERTYPE']/field[@name='Personal']"
			[Register ("Personal")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.HOLDERTYPE Personal {
				get {
					if (Personal_jfieldId == IntPtr.Zero)
						Personal_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Personal", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$HOLDERTYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Personal_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.HOLDERTYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$HOLDERTYPE", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (HOLDERTYPE); }
			}

			internal HOLDERTYPE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getHolderType;
			public unsafe string HolderType {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.HOLDERTYPE']/method[@name='getHolderType' and count(parameter)=0]"
				[Register ("getHolderType", "()Ljava/lang/String;", "GetGetHolderTypeHandler")]
				get {
					if (id_getHolderType == IntPtr.Zero)
						id_getHolderType = JNIEnv.GetMethodID (class_ref, "getHolderType", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHolderType), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.HOLDERTYPE']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$HOLDERTYPE;", "")]
			public static unsafe global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.HOLDERTYPE ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$HOLDERTYPE;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.HOLDERTYPE __ret = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.HOLDERTYPE> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.HOLDERTYPE']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$HOLDERTYPE;", "")]
			public static unsafe global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.HOLDERTYPE[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$HOLDERTYPE;");
				try {
					return (global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.HOLDERTYPE[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.HOLDERTYPE));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.REQTYPE']"
		[global::Android.Runtime.Register ("com/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$REQTYPE", DoNotGenerateAcw=true)]
		public sealed partial class REQTYPE : global::Java.Lang.Enum {


			static IntPtr CAPTURE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.REQTYPE']/field[@name='CAPTURE']"
			[Register ("CAPTURE")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.REQTYPE Capture {
				get {
					if (CAPTURE_jfieldId == IntPtr.Zero)
						CAPTURE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CAPTURE", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$REQTYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CAPTURE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.REQTYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CAPTURE_ALL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.REQTYPE']/field[@name='CAPTURE_ALL']"
			[Register ("CAPTURE_ALL")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.REQTYPE CaptureAll {
				get {
					if (CAPTURE_ALL_jfieldId == IntPtr.Zero)
						CAPTURE_ALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CAPTURE_ALL", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$REQTYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CAPTURE_ALL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.REQTYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CHANGE_PASSWORD_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.REQTYPE']/field[@name='CHANGE_PASSWORD']"
			[Register ("CHANGE_PASSWORD")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.REQTYPE ChangePassword {
				get {
					if (CHANGE_PASSWORD_jfieldId == IntPtr.Zero)
						CHANGE_PASSWORD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CHANGE_PASSWORD", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$REQTYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CHANGE_PASSWORD_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.REQTYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CREDIT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.REQTYPE']/field[@name='CREDIT']"
			[Register ("CREDIT")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.REQTYPE Credit {
				get {
					if (CREDIT_jfieldId == IntPtr.Zero)
						CREDIT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREDIT", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$REQTYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREDIT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.REQTYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CREDIT_AUTH_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.REQTYPE']/field[@name='CREDIT_AUTH']"
			[Register ("CREDIT_AUTH")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.REQTYPE CreditAuth {
				get {
					if (CREDIT_AUTH_jfieldId == IntPtr.Zero)
						CREDIT_AUTH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREDIT_AUTH", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$REQTYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREDIT_AUTH_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.REQTYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr INCREMENT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.REQTYPE']/field[@name='INCREMENT']"
			[Register ("INCREMENT")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.REQTYPE Increment {
				get {
					if (INCREMENT_jfieldId == IntPtr.Zero)
						INCREMENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INCREMENT", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$REQTYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INCREMENT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.REQTYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MERCHANT_INFO_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.REQTYPE']/field[@name='MERCHANT_INFO']"
			[Register ("MERCHANT_INFO")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.REQTYPE MerchantInfo {
				get {
					if (MERCHANT_INFO_jfieldId == IntPtr.Zero)
						MERCHANT_INFO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MERCHANT_INFO", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$REQTYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MERCHANT_INFO_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.REQTYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PASSWORD_EXPIRATION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.REQTYPE']/field[@name='PASSWORD_EXPIRATION']"
			[Register ("PASSWORD_EXPIRATION")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.REQTYPE PasswordExpiration {
				get {
					if (PASSWORD_EXPIRATION_jfieldId == IntPtr.Zero)
						PASSWORD_EXPIRATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PASSWORD_EXPIRATION", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$REQTYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PASSWORD_EXPIRATION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.REQTYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr REFUND_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.REQTYPE']/field[@name='REFUND']"
			[Register ("REFUND")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.REQTYPE Refund {
				get {
					if (REFUND_jfieldId == IntPtr.Zero)
						REFUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REFUND", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$REQTYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REFUND_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.REQTYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr REVERSAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.REQTYPE']/field[@name='REVERSAL']"
			[Register ("REVERSAL")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.REQTYPE Reversal {
				get {
					if (REVERSAL_jfieldId == IntPtr.Zero)
						REVERSAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REVERSAL", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$REQTYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REVERSAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.REQTYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SALE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.REQTYPE']/field[@name='SALE']"
			[Register ("SALE")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.REQTYPE Sale {
				get {
					if (SALE_jfieldId == IntPtr.Zero)
						SALE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SALE", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$REQTYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SALE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.REQTYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SALE_AUTH_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.REQTYPE']/field[@name='SALE_AUTH']"
			[Register ("SALE_AUTH")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.REQTYPE SaleAuth {
				get {
					if (SALE_AUTH_jfieldId == IntPtr.Zero)
						SALE_AUTH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SALE_AUTH", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$REQTYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SALE_AUTH_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.REQTYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TOKENADD_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.REQTYPE']/field[@name='TOKENADD']"
			[Register ("TOKENADD")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.REQTYPE Tokenadd {
				get {
					if (TOKENADD_jfieldId == IntPtr.Zero)
						TOKENADD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TOKENADD", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$REQTYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TOKENADD_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.REQTYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TOKENMOD_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.REQTYPE']/field[@name='TOKENMOD']"
			[Register ("TOKENMOD")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.REQTYPE Tokenmod {
				get {
					if (TOKENMOD_jfieldId == IntPtr.Zero)
						TOKENMOD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TOKENMOD", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$REQTYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TOKENMOD_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.REQTYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TOKEN_SECURITY_CODE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.REQTYPE']/field[@name='TOKEN_SECURITY_CODE']"
			[Register ("TOKEN_SECURITY_CODE")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.REQTYPE TokenSecurityCode {
				get {
					if (TOKEN_SECURITY_CODE_jfieldId == IntPtr.Zero)
						TOKEN_SECURITY_CODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TOKEN_SECURITY_CODE", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$REQTYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TOKEN_SECURITY_CODE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.REQTYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VOID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.REQTYPE']/field[@name='VOID']"
			[Register ("VOID")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.REQTYPE Void {
				get {
					if (VOID_jfieldId == IntPtr.Zero)
						VOID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VOID", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$REQTYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VOID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.REQTYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$REQTYPE", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (REQTYPE); }
			}

			internal REQTYPE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getRequestType;
			public unsafe string RequestType {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.REQTYPE']/method[@name='getRequestType' and count(parameter)=0]"
				[Register ("getRequestType", "()Ljava/lang/String;", "GetGetRequestTypeHandler")]
				get {
					if (id_getRequestType == IntPtr.Zero)
						id_getRequestType = JNIEnv.GetMethodID (class_ref, "getRequestType", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequestType), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.REQTYPE']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$REQTYPE;", "")]
			public static unsafe global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.REQTYPE ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$REQTYPE;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.REQTYPE __ret = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.REQTYPE> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.REQTYPE']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$REQTYPE;", "")]
			public static unsafe global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.REQTYPE[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$REQTYPE;");
				try {
					return (global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.REQTYPE[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.REQTYPE));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.RESPONSEHEADER']"
		[global::Android.Runtime.Register ("com/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$RESPONSEHEADER", DoNotGenerateAcw=true)]
		public sealed partial class RESPONSEHEADER : global::Java.Lang.Enum {


			static IntPtr CAPTURE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.RESPONSEHEADER']/field[@name='CAPTURE']"
			[Register ("CAPTURE")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.RESPONSEHEADER Capture {
				get {
					if (CAPTURE_jfieldId == IntPtr.Zero)
						CAPTURE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CAPTURE", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$RESPONSEHEADER;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CAPTURE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.RESPONSEHEADER> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CAPTURE_ALL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.RESPONSEHEADER']/field[@name='CAPTURE_ALL']"
			[Register ("CAPTURE_ALL")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.RESPONSEHEADER CaptureAll {
				get {
					if (CAPTURE_ALL_jfieldId == IntPtr.Zero)
						CAPTURE_ALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CAPTURE_ALL", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$RESPONSEHEADER;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CAPTURE_ALL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.RESPONSEHEADER> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CHANGE_PASSWORD_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.RESPONSEHEADER']/field[@name='CHANGE_PASSWORD']"
			[Register ("CHANGE_PASSWORD")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.RESPONSEHEADER ChangePassword {
				get {
					if (CHANGE_PASSWORD_jfieldId == IntPtr.Zero)
						CHANGE_PASSWORD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CHANGE_PASSWORD", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$RESPONSEHEADER;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CHANGE_PASSWORD_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.RESPONSEHEADER> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CREDIT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.RESPONSEHEADER']/field[@name='CREDIT']"
			[Register ("CREDIT")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.RESPONSEHEADER Credit {
				get {
					if (CREDIT_jfieldId == IntPtr.Zero)
						CREDIT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREDIT", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$RESPONSEHEADER;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREDIT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.RESPONSEHEADER> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CREDIT_AUTH_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.RESPONSEHEADER']/field[@name='CREDIT_AUTH']"
			[Register ("CREDIT_AUTH")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.RESPONSEHEADER CreditAuth {
				get {
					if (CREDIT_AUTH_jfieldId == IntPtr.Zero)
						CREDIT_AUTH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREDIT_AUTH", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$RESPONSEHEADER;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREDIT_AUTH_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.RESPONSEHEADER> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MERCHANT_INFO_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.RESPONSEHEADER']/field[@name='MERCHANT_INFO']"
			[Register ("MERCHANT_INFO")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.RESPONSEHEADER MerchantInfo {
				get {
					if (MERCHANT_INFO_jfieldId == IntPtr.Zero)
						MERCHANT_INFO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MERCHANT_INFO", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$RESPONSEHEADER;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MERCHANT_INFO_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.RESPONSEHEADER> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PASSWORD_EXPIRATION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.RESPONSEHEADER']/field[@name='PASSWORD_EXPIRATION']"
			[Register ("PASSWORD_EXPIRATION")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.RESPONSEHEADER PasswordExpiration {
				get {
					if (PASSWORD_EXPIRATION_jfieldId == IntPtr.Zero)
						PASSWORD_EXPIRATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PASSWORD_EXPIRATION", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$RESPONSEHEADER;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PASSWORD_EXPIRATION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.RESPONSEHEADER> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr REFUND_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.RESPONSEHEADER']/field[@name='REFUND']"
			[Register ("REFUND")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.RESPONSEHEADER Refund {
				get {
					if (REFUND_jfieldId == IntPtr.Zero)
						REFUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REFUND", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$RESPONSEHEADER;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REFUND_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.RESPONSEHEADER> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr REVERSAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.RESPONSEHEADER']/field[@name='REVERSAL']"
			[Register ("REVERSAL")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.RESPONSEHEADER Reversal {
				get {
					if (REVERSAL_jfieldId == IntPtr.Zero)
						REVERSAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REVERSAL", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$RESPONSEHEADER;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REVERSAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.RESPONSEHEADER> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SALE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.RESPONSEHEADER']/field[@name='SALE']"
			[Register ("SALE")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.RESPONSEHEADER Sale {
				get {
					if (SALE_jfieldId == IntPtr.Zero)
						SALE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SALE", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$RESPONSEHEADER;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SALE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.RESPONSEHEADER> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SALE_AUTH_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.RESPONSEHEADER']/field[@name='SALE_AUTH']"
			[Register ("SALE_AUTH")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.RESPONSEHEADER SaleAuth {
				get {
					if (SALE_AUTH_jfieldId == IntPtr.Zero)
						SALE_AUTH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SALE_AUTH", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$RESPONSEHEADER;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SALE_AUTH_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.RESPONSEHEADER> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TOKENADD_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.RESPONSEHEADER']/field[@name='TOKENADD']"
			[Register ("TOKENADD")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.RESPONSEHEADER Tokenadd {
				get {
					if (TOKENADD_jfieldId == IntPtr.Zero)
						TOKENADD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TOKENADD", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$RESPONSEHEADER;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TOKENADD_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.RESPONSEHEADER> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TOKENMOD_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.RESPONSEHEADER']/field[@name='TOKENMOD']"
			[Register ("TOKENMOD")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.RESPONSEHEADER Tokenmod {
				get {
					if (TOKENMOD_jfieldId == IntPtr.Zero)
						TOKENMOD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TOKENMOD", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$RESPONSEHEADER;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TOKENMOD_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.RESPONSEHEADER> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TOKEN_SECURITY_CODE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.RESPONSEHEADER']/field[@name='TOKEN_SECURITY_CODE']"
			[Register ("TOKEN_SECURITY_CODE")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.RESPONSEHEADER TokenSecurityCode {
				get {
					if (TOKEN_SECURITY_CODE_jfieldId == IntPtr.Zero)
						TOKEN_SECURITY_CODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TOKEN_SECURITY_CODE", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$RESPONSEHEADER;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TOKEN_SECURITY_CODE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.RESPONSEHEADER> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VOID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.RESPONSEHEADER']/field[@name='VOID']"
			[Register ("VOID")]
			public static global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.RESPONSEHEADER Void {
				get {
					if (VOID_jfieldId == IntPtr.Zero)
						VOID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VOID", "Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$RESPONSEHEADER;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VOID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.RESPONSEHEADER> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$RESPONSEHEADER", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RESPONSEHEADER); }
			}

			internal RESPONSEHEADER (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getResponseHeaderTag;
			public unsafe string ResponseHeaderTag {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.RESPONSEHEADER']/method[@name='getResponseHeaderTag' and count(parameter)=0]"
				[Register ("getResponseHeaderTag", "()Ljava/lang/String;", "GetGetResponseHeaderTagHandler")]
				get {
					if (id_getResponseHeaderTag == IntPtr.Zero)
						id_getResponseHeaderTag = JNIEnv.GetMethodID (class_ref, "getResponseHeaderTag", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponseHeaderTag), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.RESPONSEHEADER']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$RESPONSEHEADER;", "")]
			public static unsafe global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.RESPONSEHEADER ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$RESPONSEHEADER;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.RESPONSEHEADER __ret = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.RESPONSEHEADER> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl.RESPONSEHEADER']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$RESPONSEHEADER;", "")]
			public static unsafe global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.RESPONSEHEADER[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl$RESPONSEHEADER;");
				try {
					return (global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.RESPONSEHEADER[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl.RESPONSEHEADER));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bpn/payguardian/android/service/impl/PaymentProcessServiceImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PaymentProcessServiceImpl); }
		}

		protected PaymentProcessServiceImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl']/constructor[@name='PaymentProcessServiceImpl' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PaymentProcessServiceImpl ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PaymentProcessServiceImpl)) {
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

		static IntPtr id_ctor_Lcom_bpn_payguardian_android_service_PaymentServiceEvents_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl']/constructor[@name='PaymentProcessServiceImpl' and count(parameter)=1 and parameter[1][@type='com.bpn.payguardian.android.service.PaymentServiceEvents']]"
		[Register (".ctor", "(Lcom/bpn/payguardian/android/service/PaymentServiceEvents;)V", "")]
		public unsafe PaymentProcessServiceImpl (global::Com.Bpn.Payguardian.Android.Service.IPaymentServiceEvents p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (PaymentProcessServiceImpl)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/bpn/payguardian/android/service/PaymentServiceEvents;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/bpn/payguardian/android/service/PaymentServiceEvents;)V", __args);
					return;
				}

				if (id_ctor_Lcom_bpn_payguardian_android_service_PaymentServiceEvents_ == IntPtr.Zero)
					id_ctor_Lcom_bpn_payguardian_android_service_PaymentServiceEvents_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bpn/payguardian/android/service/PaymentServiceEvents;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bpn_payguardian_android_service_PaymentServiceEvents_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_bpn_payguardian_android_service_PaymentServiceEvents_, __args);
			} finally {
			}
		}

		static Delegate cb_bridgeCommServiceCompleted_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetBridgeCommServiceCompleted_Ljava_lang_String_Handler ()
		{
			if (cb_bridgeCommServiceCompleted_Ljava_lang_String_ == null)
				cb_bridgeCommServiceCompleted_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_BridgeCommServiceCompleted_Ljava_lang_String_);
			return cb_bridgeCommServiceCompleted_Ljava_lang_String_;
		}

		static void n_BridgeCommServiceCompleted_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BridgeCommServiceCompleted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_bridgeCommServiceCompleted_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl']/method[@name='bridgeCommServiceCompleted' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("bridgeCommServiceCompleted", "(Ljava/lang/String;)V", "GetBridgeCommServiceCompleted_Ljava_lang_String_Handler")]
		public virtual unsafe void BridgeCommServiceCompleted (string p0)
		{
			if (id_bridgeCommServiceCompleted_Ljava_lang_String_ == IntPtr.Zero)
				id_bridgeCommServiceCompleted_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "bridgeCommServiceCompleted", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_bridgeCommServiceCompleted_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bridgeCommServiceCompleted", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_dollarToCent_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl']/method[@name='dollarToCent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("dollarToCent", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string DollarToCent (string p0)
		{
			if (id_dollarToCent_Ljava_lang_String_ == IntPtr.Zero)
				id_dollarToCent_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "dollarToCent", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_dollarToCent_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getGatewayDeatils_Lcom_bpn_payguardian_android_payment_PayloadRequestHeader_;
#pragma warning disable 0169
		static Delegate GetGetGatewayDeatils_Lcom_bpn_payguardian_android_payment_PayloadRequestHeader_Handler ()
		{
			if (cb_getGatewayDeatils_Lcom_bpn_payguardian_android_payment_PayloadRequestHeader_ == null)
				cb_getGatewayDeatils_Lcom_bpn_payguardian_android_payment_PayloadRequestHeader_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetGatewayDeatils_Lcom_bpn_payguardian_android_payment_PayloadRequestHeader_);
			return cb_getGatewayDeatils_Lcom_bpn_payguardian_android_payment_PayloadRequestHeader_;
		}

		static IntPtr n_GetGatewayDeatils_Lcom_bpn_payguardian_android_payment_PayloadRequestHeader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestHeader p0 = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestHeader> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetGatewayDeatils (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getGatewayDeatils_Lcom_bpn_payguardian_android_payment_PayloadRequestHeader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl']/method[@name='getGatewayDeatils' and count(parameter)=1 and parameter[1][@type='com.bpn.payguardian.android.payment.PayloadRequestHeader']]"
		[Register ("getGatewayDeatils", "(Lcom/bpn/payguardian/android/payment/PayloadRequestHeader;)Lcom/bpn/payguardian/android/payment/PayloadRequestHeader;", "GetGetGatewayDeatils_Lcom_bpn_payguardian_android_payment_PayloadRequestHeader_Handler")]
		public virtual unsafe global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestHeader GetGatewayDeatils (global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestHeader p0)
		{
			if (id_getGatewayDeatils_Lcom_bpn_payguardian_android_payment_PayloadRequestHeader_ == IntPtr.Zero)
				id_getGatewayDeatils_Lcom_bpn_payguardian_android_payment_PayloadRequestHeader_ = JNIEnv.GetMethodID (class_ref, "getGatewayDeatils", "(Lcom/bpn/payguardian/android/payment/PayloadRequestHeader;)Lcom/bpn/payguardian/android/payment/PayloadRequestHeader;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestHeader __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestHeader> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGatewayDeatils_Lcom_bpn_payguardian_android_payment_PayloadRequestHeader_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestHeader> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGatewayDeatils", "(Lcom/bpn/payguardian/android/payment/PayloadRequestHeader;)Lcom/bpn/payguardian/android/payment/PayloadRequestHeader;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
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
			global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Service.Impl.PaymentProcessServiceImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity p0 = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ProcessBridgeCommTransaction (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_processBridgeCommTransaction_Lcom_bpn_payguardian_android_entity_PaymentRequestEntity_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.service.impl']/class[@name='PaymentProcessServiceImpl']/method[@name='processBridgeCommTransaction' and count(parameter)=2 and parameter[1][@type='com.bpn.payguardian.android.entity.PaymentRequestEntity'] and parameter[2][@type='java.lang.String']]"
		[Register ("processBridgeCommTransaction", "(Lcom/bpn/payguardian/android/entity/PaymentRequestEntity;Ljava/lang/String;)V", "GetProcessBridgeCommTransaction_Lcom_bpn_payguardian_android_entity_PaymentRequestEntity_Ljava_lang_String_Handler")]
		public virtual unsafe void ProcessBridgeCommTransaction (global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity p0, string p1)
		{
			if (id_processBridgeCommTransaction_Lcom_bpn_payguardian_android_entity_PaymentRequestEntity_Ljava_lang_String_ == IntPtr.Zero)
				id_processBridgeCommTransaction_Lcom_bpn_payguardian_android_entity_PaymentRequestEntity_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "processBridgeCommTransaction", "(Lcom/bpn/payguardian/android/entity/PaymentRequestEntity;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processBridgeCommTransaction_Lcom_bpn_payguardian_android_entity_PaymentRequestEntity_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processBridgeCommTransaction", "(Lcom/bpn/payguardian/android/entity/PaymentRequestEntity;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
