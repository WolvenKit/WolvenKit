using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AttributeTooltipData : BasePerksMenuTooltipData
	{
		[Ordinal(1)] 
		[RED("attributeId")] 
		public TweakDBID AttributeId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("attributeType")] 
		public CEnum<PerkMenuAttribute> AttributeType
		{
			get => GetPropertyValue<CEnum<PerkMenuAttribute>>();
			set => SetPropertyValue<CEnum<PerkMenuAttribute>>(value);
		}

		[Ordinal(3)] 
		[RED("attributeData")] 
		public CHandle<AttributeData> AttributeData
		{
			get => GetPropertyValue<CHandle<AttributeData>>();
			set => SetPropertyValue<CHandle<AttributeData>>(value);
		}

		[Ordinal(4)] 
		[RED("displayData")] 
		public CHandle<AttributeDisplayData> DisplayData
		{
			get => GetPropertyValue<CHandle<AttributeDisplayData>>();
			set => SetPropertyValue<CHandle<AttributeDisplayData>>(value);
		}

		public AttributeTooltipData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
