using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questMappinVariantChangedEvent : redEvent
	{
		private CWeakHandle<gameJournalEntry> _entry;
		private CEnum<gamedataMappinPhase> _phase;
		private CEnum<gamedataMappinVariant> _variant;

		[Ordinal(0)] 
		[RED("entry")] 
		public CWeakHandle<gameJournalEntry> Entry
		{
			get => GetProperty(ref _entry);
			set => SetProperty(ref _entry, value);
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

		public questMappinVariantChangedEvent()
		{
			_phase = new() { Value = Enums.gamedataMappinPhase.DefaultPhase };
			_variant = new() { Value = Enums.gamedataMappinVariant.DefaultVariant };
		}
	}
}
