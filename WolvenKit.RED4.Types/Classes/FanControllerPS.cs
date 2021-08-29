using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FanControllerPS : BasicDistractionDeviceControllerPS
	{
		private FanSetup _fanSetup;

		[Ordinal(109)] 
		[RED("fanSetup")] 
		public FanSetup FanSetup
		{
			get => GetProperty(ref _fanSetup);
			set => SetProperty(ref _fanSetup, value);
		}
	}
}
