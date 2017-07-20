using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bpn.Payguardian.Android.Payment {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']"
	[global::Android.Runtime.Register ("com/bpn/payguardian/android/payment/PayloadRequestMessage", DoNotGenerateAcw=true)]
	public partial class PayloadRequestMessage : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bpn/payguardian/android/payment/PayloadRequestMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PayloadRequestMessage); }
		}

		protected PayloadRequestMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/constructor[@name='PayloadRequestMessage' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PayloadRequestMessage ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PayloadRequestMessage)) {
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

		static Delegate cb_getAccountHolderName;
#pragma warning disable 0169
		static Delegate GetGetAccountHolderNameHandler ()
		{
			if (cb_getAccountHolderName == null)
				cb_getAccountHolderName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccountHolderName);
			return cb_getAccountHolderName;
		}

		static IntPtr n_GetAccountHolderName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccountHolderName);
		}
#pragma warning restore 0169

		static Delegate cb_setAccountHolderName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAccountHolderName_Ljava_lang_String_Handler ()
		{
			if (cb_setAccountHolderName_Ljava_lang_String_ == null)
				cb_setAccountHolderName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAccountHolderName_Ljava_lang_String_);
			return cb_setAccountHolderName_Ljava_lang_String_;
		}

		static void n_SetAccountHolderName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AccountHolderName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAccountHolderName;
		static IntPtr id_setAccountHolderName_Ljava_lang_String_;
		public virtual unsafe string AccountHolderName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getAccountHolderName' and count(parameter)=0]"
			[Register ("getAccountHolderName", "()Ljava/lang/String;", "GetGetAccountHolderNameHandler")]
			get {
				if (id_getAccountHolderName == IntPtr.Zero)
					id_getAccountHolderName = JNIEnv.GetMethodID (class_ref, "getAccountHolderName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAccountHolderName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAccountHolderName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setAccountHolderName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAccountHolderName", "(Ljava/lang/String;)V", "GetSetAccountHolderName_Ljava_lang_String_Handler")]
			set {
				if (id_setAccountHolderName_Ljava_lang_String_ == IntPtr.Zero)
					id_setAccountHolderName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAccountHolderName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAccountHolderName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAccountHolderName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getAcctType;
#pragma warning disable 0169
		static Delegate GetGetAcctTypeHandler ()
		{
			if (cb_getAcctType == null)
				cb_getAcctType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAcctType);
			return cb_getAcctType;
		}

		static IntPtr n_GetAcctType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AcctType);
		}
#pragma warning restore 0169

		static Delegate cb_setAcctType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAcctType_Ljava_lang_String_Handler ()
		{
			if (cb_setAcctType_Ljava_lang_String_ == null)
				cb_setAcctType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAcctType_Ljava_lang_String_);
			return cb_setAcctType_Ljava_lang_String_;
		}

		static void n_SetAcctType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AcctType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAcctType;
		static IntPtr id_setAcctType_Ljava_lang_String_;
		public virtual unsafe string AcctType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getAcctType' and count(parameter)=0]"
			[Register ("getAcctType", "()Ljava/lang/String;", "GetGetAcctTypeHandler")]
			get {
				if (id_getAcctType == IntPtr.Zero)
					id_getAcctType = JNIEnv.GetMethodID (class_ref, "getAcctType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAcctType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAcctType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setAcctType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAcctType", "(Ljava/lang/String;)V", "GetSetAcctType_Ljava_lang_String_Handler")]
			set {
				if (id_setAcctType_Ljava_lang_String_ == IntPtr.Zero)
					id_setAcctType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAcctType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAcctType_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAcctType", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getAmount;
#pragma warning disable 0169
		static Delegate GetGetAmountHandler ()
		{
			if (cb_getAmount == null)
				cb_getAmount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAmount);
			return cb_getAmount;
		}

		static IntPtr n_GetAmount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Amount);
		}
#pragma warning restore 0169

		static Delegate cb_setAmount_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAmount_Ljava_lang_String_Handler ()
		{
			if (cb_setAmount_Ljava_lang_String_ == null)
				cb_setAmount_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAmount_Ljava_lang_String_);
			return cb_setAmount_Ljava_lang_String_;
		}

		static void n_SetAmount_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Amount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAmount;
		static IntPtr id_setAmount_Ljava_lang_String_;
		public virtual unsafe string Amount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getAmount' and count(parameter)=0]"
			[Register ("getAmount", "()Ljava/lang/String;", "GetGetAmountHandler")]
			get {
				if (id_getAmount == IntPtr.Zero)
					id_getAmount = JNIEnv.GetMethodID (class_ref, "getAmount", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAmount), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAmount", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setAmount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAmount", "(Ljava/lang/String;)V", "GetSetAmount_Ljava_lang_String_Handler")]
			set {
				if (id_setAmount_Ljava_lang_String_ == IntPtr.Zero)
					id_setAmount_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAmount", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAmount_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAmount", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getBankAccountNum;
#pragma warning disable 0169
		static Delegate GetGetBankAccountNumHandler ()
		{
			if (cb_getBankAccountNum == null)
				cb_getBankAccountNum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBankAccountNum);
			return cb_getBankAccountNum;
		}

		static IntPtr n_GetBankAccountNum (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BankAccountNum);
		}
#pragma warning restore 0169

		static Delegate cb_setBankAccountNum_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBankAccountNum_Ljava_lang_String_Handler ()
		{
			if (cb_setBankAccountNum_Ljava_lang_String_ == null)
				cb_setBankAccountNum_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBankAccountNum_Ljava_lang_String_);
			return cb_setBankAccountNum_Ljava_lang_String_;
		}

		static void n_SetBankAccountNum_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BankAccountNum = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBankAccountNum;
		static IntPtr id_setBankAccountNum_Ljava_lang_String_;
		public virtual unsafe string BankAccountNum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getBankAccountNum' and count(parameter)=0]"
			[Register ("getBankAccountNum", "()Ljava/lang/String;", "GetGetBankAccountNumHandler")]
			get {
				if (id_getBankAccountNum == IntPtr.Zero)
					id_getBankAccountNum = JNIEnv.GetMethodID (class_ref, "getBankAccountNum", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBankAccountNum), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBankAccountNum", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setBankAccountNum' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBankAccountNum", "(Ljava/lang/String;)V", "GetSetBankAccountNum_Ljava_lang_String_Handler")]
			set {
				if (id_setBankAccountNum_Ljava_lang_String_ == IntPtr.Zero)
					id_setBankAccountNum_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBankAccountNum", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBankAccountNum_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBankAccountNum", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getBdkSlot;
#pragma warning disable 0169
		static Delegate GetGetBdkSlotHandler ()
		{
			if (cb_getBdkSlot == null)
				cb_getBdkSlot = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBdkSlot);
			return cb_getBdkSlot;
		}

		static IntPtr n_GetBdkSlot (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BdkSlot);
		}
#pragma warning restore 0169

		static Delegate cb_setBdkSlot_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBdkSlot_Ljava_lang_String_Handler ()
		{
			if (cb_setBdkSlot_Ljava_lang_String_ == null)
				cb_setBdkSlot_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBdkSlot_Ljava_lang_String_);
			return cb_setBdkSlot_Ljava_lang_String_;
		}

		static void n_SetBdkSlot_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BdkSlot = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBdkSlot;
		static IntPtr id_setBdkSlot_Ljava_lang_String_;
		public virtual unsafe string BdkSlot {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getBdkSlot' and count(parameter)=0]"
			[Register ("getBdkSlot", "()Ljava/lang/String;", "GetGetBdkSlotHandler")]
			get {
				if (id_getBdkSlot == IntPtr.Zero)
					id_getBdkSlot = JNIEnv.GetMethodID (class_ref, "getBdkSlot", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBdkSlot), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBdkSlot", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setBdkSlot' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBdkSlot", "(Ljava/lang/String;)V", "GetSetBdkSlot_Ljava_lang_String_Handler")]
			set {
				if (id_setBdkSlot_Ljava_lang_String_ == IntPtr.Zero)
					id_setBdkSlot_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBdkSlot", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBdkSlot_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBdkSlot", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getConfirmPassword;
#pragma warning disable 0169
		static Delegate GetGetConfirmPasswordHandler ()
		{
			if (cb_getConfirmPassword == null)
				cb_getConfirmPassword = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConfirmPassword);
			return cb_getConfirmPassword;
		}

		static IntPtr n_GetConfirmPassword (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ConfirmPassword);
		}
#pragma warning restore 0169

		static Delegate cb_setConfirmPassword_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetConfirmPassword_Ljava_lang_String_Handler ()
		{
			if (cb_setConfirmPassword_Ljava_lang_String_ == null)
				cb_setConfirmPassword_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConfirmPassword_Ljava_lang_String_);
			return cb_setConfirmPassword_Ljava_lang_String_;
		}

		static void n_SetConfirmPassword_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ConfirmPassword = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getConfirmPassword;
		static IntPtr id_setConfirmPassword_Ljava_lang_String_;
		public virtual unsafe string ConfirmPassword {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getConfirmPassword' and count(parameter)=0]"
			[Register ("getConfirmPassword", "()Ljava/lang/String;", "GetGetConfirmPasswordHandler")]
			get {
				if (id_getConfirmPassword == IntPtr.Zero)
					id_getConfirmPassword = JNIEnv.GetMethodID (class_ref, "getConfirmPassword", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConfirmPassword), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConfirmPassword", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setConfirmPassword' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setConfirmPassword", "(Ljava/lang/String;)V", "GetSetConfirmPassword_Ljava_lang_String_Handler")]
			set {
				if (id_setConfirmPassword_Ljava_lang_String_ == IntPtr.Zero)
					id_setConfirmPassword_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setConfirmPassword", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setConfirmPassword_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConfirmPassword", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCurrencyCode;
#pragma warning disable 0169
		static Delegate GetGetCurrencyCodeHandler ()
		{
			if (cb_getCurrencyCode == null)
				cb_getCurrencyCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrencyCode);
			return cb_getCurrencyCode;
		}

		static IntPtr n_GetCurrencyCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CurrencyCode);
		}
