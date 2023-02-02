using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCharacterManagerCombat_SetWeaponState : questICharacterManagerCombat_NodeSubType
	{
		[Ordinal(0)] 
		[RED("areaType")] 
		public CEnum<gameCityAreaType> AreaType
		{
			get => GetPropertyValue<CEnum<gameCityAreaType>>();
			set => SetPropertyValue<CEnum<gameCityAreaType>>(value);
		}

		public questCharacterManagerCombat_SetWeaponState()
		{
			AreaType = Enums.gameCityAreaType.PublicZone;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
