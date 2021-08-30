using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleRadioTierEvent : redEvent
	{
		private CUInt32 _radioTier;
		private CBool _overrideTier;

		[Ordinal(0)] 
		[RED("radioTier")] 
		public CUInt32 RadioTier
		{
			get => GetProperty(ref _radioTier);
			set => SetProperty(ref _radioTier, value);
		}

		[Ordinal(1)] 
		[RED("overrideTier")] 
		public CBool OverrideTier
		{
			get => GetProperty(ref _overrideTier);
			set => SetProperty(ref _overrideTier, value);
		}

		public VehicleRadioTierEvent()
		{
			_radioTier = 1;
		}
	}
}