#pragma warning restore 0169

		static Delegate cb_setCurrencyCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCurrencyCode_Ljava_lang_String_Handler ()
		{
			if (cb_setCurrencyCode_Ljava_lang_String_ == null)
				cb_setCurrencyCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCurrencyCode_Ljava_lang_String_);
			return cb_setCurrencyCode_Ljava_lang_String_;
		}

		static void n_SetCurrencyCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CurrencyCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrencyCode;
		static IntPtr id_setCurrencyCode_Ljava_lang_String_;
		public virtual unsafe string CurrencyCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getCurrencyCode' and count(parameter)=0]"
			[Register ("getCurrencyCode", "()Ljava/lang/String;", "GetGetCurrencyCodeHandler")]
			get {
				if (id_getCurrencyCode == IntPtr.Zero)
					id_getCurrencyCode = JNIEnv.GetMethodID (class_ref, "getCurrencyCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrencyCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrencyCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setCurrencyCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCurrencyCode", "(Ljava/lang/String;)V", "GetSetCurrencyCode_Ljava_lang_String_Handler")]
			set {
				if (id_setCurrencyCode_Ljava_lang_String_ == IntPtr.Zero)
					id_setCurrencyCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCurrencyCode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCurrencyCode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCurrencyCode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDukpt;
#pragma warning disable 0169
		static Delegate GetGetDukptHandler ()
		{
			if (cb_getDukpt == null)
				cb_getDukpt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDukpt);
			return cb_getDukpt;
		}

		static IntPtr n_GetDukpt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Dukpt);
		}
#pragma warning restore 0169

		static Delegate cb_setDukpt_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDukpt_Ljava_lang_String_Handler ()
		{
			if (cb_setDukpt_Ljava_lang_String_ == null)
				cb_setDukpt_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDukpt_Ljava_lang_String_);
			return cb_setDukpt_Ljava_lang_String_;
		}

		static void n_SetDukpt_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Dukpt = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDukpt;
		static IntPtr id_setDukpt_Ljava_lang_String_;
		public virtual unsafe string Dukpt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getDukpt' and count(parameter)=0]"
			[Register ("getDukpt", "()Ljava/lang/String;", "GetGetDukptHandler")]
			get {
				if (id_getDukpt == IntPtr.Zero)
					id_getDukpt = JNIEnv.GetMethodID (class_ref, "getDukpt", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDukpt), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDukpt", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setDukpt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDukpt", "(Ljava/lang/String;)V", "GetSetDukpt_Ljava_lang_String_Handler")]
			set {
				if (id_setDukpt_Ljava_lang_String_ == IntPtr.Zero)
					id_setDukpt_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDukpt", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDukpt_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDukpt", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getEmvEntryMedium;
#pragma warning disable 0169
		static Delegate GetGetEmvEntryMediumHandler ()
		{
			if (cb_getEmvEntryMedium == null)
				cb_getEmvEntryMedium = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEmvEntryMedium);
			return cb_getEmvEntryMedium;
		}

		static IntPtr n_GetEmvEntryMedium (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EmvEntryMedium);
		}
#pragma warning restore 0169

		static Delegate cb_setEmvEntryMedium_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEmvEntryMedium_Ljava_lang_String_Handler ()
		{
			if (cb_setEmvEntryMedium_Ljava_lang_String_ == null)
				cb_setEmvEntryMedium_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEmvEntryMedium_Ljava_lang_String_);
			return cb_setEmvEntryMedium_Ljava_lang_String_;
		}

		static void n_SetEmvEntryMedium_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EmvEntryMedium = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEmvEntryMedium;
		static IntPtr id_setEmvEntryMedium_Ljava_lang_String_;
		public virtual unsafe string EmvEntryMedium {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getEmvEntryMedium' and count(parameter)=0]"
			[Register ("getEmvEntryMedium", "()Ljava/lang/String;", "GetGetEmvEntryMediumHandler")]
			get {
				if (id_getEmvEntryMedium == IntPtr.Zero)
					id_getEmvEntryMedium = JNIEnv.GetMethodID (class_ref, "getEmvEntryMedium", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEmvEntryMedium), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEmvEntryMedium", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setEmvEntryMedium' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEmvEntryMedium", "(Ljava/lang/String;)V", "GetSetEmvEntryMedium_Ljava_lang_String_Handler")]
			set {
				if (id_setEmvEntryMedium_Ljava_lang_String_ == IntPtr.Zero)
					id_setEmvEntryMedium_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEmvEntryMedium", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEmvEntryMedium_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEmvEntryMedium", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getEmvEntryMode;
#pragma warning disable 0169
		static Delegate GetGetEmvEntryModeHandler ()
		{
			if (cb_getEmvEntryMode == null)
				cb_getEmvEntryMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEmvEntryMode);
			return cb_getEmvEntryMode;
		}

		static IntPtr n_GetEmvEntryMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EmvEntryMode);
		}
#pragma warning restore 0169

		static Delegate cb_setEmvEntryMode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEmvEntryMode_Ljava_lang_String_Handler ()
		{
			if (cb_setEmvEntryMode_Ljava_lang_String_ == null)
				cb_setEmvEntryMode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEmvEntryMode_Ljava_lang_String_);
			return cb_setEmvEntryMode_Ljava_lang_String_;
		}

		static void n_SetEmvEntryMode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EmvEntryMode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEmvEntryMode;
		static IntPtr id_setEmvEntryMode_Ljava_lang_String_;
		public virtual unsafe string EmvEntryMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getEmvEntryMode' and count(parameter)=0]"
			[Register ("getEmvEntryMode", "()Ljava/lang/String;", "GetGetEmvEntryModeHandler")]
			get {
				if (id_getEmvEntryMode == IntPtr.Zero)
					id_getEmvEntryMode = JNIEnv.GetMethodID (class_ref, "getEmvEntryMode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEmvEntryMode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEmvEntryMode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setEmvEntryMode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEmvEntryMode", "(Ljava/lang/String;)V", "GetSetEmvEntryMode_Ljava_lang_String_Handler")]
			set {
				if (id_setEmvEntryMode_Ljava_lang_String_ == IntPtr.Zero)
					id_setEmvEntryMode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEmvEntryMode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEmvEntryMode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEmvEntryMode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getEmvEntryPinMode;
#pragma warning disable 0169
		static Delegate GetGetEmvEntryPinModeHandler ()
		{
			if (cb_getEmvEntryPinMode == null)
				cb_getEmvEntryPinMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEmvEntryPinMode);
			return cb_getEmvEntryPinMode;
		}

		static IntPtr n_GetEmvEntryPinMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EmvEntryPinMode);
		}
#pragma warning restore 0169

		static Delegate cb_setEmvEntryPinMode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEmvEntryPinMode_Ljava_lang_String_Handler ()
		{
			if (cb_setEmvEntryPinMode_Ljava_lang_String_ == null)
				cb_setEmvEntryPinMode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEmvEntryPinMode_Ljava_lang_String_);
			return cb_setEmvEntryPinMode_Ljava_lang_String_;
		}

		static void n_SetEmvEntryPinMode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EmvEntryPinMode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEmvEntryPinMode;
		static IntPtr id_setEmvEntryPinMode_Ljava_lang_String_;
		public virtual unsafe string EmvEntryPinMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getEmvEntryPinMode' and count(parameter)=0]"
			[Register ("getEmvEntryPinMode", "()Ljava/lang/String;", "GetGetEmvEntryPinModeHandler")]
			get {
				if (id_getEmvEntryPinMode == IntPtr.Zero)
					id_getEmvEntryPinMode = JNIEnv.GetMethodID (class_ref, "getEmvEntryPinMode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEmvEntryPinMode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEmvEntryPinMode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setEmvEntryPinMode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEmvEntryPinMode", "(Ljava/lang/String;)V", "GetSetEmvEntryPinMode_Ljava_lang_String_Handler")]
			set {
				if (id_setEmvEntryPinMode_Ljava_lang_String_ == IntPtr.Zero)
					id_setEmvEntryPinMode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEmvEntryPinMode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEmvEntryPinMode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEmvEntryPinMode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getEmvTags;
#pragma warning disable 0169
		static Delegate GetGetEmvTagsHandler ()
		{
			if (cb_getEmvTags == null)
				cb_getEmvTags = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEmvTags);
			return cb_getEmvTags;
		}

		static IntPtr n_GetEmvTags (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EmvTags);
		}
