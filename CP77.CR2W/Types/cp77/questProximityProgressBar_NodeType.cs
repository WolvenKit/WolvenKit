using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questProximityProgressBar_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] [RED("show")] public CBool Show { get; set; }
		[Ordinal(1)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(2)] [RED("reset")] public CBool Reset { get; set; }
		[Ordinal(3)] [RED("distance")] public CFloat Distance { get; set; }
		[Ordinal(4)] [RED("distanceComparisonType")] public CEnum<EComparisonType> DistanceComparisonType { get; set; }
		[Ordinal(5)] [RED("target")] public gameEntityReference Target { get; set; }
		[Ordinal(6)] [RED("isPlayerActivator")] public CBool IsPlayerActivator { get; set; }
		[Ordinal(7)] [RED("activator")] public gameEntityReference Activator { get; set; }

		public questProximityProgressBar_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
