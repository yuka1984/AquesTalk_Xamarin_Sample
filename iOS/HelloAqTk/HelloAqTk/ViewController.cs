using System;
using Foundation;
using UIKit;

namespace HelloAqTk
{
	public partial class ViewController : UIViewController
	{
		void HandleAction(NSNotification obj)
		{
			InvokeOnMainThread(() => { 
				onPlayLabel.Text = "Done";
			});
		}

		partial void UIButtona4MElsUb_TouchUpInside(UIButton sender)
		{
			AquesTalk.AquesTalk.GetInstance.Stop();
		}

		partial void UIButtonNjzX3Y5C_TouchUpInside(UIButton sender)
		{
			var r = textfield.Text;
			var notice = NSNotification.FromName("AquesTalkDaDoneNotify", this, null);

			var ret = AquesTalk.AquesTalk.GetInstance.Play(r, 90, notice.Handle);

			if (ret != 0)
			{
				var alertController = UIAlertController.Create("Error", "音声記号列の指定が正しくありません", UIAlertControllerStyle.Alert);
				alertController.AddAction(UIAlertAction.Create("はい", UIAlertActionStyle.Default, (obj) => { }));
				PresentViewController(alertController, true, null);
				return;
			}

			onPlayLabel.Text = "Playing...";
		}

		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			NSNotificationCenter.DefaultCenter.AddObserver(new NSString("AquesTalkDaDoneNotify"), HandleAction, null);
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
