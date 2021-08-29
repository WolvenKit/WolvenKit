using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InteractiveAdControllerPS : ScriptableDeviceComponentPS
	{
		private CBool _showAd;
		private CBool _showVendor;
		private CBool _locationAdded;

		[Ordinal(104)] 
		[RED("showAd")] 
		public CBool ShowAd
		{
			get => GetProperty(ref _showAd);
			set => SetProperty(ref _showAd, value);
		}

		[Ordinal(105)] 
		[RED("showVendor")] 
		public CBool ShowVendor
		{
			get => GetProperty(ref _showVendor);
			set => SetProperty(ref _showVendor, value);
		}

		[Ordinal(106)] 
		[RED("locationAdded")] 
		public CBool LocationAdded
		{
			get => GetProperty(ref _locationAdded);
			set => SetProperty(ref _locationAdded, value);
		}
	}
}
