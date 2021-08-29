using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuestObjectiveWrapper : ABaseQuestObjectiveWrapper
	{
		private CArray<CHandle<QuestSubObjectiveWrapper>> _questSubObjectives;

		[Ordinal(6)] 
		[RED("questSubObjectives")] 
		public CArray<CHandle<QuestSubObjectiveWrapper>> QuestSubObjectives
		{
			get => GetProperty(ref _questSubObjectives);
			set => SetProperty(ref _questSubObjectives, value);
		}
	}
}
