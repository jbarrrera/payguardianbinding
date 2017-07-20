using System;
using ObjCRuntime;

namespace Fusion.PayGuardian.iOS
{

    public enum BridgeCommResponseCode
    {
        Success = 0,
        Cancel = 1,
        Error = 2,
        DeniedByCustomersBank = 30032
    }

    public enum PayGuardianTransactionState
    {
        NotStarted,
        WaitingForCard,
        ReadingCard,
        ChipCardWithUnreadChipSwiped,
        CardReadWithBrokenChip,
        CardReadWithError,
        WaitingForGateway,
        RespondingToCard,
        Voiding,
        Finished
    }

    public enum CardReadErrorCode
    {
        MSRBadRead,
        ChipBadRead,
        MSRCancelled,
        MSRButtonPressed,
        MSRInvalidPrompt,
        EncryptionFailed,
        UnableToOpenDevice,
        PINEntryCancelled,
        PINEntryInvalidLength,
        PINEntryInvalidIndex,
        PINKeyPressed,
        PINInvalidPrompt,
        PINRequestDeclined
    }
}
