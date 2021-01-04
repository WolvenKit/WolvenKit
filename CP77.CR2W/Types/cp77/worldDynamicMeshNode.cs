using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldDynamicMeshNode : worldMeshNode
	{
		[Ordinal(0)]  [RED("dynamicTrafficSetting")] public TrafficGenDynamicTrafficSetting DynamicTrafficSetting { get; set; }
		[Ordinal(1)]  [RED("initialGuess")] public CBool InitialGuess { get; set; }
		[Ordinal(2)]  [RED("isDebris")] public CBool IsDebris { get; set; }
		[Ordinal(3)]  [RED("navigationSetting")] public NavGenNavigationSetting NavigationSetting { get; set; }
		[Ordinal(4)]  [RED("startAsleep")] public CBool StartAsleep { get; set; }
		[Ordinal(5)]  [RED("useMeshNavmeshSettings")] public CBool UseMeshNavmeshSettings { get; set; }

		public worldDynamicMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
