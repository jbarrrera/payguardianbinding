using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bpn.Payguardian.Android.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']"
	[global::Android.Runtime.Register ("com/bpn/payguardian/android/entity/PaymentRequestEntity", DoNotGenerateAcw=true)]
	public partial class PaymentRequestEntity : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bpn/payguardian/android/entity/PaymentRequestEntity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PaymentRequestEntity); }
		}

		protected PaymentRequestEntity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/constructor[@name='PaymentRequestEntity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PaymentRequestEntity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PaymentRequestEntity)) {
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

		static Delegate cb_getAccType;
#pragma warning disable 0169
		static Delegate GetGetAccTypeHandler ()
		{
			if (cb_getAccType == null)
				cb_getAccType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccType);
			return cb_getAccType;
		}

		static IntPtr n_GetAccType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccType);
		}
#pragma warning restore 0169

		static Delegate cb_setAccType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAccType_Ljava_lang_String_Handler ()
		{
			if (cb_setAccType_Ljava_lang_String_ == null)
				cb_setAccType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAccType_Ljava_lang_String_);
			return cb_setAccType_Ljava_lang_String_;
		}

		static void n_SetAccType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AccType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAccType;
		static IntPtr id_setAccType_Ljava_lang_String_;
		public virtual unsafe string AccType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getAccType' and count(parameter)=0]"
			[Register ("getAccType", "()Ljava/lang/String;", "GetGetAccTypeHandler")]
			get {
				if (id_getAccType == IntPtr.Zero)
					id_getAccType = JNIEnv.GetMethodID (class_ref, "getAccType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAccType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAccType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setAccType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAccType", "(Ljava/lang/String;)V", "GetSetAccType_Ljava_lang_String_Handler")]
			set {
				if (id_setAccType_Ljava_lang_String_ == IntPtr.Zero)
					id_setAccType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAccType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAccType_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAccType", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Amount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAmount;
		static IntPtr id_setAmount_Ljava_lang_String_;
		public virtual unsafe string Amount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getAmount' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setAmount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BdkSlot = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBdkSlot;
		static IntPtr id_setBdkSlot_Ljava_lang_String_;
		public virtual unsafe string BdkSlot {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getBdkSlot' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setBdkSlot' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getCardNum;
#pragma warning disable 0169
		static Delegate GetGetCardNumHandler ()
		{
			if (cb_getCardNum == null)
				cb_getCardNum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCardNum);
			return cb_getCardNum;
		}

		static IntPtr n_GetCardNum (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CardNum);
		}
#pragma warning restore 0169

		static Delegate cb_setCardNum_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCardNum_Ljava_lang_String_Handler ()
		{
			if (cb_setCardNum_Ljava_lang_String_ == null)
				cb_setCardNum_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCardNum_Ljava_lang_String_);
			return cb_setCardNum_Ljava_lang_String_;
		}

		static void n_SetCardNum_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CardNum = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCardNum;
		static IntPtr id_setCardNum_Ljava_lang_String_;
		public virtual unsafe string CardNum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getCardNum' and count(parameter)=0]"
			[Register ("getCardNum", "()Ljava/lang/String;", "GetGetCardNumHandler")]
			get {
				if (id_getCardNum == IntPtr.Zero)
					id_getCardNum = JNIEnv.GetMethodID (class_ref, "getCardNum", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCardNum), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCardNum", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setCardNum' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCardNum", "(Ljava/lang/String;)V", "GetSetCardNum_Ljava_lang_String_Handler")]
			set {
				if (id_setCardNum_Ljava_lang_String_ == IntPtr.Zero)
					id_setCardNum_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCardNum", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCardNum_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCardNum", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCashBackAmt;
#pragma warning disable 0169
		static Delegate GetGetCashBackAmtHandler ()
		{
			if (cb_getCashBackAmt == null)
				cb_getCashBackAmt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCashBackAmt);
			return cb_getCashBackAmt;
		}

		static IntPtr n_GetCashBackAmt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CashBackAmt);
		}
#pragma warning restore 0169

		static Delegate cb_setCashBackAmt_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCashBackAmt_Ljava_lang_String_Handler ()
		{
			if (cb_setCashBackAmt_Ljava_lang_String_ == null)
				cb_setCashBackAmt_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCashBackAmt_Ljava_lang_String_);
			return cb_setCashBackAmt_Ljava_lang_String_;
		}

		static void n_SetCashBackAmt_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CashBackAmt = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCashBackAmt;
		static IntPtr id_setCashBackAmt_Ljava_lang_String_;
		public virtual unsafe string CashBackAmt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getCashBackAmt' and count(parameter)=0]"
			[Register ("getCashBackAmt", "()Ljava/lang/String;", "GetGetCashBackAmtHandler")]
			get {
				if (id_getCashBackAmt == IntPtr.Zero)
					id_getCashBackAmt = JNIEnv.GetMethodID (class_ref, "getCashBackAmt", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCashBackAmt), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCashBackAmt", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setCashBackAmt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCashBackAmt", "(Ljava/lang/String;)V", "GetSetCashBackAmt_Ljava_lang_String_Handler")]
			set {
				if (id_setCashBackAmt_Ljava_lang_String_ == IntPtr.Zero)
					id_setCashBackAmt_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCashBackAmt", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCashBackAmt_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCashBackAmt", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getClerkId;
#pragma warning disable 0169
		static Delegate GetGetClerkIdHandler ()
		{
			if (cb_getClerkId == null)
				cb_getClerkId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClerkId);
			return cb_getClerkId;
		}

		static IntPtr n_GetClerkId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClerkId);
		}
