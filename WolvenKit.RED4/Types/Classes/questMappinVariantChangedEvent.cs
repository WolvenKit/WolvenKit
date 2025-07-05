using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questMappinVariantChangedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("entry")] 
		public CWeakHandle<gameJournalEntry> Entry
		{
			get => GetPropertyValue<CWeakHandle<gameJournalEntry>>();
			set => SetPropertyValue<CWeakHandle<gameJournalEntry>>(value);
		}

		[Ordinal(1)] 
		[RED("phase")] 
		public CEnum<gamedataMappinPhase> Phase
		{
			get => GetPropertyValue<CEnum<gamedataMappinPhase>>();
			set => SetPropertyValue<CEnum<gamedataMappinPhase>>(value);
		}

		[Ordinal(2)] 
		[RED("variant")] 
		public CEnum<gamedataMappinVariant> Variant
		{
			get => GetPropertyValue<CEnum<gamedataMappinVariant>>();
			set => SetPropertyValue<CEnum<gamedataMappinVariant>>(value);
		}

		public questMappinVariantChangedEvent()
		{
			Phase = Enums.gamedataMappinPhase.DefaultPhase;
			Variant = Enums.gamedataMappinVariant.DefaultVariant;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
