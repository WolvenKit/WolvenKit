using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PerksMenuAttributeItemHoverOut : redEvent
	{
		[Ordinal(0)] 
		[RED("widget")] 
		public CWeakHandle<inkWidget> Widget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(1)] 
		[RED("attributeType")] 
		public CEnum<PerkMenuAttribute> AttributeType
		{
			get => GetPropertyValue<CEnum<PerkMenuAttribute>>();
			set => SetPropertyValue<CEnum<PerkMenuAttribute>>(value);
		}

		[Ordinal(2)] 
		[RED("attributeData")] 
		public CHandle<AttributeData> AttributeData
		{
			get => GetPropertyValue<CHandle<AttributeData>>();
			set => SetPropertyValue<CHandle<AttributeData>>(value);
		}

		public PerksMenuAttributeItemHoverOut()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