#pragma warning restore 0169

		static Delegate cb_setClerkId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetClerkId_Ljava_lang_String_Handler ()
		{
			if (cb_setClerkId_Ljava_lang_String_ == null)
				cb_setClerkId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetClerkId_Ljava_lang_String_);
			return cb_setClerkId_Ljava_lang_String_;
		}

		static void n_SetClerkId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClerkId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getClerkId;
		static IntPtr id_setClerkId_Ljava_lang_String_;
		public virtual unsafe string ClerkId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getClerkId' and count(parameter)=0]"
			[Register ("getClerkId", "()Ljava/lang/String;", "GetGetClerkIdHandler")]
			get {
				if (id_getClerkId == IntPtr.Zero)
					id_getClerkId = JNIEnv.GetMethodID (class_ref, "getClerkId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClerkId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClerkId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setClerkId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setClerkId", "(Ljava/lang/String;)V", "GetSetClerkId_Ljava_lang_String_Handler")]
			set {
				if (id_setClerkId_Ljava_lang_String_ == IntPtr.Zero)
					id_setClerkId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setClerkId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setClerkId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setClerkId", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ConfirmPassword = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getConfirmPassword;
		static IntPtr id_setConfirmPassword_Ljava_lang_String_;
		public virtual unsafe string ConfirmPassword {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getConfirmPassword' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setConfirmPassword' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getConvenienceFee;
#pragma warning disable 0169
		static Delegate GetGetConvenienceFeeHandler ()
		{
			if (cb_getConvenienceFee == null)
				cb_getConvenienceFee = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConvenienceFee);
			return cb_getConvenienceFee;
		}

		static IntPtr n_GetConvenienceFee (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ConvenienceFee);
		}
#pragma warning restore 0169

		static Delegate cb_setConvenienceFee_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetConvenienceFee_Ljava_lang_String_Handler ()
		{
			if (cb_setConvenienceFee_Ljava_lang_String_ == null)
				cb_setConvenienceFee_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConvenienceFee_Ljava_lang_String_);
			return cb_setConvenienceFee_Ljava_lang_String_;
		}

		static void n_SetConvenienceFee_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ConvenienceFee = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getConvenienceFee;
		static IntPtr id_setConvenienceFee_Ljava_lang_String_;
		public virtual unsafe string ConvenienceFee {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getConvenienceFee' and count(parameter)=0]"
			[Register ("getConvenienceFee", "()Ljava/lang/String;", "GetGetConvenienceFeeHandler")]
			get {
				if (id_getConvenienceFee == IntPtr.Zero)
					id_getConvenienceFee = JNIEnv.GetMethodID (class_ref, "getConvenienceFee", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConvenienceFee), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConvenienceFee", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setConvenienceFee' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setConvenienceFee", "(Ljava/lang/String;)V", "GetSetConvenienceFee_Ljava_lang_String_Handler")]
			set {
				if (id_setConvenienceFee_Ljava_lang_String_ == IntPtr.Zero)
					id_setConvenienceFee_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setConvenienceFee", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setConvenienceFee_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConvenienceFee", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCvNum;
#pragma warning disable 0169
		static Delegate GetGetCvNumHandler ()
		{
			if (cb_getCvNum == null)
				cb_getCvNum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCvNum);
			return cb_getCvNum;
		}

		static IntPtr n_GetCvNum (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CvNum);
		}
#pragma warning restore 0169

		static Delegate cb_setCvNum_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCvNum_Ljava_lang_String_Handler ()
		{
			if (cb_setCvNum_Ljava_lang_String_ == null)
				cb_setCvNum_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCvNum_Ljava_lang_String_);
			return cb_setCvNum_Ljava_lang_String_;
		}

		static void n_SetCvNum_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CvNum = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCvNum;
		static IntPtr id_setCvNum_Ljava_lang_String_;
		public virtual unsafe string CvNum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getCvNum' and count(parameter)=0]"
			[Register ("getCvNum", "()Ljava/lang/String;", "GetGetCvNumHandler")]
			get {
				if (id_getCvNum == IntPtr.Zero)
					id_getCvNum = JNIEnv.GetMethodID (class_ref, "getCvNum", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCvNum), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCvNum", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setCvNum' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCvNum", "(Ljava/lang/String;)V", "GetSetCvNum_Ljava_lang_String_Handler")]
			set {
				if (id_setCvNum_Ljava_lang_String_ == IntPtr.Zero)
					id_setCvNum_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCvNum", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCvNum_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCvNum", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EmvEntryMedium = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEmvEntryMedium;
		static IntPtr id_setEmvEntryMedium_Ljava_lang_String_;
		public virtual unsafe string EmvEntryMedium {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getEmvEntryMedium' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setEmvEntryMedium' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EmvEntryMode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEmvEntryMode;
		static IntPtr id_setEmvEntryMode_Ljava_lang_String_;
		public virtual unsafe string EmvEntryMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getEmvEntryMode' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setEmvEntryMode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EmvEntryPinMode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEmvEntryPinMode;
		static IntPtr id_setEmvEntryPinMode_Ljava_lang_String_;
		public virtual unsafe string EmvEntryPinMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getEmvEntryPinMode' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setEmvEntryPinMode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EmvTags = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEmvTags;
		static IntPtr id_setEmvTags_Ljava_lang_String_;
		public virtual unsafe string EmvTags {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getEmvTags' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setEmvTags' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EmvTerminalCapabilities = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEmvTerminalCapabilities;
		static IntPtr id_setEmvTerminalCapabilities_Ljava_lang_String_;
		public virtual unsafe string EmvTerminalCapabilities {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getEmvTerminalCapabilities' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setEmvTerminalCapabilities' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getEntryMode;
#pragma warning disable 0169
		static Delegate GetGetEntryModeHandler ()
		{
			if (cb_getEntryMode == null)
				cb_getEntryMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEntryMode);
			return cb_getEntryMode;
		}

		static IntPtr n_GetEntryMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EntryMode);
		}
#pragma warning restore 0169

		static Delegate cb_setEntryMode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEntryMode_Ljava_lang_String_Handler ()
		{
			if (cb_setEntryMode_Ljava_lang_String_ == null)
				cb_setEntryMode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEntryMode_Ljava_lang_String_);
			return cb_setEntryMode_Ljava_lang_String_;
		}

		static void n_SetEntryMode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EntryMode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEntryMode;
		static IntPtr id_setEntryMode_Ljava_lang_String_;
		public virtual unsafe string EntryMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getEntryMode' and count(parameter)=0]"
			[Register ("getEntryMode", "()Ljava/lang/String;", "GetGetEntryModeHandler")]
			get {
				if (id_getEntryMode == IntPtr.Zero)
					id_getEntryMode = JNIEnv.GetMethodID (class_ref, "getEntryMode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEntryMode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEntryMode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setEntryMode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEntryMode", "(Ljava/lang/String;)V", "GetSetEntryMode_Ljava_lang_String_Handler")]
			set {
				if (id_setEntryMode_Ljava_lang_String_ == IntPtr.Zero)
					id_setEntryMode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEntryMode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEntryMode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEntryMode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getExpDate;
#pragma warning disable 0169
		static Delegate GetGetExpDateHandler ()
		{
			if (cb_getExpDate == null)
				cb_getExpDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExpDate);
			return cb_getExpDate;
		}

		static IntPtr n_GetExpDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ExpDate);
		}
