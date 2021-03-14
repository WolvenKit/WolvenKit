using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetGameplayObjectiveStateRequest : gameScriptableSystemRequest
	{
		private CHandle<GemplayObjectiveData> _objectiveData;
		private CEnum<gameJournalEntryState> _objectiveState;

		[Ordinal(0)] 
		[RED("objectiveData")] 
		public CHandle<GemplayObjectiveData> ObjectiveData
		{
			get
			{
				if (_objectiveData == null)
				{
					_objectiveData = (CHandle<GemplayObjectiveData>) CR2WTypeManager.Create("handle:GemplayObjectiveData", "objectiveData", cr2w, this);
				}
				return _objectiveData;
			}
			set
			{
				if (_objectiveData == value)
				{
					return;
				}
				_objectiveData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("objectiveState")] 
		public CEnum<gameJournalEntryState> ObjectiveState
		{
			get
			{
				if (_objectiveState == null)
				{
					_objectiveState = (CEnum<gameJournalEntryState>) CR2WTypeManager.Create("gameJournalEntryState", "objectiveState", cr2w, this);
				}
				return _objectiveState;
			}
			set
			{
				if (_objectiveState == value)
				{
					return;
				}
				_objectiveState = value;
				PropertySet(this);
			}
		}

		public SetGameplayObjectiveStateRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
