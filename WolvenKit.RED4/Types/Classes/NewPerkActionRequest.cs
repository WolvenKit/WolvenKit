using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewPerkActionRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("perkType")] 
		public CEnum<gamedataNewPerkType> PerkType
		{
			get => GetPropertyValue<CEnum<gamedataNewPerkType>>();
			set => SetPropertyValue<CEnum<gamedataNewPerkType>>(value);
		}

		public NewPerkActionRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
