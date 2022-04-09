using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalMetaQuestObjective : gameJournalEntry
	{
		[Ordinal(1)] 
		[RED("description")] 
		public LocalizationString Description
		{
			get => GetPropertyValue<LocalizationString>();
			set => SetPropertyValue<LocalizationString>(value);
		}

		[Ordinal(2)] 
		[RED("progressPercent")] 
		public CUInt32 ProgressPercent
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("iconID")] 
		public TweakDBID IconID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gameJournalMetaQuestObjective()
		{
			Description = new() { Unk1 = 0, Value = "" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
