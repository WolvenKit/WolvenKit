using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_CoordinateFromVector : animAnimNode_FloatValue
	{
		[Ordinal(1)] [RED("vectorCoodrinateType")] public CEnum<animVectorCoordinateType> VectorCoodrinateType { get; set; }
		[Ordinal(2)] [RED("input")] public animVectorLink Input { get; set; }

		public animAnimNode_CoordinateFromVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
