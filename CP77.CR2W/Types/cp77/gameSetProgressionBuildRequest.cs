using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameSetProgressionBuildRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] [RED("buildID")] public TweakDBID BuildID { get; set; }

		public gameSetProgressionBuildRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
