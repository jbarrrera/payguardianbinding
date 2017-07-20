using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bpn.Payguardian.Android.Device.Rba {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.device.rba']/class[@name='Ingenico_FileWrite']"
	[global::Android.Runtime.Register ("com/bpn/payguardian/android/device/rba/Ingenico_FileWrite", DoNotGenerateAcw=true)]
	public partial class Ingenico_FileWrite : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.device.rba']/class[@name='Ingenico_FileWrite.EncodeFormat']"
		[global::Android.Runtime.Register ("com/bpn/payguardian/android/device/rba/Ingenico_FileWrite$EncodeFormat", DoNotGenerateAcw=true)]
		public sealed partial class EncodeFormat : global::Java.Lang.Enum {


			static IntPtr encode7bit_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.device.rba']/class[@name='Ingenico_FileWrite.EncodeFormat']/field[@name='encode7bit']"
			[Register ("encode7bit")]
			public static global::Com.Bpn.Payguardian.Android.Device.Rba.Ingenico_FileWrite.EncodeFormat Encode7bit {
				get {
					if (encode7bit_jfieldId == IntPtr.Zero)
						encode7bit_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "encode7bit", "Lcom/bpn/payguardian/android/device/rba/Ingenico_FileWrite$EncodeFormat;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, encode7bit_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Rba.Ingenico_FileWrite.EncodeFormat> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr encode8bit_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.device.rba']/class[@name='Ingenico_FileWrite.EncodeFormat']/field[@name='encode8bit']"
			[Register ("encode8bit")]
			public static global::Com.Bpn.Payguardian.Android.Device.Rba.Ingenico_FileWrite.EncodeFormat Encode8bit {
				get {
					if (encode8bit_jfieldId == IntPtr.Zero)
						encode8bit_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "encode8bit", "Lcom/bpn/payguardian/android/device/rba/Ingenico_FileWrite$EncodeFormat;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, encode8bit_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Rba.Ingenico_FileWrite.EncodeFormat> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bpn/payguardian/android/device/rba/Ingenico_FileWrite$EncodeFormat", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (EncodeFormat); }
			}

			internal EncodeFormat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.rba']/class[@name='Ingenico_FileWrite.EncodeFormat']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/device/rba/Ingenico_FileWrite$EncodeFormat;", "")]
			public static unsafe global::Com.Bpn.Payguardian.Android.Device.Rba.Ingenico_FileWrite.EncodeFormat ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bpn/payguardian/android/device/rba/Ingenico_FileWrite$EncodeFormat;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Bpn.Payguardian.Android.Device.Rba.Ingenico_FileWrite.EncodeFormat __ret = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Rba.Ingenico_FileWrite.EncodeFormat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.rba']/class[@name='Ingenico_FileWrite.EncodeFormat']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/bpn/payguardian/android/device/rba/Ingenico_FileWrite$EncodeFormat;", "")]
			public static unsafe global::Com.Bpn.Payguardian.Android.Device.Rba.Ingenico_FileWrite.EncodeFormat[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bpn/payguardian/android/device/rba/Ingenico_FileWrite$EncodeFormat;");
				try {
					return (global::Com.Bpn.Payguardian.Android.Device.Rba.Ingenico_FileWrite.EncodeFormat[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bpn.Payguardian.Android.Device.Rba.Ingenico_FileWrite.EncodeFormat));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.device.rba']/class[@name='Ingenico_FileWrite.EncodedData']"
		[global::Android.Runtime.Register ("com/bpn/payguardian/android/device/rba/Ingenico_FileWrite$EncodedData", DoNotGenerateAcw=true)]
		public partial class EncodedData : global::Java.Lang.Object {


			static IntPtr encData_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.device.rba']/class[@name='Ingenico_FileWrite.EncodedData']/field[@name='encData']"
			[Register ("encData")]
			public string EncData {
				get {
					if (encData_jfieldId == IntPtr.Zero)
						encData_jfieldId = JNIEnv.GetFieldID (class_ref, "encData", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, encData_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (encData_jfieldId == IntPtr.Zero)
						encData_jfieldId = JNIEnv.GetFieldID (class_ref, "encData", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, encData_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr readLen_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.device.rba']/class[@name='Ingenico_FileWrite.EncodedData']/field[@name='readLen']"
			[Register ("readLen")]
			public int ReadLen {
				get {
					if (readLen_jfieldId == IntPtr.Zero)
						readLen_jfieldId = JNIEnv.GetFieldID (class_ref, "readLen", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, readLen_jfieldId);
				}
				set {
					if (readLen_jfieldId == IntPtr.Zero)
						readLen_jfieldId = JNIEnv.GetFieldID (class_ref, "readLen", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, readLen_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bpn/payguardian/android/device/rba/Ingenico_FileWrite$EncodedData", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (EncodedData); }
			}

			protected EncodedData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.device.rba']/class[@name='Ingenico_FileWrite.EncodedResult']"
		[global::Android.Runtime.Register ("com/bpn/payguardian/android/device/rba/Ingenico_FileWrite$EncodedResult", DoNotGenerateAcw=true)]
		public sealed partial class EncodedResult : global::Java.Lang.Enum {


			static IntPtr endOfFile_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.device.rba']/class[@name='Ingenico_FileWrite.EncodedResult']/field[@name='endOfFile']"
			[Register ("endOfFile")]
			public static global::Com.Bpn.Payguardian.Android.Device.Rba.Ingenico_FileWrite.EncodedResult EndOfFile {
				get {
					if (endOfFile_jfieldId == IntPtr.Zero)
						endOfFile_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "endOfFile", "Lcom/bpn/payguardian/android/device/rba/Ingenico_FileWrite$EncodedResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, endOfFile_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Rba.Ingenico_FileWrite.EncodedResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr error_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.device.rba']/class[@name='Ingenico_FileWrite.EncodedResult']/field[@name='error']"
			[Register ("error")]
			public static global::Com.Bpn.Payguardian.Android.Device.Rba.Ingenico_FileWrite.EncodedResult Error {
				get {
					if (error_jfieldId == IntPtr.Zero)
						error_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "error", "Lcom/bpn/payguardian/android/device/rba/Ingenico_FileWrite$EncodedResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, error_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Rba.Ingenico_FileWrite.EncodedResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr success_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.device.rba']/class[@name='Ingenico_FileWrite.EncodedResult']/field[@name='success']"
			[Register ("success")]
			public static global::Com.Bpn.Payguardian.Android.Device.Rba.Ingenico_FileWrite.EncodedResult Success {
				get {
					if (success_jfieldId == IntPtr.Zero)
						success_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "success", "Lcom/bpn/payguardian/android/device/rba/Ingenico_FileWrite$EncodedResult;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, success_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Rba.Ingenico_FileWrite.EncodedResult> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bpn/payguardian/android/device/rba/Ingenico_FileWrite$EncodedResult", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (EncodedResult); }
			}

			internal EncodedResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.device.rba']/class[@name='Ingenico_FileWrite.RecordType']"
		[global::Android.Runtime.Register ("com/bpn/payguardian/android/device/rba/Ingenico_FileWrite$RecordType", DoNotGenerateAcw=true)]
		public sealed partial class RecordType : global::Java.Lang.Enum {


			static IntPtr multi_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.device.rba']/class[@name='Ingenico_FileWrite.RecordType']/field[@name='multi']"
			[Register ("multi")]
			public static global::Com.Bpn.Payguardian.Android.Device.Rba.Ingenico_FileWrite.RecordType Multi {
				get {
					if (multi_jfieldId == IntPtr.Zero)
						multi_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "multi", "Lcom/bpn/payguardian/android/device/rba/Ingenico_FileWrite$RecordType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, multi_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Rba.Ingenico_FileWrite.RecordType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr single_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.device.rba']/class[@name='Ingenico_FileWrite.RecordType']/field[@name='single']"
			[Register ("single")]
			public static global::Com.Bpn.Payguardian.Android.Device.Rba.Ingenico_FileWrite.RecordType Single {
				get {
					if (single_jfieldId == IntPtr.Zero)
						single_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "single", "Lcom/bpn/payguardian/android/device/rba/Ingenico_FileWrite$RecordType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, single_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Rba.Ingenico_FileWrite.RecordType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bpn/payguardian/android/device/rba/Ingenico_FileWrite$RecordType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RecordType); }
			}

			internal RecordType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bpn/payguardian/android/device/rba/Ingenico_FileWrite", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Ingenico_FileWrite); }
		}

		protected Ingenico_FileWrite (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bpn.payguardian.android.device.rba']/class[@name='Ingenico_FileWrite']/constructor[@name='Ingenico_FileWrite' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Ingenico_FileWrite ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Ingenico_FileWrite)) {
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

		static Delegate cb_DownloadFile_Ljava_io_InputStream_Ljava_lang_String_Lcom_bpn_payguardian_android_device_rba_Ingenico_FileWrite_EncodeFormat_ZZ;
#pragma warning disable 0169
		static Delegate GetDownloadFile_Ljava_io_InputStream_Ljava_lang_String_Lcom_bpn_payguardian_android_device_rba_Ingenico_FileWrite_EncodeFormat_ZZHandler ()
		{
			if (cb_DownloadFile_Ljava_io_InputStream_Ljava_lang_String_Lcom_bpn_payguardian_android_device_rba_Ingenico_FileWrite_EncodeFormat_ZZ == null)
				cb_DownloadFile_Ljava_io_InputStream_Ljava_lang_String_Lcom_bpn_payguardian_android_device_rba_Ingenico_FileWrite_EncodeFormat_ZZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, bool, bool>) n_DownloadFile_Ljava_io_InputStream_Ljava_lang_String_Lcom_bpn_payguardian_android_device_rba_Ingenico_FileWrite_EncodeFormat_ZZ);
			return cb_DownloadFile_Ljava_io_InputStream_Ljava_lang_String_Lcom_bpn_payguardian_android_device_rba_Ingenico_FileWrite_EncodeFormat_ZZ;
		}

		static bool n_DownloadFile_Ljava_io_InputStream_Ljava_lang_String_Lcom_bpn_payguardian_android_device_rba_Ingenico_FileWrite_EncodeFormat_ZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, bool p3, bool p4)
		{
			global::Com.Bpn.Payguardian.Android.Device.Rba.Ingenico_FileWrite __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Rba.Ingenico_FileWrite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Bpn.Payguardian.Android.Device.Rba.Ingenico_FileWrite.EncodeFormat p2 = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Rba.Ingenico_FileWrite.EncodeFormat> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DownloadFile (p0, p1, p2, p3, p4);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_DownloadFile_Ljava_io_InputStream_Ljava_lang_String_Lcom_bpn_payguardian_android_device_rba_Ingenico_FileWrite_EncodeFormat_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.rba']/class[@name='Ingenico_FileWrite']/method[@name='DownloadFile' and count(parameter)=5 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.bpn.payguardian.android.device.rba.Ingenico_FileWrite.EncodeFormat'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean']]"
		[Register ("DownloadFile", "(Ljava/io/InputStream;Ljava/lang/String;Lcom/bpn/payguardian/android/device/rba/Ingenico_FileWrite$EncodeFormat;ZZ)Z", "GetDownloadFile_Ljava_io_InputStream_Ljava_lang_String_Lcom_bpn_payguardian_android_device_rba_Ingenico_FileWrite_EncodeFormat_ZZHandler")]
		public virtual unsafe bool DownloadFile (global::System.IO.Stream p0, string p1, global::Com.Bpn.Payguardian.Android.Device.Rba.Ingenico_FileWrite.EncodeFormat p2, bool p3, bool p4)
		{
			if (id_DownloadFile_Ljava_io_InputStream_Ljava_lang_String_Lcom_bpn_payguardian_android_device_rba_Ingenico_FileWrite_EncodeFormat_ZZ == IntPtr.Zero)
				id_DownloadFile_Ljava_io_InputStream_Ljava_lang_String_Lcom_bpn_payguardian_android_device_rba_Ingenico_FileWrite_EncodeFormat_ZZ = JNIEnv.GetMethodID (class_ref, "DownloadFile", "(Ljava/io/InputStream;Ljava/lang/String;Lcom/bpn/payguardian/android/device/rba/Ingenico_FileWrite$EncodeFormat;ZZ)Z");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_DownloadFile_Ljava_io_InputStream_Ljava_lang_String_Lcom_bpn_payguardian_android_device_rba_Ingenico_FileWrite_EncodeFormat_ZZ, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "DownloadFile", "(Ljava/io/InputStream;Ljava/lang/String;Lcom/bpn/payguardian/android/device/rba/Ingenico_FileWrite$EncodeFormat;ZZ)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