#pragma warning restore 0169

		static Delegate cb_setExpDate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetExpDate_Ljava_lang_String_Handler ()
		{
			if (cb_setExpDate_Ljava_lang_String_ == null)
				cb_setExpDate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExpDate_Ljava_lang_String_);
			return cb_setExpDate_Ljava_lang_String_;
		}

		static void n_SetExpDate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ExpDate = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getExpDate;
		static IntPtr id_setExpDate_Ljava_lang_String_;
		public virtual unsafe string ExpDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getExpDate' and count(parameter)=0]"
			[Register ("getExpDate", "()Ljava/lang/String;", "GetGetExpDateHandler")]
			get {
				if (id_getExpDate == IntPtr.Zero)
					id_getExpDate = JNIEnv.GetMethodID (class_ref, "getExpDate", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExpDate), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExpDate", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setExpDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setExpDate", "(Ljava/lang/String;)V", "GetSetExpDate_Ljava_lang_String_Handler")]
			set {
				if (id_setExpDate_Ljava_lang_String_ == IntPtr.Zero)
					id_setExpDate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setExpDate", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setExpDate_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExpDate", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HolderType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getHolderType;
		static IntPtr id_setHolderType_Ljava_lang_String_;
		public virtual unsafe string HolderType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getHolderType' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setHolderType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InvNum = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getInvNum;
		static IntPtr id_setInvNum_Ljava_lang_String_;
		public virtual unsafe string InvNum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getInvNum' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setInvNum' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getMagData;
#pragma warning disable 0169
		static Delegate GetGetMagDataHandler ()
		{
			if (cb_getMagData == null)
				cb_getMagData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMagData);
			return cb_getMagData;
		}

		static IntPtr n_GetMagData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MagData);
		}
#pragma warning restore 0169

		static Delegate cb_setMagData_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMagData_Ljava_lang_String_Handler ()
		{
			if (cb_setMagData_Ljava_lang_String_ == null)
				cb_setMagData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMagData_Ljava_lang_String_);
			return cb_setMagData_Ljava_lang_String_;
		}

		static void n_SetMagData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MagData = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMagData;
		static IntPtr id_setMagData_Ljava_lang_String_;
		public virtual unsafe string MagData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getMagData' and count(parameter)=0]"
			[Register ("getMagData", "()Ljava/lang/String;", "GetGetMagDataHandler")]
			get {
				if (id_getMagData == IntPtr.Zero)
					id_getMagData = JNIEnv.GetMethodID (class_ref, "getMagData", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMagData), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMagData", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setMagData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMagData", "(Ljava/lang/String;)V", "GetSetMagData_Ljava_lang_String_Handler")]
			set {
				if (id_setMagData_Ljava_lang_String_ == IntPtr.Zero)
					id_setMagData_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMagData", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMagData_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMagData", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MerchantAccountCode);
		}
#pragma warning restore 0169

		static Delegate cb_setMerchantAccountCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMerchantAccountCode_Ljava_lang_String_Handler ()
		{
			if (cb_setMerchantAccountCode_Ljava_lang_String_ == null)
				cb_setMerchantAccountCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMerchantAccountCode_Ljava_lang_String_);
			return cb_setMerchantAccountCode_Ljava_lang_String_;
		}

		static void n_SetMerchantAccountCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MerchantAccountCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMerchantAccountCode;
		static IntPtr id_setMerchantAccountCode_Ljava_lang_String_;
		public virtual unsafe string MerchantAccountCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getMerchantAccountCode' and count(parameter)=0]"
			[Register ("getMerchantAccountCode", "()Ljava/lang/String;", "GetGetMerchantAccountCodeHandler")]
			get {
				if (id_getMerchantAccountCode == IntPtr.Zero)
					id_getMerchantAccountCode = JNIEnv.GetMethodID (class_ref, "getMerchantAccountCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMerchantAccountCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMerchantAccountCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setMerchantAccountCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMerchantAccountCode", "(Ljava/lang/String;)V", "GetSetMerchantAccountCode_Ljava_lang_String_Handler")]
			set {
				if (id_setMerchantAccountCode_Ljava_lang_String_ == IntPtr.Zero)
					id_setMerchantAccountCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMerchantAccountCode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMerchantAccountCode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMerchantAccountCode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MerchantCode);
		}
#pragma warning restore 0169

		static Delegate cb_setMerchantCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMerchantCode_Ljava_lang_String_Handler ()
		{
			if (cb_setMerchantCode_Ljava_lang_String_ == null)
				cb_setMerchantCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMerchantCode_Ljava_lang_String_);
			return cb_setMerchantCode_Ljava_lang_String_;
		}

		static void n_SetMerchantCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MerchantCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMerchantCode;
		static IntPtr id_setMerchantCode_Ljava_lang_String_;
		public virtual unsafe string MerchantCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getMerchantCode' and count(parameter)=0]"
			[Register ("getMerchantCode", "()Ljava/lang/String;", "GetGetMerchantCodeHandler")]
			get {
				if (id_getMerchantCode == IntPtr.Zero)
					id_getMerchantCode = JNIEnv.GetMethodID (class_ref, "getMerchantCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMerchantCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMerchantCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setMerchantCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMerchantCode", "(Ljava/lang/String;)V", "GetSetMerchantCode_Ljava_lang_String_Handler")]
			set {
				if (id_setMerchantCode_Ljava_lang_String_ == IntPtr.Zero)
					id_setMerchantCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMerchantCode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMerchantCode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMerchantCode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMsrKSN;
#pragma warning disable 0169
		static Delegate GetGetMsrKSNHandler ()
		{
			if (cb_getMsrKSN == null)
				cb_getMsrKSN = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMsrKSN);
			return cb_getMsrKSN;
		}

		static IntPtr n_GetMsrKSN (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MsrKSN);
		}
