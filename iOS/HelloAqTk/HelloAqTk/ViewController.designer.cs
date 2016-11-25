// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace HelloAqTk
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel onPlayLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField textfield { get; set; }

        [Action ("UIButtona4MElsUb_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButtona4MElsUb_TouchUpInside (UIKit.UIButton sender);

        [Action ("UIButtonNjzX3Y5C_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButtonNjzX3Y5C_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (onPlayLabel != null) {
                onPlayLabel.Dispose ();
                onPlayLabel = null;
            }

            if (textfield != null) {
                textfield.Dispose ();
                textfield = null;
            }
        }
    }
}