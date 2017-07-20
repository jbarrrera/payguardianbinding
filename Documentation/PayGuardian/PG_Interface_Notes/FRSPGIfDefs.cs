using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;


namespace FRS_PayGuardianIf
{
	// FPI_TenderType -- Mimics the PayGuardian.TenderType enum
	public enum FPI_TenderType
	{
		FPTT_UNKNOWN,
		FPTT_CREDIT,		// Credit Card					
		FPTT_DEBIT,			// Debit Card					
		FPTT_CHECK,			// Check						
		FPTT_EBTFS,			// EBT Food Stamp				-- Not in Dev Guide PaymentRequest
		FPTT_EBTCB,			// EBT Cash Benefit				-- Not in Dev Guide PaymentRequest
		FPTT_GIFT,			// Gift Card					
		FPTT_LOYALTY,		// Loyalty Card (?)				-- Not in Dev Guide PaymentRequest
		FPTT_CASH,			// Cash (duh)					-- Not in Dev Guide PaymentRequest
		FPTT_EBTF,			// EBT Food						
		FPTT_EBTC,			// EBT Cash						
		FPTT_EOD,			// End of Day	(what's this?)	 
		FPTT_INVALID
	}

	// FPI_TranType -- Mimics the PayGuardian.TransType enum
	public enum FPI_TranType
	{
		FPTR_UNKNOWN	= 0,	// 
		FPTR_SALEAUTH,			// Verifies/Authorizes payment amount on check or credit card
		FPTR_SALE,				// Makes a purchase with credit, debit, gift, EBT food stamp,
								//	EBT cash benefit, check, or unknown payment type
		FPTR_REFUND,			// Returns a credit, debit, gift, EBT food stamp, or unknown 
								//	payment
		FPTR_VOID,				// Removes a credit or gift transaction from an unsettled batch
		FPTR_CAPTURE,			// <Reserved for future use>
		FPTR_CREDIT,			//								-- Not in Dev Guide PaymentRequest
		FPTR_CREDITAUTH,		//								-- Not in Dev Guide PaymentRequest
		FPTR_AUTH		= 7,	//								-- Not in Dev Guide PaymentRequest
		FPTR_INCREMENT,			// NEW, v2.0.5/2.0.8+
		FPTR_CAPTUREALL,		// Performs a settlement or batch close
		FPTR_INVALID,			// NEW, v2.0.5/2.0.8+
		FPTR_RETURN,			// NEW, v2.2.6+
		FPTR_TOKENADD	= 24,	// Generates a token for a credit or gift card [Card Vaulting]
		FPTR_TOKENMOD,			// Modifies a token for a credit or gift card
		FPTR_REVERSAL,			//								-- Not in Dev Guide PaymentRequest
		FPTR_MERCHANTINFO		//								-- Not in Dev Guide PaymentRequest
	}

	public class FPI_CfgInfo
	{
		#region Member Vars
		private string		_sHomeDir	= string.Empty;
		private string		_sSigDir	= string.Empty;
		private string		_sFrsSigDir	= string.Empty;
		#endregion Member Vars

		public FPI_CfgInfo()		{ }
		
		#region Properties
		public string HomeDir
		{
			get { return _sHomeDir; }
			set { _sHomeDir = value; }
		}
		public string SigDir
		{
			get { return _sSigDir; }
			set { _sSigDir = value; }
		}
		public string FrsSigDir
		{
			get { return _sFrsSigDir; }
			set { _sFrsSigDir = value; }
		}
		#endregion Properties
	}