#pragma warning restore 0169

		static Delegate cb_setMsrKSN_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMsrKSN_Ljava_lang_String_Handler ()
		{
			if (cb_setMsrKSN_Ljava_lang_String_ == null)
				cb_setMsrKSN_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMsrKSN_Ljava_lang_String_);
			return cb_setMsrKSN_Ljava_lang_String_;
		}

		static void n_SetMsrKSN_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MsrKSN = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMsrKSN;
		static IntPtr id_setMsrKSN_Ljava_lang_String_;
		public virtual unsafe string MsrKSN {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getMsrKSN' and count(parameter)=0]"
			[Register ("getMsrKSN", "()Ljava/lang/String;", "GetGetMsrKSNHandler")]
			get {
				if (id_getMsrKSN == IntPtr.Zero)
					id_getMsrKSN = JNIEnv.GetMethodID (class_ref, "getMsrKSN", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMsrKSN), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMsrKSN", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setMsrKSN' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMsrKSN", "(Ljava/lang/String;)V", "GetSetMsrKSN_Ljava_lang_String_Handler")]
			set {
				if (id_setMsrKSN_Ljava_lang_String_ == IntPtr.Zero)
					id_setMsrKSN_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMsrKSN", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMsrKSN_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMsrKSN", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getNameOnCard;
#pragma warning disable 0169
		static Delegate GetGetNameOnCardHandler ()
		{
			if (cb_getNameOnCard == null)
				cb_getNameOnCard = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNameOnCard);
			return cb_getNameOnCard;
		}

		static IntPtr n_GetNameOnCard (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NameOnCard);
		}
#pragma warning restore 0169

		static Delegate cb_setNameOnCard_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNameOnCard_Ljava_lang_String_Handler ()
		{
			if (cb_setNameOnCard_Ljava_lang_String_ == null)
				cb_setNameOnCard_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNameOnCard_Ljava_lang_String_);
			return cb_setNameOnCard_Ljava_lang_String_;
		}

		static void n_SetNameOnCard_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NameOnCard = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNameOnCard;
		static IntPtr id_setNameOnCard_Ljava_lang_String_;
		public virtual unsafe string NameOnCard {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getNameOnCard' and count(parameter)=0]"
			[Register ("getNameOnCard", "()Ljava/lang/String;", "GetGetNameOnCardHandler")]
			get {
				if (id_getNameOnCard == IntPtr.Zero)
					id_getNameOnCard = JNIEnv.GetMethodID (class_ref, "getNameOnCard", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNameOnCard), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNameOnCard", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setNameOnCard' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNameOnCard", "(Ljava/lang/String;)V", "GetSetNameOnCard_Ljava_lang_String_Handler")]
			set {
				if (id_setNameOnCard_Ljava_lang_String_ == IntPtr.Zero)
					id_setNameOnCard_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNameOnCard", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNameOnCard_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNameOnCard", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NewPassword = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNewPassword;
		static IntPtr id_setNewPassword_Ljava_lang_String_;
		public virtual unsafe string NewPassword {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getNewPassword' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setNewPassword' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getP2pe;
#pragma warning disable 0169
		static Delegate GetGetP2peHandler ()
		{
			if (cb_getP2pe == null)
				cb_getP2pe = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetP2pe);
			return cb_getP2pe;
		}

		static IntPtr n_GetP2pe (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.P2pe);
		}
#pragma warning restore 0169

		static Delegate cb_setP2pe_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetP2pe_Ljava_lang_String_Handler ()
		{
			if (cb_setP2pe_Ljava_lang_String_ == null)
				cb_setP2pe_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetP2pe_Ljava_lang_String_);
			return cb_setP2pe_Ljava_lang_String_;
		}

		static void n_SetP2pe_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.P2pe = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getP2pe;
		static IntPtr id_setP2pe_Ljava_lang_String_;
		public virtual unsafe string P2pe {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getP2pe' and count(parameter)=0]"
			[Register ("getP2pe", "()Ljava/lang/String;", "GetGetP2peHandler")]
			get {
				if (id_getP2pe == IntPtr.Zero)
					id_getP2pe = JNIEnv.GetMethodID (class_ref, "getP2pe", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getP2pe), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getP2pe", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setP2pe' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setP2pe", "(Ljava/lang/String;)V", "GetSetP2pe_Ljava_lang_String_Handler")]
			set {
				if (id_setP2pe_Ljava_lang_String_ == IntPtr.Zero)
					id_setP2pe_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setP2pe", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setP2pe_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setP2pe", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PartialAuthorization = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPartialAuthorization;
		static IntPtr id_setPartialAuthorization_Ljava_lang_String_;
		public virtual unsafe string PartialAuthorization {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getPartialAuthorization' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setPartialAuthorization' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getPassword;
#pragma warning disable 0169
		static Delegate GetGetPasswordHandler ()
		{
			if (cb_getPassword == null)
				cb_getPassword = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPassword);
			return cb_getPassword;
		}

		static IntPtr n_GetPassword (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Password);
		}
#pragma warning restore 0169

		static Delegate cb_setPassword_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPassword_Ljava_lang_String_Handler ()
		{
			if (cb_setPassword_Ljava_lang_String_ == null)
				cb_setPassword_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPassword_Ljava_lang_String_);
			return cb_setPassword_Ljava_lang_String_;
		}

		static void n_SetPassword_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Password = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPassword;
		static IntPtr id_setPassword_Ljava_lang_String_;
		public virtual unsafe string Password {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getPassword' and count(parameter)=0]"
			[Register ("getPassword", "()Ljava/lang/String;", "GetGetPasswordHandler")]
			get {
				if (id_getPassword == IntPtr.Zero)
					id_getPassword = JNIEnv.GetMethodID (class_ref, "getPassword", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPassword), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPassword", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setPassword' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPassword", "(Ljava/lang/String;)V", "GetSetPassword_Ljava_lang_String_Handler")]
			set {
				if (id_setPassword_Ljava_lang_String_ == IntPtr.Zero)
					id_setPassword_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPassword", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPassword_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPassword", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getPin;
#pragma warning disable 0169
		static Delegate GetGetPinHandler ()
		{
			if (cb_getPin == null)
				cb_getPin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPin);
			return cb_getPin;
		}

		static IntPtr n_GetPin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Pin);
		}
