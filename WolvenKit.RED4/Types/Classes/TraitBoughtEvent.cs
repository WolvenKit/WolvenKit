using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TraitBoughtEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("traitType")] 
		public CEnum<gamedataTraitType> TraitType
		{
			get => GetPropertyValue<CEnum<gamedataTraitType>>();
			set => SetPropertyValue<CEnum<gamedataTraitType>>(value);
		}

		public TraitBoughtEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
