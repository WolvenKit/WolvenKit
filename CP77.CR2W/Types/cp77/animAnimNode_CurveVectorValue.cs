using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_CurveVectorValue : animAnimNode_VectorValue
	{
		[Ordinal(0)]  [RED("argument")] public animFloatLink Argument { get; set; }
		[Ordinal(1)]  [RED("curveData")] public curveData<Vector4> CurveData { get; set; }

		public animAnimNode_CurveVectorValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
