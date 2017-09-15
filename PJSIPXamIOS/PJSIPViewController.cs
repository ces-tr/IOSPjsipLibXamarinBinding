using System;
using IOSPjsipXamarinBinding;
using UIKit;

namespace PJSIPXamIOS
{
	public partial class PJSIPViewController : UIViewController
	{
		protected PJSIPViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic		
		}


		public PJSIPViewController() : base("PJSIPViewController", null)
		{
			
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			InitializeControls();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		void InitializeControls()
		{
			MakeCallBtn.TouchUpInside += (sender, e) => { 
				var b = IOSPjsipWrapper.IOSPjsipWrapperInstance();
				b.MakeCall();
			};
		}
	}
}

