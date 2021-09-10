using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PuppetDeviceLinkPS : DeviceLinkComponentPS
	{
		[Ordinal(25)] 
		[RED("securitySystemData")] 
		public SecuritySystemData SecuritySystemData
		{
			get => GetPropertyValue<SecuritySystemData>();
			set => SetPropertyValue<SecuritySystemData>(value);
		}

		public PuppetDeviceLinkPS()
		{
			SecuritySystemData = new();
		}
	}
}
