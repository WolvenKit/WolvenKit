using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PerksMenuAttributeItemHoldStart : redEvent
	{
		[Ordinal(0)]  [RED("widget")] public wCHandle<inkWidget> Widget { get; set; }
		[Ordinal(1)]  [RED("attributeType")] public CEnum<PerkMenuAttribute> AttributeType { get; set; }
		[Ordinal(2)]  [RED("attributeData")] public CHandle<AttributeData> AttributeData { get; set; }
		[Ordinal(3)]  [RED("actionName")] public CHandle<inkActionName> ActionName { get; set; }

		public PerksMenuAttributeItemHoldStart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
