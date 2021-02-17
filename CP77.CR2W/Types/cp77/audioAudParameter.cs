using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioAudParameter : CVariable
	{
		[Ordinal(0)] [RED("name")] public CName Name { get; set; }
		[Ordinal(1)] [RED("value")] public CFloat Value { get; set; }
		[Ordinal(2)] [RED("enterCurveType")] public CEnum<audioESoundCurveType> EnterCurveType { get; set; }
		[Ordinal(3)] [RED("enterCurveTime")] public CFloat EnterCurveTime { get; set; }
		[Ordinal(4)] [RED("exitCurveType")] public CEnum<audioESoundCurveType> ExitCurveType { get; set; }
		[Ordinal(5)] [RED("exitCurveTime")] public CFloat ExitCurveTime { get; set; }

		public audioAudParameter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
