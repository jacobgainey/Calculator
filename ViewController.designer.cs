// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Calculator
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton number { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel operation { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel screen { get; set; }

        [Action ("Button_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Button_TouchUpInside (UIKit.UIButton sender);

        [Action ("Number_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Number_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (button != null) {
                button.Dispose ();
                button = null;
            }

            if (number != null) {
                number.Dispose ();
                number = null;
            }

            if (operation != null) {
                operation.Dispose ();
                operation = null;
            }

            if (screen != null) {
                screen.Dispose ();
                screen = null;
            }
        }
    }
}