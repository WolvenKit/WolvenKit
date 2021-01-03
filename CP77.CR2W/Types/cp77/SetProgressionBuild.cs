using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SetProgressionBuild : gamePlayerScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("buildType")] public CEnum<gamedataBuildType> BuildType { get; set; }

		public SetProgressionBuild(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