	public class FPI_PmtRequest
	{
		#region Member Vars
		// --------------------------------------------
		//	FRS-specific
		private bool			_bWantSig			= true;			// Does FRS want a signature?
																	//	(PG doesn't support specifying this!)
		// --------------------------------------------
		//	PayGuardian...
		private bool			_bAutoSubmit		= true;			// Enables/disables AutoSubmit feature that 
																	//	automatically sends the payment for 
																	//	processing as soon as PayGuardian has all 
																	//	necessary information collected.
		private FPI_TenderType	_tenderType			= 
									FPI_TenderType.FPTT_UNKNOWN;	// Required	- 
		private FPI_TranType	_transType			= 
									FPI_TranType.FPTR_UNKNOWN;		// Required	- 
		private string			_acctNo				= string.Empty;	//
		private string			_amount				= string.Empty;	// Required	- Total transaction amount (includes
																	//				subtotal, cash back, tax & tip)
		private string			_authCode			= string.Empty;	//		-- Not in Dev Guide PaymentRequest
		private string			_cashBackAmt		= string.Empty;	// Total cash-back amount
		private string			_clerkId			= string.Empty;	// Required	- Employee/Clerk ID
		private string			_customFields		= string.Empty;	//	<Reserved for future use>
		private string			_email				= string.Empty;	//		-- Not in Dev Guide PaymentRequest
		private string			_extData			= string.Empty;	//		-- Not in Dev Guide PaymentRequest
		private string			_invoiceNo			= string.Empty;	// POS System invoice/tracking #
		private string			_merchantKey		= string.Empty;	//	<Reserved for future use>
		private string			_misc1Amt			= string.Empty,	//	<Reserved for future use>
								_misc2Amt			= string.Empty,	//	<Reserved for future use>
								_misc3Amt			= string.Empty;	//	<Reserved for future use>
		private string			_origRefNo			= string.Empty;	// Reference # from original transaction (for 
																	//	follow-on transactions)
		private string			_paylinkHostName	= string.Empty;	//		PayGuardian application server base URL
																	//			Default: http://localhost:8080
		private string			_phone				= string.Empty;	//		-- Not in Dev Guide PaymentRequest
		private string			_poNo				= string.Empty;	// Purchase Order #
		private string			_registerId			= string.Empty;	//		-- Not in Dev Guide PaymentRequest

		private string			_surchargeAmt		= string.Empty;	//	<Reserved for future use>
		private string			_taxAmt				= string.Empty;	// Tax amount
		private string			_tipAmt				= string.Empty;	// Tip amount
		private string			_userName			= string.Empty;	// Username of the merchant (owner of BridgePay account)
		private string			_password			= string.Empty;	// Password of the merchant
		private string			_customerName		= string.Empty;	// Customer Name
		private string			_street				= string.Empty,	// (Billing Address) Street
								_city				= string.Empty,	// (Billing Address) City
								_state				= string.Empty,	// (Billing Address) State
								_zip				= string.Empty,	// (Billing Address) ZipCode/Postal Code
								_country			= string.Empty;	// (Billing Address) Country

		// v1.0.5
		private string			_expireDt			= string.Empty;	// Expiration Date
		private string			_xtndSummary		= string.Empty;	// Extended Summary
		private string			_token				= string.Empty;	// Token (for stored card info?)
		#endregion  Member Vars
		
		// --------------------------------------------
		
		public FPI_PmtRequest()		{}
		
	//	public void Copy(  )		{}
		
		// --------------------------------------------
		
