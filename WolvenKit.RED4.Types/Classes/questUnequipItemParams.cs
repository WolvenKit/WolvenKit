using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questUnequipItemParams : RedBaseClass
	{
		private TweakDBID _slotId;
		private CFloat _unequipDurationOverride;

		[Ordinal(0)] 
		[RED("slotId")] 
		public TweakDBID SlotId
		{
			get => GetProperty(ref _slotId);
			set => SetProperty(ref _slotId, value);
		}

		[Ordinal(1)] 
		[RED("unequipDurationOverride")] 
		public CFloat UnequipDurationOverride
		{
			get => GetProperty(ref _unequipDurationOverride);
			set => SetProperty(ref _unequipDurationOverride, value);
		}
	}
}
