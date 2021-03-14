using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCrowdTemplateCharacterData : CVariable
	{
		[Ordinal(0)] [RED("characterRecordId")] public TweakDBID CharacterRecordId { get; set; }
		[Ordinal(1)] [RED("weight")] public CFloat Weight { get; set; }

		public gameCrowdTemplateCharacterData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
