using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bpn.Payguardian.Android.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants']"
	[global::Android.Runtime.Register ("com/bpn/payguardian/android/util/DeviceServiceConstants", DoNotGenerateAcw=true)]
	public partial class DeviceServiceConstants : global::Java.Lang.Object {


		static IntPtr DEFAULT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants']/field[@name='DEFAULT']"
		[Register ("DEFAULT")]
		public string Default {
			get {
				if (DEFAULT_jfieldId == IntPtr.Zero)
					DEFAULT_jfieldId = JNIEnv.GetFieldID (class_ref, "DEFAULT", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, DEFAULT_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DEFAULT_jfieldId == IntPtr.Zero)
					DEFAULT_jfieldId = JNIEnv.GetFieldID (class_ref, "DEFAULT", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, DEFAULT_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr Display_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants']/field[@name='Display']"
		[Register ("Display")]
		public IList<int> Display {
			get {
				if (Display_jfieldId == IntPtr.Zero)
					Display_jfieldId = JNIEnv.GetFieldID (class_ref, "Display", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, Display_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (Display_jfieldId == IntPtr.Zero)
					Display_jfieldId = JNIEnv.GetFieldID (class_ref, "Display", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, Display_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr HEIGHT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants']/field[@name='HEIGHT']"
		[Register ("HEIGHT")]
		public int Height {
			get {
				if (HEIGHT_jfieldId == IntPtr.Zero)
					HEIGHT_jfieldId = JNIEnv.GetFieldID (class_ref, "HEIGHT", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, HEIGHT_jfieldId);
			}
			set {
				if (HEIGHT_jfieldId == IntPtr.Zero)
					HEIGHT_jfieldId = JNIEnv.GetFieldID (class_ref, "HEIGHT", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, HEIGHT_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr HW_ERROR_CODE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants']/field[@name='HW_ERROR_CODE']"
		[Register ("HW_ERROR_CODE")]
		public string HwErrorCode {
			get {
				if (HW_ERROR_CODE_jfieldId == IntPtr.Zero)
					HW_ERROR_CODE_jfieldId = JNIEnv.GetFieldID (class_ref, "HW_ERROR_CODE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, HW_ERROR_CODE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (HW_ERROR_CODE_jfieldId == IntPtr.Zero)
					HW_ERROR_CODE_jfieldId = JNIEnv.GetFieldID (class_ref, "HW_ERROR_CODE", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, HW_ERROR_CODE_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr HW_SUCCESS_CODE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants']/field[@name='HW_SUCCESS_CODE']"
		[Register ("HW_SUCCESS_CODE")]
		public string HwSuccessCode {
			get {
				if (HW_SUCCESS_CODE_jfieldId == IntPtr.Zero)
					HW_SUCCESS_CODE_jfieldId = JNIEnv.GetFieldID (class_ref, "HW_SUCCESS_CODE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, HW_SUCCESS_CODE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (HW_SUCCESS_CODE_jfieldId == IntPtr.Zero)
					HW_SUCCESS_CODE_jfieldId = JNIEnv.GetFieldID (class_ref, "HW_SUCCESS_CODE", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, HW_SUCCESS_CODE_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr IDTECH_SIGNPAY_MSR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants']/field[@name='IDTECH_SIGNPAY_MSR']"
		[Register ("IDTECH_SIGNPAY_MSR")]
		public string IdtechSignpayMsr {
			get {
				if (IDTECH_SIGNPAY_MSR_jfieldId == IntPtr.Zero)
					IDTECH_SIGNPAY_MSR_jfieldId = JNIEnv.GetFieldID (class_ref, "IDTECH_SIGNPAY_MSR", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, IDTECH_SIGNPAY_MSR_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (IDTECH_SIGNPAY_MSR_jfieldId == IntPtr.Zero)
					IDTECH_SIGNPAY_MSR_jfieldId = JNIEnv.GetFieldID (class_ref, "IDTECH_SIGNPAY_MSR", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, IDTECH_SIGNPAY_MSR_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr IDTECH_SIGNPAY_PP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants']/field[@name='IDTECH_SIGNPAY_PP']"
		[Register ("IDTECH_SIGNPAY_PP")]
		public string IdtechSignpayPp {
			get {
				if (IDTECH_SIGNPAY_PP_jfieldId == IntPtr.Zero)
					IDTECH_SIGNPAY_PP_jfieldId = JNIEnv.GetFieldID (class_ref, "IDTECH_SIGNPAY_PP", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, IDTECH_SIGNPAY_PP_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (IDTECH_SIGNPAY_PP_jfieldId == IntPtr.Zero)
					IDTECH_SIGNPAY_PP_jfieldId = JNIEnv.GetFieldID (class_ref, "IDTECH_SIGNPAY_PP", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, IDTECH_SIGNPAY_PP_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr IDTECH_SIGN_PAY_SC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants']/field[@name='IDTECH_SIGN_PAY_SC']"
		[Register ("IDTECH_SIGN_PAY_SC")]
		public string IdtechSignPaySc {
			get {
				if (IDTECH_SIGN_PAY_SC_jfieldId == IntPtr.Zero)
					IDTECH_SIGN_PAY_SC_jfieldId = JNIEnv.GetFieldID (class_ref, "IDTECH_SIGN_PAY_SC", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, IDTECH_SIGN_PAY_SC_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (IDTECH_SIGN_PAY_SC_jfieldId == IntPtr.Zero)
					IDTECH_SIGN_PAY_SC_jfieldId = JNIEnv.GetFieldID (class_ref, "IDTECH_SIGN_PAY_SC", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, IDTECH_SIGN_PAY_SC_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr INGENICO_ISC350_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants']/field[@name='INGENICO_ISC350']"
		[Register ("INGENICO_ISC350")]
		public string IngenicoIsc350 {
			get {
				if (INGENICO_ISC350_jfieldId == IntPtr.Zero)
					INGENICO_ISC350_jfieldId = JNIEnv.GetFieldID (class_ref, "INGENICO_ISC350", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, INGENICO_ISC350_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (INGENICO_ISC350_jfieldId == IntPtr.Zero)
					INGENICO_ISC350_jfieldId = JNIEnv.GetFieldID (class_ref, "INGENICO_ISC350", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, INGENICO_ISC350_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr INGENICO_ISC350_LD_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants']/field[@name='INGENICO_ISC350_LD']"
		[Register ("INGENICO_ISC350_LD")]
		public string IngenicoIsc350Ld {
			get {
				if (INGENICO_ISC350_LD_jfieldId == IntPtr.Zero)
					INGENICO_ISC350_LD_jfieldId = JNIEnv.GetFieldID (class_ref, "INGENICO_ISC350_LD", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, INGENICO_ISC350_LD_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (INGENICO_ISC350_LD_jfieldId == IntPtr.Zero)
					INGENICO_ISC350_LD_jfieldId = JNIEnv.GetFieldID (class_ref, "INGENICO_ISC350_LD", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, INGENICO_ISC350_LD_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr INGENICO_iSC_PREFIX_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants']/field[@name='INGENICO_iSC_PREFIX']"
		[Register ("INGENICO_iSC_PREFIX")]
		public string INGENICOISCPREFIX {
			get {
				if (INGENICO_iSC_PREFIX_jfieldId == IntPtr.Zero)
					INGENICO_iSC_PREFIX_jfieldId = JNIEnv.GetFieldID (class_ref, "INGENICO_iSC_PREFIX", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, INGENICO_iSC_PREFIX_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (INGENICO_iSC_PREFIX_jfieldId == IntPtr.Zero)
					INGENICO_iSC_PREFIX_jfieldId = JNIEnv.GetFieldID (class_ref, "INGENICO_iSC_PREFIX", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, INGENICO_iSC_PREFIX_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr ING_350_SC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants']/field[@name='ING_350_SC']"
		[Register ("ING_350_SC")]
		public string Ing350Sc {
			get {
				if (ING_350_SC_jfieldId == IntPtr.Zero)
					ING_350_SC_jfieldId = JNIEnv.GetFieldID (class_ref, "ING_350_SC", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, ING_350_SC_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ING_350_SC_jfieldId == IntPtr.Zero)
					ING_350_SC_jfieldId = JNIEnv.GetFieldID (class_ref, "ING_350_SC", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, ING_350_SC_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr ISC_350_SIG_TXT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants']/field[@name='ISC_350_SIG_TXT']"
		[Register ("ISC_350_SIG_TXT")]
		public string Isc350SigTxt {
			get {
				if (ISC_350_SIG_TXT_jfieldId == IntPtr.Zero)
					ISC_350_SIG_TXT_jfieldId = JNIEnv.GetFieldID (class_ref, "ISC_350_SIG_TXT", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, ISC_350_SIG_TXT_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ISC_350_SIG_TXT_jfieldId == IntPtr.Zero)
					ISC_350_SIG_TXT_jfieldId = JNIEnv.GetFieldID (class_ref, "ISC_350_SIG_TXT", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, ISC_350_SIG_TXT_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr MAGTEK_MINI_MICR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants']/field[@name='MAGTEK_MINI_MICR']"
		[Register ("MAGTEK_MINI_MICR")]
		public string MagtekMiniMicr {
			get {
				if (MAGTEK_MINI_MICR_jfieldId == IntPtr.Zero)
					MAGTEK_MINI_MICR_jfieldId = JNIEnv.GetFieldID (class_ref, "MAGTEK_MINI_MICR", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, MAGTEK_MINI_MICR_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (MAGTEK_MINI_MICR_jfieldId == IntPtr.Zero)
					MAGTEK_MINI_MICR_jfieldId = JNIEnv.GetFieldID (class_ref, "MAGTEK_MINI_MICR", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, MAGTEK_MINI_MICR_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr PINPAD_ENCYPTION_TYPE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants']/field[@name='PINPAD_ENCYPTION_TYPE']"
		[Register ("PINPAD_ENCYPTION_TYPE")]
		public string PinpadEncyptionType {
			get {
				if (PINPAD_ENCYPTION_TYPE_jfieldId == IntPtr.Zero)
					PINPAD_ENCYPTION_TYPE_jfieldId = JNIEnv.GetFieldID (class_ref, "PINPAD_ENCYPTION_TYPE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, PINPAD_ENCYPTION_TYPE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PINPAD_ENCYPTION_TYPE_jfieldId == IntPtr.Zero)
					PINPAD_ENCYPTION_TYPE_jfieldId = JNIEnv.GetFieldID (class_ref, "PINPAD_ENCYPTION_TYPE", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, PINPAD_ENCYPTION_TYPE_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr SIGNATURE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants']/field[@name='SIGNATURE']"
		[Register ("SIGNATURE")]
		public string Signature {
			get {
				if (SIGNATURE_jfieldId == IntPtr.Zero)
					SIGNATURE_jfieldId = JNIEnv.GetFieldID (class_ref, "SIGNATURE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, SIGNATURE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SIGNATURE_jfieldId == IntPtr.Zero)
					SIGNATURE_jfieldId = JNIEnv.GetFieldID (class_ref, "SIGNATURE", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, SIGNATURE_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr SIG_BASIC_FORM_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants']/field[@name='SIG_BASIC_FORM']"
		[Register ("SIG_BASIC_FORM")]
		public string SigBasicForm {
			get {
				if (SIG_BASIC_FORM_jfieldId == IntPtr.Zero)
					SIG_BASIC_FORM_jfieldId = JNIEnv.GetFieldID (class_ref, "SIG_BASIC_FORM", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, SIG_BASIC_FORM_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SIG_BASIC_FORM_jfieldId == IntPtr.Zero)
					SIG_BASIC_FORM_jfieldId = JNIEnv.GetFieldID (class_ref, "SIG_BASIC_FORM", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, SIG_BASIC_FORM_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr SIG_BASIC_FORM_TXT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants']/field[@name='SIG_BASIC_FORM_TXT']"
		[Register ("SIG_BASIC_FORM_TXT")]
		public string SigBasicFormTxt {
			get {
				if (SIG_BASIC_FORM_TXT_jfieldId == IntPtr.Zero)
					SIG_BASIC_FORM_TXT_jfieldId = JNIEnv.GetFieldID (class_ref, "SIG_BASIC_FORM_TXT", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, SIG_BASIC_FORM_TXT_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SIG_BASIC_FORM_TXT_jfieldId == IntPtr.Zero)
					SIG_BASIC_FORM_TXT_jfieldId = JNIEnv.GetFieldID (class_ref, "SIG_BASIC_FORM_TXT", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, SIG_BASIC_FORM_TXT_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr SIG_FORM_JPOS_KEY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants']/field[@name='SIG_FORM_JPOS_KEY']"
		[Register ("SIG_FORM_JPOS_KEY")]
		public string SigFormJposKey {
			get {
				if (SIG_FORM_JPOS_KEY_jfieldId == IntPtr.Zero)
					SIG_FORM_JPOS_KEY_jfieldId = JNIEnv.GetFieldID (class_ref, "SIG_FORM_JPOS_KEY", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, SIG_FORM_JPOS_KEY_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SIG_FORM_JPOS_KEY_jfieldId == IntPtr.Zero)
					SIG_FORM_JPOS_KEY_jfieldId = JNIEnv.GetFieldID (class_ref, "SIG_FORM_JPOS_KEY", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, SIG_FORM_JPOS_KEY_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr SIG_TYPE_BASIC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants']/field[@name='SIG_TYPE_BASIC']"
		[Register ("SIG_TYPE_BASIC")]
		public string SigTypeBasic {
			get {
				if (SIG_TYPE_BASIC_jfieldId == IntPtr.Zero)
					SIG_TYPE_BASIC_jfieldId = JNIEnv.GetFieldID (class_ref, "SIG_TYPE_BASIC", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, SIG_TYPE_BASIC_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SIG_TYPE_BASIC_jfieldId == IntPtr.Zero)
					SIG_TYPE_BASIC_jfieldId = JNIEnv.GetFieldID (class_ref, "SIG_TYPE_BASIC", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, SIG_TYPE_BASIC_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr SIG_TYPE_QUESTION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants']/field[@name='SIG_TYPE_QUESTION']"
		[Register ("SIG_TYPE_QUESTION")]
		public string SigTypeQuestion {
			get {
				if (SIG_TYPE_QUESTION_jfieldId == IntPtr.Zero)
					SIG_TYPE_QUESTION_jfieldId = JNIEnv.GetFieldID (class_ref, "SIG_TYPE_QUESTION", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, SIG_TYPE_QUESTION_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SIG_TYPE_QUESTION_jfieldId == IntPtr.Zero)
					SIG_TYPE_QUESTION_jfieldId = JNIEnv.GetFieldID (class_ref, "SIG_TYPE_QUESTION", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, SIG_TYPE_QUESTION_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr SIG_TYPE_TEXT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants']/field[@name='SIG_TYPE_TEXT']"
		[Register ("SIG_TYPE_TEXT")]
		public string SigTypeText {
			get {
				if (SIG_TYPE_TEXT_jfieldId == IntPtr.Zero)
					SIG_TYPE_TEXT_jfieldId = JNIEnv.GetFieldID (class_ref, "SIG_TYPE_TEXT", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, SIG_TYPE_TEXT_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SIG_TYPE_TEXT_jfieldId == IntPtr.Zero)
					SIG_TYPE_TEXT_jfieldId = JNIEnv.GetFieldID (class_ref, "SIG_TYPE_TEXT", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, SIG_TYPE_TEXT_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr SLEEPTIME_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants']/field[@name='SLEEPTIME']"
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

		static IntPtr VERIFONE_MX_FORM_SERVICE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants']/field[@name='VERIFONE_MX_FORM_SERVICE']"
		[Register ("VERIFONE_MX_FORM_SERVICE")]
		public string VerifoneMxFormService {
			get {
				if (VERIFONE_MX_FORM_SERVICE_jfieldId == IntPtr.Zero)
					VERIFONE_MX_FORM_SERVICE_jfieldId = JNIEnv.GetFieldID (class_ref, "VERIFONE_MX_FORM_SERVICE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, VERIFONE_MX_FORM_SERVICE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (VERIFONE_MX_FORM_SERVICE_jfieldId == IntPtr.Zero)
					VERIFONE_MX_FORM_SERVICE_jfieldId = JNIEnv.GetFieldID (class_ref, "VERIFONE_MX_FORM_SERVICE", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, VERIFONE_MX_FORM_SERVICE_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr VERIFONE_MX_PERFIX_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants']/field[@name='VERIFONE_MX_PERFIX']"
		[Register ("VERIFONE_MX_PERFIX")]
		public string VerifoneMxPerfix {
			get {
				if (VERIFONE_MX_PERFIX_jfieldId == IntPtr.Zero)
					VERIFONE_MX_PERFIX_jfieldId = JNIEnv.GetFieldID (class_ref, "VERIFONE_MX_PERFIX", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, VERIFONE_MX_PERFIX_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (VERIFONE_MX_PERFIX_jfieldId == IntPtr.Zero)
					VERIFONE_MX_PERFIX_jfieldId = JNIEnv.GetFieldID (class_ref, "VERIFONE_MX_PERFIX", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, VERIFONE_MX_PERFIX_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr WIDTH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants']/field[@name='WIDTH']"
		[Register ("WIDTH")]
		public int Width {
			get {
				if (WIDTH_jfieldId == IntPtr.Zero)
					WIDTH_jfieldId = JNIEnv.GetFieldID (class_ref, "WIDTH", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, WIDTH_jfieldId);
			}
			set {
				if (WIDTH_jfieldId == IntPtr.Zero)
					WIDTH_jfieldId = JNIEnv.GetFieldID (class_ref, "WIDTH", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, WIDTH_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr claimTimeout_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants']/field[@name='claimTimeout']"
		[Register ("claimTimeout")]
		public global::Java.Lang.Integer ClaimTimeout {
			get {
				if (claimTimeout_jfieldId == IntPtr.Zero)
					claimTimeout_jfieldId = JNIEnv.GetFieldID (class_ref, "claimTimeout", "Ljava/lang/Integer;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, claimTimeout_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (claimTimeout_jfieldId == IntPtr.Zero)
					claimTimeout_jfieldId = JNIEnv.GetFieldID (class_ref, "claimTimeout", "Ljava/lang/Integer;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, claimTimeout_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr lineDisplay_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants']/field[@name='lineDisplay']"
		[Register ("lineDisplay")]
		public int LineDisplay {
			get {
				if (lineDisplay_jfieldId == IntPtr.Zero)
					lineDisplay_jfieldId = JNIEnv.GetFieldID (class_ref, "lineDisplay", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, lineDisplay_jfieldId);
			}
			set {
				if (lineDisplay_jfieldId == IntPtr.Zero)
					lineDisplay_jfieldId = JNIEnv.GetFieldID (class_ref, "lineDisplay", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, lineDisplay_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr read_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants']/field[@name='read']"
		[Register ("read")]
		public IList<int> Read {
			get {
				if (read_jfieldId == IntPtr.Zero)
					read_jfieldId = JNIEnv.GetFieldID (class_ref, "read", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, read_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (read_jfieldId == IntPtr.Zero)
					read_jfieldId = JNIEnv.GetFieldID (class_ref, "read", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, read_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr runFileCmd_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants']/field[@name='runFileCmd']"
		[Register ("runFileCmd")]
		public int RunFileCmd {
			get {
				if (runFileCmd_jfieldId == IntPtr.Zero)
					runFileCmd_jfieldId = JNIEnv.GetFieldID (class_ref, "runFileCmd", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, runFileCmd_jfieldId);
			}
			set {
				if (runFileCmd_jfieldId == IntPtr.Zero)
					runFileCmd_jfieldId = JNIEnv.GetFieldID (class_ref, "runFileCmd", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, runFileCmd_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr setVariableCmd_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants']/field[@name='setVariableCmd']"
		[Register ("setVariableCmd")]
		public int SetVariableCmd {
			get {
				if (setVariableCmd_jfieldId == IntPtr.Zero)
					setVariableCmd_jfieldId = JNIEnv.GetFieldID (class_ref, "setVariableCmd", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, setVariableCmd_jfieldId);
			}
			set {
				if (setVariableCmd_jfieldId == IntPtr.Zero)
					setVariableCmd_jfieldId = JNIEnv.GetFieldID (class_ref, "setVariableCmd", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, setVariableCmd_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr write_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants']/field[@name='write']"
		[Register ("write")]
		public IList<int> Write {
			get {
				if (write_jfieldId == IntPtr.Zero)
					write_jfieldId = JNIEnv.GetFieldID (class_ref, "write", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, write_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (write_jfieldId == IntPtr.Zero)
					write_jfieldId = JNIEnv.GetFieldID (class_ref, "write", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, write_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.COM_PORT']"
		[global::Android.Runtime.Register ("com/bpn/payguardian/android/util/DeviceServiceConstants$COM_PORT", DoNotGenerateAcw=true)]
		public sealed partial class COM_PORT : global::Java.Lang.Enum {


			static IntPtr BAUD_RATE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.COM_PORT']/field[@name='BAUD_RATE']"
			[Register ("BAUD_RATE")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.COM_PORT BaudRate {
				get {
					if (BAUD_RATE_jfieldId == IntPtr.Zero)
						BAUD_RATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BAUD_RATE", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$COM_PORT;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BAUD_RATE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.COM_PORT> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DATA_BITS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.COM_PORT']/field[@name='DATA_BITS']"
			[Register ("DATA_BITS")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.COM_PORT DataBits {
				get {
					if (DATA_BITS_jfieldId == IntPtr.Zero)
						DATA_BITS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DATA_BITS", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$COM_PORT;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DATA_BITS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.COM_PORT> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PARITY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.COM_PORT']/field[@name='PARITY']"
			[Register ("PARITY")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.COM_PORT Parity {
				get {
					if (PARITY_jfieldId == IntPtr.Zero)
						PARITY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PARITY", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$COM_PORT;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PARITY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.COM_PORT> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PORT_NAME_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.COM_PORT']/field[@name='PORT_NAME']"
			[Register ("PORT_NAME")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.COM_PORT PortName {
				get {
					if (PORT_NAME_jfieldId == IntPtr.Zero)
						PORT_NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PORT_NAME", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$COM_PORT;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PORT_NAME_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.COM_PORT> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr STOP_BITS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.COM_PORT']/field[@name='STOP_BITS']"
			[Register ("STOP_BITS")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.COM_PORT StopBits {
				get {
					if (STOP_BITS_jfieldId == IntPtr.Zero)
						STOP_BITS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STOP_BITS", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$COM_PORT;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STOP_BITS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.COM_PORT> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bpn/payguardian/android/util/DeviceServiceConstants$COM_PORT", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (COM_PORT); }
			}

			internal COM_PORT (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getPropertyName;
			public unsafe string PropertyName {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.COM_PORT']/method[@name='getPropertyName' and count(parameter)=0]"
				[Register ("getPropertyName", "()Ljava/lang/String;", "GetGetPropertyNameHandler")]
				get {
					if (id_getPropertyName == IntPtr.Zero)
						id_getPropertyName = JNIEnv.GetMethodID (class_ref, "getPropertyName", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPropertyName), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.COM_PORT']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/util/DeviceServiceConstants$COM_PORT;", "")]
			public static unsafe global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.COM_PORT ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/util/DeviceServiceConstants$COM_PORT;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.COM_PORT __ret = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.COM_PORT> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.COM_PORT']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/bpn/payguardian/android/util/DeviceServiceConstants$COM_PORT;", "")]
			public static unsafe global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.COM_PORT[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bpn/payguardian/android/util/DeviceServiceConstants$COM_PORT;");
				try {
					return (global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.COM_PORT[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.COM_PORT));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.DEVICE_CATEGORY']"
		[global::Android.Runtime.Register ("com/bpn/payguardian/android/util/DeviceServiceConstants$DEVICE_CATEGORY", DoNotGenerateAcw=true)]
		public sealed partial class DEVICE_CATEGORY : global::Java.Lang.Enum {


			static IntPtr MANUAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.DEVICE_CATEGORY']/field[@name='MANUAL']"
			[Register ("MANUAL")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.DEVICE_CATEGORY Manual {
				get {
					if (MANUAL_jfieldId == IntPtr.Zero)
						MANUAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MANUAL", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$DEVICE_CATEGORY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MANUAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.DEVICE_CATEGORY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MICR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.DEVICE_CATEGORY']/field[@name='MICR']"
			[Register ("MICR")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.DEVICE_CATEGORY Micr {
				get {
					if (MICR_jfieldId == IntPtr.Zero)
						MICR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MICR", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$DEVICE_CATEGORY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MICR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.DEVICE_CATEGORY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MSR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.DEVICE_CATEGORY']/field[@name='MSR']"
			[Register ("MSR")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.DEVICE_CATEGORY Msr {
				get {
					if (MSR_jfieldId == IntPtr.Zero)
						MSR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MSR", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$DEVICE_CATEGORY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MSR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.DEVICE_CATEGORY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PIN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.DEVICE_CATEGORY']/field[@name='PIN']"
			[Register ("PIN")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.DEVICE_CATEGORY Pin {
				get {
					if (PIN_jfieldId == IntPtr.Zero)
						PIN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PIN", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$DEVICE_CATEGORY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PIN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.DEVICE_CATEGORY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PRINT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.DEVICE_CATEGORY']/field[@name='PRINT']"
			[Register ("PRINT")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.DEVICE_CATEGORY Print {
				get {
					if (PRINT_jfieldId == IntPtr.Zero)
						PRINT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PRINT", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$DEVICE_CATEGORY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PRINT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.DEVICE_CATEGORY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SIGN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.DEVICE_CATEGORY']/field[@name='SIGN']"
			[Register ("SIGN")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.DEVICE_CATEGORY Sign {
				get {
					if (SIGN_jfieldId == IntPtr.Zero)
						SIGN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SIGN", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$DEVICE_CATEGORY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SIGN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.DEVICE_CATEGORY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bpn/payguardian/android/util/DeviceServiceConstants$DEVICE_CATEGORY", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DEVICE_CATEGORY); }
			}

			internal DEVICE_CATEGORY (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getCategory;
			public unsafe string Category {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.DEVICE_CATEGORY']/method[@name='getCategory' and count(parameter)=0]"
				[Register ("getCategory", "()Ljava/lang/String;", "GetGetCategoryHandler")]
				get {
					if (id_getCategory == IntPtr.Zero)
						id_getCategory = JNIEnv.GetMethodID (class_ref, "getCategory", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCategory), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.DEVICE_CATEGORY']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/util/DeviceServiceConstants$DEVICE_CATEGORY;", "")]
			public static unsafe global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.DEVICE_CATEGORY ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/util/DeviceServiceConstants$DEVICE_CATEGORY;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.DEVICE_CATEGORY __ret = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.DEVICE_CATEGORY> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.DEVICE_CATEGORY']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/bpn/payguardian/android/util/DeviceServiceConstants$DEVICE_CATEGORY;", "")]
			public static unsafe global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.DEVICE_CATEGORY[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bpn/payguardian/android/util/DeviceServiceConstants$DEVICE_CATEGORY;");
				try {
					return (global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.DEVICE_CATEGORY[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.DEVICE_CATEGORY));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EBTType']"
		[global::Android.Runtime.Register ("com/bpn/payguardian/android/util/DeviceServiceConstants$EBTType", DoNotGenerateAcw=true)]
		public sealed partial class EBTType : global::Java.Lang.Enum {


			static IntPtr Cash_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EBTType']/field[@name='Cash']"
			[Register ("Cash")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EBTType Cash {
				get {
					if (Cash_jfieldId == IntPtr.Zero)
						Cash_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Cash", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EBTType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Cash_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EBTType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Food_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EBTType']/field[@name='Food']"
			[Register ("Food")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EBTType Food {
				get {
					if (Food_jfieldId == IntPtr.Zero)
						Food_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Food", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EBTType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Food_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EBTType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bpn/payguardian/android/util/DeviceServiceConstants$EBTType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (EBTType); }
			}

			internal EBTType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EBTType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EBTType;", "")]
			public static unsafe global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EBTType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EBTType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EBTType __ret = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EBTType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EBTType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EBTType;", "")]
			public static unsafe global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EBTType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EBTType;");
				try {
					return (global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EBTType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EBTType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EMV_ERROR_CODE']"
		[global::Android.Runtime.Register ("com/bpn/payguardian/android/util/DeviceServiceConstants$EMV_ERROR_CODE", DoNotGenerateAcw=true)]
		public sealed partial class EMV_ERROR_CODE : global::Java.Lang.Enum {


			static IntPtr ARRT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EMV_ERROR_CODE']/field[@name='ARRT']"
			[Register ("ARRT")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EMV_ERROR_CODE Arrt {
				get {
					if (ARRT_jfieldId == IntPtr.Zero)
						ARRT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ARRT", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EMV_ERROR_CODE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ARRT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EMV_ERROR_CODE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ARSF_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EMV_ERROR_CODE']/field[@name='ARSF']"
			[Register ("ARSF")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EMV_ERROR_CODE Arsf {
				get {
					if (ARSF_jfieldId == IntPtr.Zero)
						ARSF_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ARSF", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EMV_ERROR_CODE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ARSF_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EMV_ERROR_CODE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CABLK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EMV_ERROR_CODE']/field[@name='CABLK']"
			[Register ("CABLK")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EMV_ERROR_CODE Cablk {
				get {
					if (CABLK_jfieldId == IntPtr.Zero)
						CABLK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CABLK", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EMV_ERROR_CODE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CABLK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EMV_ERROR_CODE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CAN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EMV_ERROR_CODE']/field[@name='CAN']"
			[Register ("CAN")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EMV_ERROR_CODE Can {
				get {
					if (CAN_jfieldId == IntPtr.Zero)
						CAN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CAN", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EMV_ERROR_CODE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CAN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EMV_ERROR_CODE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CDIV_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EMV_ERROR_CODE']/field[@name='CDIV']"
			[Register ("CDIV")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EMV_ERROR_CODE Cdiv {
				get {
					if (CDIV_jfieldId == IntPtr.Zero)
						CDIV_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CDIV", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EMV_ERROR_CODE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CDIV_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EMV_ERROR_CODE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CDIVN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EMV_ERROR_CODE']/field[@name='CDIVN']"
			[Register ("CDIVN")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EMV_ERROR_CODE Cdivn {
				get {
					if (CDIVN_jfieldId == IntPtr.Zero)
						CDIVN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CDIVN", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EMV_ERROR_CODE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CDIVN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EMV_ERROR_CODE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CNSUP_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EMV_ERROR_CODE']/field[@name='CNSUP']"
			[Register ("CNSUP")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EMV_ERROR_CODE Cnsup {
				get {
					if (CNSUP_jfieldId == IntPtr.Zero)
						CNSUP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CNSUP", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EMV_ERROR_CODE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CNSUP_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EMV_ERROR_CODE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CRPRE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EMV_ERROR_CODE']/field[@name='CRPRE']"
			[Register ("CRPRE")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EMV_ERROR_CODE Crpre {
				get {
					if (CRPRE_jfieldId == IntPtr.Zero)
						CRPRE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CRPRE", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EMV_ERROR_CODE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CRPRE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EMV_ERROR_CODE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CRSF_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EMV_ERROR_CODE']/field[@name='CRSF']"
			[Register ("CRSF")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EMV_ERROR_CODE Crsf {
				get {
					if (CRSF_jfieldId == IntPtr.Zero)
						CRSF_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CRSF", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EMV_ERROR_CODE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CRSF_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EMV_ERROR_CODE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FATAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EMV_ERROR_CODE']/field[@name='FATAL']"
			[Register ("FATAL")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EMV_ERROR_CODE Fatal {
				get {
					if (FATAL_jfieldId == IntPtr.Zero)
						FATAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FATAL", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EMV_ERROR_CODE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FATAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EMV_ERROR_CODE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr T2CF_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EMV_ERROR_CODE']/field[@name='T2CF']"
			[Register ("T2CF")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EMV_ERROR_CODE T2cf {
				get {
					if (T2CF_jfieldId == IntPtr.Zero)
						T2CF_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "T2CF", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EMV_ERROR_CODE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, T2CF_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EMV_ERROR_CODE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TPSF_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EMV_ERROR_CODE']/field[@name='TPSF']"
			[Register ("TPSF")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EMV_ERROR_CODE Tpsf {
				get {
					if (TPSF_jfieldId == IntPtr.Zero)
						TPSF_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TPSF", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EMV_ERROR_CODE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TPSF_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EMV_ERROR_CODE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UITMO_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EMV_ERROR_CODE']/field[@name='UITMO']"
			[Register ("UITMO")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EMV_ERROR_CODE Uitmo {
				get {
					if (UITMO_jfieldId == IntPtr.Zero)
						UITMO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UITMO", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EMV_ERROR_CODE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UITMO_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EMV_ERROR_CODE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bpn/payguardian/android/util/DeviceServiceConstants$EMV_ERROR_CODE", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (EMV_ERROR_CODE); }
			}

			internal EMV_ERROR_CODE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getErrorCode;
			public unsafe string ErrorCode {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EMV_ERROR_CODE']/method[@name='getErrorCode' and count(parameter)=0]"
				[Register ("getErrorCode", "()Ljava/lang/String;", "GetGetErrorCodeHandler")]
				get {
					if (id_getErrorCode == IntPtr.Zero)
						id_getErrorCode = JNIEnv.GetMethodID (class_ref, "getErrorCode", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getErrorCode), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EMV_ERROR_CODE']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EMV_ERROR_CODE;", "")]
			public static unsafe global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EMV_ERROR_CODE ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EMV_ERROR_CODE;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EMV_ERROR_CODE __ret = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EMV_ERROR_CODE> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EMV_ERROR_CODE']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EMV_ERROR_CODE;", "")]
			public static unsafe global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EMV_ERROR_CODE[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EMV_ERROR_CODE;");
				try {
					return (global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EMV_ERROR_CODE[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EMV_ERROR_CODE));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvCardBin']"
		[global::Android.Runtime.Register ("com/bpn/payguardian/android/util/DeviceServiceConstants$EmvCardBin", DoNotGenerateAcw=true)]
		public sealed partial class EmvCardBin : global::Java.Lang.Enum {


			static IntPtr AMERICAN_EXPRESS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvCardBin']/field[@name='AMERICAN_EXPRESS']"
			[Register ("AMERICAN_EXPRESS")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvCardBin AmericanExpress {
				get {
					if (AMERICAN_EXPRESS_jfieldId == IntPtr.Zero)
						AMERICAN_EXPRESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AMERICAN_EXPRESS", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvCardBin;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AMERICAN_EXPRESS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvCardBin> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DISCOVER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvCardBin']/field[@name='DISCOVER']"
			[Register ("DISCOVER")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvCardBin Discover {
				get {
					if (DISCOVER_jfieldId == IntPtr.Zero)
						DISCOVER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DISCOVER", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvCardBin;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DISCOVER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvCardBin> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr INTERAC_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvCardBin']/field[@name='INTERAC']"
			[Register ("INTERAC")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvCardBin Interac {
				get {
					if (INTERAC_jfieldId == IntPtr.Zero)
						INTERAC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTERAC", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvCardBin;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INTERAC_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvCardBin> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MASTERCARD_CIRRUS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvCardBin']/field[@name='MASTERCARD_CIRRUS']"
			[Register ("MASTERCARD_CIRRUS")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvCardBin MastercardCirrus {
				get {
					if (MASTERCARD_CIRRUS_jfieldId == IntPtr.Zero)
						MASTERCARD_CIRRUS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MASTERCARD_CIRRUS", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvCardBin;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MASTERCARD_CIRRUS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvCardBin> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MASTERCARD_D_C_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvCardBin']/field[@name='MASTERCARD_D_C']"
			[Register ("MASTERCARD_D_C")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvCardBin MastercardDC {
				get {
					if (MASTERCARD_D_C_jfieldId == IntPtr.Zero)
						MASTERCARD_D_C_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MASTERCARD_D_C", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvCardBin;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MASTERCARD_D_C_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvCardBin> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MASTERCARD_MAESTRO_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvCardBin']/field[@name='MASTERCARD_MAESTRO']"
			[Register ("MASTERCARD_MAESTRO")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvCardBin MastercardMaestro {
				get {
					if (MASTERCARD_MAESTRO_jfieldId == IntPtr.Zero)
						MASTERCARD_MAESTRO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MASTERCARD_MAESTRO", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvCardBin;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MASTERCARD_MAESTRO_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvCardBin> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VISA_D_C_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvCardBin']/field[@name='VISA_D_C']"
			[Register ("VISA_D_C")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvCardBin VisaDC {
				get {
					if (VISA_D_C_jfieldId == IntPtr.Zero)
						VISA_D_C_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VISA_D_C", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvCardBin;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VISA_D_C_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvCardBin> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VISA_ELECTRON_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvCardBin']/field[@name='VISA_ELECTRON']"
			[Register ("VISA_ELECTRON")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvCardBin VisaElectron {
				get {
					if (VISA_ELECTRON_jfieldId == IntPtr.Zero)
						VISA_ELECTRON_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VISA_ELECTRON", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvCardBin;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VISA_ELECTRON_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvCardBin> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VISA_PLUS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvCardBin']/field[@name='VISA_PLUS']"
			[Register ("VISA_PLUS")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvCardBin VisaPlus {
				get {
					if (VISA_PLUS_jfieldId == IntPtr.Zero)
						VISA_PLUS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VISA_PLUS", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvCardBin;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VISA_PLUS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvCardBin> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bpn/payguardian/android/util/DeviceServiceConstants$EmvCardBin", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (EmvCardBin); }
			}

			internal EmvCardBin (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_get_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvCardBin']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("get", "(Ljava/lang/String;)Ljava/lang/String;", "")]
			public static unsafe string Get (string p0)
			{
				if (id_get_Ljava_lang_String_ == IntPtr.Zero)
					id_get_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "get", "(Ljava/lang/String;)Ljava/lang/String;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvCardBin']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvCardBin;", "")]
			public static unsafe global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvCardBin ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvCardBin;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvCardBin __ret = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvCardBin> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvCardBin']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvCardBin;", "")]
			public static unsafe global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvCardBin[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvCardBin;");
				try {
					return (global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvCardBin[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvCardBin));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']"
		[global::Android.Runtime.Register ("com/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag", DoNotGenerateAcw=true)]
		public sealed partial class EmvTag : global::Java.Lang.Enum {


			static IntPtr ACCOUNT_NUMBER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='ACCOUNT_NUMBER']"
			[Register ("ACCOUNT_NUMBER")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag AccountNumber {
				get {
					if (ACCOUNT_NUMBER_jfieldId == IntPtr.Zero)
						ACCOUNT_NUMBER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACCOUNT_NUMBER", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACCOUNT_NUMBER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ACCSEQ_NUMBER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='ACCSEQ_NUMBER']"
			[Register ("ACCSEQ_NUMBER")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag AccseqNumber {
				get {
					if (ACCSEQ_NUMBER_jfieldId == IntPtr.Zero)
						ACCSEQ_NUMBER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACCSEQ_NUMBER", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACCSEQ_NUMBER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr AID_TERMINAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='AID_TERMINAL']"
			[Register ("AID_TERMINAL")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag AidTerminal {
				get {
					if (AID_TERMINAL_jfieldId == IntPtr.Zero)
						AID_TERMINAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AID_TERMINAL", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AID_TERMINAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ALT_APP_VERSION_NUMBER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='ALT_APP_VERSION_NUMBER']"
			[Register ("ALT_APP_VERSION_NUMBER")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag AltAppVersionNumber {
				get {
					if (ALT_APP_VERSION_NUMBER_jfieldId == IntPtr.Zero)
						ALT_APP_VERSION_NUMBER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALT_APP_VERSION_NUMBER", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALT_APP_VERSION_NUMBER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr AMOUNT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='AMOUNT']"
			[Register ("AMOUNT")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag Amount {
				get {
					if (AMOUNT_jfieldId == IntPtr.Zero)
						AMOUNT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AMOUNT", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AMOUNT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr APPLICATION_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='APPLICATION_ID']"
			[Register ("APPLICATION_ID")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag ApplicationId {
				get {
					if (APPLICATION_ID_jfieldId == IntPtr.Zero)
						APPLICATION_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPLICATION_ID", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APPLICATION_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr APPLICATION_LABEL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='APPLICATION_LABEL']"
			[Register ("APPLICATION_LABEL")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag ApplicationLabel {
				get {
					if (APPLICATION_LABEL_jfieldId == IntPtr.Zero)
						APPLICATION_LABEL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPLICATION_LABEL", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APPLICATION_LABEL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr APP_CRYPTOGRAM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='APP_CRYPTOGRAM']"
			[Register ("APP_CRYPTOGRAM")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag AppCryptogram {
				get {
					if (APP_CRYPTOGRAM_jfieldId == IntPtr.Zero)
						APP_CRYPTOGRAM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_CRYPTOGRAM", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APP_CRYPTOGRAM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr APP_INTER_CHANGE_PROFILE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='APP_INTER_CHANGE_PROFILE']"
			[Register ("APP_INTER_CHANGE_PROFILE")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag AppInterChangeProfile {
				get {
					if (APP_INTER_CHANGE_PROFILE_jfieldId == IntPtr.Zero)
						APP_INTER_CHANGE_PROFILE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_INTER_CHANGE_PROFILE", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APP_INTER_CHANGE_PROFILE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr APP_TRANS_COUNTER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='APP_TRANS_COUNTER']"
			[Register ("APP_TRANS_COUNTER")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag AppTransCounter {
				get {
					if (APP_TRANS_COUNTER_jfieldId == IntPtr.Zero)
						APP_TRANS_COUNTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_TRANS_COUNTER", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APP_TRANS_COUNTER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr APP_USAGE_CTRL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='APP_USAGE_CTRL']"
			[Register ("APP_USAGE_CTRL")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag AppUsageCtrl {
				get {
					if (APP_USAGE_CTRL_jfieldId == IntPtr.Zero)
						APP_USAGE_CTRL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_USAGE_CTRL", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APP_USAGE_CTRL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr APP_VERSION_NUMBER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='APP_VERSION_NUMBER']"
			[Register ("APP_VERSION_NUMBER")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag AppVersionNumber {
				get {
					if (APP_VERSION_NUMBER_jfieldId == IntPtr.Zero)
						APP_VERSION_NUMBER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_VERSION_NUMBER", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APP_VERSION_NUMBER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr AUTH_RESPONSE_CODE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='AUTH_RESPONSE_CODE']"
			[Register ("AUTH_RESPONSE_CODE")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag AuthResponseCode {
				get {
					if (AUTH_RESPONSE_CODE_jfieldId == IntPtr.Zero)
						AUTH_RESPONSE_CODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTH_RESPONSE_CODE", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUTH_RESPONSE_CODE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CARD_HODLER_NAME_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='CARD_HODLER_NAME']"
			[Register ("CARD_HODLER_NAME")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag CardHodlerName {
				get {
					if (CARD_HODLER_NAME_jfieldId == IntPtr.Zero)
						CARD_HODLER_NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CARD_HODLER_NAME", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CARD_HODLER_NAME_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CRYPTO_INFO_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='CRYPTO_INFO']"
			[Register ("CRYPTO_INFO")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag CryptoInfo {
				get {
					if (CRYPTO_INFO_jfieldId == IntPtr.Zero)
						CRYPTO_INFO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CRYPTO_INFO", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CRYPTO_INFO_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CVM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='CVM']"
			[Register ("CVM")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag Cvm {
				get {
					if (CVM_jfieldId == IntPtr.Zero)
						CVM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CVM", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CVM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CVM_LIST_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='CVM_LIST']"
			[Register ("CVM_LIST")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag CvmList {
				get {
					if (CVM_LIST_jfieldId == IntPtr.Zero)
						CVM_LIST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CVM_LIST", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CVM_LIST_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DEVICE_SERIAL_NUM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='DEVICE_SERIAL_NUM']"
			[Register ("DEVICE_SERIAL_NUM")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag DeviceSerialNum {
				get {
					if (DEVICE_SERIAL_NUM_jfieldId == IntPtr.Zero)
						DEVICE_SERIAL_NUM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_SERIAL_NUM", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEVICE_SERIAL_NUM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ERROR_CODE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='ERROR_CODE']"
			[Register ("ERROR_CODE")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag ErrorCode {
				get {
					if (ERROR_CODE_jfieldId == IntPtr.Zero)
						ERROR_CODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR_CODE", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_CODE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr EXPIRATION_DATE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='EXPIRATION_DATE']"
			[Register ("EXPIRATION_DATE")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag ExpirationDate {
				get {
					if (EXPIRATION_DATE_jfieldId == IntPtr.Zero)
						EXPIRATION_DATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXPIRATION_DATE", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXPIRATION_DATE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FILE_NAME_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='FILE_NAME']"
			[Register ("FILE_NAME")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag FileName {
				get {
					if (FILE_NAME_jfieldId == IntPtr.Zero)
						FILE_NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FILE_NAME", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FILE_NAME_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ISSUER_COUNTRY_CODE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='ISSUER_COUNTRY_CODE']"
			[Register ("ISSUER_COUNTRY_CODE")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag IssuerCountryCode {
				get {
					if (ISSUER_COUNTRY_CODE_jfieldId == IntPtr.Zero)
						ISSUER_COUNTRY_CODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISSUER_COUNTRY_CODE", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISSUER_COUNTRY_CODE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ISSURE_ACTION_CODE_DEFAULT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='ISSURE_ACTION_CODE_DEFAULT']"
			[Register ("ISSURE_ACTION_CODE_DEFAULT")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag IssureActionCodeDefault {
				get {
					if (ISSURE_ACTION_CODE_DEFAULT_jfieldId == IntPtr.Zero)
						ISSURE_ACTION_CODE_DEFAULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISSURE_ACTION_CODE_DEFAULT", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISSURE_ACTION_CODE_DEFAULT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ISSURE_ACTION_CODE_DENIAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='ISSURE_ACTION_CODE_DENIAL']"
			[Register ("ISSURE_ACTION_CODE_DENIAL")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag IssureActionCodeDenial {
				get {
					if (ISSURE_ACTION_CODE_DENIAL_jfieldId == IntPtr.Zero)
						ISSURE_ACTION_CODE_DENIAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISSURE_ACTION_CODE_DENIAL", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISSURE_ACTION_CODE_DENIAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ISSURE_ACTION_CODE_ONLINE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='ISSURE_ACTION_CODE_ONLINE']"
			[Register ("ISSURE_ACTION_CODE_ONLINE")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag IssureActionCodeOnline {
				get {
					if (ISSURE_ACTION_CODE_ONLINE_jfieldId == IntPtr.Zero)
						ISSURE_ACTION_CODE_ONLINE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISSURE_ACTION_CODE_ONLINE", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISSURE_ACTION_CODE_ONLINE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ISSURE_APPDATA_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='ISSURE_APPDATA']"
			[Register ("ISSURE_APPDATA")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag IssureAppdata {
				get {
					if (ISSURE_APPDATA_jfieldId == IntPtr.Zero)
						ISSURE_APPDATA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISSURE_APPDATA", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISSURE_APPDATA_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LANGUAGE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='LANGUAGE']"
			[Register ("LANGUAGE")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag Language {
				get {
					if (LANGUAGE_jfieldId == IntPtr.Zero)
						LANGUAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LANGUAGE", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LANGUAGE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NON_EMVTRANS_TYPE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='NON_EMVTRANS_TYPE']"
			[Register ("NON_EMVTRANS_TYPE")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag NonEmvtransType {
				get {
					if (NON_EMVTRANS_TYPE_jfieldId == IntPtr.Zero)
						NON_EMVTRANS_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NON_EMVTRANS_TYPE", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NON_EMVTRANS_TYPE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NON_EMV_CARD_ENTRY_MODE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='NON_EMV_CARD_ENTRY_MODE']"
			[Register ("NON_EMV_CARD_ENTRY_MODE")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag NonEmvCardEntryMode {
				get {
					if (NON_EMV_CARD_ENTRY_MODE_jfieldId == IntPtr.Zero)
						NON_EMV_CARD_ENTRY_MODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NON_EMV_CARD_ENTRY_MODE", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NON_EMV_CARD_ENTRY_MODE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NON_EMV_CONFIRMATION_RESCODE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='NON_EMV_CONFIRMATION_RESCODE']"
			[Register ("NON_EMV_CONFIRMATION_RESCODE")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag NonEmvConfirmationRescode {
				get {
					if (NON_EMV_CONFIRMATION_RESCODE_jfieldId == IntPtr.Zero)
						NON_EMV_CONFIRMATION_RESCODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NON_EMV_CONFIRMATION_RESCODE", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NON_EMV_CONFIRMATION_RESCODE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NON_EMV_LANGUAGE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='NON_EMV_LANGUAGE']"
			[Register ("NON_EMV_LANGUAGE")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag NonEmvLanguage {
				get {
					if (NON_EMV_LANGUAGE_jfieldId == IntPtr.Zero)
						NON_EMV_LANGUAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NON_EMV_LANGUAGE", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NON_EMV_LANGUAGE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NON_EMV_PAY_TYPE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='NON_EMV_PAY_TYPE']"
			[Register ("NON_EMV_PAY_TYPE")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag NonEmvPayType {
				get {
					if (NON_EMV_PAY_TYPE_jfieldId == IntPtr.Zero)
						NON_EMV_PAY_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NON_EMV_PAY_TYPE", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NON_EMV_PAY_TYPE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr OTHER_AMOUNT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='OTHER_AMOUNT']"
			[Register ("OTHER_AMOUNT")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag OtherAmount {
				get {
					if (OTHER_AMOUNT_jfieldId == IntPtr.Zero)
						OTHER_AMOUNT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OTHER_AMOUNT", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OTHER_AMOUNT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SERVICE_CODE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='SERVICE_CODE']"
			[Register ("SERVICE_CODE")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag ServiceCode {
				get {
					if (SERVICE_CODE_jfieldId == IntPtr.Zero)
						SERVICE_CODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SERVICE_CODE", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SERVICE_CODE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TERMINAL_CAP_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='TERMINAL_CAP']"
			[Register ("TERMINAL_CAP")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag TerminalCap {
				get {
					if (TERMINAL_CAP_jfieldId == IntPtr.Zero)
						TERMINAL_CAP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TERMINAL_CAP", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TERMINAL_CAP_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TERMINAL_COUNTRY_CODE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='TERMINAL_COUNTRY_CODE']"
			[Register ("TERMINAL_COUNTRY_CODE")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag TerminalCountryCode {
				get {
					if (TERMINAL_COUNTRY_CODE_jfieldId == IntPtr.Zero)
						TERMINAL_COUNTRY_CODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TERMINAL_COUNTRY_CODE", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TERMINAL_COUNTRY_CODE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TERMINAL_RESULTS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='TERMINAL_RESULTS']"
			[Register ("TERMINAL_RESULTS")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag TerminalResults {
				get {
					if (TERMINAL_RESULTS_jfieldId == IntPtr.Zero)
						TERMINAL_RESULTS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TERMINAL_RESULTS", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TERMINAL_RESULTS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TERMINAL_TYPE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='TERMINAL_TYPE']"
			[Register ("TERMINAL_TYPE")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag TerminalType {
				get {
					if (TERMINAL_TYPE_jfieldId == IntPtr.Zero)
						TERMINAL_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TERMINAL_TYPE", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TERMINAL_TYPE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TRACK3_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='TRACK3']"
			[Register ("TRACK3")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag Track3 {
				get {
					if (TRACK3_jfieldId == IntPtr.Zero)
						TRACK3_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRACK3", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRACK3_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TRACK_2_DATA_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='TRACK_2_DATA']"
			[Register ("TRACK_2_DATA")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag Track2Data {
				get {
					if (TRACK_2_DATA_jfieldId == IntPtr.Zero)
						TRACK_2_DATA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRACK_2_DATA", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRACK_2_DATA_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TRANSACTION_TIME_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='TRANSACTION_TIME']"
			[Register ("TRANSACTION_TIME")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag TransactionTime {
				get {
					if (TRANSACTION_TIME_jfieldId == IntPtr.Zero)
						TRANSACTION_TIME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRANSACTION_TIME", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRANSACTION_TIME_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TRANS_CATEGORY_CODE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='TRANS_CATEGORY_CODE']"
			[Register ("TRANS_CATEGORY_CODE")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag TransCategoryCode {
				get {
					if (TRANS_CATEGORY_CODE_jfieldId == IntPtr.Zero)
						TRANS_CATEGORY_CODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRANS_CATEGORY_CODE", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRANS_CATEGORY_CODE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TRANS_CURR_CODE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='TRANS_CURR_CODE']"
			[Register ("TRANS_CURR_CODE")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag TransCurrCode {
				get {
					if (TRANS_CURR_CODE_jfieldId == IntPtr.Zero)
						TRANS_CURR_CODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRANS_CURR_CODE", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRANS_CURR_CODE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TRANS_DATE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='TRANS_DATE']"
			[Register ("TRANS_DATE")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag TransDate {
				get {
					if (TRANS_DATE_jfieldId == IntPtr.Zero)
						TRANS_DATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRANS_DATE", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRANS_DATE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TRANS_INFO_STATUS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='TRANS_INFO_STATUS']"
			[Register ("TRANS_INFO_STATUS")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag TransInfoStatus {
				get {
					if (TRANS_INFO_STATUS_jfieldId == IntPtr.Zero)
						TRANS_INFO_STATUS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRANS_INFO_STATUS", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRANS_INFO_STATUS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TRANS_SEQ_COUNTER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='TRANS_SEQ_COUNTER']"
			[Register ("TRANS_SEQ_COUNTER")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag TransSeqCounter {
				get {
					if (TRANS_SEQ_COUNTER_jfieldId == IntPtr.Zero)
						TRANS_SEQ_COUNTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRANS_SEQ_COUNTER", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRANS_SEQ_COUNTER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TRANS_TYPE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='TRANS_TYPE']"
			[Register ("TRANS_TYPE")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag TransType {
				get {
					if (TRANS_TYPE_jfieldId == IntPtr.Zero)
						TRANS_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRANS_TYPE", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRANS_TYPE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UN_PREDICT_NUMBER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/field[@name='UN_PREDICT_NUMBER']"
			[Register ("UN_PREDICT_NUMBER")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag UnPredictNumber {
				get {
					if (UN_PREDICT_NUMBER_jfieldId == IntPtr.Zero)
						UN_PREDICT_NUMBER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UN_PREDICT_NUMBER", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UN_PREDICT_NUMBER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (EmvTag); }
			}

			internal EmvTag (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getPropertyName;
			public unsafe string PropertyName {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/method[@name='getPropertyName' and count(parameter)=0]"
				[Register ("getPropertyName", "()Ljava/lang/String;", "GetGetPropertyNameHandler")]
				get {
					if (id_getPropertyName == IntPtr.Zero)
						id_getPropertyName = JNIEnv.GetMethodID (class_ref, "getPropertyName", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPropertyName), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;", "")]
			public static unsafe global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag __ret = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.EmvTag']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;", "")]
			public static unsafe global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bpn/payguardian/android/util/DeviceServiceConstants$EmvTag;");
				try {
					return (global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.EmvTag));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.OnScreenGraphic']"
		[global::Android.Runtime.Register ("com/bpn/payguardian/android/util/DeviceServiceConstants$OnScreenGraphic", DoNotGenerateAcw=true)]
		public sealed partial class OnScreenGraphic : global::Java.Lang.Enum {


			static IntPtr Blank_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.OnScreenGraphic']/field[@name='Blank']"
			[Register ("Blank")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic Blank {
				get {
					if (Blank_jfieldId == IntPtr.Zero)
						Blank_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Blank", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$OnScreenGraphic;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Blank_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CashBack_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.OnScreenGraphic']/field[@name='CashBack']"
			[Register ("CashBack")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic CashBack {
				get {
					if (CashBack_jfieldId == IntPtr.Zero)
						CashBack_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CashBack", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$OnScreenGraphic;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CashBack_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Credit_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.OnScreenGraphic']/field[@name='Credit']"
			[Register ("Credit")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic Credit {
				get {
					if (Credit_jfieldId == IntPtr.Zero)
						Credit_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Credit", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$OnScreenGraphic;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Credit_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Custom_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.OnScreenGraphic']/field[@name='Custom']"
			[Register ("Custom")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic Custom {
				get {
					if (Custom_jfieldId == IntPtr.Zero)
						Custom_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Custom", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$OnScreenGraphic;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Custom_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr EBTType_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.OnScreenGraphic']/field[@name='EBTType']"
			[Register ("EBTType")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic EBTType {
				get {
					if (EBTType_jfieldId == IntPtr.Zero)
						EBTType_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EBTType", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$OnScreenGraphic;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EBTType_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LineDisplay_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.OnScreenGraphic']/field[@name='LineDisplay']"
			[Register ("LineDisplay")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic LineDisplay {
				get {
					if (LineDisplay_jfieldId == IntPtr.Zero)
						LineDisplay_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LineDisplay", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$OnScreenGraphic;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LineDisplay_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PleaseWait_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.OnScreenGraphic']/field[@name='PleaseWait']"
			[Register ("PleaseWait")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic PleaseWait {
				get {
					if (PleaseWait_jfieldId == IntPtr.Zero)
						PleaseWait_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PleaseWait", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$OnScreenGraphic;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PleaseWait_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr RxCounsel_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.OnScreenGraphic']/field[@name='RxCounsel']"
			[Register ("RxCounsel")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic RxCounsel {
				get {
					if (RxCounsel_jfieldId == IntPtr.Zero)
						RxCounsel_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RxCounsel", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$OnScreenGraphic;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RxCounsel_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr RxRelation_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.OnScreenGraphic']/field[@name='RxRelation']"
			[Register ("RxRelation")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic RxRelation {
				get {
					if (RxRelation_jfieldId == IntPtr.Zero)
						RxRelation_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RxRelation", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$OnScreenGraphic;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RxRelation_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr RxRelation1_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.OnScreenGraphic']/field[@name='RxRelation1']"
			[Register ("RxRelation1")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic RxRelation1 {
				get {
					if (RxRelation1_jfieldId == IntPtr.Zero)
						RxRelation1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RxRelation1", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$OnScreenGraphic;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RxRelation1_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr RxYesNo_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.OnScreenGraphic']/field[@name='RxYesNo']"
			[Register ("RxYesNo")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic RxYesNo {
				get {
					if (RxYesNo_jfieldId == IntPtr.Zero)
						RxYesNo_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RxYesNo", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$OnScreenGraphic;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RxYesNo_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SetCustomScreen_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.OnScreenGraphic']/field[@name='SetCustomScreen']"
			[Register ("SetCustomScreen")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic SetCustomScreen {
				get {
					if (SetCustomScreen_jfieldId == IntPtr.Zero)
						SetCustomScreen_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SetCustomScreen", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$OnScreenGraphic;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SetCustomScreen_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SigCap_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.OnScreenGraphic']/field[@name='SigCap']"
			[Register ("SigCap")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic SigCap {
				get {
					if (SigCap_jfieldId == IntPtr.Zero)
						SigCap_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SigCap", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$OnScreenGraphic;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SigCap_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SigCapText_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.OnScreenGraphic']/field[@name='SigCapText']"
			[Register ("SigCapText")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic SigCapText {
				get {
					if (SigCapText_jfieldId == IntPtr.Zero)
						SigCapText_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SigCapText", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$OnScreenGraphic;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SigCapText_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SigCapTextYesNo_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.OnScreenGraphic']/field[@name='SigCapTextYesNo']"
			[Register ("SigCapTextYesNo")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic SigCapTextYesNo {
				get {
					if (SigCapTextYesNo_jfieldId == IntPtr.Zero)
						SigCapTextYesNo_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SigCapTextYesNo", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$OnScreenGraphic;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SigCapTextYesNo_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Swipe_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.OnScreenGraphic']/field[@name='Swipe']"
			[Register ("Swipe")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic Swipe {
				get {
					if (Swipe_jfieldId == IntPtr.Zero)
						Swipe_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Swipe", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$OnScreenGraphic;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Swipe_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Tender_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.OnScreenGraphic']/field[@name='Tender']"
			[Register ("Tender")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic Tender {
				get {
					if (Tender_jfieldId == IntPtr.Zero)
						Tender_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Tender", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$OnScreenGraphic;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Tender_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Unknown_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.OnScreenGraphic']/field[@name='Unknown']"
			[Register ("Unknown")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic Unknown {
				get {
					if (Unknown_jfieldId == IntPtr.Zero)
						Unknown_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Unknown", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$OnScreenGraphic;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Unknown_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Wait_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.OnScreenGraphic']/field[@name='Wait']"
			[Register ("Wait")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic Wait {
				get {
					if (Wait_jfieldId == IntPtr.Zero)
						Wait_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Wait", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$OnScreenGraphic;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Wait_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bpn/payguardian/android/util/DeviceServiceConstants$OnScreenGraphic", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (OnScreenGraphic); }
			}

			internal OnScreenGraphic (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.OnScreenGraphic']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/util/DeviceServiceConstants$OnScreenGraphic;", "")]
			public static unsafe global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/util/DeviceServiceConstants$OnScreenGraphic;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic __ret = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.OnScreenGraphic']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/bpn/payguardian/android/util/DeviceServiceConstants$OnScreenGraphic;", "")]
			public static unsafe global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bpn/payguardian/android/util/DeviceServiceConstants$OnScreenGraphic;");
				try {
					return (global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.OnScreenGraphic));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.RxCounsel']"
		[global::Android.Runtime.Register ("com/bpn/payguardian/android/util/DeviceServiceConstants$RxCounsel", DoNotGenerateAcw=true)]
		public sealed partial class RxCounsel : global::Java.Lang.Enum {


			static IntPtr BACK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.RxCounsel']/field[@name='BACK']"
			[Register ("BACK")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxCounsel Back {
				get {
					if (BACK_jfieldId == IntPtr.Zero)
						BACK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BACK", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$RxCounsel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BACK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxCounsel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr COMMONUSE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.RxCounsel']/field[@name='COMMONUSE']"
			[Register ("COMMONUSE")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxCounsel Commonuse {
				get {
					if (COMMONUSE_jfieldId == IntPtr.Zero)
						COMMONUSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMMONUSE", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$RxCounsel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COMMONUSE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxCounsel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr HOWTO_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.RxCounsel']/field[@name='HOWTO']"
			[Register ("HOWTO")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxCounsel Howto {
				get {
					if (HOWTO_jfieldId == IntPtr.Zero)
						HOWTO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HOWTO", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$RxCounsel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HOWTO_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxCounsel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NEXT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.RxCounsel']/field[@name='NEXT']"
			[Register ("NEXT")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxCounsel Next {
				get {
					if (NEXT_jfieldId == IntPtr.Zero)
						NEXT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NEXT", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$RxCounsel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NEXT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxCounsel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PHARAMICST_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.RxCounsel']/field[@name='PHARAMICST']"
			[Register ("PHARAMICST")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxCounsel Pharamicst {
				get {
					if (PHARAMICST_jfieldId == IntPtr.Zero)
						PHARAMICST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PHARAMICST", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$RxCounsel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PHARAMICST_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxCounsel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SIDEEFFECTS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.RxCounsel']/field[@name='SIDEEFFECTS']"
			[Register ("SIDEEFFECTS")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxCounsel Sideeffects {
				get {
					if (SIDEEFFECTS_jfieldId == IntPtr.Zero)
						SIDEEFFECTS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SIDEEFFECTS", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$RxCounsel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SIDEEFFECTS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxCounsel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SKIP_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.RxCounsel']/field[@name='SKIP']"
			[Register ("SKIP")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxCounsel Skip {
				get {
					if (SKIP_jfieldId == IntPtr.Zero)
						SKIP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SKIP", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$RxCounsel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SKIP_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxCounsel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr WARNINGS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.RxCounsel']/field[@name='WARNINGS']"
			[Register ("WARNINGS")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxCounsel Warnings {
				get {
					if (WARNINGS_jfieldId == IntPtr.Zero)
						WARNINGS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WARNINGS", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$RxCounsel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WARNINGS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxCounsel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bpn/payguardian/android/util/DeviceServiceConstants$RxCounsel", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RxCounsel); }
			}

			internal RxCounsel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getRxCounsel;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.RxCounsel']/method[@name='getRxCounsel' and count(parameter)=0]"
			[Register ("getRxCounsel", "()Ljava/lang/String;", "")]
			public unsafe string GetRxCounsel ()
			{
				if (id_getRxCounsel == IntPtr.Zero)
					id_getRxCounsel = JNIEnv.GetMethodID (class_ref, "getRxCounsel", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRxCounsel), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.RxCounsel']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/util/DeviceServiceConstants$RxCounsel;", "")]
			public static unsafe global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxCounsel ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/util/DeviceServiceConstants$RxCounsel;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxCounsel __ret = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxCounsel> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.RxCounsel']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/bpn/payguardian/android/util/DeviceServiceConstants$RxCounsel;", "")]
			public static unsafe global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxCounsel[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bpn/payguardian/android/util/DeviceServiceConstants$RxCounsel;");
				try {
					return (global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxCounsel[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxCounsel));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.RxRelation']"
		[global::Android.Runtime.Register ("com/bpn/payguardian/android/util/DeviceServiceConstants$RxRelation", DoNotGenerateAcw=true)]
		public sealed partial class RxRelation : global::Java.Lang.Enum {


			static IntPtr CAREGIVER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.RxRelation']/field[@name='CAREGIVER']"
			[Register ("CAREGIVER")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxRelation Caregiver {
				get {
					if (CAREGIVER_jfieldId == IntPtr.Zero)
						CAREGIVER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CAREGIVER", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$RxRelation;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CAREGIVER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxRelation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CHILD_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.RxRelation']/field[@name='CHILD']"
			[Register ("CHILD")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxRelation Child {
				get {
					if (CHILD_jfieldId == IntPtr.Zero)
						CHILD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CHILD", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$RxRelation;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CHILD_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxRelation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr OTHER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.RxRelation']/field[@name='OTHER']"
			[Register ("OTHER")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxRelation Other {
				get {
					if (OTHER_jfieldId == IntPtr.Zero)
						OTHER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OTHER", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$RxRelation;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OTHER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxRelation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PARENT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.RxRelation']/field[@name='PARENT']"
			[Register ("PARENT")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxRelation Parent {
				get {
					if (PARENT_jfieldId == IntPtr.Zero)
						PARENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PARENT", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$RxRelation;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PARENT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxRelation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PATIENT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.RxRelation']/field[@name='PATIENT']"
			[Register ("PATIENT")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxRelation Patient {
				get {
					if (PATIENT_jfieldId == IntPtr.Zero)
						PATIENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PATIENT", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$RxRelation;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PATIENT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxRelation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr POWEROFATTORNEY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.RxRelation']/field[@name='POWEROFATTORNEY']"
			[Register ("POWEROFATTORNEY")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxRelation Powerofattorney {
				get {
					if (POWEROFATTORNEY_jfieldId == IntPtr.Zero)
						POWEROFATTORNEY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POWEROFATTORNEY", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$RxRelation;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, POWEROFATTORNEY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxRelation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SPOUSE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.RxRelation']/field[@name='SPOUSE']"
			[Register ("SPOUSE")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxRelation Spouse {
				get {
					if (SPOUSE_jfieldId == IntPtr.Zero)
						SPOUSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPOUSE", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$RxRelation;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SPOUSE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxRelation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bpn/payguardian/android/util/DeviceServiceConstants$RxRelation", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RxRelation); }
			}

			internal RxRelation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getRxRelation;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.RxRelation']/method[@name='getRxRelation' and count(parameter)=0]"
			[Register ("getRxRelation", "()Ljava/lang/String;", "")]
			public unsafe string GetRxRelation ()
			{
				if (id_getRxRelation == IntPtr.Zero)
					id_getRxRelation = JNIEnv.GetMethodID (class_ref, "getRxRelation", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRxRelation), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.RxRelation']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/util/DeviceServiceConstants$RxRelation;", "")]
			public static unsafe global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxRelation ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/util/DeviceServiceConstants$RxRelation;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxRelation __ret = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxRelation> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.RxRelation']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/bpn/payguardian/android/util/DeviceServiceConstants$RxRelation;", "")]
			public static unsafe global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxRelation[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bpn/payguardian/android/util/DeviceServiceConstants$RxRelation;");
				try {
					return (global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxRelation[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.RxRelation));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.STATUS']"
		[global::Android.Runtime.Register ("com/bpn/payguardian/android/util/DeviceServiceConstants$STATUS", DoNotGenerateAcw=true)]
		public sealed partial class STATUS : global::Java.Lang.Enum {


			static IntPtr BAD_READ_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.STATUS']/field[@name='BAD_READ']"
			[Register ("BAD_READ")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.STATUS BadRead {
				get {
					if (BAD_READ_jfieldId == IntPtr.Zero)
						BAD_READ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BAD_READ", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$STATUS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BAD_READ_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.STATUS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DATA_PARSE_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.STATUS']/field[@name='DATA_PARSE_ERROR']"
			[Register ("DATA_PARSE_ERROR")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.STATUS DataParseError {
				get {
					if (DATA_PARSE_ERROR_jfieldId == IntPtr.Zero)
						DATA_PARSE_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DATA_PARSE_ERROR", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$STATUS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DATA_PARSE_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.STATUS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DEVICE_FORM_PATH_NOTFOUND_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.STATUS']/field[@name='DEVICE_FORM_PATH_NOTFOUND']"
			[Register ("DEVICE_FORM_PATH_NOTFOUND")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.STATUS DeviceFormPathNotfound {
				get {
					if (DEVICE_FORM_PATH_NOTFOUND_jfieldId == IntPtr.Zero)
						DEVICE_FORM_PATH_NOTFOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_FORM_PATH_NOTFOUND", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$STATUS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEVICE_FORM_PATH_NOTFOUND_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.STATUS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DEVICE_FORM_PROMT_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.STATUS']/field[@name='DEVICE_FORM_PROMT_ERROR']"
			[Register ("DEVICE_FORM_PROMT_ERROR")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.STATUS DeviceFormPromtError {
				get {
					if (DEVICE_FORM_PROMT_ERROR_jfieldId == IntPtr.Zero)
						DEVICE_FORM_PROMT_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_FORM_PROMT_ERROR", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$STATUS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEVICE_FORM_PROMT_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.STATUS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DEVICE_FORM_PUSH_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.STATUS']/field[@name='DEVICE_FORM_PUSH_ERROR']"
			[Register ("DEVICE_FORM_PUSH_ERROR")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.STATUS DeviceFormPushError {
				get {
					if (DEVICE_FORM_PUSH_ERROR_jfieldId == IntPtr.Zero)
						DEVICE_FORM_PUSH_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_FORM_PUSH_ERROR", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$STATUS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEVICE_FORM_PUSH_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.STATUS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DEVICE_LINE_DISPLAY_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.STATUS']/field[@name='DEVICE_LINE_DISPLAY_ERROR']"
			[Register ("DEVICE_LINE_DISPLAY_ERROR")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.STATUS DeviceLineDisplayError {
				get {
					if (DEVICE_LINE_DISPLAY_ERROR_jfieldId == IntPtr.Zero)
						DEVICE_LINE_DISPLAY_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_LINE_DISPLAY_ERROR", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$STATUS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEVICE_LINE_DISPLAY_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.STATUS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DEVICE_NOT_CONFIGURED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.STATUS']/field[@name='DEVICE_NOT_CONFIGURED']"
			[Register ("DEVICE_NOT_CONFIGURED")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.STATUS DeviceNotConfigured {
				get {
					if (DEVICE_NOT_CONFIGURED_jfieldId == IntPtr.Zero)
						DEVICE_NOT_CONFIGURED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_NOT_CONFIGURED", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$STATUS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEVICE_NOT_CONFIGURED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.STATUS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DEVICE_SIG_CAP_USER_CANCELLED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.STATUS']/field[@name='DEVICE_SIG_CAP_USER_CANCELLED']"
			[Register ("DEVICE_SIG_CAP_USER_CANCELLED")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.STATUS DeviceSigCapUserCancelled {
				get {
					if (DEVICE_SIG_CAP_USER_CANCELLED_jfieldId == IntPtr.Zero)
						DEVICE_SIG_CAP_USER_CANCELLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_SIG_CAP_USER_CANCELLED", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$STATUS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEVICE_SIG_CAP_USER_CANCELLED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.STATUS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DEVICE_SIG_CAP_USER_IGNORED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.STATUS']/field[@name='DEVICE_SIG_CAP_USER_IGNORED']"
			[Register ("DEVICE_SIG_CAP_USER_IGNORED")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.STATUS DeviceSigCapUserIgnored {
				get {
					if (DEVICE_SIG_CAP_USER_IGNORED_jfieldId == IntPtr.Zero)
						DEVICE_SIG_CAP_USER_IGNORED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_SIG_CAP_USER_IGNORED", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$STATUS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEVICE_SIG_CAP_USER_IGNORED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.STATUS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DIRECT_IO_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.STATUS']/field[@name='DIRECT_IO_ERROR']"
			[Register ("DIRECT_IO_ERROR")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.STATUS DirectIoError {
				get {
					if (DIRECT_IO_ERROR_jfieldId == IntPtr.Zero)
						DIRECT_IO_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DIRECT_IO_ERROR", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$STATUS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DIRECT_IO_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.STATUS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.STATUS']/field[@name='ERROR']"
			[Register ("ERROR")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.STATUS Error {
				get {
					if (ERROR_jfieldId == IntPtr.Zero)
						ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$STATUS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.STATUS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SUCCESS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.STATUS']/field[@name='SUCCESS']"
			[Register ("SUCCESS")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.STATUS Success {
				get {
					if (SUCCESS_jfieldId == IntPtr.Zero)
						SUCCESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUCCESS", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$STATUS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUCCESS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.STATUS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bpn/payguardian/android/util/DeviceServiceConstants$STATUS", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (STATUS); }
			}

			internal STATUS (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.STATUS']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/util/DeviceServiceConstants$STATUS;", "")]
			public static unsafe global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.STATUS ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/util/DeviceServiceConstants$STATUS;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.STATUS __ret = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.STATUS> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.STATUS']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/bpn/payguardian/android/util/DeviceServiceConstants$STATUS;", "")]
			public static unsafe global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.STATUS[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bpn/payguardian/android/util/DeviceServiceConstants$STATUS;");
				try {
					return (global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.STATUS[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.STATUS));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.Tender']"
		[global::Android.Runtime.Register ("com/bpn/payguardian/android/util/DeviceServiceConstants$Tender", DoNotGenerateAcw=true)]
		public sealed partial class Tender : global::Java.Lang.Enum {


			static IntPtr Credit_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.Tender']/field[@name='Credit']"
			[Register ("Credit")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.Tender Credit {
				get {
					if (Credit_jfieldId == IntPtr.Zero)
						Credit_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Credit", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$Tender;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Credit_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.Tender> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Debit_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.Tender']/field[@name='Debit']"
			[Register ("Debit")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.Tender Debit {
				get {
					if (Debit_jfieldId == IntPtr.Zero)
						Debit_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Debit", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$Tender;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Debit_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.Tender> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr EBT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.Tender']/field[@name='EBT']"
			[Register ("EBT")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.Tender Ebt {
				get {
					if (EBT_jfieldId == IntPtr.Zero)
						EBT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EBT", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$Tender;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EBT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.Tender> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Gift_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.Tender']/field[@name='Gift']"
			[Register ("Gift")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.Tender Gift {
				get {
					if (Gift_jfieldId == IntPtr.Zero)
						Gift_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Gift", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$Tender;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Gift_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.Tender> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bpn/payguardian/android/util/DeviceServiceConstants$Tender", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Tender); }
			}

			internal Tender (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.Tender']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/util/DeviceServiceConstants$Tender;", "")]
			public static unsafe global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.Tender ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/util/DeviceServiceConstants$Tender;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.Tender __ret = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.Tender> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.Tender']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/bpn/payguardian/android/util/DeviceServiceConstants$Tender;", "")]
			public static unsafe global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.Tender[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bpn/payguardian/android/util/DeviceServiceConstants$Tender;");
				try {
					return (global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.Tender[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.Tender));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.YesNo']"
		[global::Android.Runtime.Register ("com/bpn/payguardian/android/util/DeviceServiceConstants$YesNo", DoNotGenerateAcw=true)]
		public sealed partial class YesNo : global::Java.Lang.Enum {


			static IntPtr NO_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.YesNo']/field[@name='NO']"
			[Register ("NO")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.YesNo No {
				get {
					if (NO_jfieldId == IntPtr.Zero)
						NO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$YesNo;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NO_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.YesNo> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr YES_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.YesNo']/field[@name='YES']"
			[Register ("YES")]
			public static global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.YesNo Yes {
				get {
					if (YES_jfieldId == IntPtr.Zero)
						YES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "YES", "Lcom/bpn/payguardian/android/util/DeviceServiceConstants$YesNo;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, YES_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.YesNo> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bpn/payguardian/android/util/DeviceServiceConstants$YesNo", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (YesNo); }
			}

			internal YesNo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getRxYesNo;
			public unsafe string RxYesNo {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.YesNo']/method[@name='getRxYesNo' and count(parameter)=0]"
				[Register ("getRxYesNo", "()Ljava/lang/String;", "GetGetRxYesNoHandler")]
				get {
					if (id_getRxYesNo == IntPtr.Zero)
						id_getRxYesNo = JNIEnv.GetMethodID (class_ref, "getRxYesNo", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRxYesNo), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.YesNo']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/util/DeviceServiceConstants$YesNo;", "")]
			public static unsafe global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.YesNo ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/util/DeviceServiceConstants$YesNo;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.YesNo __ret = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.YesNo> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants.YesNo']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/bpn/payguardian/android/util/DeviceServiceConstants$YesNo;", "")]
			public static unsafe global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.YesNo[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bpn/payguardian/android/util/DeviceServiceConstants$YesNo;");
				try {
					return (global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.YesNo[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bpn.Payguardian.Android.Util.DeviceServiceConstants.YesNo));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bpn/payguardian/android/util/DeviceServiceConstants", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeviceServiceConstants); }
		}

		protected DeviceServiceConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='DeviceServiceConstants']/constructor[@name='DeviceServiceConstants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DeviceServiceConstants ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DeviceServiceConstants)) {
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

	}
}
