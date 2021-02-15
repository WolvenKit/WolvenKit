using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamePlayerClimbInfo : IScriptable
	{
		[Ordinal(0)] [RED("descResult")] public CHandle<worldgeometryDescriptionResult> DescResult { get; set; }
		[Ordinal(1)] [RED("obstacleEnd")] public Vector4 ObstacleEnd { get; set; }
		[Ordinal(2)] [RED("climbValid")] public CBool ClimbValid { get; set; }
		[Ordinal(3)] [RED("vaultValid")] public CBool VaultValid { get; set; }

		public gamePlayerClimbInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
