using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AttributeBoughtData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("attribute")] 
		public CEnum<gamedataStatType> Attribute
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CInt32 Value
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public AttributeBoughtData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
