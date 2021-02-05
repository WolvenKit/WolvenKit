using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TraitTooltipData : BasePerksMenuTooltipData
	{
		[Ordinal(1)]  [RED("traitType")] public CEnum<gamedataTraitType> TraitType { get; set; }
		[Ordinal(2)]  [RED("attributeId")] public TweakDBID AttributeId { get; set; }
		[Ordinal(3)]  [RED("proficiency")] public CEnum<gamedataProficiencyType> Proficiency { get; set; }
		[Ordinal(4)]  [RED("traitData")] public CHandle<TraitDisplayData> TraitData { get; set; }
		[Ordinal(5)]  [RED("attributeData")] public CHandle<AttributeData> AttributeData { get; set; }

		public TraitTooltipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
