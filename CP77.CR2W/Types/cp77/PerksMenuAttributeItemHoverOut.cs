using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PerksMenuAttributeItemHoverOut : redEvent
	{
		[Ordinal(0)] [RED("widget")] public wCHandle<inkWidget> Widget { get; set; }
		[Ordinal(1)] [RED("attributeType")] public CEnum<PerkMenuAttribute> AttributeType { get; set; }
		[Ordinal(2)] [RED("attributeData")] public CHandle<AttributeData> AttributeData { get; set; }

		public PerksMenuAttributeItemHoverOut(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
