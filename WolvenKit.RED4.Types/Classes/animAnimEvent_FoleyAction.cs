using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimEvent_FoleyAction : animAnimEvent
	{
		[Ordinal(3)] 
		[RED("actionName")] 
		public CName ActionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
