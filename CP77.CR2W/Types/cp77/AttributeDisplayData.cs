using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AttributeDisplayData : IDisplayData
	{
		[Ordinal(0)] [RED("attributeId")] public TweakDBID AttributeId { get; set; }
		[Ordinal(1)] [RED("proficiencies")] public CArray<CHandle<ProficiencyDisplayData>> Proficiencies { get; set; }

		public AttributeDisplayData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