#pragma warning restore 0169

		static Delegate cb_setEmvTags_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEmvTags_Ljava_lang_String_Handler ()
		{
			if (cb_setEmvTags_Ljava_lang_String_ == null)
				cb_setEmvTags_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEmvTags_Ljava_lang_String_);
			return cb_setEmvTags_Ljava_lang_String_;
		}

		static void n_SetEmvTags_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EmvTags = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEmvTags;
		static IntPtr id_setEmvTags_Ljava_lang_String_;
		public virtual unsafe string EmvTags {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getEmvTags' and count(parameter)=0]"
			[Register ("getEmvTags", "()Ljava/lang/String;", "GetGetEmvTagsHandler")]
			get {
				if (id_getEmvTags == IntPtr.Zero)
					id_getEmvTags = JNIEnv.GetMethodID (class_ref, "getEmvTags", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEmvTags), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEmvTags", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setEmvTags' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEmvTags", "(Ljava/lang/String;)V", "GetSetEmvTags_Ljava_lang_String_Handler")]
			set {
				if (id_setEmvTags_Ljava_lang_String_ == IntPtr.Zero)
					id_setEmvTags_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEmvTags", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEmvTags_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEmvTags", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getEmvTerminalCapabilities;
#pragma warning disable 0169
		static Delegate GetGetEmvTerminalCapabilitiesHandler ()
		{
			if (cb_getEmvTerminalCapabilities == null)
				cb_getEmvTerminalCapabilities = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEmvTerminalCapabilities);
			return cb_getEmvTerminalCapabilities;
		}

		static IntPtr n_GetEmvTerminalCapabilities (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EmvTerminalCapabilities);
		}
#pragma warning restore 0169

		static Delegate cb_setEmvTerminalCapabilities_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEmvTerminalCapabilities_Ljava_lang_String_Handler ()
		{
			if (cb_setEmvTerminalCapabilities_Ljava_lang_String_ == null)
				cb_setEmvTerminalCapabilities_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEmvTerminalCapabilities_Ljava_lang_String_);
			return cb_setEmvTerminalCapabilities_Ljava_lang_String_;
		}

		static void n_SetEmvTerminalCapabilities_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EmvTerminalCapabilities = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEmvTerminalCapabilities;
		static IntPtr id_setEmvTerminalCapabilities_Ljava_lang_String_;
		public virtual unsafe string EmvTerminalCapabilities {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getEmvTerminalCapabilities' and count(parameter)=0]"
			[Register ("getEmvTerminalCapabilities", "()Ljava/lang/String;", "GetGetEmvTerminalCapabilitiesHandler")]
			get {
				if (id_getEmvTerminalCapabilities == IntPtr.Zero)
					id_getEmvTerminalCapabilities = JNIEnv.GetMethodID (class_ref, "getEmvTerminalCapabilities", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEmvTerminalCapabilities), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEmvTerminalCapabilities", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setEmvTerminalCapabilities' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEmvTerminalCapabilities", "(Ljava/lang/String;)V", "GetSetEmvTerminalCapabilities_Ljava_lang_String_Handler")]
			set {
				if (id_setEmvTerminalCapabilities_Ljava_lang_String_ == IntPtr.Zero)
					id_setEmvTerminalCapabilities_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEmvTerminalCapabilities", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEmvTerminalCapabilities_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEmvTerminalCapabilities", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getExpirationDate;
#pragma warning disable 0169
		static Delegate GetGetExpirationDateHandler ()
		{
			if (cb_getExpirationDate == null)
				cb_getExpirationDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExpirationDate);
			return cb_getExpirationDate;
		}

		static IntPtr n_GetExpirationDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ExpirationDate);
		}
#pragma warning restore 0169

		static Delegate cb_setExpirationDate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetExpirationDate_Ljava_lang_String_Handler ()
		{
			if (cb_setExpirationDate_Ljava_lang_String_ == null)
				cb_setExpirationDate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExpirationDate_Ljava_lang_String_);
			return cb_setExpirationDate_Ljava_lang_String_;
		}

		static void n_SetExpirationDate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ExpirationDate = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getExpirationDate;
		static IntPtr id_setExpirationDate_Ljava_lang_String_;
		public virtual unsafe string ExpirationDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getExpirationDate' and count(parameter)=0]"
			[Register ("getExpirationDate", "()Ljava/lang/String;", "GetGetExpirationDateHandler")]
			get {
				if (id_getExpirationDate == IntPtr.Zero)
					id_getExpirationDate = JNIEnv.GetMethodID (class_ref, "getExpirationDate", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExpirationDate), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExpirationDate", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setExpirationDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setExpirationDate", "(Ljava/lang/String;)V", "GetSetExpirationDate_Ljava_lang_String_Handler")]
			set {
				if (id_setExpirationDate_Ljava_lang_String_ == IntPtr.Zero)
					id_setExpirationDate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setExpirationDate", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setExpirationDate_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExpirationDate", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getFeeAmount;
#pragma warning disable 0169
		static Delegate GetGetFeeAmountHandler ()
		{
			if (cb_getFeeAmount == null)
				cb_getFeeAmount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFeeAmount);
			return cb_getFeeAmount;
		}

		static IntPtr n_GetFeeAmount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FeeAmount);
		}
#pragma warning restore 0169

		static Delegate cb_setFeeAmount_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetFeeAmount_Ljava_lang_Integer_Handler ()
		{
			if (cb_setFeeAmount_Ljava_lang_Integer_ == null)
				cb_setFeeAmount_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFeeAmount_Ljava_lang_Integer_);
			return cb_setFeeAmount_Ljava_lang_Integer_;
		}

		static void n_SetFeeAmount_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FeeAmount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFeeAmount;
		static IntPtr id_setFeeAmount_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer FeeAmount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getFeeAmount' and count(parameter)=0]"
			[Register ("getFeeAmount", "()Ljava/lang/Integer;", "GetGetFeeAmountHandler")]
			get {
				if (id_getFeeAmount == IntPtr.Zero)
					id_getFeeAmount = JNIEnv.GetMethodID (class_ref, "getFeeAmount", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFeeAmount), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFeeAmount", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setFeeAmount' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setFeeAmount", "(Ljava/lang/Integer;)V", "GetSetFeeAmount_Ljava_lang_Integer_Handler")]
			set {
				if (id_setFeeAmount_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setFeeAmount_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setFeeAmount", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFeeAmount_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFeeAmount", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHolderType;
#pragma warning disable 0169
		static Delegate GetGetHolderTypeHandler ()
		{
			if (cb_getHolderType == null)
				cb_getHolderType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHolderType);
			return cb_getHolderType;
		}

		static IntPtr n_GetHolderType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HolderType);
		}
#pragma warning restore 0169

		static Delegate cb_setHolderType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetHolderType_Ljava_lang_String_Handler ()
		{
			if (cb_setHolderType_Ljava_lang_String_ == null)
				cb_setHolderType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHolderType_Ljava_lang_String_);
			return cb_setHolderType_Ljava_lang_String_;
		}

		static void n_SetHolderType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HolderType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getHolderType;
		static IntPtr id_setHolderType_Ljava_lang_String_;
		public virtual unsafe string HolderType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getHolderType' and count(parameter)=0]"
			[Register ("getHolderType", "()Ljava/lang/String;", "GetGetHolderTypeHandler")]
			get {
				if (id_getHolderType == IntPtr.Zero)
					id_getHolderType = JNIEnv.GetMethodID (class_ref, "getHolderType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHolderType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHolderType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setHolderType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setHolderType", "(Ljava/lang/String;)V", "GetSetHolderType_Ljava_lang_String_Handler")]
			set {
				if (id_setHolderType_Ljava_lang_String_ == IntPtr.Zero)
					id_setHolderType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setHolderType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHolderType_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHolderType", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getInvNum;
#pragma warning disable 0169
		static Delegate GetGetInvNumHandler ()
		{
			if (cb_getInvNum == null)
				cb_getInvNum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInvNum);
			return cb_getInvNum;
		}

		static IntPtr n_GetInvNum (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.InvNum);
		}
#pragma warning restore 0169

		static Delegate cb_setInvNum_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetInvNum_Ljava_lang_String_Handler ()
		{
			if (cb_setInvNum_Ljava_lang_String_ == null)
				cb_setInvNum_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInvNum_Ljava_lang_String_);
			return cb_setInvNum_Ljava_lang_String_;
		}

		static void n_SetInvNum_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InvNum = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getInvNum;
		static IntPtr id_setInvNum_Ljava_lang_String_;
		public virtual unsafe string InvNum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getInvNum' and count(parameter)=0]"
			[Register ("getInvNum", "()Ljava/lang/String;", "GetGetInvNumHandler")]
			get {
				if (id_getInvNum == IntPtr.Zero)
					id_getInvNum = JNIEnv.GetMethodID (class_ref, "getInvNum", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInvNum), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInvNum", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setInvNum' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setInvNum", "(Ljava/lang/String;)V", "GetSetInvNum_Ljava_lang_String_Handler")]
			set {
				if (id_setInvNum_Ljava_lang_String_ == IntPtr.Zero)
					id_setInvNum_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setInvNum", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInvNum_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInvNum", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMerchantAccountCode;
#pragma warning disable 0169
		static Delegate GetGetMerchantAccountCodeHandler ()
		{
			if (cb_getMerchantAccountCode == null)
				cb_getMerchantAccountCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMerchantAccountCode);
			return cb_getMerchantAccountCode;
		}

		static IntPtr n_GetMerchantAccountCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MerchantAccountCode);
		}