#pragma warning restore 0169

		static Delegate cb_setPin_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPin_Ljava_lang_String_Handler ()
		{
			if (cb_setPin_Ljava_lang_String_ == null)
				cb_setPin_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPin_Ljava_lang_String_);
			return cb_setPin_Ljava_lang_String_;
		}

		static void n_SetPin_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Pin = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPin;
		static IntPtr id_setPin_Ljava_lang_String_;
		public virtual unsafe string Pin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getPin' and count(parameter)=0]"
			[Register ("getPin", "()Ljava/lang/String;", "GetGetPinHandler")]
			get {
				if (id_getPin == IntPtr.Zero)
					id_getPin = JNIEnv.GetMethodID (class_ref, "getPin", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPin), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPin", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setPin' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPin", "(Ljava/lang/String;)V", "GetSetPin_Ljava_lang_String_Handler")]
			set {
				if (id_setPin_Ljava_lang_String_ == IntPtr.Zero)
					id_setPin_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPin", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPin_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPin", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getPinKey;
#pragma warning disable 0169
		static Delegate GetGetPinKeyHandler ()
		{
			if (cb_getPinKey == null)
				cb_getPinKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPinKey);
			return cb_getPinKey;
		}

		static IntPtr n_GetPinKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PinKey);
		}
#pragma warning restore 0169

		static Delegate cb_setPinKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPinKey_Ljava_lang_String_Handler ()
		{
			if (cb_setPinKey_Ljava_lang_String_ == null)
				cb_setPinKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPinKey_Ljava_lang_String_);
			return cb_setPinKey_Ljava_lang_String_;
		}

		static void n_SetPinKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PinKey = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPinKey;
		static IntPtr id_setPinKey_Ljava_lang_String_;
		public virtual unsafe string PinKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getPinKey' and count(parameter)=0]"
			[Register ("getPinKey", "()Ljava/lang/String;", "GetGetPinKeyHandler")]
			get {
				if (id_getPinKey == IntPtr.Zero)
					id_getPinKey = JNIEnv.GetMethodID (class_ref, "getPinKey", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPinKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPinKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setPinKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPinKey", "(Ljava/lang/String;)V", "GetSetPinKey_Ljava_lang_String_Handler")]
			set {
				if (id_setPinKey_Ljava_lang_String_ == IntPtr.Zero)
					id_setPinKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPinKey", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPinKey_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPinKey", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getPnRefNum;
#pragma warning disable 0169
		static Delegate GetGetPnRefNumHandler ()
		{
			if (cb_getPnRefNum == null)
				cb_getPnRefNum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPnRefNum);
			return cb_getPnRefNum;
		}

		static IntPtr n_GetPnRefNum (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PnRefNum);
		}
#pragma warning restore 0169

		static Delegate cb_setPnRefNum_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPnRefNum_Ljava_lang_String_Handler ()
		{
			if (cb_setPnRefNum_Ljava_lang_String_ == null)
				cb_setPnRefNum_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPnRefNum_Ljava_lang_String_);
			return cb_setPnRefNum_Ljava_lang_String_;
		}

		static void n_SetPnRefNum_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PnRefNum = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPnRefNum;
		static IntPtr id_setPnRefNum_Ljava_lang_String_;
		public virtual unsafe string PnRefNum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getPnRefNum' and count(parameter)=0]"
			[Register ("getPnRefNum", "()Ljava/lang/String;", "GetGetPnRefNumHandler")]
			get {
				if (id_getPnRefNum == IntPtr.Zero)
					id_getPnRefNum = JNIEnv.GetMethodID (class_ref, "getPnRefNum", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPnRefNum), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPnRefNum", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setPnRefNum' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPnRefNum", "(Ljava/lang/String;)V", "GetSetPnRefNum_Ljava_lang_String_Handler")]
			set {
				if (id_setPnRefNum_Ljava_lang_String_ == IntPtr.Zero)
					id_setPnRefNum_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPnRefNum", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPnRefNum_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPnRefNum", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PoNum = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPoNum;
		static IntPtr id_setPoNum_Ljava_lang_String_;
		public virtual unsafe string PoNum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getPoNum' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setPoNum' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getRegisterNum;
#pragma warning disable 0169
		static Delegate GetGetRegisterNumHandler ()
		{
			if (cb_getRegisterNum == null)
				cb_getRegisterNum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRegisterNum);
			return cb_getRegisterNum;
		}

		static IntPtr n_GetRegisterNum (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RegisterNum);
		}
#pragma warning restore 0169

		static Delegate cb_setRegisterNum_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRegisterNum_Ljava_lang_String_Handler ()
		{
			if (cb_setRegisterNum_Ljava_lang_String_ == null)
				cb_setRegisterNum_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRegisterNum_Ljava_lang_String_);
			return cb_setRegisterNum_Ljava_lang_String_;
		}

		static void n_SetRegisterNum_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterNum = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRegisterNum;
		static IntPtr id_setRegisterNum_Ljava_lang_String_;
		public virtual unsafe string RegisterNum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getRegisterNum' and count(parameter)=0]"
			[Register ("getRegisterNum", "()Ljava/lang/String;", "GetGetRegisterNumHandler")]
			get {
				if (id_getRegisterNum == IntPtr.Zero)
					id_getRegisterNum = JNIEnv.GetMethodID (class_ref, "getRegisterNum", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRegisterNum), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRegisterNum", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setRegisterNum' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRegisterNum", "(Ljava/lang/String;)V", "GetSetRegisterNum_Ljava_lang_String_Handler")]
			set {
				if (id_setRegisterNum_Ljava_lang_String_ == IntPtr.Zero)
					id_setRegisterNum_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRegisterNum", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRegisterNum_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRegisterNum", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SecureFormat = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSecureFormat;
		static IntPtr id_setSecureFormat_Ljava_lang_String_;
		public virtual unsafe string SecureFormat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getSecureFormat' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setSecureFormat' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getSecurityInfo;
#pragma warning disable 0169
		static Delegate GetGetSecurityInfoHandler ()
		{
			if (cb_getSecurityInfo == null)
				cb_getSecurityInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSecurityInfo);
			return cb_getSecurityInfo;
		}

		static IntPtr n_GetSecurityInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SecurityInfo);
		}
