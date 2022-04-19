using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DispenseFreeSpecificItem : redEvent
	{
		[Ordinal(0)] 
		[RED("item")] 
		public TweakDBID Item
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public DispenseFreeSpecificItem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
