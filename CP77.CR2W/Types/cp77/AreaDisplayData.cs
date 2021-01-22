using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AreaDisplayData : IDisplayData
	{
		[Ordinal(0)]  [RED("area")] public CEnum<gamedataPerkArea> Area { get; set; }
		[Ordinal(1)]  [RED("attributeId")] public TweakDBID AttributeId { get; set; }
		[Ordinal(2)]  [RED("locked")] public CBool Locked { get; set; }
		[Ordinal(3)]  [RED("perks")] public CArray<CHandle<PerkDisplayData>> Perks { get; set; }
		[Ordinal(4)]  [RED("proficency")] public CEnum<gamedataProficiencyType> Proficency { get; set; }

		public AreaDisplayData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
