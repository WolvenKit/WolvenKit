using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameMuppetLookState : CVariable
	{
		[Ordinal(0)] [RED("lookDir")] public EulerAngles LookDir { get; set; }

		public gameMuppetLookState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