#pragma warning restore 0169

		static Delegate cb_setMerchantAccountCode_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetMerchantAccountCode_Ljava_lang_Integer_Handler ()
		{
			if (cb_setMerchantAccountCode_Ljava_lang_Integer_ == null)
				cb_setMerchantAccountCode_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMerchantAccountCode_Ljava_lang_Integer_);
			return cb_setMerchantAccountCode_Ljava_lang_Integer_;
		}

		static void n_SetMerchantAccountCode_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MerchantAccountCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMerchantAccountCode;
		static IntPtr id_setMerchantAccountCode_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer MerchantAccountCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getMerchantAccountCode' and count(parameter)=0]"
			[Register ("getMerchantAccountCode", "()Ljava/lang/Integer;", "GetGetMerchantAccountCodeHandler")]
			get {
				if (id_getMerchantAccountCode == IntPtr.Zero)
					id_getMerchantAccountCode = JNIEnv.GetMethodID (class_ref, "getMerchantAccountCode", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMerchantAccountCode), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMerchantAccountCode", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setMerchantAccountCode' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setMerchantAccountCode", "(Ljava/lang/Integer;)V", "GetSetMerchantAccountCode_Ljava_lang_Integer_Handler")]
			set {
				if (id_setMerchantAccountCode_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setMerchantAccountCode_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setMerchantAccountCode", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMerchantAccountCode_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMerchantAccountCode", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMerchantCode;
#pragma warning disable 0169
		static Delegate GetGetMerchantCodeHandler ()
		{
			if (cb_getMerchantCode == null)
				cb_getMerchantCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMerchantCode);
			return cb_getMerchantCode;
		}

		static IntPtr n_GetMerchantCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MerchantCode);
		}
#pragma warning restore 0169

		static Delegate cb_setMerchantCode_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetMerchantCode_Ljava_lang_Integer_Handler ()
		{
			if (cb_setMerchantCode_Ljava_lang_Integer_ == null)
				cb_setMerchantCode_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMerchantCode_Ljava_lang_Integer_);
			return cb_setMerchantCode_Ljava_lang_Integer_;
		}

		static void n_SetMerchantCode_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MerchantCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMerchantCode;
		static IntPtr id_setMerchantCode_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer MerchantCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getMerchantCode' and count(parameter)=0]"
			[Register ("getMerchantCode", "()Ljava/lang/Integer;", "GetGetMerchantCodeHandler")]
			get {
				if (id_getMerchantCode == IntPtr.Zero)
					id_getMerchantCode = JNIEnv.GetMethodID (class_ref, "getMerchantCode", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMerchantCode), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMerchantCode", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setMerchantCode' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setMerchantCode", "(Ljava/lang/Integer;)V", "GetSetMerchantCode_Ljava_lang_Integer_Handler")]
			set {
				if (id_setMerchantCode_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setMerchantCode_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setMerchantCode", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMerchantCode_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMerchantCode", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMsrKsn;
#pragma warning disable 0169
		static Delegate GetGetMsrKsnHandler ()
		{
			if (cb_getMsrKsn == null)
				cb_getMsrKsn = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMsrKsn);
			return cb_getMsrKsn;
		}

		static IntPtr n_GetMsrKsn (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MsrKsn);
		}
#pragma warning restore 0169

		static Delegate cb_setMsrKsn_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMsrKsn_Ljava_lang_String_Handler ()
		{
			if (cb_setMsrKsn_Ljava_lang_String_ == null)
				cb_setMsrKsn_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMsrKsn_Ljava_lang_String_);
			return cb_setMsrKsn_Ljava_lang_String_;
		}

		static void n_SetMsrKsn_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MsrKsn = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMsrKsn;
		static IntPtr id_setMsrKsn_Ljava_lang_String_;
		public virtual unsafe string MsrKsn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getMsrKsn' and count(parameter)=0]"
			[Register ("getMsrKsn", "()Ljava/lang/String;", "GetGetMsrKsnHandler")]
			get {
				if (id_getMsrKsn == IntPtr.Zero)
					id_getMsrKsn = JNIEnv.GetMethodID (class_ref, "getMsrKsn", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMsrKsn), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMsrKsn", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setMsrKsn' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMsrKsn", "(Ljava/lang/String;)V", "GetSetMsrKsn_Ljava_lang_String_Handler")]
			set {
				if (id_setMsrKsn_Ljava_lang_String_ == IntPtr.Zero)
					id_setMsrKsn_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMsrKsn", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMsrKsn_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMsrKsn", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getNewPassword;
#pragma warning disable 0169
		static Delegate GetGetNewPasswordHandler ()
		{
			if (cb_getNewPassword == null)
				cb_getNewPassword = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNewPassword);
			return cb_getNewPassword;
		}

		static IntPtr n_GetNewPassword (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NewPassword);
		}
#pragma warning restore 0169

		static Delegate cb_setNewPassword_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNewPassword_Ljava_lang_String_Handler ()
		{
			if (cb_setNewPassword_Ljava_lang_String_ == null)
				cb_setNewPassword_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNewPassword_Ljava_lang_String_);
			return cb_setNewPassword_Ljava_lang_String_;
		}

		static void n_SetNewPassword_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NewPassword = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNewPassword;
		static IntPtr id_setNewPassword_Ljava_lang_String_;
		public virtual unsafe string NewPassword {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getNewPassword' and count(parameter)=0]"
			[Register ("getNewPassword", "()Ljava/lang/String;", "GetGetNewPasswordHandler")]
			get {
				if (id_getNewPassword == IntPtr.Zero)
					id_getNewPassword = JNIEnv.GetMethodID (class_ref, "getNewPassword", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNewPassword), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNewPassword", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setNewPassword' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNewPassword", "(Ljava/lang/String;)V", "GetSetNewPassword_Ljava_lang_String_Handler")]
			set {
				if (id_setNewPassword_Ljava_lang_String_ == IntPtr.Zero)
					id_setNewPassword_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNewPassword", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNewPassword_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNewPassword", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getOriginatingTechnologySource;
#pragma warning disable 0169
		static Delegate GetGetOriginatingTechnologySourceHandler ()
		{
			if (cb_getOriginatingTechnologySource == null)
				cb_getOriginatingTechnologySource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOriginatingTechnologySource);
			return cb_getOriginatingTechnologySource;
		}

		static IntPtr n_GetOriginatingTechnologySource (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OriginatingTechnologySource);
		}
#pragma warning restore 0169

		static Delegate cb_setOriginatingTechnologySource_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetOriginatingTechnologySource_Ljava_lang_String_Handler ()
		{
			if (cb_setOriginatingTechnologySource_Ljava_lang_String_ == null)
				cb_setOriginatingTechnologySource_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOriginatingTechnologySource_Ljava_lang_String_);
			return cb_setOriginatingTechnologySource_Ljava_lang_String_;
		}

		static void n_SetOriginatingTechnologySource_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OriginatingTechnologySource = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOriginatingTechnologySource;
		static IntPtr id_setOriginatingTechnologySource_Ljava_lang_String_;
		public virtual unsafe string OriginatingTechnologySource {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getOriginatingTechnologySource' and count(parameter)=0]"
			[Register ("getOriginatingTechnologySource", "()Ljava/lang/String;", "GetGetOriginatingTechnologySourceHandler")]
			get {
				if (id_getOriginatingTechnologySource == IntPtr.Zero)
					id_getOriginatingTechnologySource = JNIEnv.GetMethodID (class_ref, "getOriginatingTechnologySource", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOriginatingTechnologySource), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOriginatingTechnologySource", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setOriginatingTechnologySource' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setOriginatingTechnologySource", "(Ljava/lang/String;)V", "GetSetOriginatingTechnologySource_Ljava_lang_String_Handler")]
			set {
				if (id_setOriginatingTechnologySource_Ljava_lang_String_ == IntPtr.Zero)
					id_setOriginatingTechnologySource_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setOriginatingTechnologySource", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOriginatingTechnologySource_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOriginatingTechnologySource", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getPartialAuthorization;
#pragma warning disable 0169
		static Delegate GetGetPartialAuthorizationHandler ()
		{
			if (cb_getPartialAuthorization == null)
				cb_getPartialAuthorization = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPartialAuthorization);
			return cb_getPartialAuthorization;
		}

		static IntPtr n_GetPartialAuthorization (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PartialAuthorization);
		}
#pragma warning restore 0169

		static Delegate cb_setPartialAuthorization_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPartialAuthorization_Ljava_lang_String_Handler ()
		{
			if (cb_setPartialAuthorization_Ljava_lang_String_ == null)
				cb_setPartialAuthorization_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPartialAuthorization_Ljava_lang_String_);
			return cb_setPartialAuthorization_Ljava_lang_String_;
		}

		static void n_SetPartialAuthorization_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PartialAuthorization = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPartialAuthorization;
		static IntPtr id_setPartialAuthorization_Ljava_lang_String_;
		public virtual unsafe string PartialAuthorization {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getPartialAuthorization' and count(parameter)=0]"
			[Register ("getPartialAuthorization", "()Ljava/lang/String;", "GetGetPartialAuthorizationHandler")]
			get {
				if (id_getPartialAuthorization == IntPtr.Zero)
					id_getPartialAuthorization = JNIEnv.GetMethodID (class_ref, "getPartialAuthorization", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPartialAuthorization), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPartialAuthorization", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setPartialAuthorization' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPartialAuthorization", "(Ljava/lang/String;)V", "GetSetPartialAuthorization_Ljava_lang_String_Handler")]
			set {
				if (id_setPartialAuthorization_Ljava_lang_String_ == IntPtr.Zero)
					id_setPartialAuthorization_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPartialAuthorization", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPartialAuthorization_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPartialAuthorization", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getPaymentAccountNumber;
#pragma warning disable 0169
		static Delegate GetGetPaymentAccountNumberHandler ()
		{
			if (cb_getPaymentAccountNumber == null)
				cb_getPaymentAccountNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPaymentAccountNumber);
			return cb_getPaymentAccountNumber;
		}

		static IntPtr n_GetPaymentAccountNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PaymentAccountNumber);
		}
