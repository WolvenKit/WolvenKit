using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BuyAttribute : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] [RED("attributeType")] public CEnum<gamedataStatType> AttributeType { get; set; }
		[Ordinal(2)] [RED("grantAttributePoint")] public CBool GrantAttributePoint { get; set; }

		public BuyAttribute(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
