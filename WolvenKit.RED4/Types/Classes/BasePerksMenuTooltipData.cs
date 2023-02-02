using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BasePerksMenuTooltipData : ATooltipData
	{
		[Ordinal(0)] 
		[RED("manager")] 
		public CHandle<PlayerDevelopmentDataManager> Manager
		{
			get => GetPropertyValue<CHandle<PlayerDevelopmentDataManager>>();
			set => SetPropertyValue<CHandle<PlayerDevelopmentDataManager>>(value);
		}

		public BasePerksMenuTooltipData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
