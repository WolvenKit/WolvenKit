using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animOverrideAnimSetRef : CVariable
	{
		[Ordinal(0)] [RED("animSet")] public raRef<animAnimSet> AnimSet { get; set; }
		[Ordinal(1)] [RED("variableName")] public CName VariableName { get; set; }

		public animOverrideAnimSetRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
