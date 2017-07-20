using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bpn.Payguardian.Android.Device.Unipay {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bpn.payguardian.android.device.unipay']/interface[@name='UnipayCallback']"
	[Register ("com/bpn/payguardian/android/device/unipay/UnipayCallback", "", "Com.Bpn.Payguardian.Android.Device.Unipay.IUnipayCallbackInvoker")]
	public partial interface IUnipayCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.unipay']/interface[@name='UnipayCallback']/method[@name='unipayDeviceReady' and count(parameter)=0]"
		[Register ("unipayDeviceReady", "()V", "GetUnipayDeviceReadyHandler:Com.Bpn.Payguardian.Android.Device.Unipay.IUnipayCallbackInvoker, Fusion.Android.PayGuardian")]
		void UnipayDeviceReady ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.unipay']/interface[@name='UnipayCallback']/method[@name='unipayDisplay' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unipayDisplay", "(Ljava/lang/String;)V", "GetUnipayDisplay_Ljava_lang_String_Handler:Com.Bpn.Payguardian.Android.Device.Unipay.IUnipayCallbackInvoker, Fusion.Android.PayGuardian")]
		void UnipayDisplay (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.unipay']/interface[@name='UnipayCallback']/method[@name='unipayEmvCallback' and count(parameter)=1 and parameter[1][@type='com.bpn.payguardian.android.device.model.EmvDTO']]"
		[Register ("unipayEmvCallback", "(Lcom/bpn/payguardian/android/device/model/EmvDTO;)V", "GetUnipayEmvCallback_Lcom_bpn_payguardian_android_device_model_EmvDTO_Handler:Com.Bpn.Payguardian.Android.Device.Unipay.IUnipayCallbackInvoker, Fusion.Android.PayGuardian")]
		void UnipayEmvCallback (global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.unipay']/interface[@name='UnipayCallback']/method[@name='unipayEmvComplete' and count(parameter)=1 and parameter[1][@type='com.bpn.payguardian.android.device.model.EmvDTO']]"
		[Register ("unipayEmvComplete", "(Lcom/bpn/payguardian/android/device/model/EmvDTO;)V", "GetUnipayEmvComplete_Lcom_bpn_payguardian_android_device_model_EmvDTO_Handler:Com.Bpn.Payguardian.Android.Device.Unipay.IUnipayCallbackInvoker, Fusion.Android.PayGuardian")]
		void UnipayEmvComplete (global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.unipay']/interface[@name='UnipayCallback']/method[@name='unipayError' and count(parameter)=1 and parameter[1][@type='com.bpn.payguardian.android.exception.PayGuardianException']]"
		[Register ("unipayError", "(Lcom/bpn/payguardian/android/exception/PayGuardianException;)V", "GetUnipayError_Lcom_bpn_payguardian_android_exception_PayGuardianException_Handler:Com.Bpn.Payguardian.Android.Device.Unipay.IUnipayCallbackInvoker, Fusion.Android.PayGuardian")]
		void UnipayError (global::Com.Bpn.Payguardian.Android.Exception.PayGuardianException p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.device.unipay']/interface[@name='UnipayCallback']/method[@name='unipayMsrCallback' and count(parameter)=1 and parameter[1][@type='com.bpn.payguardian.android.device.model.MsrDTO']]"
		[Register ("unipayMsrCallback", "(Lcom/bpn/payguardian/android/device/model/MsrDTO;)V", "GetUnipayMsrCallback_Lcom_bpn_payguardian_android_device_model_MsrDTO_Handler:Com.Bpn.Payguardian.Android.Device.Unipay.IUnipayCallbackInvoker, Fusion.Android.PayGuardian")]
		void UnipayMsrCallback (global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO p0);

	}

	[global::Android.Runtime.Register ("com/bpn/payguardian/android/device/unipay/UnipayCallback", DoNotGenerateAcw=true)]
	internal class IUnipayCallbackInvoker : global::Java.Lang.Object, IUnipayCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bpn/payguardian/android/device/unipay/UnipayCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IUnipayCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IUnipayCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUnipayCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bpn.payguardian.android.device.unipay.UnipayCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUnipayCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Bpn.Payguardian.Android.Device.Unipay.IUnipayCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Unipay.IUnipayCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnipayDeviceReady ();
		}
#pragma warning restore 0169

		IntPtr id_unipayDeviceReady;
		public unsafe void UnipayDeviceReady ()
		{
			if (id_unipayDeviceReady == IntPtr.Zero)
				id_unipayDeviceReady = JNIEnv.GetMethodID (class_ref, "unipayDeviceReady", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unipayDeviceReady);
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
			global::Com.Bpn.Payguardian.Android.Device.Unipay.IUnipayCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Unipay.IUnipayCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnipayDisplay (p0);
		}
#pragma warning restore 0169

		IntPtr id_unipayDisplay_Ljava_lang_String_;
		public unsafe void UnipayDisplay (string p0)
		{
			if (id_unipayDisplay_Ljava_lang_String_ == IntPtr.Zero)
				id_unipayDisplay_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "unipayDisplay", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unipayDisplay_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Bpn.Payguardian.Android.Device.Unipay.IUnipayCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Unipay.IUnipayCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO p0 = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnipayEmvCallback (p0);
		}
#pragma warning restore 0169

		IntPtr id_unipayEmvCallback_Lcom_bpn_payguardian_android_device_model_EmvDTO_;
		public unsafe void UnipayEmvCallback (global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO p0)
		{
			if (id_unipayEmvCallback_Lcom_bpn_payguardian_android_device_model_EmvDTO_ == IntPtr.Zero)
				id_unipayEmvCallback_Lcom_bpn_payguardian_android_device_model_EmvDTO_ = JNIEnv.GetMethodID (class_ref, "unipayEmvCallback", "(Lcom/bpn/payguardian/android/device/model/EmvDTO;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unipayEmvCallback_Lcom_bpn_payguardian_android_device_model_EmvDTO_, __args);
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
			global::Com.Bpn.Payguardian.Android.Device.Unipay.IUnipayCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Unipay.IUnipayCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO p0 = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnipayEmvComplete (p0);
		}
#pragma warning restore 0169

		IntPtr id_unipayEmvComplete_Lcom_bpn_payguardian_android_device_model_EmvDTO_;
		public unsafe void UnipayEmvComplete (global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO p0)
		{
			if (id_unipayEmvComplete_Lcom_bpn_payguardian_android_device_model_EmvDTO_ == IntPtr.Zero)
				id_unipayEmvComplete_Lcom_bpn_payguardian_android_device_model_EmvDTO_ = JNIEnv.GetMethodID (class_ref, "unipayEmvComplete", "(Lcom/bpn/payguardian/android/device/model/EmvDTO;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unipayEmvComplete_Lcom_bpn_payguardian_android_device_model_EmvDTO_, __args);
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
			global::Com.Bpn.Payguardian.Android.Device.Unipay.IUnipayCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Unipay.IUnipayCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bpn.Payguardian.Android.Exception.PayGuardianException p0 = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Exception.PayGuardianException> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnipayError (p0);
		}
#pragma warning restore 0169

		IntPtr id_unipayError_Lcom_bpn_payguardian_android_exception_PayGuardianException_;
		public unsafe void UnipayError (global::Com.Bpn.Payguardian.Android.Exception.PayGuardianException p0)
		{
			if (id_unipayError_Lcom_bpn_payguardian_android_exception_PayGuardianException_ == IntPtr.Zero)
				id_unipayError_Lcom_bpn_payguardian_android_exception_PayGuardianException_ = JNIEnv.GetMethodID (class_ref, "unipayError", "(Lcom/bpn/payguardian/android/exception/PayGuardianException;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unipayError_Lcom_bpn_payguardian_android_exception_PayGuardianException_, __args);
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
			global::Com.Bpn.Payguardian.Android.Device.Unipay.IUnipayCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Unipay.IUnipayCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO p0 = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnipayMsrCallback (p0);
		}
#pragma warning restore 0169

		IntPtr id_unipayMsrCallback_Lcom_bpn_payguardian_android_device_model_MsrDTO_;
		public unsafe void UnipayMsrCallback (global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO p0)
		{
			if (id_unipayMsrCallback_Lcom_bpn_payguardian_android_device_model_MsrDTO_ == IntPtr.Zero)
				id_unipayMsrCallback_Lcom_bpn_payguardian_android_device_model_MsrDTO_ = JNIEnv.GetMethodID (class_ref, "unipayMsrCallback", "(Lcom/bpn/payguardian/android/device/model/MsrDTO;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unipayMsrCallback_Lcom_bpn_payguardian_android_device_model_MsrDTO_, __args);
		}

	}

}
