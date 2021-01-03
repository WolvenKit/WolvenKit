using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_CoordinateFromVector : animAnimNode_FloatValue
	{
		[Ordinal(0)]  [RED("input")] public animVectorLink Input { get; set; }
		[Ordinal(1)]  [RED("vectorCoodrinateType")] public CEnum<animVectorCoordinateType> VectorCoodrinateType { get; set; }

		public animAnimNode_CoordinateFromVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
