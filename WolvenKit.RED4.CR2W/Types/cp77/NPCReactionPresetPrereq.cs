using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCReactionPresetPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] [RED("reactionPreset")] public CEnum<gamedataReactionPresetType> ReactionPreset { get; set; }
		[Ordinal(1)] [RED("invert")] public CBool Invert { get; set; }

		public NPCReactionPresetPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
