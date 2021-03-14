using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AttributeTooltipData : BasePerksMenuTooltipData
	{
		[Ordinal(1)] [RED("attributeId")] public TweakDBID AttributeId { get; set; }
		[Ordinal(2)] [RED("attributeType")] public CEnum<PerkMenuAttribute> AttributeType { get; set; }
		[Ordinal(3)] [RED("attributeData")] public CHandle<AttributeData> AttributeData { get; set; }
		[Ordinal(4)] [RED("displayData")] public CHandle<AttributeDisplayData> DisplayData { get; set; }

		public AttributeTooltipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