#pragma warning restore 0169

		static Delegate cb_setSecurityInfo_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSecurityInfo_Ljava_lang_String_Handler ()
		{
			if (cb_setSecurityInfo_Ljava_lang_String_ == null)
				cb_setSecurityInfo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSecurityInfo_Ljava_lang_String_);
			return cb_setSecurityInfo_Ljava_lang_String_;
		}

		static void n_SetSecurityInfo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SecurityInfo = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSecurityInfo;
		static IntPtr id_setSecurityInfo_Ljava_lang_String_;
		public virtual unsafe string SecurityInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getSecurityInfo' and count(parameter)=0]"
			[Register ("getSecurityInfo", "()Ljava/lang/String;", "GetGetSecurityInfoHandler")]
			get {
				if (id_getSecurityInfo == IntPtr.Zero)
					id_getSecurityInfo = JNIEnv.GetMethodID (class_ref, "getSecurityInfo", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSecurityInfo), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSecurityInfo", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setSecurityInfo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSecurityInfo", "(Ljava/lang/String;)V", "GetSetSecurityInfo_Ljava_lang_String_Handler")]
			set {
				if (id_setSecurityInfo_Ljava_lang_String_ == IntPtr.Zero)
					id_setSecurityInfo_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSecurityInfo", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSecurityInfo_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSecurityInfo", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getShippingAmt;
#pragma warning disable 0169
		static Delegate GetGetShippingAmtHandler ()
		{
			if (cb_getShippingAmt == null)
				cb_getShippingAmt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetShippingAmt);
			return cb_getShippingAmt;
		}

		static IntPtr n_GetShippingAmt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ShippingAmt);
		}
#pragma warning restore 0169

		static Delegate cb_setShippingAmt_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetShippingAmt_Ljava_lang_String_Handler ()
		{
			if (cb_setShippingAmt_Ljava_lang_String_ == null)
				cb_setShippingAmt_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetShippingAmt_Ljava_lang_String_);
			return cb_setShippingAmt_Ljava_lang_String_;
		}

		static void n_SetShippingAmt_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShippingAmt = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getShippingAmt;
		static IntPtr id_setShippingAmt_Ljava_lang_String_;
		public virtual unsafe string ShippingAmt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getShippingAmt' and count(parameter)=0]"
			[Register ("getShippingAmt", "()Ljava/lang/String;", "GetGetShippingAmtHandler")]
			get {
				if (id_getShippingAmt == IntPtr.Zero)
					id_getShippingAmt = JNIEnv.GetMethodID (class_ref, "getShippingAmt", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getShippingAmt), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getShippingAmt", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setShippingAmt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setShippingAmt", "(Ljava/lang/String;)V", "GetSetShippingAmt_Ljava_lang_String_Handler")]
			set {
				if (id_setShippingAmt_Ljava_lang_String_ == IntPtr.Zero)
					id_setShippingAmt_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setShippingAmt", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setShippingAmt_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShippingAmt", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getStreet;
#pragma warning disable 0169
		static Delegate GetGetStreetHandler ()
		{
			if (cb_getStreet == null)
				cb_getStreet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStreet);
			return cb_getStreet;
		}

		static IntPtr n_GetStreet (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Street);
		}
#pragma warning restore 0169

		static Delegate cb_setStreet_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStreet_Ljava_lang_String_Handler ()
		{
			if (cb_setStreet_Ljava_lang_String_ == null)
				cb_setStreet_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStreet_Ljava_lang_String_);
			return cb_setStreet_Ljava_lang_String_;
		}

		static void n_SetStreet_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Street = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStreet;
		static IntPtr id_setStreet_Ljava_lang_String_;
		public virtual unsafe string Street {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getStreet' and count(parameter)=0]"
			[Register ("getStreet", "()Ljava/lang/String;", "GetGetStreetHandler")]
			get {
				if (id_getStreet == IntPtr.Zero)
					id_getStreet = JNIEnv.GetMethodID (class_ref, "getStreet", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStreet), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStreet", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setStreet' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStreet", "(Ljava/lang/String;)V", "GetSetStreet_Ljava_lang_String_Handler")]
			set {
				if (id_setStreet_Ljava_lang_String_ == IntPtr.Zero)
					id_setStreet_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setStreet", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStreet_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStreet", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSureChargeAmt;
#pragma warning disable 0169
		static Delegate GetGetSureChargeAmtHandler ()
		{
			if (cb_getSureChargeAmt == null)
				cb_getSureChargeAmt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSureChargeAmt);
			return cb_getSureChargeAmt;
		}

		static IntPtr n_GetSureChargeAmt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SureChargeAmt);
		}
#pragma warning restore 0169

		static Delegate cb_setSureChargeAmt_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSureChargeAmt_Ljava_lang_String_Handler ()
		{
			if (cb_setSureChargeAmt_Ljava_lang_String_ == null)
				cb_setSureChargeAmt_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSureChargeAmt_Ljava_lang_String_);
			return cb_setSureChargeAmt_Ljava_lang_String_;
		}

		static void n_SetSureChargeAmt_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SureChargeAmt = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSureChargeAmt;
		static IntPtr id_setSureChargeAmt_Ljava_lang_String_;
		public virtual unsafe string SureChargeAmt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getSureChargeAmt' and count(parameter)=0]"
			[Register ("getSureChargeAmt", "()Ljava/lang/String;", "GetGetSureChargeAmtHandler")]
			get {
				if (id_getSureChargeAmt == IntPtr.Zero)
					id_getSureChargeAmt = JNIEnv.GetMethodID (class_ref, "getSureChargeAmt", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSureChargeAmt), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSureChargeAmt", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setSureChargeAmt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSureChargeAmt", "(Ljava/lang/String;)V", "GetSetSureChargeAmt_Ljava_lang_String_Handler")]
			set {
				if (id_setSureChargeAmt_Ljava_lang_String_ == IntPtr.Zero)
					id_setSureChargeAmt_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSureChargeAmt", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSureChargeAmt_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSureChargeAmt", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TaxAmount);
		}
