using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerCombat_ModifyHealth : questICharacterManagerCombat_NodeSubType
	{
		[Ordinal(0)] [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
		[Ordinal(1)] [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(2)] [RED("percent")] public CFloat Percent { get; set; }
		[Ordinal(3)] [RED("setExactValue")] public CBool SetExactValue { get; set; }
		[Ordinal(4)] [RED("noDamageIndicator")] public CBool NoDamageIndicator { get; set; }
		[Ordinal(5)] [RED("damageSourceRef")] public gameEntityReference DamageSourceRef { get; set; }

		public questCharacterManagerCombat_ModifyHealth(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
