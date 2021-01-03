using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questLevelUpData : CVariable
	{
		[Ordinal(0)]  [RED("attributePoints")] public CInt32 AttributePoints { get; set; }
		[Ordinal(1)]  [RED("disableAction")] public CBool DisableAction { get; set; }
		[Ordinal(2)]  [RED("lvl")] public CInt32 Lvl { get; set; }
		[Ordinal(3)]  [RED("perkPoints")] public CInt32 PerkPoints { get; set; }
		[Ordinal(4)]  [RED("type")] public CEnum<gamedataProficiencyType> Type { get; set; }

		public questLevelUpData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
