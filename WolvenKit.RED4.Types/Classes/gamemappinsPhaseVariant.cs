using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamemappinsPhaseVariant : gamemappinsIPointOfInterestVariant
	{
		private TweakDBID _mappinType;
		private CEnum<gamedataMappinPhase> _phase;
		private CEnum<gamedataMappinVariant> _variant;

		[Ordinal(0)] 
		[RED("mappinType")] 
		public TweakDBID MappinType
		{
			get => GetProperty(ref _mappinType);
			set => SetProperty(ref _mappinType, value);
		}

		[Ordinal(1)] 
		[RED("phase")] 
		public CEnum<gamedataMappinPhase> Phase
		{
			get => GetProperty(ref _phase);
			set => SetProperty(ref _phase, value);
		}

		[Ordinal(2)] 
		[RED("variant")] 
		public CEnum<gamedataMappinVariant> Variant
		{
			get => GetProperty(ref _variant);
			set => SetProperty(ref _variant, value);
		}

		public gamemappinsPhaseVariant()
		{
			_mappinType = new() { Value = 169957907894 };
			_phase = new() { Value = Enums.gamedataMappinPhase.DefaultPhase };
			_variant = new() { Value = Enums.gamedataMappinVariant.DefaultVariant };
		}
	}
}
