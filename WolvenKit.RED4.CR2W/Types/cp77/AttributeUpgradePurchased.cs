using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AttributeUpgradePurchased : redEvent
	{
		[Ordinal(0)] [RED("attributeType")] public CEnum<PerkMenuAttribute> AttributeType { get; set; }
		[Ordinal(1)] [RED("attributeData")] public CHandle<AttributeData> AttributeData { get; set; }

		public AttributeUpgradePurchased(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
