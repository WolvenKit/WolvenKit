using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RetryRefreshGridEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("viewMode")] 
		public CEnum<ItemViewModes> ViewMode
		{
			get => GetPropertyValue<CEnum<ItemViewModes>>();
			set => SetPropertyValue<CEnum<ItemViewModes>>(value);
		}

		[Ordinal(1)] 
		[RED("tryToPreserveFilter")] 
		public CBool TryToPreserveFilter
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public RetryRefreshGridEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
