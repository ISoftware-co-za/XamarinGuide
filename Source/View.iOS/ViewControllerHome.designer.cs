// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace ISoftware.Xamarin.Platforms.View.iOS
{
    [Register ("ViewControllerHome")]
    partial class ViewControllerHome
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView Items { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView Message { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Items != null) {
                Items.Dispose ();
                Items = null;
            }

            if (Message != null) {
                Message.Dispose ();
                Message = null;
            }
        }
    }
}