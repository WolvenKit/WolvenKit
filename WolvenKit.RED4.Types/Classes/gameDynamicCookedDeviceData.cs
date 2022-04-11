using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDynamicCookedDeviceData : gameCookedDeviceData
	{
		[Ordinal(4)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
