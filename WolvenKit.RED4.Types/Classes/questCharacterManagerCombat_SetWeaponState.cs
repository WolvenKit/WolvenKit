using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCharacterManagerCombat_SetWeaponState : questICharacterManagerCombat_NodeSubType
	{
		private CEnum<gameCityAreaType> _areaType;

		[Ordinal(0)] 
		[RED("areaType")] 
		public CEnum<gameCityAreaType> AreaType
		{
			get => GetProperty(ref _areaType);
			set => SetProperty(ref _areaType, value);
		}

		public questCharacterManagerCombat_SetWeaponState()
		{
			_areaType = new() { Value = Enums.gameCityAreaType.PublicZone };
		}
	}
}
