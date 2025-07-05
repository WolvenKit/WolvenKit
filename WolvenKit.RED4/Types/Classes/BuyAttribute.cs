using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BuyAttribute : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("attributeType")] 
		public CEnum<gamedataStatType> AttributeType
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		[Ordinal(2)] 
		[RED("grantAttributePoint")] 
		public CBool GrantAttributePoint
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public BuyAttribute()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
