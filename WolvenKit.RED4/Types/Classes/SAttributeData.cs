using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SAttributeData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gamedataAttributeDataType> Type
		{
			get => GetPropertyValue<CEnum<gamedataAttributeDataType>>();
			set => SetPropertyValue<CEnum<gamedataAttributeDataType>>(value);
		}

		[Ordinal(1)] 
		[RED("unlockedPerks")] 
		public CArray<SNewPerk> UnlockedPerks
		{
			get => GetPropertyValue<CArray<SNewPerk>>();
			set => SetPropertyValue<CArray<SNewPerk>>(value);
		}

		public SAttributeData()
		{
			UnlockedPerks = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
