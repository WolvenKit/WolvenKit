using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ClearItemAppearanceEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		public ClearItemAppearanceEvent()
		{
			ItemID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
