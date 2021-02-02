using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimSetupEntry : CVariable
	{
		[Ordinal(0)]  [RED("animSet")] public raRef<animAnimSet> AnimSet { get; set; }
		[Ordinal(1)]  [RED("variableNames")] public CArray<CName> VariableNames { get; set; }
		[Ordinal(2)]  [RED("priority")] public CUInt8 Priority { get; set; }

		public animAnimSetupEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
