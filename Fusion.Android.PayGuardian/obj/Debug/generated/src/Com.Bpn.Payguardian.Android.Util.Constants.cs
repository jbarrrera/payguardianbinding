using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bpn.Payguardian.Android.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='Constants']"
	[global::Android.Runtime.Register ("com/bpn/payguardian/android/util/Constants", DoNotGenerateAcw=true)]
	public partial class Constants : global::Java.Lang.Object {


		static IntPtr PLEASE_WAIT_CARD_READ_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='Constants']/field[@name='PLEASE_WAIT_CARD_READ']"
		[Register ("PLEASE_WAIT_CARD_READ")]
		public static string PleaseWaitCardRead {
			get {
				if (PLEASE_WAIT_CARD_READ_jfieldId == IntPtr.Zero)
					PLEASE_WAIT_CARD_READ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PLEASE_WAIT_CARD_READ", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PLEASE_WAIT_CARD_READ_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PLEASE_WAIT_CARD_READ_jfieldId == IntPtr.Zero)
					PLEASE_WAIT_CARD_READ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PLEASE_WAIT_CARD_READ", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, PLEASE_WAIT_CARD_READ_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr SWIPE_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='Constants']/field[@name='SWIPE_ERROR']"
		[Register ("SWIPE_ERROR")]
		public static string SwipeError {
			get {
				if (SWIPE_ERROR_jfieldId == IntPtr.Zero)
					SWIPE_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SWIPE_ERROR", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SWIPE_ERROR_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SWIPE_ERROR_jfieldId == IntPtr.Zero)
					SWIPE_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SWIPE_ERROR", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, SWIPE_ERROR_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr USE_ICC_CARD_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='Constants']/field[@name='USE_ICC_CARD']"
		[Register ("USE_ICC_CARD")]
		public static string UseIccCard {
			get {
				if (USE_ICC_CARD_jfieldId == IntPtr.Zero)
					USE_ICC_CARD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USE_ICC_CARD", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, USE_ICC_CARD_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (USE_ICC_CARD_jfieldId == IntPtr.Zero)
					USE_ICC_CARD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USE_ICC_CARD", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, USE_ICC_CARD_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bpn/payguardian/android/util/Constants", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Constants); }
		}

		protected Constants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='Constants']/constructor[@name='Constants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Constants ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Constants)) {
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
