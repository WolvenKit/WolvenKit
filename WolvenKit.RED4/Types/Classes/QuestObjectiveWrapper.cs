using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestObjectiveWrapper : ABaseQuestObjectiveWrapper
	{
		[Ordinal(6)] 
		[RED("questSubObjectives")] 
		public CArray<CHandle<QuestSubObjectiveWrapper>> QuestSubObjectives
		{
			get => GetPropertyValue<CArray<CHandle<QuestSubObjectiveWrapper>>>();
			set => SetPropertyValue<CArray<CHandle<QuestSubObjectiveWrapper>>>(value);
		}

		public QuestObjectiveWrapper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
