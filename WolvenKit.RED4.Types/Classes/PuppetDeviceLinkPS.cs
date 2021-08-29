using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PuppetDeviceLinkPS : DeviceLinkComponentPS
	{
		private SecuritySystemData _securitySystemData;

		[Ordinal(25)] 
		[RED("securitySystemData")] 
		public SecuritySystemData SecuritySystemData
		{
			get => GetProperty(ref _securitySystemData);
			set => SetProperty(ref _securitySystemData, value);
		}
	}
}
