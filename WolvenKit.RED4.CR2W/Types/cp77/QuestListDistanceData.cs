using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestListDistanceData : IScriptable
	{
		private wCHandle<gameJournalQuestObjective> _objective;
		private CFloat _distance;

		[Ordinal(0)] 
		[RED("objective")] 
		public wCHandle<gameJournalQuestObjective> Objective
		{
			get
			{
				if (_objective == null)
				{
					_objective = (wCHandle<gameJournalQuestObjective>) CR2WTypeManager.Create("whandle:gameJournalQuestObjective", "objective", cr2w, this);
				}
				return _objective;
			}
			set
			{
				if (_objective == value)
				{
					return;
				}
				_objective = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get
			{
				if (_distance == null)
				{
					_distance = (CFloat) CR2WTypeManager.Create("Float", "distance", cr2w, this);
				}
				return _distance;
			}
			set
			{
				if (_distance == value)
				{
					return;
				}
				_distance = value;
				PropertySet(this);
			}
		}

		public QuestListDistanceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
