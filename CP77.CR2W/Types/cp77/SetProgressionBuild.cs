using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SetProgressionBuild : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] [RED("buildType")] public CEnum<gamedataBuildType> BuildType { get; set; }

		public SetProgressionBuild(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
