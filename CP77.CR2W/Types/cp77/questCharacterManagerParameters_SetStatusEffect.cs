using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerParameters_SetStatusEffect : questICharacterManagerParameters_NodeSubType
	{
		[Ordinal(0)]  [RED("statusEffectID")] public TweakDBID StatusEffectID { get; set; }
		[Ordinal(1)]  [RED("isPlayerStatusEffectSource")] public CBool IsPlayerStatusEffectSource { get; set; }
		[Ordinal(2)]  [RED("statusEffectSourceObject")] public gameEntityReference StatusEffectSourceObject { get; set; }
		[Ordinal(3)]  [RED("recordSelector")] public CHandle<questRecordSelector> RecordSelector { get; set; }
		[Ordinal(4)]  [RED("set")] public CBool Set { get; set; }

		public questCharacterManagerParameters_SetStatusEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
