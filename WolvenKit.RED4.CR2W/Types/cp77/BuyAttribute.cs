using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BuyAttribute : gamePlayerScriptableSystemRequest
	{
		private CEnum<gamedataStatType> _attributeType;
		private CBool _grantAttributePoint;

		[Ordinal(1)] 
		[RED("attributeType")] 
		public CEnum<gamedataStatType> AttributeType
		{
			get => GetProperty(ref _attributeType);
			set => SetProperty(ref _attributeType, value);
		}

		[Ordinal(2)] 
		[RED("grantAttributePoint")] 
		public CBool GrantAttributePoint
		{
			get => GetProperty(ref _grantAttributePoint);
			set => SetProperty(ref _grantAttributePoint, value);
		}

		public BuyAttribute(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
