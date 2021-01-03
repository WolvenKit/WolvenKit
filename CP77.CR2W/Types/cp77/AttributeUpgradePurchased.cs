using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AttributeUpgradePurchased : redEvent
	{
		[Ordinal(0)]  [RED("attributeData")] public CHandle<AttributeData> AttributeData { get; set; }
		[Ordinal(1)]  [RED("attributeType")] public CEnum<PerkMenuAttribute> AttributeType { get; set; }

		public AttributeUpgradePurchased(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
