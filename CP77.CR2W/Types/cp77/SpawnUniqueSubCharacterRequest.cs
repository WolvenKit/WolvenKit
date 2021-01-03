using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SpawnUniqueSubCharacterRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("desiredDistance")] public CFloat DesiredDistance { get; set; }
		[Ordinal(1)]  [RED("subCharacterID")] public TweakDBID SubCharacterID { get; set; }

		public SpawnUniqueSubCharacterRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
