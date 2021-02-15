using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldDynamicMeshNode : worldMeshNode
	{
		[Ordinal(13)] [RED("startAsleep")] public CBool StartAsleep { get; set; }
		[Ordinal(14)] [RED("isDebris")] public CBool IsDebris { get; set; }
		[Ordinal(15)] [RED("initialGuess")] public CBool InitialGuess { get; set; }
		[Ordinal(16)] [RED("dynamicTrafficSetting")] public TrafficGenDynamicTrafficSetting DynamicTrafficSetting { get; set; }
		[Ordinal(17)] [RED("navigationSetting")] public NavGenNavigationSetting NavigationSetting { get; set; }
		[Ordinal(18)] [RED("useMeshNavmeshSettings")] public CBool UseMeshNavmeshSettings { get; set; }

		public worldDynamicMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
