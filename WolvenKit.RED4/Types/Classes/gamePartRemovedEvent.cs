using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamePartRemovedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(1)] 
		[RED("removedPartID")] 
		public gameItemID RemovedPartID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		public gamePartRemovedEvent()
		{
			ItemID = new();
			RemovedPartID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
