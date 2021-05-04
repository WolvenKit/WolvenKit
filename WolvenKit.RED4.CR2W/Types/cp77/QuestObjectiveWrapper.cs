using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestObjectiveWrapper : ABaseQuestObjectiveWrapper
	{
		private CArray<CHandle<QuestSubObjectiveWrapper>> _questSubObjectives;

		[Ordinal(6)] 
		[RED("questSubObjectives")] 
		public CArray<CHandle<QuestSubObjectiveWrapper>> QuestSubObjectives
		{
			get => GetProperty(ref _questSubObjectives);
			set => SetProperty(ref _questSubObjectives, value);
		}

		public QuestObjectiveWrapper(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
