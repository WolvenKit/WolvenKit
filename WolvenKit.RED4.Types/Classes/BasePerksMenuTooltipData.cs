using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BasePerksMenuTooltipData : ATooltipData
	{
		[Ordinal(0)] 
		[RED("manager")] 
		public CHandle<PlayerDevelopmentDataManager> Manager
		{
			get => GetPropertyValue<CHandle<PlayerDevelopmentDataManager>>();
			set => SetPropertyValue<CHandle<PlayerDevelopmentDataManager>>(value);
		}
	}
}
