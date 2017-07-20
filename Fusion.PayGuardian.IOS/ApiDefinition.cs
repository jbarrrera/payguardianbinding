using System;

using ObjCRuntime;
using Foundation;
using UIKit;


namespace Fusion.PayGuardian.iOS
{
    // @interface BPNAddress : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
     interface BPNAddress
    {
        // @property (copy, nonatomic) NSString * _Nullable street;
        [NullAllowed, Export("street")]
        string Street { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable city;
        [NullAllowed, Export("city")]
        string City { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable zip;
        [NullAllowed, Export("zip")]
        string Zip { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable country;
        [NullAllowed, Export("country")]
        string Country { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable phone;
        [NullAllowed, Export("phone")]
        string Phone { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable email;
        [NullAllowed, Export("email")]
        string Email { get; set; }
    }

    // @interface BridgeCommResponse : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
     interface BridgeCommResponse
    {
        // @property (nonatomic, strong) NSString * transactionID;
        [Export("transactionID", ArgumentSemantic.Strong)]
        string TransactionID { get; set; }

        // @property (nonatomic, strong) NSString * requestType;
        [Export("requestType", ArgumentSemantic.Strong)]
        string RequestType { get; set; }

        // @property (assign, nonatomic) BridgeCommResponseCode responseCode;
        [Export("responseCode", ArgumentSemantic.Assign)]
        BridgeCommResponseCode ResponseCode { get; set; }

        // @property (nonatomic, strong) NSString * responseDescription;
        [Export("responseDescription", ArgumentSemantic.Strong)]
        string ResponseDescription { get; set; }

        // @property (nonatomic, strong) NSString * token;
        [Export("token", ArgumentSemantic.Strong)]
        string Token { get; set; }

        // @property (nonatomic, strong) NSString * expirationDate;
        [Export("expirationDate", ArgumentSemantic.Strong)]
        string ExpirationDate { get; set; }

        // @property (nonatomic, strong) NSString * authorizationCode;
        [Export("authorizationCode", ArgumentSemantic.Strong)]
        string AuthorizationCode { get; set; }

        // @property (nonatomic, strong) NSString * originalReferenceNumber;
        [Export("originalReferenceNumber", ArgumentSemantic.Strong)]
        string OriginalReferenceNumber { get; set; }

        // @property (nonatomic, strong) NSDecimalNumber * authorizedAmount;
        [Export("authorizedAmount", ArgumentSemantic.Strong)]
        NSDecimalNumber AuthorizedAmount { get; set; }

        // @property (nonatomic, strong) NSDecimalNumber * originalAmount;
        [Export("originalAmount", ArgumentSemantic.Strong)]
        NSDecimalNumber OriginalAmount { get; set; }

        // @property (nonatomic, strong) NSString * gatewayTransactionID;
        [Export("gatewayTransactionID", ArgumentSemantic.Strong)]
        string GatewayTransactionID { get; set; }

        // @property (nonatomic, strong) NSString * gatewayMessage;
        [Export("gatewayMessage", ArgumentSemantic.Strong)]
        string GatewayMessage { get; set; }

        // @property (nonatomic, strong) NSString * internalMessage;
        [Export("internalMessage", ArgumentSemantic.Strong)]
        string InternalMessage { get; set; }

        // @property (nonatomic, strong) NSString * gatewayResult;
        [Export("gatewayResult", ArgumentSemantic.Strong)]
        string GatewayResult { get; set; }

        // @property (nonatomic, strong) NSString * AVSMessage;
        [Export("AVSMessage", ArgumentSemantic.Strong)]
        string AVSMessage { get; set; }

        // @property (nonatomic, strong) NSString * AVSResponse;
        [Export("AVSResponse", ArgumentSemantic.Strong)]
        string AVSResponse { get; set; }

        // @property (nonatomic, strong) NSString * CVMessage;
        [Export("CVMessage", ArgumentSemantic.Strong)]
        string CVMessage { get; set; }

        // @property (nonatomic, strong) NSString * CVResult;
        [Export("CVResult", ArgumentSemantic.Strong)]
        string CVResult { get; set; }

        // @property (nonatomic, strong) NSString * transactionCode;
        [Export("transactionCode", ArgumentSemantic.Strong)]
        string TransactionCode { get; set; }

        // @property (nonatomic, strong) NSString * transactionDate;
        [Export("transactionDate", ArgumentSemantic.Strong)]
        string TransactionDate { get; set; }

        // @property (nonatomic, strong) NSDecimalNumber * remainingAmount;
        [Export("remainingAmount", ArgumentSemantic.Strong)]
        NSDecimalNumber RemainingAmount { get; set; }

        // @property (nonatomic, strong) NSString * ISOCountryCode;
        [Export("ISOCountryCode", ArgumentSemantic.Strong)]
        string ISOCountryCode { get; set; }

        // @property (nonatomic, strong) NSString * ISOCurrencyCode;
        [Export("ISOCurrencyCode", ArgumentSemantic.Strong)]
        string ISOCurrencyCode { get; set; }

        // @property (nonatomic, strong) NSString * ISOTransactionDate;
        [Export("ISOTransactionDate", ArgumentSemantic.Strong)]
        string ISOTransactionDate { get; set; }

        // @property (nonatomic, strong) NSString * ISORequestDate;
        [Export("ISORequestDate", ArgumentSemantic.Strong)]
        string ISORequestDate { get; set; }

        // @property (nonatomic, strong) NSString * networkReferenceNumber;
        [Export("networkReferenceNumber", ArgumentSemantic.Strong)]
        string NetworkReferenceNumber { get; set; }

        // @property (nonatomic, strong) NSString * merchantCategoryCode;
        [Export("merchantCategoryCode", ArgumentSemantic.Strong)]
        string MerchantCategoryCode { get; set; }

        // @property (nonatomic, strong) NSString * networkMerchantID;
        [Export("networkMerchantID", ArgumentSemantic.Strong)]
        string NetworkMerchantID { get; set; }

        // @property (nonatomic, strong) NSString * networkTerminalID;
        [Export("networkTerminalID", ArgumentSemantic.Strong)]
        string NetworkTerminalID { get; set; }

        // @property (nonatomic, strong) NSString * cardType;
        [Export("cardType", ArgumentSemantic.Strong)]
        string CardType { get; set; }

        // @property (nonatomic, strong) NSString * maskedPAN;
        [Export("maskedPAN", ArgumentSemantic.Strong)]
        string MaskedPAN { get; set; }

        // @property (nonatomic, strong) NSString * responseTypeDescription;
        [Export("responseTypeDescription", ArgumentSemantic.Strong)]
        string ResponseTypeDescription { get; set; }

        // @property (nonatomic, strong) NSString * isCommercialCard;
        [Export("isCommercialCard", ArgumentSemantic.Strong)]
        string IsCommercialCard { get; set; }

        // @property (nonatomic, strong) NSString * streetMatchMessage;
        [Export("streetMatchMessage", ArgumentSemantic.Strong)]
        string StreetMatchMessage { get; set; }

        // @property (nonatomic, strong) NSString * secondsRemaining;
        [Export("secondsRemaining", ArgumentSemantic.Strong)]
        string SecondsRemaining { get; set; }

        // @property (nonatomic, strong) NSString * merchantCode;
        [Export("merchantCode", ArgumentSemantic.Strong)]
        string MerchantCode { get; set; }

        // @property (nonatomic, strong) NSString * merchantAccountCode;
        [Export("merchantAccountCode", ArgumentSemantic.Strong)]
        string MerchantAccountCode { get; set; }

        // @property (nonatomic, strong) NSString * merchantName;
        [Export("merchantName", ArgumentSemantic.Strong)]
        string MerchantName { get; set; }

        // @property (nonatomic, strong) NSString * receiptTagData;
        [Export("receiptTagData", ArgumentSemantic.Strong)]
        string ReceiptTagData { get; set; }

        // @property (nonatomic, strong) NSString * issuerTagData;
        [Export("issuerTagData", ArgumentSemantic.Strong)]
        string IssuerTagData { get; set; }

        // @property (nonatomic, strong) NSString * applicationIdentifier;
        [Export("applicationIdentifier", ArgumentSemantic.Strong)]
        string ApplicationIdentifier { get; set; }

        // @property (nonatomic, strong) NSString * terminalVerificationResults;
        [Export("terminalVerificationResults", ArgumentSemantic.Strong)]
        string TerminalVerificationResults { get; set; }

        // @property (nonatomic, strong) NSString * issuerApplicationData;
        [Export("issuerApplicationData", ArgumentSemantic.Strong)]
        string IssuerApplicationData { get; set; }

        // @property (nonatomic, strong) NSString * transactionStatusInformation;
        [Export("transactionStatusInformation", ArgumentSemantic.Strong)]
        string TransactionStatusInformation { get; set; }

        // -(instancetype)initFromXMLString:(NSString *)XMLString;
        [Export("initFromXMLString:")]
        IntPtr Constructor(string XMLString);
    }

    // @interface RBAConnectionQueue : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
     interface RBAConnectionQueue
    {
        // -(void)suspend;
        [Export("suspend")]
        void Suspend();

        // -(void)resume;
        [Export("resume")]
        void Resume();

        // -(void)run:(void (^)(void))block;
        [Export("run:")]
        void Run(Action block);

        // -(void)run:(void (^)(void))block afterBlockProcessed:(void (^)(void))afterProcessed;
        [Export("run:afterBlockProcessed:")]
        void Run(Action block, Action afterProcessed);

        // -(void)run:(void (^)(void))block processingDelay:(NSTimeInterval)processingDelay afterBlockProcessed:(void (^)(void))afterProcessed;
        [Export("run:processingDelay:afterBlockProcessed:")]
        void Run(Action block, double processingDelay, Action afterProcessed);
    }

    // @interface PayGuardianTransaction : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    [Protocol]
     interface PayGuardianTransaction
    {
        // @property (readonly, assign, nonatomic) PayGuardianTransactionState state;
        [Export("state", ArgumentSemantic.Assign)]
        PayGuardianTransactionState State { get; }

        // -(instancetype)initWithPaymentRequest:(BPNPaymentRequest *)request;
        [Export("initWithPaymentRequest:")]
        IntPtr Constructor(BPNPaymentRequest request);

        // -(void)runOnCompletion:(void (^)(BPNPayment *, NSError *))onCompletion onStateChanged:(void (^)(PayGuardianTransactionState))onStateChanged;
        [Export("runOnCompletion:onStateChanged:")]
        void RunOnCompletion(Action<BPNPayment, NSError> onCompletion, Action<PayGuardianTransactionState> onStateChanged);

        // -(void)ingenicoPushConfig:(void (^)(void))configPushComplete;
        [Export("ingenicoPushConfig:")]
        void IngenicoPushConfig(Action configPushComplete);

        // -(void)testMagtek;
        [Export("testMagtek")]
        void TestMagtek();

        // -(void)cancel;
        [Export("cancel")]
        void Cancel();

        // -(void)UNIPAY_startEmv;
        [Export("UNIPAY_startEmv")]
        void UNIPAY_startEmv();

        // @property (assign, nonatomic) BOOL retryOnBadRead;
        [Export("retryOnBadRead")]
        bool RetryOnBadRead { get; set; }

        // @property (nonatomic, strong) int * uniMag;
        //[Export("uniMag", ArgumentSemantic.Strong)]
        //unsafe int UniMag { get; set; }
    }

    // @interface BPNPayment : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
     interface BPNPayment
    {
        // @property (nonatomic, strong) BridgeCommResponse * bridgeCommResponse;
        [Export("bridgeCommResponse", ArgumentSemantic.Strong)]
        BridgeCommResponse BridgeCommResponse { get; set; }

        // @property (nonatomic, strong) BPNReceipt * receipt;
        [Export("receipt", ArgumentSemantic.Strong)]
        BPNReceipt Receipt { get; set; }
    }

    // @interface BPNReceipt : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
     interface BPNReceipt
    {
        // @property (nonatomic, strong) NSString * maskedCardNumber;
        [Export("maskedCardNumber", ArgumentSemantic.Strong)]
        string MaskedCardNumber { get; set; }

        // @property (nonatomic, strong) NSString * chipCardAID;
        [Export("chipCardAID", ArgumentSemantic.Strong)]
        string ChipCardAID { get; set; }

        // @property (nonatomic, strong) NSString * invoice;
        [Export("invoice", ArgumentSemantic.Strong)]
        string Invoice { get; set; }

        // @property (nonatomic, strong) NSString * seq;
        [Export("seq", ArgumentSemantic.Strong)]
        string Seq { get; set; }

        // @property (nonatomic, strong) NSString * authorizationCode;
        [Export("authorizationCode", ArgumentSemantic.Strong)]
        string AuthorizationCode { get; set; }

        // @property (nonatomic, strong) NSString * entryMethod;
        [Export("entryMethod", ArgumentSemantic.Strong)]
        string EntryMethod { get; set; }

        // @property (nonatomic, strong) NSDecimalNumber * totalAmount;
        [Export("totalAmount", ArgumentSemantic.Strong)]
        NSDecimalNumber TotalAmount { get; set; }

        // @property (nonatomic, strong) NSString * appLabel;
        [Export("appLabel", ArgumentSemantic.Strong)]
        string AppLabel { get; set; }

        // @property (nonatomic, strong) NSString * cardHolderName;
        [Export("cardHolderName", ArgumentSemantic.Strong)]
        string CardHolderName { get; set; }

        // @property (nonatomic, strong) NSString * networkMerchantID;
        [Export("networkMerchantID", ArgumentSemantic.Strong)]
        string NetworkMerchantID { get; set; }

        // @property (nonatomic, strong) NSString * networkTerminalID;
        [Export("networkTerminalID", ArgumentSemantic.Strong)]
        string NetworkTerminalID { get; set; }

        // @property (nonatomic, strong) NSString * cardFirstFour;
        [Export("cardFirstFour", ArgumentSemantic.Strong)]
        string CardFirstFour { get; set; }

        // @property (nonatomic, strong) NSString * cardType;
        [Export("cardType", ArgumentSemantic.Strong)]
        string CardType { get; set; }

        // @property (assign, nonatomic) BOOL requiresSignature;
        [Export("requiresSignature")]
        bool RequiresSignature { get; set; }

        // @property (assign, nonatomic) BOOL pinEntered;
        [Export("pinEntered")]
        bool PinEntered { get; set; }
    }

    // @interface BPNPaymentRequest : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    [Protocol]
     interface BPNPaymentRequest
    {
        // @property (readonly, nonatomic, strong) NSDecimalNumber * _Nonnull amount;
        [Export("amount", ArgumentSemantic.Strong)]
        NSDecimalNumber Amount { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nonnull terminalType;
        [Export("terminalType", ArgumentSemantic.Strong)]
        string TerminalType { get; }

        // @property (readonly, assign, nonatomic) BOOL testMode;
        [Export("testMode")]
        bool TestMode { get; }

        // @property (readonly, assign, nonatomic) BOOL disableEmv;
        [Export("disableEmv")]
        bool DisableEmv { get; }

        // @property (readonly, nonatomic, strong) NSDecimalNumber * _Nonnull tipAmount;
        [Export("tipAmount", ArgumentSemantic.Strong)]
        NSDecimalNumber TipAmount { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nonnull transactionID;
        [Export("transactionID", ArgumentSemantic.Strong)]
        string TransactionID { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nonnull tenderType;
        [Export("tenderType", ArgumentSemantic.Strong)]
        string TenderType { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nonnull expirationDate;
        [Export("expirationDate", ArgumentSemantic.Strong)]
        string ExpirationDate { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nonnull paymentAccountNumber;
        [Export("paymentAccountNumber", ArgumentSemantic.Strong)]
        string PaymentAccountNumber { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nonnull transactionType;
        [Export("transactionType", ArgumentSemantic.Strong)]
        string TransactionType { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nonnull username;
        [Export("username", ArgumentSemantic.Strong)]
        string Username { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nonnull password;
        [Export("password", ArgumentSemantic.Strong)]
        string Password { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nonnull merchantCode;
        [Export("merchantCode", ArgumentSemantic.Strong)]
        string MerchantCode { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nonnull merchantAccountCode;
        [Export("merchantAccountCode", ArgumentSemantic.Strong)]
        string MerchantAccountCode { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nonnull token;
        [Export("token", ArgumentSemantic.Strong)]
        string Token { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nonnull industryType;
        [Export("industryType", ArgumentSemantic.Strong)]
        string IndustryType { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nullable pnRefNum;
        [NullAllowed, Export("pnRefNum", ArgumentSemantic.Strong)]
        string PnRefNum { get; }

        // @property (readonly, nonatomic, strong) NSDecimalNumber * _Nullable cashBackAmount;
        [NullAllowed, Export("cashBackAmount", ArgumentSemantic.Strong)]
        NSDecimalNumber CashBackAmount { get; }

        // @property (readonly, nonatomic, strong) BPNAddress * _Nullable shippingAddress;
        [NullAllowed, Export("shippingAddress", ArgumentSemantic.Strong)]
        BPNAddress ShippingAddress { get; }

        // -(BPNPaymentRequest * _Nonnull)initInvoiceNumber:(NSString * _Nonnull)invoiceNumber pnRefNum:(NSString * _Nullable)pnRefNum amount:(NSDecimalNumber * _Nullable)amount tipAmount:(NSDecimalNumber * _Nullable)tipAmount cashBackAmount:(NSDecimalNumber * _Nullable)cashBackAmount tenderType:(NSString * _Nonnull)tenderType transactionType:(NSString * _Nonnull)transactionType username:(NSString * _Nonnull)username password:(NSString * _Nonnull)password merchantCode:(NSString * _Nonnull)merchantCode merchantAccountCode:(NSString * _Nonnull)merchantAccountCode paymentAccountNumber:(NSString * _Nullable)paymentAccountNumber token:(NSString * _Nullable)token expirationDate:(NSString * _Nullable)expirationDate terminalType:(NSString * _Nullable)terminalType industryType:(NSString * _Nonnull)industryType disableEmv:(BOOL)disableEmv testMode:(BOOL)testMode;
        [Export("initInvoiceNumber:pnRefNum:amount:tipAmount:cashBackAmount:tenderType:transactionType:username:password:merchantCode:merchantAccountCode:paymentAccountNumber:token:expirationDate:terminalType:industryType:disableEmv:testMode:")]
        IntPtr Constructor(string invoiceNumber, [NullAllowed] string pnRefNum, [NullAllowed] NSDecimalNumber amount, [NullAllowed] NSDecimalNumber tipAmount, [NullAllowed] NSDecimalNumber cashBackAmount, string tenderType, string transactionType, string username, string password, string merchantCode, string merchantAccountCode, [NullAllowed] string paymentAccountNumber, [NullAllowed] string token, [NullAllowed] string expirationDate, [NullAllowed] string terminalType, string industryType, bool disableEmv, bool testMode);
    }

    [Static]
    //[Verify(ConstantsInterfaceAssociation)]
    internal interface Constants
    {
        //extern NSString const TENDER_TYPE_CREDIT;
        [Field("TENDER_TYPE_CREDIT", "__Internal")]
        NSString TENDER_TYPE_CREDIT { get; }

        // extern NSString *const TENDER_TYPE_DEBIT;
        [Field("TENDER_TYPE_DEBIT", "__Internal")]
        NSString TENDER_TYPE_DEBIT { get; }

        // extern NSString *const TENDER_TYPE_GIFT;
        [Field("TENDER_TYPE_GIFT", "__Internal")]
        NSString TENDER_TYPE_GIFT { get; }

        // extern NSString *const TENDER_TYPE_LOYALTY;
        [Field("TENDER_TYPE_LOYALTY", "__Internal")]
        NSString TENDER_TYPE_LOYALTY { get; }

        // extern NSString *const TRANSACTION_TYPE_SALE;
        [Field("TRANSACTION_TYPE_SALE", "__Internal")]
        NSString TRANSACTION_TYPE_SALE { get; }

        // extern NSString *const TRANSACTION_TYPE_SALE_AUTH;
        [Field("TRANSACTION_TYPE_SALE_AUTH", "__Internal")]
        NSString TRANSACTION_TYPE_SALE_AUTH { get; }

        // extern NSString *const TRANSACTION_TYPE_CREDIT_AUTH;
        [Field("TRANSACTION_TYPE_CREDIT_AUTH", "__Internal")]
        NSString TRANSACTION_TYPE_CREDIT_AUTH { get; }

        // extern NSString *const TRANSACTION_TYPE_CAPTURE;
        [Field("TRANSACTION_TYPE_CAPTURE", "__Internal")]
        NSString TRANSACTION_TYPE_CAPTURE { get; }

        // extern NSString *const TRANSACTION_TYPE_VOID;
        [Field("TRANSACTION_TYPE_VOID", "__Internal")]
        NSString TRANSACTION_TYPE_VOID { get; }

        // extern NSString *const TRANSACTION_TYPE_REFUND;
        [Field("TRANSACTION_TYPE_REFUND", "__Internal")]
        NSString TRANSACTION_TYPE_REFUND { get; }

        // extern NSString *const TRANSACTION_TYPE_ACTIVATE;
        [Field("TRANSACTION_TYPE_ACTIVATE", "__Internal")]
        NSString TRANSACTION_TYPE_ACTIVATE { get; }

        // extern NSString *const TRANSACTION_TYPE_DEACTIVATE;
        [Field("TRANSACTION_TYPE_DEACTIVATE", "__Internal")]
        NSString TRANSACTION_TYPE_DEACTIVATE { get; }

        // extern NSString *const TRANSACTION_TYPE_RELOAD;
        [Field("TRANSACTION_TYPE_RELOAD", "__Internal")]
        NSString TRANSACTION_TYPE_RELOAD { get; }

        // extern NSString *const TRANSACTION_TYPE_BALANCE_CHECK;
        [Field("TRANSACTION_TYPE_BALANCE_CHECK", "__Internal")]
        NSString TRANSACTION_TYPE_BALANCE_CHECK { get; }

        // extern NSString *const TRANSACTION_TYPE_TOKEN_ADD;
        [Field("TRANSACTION_TYPE_TOKEN_ADD", "__Internal")]
        NSString TRANSACTION_TYPE_TOKEN_ADD { get; }

        // extern NSString *const TERMINAL_TYPE_INGENICO_BLUETOOTH;
        [Field("TERMINAL_TYPE_INGENICO_BLUETOOTH", "__Internal")]
        NSString TERMINAL_TYPE_INGENICO_BLUETOOTH { get; }

        // extern NSString *const TERMINAL_TYPE_INGENICO_IP;
        [Field("TERMINAL_TYPE_INGENICO_IP", "__Internal")]
        NSString TERMINAL_TYPE_INGENICO_IP { get; }

        // extern NSString *const TERMINAL_TYPE_MAGTEK_IDYNAMO;
        [Field("TERMINAL_TYPE_MAGTEK_IDYNAMO", "__Internal")]
        NSString TERMINAL_TYPE_MAGTEK_IDYNAMO { get; }

        // extern NSString *const TERMINAL_TYPE_MAGTEK_UDYNAMO;
        [Field("TERMINAL_TYPE_MAGTEK_UDYNAMO", "__Internal")]
        NSString TERMINAL_TYPE_MAGTEK_UDYNAMO { get; }

        // extern NSString *const TERMINAL_TYPE_IDTECH_UNIPAYIII;
        [Field("TERMINAL_TYPE_IDTECH_UNIPAYIII", "__Internal")]
        NSString TERMINAL_TYPE_IDTECH_UNIPAYIII { get; }

        // extern NSString *const TERMINAL_TYPE_IDTECH_SHUTTLE;
        [Field("TERMINAL_TYPE_IDTECH_SHUTTLE", "__Internal")]
        NSString TERMINAL_TYPE_IDTECH_SHUTTLE { get; }

        // extern NSString *const TERMINAL_TYPE_BBPOS_CHIPPER2;
        [Field("TERMINAL_TYPE_BBPOS_CHIPPER2", "__Internal")]
        NSString TERMINAL_TYPE_BBPOS_CHIPPER2 { get; }

        // extern NSString *const TERMINAL_TYPE_BBPOS_WISEPAD2;
        [Field("TERMINAL_TYPE_BBPOS_WISEPAD2", "__Internal")]
        NSString TERMINAL_TYPE_BBPOS_WISEPAD2 { get; }

        // extern NSString *const TERMINAL_TYPE_PAX_D180;
        [Field("TERMINAL_TYPE_PAX_D180", "__Internal")]
        NSString TERMINAL_TYPE_PAX_D180 { get; }

        // extern NSString *const PAYMENT_CREDIT_ACC_TYPE;
        [Field("PAYMENT_CREDIT_ACC_TYPE", "__Internal")]
        NSString PAYMENT_CREDIT_ACC_TYPE { get; }

        // extern NSString *const PAYMENT_DEBIT_ACC_TYPE;
        [Field("PAYMENT_DEBIT_ACC_TYPE", "__Internal")]
        NSString PAYMENT_DEBIT_ACC_TYPE { get; }

        // extern NSString *const PAYMENT_GIFT_ACC_TYPE;
        [Field("PAYMENT_GIFT_ACC_TYPE", "__Internal")]
        NSString PAYMENT_GIFT_ACC_TYPE { get; }

        // extern NSString *const PAYMENT_LOYALTY_ACC_TYPE;
        [Field("PAYMENT_LOYALTY_ACC_TYPE", "__Internal")]
        NSString PAYMENT_LOYALTY_ACC_TYPE { get; }

        // extern NSString *const ARPC_SUCCESS;
        [Field("ARPC_SUCCESS", "__Internal")]
        NSString ARPC_SUCCESS { get; }

        // extern NSString *const ARPC_DECLINE;
        [Field("ARPC_DECLINE", "__Internal")]
        NSString ARPC_DECLINE { get; }

        // extern NSString *const ERROR_ARSF;
        [Field("ERROR_ARSF", "__Internal")]
        NSString ERROR_ARSF { get; }

        // extern NSString *const ERROR_ARRT;
        [Field("ERROR_ARRT", "__Internal")]
        NSString ERROR_ARRT { get; }

        // extern NSString *const ERROR_CRSF;
        [Field("ERROR_CRSF", "__Internal")]
        NSString ERROR_CRSF { get; }

        // extern NSString *const ERROR_CAN;
        [Field("ERROR_CAN", "__Internal")]
        NSString ERROR_CAN { get; }

        // extern NSString *const ERROR_CDIV;
        [Field("ERROR_CDIV", "__Internal")]
        NSString ERROR_CDIV { get; }

        // extern NSString *const ERROR_CDIVN;
        [Field("ERROR_CDIVN", "__Internal")]
        NSString ERROR_CDIVN { get; }

        // extern NSString *const ERROR_CABLK;
        [Field("ERROR_CABLK", "__Internal")]
        NSString ERROR_CABLK { get; }

        // extern NSString *const ERROR_T2CF;
        [Field("ERROR_T2CF", "__Internal")]
        NSString ERROR_T2CF { get; }

        // extern NSString *const ERROR_FATAL;
        [Field("ERROR_FATAL", "__Internal")]
        NSString ERROR_FATAL { get; }

        // extern NSString *const ERROR_UITMO;
        [Field("ERROR_UITMO", "__Internal")]
        NSString ERROR_UITMO { get; }

        // extern NSString *const ERROR_CRPRE;
        [Field("ERROR_CRPRE", "__Internal")]
        NSString ERROR_CRPRE { get; }

        // extern NSString *const ERROR_CNSUP;
        [Field("ERROR_CNSUP", "__Internal")]
        NSString ERROR_CNSUP { get; }

        // extern NSString *const ERROR_TPSF;
        [Field("ERROR_TPSF", "__Internal")]
        NSString ERROR_TPSF { get; }

        // extern NSString *const MESSAGE_ARSF;
        [Field("MESSAGE_ARSF", "__Internal")]
        NSString MESSAGE_ARSF { get; }

        // extern NSString *const MESSAGE_ARRT;
        [Field("MESSAGE_ARRT", "__Internal")]
        NSString MESSAGE_ARRT { get; }

        // extern NSString *const MESSAGE_CRSF;
        [Field("MESSAGE_CRSF", "__Internal")]
        NSString MESSAGE_CRSF { get; }

        // extern NSString *const MESSAGE_CAN;
        [Field("MESSAGE_CAN", "__Internal")]
        NSString MESSAGE_CAN { get; }

        // extern NSString *const MESSAGE_CDIV;
        [Field("MESSAGE_CDIV", "__Internal")]
        NSString MESSAGE_CDIV { get; }

        // extern NSString *const MESSAGE_CDIVN;
        [Field("MESSAGE_CDIVN", "__Internal")]
        NSString MESSAGE_CDIVN { get; }

        // extern NSString *const MESSAGE_CABLK;
        [Field("MESSAGE_CABLK", "__Internal")]
        NSString MESSAGE_CABLK { get; }

        // extern NSString *const MESSAGE_T2CF;
        [Field("MESSAGE_T2CF", "__Internal")]
        NSString MESSAGE_T2CF { get; }

        // extern NSString *const MESSAGE_FATAL;
        [Field("MESSAGE_FATAL", "__Internal")]
        NSString MESSAGE_FATAL { get; }

        // extern NSString *const MESSAGE_UITMO;
        [Field("MESSAGE_UITMO", "__Internal")]
        NSString MESSAGE_UITMO { get; }

        // extern NSString *const MESSAGE_CRPRE;
        [Field("MESSAGE_CRPRE", "__Internal")]
        NSString MESSAGE_CRPRE { get; }

        // extern NSString *const MESSAGE_CNSUP;
        [Field("MESSAGE_CNSUP", "__Internal")]
        NSString MESSAGE_CNSUP { get; }

        // extern NSString *const MESSAGE_TPSF;
        [Field("MESSAGE_TPSF", "__Internal")]
        NSString MESSAGE_TPSF { get; }

        // extern NSString *const REQUEST_ONE_TIME_TOKEN;
        [Field("REQUEST_ONE_TIME_TOKEN", "__Internal")]
        NSString REQUEST_ONE_TIME_TOKEN { get; }

        // extern NSString *const REQUEST_MULTI_USE_TOKEN;
        [Field("REQUEST_MULTI_USE_TOKEN", "__Internal")]
        NSString REQUEST_MULTI_USE_TOKEN { get; }

        // extern NSString *const REQUESTMULTI_USE_TOKEN_SECURITY_CODE;
        [Field("REQUESTMULTI_USE_TOKEN_SECURITY_CODE", "__Internal")]
        NSString REQUESTMULTI_USE_TOKEN_SECURITY_CODE { get; }

        // extern NSString *const REQUEST_AUTHORIZATION;
        [Field("REQUEST_AUTHORIZATION", "__Internal")]
        NSString REQUEST_AUTHORIZATION { get; }

        // extern NSString *const REQUEST_BIN_LOOKUP;
        [Field("REQUEST_BIN_LOOKUP", "__Internal")]
        NSString REQUEST_BIN_LOOKUP { get; }

        // extern NSString *const REQUEST_CHECK_PASSWORD_EXPIRATION;
        [Field("REQUEST_CHECK_PASSWORD_EXPIRATION", "__Internal")]
        NSString REQUEST_CHECK_PASSWORD_EXPIRATION { get; }

        // extern NSString *const REQUEST_UPDATE_PASSWORD;
        [Field("REQUEST_UPDATE_PASSWORD", "__Internal")]
        NSString REQUEST_UPDATE_PASSWORD { get; }

        // extern NSString *const REQUEST_MERCHANT_INFO;
        [Field("REQUEST_MERCHANT_INFO", "__Internal")]
        NSString REQUEST_MERCHANT_INFO { get; }

        // extern NSString *const REQUEST_VOID_REFUND;
        [Field("REQUEST_VOID_REFUND", "__Internal")]
        NSString REQUEST_VOID_REFUND { get; }

        // extern NSString *const REQUEST_CAPTURE;
        [Field("REQUEST_CAPTURE", "__Internal")]
        NSString REQUEST_CAPTURE { get; }

        // extern NSString *const REQUEST_INITIATE_SETTLEMENT;
        [Field("REQUEST_INITIATE_SETTLEMENT", "__Internal")]
        NSString REQUEST_INITIATE_SETTLEMENT { get; }

        // extern NSString *const TRANSACTION_INDUSTRY_TYPE_RETAIL;
        [Field("TRANSACTION_INDUSTRY_TYPE_RETAIL", "__Internal")]
        NSString TRANSACTION_INDUSTRY_TYPE_RETAIL { get; }

        // extern NSString *const TRANSACTION_INDUSTRY_TYPE_RESTAURANT;
        [Field("TRANSACTION_INDUSTRY_TYPE_RESTAURANT", "__Internal")]
        NSString TRANSACTION_INDUSTRY_TYPE_RESTAURANT { get; }

        // extern NSString *const TRANSACTION_INDUSTRY_TYPE_ECOMMERCE;
        [Field("TRANSACTION_INDUSTRY_TYPE_ECOMMERCE", "__Internal")]
        NSString TRANSACTION_INDUSTRY_TYPE_ECOMMERCE { get; }

        // extern NSString *const TRANSACTION_INDUSTRY_TYPE_DIRECT_MARKETING;
        [Field("TRANSACTION_INDUSTRY_TYPE_DIRECT_MARKETING", "__Internal")]
        NSString TRANSACTION_INDUSTRY_TYPE_DIRECT_MARKETING { get; }

        // extern NSString *const TRANSACTION_CATEGORY_CODE_BILL_PAYMENT;
        [Field("TRANSACTION_CATEGORY_CODE_BILL_PAYMENT", "__Internal")]
        NSString TRANSACTION_CATEGORY_CODE_BILL_PAYMENT { get; }

        // extern NSString *const TRANSACTION_CATEGORY_CODE_RECURRING;
        [Field("TRANSACTION_CATEGORY_CODE_RECURRING", "__Internal")]
        NSString TRANSACTION_CATEGORY_CODE_RECURRING { get; }

        // extern NSString *const TRANSACTION_CATEGORY_CODE_INSTALLMENT;
        [Field("TRANSACTION_CATEGORY_CODE_INSTALLMENT", "__Internal")]
        NSString TRANSACTION_CATEGORY_CODE_INSTALLMENT { get; }

        // extern NSString *const TRANSACTION_CATEGORY_CODE_HEALTHCARE;
        [Field("TRANSACTION_CATEGORY_CODE_HEALTHCARE", "__Internal")]
        NSString TRANSACTION_CATEGORY_CODE_HEALTHCARE { get; }

        // extern NSString *const ORIG_TECH_SRC;
        [Field("ORIG_TECH_SRC", "__Internal")]
        NSString ORIG_TECH_SRC { get; }

        // extern NSString *const HOLDER_TYPE_PERSONAL_ACCOUNT;
        [Field("HOLDER_TYPE_PERSONAL_ACCOUNT", "__Internal")]
        NSString HOLDER_TYPE_PERSONAL_ACCOUNT { get; }

        //extern NSString* const HOLDER_TYPE_ORGANIZATION_ACCOUNT;
        [Field("HOLDER_TYPE_ORGANIZATION_ACCOUNT", "__Internal")]
        NSString HOLDER_TYPE_ORGANIZATION_ACCOUNT { get; }
    }
}
