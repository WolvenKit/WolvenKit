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
			get => GetProperty(ref _currentHighLevelState);
			set => SetProperty(ref _currentHighLevelState, value);
		}

		[Ordinal(1)] 
		[RED("currentNPCEntityID")] 
		public entEntityID CurrentNPCEntityID
		{
			get => GetProperty(ref _currentNPCEntityID);
			set => SetProperty(ref _currentNPCEntityID, value);
		}

		public gameeventsHighLevelStateDataEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
