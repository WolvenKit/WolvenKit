using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InteractiveAdControllerPS : ScriptableDeviceComponentPS
	{
		private CBool _showAd;
		private CBool _showVendor;
		private CBool _locationAdded;

		[Ordinal(103)] 
		[RED("showAd")] 
		public CBool ShowAd
		{
			get => GetProperty(ref _showAd);
			set => SetProperty(ref _showAd, value);
		}

		[Ordinal(104)] 
		[RED("showVendor")] 
		public CBool ShowVendor
		{
			get => GetProperty(ref _showVendor);
			set => SetProperty(ref _showVendor, value);
		}

		[Ordinal(105)] 
		[RED("locationAdded")] 
		public CBool LocationAdded
		{
			get => GetProperty(ref _locationAdded);
			set => SetProperty(ref _locationAdded, value);
		}

		public InteractiveAdControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
