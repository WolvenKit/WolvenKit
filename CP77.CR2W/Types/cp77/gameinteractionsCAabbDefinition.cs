using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsCAabbDefinition : gameinteractionsIShapeDefinition
	{
		[Ordinal(0)] [RED("min")] public Vector4 Min { get; set; }
		[Ordinal(1)] [RED("max")] public Vector4 Max { get; set; }

		public gameinteractionsCAabbDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
