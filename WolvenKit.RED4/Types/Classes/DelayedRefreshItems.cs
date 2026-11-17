using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DelayedRefreshItems : redEvent
	{
		[Ordinal(0)] 
		[RED("keepCurrentFilter")] 
		public CBool KeepCurrentFilter
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DelayedRefreshItems()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
