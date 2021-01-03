using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerParameters_HealPlayer : questICharacterManagerParameters_NodeSubType
	{
		[Ordinal(0)]  [RED("heal")] public CBool Heal { get; set; }
		[Ordinal(1)]  [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(2)]  [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
		[Ordinal(3)]  [RED("removeBuffs")] public CBool RemoveBuffs { get; set; }
		[Ordinal(4)]  [RED("removeDebuffs")] public CBool RemoveDebuffs { get; set; }
		[Ordinal(5)]  [RED("removeStatusEffects")] public CBool RemoveStatusEffects { get; set; }
		[Ordinal(6)]  [RED("resetCyberdeckRAM")] public CBool ResetCyberdeckRAM { get; set; }

		public questCharacterManagerParameters_HealPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
