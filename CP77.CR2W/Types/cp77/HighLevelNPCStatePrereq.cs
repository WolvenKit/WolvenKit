using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HighLevelNPCStatePrereq : NPCStatePrereq
	{
		[Ordinal(3)] [RED("valueToListen")] public CEnum<gamedataNPCHighLevelState> ValueToListen { get; set; }

		public HighLevelNPCStatePrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