#pragma warning restore 0169

		static Delegate cb_setPaymentAccountNumber_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPaymentAccountNumber_Ljava_lang_String_Handler ()
		{
			if (cb_setPaymentAccountNumber_Ljava_lang_String_ == null)
				cb_setPaymentAccountNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPaymentAccountNumber_Ljava_lang_String_);
			return cb_setPaymentAccountNumber_Ljava_lang_String_;
		}

		static void n_SetPaymentAccountNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PaymentAccountNumber = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPaymentAccountNumber;
		static IntPtr id_setPaymentAccountNumber_Ljava_lang_String_;
		public virtual unsafe string PaymentAccountNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getPaymentAccountNumber' and count(parameter)=0]"
			[Register ("getPaymentAccountNumber", "()Ljava/lang/String;", "GetGetPaymentAccountNumberHandler")]
			get {
				if (id_getPaymentAccountNumber == IntPtr.Zero)
					id_getPaymentAccountNumber = JNIEnv.GetMethodID (class_ref, "getPaymentAccountNumber", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPaymentAccountNumber), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPaymentAccountNumber", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setPaymentAccountNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPaymentAccountNumber", "(Ljava/lang/String;)V", "GetSetPaymentAccountNumber_Ljava_lang_String_Handler")]
			set {
				if (id_setPaymentAccountNumber_Ljava_lang_String_ == IntPtr.Zero)
					id_setPaymentAccountNumber_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPaymentAccountNumber", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPaymentAccountNumber_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPaymentAccountNumber", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getPinCode;
#pragma warning disable 0169
		static Delegate GetGetPinCodeHandler ()
		{
			if (cb_getPinCode == null)
				cb_getPinCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPinCode);
			return cb_getPinCode;
		}

		static IntPtr n_GetPinCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PinCode);
		}
#pragma warning restore 0169

		static Delegate cb_setPinCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPinCode_Ljava_lang_String_Handler ()
		{
			if (cb_setPinCode_Ljava_lang_String_ == null)
				cb_setPinCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPinCode_Ljava_lang_String_);
			return cb_setPinCode_Ljava_lang_String_;
		}

		static void n_SetPinCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PinCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPinCode;
		static IntPtr id_setPinCode_Ljava_lang_String_;
		public virtual unsafe string PinCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getPinCode' and count(parameter)=0]"
			[Register ("getPinCode", "()Ljava/lang/String;", "GetGetPinCodeHandler")]
			get {
				if (id_getPinCode == IntPtr.Zero)
					id_getPinCode = JNIEnv.GetMethodID (class_ref, "getPinCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPinCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPinCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setPinCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPinCode", "(Ljava/lang/String;)V", "GetSetPinCode_Ljava_lang_String_Handler")]
			set {
				if (id_setPinCode_Ljava_lang_String_ == IntPtr.Zero)
					id_setPinCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPinCode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPinCode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPinCode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getPoNum;
#pragma warning disable 0169
		static Delegate GetGetPoNumHandler ()
		{
			if (cb_getPoNum == null)
				cb_getPoNum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPoNum);
			return cb_getPoNum;
		}

		static IntPtr n_GetPoNum (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PoNum);
		}
#pragma warning restore 0169

		static Delegate cb_setPoNum_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPoNum_Ljava_lang_String_Handler ()
		{
			if (cb_setPoNum_Ljava_lang_String_ == null)
				cb_setPoNum_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPoNum_Ljava_lang_String_);
			return cb_setPoNum_Ljava_lang_String_;
		}

		static void n_SetPoNum_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PoNum = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPoNum;
		static IntPtr id_setPoNum_Ljava_lang_String_;
		public virtual unsafe string PoNum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getPoNum' and count(parameter)=0]"
			[Register ("getPoNum", "()Ljava/lang/String;", "GetGetPoNumHandler")]
			get {
				if (id_getPoNum == IntPtr.Zero)
					id_getPoNum = JNIEnv.GetMethodID (class_ref, "getPoNum", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPoNum), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPoNum", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setPoNum' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPoNum", "(Ljava/lang/String;)V", "GetSetPoNum_Ljava_lang_String_Handler")]
			set {
				if (id_setPoNum_Ljava_lang_String_ == IntPtr.Zero)
					id_setPoNum_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPoNum", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPoNum_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPoNum", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getReferenceNumber;
#pragma warning disable 0169
		static Delegate GetGetReferenceNumberHandler ()
		{
			if (cb_getReferenceNumber == null)
				cb_getReferenceNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReferenceNumber);
			return cb_getReferenceNumber;
		}

		static IntPtr n_GetReferenceNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReferenceNumber);
		}
#pragma warning restore 0169

		static Delegate cb_setReferenceNumber_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetReferenceNumber_Ljava_lang_String_Handler ()
		{
			if (cb_setReferenceNumber_Ljava_lang_String_ == null)
				cb_setReferenceNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetReferenceNumber_Ljava_lang_String_);
			return cb_setReferenceNumber_Ljava_lang_String_;
		}

		static void n_SetReferenceNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReferenceNumber = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getReferenceNumber;
		static IntPtr id_setReferenceNumber_Ljava_lang_String_;
		public virtual unsafe string ReferenceNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getReferenceNumber' and count(parameter)=0]"
			[Register ("getReferenceNumber", "()Ljava/lang/String;", "GetGetReferenceNumberHandler")]
			get {
				if (id_getReferenceNumber == IntPtr.Zero)
					id_getReferenceNumber = JNIEnv.GetMethodID (class_ref, "getReferenceNumber", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getReferenceNumber), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReferenceNumber", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setReferenceNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setReferenceNumber", "(Ljava/lang/String;)V", "GetSetReferenceNumber_Ljava_lang_String_Handler")]
			set {
				if (id_setReferenceNumber_Ljava_lang_String_ == IntPtr.Zero)
					id_setReferenceNumber_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setReferenceNumber", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setReferenceNumber_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReferenceNumber", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getRoutingNum;
#pragma warning disable 0169
		static Delegate GetGetRoutingNumHandler ()
		{
			if (cb_getRoutingNum == null)
				cb_getRoutingNum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRoutingNum);
			return cb_getRoutingNum;
		}

		static IntPtr n_GetRoutingNum (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RoutingNum);
		}
#pragma warning restore 0169

		static Delegate cb_setRoutingNum_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRoutingNum_Ljava_lang_String_Handler ()
		{
			if (cb_setRoutingNum_Ljava_lang_String_ == null)
				cb_setRoutingNum_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRoutingNum_Ljava_lang_String_);
			return cb_setRoutingNum_Ljava_lang_String_;
		}

		static void n_SetRoutingNum_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RoutingNum = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRoutingNum;
		static IntPtr id_setRoutingNum_Ljava_lang_String_;
		public virtual unsafe string RoutingNum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getRoutingNum' and count(parameter)=0]"
			[Register ("getRoutingNum", "()Ljava/lang/String;", "GetGetRoutingNumHandler")]
			get {
				if (id_getRoutingNum == IntPtr.Zero)
					id_getRoutingNum = JNIEnv.GetMethodID (class_ref, "getRoutingNum", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRoutingNum), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRoutingNum", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setRoutingNum' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRoutingNum", "(Ljava/lang/String;)V", "GetSetRoutingNum_Ljava_lang_String_Handler")]
			set {
				if (id_setRoutingNum_Ljava_lang_String_ == IntPtr.Zero)
					id_setRoutingNum_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRoutingNum", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRoutingNum_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRoutingNum", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSecureFormat;
#pragma warning disable 0169
		static Delegate GetGetSecureFormatHandler ()
		{
			if (cb_getSecureFormat == null)
				cb_getSecureFormat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSecureFormat);
			return cb_getSecureFormat;
		}

		static IntPtr n_GetSecureFormat (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SecureFormat);
		}
#pragma warning restore 0169

		static Delegate cb_setSecureFormat_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSecureFormat_Ljava_lang_String_Handler ()
		{
			if (cb_setSecureFormat_Ljava_lang_String_ == null)
				cb_setSecureFormat_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSecureFormat_Ljava_lang_String_);
			return cb_setSecureFormat_Ljava_lang_String_;
		}

		static void n_SetSecureFormat_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SecureFormat = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSecureFormat;
		static IntPtr id_setSecureFormat_Ljava_lang_String_;
		public virtual unsafe string SecureFormat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getSecureFormat' and count(parameter)=0]"
			[Register ("getSecureFormat", "()Ljava/lang/String;", "GetGetSecureFormatHandler")]
			get {
				if (id_getSecureFormat == IntPtr.Zero)
					id_getSecureFormat = JNIEnv.GetMethodID (class_ref, "getSecureFormat", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSecureFormat), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSecureFormat", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setSecureFormat' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSecureFormat", "(Ljava/lang/String;)V", "GetSetSecureFormat_Ljava_lang_String_Handler")]
			set {
				if (id_setSecureFormat_Ljava_lang_String_ == IntPtr.Zero)
					id_setSecureFormat_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSecureFormat", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSecureFormat_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSecureFormat", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSecurityCode;
#pragma warning disable 0169
		static Delegate GetGetSecurityCodeHandler ()
		{
			if (cb_getSecurityCode == null)
				cb_getSecurityCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSecurityCode);
			return cb_getSecurityCode;
		}

		static IntPtr n_GetSecurityCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SecurityCode);
		}
