using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BuyAttribute : gamePlayerScriptableSystemRequest
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
	}
}
