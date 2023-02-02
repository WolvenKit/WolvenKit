using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestListDistanceData : IScriptable
	{
		[Ordinal(0)] 
		[RED("objective")] 
		public CWeakHandle<gameJournalQuestObjective> Objective
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuestObjective>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuestObjective>>(value);
		}

		[Ordinal(1)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public QuestListDistanceData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
