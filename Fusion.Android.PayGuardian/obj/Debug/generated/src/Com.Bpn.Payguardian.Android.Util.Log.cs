using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bpn.Payguardian.Android.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='Log']"
	[global::Android.Runtime.Register ("com/bpn/payguardian/android/util/Log", DoNotGenerateAcw=true)]
	public partial class Log : global::Java.Lang.Object {


		static IntPtr LEVEL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='Log']/field[@name='LEVEL']"
		[Register ("LEVEL")]
		public static int Level {
			get {
				if (LEVEL_jfieldId == IntPtr.Zero)
					LEVEL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LEVEL", "I");
				return JNIEnv.GetStaticIntField (class_ref, LEVEL_jfieldId);
			}
			set {
				if (LEVEL_jfieldId == IntPtr.Zero)
					LEVEL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LEVEL", "I");
				try {
					JNIEnv.SetStaticField (class_ref, LEVEL_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bpn/payguardian/android/util/Log", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Log); }
		}

		protected Log (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='Log']/constructor[@name='Log' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Log ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Log)) {
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

		static IntPtr id_d_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='Log']/method[@name='d' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void D (string p0, string p1)
		{
			if (id_d_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_d_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_d_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_d_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='Log']/method[@name='d' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void D (string p0, string p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_d_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_d_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_d_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_d_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='Log']/method[@name='d' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void D (string p0, global::Java.Lang.Throwable p1, string p2, params global:: Java.Lang.Object[] p3)
		{
			if (id_d_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_d_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(Ljava/lang/String;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_d_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static IntPtr id_e_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='Log']/method[@name='e' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void E (string p0, string p1)
		{
			if (id_e_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_e_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_e_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_e_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='Log']/method[@name='e' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static unsafe void E (string p0, global::Java.Lang.Throwable p1)
		{
			if (id_e_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_e_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_e_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_i_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.util']/class[@name='Log']/method[@name='i' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("i", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void I (string p0, string p1)
		{
			if (id_i_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_i_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "i", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_i_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