		#region Properties
		// --------------------------------------------
		//	FRS-specific								|| 
		// --------------------------------------------	\/
		public bool WantSignature
		{
			get { return _bWantSig; }
			set { _bWantSig = value; }
		}
		// --------------------------------------------
		//	PayGuardian	v1.0.4							|| 
		// --------------------------------------------	\/
		public FPI_TenderType TenderType
		{
			get { return _tenderType; }
			set { _tenderType = value; }
		}
		public FPI_TranType TransType
		{
			get { return _transType; }
			set { _transType = value; }
		}
		public string Amount
		{
			get { return _amount; }
			set { _amount = value; }
		}
		public string AuthCode
		{
			get { return _authCode; }
			set { _authCode = value; }
		}
		public bool AutoSubmit
		{
			get { return _bAutoSubmit; }
			set { _bAutoSubmit = value; }
		}
		public string CashBackAmount
		{
			get { return _cashBackAmt; }
			set { _cashBackAmt = value; }
		}
		public string ClerkID
		{
			get { return _clerkId; }
			set { _clerkId = value; }
		}
		public string CustomFields
		{
			get { return _customFields; }
			set { _customFields = value; }
		}
		public string Email
		{
			get { return _email; }
			set { _email = value; }
		}
		public string ExtData
		{
			get { return _extData; }
			set { _extData = value; }
		}
		public string InvoiceNum
		{
			get { return _invoiceNo; }
			set { _invoiceNo = value; }
		}
		public string MerchantKey
		{
			get { return _merchantKey; }
			set { _merchantKey = value; }
		}
		public string Misc1Amt
		{
			get { return _misc1Amt; }
			set { _misc1Amt = value; }
		}
		public string Misc2Amt
		{
			get { return _misc2Amt; }
			set { _misc2Amt = value; }
		}
		public string Misc3Amt
		{
			get { return _misc3Amt; }
			set { _misc3Amt = value; }
		}
		public string OrigRefNum
		{
			get { return _origRefNo; }
			set { _origRefNo = value; }
		}
		public string Password
		{
			get { return _password; }
			set { _password = value; }
		}
		public string PaylinkHostName
		{
			get { return _paylinkHostName; }
			set { _paylinkHostName = value; }
		}
		public string Phone
		{
			get { return _phone; }
			set { _phone = value; }
		}
		public string PONum
		{
			get { return _poNo; }
			set { _poNo = value; }
		}
		public string RegisterID
		{
			get { return _registerId; }
			set { _registerId = value; }
		}
		public string SurchargeAmt
		{
			get { return _surchargeAmt; }
			set { _surchargeAmt = value; }
		}
		public string TaxAmt
		{
			get { return _taxAmt; }
			set { _taxAmt = value; }
		}
		public string TipAmt
		{
			get { return _tipAmt; }
			set { _tipAmt = value; }
		}
		public string UserName
		{
			get { return _userName; }
			set { _userName = value; }
		}
		public string AccountNum
		{
			get { return _acctNo; }
			set { _acctNo = value; }
		}
		public string CustomerName
		{
			get { return _customerName; }
			set { _customerName = value; }
		}
		public string Street
		{
			get { return _street; }
			set { _street = value; }
		}
		public string City
		{
			get { return _city; }
			set { _city = value; }
		}
		public string State
		{
			get { return _state; }
			set { _state = value; }
		}
		public string Zip
		{
			get { return _zip; }
			set { _zip = value; }
		}
		public string Country
		{
			get { return _country; }
			set { _country = value; }
		}
		// --------------------------------------------
		//				v1.0.5							|| 
		// --------------------------------------------	\/
		public string ExpirationDate
		{
			get { return _expireDt; }
			set { _expireDt = value; }
		}
		public string ExtendedSummary
		{
			get { return _xtndSummary; }
			set { _xtndSummary = value; }
		}
		public string Token
		{
			get { return _token; }
			set { _token = value; }
		}
		// --------------------------------------------
		#endregion Properties
	}

	public class FPI_PmtResponse
	{
		#region Member Vars
		private string			_pageRslt		= string.Empty;	//    From ShowPage call
		private string			_pageMsg		= string.Empty;	//    From ShowPage call
		private string			_resultCode		= string.Empty;	//    Result code of the transaction
		private string			_resultText		= string.Empty;	//    Details from the processor or payment 
																//   	gateway about the transaction result
		private string			_frsRsltCode	= string.Empty;	//    Result code that FRS has always understood.
		private string			_cardType		= string.Empty;	//    Type of card (VISA, AMEX, etc)
		private string			_maskedAcctNo	= string.Empty;	//    1st 6 & last 4 digits, 'x's in between
		private string			_authCode		= string.Empty;	//    Auth code from processor
		private string			_refNo			= string.Empty;	//    Gateway reference/token number (used in 
																//   	follow-on transactions)
		private string			_avsResponse	= string.Empty;	//    AVS response code
		private string			_cvvResponse	= string.Empty;	//    CVV response code
		private string			_approvedAmt	= string.Empty;	//    Actual approved amount; may differ from 
																//   	requested amount
		private string			_tipAmt			= string.Empty;	// * 		-- Not in Dev Guide PaymentRequest
		private string			_cashBackAmt	= string.Empty;	// * 		-- Not in Dev Guide PaymentRequest
		private string			_submittedAmt	= string.Empty;	// * 		-- Not in Dev Guide PaymentRequest
		private string			_requestedAmt	= string.Empty;	// *  Original requested amount of the transaction
		private string			_remainBalance	= string.Empty;	// *  Remaining balance on gift or prepaid card
		private bool			_bIsCommercial	= false;		//   	Is commercial card?
		private string			_hostCode		= string.Empty;	// *  Payment processing host reference number
		private string			_hostResponse	= string.Empty;	// *  Payment processing host response
		private string			_msg			= string.Empty;	// ** Host or gateway message (now GatewayMessage?)
		private string			_msg1			= string.Empty;	// **	<Reserved for future use>
		private string			_msg2			= string.Empty;	// **	<Reserved for future use>
		private string			_rawResponse	= string.Empty;	//   				NEED THIS?????
		private string			_timeStamp		= string.Empty;	//    Time and date of the transaction
		private string			_extData		= string.Empty;	//   		-- Not in Dev Guide PaymentRequest
																//			[Save ExtData.ToString() here.]

