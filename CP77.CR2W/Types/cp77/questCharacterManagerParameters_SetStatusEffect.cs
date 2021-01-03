using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerParameters_SetStatusEffect : questICharacterManagerParameters_NodeSubType
	{
		[Ordinal(0)]  [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(1)]  [RED("isPlayerStatusEffectSource")] public CBool IsPlayerStatusEffectSource { get; set; }
		[Ordinal(2)]  [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
		[Ordinal(3)]  [RED("recordSelector")] public CHandle<questRecordSelector> RecordSelector { get; set; }
		[Ordinal(4)]  [RED("set")] public CBool Set { get; set; }
		[Ordinal(5)]  [RED("statusEffectID")] public TweakDBID StatusEffectID { get; set; }
		[Ordinal(6)]  [RED("statusEffectSourceObject")] public gameEntityReference StatusEffectSourceObject { get; set; }

		public questCharacterManagerParameters_SetStatusEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
