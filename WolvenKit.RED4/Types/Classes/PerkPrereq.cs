using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PerkPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("perk")] 
		public CEnum<gamedataPerkType> Perk
		{
			get => GetPropertyValue<CEnum<gamedataPerkType>>();
			set => SetPropertyValue<CEnum<gamedataPerkType>>(value);
		}

		public PerkPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
