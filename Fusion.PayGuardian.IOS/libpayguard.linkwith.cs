using System;
using ObjCRuntime;
[assembly: LinkWith("libpayguard.a",
    LinkTarget.ArmV7 | LinkTarget.Simulator | LinkTarget.Arm64 | LinkTarget.Simulator64 | LinkTarget.ArmV7s,
    ForceLoad = false, SmartLink = true,
    Frameworks = "CFNetwork CoreAudioKit CoreAudio AudioToolbox MediaPlayer MessageUI AVFoundation ExternalAccessory CoreTelephony CoreBluetooth UIKit Foundation CoreGraphics",
    LinkerFlags = "-lstdc++ -lxml2")]
