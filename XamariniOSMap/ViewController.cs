using System;

using UIKit;

using Google.Maps;
using CoreGraphics;

namespace XamariniOSMap
{
	public partial class ViewController : UIViewController
	{
		MapView mapView;
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();


			var camera = CameraPosition.FromCamera(latitude: 37.79,
											longitude: -122.40,
											zoom: 6);
			mapView = MapView.FromCamera(CGRect.Empty, camera);
			mapView.MyLocationEnabled = true;
			View = mapView;
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
