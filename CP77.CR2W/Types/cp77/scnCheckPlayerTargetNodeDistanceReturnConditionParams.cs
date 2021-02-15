using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnCheckPlayerTargetNodeDistanceReturnConditionParams : CVariable
	{
		[Ordinal(0)] [RED("distance")] public CFloat Distance { get; set; }
		[Ordinal(1)] [RED("comparisonType")] public CEnum<EComparisonType> ComparisonType { get; set; }
		[Ordinal(2)] [RED("targetNode")] public NodeRef TargetNode { get; set; }

		public scnCheckPlayerTargetNodeDistanceReturnConditionParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