#pragma warning restore 0169

		static Delegate cb_setTaxAmount_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTaxAmount_Ljava_lang_String_Handler ()
		{
			if (cb_setTaxAmount_Ljava_lang_String_ == null)
				cb_setTaxAmount_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTaxAmount_Ljava_lang_String_);
			return cb_setTaxAmount_Ljava_lang_String_;
		}

		static void n_SetTaxAmount_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TaxAmount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTaxAmount;
		static IntPtr id_setTaxAmount_Ljava_lang_String_;
		public virtual unsafe string TaxAmount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getTaxAmount' and count(parameter)=0]"
			[Register ("getTaxAmount", "()Ljava/lang/String;", "GetGetTaxAmountHandler")]
			get {
				if (id_getTaxAmount == IntPtr.Zero)
					id_getTaxAmount = JNIEnv.GetMethodID (class_ref, "getTaxAmount", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTaxAmount), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTaxAmount", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setTaxAmount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTaxAmount", "(Ljava/lang/String;)V", "GetSetTaxAmount_Ljava_lang_String_Handler")]
			set {
				if (id_setTaxAmount_Ljava_lang_String_ == IntPtr.Zero)
					id_setTaxAmount_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTaxAmount", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTaxAmount_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTaxAmount", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TaxRate);
		}
#pragma warning restore 0169

		static Delegate cb_setTaxRate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTaxRate_Ljava_lang_String_Handler ()
		{
			if (cb_setTaxRate_Ljava_lang_String_ == null)
				cb_setTaxRate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTaxRate_Ljava_lang_String_);
			return cb_setTaxRate_Ljava_lang_String_;
		}

		static void n_SetTaxRate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TaxRate = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTaxRate;
		static IntPtr id_setTaxRate_Ljava_lang_String_;
		public virtual unsafe string TaxRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getTaxRate' and count(parameter)=0]"
			[Register ("getTaxRate", "()Ljava/lang/String;", "GetGetTaxRateHandler")]
			get {
				if (id_getTaxRate == IntPtr.Zero)
					id_getTaxRate = JNIEnv.GetMethodID (class_ref, "getTaxRate", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTaxRate), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTaxRate", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setTaxRate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTaxRate", "(Ljava/lang/String;)V", "GetSetTaxRate_Ljava_lang_String_Handler")]
			set {
				if (id_setTaxRate_Ljava_lang_String_ == IntPtr.Zero)
					id_setTaxRate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTaxRate", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTaxRate_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTaxRate", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTenderType;
#pragma warning disable 0169
		static Delegate GetGetTenderTypeHandler ()
		{
			if (cb_getTenderType == null)
				cb_getTenderType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTenderType);
			return cb_getTenderType;
		}

		static IntPtr n_GetTenderType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TenderType);
		}
#pragma warning restore 0169

		static Delegate cb_setTenderType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTenderType_Ljava_lang_String_Handler ()
		{
			if (cb_setTenderType_Ljava_lang_String_ == null)
				cb_setTenderType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTenderType_Ljava_lang_String_);
			return cb_setTenderType_Ljava_lang_String_;
		}

		static void n_SetTenderType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TenderType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTenderType;
		static IntPtr id_setTenderType_Ljava_lang_String_;
		public virtual unsafe string TenderType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getTenderType' and count(parameter)=0]"
			[Register ("getTenderType", "()Ljava/lang/String;", "GetGetTenderTypeHandler")]
			get {
				if (id_getTenderType == IntPtr.Zero)
					id_getTenderType = JNIEnv.GetMethodID (class_ref, "getTenderType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTenderType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTenderType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setTenderType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTenderType", "(Ljava/lang/String;)V", "GetSetTenderType_Ljava_lang_String_Handler")]
			set {
				if (id_setTenderType_Ljava_lang_String_ == IntPtr.Zero)
					id_setTenderType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTenderType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTenderType_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTenderType", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TerminalType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTerminalType;
		static IntPtr id_setTerminalType_Ljava_lang_String_;
		public virtual unsafe string TerminalType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getTerminalType' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setTerminalType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TipAmount);
		}
#pragma warning restore 0169

		static Delegate cb_setTipAmount_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTipAmount_Ljava_lang_String_Handler ()
		{
			if (cb_setTipAmount_Ljava_lang_String_ == null)
				cb_setTipAmount_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTipAmount_Ljava_lang_String_);
			return cb_setTipAmount_Ljava_lang_String_;
		}

		static void n_SetTipAmount_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TipAmount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTipAmount;
		static IntPtr id_setTipAmount_Ljava_lang_String_;
		public virtual unsafe string TipAmount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getTipAmount' and count(parameter)=0]"
			[Register ("getTipAmount", "()Ljava/lang/String;", "GetGetTipAmountHandler")]
			get {
				if (id_getTipAmount == IntPtr.Zero)
					id_getTipAmount = JNIEnv.GetMethodID (class_ref, "getTipAmount", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTipAmount), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTipAmount", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setTipAmount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTipAmount", "(Ljava/lang/String;)V", "GetSetTipAmount_Ljava_lang_String_Handler")]
			set {
				if (id_setTipAmount_Ljava_lang_String_ == IntPtr.Zero)
					id_setTipAmount_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTipAmount", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTipAmount_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTipAmount", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Token = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getToken;
		static IntPtr id_setToken_Ljava_lang_String_;
		public virtual unsafe string Token {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getToken' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Track1 = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTrack1;
		static IntPtr id_setTrack1_Ljava_lang_String_;
		public virtual unsafe string Track1 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getTrack1' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setTrack1' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Track2 = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTrack2;
		static IntPtr id_setTrack2_Ljava_lang_String_;
		public virtual unsafe string Track2 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getTrack2' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setTrack2' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Track3 = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTrack3;
		static IntPtr id_setTrack3_Ljava_lang_String_;
		public virtual unsafe string Track3 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getTrack3' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setTrack3' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TrackData = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTrackData;
		static IntPtr id_setTrackData_Ljava_lang_String_;
		public virtual unsafe string TrackData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getTrackData' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setTrackData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TrackIdentifier = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTrackIdentifier;
		static IntPtr id_setTrackIdentifier_Ljava_lang_String_;
		public virtual unsafe string TrackIdentifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getTrackIdentifier' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setTrackIdentifier' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TrackIndicator = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTrackIndicator;
		static IntPtr id_setTrackIndicator_Ljava_lang_String_;
		public virtual unsafe string TrackIndicator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getTrackIndicator' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setTrackIndicator' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TransCatCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTransCatCode;
		static IntPtr id_setTransCatCode_Ljava_lang_String_;
		public virtual unsafe string TransCatCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getTransCatCode' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setTransCatCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TransIndustryType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTransIndustryType;
		static IntPtr id_setTransIndustryType_Ljava_lang_String_;
		public virtual unsafe string TransIndustryType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getTransIndustryType' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setTransIndustryType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getTransType;
#pragma warning disable 0169
		static Delegate GetGetTransTypeHandler ()
		{
			if (cb_getTransType == null)
				cb_getTransType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransType);
			return cb_getTransType;
		}

		static IntPtr n_GetTransType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TransType);
		}
