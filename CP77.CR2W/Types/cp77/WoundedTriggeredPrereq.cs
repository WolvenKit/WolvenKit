using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WoundedTriggeredPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] [RED("currValue")] public CUInt32 CurrValue { get; set; }

		public WoundedTriggeredPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
