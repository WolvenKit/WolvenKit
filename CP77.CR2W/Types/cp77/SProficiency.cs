using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SProficiency : CVariable
	{
		[Ordinal(0)]  [RED("currentExp")] public CInt32 CurrentExp { get; set; }
		[Ordinal(1)]  [RED("currentLevel")] public CInt32 CurrentLevel { get; set; }
		[Ordinal(2)]  [RED("expToLevel")] public CInt32 ExpToLevel { get; set; }
		[Ordinal(3)]  [RED("isAtMaxLevel")] public CBool IsAtMaxLevel { get; set; }
		[Ordinal(4)]  [RED("maxLevel")] public CInt32 MaxLevel { get; set; }
		[Ordinal(5)]  [RED("spentPerkPoints")] public CInt32 SpentPerkPoints { get; set; }
		[Ordinal(6)]  [RED("type")] public CEnum<gamedataProficiencyType> Type { get; set; }

		public SProficiency(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