#pragma warning restore 0169

		static Delegate cb_setSecurityCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSecurityCode_Ljava_lang_String_Handler ()
		{
			if (cb_setSecurityCode_Ljava_lang_String_ == null)
				cb_setSecurityCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSecurityCode_Ljava_lang_String_);
			return cb_setSecurityCode_Ljava_lang_String_;
		}

		static void n_SetSecurityCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SecurityCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSecurityCode;
		static IntPtr id_setSecurityCode_Ljava_lang_String_;
		public virtual unsafe string SecurityCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getSecurityCode' and count(parameter)=0]"
			[Register ("getSecurityCode", "()Ljava/lang/String;", "GetGetSecurityCodeHandler")]
			get {
				if (id_getSecurityCode == IntPtr.Zero)
					id_getSecurityCode = JNIEnv.GetMethodID (class_ref, "getSecurityCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSecurityCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSecurityCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setSecurityCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSecurityCode", "(Ljava/lang/String;)V", "GetSetSecurityCode_Ljava_lang_String_Handler")]
			set {
				if (id_setSecurityCode_Ljava_lang_String_ == IntPtr.Zero)
					id_setSecurityCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSecurityCode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSecurityCode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSecurityCode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getShipToState;
#pragma warning disable 0169
		static Delegate GetGetShipToStateHandler ()
		{
			if (cb_getShipToState == null)
				cb_getShipToState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetShipToState);
			return cb_getShipToState;
		}

		static IntPtr n_GetShipToState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ShipToState);
		}
#pragma warning restore 0169

		static Delegate cb_setShipToState_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetShipToState_Ljava_lang_String_Handler ()
		{
			if (cb_setShipToState_Ljava_lang_String_ == null)
				cb_setShipToState_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetShipToState_Ljava_lang_String_);
			return cb_setShipToState_Ljava_lang_String_;
		}

		static void n_SetShipToState_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShipToState = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getShipToState;
		static IntPtr id_setShipToState_Ljava_lang_String_;
		public virtual unsafe string ShipToState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getShipToState' and count(parameter)=0]"
			[Register ("getShipToState", "()Ljava/lang/String;", "GetGetShipToStateHandler")]
			get {
				if (id_getShipToState == IntPtr.Zero)
					id_getShipToState = JNIEnv.GetMethodID (class_ref, "getShipToState", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getShipToState), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getShipToState", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setShipToState' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setShipToState", "(Ljava/lang/String;)V", "GetSetShipToState_Ljava_lang_String_Handler")]
			set {
				if (id_setShipToState_Ljava_lang_String_ == IntPtr.Zero)
					id_setShipToState_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setShipToState", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setShipToState_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShipToState", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getShipToStreet;
#pragma warning disable 0169
		static Delegate GetGetShipToStreetHandler ()
		{
			if (cb_getShipToStreet == null)
				cb_getShipToStreet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetShipToStreet);
			return cb_getShipToStreet;
		}

		static IntPtr n_GetShipToStreet (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ShipToStreet);
		}
#pragma warning restore 0169

		static Delegate cb_setShipToStreet_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetShipToStreet_Ljava_lang_String_Handler ()
		{
			if (cb_setShipToStreet_Ljava_lang_String_ == null)
				cb_setShipToStreet_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetShipToStreet_Ljava_lang_String_);
			return cb_setShipToStreet_Ljava_lang_String_;
		}

		static void n_SetShipToStreet_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShipToStreet = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getShipToStreet;
		static IntPtr id_setShipToStreet_Ljava_lang_String_;
		public virtual unsafe string ShipToStreet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getShipToStreet' and count(parameter)=0]"
			[Register ("getShipToStreet", "()Ljava/lang/String;", "GetGetShipToStreetHandler")]
			get {
				if (id_getShipToStreet == IntPtr.Zero)
					id_getShipToStreet = JNIEnv.GetMethodID (class_ref, "getShipToStreet", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getShipToStreet), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getShipToStreet", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setShipToStreet' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setShipToStreet", "(Ljava/lang/String;)V", "GetSetShipToStreet_Ljava_lang_String_Handler")]
			set {
				if (id_setShipToStreet_Ljava_lang_String_ == IntPtr.Zero)
					id_setShipToStreet_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setShipToStreet", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setShipToStreet_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShipToStreet", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getShipToZip;
#pragma warning disable 0169
		static Delegate GetGetShipToZipHandler ()
		{
			if (cb_getShipToZip == null)
				cb_getShipToZip = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetShipToZip);
			return cb_getShipToZip;
		}

		static IntPtr n_GetShipToZip (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ShipToZip);
		}
#pragma warning restore 0169

		static Delegate cb_setShipToZip_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetShipToZip_Ljava_lang_String_Handler ()
		{
			if (cb_setShipToZip_Ljava_lang_String_ == null)
				cb_setShipToZip_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetShipToZip_Ljava_lang_String_);
			return cb_setShipToZip_Ljava_lang_String_;
		}

		static void n_SetShipToZip_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShipToZip = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getShipToZip;
		static IntPtr id_setShipToZip_Ljava_lang_String_;
		public virtual unsafe string ShipToZip {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getShipToZip' and count(parameter)=0]"
			[Register ("getShipToZip", "()Ljava/lang/String;", "GetGetShipToZipHandler")]
			get {
				if (id_getShipToZip == IntPtr.Zero)
					id_getShipToZip = JNIEnv.GetMethodID (class_ref, "getShipToZip", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getShipToZip), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getShipToZip", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setShipToZip' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setShipToZip", "(Ljava/lang/String;)V", "GetSetShipToZip_Ljava_lang_String_Handler")]
			set {
				if (id_setShipToZip_Ljava_lang_String_ == IntPtr.Zero)
					id_setShipToZip_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setShipToZip", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setShipToZip_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShipToZip", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTaxAmount;
#pragma warning disable 0169
		static Delegate GetGetTaxAmountHandler ()
		{
			if (cb_getTaxAmount == null)
				cb_getTaxAmount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTaxAmount);
			return cb_getTaxAmount;
		}

		static IntPtr n_GetTaxAmount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TaxAmount);
		}
#pragma warning restore 0169

		static Delegate cb_setTaxAmount_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetTaxAmount_Ljava_lang_Integer_Handler ()
		{
			if (cb_setTaxAmount_Ljava_lang_Integer_ == null)
				cb_setTaxAmount_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTaxAmount_Ljava_lang_Integer_);
			return cb_setTaxAmount_Ljava_lang_Integer_;
		}

		static void n_SetTaxAmount_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TaxAmount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTaxAmount;
		static IntPtr id_setTaxAmount_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer TaxAmount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getTaxAmount' and count(parameter)=0]"
			[Register ("getTaxAmount", "()Ljava/lang/Integer;", "GetGetTaxAmountHandler")]
			get {
				if (id_getTaxAmount == IntPtr.Zero)
					id_getTaxAmount = JNIEnv.GetMethodID (class_ref, "getTaxAmount", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTaxAmount), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTaxAmount", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setTaxAmount' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setTaxAmount", "(Ljava/lang/Integer;)V", "GetSetTaxAmount_Ljava_lang_Integer_Handler")]
			set {
				if (id_setTaxAmount_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setTaxAmount_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setTaxAmount", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTaxAmount_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTaxAmount", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTaxRate;
#pragma warning disable 0169
		static Delegate GetGetTaxRateHandler ()
		{
			if (cb_getTaxRate == null)
				cb_getTaxRate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTaxRate);
			return cb_getTaxRate;
		}

		static IntPtr n_GetTaxRate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TaxRate);
		}
#pragma warning restore 0169

		static Delegate cb_setTaxRate_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetTaxRate_Ljava_lang_Integer_Handler ()
		{
			if (cb_setTaxRate_Ljava_lang_Integer_ == null)
				cb_setTaxRate_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTaxRate_Ljava_lang_Integer_);
			return cb_setTaxRate_Ljava_lang_Integer_;
		}

		static void n_SetTaxRate_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TaxRate = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTaxRate;
		static IntPtr id_setTaxRate_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer TaxRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getTaxRate' and count(parameter)=0]"
			[Register ("getTaxRate", "()Ljava/lang/Integer;", "GetGetTaxRateHandler")]
			get {
				if (id_getTaxRate == IntPtr.Zero)
					id_getTaxRate = JNIEnv.GetMethodID (class_ref, "getTaxRate", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTaxRate), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTaxRate", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setTaxRate' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setTaxRate", "(Ljava/lang/Integer;)V", "GetSetTaxRate_Ljava_lang_Integer_Handler")]
			set {
				if (id_setTaxRate_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setTaxRate_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setTaxRate", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTaxRate_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTaxRate", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTerminalType;
#pragma warning disable 0169
		static Delegate GetGetTerminalTypeHandler ()
		{
			if (cb_getTerminalType == null)
				cb_getTerminalType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTerminalType);
			return cb_getTerminalType;
		}

		static IntPtr n_GetTerminalType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TerminalType);
		}
