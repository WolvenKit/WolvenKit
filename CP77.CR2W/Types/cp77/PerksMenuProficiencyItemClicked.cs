using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PerksMenuProficiencyItemClicked : PerksMenuAttributeItemClicked
	{
		[Ordinal(0)]  [RED("widget")] public wCHandle<inkWidget> Widget { get; set; }
		[Ordinal(1)]  [RED("attributeType")] public CEnum<PerkMenuAttribute> AttributeType { get; set; }
		[Ordinal(2)]  [RED("attributeData")] public CHandle<AttributeData> AttributeData { get; set; }
		[Ordinal(3)]  [RED("index")] public CInt32 Index { get; set; }

		public PerksMenuProficiencyItemClicked(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
