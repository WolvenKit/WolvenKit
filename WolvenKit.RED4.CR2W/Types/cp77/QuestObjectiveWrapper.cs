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
			get
			{
				if (_questSubObjectives == null)
				{
					_questSubObjectives = (CArray<CHandle<QuestSubObjectiveWrapper>>) CR2WTypeManager.Create("array:handle:QuestSubObjectiveWrapper", "questSubObjectives", cr2w, this);
				}
				return _questSubObjectives;
			}
			set
			{
				if (_questSubObjectives == value)
				{
					return;
				}
				_questSubObjectives = value;
				PropertySet(this);
			}
		}

		public QuestObjectiveWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
