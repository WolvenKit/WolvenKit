using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SpawnUniqueSubCharacterRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("subCharacterID")] public TweakDBID SubCharacterID { get; set; }
		[Ordinal(1)] [RED("desiredDistance")] public CFloat DesiredDistance { get; set; }

		public SpawnUniqueSubCharacterRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
