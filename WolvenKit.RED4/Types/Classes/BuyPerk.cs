using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BuyPerk : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("perkType")] 
		public CEnum<gamedataPerkType> PerkType
		{
			get => GetPropertyValue<CEnum<gamedataPerkType>>();
			set => SetPropertyValue<CEnum<gamedataPerkType>>(value);
		}

		public BuyPerk()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
