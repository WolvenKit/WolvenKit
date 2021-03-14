using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsHighLevelStateDataEvent : redEvent
	{
		private CEnum<gamedataNPCHighLevelState> _currentHighLevelState;
		private entEntityID _currentNPCEntityID;

		[Ordinal(0)] 
		[RED("currentHighLevelState")] 
		public CEnum<gamedataNPCHighLevelState> CurrentHighLevelState
		{
			get
			{
				if (_currentHighLevelState == null)
				{
					_currentHighLevelState = (CEnum<gamedataNPCHighLevelState>) CR2WTypeManager.Create("gamedataNPCHighLevelState", "currentHighLevelState", cr2w, this);
				}
				return _currentHighLevelState;
			}
			set
			{
				if (_currentHighLevelState == value)
				{
					return;
				}
				_currentHighLevelState = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("currentNPCEntityID")] 
		public entEntityID CurrentNPCEntityID
		{
			get
			{
				if (_currentNPCEntityID == null)
				{
					_currentNPCEntityID = (entEntityID) CR2WTypeManager.Create("entEntityID", "currentNPCEntityID", cr2w, this);
				}
				return _currentNPCEntityID;
			}
			set
			{
				if (_currentNPCEntityID == value)
				{
					return;
				}
				_currentNPCEntityID = value;
				PropertySet(this);
			}
		}

		public gameeventsHighLevelStateDataEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
