using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UnlockPerkArea : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("perkArea")] 
		public CEnum<gamedataPerkArea> PerkArea
		{
			get => GetPropertyValue<CEnum<gamedataPerkArea>>();
			set => SetPropertyValue<CEnum<gamedataPerkArea>>(value);
		}

		public UnlockPerkArea()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
