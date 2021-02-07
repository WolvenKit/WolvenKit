using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerCombat_ModifyHealth : questICharacterManagerCombat_NodeSubType
	{
		[Ordinal(0)]  [RED("percent")] public CFloat Percent { get; set; }
		[Ordinal(1)]  [RED("setExactValue")] public CBool SetExactValue { get; set; }
		[Ordinal(2)]  [RED("noDamageIndicator")] public CBool NoDamageIndicator { get; set; }
		[Ordinal(3)]  [RED("damageSourceRef")] public gameEntityReference DamageSourceRef { get; set; }

		public questCharacterManagerCombat_ModifyHealth(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