#pragma warning restore 0169

		static Delegate cb_setTerminalType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTerminalType_Ljava_lang_String_Handler ()
		{
			if (cb_setTerminalType_Ljava_lang_String_ == null)
				cb_setTerminalType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTerminalType_Ljava_lang_String_);
			return cb_setTerminalType_Ljava_lang_String_;
		}

		static void n_SetTerminalType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TerminalType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTerminalType;
		static IntPtr id_setTerminalType_Ljava_lang_String_;
		public virtual unsafe string TerminalType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getTerminalType' and count(parameter)=0]"
			[Register ("getTerminalType", "()Ljava/lang/String;", "GetGetTerminalTypeHandler")]
			get {
				if (id_getTerminalType == IntPtr.Zero)
					id_getTerminalType = JNIEnv.GetMethodID (class_ref, "getTerminalType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTerminalType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTerminalType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setTerminalType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTerminalType", "(Ljava/lang/String;)V", "GetSetTerminalType_Ljava_lang_String_Handler")]
			set {
				if (id_setTerminalType_Ljava_lang_String_ == IntPtr.Zero)
					id_setTerminalType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTerminalType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTerminalType_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTerminalType", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTipAmount;
#pragma warning disable 0169
		static Delegate GetGetTipAmountHandler ()
		{
			if (cb_getTipAmount == null)
				cb_getTipAmount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTipAmount);
			return cb_getTipAmount;
		}

		static IntPtr n_GetTipAmount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TipAmount);
		}
#pragma warning restore 0169

		static Delegate cb_setTipAmount_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetTipAmount_Ljava_lang_Integer_Handler ()
		{
			if (cb_setTipAmount_Ljava_lang_Integer_ == null)
				cb_setTipAmount_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTipAmount_Ljava_lang_Integer_);
			return cb_setTipAmount_Ljava_lang_Integer_;
		}

		static void n_SetTipAmount_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TipAmount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTipAmount;
		static IntPtr id_setTipAmount_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer TipAmount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getTipAmount' and count(parameter)=0]"
			[Register ("getTipAmount", "()Ljava/lang/Integer;", "GetGetTipAmountHandler")]
			get {
				if (id_getTipAmount == IntPtr.Zero)
					id_getTipAmount = JNIEnv.GetMethodID (class_ref, "getTipAmount", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTipAmount), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTipAmount", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setTipAmount' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setTipAmount", "(Ljava/lang/Integer;)V", "GetSetTipAmount_Ljava_lang_Integer_Handler")]
			set {
				if (id_setTipAmount_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setTipAmount_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setTipAmount", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTipAmount_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTipAmount", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getToken;
#pragma warning disable 0169
		static Delegate GetGetTokenHandler ()
		{
			if (cb_getToken == null)
				cb_getToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetToken);
			return cb_getToken;
		}

		static IntPtr n_GetToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Token);
		}
#pragma warning restore 0169

		static Delegate cb_setToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetToken_Ljava_lang_String_Handler ()
		{
			if (cb_setToken_Ljava_lang_String_ == null)
				cb_setToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetToken_Ljava_lang_String_);
			return cb_setToken_Ljava_lang_String_;
		}

		static void n_SetToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Token = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getToken;
		static IntPtr id_setToken_Ljava_lang_String_;
		public virtual unsafe string Token {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getToken' and count(parameter)=0]"
			[Register ("getToken", "()Ljava/lang/String;", "GetGetTokenHandler")]
			get {
				if (id_getToken == IntPtr.Zero)
					id_getToken = JNIEnv.GetMethodID (class_ref, "getToken", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getToken), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getToken", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setToken", "(Ljava/lang/String;)V", "GetSetToken_Ljava_lang_String_Handler")]
			set {
				if (id_setToken_Ljava_lang_String_ == IntPtr.Zero)
					id_setToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setToken", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setToken_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setToken", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTrack1;
#pragma warning disable 0169
		static Delegate GetGetTrack1Handler ()
		{
			if (cb_getTrack1 == null)
				cb_getTrack1 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrack1);
			return cb_getTrack1;
		}

		static IntPtr n_GetTrack1 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Track1);
		}
#pragma warning restore 0169

		static Delegate cb_setTrack1_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTrack1_Ljava_lang_String_Handler ()
		{
			if (cb_setTrack1_Ljava_lang_String_ == null)
				cb_setTrack1_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTrack1_Ljava_lang_String_);
			return cb_setTrack1_Ljava_lang_String_;
		}

		static void n_SetTrack1_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Track1 = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTrack1;
		static IntPtr id_setTrack1_Ljava_lang_String_;
		public virtual unsafe string Track1 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getTrack1' and count(parameter)=0]"
			[Register ("getTrack1", "()Ljava/lang/String;", "GetGetTrack1Handler")]
			get {
				if (id_getTrack1 == IntPtr.Zero)
					id_getTrack1 = JNIEnv.GetMethodID (class_ref, "getTrack1", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrack1), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrack1", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setTrack1' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTrack1", "(Ljava/lang/String;)V", "GetSetTrack1_Ljava_lang_String_Handler")]
			set {
				if (id_setTrack1_Ljava_lang_String_ == IntPtr.Zero)
					id_setTrack1_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTrack1", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTrack1_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTrack1", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTrack2;
#pragma warning disable 0169
		static Delegate GetGetTrack2Handler ()
		{
			if (cb_getTrack2 == null)
				cb_getTrack2 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrack2);
			return cb_getTrack2;
		}

		static IntPtr n_GetTrack2 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Track2);
		}
#pragma warning restore 0169

		static Delegate cb_setTrack2_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTrack2_Ljava_lang_String_Handler ()
		{
			if (cb_setTrack2_Ljava_lang_String_ == null)
				cb_setTrack2_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTrack2_Ljava_lang_String_);
			return cb_setTrack2_Ljava_lang_String_;
		}

		static void n_SetTrack2_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Track2 = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTrack2;
		static IntPtr id_setTrack2_Ljava_lang_String_;
		public virtual unsafe string Track2 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getTrack2' and count(parameter)=0]"
			[Register ("getTrack2", "()Ljava/lang/String;", "GetGetTrack2Handler")]
			get {
				if (id_getTrack2 == IntPtr.Zero)
					id_getTrack2 = JNIEnv.GetMethodID (class_ref, "getTrack2", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrack2), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrack2", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setTrack2' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTrack2", "(Ljava/lang/String;)V", "GetSetTrack2_Ljava_lang_String_Handler")]
			set {
				if (id_setTrack2_Ljava_lang_String_ == IntPtr.Zero)
					id_setTrack2_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTrack2", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTrack2_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTrack2", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTrack3;
#pragma warning disable 0169
		static Delegate GetGetTrack3Handler ()
		{
			if (cb_getTrack3 == null)
				cb_getTrack3 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrack3);
			return cb_getTrack3;
		}

		static IntPtr n_GetTrack3 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Track3);
		}
#pragma warning restore 0169

		static Delegate cb_setTrack3_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTrack3_Ljava_lang_String_Handler ()
		{
			if (cb_setTrack3_Ljava_lang_String_ == null)
				cb_setTrack3_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTrack3_Ljava_lang_String_);
			return cb_setTrack3_Ljava_lang_String_;
		}

		static void n_SetTrack3_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Track3 = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTrack3;
		static IntPtr id_setTrack3_Ljava_lang_String_;
		public virtual unsafe string Track3 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getTrack3' and count(parameter)=0]"
			[Register ("getTrack3", "()Ljava/lang/String;", "GetGetTrack3Handler")]
			get {
				if (id_getTrack3 == IntPtr.Zero)
					id_getTrack3 = JNIEnv.GetMethodID (class_ref, "getTrack3", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrack3), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrack3", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setTrack3' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTrack3", "(Ljava/lang/String;)V", "GetSetTrack3_Ljava_lang_String_Handler")]
			set {
				if (id_setTrack3_Ljava_lang_String_ == IntPtr.Zero)
					id_setTrack3_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTrack3", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTrack3_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTrack3", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTrackData;
#pragma warning disable 0169
		static Delegate GetGetTrackDataHandler ()
		{
			if (cb_getTrackData == null)
				cb_getTrackData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrackData);
			return cb_getTrackData;
		}

		static IntPtr n_GetTrackData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TrackData);
		}
#pragma warning restore 0169

		static Delegate cb_setTrackData_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTrackData_Ljava_lang_String_Handler ()
		{
			if (cb_setTrackData_Ljava_lang_String_ == null)
				cb_setTrackData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTrackData_Ljava_lang_String_);
			return cb_setTrackData_Ljava_lang_String_;
		}

		static void n_SetTrackData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TrackData = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTrackData;
		static IntPtr id_setTrackData_Ljava_lang_String_;
		public virtual unsafe string TrackData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getTrackData' and count(parameter)=0]"
			[Register ("getTrackData", "()Ljava/lang/String;", "GetGetTrackDataHandler")]
			get {
				if (id_getTrackData == IntPtr.Zero)
					id_getTrackData = JNIEnv.GetMethodID (class_ref, "getTrackData", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrackData), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrackData", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setTrackData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTrackData", "(Ljava/lang/String;)V", "GetSetTrackData_Ljava_lang_String_Handler")]
			set {
				if (id_setTrackData_Ljava_lang_String_ == IntPtr.Zero)
					id_setTrackData_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTrackData", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTrackData_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTrackData", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTrackIdentifier;
#pragma warning disable 0169
		static Delegate GetGetTrackIdentifierHandler ()
		{
			if (cb_getTrackIdentifier == null)
				cb_getTrackIdentifier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrackIdentifier);
			return cb_getTrackIdentifier;
		}

		static IntPtr n_GetTrackIdentifier (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TrackIdentifier);
		}
