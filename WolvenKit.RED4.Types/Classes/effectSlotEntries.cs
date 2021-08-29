using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class effectSlotEntries : effectIPlacementEntries
	{
		private CBool _inheritRotation;
		private CArray<effectSlotEntry> _slots;

		[Ordinal(0)] 
		[RED("inheritRotation")] 
		public CBool InheritRotation
		{
			get => GetProperty(ref _inheritRotation);
			set => SetProperty(ref _inheritRotation, value);
		}

		[Ordinal(1)] 
		[RED("slots")] 
		public CArray<effectSlotEntry> Slots
		{
			get => GetProperty(ref _slots);
			set => SetProperty(ref _slots, value);
		}
	}
}
