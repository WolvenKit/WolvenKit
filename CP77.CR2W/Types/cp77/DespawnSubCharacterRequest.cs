using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DespawnSubCharacterRequest : DespawnUniqueSubCharacterRequest
	{
		[Ordinal(0)]  [RED("subCharacterID")] public TweakDBID SubCharacterID { get; set; }

		public DespawnSubCharacterRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
