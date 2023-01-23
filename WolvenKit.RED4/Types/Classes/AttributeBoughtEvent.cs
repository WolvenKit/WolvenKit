using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AttributeBoughtEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("attributeType")] 
		public CEnum<gamedataStatType> AttributeType
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		public AttributeBoughtEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
