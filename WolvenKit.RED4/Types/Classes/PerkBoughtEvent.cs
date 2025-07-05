using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PerkBoughtEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("perkType")] 
		public CEnum<gamedataPerkType> PerkType
		{
			get => GetPropertyValue<CEnum<gamedataPerkType>>();
			set => SetPropertyValue<CEnum<gamedataPerkType>>(value);
		}

		public PerkBoughtEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
