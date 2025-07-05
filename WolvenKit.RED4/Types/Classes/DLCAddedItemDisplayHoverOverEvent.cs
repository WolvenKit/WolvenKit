using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DLCAddedItemDisplayHoverOverEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("itemTDBID")] 
		public TweakDBID ItemTDBID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public DLCAddedItemDisplayHoverOverEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
