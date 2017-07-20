using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bpn.Payguardian.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardianStatus']"
	[global::Android.Runtime.Register ("com/bpn/payguardian/android/PayGuardianStatus", DoNotGenerateAcw=true)]
	public sealed partial class PayGuardianStatus : global::Java.Lang.Enum {


		static IntPtr CANCELLED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardianStatus']/field[@name='CANCELLED']"
		[Register ("CANCELLED")]
		public static global::Com.Bpn.Payguardian.Android.PayGuardianStatus Cancelled {
			get {
				if (CANCELLED_jfieldId == IntPtr.Zero)
					CANCELLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CANCELLED", "Lcom/bpn/payguardian/android/PayGuardianStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CANCELLED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardianStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CARD_INSERTED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardianStatus']/field[@name='CARD_INSERTED']"
		[Register ("CARD_INSERTED")]
		public static global::Com.Bpn.Payguardian.Android.PayGuardianStatus CardInserted {
			get {
				if (CARD_INSERTED_jfieldId == IntPtr.Zero)
					CARD_INSERTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CARD_INSERTED", "Lcom/bpn/payguardian/android/PayGuardianStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CARD_INSERTED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardianStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr COMPLETED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardianStatus']/field[@name='COMPLETED']"
		[Register ("COMPLETED")]
		public static global::Com.Bpn.Payguardian.Android.PayGuardianStatus Completed {
			get {
				if (COMPLETED_jfieldId == IntPtr.Zero)
					COMPLETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMPLETED", "Lcom/bpn/payguardian/android/PayGuardianStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COMPLETED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardianStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CONNECTING_TO_TERMINAL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardianStatus']/field[@name='CONNECTING_TO_TERMINAL']"
		[Register ("CONNECTING_TO_TERMINAL")]
		public static global::Com.Bpn.Payguardian.Android.PayGuardianStatus ConnectingToTerminal {
			get {
				if (CONNECTING_TO_TERMINAL_jfieldId == IntPtr.Zero)
					CONNECTING_TO_TERMINAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONNECTING_TO_TERMINAL", "Lcom/bpn/payguardian/android/PayGuardianStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONNECTING_TO_TERMINAL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardianStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardianStatus']/field[@name='ERROR']"
		[Register ("ERROR")]
		public static global::Com.Bpn.Payguardian.Android.PayGuardianStatus Error {
			get {
				if (ERROR_jfieldId == IntPtr.Zero)
					ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR", "Lcom/bpn/payguardian/android/PayGuardianStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardianStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FATAL_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardianStatus']/field[@name='FATAL_ERROR']"
		[Register ("FATAL_ERROR")]
		public static global::Com.Bpn.Payguardian.Android.PayGuardianStatus FatalError {
			get {
				if (FATAL_ERROR_jfieldId == IntPtr.Zero)
					FATAL_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FATAL_ERROR", "Lcom/bpn/payguardian/android/PayGuardianStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FATAL_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardianStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PIN_ENTRY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardianStatus']/field[@name='PIN_ENTRY']"
		[Register ("PIN_ENTRY")]
		public static global::Com.Bpn.Payguardian.Android.PayGuardianStatus PinEntry {
			get {
				if (PIN_ENTRY_jfieldId == IntPtr.Zero)
					PIN_ENTRY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PIN_ENTRY", "Lcom/bpn/payguardian/android/PayGuardianStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PIN_ENTRY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardianStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PROCESSING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardianStatus']/field[@name='PROCESSING']"
		[Register ("PROCESSING")]
		public static global::Com.Bpn.Payguardian.Android.PayGuardianStatus Processing {
			get {
				if (PROCESSING_jfieldId == IntPtr.Zero)
					PROCESSING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROCESSING", "Lcom/bpn/payguardian/android/PayGuardianStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PROCESSING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardianStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SWIPE_CARD_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardianStatus']/field[@name='SWIPE_CARD']"
		[Register ("SWIPE_CARD")]
		public static global::Com.Bpn.Payguardian.Android.PayGuardianStatus SwipeCard {
			get {
				if (SWIPE_CARD_jfieldId == IntPtr.Zero)
					SWIPE_CARD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SWIPE_CARD", "Lcom/bpn/payguardian/android/PayGuardianStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SWIPE_CARD_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardianStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TERMINAL_MESSAGE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardianStatus']/field[@name='TERMINAL_MESSAGE']"
		[Register ("TERMINAL_MESSAGE")]
		public static global::Com.Bpn.Payguardian.Android.PayGuardianStatus TerminalMessage {
			get {
				if (TERMINAL_MESSAGE_jfieldId == IntPtr.Zero)
					TERMINAL_MESSAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TERMINAL_MESSAGE", "Lcom/bpn/payguardian/android/PayGuardianStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TERMINAL_MESSAGE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardianStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TRANSACTION_STARTED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardianStatus']/field[@name='TRANSACTION_STARTED']"
		[Register ("TRANSACTION_STARTED")]
		public static global::Com.Bpn.Payguardian.Android.PayGuardianStatus TransactionStarted {
			get {
				if (TRANSACTION_STARTED_jfieldId == IntPtr.Zero)
					TRANSACTION_STARTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRANSACTION_STARTED", "Lcom/bpn/payguardian/android/PayGuardianStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRANSACTION_STARTED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardianStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TRANSACTION_STARTING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardianStatus']/field[@name='TRANSACTION_STARTING']"
		[Register ("TRANSACTION_STARTING")]
		public static global::Com.Bpn.Payguardian.Android.PayGuardianStatus TransactionStarting {
			get {
				if (TRANSACTION_STARTING_jfieldId == IntPtr.Zero)
					TRANSACTION_STARTING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRANSACTION_STARTING", "Lcom/bpn/payguardian/android/PayGuardianStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRANSACTION_STARTING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardianStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNABLE_TO_CONNECT_TO_TERMINAL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardianStatus']/field[@name='UNABLE_TO_CONNECT_TO_TERMINAL']"
		[Register ("UNABLE_TO_CONNECT_TO_TERMINAL")]
		public static global::Com.Bpn.Payguardian.Android.PayGuardianStatus UnableToConnectToTerminal {
			get {
				if (UNABLE_TO_CONNECT_TO_TERMINAL_jfieldId == IntPtr.Zero)
					UNABLE_TO_CONNECT_TO_TERMINAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNABLE_TO_CONNECT_TO_TERMINAL", "Lcom/bpn/payguardian/android/PayGuardianStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNABLE_TO_CONNECT_TO_TERMINAL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardianStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNIPAYIII_AUTOCONFIG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardianStatus']/field[@name='UNIPAYIII_AUTOCONFIG']"
		[Register ("UNIPAYIII_AUTOCONFIG")]
		public static global::Com.Bpn.Payguardian.Android.PayGuardianStatus UnipayiiiAutoconfig {
			get {
				if (UNIPAYIII_AUTOCONFIG_jfieldId == IntPtr.Zero)
					UNIPAYIII_AUTOCONFIG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNIPAYIII_AUTOCONFIG", "Lcom/bpn/payguardian/android/PayGuardianStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNIPAYIII_AUTOCONFIG_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardianStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bpn/payguardian/android/PayGuardianStatus", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PayGuardianStatus); }
		}

		internal PayGuardianStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardianStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/PayGuardianStatus;", "")]
		public static unsafe global::Com.Bpn.Payguardian.Android.PayGuardianStatus ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/PayGuardianStatus;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Bpn.Payguardian.Android.PayGuardianStatus __ret = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardianStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android']/class[@name='PayGuardianStatus']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/bpn/payguardian/android/PayGuardianStatus;", "")]
		public static unsafe global::Com.Bpn.Payguardian.Android.PayGuardianStatus[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bpn/payguardian/android/PayGuardianStatus;");
			try {
				return (global::Com.Bpn.Payguardian.Android.PayGuardianStatus[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bpn.Payguardian.Android.PayGuardianStatus));
			} finally {
			}
		}

	}
}
