using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DespawnUniqueSubCharacterRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("subCharacterID")] public TweakDBID SubCharacterID { get; set; }

		public DespawnUniqueSubCharacterRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
