using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetProgressionBuild : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] [RED("buildType")] public CEnum<gamedataBuildType> BuildType { get; set; }

		public SetProgressionBuild(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
