using System;
using System.Collections.Generic;
using System.Linq;
using Fusion.PayGuardian.iOS;
using Foundation;
using UIKit;

namespace BindingTestings.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.

    

            //if (nsO is NSDecimalNumber)
            //{
            //    return decimal.Parse(nsO.ToString(), CultureInfo.InvariantCulture);
            //}

            NSDecimalNumber valor1 = new NSDecimalNumber();

            NSDecimalNumber valor2 = new NSDecimalNumber();

            NSDecimalNumber valor3 = new NSDecimalNumber();
            //NSDecimalNumber valor = (NSDecimalNumber)3.6545;

            BPNPaymentRequest Request = new BPNPaymentRequest("323", "333", valor1, valor2, valor3, "dos", "3", "jose", "barrera", "merchant",
              "merchantacout", "codepay", "token", "10/10/20", "teminal", "industry", true, true);

            //BPNAddress
            UIApplication.Main(args, null, "AppDelegate");
        }

    }
}
