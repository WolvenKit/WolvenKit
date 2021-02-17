using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questdbgCallstackData : CVariable
	{
		[Ordinal(0)] [RED("resourceHash")] public CUInt64 ResourceHash { get; set; }
		[Ordinal(1)] [RED("phases")] public CArray<questdbgCallstackPhase> Phases { get; set; }
		[Ordinal(2)] [RED("blocks")] public CArray<questdbgCallstackBlock> Blocks { get; set; }
		[Ordinal(3)] [RED("executed")] public CArray<CUInt64> Executed { get; set; }
		[Ordinal(4)] [RED("failed")] public CArray<CUInt64> Failed { get; set; }
		[Ordinal(5)] [RED("callstackRevision")] public CUInt32 CallstackRevision { get; set; }

		public questdbgCallstackData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
