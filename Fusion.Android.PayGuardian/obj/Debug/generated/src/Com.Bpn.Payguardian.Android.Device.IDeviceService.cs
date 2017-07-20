using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bpn.Payguardian.Android.Device {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bpn.payguardian.android.device']/interface[@name='DeviceService']"
	[Register ("com/bpn/payguardian/android/device/DeviceService", "", "Com.Bpn.Payguardian.Android.Device.IDeviceServiceInvoker")]
	public partial interface IDeviceService : IJavaObject {

	}

	[global::Android.Runtime.Register ("com/bpn/payguardian/android/device/DeviceService", DoNotGenerateAcw=true)]
	internal class IDeviceServiceInvoker : global::Java.Lang.Object, IDeviceService {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bpn/payguardian/android/device/DeviceService");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDeviceServiceInvoker); }
		}

		IntPtr class_ref;

		public static IDeviceService GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDeviceService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bpn.payguardian.android.device.DeviceService"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDeviceServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

}
