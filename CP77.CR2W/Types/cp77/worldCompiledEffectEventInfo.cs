using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldCompiledEffectEventInfo : CVariable
	{
		[Ordinal(0)] [RED("eventRUID")] public CRUID EventRUID { get; set; }
		[Ordinal(1)] [RED("placementIndexMask")] public CUInt64 PlacementIndexMask { get; set; }
		[Ordinal(2)] [RED("componentIndexMask")] public CUInt64 ComponentIndexMask { get; set; }
		[Ordinal(3)] [RED("flags")] public CUInt8 Flags { get; set; }

		public worldCompiledEffectEventInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
