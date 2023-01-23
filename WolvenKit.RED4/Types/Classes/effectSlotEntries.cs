using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class effectSlotEntries : effectIPlacementEntries
	{
		[Ordinal(0)] 
		[RED("inheritRotation")] 
		public CBool InheritRotation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("slots")] 
		public CArray<effectSlotEntry> Slots
		{
			get => GetPropertyValue<CArray<effectSlotEntry>>();
			set => SetPropertyValue<CArray<effectSlotEntry>>(value);
		}

		public effectSlotEntries()
		{
			InheritRotation = true;
			Slots = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
