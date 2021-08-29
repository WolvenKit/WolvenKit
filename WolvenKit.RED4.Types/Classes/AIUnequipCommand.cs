using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIUnequipCommand : AICommand
	{
		private TweakDBID _slotId;
		private CFloat _durationOverride;

		[Ordinal(4)] 
		[RED("slotId")] 
		public TweakDBID SlotId
		{
			get => GetProperty(ref _slotId);
			set => SetProperty(ref _slotId, value);
		}

		[Ordinal(5)] 
		[RED("durationOverride")] 
		public CFloat DurationOverride
		{
			get => GetProperty(ref _durationOverride);
			set => SetProperty(ref _durationOverride, value);
		}
	}
}
