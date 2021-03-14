using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerksMenuAttributeItemHoverOver : redEvent
	{
		[Ordinal(0)] [RED("widget")] public wCHandle<inkWidget> Widget { get; set; }
		[Ordinal(1)] [RED("attributeType")] public CEnum<PerkMenuAttribute> AttributeType { get; set; }
		[Ordinal(2)] [RED("attributeData")] public CHandle<AttributeData> AttributeData { get; set; }

		public PerksMenuAttributeItemHoverOver(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