#pragma warning restore 0169

		static Delegate cb_setTransType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTransType_Ljava_lang_String_Handler ()
		{
			if (cb_setTransType_Ljava_lang_String_ == null)
				cb_setTransType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTransType_Ljava_lang_String_);
			return cb_setTransType_Ljava_lang_String_;
		}

		static void n_SetTransType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TransType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTransType;
		static IntPtr id_setTransType_Ljava_lang_String_;
		public virtual unsafe string TransType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getTransType' and count(parameter)=0]"
			[Register ("getTransType", "()Ljava/lang/String;", "GetGetTransTypeHandler")]
			get {
				if (id_getTransType == IntPtr.Zero)
					id_getTransType = JNIEnv.GetMethodID (class_ref, "getTransType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTransType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setTransType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTransType", "(Ljava/lang/String;)V", "GetSetTransType_Ljava_lang_String_Handler")]
			set {
				if (id_setTransType_Ljava_lang_String_ == IntPtr.Zero)
					id_setTransType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTransType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTransType_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTransType", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTransactionId;
#pragma warning disable 0169
		static Delegate GetGetTransactionIdHandler ()
		{
			if (cb_getTransactionId == null)
				cb_getTransactionId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransactionId);
			return cb_getTransactionId;
		}

		static IntPtr n_GetTransactionId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TransactionId);
		}
#pragma warning restore 0169

		static Delegate cb_setTransactionId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTransactionId_Ljava_lang_String_Handler ()
		{
			if (cb_setTransactionId_Ljava_lang_String_ == null)
				cb_setTransactionId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTransactionId_Ljava_lang_String_);
			return cb_setTransactionId_Ljava_lang_String_;
		}

		static void n_SetTransactionId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TransactionId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTransactionId;
		static IntPtr id_setTransactionId_Ljava_lang_String_;
		public virtual unsafe string TransactionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getTransactionId' and count(parameter)=0]"
			[Register ("getTransactionId", "()Ljava/lang/String;", "GetGetTransactionIdHandler")]
			get {
				if (id_getTransactionId == IntPtr.Zero)
					id_getTransactionId = JNIEnv.GetMethodID (class_ref, "getTransactionId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTransactionId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransactionId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setTransactionId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTransactionId", "(Ljava/lang/String;)V", "GetSetTransactionId_Ljava_lang_String_Handler")]
			set {
				if (id_setTransactionId_Ljava_lang_String_ == IntPtr.Zero)
					id_setTransactionId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTransactionId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTransactionId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTransactionId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getUsername;
#pragma warning disable 0169
		static Delegate GetGetUsernameHandler ()
		{
			if (cb_getUsername == null)
				cb_getUsername = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUsername);
			return cb_getUsername;
		}

		static IntPtr n_GetUsername (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Username);
		}
#pragma warning restore 0169

		static Delegate cb_setUsername_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUsername_Ljava_lang_String_Handler ()
		{
			if (cb_setUsername_Ljava_lang_String_ == null)
				cb_setUsername_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUsername_Ljava_lang_String_);
			return cb_setUsername_Ljava_lang_String_;
		}

		static void n_SetUsername_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Username = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUsername;
		static IntPtr id_setUsername_Ljava_lang_String_;
		public virtual unsafe string Username {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getUsername' and count(parameter)=0]"
			[Register ("getUsername", "()Ljava/lang/String;", "GetGetUsernameHandler")]
			get {
				if (id_getUsername == IntPtr.Zero)
					id_getUsername = JNIEnv.GetMethodID (class_ref, "getUsername", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUsername), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUsername", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setUsername' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUsername", "(Ljava/lang/String;)V", "GetSetUsername_Ljava_lang_String_Handler")]
			set {
				if (id_setUsername_Ljava_lang_String_ == IntPtr.Zero)
					id_setUsername_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUsername", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUsername_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUsername", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getZipCode;
#pragma warning disable 0169
		static Delegate GetGetZipCodeHandler ()
		{
			if (cb_getZipCode == null)
				cb_getZipCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetZipCode);
			return cb_getZipCode;
		}

		static IntPtr n_GetZipCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ZipCode);
		}
#pragma warning restore 0169

		static Delegate cb_setZipCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetZipCode_Ljava_lang_String_Handler ()
		{
			if (cb_setZipCode_Ljava_lang_String_ == null)
				cb_setZipCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetZipCode_Ljava_lang_String_);
			return cb_setZipCode_Ljava_lang_String_;
		}

		static void n_SetZipCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity __this = global::Java.Lang.Object.GetObject<global::Com.Bpn.Payguardian.Android.Entity.PaymentRequestEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ZipCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getZipCode;
		static IntPtr id_setZipCode_Ljava_lang_String_;
		public virtual unsafe string ZipCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='getZipCode' and count(parameter)=0]"
			[Register ("getZipCode", "()Ljava/lang/String;", "GetGetZipCodeHandler")]
			get {
				if (id_getZipCode == IntPtr.Zero)
					id_getZipCode = JNIEnv.GetMethodID (class_ref, "getZipCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getZipCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getZipCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bpn.payguardian.android.entity']/class[@name='PaymentRequestEntity']/method[@name='setZipCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setZipCode", "(Ljava/lang/String;)V", "GetSetZipCode_Ljava_lang_String_Handler")]
			set {
				if (id_setZipCode_Ljava_lang_String_ == IntPtr.Zero)
					id_setZipCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setZipCode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setZipCode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setZipCode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
