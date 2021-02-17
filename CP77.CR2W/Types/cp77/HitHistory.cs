using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HitHistory : IScriptable
	{
		[Ordinal(0)] [RED("hitHistory")] public CArray<HitHistoryItem> HitHistory_ { get; set; }
		[Ordinal(1)] [RED("maxEntries")] public CInt32 MaxEntries { get; set; }

		public HitHistory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