		// v1.0.5...
		private string			_avsMsg			= string.Empty;	//    AVS message
		private string			_cvvMsg			= string.Empty;	//    CVV message
		private string			_expireDt		= string.Empty;	//    Expiration Date
		private string			_gtwayMsg		= string.Empty;	//    Gateway message
		private string			_gtwayRslt		= string.Empty;	// ** Gateway result
		private string			_intrnlMsg		= string.Empty;	//    Internal message
		private string			_isoCntryCode	= string.Empty;	//    ISO Country Code
		private string			_isoCrncyCode	= string.Empty;	// ** ISO Currency Code
		private string			_isoRequestDt	= string.Empty;	//    ISO Request Date
		private string			_merchCatCode	= string.Empty;	//    Merchant Category Code
		private string			_ntwkMerchId	= string.Empty;	//    Network Merchant ID
		private string			_ntwkRefNo		= string.Empty;	//    Network Reference Number
		private string			_ntwkTermId		= string.Empty;	//    Network Terminal ID
		private string			_remainAmt		= string.Empty;	//    Remaining amount (requested - approved)
		private string			_respnsTypeDesc	= string.Empty;	// ** Response Type Description
		private string			_streetMatchMsg	= string.Empty;	//    Street Match message
		private string			_token			= string.Empty;	// ** Token
		private string			_xactCode		= string.Empty;	// ** Transaction Code

		// v2.2.9.3...
		private string			_appLbl			= string.Empty;	// ?  appLabel (whatever EMV returns)
		private string			_atc			= string.Empty;	// ?  ATC (what the hell is this?????)
		private string			_chipCrdAid		= string.Empty;	// ?  chipCardAID (EMV stuff)
		private string			_custAcctCode	= string.Empty;	// ?  CustomerAccountCode (?????)
		private string			_entryMethod	= string.Empty;	// ?  entryMethod (EMV (only?))
		private string			_entryMode		= string.Empty;	// ?  entryMode (EMV (only?))
		private string			_invcNo			= string.Empty;	// ?  InvNum (probably v2.2.7?)
		private string			_issuerTagData	= string.Empty;	// ?  issuerTagData (what the hell is this?????)
		private string			_recptTagData	= string.Empty;	// ?  receiptTagData 
		
		// ServiceFeeResult: How to handle? All string data here, or clone the class?
		private string			_svcFeeRslt		= string.Empty;	//    serviceFeeResult
		
		private string			_tndrType		= string.Empty;	//    tenderType (Credit, Debit, ...)
		private string			_tokenResponse	= string.Empty;	//    tokenResponse (?????)
		
		//	*	-- if appropriate
		//	**	-- optional
		//	?	-- don't know
		
		// --------------------------------------------
		//	FRS-specific
		// ---------------------------------------
		//	Copy of Base64-Encoded PNG Signature
		//		[Added to ExtData, PG 2.2.8 (7?)]
		private string			_sigCapPng64	= string.Empty;	//    Fusion-specific (from ExtData, if available)
		
