using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsHighLevelStateDataEvent : redEvent
	{
		[Ordinal(0)] [RED("currentHighLevelState")] public CEnum<gamedataNPCHighLevelState> CurrentHighLevelState { get; set; }
		[Ordinal(1)] [RED("currentNPCEntityID")] public entEntityID CurrentNPCEntityID { get; set; }

		public gameeventsHighLevelStateDataEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
