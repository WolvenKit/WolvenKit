using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_CurveVectorValue : animAnimNode_VectorValue
	{
		[Ordinal(1)] [RED("curveData")] public curveData<Vector4> CurveData { get; set; }
		[Ordinal(2)] [RED("argument")] public animFloatLink Argument { get; set; }

		public animAnimNode_CurveVectorValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
