using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RarityOfEquippedConsumableItemPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("consumableItemTag")] 
		public CName ConsumableItemTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("qualityLessThan")] 
		public CEnum<gamedataQuality> QualityLessThan
		{
			get => GetPropertyValue<CEnum<gamedataQuality>>();
			set => SetPropertyValue<CEnum<gamedataQuality>>(value);
		}

		public RarityOfEquippedConsumableItemPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
