using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AttributeUpgradePurchased : redEvent
	{
		[Ordinal(0)] 
		[RED("attributeType")] 
		public CEnum<PerkMenuAttribute> AttributeType
		{
			get => GetPropertyValue<CEnum<PerkMenuAttribute>>();
			set => SetPropertyValue<CEnum<PerkMenuAttribute>>(value);
		}

		[Ordinal(1)] 
		[RED("attributeData")] 
		public CHandle<AttributeData> AttributeData
		{
			get => GetPropertyValue<CHandle<AttributeData>>();
			set => SetPropertyValue<CHandle<AttributeData>>(value);
		}

		public AttributeUpgradePurchased()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
