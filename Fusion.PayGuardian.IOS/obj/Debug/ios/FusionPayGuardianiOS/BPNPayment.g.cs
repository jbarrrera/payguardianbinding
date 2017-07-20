//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using SceneKit;
using Security;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace Fusion.PayGuardian.iOS {
	[Protocol (Name = "BPNPayment", WrapperType = typeof (BPNPaymentWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "BridgeCommResponse", Selector = "bridgeCommResponse", PropertyType = typeof (Fusion.PayGuardian.iOS.BridgeCommResponse), GetterSelector = "bridgeCommResponse", SetterSelector = "setBridgeCommResponse:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Receipt", Selector = "receipt", PropertyType = typeof (Fusion.PayGuardian.iOS.BPNReceipt), GetterSelector = "receipt", SetterSelector = "setReceipt:", ArgumentSemantic = ArgumentSemantic.Retain)]
	public interface IBPNPayment : INativeObject, IDisposable
	{
	}
	
	public static partial class BPNPayment_Extensions {
		[CompilerGenerated]
		public static BridgeCommResponse GetBridgeCommResponse (this IBPNPayment This)
		{
			return  Runtime.GetNSObject<BridgeCommResponse> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("bridgeCommResponse")));
		}
		
		[CompilerGenerated]
		public static void SetBridgeCommResponse (this IBPNPayment This, BridgeCommResponse value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setBridgeCommResponse:"), value.Handle);
		}
		
		[CompilerGenerated]
		public static BPNReceipt GetReceipt (this IBPNPayment This)
		{
			return  Runtime.GetNSObject<BPNReceipt> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("receipt")));
		}
		
		[CompilerGenerated]
		public static void SetReceipt (this IBPNPayment This, BPNReceipt value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setReceipt:"), value.Handle);
		}
		
	}
	
	internal sealed class BPNPaymentWrapper : BaseWrapper, IBPNPayment {
		[Preserve (Conditional = true)]
		public BPNPaymentWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace Fusion.PayGuardian.iOS {
	[Protocol]
	[Register("BPNPayment", true)]
	public unsafe partial class BPNPayment : NSObject, IBPNPayment {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("BPNPayment");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public BPNPayment () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected BPNPayment (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal BPNPayment (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual BridgeCommResponse BridgeCommResponse {
			[Export ("bridgeCommResponse", ArgumentSemantic.Retain)]
			get {
				BridgeCommResponse ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<BridgeCommResponse> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("bridgeCommResponse")));
				} else {
					ret =  Runtime.GetNSObject<BridgeCommResponse> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bridgeCommResponse")));
				}
				return ret;
			}
			
			[Export ("setBridgeCommResponse:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBridgeCommResponse:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBridgeCommResponse:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual BPNReceipt Receipt {
			[Export ("receipt", ArgumentSemantic.Retain)]
			get {
				BPNReceipt ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<BPNReceipt> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("receipt")));
				} else {
					ret =  Runtime.GetNSObject<BPNReceipt> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("receipt")));
				}
				return ret;
			}
			
			[Export ("setReceipt:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setReceipt:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setReceipt:"), value.Handle);
				}
			}
		}
		
	} /* class BPNPayment */
}