#pragma warning restore 0169

		static Delegate cb_setTrackIdentifier_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTrackIdentifier_Ljava_lang_String_Handler ()
		{
			if (cb_setTrackIdentifier_Ljava_lang_String_ == null)
				cb_setTrackIdentifier_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTrackIdentifier_Ljava_lang_String_);
			return cb_setTrackIdentifier_Ljava_lang_String_;
		}

		static void n_SetTrackIdentifier_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TrackIdentifier = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTrackIdentifier;
		static IntPtr id_setTrackIdentifier_Ljava_lang_String_;
		public virtual unsafe string TrackIdentifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getTrackIdentifier' and count(parameter)=0]"
			[Register ("getTrackIdentifier", "()Ljava/lang/String;", "GetGetTrackIdentifierHandler")]
			get {
				if (id_getTrackIdentifier == IntPtr.Zero)
					id_getTrackIdentifier = JNIEnv.GetMethodID (class_ref, "getTrackIdentifier", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrackIdentifier), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrackIdentifier", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setTrackIdentifier' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTrackIdentifier", "(Ljava/lang/String;)V", "GetSetTrackIdentifier_Ljava_lang_String_Handler")]
			set {
				if (id_setTrackIdentifier_Ljava_lang_String_ == IntPtr.Zero)
					id_setTrackIdentifier_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTrackIdentifier", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTrackIdentifier_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTrackIdentifier", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTrackIndicator;
#pragma warning disable 0169
		static Delegate GetGetTrackIndicatorHandler ()
		{
			if (cb_getTrackIndicator == null)
				cb_getTrackIndicator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrackIndicator);
			return cb_getTrackIndicator;
		}

		static IntPtr n_GetTrackIndicator (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TrackIndicator);
		}
#pragma warning restore 0169

		static Delegate cb_setTrackIndicator_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTrackIndicator_Ljava_lang_String_Handler ()
		{
			if (cb_setTrackIndicator_Ljava_lang_String_ == null)
				cb_setTrackIndicator_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTrackIndicator_Ljava_lang_String_);
			return cb_setTrackIndicator_Ljava_lang_String_;
		}

		static void n_SetTrackIndicator_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TrackIndicator = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTrackIndicator;
		static IntPtr id_setTrackIndicator_Ljava_lang_String_;
		public virtual unsafe string TrackIndicator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getTrackIndicator' and count(parameter)=0]"
			[Register ("getTrackIndicator", "()Ljava/lang/String;", "GetGetTrackIndicatorHandler")]
			get {
				if (id_getTrackIndicator == IntPtr.Zero)
					id_getTrackIndicator = JNIEnv.GetMethodID (class_ref, "getTrackIndicator", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrackIndicator), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrackIndicator", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setTrackIndicator' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTrackIndicator", "(Ljava/lang/String;)V", "GetSetTrackIndicator_Ljava_lang_String_Handler")]
			set {
				if (id_setTrackIndicator_Ljava_lang_String_ == IntPtr.Zero)
					id_setTrackIndicator_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTrackIndicator", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTrackIndicator_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTrackIndicator", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTransCatCode;
#pragma warning disable 0169
		static Delegate GetGetTransCatCodeHandler ()
		{
			if (cb_getTransCatCode == null)
				cb_getTransCatCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransCatCode);
			return cb_getTransCatCode;
		}

		static IntPtr n_GetTransCatCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TransCatCode);
		}
#pragma warning restore 0169

		static Delegate cb_setTransCatCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTransCatCode_Ljava_lang_String_Handler ()
		{
			if (cb_setTransCatCode_Ljava_lang_String_ == null)
				cb_setTransCatCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTransCatCode_Ljava_lang_String_);
			return cb_setTransCatCode_Ljava_lang_String_;
		}

		static void n_SetTransCatCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TransCatCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTransCatCode;
		static IntPtr id_setTransCatCode_Ljava_lang_String_;
		public virtual unsafe string TransCatCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getTransCatCode' and count(parameter)=0]"
			[Register ("getTransCatCode", "()Ljava/lang/String;", "GetGetTransCatCodeHandler")]
			get {
				if (id_getTransCatCode == IntPtr.Zero)
					id_getTransCatCode = JNIEnv.GetMethodID (class_ref, "getTransCatCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTransCatCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransCatCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setTransCatCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTransCatCode", "(Ljava/lang/String;)V", "GetSetTransCatCode_Ljava_lang_String_Handler")]
			set {
				if (id_setTransCatCode_Ljava_lang_String_ == IntPtr.Zero)
					id_setTransCatCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTransCatCode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTransCatCode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTransCatCode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTransIndustryType;
#pragma warning disable 0169
		static Delegate GetGetTransIndustryTypeHandler ()
		{
			if (cb_getTransIndustryType == null)
				cb_getTransIndustryType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransIndustryType);
			return cb_getTransIndustryType;
		}

		static IntPtr n_GetTransIndustryType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TransIndustryType);
		}
#pragma warning restore 0169

		static Delegate cb_setTransIndustryType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTransIndustryType_Ljava_lang_String_Handler ()
		{
			if (cb_setTransIndustryType_Ljava_lang_String_ == null)
				cb_setTransIndustryType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTransIndustryType_Ljava_lang_String_);
			return cb_setTransIndustryType_Ljava_lang_String_;
		}

		static void n_SetTransIndustryType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TransIndustryType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTransIndustryType;
		static IntPtr id_setTransIndustryType_Ljava_lang_String_;
		public virtual unsafe string TransIndustryType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getTransIndustryType' and count(parameter)=0]"
			[Register ("getTransIndustryType", "()Ljava/lang/String;", "GetGetTransIndustryTypeHandler")]
			get {
				if (id_getTransIndustryType == IntPtr.Zero)
					id_getTransIndustryType = JNIEnv.GetMethodID (class_ref, "getTransIndustryType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTransIndustryType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransIndustryType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setTransIndustryType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTransIndustryType", "(Ljava/lang/String;)V", "GetSetTransIndustryType_Ljava_lang_String_Handler")]
			set {
				if (id_setTransIndustryType_Ljava_lang_String_ == IntPtr.Zero)
					id_setTransIndustryType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTransIndustryType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTransIndustryType_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTransIndustryType", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTransactionCode;
#pragma warning disable 0169
		static Delegate GetGetTransactionCodeHandler ()
		{
			if (cb_getTransactionCode == null)
				cb_getTransactionCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransactionCode);
			return cb_getTransactionCode;
		}

		static IntPtr n_GetTransactionCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TransactionCode);
		}
#pragma warning restore 0169

		static Delegate cb_setTransactionCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTransactionCode_Ljava_lang_String_Handler ()
		{
			if (cb_setTransactionCode_Ljava_lang_String_ == null)
				cb_setTransactionCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTransactionCode_Ljava_lang_String_);
			return cb_setTransactionCode_Ljava_lang_String_;
		}

		static void n_SetTransactionCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TransactionCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTransactionCode;
		static IntPtr id_setTransactionCode_Ljava_lang_String_;
		public virtual unsafe string TransactionCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getTransactionCode' and count(parameter)=0]"
			[Register ("getTransactionCode", "()Ljava/lang/String;", "GetGetTransactionCodeHandler")]
			get {
				if (id_getTransactionCode == IntPtr.Zero)
					id_getTransactionCode = JNIEnv.GetMethodID (class_ref, "getTransactionCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTransactionCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransactionCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setTransactionCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTransactionCode", "(Ljava/lang/String;)V", "GetSetTransactionCode_Ljava_lang_String_Handler")]
			set {
				if (id_setTransactionCode_Ljava_lang_String_ == IntPtr.Zero)
					id_setTransactionCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTransactionCode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTransactionCode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTransactionCode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTransactionType;
#pragma warning disable 0169
		static Delegate GetGetTransactionTypeHandler ()
		{
			if (cb_getTransactionType == null)
				cb_getTransactionType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransactionType);
			return cb_getTransactionType;
		}

		static IntPtr n_GetTransactionType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TransactionType);
		}
#pragma warning restore 0169

		static Delegate cb_setTransactionType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTransactionType_Ljava_lang_String_Handler ()
		{
			if (cb_setTransactionType_Ljava_lang_String_ == null)
				cb_setTransactionType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTransactionType_Ljava_lang_String_);
			return cb_setTransactionType_Ljava_lang_String_;
		}

		static void n_SetTransactionType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Payment.PayloadRequestMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TransactionType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTransactionType;
		static IntPtr id_setTransactionType_Ljava_lang_String_;
		public virtual unsafe string TransactionType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='getTransactionType' and count(parameter)=0]"
			[Register ("getTransactionType", "()Ljava/lang/String;", "GetGetTransactionTypeHandler")]
			get {
				if (id_getTransactionType == IntPtr.Zero)
					id_getTransactionType = JNIEnv.GetMethodID (class_ref, "getTransactionType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTransactionType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransactionType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.payment']/class[@name='PayloadRequestMessage']/method[@name='setTransactionType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTransactionType", "(Ljava/lang/String;)V", "GetSetTransactionType_Ljava_lang_String_Handler")]
			set {
				if (id_setTransactionType_Ljava_lang_String_ == IntPtr.Zero)
					id_setTransactionType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTransactionType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTransactionType_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTransactionType", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
