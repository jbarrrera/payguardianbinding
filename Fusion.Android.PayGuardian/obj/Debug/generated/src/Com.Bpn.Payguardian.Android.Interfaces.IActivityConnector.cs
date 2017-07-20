using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bpn.Payguardian.Android.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bpn.payguardian.android.interfaces']/interface[@name='ActivityConnector']"
	[Register ("com/bpn/payguardian/android/interfaces/ActivityConnector", "", "Com.Bpn.Payguardian.Android.Interfaces.IActivityConnectorInvoker")]
	public partial interface IActivityConnector : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.interfaces']/interface[@name='ActivityConnector']/method[@name='badCardReader' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("badCardReader", "(Ljava/lang/String;)V", "GetBadCardReader_Ljava_lang_String_Handler:Com.Bpn.Payguardian.Android.Interfaces.IActivityConnectorInvoker, Fusion.Android.PayGuardian")]
		void BadCardReader (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.interfaces']/interface[@name='ActivityConnector']/method[@name='badCardReaderRetry' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("badCardReaderRetry", "(Ljava/lang/String;)V", "GetBadCardReaderRetry_Ljava_lang_String_Handler:Com.Bpn.Payguardian.Android.Interfaces.IActivityConnectorInvoker, Fusion.Android.PayGuardian")]
		void BadCardReaderRetry (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.interfaces']/interface[@name='ActivityConnector']/method[@name='cardReaderCompleted' and count(parameter)=1 and parameter[1][@type='com.bpn.payguardian.android.device.model.MsrDTO']]"
		[Register ("cardReaderCompleted", "(Lcom/bpn/payguardian/android/device/model/MsrDTO;)V", "GetCardReaderCompleted_Lcom_bpn_payguardian_android_device_model_MsrDTO_Handler:Com.Bpn.Payguardian.Android.Interfaces.IActivityConnectorInvoker, Fusion.Android.PayGuardian")]
		void CardReaderCompleted (global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.interfaces']/interface[@name='ActivityConnector']/method[@name='connect' and count(parameter)=0]"
		[Register ("connect", "()V", "GetConnectHandler:Com.Bpn.Payguardian.Android.Interfaces.IActivityConnectorInvoker, Fusion.Android.PayGuardian")]
		void Connect ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.interfaces']/interface[@name='ActivityConnector']/method[@name='connectEmvSwipe' and count(parameter)=0]"
		[Register ("connectEmvSwipe", "()V", "GetConnectEmvSwipeHandler:Com.Bpn.Payguardian.Android.Interfaces.IActivityConnectorInvoker, Fusion.Android.PayGuardian")]
		void ConnectEmvSwipe ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.interfaces']/interface[@name='ActivityConnector']/method[@name='connectUnipayIII' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("connectUnipayIII", "(Z)V", "GetConnectUnipayIII_ZHandler:Com.Bpn.Payguardian.Android.Interfaces.IActivityConnectorInvoker, Fusion.Android.PayGuardian")]
		void ConnectUnipayIII (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.interfaces']/interface[@name='ActivityConnector']/method[@name='connectWisePad' and count(parameter)=0]"
		[Register ("connectWisePad", "()V", "GetConnectWisePadHandler:Com.Bpn.Payguardian.Android.Interfaces.IActivityConnectorInvoker, Fusion.Android.PayGuardian")]
		void ConnectWisePad ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.interfaces']/interface[@name='ActivityConnector']/method[@name='disconnectEmvSwipe' and count(parameter)=0]"
		[Register ("disconnectEmvSwipe", "()V", "GetDisconnectEmvSwipeHandler:Com.Bpn.Payguardian.Android.Interfaces.IActivityConnectorInvoker, Fusion.Android.PayGuardian")]
		void DisconnectEmvSwipe ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.interfaces']/interface[@name='ActivityConnector']/method[@name='emvAuthorizationRequestCompleted' and count(parameter)=1 and parameter[1][@type='com.bpn.payguardian.android.device.model.EmvDTO']]"
		[Register ("emvAuthorizationRequestCompleted", "(Lcom/bpn/payguardian/android/device/model/EmvDTO;)V", "GetEmvAuthorizationRequestCompleted_Lcom_bpn_payguardian_android_device_model_EmvDTO_Handler:Com.Bpn.Payguardian.Android.Interfaces.IActivityConnectorInvoker, Fusion.Android.PayGuardian")]
		void EmvAuthorizationRequestCompleted (global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.interfaces']/interface[@name='ActivityConnector']/method[@name='emvAuthorizationResponseCompleted' and count(parameter)=1 and parameter[1][@type='com.bpn.payguardian.android.device.model.EmvDTO']]"
		[Register ("emvAuthorizationResponseCompleted", "(Lcom/bpn/payguardian/android/device/model/EmvDTO;)V", "GetEmvAuthorizationResponseCompleted_Lcom_bpn_payguardian_android_device_model_EmvDTO_Handler:Com.Bpn.Payguardian.Android.Interfaces.IActivityConnectorInvoker, Fusion.Android.PayGuardian")]
		void EmvAuthorizationResponseCompleted (global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.interfaces']/interface[@name='ActivityConnector']/method[@name='pinEntryCompleted' and count(parameter)=1 and parameter[1][@type='com.bpn.payguardian.android.device.model.PinPadDTO']]"
		[Register ("pinEntryCompleted", "(Lcom/bpn/payguardian/android/device/model/PinPadDTO;)V", "GetPinEntryCompleted_Lcom_bpn_payguardian_android_device_model_PinPadDTO_Handler:Com.Bpn.Payguardian.Android.Interfaces.IActivityConnectorInvoker, Fusion.Android.PayGuardian")]
		void PinEntryCompleted (global::Com.Bpn.Payguardian.Android.Device.Model.PinPadDTO p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.interfaces']/interface[@name='ActivityConnector']/method[@name='readCardReader' and count(parameter)=0]"
		[Register ("readCardReader", "()V", "GetReadCardReaderHandler:Com.Bpn.Payguardian.Android.Interfaces.IActivityConnectorInvoker, Fusion.Android.PayGuardian")]
		void ReadCardReader ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.interfaces']/interface[@name='ActivityConnector']/method[@name='readEmvSwipeReader' and count(parameter)=0]"
		[Register ("readEmvSwipeReader", "()V", "GetReadEmvSwipeReaderHandler:Com.Bpn.Payguardian.Android.Interfaces.IActivityConnectorInvoker, Fusion.Android.PayGuardian")]
		void ReadEmvSwipeReader ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.interfaces']/interface[@name='ActivityConnector']/method[@name='readPinEntry' and count(parameter)=0]"
		[Register ("readPinEntry", "()V", "GetReadPinEntryHandler:Com.Bpn.Payguardian.Android.Interfaces.IActivityConnectorInvoker, Fusion.Android.PayGuardian")]
		void ReadPinEntry ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.interfaces']/interface[@name='ActivityConnector']/method[@name='readWisePadReader' and count(parameter)=0]"
		[Register ("readWisePadReader", "()V", "GetReadWisePadReaderHandler:Com.Bpn.Payguardian.Android.Interfaces.IActivityConnectorInvoker, Fusion.Android.PayGuardian")]
		void ReadWisePadReader ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.interfaces']/interface[@name='ActivityConnector']/method[@name='selectBbposEmvApplication' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;java.lang.String&gt;']]"
		[Register ("selectBbposEmvApplication", "(Ljava/util/ArrayList;)V", "GetSelectBbposEmvApplication_Ljava_util_ArrayList_Handler:Com.Bpn.Payguardian.Android.Interfaces.IActivityConnectorInvoker, Fusion.Android.PayGuardian")]
		void SelectBbposEmvApplication (global::System.Collections.Generic.IList<string> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.interfaces']/interface[@name='ActivityConnector']/method[@name='sendBbposEmvFinalConfirm' and count(parameter)=0]"
		[Register ("sendBbposEmvFinalConfirm", "()V", "GetSendBbposEmvFinalConfirmHandler:Com.Bpn.Payguardian.Android.Interfaces.IActivityConnectorInvoker, Fusion.Android.PayGuardian")]
		void SendBbposEmvFinalConfirm ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.interfaces']/interface[@name='ActivityConnector']/method[@name='sendServerConnectivity' and count(parameter)=0]"
		[Register ("sendServerConnectivity", "()V", "GetSendServerConnectivityHandler:Com.Bpn.Payguardian.Android.Interfaces.IActivityConnectorInvoker, Fusion.Android.PayGuardian")]
		void SendServerConnectivity ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.interfaces']/interface[@name='ActivityConnector']/method[@name='setBbposEmvAmount' and count(parameter)=0]"
		[Register ("setBbposEmvAmount", "()V", "GetSetBbposEmvAmountHandler:Com.Bpn.Payguardian.Android.Interfaces.IActivityConnectorInvoker, Fusion.Android.PayGuardian")]
		void SetBbposEmvAmount ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.interfaces']/interface[@name='ActivityConnector']/method[@name='setEmvApplication' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setEmvApplication", "(I)V", "GetSetEmvApplication_IHandler:Com.Bpn.Payguardian.Android.Interfaces.IActivityConnectorInvoker, Fusion.Android.PayGuardian")]
		void SetEmvApplication (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.interfaces']/interface[@name='ActivityConnector']/method[@name='setReadData' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setReadData", "(Z)V", "GetSetReadData_ZHandler:Com.Bpn.Payguardian.Android.Interfaces.IActivityConnectorInvoker, Fusion.Android.PayGuardian")]
		void SetReadData (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.interfaces']/interface[@name='ActivityConnector']/method[@name='showKeyed' and count(parameter)=0]"
		[Register ("showKeyed", "()V", "GetShowKeyedHandler:Com.Bpn.Payguardian.Android.Interfaces.IActivityConnectorInvoker, Fusion.Android.PayGuardian")]
		void ShowKeyed ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.interfaces']/interface[@name='ActivityConnector']/method[@name='startBbposEmv' and count(parameter)=0]"
		[Register ("startBbposEmv", "()V", "GetStartBbposEmvHandler:Com.Bpn.Payguardian.Android.Interfaces.IActivityConnectorInvoker, Fusion.Android.PayGuardian")]
		void StartBbposEmv ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.interfaces']/interface[@name='ActivityConnector']/method[@name='updateStatus' and count(parameter)=1 and parameter[1][@type='com.bpn.payguardian.android.PayGuardianStatus']]"
		[Register ("updateStatus", "(Lcom/bpn/payguardian/android/PayGuardianStatus;)V", "GetUpdateStatus_Lcom_bpn_payguardian_android_PayGuardianStatus_Handler:Com.Bpn.Payguardian.Android.Interfaces.IActivityConnectorInvoker, Fusion.Android.PayGuardian")]
		void UpdateStatus (global::Com.Bpn.Payguardian.Android.PayGuardianStatus p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.interfaces']/interface[@name='ActivityConnector']/method[@name='updateStatus' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("updateStatus", "(Ljava/lang/String;)V", "GetUpdateStatus_Ljava_lang_String_Handler:Com.Bpn.Payguardian.Android.Interfaces.IActivityConnectorInvoker, Fusion.Android.PayGuardian")]
		void UpdateStatus (string p0);

	}

	[global::Android.Runtime.Register ("com/bpn/payguardian/android/interfaces/ActivityConnector", DoNotGenerateAcw=true)]
	internal class IActivityConnectorInvoker : global::Java.Lang.Object, IActivityConnector {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bpn/payguardian/android/interfaces/ActivityConnector");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IActivityConnectorInvoker); }
		}

		IntPtr class_ref;

		public static IActivityConnector GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IActivityConnector> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bpn.payguardian.android.interfaces.ActivityConnector"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IActivityConnectorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BadCardReader (p0);
		}
#pragma warning restore 0169

		IntPtr id_badCardReader_Ljava_lang_String_;
		public unsafe void BadCardReader (string p0)
		{
			if (id_badCardReader_Ljava_lang_String_ == IntPtr.Zero)
				id_badCardReader_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "badCardReader", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_badCardReader_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BadCardReaderRetry (p0);
		}
#pragma warning restore 0169

		IntPtr id_badCardReaderRetry_Ljava_lang_String_;
		public unsafe void BadCardReaderRetry (string p0)
		{
			if (id_badCardReaderRetry_Ljava_lang_String_ == IntPtr.Zero)
				id_badCardReaderRetry_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "badCardReaderRetry", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_badCardReaderRetry_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO p0 = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CardReaderCompleted (p0);
		}
#pragma warning restore 0169

		IntPtr id_cardReaderCompleted_Lcom_bpn_payguardian_android_device_model_MsrDTO_;
		public unsafe void CardReaderCompleted (global::Com.Bpn.Payguardian.Android.Device.Model.MsrDTO p0)
		{
			if (id_cardReaderCompleted_Lcom_bpn_payguardian_android_device_model_MsrDTO_ == IntPtr.Zero)
				id_cardReaderCompleted_Lcom_bpn_payguardian_android_device_model_MsrDTO_ = JNIEnv.GetMethodID (class_ref, "cardReaderCompleted", "(Lcom/bpn/payguardian/android/device/model/MsrDTO;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cardReaderCompleted_Lcom_bpn_payguardian_android_device_model_MsrDTO_, __args);
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
			global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Connect ();
		}
#pragma warning restore 0169

		IntPtr id_connect;
		public unsafe void Connect ()
		{
			if (id_connect == IntPtr.Zero)
				id_connect = JNIEnv.GetMethodID (class_ref, "connect", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connect);
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
			global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConnectEmvSwipe ();
		}
#pragma warning restore 0169

		IntPtr id_connectEmvSwipe;
		public unsafe void ConnectEmvSwipe ()
		{
			if (id_connectEmvSwipe == IntPtr.Zero)
				id_connectEmvSwipe = JNIEnv.GetMethodID (class_ref, "connectEmvSwipe", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connectEmvSwipe);
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
			global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConnectUnipayIII (p0);
		}
#pragma warning restore 0169

		IntPtr id_connectUnipayIII_Z;
		public unsafe void ConnectUnipayIII (bool p0)
		{
			if (id_connectUnipayIII_Z == IntPtr.Zero)
				id_connectUnipayIII_Z = JNIEnv.GetMethodID (class_ref, "connectUnipayIII", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connectUnipayIII_Z, __args);
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
			global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConnectWisePad ();
		}
#pragma warning restore 0169

		IntPtr id_connectWisePad;
		public unsafe void ConnectWisePad ()
		{
			if (id_connectWisePad == IntPtr.Zero)
				id_connectWisePad = JNIEnv.GetMethodID (class_ref, "connectWisePad", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connectWisePad);
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
			global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisconnectEmvSwipe ();
		}
#pragma warning restore 0169

		IntPtr id_disconnectEmvSwipe;
		public unsafe void DisconnectEmvSwipe ()
		{
			if (id_disconnectEmvSwipe == IntPtr.Zero)
				id_disconnectEmvSwipe = JNIEnv.GetMethodID (class_ref, "disconnectEmvSwipe", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disconnectEmvSwipe);
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
			global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO p0 = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EmvAuthorizationRequestCompleted (p0);
		}
#pragma warning restore 0169

		IntPtr id_emvAuthorizationRequestCompleted_Lcom_bpn_payguardian_android_device_model_EmvDTO_;
		public unsafe void EmvAuthorizationRequestCompleted (global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO p0)
		{
			if (id_emvAuthorizationRequestCompleted_Lcom_bpn_payguardian_android_device_model_EmvDTO_ == IntPtr.Zero)
				id_emvAuthorizationRequestCompleted_Lcom_bpn_payguardian_android_device_model_EmvDTO_ = JNIEnv.GetMethodID (class_ref, "emvAuthorizationRequestCompleted", "(Lcom/bpn/payguardian/android/device/model/EmvDTO;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_emvAuthorizationRequestCompleted_Lcom_bpn_payguardian_android_device_model_EmvDTO_, __args);
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
			global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO p0 = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EmvAuthorizationResponseCompleted (p0);
		}
#pragma warning restore 0169

		IntPtr id_emvAuthorizationResponseCompleted_Lcom_bpn_payguardian_android_device_model_EmvDTO_;
		public unsafe void EmvAuthorizationResponseCompleted (global::Com.Bpn.Payguardian.Android.Device.Model.EmvDTO p0)
		{
			if (id_emvAuthorizationResponseCompleted_Lcom_bpn_payguardian_android_device_model_EmvDTO_ == IntPtr.Zero)
				id_emvAuthorizationResponseCompleted_Lcom_bpn_payguardian_android_device_model_EmvDTO_ = JNIEnv.GetMethodID (class_ref, "emvAuthorizationResponseCompleted", "(Lcom/bpn/payguardian/android/device/model/EmvDTO;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_emvAuthorizationResponseCompleted_Lcom_bpn_payguardian_android_device_model_EmvDTO_, __args);
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
			global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bpn.Payguardian.Android.Device.Model.PinPadDTO p0 = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Device.Model.PinPadDTO> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PinEntryCompleted (p0);
		}
#pragma warning restore 0169

		IntPtr id_pinEntryCompleted_Lcom_bpn_payguardian_android_device_model_PinPadDTO_;
		public unsafe void PinEntryCompleted (global::Com.Bpn.Payguardian.Android.Device.Model.PinPadDTO p0)
		{
			if (id_pinEntryCompleted_Lcom_bpn_payguardian_android_device_model_PinPadDTO_ == IntPtr.Zero)
				id_pinEntryCompleted_Lcom_bpn_payguardian_android_device_model_PinPadDTO_ = JNIEnv.GetMethodID (class_ref, "pinEntryCompleted", "(Lcom/bpn/payguardian/android/device/model/PinPadDTO;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pinEntryCompleted_Lcom_bpn_payguardian_android_device_model_PinPadDTO_, __args);
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
			global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReadCardReader ();
		}
#pragma warning restore 0169

		IntPtr id_readCardReader;
		public unsafe void ReadCardReader ()
		{
			if (id_readCardReader == IntPtr.Zero)
				id_readCardReader = JNIEnv.GetMethodID (class_ref, "readCardReader", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readCardReader);
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
			global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReadEmvSwipeReader ();
		}
#pragma warning restore 0169

		IntPtr id_readEmvSwipeReader;
		public unsafe void ReadEmvSwipeReader ()
		{
			if (id_readEmvSwipeReader == IntPtr.Zero)
				id_readEmvSwipeReader = JNIEnv.GetMethodID (class_ref, "readEmvSwipeReader", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readEmvSwipeReader);
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
			global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReadPinEntry ();
		}
#pragma warning restore 0169

		IntPtr id_readPinEntry;
		public unsafe void ReadPinEntry ()
		{
			if (id_readPinEntry == IntPtr.Zero)
				id_readPinEntry = JNIEnv.GetMethodID (class_ref, "readPinEntry", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readPinEntry);
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
			global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReadWisePadReader ();
		}
#pragma warning restore 0169

		IntPtr id_readWisePadReader;
		public unsafe void ReadWisePadReader ()
		{
			if (id_readWisePadReader == IntPtr.Zero)
				id_readWisePadReader = JNIEnv.GetMethodID (class_ref, "readWisePadReader", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readWisePadReader);
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
			global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SelectBbposEmvApplication (p0);
		}
#pragma warning restore 0169

		IntPtr id_selectBbposEmvApplication_Ljava_util_ArrayList_;
		public unsafe void SelectBbposEmvApplication (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_selectBbposEmvApplication_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_selectBbposEmvApplication_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "selectBbposEmvApplication", "(Ljava/util/ArrayList;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_selectBbposEmvApplication_Ljava_util_ArrayList_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendBbposEmvFinalConfirm ();
		}
#pragma warning restore 0169

		IntPtr id_sendBbposEmvFinalConfirm;
		public unsafe void SendBbposEmvFinalConfirm ()
		{
			if (id_sendBbposEmvFinalConfirm == IntPtr.Zero)
				id_sendBbposEmvFinalConfirm = JNIEnv.GetMethodID (class_ref, "sendBbposEmvFinalConfirm", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendBbposEmvFinalConfirm);
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
			global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendServerConnectivity ();
		}
#pragma warning restore 0169

		IntPtr id_sendServerConnectivity;
		public unsafe void SendServerConnectivity ()
		{
			if (id_sendServerConnectivity == IntPtr.Zero)
				id_sendServerConnectivity = JNIEnv.GetMethodID (class_ref, "sendServerConnectivity", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendServerConnectivity);
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
			global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBbposEmvAmount ();
		}
#pragma warning restore 0169

		IntPtr id_setBbposEmvAmount;
		public unsafe void SetBbposEmvAmount ()
		{
			if (id_setBbposEmvAmount == IntPtr.Zero)
				id_setBbposEmvAmount = JNIEnv.GetMethodID (class_ref, "setBbposEmvAmount", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBbposEmvAmount);
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
			global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetEmvApplication (p0);
		}
#pragma warning restore 0169

		IntPtr id_setEmvApplication_I;
		public unsafe void SetEmvApplication (int p0)
		{
			if (id_setEmvApplication_I == IntPtr.Zero)
				id_setEmvApplication_I = JNIEnv.GetMethodID (class_ref, "setEmvApplication", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEmvApplication_I, __args);
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
			global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetReadData (p0);
		}
#pragma warning restore 0169

		IntPtr id_setReadData_Z;
		public unsafe void SetReadData (bool p0)
		{
			if (id_setReadData_Z == IntPtr.Zero)
				id_setReadData_Z = JNIEnv.GetMethodID (class_ref, "setReadData", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setReadData_Z, __args);
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
			global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowKeyed ();
		}
#pragma warning restore 0169

		IntPtr id_showKeyed;
		public unsafe void ShowKeyed ()
		{
			if (id_showKeyed == IntPtr.Zero)
				id_showKeyed = JNIEnv.GetMethodID (class_ref, "showKeyed", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showKeyed);
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
			global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartBbposEmv ();
		}
#pragma warning restore 0169

		IntPtr id_startBbposEmv;
		public unsafe void StartBbposEmv ()
		{
			if (id_startBbposEmv == IntPtr.Zero)
				id_startBbposEmv = JNIEnv.GetMethodID (class_ref, "startBbposEmv", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startBbposEmv);
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
			global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bpn.Payguardian.Android.PayGuardianStatus p0 = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.PayGuardianStatus> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateStatus (p0);
		}
#pragma warning restore 0169

		IntPtr id_updateStatus_Lcom_bpn_payguardian_android_PayGuardianStatus_;
		public unsafe void UpdateStatus (global::Com.Bpn.Payguardian.Android.PayGuardianStatus p0)
		{
			if (id_updateStatus_Lcom_bpn_payguardian_android_PayGuardianStatus_ == IntPtr.Zero)
				id_updateStatus_Lcom_bpn_payguardian_android_PayGuardianStatus_ = JNIEnv.GetMethodID (class_ref, "updateStatus", "(Lcom/bpn/payguardian/android/PayGuardianStatus;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateStatus_Lcom_bpn_payguardian_android_PayGuardianStatus_, __args);
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
			global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Interfaces.IActivityConnector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateStatus (p0);
		}
#pragma warning restore 0169

		IntPtr id_updateStatus_Ljava_lang_String_;
		public unsafe void UpdateStatus (string p0)
		{
			if (id_updateStatus_Ljava_lang_String_ == IntPtr.Zero)
				id_updateStatus_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateStatus", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateStatus_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