		private bool			_bSignError		= false;		//    Fusion-specific (no direct match in PG)
		private string			_encodedSig		= string.Empty;	//    Fusion-specific (no direct match in PG)
		private string			_sigFilePath	= string.Empty;	//    Fusion-specific (no direct match in PG)
		private string			_sigErrMsg		= string.Empty;	//    Fusion-specific (no direct match in PG)
		
		// --------------------------------------------
		//	Miscellaneous, not in PG
		// ---------------------------------------
		private string			_showRspns		= string.Empty;	//    Result from PG ShowPageResult.ToString()
		private string			_pmtRspns		= string.Empty;	//    Result from PG PmtResponse.ToString()
		
		#endregion  Member Vars
		
		// --------------------------------------------
		
		public FPI_PmtResponse() { }
		
		// --------------------------------------------
		
		#region Properties
		// --------------------------------------------
		public string PageResultCode
		{
			get { return _pageRslt; }
			set { _pageRslt = value; }
		}
		public string PageMessage
		{
			get { return _pageMsg; }
			set { _pageMsg = value; }
		}
		public string ResultCode
		{
			get { return _resultCode; }
			set { _resultCode = value; }
		}
		public string ResultText
		{
			get { return _resultText; }
			set { _resultText = value; }
		}
		public string FrsResultCode
		{
			get { return _frsRsltCode; }
			set { _frsRsltCode = value; }
		}
		public string CardType
		{
			get { return _cardType; }
			set { _cardType = value; }
		}
		public string MaskedCardNo
		{
			get { return _maskedAcctNo; }
			set { _maskedAcctNo = value; }
		}
		public string AuthCode
		{
			get { return _authCode; }
			set { _authCode = value; }
		}
		public string RefNum
		{
			get { return _refNo; }
			set { _refNo = value; }
		}
		public string AvsResponse
		{
			get { return _avsResponse; }
			set { _avsResponse = value; }
		}
		public string CvvResponse
		{
			get { return _cvvResponse; }
			set { _cvvResponse = value; }
		}
		public string ApprovedAmt
		{
			get { return _approvedAmt; }
			set { _approvedAmt = value; }
		}
		public string TipAmt
		{
			get { return _tipAmt; }
			set { _tipAmt = value; }
		}
		public string CashBackAmt
		{
			get { return _cashBackAmt; }
			set { _cashBackAmt = value; }
		}
		public string SubmittedAmt
		{
			get { return _submittedAmt; }
			set { _submittedAmt = value; }
		}
		public string RequestedAmt
		{
			get { return _requestedAmt; }
			set { _requestedAmt = value; }
		}
		public string RemainingBalance
		{
			get { return _remainBalance; }
			set { _remainBalance = value; }
		}
		public bool IsCommercialCard
		{
			get { return _bIsCommercial; }
			set { _bIsCommercial = value; }
		}
		public string HostCode
		{
			get { return _hostCode; }
			set { _hostCode = value; }
		}
		public string HostResponse
		{
			get { return _hostResponse; }
			set { _hostResponse = value; }
		}
		public string Message
		{
			get { return _msg; }
			set { _msg = value; }
		}
		public string Message1
		{
			get { return _msg1; }
			set { _msg1 = value; }
		}
		public string Message2
		{
			get { return _msg2; }
			set { _msg2 = value; }
		}
		public string RawResponse
		{
			get { return _rawResponse; }
			set { _rawResponse = value; }
		}
		public string Timestamp
		{
			get { return _timeStamp; }
			set { _timeStamp = value; }
		}
		public string ExtData
		{
			get { return _extData; }
			set { _extData = value; }
		}
		// --------------------------------------------
		//				v1.0.5							|| 
		// --------------------------------------------	\/
		public string AvsMessage
		{
			get { return _avsMsg; }
			set { _avsMsg = value; }
		}
		public string CvvMessage
		{
			get { return _cvvMsg; }
			set { _cvvMsg = value; }
		}
		public string ExpirationDate
		{
			get { return _expireDt; }
			set { _expireDt = value; }
		}
		public string GatewayMessage
		{
			get { return _gtwayMsg; }
			set { _gtwayMsg = value; }
		}
		public string GatewayResult
		{
			get { return _gtwayRslt; }
			set { _gtwayRslt = value; }
		}
		public string InternalMessage
		{
			get { return _intrnlMsg; }
			set { _intrnlMsg = value; }
		}
		public string CountryCode
		{
			get { return _isoCntryCode; }
			set { _isoCntryCode = value; }
		}
		public string CurrencyCode
		{
			get { return _isoCrncyCode; }
			set { _isoCrncyCode = value; }
		}
		public string RequestDate
		{
			get { return _isoRequestDt; }
			set { _isoRequestDt = value; }
		}
		public string MerchCategoryCode
		{
			get { return _merchCatCode; }
			set { _merchCatCode = value; }
		}
		public string NetworkMerchId
		{
			get { return _ntwkMerchId; }
			set { _ntwkMerchId = value; }
		}
		public string NetworkRefNo
		{
			get { return _ntwkRefNo; }
			set { _ntwkRefNo = value; }
		}
		public string NetworkTerminalId
		{
			get { return _ntwkTermId; }
			set { _ntwkTermId = value; }
		}
		public string RemainingAmt
		{
			get { return _remainAmt; }
			set { _remainAmt = value; }
		}
		public string ResponseTypeDesc
		{
			get { return _respnsTypeDesc; }
			set { _respnsTypeDesc = value; }
		}
		public string StreetMatchMsg
		{
			get { return _streetMatchMsg; }
			set { _streetMatchMsg = value; }
		}
		public string Token
		{
			get { return _token; }
			set { _token = value; }
		}
		public string TransactionCode
		{
			get { return _xactCode; }
			set { _xactCode = value; }
		}
		// --------------------------------------------
		//				v2.2.9.3						|| 
		// --------------------------------------------	\/
		public string AppLabel
		{
			get { return _appLbl; }
			set { _appLbl = value; }
		}
		public string ATC
		{
			get { return _atc; }
			set { _atc = value; }
		}
		public string ChipCardAID
		{
			get { return _chipCrdAid; }
			set { _chipCrdAid = value; }
		}
		public string CustomerAccountCode
		{
			get { return _custAcctCode; }
			set { _custAcctCode = value; }
		}
		public string EntryMethod
		{
			get { return _entryMethod; }
			set { _entryMethod = value; }
		}
		public string EntryMode
		{
			get { return _entryMode; }
			set { _entryMode = value; }
		}
		public string InvoiceNum
		{
			get { return _invcNo; }
			set { _invcNo = value; }
		}
		public string IssuerTagData
		{
			get { return _issuerTagData; }
			set { _issuerTagData = value; }
		}
		public string ReceiptTagData
		{
			get { return _recptTagData; }
			set { _recptTagData = value; }
		}
		public string ServiceFeeResult
		{
			get { return _svcFeeRslt; }
			set { _svcFeeRslt = value; }
		}
		public string TenderType
		{
			get { return _tndrType; }
			set { _tndrType = value; }
		}
		public string TokenResponse
		{
			get { return _tokenResponse; }
			set { _tokenResponse = value; }
		}
		// --------------------------------------------
		//	FRS-specific								|| 
		// --------------------------------------------	\/
		public string EncodedPngSig
		{
			get { return _sigCapPng64; }
			set { _sigCapPng64 = value; }
		}
		public bool SignatureError
		{
			get { return _bSignError; }
			set { _bSignError = value; }
		}
		public string EncodedSig
		{
			get { return _encodedSig; }
			set { _encodedSig = value; }
		}
		public string SigFilePath
		{
			get { return _sigFilePath; }
			set { _sigFilePath = value; }
		}
		public string SigErrorMsg
		{
			get { return _sigErrMsg; }
			set { _sigErrMsg = value; }
		}
		// --------------------------------------------
		//	Miscellaneous, not in PG
		// ---------------------------------------
		public string ShowPageResultStr
		{
			get { return _showRspns; }
			set { _showRspns = value; }
		}
		public string PmtResponseStr
		{
			get { return _pmtRspns; }
			set { _pmtRspns = value; }
		}
		// --------------------------------------------
		#endregion Properties
	}
	
	
}